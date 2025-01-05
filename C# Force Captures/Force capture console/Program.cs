using dnc.daq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Diagnostics;



namespace Force_capture_console
{
    class Program
    {

        public const short deviceNo = 0;   // The device number. Starts at 0, there's 1 device...
        //private static System.Timers.Timer timer;
        private const int TargetFrameTimeMs = 100;

        private static string filePath = "output.txt";
        private static DateTime startTime = DateTime.Now;
        private static dnc.daq.DncDaq dncDaq; // Make sure to initialize this properly



        public static string FormatFloatArray(float[] array, string separator = " ")
        {
            return $"[{string.Join(separator, array)}]";
        }


        public static float getchannelVoltage(short channel)
        {
            float channelVoltage;
            int ret = dncDaq.AiInputChannel(deviceNo, channel, out channelVoltage);

            if (ret != 0)
            {
                // If there's an error, retrieve and display the error string
                string errorString;
                int retError = dncDaq.DaqErrorString(deviceNo, ret, out errorString);
                if (retError != 0)
                {
                    errorString = "Unknown error";
                }
                Console.WriteLine($"Error reading channel: {ret} - {errorString}");

            }

            return channelVoltage;

        }
        public static float[] getForceVoltages()
        {

            float[] forcesAndTorques = new float[6];
            short deviceNo = 0;   // Replace with your device number
            short channelMultiple = 12;    // The channels you want to read from

            float[] first12Channels = new float[12];
            int ret = dncDaq.AiInputMultiChannel(deviceNo, channelMultiple, first12Channels);

            if ( ret != 0 )
            {
                // If there's an error, retrieve and display the error string
                string errorString;
                int retError = dncDaq.DaqErrorString(deviceNo, ret, out errorString);
                if (retError != 0)
                {
                    errorString = "Unknown error";
                }
                Console.WriteLine($"Error reading channel: {ret} - {errorString}");

            }

            for ( int i = 0; i<6; i++)
            {
                forcesAndTorques[i] = first12Channels[i + 6];

            }

            return forcesAndTorques;

        }

        public static void showForceVoltages(float[] forcesAndTorques)
        {
            
            String[] channelName = { "x", "y", "z", "tx", "ty", "tz" };


            //for (int i = 0; i < 6; i++)
            //{
            //    int r = i % 3;
            //    int torques = (i >= 3) ? 1 : 0;

            //    Console.WriteLine($"{i}, {torques}, {r}");
            //}

            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Voltages: {FormatFloatArray(forcesAndTorques, ", ")}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{channelName[i]}: {forcesAndTorques[i]}V   |  {channelName[i+3]}: {forcesAndTorques[i+3]}V  ");
            }
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\n");

        }




        public static async Task WriteToFileAsync()
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Stopwatch stopwatch = new Stopwatch();
                while (true)
                {
                    stopwatch.Restart();

                    // Get the force voltages
                    float[] forceAndTorques = getForceVoltages();

                    // Convert the float array to a string
                    string dataString = FormatFloatArray(forceAndTorques, " ");

                    // Calculate the relative time
                    TimeSpan elapsedTime = DateTime.Now - startTime;
                    string timestamp = elapsedTime.TotalSeconds.ToString();

                    // Prepare the output line
                    string outputLine = $"{timestamp} {dataString} Contec-Force-Torque[x,y,z,tx,ty,tz]";

                    // Write the line to the file
                    await writer.WriteLineAsync(outputLine);

                    // Print the line to the console
                    Console.WriteLine(outputLine);



                    // Wait for the remaining time to complete the target frame time
                    stopwatch.Stop();
                    int elapsedMs = (int)stopwatch.ElapsedMilliseconds;
                    int delayMs = TargetFrameTimeMs - elapsedMs;

                    // Ensure we don't delay for a negative value
                    if (delayMs > 0)
                    {
                        await Task.Delay(delayMs);
                    }
                }
            }
        }






        public class MockContainer : IContainer
        {
            // Internal collection to store components
            private readonly List<IComponent> components = new List<IComponent>();

            // Implement the Components property with the correct return type
            public ComponentCollection Components
            {
                get
                {
                    // Return a ComponentCollection containing the list of components
                    return new ComponentCollection(components.ToArray());
                }
            }

            public void Dispose()
            {
                // Dispose of all components
                foreach (var component in components)
                {
                    component.Dispose();
                }
                components.Clear();
            }

            public void Add(IComponent component)
            {
                components.Add(component);
            }

            public void Remove(IComponent component)
            {
                components.Remove(component);
            }

            public void Add(IComponent component, string name)
            {
                components.Add(component);
                // Optionally handle the name if needed
            }
        }


        static async Task Main(string[] args)
        {
            Console.WriteLine("\nStart of Program\n");
            // Create an instance of the mock container
            IContainer container = new MockContainer();

            // Initialize the DAQ object
            dncDaq = new dnc.daq.DncDaq(container);
            Console.WriteLine("Before property");
            dncDaq.ShowProperty(); // Must be there, just click ok

            if (dncDaq.DaqProperty.Device.Count <= 0)
            {
                Console.WriteLine("0 Device connected!");
            }



            // Define device number and channel
            short channel = 6;
            float channelVoltage;
            int ret = dncDaq.AiInputChannel(deviceNo, channel, out channelVoltage);



            if (ret == 0)
            {
                // Display the result
                //Console.WriteLine("There was no error!");
                Console.WriteLine($"Channel {channel}: {channelVoltage}");
            }
            else
            {
                // If there's an error, retrieve and display the error string
                string errorString;
                int retError = dncDaq.DaqErrorString(deviceNo, ret, out errorString);
                if (retError != 0)
                {
                    errorString = "Unknown error";
                }
                Console.WriteLine($"Error reading channel: {ret} - {errorString}");
          
            }

            //short channelMultiple = 12;    // The channel you want to read from
            //float[] aiDataMultiple = new float[channelMultiple];
            //int retMulti = dncDaq.AiInputMultiChannel(deviceNo, channelMultiple, aiDataMultiple);
            //Console.WriteLine($"Channels {channelMultiple}: {FormatFloatArray(aiDataMultiple, ", ")}");

            //Stopwatch stopwatch = new Stopwatch();
            //startTime = DateTime.Now;
            //while (true)
            //{
            //    stopwatch.Restart();
            //    float[] forceAndTorques = getForceVoltages();
            //    showForceVoltages(forceAndTorques);

            //   stopwatch.Stop();
            //    int elapsedMs = (int)stopwatch.ElapsedMilliseconds;
            //    int delayMs = TargetFrameTimeMs - elapsedMs;
            //    Console.WriteLine(elapsedMs);

            //}

            // Record start time
            startTime = DateTime.Now;

            // Start the asynchronous file writing task
            Task fileWritingTask = WriteToFileAsync();

            // Keep the main thread alive
            await fileWritingTask;




            Console.WriteLine("\nEnd of Program\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}


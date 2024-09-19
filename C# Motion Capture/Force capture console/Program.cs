using dnc.daq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Force_capture_console
{
    class Program
    {

        public static string FormatFloatArray(float[] array, string separator = " ")
        {
            return $"[{string.Join(separator, array)}]";
        }

        public static float[] getForces(dnc.daq.DncDaq dncDaq)
        {

            float[] forces = new float[6];
            short deviceNo = 0;   // Replace with your device number
            short channelMultiple = 12;    // The channels you want to read from

            float[] first12Channels = new float[12];
            int retMulti = dncDaq.AiInputMultiChannel(deviceNo, channelMultiple, first12Channels);

            for ( int i = 0; i<6; i++)
            {
                forces[i] = first12Channels[i + 6];

            }

            return forces;

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


        static void Main(string[] args)
        {
            Console.WriteLine("\nStart of Program\n");
            // Create an instance of the mock container
            IContainer container = new MockContainer();



            //Console.WriteLine("\nBefore creating the dnc Daq\n");
            // Initialize the DAQ object
            dnc.daq.DncDaq dncDaq = new dnc.daq.DncDaq(container);
            //Console.WriteLine("\nAfter creating the dnc Daq\n");

            dncDaq.ShowProperty(); // Must be there, just click ok
            if (dncDaq.DaqProperty.Device.Count <= 0)
            {
                Console.WriteLine("0 Device connected!");
            }



            // Define device number and channel
            short deviceNo = 0;   // Replace with your device number
            short channel = 6;    // The channel you want to read from
            float channelVoltage;
            int ret = dncDaq.AiInputChannel(deviceNo, channel, out channelVoltage);


            short channelMultiple = 12;    // The channel you want to read from
            float[] aiDataMultiple = new float[channelMultiple];
            int retMulti = dncDaq.AiInputMultiChannel(deviceNo, channelMultiple, aiDataMultiple);



            if (ret == 0)
            {
                // Display the result
                Console.WriteLine("There was no error!");
                Console.WriteLine($"Channel {channel}: {channelVoltage}");
                Console.WriteLine($"Channels {channelMultiple}: {FormatFloatArray(aiDataMultiple, ", ")}");
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

            Console.WriteLine("\nEnd of Program\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}


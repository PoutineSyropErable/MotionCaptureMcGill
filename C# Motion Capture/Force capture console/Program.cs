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



            Console.WriteLine("\nBefore creating the dnc Daq\n");
            // Initialize the DAQ object
            dnc.daq.DncDaq dncDaq = new dnc.daq.DncDaq(container);
            Console.WriteLine("\nAfter creating the dnc Daq\n");



            // Define device number and channel
            short deviceNo = 0;   // Replace with your device number
            short channel = 6;    // The channel you want to read from

            // Read from the input channel
            float aiData;

            Console.WriteLine("\nBefore the single channel try\n");
            int ret = dncDaq.AiInputChannel(deviceNo, channel, out aiData);
            Console.WriteLine("\nAfter the single input try\n");


            Console.WriteLine("\nBefore the multi input try\n");
            short channelMultiple = 12;    // The channel you want to read from
            float[] aiDataMultiple = new float[channelMultiple];
            int retMulti = dncDaq.AiInputMultiChannel(deviceNo, channelMultiple, aiDataMultiple);
            Console.WriteLine("\nAfter the multi input try\n");

            Console.WriteLine($"Error reading single channel: {ret}");
            Console.WriteLine($"Error reading Multi channel: {ret}");


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
            else
            {
                // Display the result
                Console.WriteLine("There was no error!");
                Console.WriteLine($"Channel {channel}: {aiData}");
                Console.WriteLine($"Channels {channelMultiple}: {aiDataMultiple}");
            }

            Console.WriteLine("\nEnd of Program\n");
        }
    }
}


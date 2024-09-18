using System;
using Dnc;  // Adjust this if the namespace is different in your DLL

namespace SimpleInputConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the DAQ object
            DncDaq dncDaq = new DncDaq();

            // Initialize the DAQ device
            int retInit = dncDaq.Initialize();
            if (retInit != 0)
            {
                Console.WriteLine("Error initializing DAQ device: " + retInit);
                return;
            }

            // Define device number and channel
            short deviceNo = 0;   // Replace with your device number
            short channel = 6;    // The channel you want to read from

            // Read from the input channel
            float aiData;
            int ret = dncDaq.AiInputChannel(deviceNo, channel, out aiData);

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
                Console.WriteLine($"Channel {channel}: {aiData}");
            }

            // Cleanup
            dncDaq.Close();
        }
    }
}


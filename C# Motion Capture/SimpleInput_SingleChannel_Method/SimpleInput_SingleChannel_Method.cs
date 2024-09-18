using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInput_SingleChannel_Method
{
    public partial class SimpleInput_SingleChannel_Method : Form
    {
        public SimpleInput_SingleChannel_Method()
        {
            InitializeComponent();
        }

        //================================================================================
        // DncDaq Setting button click event
        //================================================================================
        private void button_DaqProperty_Click(object sender, EventArgs e)
        {
            //----------------------------------------
            // Displays DncDaq settings screen
            //----------------------------------------
            dncDaq1.ShowProperty();
        }

        //================================================================================
        // Exit button click event
        //================================================================================
        private void button_Exit_Click(object sender, EventArgs e)
        {
            //----------------------------------------
            // Exit the dialog
            //----------------------------------------
            this.Close();
        }

        //================================================================================
        // DncDaqInit event
        //================================================================================
        private void dncDaq1_OnInit(object sender, EventArgs e)
        {
            //----------------------------------------
            // Clear Error Details
            //----------------------------------------
            textBox_ErrorDetail.Text = "";
            //----------------------------------------
            // Check if device settings exist in DncDaq
            //----------------------------------------
            if (dncDaq1.DaqProperty.Device.Count <= 0)
            {
                textBox_ErrorDetail.Text = "There is no device setting.";
                return;
            }
            //----------------------------------------
            // Check if input task settings exist in DncDaq
            //----------------------------------------
            if (dncDaq1.DaqProperty.InputTask.Count <= 0)
            {
                textBox_ErrorDetail.Text = "There is no input task setting.";
                return;
            }
        }

        //================================================================================
        // DncDaq error event
        //================================================================================
        private void dncDaq1_OnError(object sender, short DeviceNo, dnc.common.DncErrorEventArgs e)
        {
            int ret;             // Variable for getting return value
            string error_string;    // Error string

            //----------------------------------------
            // Get the error string from the error No. in the event argument
            //----------------------------------------
            ret = dncDaq1.DaqErrorString(DeviceNo, e.Error, out error_string);
            //----------------------------------------
            // When failed to get the error string, initialize the error string
            //----------------------------------------
            if (ret != 0)
            {
                error_string = "";
            }
            //----------------------------------------
            // Displays the obtained error string and the status information in the event argument on the label
            // Check if Invoke is required because the error event may be executed in another thread,
            // and if necessary, access the form control with Invoke.
            //----------------------------------------
            if (InvokeRequired == true)
            {
                //----------------------------------------
                // Displays error parameters in the text box
                // The method called by Invoke is described by the lambda expression [=>]
                //----------------------------------------
                Invoke(new Action(() => textBox_ErrorDetail.Text = "Device No.: " + DeviceNo.ToString() + "\r\n" +
                                                                    "Error type: " + e.ErrorType.ToString() + "\r\n" +
                                                                    "Error code(value): " + e.Error.ToString() + "\r\n" +
                                                                    "Error code(character string): " + error_string + "\r\n" +
                                                                    "Error parameter: " + e.Param.ToString()
                                                                    ));
            }
            else
            {
                //----------------------------------------
                // Displays error parameters in the text box
                //----------------------------------------
                textBox_ErrorDetail.Text = "Device No.: " + DeviceNo.ToString() + "\r\n" +
                                            "Error type: " + e.ErrorType.ToString() + "\r\n" +
                                            "Error code(value): " + e.Error.ToString() + "\r\n" +
                                            "Error code(character string): " + error_string + "\r\n" +
                                            "Error parameter: " + e.Param.ToString();
            }
        }

        //================================================================================
        // AiInputChannel button click event
        //================================================================================
        private void button_InputChannel_Click(object sender, EventArgs e)
        {
            int ret1;            // Variable for getting return value
            int ret2;            // Variable for getting return value 2
            float aidata;          // Variables for storing analog data
            short device_no;       // Device No. storage variable
            short channel;         // Variable for storing channel data
            string error_string;    // Error string

            //------------------------------------
            // Get the device number and conversion channel from the text box
            //------------------------------------
            try
            {
                device_no = short.Parse(textBox_DeviceNo.Text);
                channel = short.Parse(textBox_ChannelNo.Text);
            }
            catch (Exception ex)
            {
                textBox_ErrorDetail.Text = ex.Message;
                return;
            }
            //------------------------------------
            // Executing the AiInputChannel method
            //------------------------------------
            ret1 = dncDaq1.AiInputChannel(device_no, channel, out aidata);
            //------------------------------------
            // Error process
            //------------------------------------
            if (ret1 != 0)
            {
                //------------------------------------
                // If the ErrorString method fails, the error content is cleared
                //------------------------------------
                ret2 = dncDaq1.DaqErrorString(device_no, ret1, out error_string);
                if (ret2 != 0)
                {
                    error_string = "";
                }
                textBox_ErrorDetail.Text = "AiInputChannel= " + ret1.ToString() + " " + error_string;
                return;
            }
            //------------------------------------
            // Displays the acquired data on the label
            //------------------------------------
            textBox_Data.Text = channel.ToString() + "\t" + aidata.ToString() + "\r\n";
            textBox_ErrorDetail.Text = "AiInputChannel: " + ret1.ToString() + " Completed normally";
        }
    }
}

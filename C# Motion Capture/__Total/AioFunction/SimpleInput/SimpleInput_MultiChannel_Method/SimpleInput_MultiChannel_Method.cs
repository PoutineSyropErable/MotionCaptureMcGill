using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInput_MultiChannel_Method
{
    public partial class SimpleInput_MultiChannel_Method : Form
    {
        public SimpleInput_MultiChannel_Method()
        {
            InitializeComponent();
        }

        //================================================================================
        // DncDaq Setting button click event
        //================================================================================
        private void button_DaqProperty_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // Displays DncDaq settings screen
            //-----------------------------
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
        }

        //================================================================================
        // DncDaq error event
        //================================================================================
        private void dncDaq1_OnError(object sender, short DeviceNo, dnc.common.DncErrorEventArgs e)
        {
            int     ret;             // Variable for getting return value
            string  error_string;    // Error string

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
                textBox_ErrorDetail.Text = "Device No.: " + DeviceNo.ToString() + "\r\n" +
                                           "Error type: " + e.ErrorType.ToString() + "\r\n" +
                                           "Error code(value): " + e.Error.ToString() + "\r\n" +
                                           "Error code(character string): " + error_string + "\r\n" +
                                           "Error parameter: " + e.Param.ToString();
            }
        }

        //================================================================================
        // Processing when the AiInputMultiChannel button is pressed
        //================================================================================
        private void button_AiInputMultiChannel_Click(object sender, EventArgs e)
        {
            int     ret1;            // Variable for getting return value
            int     ret2;            // Variable for getting return value 2
            float[] aidata;          // Array for storing analog data
            short   device_no;       // Variable for storing Device No.
            short   channels;        // Variable for storing channel data
            string  error_string;    // Error string

            //------------------------------------
            // Get the Device No. and the number of conversion channels from the text box
            //------------------------------------
            try
            {
                device_no = short.Parse(textBox_DeviceNo.Text);
                channels = short.Parse(textBox_ChannelNum.Text);
            }
            catch (Exception ex)
            {
                textBox_ErrorDetail.Text = ex.Message;
                return;
            }
            //------------------------------------
            // Initialize the array for the number of channels for data storage
            //------------------------------------
            aidata = new float[channels];
            //------------------------------------
            // Executing the AiInputMultiChannel method
            //------------------------------------
            ret1 = dncDaq1.AiInputMultiChannel(device_no, channels, aidata);
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
                textBox_ErrorDetail.Text = "AiInputMultiChannel= " + ret1.ToString() + " " + error_string;
                return;
            }
            //------------------------------------
            // Conversion data display processing
            //------------------------------------
            short i;
            textBox_Data.Text = "";
            for (i = 0; i < channels; i++)
            {
                textBox_Data.Text += i + "\t" + aidata[i] + "\r\n";
            }
            textBox_ErrorDetail.Text = "AiInputMultiChannel: " + ret1.ToString() + " Completed normally ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeCount
{
    public partial class EdgeCount : Form
    {
        public EdgeCount()
        {
            InitializeComponent();
        }

        //================================================================================
        // DncDaq Setting button click event
        //================================================================================
        private void button_DaqProperty_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // Displays the DncDaq Settings screen
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
            //----------------------------------------
            // Check if edge settings exist in DncDaq
            //----------------------------------------
            if (dncDaq1.DaqProperty.Device[0].Edge.Count <= 3)
            {
                textBox_ErrorDetail.Text = "There is no edge setting.";
                return;
            }
            //----------------------------------------
            // Get the detection direction of the edge setting in the text box
            //----------------------------------------
            textBox_direction0.Text = dncDaq1.DaqProperty.Device[0].Edge[0].EdgeType.ToString();
            textBox_direction1.Text = dncDaq1.DaqProperty.Device[0].Edge[1].EdgeType.ToString();
            textBox_direction2.Text = dncDaq1.DaqProperty.Device[0].Edge[2].EdgeType.ToString();
            textBox_direction3.Text = dncDaq1.DaqProperty.Device[0].Edge[3].EdgeType.ToString();
        }

        //================================================================================
        // DNC-DAQ error event
        //================================================================================
        private void dncDaq1_OnError(object sender, short DeviceNo, dnc.common.DncErrorEventArgs e)
        {
            int    ret;             // Variable for getting return value
            string error_string;    // Error string

            //------------------------------------
            // Get the error string from the error No. in the event argument
            //------------------------------------
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
                // Add the error parameter to the list box
                // The method called by Invoke is described by the lambda expression [=>].
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
                // Add the error parameter to the list box
                //----------------------------------------
                textBox_ErrorDetail.Text = "Device No.: " + DeviceNo.ToString() + "\r\n" +
                                           "Error type: " + e.ErrorType.ToString() + "\r\n" +
                                           "Error code(value): " + e.Error.ToString() + "\r\n" +
                                           "Error code(character string): " + error_string + "\r\n" +
                                           "Error parameter: " + e.Param.ToString();
            }
        }

        //================================================================================
        // Action when a DNC-DAQ edge event occurs
        //================================================================================
        private void dncDaq1_OnEdge(object sender, dnc.daq.EdgeEventArgs e)
        {
            //------------------------------------
            // Branches the process by the bit number in the event argument
            // This sample uses bit0-3
            // If anything other than bit0-3 is detected, it will be displayed in the error text box.
            //------------------------------------
            switch (e.BitNumber)
            {
                case 0:
                    textBox_Count0.Text = e.Count.ToString();
                    break;
                case 1:
                    textBox_Count1.Text = e.Count.ToString();
                    break;
                case 2:
                    textBox_Count2.Text = e.Count.ToString();
                    break;
                case 3:
                    textBox_Count3.Text = e.Count.ToString();
                    break;
                default:
                    textBox_ErrorDetail.Text = "BitNo.: " + e.BitNumber.ToString() + "\r\n" +
                                               "Count value: " + e.Count.ToString() + "\r\n" +
                                               "Edge direction: " + e.EdgeType.ToString();
                    break;
            }
        }
    }
}

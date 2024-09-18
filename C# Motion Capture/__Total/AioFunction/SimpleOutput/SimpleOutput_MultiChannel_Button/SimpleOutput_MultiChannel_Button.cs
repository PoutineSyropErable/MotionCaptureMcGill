﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleOutput_MultiChannel_Button
{
    public partial class SimpleOutput_MultiChannel_Button : Form
    {
        public SimpleOutput_MultiChannel_Button()
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
            // Check if output task settings exist in DncDaq
            //----------------------------------------
            if (dncDaq1.DaqProperty.OutputTask.Count <= 0)
            {
                textBox_ErrorDetail.Text = "There is no output task setting.";
                return;
            }
            //----------------------------------------
            // The ch setting used in the output task setting is reflected in the label
            //----------------------------------------
            label_Channel.Text = "ch." + dncDaq1.DaqProperty.OutputTask[0].AccessTypeOutputValue;
        }

        //================================================================================
        // Action when a DNC-DAQ error event occurs
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
    }
}

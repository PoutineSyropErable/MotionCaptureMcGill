using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinuousInput_Graph_WriteFile
{
    public partial class ContinuousInput_Graph_WriteFile : Form
    {
        public ContinuousInput_Graph_WriteFile()
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
        // DncGraph Setting button click Event
        //================================================================================
        private void button_GraphProperty_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // Displays DncGraph settings screen
            //-----------------------------
            dncGraph1.ShowProperty();
        }

        //================================================================================
        // DncWriteFile Setting button click event
        //================================================================================
        private void button_WriteFileProperty_Click(object sender, EventArgs e)
        {
            //-----------------------------
            // Displays DncWriteFile settings screen
            //-----------------------------
            dncWriteFile1.ShowProperty();
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
            string start_trg;    // Variable for confirming DncDaq start trigger
            string stop_trg;     // Variable for confirming DncDaq stop trigger

            //----------------------------------------
            // Clear Error Details
            //----------------------------------------
            listBox_ErrorDetail.Items.Clear();
            //----------------------------------------
            // Check if device settings exist in DncDaq
            //----------------------------------------
            if (dncDaq1.DaqProperty.Device.Count <= 0)
            {
            	listBox_ErrorDetail.Items.Add("There is no device setting.");
                return;
            }
   			//----------------------------------------
			// Check if sampling settings exist in DncDaq
			//----------------------------------------
			if (dncDaq1.DaqProperty.Device[0].Sampling.Count <= 0)
			{
				listBox_ErrorDetail.Items.Add("There is no sampling setting.");
				return;
			}
            //----------------------------------------
            // Check if input task settings exist in DncDaq
            //----------------------------------------
            if (dncDaq1.DaqProperty.InputTask.Count <= 0)
            {
                listBox_ErrorDetail.Items.Add("There is no input task setting.");
                return;
            }
            //----------------------------------------
            // Check the start and stop trigger in the DncDaq sampling settings
            // The default is the following settings
            //   Start Trigger : dncButton_StartTrigger_click
            //   Stop Trigger : dncButton_StopTrigger_click
            // If the above button is not used in the start trigger / stop trigger, it is disabled
            // If you change the button name or use the stop trigger button for the start trigger,
            // the code part that enables / disables the button also needs to be modified to match the button name. 
            //----------------------------------------
            start_trg = dncDaq1.DaqProperty.Device[0].Sampling[0].StartTrigger;
            stop_trg = dncDaq1.DaqProperty.Device[0].Sampling[0].StopTrigger;
            //----------------------------------------
            // Check if the start trigger is [dncButton_StartTrigger] and enable or disable the button
            // When using a button, the ButtonName_click / ButtonName_valueChange / ButtonName_OnPressed
            // can be selected, so you should compare the first part of string(ButtonName).
            //----------------------------------------
            if (start_trg.StartsWith("dncButton_StartTrigger") == true)
            {
                //----------------------------------------
                // Enable the button if dncButton_StartTrigger is used
                //----------------------------------------
                dncButton_StartTrigger.Enabled = true;
            }
            else
            {
                //----------------------------------------
                // Disable the button if dncButton_StartTrigger is not used
                //----------------------------------------
                dncButton_StartTrigger.Enabled = false;
            }
            //----------------------------------------
            // Check if the stop trigger is [dncButton_StopTrigger] and enable or disable the button
            // When using a button, the ButtonName_click / ButtonName_valueChange / ButtonName_OnPressed
            // can be selected, so you should compare the first part of string(ButtonName).
            //----------------------------------------
            if (stop_trg.StartsWith("dncButton_StopTrigger") == true)
            {
                //----------------------------------------
                // Enable the button if dncButton_StopTrigger is used
                //----------------------------------------
                dncButton_StopTrigger.Enabled = true;
            }
            else
            {
                //----------------------------------------
                // Disable the button if dncButton_StopTrigger is not used
                //----------------------------------------
                dncButton_StopTrigger.Enabled = false;
            }
            //----------------------------------------
            // Reflects the DncDaq sampling status on the label
            //----------------------------------------
            textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
            textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
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
                //------------------------------------
                // Add the error parameter to the list box
                // The method called by Invoke is described by the lambda expression [=>]
                //------------------------------------
                Invoke(new Action(() => listBox_ErrorDetail.Items.Add(  "Error component: DncDaq" + ", " +
                                                                        "Device No.: " + DeviceNo.ToString() + ", " +
                                                                        "Error type: " + e.ErrorType.ToString() + ", " +
                                                                        "Error code(value): " + e.Error.ToString() + ", " +
                                                                        "Error code(character string): " + error_string + ", " +
                                                                        "Error parameter: " + e.Param.ToString()
                                                                        )));
            }
            else
            {
                //----------------------------------------
                // Add the error parameter to the list box
                //----------------------------------------
                listBox_ErrorDetail.Items.Add(  "Error component: DncDaq" + ", " +
                                                "Device No.: " + DeviceNo.ToString() + ", " +
                                                "Error type: " + e.ErrorType.ToString() + ", " +
                                                "Error code(value): " + e.Error.ToString() + ", " +
                                                "Error code(character string): " + error_string + ", " +
                                                "Error parameter: " + e.Param.ToString()
                                                );
            }
        }

        //================================================================================
        // DncGraph error event
        //================================================================================
        private void dncGraph1_OnError(object sender, dnc.common.DncErrorEventArgs e)
        {
            int    ret;             // Variable for getting return value
            string error_string;    // Error string

            //----------------------------------------
            // Get the error string from the error No. in the event argument
            //----------------------------------------
            ret = dncGraph1.ErrorString(e.Error, out error_string);
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
                //------------------------------------
                // Add the error parameter to the list box
                // The method called by Invoke is described by the lambda expression [=>]
                //------------------------------------
                Invoke(new Action(() => listBox_ErrorDetail.Items.Add(  "Error component: DncGraph" + ", " +
                                                                        "Error type: " + e.ErrorType.ToString() + ", " +
                                                                        "Error code(value): " + e.Error.ToString() + ", " +
                                                                        "Error code(character string): " + error_string + ", " +
                                                                        "Error parameter: " + e.Param.ToString()
                                                                        )));
            }
            else
            {
                //----------------------------------------
                // Add the error parameter to the list box
                //----------------------------------------
                listBox_ErrorDetail.Items.Add(  "Error component: DncGraph" + ", " +
                                                "Error type: " + e.ErrorType.ToString() + ", " +
                                                "Error code(value): " + e.Error.ToString() + ", " +
                                                "Error code(character string): " + error_string + ", " +
                                                "Error parameter: " + e.Param.ToString()
                                                );
            }
        }

        //================================================================================
        // DncWriteFile error event
        //================================================================================
        private void dncWriteFile1_OnError(object sender, dnc.common.DncErrorEventArgs e)
        {
            int     ret;             // Variable for getting return value
            string  error_string;    // Error string

            //----------------------------------------
            // Get the error string from the error No. in the event argument
            //----------------------------------------
            ret = dncWriteFile1.ErrorString(e.Error, out error_string);
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
                //------------------------------------
                // Add the error parameter to the list box
                // The method called by Invoke is described by the lambda expression [=>]
                //------------------------------------
                Invoke(new Action(() => listBox_ErrorDetail.Items.Add(  "Error component: DncWriteFile" + ", " +
                                                                        "Error type: " + e.ErrorType.ToString() + ", " +
                                                                        "Error code(value): " + e.Error.ToString() + ", " +
                                                                        "Error code(character string): " + error_string + ", " +
                                                                        "Error parameter: " + e.Param.ToString()
                                                                        )));
            }
            else
            {
                //----------------------------------------
                // Add the error parameter to the list box
                //----------------------------------------
                listBox_ErrorDetail.Items.Add(  "Error component: DncWriteFile" + ", " +
                                                "Error type: " + e.ErrorType.ToString() + ", " +
                                                "Error code(value): " + e.Error.ToString() + ", " +
                                                "Error code(character string): " + error_string + ", " +
                                                "Error parameter: " + e.Param.ToString()
                                                );
            }
        }

        //================================================================================
        // DncDaq sampling start event
        //================================================================================
        private void dncDaq1_OnAioContinuousModeStart(object sender, dnc.daq.AioContinuousModeStartEventArgs e)
        {
            //----------------------------------------
            // Displays status information on the label
            // Check if Invoke is required because the error event may be executed in another thread,
            // and if necessary, access the form control with Invoke.
            //----------------------------------------
            if (InvokeRequired == true)
            {
                //----------------------------------------
                // Displays the sampling status in the text box
                // The method called by Invoke is described by the lambda expression [=>].
                //----------------------------------------
                Invoke(new Action(() => {   textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                                            textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
                                        }));
            }
            else
            {
                //----------------------------------------
                // Displays the sampling status in the text box
                //----------------------------------------
                textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
            }
        }

        //================================================================================
        // DncDaq sampling stop event
        //================================================================================
        private void dncDaq1_OnAioContinuousModeStop(object sender, dnc.daq.AioContinuousModeStopEventArgs e)
        {
            //----------------------------------------
            // Displays status information on the label
            // Check if Invoke is required because the error event may be executed in another thread,
            // and if necessary, access the form control with Invoke.
            //----------------------------------------
            if (InvokeRequired == true)
            {
                //----------------------------------------
                // Displays sampling status / buffer status in the text box
                // The method called by Invoke is described by the lambda expression [=>]
                //----------------------------------------
                Invoke(new Action(() => {   textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                                            textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
                                        }));
            }
            else
            {
                //----------------------------------------
                // Displays sampling status / buffer status in the text box
                //----------------------------------------
                textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
            }
        }
    }
}

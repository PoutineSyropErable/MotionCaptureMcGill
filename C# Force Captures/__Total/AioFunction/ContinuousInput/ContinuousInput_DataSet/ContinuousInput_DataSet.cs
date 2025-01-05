using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContinuousInput_DataSet
{
    public partial class ContinuousInput_DataSet : Form
    {
        //-----------------------------
        // Total number of samplings
        //-----------------------------
        public UInt32 total_count;

        public ContinuousInput_DataSet()
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
        // DncDataSet Setting button click event
        //================================================================================
        private void button_DataSetProperty_Click(object sender, EventArgs e)
        {
            //----------------------------------------
            // Displays DncDateSet settings screen
            //----------------------------------------
            dncDataSet1.ShowProperty();
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
            int     ret1;            // Variable for getting return value 
            int     ret2;            // Variable for getting return value 2
            string  error_string;    // Error string
            string  start_trg;       // Variable for confirming DncDaq start trigger
            string  stop_trg;        // Variable for confirming DncDaq stop trigger

            //----------------------------------------
            // Clear Error Details
            //----------------------------------------
            listBox_ErrorDetail.Items.Clear();
            //----------------------------------------
            // Reset the number of samplings
            //----------------------------------------
            total_count = 0;
            //----------------------------------------
            // Clear the data display text box
            //----------------------------------------
            textBox_data.Clear();
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
            // Resets the contents of the DncDataSet buffer
            //----------------------------------------
            ret1 = dncDataSet1.BufferReset();
            //------------------------------------
            // Error process
            //------------------------------------
            if (ret1 != 0)
            {
                //------------------------------------
                // If the ErrorString method fails, the error content is cleared
                //------------------------------------
                ret2 = dncDataSet1.ErrorString(ret1, out error_string);
                if (ret2 != 0)
                {
                    error_string = "";
                }
                listBox_ErrorDetail.Text += "DncDataSet:BufferReset exception:" + error_string;
                return;
            }
            //----------------------------------------
            // Reflects the DncDaq sampling status on the label
            //----------------------------------------
            textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
            textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
            //----------------------------------------
            // Reflects the DncDataSet status on the label
            //----------------------------------------
            textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
            textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
        }

        //================================================================================
        // DncDaq error event
        //================================================================================
        private void dncDaq1_OnError(object sender, short DeviceNo, dnc.common.DncErrorEventArgs e)
        {
            int     ret;             // Variable for getting return value
            string  error_string;    // Error string

            //------------------------------------
            // Get the error string from the error No. in the event argument
            //------------------------------------
            ret = dncDaq1.DaqErrorString(DeviceNo, e.Error, out error_string);
            //------------------------------------
            // When failed to get the error string, initialize the error string
            //------------------------------------
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
                Invoke(new Action(() => {   listBox_ErrorDetail.Items.Add("Error component: DncDaq" + ", " +
                                                                          "Device No.: " + DeviceNo.ToString() + ", " +
                                                                          "Error type: " + e.ErrorType.ToString() + ", " +
                                                                          "Error code(value): " + e.Error.ToString() + ", " +
                                                                          "Error code(character string): " + error_string + ", " +
                                                                          "Error parameter: " + e.Param.ToString()
                                                                          );
                                            textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                                            textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
                                        }));
            }
            else
            {
                //------------------------------------
                // Add the error parameter to the list box
                //------------------------------------
                listBox_ErrorDetail.Items.Add("Error component: DncDaq" + ", " +
                                              "Device No.: " + DeviceNo.ToString() + ", " +
                                              "Error type: " + e.ErrorType.ToString() + ", " +
                                              "Error code(value): " + e.Error.ToString() + ", " +
                                              "Error code(character string): " + error_string + ", " +
                                              "Error parameter: " + e.Param.ToString()
                                              );
                textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
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
                // Displays sampling status / buffer status in the text box
                // The method called by Invoke is described by the lambda expression [=>]
                //----------------------------------------
                Invoke(new Action(() => {   textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                                            textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
                                            textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
                                            textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
                                        }));
            }
            else
            {
                //----------------------------------------
                // Displays sampling status / buffer status in the text box
                //----------------------------------------
                textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
                textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
                textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
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
                                            textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
                                            textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
                                        }));
            }
            else
            {
                //----------------------------------------
                // Displays sampling status / buffer status in the text box
                //----------------------------------------
                textBox_SamplingStatus.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeStateText;
                textBox_SamplingError.Text = dncDaq1.DaqProperty.Device[0].AiContinuousModeErrorText;
                textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
                textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
            }
        }

        //================================================================================
        // DncDataSet error event
        //================================================================================
        private void dncDataSet1_OnError(object sender, dnc.common.DncErrorEventArgs e)
        {
            int     ret;             // Variable for getting return value
            string  error_string;    // Error string

            //------------------------------------
            // Get the error string from the error No. in the event argument
            //------------------------------------
            ret = dncDataSet1.ErrorString(e.Error, out error_string);
            //------------------------------------
            // When failed to get the error string, initialize the error string
            //------------------------------------
            if (ret != 0)
            {
                error_string = "";
            }
            //------------------------------------
            // Displays the obtained error string and the status information in the event argument on the label
            // Check if Invoke is required because the error event may be executed in another thread,
            // and if necessary, access the form control with Invoke.
            //------------------------------------
            if (InvokeRequired == true)
            {
                //------------------------------------
                // Add the error parameter to the list box
                // The method called by Invoke is described by the lambda expression [=>]
                //------------------------------------
                Invoke(new Action(() => {
                                            listBox_ErrorDetail.Items.Add("Error component: DncDataSet" + ", " +
                                                                          "Error type: " + e.ErrorType.ToString() + ", " +
                                                                          "Error code(value): " + e.Error.ToString() + ", " +
                                                                          "Error code(character string): " + error_string + ", " +
                                                                          "Error parameter: " + e.Param.ToString()
                                                                          );
                                            textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
                                            textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
                                        }));
            }
            else
            {
                //------------------------------------
                // Add the error parameter to the list box
                //------------------------------------
                listBox_ErrorDetail.Items.Add("Error component: DncDataSet" + ", " +
                                              "Error type: " + e.ErrorType.ToString() + ", " +
                                              "Error code(value): " + e.Error.ToString() + ", " +
                                              "Error code(character string): " + error_string + ", " +
                                              "Error parameter: " + e.Param.ToString()
                                              );
                textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
                textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
            }
        }

        //================================================================================
        // DncDaq timing event
        //================================================================================
        private void dncDaq1_OnTiming(object sender, dnc.daq.TimingEventArgs e)
        {
            //------------------------------------
            // Gets the number of data in the DataSet and displays it on the label
            //------------------------------------
            Invoke(new Action(() => textBox_DataSetCount.Text = dncDataSet1.DataSetProperty.DataSetCount.ToString()));
        }

        //================================================================================
        // DncDataSet event that the specified number of data are stored
        //================================================================================
        private void dncDataSet1_OnNumOfDataStore_1(object sender, dnc.dataset.OnNumOfDataStoreEventArgs e)
        {
            int     ret1;              // Variable for getting return value
            int     ret2;              // Variable for getting return value 2 
            int     data_set_unit;     // Variable for storing data set unit
            int     data_set_count;    // Variable for storing data count (data set unit) in buffer
            int     i;
            int     j;
            float[] sampling_data;     // Array for storing sampling data
            string  data;              // Character string for displaying sampling data
            string  error_string;      // Error string

            //------------------------------------
            // Get the dataset unit from the DncDataSet property
            //------------------------------------
            data_set_unit = dncDataSet1.DataSetProperty.DataSetUnit;
            //------------------------------------
            // Get the number of data counts in the buffer (Data set unit) from the DncDataSet property
            //------------------------------------
            data_set_count = dncDataSet1.DataSetProperty.DataSetCount;
            //------------------------------------
            // Initialize the array that stores the data
            //------------------------------------
            sampling_data = new float[data_set_count * data_set_unit];
            //------------------------------------
            // Get sampling data
            //------------------------------------
            ret1 = dncDataSet1.GetBufferData(ref data_set_count, sampling_data);
            //------------------------------------
            // Error process
            //------------------------------------
            if (ret1 != 0)
            {
                //------------------------------------
                // If the ErrorString method fails, the error content is cleared
                //------------------------------------
                ret2 = dncDataSet1.ErrorString(ret1, out error_string);
                if (ret2 != 0)
                {
                    error_string = "";
                }
                Invoke(new Action(()=>listBox_ErrorDetail.Items.Add("DncDataSet:GetBufferData exception:" + error_string) ));
                return;
            }
            //------------------------------------
            // Initialize the variables for the acquired data
            //------------------------------------
            data = "";
            //------------------------------------
            // The first line shows the data item name
            // This sample assumes that the ch. Used is a serial number starting from 0
            //------------------------------------
            data += "Count" + "\t";
            for (i = 0; i < data_set_unit; i++)
            {
                data += "ch." + i.ToString() + "[V]" + "\t";
            }
            data += "\r\n";
            //------------------------------------
            // Data will be added to the second and subsequent lines
            //------------------------------------
            for (i = 0; i < sampling_data.Length; i += data_set_unit, total_count++)
            {
                data += total_count.ToString() + "\t";
                for (j = 0; j < data_set_unit; j++)
                {
                    data += string.Format("{0:F3}", sampling_data[i + j]) + "\t";
                }
                data += "\r\n";
            }
            //------------------------------------
            // Add the acquired data
            //------------------------------------
            Invoke(new Action(() => {   textBox_data.Text = data;
                                        textBox_DataSetCount.Text = dncDataSet1.DataSetProperty.DataCount.ToString();
                                        textBox_DataSetStatus.Text = dncDataSet1.DataSetProperty.BufferStatusText;
                                        textBox_DataSetError.Text = dncDataSet1.DataSetProperty.BufferErrorText;
                                    }));
        }
    }
}
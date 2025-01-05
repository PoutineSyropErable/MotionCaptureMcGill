namespace ContinuousInput_DataSet
{
    partial class ContinuousInput_DataSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            dnc.dataset.DncDataSetProperty dncDataSetProperty1 = new dnc.dataset.DncDataSetProperty();
            dnc.button.DncButtonProperty dncButtonProperty1 = new dnc.button.DncButtonProperty();
            dnc.button.DncButtonProperty dncButtonProperty2 = new dnc.button.DncButtonProperty();
            dnc.daq.DncDaqProperty dncDaqProperty1 = new dnc.daq.DncDaqProperty();
            this.dncDataSet1 = new dnc.dataset.DncDataSet(this.components);
            this.label_DataSetCount = new System.Windows.Forms.Label();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.dncButton_StopTrigger = new dnc.button.DncButton(this.components);
            this.dncButton_StartTrigger = new dnc.button.DncButton(this.components);
            this.textBox_DataSetCount = new System.Windows.Forms.TextBox();
            this.groupBox_ActionButton = new System.Windows.Forms.GroupBox();
            this.textBox_DataSetError = new System.Windows.Forms.TextBox();
            this.textBox_DataSetStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_DaqProperty = new System.Windows.Forms.Button();
            this.textBox_SamplingError = new System.Windows.Forms.TextBox();
            this.textBox_SamplingStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_ErrorDetail = new System.Windows.Forms.ListBox();
            this.label_ErrorDetail = new System.Windows.Forms.Label();
            this.button_DataSetProperty = new System.Windows.Forms.Button();
            this.groupBox_PropertyWindow = new System.Windows.Forms.GroupBox();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.daqInputTask1 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqTiming1 = new dnc.daq.task.DaqTiming(this.components);
            this.daqSampling1 = new dnc.daq.task.DaqSampling(this.components);
            this.daqDevice1 = new dnc.daq.task.DaqDevice(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dncDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StopTrigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StartTrigger)).BeginInit();
            this.groupBox_ActionButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
            this.groupBox_PropertyWindow.SuspendLayout();
            this.groupBox_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dncDataSet1
            // 
            this.dncDataSet1.BufferValueByte = new byte[] {
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0))};
            this.dncDataSet1.BufferValueFloat = new float[] {
        0F,
        0F,
        0F,
        0F};
            this.dncDataSet1.BufferValueInt = new int[] {
        0,
        0,
        0,
        0};
            dncDataSetProperty1.BufferSizeUnit = dnc.dataset.DSetBufferSizeUnit.x1000;
            dncDataSetProperty1.DataSetUnit = ((short)(4));
            dncDataSetProperty1.DataType = dnc.dataset.DSetDataType.Float;
            dncDataSetProperty1.EventDataNum = 4000;
            dncDataSetProperty1.EventDataSetNum = 1000;
            this.dncDataSet1.DataSetProperty = dncDataSetProperty1;
            this.dncDataSet1.DncName = "dncDataSet1";
            this.dncDataSet1.OnError += new dnc.common.DncErrorEventHandler(this.dncDataSet1_OnError);
            this.dncDataSet1.OnNumOfDataStore += new dnc.dataset.DataSetDataStoreEventHandler(this.dncDataSet1_OnNumOfDataStore_1);
            // 
            // label_DataSetCount
            // 
            this.label_DataSetCount.AutoSize = true;
            this.label_DataSetCount.Location = new System.Drawing.Point(19, 383);
            this.label_DataSetCount.Name = "label_DataSetCount";
            this.label_DataSetCount.Size = new System.Drawing.Size(109, 13);
            this.label_DataSetCount.TabIndex = 17;
            this.label_DataSetCount.Text = "DataSet Data Count: ";
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(14, 12);
            this.textBox_data.Multiline = true;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_data.Size = new System.Drawing.Size(468, 356);
            this.textBox_data.TabIndex = 16;
            this.textBox_data.WordWrap = false;
            // 
            // dncButton_StopTrigger
            // 
            dncButtonProperty1.OffLedColor = System.Drawing.Color.Empty;
            dncButtonProperty1.OnLedColor = System.Drawing.Color.Empty;
            dncButtonProperty1.TextOff = "Stop Trigger";
            dncButtonProperty1.TextOn = "Stop Trigger";
            this.dncButton_StopTrigger.ButtonProperty = dncButtonProperty1;
            this.dncButton_StopTrigger.Location = new System.Drawing.Point(22, 61);
            this.dncButton_StopTrigger.Name = "dncButton_StopTrigger";
            this.dncButton_StopTrigger.Size = new System.Drawing.Size(117, 25);
            this.dncButton_StopTrigger.TabIndex = 1;
            this.dncButton_StopTrigger.UseVisualStyleBackColor = true;
            // 
            // dncButton_StartTrigger
            // 
            dncButtonProperty2.OffLedColor = System.Drawing.Color.Empty;
            dncButtonProperty2.OnLedColor = System.Drawing.Color.Empty;
            dncButtonProperty2.TextOff = "Start Trigger";
            dncButtonProperty2.TextOn = "Start Trigger";
            this.dncButton_StartTrigger.ButtonProperty = dncButtonProperty2;
            this.dncButton_StartTrigger.Location = new System.Drawing.Point(22, 29);
            this.dncButton_StartTrigger.Name = "dncButton_StartTrigger";
            this.dncButton_StartTrigger.Size = new System.Drawing.Size(117, 25);
            this.dncButton_StartTrigger.TabIndex = 0;
            this.dncButton_StartTrigger.UseVisualStyleBackColor = true;
            // 
            // textBox_DataSetCount
            // 
            this.textBox_DataSetCount.Location = new System.Drawing.Point(140, 379);
            this.textBox_DataSetCount.Name = "textBox_DataSetCount";
            this.textBox_DataSetCount.Size = new System.Drawing.Size(93, 20);
            this.textBox_DataSetCount.TabIndex = 18;
            // 
            // groupBox_ActionButton
            // 
            this.groupBox_ActionButton.Controls.Add(this.dncButton_StopTrigger);
            this.groupBox_ActionButton.Controls.Add(this.dncButton_StartTrigger);
            this.groupBox_ActionButton.Location = new System.Drawing.Point(502, 134);
            this.groupBox_ActionButton.Name = "groupBox_ActionButton";
            this.groupBox_ActionButton.Size = new System.Drawing.Size(153, 108);
            this.groupBox_ActionButton.TabIndex = 15;
            this.groupBox_ActionButton.TabStop = false;
            this.groupBox_ActionButton.Text = "Button for Linkage";
            // 
            // textBox_DataSetError
            // 
            this.textBox_DataSetError.Location = new System.Drawing.Point(436, 46);
            this.textBox_DataSetError.Name = "textBox_DataSetError";
            this.textBox_DataSetError.Size = new System.Drawing.Size(208, 20);
            this.textBox_DataSetError.TabIndex = 41;
            // 
            // textBox_DataSetStatus
            // 
            this.textBox_DataSetStatus.Location = new System.Drawing.Point(122, 48);
            this.textBox_DataSetStatus.Name = "textBox_DataSetStatus";
            this.textBox_DataSetStatus.Size = new System.Drawing.Size(208, 20);
            this.textBox_DataSetStatus.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "DataSet Error ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "DataSet Status ";
            // 
            // dncDaq1
            // 
            dncDaqProperty1.DebugLogFileName = "DncDaqDebugLog.log";
            dncDaqProperty1.DebugLogTarget.ERROR = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.EVENT = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.EXEPTION = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.INFO = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.Device.Add(this.daqDevice1);
            dncDaqProperty1.InputTask.Add(this.daqInputTask1);
            dncDaqProperty1.TaskMode = dnc.daq.DaqTaskMode.AdvancedMode;
            dncDaqProperty1.Timing.Add(this.daqTiming1);
            this.dncDaq1.DaqProperty = dncDaqProperty1;
            this.dncDaq1.DncName = "dncDaq1";
            this.dncDaq1.OnError += new dnc.common.DncDaqErrorEventHandler(this.dncDaq1_OnError);
            this.dncDaq1.OnTiming += new dnc.daq.TimingEventHandler(this.dncDaq1_OnTiming);
            this.dncDaq1.OnAioContinuousModeStart += new dnc.daq.AioContinuousModeStartEventHandler(this.dncDaq1_OnAioContinuousModeStart);
            this.dncDaq1.OnAioContinuousModeStop += new dnc.daq.AioContinuousModeStopEventHandler(this.dncDaq1_OnAioContinuousModeStop);
            this.dncDaq1.OnInit += new System.EventHandler(this.dncDaq1_OnInit);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(524, 371);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(117, 25);
            this.button_Exit.TabIndex = 13;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_DaqProperty
            // 
            this.button_DaqProperty.Location = new System.Drawing.Point(22, 27);
            this.button_DaqProperty.Name = "button_DaqProperty";
            this.button_DaqProperty.Size = new System.Drawing.Size(117, 25);
            this.button_DaqProperty.TabIndex = 2;
            this.button_DaqProperty.Text = "DncDaq Setting";
            this.button_DaqProperty.UseVisualStyleBackColor = true;
            this.button_DaqProperty.Click += new System.EventHandler(this.button_DaqProperty_Click);
            // 
            // textBox_SamplingError
            // 
            this.textBox_SamplingError.Location = new System.Drawing.Point(436, 18);
            this.textBox_SamplingError.Name = "textBox_SamplingError";
            this.textBox_SamplingError.Size = new System.Drawing.Size(208, 20);
            this.textBox_SamplingError.TabIndex = 10;
            // 
            // textBox_SamplingStatus
            // 
            this.textBox_SamplingStatus.Location = new System.Drawing.Point(122, 21);
            this.textBox_SamplingStatus.Name = "textBox_SamplingStatus";
            this.textBox_SamplingStatus.Size = new System.Drawing.Size(208, 20);
            this.textBox_SamplingStatus.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sampling Error ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sampling Status ";
            // 
            // listBox_ErrorDetail
            // 
            this.listBox_ErrorDetail.FormattingEnabled = true;
            this.listBox_ErrorDetail.HorizontalScrollbar = true;
            this.listBox_ErrorDetail.Location = new System.Drawing.Point(122, 90);
            this.listBox_ErrorDetail.Name = "listBox_ErrorDetail";
            this.listBox_ErrorDetail.Size = new System.Drawing.Size(522, 108);
            this.listBox_ErrorDetail.TabIndex = 7;
            // 
            // label_ErrorDetail
            // 
            this.label_ErrorDetail.AutoSize = true;
            this.label_ErrorDetail.Location = new System.Drawing.Point(13, 90);
            this.label_ErrorDetail.Name = "label_ErrorDetail";
            this.label_ErrorDetail.Size = new System.Drawing.Size(67, 13);
            this.label_ErrorDetail.TabIndex = 6;
            this.label_ErrorDetail.Text = "Error Details ";
            // 
            // button_DataSetProperty
            // 
            this.button_DataSetProperty.Location = new System.Drawing.Point(22, 65);
            this.button_DataSetProperty.Name = "button_DataSetProperty";
            this.button_DataSetProperty.Size = new System.Drawing.Size(117, 25);
            this.button_DataSetProperty.TabIndex = 3;
            this.button_DataSetProperty.Text = "DataSet Setting";
            this.button_DataSetProperty.UseVisualStyleBackColor = true;
            this.button_DataSetProperty.Click += new System.EventHandler(this.button_DataSetProperty_Click);
            // 
            // groupBox_PropertyWindow
            // 
            this.groupBox_PropertyWindow.Controls.Add(this.button_DataSetProperty);
            this.groupBox_PropertyWindow.Controls.Add(this.button_DaqProperty);
            this.groupBox_PropertyWindow.Location = new System.Drawing.Point(502, 16);
            this.groupBox_PropertyWindow.Name = "groupBox_PropertyWindow";
            this.groupBox_PropertyWindow.Size = new System.Drawing.Size(153, 101);
            this.groupBox_PropertyWindow.TabIndex = 12;
            this.groupBox_PropertyWindow.TabStop = false;
            this.groupBox_PropertyWindow.Text = "Setting Screen Display ";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.textBox_DataSetError);
            this.groupBox_Status.Controls.Add(this.textBox_DataSetStatus);
            this.groupBox_Status.Controls.Add(this.label8);
            this.groupBox_Status.Controls.Add(this.label9);
            this.groupBox_Status.Controls.Add(this.textBox_SamplingError);
            this.groupBox_Status.Controls.Add(this.textBox_SamplingStatus);
            this.groupBox_Status.Controls.Add(this.label2);
            this.groupBox_Status.Controls.Add(this.label1);
            this.groupBox_Status.Controls.Add(this.listBox_ErrorDetail);
            this.groupBox_Status.Controls.Add(this.label_ErrorDetail);
            this.groupBox_Status.Location = new System.Drawing.Point(14, 414);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(657, 215);
            this.groupBox_Status.TabIndex = 14;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "Status Display ";
            // 
            // daqInputTask1
            // 
            this.daqInputTask1.AccessType = dnc.daq.DaqInputAccessType.Analog;
            this.daqInputTask1.AccessTypeInputValue = "0-3";
            this.daqInputTask1.DeviceName = "AIO000";
            this.daqInputTask1.InputNo = 0;
            this.daqInputTask1.Target = "dncDataSet1";
            this.daqInputTask1.TaskValueByte = null;
            this.daqInputTask1.TaskValueFloat = null;
            this.daqInputTask1.TaskValueInt = null;
            this.daqInputTask1.Timing = "Timing_00";
            // 
            // daqTiming1
            // 
            this.daqTiming1.TimingName = "Timing_00";
            this.daqTiming1.TimingNo = 0;
            // 
            // daqSampling1
            // 
            this.daqSampling1.BufferSize = ((uint)(1000000u));
            this.daqSampling1.DataStoreNum = "Auto";
            this.daqSampling1.DataStoreNumInput = 1;
            this.daqSampling1.Enabled = true;
            this.daqSampling1.InputType = dnc.daq.DaqAioSamplingInputType.VoltCurr;
            this.daqSampling1.SamplingNo = 0;
            this.daqSampling1.StartTrigger = "dncButton_StartTrigger_Click";
            this.daqSampling1.StopTrigger = "dncButton_StopTrigger_Click";
            // 
            // daqDevice1
            // 
            this.daqDevice1.AiInputMethod = ((short)(0));
            this.daqDevice1.AiRange = new short[0];
            this.daqDevice1.AiScanClock = 2F;
            this.daqDevice1.AoDefaultOutData = new float[] {
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F};
            this.daqDevice1.AoRange = new short[0];
            this.daqDevice1.BufferOverOperation = dnc.daq.DaqAioSamplingBufferOver.All;
            this.daqDevice1.DeviceName = "AIO000";
            this.daqDevice1.DeviceNo = ((short)(0));
            this.daqDevice1.DoDefaultOutData = new byte[] {
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0))};
            this.daqDevice1.ModelName = "AIO-163202F-PE";
            this.daqDevice1.Sampling.Add(this.daqSampling1);
            this.daqDevice1.SamplingEnable = true;
            this.daqDevice1.TabName = "Device00";
            // 
            // ContinuousInput_DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 640);
            this.Controls.Add(this.label_DataSetCount);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.textBox_DataSetCount);
            this.Controls.Add(this.groupBox_ActionButton);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox_PropertyWindow);
            this.Controls.Add(this.groupBox_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContinuousInput_DataSet";
            this.Text = "Analog Sampling Sample (DataSet Linkage) ";
            ((System.ComponentModel.ISupportInitialize)(this.dncDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StopTrigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StartTrigger)).EndInit();
            this.groupBox_ActionButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
            this.groupBox_PropertyWindow.ResumeLayout(false);
            this.groupBox_Status.ResumeLayout(false);
            this.groupBox_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dnc.dataset.DncDataSet dncDataSet1;
        private System.Windows.Forms.Label label_DataSetCount;
        private System.Windows.Forms.TextBox textBox_data;
        private dnc.button.DncButton dncButton_StopTrigger;
        private dnc.button.DncButton dncButton_StartTrigger;
        private System.Windows.Forms.TextBox textBox_DataSetCount;
        private System.Windows.Forms.GroupBox groupBox_ActionButton;
        private System.Windows.Forms.TextBox textBox_DataSetError;
        private System.Windows.Forms.TextBox textBox_DataSetStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private dnc.daq.DncDaq dncDaq1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_DaqProperty;
        private System.Windows.Forms.TextBox textBox_SamplingError;
        private System.Windows.Forms.TextBox textBox_SamplingStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_ErrorDetail;
        private System.Windows.Forms.Label label_ErrorDetail;
        private System.Windows.Forms.Button button_DataSetProperty;
        private System.Windows.Forms.GroupBox groupBox_PropertyWindow;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private dnc.daq.task.DaqDevice daqDevice1;
        private dnc.daq.task.DaqSampling daqSampling1;
        private dnc.daq.task.DaqInputTask daqInputTask1;
        private dnc.daq.task.DaqTiming daqTiming1;
    }
}


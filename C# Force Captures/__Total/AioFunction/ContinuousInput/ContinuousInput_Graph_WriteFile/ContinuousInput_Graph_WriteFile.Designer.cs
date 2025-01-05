namespace ContinuousInput_Graph_WriteFile
{
    partial class ContinuousInput_Graph_WriteFile
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
            dnc.button.DncButtonProperty dncButtonProperty1 = new dnc.button.DncButtonProperty();
            dnc.button.DncButtonProperty dncButtonProperty2 = new dnc.button.DncButtonProperty();
            dnc.writefile.DncWriteFileProperty dncWriteFileProperty1 = new dnc.writefile.DncWriteFileProperty();
            dnc.graph.DncGraphProperty dncGraphProperty1 = new dnc.graph.DncGraphProperty();
            dnc.daq.DncDaqProperty dncDaqProperty1 = new dnc.daq.DncDaqProperty();
            this.graphLine1 = new dnc.graph.collection.GraphLine(this.components);
            this.graphLine2 = new dnc.graph.collection.GraphLine(this.components);
            this.graphLine3 = new dnc.graph.collection.GraphLine(this.components);
            this.graphLine4 = new dnc.graph.collection.GraphLine(this.components);
            this.groupBox_ActionButton = new System.Windows.Forms.GroupBox();
            this.dncButton_StopTrigger = new dnc.button.DncButton(this.components);
            this.dncButton_StartTrigger = new dnc.button.DncButton(this.components);
            this.textBox_SamplingError = new System.Windows.Forms.TextBox();
            this.textBox_SamplingStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_ErrorDetail = new System.Windows.Forms.ListBox();
            this.label_ErrorDetail = new System.Windows.Forms.Label();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.dncWriteFile1 = new dnc.writefile.DncWriteFile(this.components);
            this.dncGraph1 = new dnc.graph.DncGraph(this.components);
            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_WriteFileProperty = new System.Windows.Forms.Button();
            this.button_GraphProperty = new System.Windows.Forms.Button();
            this.groupBox_PropertyWindow = new System.Windows.Forms.GroupBox();
            this.button_DaqProperty = new System.Windows.Forms.Button();
            this.daqInputTask1 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqInputTask2 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqTiming1 = new dnc.daq.task.DaqTiming(this.components);
            this.daqSampling1 = new dnc.daq.task.DaqSampling(this.components);
            this.daqDevice1 = new dnc.daq.task.DaqDevice(this.components);
            this.groupBox_ActionButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StopTrigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StartTrigger)).BeginInit();
            this.groupBox_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncWriteFile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
            this.groupBox_PropertyWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphLine1
            // 
            this.graphLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphLine1.LineName = "CH0";
            this.graphLine1.LineNo = 0;
            // 
            // graphLine2
            // 
            this.graphLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.graphLine2.LineName = "CH1";
            this.graphLine2.LineNo = 1;
            // 
            // graphLine3
            // 
            this.graphLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.graphLine3.LineName = "CH2";
            this.graphLine3.LineNo = 2;
            // 
            // graphLine4
            // 
            this.graphLine4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(32)))), ((int)(((byte)(9)))));
            this.graphLine4.LineName = "CH3";
            this.graphLine4.LineNo = 3;
            // 
            // groupBox_ActionButton
            // 
            this.groupBox_ActionButton.Controls.Add(this.dncButton_StopTrigger);
            this.groupBox_ActionButton.Controls.Add(this.dncButton_StartTrigger);
            this.groupBox_ActionButton.Location = new System.Drawing.Point(731, 199);
            this.groupBox_ActionButton.Name = "groupBox_ActionButton";
            this.groupBox_ActionButton.Size = new System.Drawing.Size(153, 108);
            this.groupBox_ActionButton.TabIndex = 12;
            this.groupBox_ActionButton.TabStop = false;
            this.groupBox_ActionButton.Text = "Button for Linkage ";
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
            // textBox_SamplingError
            // 
            this.textBox_SamplingError.Location = new System.Drawing.Point(512, 23);
            this.textBox_SamplingError.Name = "textBox_SamplingError";
            this.textBox_SamplingError.Size = new System.Drawing.Size(250, 20);
            this.textBox_SamplingError.TabIndex = 10;
            // 
            // textBox_SamplingStatus
            // 
            this.textBox_SamplingStatus.Location = new System.Drawing.Point(125, 23);
            this.textBox_SamplingStatus.Name = "textBox_SamplingStatus";
            this.textBox_SamplingStatus.Size = new System.Drawing.Size(250, 20);
            this.textBox_SamplingStatus.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sampling Error ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sampling Status ";
            // 
            // listBox_ErrorDetail
            // 
            this.listBox_ErrorDetail.FormattingEnabled = true;
            this.listBox_ErrorDetail.HorizontalScrollbar = true;
            this.listBox_ErrorDetail.Location = new System.Drawing.Point(125, 68);
            this.listBox_ErrorDetail.Name = "listBox_ErrorDetail";
            this.listBox_ErrorDetail.Size = new System.Drawing.Size(637, 108);
            this.listBox_ErrorDetail.TabIndex = 7;
            // 
            // label_ErrorDetail
            // 
            this.label_ErrorDetail.AutoSize = true;
            this.label_ErrorDetail.Location = new System.Drawing.Point(16, 68);
            this.label_ErrorDetail.Name = "label_ErrorDetail";
            this.label_ErrorDetail.Size = new System.Drawing.Size(67, 13);
            this.label_ErrorDetail.TabIndex = 6;
            this.label_ErrorDetail.Text = "Error Details ";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.textBox_SamplingError);
            this.groupBox_Status.Controls.Add(this.textBox_SamplingStatus);
            this.groupBox_Status.Controls.Add(this.label2);
            this.groupBox_Status.Controls.Add(this.label1);
            this.groupBox_Status.Controls.Add(this.listBox_ErrorDetail);
            this.groupBox_Status.Controls.Add(this.label_ErrorDetail);
            this.groupBox_Status.Location = new System.Drawing.Point(23, 446);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(791, 202);
            this.groupBox_Status.TabIndex = 11;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "Status Display ";
            // 
            // dncWriteFile1
            // 
            this.dncWriteFile1.DncName = "dncWriteFile1";
            dncWriteFileProperty1.ColumnName = new string[] {
        "Time",
        "CH0",
        "CH1",
        "CH2",
        "CH3"};
            dncWriteFileProperty1.ColumnNameEnable = true;
            dncWriteFileProperty1.ColumnNameNum = ((short)(5));
            dncWriteFileProperty1.ColumnNum = ((short)(4));
            dncWriteFileProperty1.DataPadingDigit = ((short)(1));
            dncWriteFileProperty1.FirstColumnType = dnc.writefile.WFileFirstColumnType.TimeStamp;
            dncWriteFileProperty1.IndexDigits = ((short)(1));
            dncWriteFileProperty1.NameOption = dnc.writefile.WFileFileNameOption.DateAndNum;
            dncWriteFileProperty1.TimeStampFormat = dnc.writefile.WFileTimeStampOption.ToMsec;
            this.dncWriteFile1.WriteFileProperty = dncWriteFileProperty1;
            this.dncWriteFile1.OnError += new dnc.common.DncErrorEventHandler(this.dncWriteFile1_OnError);
            // 
            // dncGraph1
            // 
            this.dncGraph1.DncName = "dncGraph1";
            dncGraphProperty1.Cursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.Cursor.PropertyHeight = ((short)(160));
            dncGraphProperty1.Cursor.PropertyPositionX = ((short)(503));
            dncGraphProperty1.Cursor.PropertyPositionY = ((short)(129));
            dncGraphProperty1.DrawingMode = dnc.graph.GraphDrawingMode.Additional;
            dncGraphProperty1.GraphArea.LineColor = System.Drawing.Color.Gray;
            dncGraphProperty1.Legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.Line.Add(this.graphLine1);
            dncGraphProperty1.Line.Add(this.graphLine2);
            dncGraphProperty1.Line.Add(this.graphLine3);
            dncGraphProperty1.Line.Add(this.graphLine4);
            dncGraphProperty1.LineNum = ((short)(4));
            dncGraphProperty1.PlotArea.LineColor = System.Drawing.Color.LightSlateGray;
            dncGraphProperty1.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.Title.Text = "Sampling Data";
            dncGraphProperty1.ToolBar.PositionX = ((short)(152));
            dncGraphProperty1.ToolBar.PositionY = ((short)(370));
            dncGraphProperty1.XAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.XAxisLabel.Text = "Sampling Times";
            dncGraphProperty1.XAxisScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.XAxisScale.MaximumRange = 1000F;
            dncGraphProperty1.XAxisScale.SubScaleLineType = dnc.graph.GraphLineType.Dot;
            dncGraphProperty1.YAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.YAxisLabel.Text = "Voltage[V]";
            dncGraphProperty1.YAxisLabel.TextDirection = dnc.graph.GraphTextDirection.Rotate90L;
            dncGraphProperty1.YAxisScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.YAxisScale.MaximumRange = 10F;
            dncGraphProperty1.YAxisScale.MinimumRange = -10F;
            dncGraphProperty1.YAxisScale.SubScaleLineType = dnc.graph.GraphLineType.None;
            dncGraphProperty1.YSecondaryAxis.Enable = false;
            dncGraphProperty1.YSecondaryAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.YSecondaryAxisScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dncGraphProperty1.YSecondaryAxisScale.SubScaleLineType = dnc.graph.GraphLineType.Dot;
            this.dncGraph1.GraphProperty = dncGraphProperty1;
            this.dncGraph1.Location = new System.Drawing.Point(21, 15);
            this.dncGraph1.Name = "dncGraph1";
            this.dncGraph1.Size = new System.Drawing.Size(690, 406);
            this.dncGraph1.TabIndex = 10;
            this.dncGraph1.OnError += new dnc.common.DncErrorEventHandler(this.dncGraph1_OnError);
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
            dncDaqProperty1.InputTask.Add(this.daqInputTask2);
            dncDaqProperty1.TaskMode = dnc.daq.DaqTaskMode.AdvancedMode;
            dncDaqProperty1.Timing.Add(this.daqTiming1);
            this.dncDaq1.DaqProperty = dncDaqProperty1;
            this.dncDaq1.DncName = "dncDaq1";
            this.dncDaq1.OnError += new dnc.common.DncDaqErrorEventHandler(this.dncDaq1_OnError);
            this.dncDaq1.OnAioContinuousModeStart += new dnc.daq.AioContinuousModeStartEventHandler(this.dncDaq1_OnAioContinuousModeStart);
            this.dncDaq1.OnAioContinuousModeStop += new dnc.daq.AioContinuousModeStopEventHandler(this.dncDaq1_OnAioContinuousModeStop);
            this.dncDaq1.OnInit += new System.EventHandler(this.dncDaq1_OnInit);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(753, 396);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(117, 25);
            this.button_Exit.TabIndex = 9;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_WriteFileProperty
            // 
            this.button_WriteFileProperty.Location = new System.Drawing.Point(22, 120);
            this.button_WriteFileProperty.Name = "button_WriteFileProperty";
            this.button_WriteFileProperty.Size = new System.Drawing.Size(117, 25);
            this.button_WriteFileProperty.TabIndex = 4;
            this.button_WriteFileProperty.Text = "DncWriteFile Setting";
            this.button_WriteFileProperty.UseVisualStyleBackColor = true;
            this.button_WriteFileProperty.Click += new System.EventHandler(this.button_WriteFileProperty_Click);
            // 
            // button_GraphProperty
            // 
            this.button_GraphProperty.Location = new System.Drawing.Point(22, 77);
            this.button_GraphProperty.Name = "button_GraphProperty";
            this.button_GraphProperty.Size = new System.Drawing.Size(117, 25);
            this.button_GraphProperty.TabIndex = 3;
            this.button_GraphProperty.Text = "DncGraph Setting";
            this.button_GraphProperty.UseVisualStyleBackColor = true;
            this.button_GraphProperty.Click += new System.EventHandler(this.button_GraphProperty_Click);
            // 
            // groupBox_PropertyWindow
            // 
            this.groupBox_PropertyWindow.Controls.Add(this.button_WriteFileProperty);
            this.groupBox_PropertyWindow.Controls.Add(this.button_GraphProperty);
            this.groupBox_PropertyWindow.Controls.Add(this.button_DaqProperty);
            this.groupBox_PropertyWindow.Location = new System.Drawing.Point(731, 15);
            this.groupBox_PropertyWindow.Name = "groupBox_PropertyWindow";
            this.groupBox_PropertyWindow.Size = new System.Drawing.Size(153, 166);
            this.groupBox_PropertyWindow.TabIndex = 8;
            this.groupBox_PropertyWindow.TabStop = false;
            this.groupBox_PropertyWindow.Text = "Setting Screen Display ";
            // 
            // button_DaqProperty
            // 
            this.button_DaqProperty.Location = new System.Drawing.Point(22, 33);
            this.button_DaqProperty.Name = "button_DaqProperty";
            this.button_DaqProperty.Size = new System.Drawing.Size(117, 25);
            this.button_DaqProperty.TabIndex = 2;
            this.button_DaqProperty.Text = "DncDaq Setting";
            this.button_DaqProperty.UseVisualStyleBackColor = true;
            this.button_DaqProperty.Click += new System.EventHandler(this.button_DaqProperty_Click);
            // 
            // daqInputTask1
            // 
            this.daqInputTask1.AccessType = dnc.daq.DaqInputAccessType.Analog;
            this.daqInputTask1.AccessTypeInputValue = "0-3";
            this.daqInputTask1.DeviceName = "AIO000";
            this.daqInputTask1.InputNo = 0;
            this.daqInputTask1.Target = "dncGraph1";
            this.daqInputTask1.TaskValueByte = null;
            this.daqInputTask1.TaskValueFloat = null;
            this.daqInputTask1.TaskValueInt = null;
            this.daqInputTask1.Timing = "Timing_00";
            // 
            // daqInputTask2
            // 
            this.daqInputTask2.AccessType = dnc.daq.DaqInputAccessType.Analog;
            this.daqInputTask2.AccessTypeInputValue = "0-3";
            this.daqInputTask2.DeviceName = "AIO000";
            this.daqInputTask2.InputNo = 1;
            this.daqInputTask2.Target = "dncWriteFile1";
            this.daqInputTask2.TaskValueByte = null;
            this.daqInputTask2.TaskValueFloat = null;
            this.daqInputTask2.TaskValueInt = null;
            this.daqInputTask2.Timing = "Timing_00";
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
            // ContinuousInput_Graph_WriteFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 662);
            this.Controls.Add(this.groupBox_ActionButton);
            this.Controls.Add(this.groupBox_Status);
            this.Controls.Add(this.dncGraph1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox_PropertyWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContinuousInput_Graph_WriteFile";
            this.Text = "Analog Sampling Sample (Graph, WriteFile Linkage) ";
            this.groupBox_ActionButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StopTrigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_StartTrigger)).EndInit();
            this.groupBox_Status.ResumeLayout(false);
            this.groupBox_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncWriteFile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
            this.groupBox_PropertyWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ActionButton;
        private dnc.button.DncButton dncButton_StopTrigger;
        private dnc.button.DncButton dncButton_StartTrigger;
        private System.Windows.Forms.TextBox textBox_SamplingError;
        private System.Windows.Forms.TextBox textBox_SamplingStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_ErrorDetail;
        private System.Windows.Forms.Label label_ErrorDetail;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private dnc.writefile.DncWriteFile dncWriteFile1;
        private dnc.graph.DncGraph dncGraph1;
        private dnc.graph.collection.GraphLine graphLine1;
        private dnc.graph.collection.GraphLine graphLine2;
        private dnc.graph.collection.GraphLine graphLine3;
        private dnc.graph.collection.GraphLine graphLine4;
        private dnc.daq.DncDaq dncDaq1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_WriteFileProperty;
        private System.Windows.Forms.Button button_GraphProperty;
        private System.Windows.Forms.GroupBox groupBox_PropertyWindow;
        private System.Windows.Forms.Button button_DaqProperty;
        private dnc.daq.task.DaqDevice daqDevice1;
        private dnc.daq.task.DaqSampling daqSampling1;
        private dnc.daq.task.DaqInputTask daqInputTask1;
        private dnc.daq.task.DaqInputTask daqInputTask2;
        private dnc.daq.task.DaqTiming daqTiming1;
    }
}


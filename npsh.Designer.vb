<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPLCData
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        'This call is required by the Windows Form Designer.
        IsInitializing = True
        InitializeComponent()
        IsInitializing = False
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents RadioButtonAbsolute As System.Windows.Forms.RadioButton
	Public WithEvents RadioButtonGauge As System.Windows.Forms.RadioButton
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents txtConstantFlow As System.Windows.Forms.TextBox
	Public WithEvents chkConstantFlow As System.Windows.Forms.CheckBox
	Public WithEvents cmdCalibrate As System.Windows.Forms.Button
	Public WithEvents txtComment As System.Windows.Forms.TextBox
	Public WithEvents txtValvePositionDisplay As System.Windows.Forms.TextBox
	Public WithEvents txtValvePosition As System.Windows.Forms.TextBox
	Public WithEvents txtDeltaSuctionPressure As System.Windows.Forms.TextBox
	Public WithEvents txtNPSHa97 As System.Windows.Forms.TextBox
	Public WithEvents txtTDH97 As System.Windows.Forms.TextBox
	Public WithEvents txtDischGaugeHeight As System.Windows.Forms.TextBox
	Public WithEvents txtNPSHa As System.Windows.Forms.TextBox
	Public WithEvents txtTDH As System.Windows.Forms.TextBox
	Public WithEvents txtInHgDisplay As System.Windows.Forms.TextBox
	Public WithEvents txtInHg As System.Windows.Forms.TextBox
	Public WithEvents txtFlowForCalcs As System.Windows.Forms.TextBox
	Public WithEvents txtPctHead As System.Windows.Forms.TextBox
	Public WithEvents txtAveTDH As System.Windows.Forms.TextBox
	Public WithEvents txtVapPress As System.Windows.Forms.TextBox
	Public WithEvents txtSpVol As System.Windows.Forms.TextBox
	Public WithEvents txtDischVelHead As System.Windows.Forms.TextBox
	Public WithEvents txtSuctVelHead As System.Windows.Forms.TextBox
	Public WithEvents txtSuctGaugeHeight As System.Windows.Forms.TextBox
	Public WithEvents cmdStartTest As System.Windows.Forms.Button
	Public WithEvents cmbDisch As System.Windows.Forms.ComboBox
	Public WithEvents cmbSuction As System.Windows.Forms.ComboBox
	Public WithEvents rtbDataOut As System.Windows.Forms.TextBox
    '	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public WithEvents txtFileName As System.Windows.Forms.TextBox
	Public WithEvents cmdSaveData As System.Windows.Forms.Button
	Public WithEvents txtTC4 As System.Windows.Forms.TextBox
	Public WithEvents txtTC3 As System.Windows.Forms.TextBox
	Public WithEvents txtTC2 As System.Windows.Forms.TextBox
	Public WithEvents txtTC1 As System.Windows.Forms.TextBox
	Public WithEvents txtTC1Display As System.Windows.Forms.TextBox
	Public WithEvents txtTC2Display As System.Windows.Forms.TextBox
	Public WithEvents txtTC3Display As System.Windows.Forms.TextBox
	Public WithEvents txtTC4Display As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents txtFlow As System.Windows.Forms.TextBox
	Public WithEvents txtSuction As System.Windows.Forms.TextBox
	Public WithEvents txtDischarge As System.Windows.Forms.TextBox
	Public WithEvents txtTemperature As System.Windows.Forms.TextBox
	Public WithEvents txtSuctionDisplay As System.Windows.Forms.TextBox
	Public WithEvents txtDischargeDisplay As System.Windows.Forms.TextBox
	Public WithEvents txtFlowDisplay As System.Windows.Forms.TextBox
	Public WithEvents txtTemperatureDisplay As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtAI1 As System.Windows.Forms.TextBox
    Public WithEvents txtAI2 As System.Windows.Forms.TextBox
    Public WithEvents txtAI3 As System.Windows.Forms.TextBox
    Public WithEvents txtAI4 As System.Windows.Forms.TextBox
    Public WithEvents txtAI4Display As System.Windows.Forms.TextBox
    Public WithEvents txtAI3Display As System.Windows.Forms.TextBox
    Public WithEvents txtAI2Display As System.Windows.Forms.TextBox
    Public WithEvents txtAI1Display As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cmbPLCLoop As System.Windows.Forms.ComboBox
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents txtSN As System.Windows.Forms.TextBox
    Public WithEvents tmrStartUp As System.Windows.Forms.Timer
    Public WithEvents txtUpdateInterval As System.Windows.Forms.TextBox
    Public WithEvents tmrGetDDE As System.Windows.Forms.Timer
    Public WithEvents lblConstantFlow As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label56 As System.Windows.Forms.Label
    Public WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents Label54 As System.Windows.Forms.Label
    Public WithEvents lblVersion As System.Windows.Forms.Label
    Public WithEvents Label52 As System.Windows.Forms.Label
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents Label47 As System.Windows.Forms.Label
    Public WithEvents Label46 As System.Windows.Forms.Label
    Public WithEvents Label45 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label42 As System.Windows.Forms.Label
    Public WithEvents Label41 As System.Windows.Forms.Label
    Public WithEvents Label40 As System.Windows.Forms.Label
    Public WithEvents Label39 As System.Windows.Forms.Label
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    'Public WithEvents optDischargePressure As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpGetPLCData = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonAbsolute = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGauge = New System.Windows.Forms.RadioButton()
        Me.txtConstantFlow = New System.Windows.Forms.TextBox()
        Me.chkConstantFlow = New System.Windows.Forms.CheckBox()
        Me.cmdCalibrate = New System.Windows.Forms.Button()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.txtValvePositionDisplay = New System.Windows.Forms.TextBox()
        Me.txtValvePosition = New System.Windows.Forms.TextBox()
        Me.txtDeltaSuctionPressure = New System.Windows.Forms.TextBox()
        Me.txtNPSHa97 = New System.Windows.Forms.TextBox()
        Me.txtTDH97 = New System.Windows.Forms.TextBox()
        Me.txtDischGaugeHeight = New System.Windows.Forms.TextBox()
        Me.txtNPSHa = New System.Windows.Forms.TextBox()
        Me.txtTDH = New System.Windows.Forms.TextBox()
        Me.txtInHgDisplay = New System.Windows.Forms.TextBox()
        Me.txtInHg = New System.Windows.Forms.TextBox()
        Me.txtFlowForCalcs = New System.Windows.Forms.TextBox()
        Me.txtPctHead = New System.Windows.Forms.TextBox()
        Me.txtAveTDH = New System.Windows.Forms.TextBox()
        Me.txtVapPress = New System.Windows.Forms.TextBox()
        Me.txtSpVol = New System.Windows.Forms.TextBox()
        Me.txtDischVelHead = New System.Windows.Forms.TextBox()
        Me.txtSuctVelHead = New System.Windows.Forms.TextBox()
        Me.txtSuctGaugeHeight = New System.Windows.Forms.TextBox()
        Me.cmdStartTest = New System.Windows.Forms.Button()
        Me.cmbDisch = New System.Windows.Forms.ComboBox()
        Me.cmbSuction = New System.Windows.Forms.ComboBox()
        Me.rtbDataOut = New System.Windows.Forms.TextBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.cmdSaveData = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtTC4 = New System.Windows.Forms.TextBox()
        Me.txtTC3 = New System.Windows.Forms.TextBox()
        Me.txtTC2 = New System.Windows.Forms.TextBox()
        Me.txtTC1 = New System.Windows.Forms.TextBox()
        Me.txtTC1Display = New System.Windows.Forms.TextBox()
        Me.txtTC2Display = New System.Windows.Forms.TextBox()
        Me.txtTC3Display = New System.Windows.Forms.TextBox()
        Me.txtTC4Display = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldatarow = New System.Windows.Forms.Label()
        Me.lblInputData = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtFlow = New System.Windows.Forms.TextBox()
        Me.txtSuction = New System.Windows.Forms.TextBox()
        Me.txtDischarge = New System.Windows.Forms.TextBox()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.txtSuctionDisplay = New System.Windows.Forms.TextBox()
        Me.txtDischargeDisplay = New System.Windows.Forms.TextBox()
        Me.txtFlowDisplay = New System.Windows.Forms.TextBox()
        Me.txtTemperatureDisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtAI1 = New System.Windows.Forms.TextBox()
        Me.txtAI2 = New System.Windows.Forms.TextBox()
        Me.txtAI3 = New System.Windows.Forms.TextBox()
        Me.txtAI4 = New System.Windows.Forms.TextBox()
        Me.txtAI4Display = New System.Windows.Forms.TextBox()
        Me.txtAI3Display = New System.Windows.Forms.TextBox()
        Me.txtAI2Display = New System.Windows.Forms.TextBox()
        Me.txtAI1Display = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbPLCLoop = New System.Windows.Forms.ComboBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.tmrStartUp = New System.Windows.Forms.Timer(Me.components)
        Me.txtUpdateInterval = New System.Windows.Forms.TextBox()
        Me.tmrGetDDE = New System.Windows.Forms.Timer(Me.components)
        Me.lblConstantFlow = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblListBox = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRPM = New System.Windows.Forms.Label()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.lblMounting = New System.Windows.Forms.Label()
        Me.lblCircPath = New System.Windows.Forms.Label()
        Me.lblImpDia = New System.Windows.Forms.Label()
        Me.lblNPSHa = New System.Windows.Forms.Label()
        Me.lblNPSHr = New System.Windows.Forms.Label()
        Me.lblDesignFlow = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.lblSalesOrder = New System.Windows.Forms.Label()
        Me.lblModelNumber = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.lblDesignTDH = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Frame4.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 15)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpGetPLCData})
        Me.ShapeContainer1.Size = New System.Drawing.Size(449, 58)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'shpGetPLCData
        '
        Me.shpGetPLCData.BackColor = System.Drawing.SystemColors.Window
        Me.shpGetPLCData.BorderColor = System.Drawing.SystemColors.WindowText
        Me.shpGetPLCData.FillColor = System.Drawing.Color.Green
        Me.shpGetPLCData.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpGetPLCData.Location = New System.Drawing.Point(8, 3)
        Me.shpGetPLCData.Name = "shpGetPLCData"
        Me.shpGetPLCData.Size = New System.Drawing.Size(17, 17)
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.RadioButtonAbsolute)
        Me.Frame4.Controls.Add(Me.RadioButtonGauge)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(316, 130)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(201, 47)
        Me.Frame4.TabIndex = 111
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Input Discharge Pressure"
        Me.Frame4.Visible = False
        '
        'RadioButtonAbsolute
        '
        Me.RadioButtonAbsolute.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonAbsolute.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadioButtonAbsolute.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAbsolute.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButtonAbsolute.Location = New System.Drawing.Point(104, 16)
        Me.RadioButtonAbsolute.Name = "RadioButtonAbsolute"
        Me.RadioButtonAbsolute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButtonAbsolute.Size = New System.Drawing.Size(90, 18)
        Me.RadioButtonAbsolute.TabIndex = 113
        Me.RadioButtonAbsolute.TabStop = True
        Me.RadioButtonAbsolute.Text = "Absolute"
        Me.RadioButtonAbsolute.UseVisualStyleBackColor = False
        '
        'RadioButtonGauge
        '
        Me.RadioButtonGauge.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonGauge.Checked = True
        Me.RadioButtonGauge.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadioButtonGauge.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonGauge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButtonGauge.Location = New System.Drawing.Point(16, 16)
        Me.RadioButtonGauge.Name = "RadioButtonGauge"
        Me.RadioButtonGauge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButtonGauge.Size = New System.Drawing.Size(73, 22)
        Me.RadioButtonGauge.TabIndex = 112
        Me.RadioButtonGauge.TabStop = True
        Me.RadioButtonGauge.Text = "Gauge"
        Me.RadioButtonGauge.UseVisualStyleBackColor = False
        '
        'txtConstantFlow
        '
        Me.txtConstantFlow.AcceptsReturn = True
        Me.txtConstantFlow.BackColor = System.Drawing.SystemColors.Window
        Me.txtConstantFlow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConstantFlow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConstantFlow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConstantFlow.Location = New System.Drawing.Point(377, 104)
        Me.txtConstantFlow.MaxLength = 0
        Me.txtConstantFlow.Name = "txtConstantFlow"
        Me.txtConstantFlow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConstantFlow.Size = New System.Drawing.Size(57, 20)
        Me.txtConstantFlow.TabIndex = 109
        Me.txtConstantFlow.Visible = False
        '
        'chkConstantFlow
        '
        Me.chkConstantFlow.BackColor = System.Drawing.SystemColors.Control
        Me.chkConstantFlow.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkConstantFlow.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConstantFlow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkConstantFlow.Location = New System.Drawing.Point(352, 79)
        Me.chkConstantFlow.Name = "chkConstantFlow"
        Me.chkConstantFlow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkConstantFlow.Size = New System.Drawing.Size(145, 30)
        Me.chkConstantFlow.TabIndex = 108
        Me.chkConstantFlow.Text = "Constant Flow"
        Me.chkConstantFlow.UseVisualStyleBackColor = False
        '
        'cmdCalibrate
        '
        Me.cmdCalibrate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalibrate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalibrate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalibrate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalibrate.Location = New System.Drawing.Point(828, 2)
        Me.cmdCalibrate.Name = "cmdCalibrate"
        Me.cmdCalibrate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalibrate.Size = New System.Drawing.Size(81, 33)
        Me.cmdCalibrate.TabIndex = 107
        Me.cmdCalibrate.Text = "Calibrate Software"
        Me.cmdCalibrate.UseVisualStyleBackColor = False
        Me.cmdCalibrate.Visible = False
        '
        'txtComment
        '
        Me.txtComment.AcceptsReturn = True
        Me.txtComment.BackColor = System.Drawing.SystemColors.Window
        Me.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComment.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtComment.Location = New System.Drawing.Point(520, 104)
        Me.txtComment.MaxLength = 0
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtComment.Size = New System.Drawing.Size(393, 73)
        Me.txtComment.TabIndex = 105
        '
        'txtValvePositionDisplay
        '
        Me.txtValvePositionDisplay.AcceptsReturn = True
        Me.txtValvePositionDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.txtValvePositionDisplay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValvePositionDisplay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValvePositionDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtValvePositionDisplay.Location = New System.Drawing.Point(920, 277)
        Me.txtValvePositionDisplay.MaxLength = 0
        Me.txtValvePositionDisplay.Name = "txtValvePositionDisplay"
        Me.txtValvePositionDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtValvePositionDisplay.Size = New System.Drawing.Size(49, 20)
        Me.txtValvePositionDisplay.TabIndex = 104
        '
        'txtValvePosition
        '
        Me.txtValvePosition.AcceptsReturn = True
        Me.txtValvePosition.BackColor = System.Drawing.SystemColors.Window
        Me.txtValvePosition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValvePosition.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValvePosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtValvePosition.Location = New System.Drawing.Point(976, 277)
        Me.txtValvePosition.MaxLength = 0
        Me.txtValvePosition.Name = "txtValvePosition"
        Me.txtValvePosition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtValvePosition.Size = New System.Drawing.Size(63, 20)
        Me.txtValvePosition.TabIndex = 102
        Me.txtValvePosition.Text = "Text1"
        Me.txtValvePosition.Visible = False
        '
        'txtDeltaSuctionPressure
        '
        Me.txtDeltaSuctionPressure.AcceptsReturn = True
        Me.txtDeltaSuctionPressure.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeltaSuctionPressure.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeltaSuctionPressure.Font = New System.Drawing.Font("Arial", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeltaSuctionPressure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeltaSuctionPressure.Location = New System.Drawing.Point(352, 692)
        Me.txtDeltaSuctionPressure.MaxLength = 0
        Me.txtDeltaSuctionPressure.Name = "txtDeltaSuctionPressure"
        Me.txtDeltaSuctionPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeltaSuctionPressure.Size = New System.Drawing.Size(145, 51)
        Me.txtDeltaSuctionPressure.TabIndex = 100
        Me.txtDeltaSuctionPressure.Text = "Text1"
        Me.txtDeltaSuctionPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNPSHa97
        '
        Me.txtNPSHa97.AcceptsReturn = True
        Me.txtNPSHa97.BackColor = System.Drawing.SystemColors.Window
        Me.txtNPSHa97.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNPSHa97.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPSHa97.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNPSHa97.Location = New System.Drawing.Point(192, 692)
        Me.txtNPSHa97.MaxLength = 0
        Me.txtNPSHa97.Name = "txtNPSHa97"
        Me.txtNPSHa97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNPSHa97.Size = New System.Drawing.Size(145, 63)
        Me.txtNPSHa97.TabIndex = 97
        Me.txtNPSHa97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTDH97
        '
        Me.txtTDH97.AcceptsReturn = True
        Me.txtTDH97.BackColor = System.Drawing.SystemColors.Window
        Me.txtTDH97.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTDH97.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDH97.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTDH97.Location = New System.Drawing.Point(16, 692)
        Me.txtTDH97.MaxLength = 0
        Me.txtTDH97.Name = "txtTDH97"
        Me.txtTDH97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTDH97.Size = New System.Drawing.Size(145, 63)
        Me.txtTDH97.TabIndex = 96
        Me.txtTDH97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDischGaugeHeight
        '
        Me.txtDischGaugeHeight.AcceptsReturn = True
        Me.txtDischGaugeHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtDischGaugeHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDischGaugeHeight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDischGaugeHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDischGaugeHeight.Location = New System.Drawing.Point(264, 125)
        Me.txtDischGaugeHeight.MaxLength = 0
        Me.txtDischGaugeHeight.Name = "txtDischGaugeHeight"
        Me.txtDischGaugeHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDischGaugeHeight.Size = New System.Drawing.Size(33, 20)
        Me.txtDischGaugeHeight.TabIndex = 91
        Me.txtDischGaugeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNPSHa
        '
        Me.txtNPSHa.AcceptsReturn = True
        Me.txtNPSHa.BackColor = System.Drawing.SystemColors.Window
        Me.txtNPSHa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNPSHa.Enabled = False
        Me.txtNPSHa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPSHa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNPSHa.Location = New System.Drawing.Point(545, 221)
        Me.txtNPSHa.MaxLength = 0
        Me.txtNPSHa.Name = "txtNPSHa"
        Me.txtNPSHa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNPSHa.Size = New System.Drawing.Size(49, 20)
        Me.txtNPSHa.TabIndex = 82
        Me.txtNPSHa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDH
        '
        Me.txtTDH.AcceptsReturn = True
        Me.txtTDH.BackColor = System.Drawing.SystemColors.Window
        Me.txtTDH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTDH.Enabled = False
        Me.txtTDH.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTDH.Location = New System.Drawing.Point(656, 216)
        Me.txtTDH.MaxLength = 0
        Me.txtTDH.Name = "txtTDH"
        Me.txtTDH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTDH.Size = New System.Drawing.Size(49, 20)
        Me.txtTDH.TabIndex = 81
        Me.txtTDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInHgDisplay
        '
        Me.txtInHgDisplay.AcceptsReturn = True
        Me.txtInHgDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.txtInHgDisplay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInHgDisplay.Enabled = False
        Me.txtInHgDisplay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInHgDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInHgDisplay.Location = New System.Drawing.Point(545, 285)
        Me.txtInHgDisplay.MaxLength = 0
        Me.txtInHgDisplay.Name = "txtInHgDisplay"
        Me.txtInHgDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInHgDisplay.Size = New System.Drawing.Size(49, 20)
        Me.txtInHgDisplay.TabIndex = 80
        Me.txtInHgDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInHg
        '
        Me.txtInHg.AcceptsReturn = True
        Me.txtInHg.BackColor = System.Drawing.SystemColors.Window
        Me.txtInHg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInHg.Enabled = False
        Me.txtInHg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInHg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInHg.Location = New System.Drawing.Point(488, 240)
        Me.txtInHg.MaxLength = 0
        Me.txtInHg.Name = "txtInHg"
        Me.txtInHg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInHg.Size = New System.Drawing.Size(17, 20)
        Me.txtInHg.TabIndex = 78
        Me.txtInHg.Visible = False
        '
        'txtFlowForCalcs
        '
        Me.txtFlowForCalcs.AcceptsReturn = True
        Me.txtFlowForCalcs.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlowForCalcs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlowForCalcs.Enabled = False
        Me.txtFlowForCalcs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlowForCalcs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlowForCalcs.Location = New System.Drawing.Point(545, 253)
        Me.txtFlowForCalcs.MaxLength = 0
        Me.txtFlowForCalcs.Name = "txtFlowForCalcs"
        Me.txtFlowForCalcs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlowForCalcs.Size = New System.Drawing.Size(49, 20)
        Me.txtFlowForCalcs.TabIndex = 76
        Me.txtFlowForCalcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPctHead
        '
        Me.txtPctHead.AcceptsReturn = True
        Me.txtPctHead.BackColor = System.Drawing.SystemColors.Window
        Me.txtPctHead.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPctHead.Enabled = False
        Me.txtPctHead.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPctHead.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPctHead.Location = New System.Drawing.Point(656, 280)
        Me.txtPctHead.MaxLength = 0
        Me.txtPctHead.Name = "txtPctHead"
        Me.txtPctHead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPctHead.Size = New System.Drawing.Size(49, 20)
        Me.txtPctHead.TabIndex = 73
        Me.txtPctHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAveTDH
        '
        Me.txtAveTDH.AcceptsReturn = True
        Me.txtAveTDH.BackColor = System.Drawing.SystemColors.Window
        Me.txtAveTDH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAveTDH.Enabled = False
        Me.txtAveTDH.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAveTDH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAveTDH.Location = New System.Drawing.Point(656, 248)
        Me.txtAveTDH.MaxLength = 0
        Me.txtAveTDH.Name = "txtAveTDH"
        Me.txtAveTDH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAveTDH.Size = New System.Drawing.Size(49, 20)
        Me.txtAveTDH.TabIndex = 72
        Me.txtAveTDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVapPress
        '
        Me.txtVapPress.AcceptsReturn = True
        Me.txtVapPress.BackColor = System.Drawing.SystemColors.Window
        Me.txtVapPress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVapPress.Enabled = False
        Me.txtVapPress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVapPress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVapPress.Location = New System.Drawing.Point(920, 253)
        Me.txtVapPress.MaxLength = 0
        Me.txtVapPress.Name = "txtVapPress"
        Me.txtVapPress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVapPress.Size = New System.Drawing.Size(49, 20)
        Me.txtVapPress.TabIndex = 68
        '
        'txtSpVol
        '
        Me.txtSpVol.AcceptsReturn = True
        Me.txtSpVol.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpVol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpVol.Enabled = False
        Me.txtSpVol.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpVol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpVol.Location = New System.Drawing.Point(920, 221)
        Me.txtSpVol.MaxLength = 0
        Me.txtSpVol.Name = "txtSpVol"
        Me.txtSpVol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpVol.Size = New System.Drawing.Size(49, 20)
        Me.txtSpVol.TabIndex = 66
        '
        'txtDischVelHead
        '
        Me.txtDischVelHead.AcceptsReturn = True
        Me.txtDischVelHead.BackColor = System.Drawing.SystemColors.Window
        Me.txtDischVelHead.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDischVelHead.Enabled = False
        Me.txtDischVelHead.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDischVelHead.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDischVelHead.Location = New System.Drawing.Point(789, 253)
        Me.txtDischVelHead.MaxLength = 0
        Me.txtDischVelHead.Name = "txtDischVelHead"
        Me.txtDischVelHead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDischVelHead.Size = New System.Drawing.Size(41, 20)
        Me.txtDischVelHead.TabIndex = 64
        Me.txtDischVelHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSuctVelHead
        '
        Me.txtSuctVelHead.AcceptsReturn = True
        Me.txtSuctVelHead.BackColor = System.Drawing.SystemColors.Window
        Me.txtSuctVelHead.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuctVelHead.Enabled = False
        Me.txtSuctVelHead.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuctVelHead.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSuctVelHead.Location = New System.Drawing.Point(789, 221)
        Me.txtSuctVelHead.MaxLength = 0
        Me.txtSuctVelHead.Name = "txtSuctVelHead"
        Me.txtSuctVelHead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSuctVelHead.Size = New System.Drawing.Size(41, 20)
        Me.txtSuctVelHead.TabIndex = 63
        Me.txtSuctVelHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSuctGaugeHeight
        '
        Me.txtSuctGaugeHeight.AcceptsReturn = True
        Me.txtSuctGaugeHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtSuctGaugeHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuctGaugeHeight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuctGaugeHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSuctGaugeHeight.Location = New System.Drawing.Point(264, 104)
        Me.txtSuctGaugeHeight.MaxLength = 0
        Me.txtSuctGaugeHeight.Name = "txtSuctGaugeHeight"
        Me.txtSuctGaugeHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSuctGaugeHeight.Size = New System.Drawing.Size(33, 20)
        Me.txtSuctGaugeHeight.TabIndex = 60
        Me.txtSuctGaugeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdStartTest
        '
        Me.cmdStartTest.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStartTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStartTest.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartTest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStartTest.Location = New System.Drawing.Point(256, 40)
        Me.cmdStartTest.Name = "cmdStartTest"
        Me.cmdStartTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStartTest.Size = New System.Drawing.Size(105, 33)
        Me.cmdStartTest.TabIndex = 59
        Me.cmdStartTest.Text = "Start Test"
        Me.cmdStartTest.UseVisualStyleBackColor = False
        '
        'cmbDisch
        '
        Me.cmbDisch.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDisch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDisch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDisch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDisch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDisch.Location = New System.Drawing.Point(96, 128)
        Me.cmbDisch.Name = "cmbDisch"
        Me.cmbDisch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDisch.Size = New System.Drawing.Size(81, 22)
        Me.cmbDisch.TabIndex = 58
        '
        'cmbSuction
        '
        Me.cmbSuction.BackColor = System.Drawing.Color.White
        Me.cmbSuction.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSuction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuction.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSuction.Location = New System.Drawing.Point(96, 96)
        Me.cmbSuction.Name = "cmbSuction"
        Me.cmbSuction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSuction.Size = New System.Drawing.Size(81, 22)
        Me.cmbSuction.TabIndex = 54
        '
        'rtbDataOut
        '
        Me.rtbDataOut.AcceptsReturn = True
        Me.rtbDataOut.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDataOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rtbDataOut.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDataOut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rtbDataOut.Location = New System.Drawing.Point(8, 418)
        Me.rtbDataOut.MaxLength = 0
        Me.rtbDataOut.Multiline = True
        Me.rtbDataOut.Name = "rtbDataOut"
        Me.rtbDataOut.ReadOnly = True
        Me.rtbDataOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rtbDataOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rtbDataOut.Size = New System.Drawing.Size(644, 121)
        Me.rtbDataOut.TabIndex = 48
        '
        'txtFileName
        '
        Me.txtFileName.AcceptsReturn = True
        Me.txtFileName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFileName.Location = New System.Drawing.Point(8, 606)
        Me.txtFileName.MaxLength = 0
        Me.txtFileName.Multiline = True
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFileName.Size = New System.Drawing.Size(433, 36)
        Me.txtFileName.TabIndex = 46
        Me.txtFileName.Text = "No File Open" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdSaveData
        '
        Me.cmdSaveData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSaveData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSaveData.Location = New System.Drawing.Point(187, 567)
        Me.cmdSaveData.Name = "cmdSaveData"
        Me.cmdSaveData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSaveData.Size = New System.Drawing.Size(97, 33)
        Me.cmdSaveData.TabIndex = 45
        Me.cmdSaveData.Text = "Save Data"
        Me.cmdSaveData.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtTC4)
        Me.Frame2.Controls.Add(Me.txtTC3)
        Me.Frame2.Controls.Add(Me.txtTC2)
        Me.Frame2.Controls.Add(Me.txtTC1)
        Me.Frame2.Controls.Add(Me.txtTC1Display)
        Me.Frame2.Controls.Add(Me.txtTC2Display)
        Me.Frame2.Controls.Add(Me.txtTC3Display)
        Me.Frame2.Controls.Add(Me.txtTC4Display)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 248)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(449, 57)
        Me.Frame2.TabIndex = 31
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Thermocouples"
        '
        'txtTC4
        '
        Me.txtTC4.AcceptsReturn = True
        Me.txtTC4.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC4.Location = New System.Drawing.Point(328, 32)
        Me.txtTC4.MaxLength = 0
        Me.txtTC4.Name = "txtTC4"
        Me.txtTC4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC4.Size = New System.Drawing.Size(17, 20)
        Me.txtTC4.TabIndex = 39
        Me.txtTC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTC4.Visible = False
        '
        'txtTC3
        '
        Me.txtTC3.AcceptsReturn = True
        Me.txtTC3.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC3.Location = New System.Drawing.Point(224, 32)
        Me.txtTC3.MaxLength = 0
        Me.txtTC3.Name = "txtTC3"
        Me.txtTC3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC3.Size = New System.Drawing.Size(17, 20)
        Me.txtTC3.TabIndex = 38
        Me.txtTC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTC3.Visible = False
        '
        'txtTC2
        '
        Me.txtTC2.AcceptsReturn = True
        Me.txtTC2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC2.Location = New System.Drawing.Point(112, 32)
        Me.txtTC2.MaxLength = 0
        Me.txtTC2.Name = "txtTC2"
        Me.txtTC2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC2.Size = New System.Drawing.Size(17, 20)
        Me.txtTC2.TabIndex = 37
        Me.txtTC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTC2.Visible = False
        '
        'txtTC1
        '
        Me.txtTC1.AcceptsReturn = True
        Me.txtTC1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC1.Location = New System.Drawing.Point(8, 32)
        Me.txtTC1.MaxLength = 0
        Me.txtTC1.Name = "txtTC1"
        Me.txtTC1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC1.Size = New System.Drawing.Size(17, 20)
        Me.txtTC1.TabIndex = 36
        Me.txtTC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTC1.Visible = False
        '
        'txtTC1Display
        '
        Me.txtTC1Display.AcceptsReturn = True
        Me.txtTC1Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC1Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC1Display.Enabled = False
        Me.txtTC1Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC1Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC1Display.Location = New System.Drawing.Point(32, 32)
        Me.txtTC1Display.MaxLength = 0
        Me.txtTC1Display.Name = "txtTC1Display"
        Me.txtTC1Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC1Display.Size = New System.Drawing.Size(73, 20)
        Me.txtTC1Display.TabIndex = 35
        Me.txtTC1Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTC2Display
        '
        Me.txtTC2Display.AcceptsReturn = True
        Me.txtTC2Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC2Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC2Display.Enabled = False
        Me.txtTC2Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC2Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC2Display.Location = New System.Drawing.Point(139, 32)
        Me.txtTC2Display.MaxLength = 0
        Me.txtTC2Display.Name = "txtTC2Display"
        Me.txtTC2Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC2Display.Size = New System.Drawing.Size(73, 20)
        Me.txtTC2Display.TabIndex = 34
        Me.txtTC2Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTC3Display
        '
        Me.txtTC3Display.AcceptsReturn = True
        Me.txtTC3Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC3Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC3Display.Enabled = False
        Me.txtTC3Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC3Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC3Display.Location = New System.Drawing.Point(245, 32)
        Me.txtTC3Display.MaxLength = 0
        Me.txtTC3Display.Name = "txtTC3Display"
        Me.txtTC3Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC3Display.Size = New System.Drawing.Size(73, 20)
        Me.txtTC3Display.TabIndex = 33
        Me.txtTC3Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTC4Display
        '
        Me.txtTC4Display.AcceptsReturn = True
        Me.txtTC4Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtTC4Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTC4Display.Enabled = False
        Me.txtTC4Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC4Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTC4Display.Location = New System.Drawing.Point(352, 32)
        Me.txtTC4Display.MaxLength = 0
        Me.txtTC4Display.Name = "txtTC4Display"
        Me.txtTC4Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTC4Display.Size = New System.Drawing.Size(73, 20)
        Me.txtTC4Display.TabIndex = 32
        Me.txtTC4Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(352, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "4"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(245, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "3"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(139, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(32, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbldatarow
        '
        Me.lbldatarow.AutoSize = True
        Me.lbldatarow.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatarow.ForeColor = System.Drawing.Color.Red
        Me.lbldatarow.Location = New System.Drawing.Point(15, 805)
        Me.lbldatarow.Name = "lbldatarow"
        Me.lbldatarow.Size = New System.Drawing.Size(91, 26)
        Me.lbldatarow.TabIndex = 122
        Me.lbldatarow.Text = "Label50"
        Me.lbldatarow.Visible = False
        '
        'lblInputData
        '
        Me.lblInputData.AutoSize = True
        Me.lblInputData.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputData.ForeColor = System.Drawing.Color.Red
        Me.lblInputData.Location = New System.Drawing.Point(17, 860)
        Me.lblInputData.Name = "lblInputData"
        Me.lblInputData.Size = New System.Drawing.Size(170, 16)
        Me.lblInputData.TabIndex = 121
        Me.lblInputData.Text = "Input Data from Excel File"
        Me.lblInputData.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtFlow)
        Me.Frame1.Controls.Add(Me.txtSuction)
        Me.Frame1.Controls.Add(Me.txtDischarge)
        Me.Frame1.Controls.Add(Me.txtTemperature)
        Me.Frame1.Controls.Add(Me.txtSuctionDisplay)
        Me.Frame1.Controls.Add(Me.txtDischargeDisplay)
        Me.Frame1.Controls.Add(Me.txtFlowDisplay)
        Me.Frame1.Controls.Add(Me.txtTemperatureDisplay)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.ShapeContainer1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 176)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(449, 73)
        Me.Frame1.TabIndex = 18
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Pump Data"
        '
        'txtFlow
        '
        Me.txtFlow.AcceptsReturn = True
        Me.txtFlow.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlow.Location = New System.Drawing.Point(8, 48)
        Me.txtFlow.MaxLength = 0
        Me.txtFlow.Name = "txtFlow"
        Me.txtFlow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlow.Size = New System.Drawing.Size(17, 20)
        Me.txtFlow.TabIndex = 26
        Me.txtFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFlow.Visible = False
        '
        'txtSuction
        '
        Me.txtSuction.AcceptsReturn = True
        Me.txtSuction.BackColor = System.Drawing.SystemColors.Window
        Me.txtSuction.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuction.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSuction.Location = New System.Drawing.Point(120, 48)
        Me.txtSuction.MaxLength = 0
        Me.txtSuction.Name = "txtSuction"
        Me.txtSuction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSuction.Size = New System.Drawing.Size(17, 20)
        Me.txtSuction.TabIndex = 25
        Me.txtSuction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSuction.Visible = False
        '
        'txtDischarge
        '
        Me.txtDischarge.AcceptsReturn = True
        Me.txtDischarge.BackColor = System.Drawing.SystemColors.Window
        Me.txtDischarge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDischarge.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDischarge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDischarge.Location = New System.Drawing.Point(224, 48)
        Me.txtDischarge.MaxLength = 0
        Me.txtDischarge.Name = "txtDischarge"
        Me.txtDischarge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDischarge.Size = New System.Drawing.Size(17, 20)
        Me.txtDischarge.TabIndex = 24
        Me.txtDischarge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDischarge.Visible = False
        '
        'txtTemperature
        '
        Me.txtTemperature.AcceptsReturn = True
        Me.txtTemperature.BackColor = System.Drawing.SystemColors.Window
        Me.txtTemperature.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTemperature.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTemperature.Location = New System.Drawing.Point(328, 48)
        Me.txtTemperature.MaxLength = 0
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTemperature.Size = New System.Drawing.Size(17, 20)
        Me.txtTemperature.TabIndex = 23
        Me.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTemperature.Visible = False
        '
        'txtSuctionDisplay
        '
        Me.txtSuctionDisplay.AcceptsReturn = True
        Me.txtSuctionDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.txtSuctionDisplay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuctionDisplay.Enabled = False
        Me.txtSuctionDisplay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuctionDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSuctionDisplay.Location = New System.Drawing.Point(139, 48)
        Me.txtSuctionDisplay.MaxLength = 0
        Me.txtSuctionDisplay.Name = "txtSuctionDisplay"
        Me.txtSuctionDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSuctionDisplay.Size = New System.Drawing.Size(73, 20)
        Me.txtSuctionDisplay.TabIndex = 22
        Me.txtSuctionDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDischargeDisplay
        '
        Me.txtDischargeDisplay.AcceptsReturn = True
        Me.txtDischargeDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.txtDischargeDisplay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDischargeDisplay.Enabled = False
        Me.txtDischargeDisplay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDischargeDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDischargeDisplay.Location = New System.Drawing.Point(246, 48)
        Me.txtDischargeDisplay.MaxLength = 0
        Me.txtDischargeDisplay.Name = "txtDischargeDisplay"
        Me.txtDischargeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDischargeDisplay.Size = New System.Drawing.Size(73, 20)
        Me.txtDischargeDisplay.TabIndex = 21
        Me.txtDischargeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFlowDisplay
        '
        Me.txtFlowDisplay.AcceptsReturn = True
        Me.txtFlowDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlowDisplay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlowDisplay.Enabled = False
        Me.txtFlowDisplay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlowDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlowDisplay.Location = New System.Drawing.Point(32, 48)
        Me.txtFlowDisplay.MaxLength = 0
        Me.txtFlowDisplay.Name = "txtFlowDisplay"
        Me.txtFlowDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlowDisplay.Size = New System.Drawing.Size(73, 20)
        Me.txtFlowDisplay.TabIndex = 20
        Me.txtFlowDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTemperatureDisplay
        '
        Me.txtTemperatureDisplay.AcceptsReturn = True
        Me.txtTemperatureDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.txtTemperatureDisplay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTemperatureDisplay.Enabled = False
        Me.txtTemperatureDisplay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatureDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTemperatureDisplay.Location = New System.Drawing.Point(352, 48)
        Me.txtTemperatureDisplay.MaxLength = 0
        Me.txtTemperatureDisplay.Name = "txtTemperatureDisplay"
        Me.txtTemperatureDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTemperatureDisplay.Size = New System.Drawing.Size(73, 20)
        Me.txtTemperatureDisplay.TabIndex = 19
        Me.txtTemperatureDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Flow"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(123, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(97, 33)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Suction Pressure (PSIA)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(232, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 33)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = " Disch Pressure (PSIA)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(344, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Temperature"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.txtAI1)
        Me.Frame3.Controls.Add(Me.txtAI2)
        Me.Frame3.Controls.Add(Me.txtAI3)
        Me.Frame3.Controls.Add(Me.txtAI4)
        Me.Frame3.Controls.Add(Me.txtAI4Display)
        Me.Frame3.Controls.Add(Me.txtAI3Display)
        Me.Frame3.Controls.Add(Me.txtAI2Display)
        Me.Frame3.Controls.Add(Me.txtAI1Display)
        Me.Frame3.Controls.Add(Me.Label9)
        Me.Frame3.Controls.Add(Me.Label10)
        Me.Frame3.Controls.Add(Me.Label11)
        Me.Frame3.Controls.Add(Me.Label12)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(8, 304)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(449, 65)
        Me.Frame3.TabIndex = 5
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Analog Inputs"
        '
        'txtAI1
        '
        Me.txtAI1.AcceptsReturn = True
        Me.txtAI1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI1.Location = New System.Drawing.Point(8, 35)
        Me.txtAI1.MaxLength = 0
        Me.txtAI1.Name = "txtAI1"
        Me.txtAI1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI1.Size = New System.Drawing.Size(17, 20)
        Me.txtAI1.TabIndex = 13
        Me.txtAI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAI1.Visible = False
        '
        'txtAI2
        '
        Me.txtAI2.AcceptsReturn = True
        Me.txtAI2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI2.Location = New System.Drawing.Point(112, 35)
        Me.txtAI2.MaxLength = 0
        Me.txtAI2.Name = "txtAI2"
        Me.txtAI2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI2.Size = New System.Drawing.Size(17, 20)
        Me.txtAI2.TabIndex = 12
        Me.txtAI2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAI2.Visible = False
        '
        'txtAI3
        '
        Me.txtAI3.AcceptsReturn = True
        Me.txtAI3.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI3.Location = New System.Drawing.Point(216, 35)
        Me.txtAI3.MaxLength = 0
        Me.txtAI3.Name = "txtAI3"
        Me.txtAI3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI3.Size = New System.Drawing.Size(17, 20)
        Me.txtAI3.TabIndex = 11
        Me.txtAI3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAI3.Visible = False
        '
        'txtAI4
        '
        Me.txtAI4.AcceptsReturn = True
        Me.txtAI4.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI4.Location = New System.Drawing.Point(328, 35)
        Me.txtAI4.MaxLength = 0
        Me.txtAI4.Name = "txtAI4"
        Me.txtAI4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI4.Size = New System.Drawing.Size(17, 20)
        Me.txtAI4.TabIndex = 10
        Me.txtAI4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAI4.Visible = False
        '
        'txtAI4Display
        '
        Me.txtAI4Display.AcceptsReturn = True
        Me.txtAI4Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI4Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI4Display.Enabled = False
        Me.txtAI4Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI4Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI4Display.Location = New System.Drawing.Point(352, 35)
        Me.txtAI4Display.MaxLength = 0
        Me.txtAI4Display.Name = "txtAI4Display"
        Me.txtAI4Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI4Display.Size = New System.Drawing.Size(73, 20)
        Me.txtAI4Display.TabIndex = 9
        Me.txtAI4Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAI3Display
        '
        Me.txtAI3Display.AcceptsReturn = True
        Me.txtAI3Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI3Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI3Display.Enabled = False
        Me.txtAI3Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI3Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI3Display.Location = New System.Drawing.Point(245, 35)
        Me.txtAI3Display.MaxLength = 0
        Me.txtAI3Display.Name = "txtAI3Display"
        Me.txtAI3Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI3Display.Size = New System.Drawing.Size(73, 20)
        Me.txtAI3Display.TabIndex = 8
        Me.txtAI3Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAI2Display
        '
        Me.txtAI2Display.AcceptsReturn = True
        Me.txtAI2Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI2Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI2Display.Enabled = False
        Me.txtAI2Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI2Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI2Display.Location = New System.Drawing.Point(139, 35)
        Me.txtAI2Display.MaxLength = 0
        Me.txtAI2Display.Name = "txtAI2Display"
        Me.txtAI2Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI2Display.Size = New System.Drawing.Size(73, 20)
        Me.txtAI2Display.TabIndex = 7
        Me.txtAI2Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAI1Display
        '
        Me.txtAI1Display.AcceptsReturn = True
        Me.txtAI1Display.BackColor = System.Drawing.SystemColors.Window
        Me.txtAI1Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAI1Display.Enabled = False
        Me.txtAI1Display.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAI1Display.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAI1Display.Location = New System.Drawing.Point(32, 35)
        Me.txtAI1Display.MaxLength = 0
        Me.txtAI1Display.Name = "txtAI1Display"
        Me.txtAI1Display.ReadOnly = True
        Me.txtAI1Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAI1Display.Size = New System.Drawing.Size(73, 20)
        Me.txtAI1Display.TabIndex = 6
        Me.txtAI1Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(32, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(136, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(245, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "3"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(352, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "4"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbPLCLoop
        '
        Me.cmbPLCLoop.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPLCLoop.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPLCLoop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPLCLoop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPLCLoop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPLCLoop.Location = New System.Drawing.Point(120, 40)
        Me.cmbPLCLoop.Name = "cmbPLCLoop"
        Me.cmbPLCLoop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPLCLoop.Size = New System.Drawing.Size(105, 22)
        Me.cmbPLCLoop.TabIndex = 4
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(472, 40)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(81, 25)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'txtSN
        '
        Me.txtSN.AcceptsReturn = True
        Me.txtSN.BackColor = System.Drawing.SystemColors.Window
        Me.txtSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSN.Location = New System.Drawing.Point(120, 8)
        Me.txtSN.MaxLength = 0
        Me.txtSN.Name = "txtSN"
        Me.txtSN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSN.Size = New System.Drawing.Size(105, 20)
        Me.txtSN.TabIndex = 1
        '
        'tmrStartUp
        '
        Me.tmrStartUp.Interval = 1000
        '
        'txtUpdateInterval
        '
        Me.txtUpdateInterval.AcceptsReturn = True
        Me.txtUpdateInterval.BackColor = System.Drawing.SystemColors.Window
        Me.txtUpdateInterval.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUpdateInterval.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateInterval.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUpdateInterval.Location = New System.Drawing.Point(680, 0)
        Me.txtUpdateInterval.MaxLength = 0
        Me.txtUpdateInterval.Name = "txtUpdateInterval"
        Me.txtUpdateInterval.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUpdateInterval.Size = New System.Drawing.Size(41, 20)
        Me.txtUpdateInterval.TabIndex = 0
        Me.txtUpdateInterval.Text = "Text1"
        Me.txtUpdateInterval.Visible = False
        '
        'tmrGetDDE
        '
        Me.tmrGetDDE.Enabled = True
        Me.tmrGetDDE.Interval = 1000
        '
        'lblConstantFlow
        '
        Me.lblConstantFlow.BackColor = System.Drawing.SystemColors.Control
        Me.lblConstantFlow.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblConstantFlow.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConstantFlow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConstantFlow.Location = New System.Drawing.Point(431, 108)
        Me.lblConstantFlow.Name = "lblConstantFlow"
        Me.lblConstantFlow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblConstantFlow.Size = New System.Drawing.Size(57, 17)
        Me.lblConstantFlow.TabIndex = 110
        Me.lblConstantFlow.Text = "GPM"
        Me.lblConstantFlow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(520, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(97, 17)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Comments"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(822, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(92, 36)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Valve Position"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.SystemColors.Control
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Location = New System.Drawing.Point(345, 656)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(169, 33)
        Me.Label56.TabIndex = 101
        Me.Label56.Text = " Delta Suction Pressure psi / second"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.Control
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(192, 652)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(125, 37)
        Me.Label55.TabIndex = 99
        Me.Label55.Text = "NPSHa"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.Control
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Location = New System.Drawing.Point(13, 652)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(132, 33)
        Me.Label54.TabIndex = 98
        Me.Label54.Text = "TDH (%)"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
        Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVersion.Location = New System.Drawing.Point(602, 48)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVersion.Size = New System.Drawing.Size(367, 25)
        Me.lblVersion.TabIndex = 95
        Me.lblVersion.Text = "Version 1.5"
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.Location = New System.Drawing.Point(200, 104)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(57, 17)
        Me.Label52.TabIndex = 94
        Me.Label52.Text = "Suction"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(187, 128)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(74, 20)
        Me.Label32.TabIndex = 93
        Me.Label32.Text = "Discharge"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(297, 122)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(13, 24)
        Me.Label31.TabIndex = 92
        Me.Label31.Text = """"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(248, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(449, 25)
        Me.Label25.TabIndex = 90
        Me.Label25.Text = "NPSH Test Data Acquisition and Collection"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(540, 385)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(61, 11)
        Me.Label49.TabIndex = 89
        Me.Label49.Text = " % Head "
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(324, 396)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(33, 11)
        Me.Label48.TabIndex = 88
        Me.Label48.Text = "Suct"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(382, 396)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(33, 11)
        Me.Label47.TabIndex = 87
        Me.Label47.Text = "Disc"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.SystemColors.Control
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label46.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label46.Location = New System.Drawing.Point(445, 385)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label46.Size = New System.Drawing.Size(26, 11)
        Me.Label46.TabIndex = 86
        Me.Label46.Text = "TDH"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(489, 385)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(40, 11)
        Me.Label45.TabIndex = 85
        Me.Label45.Text = "NPSHa"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(489, 222)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(49, 17)
        Me.Label35.TabIndex = 84
        Me.Label35.Text = "NPSHa"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(603, 217)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(49, 17)
        Me.Label38.TabIndex = 83
        Me.Label38.Text = "TDH"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.Control
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(505, 286)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(48, 19)
        Me.Label44.TabIndex = 79
        Me.Label44.Text = "In Hg"
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(505, 254)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(48, 22)
        Me.Label43.TabIndex = 77
        Me.Label43.Text = "Flow"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.Control
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label42.Location = New System.Drawing.Point(603, 275)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(49, 33)
        Me.Label42.TabIndex = 75
        Me.Label42.Text = "% Head"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.Control
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(602, 244)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(50, 32)
        Me.Label41.TabIndex = 74
        Me.Label41.Text = "Ave TDH"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.Control
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(726, 224)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(57, 17)
        Me.Label40.TabIndex = 71
        Me.Label40.Text = "Suction"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(711, 256)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(78, 20)
        Me.Label39.TabIndex = 70
        Me.Label39.Text = "Discharge"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(858, 247)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(64, 33)
        Me.Label37.TabIndex = 69
        Me.Label37.Text = "Vap Press"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(864, 218)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(50, 34)
        Me.Label36.TabIndex = 67
        Me.Label36.Text = "Spec Vol"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(767, 198)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(80, 21)
        Me.Label34.TabIndex = 65
        Me.Label34.Text = "Vel Head"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(216, 84)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(105, 17)
        Me.Label33.TabIndex = 62
        Me.Label33.Text = "Gauge Height"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(297, 98)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(17, 17)
        Me.Label30.TabIndex = 61
        Me.Label30.Text = """"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(64, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(105, 17)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "Pipe Sizes"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(32, 130)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(57, 17)
        Me.Label27.TabIndex = 56
        Me.Label27.Text = "Discharge"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(32, 98)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(57, 17)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "Suction"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(267, 375)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(54, 11)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "Temp   "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(211, 375)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(40, 11)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "Disch"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(154, 375)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(33, 11)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Suct"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(101, 385)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(54, 11)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Flow   "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(16, 385)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(68, 11)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Time     "
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(8, 581)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(105, 17)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "File Name"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(97, 17)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Loop Select"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(32, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(81, 17)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Serial No"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Chart1
        '
        ChartArea1.BackColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(753, 320)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Lime
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(730, 511)
        Me.Chart1.TabIndex = 115
        Me.Chart1.Text = "Chart1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(154, 396)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(54, 11)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Press  "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(211, 396)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(54, 11)
        Me.Label16.TabIndex = 117
        Me.Label16.Text = "Press  "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(324, 375)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(89, 11)
        Me.Label17.TabIndex = 118
        Me.Label17.Text = "Velocity Hd "
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Red
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(961, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(413, 84)
        Me.ListBox1.TabIndex = 119
        Me.ListBox1.Visible = False
        '
        'lblListBox
        '
        Me.lblListBox.AutoSize = True
        Me.lblListBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListBox.ForeColor = System.Drawing.Color.Red
        Me.lblListBox.Location = New System.Drawing.Point(1100, 7)
        Me.lblListBox.Name = "lblListBox"
        Me.lblListBox.Size = New System.Drawing.Size(131, 18)
        Me.lblListBox.TabIndex = 120
        Me.lblListBox.Text = "Select Worksheet"
        Me.lblListBox.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDesignTDH)
        Me.GroupBox1.Controls.Add(Me.Label64)
        Me.GroupBox1.Controls.Add(Me.lblRPM)
        Me.GroupBox1.Controls.Add(Me.lblFrequency)
        Me.GroupBox1.Controls.Add(Me.lblVoltage)
        Me.GroupBox1.Controls.Add(Me.Label66)
        Me.GroupBox1.Controls.Add(Me.Label67)
        Me.GroupBox1.Controls.Add(Me.Label68)
        Me.GroupBox1.Controls.Add(Me.lblMounting)
        Me.GroupBox1.Controls.Add(Me.lblCircPath)
        Me.GroupBox1.Controls.Add(Me.lblImpDia)
        Me.GroupBox1.Controls.Add(Me.lblNPSHa)
        Me.GroupBox1.Controls.Add(Me.lblNPSHr)
        Me.GroupBox1.Controls.Add(Me.lblDesignFlow)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.Label62)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.Label57)
        Me.GroupBox1.Controls.Add(Me.lblSalesOrder)
        Me.GroupBox1.Controls.Add(Me.lblModelNumber)
        Me.GroupBox1.Controls.Add(Me.lblCustomer)
        Me.GroupBox1.Controls.Add(Me.Label53)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Location = New System.Drawing.Point(1070, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 153)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pump Info"
        '
        'lblRPM
        '
        Me.lblRPM.AutoSize = True
        Me.lblRPM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPM.Location = New System.Drawing.Point(516, 55)
        Me.lblRPM.Name = "lblRPM"
        Me.lblRPM.Size = New System.Drawing.Size(0, 15)
        Me.lblRPM.TabIndex = 23
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrequency.Location = New System.Drawing.Point(516, 38)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(0, 15)
        Me.lblFrequency.TabIndex = 22
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoltage.Location = New System.Drawing.Point(516, 20)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(0, 15)
        Me.lblVoltage.TabIndex = 21
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(466, 55)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(34, 14)
        Me.Label66.TabIndex = 20
        Me.Label66.Text = "RPM::"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(440, 38)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(62, 14)
        Me.Label67.TabIndex = 19
        Me.Label67.Text = "Frequency:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(456, 20)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(46, 14)
        Me.Label68.TabIndex = 18
        Me.Label68.Text = "Voltage:"
        '
        'lblMounting
        '
        Me.lblMounting.AutoSize = True
        Me.lblMounting.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMounting.Location = New System.Drawing.Point(377, 92)
        Me.lblMounting.Name = "lblMounting"
        Me.lblMounting.Size = New System.Drawing.Size(0, 15)
        Me.lblMounting.TabIndex = 17
        '
        'lblCircPath
        '
        Me.lblCircPath.AutoSize = True
        Me.lblCircPath.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircPath.Location = New System.Drawing.Point(377, 74)
        Me.lblCircPath.Name = "lblCircPath"
        Me.lblCircPath.Size = New System.Drawing.Size(0, 15)
        Me.lblCircPath.TabIndex = 16
        '
        'lblImpDia
        '
        Me.lblImpDia.AutoSize = True
        Me.lblImpDia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpDia.Location = New System.Drawing.Point(377, 56)
        Me.lblImpDia.Name = "lblImpDia"
        Me.lblImpDia.Size = New System.Drawing.Size(0, 15)
        Me.lblImpDia.TabIndex = 15
        '
        'lblNPSHa
        '
        Me.lblNPSHa.AutoSize = True
        Me.lblNPSHa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPSHa.Location = New System.Drawing.Point(377, 38)
        Me.lblNPSHa.Name = "lblNPSHa"
        Me.lblNPSHa.Size = New System.Drawing.Size(0, 15)
        Me.lblNPSHa.TabIndex = 14
        '
        'lblNPSHr
        '
        Me.lblNPSHr.AutoSize = True
        Me.lblNPSHr.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPSHr.Location = New System.Drawing.Point(377, 20)
        Me.lblNPSHr.Name = "lblNPSHr"
        Me.lblNPSHr.Size = New System.Drawing.Size(0, 15)
        Me.lblNPSHr.TabIndex = 13
        '
        'lblDesignFlow
        '
        Me.lblDesignFlow.AutoSize = True
        Me.lblDesignFlow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignFlow.Location = New System.Drawing.Point(95, 75)
        Me.lblDesignFlow.Name = "lblDesignFlow"
        Me.lblDesignFlow.Size = New System.Drawing.Size(0, 15)
        Me.lblDesignFlow.TabIndex = 12
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(313, 92)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(53, 14)
        Me.Label61.TabIndex = 11
        Me.Label61.Text = "Mounting:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(313, 74)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(53, 14)
        Me.Label62.TabIndex = 10
        Me.Label62.Text = "Circ Path:"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(302, 56)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(64, 14)
        Me.Label59.TabIndex = 9
        Me.Label59.Text = "Impeller Dia:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(323, 38)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(43, 14)
        Me.Label60.TabIndex = 8
        Me.Label60.Text = "NPSHa:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(325, 20)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(41, 14)
        Me.Label58.TabIndex = 7
        Me.Label58.Text = "NPSHr:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(14, 75)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(70, 14)
        Me.Label57.TabIndex = 6
        Me.Label57.Text = "Design Flow:"
        '
        'lblSalesOrder
        '
        Me.lblSalesOrder.AutoSize = True
        Me.lblSalesOrder.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesOrder.Location = New System.Drawing.Point(90, 55)
        Me.lblSalesOrder.Name = "lblSalesOrder"
        Me.lblSalesOrder.Size = New System.Drawing.Size(0, 15)
        Me.lblSalesOrder.TabIndex = 5
        '
        'lblModelNumber
        '
        Me.lblModelNumber.AutoSize = True
        Me.lblModelNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelNumber.Location = New System.Drawing.Point(90, 38)
        Me.lblModelNumber.Name = "lblModelNumber"
        Me.lblModelNumber.Size = New System.Drawing.Size(0, 15)
        Me.lblModelNumber.TabIndex = 4
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(90, 20)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(0, 15)
        Me.lblCustomer.TabIndex = 3
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(16, 55)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(68, 14)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Sales Order:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(6, 38)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(78, 14)
        Me.Label51.TabIndex = 1
        Me.Label51.Text = "Model Number:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(25, 20)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(59, 14)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "Customer: "
        '
        'lblDesignTDH
        '
        Me.lblDesignTDH.AutoSize = True
        Me.lblDesignTDH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignTDH.Location = New System.Drawing.Point(95, 93)
        Me.lblDesignTDH.Name = "lblDesignTDH"
        Me.lblDesignTDH.Size = New System.Drawing.Size(0, 15)
        Me.lblDesignTDH.TabIndex = 25
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(14, 93)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(66, 14)
        Me.Label64.TabIndex = 24
        Me.Label64.Text = "Design TDH:"
        '
        'frmPLCData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1691, 885)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbldatarow)
        Me.Controls.Add(Me.lblInputData)
        Me.Controls.Add(Me.lblListBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.txtConstantFlow)
        Me.Controls.Add(Me.chkConstantFlow)
        Me.Controls.Add(Me.cmdCalibrate)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.txtValvePositionDisplay)
        Me.Controls.Add(Me.txtValvePosition)
        Me.Controls.Add(Me.txtDeltaSuctionPressure)
        Me.Controls.Add(Me.txtNPSHa97)
        Me.Controls.Add(Me.txtTDH97)
        Me.Controls.Add(Me.txtDischGaugeHeight)
        Me.Controls.Add(Me.txtNPSHa)
        Me.Controls.Add(Me.txtTDH)
        Me.Controls.Add(Me.txtInHgDisplay)
        Me.Controls.Add(Me.txtInHg)
        Me.Controls.Add(Me.txtFlowForCalcs)
        Me.Controls.Add(Me.txtPctHead)
        Me.Controls.Add(Me.txtAveTDH)
        Me.Controls.Add(Me.txtVapPress)
        Me.Controls.Add(Me.txtSpVol)
        Me.Controls.Add(Me.txtDischVelHead)
        Me.Controls.Add(Me.txtSuctVelHead)
        Me.Controls.Add(Me.txtSuctGaugeHeight)
        Me.Controls.Add(Me.cmdStartTest)
        Me.Controls.Add(Me.cmbDisch)
        Me.Controls.Add(Me.cmbSuction)
        Me.Controls.Add(Me.rtbDataOut)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.cmdSaveData)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.cmbPLCLoop)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtSN)
        Me.Controls.Add(Me.txtUpdateInterval)
        Me.Controls.Add(Me.lblConstantFlow)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label28)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(39, 34)
        Me.Name = "frmPLCData"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NPSH Data Acquisition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame4.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents shpGetPLCData As PowerPacks.OvalShape
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Public WithEvents Label15 As Label
    Public WithEvents Label16 As Label
    Public WithEvents Label17 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblListBox As Label
    Friend WithEvents lblInputData As Label
    Friend WithEvents lbldatarow As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lblRPM As Label
    Friend WithEvents lblFrequency As Label
    Friend WithEvents lblVoltage As Label
    Friend WithEvents lblMounting As Label
    Friend WithEvents lblCircPath As Label
    Friend WithEvents lblImpDia As Label
    Friend WithEvents lblNPSHa As Label
    Friend WithEvents lblNPSHr As Label
    Friend WithEvents lblDesignFlow As Label
    Friend WithEvents lblSalesOrder As Label
    Friend WithEvents lblModelNumber As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblDesignTDH As Label
    Friend WithEvents Label64 As Label
#End Region
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
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
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents txtLogin As System.Windows.Forms.TextBox
	Public WithEvents lblLogin As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdOK = New System.Windows.Forms.Button
		Me.txtLogin = New System.Windows.Forms.TextBox
		Me.lblLogin = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Enter Password"
		Me.ClientSize = New System.Drawing.Size(388, 160)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmLogin"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "OK"
		Me.cmdOK.Size = New System.Drawing.Size(81, 33)
		Me.cmdOK.Location = New System.Drawing.Point(152, 112)
		Me.cmdOK.TabIndex = 2
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.txtLogin.AutoSize = False
		Me.txtLogin.Size = New System.Drawing.Size(145, 25)
		Me.txtLogin.Location = New System.Drawing.Point(120, 64)
		Me.txtLogin.TabIndex = 0
		Me.txtLogin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLogin.AcceptsReturn = True
		Me.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLogin.BackColor = System.Drawing.SystemColors.Window
		Me.txtLogin.CausesValidation = True
		Me.txtLogin.Enabled = True
		Me.txtLogin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLogin.HideSelection = True
		Me.txtLogin.ReadOnly = False
		Me.txtLogin.Maxlength = 0
		Me.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLogin.MultiLine = False
		Me.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLogin.TabStop = True
		Me.txtLogin.Visible = True
		Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLogin.Name = "txtLogin"
		Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblLogin.Text = "Please enter your Password."
		Me.lblLogin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLogin.Size = New System.Drawing.Size(385, 49)
		Me.lblLogin.Location = New System.Drawing.Point(0, 8)
		Me.lblLogin.TabIndex = 1
		Me.lblLogin.BackColor = System.Drawing.SystemColors.Control
		Me.lblLogin.Enabled = True
		Me.lblLogin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLogin.UseMnemonic = True
		Me.lblLogin.Visible = True
		Me.lblLogin.AutoSize = False
		Me.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLogin.Name = "lblLogin"
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(txtLogin)
		Me.Controls.Add(lblLogin)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class
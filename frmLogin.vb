Option Strict Off
Option Explicit On
Friend Class frmLogin
	Inherits System.Windows.Forms.Form
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Calibrating = False
        'UPGRADE_ISSUE: Len function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(txtLogin.Text) Or Len(txtLogin.Text) = 0 Then
        Else
            If txtLogin.Text = "Admin" Then
                Calibrating = True
                frmPLCData.CalibrateSoftware()
            Else
            End If
        End If
		Me.Hide()
	End Sub
End Class
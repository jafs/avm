Public Class CtrGsmCalls

    Private Sub chkGsmTimer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGsmTimer.CheckedChanged
        If chkGsmTimer.Checked Then
            chkGsmTimer.Text = "Disable Monitor"
            chkGsmTimer.BackColor = Drawing.Color.FromArgb(255, 210, 220)
            chkGsmTimer.ForeColor = Drawing.Color.FromArgb(80, 40, 40)
        Else
            chkGsmTimer.Text = "Enable Monitor"
            chkGsmTimer.BackColor = Drawing.Color.FromArgb(220, 255, 230)
            chkGsmTimer.ForeColor = Drawing.Color.FromArgb(40, 80, 40)
        End If
    End Sub
End Class

Public Class frmMain

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = e.CloseReason
        If UnloadMode = CloseReason.UserClosing Then
            Select Case MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    frmLogin.Close()
                Case Windows.Forms.DialogResult.No
                    Cancel = True
            End Select
        End If
        e.Cancel = Cancel
    End Sub


  
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showUSC(uscMainmenu)
    End Sub
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            currentUSC.Width = pnlMain.Width
            currentUSC.Height = pnlMain.Height
        Catch ex As Exception

        End Try
    End Sub
End Class


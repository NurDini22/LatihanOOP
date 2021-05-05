Public Class Form1
    Private Sub BtnPapar_Click(sender As Object, e As EventArgs) Handles BtnPapar.Click
        Dim strNoMatrik As String = txtNoMatrik.Text

        If strNoMatrik.Length < 12 Then
            MessageBox.Show("Nombor matrik terlalu pendek")

        Else
            Dim PelajarBaru As New Pelajar(strNoMatrik)
            txtPoliteknik.Text = PelajarBaru.Politeknik
            txtProgram.Text = PelajarBaru.Program
            txtAmbilan.Text = PelajarBaru.Ambilan
        End If
    End Sub
End Class

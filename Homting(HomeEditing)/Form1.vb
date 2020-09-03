Public Class Form1
    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Dim opj As New OpenFileDialog
        Dim img As String
        opj.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png|All files (*.*)|*.*"
        If opj.ShowDialog(Me) = DialogResult.OK Then
            img = opj.FileName
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        End If
    End Sub
    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        Dim opj As New OpenFileDialog
        Dim img As String
        opj.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png|All files (*.*)|*.*"
        If opj.ShowDialog(Me) = DialogResult.OK Then
            img = opj.FileName
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        End If
    End Sub
    Private Sub ToolboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolboxToolStripMenuItem.Click
        Toolbox.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutApp.Show()
    End Sub

    Private Sub ShareAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShareAppToolStripMenuItem.Click
        Dim url


        url = ("https://drive.google.com/open?id=1BAEn2uHIewpM4XTRvhZXtI4GScZarEiQ")
        Clipboard.SetText(url)
        MessageBox.Show("URL has been copied")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim svpj As New SaveFileDialog
        Dim img As String
        svpj.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png|All files (*.*)|*.*"
        If svpj.ShowDialog(Me) = DialogResult.OK Then
            img = svpj.FileName
            PictureBox1.Image.Save(img)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim svpj As New SaveFileDialog
        Dim img As String
        svpj.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png|All files (*.*)|*.*"
        If svpj.ShowDialog(Me) = DialogResult.OK Then
            img = svpj.FileName
            PictureBox1.Image.Save(img)
        End If
    End Sub
End Class

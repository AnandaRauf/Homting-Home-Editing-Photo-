Imports System.Drawing.Imaging

Public Class Toolbox
    Private Sub Filter1but_Click(sender As Object, e As EventArgs) Handles Filter1but.Click
        If Form1.PictureBox1.Image IsNot Nothing Then Form1.PictureBox1.Image =
         InvertColorMatrix(Form1.PictureBox1.Image)
    End Sub
    Private Shared Function InvertColorMatrix(ByVal imgSource _
         As Image) As Image
        Dim bmpDest As Bitmap = New Bitmap(imgSource.Width,
         imgSource.Height)
        Dim clrMatrix As ColorMatrix = New ColorMatrix(New Single() _
         () {New Single() {-1, 0, 0, 0, 0}, New Single() {0, -1,
         0, 0, 0}, New Single() {0, 0, -1, 0, 0}, New Single() _
         {0, 0, 0, 1, 0}, New Single() {1, 1, 1, 0, 1}})

        Using attrImage As ImageAttributes = New ImageAttributes()
            attrImage.SetColorMatrix(clrMatrix)

            Using g As Graphics = Graphics.FromImage(bmpDest)
                g.DrawImage(imgSource, New Rectangle(0, 0,
               imgSource.Width, imgSource.Height), 0, 0,
               imgSource.Width, imgSource.Height,
               GraphicsUnit.Pixel, attrImage)
            End Using
        End Using

        Return bmpDest
    End Function

    Private Sub Filter2but_Click(sender As Object, e As EventArgs) Handles Filter2but.Click
        If Form1.PictureBox1.Image IsNot Nothing Then Form1.PictureBox1.Image =
         InvertColorMatrix1(Form1.PictureBox1.Image)
    End Sub
    Private Shared Function InvertColorMatrix1(ByVal imgSource _
         As Image) As Image
        Dim bmpDest As Bitmap = New Bitmap(imgSource.Width,
         imgSource.Height)
        Dim clrMatrix As ColorMatrix = New ColorMatrix(New Single() _
         () {New Single() {0, 0, 0, 0, 0}, New Single() {0, -1,
         0, 0, 0}, New Single() {0, 0, 1, 0, 0}, New Single() _
         {0, 0, 0, 1, 0}, New Single() {1, 1, 1, 0, 1}})

        Using attrImage As ImageAttributes = New ImageAttributes()
            attrImage.SetColorMatrix(clrMatrix)

            Using g As Graphics = Graphics.FromImage(bmpDest)
                g.DrawImage(imgSource, New Rectangle(0, 0,
               imgSource.Width, imgSource.Height), 0, 0,
               imgSource.Width, imgSource.Height,
               GraphicsUnit.Pixel, attrImage)
            End Using
        End Using

        Return bmpDest
    End Function


End Class
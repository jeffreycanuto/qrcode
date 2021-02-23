Imports ThoughtWorks.QRCode.Codec

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gen As New QRCodeEncoder
        Dim img As Image
        Dim btm As Bitmap
        Dim str As String

        Dim thk As String = "thank you daw"
        str = txtname.Text + " " + txtAge.Text
        gen.QRCodeScale = 5
        img = gen.Encode(str)
        btm = New Bitmap(img)
        btm.Save("qrimage.jpg")
        PictureBox1.ImageLocation = "qrimage.jpg"

    End Sub
End Class

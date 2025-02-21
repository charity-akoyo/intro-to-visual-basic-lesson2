Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Object Demonstration")

    End Sub

    Private Sub Button2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Load Picture")

    End Sub

    Private Sub Button3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Display Test")

    End Sub

    Private Sub Button4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Sample Test")

    End Sub

    Private Sub Button5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Font")

    End Sub

    Private Sub Button6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Garamond")

    End Sub

    Private Sub Button7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Magneto")

    End Sub

    Private Sub Button8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Tahoma")

    End Sub

    Private Sub Button9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Font Style")

    End Sub

    Private Sub Button10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Font color")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim image As Image
        image = Image.FromFile("C:\User\KWUST\Desktop\image1000015199.jpg")
        PictureBox1.Image = image
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("Application Exit")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Application Exit")
    End Sub
End Class

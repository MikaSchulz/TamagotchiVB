Public Class PictureBoxTransparent
    Inherits PictureBox

    Public Bitmap As Bitmap
    'Public Color As Color

    'Public Sub New(x As Integer, y As Integer, Bitmap As Bitmap)
    '    Me.x = x
    '    Me.y = y
    '    Me.Bitmap = Bitmap
    'End Sub

    'Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer, color As Color)
    '    Me.x = x
    '    Me.y = y
    '    Me.width = width
    '    Me.height = height
    '    Me.color = color
    'End Sub
    Public Sub New()
    End Sub

    Public Sub DrawPicture(graphics As Graphics)
        Dim r As New Rectangle(Left, Top, Width, Height)
        graphics.DrawImage(Bitmap, r)
    End Sub

End Class

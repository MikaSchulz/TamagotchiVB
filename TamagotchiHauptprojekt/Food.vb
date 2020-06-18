Public Class Food
    Public Name As String
    Public Regeneration As Integer
    Public Skin As Integer
    Public Price As Byte

    Public Sub New(ByVal Name As String, ByVal Regeneration As Integer, ByVal Price As Byte, ByVal Skin As Integer)
        Me.Name = Name
        Me.Regeneration = Regeneration
        Me.Price = Price
        Me.Skin = Skin
    End Sub
End Class
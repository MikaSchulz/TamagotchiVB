Public Class MemoryCard
    Private ReadOnly id As Byte
    Private ReadOnly label As Label
    Private ReadOnly icon As String
    Private revealed As Boolean

    Public Sub New(ByVal id As Byte, ByVal label As Label, ByVal icon As String)
        Me.id = id
        Me.label = label
        Me.icon = icon
    End Sub

    Public Function GetId() As Byte
        Return id
    End Function
    Public Function GetLabel() As Label
        Return label
    End Function
    Public Function GetIcon() As String
        Return icon
    End Function

    Public Sub ShowIcon(ByVal show As Boolean)
        If show Then
            label.Text = icon
        Else
            If Not revealed Then
                label.Text = ""
            End If
        End If
    End Sub
    Public Sub SetSelected(ByVal selected As Boolean)
        If selected Then
            label.BackColor = Color.Orange
        Else
            label.BackColor = Color.CornflowerBlue
        End If
    End Sub
    Public Function IsRevealed() As Boolean
        Return revealed
    End Function

    Public Sub SetRevealed(ByVal revealed As Boolean)
        Me.revealed = revealed
    End Sub

End Class

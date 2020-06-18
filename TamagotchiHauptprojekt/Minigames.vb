Imports System.ComponentModel

Public Class Minigames
    Inherits Selector

    Public Sub New(ByVal lastgame As Byte)
        MyBase.New(TamagotchiManager.Instance.GetObjects.GetMinigameLabels(), 4, lastgame)
        InitializeComponent()
    End Sub

    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.GetMinigameLabels(), 4)
        InitializeComponent()
    End Sub

    Public Overrides Sub Selecting()
        Select Case GetSelected()
            Case 0
                If TamagotchiManager.Instance.GetTamagotchi.GetExhaustion() >= 10 And TamagotchiManager.Instance.GetTamagotchi.GetLove() >= 10 Then
                    Utils.OpenForm(New LeftRight(), Me)
                Else
                    lblAttention.Location = New System.Drawing.Point(25, 350)
                    lblAttention.Visible = True
                End If
            Case 1
                If TamagotchiManager.Instance.GetTamagotchi.GetExhaustion() >= 5 And TamagotchiManager.Instance.GetTamagotchi.GetLove() >= 10 Then
                    Utils.OpenForm(New Memory, Me)
                Else
                    lblAttention.Location = New System.Drawing.Point(287, 350)
                    lblAttention.Visible = True
                End If
            Case 2
                Utils.OpenForm(New SlotMachine, Me)
            Case 3
                Utils.OpenForm(New TamagotchiScreen, Me)
        End Select
    End Sub

    Private Sub Minigames_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

    Private Sub Minigames_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = TamagotchiManager.Instance.GetLocation
    End Sub
End Class
Imports System.ComponentModel

Public Class Dead
    Inherits Selector

    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.GetDead, 4)
        InitializeComponent()
    End Sub
    Public Overrides Sub Selecting()
        If GetSelected() = 0 Then
            Utils.OpenForm(New ChooseCharacter(), Me)
        Else
            Dim tamagotchi As Tamagotchi = TamagotchiManager.Instance.GetTamagotchi
            tamagotchi.SetSystemtime(DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
            tamagotchi.SetExhaustion(33)
            tamagotchi.SetFood(33)
            tamagotchi.SetFun(33)
            tamagotchi.SetHydration(33)
            tamagotchi.SetLove(33)
            Utils.OpenForm(New TamagotchiScreen(), Me)
        End If
    End Sub

    Private Sub Dead_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = TamagotchiManager.Instance.GetLocation
        lblName.Text = TamagotchiManager.Instance.GetTamagotchi.GetPlayername
    End Sub

    Private Sub Dead_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub


End Class
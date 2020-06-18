Imports System.ComponentModel

Public Class Settings
    Inherits Selector

    Private ReadOnly tamagotchi As Tamagotchi = TamagotchiManager.Instance.GetTamagotchi

    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.GetSettings, 4)
        InitializeComponent()
    End Sub


    Public Overrides Sub Selecting()
        Select Case GetSelected()
            Case 0
                Utils.OpenForm(New ChooseBackground(), Me)
                Return
            Case 1
                tamagotchi.SetDifficulty(0)
            Case 2
                tamagotchi.SetDifficulty(1)
            Case 3
                tamagotchi.SetDifficulty(2)
            Case 4
                tamagotchi.SetDifficulty(3)
        End Select

        Utils.OpenForm(New TamagotchiScreen(), Me)
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = TamagotchiManager.Instance.GetLocation()
        lblDescription.Text = GetDescription(tamagotchi.GetDifficulty)
    End Sub

    Private Sub Settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

    Private Sub Settings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If GetSelected() > 0 And GetSelected() < 5 Then
            lblDescription.Text = GetDescription(GetSelected() - 1)
        Else
            lblDescription.Text = GetDescription(tamagotchi.GetDifficulty)
        End If
    End Sub

    Public Function GetDescription(ByVal difficulty As Byte) As String
        Select Case difficulty
            Case 0
                Return "Einfach:" & vbCr & "Für selten spielende Spieler geeignet"
            Case 1
                Return "Normal:" & vbCr & "Für die meisten Spieler geeignet"
            Case 2
                Return "Schwer:" & vbCr & "Für häufig spielende Spieler geeignet"
            Case 3
                Return "Freies Spiel:" & vbCr & "Du verlierst keine Lebenspunkte und erhälst keine Coins"
        End Select
        Return Nothing
    End Function

End Class
Imports System.ComponentModel

Public Class ChooseBackground
    Inherits Selector

    'Public Shared pbxBack0 As New PictureBoxTransparent() With { 'Statische Transparente Pictureboxen werden erstellt
    '    .Left = 35,
    '    .Top = 126,
    '    .Bitmap = My.Resources.CatHappy 'Texturen werden geladen
    '}
    'Public Shared pbxBack1 As New PictureBoxTransparent() With {
    '    .Left = 294,
    '    .Top = 126,
    '    .Bitmap = My.Resources.DogHappy
    '}
    'Public Shared pbxBack2 As New PictureBoxTransparent() With {
    '    .Left = 552,
    '    .Top = 126,
    '    .Bitmap = My.Resources.OXHappy
    '}

    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.getBackgroundElements, 4, TamagotchiManager.Instance.GetTamagotchi.GetBackground) 'Springt zum Konstrukter der Mutterklasse
        InitializeComponent() 'Erstellt alle Elemente vom ChooseBackground initialisiert er auf die Mutterklasse (Selektor)
    End Sub

    Public Overrides Sub Selecting() 'Die Prozedur wird in der Mutterklasse ausgeführt und hier wird sie beschrieben (MustOverride und Override)
        'Console.WriteLine("Selected: " & GetSelected())
        'Console.WriteLine("finished")
        If Not GetSelected() = 3 Then
            TamagotchiManager.Instance.GetTamagotchi.SetBackground(GetSelected())
        End If
        Utils.OpenForm(New Settings(), Me)
    End Sub

    Private Sub ChooseBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Location = TamagotchiManager.Instance.GetLocation()
    End Sub

    Private Sub ChooseCharacter_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

End Class
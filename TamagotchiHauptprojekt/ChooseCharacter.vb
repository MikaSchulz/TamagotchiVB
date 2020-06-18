Imports System.ComponentModel

Public Class ChooseCharacter
    Inherits Selector

    'Public Shared pbxBack0 As New PictureBox With {
    '    .BackColor = Color.Red,
    '    .Location = New Point(35, 126),
    '    .Name = "pbxChar0",
    '    .Size = New Size(222, 222),
    '    .TabIndex = 3,
    '    .TabStop = False
    '}

    'Public Shared pbxBack1 As New PictureBox With {
    '    .BackColor = Color.Yellow,
    '    .Location = New Point(294, 126),
    '    .Name = "pbxChar1",
    '    .Size = New Size(222, 222),
    '    .TabIndex = 4,
    '    .TabStop = False
    '}

    'Public Shared pbxBack2 As New PictureBox With {
    '    .BackColor = Color.Blue,
    '    .Location = New Point(552, 126),
    '    .Name = "pbxChar2",
    '    .Size = New Size(222, 222),
    '    .TabIndex = 5,
    '    .TabStop = False
    '}


    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.getCharacterElements(), 1)
        InitializeComponent()
    End Sub

    Public Overrides Sub Selecting()
        'Console.WriteLine("Selected: " & GetSelected())
        'Console.WriteLine("finished")
        TamagotchiManager.Instance.SetCharacter(GetSelected())
        Utils.OpenForm(New ChooseName(), Me)
    End Sub

    'Private selected As Integer = 1

    'Private Sub ChooseCharacter_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = 37 Then
    '        setSelected(-1)
    '    ElseIf e.KeyCode = 39 Then
    '        setSelected(1)
    '    ElseIf e.KeyCode = 38 Or e.KeyCode = 40 Then
    '        Dim cn As ChooseName
    '        cn = New ChooseName()
    '        cn.Show()
    '        Me.Hide()
    '    End If

    '    Select Case selected
    '        Case 0
    '            pbxSelect.Left = pbxChar0.Left - 17
    '        Case 1
    '            pbxSelect.Left = pbxChar1.Left - 17
    '        Case 2
    '            pbxSelect.Left = pbxChar2.Left - 17
    '    End Select
    'End Sub

    'Private Sub setSelected(modifier As Integer)
    '    Dim nextSel As Integer = selected
    '    nextSel += modifier
    '    If nextSel >= 0 And nextSel <= 2 Then
    '        selected = nextSel
    '    End If
    'End Sub

    'Public Function getSelected() As Integer
    '    Return selected
    'End Function

    Private Sub ChooseCharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Später entfernen
        If TamagotchiManager.Instance.GetLocation = Nothing Then
            Location = Utils.GetCenter(Me)
        Else
            Location = TamagotchiManager.Instance.GetLocation
        End If
        lblHeader.Left = 810 / 2 - lblHeader.Size.Width / 2
    End Sub

    Private Sub ChooseCharacter_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

End Class
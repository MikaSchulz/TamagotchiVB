Imports System.ComponentModel

Public Class Memory

    Private tries As Byte = 10
    Private selected As Byte = 0
    Private cardList As List(Of MemoryCard)
    Private lblList As List(Of Label)
    Private icons As List(Of String)
    Private ReadOnly rdm As New Random
    Private firstAction As Boolean
    Private ReadOnly tamagotchi As Tamagotchi = TamagotchiManager.Instance.GetTamagotchi

    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = TamagotchiManager.Instance.GetLocation
        Inititalize()
    End Sub


    Public Sub Inititalize()
        firstAction = True
        tries = 10
        selected = 0
        cardList = New List(Of MemoryCard)
        lblList = New List(Of Label) From {lblMem1, lblMem2, lblMem3, lblMem4, lblMem5, lblMem6, lblMem7, lblMem8, lblMem9, lblMem10, lblMem11, lblMem12, lblMem13, lblMem14, lblMem15, lblMem16}
        icons = New List(Of String) From {"%", "%", "b", "b", "h", "h", "j", "j", "!", "!", "Y", "Y", "d", "d", "O", "O"}
        For Each label In lblList
            label.Text = ""
            label.BackColor = Color.CornflowerBlue
        Next
        lblTries.Text = "Versuche: " & tries
        lblMem1.BackColor = Color.Orange
        CreateNewCardList()
        'For Each card In cardList
        '    Console.WriteLine("ID: " & card.GetId & ", Name:" & card.GetLabel.Name & ", Icon:" & card.GetIcon & ", Revealed: " & card.IsRevealed)
        'Next
    End Sub

    Public Sub CreateNewCardList()
        For Each lbl In lblList
            Dim index = rdm.Next(icons.Count)
            Dim ic = icons(index)
            icons.RemoveAt(index)
            cardList.Add(New MemoryCard(cardList.Count, lbl, ic))
        Next
        'Dim temp As Integer = 0
        'For i As Integer = 0 To icons.Count - 1
        '    Dim index = rdm.Next(icons.Count)
        '    Dim firstIcon = icons(index)
        '    icons.RemoveAt(index)
        '    lblList.Item(lblList.ElementAt(temp).Key) = firstIcon
        '    temp += 1
        'Next
    End Sub

    Private Sub Memory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 37 Then
            SetSelected(-1)
        ElseIf e.KeyCode = 39 Then
            SetSelected(1)
        ElseIf e.KeyCode = 38 Or e.KeyCode = 40 Then
            Selecting()
            Return
        End If
    End Sub

    Private firstCardNumber As Integer = -1
    Private secondCardNumber As Integer = -1

    Private Sub Selecting()
        If selected = 16 Then
            Utils.OpenForm(New Minigames(1), Me)
            Return
        End If
        If firstAction = True Then
            If tamagotchi.GetExhaustion < 5 Then
                Utils.OpenForm(New Minigames, Me)
                Return
            End If
            tamagotchi.ModifyExhaustion(-5)
            firstAction = False
        End If
        If timerDisappear.Enabled = True Then
            Return
        End If
        Dim card As MemoryCard = GetCardById(selected)
        If card.IsRevealed Then
            Return
        End If


        lblStatus.Visible = False
        card.ShowIcon(True)

        If firstCardNumber = -1 Then
            firstCardNumber = card.GetId
        Else
            Dim firstCard As MemoryCard = GetCardById(firstCardNumber)
            If firstCard IsNot card Then
                secondCardNumber = card.GetId
                If firstCard.GetIcon = card.GetIcon Then
                    firstCard.SetRevealed(True)
                    card.SetRevealed(True)
                    If WonGame() Then
                        SetStatus(1)
                        tamagotchi.ModifyCoins(10)
                        tamagotchi.ModifyExhaustion(-5)
                        tamagotchi.ModifyFun(10)
                        Inititalize()
                    End If
                    firstCardNumber = -1
                    secondCardNumber = -1
                Else
                    tries -= 1
                    If tries = 0 Then
                        SetStatus(0)
                        tamagotchi.ModifyExhaustion(-5)
                        tamagotchi.ModifyFun(10)
                        Inititalize()
                    End If
                    lblTries.Text = "Versuche: " & tries
                    timerDisappear.Start()
                End If
            End If
        End If
    End Sub


    Private Sub SetSelected(modifier As Integer)
        Dim nextSel As Integer = selected
        nextSel += modifier
        If nextSel >= 0 And nextSel <= 16 Then
            If selected <> 16 Then
                cardList(selected).SetSelected(False)
            End If
            lblBackSelector.Visible = False
            selected = nextSel
        End If
        If selected = 16 Then
            lblBackSelector.Visible = True
        Else
            cardList(selected).SetSelected(True)
        End If
    End Sub


    Private Sub TimerDisappear_Tick(sender As Object, e As EventArgs) Handles timerDisappear.Tick
        GetCardById(firstCardNumber).ShowIcon(False)
        GetCardById(secondCardNumber).ShowIcon(False)
        firstCardNumber = -1
        secondCardNumber = -1
        timerDisappear.Stop()

    End Sub

    Private Function GetCardById(ByVal id As Byte) As MemoryCard
        For Each card In cardList
            If card.GetId = id Then
                Return card
            End If
        Next
        Return Nothing
    End Function

    Private Function WonGame() As Boolean
        For Each card In cardList
            If Not card.IsRevealed Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub SetStatus(ByVal status As Byte)
        If status = 0 Then
            lblStatus.Height = 143
            lblStatus.Text = "Du hast verloren. Spiel wurde neugestartet."
            lblStatus.Visible = True
        ElseIf status = 1 Then
            lblStatus.Height = 105
            lblStatus.Text = "Du hast 10 Punkte gewonnen."
            lblStatus.Visible = True
        End If
    End Sub

    Private Sub Memory_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub
End Class
Imports System.ComponentModel

Public Class LeftRight
    Inherits Selector

    'Private running As Boolean = False
    Private ReadOnly generator As New Random
    Private randomNumber As Integer
    Private interval As Integer
    Private pressed As Boolean
    Private score As Integer
    Private highscore As Integer

    Private firstAction As Boolean

    Private ReadOnly tamagotchi As Tamagotchi = TamagotchiManager.Instance.GetTamagotchi
    Private imaLeft As Bitmap
    Private imaMid As Bitmap
    Private imaRight As Bitmap

    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.GetLeftRightElements(), 4)
        InitializeComponent()
    End Sub

    Public Overrides Sub Selecting()
        If Not IsSelectorEnabled() Then
            Return
        End If
        Select Case GetSelected()
            Case 0
                SetSelectorEnabled(False)
                ResetStats()
                pbxMid.Hide()
                pbxLeft.Hide()
                pbxRight.Hide()
                'btnStart.Hide()
                'btnStart.Enabled = False
                lblInfo.Hide()
                LeftRightTimer.Start()
                Tick()
            Case 1
                Utils.OpenForm(New Minigames(0), Me)
        End Select
    End Sub

    Private Sub LeftRight_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = TamagotchiManager.Instance.GetLocation
        Dim skin As Integer = TamagotchiManager.Instance.GetTamagotchi.GetSkin
        imaLeft = My.Resources.ResourceManager.GetObject(Utils.GetSkin(skin) & "LookLeft")
        imaMid = My.Resources.ResourceManager.GetObject(Utils.GetSkin(skin) & "Front")
        imaRight = My.Resources.ResourceManager.GetObject(Utils.GetSkin(skin) & "LookRight")
        pbxMid.Image = imaMid
        pbxLeft.Image = imaLeft
        pbxRight.Image = imaRight
        ResetStats()
    End Sub

    'Private Sub Start_click(sender As Object, e As EventArgs) Handles btnStart.Click
    '    ResetStats()
    '    pbxMid.Hide()
    '    pbxLeft.Hide()
    '    pbxRight.Hide()
    '    'btnStart.Hide()
    '    'btnStart.Enabled = False
    '    LeftRightTimer.Start()
    '    Tick()
    'End Sub

    Public Sub LeftRightTimer_Tick(sender As Object, e As EventArgs) Handles LeftRightTimer.Tick
        Tick()
    End Sub

    Private Sub LeftRight_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not IsSelectorEnabled() Then
            If firstAction = True Then
                If tamagotchi.GetExhaustion < 10 Then
                    Utils.OpenForm(New Minigames, Me)
                    Return
                End If
                tamagotchi.ModifyExhaustion(-10)
                firstAction = False
            End If
            If pressed = True Then
                Return
            End If
            If pbxMid.Visible Then
                Return
            End If
            Select Case e.KeyCode
                Case 39
                    If randomNumber = 0 Then
                        GameEnd()
                        Return
                    End If
                    pressed = True
                Case 37
                    If randomNumber = 1 Then
                        GameEnd()
                        Return
                    End If
                    pressed = True
                Case Else
                    Return
            End Select
            score += 1
            lblPoints.Text = "Punkte: " & score
        End If
    End Sub

    Private Sub ResetStats()
        randomNumber = 0
        interval = 1000
        firstAction = True
        pressed = True
        score = 0
        highscore = tamagotchi.GetHighscoreLeftRight()
        lblNewHighscore.Hide()
        lblPoints.Text = "Punkte: " & score
        lblHighscore.Text = "Highscore: " & highscore
    End Sub

    Private Sub GameEnd()
        If highscore < score Then
            highscore = score
            tamagotchi.SetHighscoreLeftRight(highscore)
            lblHighscore.Text = "Highscore: " & highscore
            lblNewHighscore.Show()
        End If
        LeftRightTimer.Stop()
        tamagotchi.ModifyCoins(score)
        tamagotchi.ModifyFun(15)
        pbxMid.Hide()
        pbxLeft.Hide()
        pbxRight.Hide()
        SetSelectorEnabled(True)
        lblInfo.Show()
        'btnStart.Show()
        'btnStart.Enabled = True
    End Sub

    Public Sub Tick()
        If Not pbxMid.Visible Then

            If pressed = False Then
                GameEnd()
                Return
            End If

            pbxMid.Show()

            interval -= Int(Math.Ceiling(interval / 1000 * 25))
            If (interval > 0) Then
                LeftRightTimer.Interval = interval
            End If
            pbxLeft.Hide()
            pbxRight.Hide()
            pressed = False
            randomNumber = generator.Next(0, 2)

        Else
            pbxMid.Hide()

            If randomNumber = 0 Then
                pbxLeft.Show()
                pbxMid.Hide()
            End If
            If randomNumber = 1 Then
                pbxRight.Show()
                pbxMid.Hide()
            End If
        End If
    End Sub

    Private Sub LeftRight_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
        imaLeft.Dispose()
        imaMid.Dispose()
        imaRight.Dispose()
    End Sub

End Class
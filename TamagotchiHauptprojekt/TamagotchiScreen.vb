Imports System.ComponentModel

Public Class TamagotchiScreen
    Inherits Selector

    Private Shared ReadOnly tm As TamagotchiManager = TamagotchiManager.Instance
    Private moodSkin As String
    Private Sub TamagotchiScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tm.GetLocation = Nothing Then
            Location = Utils.GetCenter(Me)
        Else
            Location = tm.GetLocation
        End If
        Dim tamagotchi As Tamagotchi = tm.GetTamagotchi
        moodSkin = Utils.GetSkin(tamagotchi.GetSkin) & "Happy"

        lblName.Text = "Name: " & tamagotchi.GetPlayername()
        lblCoinsValue.Text = "Coins: " & tamagotchi.GetCoins
        pbxHydration.Width = 177 / 100 * tamagotchi.GetHydration
        pbxFood.Width = 177 / 100 * tamagotchi.GetFood
        pbxFun.Width = 177 / 100 * tamagotchi.GetFun
        pbxLove.Width = 177 / 100 * tamagotchi.GetLove
        pbxExhaustion.Width = 177 / 100 * tamagotchi.GetExhaustion

        SetMood(tamagotchi)

    End Sub

    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.GetTamagotchiScreen, 4, 2)
        InitializeComponent()

    End Sub

    Public Overrides Sub Selecting()
        Select Case GetSelected()
            Case 0
                Utils.OpenForm(New Settings(), Me)
            Case 1
                Utils.OpenForm(New Shop(), Me)
            Case 2
                Utils.OpenForm(New Minigames(), Me)
            Case 3
                If Not timerLove.Enabled Then
                    timerLove.Start()
                End If

        End Select
    End Sub
    Private Sub TamagotchiScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

    Private Sub TamagotchiScreen_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim skin As Integer = tm.GetTamagotchi.GetSkin
        Dim newMoodSkin As Bitmap = My.Resources.ResourceManager.GetObject(moodSkin)
        Dim r As New Rectangle(241, 65, newMoodSkin.Width, newMoodSkin.Height)
        e.Graphics.DrawImage(newMoodSkin, r)
    End Sub

    Private Sub BarTimer_Tick(sender As Object, e As EventArgs) Handles timerBar.Tick
        'Console.WriteLine("TIME: " & DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
        Dim calcTam As Tamagotchi = tm.GetTamagotchiCalculator.CalculatedAttributes(tm.GetTamagotchi, False)
        'Console.WriteLine(tm.GetTamagotchi.GetSystemtime)
        'Console.WriteLine(calcTam.GetSystemtime)
        'If Not calcTam Is tm.GetTamagotchi Then
        '    Console.WriteLine("NOT SAME")
        If calcTam IsNot tm.GetTamagotchi Then
            calcTam.SetSystemtime(DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
            tm.SetTamagotchi(calcTam)
            pbxHydration.Width = 177 / 100 * tm.GetTamagotchi.GetHydration
            pbxFood.Width = 177 / 100 * tm.GetTamagotchi.GetFood
            pbxFun.Width = 177 / 100 * tm.GetTamagotchi.GetFun
            pbxLove.Width = 177 / 100 * tm.GetTamagotchi.GetLove
            pbxExhaustion.Width = 177 / 100 * tm.GetTamagotchi.GetExhaustion
            SetMood(calcTam)
        End If


        'End If
        'tm.GetTamagotchi.SetSystemtime(DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
        'Console.WriteLine(tm.GetTamagotchi.GetSystemtime)
        'lblExhaustion.Text = "AUTO"
        'Console.WriteLine(tm.GetTamagotchi.GetSystemtime)

    End Sub



    Private Sub SetMood(ByVal tamagotchi As Tamagotchi)
        Dim mood As String = "Happy"
        If tamagotchi.GetFun < 10 Or tamagotchi.GetLove < 20 Then
            mood = "Mad"
        End If
        If tamagotchi.GetExhaustion < 5 Then
            mood = "Tired"
        End If
        If tamagotchi.GetFood < 10 Or tamagotchi.GetHydration < 10 Then
            mood = "Sad"
        End If
        If tamagotchi.GetFood = 0 And tamagotchi.GetHydration = 0 Then
            Dead()
        End If
        Dim skin As Integer = tm.GetTamagotchi.GetSkin
        Dim newMoodSkinString As String = Utils.GetSkin(skin) & mood
        If newMoodSkinString <> moodSkin Then
            'Console.WriteLine(newMoodSkinString)
            'Console.WriteLine(moodSkin)
            Dim newMoodSkin As Bitmap = My.Resources.ResourceManager.GetObject(newMoodSkinString)
            moodSkin = newMoodSkinString
            Dim rect As Rectangle = New Rectangle(241, 65, newMoodSkin.Width, newMoodSkin.Height)
            Invalidate(rect)
        End If
    End Sub

    Private Sub Dead()
        Utils.OpenForm(New Dead(), Me)
    End Sub

    Private Sub TimerLove_Tick(sender As Object, e As EventArgs) Handles timerLove.Tick
        tm.GetTamagotchi.ModifyLove(2)
        pbxLove.Width = 177 / 100 * tm.GetTamagotchi.GetLove
        timerLove.Stop()
    End Sub
    'Private Sub Shop_Click(sender As Object, e As EventArgs) Handles Shop.Click
    '    Utils.OpenForm(New Shop(), Me)
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Utils.OpenForm(New Memory(), Me)
    'End Sub

End Class
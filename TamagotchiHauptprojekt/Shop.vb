Imports System.ComponentModel

Public Class Shop
    Inherits Selector

    Private ReadOnly tamagotchi As Tamagotchi = TamagotchiManager.Instance.GetTamagotchi
    Private ReadOnly waitDuration As Long = 36000000000
    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.GetShopElements(), 4, 0)
        InitializeComponent()
    End Sub

    Public Overrides Sub Selecting()
        'Console.WriteLine("Selected: " & GetSelected())
        'Console.WriteLine("finished")
        'If GetSelected() = 5 Then
        '    If TamagotchiManager.Instance.GetTamagotchi.GetCoins >= 15 Then
        '        Utils.OpenForm(New TamagotchiScreen(), Me)
        '        MsgBox("gekauft")
        '        TamagotchiManager.Instance.GetTamagotchi.ModifyCoins(-15)

        '    Else
        '        MsgBox("Nicht genug Coins!")
        '    End If '15
        ' End If
        Dim Coins As Integer = 0
        Dim Food As Integer = 0
        Dim Hydration As Integer = 0

        Select Case GetSelected()

            Case 0
                If lblBread.Text <> "Brot : Kostenlos" Then
                    Return
                End If
                If tamagotchi.GetFood = 100 Then
                    Return
                End If
                Food = 5
                tamagotchi.SetFreeBread(DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
            Case 1
                Coins = 10
                Food = 10
            Case 2
                Coins = 15
                Food = 15
            Case 3
                If lblWater.Text <> "Wasser : Kostenlos" Then
                    Return
                End If
                If tamagotchi.GetHydration = 100 Then
                    Return
                End If
                Hydration = 5
                tamagotchi.SetFreeWater(DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
            Case 4
                Coins = 10
                Hydration = 10
            Case 5
                Coins = 15
                Hydration = 15
            Case 6
                Utils.OpenForm(New TamagotchiScreen(), Me)
                Return
        End Select
        If tamagotchi.GetCoins >= Coins Then
            If tamagotchi.GetFood = 100 And Food > 0 Then
                Return
            End If
            If tamagotchi.GetHydration = 100 And Hydration > 0 Then
                Return
            End If
            tamagotchi.ModifyFood(Food)
            tamagotchi.ModifyHydration(Hydration)
            tamagotchi.ModifyCoins(-1 * Coins)
            Utils.OpenForm(New TamagotchiScreen(), Me)
        End If
    End Sub

    Private Sub Shop_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = TamagotchiManager.Instance.GetLocation
        lblCoinsValue.Text = "Coins: " & tamagotchi.GetCoins

        lblBread.Text = "Brot : " & GetTime(tamagotchi.GetFreeBread)
        lblWater.Text = "Wasser : " & GetTime(tamagotchi.GetFreeWater)
    End Sub

    Private Sub TimerFreeItems_Tick(sender As Object, e As EventArgs) Handles timerFreeItems.Tick
        lblBread.Text = "Brot : " & GetTime(tamagotchi.GetFreeBread)
        lblWater.Text = "Wasser : " & GetTime(tamagotchi.GetFreeWater)
    End Sub

    'Private Function IsFree(ByVal item As Byte) As Boolean
    '    Dim lastUsed As Long
    '    If item = 0 Then
    '        lastUsed = tamagotchi.GetFreeBread
    '    ElseIf item = 1 Then
    '        lastUsed = tamagotchi.GetFreeWater
    '    End If
    '    Dim timeNow As Long = DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks
    '    If lastUsed = 0 Then
    '        Return True
    '    Else
    '        Dim timePassed As Long = timeNow - lastUsed
    '        If timePassed >= waitDuration Then
    '            Return True
    '        End If
    '        '3 Stunden 933120000000000
    '        '3 Stunden 311040000000000
    '        '1 Min       5184000000000

    '    End If
    '    Return False
    'End Function

    Private Function GetTime(ByVal lastUsed As Long) As String
        If lastUsed = 0 Then
            Return "Kostenlos"
        End If
        Dim timeNow As Long = DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks
        Dim timePassed As Long = timeNow - lastUsed
        Dim remainingTime As Long = waitDuration - timePassed
        'Console.WriteLine(remainingTime)
        If remainingTime <= 0 Then
            Return "Kostenlos"
        End If
        Dim span As TimeSpan = TimeSpan.FromTicks(remainingTime)

        'Dim sec As Long = TimeSpan.FromSeconds(1).Ticks
        'Console.WriteLine("1s: " & sec)

        'Dim min As Long = TimeSpan.FromMinutes(1).Ticks
        'Console.WriteLine("1m: " & min)

        'Dim hour As Long = TimeSpan.FromHours(1).Ticks
        'Console.WriteLine("1h: " & hour)

        Return span.Duration.ToString("mm\:ss")
    End Function



End Class
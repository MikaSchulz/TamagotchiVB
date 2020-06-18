Public Class Tamagotchi
    Private systemtime As Long
    Private playername As String
    Private skin As Integer
    Private background As Integer
    Private difficulty As Integer
    Private highscoreLeftRight As Integer
    Private freebread As Long
    Private freewater As Long
    Private coins As Integer
    Private food As Double
    Private hydration As Double
    Private fun As Double
    Private love As Double
    Private exhaustion As Double

    Public Sub New(ByVal systemtime As Long, ByVal playername As String, ByVal skin As Integer, ByVal background As Integer, ByVal difficulty As Integer, ByVal highscoreLeftRight As Integer, ByVal freebread As Long, ByVal freewater As Long, ByVal coins As Integer, ByVal food As Double, ByVal hydration As Double, ByVal fun As Double, ByVal love As Double, ByVal exhaustion As Double)
        Me.systemtime = systemtime
        Me.playername = playername
        Me.skin = skin
        Me.background = background
        Me.difficulty = difficulty
        Me.highscoreLeftRight = highscoreLeftRight
        Me.freebread = freebread
        Me.freewater = freewater
        Me.coins = coins
        Me.food = food
        Me.hydration = hydration
        Me.fun = fun
        Me.love = love
        Me.exhaustion = exhaustion
    End Sub

    Public Sub New(ByVal playername As String, ByVal skin As Integer)
        Me.playername = playername
        Me.skin = skin
        systemtime = DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks
        background = 1
        difficulty = 1
        highscoreLeftRight = 0
        freebread = 0
        freewater = 0
        coins = 10
        food = 100
        hydration = 100
        fun = 100
        love = 100
        exhaustion = 100
    End Sub

    Public Sub SetSystemtime(systemtime As Long)
        Me.systemtime = systemtime
    End Sub
    Public Function GetSystemtime() As Long
        Return systemtime
    End Function

    Public Sub SetPlayername(playername As String)
        Me.playername = playername
    End Sub
    Public Function GetPlayername() As String
        Return playername
    End Function
    Public Sub SetSkin(skin As Integer)
        Me.skin = skin
    End Sub

    Public Function GetSkin() As Integer
        Return skin
    End Function
    Public Sub SetBackground(background As Integer)
        Me.background = background
    End Sub
    Public Function GetBackground() As Integer
        Return background
    End Function
    Public Sub SetDifficulty(difficulty As Integer)
        Me.difficulty = difficulty
    End Sub
    Public Function GetDifficulty() As Integer
        Return difficulty
    End Function

    Public Function GetHighscoreLeftRight() As Integer
        Return highscoreLeftRight
    End Function

    Public Sub SetHighscoreLeftRight(highscoreLeftRight As Integer)
        Me.highscoreLeftRight = highscoreLeftRight
    End Sub

    Public Function GetFreeBread() As Long
        Return freebread
    End Function

    Public Sub SetFreeBread(freebread As Long)
        If difficulty = 3 Then
            Return
        End If
        Me.freebread = freebread
    End Sub
    Public Function GetFreeWater() As Long
        Return freewater
    End Function

    Public Sub SetFreeWater(freewater As Long)
        If difficulty = 3 Then
            Return
        End If
        Me.freewater = freewater
    End Sub

    Public Sub ModifyCoins(ByVal coins As Integer)

        If difficulty = 3 Then
            Return
        End If
        Me.coins += coins
    End Sub
    Public Function GetCoins() As Integer
        Return coins
    End Function

    Public Sub SetCoins(ByVal coins As Integer)
        Me.coins = coins
    End Sub
    Public Sub ModifyFood(food As Double)
        If difficulty = 3 Then
            Return
        End If
        Dim newFood = Me.food + food
        If newFood > 100 Then
            Me.food = 100
            Return
        ElseIf newFood < 0 Then
            Me.food = 0
            Return
        End If
        Me.food += food
    End Sub

    Public Function GetFood() As Double
        Return food
    End Function

    Public Sub SetFood(food As Double)
        Me.food = food
    End Sub

    Public Sub ModifyHydration(hydration As Double)
        If difficulty = 3 Then
            Return
        End If
        Dim newHydration = Me.hydration + hydration
        If newHydration > 100 Then
            Me.hydration = 100
            Return
        ElseIf newHydration < 0 Then
            Me.hydration = 0
            Return
        End If
        Me.hydration += hydration
    End Sub

    Public Function GetHydration() As Double
        Return hydration
    End Function

    Public Sub SetHydration(hydration As Double)
        Me.hydration = hydration
    End Sub

    Public Sub ModifyFun(fun As Double)
        If difficulty = 3 Then
            Return
        End If
        Dim newFun = Me.fun + fun
        If newFun > 100 Then
            Me.fun = 100
            Return
        ElseIf newFun < 0 Then
            Me.fun = 0
            Return
        End If
        Me.fun += fun
    End Sub

    Public Function GetFun() As Double
        Return fun
    End Function

    Public Sub SetFun(fun As Double)
        Me.fun = fun
    End Sub

    Public Sub ModifyLove(love As Double)
        If difficulty = 3 Then
            Return
        End If
        Dim newLove = Me.love + love
        If newLove > 100 Then
            Me.love = 100
            Return
        ElseIf newLove < 0 Then
            Me.love = 0
            Return
        End If
        Me.love += love
    End Sub

    Public Function GetLove() As Double
        Return love
    End Function

    Public Sub SetLove(love As Double)
        Me.love = love
    End Sub
    Public Sub ModifyExhaustion(exhaustion As Double)
        If difficulty = 3 Then
            Return
        End If
        Dim newExhaustion = Me.exhaustion + exhaustion
        If newExhaustion > 100 Then
            Me.exhaustion = 100
            Return
        ElseIf newExhaustion < 0 Then
            Me.exhaustion = 0
            Return
        End If
        Me.exhaustion += exhaustion
    End Sub

    Public Function GetExhaustion() As Double
        Return exhaustion
    End Function

    Public Sub SetExhaustion(exhaustion As Double)
        Me.exhaustion = exhaustion
    End Sub

    Public Function GetClone() As Tamagotchi
        Return DirectCast(MemberwiseClone(), Tamagotchi)
    End Function

End Class
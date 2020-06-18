Public Class TamagotchiCalculator

    Public Function CalculatedAttributes(ByVal tamagotchi As Tamagotchi, ByVal exhaustion As Boolean) As Tamagotchi

        Dim timePast As Long = tamagotchi.GetSystemtime
        Dim timeNow As Long = DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks
        Dim estimatedTime As Long = timeNow - timePast
        Dim calcTam As Tamagotchi = tamagotchi.GetClone()

        'Console.WriteLine(estimatedTime)
        If tamagotchi.GetDifficulty = 3 Then
            Return tamagotchi
        End If
        Dim value As Integer = Math.Floor(estimatedTime / GetModifier(calcTam) / 1000000000)
        'Console.WriteLine("Value: " & value)
        If value = 0 Then
            Return tamagotchi
        End If
        If exhaustion Then
            calcTam.ModifyExhaustion(value)
        End If
        calcTam.ModifyFood(-value)
        calcTam.ModifyFun(-value)
        calcTam.ModifyHydration(-value)
        calcTam.ModifyLove(-value)
        Return calcTam
    End Function

    Public Function GetModifier(ByVal tamagotchi As Tamagotchi) As Double
        'Return 12000000000
        Select Case tamagotchi.GetDifficulty
            Case 0
                'Return 0.05
                'Return 0.1
                Return 108
            Case 1
                Return 24
            Case 2
                Return 12
            Case 3
                Return Nothing
        End Select
        Return Nothing
    End Function



End Class

Public Class TamagotchiManager

    Private Shared tamagotchiManager As TamagotchiManager
    Private ReadOnly fileManager As FileManager
    Private ReadOnly tamagotchiCalculator As TamagotchiCalculator
    Private ReadOnly objects As Objects
    Private character As Integer

    Private tamagotchi As Tamagotchi
    Private location As Point = Nothing

    Public Sub New()

        tamagotchiManager = Me
        fileManager = New FileManager
        tamagotchiCalculator = New TamagotchiCalculator
        objects = New Objects

    End Sub

    Public Function GetFileManager() As FileManager
        Return fileManager
    End Function

    Public Function GetTamagotchi() As Tamagotchi
        Return tamagotchi
    End Function

    Public Function GetTamagotchiCalculator() As TamagotchiCalculator
        Return tamagotchiCalculator
    End Function

    Public Function GetObjects() As Objects
        Return objects
    End Function
    Public Function GetLocation()
        Return location
    End Function

    Public Sub SetLocation(location As Point)
        Me.location = location
    End Sub

    Public Sub SetTamagotchi(tamagotchi As Tamagotchi)
        Me.tamagotchi = tamagotchi
    End Sub

    Public Sub SetCharacter(ByVal character As Integer)
        Me.character = character
    End Sub

    Public Function GetCharacter() As Integer
        Return character
    End Function

    Public Shared Function Instance() As TamagotchiManager
        Return tamagotchiManager
    End Function

End Class

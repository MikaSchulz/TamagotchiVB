Public Class FileManager

    Private ReadOnly fileSystem As MyServices.FileSystemProxy = My.Computer.FileSystem
    Private ReadOnly fileDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Tamagotchi"
    Private ReadOnly fileName As String = fileDirectory & "\tamagotchi.txt"

    Private attributes As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
        {"Systemtime", Nothing}, {"Playername", Nothing}, {"Skin", Nothing}, {"Background", Nothing}, {"Difficulty", Nothing}, {"HighscoreLeftRight", Nothing}, {"FreeBread", Nothing}, {"FreeWater", Nothing}, {"Coins", Nothing}, {"Food", Nothing}, {"Hydration", Nothing}, {"Fun", Nothing}, {"Love", Nothing}, {"Exhaustion", Nothing}
    }
    Public Sub New()

        If Not fileSystem.DirectoryExists(fileDirectory) Then
            fileSystem.CreateDirectory(fileDirectory)
        End If

        If Not fileSystem.FileExists(fileName) Then
            SaveFile()
            'Console.WriteLine("File erstellt")
        Else
            LoadFile()
            'Console.WriteLine("File geladen")
        End If

    End Sub

    Public Function GetAttribute(attribute As String) As Object
        Return attributes.Item(attribute)
    End Function

    Public Sub SetAttribute(attribute As String, value As Object)
        attributes.Item(attribute) = value
    End Sub

    Public Function GetAttributes() As Dictionary(Of String, Object)
        Return attributes
    End Function

    Public Function GetKeySet() As Dictionary(Of String, Object).KeyCollection
        Return attributes.Keys
    End Function

    Public Function GetTamagotchi() As Tamagotchi
        Dim systemtime As Long = GetAttribute("Systemtime")
        Dim playername As String = GetAttribute("Playername")
        Dim skin As Integer = GetAttribute("Skin")
        Dim background As Integer = GetAttribute("Background")
        Dim difficulty As Integer = GetAttribute("Difficulty")
        Dim highscoreLeftRight As Integer = GetAttribute("HighscoreLeftRight")
        Dim freebread As Long = GetAttribute("FreeBread")
        Dim freewater As Long = GetAttribute("FreeWater")
        Dim coins As Integer = GetAttribute("Coins")
        Dim food As Double = GetAttribute("Food")
        Dim hydration As Double = GetAttribute("Hydration")
        Dim fun As Double = GetAttribute("Fun")
        Dim love As Double = GetAttribute("Love")
        Dim exhaustion As Double = GetAttribute("Exhaustion")
        Return New Tamagotchi(systemtime, playername, skin, background, difficulty, highscoreLeftRight, freebread, freewater, coins, food, hydration, fun, love, exhaustion)

    End Function

    Public Sub SaveFile(tamagotchi As Tamagotchi)
        SetAttribute("Systemtime", DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
        SetAttribute("Playername", tamagotchi.GetPlayername)
        SetAttribute("Skin", tamagotchi.GetSkin)
        SetAttribute("Background", tamagotchi.GetBackground)
        SetAttribute("Difficulty", tamagotchi.getDifficulty)
        SetAttribute("HighscoreLeftRight", tamagotchi.GetHighscoreLeftRight)
        SetAttribute("FreeBread", tamagotchi.getFreeBread)
        SetAttribute("FreeWater", tamagotchi.getFreeWater)
        SetAttribute("Coins", tamagotchi.getCoins)
        SetAttribute("Food", tamagotchi.getFood)
        SetAttribute("Hydration", tamagotchi.getHydration)
        SetAttribute("Fun", tamagotchi.getFun)
        SetAttribute("Love", tamagotchi.getLove)
        SetAttribute("Exhaustion", tamagotchi.GetExhaustion)
        SaveFile()
    End Sub

    Public Sub SaveFile()

        Dim filetext As String = Nothing
        For Each att In attributes
            filetext = filetext & att.Key & ": " & att.Value & vbNewLine
        Next
        fileSystem.WriteAllText(fileName, filetext, False)

    End Sub

    Public Sub LoadFile()
        Dim fileReader As IO.StreamReader = fileSystem.OpenTextFileReader(fileName)

        Dim readString As String
        Dim tempAttributes As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        Dim keys As Dictionary(Of String, Object).KeyCollection = attributes.Keys
        Dim resetConfig As Byte = 0

        For Each key As String In keys
            readString = fileReader.ReadLine
            If readString Is Nothing Then
                SendError(resetConfig)
                Exit For
            End If

            Dim attributeSet As String()
            Try
                attributeSet = readString.Replace(" ", Nothing).Split(":")
            Catch ex As IndexOutOfRangeException
                SendError(resetConfig)
                Exit For
            End Try

            If attributeSet(0) = key Then
                tempAttributes.Add(attributeSet(0), attributeSet(1))
            Else
                SendError(resetConfig)
                Exit For
            End If

        Next
        fileReader.Close()

        If resetConfig = 1 Then
            SaveFile()
            LoadFile()
            Return
        ElseIf resetConfig = 2 Then
            End
            Return
        End If
        attributes.Clear()
        attributes = tempAttributes

        'Do
        '    readString = fileReader.ReadLine
        '    If readString Is Nothing Then
        '        Exit Do
        '    End If

        '    Try
        '        Dim attributeSet As String() = readString.Replace(" ", Nothing).Split(":")
        '        If attributeSet(0) = keys(key) Then
        '            Console.WriteLine(attributeSet(0) & " " & keys(key))
        '            tempAttributes.Add(attributeSet(0), attributeSet(1))
        '            key += 1
        '        Else
        '            resetConfig = SendError()
        '        End If
        '    Catch ex As IndexOutOfRangeException

        '        resetConfig = SendError()

        '    End Try


        'Loop Until readString Is Nothing

        'fileReader.Close()


    End Sub

    Private Sub SendError(ByRef resetConfig)
        Dim Msg As String = "Die Konfigurationsdatei wurde beschädigt. Versuche sie zu reparieren oder erstelle eine neue Datei." & vbNewLine & "Möchtest du Datei neu erstellen? " & vbNewLine & "WARNUNG: Alle gespeicherten Daten gehen dann verloren."
        Dim Style As Integer = vbYesNo + vbCritical + vbDefaultButton2
        Dim Title As String = "BESCHÄDIGTE KONFIGURATIONSDATEI"
        Dim result As MsgBoxResult = MsgBox(Msg, Style, Title)
        If result = vbYes Then
            resetConfig = 1
        Else
            resetConfig = 2
        End If
    End Sub
End Class
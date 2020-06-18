Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst.  Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung mit einem Fehler beendet wird.
    ' UnhandledException: Wird bei einem Ausnahmefehler ausgelöst.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn die Anwendung bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        Private filemanager As FileManager
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            Dim tm = New TamagotchiManager() 'ApplicationStartup wird als Erstes ausgeführt, wenn Applikation gestartet wird
            filemanager = tm.GetFileManager

            If Not TamagotchiExsits() Then 'Geprüft ob Tamagotchi existiert oder nicht
                Application.MainForm = ChooseCharacter 'Form ChooseCharacter wird geladen

                'Console.WriteLine(DateAndTime.Now)
                'Console.WriteLine("Existiert Nicht")
            Else
                Dim tamagotchi As Tamagotchi = filemanager.GetTamagotchi
                Dim calctam = tm.GetTamagotchiCalculator.CalculatedAttributes(tamagotchi, True)
                If calctam IsNot tamagotchi Then
                    'Console.WriteLine("same")
                    calctam.SetSystemtime(DateTime.Now.Ticks - New DateTime(1970, 1, 1).Ticks)
                End If
                tm.SetTamagotchi(calctam) 'Tamagotchi aus dem FileManager wird ausgelesen und ins Programm geladen

                'Console.WriteLine(DateAndTime.Now)
                'Console.WriteLine("Existiert")
            End If

        End Sub

        Private Function TamagotchiExsits() As Boolean

            Dim keys As Dictionary(Of String, Object).KeyCollection = filemanager.GetKeySet() 'Key-value pair -> Jeder Schlüssel hat einen Wert und ist in einer List gespeichert (z.B. STRING + WERT), liest die Werte aus dem FileManager aus und springt in die For-Next-Schleife

            For i = 0 To keys.Count - 1 'Holt sich den jeweiligen Wert vom Schlüssel und überprüft ob ein Schlüssel vorhanden ist
                If filemanager.GetAttribute(keys(i)) = Nothing Then 'Wenn ein Wert fehlt -> kein Tamagotchi, sonst Return True
                    Return False
                End If
            Next
            Return True
        End Function

    End Class
End Namespace

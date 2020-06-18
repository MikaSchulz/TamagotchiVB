Public Class Utils

    Public Shared Function GetCenter(ByVal form As Form) As Point
        Dim r As Rectangle = Screen.FromPoint(form.Location).WorkingArea
        Dim x = r.Left + (r.Width - form.Width) \ 2
        Dim y = r.Top + (r.Height - form.Height) \ 2
        Return New Point(x, y)
    End Function

    Public Shared Sub OnClose(ByVal closingForm As Form)

        Dim tamagotchi As Tamagotchi = TamagotchiManager.Instance.GetTamagotchi
        If tamagotchi IsNot Nothing Then
            TamagotchiManager.Instance.GetFileManager.SaveFile(tamagotchi)
        End If
        TamagotchiManager.Instance.SetLocation(closingForm.Location)
        'Dim openForms As Byte
        'For Each preForm In Application.OpenForms
        '    Dim form As Form = DirectCast(preForm, Form)
        '    If form.Visible Then
        '        openForms += 1
        '    End If
        'Next
        'If openForms <= 1 Then
        '    Application.Exit()
        'End If
    End Sub

    Public Shared Function GetSkin(ByVal skin As Integer) As String
        Select Case skin
            Case 0
                Return "Cat"
            Case 1
                Return "Dog"
            Case 2
                Return "OX"
        End Select
        Return 0
    End Function

    Public Shared Function GetBackground(ByVal background As Integer)
        Select Case background
            Case 0
                Return "Background0"
            Case 1
                Return "Background1"
            Case 2
                Return "Background2"
        End Select
        Return 0
    End Function

    Public Shared Sub OpenForm(ByVal newForm As Form, ByVal oldForm As Form)

        TamagotchiManager.Instance.SetLocation(oldForm.Location)
        newForm.Show()
        'oldForm.hide()
        oldForm.Close()

    End Sub

    Public Shared Function RoundUp(value As Double, decimals As Integer) As Double
        Return Math.Ceiling(value * (10 ^ decimals)) / (10 ^ decimals)
    End Function

End Class
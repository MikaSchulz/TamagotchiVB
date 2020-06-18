Imports System.ComponentModel
Public Class ChooseName

    Private Shared ReadOnly tm As TamagotchiManager = TamagotchiManager.Instance
    Private Shared ReadOnly skin As Bitmap = My.Resources.ResourceManager.GetObject(Utils.GetSkin(tm.GetCharacter) & "Happy")


    Public Shared pbxSkin As New PictureBoxTransparent() With {
        .Left = 277,
        .Top = 108,
        .Width = skin.Width,
        .Height = skin.Height,
        .Bitmap = skin
    }

    Private Sub ChooseName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = tm.GetLocation
        lblHeader.Left = 810 / 2 - lblHeader.Size.Width / 2
        txtName.Left = 810 / 2 - txtName.Size.Width / 2
        'tm.setLocation(Location)
        'Console.WriteLine(Utils.GetSkin(ChooseCharacter.GetSelected) & "Happy")
    End Sub

    Public Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = 38 Or e.KeyCode = 40 Then
            If txtName.Text = Nothing Then
                MsgBox("Bitte geben Sie einen Namen ein.", vbOKOnly, "Fehler")
            Else
                Dim tamagotchi As Tamagotchi = New Tamagotchi(txtName.Text, tm.GetCharacter())
                tm.SetTamagotchi(tamagotchi)
                tm.GetFileManager.SaveFile(tamagotchi)
                'ChooseCharacter.Tamagotchi.setPlayername(txtName.Text)

                'Utils.saveLocation(Location)
                Utils.OpenForm(New TamagotchiScreen(), Me)
            End If
        End If
    End Sub

    Private Sub ChooseName_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        pbxSkin.DrawPicture(e.Graphics)
    End Sub

    Private Sub ChooseName_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

End Class
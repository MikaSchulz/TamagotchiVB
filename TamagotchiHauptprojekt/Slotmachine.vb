Imports System.ComponentModel

Public Class SlotMachine
    Inherits Selector

    Private ReadOnly tamagotchi As Tamagotchi = TamagotchiManager.Instance.GetTamagotchi

    Private ReadOnly rdn As New System.Random
    Private numberOfTicks As Integer
    Const minStake As Integer = 10
    Dim running As Boolean = False

    Public Sub New()
        MyBase.New(TamagotchiManager.Instance.GetObjects.getSlotMachineElements(), 4, 0)
        InitializeComponent()
    End Sub

    Public Overrides Sub Selecting()
        If running Then
            Return
        End If
        Select Case GetSelected()
            Case 0
                If tamagotchi.GetCoins >= Val(lblStakeValue.Text) Then
                    lblCoinsValue.Text = tamagotchi.GetCoins - (Val(lblStakeValue.Text))
                    numberOfTicks = 0
                    running = True
                    SetStatus(1)
                    tmrSpinSlot.Enabled = True
                Else
                    SetStatus(0)
                End If
            Case 1
                If Val(lblStakeValue.Text) < tamagotchi.GetCoins Then
                    lblStakeValue.Text = Val(lblStakeValue.Text) + 10
                End If
            Case 2
                If Val(lblStakeValue.Text) > minStake Then
                    lblStakeValue.Text = Val(lblStakeValue.Text) - 10
                End If
            Case 3
                TamagotchiManager.Instance.SetLocation(Location)
                Utils.OpenForm(New Minigames(2), Me)
        End Select
    End Sub


    Private Sub TmrSpin_Tick(sender As Object, e As EventArgs) Handles tmrSpinSlot.Tick

        numberOfTicks += 1
        If Not numberOfTicks > 20 Then
            lblSlot1.Text = rdn.Next(1, 9)
        End If

        If Not numberOfTicks > 30 Then
            lblSlot2.Text = rdn.Next(1, 9)
        End If

        If Not numberOfTicks > 40 Then
            lblSlot3.Text = rdn.Next(1, 9)
            Return
        End If

        tmrSpinSlot.Stop()
        tamagotchi.ModifyCoins(-1 * (Val(lblStakeValue.Text)))
        running = False

        If Val(lblSlot1.Text) = 7 And Val(lblSlot2.Text) = 7 And Val(lblSlot3.Text) = 7 Then
            SetStatus(2)
            tamagotchi.ModifyCoins(Val(lblStakeValue.Text) * 5)
        ElseIf Val(lblSlot1.Text) = Val(lblSlot2.Text) And Val(lblSlot1.Text) = Val(lblSlot3.Text) Then
            SetStatus(2)
            tamagotchi.ModifyCoins(Val(lblStakeValue.Text) * 3)
        ElseIf Val(lblSlot1.Text) = Val(lblSlot2.Text) Or Val(lblSlot1.Text) = Val(lblSlot3.Text) Or Val(lblSlot2.Text) = Val(lblSlot3.Text) Then
            SetStatus(2)
            tamagotchi.ModifyCoins(Val(lblStakeValue.Text) * 1)
        Else
            SetStatus(3)
        End If

        lblCoinsValue.Text = tamagotchi.GetCoins

        If Val(tamagotchi.GetCoins < lblStakeValue.Text) Then
            lblStakeValue.Text = tamagotchi.GetCoins
        End If

        If Val(tamagotchi.GetCoins < minStake) Then
            lblStakeValue.Text = minStake
        End If

    End Sub

    Private Sub TamagotchiScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Utils.OnClose(Me)
    End Sub

    Public Sub SetStatus(ByVal status As Byte)
        Select Case status
            Case 0
                lblStatus.Text = "Zu wenig Coins"
            Case 1
                lblStatus.Text = "Drehe ..."
            Case 2
                lblStatus.Text = "Du hast gewonnen!"
            Case 3
                lblStatus.Text = "Leider verloren"
        End Select


    End Sub

    Private Sub SlotMachine_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = TamagotchiManager.Instance.GetLocation
        lblCoinsValue.Text = tamagotchi.GetCoins
        If (tamagotchi.GetCoins < minStake) Then
            SetStatus(0)
        End If
    End Sub

End Class

'Private Sub TmrCountTicks_Tick(sender As Object, e As EventArgs) Handles tmrCountTicks.Tick
'    numberOfTicks += 1
'    If numberOfTicks = 42 Then
'        numberOfTicks = 0
'        tmrWins.Enabled = True
'        tmrCountTicks.Enabled = False
'    End If
'End Sub

'Private Sub TmrWins_Tick(sender As Object, e As EventArgs) Handles tmrWins.Tick
'    If tmrSpinSlot.Enabled = False And tmrSpinSlot2.Enabled = False And tmrSpinSlot3.Enabled = False Then
'        If Val(lblSlot1.Text) = 7 And Val(lblSlot2.Text) = 7 And Val(lblSlot3.Text) = 7 Then
'            tmrWins.Enabled = False
'            MsgBox("Sie haben gewonnen!", vbOKOnly, "Slot machine")
'            TamagotchiManager.Instance.GetTamagotchi.SetCoins(TamagotchiManager.Instance.GetTamagotchi.GetCoins + Val(lblStakeValue.Text) * 5)
'            lblStakeValue.Text = minStake
'        Else
'            If Val(lblSlot1.Text) = Val(lblSlot2.Text) And Val(lblSlot1.Text) = Val(lblSlot3.Text) Then
'                tmrWins.Enabled = False
'                MsgBox("Sie haben gewonnen!", vbOKOnly, "Slot machine")
'                TamagotchiManager.Instance.GetTamagotchi.SetCoins(TamagotchiManager.Instance.GetTamagotchi.GetCoins + Val(lblStakeValue.Text) * 3)
'                lblStakeValue.Text = minStake
'            ElseIf Val(lblSlot1.Text) = Val(lblSlot2.Text) Or Val(lblSlot1.Text) = Val(lblSlot3.Text) Or Val(lblSlot2.Text) = Val(lblSlot3.Text) Then
'                tmrWins.Enabled = False
'                MsgBox("Sie haben gewonnen!", vbOKOnly, "Slot machine")
'                TamagotchiManager.Instance.GetTamagotchi.SetCoins(TamagotchiManager.Instance.GetTamagotchi.GetCoins + Val(lblStakeValue.Text) * 1)
'                lblStakeValue.Text = minStake
'            Else
'                tmrWins.Enabled = False
'                MsgBox("Leider verloren!", vbOKOnly, "Slot machine")
'                lblStakeValue.Text = minStake
'            End If
'        End If
'    End If
'End Sub

'Private Sub TmrDisablePullBtn_Tick(sender As Object, e As EventArgs) Handles tmrDisablePullBtn.Tick
'    If TamagotchiManager.Instance.GetTamagotchi.GetCoins < minStake Then
'        btnPull.Enabled = False
'    Else
'        btnPull.Enabled = True
'    End If
'    If tmrCountTicks.Enabled = True Then
'        btnPull.Enabled = False
'        btnSubstract.Enabled = False
'        btnAdd.Enabled = False
'    End If
'End Sub

'Private Sub TmrRefreshCoins_Tick(sender As Object, e As EventArgs) Handles tmrRefreshCoins.Tick
'    lblCoinsValue.Text = TamagotchiManager.Instance.GetTamagotchi.GetCoins
'End Sub

'Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
'    Utils.OpenForm(New TamagotchiScreen(), Me)
'End Sub

'Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
'    If Val(lblStakeValue.Text) >= TamagotchiManager.Instance.GetTamagotchi.GetCoins Then
'        btnAdd.Enabled = False
'    Else
'        lblStakeValue.Text = Val(lblStakeValue.Text) + 10
'    End If
'End Sub

'Private Sub BtnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
'    If Val(lblStakeValue.Text) <= minStake Then
'        btnSubstract.Enabled = False
'    Else
'        lblStakeValue.Text = Val(lblStakeValue.Text) - 10
'    End If
'End Sub
'Private Sub BtnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click
'    TamagotchiManager.Instance.GetTamagotchi.ModifyCoins(-1 * (Val(lblStakeValue.Text)))
'    tmrCountTicks.Enabled = True
'    tmrSpinSlot.Enabled = True
'    tmrSpinSlot2.Enabled = True
'    tmrSpinSlot3.Enabled = True
'End Sub

'Private Sub tmrStake_Tick(sender As Object, e As EventArgs) Handles tmrStake.Tick
'    If Val(lblStakeValue.Text) >= TamagotchiManager.Instance.GetTamagotchi.GetCoins Then
'        btnAdd.Enabled = False
'    Else
'        btnAdd.Enabled = True
'    End If

'    If Val(lblStakeValue.Text) <= minStake Or TamagotchiManager.Instance.GetTamagotchi.GetCoins <= minStake Then
'        btnSubstract.Enabled = False
'    Else
'        btnSubstract.Enabled = True
'    End If
'End Sub

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SlotMachine
    Inherits Selector

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrSpinSlot = New System.Windows.Forms.Timer(Me.components)
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDescriptionHeader = New System.Windows.Forms.Label()
        Me.lblCoinsValue = New System.Windows.Forms.Label()
        Me.lblStake = New System.Windows.Forms.Label()
        Me.lblStakeValue = New System.Windows.Forms.Label()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.lblSlot3 = New System.Windows.Forms.Label()
        Me.lblSlot2 = New System.Windows.Forms.Label()
        Me.lblSlot1 = New System.Windows.Forms.Label()
        Me.lblStakeChange = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrSpinSlot
        '
        Me.tmrSpinSlot.Interval = 50
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(498, 357)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(299, 69)
        Me.lblDescription.TabIndex = 29
        Me.lblDescription.Text = "3 gleiche Zahlen (Einsatz x 3)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 gleiche Zahlen (Einsatz x 1)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 mal die 7 (Eins" &
    "atz x 5)"
        '
        'lblDescriptionHeader
        '
        Me.lblDescriptionHeader.AutoSize = True
        Me.lblDescriptionHeader.BackColor = Color.Transparent
        Me.lblDescriptionHeader.Font = New System.Drawing.Font("Verdana", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionHeader.Location = New System.Drawing.Point(496, 316)
        Me.lblDescriptionHeader.Name = "lblDescriptionHeader"
        Me.lblDescriptionHeader.Size = New System.Drawing.Size(194, 32)
        Me.lblDescriptionHeader.TabIndex = 28
        Me.lblDescriptionHeader.Text = "Gewinn bei:"
        '
        'lblCoinsValue
        '
        Me.lblCoinsValue.BackColor = Color.White
        Me.lblCoinsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCoinsValue.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinsValue.Location = New System.Drawing.Point(213, 287)
        Me.lblCoinsValue.Name = "lblCoinsValue"
        Me.lblCoinsValue.Size = New System.Drawing.Size(199, 44)
        Me.lblCoinsValue.TabIndex = 25
        Me.lblCoinsValue.Text = "0"
        Me.lblCoinsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStake
        '
        Me.lblStake.AutoSize = True
        Me.lblStake.BackColor = Color.Transparent
        Me.lblStake.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStake.Location = New System.Drawing.Point(99, 236)
        Me.lblStake.Name = "lblStake"
        Me.lblStake.Size = New System.Drawing.Size(109, 29)
        Me.lblStake.TabIndex = 24
        Me.lblStake.Text = "Einsatz:"
        '
        'lblStakeValue
        '
        Me.lblStakeValue.BackColor = Color.White
        Me.lblStakeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStakeValue.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStakeValue.Location = New System.Drawing.Point(213, 228)
        Me.lblStakeValue.Name = "lblStakeValue"
        Me.lblStakeValue.Size = New System.Drawing.Size(200, 48)
        Me.lblStakeValue.TabIndex = 23
        Me.lblStakeValue.Text = "10"
        Me.lblStakeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCoins
        '
        Me.lblCoins.AutoSize = True
        Me.lblCoins.BackColor = Color.Transparent
        Me.lblCoins.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoins.Location = New System.Drawing.Point(118, 293)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(90, 29)
        Me.lblCoins.TabIndex = 20
        Me.lblCoins.Text = "Coins:"
        '
        'lblSlot3
        '
        Me.lblSlot3.BackColor = Color.White
        Me.lblSlot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlot3.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot3.Location = New System.Drawing.Point(420, 18)
        Me.lblSlot3.Name = "lblSlot3"
        Me.lblSlot3.Size = New System.Drawing.Size(200, 200)
        Me.lblSlot3.TabIndex = 18
        Me.lblSlot3.Text = "1"
        Me.lblSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlot2
        '
        Me.lblSlot2.BackColor = Color.White
        Me.lblSlot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlot2.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot2.Location = New System.Drawing.Point(214, 18)
        Me.lblSlot2.Name = "lblSlot2"
        Me.lblSlot2.Size = New System.Drawing.Size(200, 200)
        Me.lblSlot2.TabIndex = 17
        Me.lblSlot2.Text = "1"
        Me.lblSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlot1
        '
        Me.lblSlot1.BackColor = Color.White
        Me.lblSlot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlot1.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot1.Location = New System.Drawing.Point(8, 18)
        Me.lblSlot1.Name = "lblSlot1"
        Me.lblSlot1.Size = New System.Drawing.Size(200, 200)
        Me.lblSlot1.TabIndex = 16
        Me.lblSlot1.Text = "1"
        Me.lblSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStakeChange
        '
        Me.lblStakeChange.AutoSize = True
        Me.lblStakeChange.BackColor = Color.Transparent
        Me.lblStakeChange.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStakeChange.Location = New System.Drawing.Point(257, 387)
        Me.lblStakeChange.Name = "lblStakeChange"
        Me.lblStakeChange.Size = New System.Drawing.Size(109, 29)
        Me.lblStakeChange.TabIndex = 36
        Me.lblStakeChange.Text = "Einsatz:"
        Me.lblStakeChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(420, 228)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(374, 47)
        Me.lblStatus.TabIndex = 32
        Me.lblStatus.Text = "Bereit zum drehen"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SlotMachine
        '
        Me.Icon = My.Resources.TamagotchiIcon
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(809, 456)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblStakeChange)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDescriptionHeader)
        Me.Controls.Add(Me.lblCoinsValue)
        Me.Controls.Add(Me.lblStake)
        Me.Controls.Add(Me.lblStakeValue)
        Me.Controls.Add(Me.lblCoins)
        Me.Controls.Add(Me.lblSlot3)
        Me.Controls.Add(Me.lblSlot2)
        Me.Controls.Add(Me.lblSlot1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 495)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 495)
        Me.Name = "SlotMachine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tamagotchi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrSpinSlot As Timer
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDescriptionHeader As Label
    Friend WithEvents lblCoinsValue As Label
    Friend WithEvents lblStake As Label
    Friend WithEvents lblStakeValue As Label
    Friend WithEvents lblCoins As Label
    Friend WithEvents lblSlot3 As Label
    Friend WithEvents lblSlot2 As Label
    Friend WithEvents lblSlot1 As Label
    Friend WithEvents lblStakeChange As Label
    Friend WithEvents lblStatus As Label
End Class

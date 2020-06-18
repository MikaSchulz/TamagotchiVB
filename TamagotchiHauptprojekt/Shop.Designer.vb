<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shop
    Inherits Selector
    'Inherits System.Windows.Forms.Form
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblCoinsValue = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblBread = New System.Windows.Forms.Label()
        Me.lblSalad = New System.Windows.Forms.Label()
        Me.lblLasagne = New System.Windows.Forms.Label()
        Me.lblWater = New System.Windows.Forms.Label()
        Me.lblMilk = New System.Windows.Forms.Label()
        Me.lblEnergy = New System.Windows.Forms.Label()
        Me.timerFreeItems = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.White
        Me.lblHeader.Font = New System.Drawing.Font("MS Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(255, 31)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(357, 27)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Was möchtest du kaufen?"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCoinsValue
        '
        Me.lblCoinsValue.AutoSize = True
        Me.lblCoinsValue.BackColor = System.Drawing.Color.White
        Me.lblCoinsValue.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinsValue.Location = New System.Drawing.Point(0, 60)
        Me.lblCoinsValue.Name = "lblCoinsValue"
        Me.lblCoinsValue.Size = New System.Drawing.Size(66, 18)
        Me.lblCoinsValue.TabIndex = 27
        Me.lblCoinsValue.Text = "Coins: "
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(210, 60)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = "Wechseln: ⬅️ oder ➡️" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Festlegen: ⬆️ oder ⬇️"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBread
        '
        Me.lblBread.BackColor = System.Drawing.Color.White
        Me.lblBread.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBread.Location = New System.Drawing.Point(51, 221)
        Me.lblBread.Name = "lblBread"
        Me.lblBread.Size = New System.Drawing.Size(170, 38)
        Me.lblBread.TabIndex = 15
        Me.lblBread.Text = "Brot : Kostenlos"
        Me.lblBread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalad
        '
        Me.lblSalad.BackColor = System.Drawing.Color.White
        Me.lblSalad.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalad.Location = New System.Drawing.Point(310, 221)
        Me.lblSalad.Name = "lblSalad"
        Me.lblSalad.Size = New System.Drawing.Size(170, 38)
        Me.lblSalad.TabIndex = 16
        Me.lblSalad.Text = "Salat : 10 C"
        Me.lblSalad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLasagne
        '
        Me.lblLasagne.BackColor = System.Drawing.Color.White
        Me.lblLasagne.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLasagne.Location = New System.Drawing.Point(569, 221)
        Me.lblLasagne.Name = "lblLasagne"
        Me.lblLasagne.Size = New System.Drawing.Size(170, 38)
        Me.lblLasagne.TabIndex = 17
        Me.lblLasagne.Text = "Lasagne : 15 C"
        Me.lblLasagne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWater
        '
        Me.lblWater.BackColor = System.Drawing.Color.White
        Me.lblWater.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWater.Location = New System.Drawing.Point(51, 394)
        Me.lblWater.Name = "lblWater"
        Me.lblWater.Size = New System.Drawing.Size(170, 38)
        Me.lblWater.TabIndex = 18
        Me.lblWater.Text = "Wasser : Kostenlos"
        Me.lblWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMilk
        '
        Me.lblMilk.BackColor = System.Drawing.Color.White
        Me.lblMilk.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilk.Location = New System.Drawing.Point(310, 394)
        Me.lblMilk.Name = "lblMilk"
        Me.lblMilk.Size = New System.Drawing.Size(170, 38)
        Me.lblMilk.TabIndex = 19
        Me.lblMilk.Text = "Milch : 10 C"
        Me.lblMilk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnergy
        '
        Me.lblEnergy.BackColor = System.Drawing.Color.White
        Me.lblEnergy.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnergy.Location = New System.Drawing.Point(569, 394)
        Me.lblEnergy.Name = "lblEnergy"
        Me.lblEnergy.Size = New System.Drawing.Size(170, 38)
        Me.lblEnergy.TabIndex = 20
        Me.lblEnergy.Text = "Energy : 15 C"
        Me.lblEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerFreeItems
        '
        Me.timerFreeItems.Enabled = True
        Me.timerFreeItems.Interval = 1000
        '
        'Shop
        '
        Me.Icon = My.Resources.TamagotchiIcon
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.ResourceManager.GetObject(Utils.GetBackground(TamagotchiManager.Instance.GetTamagotchi.GetBackground))
        Me.ClientSize = New System.Drawing.Size(809, 456)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblBread)
        Me.Controls.Add(Me.lblSalad)
        Me.Controls.Add(Me.lblLasagne)
        Me.Controls.Add(Me.lblWater)
        Me.Controls.Add(Me.lblMilk)
        Me.Controls.Add(Me.lblEnergy)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblCoinsValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 495)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 495)
        Me.Name = "Shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tamagotchi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblCoinsValue As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblBread As Label
    Friend WithEvents lblSalad As Label
    Friend WithEvents lblLasagne As Label
    Friend WithEvents lblWater As Label
    Friend WithEvents lblMilk As Label
    Friend WithEvents lblEnergy As Label
    Friend WithEvents timerFreeItems As Timer
End Class

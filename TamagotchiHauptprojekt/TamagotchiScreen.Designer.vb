<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TamagotchiScreen
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHydration = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblFun = New System.Windows.Forms.Label()
        Me.lblLove = New System.Windows.Forms.Label()
        Me.timerBar = New System.Windows.Forms.Timer(Me.components)
        Me.timerLove = New System.Windows.Forms.Timer(Me.components)
        Me.lblCoinsValue = New System.Windows.Forms.Label()
        Me.lblExhaustion = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pbxExhaustion = New System.Windows.Forms.PictureBox()
        Me.pbxExhaustionBack = New System.Windows.Forms.PictureBox()
        Me.pbxLove = New System.Windows.Forms.PictureBox()
        Me.pbxFood = New System.Windows.Forms.PictureBox()
        Me.pbxFun = New System.Windows.Forms.PictureBox()
        Me.pbxHydration = New System.Windows.Forms.PictureBox()
        Me.pbxHydrationBack = New System.Windows.Forms.PictureBox()
        Me.pbxFoodBack = New System.Windows.Forms.PictureBox()
        Me.pbxFunBack = New System.Windows.Forms.PictureBox()
        Me.pbxLoveBack = New System.Windows.Forms.PictureBox()
        CType(Me.pbxExhaustion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxExhaustionBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHydration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHydrationBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFoodBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFunBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLoveBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 23)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name: "
        '
        'lblHydration
        '
        Me.lblHydration.BackColor = System.Drawing.Color.White
        Me.lblHydration.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHydration.Location = New System.Drawing.Point(515, 12)
        Me.lblHydration.Name = "lblHydration"
        Me.lblHydration.Size = New System.Drawing.Size(98, 25)
        Me.lblHydration.TabIndex = 14
        Me.lblHydration.Text = "Hydration:"
        Me.lblHydration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFood
        '
        Me.lblFood.BackColor = System.Drawing.Color.White
        Me.lblFood.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFood.Location = New System.Drawing.Point(515, 37)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(98, 25)
        Me.lblFood.TabIndex = 15
        Me.lblFood.Text = "Essen:"
        Me.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFun
        '
        Me.lblFun.BackColor = System.Drawing.Color.White
        Me.lblFun.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFun.Location = New System.Drawing.Point(515, 62)
        Me.lblFun.Name = "lblFun"
        Me.lblFun.Size = New System.Drawing.Size(98, 25)
        Me.lblFun.TabIndex = 16
        Me.lblFun.Text = "Spaß:"
        Me.lblFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLove
        '
        Me.lblLove.BackColor = System.Drawing.Color.White
        Me.lblLove.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLove.Location = New System.Drawing.Point(515, 87)
        Me.lblLove.Name = "lblLove"
        Me.lblLove.Size = New System.Drawing.Size(98, 25)
        Me.lblLove.TabIndex = 17
        Me.lblLove.Text = "Liebe:"
        Me.lblLove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'timerBar
        '
        Me.timerBar.Enabled = True
        Me.timerBar.Interval = 1000
        '
        'timerLove
        '
        Me.timerLove.Enabled = False
        Me.timerLove.Interval = 500
        '
        'lblCoinsValue
        '
        Me.lblCoinsValue.AutoSize = True
        Me.lblCoinsValue.BackColor = System.Drawing.Color.White
        Me.lblCoinsValue.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinsValue.Location = New System.Drawing.Point(13, 43)
        Me.lblCoinsValue.Name = "lblCoinsValue"
        Me.lblCoinsValue.Size = New System.Drawing.Size(66, 18)
        Me.lblCoinsValue.TabIndex = 27
        Me.lblCoinsValue.Text = "Coins: "
        '
        'lblExhaustion
        '
        Me.lblExhaustion.BackColor = System.Drawing.Color.White
        Me.lblExhaustion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExhaustion.Location = New System.Drawing.Point(515, 112)
        Me.lblExhaustion.Name = "lblExhaustion"
        Me.lblExhaustion.Size = New System.Drawing.Size(98, 25)
        Me.lblExhaustion.TabIndex = 29
        Me.lblExhaustion.Text = "Ausdauer:"
        Me.lblExhaustion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(0, 396)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(210, 60)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Wechseln: ⬅️ oder ➡️" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Festlegen: ⬆️ oder ⬇️"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxExhaustion
        '
        Me.pbxExhaustion.BackColor = System.Drawing.Color.Magenta
        Me.pbxExhaustion.Location = New System.Drawing.Point(617, 116)
        Me.pbxExhaustion.Name = "pbxExhaustion"
        Me.pbxExhaustion.Size = New System.Drawing.Size(177, 17)
        Me.pbxExhaustion.TabIndex = 28
        Me.pbxExhaustion.TabStop = False
        '
        'pbxExhaustionBack
        '
        Me.pbxExhaustionBack.BackColor = System.Drawing.Color.Black
        Me.pbxExhaustionBack.Location = New System.Drawing.Point(613, 112)
        Me.pbxExhaustionBack.Name = "pbxExhaustionBack"
        Me.pbxExhaustionBack.Size = New System.Drawing.Size(185, 25)
        Me.pbxExhaustionBack.TabIndex = 30
        Me.pbxExhaustionBack.TabStop = False
        '
        'pbxLove
        '
        Me.pbxLove.BackColor = System.Drawing.Color.Salmon
        Me.pbxLove.Location = New System.Drawing.Point(617, 91)
        Me.pbxLove.Name = "pbxLove"
        Me.pbxLove.Size = New System.Drawing.Size(177, 17)
        Me.pbxLove.TabIndex = 4
        Me.pbxLove.TabStop = False
        '
        'pbxFood
        '
        Me.pbxFood.BackColor = System.Drawing.Color.LimeGreen
        Me.pbxFood.Location = New System.Drawing.Point(617, 41)
        Me.pbxFood.Name = "pbxFood"
        Me.pbxFood.Size = New System.Drawing.Size(177, 17)
        Me.pbxFood.TabIndex = 3
        Me.pbxFood.TabStop = False
        '
        'pbxFun
        '
        Me.pbxFun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbxFun.Location = New System.Drawing.Point(617, 66)
        Me.pbxFun.Name = "pbxFun"
        Me.pbxFun.Size = New System.Drawing.Size(177, 17)
        Me.pbxFun.TabIndex = 2
        Me.pbxFun.TabStop = False
        '
        'pbxHydration
        '
        Me.pbxHydration.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pbxHydration.Location = New System.Drawing.Point(617, 16)
        Me.pbxHydration.Name = "pbxHydration"
        Me.pbxHydration.Size = New System.Drawing.Size(177, 17)
        Me.pbxHydration.TabIndex = 1
        Me.pbxHydration.TabStop = False
        '
        'pbxHydrationBack
        '
        Me.pbxHydrationBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbxHydrationBack.Location = New System.Drawing.Point(613, 12)
        Me.pbxHydrationBack.Name = "pbxHydrationBack"
        Me.pbxHydrationBack.Size = New System.Drawing.Size(185, 25)
        Me.pbxHydrationBack.TabIndex = 24
        Me.pbxHydrationBack.TabStop = False
        '
        'pbxFoodBack
        '
        Me.pbxFoodBack.BackColor = System.Drawing.Color.Black
        Me.pbxFoodBack.Location = New System.Drawing.Point(613, 37)
        Me.pbxFoodBack.Name = "pbxFoodBack"
        Me.pbxFoodBack.Size = New System.Drawing.Size(185, 25)
        Me.pbxFoodBack.TabIndex = 23
        Me.pbxFoodBack.TabStop = False
        '
        'pbxFunBack
        '
        Me.pbxFunBack.BackColor = System.Drawing.Color.Black
        Me.pbxFunBack.Location = New System.Drawing.Point(613, 62)
        Me.pbxFunBack.Name = "pbxFunBack"
        Me.pbxFunBack.Size = New System.Drawing.Size(185, 25)
        Me.pbxFunBack.TabIndex = 22
        Me.pbxFunBack.TabStop = False
        '
        'pbxLoveBack
        '
        Me.pbxLoveBack.BackColor = System.Drawing.Color.Black
        Me.pbxLoveBack.Location = New System.Drawing.Point(613, 87)
        Me.pbxLoveBack.Name = "pbxLoveBack"
        Me.pbxLoveBack.Size = New System.Drawing.Size(185, 25)
        Me.pbxLoveBack.TabIndex = 21
        Me.pbxLoveBack.TabStop = False
        '
        'TamagotchiScreen
        '
        Me.Icon = My.Resources.TamagotchiIcon
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 456)
        Me.BackgroundImage = My.Resources.ResourceManager.GetObject(Utils.GetBackground(TamagotchiManager.Instance.GetTamagotchi.GetBackground))
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblExhaustion)
        Me.Controls.Add(Me.pbxExhaustion)
        Me.Controls.Add(Me.pbxExhaustionBack)
        Me.Controls.Add(Me.lblCoinsValue)
        Me.Controls.Add(Me.lblLove)
        Me.Controls.Add(Me.lblFun)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.lblHydration)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbxLove)
        Me.Controls.Add(Me.pbxFood)
        Me.Controls.Add(Me.pbxFun)
        Me.Controls.Add(Me.pbxHydration)
        Me.Controls.Add(Me.pbxHydrationBack)
        Me.Controls.Add(Me.pbxFoodBack)
        Me.Controls.Add(Me.pbxFunBack)
        Me.Controls.Add(Me.pbxLoveBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 495)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 495)
        Me.Name = "TamagotchiScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tamagotchi"
        CType(Me.pbxExhaustion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxExhaustionBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHydration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHydrationBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFoodBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFunBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLoveBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxLoveBack As PictureBox
    Friend WithEvents pbxFunBack As PictureBox
    Friend WithEvents pbxFoodBack As PictureBox
    Friend WithEvents pbxHydrationBack As PictureBox
    Friend WithEvents pbxHydration As PictureBox
    Friend WithEvents pbxFun As PictureBox
    Friend WithEvents pbxFood As PictureBox
    Friend WithEvents pbxLove As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblHydration As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents lblFun As Label
    Friend WithEvents lblLove As Label
    Private WithEvents timerBar As Timer
    Private WithEvents timerLove As Timer
    Friend WithEvents lblCoinsValue As Label
    Friend WithEvents lblExhaustion As Label
    Friend WithEvents pbxExhaustion As PictureBox
    Friend WithEvents pbxExhaustionBack As PictureBox
    Friend WithEvents lblInfo As Label
End Class

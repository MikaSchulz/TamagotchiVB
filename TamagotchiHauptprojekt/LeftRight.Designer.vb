<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeftRight
    Inherits Selector

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LeftRightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblHighscore = New System.Windows.Forms.Label()
        Me.pbxLeft = New System.Windows.Forms.PictureBox()
        Me.pbxRight = New System.Windows.Forms.PictureBox()
        Me.pbxMid = New System.Windows.Forms.PictureBox()
        Me.lblNewHighscore = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        CType(Me.pbxLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftRightTimer
        '
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BackColor = Color.White
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(12, 9)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(103, 25)
        Me.lblPoints.TabIndex = 12
        Me.lblPoints.Text = "Punkte: 0"
        '
        'lblHighscore
        '
        Me.lblHighscore.AutoSize = True
        Me.lblHighscore.BackColor = Color.White
        Me.lblHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighscore.Location = New System.Drawing.Point(12, 34)
        Me.lblHighscore.Name = "lblHighscore"
        Me.lblHighscore.Size = New System.Drawing.Size(133, 25)
        Me.lblHighscore.TabIndex = 13
        Me.lblHighscore.Text = "Highscore: 0"
        '
        'pbxLeft
        '
        Me.pbxLeft.BackColor = System.Drawing.Color.Transparent
        Me.pbxLeft.Location = New System.Drawing.Point(253, 123)
        Me.pbxLeft.Name = "pbxLeft"
        Me.pbxLeft.Size = New System.Drawing.Size(300, 235)
        Me.pbxLeft.TabIndex = 14
        Me.pbxLeft.TabStop = False
        Me.pbxLeft.Visible = False
        '
        'pbxRight
        '
        Me.pbxRight.BackColor = System.Drawing.Color.Transparent
        Me.pbxRight.Location = New System.Drawing.Point(253, 123)
        Me.pbxRight.Name = "pbxRight"
        Me.pbxRight.Size = New System.Drawing.Size(300, 235)
        Me.pbxRight.TabIndex = 15
        Me.pbxRight.TabStop = False
        Me.pbxRight.Visible = False
        '
        'pbxMid
        '
        Me.pbxMid.BackColor = System.Drawing.Color.Transparent
        Me.pbxMid.Location = New System.Drawing.Point(249, 123)
        Me.pbxMid.Name = "pbxMid"
        Me.pbxMid.Size = New System.Drawing.Size(310, 300)
        Me.pbxMid.TabIndex = 16
        Me.pbxMid.TabStop = False
        Me.pbxMid.Visible = False
        '
        'lblNewHighscore
        '
        Me.lblNewHighscore.AutoSize = True
        Me.lblNewHighscore.BackColor = System.Drawing.Color.White
        Me.lblNewHighscore.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewHighscore.ForeColor = System.Drawing.Color.Black
        Me.lblNewHighscore.Location = New System.Drawing.Point(242, 82)
        Me.lblNewHighscore.Name = "lblNewHighscore"
        Me.lblNewHighscore.Size = New System.Drawing.Size(329, 38)
        Me.lblNewHighscore.TabIndex = 17
        Me.lblNewHighscore.Text = "Neuer Highscore!"
        Me.lblNewHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(601, 270)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(210, 186)
        Me.lblDescription.TabIndex = 23
        Me.lblDescription.Text = "Drücke in die gleiche Richtung wie das Tamagotchi guckt." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Achtung es wird schneller!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Benutze: ⬅️ oder ➡️"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeftRight
        '
        Me.Icon = My.Resources.TamagotchiIcon
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.ResourceManager.GetObject(Utils.GetBackground(TamagotchiManager.Instance.GetTamagotchi.GetBackground))
        Me.ClientSize = New System.Drawing.Size(809, 456)
        Me.Controls.Add(Me.lblNewHighscore)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.pbxMid)
        Me.Controls.Add(Me.pbxRight)
        Me.Controls.Add(Me.pbxLeft)
        Me.Controls.Add(Me.lblHighscore)
        Me.Controls.Add(Me.lblPoints)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 495)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 495)
        Me.Name = "LeftRight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tamagotchi"
        CType(Me.pbxLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LeftRightTimer As Timer
    Friend WithEvents lblPoints As Label
    Friend WithEvents lblHighscore As Label
    Friend WithEvents pbxLeft As PictureBox
    Friend WithEvents pbxRight As PictureBox
    Friend WithEvents pbxMid As PictureBox
    Friend WithEvents lblNewHighscore As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblDescription As Label
End Class

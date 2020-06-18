<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Minigames
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
        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 456)
        Me.BackgroundImage = My.Resources.ResourceManager.GetObject(Utils.GetBackground(TamagotchiManager.Instance.GetTamagotchi.GetBackground))

        'Picturebox1
        Me.pbxLR = New Windows.Forms.PictureBox()
        Me.pbxMR = New Windows.Forms.PictureBox()
        Me.pbxSL = New Windows.Forms.PictureBox()
        Me.lblInfo = New Windows.Forms.Label()
        Me.lblHeader = New Windows.Forms.Label()
        Me.lblAttention = New Windows.Forms.Label()
        CType(Me.pbxMR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pbxLR.Image = My.Resources.Resources.leftright
        Me.pbxLR.Location = New System.Drawing.Point(25, 140)
        Me.pbxLR.Name = "pbxLR"
        Me.pbxLR.Size = New System.Drawing.Size(234, 130)
        Me.pbxMR.Image = My.Resources.Resources.memory
        Me.pbxMR.Location = New System.Drawing.Point(287, 140)
        Me.pbxMR.Name = "pbxMR"
        Me.pbxMR.Size = New System.Drawing.Size(234, 130)
        Me.pbxSL.Image = My.Resources.Resources.slotmachine
        Me.pbxSL.Location = New System.Drawing.Point(549, 140)
        Me.pbxSL.Name = "pbxSL"
        Me.pbxSL.Size = New System.Drawing.Size(234, 130)
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
        Me.lblInfo.TabIndex = 21
        Me.lblInfo.Text = "Wechseln: ⬅️ oder ➡️" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Festlegen: ⬆️ oder ⬇️"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAttention
        '
        Me.lblAttention.Visible = False
        Me.lblAttention.AutoSize = False
        Me.lblAttention.Location = New System.Drawing.Point(25, 350)
        Me.lblAttention.Text = """Ich möchte nicht!"""
        Me.lblAttention.Font = New Font("Verdana", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttention.Size = New System.Drawing.Size(234, 30)
        Me.lblAttention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeader
        '
        Me.Icon = My.Resources.TamagotchiIcon
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.White
        Me.lblHeader.Font = New System.Drawing.Font("MS Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(26, 39)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(567, 27)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Welches Minispiel möchtest du spielen?"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Controls.Add(Me.pbxLR)
        Me.Controls.Add(Me.pbxMR)
        Me.Controls.Add(Me.pbxSL)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblAttention)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 495)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 495)
        Me.Name = "Minigames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tamagotchi"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pbxLR As PictureBox
    Friend WithEvents pbxMR As PictureBox
    Friend WithEvents pbxSL As PictureBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblAttention As Label
End Class

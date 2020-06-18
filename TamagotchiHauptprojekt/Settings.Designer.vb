<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.White
        Me.lblHeader.Font = New System.Drawing.Font("MS Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(278, 42)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(221, 29)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Einstellungen"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDifficulty
        '
        Me.lblDifficulty.BackColor = System.Drawing.Color.LightYellow
        Me.lblDifficulty.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.ForeColor = System.Drawing.Color.Black
        Me.lblDifficulty.Location = New System.Drawing.Point(333, 141)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(347, 29)
        Me.lblDifficulty.TabIndex = 10
        Me.lblDifficulty.Text = "Schwierigkeitsgrad"
        Me.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.LightYellow
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(480, 183)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(200, 138)
        Me.lblDescription.TabIndex = 14
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Settings
        '
        Me.Icon = My.Resources.TamagotchiIcon
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 456)
        Me.BackgroundImage = My.Resources.ResourceManager.GetObject(Utils.GetBackground(TamagotchiManager.Instance.GetTamagotchi.GetBackground))
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 495)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 495)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tamagotchi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents lblDescription As Label
End Class

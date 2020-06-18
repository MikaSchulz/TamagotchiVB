<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dead
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
        Me.pbxGravestone = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.pbxGravestone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxGravestone
        '
        Me.pbxGravestone.BackColor = System.Drawing.Color.Transparent
        Me.pbxGravestone.Image = My.Resources.Resources.Grabstein
        Me.pbxGravestone.Location = New System.Drawing.Point(260, 41)
        Me.pbxGravestone.Name = "pbxGravestone"
        Me.pbxGravestone.Size = New System.Drawing.Size(290, 304)
        Me.pbxGravestone.TabIndex = 0
        Me.pbxGravestone.TabStop = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(277, 296)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(258, 34)
        Me.lblName.TabIndex = 1
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dead
        '
        Me.Icon = My.Resources.TamagotchiIcon
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(809, 456)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbxGravestone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 495)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 495)
        Me.Name = "Dead"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tamagotchi"
        CType(Me.pbxGravestone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxGravestone As PictureBox
    Friend WithEvents lblName As Label
End Class

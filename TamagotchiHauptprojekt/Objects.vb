Public Class Objects
    Public Function GetBack() As Label
        Dim lblBack As New Label() With {
            .AutoSize = False,
            .BackColor = Color.Silver,
            .Font = New Font("Verdana", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .Text = "Zurück",
            .Left = 657,
            .Top = 18,
            .Width = 140,
            .Height = 50,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        Return lblBack
    End Function

    Public Function GetLeftRightElements() As Object()
        Dim lblStart As New Label() With {
           .BackColor = Color.Silver,
            .Font = New Font("Verdana", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .Location = New Point(309, 220),
            .Name = "lblStart",
            .Size = New Size(200, 50),
            .TabIndex = 21,
            .Text = "Start",
            .TextAlign = ContentAlignment.MiddleCenter
        }
        Return New Object() {lblStart, GetBack()}
    End Function

    Public Function GetBackgroundElements() As Object()

        Dim pbxBack0 As New PictureBoxTransparent() With {
            .Left = 12,
            .Top = 143,
            .Width = 240,
            .Height = 144,
            .Bitmap = My.Resources.Background0
        }
        Dim pbxBack1 As New PictureBoxTransparent() With {
            .Left = 285,
            .Top = 143,
            .Width = 240,
            .Height = 144,
            .Bitmap = My.Resources.Background1
        }
        Dim pbxBack2 As New PictureBoxTransparent With {
            .Left = 557,
            .Top = 143,
            .Width = 240,
            .Height = 144,
            .Bitmap = My.Resources.Background2
        }
        Return New Object() {pbxBack0, pbxBack1, pbxBack2, GetBack()}
    End Function

    Public Function GetShopElements() As Object()
        Dim pbxShop5 As New PictureBoxTransparent With {
            .Location = New Point(579, 277),
            .Size = New Size(150, 100),
            .Bitmap = My.Resources.energy_drink
        }

        Dim pbxShop4 As New PictureBoxTransparent With {
            .Location = New Point(320, 277),
            .Size = New Size(150, 100),
            .Bitmap = My.Resources.milk
        }

        Dim pbxShop3 As New PictureBoxTransparent With {
            .Location = New Point(61, 277),
            .Size = New Size(150, 100),
            .Bitmap = My.Resources.water_bottle
        }

        Dim pbxShop2 As New PictureBoxTransparent With {
            .Location = New Point(579, 102),
            .Size = New Size(150, 100),
            .Bitmap = My.Resources.lasagna
        }

        Dim pbxShop1 As New PictureBoxTransparent With {
            .Location = New Point(320, 102),
            .Size = New Size(150, 100),
            .Bitmap = My.Resources.salad
        }

        Dim pbxShop0 As New PictureBoxTransparent With {
            .Location = New Point(61, 102),
            .Size = New Size(150, 100),
            .Bitmap = My.Resources.bread
        }

        Return New Object() {pbxShop0, pbxShop1, pbxShop2, pbxShop3, pbxShop4, pbxShop5, GetBack()}
    End Function

    Public Function GetSlotMachineElements() As Object()
        Dim lblPull As New Label() With {
            .AutoSize = False,
            .Font = New Font("Verdana", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = Color.Silver,
            .Text = "Ziehen",
            .Left = 33,
            .Top = 376,
            .Width = 200,
            .Height = 50
        }

        Dim lblStakePlus As New Label() With {
            .AutoSize = False,
            .Font = New Font("Verdana", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = Color.Silver,
            .Text = "+",
            .Left = 368,
            .Top = 376,
            .Width = 50,
            .Height = 50
        }
        Dim lblStakeMinus As New Label() With {
            .AutoSize = False,
            .Font = New Font("Verdana", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = Color.Silver,
            .Text = "-",
            .Left = 429,
            .Top = 376,
            .Width = 50,
            .Height = 50
        }

        Return New Label() {lblPull, lblStakePlus, lblStakeMinus, GetBack()}
    End Function

    Public Function GetCharacterElements() As Object()
        Dim pbxCat As New PictureBoxTransparent() With {
            .Left = 9,
            .Top = 126,
            .Width = 256,
            .Height = 194,
            .Bitmap = My.Resources.CatHappy
        }
        Dim pbxDog As New PictureBoxTransparent() With {
            .Left = 275,
            .Top = 126,
            .Width = 256,
            .Height = 194,
            .Bitmap = My.Resources.DogHappy
        }
        Dim pbxOX As New PictureBoxTransparent() With {
            .Left = 544,
            .Top = 126,
            .Width = 256,
            .Height = 194,
            .Bitmap = My.Resources.OXHappy
        }

        Return New PictureBoxTransparent() {pbxCat, pbxDog, pbxOX}
    End Function

    Public Function GetMinigameLabels() As Object()
        Dim lblLeftRight As New Label() With {
            .AutoSize = False,
            .Font = New Font("Verdana", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = Color.Silver,
            .Text = "Left Right",
            .Left = 25,
            .Top = 288,
            .Width = 234,
            .Height = 48
        }
        Dim lblMemory As New Label() With {
            .AutoSize = False,
            .Font = New Font("Verdana", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = Color.Silver,
            .Text = "Memory",
            .Left = 287,
            .Top = 288,
            .Width = 234,
            .Height = 48
            }
        Dim lblSlotmachine As New Label() With {
            .AutoSize = False,
            .Font = New Font("Verdana", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = Color.Silver,
            .Text = "Slot machine",
            .Left = 549,
            .Top = 288,
            .Width = 234,
            .Height = 48
            }

        Return New Label() {lblLeftRight, lblMemory, lblSlotmachine, GetBack()}
    End Function

    Public Function GetTamagotchiScreen() As Object()
        Dim pbxSettings As New PictureBoxTransparent With {
            .Location = New Point(12, 70),
            .Size = New Size(65, 65),
            .Bitmap = My.Resources.settings
        }
        Dim pbxShop As New PictureBoxTransparent With {
            .Location = New Point(60, 232),
            .Size = New Size(150, 150),
            .Bitmap = My.Resources.shop
        }

        Dim pbxActions As New PictureBoxTransparent With {
            .Location = New Point(330, 307),
            .Size = New Size(150, 75),
            .Bitmap = My.Resources.gaming
        }

        Dim pbxCare As New PictureBoxTransparent With {
            .Location = New Point(599, 232),
            .Size = New Size(150, 150),
            .Bitmap = My.Resources.streicheln
        }

        Return New PictureBoxTransparent() {pbxSettings, pbxShop, pbxActions, pbxCare}
    End Function
    Public Function GetSettings() As Object()
        Dim pbxBackground As New PictureBoxTransparent With {
            .Location = New Point(130, 141),
            .Size = New Size(180, 180),
            .Bitmap = My.Resources.background
        }
        Dim lblEasy As New Label() With {
            .AutoSize = True,
            .Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .ForeColor = System.Drawing.Color.Black,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = System.Drawing.Color.LightYellow,
            .Text = "Einfach",
            .Left = 333,
            .Top = 183,
            .Width = 88,
            .Height = 25
        }
        Dim lblNormal As New Label() With {
            .AutoSize = True,
            .Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .ForeColor = System.Drawing.Color.Black,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = System.Drawing.Color.LightYellow,
            .Text = "Normal",
            .Left = 333,
            .Top = 219,
            .Width = 89,
            .Height = 25
        }
        Dim lblHard As New Label() With {
            .AutoSize = True,
            .Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .ForeColor = System.Drawing.Color.Black,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = System.Drawing.Color.LightYellow,
            .Text = "Schwer",
            .Left = 333,
            .Top = 257,
            .Width = 89,
            .Height = 25
        }
        Dim lblFreeGame As New Label() With {
            .AutoSize = True,
            .Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .ForeColor = System.Drawing.Color.Black,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = System.Drawing.Color.LightYellow,
            .Text = "Freies Spiel",
            .Left = 333,
            .Top = 296,
            .Width = 135,
            .Height = 25
        }
        Return New Object() {pbxBackground, lblEasy, lblNormal, lblHard, lblFreeGame, GetBack()}

    End Function

    Public Function GetDead() As Object()
        Dim lblRestart As New Label() With {
            .AutoSize = False,
            .Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .ForeColor = System.Drawing.Color.Black,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = System.Drawing.Color.Silver,
            .Text = "Neustarten",
            .Left = 189,
            .Top = 372,
            .Width = 197,
            .Height = 50
        }
        Dim lblRevive As New Label() With {
            .AutoSize = False,
            .Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .ForeColor = System.Drawing.Color.Black,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BackColor = System.Drawing.Color.Silver,
            .Text = "Wiederbeleben",
            .Left = 424,
            .Top = 372,
            .Width = 197,
            .Height = 50
        }

        Return New Label() {lblRestart, lblRevive}
    End Function
    ''
    ''lblFreeGame
    ''
    'Me.lblFreeGame.AutoSize = True
    'Me.lblFreeGame.BackColor = System.Drawing.Color.LightYellow
    'Me.lblFreeGame.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    'Me.lblFreeGame.ForeColor = System.Drawing.Color.Black
    'Me.lblFreeGame.Location = New System.Drawing.Point(333, 296)
    'Me.lblFreeGame.Name = "lblFreeGame"
    'Me.lblFreeGame.Size = New System.Drawing.Size(135, 25)
    'Me.lblFreeGame.TabIndex = 13
    'Me.lblFreeGame.Text = "Freies Spiel"
    'Me.lblFreeGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
End Class

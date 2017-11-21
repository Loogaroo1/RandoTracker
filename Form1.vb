Public Class Form1
    Dim Bow, Boomerang, Glove, Sword, Armor, Shield, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, CrystalCount, FairyCrystal, PendantCount, Available, AgaTree, Library, MazeRace, SpecRock, EtherTab, Floating, DPLedge, BombosTab, ZoraLedge, LakeIsle, Pedestal, Bumper As Integer
    Dim Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Form1_KeyDown() Handles Me.KeyDown
        If My.Computer.Keyboard.ShiftKeyDown Then
            EPLabel2.Text = "1"
            DPLabel2.Text = "2"
            TOHLabel2.Text = "3"
            PODLabel2.Text = "4"
            SPLabel2.Text = "5"
            SWLabel2.Text = "6"
            TTLabel2.Text = "7"
            IPLabel2.Text = "8"
            MMLabel2.Text = "9"
            TRLabel2.Text = "0"
        End If
    End Sub

    Private Sub Form1_KeyUp() Handles Me.KeyUp
        EPLabel2.Text = "EP"
        DPLabel2.Text = "DP"
        TOHLabel2.Text = "TOH"
        PODLabel2.Text = "POD"
        SPLabel2.Text = "SP"
        SWLabel2.Text = "SW"
        TTLabel2.Text = "TT"
        IPLabel2.Text = "IP"
        MMLabel2.Text = "MM"
        TRLabel2.Text = "TR"
    End Sub


    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case (e.KeyChar)
            Case "!"
                EPBoss.Checked = True
                EPBoss.Image = My.Resources.bossdead
                EPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then EPPrizes.Text = 0 Else EPChests.Text = 0
                EPLabel2.BackColor = Color.Green
            Case "@"
                DPBoss.Checked = True
                DPBoss.Image = My.Resources.bossdead
                DPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then DPPrizes.Text = 0 Else DPChests.Text = 0
                DPLabel2.BackColor = Color.Green
            Case "#"
                HeraBoss.Checked = True
                HeraBoss.Image = My.Resources.bossdead
                TOHLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then TOHPrizes.Text = 0 Else TOHChests.Text = 0
                TOHLabel2.BackColor = Color.Green
            Case "$"
                PODBoss.Checked = True
                PODBoss.Image = My.Resources.bossdead
                PODLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then PODPrizes.Text = 0 Else PODChests.Text = 0
                PODLabel2.BackColor = Color.Green
            Case "%"
                SPBoss.Checked = True
                SPBoss.Image = My.Resources.bossdead
                SPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then SPPrizes.Text = 0 Else SPChests.Text = 0
                SPLabel2.BackColor = Color.Green
            Case "^"
                SWBoss.Checked = True
                SWBoss.Image = My.Resources.bossdead
                SWLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then SWPrizes.Text = 0 Else SWChests.Text = 0
                SWLabel2.BackColor = Color.Green
            Case "&"
                TTBoss.Checked = True
                TTBoss.Image = My.Resources.bossdead
                TTLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then TTPrizes.Text = 0 Else TTChests.Text = 0
                TTLabel2.BackColor = Color.Green
            Case "*"
                IPBoss.Checked = True
                IPBoss.Image = My.Resources.bossdead
                IPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then IPPrizes.Text = 0 Else IPChests.Text = 0
                IPLabel2.BackColor = Color.Green
            Case "("
                MMBoss.Checked = True
                MMBoss.Image = My.Resources.bossdead
                MMLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then MMPrizes.Text = 0 Else MMChests.Text = 0
                MMLabel2.BackColor = Color.Green
            Case ")"
                TRBoss.Checked = True
                TRBoss.Image = My.Resources.bossdead
                TRLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then TRPrizes.Text = 0 Else TRChests.Text = 0
                TRLabel2.BackColor = Color.Green
        End Select
        CrystalCheck()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            HCKeys.Visible = False
            EPKeys.Visible = False
            EPMap.Visible = False
            EPBigKey.Visible = False
            DPKeys.Visible = False
            DPMap.Visible = False
            DPBigKey.Visible = False
            TOHKeys.Visible = False
            HeraMap.Visible = False
            HeraBigKey.Visible = False
            PODKeys.Visible = False
            PODMap.Visible = False
            PODBigKey.Visible = False
            SPKeys.Visible = False
            SPMap.Visible = False
            SPBigKey.Visible = False
            SWKeys.Visible = False
            SWMap.Visible = False
            SWBigKey.Visible = False
            TTKeys.Visible = False
            TTMap.Visible = False
            TTBigKey.Visible = False
            IPKeys.Visible = False
            IPMap.Visible = False
            IPBigKey.Visible = False
            MMKeys.Visible = False
            MMMap.Visible = False
            MMBigKey.Visible = False
            TRKeys.Visible = False
            TRMap.Visible = False
            TRBigKey.Visible = False
            AGLabel.Visible = False
            AGChests.Visible = False
            AGKeys.Visible = False
            GTLabel.Visible = False
            GTChests.Visible = False
            GTKeys.Visible = False
            GTMap.Visible = False
            GTBigKey.Visible = False
            HCPrizes.Visible = True
            EPPrizes.Visible = True
            DPPrizes.Visible = True
            TOHPrizes.Visible = True
            PODPrizes.Visible = True
            SPPrizes.Visible = True
            SWPrizes.Visible = True
            TTPrizes.Visible = True
            IPPrizes.Visible = True
            MMPrizes.Visible = True
            TRPrizes.Visible = True
            EPBoss.Left = 137
            DPBoss.Left = 137
            HeraBoss.Left = 137
            PODBoss.Left = 137
            SPBoss.Left = 137
            SWBoss.Left = 362
            TTBoss.Left = 362
            IPBoss.Left = 362
            MMBoss.Left = 362
            TRBoss.Left = 362
            EPReward = 0
            DPReward = 0
            TOHReward = 0
            PODReward = 0
            SPReward = 0
            SWReward = 0
            TTReward = 0
            IPReward = 0
            MMReward = 0
            TRReward = 0
            EPButton.Image = My.Resources.crystal
            DPButton.Image = My.Resources.crystal
            TOHButton.Image = My.Resources.crystal
            PODButton.Image = My.Resources.crystal
            SPButton.Image = My.Resources.crystal
            SWButton.Image = My.Resources.crystal
            TTButton.Image = My.Resources.crystal
            IPButton.Image = My.Resources.crystal
            MMButton.Image = My.Resources.crystal
            TRButton.Image = My.Resources.crystal
            HCChests.Text = 0
            AGChests.Text = 0
            EPChests.Text = 0
            DPChests.Text = 0
            TOHChests.Text = 0
            PODChests.Text = 0
            SPChests.Text = 0
            SWChests.Text = 0
            TTChests.Text = 0
            IPChests.Text = 0
            MMChests.Text = 0
            TRChests.Text = 0
            GTChests.Text = 0
            HCPrizes.Text = 6
            EPPrizes.Text = 3
            DPPrizes.Text = 2
            TOHPrizes.Text = 2
            PODPrizes.Text = 5
            SPPrizes.Text = 6
            SWPrizes.Text = 2
            TTPrizes.Text = 4
            IPPrizes.Text = 3
            MMPrizes.Text = 2
            TRPrizes.Text = 5
            HCCheck()
            EPCheck()
            DPCheck()
            TOHCheck()
            AgaCheck()
            PODCheck()
            SPCheck()
            SWCheck()
            TTCheck()
            IPCheck()
            MMCheck()
            TRCheck()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            HCKeys.Visible = True
            EPKeys.Visible = True
            EPMap.Visible = True
            EPBigKey.Visible = True
            DPKeys.Visible = True
            DPMap.Visible = True
            DPBigKey.Visible = True
            TOHKeys.Visible = True
            HeraMap.Visible = True
            HeraBigKey.Visible = True
            PODKeys.Visible = True
            PODMap.Visible = True
            PODBigKey.Visible = True
            SPKeys.Visible = True
            SPMap.Visible = True
            SPBigKey.Visible = True
            SWKeys.Visible = True
            SWMap.Visible = True
            SWBigKey.Visible = True
            TTKeys.Visible = True
            TTMap.Visible = True
            TTBigKey.Visible = True
            IPKeys.Visible = True
            IPMap.Visible = True
            IPBigKey.Visible = True
            MMKeys.Visible = True
            MMMap.Visible = True
            MMBigKey.Visible = True
            TRKeys.Visible = True
            TRMap.Visible = True
            TRBigKey.Visible = True
            AGLabel.Visible = True
            AGChests.Visible = True
            AGKeys.Visible = True
            GTLabel.Visible = True
            GTChests.Visible = True
            GTKeys.Visible = True
            GTMap.Visible = True
            GTBigKey.Visible = True
            HCPrizes.Visible = False
            EPPrizes.Visible = False
            DPPrizes.Visible = False
            TOHPrizes.Visible = False
            PODPrizes.Visible = False
            SPPrizes.Visible = False
            SWPrizes.Visible = False
            TTPrizes.Visible = False
            IPPrizes.Visible = False
            MMPrizes.Visible = False
            TRPrizes.Visible = False
            EPBoss.Left = 195
            DPBoss.Left = 195
            HeraBoss.Left = 195
            PODBoss.Left = 195
            SPBoss.Left = 195
            SWBoss.Left = 420
            TTBoss.Left = 420
            IPBoss.Left = 420
            MMBoss.Left = 420
            TRBoss.Left = 420
            EPReward = -1
            DPReward = -1
            TOHReward = -1
            PODReward = -1
            SPReward = -1
            SWReward = -1
            TTReward = -1
            IPReward = -1
            MMReward = -1
            TRReward = -1
            EPButton.Image = Nothing
            DPButton.Image = Nothing
            TOHButton.Image = Nothing
            PODButton.Image = Nothing
            SPButton.Image = Nothing
            SWButton.Image = Nothing
            TTButton.Image = Nothing
            IPButton.Image = Nothing
            MMButton.Image = Nothing
            TRButton.Image = Nothing
            HCChests.Text = 8
            AGChests.Text = 2
            EPChests.Text = 6
            DPChests.Text = 6
            TOHChests.Text = 6
            PODChests.Text = 14
            SPChests.Text = 10
            SWChests.Text = 8
            TTChests.Text = 8
            IPChests.Text = 8
            MMChests.Text = 8
            TRChests.Text = 12
            GTChests.Text = 27
            HCPrizes.Text = 6
            EPPrizes.Text = 3
            DPPrizes.Text = 2
            TOHPrizes.Text = 2
            PODPrizes.Text = 5
            SPPrizes.Text = 6
            SWPrizes.Text = 2
            TTPrizes.Text = 4
            IPPrizes.Text = 3
            MMPrizes.Text = 2
            TRPrizes.Text = 5
            HCCheck()
            EPCheck()
            DPCheck()
            TOHCheck()
            AgaCheck()
            PODCheck()
            SPCheck()
            SWCheck()
            TTCheck()
            IPCheck()
            MMCheck()
            TRCheck()
        End If
    End Sub

    Public Sub LWCheck()
        '' Hyrule Castle - Dark chest lamp blocked; sewer chests blocked by glove or Key, then boots or bombs
        If Lamp = True And (Glove > 0 Or HCKeys.Text = 1) And (Bombs = True Or Boots = True) Then
            HCLabel.BackColor = Color.Green
            HCLabel.ForeColor = Color.White
        Else
            HCLabel.BackColor = Color.Yellow
            HCLabel.ForeColor = Color.Black
        End If

        '' Lumberjack Tree - Aganhim and Boots
        If Aganhim = True And Boots = True Then
            LW6.Enabled = True
            LW6.BackColor = Color.WhiteSmoke
        Else
            LW6.Enabled = False
            LW6.BackColor = Color.Red
        End If

        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave - Bomb
        If Bombs = True Then
            LW9.Enabled = True
            LW9.BackColor = Color.WhiteSmoke
            LW10.Enabled = True
            LW10.BackColor = Color.WhiteSmoke
            LW12.Enabled = True
            LW12.BackColor = Color.WhiteSmoke
            LW18.Enabled = True
            LW18.BackColor = Color.WhiteSmoke
            LW19.Enabled = True
            LW19.BackColor = Color.WhiteSmoke
            LW20.Enabled = True
            LW20.BackColor = Color.WhiteSmoke
        Else
            LW9.Enabled = True
            LW9.BackColor = Color.Yellow
            LW10.Enabled = True
            LW10.BackColor = Color.Yellow
            LW12.Enabled = False
            LW12.BackColor = Color.Red
            LW18.Enabled = False
            LW18.BackColor = Color.Red
            LW19.Enabled = False
            LW19.BackColor = Color.Red
            LW20.Enabled = False
            LW20.BackColor = Color.Red
        End If

        '' Sick Kid - Bottle
        If Bottle = True Then
            LW14.Enabled = True
            LW14.BackColor = Color.WhiteSmoke
        Else
            LW14.Enabled = False
            LW14.BackColor = Color.Red
        End If

        '' Library, Bonk Rocks - Boots
        If Boots = True Then
            LW15.Enabled = True
            LW15.BackColor = Color.WhiteSmoke
            LW29.Enabled = True
            LW29.BackColor = Color.WhiteSmoke
        Else
            LW15.Enabled = False
            LW15.BackColor = Color.Red
            LW29.Enabled = True
            LW29.BackColor = Color.Red
        End If

        '' Maze Race, Sahasrahla's Back Room - Boots or Bomb
        If Boots = True Or Bombs = True Then
            LW16.Enabled = True
            LW16.BackColor = Color.WhiteSmoke
            LW21.Enabled = True
            LW21.BackColor = Color.WhiteSmoke
        Else
            LW16.Enabled = False
            LW16.BackColor = Color.Red
            LW21.Enabled = True
            LW21.BackColor = Color.Red
        End If

        '' Desert Ledge - Desert Palace access (Book or Flute/Mitt/Mirror)
        If Book = True Or (Flute = True And Glove = 2 And Mirror = True) Then
            LW22.Enabled = True
            LW22.BackColor = Color.WhiteSmoke
        Else
            LW22.Enabled = False
            LW22.BackColor = Color.Red
        End If

        '' Bombos Tablet - Master Sword, Book, Access via Dark World
        If Pearl = True And Mirror = True And Book = True And Sword >= 2 And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or Aganhim = True And Hookshot = True And (Hammer = True Or Glove > 0 Or Flippers = True)) Then
            LW23.Enabled = True
            LW23.BackColor = Color.WhiteSmoke
        Else
            LW23.Enabled = False
            LW23.BackColor = Color.Red
        End If

        '' Checkerboard - Flute, Mitt, Mirror (no Pearl required)
        If Flute = True And Glove = 2 And Mirror = True Then
            LW24.Enabled = True
            LW24.BackColor = Color.WhiteSmoke
        Else
            LW24.Enabled = False
            LW24.BackColor = Color.Red
        End If

        '' Dwarves - Pearl, Mitt (no Mirror required)
        If Pearl = True And Glove = 2 Then
            LW25.Enabled = True
            LW25.BackColor = Color.WhiteSmoke
        Else
            LW25.Enabled = False
            LW25.BackColor = Color.Red
        End If

        '' Powder Bat - Powder, Hammer or Mirror+Pearl+Mitt
        If Powder = True And (Hammer = True Or (Mirror = True And Pearl = True And Glove = 2)) Then
            LW26.Enabled = True
            LW26.BackColor = Color.WhiteSmoke
        Else
            LW26.Enabled = False
            LW26.BackColor = Color.Red
        End If

        '' Dig Spot - Shovel
        If Shovel = True Then
            LW27.Enabled = True
            LW27.BackColor = Color.WhiteSmoke
        Else
            LW27.Enabled = False
            LW27.BackColor = Color.Red
        End If

        '' Cave south of Grove, Graveyard Cave - Mirror, Access via Dark World
        If Mirror = True And Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or (Aganhim = True And Hookshot = True And Flippers = True And Glove > 0)) Then
            LW28.Enabled = True
            LW28.BackColor = Color.WhiteSmoke
            LW30.Enabled = True
            LW30.BackColor = Color.WhiteSmoke
        Else
            LW28.Enabled = False
            LW28.BackColor = Color.Red
            LW30.Enabled = False
            LW30.BackColor = Color.Red
        End If

        '' King's Tomb - Boots, Mitt or Access via Dark World
        If Boots = True And (Glove = 2 Or (Mirror = True And (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Hammer = True Or Flippers = True Or Glove > 0)))) Then
            LW31.Enabled = True
            LW31.BackColor = Color.WhiteSmoke
        Else
            LW31.Enabled = False
            LW31.BackColor = Color.Red
        End If

        '' Hobo, Zora's Ledge, Waterfall - Flippers (Hobo can be faked)
        If Flippers = True Then
            LW32.Enabled = True
            LW32.BackColor = Color.WhiteSmoke
            LW35.Enabled = True
            LW35.BackColor = Color.WhiteSmoke
            LW37.Enabled = True
            LW37.BackColor = Color.WhiteSmoke
        Else
            LW32.Enabled = True
            LW32.BackColor = Color.Orange
            If Pearl = True Then
                LW35.Enabled = True
                LW35.BackColor = Color.Orange
            Else
                LW35.Enabled = False
                LW35.BackColor = Color.Red
            End If
            LW37.Enabled = False
            LW37.BackColor = Color.Red
        End If

        '' Hylia Island - Flippers, Mirror, Pearl, access via Dark World
        If Pearl = True And Flippers = True And Mirror = True And (Aganhim = True Or (Glove > 0 And Hammer = True) Or Glove = 2) Then
            LW33.Enabled = True
            LW33.BackColor = Color.WhiteSmoke
        Else
            LW33.Enabled = False
            LW33.BackColor = Color.Red
        End If

        '' Witch - Mushroom
        If Mushroom = True Then
            LW34.Enabled = True
            LW34.BackColor = Color.WhiteSmoke
        Else
            LW34.Enabled = False
            LW34.BackColor = Color.Red
        End If

        '' Zora - Glove or Flippers (can be faked)
        If Flippers = True Or Glove > 0 Then
            LW36.Enabled = True
            LW36.BackColor = Color.WhiteSmoke
        Else
            LW36.Enabled = True
            LW36.BackColor = Color.Orange
        End If

        '' Old Man - Death Mountain access and Lamp (can be dark-navved)
        If Flute = True Or Glove > 0 Then
            If Lamp = True Then
                LW38.Enabled = True
                LW38.BackColor = Color.WhiteSmoke
            Else
                LW38.Enabled = True
                LW38.BackColor = Color.Orange
            End If
        Else
            LW38.Enabled = False
            LW38.BackColor = Color.Red
        End If

        '' Spectacle Cave - Death Mountain access (Lamp prevents sequence break if Glove is used)
        If Flute = True Or (Glove > 0 And Lamp = True) Then
            LW39.Enabled = True
            LW39.BackColor = Color.WhiteSmoke
        ElseIf Glove > 0 Then
            LW39.Enabled = True
            LW39.BackColor = Color.Orange
        Else
            LW39.Enabled = False
            LW39.BackColor = Color.Red
        End If

        '' Spectacle Rock - Death Mountain access (Lamp prevents sequence break if Glove is used) and Mirror
        If Mirror = True And (Flute = True Or (Glove > 0 And Lamp = True)) Then
            LW40.Enabled = True
            LW40.BackColor = Color.WhiteSmoke
        ElseIf Mirror = True And Glove > 0 Then
            LW40.Enabled = True
            LW40.BackColor = Color.Orange
        Else
            LW40.Enabled = False
            LW40.BackColor = Color.Red
        End If

        '' Ether Tablet - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot+Hammer, Master Sword, Book
        If Sword >= 2 And Book = True And (Flute = True Or (Glove > 0 And Lamp = True)) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
            LW41.Enabled = True
            LW41.BackColor = Color.WhiteSmoke
        ElseIf Sword >= 2 And Book = True And Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
            LW41.Enabled = True
            LW41.BackColor = Color.Orange
        Else
            LW41.Enabled = False
            LW41.BackColor = Color.Red
        End If

        '' East Death Mountain, Spiral Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Hookshot or Mirror+Hammer
        If (Flute = True Or (Glove > 0 And Lamp = True)) And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Bombs = True Then
                LW42.Enabled = True
                LW42.BackColor = Color.WhiteSmoke
            Else
                LW42.Enabled = True
                LW42.BackColor = Color.Yellow
            End If
            LW43.Enabled = True
            LW43.BackColor = Color.WhiteSmoke
        ElseIf Glove > 0 And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Bombs = True Then
                LW42.Enabled = True
                LW42.BackColor = Color.Orange
            Else
                LW42.Enabled = True
                LW42.BackColor = Color.Yellow
            End If
            LW43.Enabled = True
            LW43.BackColor = Color.Orange
        Else
            LW42.Enabled = False
            LW42.BackColor = Color.Red
            LW43.Enabled = False
            LW43.BackColor = Color.Red
        End If

        '' Floating Island - Death Mountain access (Lamp prevents sequence break if Glove is used), Mitt, Pearl, Mirror
        If Pearl = True And Glove = 2 And Mirror = True And (Hookshot = True Or Hammer = True) Then
            If Flute = True Or Lamp = True Then
                LW44.Enabled = True
                LW44.BackColor = Color.WhiteSmoke
            Else
                LW44.Enabled = True
                LW44.BackColor = Color.Orange
            End If
        Else
            LW44.Enabled = False
            LW44.BackColor = Color.Red
        End If

        '' Mimic Cave - Turtle Rock access (Lamp prevents sequence break if Glove is used), Mirror
        If TRAccess = True And Mirror = True Then
            If FireRod = True Then
                LW45.Enabled = True
                LW45.BackColor = Color.WhiteSmoke
            Else
                LW45.Enabled = True
                LW45.BackColor = Color.Yellow
            End If
        Else
            LW45.Enabled = False
            LW45.BackColor = Color.Red
        End If

        '' Sahasrahla's Green Pendant
        If GreenPendant = True Then
            LW46.Enabled = True
            LW46.BackColor = Color.WhiteSmoke
        Else
            LW46.Enabled = False
            LW46.BackColor = Color.Red
        End If

        '' Pedestal
        If PendantCount = 3 Then
            LW47.Enabled = True
            LW47.BackColor = Color.WhiteSmoke
        Else
            LW47.Enabled = False
            LW47.BackColor = Color.Red
        End If

        If LW1.Checked = True Then LW1.BackColor = Color.FromArgb(64, 64, 64)
        If LW2.Checked = True Then LW2.BackColor = Color.FromArgb(64, 64, 64)
        If LW6.Checked = True Then LW6.BackColor = Color.FromArgb(64, 64, 64)
        If LW7.Checked = True Then LW7.BackColor = Color.FromArgb(64, 64, 64)
        If LW8.Checked = True Then LW8.BackColor = Color.FromArgb(64, 64, 64)
        If LW9.Checked = True Then LW9.BackColor = Color.FromArgb(64, 64, 64)
        If LW10.Checked = True Then LW10.BackColor = Color.FromArgb(64, 64, 64)
        If LW11.Checked = True Then LW11.BackColor = Color.FromArgb(64, 64, 64)
        If LW12.Checked = True Then LW12.BackColor = Color.FromArgb(64, 64, 64)
        If LW13.Checked = True Then LW13.BackColor = Color.FromArgb(64, 64, 64)
        If LW14.Checked = True Then LW14.BackColor = Color.FromArgb(64, 64, 64)
        If LW15.Checked = True Then LW15.BackColor = Color.FromArgb(64, 64, 64)
        If LW16.Checked = True Then LW16.BackColor = Color.FromArgb(64, 64, 64)
        If LW17.Checked = True Then LW17.BackColor = Color.FromArgb(64, 64, 64)
        If LW18.Checked = True Then LW18.BackColor = Color.FromArgb(64, 64, 64)
        If LW19.Checked = True Then LW19.BackColor = Color.FromArgb(64, 64, 64)
        If LW20.Checked = True Then LW20.BackColor = Color.FromArgb(64, 64, 64)
        If LW21.Checked = True Then LW21.BackColor = Color.FromArgb(64, 64, 64)
        If LW22.Checked = True Then LW22.BackColor = Color.FromArgb(64, 64, 64)
        If LW23.Checked = True Then LW23.BackColor = Color.FromArgb(64, 64, 64)
        If LW24.Checked = True Then LW24.BackColor = Color.FromArgb(64, 64, 64)
        If LW25.Checked = True Then LW25.BackColor = Color.FromArgb(64, 64, 64)
        If LW26.Checked = True Then LW26.BackColor = Color.FromArgb(64, 64, 64)
        If LW27.Checked = True Then LW27.BackColor = Color.FromArgb(64, 64, 64)
        If LW28.Checked = True Then LW28.BackColor = Color.FromArgb(64, 64, 64)
        If LW29.Checked = True Then LW29.BackColor = Color.FromArgb(64, 64, 64)
        If LW30.Checked = True Then LW30.BackColor = Color.FromArgb(64, 64, 64)
        If LW31.Checked = True Then LW31.BackColor = Color.FromArgb(64, 64, 64)
        If LW32.Checked = True Then LW32.BackColor = Color.FromArgb(64, 64, 64)
        If LW33.Checked = True Then LW33.BackColor = Color.FromArgb(64, 64, 64)
        If LW34.Checked = True Then LW34.BackColor = Color.FromArgb(64, 64, 64)
        If LW35.Checked = True Then LW35.BackColor = Color.FromArgb(64, 64, 64)
        If LW36.Checked = True Then LW36.BackColor = Color.FromArgb(64, 64, 64)
        If LW37.Checked = True Then LW37.BackColor = Color.FromArgb(64, 64, 64)
        If LW38.Checked = True Then LW38.BackColor = Color.FromArgb(64, 64, 64)
        If LW39.Checked = True Then LW39.BackColor = Color.FromArgb(64, 64, 64)
        If LW40.Checked = True Then LW40.BackColor = Color.FromArgb(64, 64, 64)
        If LW41.Checked = True Then LW41.BackColor = Color.FromArgb(64, 64, 64)
        If LW42.Checked = True Then LW42.BackColor = Color.FromArgb(64, 64, 64)
        If LW43.Checked = True Then LW43.BackColor = Color.FromArgb(64, 64, 64)
        If LW44.Checked = True Then LW44.BackColor = Color.FromArgb(64, 64, 64)
        If LW45.Checked = True Then LW45.BackColor = Color.FromArgb(64, 64, 64)
        If LW46.Checked = True Then LW46.BackColor = Color.FromArgb(64, 64, 64)
        If LW47.Checked = True Then LW47.BackColor = Color.FromArgb(64, 64, 64)

    End Sub

    Public Sub DWCheck()
        '' Pyramid - Aganhim or Access from warp
        If Aganhim = True Or (Pearl = True And ((Glove > 0 And Hammer = True) Or (Glove = 2 And Flippers = True))) Then
            DW1.Enabled = True
            DW1.BackColor = Color.WhiteSmoke
        Else
            DW1.Enabled = False
            DW1.BackColor = Color.Red
        End If

        '' Chest Game, C House, Sealed Hut, Bumper Cave - Mitt, Glove/Hammer, or Aganhim/Hookshot/Access (Cape also required for Bumper Cave)
        If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
            DW2.Enabled = True
            DW2.BackColor = Color.WhiteSmoke
            DW3.Enabled = True
            DW3.BackColor = Color.WhiteSmoke
            DW4.Enabled = True
            DW4.BackColor = Color.WhiteSmoke
            If Cape = True Then
                DW7.Enabled = True
                DW7.BackColor = Color.WhiteSmoke
            Else
                DW7.Enabled = False
                DW7.BackColor = Color.Red
            End If
        Else
            DW2.Enabled = False
            DW2.BackColor = Color.Red
            DW3.Enabled = False
            DW3.BackColor = Color.Red
            DW4.Enabled = False
            DW4.BackColor = Color.Red
            DW7.Enabled = False
            DW7.BackColor = Color.Red
        End If

        '' Digging Game, Tree Kid, Swamp Hype - Mitt, Glove/Hammer, Aganhim/Hammer, or Aganhim/Hookshot/Glove or Flippers
        If Pearl = True And (Glove = 2 Or (Hammer = True And Glove > 0) Or (Hammer = True And Aganhim = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Flippers = True))) Then
            DW5.Enabled = True
            DW5.BackColor = Color.WhiteSmoke
            DW10.Enabled = True
            DW10.BackColor = Color.WhiteSmoke
            If Bombs = True Then
                DW11.Enabled = True
                DW11.BackColor = Color.WhiteSmoke
            Else
                DW11.Enabled = False
                DW11.BackColor = Color.Red
            End If
        Else
            DW5.Enabled = False
            DW5.BackColor = Color.Red
            DW10.Enabled = False
            DW10.BackColor = Color.Red
            DW11.Enabled = False
            DW11.BackColor = Color.Red
        End If

        '' Mire Cave - Flute, Mitt, Pearl
        If Flute = True And Glove = 2 And Pearl = True Then
            DW6.Enabled = True
            DW6.BackColor = Color.WhiteSmoke
        Else
            DW6.Enabled = False
            DW6.BackColor = Color.Red
        End If

        '' Purple Chest - Dwarves complete (no further items required)
        If LW25.Checked = True Then
            DW8.Enabled = True
            DW8.BackColor = Color.WhiteSmoke
        Else
            DW8.Enabled = False
            DW8.BackColor = Color.Red
        End If

        '' Hammer Pegs - Pearl, Mitt, Hammer
        If Pearl = True And Glove = 2 And Hammer = True Then
            DW9.Enabled = True
            DW9.BackColor = Color.WhiteSmoke
        Else
            DW9.Enabled = False
            DW9.BackColor = Color.Red
        End If

        '' Catfish - Pearl, Glove, Aganhim/Hammer/Mitt+Flippers
        If Pearl = True And Glove > 0 And ((Glove = 2 And Flippers = True) Or Hammer = True Or Aganhim = True) Then
            DW12.Enabled = True
            DW12.BackColor = Color.WhiteSmoke
        Else
            DW12.Enabled = False
            DW12.BackColor = Color.Red
        End If

        '' Spike Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Hammer, Safety item (Byrna or Cape)
        If Pearl = True And Hammer = True And (Flute = True Or (Glove > 0 And Lamp = True)) Then
            If Byrna = True Or Cape = True Then
                DW13.Enabled = True
                DW13.BackColor = Color.WhiteSmoke
            Else
                DW13.Enabled = True
                DW13.BackColor = Color.Orange
            End If
        ElseIf Pearl = True And Hammer = True And Glove > 0 Then
            DW13.Enabled = True
            DW13.BackColor = Color.Orange
        Else
            DW13.Enabled = False
            DW13.BackColor = Color.Red
        End If

        '' East DW DM - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror
        If Glove = 2 And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Flute = True Or Lamp = True Then
                DW14.Enabled = True
                DW14.BackColor = Color.WhiteSmoke
            Else
                DW14.Enabled = True
                DW14.BackColor = Color.Orange
            End If
        Else
            DW14.Enabled = False
            DW14.BackColor = Color.Red
        End If

        '' Hookshot Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror+Boots (Partially blocked without Hookshot)
        If Pearl = True And Glove = 2 And Hookshot = True Then
            If Flute = True Or Lamp = True Then
                DW15.Enabled = True
                DW15.BackColor = Color.WhiteSmoke
            Else
                DW15.Enabled = True
                DW15.BackColor = Color.Orange
            End If
        ElseIf Pearl = True And Glove = 2 And Hammer = True And Mirror = True And Boots = True Then
            DW15.Enabled = True
            DW15.BackColor = Color.Yellow
        Else
            DW15.Enabled = False
            DW15.BackColor = Color.Red
        End If

        '' Fat Fairy - Crystals 5 & 6, Pearl, Hammer, Glove or Aganhim
        If Pearl = True And FairyCrystal = 2 And ((Glove > 0 And Hammer = True) Or (Aganhim = True And Mirror = True) Or (Aganhim = True And Hammer = True)) Then
            DW16.Enabled = True
            DW16.BackColor = Color.WhiteSmoke
        Else
            DW16.Enabled = False
            DW16.BackColor = Color.Red
        End If

        If DW1.Checked = True Then DW1.BackColor = Color.FromArgb(64, 64, 64)
        If DW2.Checked = True Then DW2.BackColor = Color.FromArgb(64, 64, 64)
        If DW3.Checked = True Then DW3.BackColor = Color.FromArgb(64, 64, 64)
        If DW4.Checked = True Then DW4.BackColor = Color.FromArgb(64, 64, 64)
        If DW5.Checked = True Then DW5.BackColor = Color.FromArgb(64, 64, 64)
        If DW6.Checked = True Then DW6.BackColor = Color.FromArgb(64, 64, 64)
        If DW7.Checked = True Then DW7.BackColor = Color.FromArgb(64, 64, 64)
        If DW8.Checked = True Then DW8.BackColor = Color.FromArgb(64, 64, 64)
        If DW9.Checked = True Then DW9.BackColor = Color.FromArgb(64, 64, 64)
        If DW10.Checked = True Then DW10.BackColor = Color.FromArgb(64, 64, 64)
        If DW11.Checked = True Then DW11.BackColor = Color.FromArgb(64, 64, 64)
        If DW12.Checked = True Then DW12.BackColor = Color.FromArgb(64, 64, 64)
        If DW13.Checked = True Then DW13.BackColor = Color.FromArgb(64, 64, 64)
        If DW14.Checked = True Then DW14.BackColor = Color.FromArgb(64, 64, 64)
        If DW15.Checked = True Then DW15.BackColor = Color.FromArgb(64, 64, 64)
        If DW16.Checked = True Then DW16.BackColor = Color.FromArgb(64, 64, 64)

    End Sub

    Private Sub LocationClick(sender As Object, e As EventArgs) Handles LW1.CheckedChanged, LW2.CheckedChanged, LW6.CheckedChanged, LW7.CheckedChanged, LW8.CheckedChanged, LW9.CheckedChanged, LW10.CheckedChanged, LW11.CheckedChanged, LW12.CheckedChanged, LW13.CheckedChanged, LW14.CheckedChanged, LW15.CheckedChanged, LW16.CheckedChanged,
        LW17.CheckedChanged, LW18.CheckedChanged, LW19.CheckedChanged, LW20.CheckedChanged, LW21.CheckedChanged, LW22.CheckedChanged, LW23.CheckedChanged, LW24.CheckedChanged, LW25.CheckedChanged, LW26.CheckedChanged, LW27.CheckedChanged, LW28.CheckedChanged, LW29.CheckedChanged, LW30.CheckedChanged, LW31.CheckedChanged, LW32.CheckedChanged,
        LW33.CheckedChanged, LW34.CheckedChanged, LW35.CheckedChanged, LW36.CheckedChanged, LW37.CheckedChanged, LW38.CheckedChanged, LW39.CheckedChanged, LW40.CheckedChanged, LW41.CheckedChanged, LW42.CheckedChanged, LW43.CheckedChanged, LW44.CheckedChanged, LW45.CheckedChanged, LW46.CheckedChanged, LW47.CheckedChanged, DW1.CheckedChanged,
        DW2.CheckedChanged, DW3.CheckedChanged, DW4.CheckedChanged, DW5.CheckedChanged, DW6.CheckedChanged, DW7.CheckedChanged, DW8.CheckedChanged, DW9.CheckedChanged, DW10.CheckedChanged, DW11.CheckedChanged, DW12.CheckedChanged, DW13.CheckedChanged, DW14.CheckedChanged, DW15.CheckedChanged, DW16.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then DirectCast(sender, CheckBox).BackColor = Color.FromArgb(64, 64, 64) Else DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
        LWCheck()
        DWCheck()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgaTree = (AgaTree + 1) Mod 3
        Select Case AgaTree
            Case 1
                Button1.Image = My.Resources.redchest
            Case 2
                Button1.Image = My.Resources.greenchest
            Case Else
                Button1.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Library = (Library + 1) Mod 3
        Select Case Library
            Case 1
                Button2.Image = My.Resources.redchest
            Case 2
                Button2.Image = My.Resources.greenchest
            Case Else
                Button2.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MazeRace = (MazeRace + 1) Mod 3
        Select Case MazeRace
            Case 1
                Button3.Image = My.Resources.redchest
            Case 2
                Button3.Image = My.Resources.greenchest
            Case Else
                Button3.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SpecRock = (SpecRock + 1) Mod 3
        Select Case SpecRock
            Case 1
                Button4.Image = My.Resources.redchest
            Case 2
                Button4.Image = My.Resources.greenchest
            Case Else
                Button4.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EtherTab = (EtherTab + 1) Mod 3
        Select Case EtherTab
            Case 1
                Button5.Image = My.Resources.redchest
            Case 2
                Button5.Image = My.Resources.greenchest
            Case Else
                Button5.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Floating = (Floating + 1) Mod 3
        Select Case Floating
            Case 1
                Button6.Image = My.Resources.redchest
            Case 2
                Button6.Image = My.Resources.greenchest
            Case Else
                Button6.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DPLedge = (DPLedge + 1) Mod 3
        Select Case DPLedge
            Case 1
                Button7.Image = My.Resources.redchest
            Case 2
                Button7.Image = My.Resources.greenchest
            Case Else
                Button7.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BombosTab = (BombosTab + 1) Mod 3
        Select Case BombosTab
            Case 1
                Button8.Image = My.Resources.redchest
            Case 2
                Button8.Image = My.Resources.greenchest
            Case Else
                Button8.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ZoraLedge = (ZoraLedge + 1) Mod 3
        Select Case ZoraLedge
            Case 1
                Button9.Image = My.Resources.redchest
            Case 2
                Button9.Image = My.Resources.greenchest
            Case Else
                Button9.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        LakeIsle = (LakeIsle + 1) Mod 3
        Select Case LakeIsle
            Case 1
                Button10.Image = My.Resources.redchest
            Case 2
                Button10.Image = My.Resources.greenchest
            Case Else
                Button10.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Pedestal = (Pedestal + 1) Mod 3
        Select Case Pedestal
            Case 1
                Button11.Image = My.Resources.redchest
            Case 2
                Button11.Image = My.Resources.greenchest
            Case Else
                Button11.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Bumper = (Bumper + 1) Mod 3
        Select Case Bumper
            Case 1
                Button12.Image = My.Resources.redchest
            Case 2
                Button12.Image = My.Resources.greenchest
            Case Else
                Button12.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Public Sub HCCheck()
        If RadioButton1.Checked = True Then
            If Glove > 0 And Lamp = True And (Bombs = True Or Boots = True) Then
                HCLabel.BackColor = Color.Green
                HCLabel.ForeColor = Color.White
                HCChests.Text = 8
                HCChests.ForeColor = Color.White
            ElseIf Lamp = True And (Bombs = True Or Boots = True) Then
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
                HCChests.Text = 8
                HCChests.ForeColor = Color.Yellow
            ElseIf Lamp = True Then
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
                HCChests.Text = 5
                HCChests.ForeColor = Color.White
            Else
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
                HCChests.Text = 5
                HCChests.ForeColor = Color.Yellow
            End If
        Else
            If (Glove > 0 Or HCKeys.Text = 1) And Lamp = True And (Bombs = True Or Boots = True) Then
                HCLabel.BackColor = Color.Green
                HCLabel.ForeColor = Color.White
            Else
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub HCClick(sender As Object, e As EventArgs)
        If DirectCast(sender, CheckBox).Name = "HC1" Then
            If DirectCast(sender, CheckBox).Checked = True Then
                DirectCast(sender, CheckBox).Image = My.Resources.key
            ElseIf My.Computer.Keyboard.ShiftKeyDown Then
                DirectCast(sender, CheckBox).Checked = True
                DirectCast(sender, CheckBox).BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.nokey
                DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
            End If
        Else
            If DirectCast(sender, CheckBox).Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
        End If
    End Sub

    Private Sub HCChests_MouseDown(sender As Object, e As EventArgs) Handles HCChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If HCChests.Text > 0 Then HCChests.Text = HCChests.Text - 1
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If HCChests.Text < 8 Then HCChests.Text = HCChests.Text + 1
            End If
        End If
    End Sub

    Private Sub HCKeys_MouseDown(sender As Object, e As EventArgs) Handles HCKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then HCKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then HCKeys.Text = 0
        LWCheck()
    End Sub

    Private Sub AGChests_MouseDown(sender As Object, e As MouseEventArgs) Handles AGChests.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If AGChests.Text > 0 Then AGChests.Text = AGChests.Text - 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If AGChests.Text < 2 Then AGChests.Text = AGChests.Text + 1
        End If
    End Sub

    Private Sub EPClick(sender As Object, e As EventArgs) Handles EPMap.CheckedChanged, EPBigKey.CheckedChanged, EPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "EPMap"
                If EPMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "EPBigKey"
                If EPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    EPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    EPBigKey.BackColor = Color.Red
                End If
            Case "EPBoss"
                If EPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    EPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    EPButton.BackColor = Color.Black
                End If
        End Select
        EPCheck()
        CrystalCheck()
    End Sub

    Private Sub EPChests_MouseDown(sender As Object, e As EventArgs) Handles EPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If EPChests.Text > 0 Then EPChests.Text = EPChests.Text - 1
                If EPChests.Text = 0 Then EPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If EPChests.Text < 6 Then EPChests.Text = EPChests.Text + 1
                EPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub EPPrizes_MouseDown(sender As Object, e As EventArgs) Handles EPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If EPPrizes.Text > 0 Then EPPrizes.Text = EPPrizes.Text - 1
                If EPPrizes.Text = 0 Then EPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If EPPrizes.Text < 5 Then EPPrizes.Text = EPPrizes.Text + 1
                EPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Public Sub EPCheck()
        If RadioButton1.Checked = True Then
            If Bow > 0 Then
                EPLabel.ForeColor = Color.White
                EPBoss.Enabled = True
                EPChests.Text = 6
                If Lamp = True Then
                    EPLabel.BackColor = Color.Green
                    EPChests.ForeColor = Color.White
                Else
                    EPLabel.BackColor = Color.Orange
                    EPChests.ForeColor = Color.Orange
                End If
            Else
                EPLabel.BackColor = Color.Yellow
                EPLabel.ForeColor = Color.Black
                EPBoss.Enabled = False
                EPChests.Text = 5
                If Lamp = True Then EPChests.ForeColor = Color.White Else EPChests.ForeColor = Color.Yellow
            End If
        Else
            If Bow > 0 And Lamp = True Then
                EPLabel.ForeColor = Color.White
                EPLabel.BackColor = Color.Green
                EPBoss.Enabled = True
            ElseIf Bow > 0 Then
                EPLabel.ForeColor = Color.White
                EPLabel.BackColor = Color.Orange
                EPBoss.Enabled = True
            Else
                EPLabel.ForeColor = Color.Black
                EPLabel.BackColor = Color.Yellow
                EPBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub DPClick(sender As Object, e As EventArgs) Handles DPMap.CheckedChanged, DPBigKey.CheckedChanged, DPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "DPMap"
                If DPMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "DPBigKey"
                If DPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    DPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    DPBigKey.BackColor = Color.Red
                End If
            Case "DPBoss"
                If DPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    DPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    DPButton.BackColor = Color.Black
                End If
        End Select
        DPCheck()
        CrystalCheck()
    End Sub
    Private Sub DPChests_MouseDown(sender As Object, e As EventArgs) Handles DPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If DPChests.Text > 0 Then DPChests.Text = DPChests.Text - 1
                If DPChests.Text = 0 Then DPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If DPChests.Text < 6 Then DPChests.Text = DPChests.Text + 1
                DPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub DPPrizes_MouseDown(sender As Object, e As EventArgs) Handles DPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If DPPrizes.Text > 0 Then DPPrizes.Text = DPPrizes.Text - 1
                If DPPrizes.Text = 0 Then DPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If DPPrizes.Text < 5 Then DPPrizes.Text = DPPrizes.Text + 1
                DPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DPKeys_MouseDown(sender As Object, e As EventArgs) Handles DPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then DPKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then DPKeys.Text = 0
        DPCheck()
    End Sub

    Public Sub DPCheck()
        If RadioButton1.Checked = True Then
            If (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 Then
                DPLabel.BackColor = Color.Green
                DPLabel.ForeColor = Color.White
                DPChests.Text = 6
                DPChests.ForeColor = Color.White
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPChests.Text = 5
                DPChests.ForeColor = Color.Yellow
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPChests.Text = 4
                DPChests.ForeColor = Color.Yellow
                DPBoss.Enabled = False
            Else
                DPLabel.BackColor = Color.Red
                DPLabel.ForeColor = Color.Black
                DPChests.Text = 0
                DPChests.ForeColor = Color.White
                DPBoss.Enabled = False
            End If
        Else
            If (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 And DPBigKey.Checked = True Then
                DPLabel.BackColor = Color.Green
                DPLabel.ForeColor = Color.White
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPBoss.Enabled = False
            Else
                DPLabel.BackColor = Color.Red
                DPLabel.ForeColor = Color.Black
                DPBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub TOHClick(sender As Object, e As EventArgs) Handles HeraMap.CheckedChanged, HeraBigKey.CheckedChanged, HeraBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "HeraMap"
                If HeraMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "HeraBigKey"
                If HeraBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    HeraBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    HeraBigKey.BackColor = Color.Red
                End If
            Case "HeraBoss"
                If HeraBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TOHButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TOHButton.BackColor = Color.Black
                End If
        End Select
        TOHCheck()
        CrystalCheck()
    End Sub
    Private Sub TOHChests_MouseDown(sender As Object, e As EventArgs) Handles TOHChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TOHChests.Text > 0 Then TOHChests.Text = TOHChests.Text - 1
                If TOHChests.Text = 0 Then TOHLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TOHChests.Text < 6 Then TOHChests.Text = TOHChests.Text + 1
                TOHLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TOHPrizes_MouseDown(sender As Object, e As EventArgs) Handles TOHPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TOHPrizes.Text > 0 Then TOHPrizes.Text = TOHPrizes.Text - 1
                If TOHPrizes.Text = 0 Then TOHLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TOHPrizes.Text < 5 Then TOHPrizes.Text = TOHPrizes.Text + 1
                TOHLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub HeraKeys_MouseDown(sender As Object, e As EventArgs) Handles TOHKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then TOHKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then TOHKeys.Text = 0
        TOHCheck()
    End Sub
    Public Sub TOHCheck()
        If RadioButton1.Checked = True Then
            If Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) And (Lamp = True Or FireRod = True) And (Sword > 0 Or Hammer = True) Then
                TOHLabel.ForeColor = Color.White
                HeraBoss.Enabled = True
                If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
                TOHChests.Text = 6
                TOHChests.ForeColor = Color.White
            ElseIf Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) Then
                TOHLabel.BackColor = Color.Yellow
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = True
                TOHChests.Text = 5
                TOHChests.ForeColor = Color.Yellow
            ElseIf Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                TOHLabel.BackColor = Color.Yellow
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
                TOHChests.Text = 4
                TOHChests.ForeColor = Color.Yellow
            Else
                TOHLabel.BackColor = Color.Red
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
                TOHChests.Text = 0
                TOHChests.ForeColor = Color.White
            End If
        Else
            If Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) And HeraBigKey.Checked = True Then
                TOHLabel.ForeColor = Color.White
                HeraBoss.Enabled = True
                If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
            ElseIf (Flute = True Or Glove > 0) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                TOHLabel.BackColor = Color.Yellow
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
            Else
                TOHLabel.BackColor = Color.Red
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub AGKeys_MouseDown(sender As Object, e As EventArgs) Handles AGKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If AGKeys.Text < 2 Then AGKeys.Text = AGKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If AGKeys.Text > 0 Then AGKeys.Text = AGKeys.Text - 1
        End If
        AgaCheck()
    End Sub

    Public Sub AgaCheck()
        If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True And AGKeys.Text = 2 Then
            AgaButton.Visible = True
            AGLabel.BackColor = Color.Green
            AGLabel.ForeColor = Color.White
        Else
            AgaButton.Visible = False
            AGLabel.BackColor = Color.Red
            AGLabel.ForeColor = Color.Black
        End If
    End Sub
    Private Sub PODClick(sender As Object, e As EventArgs) Handles PODMap.CheckedChanged, PODBigKey.CheckedChanged, PODBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "PODMap"
                If PODMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "PODBigKey"
                If PODBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    PODBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    PODBigKey.BackColor = Color.Red
                End If
            Case "PODBoss"
                If PODBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    PODButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    PODButton.BackColor = Color.Black
                End If
        End Select
        PODCheck()
        CrystalCheck()
    End Sub
    Private Sub PODChests_MouseDown(sender As Object, e As EventArgs) Handles PODChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If PODChests.Text > 0 Then PODChests.Text = PODChests.Text - 1
                If PODChests.Text = 0 Then PODLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If PODChests.Text < 14 Then PODChests.Text = PODChests.Text + 1
                PODLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODPrizes_MouseDown(sender As Object, e As EventArgs) Handles PODPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If PODPrizes.Text > 0 Then PODPrizes.Text = PODPrizes.Text - 1
                If PODPrizes.Text = 0 Then PODLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If PODPrizes.Text < 5 Then PODPrizes.Text = PODPrizes.Text + 1
                PODLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODKeys_MouseDown(sender As Object, e As EventArgs) Handles PODKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If PODKeys.Text < 6 Then PODKeys.Text = PODKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If PODKeys.Text > 0 Then PODKeys.Text = PODKeys.Text - 1
        End If
    End Sub
    Public Sub PODCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 0 And Hammer = True Then
                PODBoss.Enabled = True
                PODChests.Text = 14
                PODChests.ForeColor = Color.White
                If Lamp = True Then
                    PODLabel.BackColor = Color.Green
                    PODLabel.ForeColor = Color.White
                Else
                    PODLabel.BackColor = Color.Orange
                    PODLabel.ForeColor = Color.Orange
                End If
            ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 0 Then
                PODBoss.Enabled = False
                PODChests.Text = 13
                PODChests.ForeColor = Color.Yellow
                PODLabel.BackColor = Color.Yellow
                PODLabel.ForeColor = Color.Black
            ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                PODBoss.Enabled = False
                PODChests.Text = 11
                PODChests.ForeColor = Color.Yellow
                PODLabel.BackColor = Color.Yellow
                PODLabel.ForeColor = Color.Yellow
            Else
                PODChests.Text = 0
                PODChests.ForeColor = Color.White
                PODLabel.BackColor = Color.Red
                PODLabel.ForeColor = Color.Black
                PODBoss.Enabled = False
            End If
        Else
            If Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 0 And Hammer = True And PODBigKey.Checked = True Then
                If Lamp = True Then PODLabel.BackColor = Color.Green Else PODLabel.BackColor = Color.Orange
                PODLabel.ForeColor = Color.White
                PODBoss.Enabled = True
            ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                PODLabel.BackColor = Color.Yellow
                PODLabel.ForeColor = Color.Black
                PODBoss.Enabled = False
            Else
                PODLabel.BackColor = Color.Red
                PODLabel.ForeColor = Color.Black
                PODBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub SPClick(sender As Object, e As EventArgs) Handles SPMap.CheckedChanged, SPBigKey.CheckedChanged, SPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SPMap"
                If SPMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "SPBigKey"
                If SPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkey Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
            Case "SPBoss"
                If SPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    SPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SPButton.BackColor = Color.Black
                End If
        End Select
        SPCheck()
        CrystalCheck()
    End Sub
    Private Sub SPChests_MouseDown(sender As Object, e As EventArgs) Handles SPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SPChests.Text > 0 Then SPChests.Text = SPChests.Text - 1
                If SPChests.Text = 0 Then SPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SPChests.Text < 10 Then SPChests.Text = SPChests.Text + 1
                SPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPPrizes_MouseDown(sender As Object, e As EventArgs) Handles SPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SPPrizes.Text > 0 Then SPPrizes.Text = SPPrizes.Text - 1
                If SPPrizes.Text = 0 Then SPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SPPrizes.Text < 5 Then SPPrizes.Text = SPPrizes.Text + 1
                SPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPKeys_MouseDown(sender As Object, e As EventArgs) Handles SPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then SPKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then SPKeys.Text = 0
        SPCheck()
    End Sub
    Public Sub SPCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) Then
                SPLabel.BackColor = Color.Green
                SPLabel.ForeColor = Color.White
                SPChests.Text = 10
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = True
            ElseIf Pearl = True And Flippers = True And Mirror = True And Hammer = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                SPLabel.BackColor = Color.Yellow
                SPLabel.ForeColor = Color.Black
                SPChests.Text = 6
                SPChests.ForeColor = Color.Yellow
                SPBoss.Enabled = False
            ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                SPLabel.BackColor = Color.Yellow
                SPLabel.ForeColor = Color.Black
                SPChests.Text = 2
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = False
            Else
                SPLabel.BackColor = Color.Red
                SPLabel.ForeColor = Color.Black
                SPChests.Text = 0
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = False
            End If
        Else
            If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) And SPKeys.Text = 1 Then
                SPLabel.BackColor = Color.Green
                SPLabel.ForeColor = Color.White
                SPBoss.Enabled = True
            ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                SPLabel.BackColor = Color.Yellow
                SPLabel.ForeColor = Color.Black
                SPBoss.Enabled = False
            Else
                SPLabel.BackColor = Color.Red
                SPLabel.ForeColor = Color.Black
                SPBoss.Enabled = False
            End If
        End If

    End Sub

    Private Sub SWClick(sender As Object, e As EventArgs) Handles SWMap.CheckedChanged, SWBigKey.CheckedChanged, SWBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SWMap"
                If SWMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "SWBigKey"
                If SWBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkey Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
            Case "SWBoss"
                If SWBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    SWButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SWButton.BackColor = Color.Black
                End If
        End Select
        SWCheck()
        CrystalCheck()
    End Sub
    Private Sub SWChests_MouseDown(sender As Object, e As EventArgs) Handles SWChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SWChests.Text > 0 Then SWChests.Text = SWChests.Text - 1
                If SWChests.Text = 0 Then SWLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SWChests.Text < 8 Then SWChests.Text = SWChests.Text + 1
                SWLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SWPrizes_MouseDown(sender As Object, e As EventArgs) Handles SWPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SWPrizes.Text > 0 Then SWPrizes.Text = SWPrizes.Text - 1
                If SWPrizes.Text = 0 Then SWLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SWPrizes.Text < 2 Then SWPrizes.Text = SWPrizes.Text + 1
                SWLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub SWKeys_MouseDown(sender As Object, e As EventArgs) Handles SWKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If SWKeys.Text < 3 Then SWKeys.Text = SWKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If SWKeys.Text > 0 Then SWKeys.Text = SWKeys.Text - 1
        End If
    End Sub


    Public Sub SWCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True And Sword > 0 Then
                SWLabel.BackColor = Color.Green
                SWLabel.ForeColor = Color.White
                SWChests.Text = 8
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = True
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                SWLabel.BackColor = Color.Yellow
                SWLabel.ForeColor = Color.Black
                SWChests.Text = 7
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = False
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                SWLabel.BackColor = Color.Yellow
                SWLabel.ForeColor = Color.Black
                SWChests.Text = 6
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = False
            Else
                SWLabel.BackColor = Color.Red
                SWLabel.ForeColor = Color.Black
                SWChests.Text = 0
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = False
            End If
        Else
            If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True And Sword > 0 Then
                SWLabel.BackColor = Color.Green
                SWLabel.ForeColor = Color.White
                SWBoss.Enabled = True
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                SWLabel.BackColor = Color.Yellow
                SWLabel.ForeColor = Color.Black
                SWBoss.Enabled = False
            Else
                SWLabel.BackColor = Color.Red
                SWLabel.ForeColor = Color.Black
                SWBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub TTClick(sender As Object, e As EventArgs) Handles TTMap.CheckedChanged, TTBigKey.CheckedChanged, TTBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TTMap"
                If TTMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "TTBigKey"
                If TTBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    TTBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    TTBigKey.BackColor = Color.Red
                End If
            Case "TTBoss"
                If TTBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TTButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TTButton.BackColor = Color.Black
                End If
        End Select
        TTCheck()
        CrystalCheck()
    End Sub
    Private Sub TTPrizes_MouseDown(sender As Object, e As EventArgs) Handles TTPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TTPrizes.Text > 0 Then TTPrizes.Text = TTPrizes.Text - 1
                If TTPrizes.Text = 0 Then TTLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TTPrizes.Text < 4 Then TTPrizes.Text = TTPrizes.Text + 1
                TTLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TTChests_MouseDown(sender As Object, e As EventArgs) Handles TTChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TTChests.Text > 0 Then TTChests.Text = TTChests.Text - 1
                If TTChests.Text = 0 Then TTLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TTChests.Text < 8 Then TTChests.Text = TTChests.Text + 1
                TTLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub TTKeys_MouseDown(sender As Object, e As EventArgs) Handles TTKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then TTKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then TTKeys.Text = 0
    End Sub

    Public Sub TTCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                TTLabel.BackColor = Color.Green
                TTLabel.ForeColor = Color.White
                If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = True
            Else
                TTLabel.BackColor = Color.Red
                TTLabel.ForeColor = Color.Black
                TTChests.Text = 0
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = False
            End If
        Else
            If Pearl = True And TTBigKey.Checked = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                TTLabel.BackColor = Color.Green
                TTLabel.ForeColor = Color.White
                TTBoss.Enabled = True
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                TTLabel.BackColor = Color.Yellow
                TTLabel.ForeColor = Color.Black
                TTBoss.Enabled = False
            Else
                TTLabel.BackColor = Color.Red
                TTLabel.ForeColor = Color.Black
                TTBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub IPClick(sender As Object, e As EventArgs) Handles IPMap.CheckedChanged, IPBigKey.CheckedChanged, IPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "IPMap"
                If IPMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "IPBigKey"
                If IPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkey Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
            Case "IPBoss"
                If IPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    IPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    IPButton.BackColor = Color.Black
                End If
        End Select
        IPCheck()
        CrystalCheck()
    End Sub
    Private Sub IPPrizes_MouseDown(sender As Object, e As EventArgs) Handles IPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If IPPrizes.Text > 0 Then IPPrizes.Text = IPPrizes.Text - 1
                If IPPrizes.Text = 0 Then IPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If IPPrizes.Text < 2 Then IPPrizes.Text = IPPrizes.Text + 1
                IPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPChests_MouseDown(sender As Object, e As EventArgs) Handles IPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If IPChests.Text > 0 Then IPChests.Text = IPChests.Text - 1
                If IPChests.Text = 0 Then IPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If IPChests.Text < 8 Then IPChests.Text = IPChests.Text + 1
                IPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPKeys_MouseDown(sender As Object, e As EventArgs) Handles IPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If IPKeys.Text < 3 Then IPKeys.Text = IPKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If IPKeys.Text < 3 Then IPKeys.Text = IPKeys.Text - 1
        End If
    End Sub

    Public Sub IPCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) And Hammer = True And Hookshot = True Then
                IPLabel.ForeColor = Color.White
                IPChests.Text = 8
                IPBoss.Enabled = True
                If Flippers = True Then
                    IPLabel.BackColor = Color.Green
                    IPChests.ForeColor = Color.White
                Else
                    IPLabel.BackColor = Color.Orange
                    IPChests.ForeColor = Color.Orange
                End If
            ElseIf Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) Then
                IPLabel.BackColor = Color.Yellow
                IPLabel.ForeColor = Color.Black
                IPChests.Text = 7
                If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                IPBoss.Enabled = False
            Else
                IPLabel.BackColor = Color.Red
                IPLabel.ForeColor = Color.Black
                IPChests.Text = 0
                IPChests.ForeColor = Color.White
                IPBoss.Enabled = False
            End If
        Else
            If Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) And Hammer = True Then
                If Flippers = True And Hookshot = True And (Somaria = True Or IPBigKey.Checked = True) Then IPLabel.BackColor = Color.Green Else IPLabel.BackColor = Color.Orange
                IPLabel.ForeColor = Color.White
                IPBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Flippers = True And (FireRod = True Or Bombos = True) Then
                IPLabel.BackColor = Color.Yellow
                IPLabel.ForeColor = Color.Black
                IPBoss.Enabled = False
            Else
                IPLabel.BackColor = Color.Red
                IPLabel.ForeColor = Color.Black
                IPBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub MMClick(sender As Object, e As EventArgs) Handles MMMap.CheckedChanged, MMBigKey.CheckedChanged, MMBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "MMMap"
                If MMMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "MMBigKey"
                If MMBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    MMBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    MMBigKey.BackColor = Color.Red
                End If
            Case "MMBoss"
                If MMBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    MMButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    MMButton.BackColor = Color.Black
                End If
        End Select
        MMCheck()
        CrystalCheck()
    End Sub
    Private Sub MMPrizes_MouseDown(sender As Object, e As EventArgs) Handles MMPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If MMPrizes.Text > 0 Then MMPrizes.Text = MMPrizes.Text - 1
                If MMPrizes.Text = 0 Then MMLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If MMPrizes.Text < 2 Then MMPrizes.Text = MMPrizes.Text + 1
                MMLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMChests_MouseDown(sender As Object, e As EventArgs) Handles MMChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If MMChests.Text > 0 Then MMChests.Text = MMChests.Text - 1
                If MMChests.Text = 0 Then MMLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If MMChests.Text < 8 Then MMChests.Text = MMChests.Text + 1
                MMLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMKeys_MouseDown(sender As Object, e As EventArgs) Handles MMKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If MMKeys.Text < 3 Then MMKeys.Text = MMKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If MMKeys.Text > 0 Then MMKeys.Text = MMKeys.Text - 1
        End If
    End Sub
    Public Sub MMCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Glove = 2 And Flute = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True Then
                MMBoss.Enabled = True
                MMChests.Text = 8
                MMLabel.ForeColor = Color.White
                If Lamp = True Then
                    MMLabel.BackColor = Color.Green
                    MMChests.ForeColor = Color.White
                Else
                    MMLabel.BackColor = Color.Orange
                    MMChests.ForeColor = Color.Orange
                End If
            ElseIf Pearl = True And Glove = 2 And Flute = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                MMLabel.BackColor = Color.Yellow
                MMLabel.ForeColor = Color.Black
                MMChests.Text = 7
                MMChests.ForeColor = Color.White
                MMBoss.Enabled = False
            Else
                MMLabel.BackColor = Color.Red
                MMLabel.ForeColor = Color.Black
                MMChests.Text = 0
                MMChests.ForeColor = Color.White
                MMBoss.Enabled = False
            End If
        Else
            If Pearl = True And Glove = 2 And Flute = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True And MMBigKey.Checked = True Then
                If Lamp = True Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Orange
                MMLabel.ForeColor = Color.White
                MMBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Flute = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                MMLabel.BackColor = Color.Yellow
                MMLabel.ForeColor = Color.Black
                MMBoss.Enabled = False
            Else
                MMLabel.BackColor = Color.Red
                MMLabel.ForeColor = Color.Black
                MMBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub MireBEQ_Click(sender As Object, e As EventArgs) Handles MireBEQ.Click
        MireMedallion = (MireMedallion + 1) Mod 4
        Select Case MireMedallion
            Case 0
                MireBEQ.Image = My.Resources.whatmedallion
            Case 1
                MireBEQ.Image = My.Resources.bombosMMTR
            Case 2
                MireBEQ.Image = My.Resources.etherMMTR
            Case 3
                MireBEQ.Image = My.Resources.quakeMMTR
        End Select
        MMCheck()
    End Sub
    Private Sub TRClick(sender As Object, e As EventArgs) Handles TRMap.CheckedChanged, TRBigKey.CheckedChanged, TRBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TRMap"
                If TRMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "TRBigKey"
                If TRBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    TRBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    TRBigKey.BackColor = Color.Red
                End If
            Case "TRBoss"
                If TRBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TRButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TRButton.BackColor = Color.Black
                End If
        End Select
        TRCheck()
        CrystalCheck()
    End Sub
    Private Sub TRPrizes_MouseDown(sender As Object, e As EventArgs) Handles TRPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TRPrizes.Text > 0 Then TRPrizes.Text = TRPrizes.Text - 1
                If TRPrizes.Text = 0 Then TRLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TRPrizes.Text < 5 Then TRPrizes.Text = TRPrizes.Text + 1
                TRLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRChests_MouseDown(sender As Object, e As EventArgs) Handles TRChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TRChests.Text > 0 Then TRChests.Text = TRChests.Text - 1
                If TRChests.Text = 0 Then TRLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TRChests.Text < 12 Then TRChests.Text = TRChests.Text + 1
                TRLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRKeys_MouseDown(sender As Object, e As EventArgs) Handles TRKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If TRKeys.Text < 4 Then TRKeys.Text = TRKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If TRKeys.Text > 0 Then TRKeys.Text = TRKeys.Text - 1
        End If
    End Sub
    Public Sub TRCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And TRBigKey.Checked = True Then
                TRAccess = True
                TRChests.Text = 12
                If Lamp = True And Sword > 1 Then
                    TRLabel.BackColor = Color.Green
                    TRChests.ForeColor = Color.White
                Else
                    TRLabel.BackColor = Color.Orange
                    TRChests.ForeColor = Color.Orange
                End If
                TRLabel.ForeColor = Color.White
                TRBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And FireRod = True Then
                TRAccess = True
                TRChests.Text = 11
                If Lamp = True Then TRChests.ForeColor = Color.White Else TRChests.ForeColor = Color.Yellow
                TRLabel.BackColor = Color.Yellow
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                TRAccess = True
                TRChests.Text = 9
                TRChests.ForeColor = Color.Yellow
                TRLabel.BackColor = Color.Yellow
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            Else
                TRAccess = False
                TRLabel.BackColor = Color.Red
                TRLabel.ForeColor = Color.Black
                TRChests.Text = 0
                TRChests.ForeColor = Color.White
                TRBoss.Enabled = False
            End If
        Else
            If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And TRBigKey.Checked = True Then
                TRAccess = True
                If Lamp = True And Sword > 1 Then TRLabel.BackColor = Color.Green Else TRLabel.BackColor = Color.Orange
                TRLabel.ForeColor = Color.White
                TRBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                TRAccess = True
                TRLabel.BackColor = Color.Yellow
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            Else
                TRAccess = False
                TRLabel.BackColor = Color.Red
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub TurtleBEQ_Click(sender As Object, e As EventArgs) Handles TurtleBEQ.Click
        TurtleMedallion = (TurtleMedallion + 1) Mod 4
        Select Case TurtleMedallion
            Case 0
                TurtleBEQ.Image = My.Resources.whatmedallion
            Case 1
                TurtleBEQ.Image = My.Resources.bombosMMTR
            Case 2
                TurtleBEQ.Image = My.Resources.etherMMTR
            Case 3
                TurtleBEQ.Image = My.Resources.quakeMMTR
        End Select
        TRCheck()
    End Sub

    Private Sub GTClick(sender As Object, e As EventArgs) Handles GTMap.CheckedChanged, GTBigKey.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "GTMap"
                If GTMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "GTBigKey"
                If GTBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    GTBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    GTBigKey.BackColor = Color.Red
                End If
        End Select
        GTCheck()
        CrystalCheck()
    End Sub

    Private Sub GTChests_MouseDown(sender As Object, e As EventArgs) Handles GTChests.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If GTChests.Text > 0 Then GTChests.Text = GTChests.Text - 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If GTChests.Text < 27 Then GTChests.Text = GTChests.Text + 1
        End If
    End Sub

    Private Sub GTKeys_MouseDown(sender As Object, e As EventArgs) Handles GTKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If GTKeys.Text < 3 Then GTKeys.Text = GTKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If GTKeys.Text > 0 Then GTKeys.Text = GTKeys.Text - 1
        End If
    End Sub

    Public Sub GTCheck()
        If RadioButton2.Checked = True Then
            If CrystalCount = 7 And GTBigKey.Checked = True Then
                GTLabel.BackColor = Color.Green
                GTLabel.ForeColor = Color.White
            ElseIf CrystalCount = 7 Then
                GTLabel.BackColor = Color.Yellow
                GTLabel.ForeColor = Color.Black
            Else
                GTLabel.BackColor = Color.Red
                GTLabel.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub CrystalClick(sender As Object, e As EventArgs) Handles EPButton.Click, DPButton.Click, TOHButton.Click, PODButton.Click, SPButton.Click, SWButton.Click, TTButton.Click, IPButton.Click, MMButton.Click, TRButton.Click
        Select Case DirectCast(sender, PictureBox).Name
            Case "EPButton"
                EPReward = (EPReward + 1) Mod 4
                Select Case EPReward
                    Case 0
                        EPButton.Image = My.Resources.crystal
                    Case 1
                        EPButton.Image = My.Resources.fairycrystal
                    Case 2
                        EPButton.Image = My.Resources.otherpendant
                    Case 3
                        EPButton.Image = My.Resources.greenpendant
                End Select
            Case "DPButton"
                DPReward = (DPReward + 1) Mod 4
                Select Case DPReward
                    Case 0
                        DPButton.Image = My.Resources.crystal
                    Case 1
                        DPButton.Image = My.Resources.fairycrystal
                    Case 2
                        DPButton.Image = My.Resources.otherpendant
                    Case 3
                        DPButton.Image = My.Resources.greenpendant
                End Select
            Case "TOHButton"
                TOHReward = (TOHReward + 1) Mod 4
                Select Case TOHReward
                    Case 0
                        TOHButton.Image = My.Resources.crystal
                    Case 1
                        TOHButton.Image = My.Resources.fairycrystal
                    Case 2
                        TOHButton.Image = My.Resources.otherpendant
                    Case 3
                        TOHButton.Image = My.Resources.greenpendant
                End Select
            Case "PODButton"
                PODReward = (PODReward + 1) Mod 4
                Select Case PODReward
                    Case 0
                        PODButton.Image = My.Resources.crystal
                    Case 1
                        PODButton.Image = My.Resources.fairycrystal
                    Case 2
                        PODButton.Image = My.Resources.otherpendant
                    Case 3
                        PODButton.Image = My.Resources.greenpendant
                End Select
            Case "SPButton"
                SPReward = (SPReward + 1) Mod 4
                Select Case SPReward
                    Case 0
                        SPButton.Image = My.Resources.crystal
                    Case 1
                        SPButton.Image = My.Resources.fairycrystal
                    Case 2
                        SPButton.Image = My.Resources.otherpendant
                    Case 3
                        SPButton.Image = My.Resources.greenpendant
                End Select
            Case "SWButton"
                SWReward = (SWReward + 1) Mod 4
                Select Case SWReward
                    Case 0
                        SWButton.Image = My.Resources.crystal
                    Case 1
                        SWButton.Image = My.Resources.fairycrystal
                    Case 2
                        SWButton.Image = My.Resources.otherpendant
                    Case 3
                        SWButton.Image = My.Resources.greenpendant
                End Select
            Case "TTButton"
                TTReward = (TTReward + 1) Mod 4
                Select Case TTReward
                    Case 0
                        TTButton.Image = My.Resources.crystal
                    Case 1
                        TTButton.Image = My.Resources.fairycrystal
                    Case 2
                        TTButton.Image = My.Resources.otherpendant
                    Case 3
                        TTButton.Image = My.Resources.greenpendant
                End Select
            Case "IPButton"
                IPReward = (IPReward + 1) Mod 4
                Select Case IPReward
                    Case 0
                        IPButton.Image = My.Resources.crystal
                    Case 1
                        IPButton.Image = My.Resources.fairycrystal
                    Case 2
                        IPButton.Image = My.Resources.otherpendant
                    Case 3
                        IPButton.Image = My.Resources.greenpendant
                End Select
            Case "MMButton"
                MMReward = (MMReward + 1) Mod 4
                Select Case MMReward
                    Case 0
                        MMButton.Image = My.Resources.crystal
                    Case 1
                        MMButton.Image = My.Resources.fairycrystal
                    Case 2
                        MMButton.Image = My.Resources.otherpendant
                    Case 3
                        MMButton.Image = My.Resources.greenpendant
                End Select
            Case "TRButton"
                TRReward = (TRReward + 1) Mod 4
                Select Case TRReward
                    Case 0
                        TRButton.Image = My.Resources.crystal
                    Case 1
                        TRButton.Image = My.Resources.fairycrystal
                    Case 2
                        TRButton.Image = My.Resources.otherpendant
                    Case 3
                        TRButton.Image = My.Resources.greenpendant
                End Select
        End Select
        LWCheck()
        DWCheck()
        CrystalCheck()
    End Sub
    Public Sub CrystalCheck()
        CrystalCount = 0
        FairyCrystal = 0
        PendantCount = 0
        GreenPendant = False
        If EPBoss.Checked = True Then
            Select Case EPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If DPBoss.Checked = True Then
            Select Case DPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If HeraBoss.Checked = True Then
            Select Case TOHReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If PODBoss.Checked = True Then
            Select Case PODReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If SPBoss.Checked = True Then
            Select Case SPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If SWBoss.Checked = True Then
            Select Case SWReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If TTBoss.Checked = True Then
            Select Case TTReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If IPBoss.Checked = True Then
            Select Case IPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If MMBoss.Checked = True Then
            Select Case MMReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If TRBoss.Checked = True Then
            Select Case TRReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        LWCheck()
        DWCheck()
        GTCheck()
    End Sub

    Private Sub BowButton_Click(sender As Object, e As EventArgs) Handles BowButton.Click
        Bow = (Bow + 1) Mod 3
        Select Case Bow
            Case 0
                BowButton.Image = My.Resources.nobow
            Case 1
                BowButton.Image = My.Resources.bow
            Case 2
                BowButton.Image = My.Resources.silvers
        End Select
        EPCheck()
        PODCheck()
    End Sub

    Private Sub BoomButton_Click(sender As Object, e As EventArgs) Handles BoomButton.Click
        Boomerang = (Boomerang + 1) Mod 3
        Select Case Boomerang
            Case 0
                BoomButton.Image = My.Resources.noboomerang
            Case 1
                BoomButton.Image = My.Resources.blueboom
            Case 2
                BoomButton.Image = My.Resources.redboom
        End Select
    End Sub

    Private Sub HookButton_Click(sender As Object, e As EventArgs) Handles HookButton.Click
        If Hookshot = False Then Hookshot = True Else Hookshot = False
        If Hookshot = True Then HookButton.Image = My.Resources.hookshot Else HookButton.Image = My.Resources.nohook
        TOHCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub BombButton_Click(sender As Object, e As EventArgs) Handles BombButton.Click
        If Bombs = False Then Bombs = True Else Bombs = False
        If Bombs = True Then BombButton.Image = My.Resources.bombs Else BombButton.Image = My.Resources.nobombs
        SPCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub PowderButton_Click(sender As Object, e As EventArgs) Handles PowderButton.Click
        If Powder = False Then Powder = True Else Powder = False
        If Powder = True Then PowderButton.Image = My.Resources.powder Else PowderButton.Image = My.Resources.nopowder
        LWCheck()
    End Sub

    Private Sub FireButton_Click(sender As Object, e As EventArgs) Handles FireButton.Click
        If FireRod = False Then FireRod = True Else FireRod = False
        If FireRod = True Then FireButton.Image = My.Resources.firerod Else FireButton.Image = My.Resources.nofirerod
        DPCheck()
        TOHCheck()
        SWCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub IceButton_Click(sender As Object, e As EventArgs) Handles IceButton.Click
        If IceRod = False Then IceRod = True Else IceRod = False
        If IceRod = True Then IceButton.Image = My.Resources.icerod Else IceButton.Image = My.Resources.noicerod
        TRCheck()
    End Sub

    Private Sub BombosButton_Click(sender As Object, e As EventArgs) Handles BombosButton.Click
        If Bombos = False Then Bombos = True Else Bombos = False
        If Bombos = True Then
            BombosButton.Image = My.Resources.bombos
            MedallionCount = MedallionCount + 1
        Else
            BombosButton.Image = My.Resources.nobombos
            MedallionCount = MedallionCount - 1
        End If
        IPCheck()
        MMCheck()
        TRCheck()
    End Sub

    Private Sub EtherButton_Click(sender As Object, e As EventArgs) Handles EtherButton.Click
        If Ether = False Then Ether = True Else Ether = False
        If Ether = True Then
            EtherButton.Image = My.Resources.ether
            MedallionCount = MedallionCount + 1
        Else
            EtherButton.Image = My.Resources.noether
            MedallionCount = MedallionCount - 1
        End If
        MMCheck()
        TRCheck()
    End Sub

    Private Sub QuakeButton_Click(sender As Object, e As EventArgs) Handles QuakeButton.Click
        If Quake = False Then Quake = True Else Quake = False
        If Quake = True Then
            QuakeButton.Image = My.Resources.quake
            MedallionCount = MedallionCount + 1
        Else
            QuakeButton.Image = My.Resources.noquake
            MedallionCount = MedallionCount - 1
        End If
        MMCheck()
        TRCheck()
    End Sub

    Private Sub LampButton_Click(sender As Object, e As EventArgs) Handles LampButton.Click
        If Lamp = False Then Lamp = True Else Lamp = False
        If Lamp = True Then LampButton.Image = My.Resources.lamp Else LampButton.Image = My.Resources.nolamp
        EPCheck()
        DPCheck()
        TOHCheck()
        AgaCheck()
        PODCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub HammerButton_Click(sender As Object, e As EventArgs) Handles HammerButton.Click
        If Hammer = False Then Hammer = True Else Hammer = False
        If Hammer = True Then HammerButton.Image = My.Resources.hammer Else HammerButton.Image = My.Resources.nohammer
        TOHCheck()
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub FluteButton_Click(sender As Object, e As EventArgs) Handles FluteButton.Click
        If Flute = False Then Flute = True Else Flute = False
        If Flute = True Then FluteButton.Image = My.Resources.flute Else FluteButton.Image = My.Resources.noflute
        DPCheck()
        TOHCheck()
        MMCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub NetButton_Click(sender As Object, e As EventArgs) Handles NetButton.Click
        If Net = False Then Net = True Else Net = False
        If Net = True Then NetButton.Image = My.Resources.bugnet Else NetButton.Image = My.Resources.nobugnet
        AgaCheck()
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        If Book = False Then Book = True Else Book = False
        If Book = True Then BookButton.Image = My.Resources.book Else BookButton.Image = My.Resources.nobook
        DPCheck()
        LWCheck()
    End Sub

    Private Sub BottleButton_Click(sender As Object, e As EventArgs) Handles BottleButton.Click
        If Bottle = False Then Bottle = True Else Bottle = False
        If Bottle = True Then BottleButton.Image = My.Resources.bottle Else BottleButton.Image = My.Resources.nobottle
        LWCheck()
    End Sub

    Private Sub SomariaButton_Click(sender As Object, e As EventArgs) Handles SomariaButton.Click
        If Somaria = False Then Somaria = True Else Somaria = False
        If Somaria = True Then SomariaButton.Image = My.Resources.somaria Else SomariaButton.Image = My.Resources.nosomaria
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub ByrnaButton_Click(sender As Object, e As EventArgs) Handles ByrnaButton.Click
        If Byrna = False Then Byrna = True Else Byrna = False
        If Byrna = True Then ByrnaButton.Image = My.Resources.byrna Else ByrnaButton.Image = My.Resources.nobyrna
        MMCheck()
        TRCheck()
        DWCheck()
    End Sub

    Private Sub CapeButton_Click(sender As Object, e As EventArgs) Handles CapeButton.Click
        If Cape = False Then Cape = True Else Cape = False
        If Cape = True Then CapeButton.Image = My.Resources.cape Else CapeButton.Image = My.Resources.nocape
        AgaCheck()
        MMCheck()
        TRCheck()
        DWCheck()
    End Sub

    Private Sub MirrorButton_Click(sender As Object, e As EventArgs) Handles MirrorButton.Click
        If Mirror = False Then Mirror = True Else Mirror = False
        If Mirror = True Then MirrorButton.Image = My.Resources.mirror Else MirrorButton.Image = My.Resources.nomirror
        DPCheck()
        TOHCheck()
        SPCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub BootButton_Click(sender As Object, e As EventArgs) Handles BootButton.Click
        If Boots = False Then Boots = True Else Boots = False
        If Boots = True Then BootButton.Image = My.Resources.boots Else BootButton.Image = My.Resources.noboots
        DPCheck()
        MMCheck()
        LWCheck()
    End Sub

    Private Sub GloveButton_Click(sender As Object, e As EventArgs) Handles GloveButton.Click
        Glove = (Glove + 1) Mod 3
        Select Case Glove
            Case 0
                GloveButton.Image = My.Resources.noglove
            Case 1
                GloveButton.Image = My.Resources.glove
            Case 2
                GloveButton.Image = My.Resources.mitt
        End Select
        DPCheck()
        TOHCheck()
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub FlipperButton_Click(sender As Object, e As EventArgs) Handles FlipperButton.Click
        If Flippers = False Then Flippers = True Else Flippers = False
        If Flippers = True Then FlipperButton.Image = My.Resources.flippers Else FlipperButton.Image = My.Resources.noflippers
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub PearlButton_Click(sender As Object, e As EventArgs) Handles PearlButton.Click
        If Pearl = False Then Pearl = True Else Pearl = False
        If Pearl = True Then PearlButton.Image = My.Resources.pearl Else PearlButton.Image = My.Resources.nopearl
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub MushButton_Click(sender As Object, e As EventArgs) Handles MushButton.Click
        If Mushroom = False Then Mushroom = True Else Mushroom = False
        If Mushroom = True Then MushButton.Image = My.Resources.mushroom Else MushButton.Image = My.Resources.nomushroom
        LWCheck()
    End Sub

    Private Sub ShovelButton_Click(sender As Object, e As EventArgs) Handles ShovelButton.Click
        If Shovel = False Then Shovel = True Else Shovel = False
        If Shovel = True Then ShovelButton.Image = My.Resources.shovel Else ShovelButton.Image = My.Resources.noshovel
        LWCheck()
    End Sub

    Private Sub AgaButton_Click(sender As Object, e As EventArgs) Handles AgaButton.Click
        If Aganhim = False Then Aganhim = True Else Aganhim = False
        If Aganhim = True Then AgaButton.Image = My.Resources.aganhim Else AgaButton.Image = My.Resources.noaganhim
        PODCheck()
        SWCheck()
        TTCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub SwordButton_Click(sender As Object, e As EventArgs) Handles SwordButton.Click
        Sword = (Sword + 1) Mod 5
        Select Case Sword
            Case 0
                SwordButton.Image = My.Resources.nosword
            Case 1
                SwordButton.Image = My.Resources.sword1
            Case 2
                SwordButton.Image = My.Resources.sword2
            Case 3
                SwordButton.Image = My.Resources.sword3
            Case 4
                SwordButton.Image = My.Resources.sword4
        End Select
        AgaCheck()
        TOHCheck()
        SWCheck()
    End Sub

    Private Sub ArmorButton_Click(sender As Object, e As EventArgs) Handles ArmorButton.Click
        Armor = (Armor + 1) Mod 3
        Select Case Armor
            Case 0
                ArmorButton.Image = My.Resources.greenmail
            Case 1
                ArmorButton.Image = My.Resources.bluemail
            Case 2
                ArmorButton.Image = My.Resources.redmail
        End Select

    End Sub

    Private Sub ShieldButton_Click(sender As Object, e As EventArgs) Handles ShieldButton.Click
        Shield = (Shield + 1) Mod 4
        Select Case Shield
            Case 0
                ShieldButton.Image = My.Resources.noshield
            Case 1
                ShieldButton.Image = My.Resources.shield1
            Case 2
                ShieldButton.Image = My.Resources.shield2
            Case 3
                ShieldButton.Image = My.Resources.shield3
        End Select
        TRCheck()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Form2.ShowDialog()
    End Sub
End Class

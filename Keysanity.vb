Public Class Form1
    Dim Bow, Boomerang, Glove, Sword, Armor, Shield, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, CrystalCount, FairyCrystal, PendantCount, Available As Integer
    Dim Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Public Sub LWCheck()
        '' Castle & Escape - Castle partially blocked by lamp, Escape blocked by Glove or Sewer Key plus Boots or Bombs
        If Lamp = True And (Glove > 0 Or HC1.Checked = True) And (Bombs = True Or Boots = True) Then
            HCLabel.BackColor = Color.Green
            HCLabel.ForeColor = Color.White
        ElseIf (Glove > 0 Or HC1.Checked = True) And (Bombs = True Or Boots = True) Then
            HCLabel.BackColor = Color.Yellow
            HCLabel.ForeColor = Color.Black
        ElseIf Lamp = True Then
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

    Private Sub HCClick(sender As Object, e As EventArgs) Handles HC1.CheckedChanged, HC2.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "HC1"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "HC2"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "HC1"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "HC2"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
            End Select
        End If
    End Sub
    Private Sub AGClick(sender As Object, e As EventArgs) Handles AG1.CheckedChanged, AG2.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            DirectCast(sender, CheckBox).Image = My.Resources.key1
        Else
            If My.Computer.Keyboard.ShiftKeyDown Then
                DirectCast(sender, CheckBox).Checked = True
                DirectCast(sender, CheckBox).BackColor = Color.Green
                DirectCast(sender, CheckBox).Image = My.Resources.key1
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
            End If
        End If
    End Sub
    Private Sub EPClick(sender As Object, e As EventArgs) Handles EP4.CheckedChanged, EP5.CheckedChanged, EP6.CheckedChanged, EPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "EP4"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "EP5"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "EP6"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "EPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    EPButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "EP4"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "EP5"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "EP6"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "EPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    EPButton.BackColor = Color.Black
            End Select
        End If
        EPCheck()
        CrystalCheck()
    End Sub

    Public Sub EPCheck()
        If Bow > 0 And Lamp = True And EP6.Checked = True Then
            EPLabel2.BackColor = Color.Green
            EPLabel2.ForeColor = Color.White
            EPBoss.Enabled = True
        End If
        If Bow > 0 And Lamp = False And EP6.Checked = True Then
            EPLabel2.BackColor = Color.Orange
            EPLabel2.ForeColor = Color.Black
            EPBoss.Enabled = True
        End If
        If Bow = 0 Then
            EPLabel2.BackColor = Color.Yellow
            EPLabel2.ForeColor = Color.Black
            EPBoss.Enabled = False
        End If
    End Sub

    Private Sub DPLabel_Click(sender As Object, e As EventArgs) Handles DPLabel.Click
        If DPLabel.BackColor = Color.Black Then DPLabel.BackColor = Color.Green Else DPLabel.BackColor = Color.Black
    End Sub

    Private Sub DPClick(sender As Object, e As EventArgs) Handles DP3.CheckedChanged, DP4.CheckedChanged, DP5.CheckedChanged, DP6.CheckedChanged, DPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "DP3"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "DP4"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "DP5"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "DP6"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "DPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    DPButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "DP3"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "DP4"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "DP5"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "DP6"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "DPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    DPButton.BackColor = Color.Black
            End Select
        End If
        DPCheck()
        CrystalCheck()
    End Sub
    Public Sub DPCheck()
        If (Book = True Or (Flute = True And Mirror = True And Glove = 2)) And Boots = True And (FireRod = True Or Lamp = True) And Glove > 0 And DP6.Checked = True Then
            DPLabel2.BackColor = Color.Green
            DPLabel2.ForeColor = Color.White
            DPBoss.Enabled = True
        ElseIf Book = True Or (Flute = True And Mirror = True And Glove = 2) Then
            DPLabel2.BackColor = Color.Yellow
            DPLabel2.ForeColor = Color.Black
            DPBoss.Enabled = False
        Else
            DPLabel2.BackColor = Color.Red
            DPLabel2.ForeColor = Color.Black
            DPBoss.Enabled = False
        End If
    End Sub
    Private Sub TOHLabel_Click(sender As Object, e As EventArgs) Handles TOHLabel.Click
        If TOHLabel.BackColor = Color.Black Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Black
    End Sub

    Private Sub TOHClick(sender As Object, e As EventArgs) Handles Hera3.CheckedChanged, Hera4.CheckedChanged, Hera5.CheckedChanged, Hera6.CheckedChanged, HeraBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "Hera3"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "Hera4"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "Hera5"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "Hera6"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "HeraBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TOHButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "Hera3"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "Hera4"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "Hera5"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "Hera6"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "HeraBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TOHButton.BackColor = Color.Black
            End Select
        End If
        TOHCheck()
    End Sub
    Public Sub TOHCheck()
        If (Flute = True Or (Glove > 0 And Lamp = True)) And (Mirror = True Or (Hammer = True And Hookshot = True)) And (FireRod = True Or Lamp = True) And (Sword > 0 Or Hammer = True) And Hera6.Checked = True Then
            TOHLabel2.BackColor = Color.Green
            TOHLabel2.ForeColor = Color.White
            HeraBoss.Enabled = True
        ElseIf Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) And FireRod = True And (Sword > 0 Or Hammer = True) And Hera6.Checked = True Then
            TOHLabel2.BackColor = Color.Orange
            TOHLabel2.ForeColor = Color.Black
            HeraBoss.Enabled = True
        ElseIf (Flute = True Or (Glove > 0 And Lamp = True)) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
            TOHLabel2.BackColor = Color.Yellow
            TOHLabel2.ForeColor = Color.Black
            HeraBoss.Enabled = False
        Else
            TOHLabel2.BackColor = Color.Red
            TOHLabel2.ForeColor = Color.Black
            HeraBoss.Enabled = False
        End If
        CrystalCheck()
    End Sub
    Public Sub AgaCheck()
        If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True Then
            AgaButton.Visible = True
            AgaLabel.BackColor = Color.Green
            AgaLabel.ForeColor = Color.White
        Else
            AgaButton.Visible = False
            AgaLabel.BackColor = Color.Red
            AgaLabel.ForeColor = Color.Black
        End If
    End Sub
    Private Sub PODClick(sender As Object, e As EventArgs) Handles POD6.CheckedChanged, POD7.CheckedChanged, POD8.CheckedChanged, POD9.CheckedChanged, POD10.CheckedChanged, POD11.CheckedChanged, POD12.CheckedChanged, POD13.CheckedChanged, POD14.CheckedChanged, PODBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "POD6", "POD7", "POD8", "POD9", "POD10", "POD11"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "POD12"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "POD13"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "POD14"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "PODBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    PODButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "POD6", "POD7", "POD8", "POD9", "POD10", "POD11"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "POD12"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "POD13"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "POD14"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "PODBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    PODButton.BackColor = Color.Black
            End Select
        End If
        PODCheck()
        CrystalCheck()
    End Sub
    Public Sub PODCheck()
        If Pearl = True And Bow > 0 And Hammer = True And Lamp = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And POD14.Checked = True Then
            PODLabel2.BackColor = Color.Green
            PODLabel2.ForeColor = Color.White
            PODBoss.Enabled = True
        ElseIf Pearl = True And Bow > 0 And Hammer = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And POD14.Checked = True Then
            PODLabel2.BackColor = Color.Orange
            PODLabel2.ForeColor = Color.Black
            PODBoss.Enabled = True
        ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
            PODLabel2.BackColor = Color.Yellow
            PODLabel2.ForeColor = Color.Black
            PODBoss.Enabled = False
        Else
            PODLabel2.BackColor = Color.Red
            PODLabel2.ForeColor = Color.Black
            PODBoss.Enabled = False
        End If
    End Sub
    Private Sub SPClick(sender As Object, e As EventArgs) Handles SP7.CheckedChanged, SP8.CheckedChanged, SP9.CheckedChanged, SP10.CheckedChanged, SPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "SP7"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "SP8"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "SP9"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "SP10"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "SPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    SPButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "SP7"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "SP8"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "SP9"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "SP10"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "SPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SPButton.BackColor = Color.Black
            End Select
        End If
        SPCheck()
        CrystalCheck()
    End Sub
    Public Sub SPCheck()
        If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) And SP7.Checked = True Then
            SPLabel2.BackColor = Color.Green
            SPLabel2.ForeColor = Color.White
            SPBoss.Enabled = True
        ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove > 0 Or Aganhim = True) Then
            SPLabel2.BackColor = Color.Yellow
            SPLabel2.ForeColor = Color.Black
            SPBoss.Enabled = False
        Else
            SPLabel2.BackColor = Color.Red
            SPLabel2.ForeColor = Color.Black
            SPBoss.Enabled = False
        End If
    End Sub
    Private Sub PODLabel_Click(sender As Object, e As EventArgs) Handles PODLabel.Click
        If PODLabel.BackColor = Color.Black Then PODLabel.BackColor = Color.Green Else PODLabel.BackColor = Color.Black
    End Sub

    Private Sub SPLabel_Click(sender As Object, e As EventArgs) Handles SPLabel.Click
        If SPLabel.BackColor = Color.Black Then SPLabel.BackColor = Color.Green Else SPLabel.BackColor = Color.Black
    End Sub

    Private Sub SWLabel_Click(sender As Object, e As EventArgs) Handles SWLabel.Click
        If SWLabel.BackColor = Color.Black Then SWLabel.BackColor = Color.Green Else SWLabel.BackColor = Color.Black
    End Sub

    Private Sub TTLabel_Click(sender As Object, e As EventArgs) Handles TTLabel.Click
        If TTLabel.BackColor = Color.Black Then TTLabel.BackColor = Color.Green Else TTLabel.BackColor = Color.Black
    End Sub

    Private Sub IPLabel_Click(sender As Object, e As EventArgs) Handles IPLabel.Click
        If IPLabel.BackColor = Color.Black Then IPLabel.BackColor = Color.Green Else IPLabel.BackColor = Color.Black
    End Sub

    Private Sub MMLabel_Click(sender As Object, e As EventArgs) Handles MMLabel.Click
        If MMLabel.BackColor = Color.Black Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Black
    End Sub

    Private Sub TRLabel_Click(sender As Object, e As EventArgs) Handles TRLabel.Click
        If TRLabel.BackColor = Color.Black Then TRLabel.BackColor = Color.Green Else TRLabel.BackColor = Color.Black
    End Sub

    Private Sub EPLabel_Click(sender As Object, e As EventArgs) Handles EPLabel.Click
        If EPLabel.BackColor = Color.Black Then EPLabel.BackColor = Color.Green Else EPLabel.BackColor = Color.Black
    End Sub

    Private Sub SWClick(sender As Object, e As EventArgs) Handles SW3.CheckedChanged, SW4.CheckedChanged, SW5.CheckedChanged, SW6.CheckedChanged, SW7.CheckedChanged, SW8.CheckedChanged, SWBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "SW3", "SW4", "SW5"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "SW6"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "SW7"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "SW8"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "SWBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    SWButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "SW3", "SW4", "SW5"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "SW6"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "SW7"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "SW8"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "SWBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SWButton.BackColor = Color.Black
            End Select
        End If
        SWCheck()
        CrystalCheck()
    End Sub
    Public Sub SWCheck()
        If Pearl = True And FireRod = True And Sword > 0 And ((Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True)))) Then
            SWLabel2.BackColor = Color.Green
            SWLabel2.ForeColor = Color.White
            SWBoss.Enabled = True
        ElseIf Pearl = True And ((Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True)))) Then
            SWLabel2.BackColor = Color.Yellow
            SWLabel2.ForeColor = Color.Black
            SWBoss.Enabled = False
        Else
            SWLabel2.BackColor = Color.Red
            SWLabel2.ForeColor = Color.Black
            SWBoss.Enabled = False
        End If
    End Sub


    Private Sub TTClick(sender As Object, e As EventArgs) Handles TT5.CheckedChanged, TT6.CheckedChanged, TT7.CheckedChanged, TT8.CheckedChanged, TTBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "TT5"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "TT6"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "TT7"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "TT8"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "TTBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TTButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "TT5"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "TT6"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "TT7"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "TT8"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "TTBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TTButton.BackColor = Color.Black
            End Select
        End If
        TTCheck()
        CrystalCheck()
    End Sub
    Public Sub TTCheck()
        If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And TT8.Checked = True Then
            TTLabel2.BackColor = Color.Green
            TTLabel2.ForeColor = Color.White
            TTBoss.Enabled = True
        ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
            TTLabel2.BackColor = Color.Yellow
            TTLabel2.ForeColor = Color.Black
            TTBoss.Enabled = True
        Else
            TTLabel2.BackColor = Color.Red
            TTLabel2.ForeColor = Color.Black
            TTBoss.Enabled = False
        End If
    End Sub

    Private Sub IPClick(sender As Object, e As EventArgs) Handles IP4.CheckedChanged, IP5.CheckedChanged, IP6.CheckedChanged, IP7.CheckedChanged, IP8.CheckedChanged, IPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "IP4", "IP5"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "IP6"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "IP7"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "IP8"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "IPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    IPButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "IP4", "IP5"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "IP6"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "IP7"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "IP8"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "IPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    IPButton.BackColor = Color.Black
            End Select
        End If
        IPCheck()
        CrystalCheck()
    End Sub
    Public Sub IPCheck()
        If Pearl = True And Flippers = True And Glove = 2 And Hammer = True And Hookshot = True And (FireRod = True Or Bombos = True) And IP8.Checked = True Then
            IPLabel2.BackColor = Color.Green
            IPLabel2.ForeColor = Color.White
            IPBoss.Enabled = True
        ElseIf Pearl = True And Glove = 2 And Hammer = True And Hookshot = True And (FireRod = True Or Bombos = True) And IP8.Checked = True Then
            IPLabel2.BackColor = Color.Orange
            IPLabel2.ForeColor = Color.Black
            IPBoss.Enabled = True
        ElseIf Pearl = True And Flippers = True And Glove = 2 And Hammer = True And (FireRod = True Or Bombos = True) Then
            IPLabel2.BackColor = Color.Yellow
            IPLabel2.ForeColor = Color.Black
            IPBoss.Enabled = True
        ElseIf Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) Then
            IPLabel2.BackColor = Color.Yellow
            IPLabel2.ForeColor = Color.Black
            IPBoss.Enabled = False
        Else
            IPLabel2.BackColor = Color.Red
            IPLabel2.ForeColor = Color.Black
            IPBoss.Enabled = False
        End If
    End Sub
    Private Sub MMClick(sender As Object, e As EventArgs) Handles MM3.CheckedChanged, MM4.CheckedChanged, MM5.CheckedChanged, MM6.CheckedChanged, MM7.CheckedChanged, MM8.CheckedChanged, MMBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "MM3", "MM4", "MM5"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "MM6"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "MM7"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "MM8"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "MMBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    MMButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "MM3", "MM4", "MM5"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "MM6"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "MM7"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "MM8"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "MMBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    MMButton.BackColor = Color.Black
            End Select
        End If
        MMCheck()
        CrystalCheck()
    End Sub
    Public Sub MMCheck()
        If Pearl = True And Glove = 2 And Flute = True And Somaria = True And Lamp = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And MM8.Checked = True Then
            MMLabel2.BackColor = Color.Green
            MMLabel2.ForeColor = Color.White
            MMBoss.Enabled = True
        ElseIf Pearl = True And Glove = 2 And Flute = True And Somaria = True And FireRod = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And MM8.Checked = True Then
            MMLabel2.BackColor = Color.Orange
            MMLabel2.ForeColor = Color.Black
            MMBoss.Enabled = True
        ElseIf Pearl = True And Glove = 2 And Flute = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
            MMLabel2.BackColor = Color.Yellow
            MMLabel2.ForeColor = Color.Black
            MMBoss.Enabled = False
        Else
            MMLabel2.BackColor = Color.Red
            MMLabel2.ForeColor = Color.Black
            MMBoss.Enabled = False
        End If
        CrystalCheck()
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
    Private Sub TRClick(sender As Object, e As EventArgs) Handles TR6.CheckedChanged, TR7.CheckedChanged, TR8.CheckedChanged, TR9.CheckedChanged, TR10.CheckedChanged, TR11.CheckedChanged, TR8.CheckedChanged, TR9.CheckedChanged, TR12.CheckedChanged, TRBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "TR6", "TR7", "TR8", "TR9"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "TR10"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "TR11"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "TR12"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
                Case "TRBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TRButton.BackColor = Color.Green
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "TR6", "TR7", "TR8", "TR9"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "TR10"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "TR11"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "TR12"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
                Case "TRBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TRButton.BackColor = Color.Black
            End Select
        End If
        TRCheck()
        CrystalCheck()
    End Sub

    Public Sub TRCheck()
        If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And Lamp = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And TR12.Checked = True Then
            TRAccess = True
            TRLabel2.BackColor = Color.Green
            TRLabel2.ForeColor = Color.White
            TRBoss.Enabled = True
        ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And TR12.Checked = True Then
            TRAccess = True
            TRLabel2.BackColor = Color.Orange
            TRLabel2.ForeColor = Color.Black
            TRBoss.Enabled = True
        ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
            TRAccess = True
            TRLabel2.BackColor = Color.Yellow
            TRLabel2.ForeColor = Color.Black
            TRBoss.Enabled = False
        Else
            TRAccess = False
            TRLabel2.BackColor = Color.Red
            TRLabel2.ForeColor = Color.Black
            TRBoss.Enabled = False
        End If
    End Sub

    Private Sub GT_CheckedChanged(sender As Object, e As EventArgs) Handles GT1.CheckedChanged, GT2.CheckedChanged, GT3.CheckedChanged, GT4.CheckedChanged, GT5.CheckedChanged, GT6.CheckedChanged, GT7.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            Select Case DirectCast(sender, CheckBox).Name
                Case "GT1", "GT2", "GT3", "GT4"
                    DirectCast(sender, CheckBox).Image = My.Resources.key1
                Case "GT5"
                    DirectCast(sender, CheckBox).Image = My.Resources.map1
                Case "GT6"
                    DirectCast(sender, CheckBox).Image = My.Resources.compass1
                Case "GT7"
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey1
            End Select
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "GT1", "GT2", "GT3", "GT4"
                    If My.Computer.Keyboard.ShiftKeyDown Then
                        DirectCast(sender, CheckBox).Checked = True
                        DirectCast(sender, CheckBox).BackColor = Color.Green
                        DirectCast(sender, CheckBox).Image = My.Resources.key1
                    Else
                        DirectCast(sender, CheckBox).Image = My.Resources.nokey1
                        DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
                    End If
                Case "GT5"
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap1
                Case "GT6"
                    DirectCast(sender, CheckBox).Image = My.Resources.nocompass1
                Case "GT7"
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey1
            End Select
        End If
        GTCheck()
    End Sub

    Public Sub GTCheck()
        If CrystalCount = 7 And GT7.Checked = True Then
            GTLabel.BackColor = Color.Green
            GTLabel.ForeColor = Color.White
        ElseIf CrystalCount = 7 Then
            GTLabel.BackColor = Color.Yellow
            GTLabel.ForeColor = Color.Black
        Else
            GTLabel.BackColor = Color.Red
            GTLabel.ForeColor = Color.Black
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
        CrystalCheck()
    End Sub

    Private Sub HCPrizes_Click(sender As Object, e As EventArgs) Handles HCPrizes.Click

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
        PODCheck()
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
        TRCheck()
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

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case (e.KeyChar)
            Case "!"
                EPButton.BackColor = Color.Green
            Case "@"
                DPButton.BackColor = Color.Green
            Case "#"
                TOHButton.BackColor = Color.Green
            Case "$"
                PODButton.BackColor = Color.Green
            Case "%"
                SPButton.BackColor = Color.Green
            Case "^"
                SWButton.BackColor = Color.Green
            Case "&"
                TTButton.BackColor = Color.Green
            Case "*"
                IPButton.BackColor = Color.Green
            Case "("
                MMButton.BackColor = Color.Green
            Case ")"
                TRButton.BackColor = Color.Green
        End Select
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Shift) = True Then
            EPLabel.Text = "1"
            DPLabel.Text = "2"
            TOHLabel.Text = "3"
            PODLabel.Text = "4"
            SPLabel.Text = "5"
            SWLabel.Text = "6"
            TTLabel.Text = "7"
            IPLabel.Text = "8"
            MMLabel.Text = "9"
            TRLabel.Text = "0"
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If (e.Shift) = False Then
            EPLabel.Text = "EP"
            DPLabel.Text = "DP"
            TOHLabel.Text = "TOH"
            PODLabel.Text = "POD"
            SPLabel.Text = "SP"
            SWLabel.Text = "SW"
            TTLabel.Text = "TT"
            IPLabel.Text = "IP"
            MMLabel.Text = "MM"
            TRLabel.Text = "TR"
        End If
    End Sub
    Private Sub HCPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles HCPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If HCPrizes.Text < 8 Then HCPrizes.Text = HCPrizes.Text + 1
        End If
        If e.Button = MouseButtons.Left Then
            If HCPrizes.Text > 0 Then HCPrizes.Text = HCPrizes.Text - 1
        End If
    End Sub
    Private Sub AgaPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles AgaPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If AgaPrizes.Text < 2 Then AgaPrizes.Text = AgaPrizes.Text + 1
        End If
        If e.Button = MouseButtons.Left Then
            If AgaPrizes.Text > 0 Then AgaPrizes.Text = AgaPrizes.Text - 1
        End If
    End Sub

    Private Sub EPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles EPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If EPPrizes.Text < 6 Then EPPrizes.Text = EPPrizes.Text + 1
            EPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If EPPrizes.Text > 0 Then EPPrizes.Text = EPPrizes.Text - 1
            If EPPrizes.Text = 0 Then EPLabel.BackColor = Color.Green
        End If
    End Sub

    Private Sub DPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles DPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If DPPrizes.Text < 6 Then DPPrizes.Text = DPPrizes.Text + 1
            DPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If DPPrizes.Text > 0 Then DPPrizes.Text = DPPrizes.Text - 1
            If DPPrizes.Text = 0 Then DPLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub TOHPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TOHPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If TOHPrizes.Text < 6 Then TOHPrizes.Text = TOHPrizes.Text + 1
            TOHLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If TOHPrizes.Text > 0 Then TOHPrizes.Text = TOHPrizes.Text - 1
            If TOHPrizes.Text = 0 Then TOHLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub PODPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles PODPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If PODPrizes.Text < 14 Then PODPrizes.Text = PODPrizes.Text + 1
            PODLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If PODPrizes.Text > 0 Then PODPrizes.Text = PODPrizes.Text - 1
            If PODPrizes.Text = 0 Then PODLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub SPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles SPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If SPPrizes.Text < 10 Then SPPrizes.Text = SPPrizes.Text + 1
            SPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If SPPrizes.Text > 0 Then SPPrizes.Text = SPPrizes.Text - 1
            If SPPrizes.Text = 0 Then SPLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub SWPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles SWPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If SWPrizes.Text < 8 Then SWPrizes.Text = SWPrizes.Text + 1
            SWLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If SWPrizes.Text > 0 Then SWPrizes.Text = SWPrizes.Text - 1
            If SWPrizes.Text = 0 Then SWLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub TTPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TTPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If TTPrizes.Text < 8 Then TTPrizes.Text = TTPrizes.Text + 1
            TTLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If TTPrizes.Text > 0 Then TTPrizes.Text = TTPrizes.Text - 1
            If TTPrizes.Text = 0 Then TTLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub IPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles IPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If IPPrizes.Text < 8 Then IPPrizes.Text = IPPrizes.Text + 1
            IPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If IPPrizes.Text > 0 Then IPPrizes.Text = IPPrizes.Text - 1
            If IPPrizes.Text = 0 Then IPLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub MMPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles MMPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If MMPrizes.Text < 8 Then MMPrizes.Text = MMPrizes.Text + 1
            MMLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If MMPrizes.Text > 0 Then MMPrizes.Text = MMPrizes.Text - 1
            If MMPrizes.Text = 0 Then MMLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub TRPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TRPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If TRPrizes.Text < 12 Then TRPrizes.Text = TRPrizes.Text + 1
            TRLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If TRPrizes.Text > 0 Then TRPrizes.Text = TRPrizes.Text - 1
            If TRPrizes.Text = 0 Then TRLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub GTPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles GTPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If GTPrizes.Text < 27 Then GTPrizes.Text = GTPrizes.Text + 1
        End If
        If e.Button = MouseButtons.Left Then
            If GTPrizes.Text > 0 Then GTPrizes.Text = GTPrizes.Text - 1
        End If
    End Sub
End Class

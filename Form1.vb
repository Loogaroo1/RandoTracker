Public Class Form1
    Dim Bow, Boomerang, Glove, Sword, Armor, Shield, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, CrystalCount, FairyCrystal, PendantCount, Available As Integer
    Dim Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess As Boolean
    Public Sub LWCheck()
        '' Castle - Partially blocked by lamp
        If Lamp = True Then
            LW3.Enabled = True
            LW3.BackColor = Color.WhiteSmoke
        Else
            LW3.Enabled = True
            LW3.BackColor = Color.Yellow
        End If

        '' Escape - Bombs/Boots with Glove (sequence break)
        If Glove > 0 And (Bombs = True Or Boots = True) Then
            LW4.Enabled = True
            LW4.BackColor = Color.WhiteSmoke
        Else
            LW4.Enabled = True
            LW4.BackColor = Color.Orange
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
        If LW3.Checked = True Then LW3.BackColor = Color.FromArgb(64, 64, 64)
        If LW4.Checked = True Then LW4.BackColor = Color.FromArgb(64, 64, 64)
        If LW5.Checked = True Then LW5.BackColor = Color.FromArgb(64, 64, 64)
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

    Private Sub LocationClick(sender As Object, e As EventArgs) Handles LW1.CheckedChanged, LW2.CheckedChanged, LW3.CheckedChanged, LW4.CheckedChanged, LW5.CheckedChanged, LW6.CheckedChanged, LW7.CheckedChanged, LW8.CheckedChanged, LW9.CheckedChanged, LW10.CheckedChanged, LW11.CheckedChanged, LW12.CheckedChanged, LW13.CheckedChanged, LW14.CheckedChanged, LW15.CheckedChanged, LW16.CheckedChanged,
        LW17.CheckedChanged, LW18.CheckedChanged, LW19.CheckedChanged, LW20.CheckedChanged, LW21.CheckedChanged, LW22.CheckedChanged, LW23.CheckedChanged, LW24.CheckedChanged, LW25.CheckedChanged, LW26.CheckedChanged, LW27.CheckedChanged, LW28.CheckedChanged, LW29.CheckedChanged, LW30.CheckedChanged, LW31.CheckedChanged, LW32.CheckedChanged,
        LW33.CheckedChanged, LW34.CheckedChanged, LW35.CheckedChanged, LW36.CheckedChanged, LW37.CheckedChanged, LW38.CheckedChanged, LW39.CheckedChanged, LW40.CheckedChanged, LW41.CheckedChanged, LW42.CheckedChanged, LW43.CheckedChanged, LW44.CheckedChanged, LW45.CheckedChanged, LW46.CheckedChanged, LW47.CheckedChanged, DW1.CheckedChanged,
        DW2.CheckedChanged, DW3.CheckedChanged, DW4.CheckedChanged, DW5.CheckedChanged, DW6.CheckedChanged, DW7.CheckedChanged, DW8.CheckedChanged, DW9.CheckedChanged, DW10.CheckedChanged, DW11.CheckedChanged, DW12.CheckedChanged, DW13.CheckedChanged, DW14.CheckedChanged, DW15.CheckedChanged, DW16.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then DirectCast(sender, CheckBox).BackColor = Color.FromArgb(64, 64, 64) Else DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
        LWCheck()
        DWCheck()
    End Sub

    Private Sub EPInfo(sender As Object, e As EventArgs) Handles EP1.MouseHover, EP2.MouseHover, EP3.MouseHover, EP4.MouseHover, EP5.MouseHover, EPBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "EP1"
                If EP1.Checked = False Then PictureBox1.Image = My.Resources.EP1
            Case "EP2"
                If EP2.Checked = False Then PictureBox1.Image = My.Resources.EP2
            Case "EP3"
                If EP3.Checked = False Then PictureBox1.Image = My.Resources.EP3
            Case "EP4"
                If EP4.Checked = False Then PictureBox1.Image = My.Resources.EP4
            Case "EP5"
                If EP5.Checked = False Then PictureBox1.Image = My.Resources.EP5
            Case "EPBoss"
                If EPBoss.Checked = False Then PictureBox1.Image = My.Resources.EPBoss
        End Select
    End Sub
    Private Sub EPClick(sender As Object, e As EventArgs) Handles EP1.CheckedChanged, EP2.CheckedChanged, EP3.CheckedChanged, EP4.CheckedChanged, EP5.CheckedChanged, EPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "EPBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                EPButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "EPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    EPButton.BackColor = Color.Black
                Case "EP5"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            EPCheck()
        End If
        CrystalCheck()
    End Sub

    Public Sub EPCheck()
        If Lamp = True Then EP4.Image = My.Resources.chest Else EP4.Image = My.Resources.chestlamp
        If Bow > 0 And Lamp = True Then
            EPBoss.Enabled = True
            EPBoss.Image = My.Resources.boss
        ElseIf Bow > 0 And Lamp = False Then
            EPBoss.Enabled = True
            EPBoss.Image = My.Resources.bosslamp
        Else
            EPBoss.Enabled = False
            EPBoss.Image = My.Resources.boss
        End If
        If EP1.Checked = True Then EP1.Image = My.Resources.chestopen
        If EP2.Checked = True Then EP2.Image = My.Resources.chestopen
        If EP3.Checked = True Then EP3.Image = My.Resources.chestopen
        If EP4.Checked = True Then EP4.Image = My.Resources.chestopen
        If EP5.Checked = True Then EP5.Image = My.Resources.chestopen
        If EPBoss.Checked = True Then EPBoss.Image = My.Resources.bossdead
    End Sub

    Private Sub DPLabel_Click(sender As Object, e As EventArgs) Handles DPLabel.Click
        If DPLabel.BackColor = Color.Black Then DPLabel.BackColor = Color.Green Else DPLabel.BackColor = Color.Black
    End Sub

    Private Sub DPClick(sender As Object, e As EventArgs) Handles DP1.CheckedChanged, DP2.CheckedChanged, DP3.CheckedChanged, DP4.CheckedChanged, DP5.CheckedChanged, DPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "DPBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                DPButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "DPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    DPButton.BackColor = Color.Black
                Case "DP4"
                    DirectCast(sender, CheckBox).Image = My.Resources.torch
                Case "DP5"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            DPCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub DPCheck()
        If Book = True Or (Flute = True And Mirror = True And Glove = 2) Then
            DP1.Enabled = True
            If Boots = True Then
                DP2.Enabled = True
                DP2.Image = My.Resources.chest
                DP3.Enabled = True
                DP3.Image = My.Resources.chest
                DP4.Enabled = True
                DP4.Image = My.Resources.torch
                DP5.Enabled = True
                DP5.Image = My.Resources.chestbigkey
            Else
                DP2.Enabled = True
                DP2.Image = My.Resources.chestmaybe
                DP3.Enabled = True
                DP3.Image = My.Resources.chestmaybe
                DP4.Enabled = False
                DP4.Image = My.Resources.torch
                DP5.Enabled = True
                DP5.Image = My.Resources.chestbigkeymaybe
            End If
            If Glove > 0 And (Lamp = True Or FireRod = True) Then
                DPBoss.Enabled = True
                If Boots = True Then DPBoss.Image = My.Resources.boss Else DPBoss.Image = My.Resources.bossmaybe
            Else
                DPBoss.Enabled = False
                DPBoss.Image = My.Resources.boss
            End If
        Else
            DP1.Enabled = False
            DP1.Image = My.Resources.chest
            DP2.Enabled = False
            DP2.Image = My.Resources.chest
            DP3.Enabled = False
            DP3.Image = My.Resources.chest
            DP4.Enabled = False
            DP4.Image = My.Resources.torch
            DP5.Enabled = False
            DP5.Image = My.Resources.chestbigkey
            DPBoss.Enabled = False
            DPBoss.Image = My.Resources.boss
        End If
        If DP1.Checked = True Then DP1.Image = My.Resources.chestopen
        If DP2.Checked = True Then DP2.Image = My.Resources.chestopen
        If DP3.Checked = True Then DP3.Image = My.Resources.chestopen
        If DP4.Checked = True Then DP4.Image = My.Resources.chestopen
        If DP5.Checked = True Then DP5.Image = My.Resources.chestopen
        If DPBoss.Checked = True Then DPBoss.Image = My.Resources.bossdead
    End Sub
    Private Sub DPInfo(sender As Object, e As EventArgs) Handles DP1.MouseHover, DP2.MouseHover, DP3.MouseHover, DP4.MouseHover, DP5.MouseHover, DPBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "DP1"
                If DP1.Checked = False Then PictureBox1.Image = My.Resources.DP1
            Case "DP2"
                If DP2.Checked = False Then PictureBox1.Image = My.Resources.DP2
            Case "DP3"
                If DP3.Checked = False Then PictureBox1.Image = My.Resources.DP3
            Case "DP4"
                If DP4.Checked = False Then PictureBox1.Image = My.Resources.DP4
            Case "DP5"
                If DP5.Checked = False Then PictureBox1.Image = My.Resources.DP5
            Case "DPBoss"
                If DPBoss.Checked = False Then PictureBox1.Image = My.Resources.DPBoss
        End Select
    End Sub

    Private Sub TOHLabel_Click(sender As Object, e As EventArgs) Handles TOHLabel.Click
        If TOHLabel.BackColor = Color.Black Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Black
    End Sub

    Private Sub TOHClick(sender As Object, e As EventArgs) Handles Hera1.CheckedChanged, Hera2.CheckedChanged, Hera3.CheckedChanged, Hera4.CheckedChanged, Hera5.CheckedChanged, HeraBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "HeraBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                TOHButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "HeraBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TOHButton.BackColor = Color.Black
                Case "Hera5"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            TOHCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub TOHCheck()
        If Flute = True And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
            Hera1.Enabled = True
            Hera1.Image = My.Resources.chest
            Hera2.Enabled = True
            Hera2.Image = My.Resources.chest
            If Lamp = True Or FireRod = True Then
                Hera3.Enabled = True
                Hera3.Image = My.Resources.chest
                Hera4.Enabled = True
                Hera4.Image = My.Resources.chest
                Hera5.Enabled = True
                Hera5.Image = My.Resources.chestbigkey
                If Sword > 0 Or Hammer = True Then
                    HeraBoss.Enabled = True
                    HeraBoss.Image = My.Resources.boss
                Else
                    HeraBoss.Enabled = False
                    HeraBoss.Image = My.Resources.boss
                End If
            Else
                Hera3.Enabled = False
                Hera3.Image = My.Resources.chest
                Hera4.Enabled = True
                Hera4.Image = My.Resources.chestmaybe
                Hera5.Enabled = True
                Hera5.Image = My.Resources.chestbigkeymaybe
                If Sword > 0 Or Hammer = True Then
                    HeraBoss.Enabled = True
                    HeraBoss.Image = My.Resources.bossmaybe
                Else
                    HeraBoss.Enabled = False
                    HeraBoss.Image = My.Resources.boss
                End If
            End If
        ElseIf Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
            If Lamp = True Then
                Hera1.Enabled = True
                Hera1.Image = My.Resources.chest
                Hera2.Enabled = True
                Hera2.Image = My.Resources.chest
                Hera3.Enabled = True
                Hera3.Image = My.Resources.chest
                Hera4.Enabled = True
                Hera4.Image = My.Resources.chest
                Hera5.Enabled = True
                Hera5.Image = My.Resources.chestbigkey
                If Sword > 0 Or Hammer = True Then
                    HeraBoss.Enabled = True
                    HeraBoss.Image = My.Resources.boss
                Else
                    HeraBoss.Enabled = False
                    HeraBoss.Image = My.Resources.boss
                End If
            ElseIf FireRod = True Then
                Hera1.Enabled = True
                Hera1.Image = My.Resources.chestlamp
                Hera2.Enabled = True
                Hera2.Image = My.Resources.chestlamp
                Hera3.Enabled = True
                Hera3.Image = My.Resources.chestlamp
                Hera4.Enabled = True
                Hera4.Image = My.Resources.chestlamp
                Hera5.Enabled = True
                Hera5.Image = My.Resources.chestbigkeylamp
                If Sword > 0 Or Hammer = True Then
                    HeraBoss.Enabled = True
                    HeraBoss.Image = My.Resources.bosslamp
                Else
                    HeraBoss.Enabled = False
                    HeraBoss.Image = My.Resources.boss
                End If
            Else
                Hera1.Enabled = True
                Hera1.Image = My.Resources.chestlamp
                Hera2.Enabled = True
                Hera2.Image = My.Resources.chestlamp
                Hera3.Enabled = False
                Hera3.Image = My.Resources.chest
                Hera4.Enabled = True
                Hera4.Image = My.Resources.chestmaybe
                Hera5.Enabled = True
                Hera5.Image = My.Resources.chestbigkeymaybe
                If Sword > 0 Or Hammer = True Then
                    HeraBoss.Enabled = True
                    HeraBoss.Image = My.Resources.bossmaybe
                Else
                    HeraBoss.Enabled = False
                    HeraBoss.Image = My.Resources.boss
                End If
            End If
        Else
            Hera1.Enabled = False
            Hera1.Image = My.Resources.chest
            Hera2.Enabled = False
            Hera2.Image = My.Resources.chest
            Hera3.Enabled = False
            Hera3.Image = My.Resources.chest
            Hera4.Enabled = False
            Hera4.Image = My.Resources.chest
            Hera5.Enabled = False
            Hera5.Image = My.Resources.chestbigkey
            HeraBoss.Enabled = False
            HeraBoss.Image = My.Resources.boss
        End If
        If Hera1.Checked = True Then Hera1.Image = My.Resources.chestopen
        If Hera2.Checked = True Then Hera2.Image = My.Resources.chestopen
        If Hera3.Checked = True Then Hera3.Image = My.Resources.chestopen
        If Hera4.Checked = True Then Hera4.Image = My.Resources.chestopen
        If Hera5.Checked = True Then Hera5.Image = My.Resources.chestopen
        If HeraBoss.Checked = True Then HeraBoss.Image = My.Resources.bossdead
    End Sub
    Private Sub TOHInfo(sender As Object, e As EventArgs) Handles Hera1.MouseHover, Hera2.MouseHover, Hera3.MouseHover, Hera4.MouseHover, Hera5.MouseHover, HeraBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "Hera1"
                If DP1.Checked = False Then PictureBox1.Image = My.Resources.TOH1
            Case "Hera2"
                If DP2.Checked = False Then PictureBox1.Image = My.Resources.TOH2
            Case "Hera3"
                If DP3.Checked = False Then PictureBox1.Image = My.Resources.TOH3
            Case "Hera4"
                If DP4.Checked = False Then PictureBox1.Image = My.Resources.TOH4
            Case "Hera5"
                If DP5.Checked = False Then PictureBox1.Image = My.Resources.TOH5
            Case "HeraBoss"
                If DPBoss.Checked = False Then PictureBox1.Image = My.Resources.TOHBoss
        End Select
    End Sub
    Public Sub AgaCheck()
        If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True Then
            AgaButton.Visible = True
        Else
            AgaButton.Visible = False
        End If
    End Sub
    Private Sub PODClick(sender As Object, e As EventArgs) Handles POD1.CheckedChanged, POD2.CheckedChanged, POD3.CheckedChanged, POD4.CheckedChanged, POD5.CheckedChanged, POD6.CheckedChanged, POD7.CheckedChanged, POD8.CheckedChanged, POD9.CheckedChanged, POD10.CheckedChanged, POD11.CheckedChanged, POD12.CheckedChanged, POD13.CheckedChanged, PODBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "PODBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                PODButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "PODBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    PODButton.BackColor = Color.Black
                Case "POD13"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            PODCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub PODCheck()
        If Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
            POD1.Enabled = True
            POD1.Image = My.Resources.chest
            If Bow > 0 And Lamp = True Then
                If Bombs = True Then
                    POD2.Enabled = True
                    POD2.Image = My.Resources.chest
                    POD5.Enabled = True
                    POD5.Image = My.Resources.chest
                    POD6.Enabled = True
                    POD6.Image = My.Resources.chest
                    POD13.Enabled = True
                    POD13.Image = My.Resources.chestbigkey
                ElseIf Boots = True Then
                    POD2.Enabled = False
                    POD2.Image = My.Resources.chest
                    POD5.Enabled = True
                    POD5.Image = My.Resources.chest
                    POD6.Enabled = False
                    POD6.Image = My.Resources.chest
                    POD13.Enabled = False
                    POD13.Image = My.Resources.chestbigkey
                Else
                    POD2.Enabled = False
                    POD2.Image = My.Resources.chest
                    POD5.Enabled = False
                    POD5.Image = My.Resources.chest
                    POD6.Enabled = False
                    POD6.Image = My.Resources.chest
                    POD13.Enabled = False
                    POD13.Image = My.Resources.chestbigkey
                End If
                POD3.Enabled = True
                POD3.Image = My.Resources.chest
                POD4.Enabled = True
                POD4.Image = My.Resources.chest
                POD7.Enabled = True
                POD7.Image = My.Resources.chest
                POD8.Enabled = True
                POD8.Image = My.Resources.chest
                POD9.Enabled = True
                POD9.Image = My.Resources.chest
                POD10.Enabled = True
                POD10.Image = My.Resources.chest
                POD11.Enabled = True
                POD11.Image = My.Resources.chest
                POD12.Enabled = True
                POD12.Image = My.Resources.chest
                If Hammer = True Then
                    PODBoss.Enabled = True
                    PODBoss.Image = My.Resources.boss
                Else
                    PODBoss.Enabled = False
                    PODBoss.Image = My.Resources.boss
                End If
            ElseIf Bow > 0 And Lamp = False Then
                If Bombs = True Then
                    POD2.Enabled = True
                    POD2.Image = My.Resources.chest
                    POD5.Enabled = True
                    POD5.Image = My.Resources.chest
                    POD6.Enabled = True
                    POD6.Image = My.Resources.chest
                    POD13.Enabled = True
                    POD13.Image = My.Resources.chestbigkeylamp
                ElseIf Boots = True Then
                    POD2.Enabled = False
                    POD2.Image = My.Resources.chest
                    POD5.Enabled = True
                    POD5.Image = My.Resources.chest
                    POD6.Enabled = False
                    POD6.Image = My.Resources.chest
                    POD13.Enabled = False
                    POD13.Image = My.Resources.chestbigkey
                Else
                    POD2.Enabled = False
                    POD2.Image = My.Resources.chest
                    POD5.Enabled = False
                    POD5.Image = My.Resources.chest
                    POD6.Enabled = False
                    POD6.Image = My.Resources.chest
                    POD13.Enabled = False
                    POD13.Image = My.Resources.chestbigkey
                End If
                POD3.Enabled = True
                POD3.Image = My.Resources.chest
                POD4.Enabled = True
                POD4.Image = My.Resources.chest
                POD7.Enabled = True
                POD7.Image = My.Resources.chest
                POD8.Enabled = True
                POD8.Image = My.Resources.chest
                POD9.Enabled = True
                POD9.Image = My.Resources.chestlamp
                POD10.Enabled = True
                POD10.Image = My.Resources.chestlamp
                POD11.Enabled = True
                POD11.Image = My.Resources.chestlamp
                POD12.Enabled = True
                POD12.Image = My.Resources.chestlamp
                If Hammer = True Then
                    PODBoss.Enabled = True
                    PODBoss.Image = My.Resources.bosslamp
                Else
                    PODBoss.Enabled = False
                    PODBoss.Image = My.Resources.boss
                End If
            Else
                If Bombs = True Then
                    POD2.Enabled = True
                    POD2.Image = My.Resources.chestmaybe
                    POD13.Enabled = True
                    POD13.Image = My.Resources.chestbigkeymaybe
                Else
                    POD2.Enabled = False
                    POD2.Image = My.Resources.chest
                    POD13.Enabled = False
                    POD13.Image = My.Resources.chestbigkey
                End If
                POD3.Enabled = True
                POD3.Image = My.Resources.chestmaybe
                POD4.Enabled = True
                POD4.Image = My.Resources.chestmaybe
                POD5.Enabled = False
                POD5.Image = My.Resources.chest
                POD6.Enabled = False
                POD6.Image = My.Resources.chest
                POD7.Enabled = True
                POD7.Image = My.Resources.chestmaybe
                POD8.Enabled = True
                POD8.Image = My.Resources.chestmaybe
                POD9.Enabled = True
                POD9.Image = My.Resources.chestmaybe
                POD10.Enabled = True
                POD10.Image = My.Resources.chestmaybe
                POD11.Enabled = True
                POD11.Image = My.Resources.chestmaybe
                POD12.Enabled = True
                POD12.Image = My.Resources.chestmaybe
                PODBoss.Enabled = False
                PODBoss.Image = My.Resources.boss
            End If
        Else
            POD1.Enabled = False
            POD1.Image = My.Resources.chest
            POD2.Enabled = False
            POD2.Image = My.Resources.chest
            POD3.Enabled = False
            POD3.Image = My.Resources.chest
            POD4.Enabled = False
            POD4.Image = My.Resources.chest
            POD5.Enabled = False
            POD5.Image = My.Resources.chest
            POD6.Enabled = False
            POD6.Image = My.Resources.chest
            POD7.Enabled = False
            POD7.Image = My.Resources.chest
            POD8.Enabled = False
            POD8.Image = My.Resources.chest
            POD9.Enabled = False
            POD9.Image = My.Resources.chest
            POD10.Enabled = False
            POD10.Image = My.Resources.chest
            POD11.Enabled = False
            POD11.Image = My.Resources.chest
            POD12.Enabled = False
            POD12.Image = My.Resources.chest
            POD13.Enabled = False
            POD13.Image = My.Resources.chestbigkey
            PODBoss.Enabled = False
            PODBoss.Image = My.Resources.boss
        End If
        If POD1.Checked = True Then POD1.Image = My.Resources.chestopen
        If POD2.Checked = True Then POD2.Image = My.Resources.chestopen
        If POD3.Checked = True Then POD3.Image = My.Resources.chestopen
        If POD4.Checked = True Then POD4.Image = My.Resources.chestopen
        If POD5.Checked = True Then POD5.Image = My.Resources.chestopen
        If POD6.Checked = True Then POD6.Image = My.Resources.chestopen
        If POD7.Checked = True Then POD7.Image = My.Resources.chestopen
        If POD8.Checked = True Then POD8.Image = My.Resources.chestopen
        If POD9.Checked = True Then POD9.Image = My.Resources.chestopen
        If POD10.Checked = True Then POD10.Image = My.Resources.chestopen
        If POD11.Checked = True Then POD11.Image = My.Resources.chestopen
        If POD12.Checked = True Then POD12.Image = My.Resources.chestopen
        If POD13.Checked = True Then POD13.Image = My.Resources.chestopen
        If PODBoss.Checked = True Then PODBoss.Image = My.Resources.bossdead
    End Sub
    Private Sub PODInfo(sender As Object, e As EventArgs) Handles POD1.MouseHover, POD2.MouseHover, POD3.MouseHover, POD4.MouseHover, POD5.MouseHover, POD6.MouseHover, POD7.MouseHover, POD8.MouseHover, POD9.MouseHover, POD10.MouseHover, POD11.MouseHover, POD12.MouseHover, POD13.MouseHover, PODBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "POD1"
                If POD1.Checked = False Then PictureBox1.Image = My.Resources.POD1
            Case "POD2"
                If POD2.Checked = False Then PictureBox1.Image = My.Resources.POD2
            Case "POD3"
                If POD3.Checked = False Then PictureBox1.Image = My.Resources.POD3
            Case "POD4"
                If POD4.Checked = False Then PictureBox1.Image = My.Resources.POD4
            Case "POD5"
                If POD5.Checked = False Then PictureBox1.Image = My.Resources.POD5
            Case "POD6"
                If POD6.Checked = False Then PictureBox1.Image = My.Resources.POD6
            Case "POD7"
                If POD7.Checked = False Then PictureBox1.Image = My.Resources.POD7
            Case "POD8"
                If POD8.Checked = False Then PictureBox1.Image = My.Resources.POD8
            Case "POD9"
                If POD9.Checked = False Then PictureBox1.Image = My.Resources.POD9
            Case "POD10"
                If POD10.Checked = False Then PictureBox1.Image = My.Resources.POD10
            Case "POD11"
                If POD11.Checked = False Then PictureBox1.Image = My.Resources.POD11
            Case "POD12"
                If POD12.Checked = False Then PictureBox1.Image = My.Resources.POD12
            Case "POD13"
                If POD13.Checked = False Then PictureBox1.Image = My.Resources.POD13
            Case "PODBoss"
                If PODBoss.Checked = False Then PictureBox1.Image = My.Resources.PODBoss
        End Select
    End Sub
    Private Sub SPClick(sender As Object, e As EventArgs) Handles SP1.CheckedChanged, SP2.CheckedChanged, SP3.CheckedChanged, SP4.CheckedChanged, SP5.CheckedChanged, SP6.CheckedChanged, SP7.CheckedChanged, SP8.CheckedChanged, SP9.CheckedChanged, SPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "SPBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                SPButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "SPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SPButton.BackColor = Color.Black
                Case "SP9"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            SPCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub SPCheck()
        If Pearl = True And Flippers = True And Mirror = True And ((Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or (Aganhim = True And Hookshot = True And Glove > 0) Or Glove = 2) Then
            SP1.Enabled = True
            SP1.Image = My.Resources.chest
            If Bombs = True Then
                SP2.Enabled = True
                SP2.Image = My.Resources.chest
            Else
                SP2.Enabled = False
                SP2.Image = My.Resources.chest
            End If
            If Hammer = True Then
                SP3.Enabled = True
                SP3.Image = My.Resources.chest
                SP4.Enabled = True
                SP4.Image = My.Resources.chest
                SP5.Enabled = True
                SP5.Image = My.Resources.chest
            Else
                SP3.Enabled = False
                SP3.Image = My.Resources.chest
                SP4.Enabled = False
                SP4.Image = My.Resources.chest
                SP5.Enabled = False
                SP5.Image = My.Resources.chest
            End If
            If Hammer = True And Hookshot = True Then
                SP6.Enabled = True
                SP6.Image = My.Resources.chest
                SP7.Enabled = True
                SP7.Image = My.Resources.chest
                SP8.Enabled = True
                SP8.Image = My.Resources.chest
                SP9.Enabled = True
                SP9.Image = My.Resources.chestbigkey
                SPBoss.Enabled = True
                SPBoss.Image = My.Resources.boss
            Else
                SP6.Enabled = False
                SP6.Image = My.Resources.chest
                SP7.Enabled = False
                SP7.Image = My.Resources.chest
                SP8.Enabled = False
                SP8.Image = My.Resources.chest
                SP9.Enabled = True
                SP9.Image = My.Resources.chestbigkeymaybe
                SPBoss.Enabled = False
                SPBoss.Image = My.Resources.boss
            End If
        Else
            SP1.Enabled = False
            SP1.Image = My.Resources.chest
            SP2.Enabled = False
            SP2.Image = My.Resources.chest
            SP3.Enabled = False
            SP3.Image = My.Resources.chest
            SP4.Enabled = False
            SP4.Image = My.Resources.chest
            SP5.Enabled = False
            SP5.Image = My.Resources.chest
            SP6.Enabled = False
            SP6.Image = My.Resources.chest
            SP7.Enabled = False
            SP7.Image = My.Resources.chest
            SP8.Enabled = False
            SP8.Image = My.Resources.chest
            SP9.Enabled = False
            SP9.Image = My.Resources.chestbigkey
            SPBoss.Enabled = False
            SPBoss.Image = My.Resources.boss
        End If
        If SP1.Checked = True Then SP1.Image = My.Resources.chestopen
        If SP2.Checked = True Then SP2.Image = My.Resources.chestopen
        If SP3.Checked = True Then SP3.Image = My.Resources.chestopen
        If SP4.Checked = True Then SP4.Image = My.Resources.chestopen
        If SP5.Checked = True Then SP5.Image = My.Resources.chestopen
        If SP6.Checked = True Then SP6.Image = My.Resources.chestopen
        If SP7.Checked = True Then SP7.Image = My.Resources.chestopen
        If SP8.Checked = True Then SP8.Image = My.Resources.chestopen
        If SP9.Checked = True Then SP9.Image = My.Resources.chestopen
        If SPBoss.Checked = True Then SPBoss.Image = My.Resources.bossdead
    End Sub
    Private Sub SPInfo(sender As Object, e As EventArgs) Handles SP1.MouseHover, SP2.MouseHover, SP3.MouseHover, SP4.MouseHover, SP5.MouseHover, SP6.MouseHover, SP7.MouseHover, SP8.MouseHover, SP9.MouseHover, SPBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "SP1"
                If SP1.Checked = False Then PictureBox1.Image = My.Resources.SP1
            Case "SP2"
                If SP2.Checked = False Then PictureBox1.Image = My.Resources.SP2
            Case "SP3"
                If SP3.Checked = False Then PictureBox1.Image = My.Resources.SP3
            Case "SP4"
                If SP4.Checked = False Then PictureBox1.Image = My.Resources.SP4
            Case "SP5"
                If SP5.Checked = False Then PictureBox1.Image = My.Resources.SP5
            Case "SP6"
                If SP6.Checked = False Then PictureBox1.Image = My.Resources.SP6
            Case "SP7"
                If SP7.Checked = False Then PictureBox1.Image = My.Resources.SP7
            Case "SP8"
                If SP8.Checked = False Then PictureBox1.Image = My.Resources.SP8
            Case "SP9"
                If SP9.Checked = False Then PictureBox1.Image = My.Resources.SP9
            Case "SPBoss"
                If SPBoss.Checked = False Then PictureBox1.Image = My.Resources.SPBoss
        End Select
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

    Private Sub ResetButton_Click(sender As Object, e As EventArgs)
        MsgBox("LOL. Close program and reopen.")
    End Sub

    Private Sub EPLabel_Click(sender As Object, e As EventArgs) Handles EPLabel.Click
        If EPLabel.BackColor = Color.Black Then EPLabel.BackColor = Color.Green Else EPLabel.BackColor = Color.Black
    End Sub

    Private Sub SWClick(sender As Object, e As EventArgs) Handles SW1.CheckedChanged, SW2.CheckedChanged, SW3.CheckedChanged, SW4.CheckedChanged, SW5.CheckedChanged, SW6.CheckedChanged, SW7.CheckedChanged, SWBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "SWBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                SWButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "SWBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SWButton.BackColor = Color.Black
                Case "SW7"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            SWCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub SWCheck()
        If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
            SW1.Enabled = True
            SW1.Image = My.Resources.chest
            SW2.Enabled = True
            SW2.Image = My.Resources.chest
            SW3.Enabled = True
            SW3.Image = My.Resources.chest
            SW4.Enabled = True
            SW4.Image = My.Resources.chest
            SW5.Enabled = True
            SW5.Image = My.Resources.chest
            If FireRod = True Then
                SW6.Enabled = True
                SW6.Image = My.Resources.chest
                SW7.Enabled = True
                SW7.Image = My.Resources.chestbigkey
                If Sword > 0 Then
                    SWBoss.Enabled = True
                    SWBoss.Image = My.Resources.boss
                Else
                    SWBoss.Enabled = False
                    SWBoss.Image = My.Resources.boss
                End If
            Else
                SW6.Enabled = False
                SW6.Image = My.Resources.chest
                SW7.Enabled = True
                SW7.Image = My.Resources.chestbigkeymaybe
                SWBoss.Enabled = False
                SWBoss.Image = My.Resources.boss
            End If
        Else
            SW1.Enabled = False
            SW1.Image = My.Resources.chest
            SW2.Enabled = False
            SW2.Image = My.Resources.chest
            SW3.Enabled = False
            SW3.Image = My.Resources.chest
            SW4.Enabled = False
            SW4.Image = My.Resources.chest
            SW5.Enabled = False
            SW5.Image = My.Resources.chest
            SW6.Enabled = False
            SW6.Image = My.Resources.chest
            SW7.Enabled = False
            SW7.Image = My.Resources.chestbigkey
            SWBoss.Enabled = False
            SWBoss.Image = My.Resources.boss
        End If
        If SW1.Checked = True Then SW1.Image = My.Resources.chestopen
        If SW2.Checked = True Then SW2.Image = My.Resources.chestopen
        If SW3.Checked = True Then SW3.Image = My.Resources.chestopen
        If SW4.Checked = True Then SW4.Image = My.Resources.chestopen
        If SW5.Checked = True Then SW5.Image = My.Resources.chestopen
        If SW6.Checked = True Then SW6.Image = My.Resources.chestopen
        If SW7.Checked = True Then SW7.Image = My.Resources.chestopen
        If SWBoss.Checked = True Then SWBoss.Image = My.Resources.bossdead
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SWInfo(sender As Object, e As EventArgs) Handles SW1.MouseHover, SW2.MouseHover, SW3.MouseHover, SW4.MouseHover, SW5.MouseHover, SW6.MouseHover, SW7.MouseHover, SWBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "SW1"
                If SW1.Checked = False Then PictureBox1.Image = My.Resources.SW1
            Case "SW2"
                If SW2.Checked = False Then PictureBox1.Image = My.Resources.SW2
            Case "SW3"
                If SW3.Checked = False Then PictureBox1.Image = My.Resources.SW3
            Case "SW4"
                If SW4.Checked = False Then PictureBox1.Image = My.Resources.SW4
            Case "SW5"
                If SW5.Checked = False Then PictureBox1.Image = My.Resources.SW5
            Case "SW6"
                If SW6.Checked = False Then PictureBox1.Image = My.Resources.SW6
            Case "SW7"
                If SW7.Checked = False Then PictureBox1.Image = My.Resources.SW7
            Case "SWBoss"
                If SWBoss.Checked = False Then PictureBox1.Image = My.Resources.SWBoss
        End Select
    End Sub
    Private Sub TTClick(sender As Object, e As EventArgs) Handles TT1.CheckedChanged, TT2.CheckedChanged, TT3.CheckedChanged, TT4.CheckedChanged, TT5.CheckedChanged, TT6.CheckedChanged, TT7.CheckedChanged, TTBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "TTBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                TTButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "TTBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TTButton.BackColor = Color.Black
                Case "TT7"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            TTCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub TTCheck()
        If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
            TT1.Enabled = True
            TT1.Image = My.Resources.chest
            TT2.Enabled = True
            TT2.Image = My.Resources.chest
            TT3.Enabled = True
            TT3.Image = My.Resources.chest
            TT4.Enabled = True
            TT4.Image = My.Resources.chest
            TT5.Enabled = True
            TT5.Image = My.Resources.chest
            TT6.Enabled = True
            TT6.Image = My.Resources.chest
            TTBoss.Enabled = True
            TTBoss.Image = My.Resources.boss
            If Hammer = True Then
                TT7.Enabled = True
                TT7.Image = My.Resources.chestbigkey
            Else
                TT7.Enabled = False
                TT7.Image = My.Resources.chestbigkey
            End If
        Else
            TT1.Enabled = False
            TT1.Image = My.Resources.chest
            TT2.Enabled = False
            TT2.Image = My.Resources.chest
            TT3.Enabled = False
            TT3.Image = My.Resources.chest
            TT4.Enabled = False
            TT4.Image = My.Resources.chest
            TT5.Enabled = False
            TT5.Image = My.Resources.chest
            TT6.Enabled = False
            TT6.Image = My.Resources.chest
            TT7.Enabled = False
            TT7.Image = My.Resources.chestbigkey
            TTBoss.Enabled = False
            TTBoss.Image = My.Resources.boss
        End If
        If TT1.Checked = True Then TT1.Image = My.Resources.chestopen
        If TT2.Checked = True Then TT2.Image = My.Resources.chestopen
        If TT3.Checked = True Then TT3.Image = My.Resources.chestopen
        If TT4.Checked = True Then TT4.Image = My.Resources.chestopen
        If TT5.Checked = True Then TT5.Image = My.Resources.chestopen
        If TT6.Checked = True Then TT6.Image = My.Resources.chestopen
        If TT7.Checked = True Then TT7.Image = My.Resources.chestopen
        If TTBoss.Checked = True Then TTBoss.Image = My.Resources.bossdead
    End Sub

    Private Sub TTInfo(sender As Object, e As EventArgs) Handles TT1.MouseHover, TT2.MouseHover, TT3.MouseHover, TT4.MouseHover, TT5.MouseHover, TT6.MouseHover, TT7.MouseHover, TTBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "TT1"
                If TT1.Checked = False Then PictureBox1.Image = My.Resources.TT1
            Case "TT2"
                If TT2.Checked = False Then PictureBox1.Image = My.Resources.TT2
            Case "TT3"
                If TT3.Checked = False Then PictureBox1.Image = My.Resources.TT3
            Case "TT4"
                If TT4.Checked = False Then PictureBox1.Image = My.Resources.TT4
            Case "TT5"
                If TT5.Checked = False Then PictureBox1.Image = My.Resources.TT5
            Case "TT6"
                If TT6.Checked = False Then PictureBox1.Image = My.Resources.TT6
            Case "TT7"
                If TT7.Checked = False Then PictureBox1.Image = My.Resources.TT7
            Case "TTBoss"
                If TTBoss.Checked = False Then PictureBox1.Image = My.Resources.TTBoss
        End Select
    End Sub
    Private Sub IPClick(sender As Object, e As EventArgs) Handles IP1.CheckedChanged, IP2.CheckedChanged, IP3.CheckedChanged, IP4.CheckedChanged, IP5.CheckedChanged, IP6.CheckedChanged, IP7.CheckedChanged, IPBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "IPBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                IPButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "IPBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    IPButton.BackColor = Color.Black
                Case "IP7"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            IPCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub IPCheck()
        If Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) Then
            If Flippers = True Then
                IP1.Enabled = True
                IP1.Image = My.Resources.chest
                IP2.Enabled = True
                IP2.Image = My.Resources.chest
                IP3.Enabled = True
                IP3.Image = My.Resources.chest
                If Hookshot = True Then
                    IP4.Enabled = True
                    IP4.Image = My.Resources.chest
                Else
                    IP4.Enabled = True
                    IP4.Image = My.Resources.chestmaybe
                    IP5.Enabled = True
                    IP5.Image = My.Resources.chestmaybe
                    IP6.Enabled = True
                    IP6.Image = My.Resources.chestmaybe
                End If
                If Hammer = True Then
                    IP5.Enabled = True
                    IP5.Image = My.Resources.chest
                    IP6.Enabled = True
                    IP6.Image = My.Resources.chest
                    IP7.Enabled = True
                    IP7.Image = My.Resources.chestbigkey
                    IPBoss.Enabled = True
                    IPBoss.Image = My.Resources.boss
                Else
                    IP5.Enabled = False
                    IP5.Image = My.Resources.chest
                    IP6.Enabled = False
                    IP6.Image = My.Resources.chest
                    IP7.Enabled = True
                    IP7.Image = My.Resources.chestbigkeymaybe
                    IPBoss.Enabled = False
                    IPBoss.Image = My.Resources.boss
                End If
            Else
                IP1.Enabled = True
                IP1.Image = My.Resources.chestflippers
                IP2.Enabled = True
                IP2.Image = My.Resources.chestflippers
                IP3.Enabled = True
                IP3.Image = My.Resources.chestflippers
                If Hookshot = True Then
                    IP4.Enabled = True
                    IP4.Image = My.Resources.chestflippers
                    IP5.Enabled = True
                    IP5.Image = My.Resources.chestflippers
                    IP6.Enabled = True
                    IP6.Image = My.Resources.chestflippers
                Else
                    IP4.Enabled = True
                    IP4.Image = My.Resources.chestmaybe
                    IP5.Enabled = True
                    IP5.Image = My.Resources.chestmaybe
                    IP6.Enabled = True
                    IP6.Image = My.Resources.chestmaybe
                End If
                If Hammer = True Then
                    IP5.Enabled = True
                    IP5.Image = My.Resources.chestflippers
                    IP6.Enabled = True
                    IP6.Image = My.Resources.chestflippers
                    IP7.Enabled = True
                    IP7.Image = My.Resources.chestbigkeyflipper
                    IPBoss.Enabled = True
                    IPBoss.Image = My.Resources.bossflippers
                Else
                    IP5.Enabled = False
                    IP5.Image = My.Resources.chest
                    IP6.Enabled = False
                    IP6.Image = My.Resources.chest
                    IP7.Enabled = True
                    IP7.Image = My.Resources.chestbigkeymaybe
                    IPBoss.Enabled = False
                    IPBoss.Image = My.Resources.boss
                End If
            End If
        Else
            IP1.Enabled = False
            IP1.Image = My.Resources.chest
            IP2.Enabled = False
            IP2.Image = My.Resources.chest
            IP3.Enabled = False
            IP3.Image = My.Resources.chest
            IP4.Enabled = False
            IP4.Image = My.Resources.chest
            IP5.Enabled = False
            IP5.Image = My.Resources.chest
            IP6.Enabled = False
            IP6.Image = My.Resources.chest
            IP7.Enabled = False
            IP7.Image = My.Resources.chestbigkey
            IPBoss.Enabled = False
            IPBoss.Image = My.Resources.boss
        End If
        If IP1.Checked = True Then IP1.Image = My.Resources.chestopen
        If IP2.Checked = True Then IP2.Image = My.Resources.chestopen
        If IP3.Checked = True Then IP3.Image = My.Resources.chestopen
        If IP4.Checked = True Then IP4.Image = My.Resources.chestopen
        If IP5.Checked = True Then IP5.Image = My.Resources.chestopen
        If IP6.Checked = True Then IP6.Image = My.Resources.chestopen
        If IP7.Checked = True Then IP7.Image = My.Resources.chestopen
        If IPBoss.Checked = True Then IPBoss.Image = My.Resources.bossdead
    End Sub
    Private Sub IPInfo(sender As Object, e As EventArgs) Handles IP1.MouseHover, IP2.MouseHover, IP3.MouseHover, IP4.MouseHover, IP5.MouseHover, IP6.MouseHover, IP7.MouseHover, IPBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "IP1"
                If IP1.Checked = False Then PictureBox1.Image = My.Resources.IP1
            Case "IP2"
                If IP2.Checked = False Then PictureBox1.Image = My.Resources.IP2
            Case "IP3"
                If IP3.Checked = False Then PictureBox1.Image = My.Resources.IP3
            Case "IP4"
                If IP4.Checked = False Then PictureBox1.Image = My.Resources.IP4
            Case "IP5"
                If IP5.Checked = False Then PictureBox1.Image = My.Resources.IP5
            Case "IP6"
                If IP6.Checked = False Then PictureBox1.Image = My.Resources.IP6
            Case "IP7"
                If IP7.Checked = False Then PictureBox1.Image = My.Resources.IP7
            Case "IPBoss"
                If IPBoss.Checked = False Then PictureBox1.Image = My.Resources.IPBoss
        End Select
    End Sub
    Private Sub MMClick(sender As Object, e As EventArgs) Handles MM1.CheckedChanged, MM2.CheckedChanged, MM3.CheckedChanged, MM4.CheckedChanged, MM5.CheckedChanged, MM6.CheckedChanged, MM7.CheckedChanged, MMBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "MMBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                MMButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "MMBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    MMButton.BackColor = Color.Black
                Case "MM7"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            MMCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub MMCheck()
        If Pearl = True And Glove = 2 And Flute = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
            MM1.Enabled = True
            MM1.Image = My.Resources.chest
            MM2.Enabled = True
            If Byrna = True Or Cape = True Then MM2.Image = My.Resources.chest Else MM2.Image = My.Resources.chestheart
            MM3.Enabled = True
            MM3.Image = My.Resources.chest
            MM4.Enabled = True
            MM4.Image = My.Resources.chest
            If Lamp = True Or FireRod = True Then
                MM5.Enabled = True
                MM5.Image = My.Resources.chest
                MM6.Enabled = True
                MM6.Image = My.Resources.chest
                MM7.Enabled = True
                MM7.Image = My.Resources.chestbigkey
            Else
                MM5.Enabled = False
                MM5.Image = My.Resources.chest
                MM6.Enabled = False
                MM6.Image = My.Resources.chest
                MM7.Enabled = True
                MM7.Image = My.Resources.chestbigkeymaybe
            End If
            If Lamp = True And Somaria = True Then
                MMBoss.Enabled = True
                MMBoss.Image = My.Resources.boss
            ElseIf Lamp = False And Somaria = True Then
                MMBoss.Enabled = True
                MMBoss.Image = My.Resources.bosslamp
            Else
                MMBoss.Enabled = False
                MMBoss.Image = My.Resources.boss
            End If
        Else
            MM1.Enabled = False
            MM1.Image = My.Resources.chest
            MM2.Enabled = False
            MM2.Image = My.Resources.chest
            MM3.Enabled = False
            MM3.Image = My.Resources.chest
            MM4.Enabled = False
            MM4.Image = My.Resources.chest
            MM5.Enabled = False
            MM5.Image = My.Resources.chest
            MM6.Enabled = False
            MM6.Image = My.Resources.chest
            MM7.Enabled = False
            MM7.Image = My.Resources.chestbigkey
            MMBoss.Enabled = False
            MMBoss.Image = My.Resources.boss
        End If
        If MM1.Checked = True Then MM1.Image = My.Resources.chestopen
        If MM2.Checked = True Then MM2.Image = My.Resources.chestopen
        If MM3.Checked = True Then MM3.Image = My.Resources.chestopen
        If MM4.Checked = True Then MM4.Image = My.Resources.chestopen
        If MM5.Checked = True Then MM5.Image = My.Resources.chestopen
        If MM6.Checked = True Then MM6.Image = My.Resources.chestopen
        If MM7.Checked = True Then MM7.Image = My.Resources.chestopen
        If MMBoss.Checked = True Then MMBoss.Image = My.Resources.bossdead
    End Sub
    Private Sub MMInfo(sender As Object, e As EventArgs) Handles MM1.MouseHover, MM2.MouseHover, MM3.MouseHover, MM4.MouseHover, MM5.MouseHover, MM6.MouseHover, MM7.MouseHover, MMBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "MM1"
                If MM1.Checked = False Then PictureBox1.Image = My.Resources.MM1
            Case "MM2"
                If MM2.Checked = False Then PictureBox1.Image = My.Resources.MM2
            Case "MM3"
                If MM3.Checked = False Then PictureBox1.Image = My.Resources.MM3
            Case "MM4"
                If MM4.Checked = False Then PictureBox1.Image = My.Resources.MM4
            Case "MM5"
                If MM5.Checked = False Then PictureBox1.Image = My.Resources.MM5
            Case "MM6"
                If MM6.Checked = False Then PictureBox1.Image = My.Resources.MM6
            Case "MM7"
                If MM7.Checked = False Then PictureBox1.Image = My.Resources.MM7
            Case "MMBoss"
                If MMBoss.Checked = False Then PictureBox1.Image = My.Resources.MMBoss
        End Select
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
    Private Sub TRClick(sender As Object, e As EventArgs) Handles TR1.CheckedChanged, TR2.CheckedChanged, TR3.CheckedChanged, TR4.CheckedChanged, TR5.CheckedChanged, TR6.CheckedChanged, TR7.CheckedChanged, TR8.CheckedChanged, TR9.CheckedChanged, TR10.CheckedChanged, TR11.CheckedChanged, TR8.CheckedChanged, TR9.CheckedChanged, TRBoss.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            If DirectCast(sender, CheckBox).Name = "TRBoss" Then
                DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                TRButton.BackColor = Color.Green
            Else
                DirectCast(sender, CheckBox).Image = My.Resources.chestopen
            End If
        Else
            Select Case DirectCast(sender, CheckBox).Name
                Case "TRBoss"
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TRButton.BackColor = Color.Black
                Case "TR11"
                    DirectCast(sender, CheckBox).Image = My.Resources.chestbigkey
                Case Else
                    DirectCast(sender, CheckBox).Image = My.Resources.chest
            End Select
            TOHCheck()
        End If
        CrystalCheck()
    End Sub
    Public Sub TRCheck()
        If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
            TRAccess = True
            TR1.Enabled = True
            TR1.Image = My.Resources.chest
            If FireRod = True Then
                TR2.Enabled = True
                TR2.Image = My.Resources.chest
                TR3.Enabled = True
                TR3.Image = My.Resources.chest
                TR4.Enabled = True
                TR4.Image = My.Resources.chest
                TR5.Enabled = True
                TR5.Image = My.Resources.chest
                TR6.Enabled = True
                TR6.Image = My.Resources.chest
                TR11.Enabled = True
                TR11.Image = My.Resources.chestbigkey
                If Lamp = True And (Byrna = True Or Cape = True Or Shield = 3) Then
                    TR7.Enabled = True
                    TR7.Image = My.Resources.chest
                    TR8.Enabled = True
                    TR8.Image = My.Resources.chest
                    TR9.Enabled = True
                    TR9.Image = My.Resources.chest
                    TR10.Enabled = True
                    TR10.Image = My.Resources.chest
                    If IceRod = True Then
                        TRBoss.Enabled = True
                        TRBoss.Image = My.Resources.boss
                    Else
                        TRBoss.Enabled = False
                        TRBoss.Image = My.Resources.boss
                    End If
                ElseIf Lamp = True And Byrna = False And Cape = False And Shield < 3 Then
                    TR7.Enabled = True
                    TR7.Image = My.Resources.chestheart
                    TR8.Enabled = True
                    TR8.Image = My.Resources.chestheart
                    TR9.Enabled = True
                    TR9.Image = My.Resources.chestheart
                    TR10.Enabled = True
                    TR10.Image = My.Resources.chestheart
                    If IceRod = True And Sword > 1 Then
                        TRBoss.Enabled = True
                        TRBoss.Image = My.Resources.boss
                    ElseIf IceRod = True Then
                        TRBoss.Enabled = True
                        TRBoss.Image = My.Resources.bossmaster
                    Else
                        TRBoss.Enabled = False
                        TRBoss.Image = My.Resources.boss
                    End If
                Else
                    TR7.Enabled = True
                    TR7.Image = My.Resources.chestlamp
                    TR8.Enabled = True
                    TR8.Image = My.Resources.chestlamp
                    TR9.Enabled = True
                    TR9.Image = My.Resources.chestlamp
                    TR10.Enabled = True
                    TR10.Image = My.Resources.chestlamp
                    If IceRod = True Then
                        TRBoss.Enabled = True
                        TRBoss.Image = My.Resources.bosslamp
                    Else
                        TRBoss.Enabled = False
                        TRBoss.Image = My.Resources.boss
                    End If
                End If
            Else
                TR2.Enabled = False
                TR2.Image = My.Resources.chest
                TR3.Enabled = False
                TR3.Image = My.Resources.chest
                TR4.Enabled = True
                TR4.Image = My.Resources.chestmaybe
                TR5.Enabled = True
                TR5.Image = My.Resources.chestmaybe
                TR6.Enabled = True
                TR6.Image = My.Resources.chestmaybe
                TR7.Enabled = True
                TR7.Image = My.Resources.chestmaybe
                TR8.Enabled = True
                TR8.Image = My.Resources.chestmaybe
                TR9.Enabled = True
                TR9.Image = My.Resources.chestmaybe
                TR10.Enabled = True
                TR10.Image = My.Resources.chestmaybe
                TR11.Enabled = True
                TR11.Image = My.Resources.chestbigkeymaybe
                TRBoss.Enabled = False
                TRBoss.Image = My.Resources.boss
            End If
        Else
            TRAccess = False
            TR1.Enabled = False
            TR1.Image = My.Resources.chest
            TR2.Enabled = False
            TR2.Image = My.Resources.chest
            TR3.Enabled = False
            TR3.Image = My.Resources.chest
            TR4.Enabled = False
            TR4.Image = My.Resources.chest
            TR5.Enabled = False
            TR5.Image = My.Resources.chest
            TR6.Enabled = False
            TR6.Image = My.Resources.chest
            TR7.Enabled = False
            TR7.Image = My.Resources.chest
            TR8.Enabled = False
            TR8.Image = My.Resources.chest
            TR9.Enabled = False
            TR9.Image = My.Resources.chest
            TR10.Enabled = False
            TR10.Image = My.Resources.chest
            TR11.Enabled = False
            TR11.Image = My.Resources.chestbigkey
            TRBoss.Enabled = False
            TRBoss.Image = My.Resources.boss
        End If
        If TR1.Checked = True Then TR1.Image = My.Resources.chestopen
        If TR2.Checked = True Then TR2.Image = My.Resources.chestopen
        If TR3.Checked = True Then TR3.Image = My.Resources.chestopen
        If TR4.Checked = True Then TR4.Image = My.Resources.chestopen
        If TR5.Checked = True Then TR5.Image = My.Resources.chestopen
        If TR6.Checked = True Then TR6.Image = My.Resources.chestopen
        If TR7.Checked = True Then TR7.Image = My.Resources.chestopen
        If TR8.Checked = True Then TR8.Image = My.Resources.chestopen
        If TR9.Checked = True Then TR9.Image = My.Resources.chestopen
        If TR10.Checked = True Then TR10.Image = My.Resources.chestopen
        If TR11.Checked = True Then TR11.Image = My.Resources.chestopen
        If TRBoss.Checked = True Then TRBoss.Image = My.Resources.bossdead
    End Sub

    Private Sub TRInfo(sender As Object, e As EventArgs) Handles TR1.MouseHover, TR2.MouseHover, TR3.MouseHover, TR4.MouseHover, TR5.MouseHover, TR6.MouseHover, TR7.MouseHover, TR8.MouseHover, TR9.MouseHover, TR10.MouseHover, TR11.MouseHover, TRBoss.MouseHover
        Select Case DirectCast(sender, CheckBox).Name
            Case "TR1"
                If TR1.Checked = False Then PictureBox1.Image = My.Resources.TR1
            Case "TR2"
                If TR2.Checked = False Then PictureBox1.Image = My.Resources.TR2
            Case "TR3"
                If TR3.Checked = False Then PictureBox1.Image = My.Resources.TR3
            Case "TR4"
                If TR4.Checked = False Then PictureBox1.Image = My.Resources.TR4
            Case "TR5"
                If TR5.Checked = False Then PictureBox1.Image = My.Resources.TR5
            Case "TR6"
                If TR6.Checked = False Then PictureBox1.Image = My.Resources.TR6
            Case "TR7"
                If TR7.Checked = False Then PictureBox1.Image = My.Resources.TR7
            Case "TR8"
                If TR8.Checked = False Then PictureBox1.Image = My.Resources.TR8
            Case "TR9"
                If TR9.Checked = False Then PictureBox1.Image = My.Resources.TR9
            Case "TR10"
                If TR10.Checked = False Then PictureBox1.Image = My.Resources.TR10
            Case "TR11"
                If TR11.Checked = False Then PictureBox1.Image = My.Resources.TR11
            Case "TRBoss"
                If TRBoss.Checked = False Then PictureBox1.Image = My.Resources.TRBoss
        End Select
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
                EP1.Checked = True
                EP1.Image = My.Resources.chestopen
                EP2.Checked = True
                EP2.Image = My.Resources.chestopen
                EP3.Checked = True
                EP3.Image = My.Resources.chestopen
                EP4.Checked = True
                EP4.Image = My.Resources.chestopen
                EP5.Checked = True
                EP5.Image = My.Resources.chestopen
                EPBoss.Checked = True
                EPBoss.Image = My.Resources.bossdead
                EPLabel.BackColor = Color.Green
                EPPrizes.Text = 0
            Case "@"
                DP1.Checked = True
                DP1.Image = My.Resources.chestopen
                DP2.Checked = True
                DP2.Image = My.Resources.chestopen
                DP3.Checked = True
                DP3.Image = My.Resources.chestopen
                DP4.Checked = True
                DP4.Image = My.Resources.chestopen
                DP5.Checked = True
                DP5.Image = My.Resources.chestopen
                DPBoss.Checked = True
                DPBoss.Image = My.Resources.bossdead
                DPLabel.BackColor = Color.Green
                DPPrizes.Text = 0
            Case "#"
                Hera1.Checked = True
                Hera1.Image = My.Resources.chestopen
                Hera2.Checked = True
                Hera2.Image = My.Resources.chestopen
                Hera3.Checked = True
                Hera3.Image = My.Resources.chestopen
                Hera4.Checked = True
                Hera4.Image = My.Resources.chestopen
                Hera5.Checked = True
                Hera5.Image = My.Resources.chestopen
                HeraBoss.Checked = True
                HeraBoss.Image = My.Resources.bossdead
                TOHLabel.BackColor = Color.Green
                TOHPrizes.Text = 0
            Case "$"
                POD1.Checked = True
                POD1.Image = My.Resources.chestopen
                POD2.Checked = True
                POD2.Image = My.Resources.chestopen
                POD3.Checked = True
                POD3.Image = My.Resources.chestopen
                POD4.Checked = True
                POD4.Image = My.Resources.chestopen
                POD5.Checked = True
                POD5.Image = My.Resources.chestopen
                POD6.Checked = True
                POD6.Image = My.Resources.chestopen
                POD7.Checked = True
                POD7.Image = My.Resources.chestopen
                POD8.Checked = True
                POD8.Image = My.Resources.chestopen
                POD9.Checked = True
                POD9.Image = My.Resources.chestopen
                POD10.Checked = True
                POD10.Image = My.Resources.chestopen
                POD11.Checked = True
                POD11.Image = My.Resources.chestopen
                POD12.Checked = True
                POD12.Image = My.Resources.chestopen
                POD13.Checked = True
                POD13.Image = My.Resources.chestopen
                PODBoss.Checked = True
                PODBoss.Image = My.Resources.bossdead
                PODLabel.BackColor = Color.Green
                PODPrizes.Text = 0
            Case "%"
                SP1.Checked = True
                SP1.Image = My.Resources.chestopen
                SP2.Checked = True
                SP2.Image = My.Resources.chestopen
                SP3.Checked = True
                SP3.Image = My.Resources.chestopen
                SP4.Checked = True
                SP4.Image = My.Resources.chestopen
                SP5.Checked = True
                SP5.Image = My.Resources.chestopen
                SP6.Checked = True
                SP6.Image = My.Resources.chestopen
                SP7.Checked = True
                SP7.Image = My.Resources.chestopen
                SP8.Checked = True
                SP8.Image = My.Resources.chestopen
                SP9.Checked = True
                SP9.Image = My.Resources.chestopen
                SPBoss.Checked = True
                SPBoss.Image = My.Resources.bossdead
                SPLabel.BackColor = Color.Green
                SPPrizes.Text = 0
            Case "^"
                SW1.Checked = True
                SW1.Image = My.Resources.chestopen
                SW2.Checked = True
                SW2.Image = My.Resources.chestopen
                SW3.Checked = True
                SW3.Image = My.Resources.chestopen
                SW4.Checked = True
                SW4.Image = My.Resources.chestopen
                SW5.Checked = True
                SW5.Image = My.Resources.chestopen
                SW6.Checked = True
                SW6.Image = My.Resources.chestopen
                SW7.Checked = True
                SW7.Image = My.Resources.chestopen
                SWBoss.Checked = True
                SWBoss.Image = My.Resources.bossdead
                SWLabel.BackColor = Color.Green
                SWPrizes.Text = 0
            Case "&"
                TT1.Checked = True
                TT1.Image = My.Resources.chestopen
                TT2.Checked = True
                TT2.Image = My.Resources.chestopen
                TT3.Checked = True
                TT3.Image = My.Resources.chestopen
                TT4.Checked = True
                TT4.Image = My.Resources.chestopen
                TT5.Checked = True
                TT5.Image = My.Resources.chestopen
                TT6.Checked = True
                TT6.Image = My.Resources.chestopen
                TT7.Checked = True
                TT7.Image = My.Resources.chestopen
                TTBoss.Checked = True
                TTBoss.Image = My.Resources.bossdead
                TTLabel.BackColor = Color.Green
                TTPrizes.Text = 0
            Case "*"
                IP1.Checked = True
                IP1.Image = My.Resources.chestopen
                IP2.Checked = True
                IP2.Image = My.Resources.chestopen
                IP3.Checked = True
                IP3.Image = My.Resources.chestopen
                IP4.Checked = True
                IP4.Image = My.Resources.chestopen
                IP5.Checked = True
                IP5.Image = My.Resources.chestopen
                IP6.Checked = True
                IP6.Image = My.Resources.chestopen
                IP7.Checked = True
                IP7.Image = My.Resources.chestopen
                IPBoss.Checked = True
                IPBoss.Image = My.Resources.bossdead
                IPLabel.BackColor = Color.Green
                IPPrizes.Text = 0
            Case "("
                MM1.Checked = True
                MM1.Image = My.Resources.chestopen
                MM2.Checked = True
                MM2.Image = My.Resources.chestopen
                MM3.Checked = True
                MM3.Image = My.Resources.chestopen
                MM4.Checked = True
                MM4.Image = My.Resources.chestopen
                MM5.Checked = True
                MM5.Image = My.Resources.chestopen
                MM6.Checked = True
                MM6.Image = My.Resources.chestopen
                MM7.Checked = True
                MM7.Image = My.Resources.chestopen
                MMBoss.Checked = True
                MMBoss.Image = My.Resources.bossdead
                MMLabel.BackColor = Color.Green
                MMPrizes.Text = 0
            Case ")"
                TR1.Checked = True
                TR1.Image = My.Resources.chestopen
                TR2.Checked = True
                TR2.Image = My.Resources.chestopen
                TR3.Checked = True
                TR3.Image = My.Resources.chestopen
                TR4.Checked = True
                TR4.Image = My.Resources.chestopen
                TR5.Checked = True
                TR5.Image = My.Resources.chestopen
                TR6.Checked = True
                TR6.Image = My.Resources.chestopen
                TR7.Checked = True
                TR7.Image = My.Resources.chestopen
                TR8.Checked = True
                TR8.Image = My.Resources.chestopen
                TR9.Checked = True
                TR10.Image = My.Resources.chestopen
                TR10.Checked = True
                TR11.Image = My.Resources.chestopen
                TR11.Checked = True
                TR11.Image = My.Resources.chestopen
                TRBoss.Checked = True
                TRBoss.Image = My.Resources.bossdead
                TRLabel.BackColor = Color.Green
                TRPrizes.Text = 0
        End Select
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Shift) = True Then
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

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If (e.Shift) = False Then
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
        End If
    End Sub
    Private Sub EPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles EPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If EPPrizes.Text < 3 Then EPPrizes.Text = EPPrizes.Text + 1
            EPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If EPPrizes.Text > 0 Then EPPrizes.Text = EPPrizes.Text - 1
            If EPPrizes.Text = 0 Then EPLabel.BackColor = Color.Green
        End If
    End Sub

    Private Sub DPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles DPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If DPPrizes.Text < 2 Then DPPrizes.Text = DPPrizes.Text + 1
            DPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If DPPrizes.Text > 0 Then DPPrizes.Text = DPPrizes.Text - 1
            If DPPrizes.Text = 0 Then DPLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub TOHPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TOHPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If TOHPrizes.Text < 2 Then TOHPrizes.Text = TOHPrizes.Text + 1
            TOHLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If TOHPrizes.Text > 0 Then TOHPrizes.Text = TOHPrizes.Text - 1
            If TOHPrizes.Text = 0 Then TOHLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub PODPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles PODPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If PODPrizes.Text < 5 Then PODPrizes.Text = PODPrizes.Text + 1
            PODLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If PODPrizes.Text > 0 Then PODPrizes.Text = PODPrizes.Text - 1
            If PODPrizes.Text = 0 Then PODLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub SPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles SPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If SPPrizes.Text < 6 Then SPPrizes.Text = SPPrizes.Text + 1
            SPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If SPPrizes.Text > 0 Then SPPrizes.Text = SPPrizes.Text - 1
            If SPPrizes.Text = 0 Then SPLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub SWPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles SWPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If SWPrizes.Text < 2 Then SWPrizes.Text = SWPrizes.Text + 1
            SWLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If SWPrizes.Text > 0 Then SWPrizes.Text = SWPrizes.Text - 1
            If SWPrizes.Text = 0 Then SWLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub TTPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TTPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If TTPrizes.Text < 4 Then TTPrizes.Text = TTPrizes.Text + 1
            TTLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If TTPrizes.Text > 0 Then TTPrizes.Text = TTPrizes.Text - 1
            If TTPrizes.Text = 0 Then TTLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub IPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles IPPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If IPPrizes.Text < 3 Then IPPrizes.Text = IPPrizes.Text + 1
            IPLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If IPPrizes.Text > 0 Then IPPrizes.Text = IPPrizes.Text - 1
            If IPPrizes.Text = 0 Then IPLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub MMPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles MMPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If MMPrizes.Text < 2 Then MMPrizes.Text = MMPrizes.Text + 1
            MMLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If MMPrizes.Text > 0 Then MMPrizes.Text = MMPrizes.Text - 1
            If MMPrizes.Text = 0 Then MMLabel.BackColor = Color.Green
        End If
    End Sub
    Private Sub TRPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TRPrizes.MouseDown
        If e.Button = MouseButtons.Right Then
            If TRPrizes.Text < 3 Then TRPrizes.Text = TRPrizes.Text + 1
            TRLabel.BackColor = Color.Black
        End If
        If e.Button = MouseButtons.Left Then
            If TRPrizes.Text > 0 Then TRPrizes.Text = TRPrizes.Text - 1
            If TRPrizes.Text = 0 Then TRLabel.BackColor = Color.Green
        End If
    End Sub

End Class

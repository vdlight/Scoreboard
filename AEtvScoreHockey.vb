Imports System.Net
Imports System.IO
Imports System.Text
Public Class AEtvScoreHockey
    ' <SerializableAttribute()> <TypeConverterAttribute(GetType(ColorConverter))>Public Structure Color
    Public Declare Function GetAsyncKeyState Lib "User32" (ByVal vkKey As Integer) As Short


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Reset till Default
        If Not Timer1.Enabled = True Then
            Timer1.Enabled = False
            TMinuter.Value = 0
            EMinuter.Value = 0
            TSekunder.Value = 0
            ESekunder.Value = 0
            Hemmascore.Value = 0
            BortaScore.Value = 0
            Period.Value = 1
            Periodlangd.Text = "20:00"
            HSNR1.Text = ""
            HSNR2.Text = ""
            BSNR1.Text = ""
            BSNR1.Text = ""
            HUT1.Text = ""
            HUT2.Text = ""
            BUT1.Text = ""
            BUT2.Text = ""
            UtvisadSpelare.Text = ""
            UtvisningsTid.Text = "02:00"
            HemmaUtvisning.Items.Clear()
            BortaUtvisning.Items.Clear()
            UdateraUtvisningar()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'strarta klocka
        If Timer1.Enabled = True Then Timer1.Enabled = False Else Timer1.Enabled = True
        If Button1.BackColor = Color.Red Then Button1.BackColor = Color.Green Else Button1.BackColor = Color.Red

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'stoppa klocka
        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Not LTrim(Str(TMinuter.Value)) + LTrim(Str(EMinuter.Value)) + ":" + LTrim(Str(TSekunder.Value)) + LTrim(Str(ESekunder.Value)) = Periodlangd.Text Then
            If ESekunder.Value < 9 Then
                ESekunder.Value = ESekunder.Value + 1
            Else
                ESekunder.Value = 0
                If TSekunder.Value < 5 Then
                    TSekunder.Value = TSekunder.Value + 1
                Else
                    TSekunder.Value = 0
                    If EMinuter.Value < 9 Then
                        EMinuter.Value = EMinuter.Value + 1
                    Else
                        If Not TMinuter.Value = TMinuter.Maximum Then
                            TMinuter.Value = TMinuter.Value + 1
                        End If
                        EMinuter.Value = 0
                    End If
                End If
            End If
            AETVHockeyScoreBoardOut.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value

            'Kolla om hemmautvisning skall raderas
            If HUT1.Text = "00:00" Then
                HUT1.Text = ""
                If HemmaUtvisning.Items.Count > 0 Then
                    HemmaUtvisning.SelectedIndex = 0
                    If HSNR1.Text = Mid(HemmaUtvisning.Text, 1, 2) Then
                        HemmaUtvisning.Items.RemoveAt(0)
                        HemmaUtvisning.Refresh()
                        HSNR1.Text = ""
                    End If
                End If
            End If
            'Kolla om bortautvisning skall raderas
            If BUT1.Text = "00:00" Then
                BUT1.Text = ""
                If BortaUtvisning.Items.Count > 0 Then
                    BortaUtvisning.SelectedIndex = 0
                    If BSNR1.Text = Mid(BortaUtvisning.Text, 1, 2) Then
                        BortaUtvisning.Items.RemoveAt(0)
                        BortaUtvisning.Refresh()
                        BSNR1.Text = ""
                    End If
                End If
            End If

            'Kollar om det finns utvisning

            If HemmaUtvisning.Items.Count > 0 Or BortaUtvisning.Items.Count > 0 Then

                'HemmaUtvisning
                If HemmaUtvisning.Items.Count > 0 Then
                    HemmaUtvisning.SelectedIndex = 0
                    If HSNR1.Text <> Mid(HemmaUtvisning.Text, 1, 2) Then
                        HSNR1.Text = Mid(HemmaUtvisning.Text, 1, 2)
                        HUT1.Text = Mid(HemmaUtvisning.Text, 4, 5)
                    End If
                    If HSNR1.Text = Mid(HemmaUtvisning.Text, 1, 2) Then
                        Dim HUS1, HUM1, HUS2, HUM2 As Double
                        Dim HUvkvar1, HUvkvar2 As String
                        HUvkvar1 = Mid(HemmaUtvisning.Text, 4, 5)
                        HUS1 = Int(Val(Mid(HUvkvar1, 4, 2)))
                        HUM1 = Val(Mid(HUvkvar1, 1, 2))

                        If HUS1 > 0 Then
                            HUS1 = HUS1 - 1
                        Else
                            If HUM1 > 0 Then
                                HUM1 = HUM1 - 1
                                HUS1 = 59
                            Else
                                HUvkvar1 = ""
                                HemmaUtvisning.Items.RemoveAt(0)
                                HemmaUtvisning.Refresh()
                            End If
                        End If
                        'Skriv ändring för Hemma utvisning 1
                        HUT1.Text = Format(HUM1, "00") + ":" + Format(HUS1, "00")
                        If Not HUT1.Text = "00:00" Then
                            HemmaUtvisning.Items.RemoveAt(0)
                            HemmaUtvisning.Items.Insert(0, HSNR1.Text + "|" + HUT1.Text)
                            HemmaUtvisning.Refresh()
                        End If
                        'Skriv ändring Hemma utvisning 2
                        If HemmaUtvisning.Items.Count > 1 Then
                            HemmaUtvisning.SelectedIndex = 1
                            If HSNR2.Text <> Mid(HemmaUtvisning.Text, 1, 2) Then
                                HSNR2.Text = Mid(HemmaUtvisning.Text, 1, 2)
                                HUT2.Text = Mid(HemmaUtvisning.Text, 4, 5)
                            End If
                            If HSNR2.Text = Mid(HemmaUtvisning.Text, 1, 2) Then
                                HUvkvar2 = Mid(HemmaUtvisning.Text, 4, 5)
                                HUS2 = Val(Mid(HUvkvar2, 4, 2))
                                HUM2 = Val(Mid(HUvkvar2, 1, 2))

                                If HUS2 > 0 Then
                                    HUS2 = HUS2 - 1
                                Else
                                    If HUM2 > 0 Then
                                        HUM2 = HUM2 - 1
                                        HUS2 = 59
                                    Else
                                        HUvkvar2 = ""
                                        HemmaUtvisning.Items.RemoveAt(1)
                                        HemmaUtvisning.Refresh()
                                    End If
                                End If
                                'Skriv ändring Hemma utvisning 2
                                HUT2.Text = Format(HUM2, "00") + ":" + Format(HUS2, "00")
                                If HemmaUtvisning.Items.Count > 1 Then
                                    HemmaUtvisning.Items.RemoveAt(1)
                                    HemmaUtvisning.Items.Insert(1, HSNR2.Text + "|" + HUT2.Text)
                                    HemmaUtvisning.Refresh()
                                End If
                            End If
                        Else
                            HSNR2.Text = ""
                            HUT2.Text = ""
                        End If
                    End If
                Else
                    HUT1.Text = ""
                    HSNR1.Text = ""
                    HUT2.Text = ""
                    HSNR2.Text = ""
                End If

                'Borta utvisning


                If BortaUtvisning.Items.Count > 0 Then
                    BortaUtvisning.SelectedIndex = 0
                    If BSNR1.Text <> Mid(BortaUtvisning.Text, 1, 2) Then
                        BSNR1.Text = Mid(BortaUtvisning.Text, 1, 2)
                        BUT1.Text = Mid(BortaUtvisning.Text, 4, 5)
                    End If
                    If BSNR1.Text = Mid(BortaUtvisning.Text, 1, 2) Then
                        Dim bUS1, bUM1, bUS2, bUM2 As Double
                        Dim bUvkvar1, bUvkvar2 As String
                        bUvkvar1 = Mid(BortaUtvisning.Text, 4, 5)
                        bUS1 = Val(Mid(bUvkvar1, 4, 2))
                        bUM1 = Val(Mid(bUvkvar1, 1, 2))

                        If bUS1 > 0 Then
                            bUS1 = bUS1 - 1
                        Else
                            If bUM1 > 0 Then
                                bUM1 = bUM1 - 1
                                bUS1 = 59
                            Else
                                bUvkvar1 = ""
                                BortaUtvisning.Items.RemoveAt(0)
                                BortaUtvisning.Refresh()
                            End If
                        End If
                        'Skriv ändring för Borta utvisning 1
                        BUT1.Text = Format(bUM1, "00") + ":" + Format(bUS1, "00")
                        If Not BUT1.Text = "00:00" Then
                            BortaUtvisning.Items.RemoveAt(0)
                            BortaUtvisning.Items.Insert(0, BSNR1.Text + "|" + BUT1.Text)
                            BortaUtvisning.Refresh()

                        End If
                        'Skriv ändring borta utvisning 2
                        If BortaUtvisning.Items.Count > 1 Then
                            BortaUtvisning.SelectedIndex = 1
                            If BSNR2.Text <> Mid(BortaUtvisning.Text, 1, 2) Then
                                BSNR2.Text = Mid(BortaUtvisning.Text, 1, 2)
                                BUT2.Text = Mid(BortaUtvisning.Text, 4, 5)
                            End If
                            If BSNR2.Text = Mid(BortaUtvisning.Text, 1, 2) Then
                                bUvkvar2 = Mid(BortaUtvisning.Text, 4, 5)
                                bUS2 = Val(Mid(bUvkvar2, 4, 2))
                                bUM2 = Val(Mid(bUvkvar2, 1, 2))

                                If bUS2 > 0 Then
                                    bUS2 = bUS2 - 1
                                Else
                                    If bUM2 > 0 Then
                                        bUM2 = bUM2 - 1
                                        bUS2 = 59
                                    Else
                                        bUvkvar2 = ""
                                        BortaUtvisning.Items.RemoveAt(1)
                                        BortaUtvisning.Refresh()
                                    End If
                                End If
                                'Skriv ändring Borta utvisning 2
                                BUT2.Text = Format(bUM2, "00") + ":" + Format(bUS2, "00")
                                If BortaUtvisning.Items.Count > 1 Then
                                    BortaUtvisning.Items.RemoveAt(1)
                                    BortaUtvisning.Items.Insert(1, BSNR2.Text + "|" + BUT2.Text)
                                    BortaUtvisning.Refresh()
                                End If
                            End If
                        Else
                            BSNR2.Text = ""
                            BUT2.Text = ""
                        End If
                    End If
                Else
                    BUT1.Text = ""
                    BSNR1.Text = ""
                    BUT2.Text = ""
                    BSNR2.Text = ""

                End If

            End If
        Else
            Timer1.Enabled = False
        End If
        UdateraUtvisningar()
    End Sub

    Private Sub UdateraUtvisningar()
        If HemmaUtvisning.Items.Count > 0 Or BortaUtvisning.Items.Count > 0 Then
            If HemmaUtvisning.Items.Count > 0 Then
                HemmaUtvisning.SelectedIndex = 0
                AETVHockeyScoreBoardOut.LblUtvH1.Text = Mid(HemmaUtvisning.Text, 4, 5)
                AETVHockeyScoreBoardOut.LblUtvH1.Visible = CheckBox1.Checked
                If HemmaUtvisning.Items.Count > 1 Then
                    HemmaUtvisning.SelectedIndex = 1
                    AETVHockeyScoreBoardOut.LblUtvH2.Text = Mid(HemmaUtvisning.Text, 4, 5)
                    AETVHockeyScoreBoardOut.LblUtvH2.Visible = CheckBox1.Checked
                Else
                    AETVHockeyScoreBoardOut.LblUtvH2.Text = ""
                    AETVHockeyScoreBoardOut.LblUtvH2.Visible = False

                End If
            Else
                AETVHockeyScoreBoardOut.LblUtvH1.Text = ""
                AETVHockeyScoreBoardOut.LblUtvH2.Text = ""
                AETVHockeyScoreBoardOut.LblUtvH1.Visible = False
                AETVHockeyScoreBoardOut.LblUtvH2.Visible = False

            End If
            If BortaUtvisning.Items.Count > 0 Then
                BortaUtvisning.SelectedIndex = 0
                AETVHockeyScoreBoardOut.LblUtvB1.Text = Mid(BortaUtvisning.Text, 4, 5)
                AETVHockeyScoreBoardOut.LblUtvB1.Visible = CheckBox1.Checked
                If BortaUtvisning.Items.Count > 1 Then
                    BortaUtvisning.SelectedIndex = 1
                    AETVHockeyScoreBoardOut.LblUtvB2.Text = Mid(BortaUtvisning.Text, 4, 5)
                    AETVHockeyScoreBoardOut.LblUtvB2.Visible = CheckBox1.Checked
                Else
                    AETVHockeyScoreBoardOut.LblUtvB2.Text = ""
                    AETVHockeyScoreBoardOut.LblUtvB2.Visible = False
                End If
            Else
                AETVHockeyScoreBoardOut.LblUtvB1.Text = ""
                AETVHockeyScoreBoardOut.LblUtvB2.Text = ""
                AETVHockeyScoreBoardOut.LblUtvB1.Visible = False
                AETVHockeyScoreBoardOut.LblUtvB2.Visible = False
            End If
        Else
            AETVHockeyScoreBoardOut.LblUtvB1.Text = ""
            AETVHockeyScoreBoardOut.LblUtvB2.Text = ""
            AETVHockeyScoreBoardOut.LblUtvH1.Text = ""
            AETVHockeyScoreBoardOut.LblUtvH2.Text = ""
            AETVHockeyScoreBoardOut.LblUtvB1.Visible = False
            AETVHockeyScoreBoardOut.LblUtvB2.Visible = False
            AETVHockeyScoreBoardOut.LblUtvH1.Visible = False
            AETVHockeyScoreBoardOut.LblUtvH2.Visible = False

        End If

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Lägg till HemmaUtvisning
        If Val(UtvisadSpelare.Text) > 0 Then
            HemmaUtvisning.Items.Add(Format(Val(UtvisadSpelare.Text), "00") + "|" + UtvisningsTid.Text)
            UtvisadSpelare.Text = ""
            UtvisadSpelare.Focus()
            UdateraUtvisningar()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Lägg till BortaUtvisning
        If Val(UtvisadSpelare.Text) > 0 Then
            BortaUtvisning.Items.Add(Format(Val(UtvisadSpelare.Text), "00") + "|" + UtvisningsTid.Text)
            UtvisadSpelare.Text = ""
            UtvisadSpelare.Focus()
            UdateraUtvisningar()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Tabort HemmaUtvisning
        If HemmaUtvisning.SelectedIndex >= 0 Then
            HemmaUtvisning.Items.RemoveAt(HemmaUtvisning.SelectedIndex)
            HemmaUtvisning.Refresh()
            If HemmaUtvisning.SelectedIndex = 0 Then
                HSNR1.Text = ""
                HUT1.Text = ""
            ElseIf HemmaUtvisning.SelectedIndex = 1 Then
                HSNR2.Text = ""
                HUT2.Text = ""
            End If
        End If
        UdateraUtvisningar()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Tabort TabortUtvisning
        If BortaUtvisning.SelectedIndex >= 0 Then
            BortaUtvisning.Items.RemoveAt(BortaUtvisning.SelectedIndex)
            BortaUtvisning.Refresh()
            If BortaUtvisning.SelectedIndex = 0 Then
                BSNR1.Text = ""
                BUT1.Text = ""
            ElseIf BortaUtvisning.SelectedIndex = 1 Then
                BSNR2.Text = ""
                BUT2.Text = ""
            End If
        End If
        UdateraUtvisningar()
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' Ändra HemmaUtvisning
        Dim Valtindex As Integer

        If HemmaUtvisning.SelectedIndex >= 0 Then
            If Val(UtvisadSpelare.Text) > 0 Then
                Valtindex = HemmaUtvisning.SelectedIndex
                HemmaUtvisning.Items.RemoveAt(Valtindex)
                HemmaUtvisning.Items.Insert(Valtindex, Format(Val(UtvisadSpelare.Text), "00") + "|" + UtvisningsTid.Text)
                UtvisadSpelare.Text = ""
                UtvisadSpelare.Focus()
                If Valtindex = 0 Then
                    HemmaUtvisning.SelectedIndex = 0
                    HSNR1.Text = Mid(HemmaUtvisning.Text, 1, 2)
                    HUT1.Text = Mid(HemmaUtvisning.Text, 4, 5)
                End If

                If Valtindex = 1 Then
                    HemmaUtvisning.SelectedIndex = 1
                    HSNR2.Text = Mid(HemmaUtvisning.Text, 1, 2)
                    HUT2.Text = Mid(HemmaUtvisning.Text, 4, 5)
                End If
            End If
            HemmaUtvisning.Refresh()
        End If
        UdateraUtvisningar()
    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ' Ändra BortaUtvisning
        Dim Valtindex As Integer

        If BortaUtvisning.SelectedIndex >= 0 Then
            If Val(UtvisadSpelare.Text) > 0 Then
                Valtindex = BortaUtvisning.SelectedIndex
                BortaUtvisning.Items.RemoveAt(Valtindex)
                BortaUtvisning.Items.Insert(Valtindex, Format(Val(UtvisadSpelare.Text), "00") + "|" + UtvisningsTid.Text)
                UtvisadSpelare.Text = ""
                UtvisadSpelare.Focus()
                If Valtindex = 0 Then
                    BortaUtvisning.SelectedIndex = 0
                    BSNR1.Text = Mid(BortaUtvisning.Text, 1, 2)
                    BUT1.Text = Mid(BortaUtvisning.Text, 4, 5)
                End If

                If Valtindex = 1 Then
                    BortaUtvisning.SelectedIndex = 1
                    BSNR2.Text = Mid(BortaUtvisning.Text, 1, 2)
                    BUT2.Text = Mid(BortaUtvisning.Text, 4, 5)
                End If
            End If
            BortaUtvisning.Refresh()
        End If
        UdateraUtvisningar()
    End Sub

    Private Sub OnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnOff.Click
        ' Slå av och på scoreboard

        UdateraUtvisningar()
        If OnOff.Text = "On !!!" Then
            OnOff.Text = "Off !!!"
            OnOff.BackColor = Color.LimeGreen
          
            Dim Outlocation As New Point(Convert.ToInt32(TBPosX.Text), Convert.ToInt32(TBPosY.Text))
            ' Dim Farg As New Color(0, TBColR.Text, TBColG.Text, TBColB)
            ' Form2.BackColor = Farg
            AETVHockeyScoreBoardOut.BackColor = TBColR.BackColor
            AETVHockeyScoreBoardOut.Location = Outlocation
            AETVHockeyScoreBoardOut.LblHemmaLag.Text = TBHemmaLag.Text
            AETVHockeyScoreBoardOut.LblBortaLag.Text = TBBortaLag.Text
            AETVHockeyScoreBoardOut.PBScoreboard.Visible = CheckBox1.Checked
            AETVHockeyScoreBoardOut.PBLT.Visible = CheckBox2.Checked
            AETVHockeyScoreBoardOut.Show()
        Else
            OnOff.BackColor = Color.LightSlateGray
            OnOff.Text = "On !!!"
            AETVHockeyScoreBoardOut.Close()
        End If
        AETVHockeyScoreBoardOut.PBScoreboard.Visible = CheckBox1.Checked
    End Sub

    Private Sub AEtvScoreHockey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ESekunder_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESekunder.ValueChanged
        If Timer1.Enabled = False Then
            AETVHockeyScoreBoardOut.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub TSekunder_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSekunder.ValueChanged
        If Timer1.Enabled = False Then
            AETVHockeyScoreBoardOut.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub EMinuter_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMinuter.ValueChanged
        If Timer1.Enabled = False Then
            AETVHockeyScoreBoardOut.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub TMinuter_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMinuter.ValueChanged
        If Timer1.Enabled = False Then
            AETVHockeyScoreBoardOut.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub Hemmascore_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hemmascore.ValueChanged
        AETVHockeyScoreBoardOut.LblHemmaScore.Text = Convert.ToString(Hemmascore.Value)
    End Sub

    Private Sub BortaScore_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BortaScore.ValueChanged
        AETVHockeyScoreBoardOut.LblBortaScore.Text = Convert.ToString(BortaScore.Value)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Not Timer1.Enabled = True Then
            TMinuter.Value = 0
            EMinuter.Value = 0
            TSekunder.Value = 0
            ESekunder.Value = 0
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Not Timer1.Enabled = True Then
            AETVHockeyScoreBoardOut.Close()
            Me.Close()
        End If
    End Sub

    Private Sub TBHemmaLag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBHemmaLag.TextChanged
        AETVHockeyScoreBoardOut.LblHemmaLag.Text = TBHemmaLag.Text

    End Sub

    Private Sub TBBortaLag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBortaLag.TextChanged
        AETVHockeyScoreBoardOut.LblBortaLag.Text = TBBortaLag.Text

    End Sub

    Private Sub Period_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Period.ValueChanged
        If Timer1.Enabled = False Then
            AETVHockeyScoreBoardOut.LblPeriod.Text = "P" & Period.Value
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Convert.ToBoolean(GetAsyncKeyState(Keys.RControlKey)) Then
            If Timer1.Enabled = True Then Timer1.Enabled = False Else Timer1.Enabled = True
            If Button1.BackColor = Color.Red Then Button1.BackColor = Color.Green Else Button1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ColorDialog1.Color = TBColR.BackColor
        ColorDialog1.ShowDialog()
        TBColR.Text = ColorDialog1.Color.ToString
        TBColR.BackColor = ColorDialog1.Color
        AETVHockeyScoreBoardOut.BackColor = TBColR.BackColor
        AETVHockeyScoreBoardOut.TransparencyKey = TBColR.BackColor


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        AETVHockeyScoreBoardOut.PBScoreboard.Visible = CheckBox1.Checked
        If CheckBox1.Checked = False Then
            AETVHockeyScoreBoardOut.LblUtvH1.Visible = CheckBox1.Checked
            AETVHockeyScoreBoardOut.LblUtvH2.Visible = CheckBox1.Checked
            AETVHockeyScoreBoardOut.LblUtvB1.Visible = CheckBox1.Checked
            AETVHockeyScoreBoardOut.LblUtvB2.Visible = CheckBox1.Checked
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = "PNG |*.png"
        If OpenFileDialog1.ShowDialog = 1 Then
            Label9.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        OpenFileDialog1.Filter = "PNG |*.png"
        If OpenFileDialog1.ShowDialog = 1 Then
            Label10.Text = OpenFileDialog1.FileName
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        OpenFileDialog1.Filter = "Game|*.game"
        If OpenFileDialog1.ShowDialog = 1 Then
            Dim Objreader As New System.IO.StreamReader(OpenFileDialog1.FileName)
            Dim filenum As Integer = FreeFile()

            Dim fileline As String
            Dim namn As String
            Do Until Objreader.EndOfStream
                fileline = Objreader.ReadLine
                If Convert.ToBoolean(InStr(fileline, ";")) Then
                    namn = Mid(fileline, 1, InStr(fileline, ";"))
                    Select Case namn
                        Case "HomeTeam;"
                            TBHemmaLag.Text = Mid(fileline, 10, Len(fileline) - 9)
                        Case "AwayTeam;"
                            TBBortaLag.Text = Mid(fileline, 10, Len(fileline) - 9)
                        Case "HomePic;"
                            Label9.Text = Mid(fileline, 9, Len(fileline) - 8)
                            PictureBox1.Image = Image.FromFile(Mid(fileline, 9, Len(fileline) - 8))

                        Case "AwayPic;"
                            Label10.Text = Mid(fileline, 9, Len(fileline) - 8)
                            PictureBox2.Image = Image.FromFile(Mid(fileline, 9, Len(fileline) - 8))

                        Case "Colour;"
                            TBColR.Text = Mid(fileline, 8, Len(fileline) - 7)
                            '  TBColR.BackColor = Color.FromKnownColor(TBColR.Text)
                            AETVHockeyScoreBoardOut.BackColor = TBColR.BackColor
                            AETVHockeyScoreBoardOut.TransparencyKey = TBColR.BackColor
                        Case "X-Pos;"
                            TBPosX.Text = Mid(fileline, 7, Len(fileline) - 6)
                        Case "Y-Pos;"
                            TBPosY.Text = Mid(fileline, 7, Len(fileline) - 6)
                    End Select
                End If
                fileline = ""
            Loop
            Objreader.Close()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveFileDialog1.Filter = "Game|*.game"
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim objwriter As New IO.StreamWriter(SaveFileDialog1.FileName)


        Dim filrader As String = ""
        If TBHemmaLag.Text > "" Then filrader += "HomeTeam;" & TBHemmaLag.Text & vbCrLf
        If TBBortaLag.Text > "" Then filrader += "AwayTeam;" & TBBortaLag.Text & vbCrLf
        If Label9.Text > "" Then filrader += "HomePic;" & Label9.Text & vbCrLf
        If Label10.Text > "" Then filrader += "AwayPic;" & Label10.Text & vbCrLf
        If TBColR.Text > "" Then filrader += "Colour;" & TBColR.Text & vbCrLf
        If TBPosX.Text > "" Then filrader += "X-Pos;" & TBPosX.Text & vbCrLf
        If TBPosY.Text > "" Then filrader += "Y-Pos;" & TBPosY.Text & vbCrLf

        objwriter.Write(filrader)
        objwriter.Close()

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        AETVHockeyScoreBoardOut.PBLT.Visible = CheckBox2.Checked
        AETVHockeyScoreBoardOut.LblTit1.Visible = CheckBox2.Checked
        AETVHockeyScoreBoardOut.LblTit2.Visible = CheckBox2.Checked
        AETVHockeyScoreBoardOut.LblTit1.Text = TBtit1.Text
        AETVHockeyScoreBoardOut.LblTit2.Text = TBtit2.Text
        'If CheckBox2.Checked = False Then
        'AETVHockeyScoreBoardOut.LblTit1.Visible = CheckBox2.Checked
        'A'ETVHockeyScoreBoardOut.LblTit2.Visible = CheckBox2.Checked
        'End If
    End Sub

    Private Sub TBtit1_LostFocus(sender As Object, e As EventArgs) Handles TBtit1.LostFocus
        AETVHockeyScoreBoardOut.LblTit1.Text = TBtit1.Text
    End Sub

    Private Sub TBtit2_LostFocus(sender As Object, e As EventArgs) Handles TBtit2.LostFocus
        AETVHockeyScoreBoardOut.LblTit2.Text = TBtit2.Text
    End Sub

    Private Sub Periodlangd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Periodlangd.SelectedIndexChanged

    End Sub

    Private Sub TBPosY_TextChanged(sender As Object, e As EventArgs) Handles TBPosY.TextChanged

    End Sub

    Private Sub UtvisadSpelare_TextChanged(sender As Object, e As EventArgs) Handles UtvisadSpelare.TextChanged

    End Sub

    Private Sub TBColR_TextChanged(sender As Object, e As EventArgs) Handles TBColR.TextChanged

    End Sub

    Private Sub TBPosX_TextChanged(sender As Object, e As EventArgs) Handles TBPosX.TextChanged

    End Sub
End Class

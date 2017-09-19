Imports System.Net

Public Class Form1
    ' <SerializableAttribute()> <TypeConverterAttribute(GetType(ColorConverter))>Public Structure Color
    Private Declare Function GetAsyncKeyState Lib "User32" (ByVal vkKey As Integer) As Short


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
        Timer1.Enabled = True

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
            Form2.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value

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
                        Dim HUS1, HUM1, HUS2, HUM2 As Integer
                        Dim HUvkvar1, HUvkvar2 As String
                        HUvkvar1 = Mid(HemmaUtvisning.Text, 4, 5)
                        HUS1 = Val(Mid(HUvkvar1, 4, 2))
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
                                HemmaUtvisning.Items.RemoveAt(1)
                                HemmaUtvisning.Items.Insert(1, HSNR2.Text + "|" + HUT2.Text)
                                HemmaUtvisning.Refresh()

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
                        Dim bUS1, bUM1, bUS2, bUM2 As Integer
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
                                BortaUtvisning.Items.RemoveAt(1)
                                BortaUtvisning.Items.Insert(1, BSNR2.Text + "|" + BUT2.Text)
                                BortaUtvisning.Refresh()

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
                Form2.LblUtvH1.Text = Mid(HemmaUtvisning.Text, 4, 5)
                If HemmaUtvisning.Items.Count > 1 Then
                    HemmaUtvisning.SelectedIndex = 1
                    Form2.LblUtvH2.Text = Mid(HemmaUtvisning.Text, 4, 5)
                Else
                    Form2.LblUtvH2.Text = ""
                End If
            Else
                Form2.LblUtvH1.Text = ""
                Form2.LblUtvH2.Text = ""
            End If
            If BortaUtvisning.Items.Count > 0 Then
                BortaUtvisning.SelectedIndex = 0
                Form2.LblUtvB1.Text = Mid(BortaUtvisning.Text, 4, 5)
                If BortaUtvisning.Items.Count > 1 Then
                    BortaUtvisning.SelectedIndex = 1
                    Form2.LblUtvB2.Text = Mid(BortaUtvisning.Text, 4, 5)
                Else
                    Form2.LblUtvB2.Text = ""
                End If
            Else
                Form2.LblUtvB1.Text = ""
                Form2.LblUtvB2.Text = ""
            End If
        Else
            Form2.LblUtvB1.Text = ""
            Form2.LblUtvB2.Text = ""
            Form2.LblUtvH1.Text = ""
            Form2.LblUtvH2.Text = ""

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
            Dim Outlocation As New Point(TBPosX.Text, TBPosY.Text)
            '   Dim Farg As New Color(0, TBColR.Text, TBColG.Text, TBColB)
            ' Form2.BackColor = Farg
            Form2.BackColor = TBColR.BackColor
            Form2.Location = Outlocation
            Form2.Show()
        Else
            OnOff.BackColor = Color.LightSlateGray
            OnOff.Text = "On !!!"
            Form2.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form2.LblHemmaLag.Text = TBHemmaLag.Text
        Form2.LblBortaLag.Text = TBBortaLag.Text
    End Sub


    Private Sub ESekunder_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESekunder.ValueChanged
        If Timer1.Enabled = False Then
            Form2.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub TSekunder_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSekunder.ValueChanged
        If Timer1.Enabled = False Then
            Form2.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub EMinuter_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMinuter.ValueChanged
        If Timer1.Enabled = False Then
            Form2.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub TMinuter_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMinuter.ValueChanged
        If Timer1.Enabled = False Then
            Form2.LblTid.Text = TMinuter.Value & EMinuter.Value & ":" & TSekunder.Value & ESekunder.Value
        End If
    End Sub

    Private Sub Hemmascore_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hemmascore.ValueChanged
        Form2.LblHemmaScore.Text = Hemmascore.Value
    End Sub

    Private Sub BortaScore_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BortaScore.ValueChanged
        Form2.LblBortaScore.Text = BortaScore.Value
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
            Form2.Close()
            Me.Close()
        End If
    End Sub

    Private Sub TBHemmaLag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBHemmaLag.TextChanged
        Form2.LblHemmaLag.Text = TBHemmaLag.Text

    End Sub

    Private Sub TBBortaLag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBortaLag.TextChanged
        Form2.LblBortaLag.Text = TBBortaLag.Text

    End Sub

    Private Sub Period_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Period.ValueChanged
        If Timer1.Enabled = False Then
            Form2.LblPeriod.Text = "P" & Period.Value
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If GetAsyncKeyState(Keys.RControlKey) Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            Else
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ColorDialog1.Color = TBColR.BackColor
        ColorDialog1.ShowDialog()
        TBColR.BackColor = ColorDialog1.Color
        Form2.BackColor = TBColR.BackColor

    End Sub

    Private Sub TBColG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

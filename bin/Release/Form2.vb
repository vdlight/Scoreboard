Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblHemmaLag.Parent = PBScoreboard
        LblHemmaScore.Parent = PBScoreboard
        LblBortaLag.Parent = PBScoreboard
        LblBortaScore.Parent = PBScoreboard
        LblTid.Parent = PBScoreboard
        LblPeriod.Parent = PBScoreboard
        LblUtvH1.Parent = PBScoreboard
        LblUtvH2.Parent = PBScoreboard
        LblUtvB1.Parent = PBScoreboard
        LblUtvB2.Parent = PBScoreboard
        LblHemmaLag.Text = Form1.TBHemmaLag.Text
        LblHemmaScore.Text = Form1.Hemmascore.Value
        LblBortaLag.Text = Form1.TBBortaLag.Text
        LblBortaScore.Text = Form1.BortaScore.Value
        LblTid.Text = Form1.TMinuter.Value & Form1.EMinuter.Value & ":" & Form1.TSekunder.Value & Form1.ESekunder.Value
        LblPeriod.Text = "P" & Form1.Period.Value
        LblUtvH1.Text = Form1.hut1.text
        LblUtvH2.Text = Form1.hut2.text
        LblUtvB1.Text = Form1.but1.text
        LblUtvB2.Text = Form1.but2.text

    End Sub


End Class
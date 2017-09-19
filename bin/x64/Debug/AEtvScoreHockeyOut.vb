Public Class AETVHockeyScoreBoardOut

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblHemmaLag.Parent = PBScoreboard
        LblHemmaScore.Parent = PBScoreboard
        LblBortaLag.Parent = PBScoreboard
        LblBortaScore.Parent = PBScoreboard
        LblTid.Parent = PBScoreboard
        LblPeriod.Parent = PBScoreboard
        LblTit1.Parent = PBLT
        LblTit2.Parent = PBLT
        LblHemmaLag.Text = AEtvScoreHockey.TBHemmaLag.Text
        LblHemmaScore.Text = Convert.ToString(AEtvScoreHockey.Hemmascore.Value)
        LblBortaLag.Text = AEtvScoreHockey.TBBortaLag.Text
        LblBortaScore.Text = Convert.ToString(AEtvScoreHockey.BortaScore.Value)
        LblTid.Text = AEtvScoreHockey.TMinuter.Value & AEtvScoreHockey.EMinuter.Value & ":" & AEtvScoreHockey.TSekunder.Value & AEtvScoreHockey.ESekunder.Value
        LblPeriod.Text = "P" & AEtvScoreHockey.Period.Value
        LblUtvH1.Text = AEtvScoreHockey.HUT1.Text
        LblUtvH2.Text = AEtvScoreHockey.HUT2.Text
        LblUtvB1.Text = AEtvScoreHockey.BUT1.Text
        LblUtvB2.Text = AEtvScoreHockey.BUT2.Text
        LblTit1.Text = AEtvScoreHockey.TBtit1.Text
        LblTit2.Text = AEtvScoreHockey.TBtit2.Text

    End Sub

    Private Sub LblUtvB1_Click(sender As Object, e As EventArgs) Handles LblUtvB1.Click

    End Sub

    Private Sub LblUtvB2_Click(sender As Object, e As EventArgs) Handles LblUtvB2.Click

    End Sub

    Private Sub LblTid_Click(sender As Object, e As EventArgs) Handles LblTid.Click

    End Sub

    Private Sub LblUtvH1_Click(sender As Object, e As EventArgs) Handles LblUtvH1.Click

    End Sub

    Private Sub LblBortaScore_Click(sender As Object, e As EventArgs) Handles LblBortaScore.Click

    End Sub

    Private Sub LblHemmaScore_Click(sender As Object, e As EventArgs) Handles LblHemmaScore.Click

    End Sub
End Class

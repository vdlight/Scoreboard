﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AETVHockeyScoreBoardOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AETVHockeyScoreBoardOut))
        Me.LblUtvB2 = New System.Windows.Forms.Label()
        Me.LblUtvB1 = New System.Windows.Forms.Label()
        Me.LblHemmaScore = New System.Windows.Forms.Label()
        Me.LblBortaScore = New System.Windows.Forms.Label()
        Me.LblTid = New System.Windows.Forms.Label()
        Me.LblPeriod = New System.Windows.Forms.Label()
        Me.LblBortaLag = New System.Windows.Forms.Label()
        Me.LblHemmaLag = New System.Windows.Forms.Label()
        Me.LblUtvH2 = New System.Windows.Forms.Label()
        Me.LblUtvH1 = New System.Windows.Forms.Label()
        Me.PBScoreboard = New System.Windows.Forms.PictureBox()
        Me.PBLT = New System.Windows.Forms.PictureBox()
        Me.LblTit1 = New System.Windows.Forms.Label()
        Me.LblTit2 = New System.Windows.Forms.Label()
        CType(Me.PBScoreboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUtvB2
        '
        Me.LblUtvB2.BackColor = System.Drawing.Color.IndianRed
        Me.LblUtvB2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUtvB2.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUtvB2.ForeColor = System.Drawing.Color.White
        Me.LblUtvB2.Location = New System.Drawing.Point(455, 134)
        Me.LblUtvB2.Margin = New System.Windows.Forms.Padding(0)
        Me.LblUtvB2.Name = "LblUtvB2"
        Me.LblUtvB2.Size = New System.Drawing.Size(93, 36)
        Me.LblUtvB2.TabIndex = 11
        Me.LblUtvB2.Text = "00:00"
        Me.LblUtvB2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblUtvB1
        '
        Me.LblUtvB1.BackColor = System.Drawing.Color.IndianRed
        Me.LblUtvB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUtvB1.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUtvB1.ForeColor = System.Drawing.Color.White
        Me.LblUtvB1.Location = New System.Drawing.Point(455, 101)
        Me.LblUtvB1.Margin = New System.Windows.Forms.Padding(0)
        Me.LblUtvB1.Name = "LblUtvB1"
        Me.LblUtvB1.Size = New System.Drawing.Size(93, 36)
        Me.LblUtvB1.TabIndex = 12
        Me.LblUtvB1.Text = "00:00"
        Me.LblUtvB1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblHemmaScore
        '
        Me.LblHemmaScore.BackColor = System.Drawing.Color.Transparent
        Me.LblHemmaScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblHemmaScore.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHemmaScore.ForeColor = System.Drawing.Color.White
        Me.LblHemmaScore.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LblHemmaScore.Location = New System.Drawing.Point(160, 5)
        Me.LblHemmaScore.Margin = New System.Windows.Forms.Padding(0)
        Me.LblHemmaScore.Name = "LblHemmaScore"
        Me.LblHemmaScore.Size = New System.Drawing.Size(55, 50)
        Me.LblHemmaScore.TabIndex = 13
        Me.LblHemmaScore.Text = "00"
        Me.LblHemmaScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBortaScore
        '
        Me.LblBortaScore.BackColor = System.Drawing.Color.Transparent
        Me.LblBortaScore.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBortaScore.ForeColor = System.Drawing.Color.White
        Me.LblBortaScore.Location = New System.Drawing.Point(448, 5)
        Me.LblBortaScore.Margin = New System.Windows.Forms.Padding(0)
        Me.LblBortaScore.Name = "LblBortaScore"
        Me.LblBortaScore.Size = New System.Drawing.Size(55, 50)
        Me.LblBortaScore.TabIndex = 14
        Me.LblBortaScore.Text = "00"
        Me.LblBortaScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTid
        '
        Me.LblTid.BackColor = System.Drawing.Color.Transparent
        Me.LblTid.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTid.ForeColor = System.Drawing.Color.White
        Me.LblTid.Location = New System.Drawing.Point(256, 5)
        Me.LblTid.Margin = New System.Windows.Forms.Padding(0)
        Me.LblTid.Name = "LblTid"
        Me.LblTid.Size = New System.Drawing.Size(119, 50)
        Me.LblTid.TabIndex = 15
        Me.LblTid.Text = "00:00"
        Me.LblTid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPeriod
        '
        Me.LblPeriod.BackColor = System.Drawing.Color.Transparent
        Me.LblPeriod.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeriod.ForeColor = System.Drawing.Color.White
        Me.LblPeriod.Location = New System.Drawing.Point(209, 5)
        Me.LblPeriod.Margin = New System.Windows.Forms.Padding(0)
        Me.LblPeriod.Name = "LblPeriod"
        Me.LblPeriod.Size = New System.Drawing.Size(57, 50)
        Me.LblPeriod.TabIndex = 16
        Me.LblPeriod.Text = "P0"
        Me.LblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBortaLag
        '
        Me.LblBortaLag.BackColor = System.Drawing.Color.Transparent
        Me.LblBortaLag.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBortaLag.ForeColor = System.Drawing.Color.White
        Me.LblBortaLag.Location = New System.Drawing.Point(361, 6)
        Me.LblBortaLag.Margin = New System.Windows.Forms.Padding(0)
        Me.LblBortaLag.Name = "LblBortaLag"
        Me.LblBortaLag.Size = New System.Drawing.Size(97, 50)
        Me.LblBortaLag.TabIndex = 17
        Me.LblBortaLag.Text = "XXXX"
        Me.LblBortaLag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblHemmaLag
        '
        Me.LblHemmaLag.BackColor = System.Drawing.Color.Transparent
        Me.LblHemmaLag.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHemmaLag.ForeColor = System.Drawing.Color.White
        Me.LblHemmaLag.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LblHemmaLag.Location = New System.Drawing.Point(74, 6)
        Me.LblHemmaLag.Margin = New System.Windows.Forms.Padding(0)
        Me.LblHemmaLag.Name = "LblHemmaLag"
        Me.LblHemmaLag.Size = New System.Drawing.Size(97, 50)
        Me.LblHemmaLag.TabIndex = 18
        Me.LblHemmaLag.Text = "XXXX"
        Me.LblHemmaLag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUtvH2
        '
        Me.LblUtvH2.BackColor = System.Drawing.Color.IndianRed
        Me.LblUtvH2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUtvH2.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUtvH2.ForeColor = System.Drawing.Color.White
        Me.LblUtvH2.Location = New System.Drawing.Point(167, 134)
        Me.LblUtvH2.Margin = New System.Windows.Forms.Padding(0)
        Me.LblUtvH2.Name = "LblUtvH2"
        Me.LblUtvH2.Size = New System.Drawing.Size(93, 36)
        Me.LblUtvH2.TabIndex = 19
        Me.LblUtvH2.Text = "00:00"
        Me.LblUtvH2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblUtvH1
        '
        Me.LblUtvH1.BackColor = System.Drawing.Color.IndianRed
        Me.LblUtvH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUtvH1.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUtvH1.ForeColor = System.Drawing.Color.White
        Me.LblUtvH1.Location = New System.Drawing.Point(167, 101)
        Me.LblUtvH1.Margin = New System.Windows.Forms.Padding(0)
        Me.LblUtvH1.Name = "LblUtvH1"
        Me.LblUtvH1.Size = New System.Drawing.Size(93, 36)
        Me.LblUtvH1.TabIndex = 20
        Me.LblUtvH1.Text = "00:00"
        Me.LblUtvH1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PBScoreboard
        '
        Me.PBScoreboard.Image = Global.AEtvScoreHockey.My.Resources.Resources.AEtvScoreHockey2
        Me.PBScoreboard.Location = New System.Drawing.Point(51, 43)
        Me.PBScoreboard.Margin = New System.Windows.Forms.Padding(0)
        Me.PBScoreboard.Name = "PBScoreboard"
        Me.PBScoreboard.Size = New System.Drawing.Size(500, 58)
        Me.PBScoreboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBScoreboard.TabIndex = 21
        Me.PBScoreboard.TabStop = False
        '
        'PBLT
        '
        Me.PBLT.Image = CType(resources.GetObject("PBLT.Image"), System.Drawing.Image)
        Me.PBLT.Location = New System.Drawing.Point(54, 517)
        Me.PBLT.Margin = New System.Windows.Forms.Padding(0)
        Me.PBLT.Name = "PBLT"
        Me.PBLT.Size = New System.Drawing.Size(1158, 170)
        Me.PBLT.TabIndex = 24
        Me.PBLT.TabStop = False
        Me.PBLT.Visible = False
        '
        'LblTit1
        '
        Me.LblTit1.AutoSize = True
        Me.LblTit1.BackColor = System.Drawing.Color.Transparent
        Me.LblTit1.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTit1.ForeColor = System.Drawing.Color.White
        Me.LblTit1.Location = New System.Drawing.Point(190, 35)
        Me.LblTit1.Margin = New System.Windows.Forms.Padding(0)
        Me.LblTit1.Name = "LblTit1"
        Me.LblTit1.Size = New System.Drawing.Size(257, 43)
        Me.LblTit1.TabIndex = 25
        Me.LblTit1.Text = "Kommentator"
        Me.LblTit1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LblTit2
        '
        Me.LblTit2.AutoSize = True
        Me.LblTit2.BackColor = System.Drawing.Color.Transparent
        Me.LblTit2.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTit2.ForeColor = System.Drawing.Color.White
        Me.LblTit2.Location = New System.Drawing.Point(190, 78)
        Me.LblTit2.Margin = New System.Windows.Forms.Padding(0)
        Me.LblTit2.Name = "LblTit2"
        Me.LblTit2.Size = New System.Drawing.Size(467, 43)
        Me.LblTit2.TabIndex = 26
        Me.LblTit2.Text = "Grodan Boll och Kalle Kula"
        '
        'AETVHockeyScoreBoardOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblTit2)
        Me.Controls.Add(Me.LblTit1)
        Me.Controls.Add(Me.PBLT)
        Me.Controls.Add(Me.LblTid)
        Me.Controls.Add(Me.LblHemmaScore)
        Me.Controls.Add(Me.LblUtvB2)
        Me.Controls.Add(Me.LblUtvB1)
        Me.Controls.Add(Me.LblUtvH2)
        Me.Controls.Add(Me.LblUtvH1)
        Me.Controls.Add(Me.LblBortaScore)
        Me.Controls.Add(Me.LblPeriod)
        Me.Controls.Add(Me.LblBortaLag)
        Me.Controls.Add(Me.LblHemmaLag)
        Me.Controls.Add(Me.PBScoreboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(1000, 0)
        Me.Name = "AETVHockeyScoreBoardOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AEtv Hockey Scoreboard Out"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.PBScoreboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblUtvB2 As System.Windows.Forms.Label
    Friend WithEvents LblUtvB1 As System.Windows.Forms.Label
    Friend WithEvents LblHemmaScore As System.Windows.Forms.Label
    Friend WithEvents LblBortaScore As System.Windows.Forms.Label
    Friend WithEvents LblTid As System.Windows.Forms.Label
    Friend WithEvents LblPeriod As System.Windows.Forms.Label
    Friend WithEvents LblBortaLag As System.Windows.Forms.Label
    Friend WithEvents LblHemmaLag As System.Windows.Forms.Label
    Friend WithEvents LblUtvH2 As System.Windows.Forms.Label
    Friend WithEvents LblUtvH1 As System.Windows.Forms.Label
    Friend WithEvents PBScoreboard As System.Windows.Forms.PictureBox
    Friend WithEvents PBLT As System.Windows.Forms.PictureBox
    Friend WithEvents LblTit1 As System.Windows.Forms.Label
    Friend WithEvents LblTit2 As System.Windows.Forms.Label
End Class

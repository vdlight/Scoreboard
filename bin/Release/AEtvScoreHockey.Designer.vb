<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AEtvScoreHockey
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AEtvScoreHockey))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Hemmascore = New System.Windows.Forms.NumericUpDown()
        Me.BortaScore = New System.Windows.Forms.NumericUpDown()
        Me.TMinuter = New System.Windows.Forms.NumericUpDown()
        Me.TSekunder = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HemmaUtvisning = New System.Windows.Forms.ListBox()
        Me.UtvisadSpelare = New System.Windows.Forms.TextBox()
        Me.UtvisningsTid = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BortaUtvisning = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Period = New System.Windows.Forms.NumericUpDown()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Periodlangd = New System.Windows.Forms.ComboBox()
        Me.EMinuter = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ESekunder = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BUT1 = New System.Windows.Forms.Label()
        Me.BUT2 = New System.Windows.Forms.Label()
        Me.BSNR1 = New System.Windows.Forms.Label()
        Me.BSNR2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.HUT1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HSNR1 = New System.Windows.Forms.Label()
        Me.HUT2 = New System.Windows.Forms.Label()
        Me.HSNR2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OnOff = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TBPort = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TBTo = New System.Windows.Forms.TextBox()
        Me.TBHemmaLag = New System.Windows.Forms.TextBox()
        Me.TBBortaLag = New System.Windows.Forms.TextBox()
        Me.TBPosY = New System.Windows.Forms.TextBox()
        Me.TBPosX = New System.Windows.Forms.TextBox()
        Me.TBColR = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TBtit1 = New System.Windows.Forms.TextBox()
        Me.TBtit2 = New System.Windows.Forms.TextBox()
        CType(Me.Hemmascore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BortaScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMinuter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSekunder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMinuter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESekunder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Hemmascore
        '
        Me.Hemmascore.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hemmascore.Location = New System.Drawing.Point(8, 16)
        Me.Hemmascore.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.Hemmascore.Name = "Hemmascore"
        Me.Hemmascore.Size = New System.Drawing.Size(78, 49)
        Me.Hemmascore.TabIndex = 3
        Me.Hemmascore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BortaScore
        '
        Me.BortaScore.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BortaScore.Location = New System.Drawing.Point(404, 16)
        Me.BortaScore.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.BortaScore.Name = "BortaScore"
        Me.BortaScore.Size = New System.Drawing.Size(74, 49)
        Me.BortaScore.TabIndex = 4
        Me.BortaScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TMinuter
        '
        Me.TMinuter.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold)
        Me.TMinuter.Location = New System.Drawing.Point(156, 16)
        Me.TMinuter.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.TMinuter.Name = "TMinuter"
        Me.TMinuter.Size = New System.Drawing.Size(45, 49)
        Me.TMinuter.TabIndex = 7
        Me.TMinuter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSekunder
        '
        Me.TSekunder.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold)
        Me.TSekunder.Location = New System.Drawing.Point(264, 17)
        Me.TSekunder.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.TSekunder.Name = "TSekunder"
        Me.TSekunder.Size = New System.Drawing.Size(45, 49)
        Me.TSekunder.TabIndex = 8
        Me.TSekunder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(6, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 124)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Start / Stop"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(204, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 36)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 36)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HemmaUtvisning
        '
        Me.HemmaUtvisning.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HemmaUtvisning.FormattingEnabled = True
        Me.HemmaUtvisning.ItemHeight = 19
        Me.HemmaUtvisning.Location = New System.Drawing.Point(10, 91)
        Me.HemmaUtvisning.Name = "HemmaUtvisning"
        Me.HemmaUtvisning.ScrollAlwaysVisible = True
        Me.HemmaUtvisning.Size = New System.Drawing.Size(109, 99)
        Me.HemmaUtvisning.TabIndex = 12
        '
        'UtvisadSpelare
        '
        Me.UtvisadSpelare.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.UtvisadSpelare.Location = New System.Drawing.Point(174, 125)
        Me.UtvisadSpelare.Name = "UtvisadSpelare"
        Me.UtvisadSpelare.Size = New System.Drawing.Size(42, 32)
        Me.UtvisadSpelare.TabIndex = 13
        '
        'UtvisningsTid
        '
        Me.UtvisningsTid.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.UtvisningsTid.FormattingEnabled = True
        Me.UtvisningsTid.Items.AddRange(New Object() {"02:00", "04:00", "05:00", "06:00", "07:00", "08:00"})
        Me.UtvisningsTid.Location = New System.Drawing.Point(222, 125)
        Me.UtvisningsTid.Name = "UtvisningsTid"
        Me.UtvisningsTid.Size = New System.Drawing.Size(87, 32)
        Me.UtvisningsTid.TabIndex = 14
        Me.UtvisningsTid.Text = "02:00"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(125, 91)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "+<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(317, 91)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 32)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "+>"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BortaUtvisning
        '
        Me.BortaUtvisning.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BortaUtvisning.FormattingEnabled = True
        Me.BortaUtvisning.ItemHeight = 19
        Me.BortaUtvisning.Location = New System.Drawing.Point(368, 91)
        Me.BortaUtvisning.Name = "BortaUtvisning"
        Me.BortaUtvisning.ScrollAlwaysVisible = True
        Me.BortaUtvisning.Size = New System.Drawing.Size(110, 99)
        Me.BortaUtvisning.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button6.Location = New System.Drawing.Point(317, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 32)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "->"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button7.Location = New System.Drawing.Point(125, 159)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 32)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "-<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Period)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Periodlangd)
        Me.GroupBox1.Controls.Add(Me.EMinuter)
        Me.GroupBox1.Controls.Add(Me.TSekunder)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ESekunder)
        Me.GroupBox1.Controls.Add(Me.TMinuter)
        Me.GroupBox1.Controls.Add(Me.Hemmascore)
        Me.GroupBox1.Controls.Add(Me.BortaScore)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 107)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Period
        '
        Me.Period.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Period.Location = New System.Drawing.Point(207, 68)
        Me.Period.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Period.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Period.Name = "Period"
        Me.Period.Size = New System.Drawing.Size(40, 32)
        Me.Period.TabIndex = 14
        Me.Period.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(156, 74)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(44, 25)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "Reset"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Periodlangd
        '
        Me.Periodlangd.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Periodlangd.FormattingEnabled = True
        Me.Periodlangd.Items.AddRange(New Object() {"20:00", "05:00"})
        Me.Periodlangd.Location = New System.Drawing.Point(264, 68)
        Me.Periodlangd.Name = "Periodlangd"
        Me.Periodlangd.Size = New System.Drawing.Size(88, 32)
        Me.Periodlangd.TabIndex = 12
        Me.Periodlangd.Text = "20:00"
        '
        'EMinuter
        '
        Me.EMinuter.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold)
        Me.EMinuter.Location = New System.Drawing.Point(202, 16)
        Me.EMinuter.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.EMinuter.Name = "EMinuter"
        Me.EMinuter.Size = New System.Drawing.Size(45, 49)
        Me.EMinuter.TabIndex = 9
        Me.EMinuter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(243, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 41)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = ":"
        '
        'ESekunder
        '
        Me.ESekunder.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold)
        Me.ESekunder.Location = New System.Drawing.Point(307, 17)
        Me.ESekunder.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.ESekunder.Name = "ESekunder"
        Me.ESekunder.Size = New System.Drawing.Size(45, 49)
        Me.ESekunder.TabIndex = 10
        Me.ESekunder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.BortaUtvisning)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.HemmaUtvisning)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.UtvisningsTid)
        Me.GroupBox2.Controls.Add(Me.UtvisadSpelare)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 198)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BUT1)
        Me.GroupBox6.Controls.Add(Me.BUT2)
        Me.GroupBox6.Controls.Add(Me.BSNR1)
        Me.GroupBox6.Controls.Add(Me.BSNR2)
        Me.GroupBox6.Location = New System.Drawing.Point(320, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(158, 74)
        Me.GroupBox6.TabIndex = 59
        Me.GroupBox6.TabStop = False
        '
        'BUT1
        '
        Me.BUT1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BUT1.Location = New System.Drawing.Point(71, 13)
        Me.BUT1.Name = "BUT1"
        Me.BUT1.Size = New System.Drawing.Size(81, 23)
        Me.BUT1.TabIndex = 54
        '
        'BUT2
        '
        Me.BUT2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BUT2.Location = New System.Drawing.Point(71, 43)
        Me.BUT2.Name = "BUT2"
        Me.BUT2.Size = New System.Drawing.Size(81, 23)
        Me.BUT2.TabIndex = 55
        '
        'BSNR1
        '
        Me.BSNR1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BSNR1.Location = New System.Drawing.Point(6, 13)
        Me.BSNR1.Name = "BSNR1"
        Me.BSNR1.Size = New System.Drawing.Size(38, 23)
        Me.BSNR1.TabIndex = 52
        '
        'BSNR2
        '
        Me.BSNR2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BSNR2.Location = New System.Drawing.Point(6, 43)
        Me.BSNR2.Name = "BSNR2"
        Me.BSNR2.Size = New System.Drawing.Size(38, 23)
        Me.BSNR2.TabIndex = 53
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HUT1)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.HSNR1)
        Me.GroupBox4.Controls.Add(Me.HUT2)
        Me.GroupBox4.Controls.Add(Me.HSNR2)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 74)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        '
        'HUT1
        '
        Me.HUT1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.HUT1.Location = New System.Drawing.Point(71, 15)
        Me.HUT1.Name = "HUT1"
        Me.HUT1.Size = New System.Drawing.Size(81, 23)
        Me.HUT1.TabIndex = 50
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(252, 1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(214, 64)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(44, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(0, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 23)
        Me.Label6.TabIndex = 49
        '
        'HSNR1
        '
        Me.HSNR1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.HSNR1.Location = New System.Drawing.Point(6, 15)
        Me.HSNR1.Name = "HSNR1"
        Me.HSNR1.Size = New System.Drawing.Size(38, 23)
        Me.HSNR1.TabIndex = 48
        '
        'HUT2
        '
        Me.HUT2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.HUT2.Location = New System.Drawing.Point(71, 48)
        Me.HUT2.Name = "HUT2"
        Me.HUT2.Size = New System.Drawing.Size(81, 23)
        Me.HUT2.TabIndex = 51
        '
        'HSNR2
        '
        Me.HSNR2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.HSNR2.Location = New System.Drawing.Point(6, 48)
        Me.HSNR2.Name = "HSNR2"
        Me.HSNR2.Size = New System.Drawing.Size(38, 23)
        Me.HSNR2.TabIndex = 49
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(317, 124)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(45, 32)
        Me.Button8.TabIndex = 56
        Me.Button8.Text = "=>"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 37
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button9.Location = New System.Drawing.Point(125, 125)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(45, 32)
        Me.Button9.TabIndex = 45
        Me.Button9.Text = "=<"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(234, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 143)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'OnOff
        '
        Me.OnOff.BackColor = System.Drawing.Color.LightSlateGray
        Me.OnOff.Location = New System.Drawing.Point(20, 18)
        Me.OnOff.Name = "OnOff"
        Me.OnOff.Size = New System.Drawing.Size(78, 36)
        Me.OnOff.TabIndex = 12
        Me.OnOff.Text = "On !!!"
        Me.OnOff.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Controls.Add(Me.Button11)
        Me.GroupBox7.Controls.Add(Me.TBPort)
        Me.GroupBox7.Controls.Add(Me.Button10)
        Me.GroupBox7.Controls.Add(Me.TBTo)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 551)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(491, 57)
        Me.GroupBox7.TabIndex = 36
        Me.GroupBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 4
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(404, 15)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 36)
        Me.Button11.TabIndex = 3
        Me.Button11.Text = "Avsluta"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TBPort
        '
        Me.TBPort.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TBPort.Location = New System.Drawing.Point(146, 19)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(55, 26)
        Me.TBPort.TabIndex = 1
        Me.TBPort.Text = "9998"
        Me.TBPort.Visible = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(204, 14)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 36)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Connect..."
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'TBTo
        '
        Me.TBTo.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TBTo.Location = New System.Drawing.Point(9, 19)
        Me.TBTo.Name = "TBTo"
        Me.TBTo.Size = New System.Drawing.Size(131, 26)
        Me.TBTo.TabIndex = 0
        Me.TBTo.Text = "192.168.2.19"
        Me.TBTo.Visible = False
        '
        'TBHemmaLag
        '
        Me.TBHemmaLag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHemmaLag.Location = New System.Drawing.Point(22, 124)
        Me.TBHemmaLag.Name = "TBHemmaLag"
        Me.TBHemmaLag.Size = New System.Drawing.Size(58, 26)
        Me.TBHemmaLag.TabIndex = 37
        Me.TBHemmaLag.Text = "HOME"
        '
        'TBBortaLag
        '
        Me.TBBortaLag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBortaLag.Location = New System.Drawing.Point(170, 124)
        Me.TBBortaLag.Name = "TBBortaLag"
        Me.TBBortaLag.Size = New System.Drawing.Size(58, 26)
        Me.TBBortaLag.TabIndex = 38
        Me.TBBortaLag.Text = "AWAY"
        '
        'TBPosY
        '
        Me.TBPosY.Location = New System.Drawing.Point(144, 38)
        Me.TBPosY.Name = "TBPosY"
        Me.TBPosY.Size = New System.Drawing.Size(38, 20)
        Me.TBPosY.TabIndex = 40
        Me.TBPosY.Text = "0"
        '
        'TBPosX
        '
        Me.TBPosX.Location = New System.Drawing.Point(144, 19)
        Me.TBPosX.Name = "TBPosX"
        Me.TBPosX.Size = New System.Drawing.Size(38, 20)
        Me.TBPosX.TabIndex = 39
        Me.TBPosX.Text = "1920"
        '
        'TBColR
        '
        Me.TBColR.BackColor = System.Drawing.Color.Black
        Me.TBColR.Location = New System.Drawing.Point(22, 85)
        Me.TBColR.Name = "TBColR"
        Me.TBColR.Size = New System.Drawing.Size(206, 20)
        Me.TBColR.TabIndex = 41
        Me.TBColR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Hemmalag"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(171, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Bortalag"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(106, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Y-Pos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(106, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "X-Pos"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(22, 60)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 48
        Me.Button13.Text = "Färg"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(443, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 53
        Me.CheckBox1.Text = "Scoreboard"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "PNG"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(170, 156)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'BtnRead
        '
        Me.BtnRead.Location = New System.Drawing.Point(89, 156)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(75, 23)
        Me.BtnRead.TabIndex = 56
        Me.BtnRead.Text = "Open File"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(89, 186)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 57
        Me.BtnSave.Text = "Save File"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "game"
        Me.SaveFileDialog1.Title = "Save"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 59
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(443, 41)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox2.TabIndex = 60
        Me.CheckBox2.Text = "Lower third"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TBtit1
        '
        Me.TBtit1.Location = New System.Drawing.Point(443, 60)
        Me.TBtit1.Name = "TBtit1"
        Me.TBtit1.Size = New System.Drawing.Size(176, 20)
        Me.TBtit1.TabIndex = 61
        '
        'TBtit2
        '
        Me.TBtit2.Location = New System.Drawing.Point(443, 85)
        Me.TBtit2.Name = "TBtit2"
        Me.TBtit2.Size = New System.Drawing.Size(176, 20)
        Me.TBtit2.TabIndex = 62
        '
        'AEtvScoreHockey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 620)
        Me.Controls.Add(Me.TBtit2)
        Me.Controls.Add(Me.TBtit1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.OnOff)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBColR)
        Me.Controls.Add(Me.TBPosY)
        Me.Controls.Add(Me.TBPosX)
        Me.Controls.Add(Me.TBBortaLag)
        Me.Controls.Add(Me.TBHemmaLag)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "AEtvScoreHockey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TAIF-TV Scoreboard"
        CType(Me.Hemmascore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BortaScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMinuter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSekunder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Period, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMinuter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESekunder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Hemmascore As System.Windows.Forms.NumericUpDown
    Friend WithEvents BortaScore As System.Windows.Forms.NumericUpDown
    Friend WithEvents TMinuter As System.Windows.Forms.NumericUpDown
    Friend WithEvents TSekunder As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents HemmaUtvisning As System.Windows.Forms.ListBox
    Friend WithEvents UtvisadSpelare As System.Windows.Forms.TextBox
    Friend WithEvents UtvisningsTid As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BortaUtvisning As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents EMinuter As System.Windows.Forms.NumericUpDown
    Friend WithEvents ESekunder As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents BSNR2 As System.Windows.Forms.Label
    Protected WithEvents BSNR1 As System.Windows.Forms.Label
    Protected WithEvents HSNR2 As System.Windows.Forms.Label
    Protected WithEvents HSNR1 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Protected WithEvents Label5 As System.Windows.Forms.Label
    Protected WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OnOff As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents TBTo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Period As System.Windows.Forms.NumericUpDown
    Friend WithEvents TBHemmaLag As System.Windows.Forms.TextBox
    Friend WithEvents TBBortaLag As System.Windows.Forms.TextBox
    Friend WithEvents BUT2 As System.Windows.Forms.Label
    Friend WithEvents BUT1 As System.Windows.Forms.Label
    Friend WithEvents HUT2 As System.Windows.Forms.Label
    Friend WithEvents HUT1 As System.Windows.Forms.Label
    Friend WithEvents TBPosY As System.Windows.Forms.TextBox
    Friend WithEvents TBPosX As System.Windows.Forms.TextBox
    Friend WithEvents TBColR As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRead As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TBtit1 As System.Windows.Forms.TextBox
    Friend WithEvents TBtit2 As System.Windows.Forms.TextBox
    Friend WithEvents Periodlangd As System.Windows.Forms.ComboBox

End Class

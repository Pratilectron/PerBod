<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New PerBod.FormSkin()
        Me.Poids1 = New System.Windows.Forms.TextBox()
        Me.Taille1 = New System.Windows.Forms.TextBox()
        Me.Age1 = New System.Windows.Forms.TextBox()
        Me.Nom1 = New System.Windows.Forms.TextBox()
        Me.FlatLabel12 = New PerBod.FlatLabel()
        Me.FlatLabel11 = New PerBod.FlatLabel()
        Me.FlatButton1 = New PerBod.FlatButton()
        Me.bar1 = New PerBod.FlatProgressBar()
        Me.FlatGroupBox1 = New PerBod.FlatGroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.FlatLabel10 = New PerBod.FlatLabel()
        Me.FlatLabel9 = New PerBod.FlatLabel()
        Me.FlatLabel8 = New PerBod.FlatLabel()
        Me.FlatLabel7 = New PerBod.FlatLabel()
        Me.FlatLabel6 = New PerBod.FlatLabel()
        Me.track1 = New PerBod.FlatTrackBar()
        Me.FlatMini1 = New PerBod.FlatMini()
        Me.FlatClose1 = New PerBod.FlatClose()
        Me.FlatLabel5 = New PerBod.FlatLabel()
        Me.FlatLabel4 = New PerBod.FlatLabel()
        Me.FlatLabel3 = New PerBod.FlatLabel()
        Me.FlatLabel2 = New PerBod.FlatLabel()
        Me.FlatLabel1 = New PerBod.FlatLabel()
        Me.Sexe1 = New PerBod.FlatComboBox()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Poids1)
        Me.FormSkin1.Controls.Add(Me.Taille1)
        Me.FormSkin1.Controls.Add(Me.Age1)
        Me.FormSkin1.Controls.Add(Me.Nom1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel12)
        Me.FormSkin1.Controls.Add(Me.FlatLabel11)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.bar1)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.Sexe1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(410, 503)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "PerBod"
        '
        'Poids1
        '
        Me.Poids1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Poids1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Poids1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Poids1.ForeColor = System.Drawing.Color.Silver
        Me.Poids1.Location = New System.Drawing.Point(153, 274)
        Me.Poids1.MaxLength = 3
        Me.Poids1.Multiline = True
        Me.Poids1.Name = "Poids1"
        Me.Poids1.Size = New System.Drawing.Size(128, 22)
        Me.Poids1.TabIndex = 33
        Me.Poids1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Poids1.WordWrap = False
        '
        'Taille1
        '
        Me.Taille1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Taille1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Taille1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Taille1.ForeColor = System.Drawing.Color.Silver
        Me.Taille1.Location = New System.Drawing.Point(153, 238)
        Me.Taille1.MaxLength = 3
        Me.Taille1.Multiline = True
        Me.Taille1.Name = "Taille1"
        Me.Taille1.Size = New System.Drawing.Size(128, 22)
        Me.Taille1.TabIndex = 32
        Me.Taille1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Taille1.WordWrap = False
        '
        'Age1
        '
        Me.Age1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Age1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Age1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Age1.ForeColor = System.Drawing.Color.Silver
        Me.Age1.Location = New System.Drawing.Point(153, 162)
        Me.Age1.MaxLength = 2
        Me.Age1.Multiline = True
        Me.Age1.Name = "Age1"
        Me.Age1.Size = New System.Drawing.Size(128, 22)
        Me.Age1.TabIndex = 31
        Me.Age1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Age1.WordWrap = False
        '
        'Nom1
        '
        Me.Nom1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Nom1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Nom1.ForeColor = System.Drawing.Color.Silver
        Me.Nom1.Location = New System.Drawing.Point(153, 125)
        Me.Nom1.MaxLength = 20
        Me.Nom1.Multiline = True
        Me.Nom1.Name = "Nom1"
        Me.Nom1.Size = New System.Drawing.Size(128, 20)
        Me.Nom1.TabIndex = 30
        Me.Nom1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlatLabel12
        '
        Me.FlatLabel12.AutoSize = True
        Me.FlatLabel12.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel12.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel12.ForeColor = System.Drawing.Color.White
        Me.FlatLabel12.Location = New System.Drawing.Point(302, 268)
        Me.FlatLabel12.Name = "FlatLabel12"
        Me.FlatLabel12.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.FlatLabel12.Size = New System.Drawing.Size(39, 27)
        Me.FlatLabel12.TabIndex = 29
        Me.FlatLabel12.Text = "(en Kg)"
        Me.FlatLabel12.UseCompatibleTextRendering = True
        '
        'FlatLabel11
        '
        Me.FlatLabel11.AutoSize = True
        Me.FlatLabel11.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel11.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel11.ForeColor = System.Drawing.Color.White
        Me.FlatLabel11.Location = New System.Drawing.Point(302, 233)
        Me.FlatLabel11.Name = "FlatLabel11"
        Me.FlatLabel11.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.FlatLabel11.Size = New System.Drawing.Size(42, 27)
        Me.FlatLabel11.TabIndex = 28
        Me.FlatLabel11.Text = "(en Cm)"
        Me.FlatLabel11.UseCompatibleTextRendering = True
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(153, 402)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = True
        Me.FlatButton1.Size = New System.Drawing.Size(106, 28)
        Me.FlatButton1.TabIndex = 27
        Me.FlatButton1.Text = "Submit"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'bar1
        '
        Me.bar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.bar1.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.bar1.Location = New System.Drawing.Point(37, 388)
        Me.bar1.Maximum = 100
        Me.bar1.Name = "bar1"
        Me.bar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.bar1.Size = New System.Drawing.Size(342, 42)
        Me.bar1.TabIndex = 26
        Me.bar1.Text = "FlatProgressBar1"
        Me.bar1.UseWaitCursor = True
        Me.bar1.Value = 0
        Me.bar1.Visible = False
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.LinkLabel1)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel10)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel9)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel8)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel7)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel6)
        Me.FlatGroupBox1.Controls.Add(Me.track1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.ForeColor = System.Drawing.Color.Coral
        Me.FlatGroupBox1.Location = New System.Drawing.Point(37, 296)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(361, 92)
        Me.FlatGroupBox1.TabIndex = 24
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Simplified Arabic Fixed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.InactiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(319, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 19)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help"
        Me.LinkLabel1.UseCompatibleTextRendering = True
        Me.LinkLabel1.UseMnemonic = False
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel10.ForeColor = System.Drawing.Color.White
        Me.FlatLabel10.Location = New System.Drawing.Point(-3, 20)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(147, 13)
        Me.FlatLabel10.TabIndex = 29
        Me.FlatLabel10.Text = "Niveau d’Activité Physique :"
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel9.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.FlatLabel9.Location = New System.Drawing.Point(270, 47)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(45, 13)
        Me.FlatLabel9.TabIndex = 28
        Me.FlatLabel9.Text = "Intense"
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.LawnGreen
        Me.FlatLabel8.Location = New System.Drawing.Point(191, 47)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(53, 13)
        Me.FlatLabel8.TabIndex = 27
        Me.FlatLabel8.Text = "Modérée"
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.GreenYellow
        Me.FlatLabel7.Location = New System.Drawing.Point(113, 47)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(41, 13)
        Me.FlatLabel7.TabIndex = 26
        Me.FlatLabel7.Text = "Légère"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.Yellow
        Me.FlatLabel6.Location = New System.Drawing.Point(19, 47)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(62, 13)
        Me.FlatLabel6.TabIndex = 25
        Me.FlatLabel6.Text = "Sédentaire"
        '
        'track1
        '
        Me.track1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.track1.HatchColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.track1.Location = New System.Drawing.Point(41, 63)
        Me.track1.Maximum = 3
        Me.track1.Minimum = 0
        Me.track1.Name = "track1"
        Me.track1.ShowValue = False
        Me.track1.Size = New System.Drawing.Size(255, 23)
        Me.track1.Style = PerBod.FlatTrackBar._Style.Slider
        Me.track1.TabIndex = 24
        Me.track1.Text = "FlatTrackBar1"
        Me.track1.TrackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.track1.Value = 0
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(356, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 19
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(380, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 18
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(106, 268)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.FlatLabel5.Size = New System.Drawing.Size(41, 21)
        Me.FlatLabel5.TabIndex = 16
        Me.FlatLabel5.Text = "Poids :"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(108, 233)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.FlatLabel4.Size = New System.Drawing.Size(39, 21)
        Me.FlatLabel4.TabIndex = 15
        Me.FlatLabel4.Text = "Taille :"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(112, 195)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.FlatLabel3.Size = New System.Drawing.Size(36, 21)
        Me.FlatLabel3.TabIndex = 14
        Me.FlatLabel3.Text = "Sexe :"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(115, 158)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.FlatLabel2.Size = New System.Drawing.Size(33, 21)
        Me.FlatLabel2.TabIndex = 13
        Me.FlatLabel2.Text = "Âge :"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(111, 120)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.FlatLabel1.Size = New System.Drawing.Size(37, 21)
        Me.FlatLabel1.TabIndex = 12
        Me.FlatLabel1.Text = "Nom :"
        '
        'Sexe1
        '
        Me.Sexe1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Sexe1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sexe1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Sexe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sexe1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Sexe1.ForeColor = System.Drawing.Color.White
        Me.Sexe1.FormattingEnabled = True
        Me.Sexe1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Sexe1.ItemHeight = 18
        Me.Sexe1.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.Sexe1.Location = New System.Drawing.Point(153, 200)
        Me.Sexe1.Name = "Sexe1"
        Me.Sexe1.Size = New System.Drawing.Size(168, 24)
        Me.Sexe1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 503)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PerBod"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents Sexe1 As FlatComboBox
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents bar1 As FlatProgressBar
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents FlatLabel10 As FlatLabel
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents FlatLabel8 As FlatLabel
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents track1 As FlatTrackBar
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlatLabel12 As FlatLabel
    Friend WithEvents FlatLabel11 As FlatLabel
    Friend WithEvents Nom1 As TextBox
    Friend WithEvents Poids1 As TextBox
    Friend WithEvents Taille1 As TextBox
    Friend WithEvents Age1 As TextBox
End Class

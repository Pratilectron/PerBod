<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.FormSkin1 = New PerBod.FormSkin()
        Me.bar = New PerBod.SharpProgreSsBar()
        Me.FlatButton1 = New PerBod.FlatButton()
        Me.Gdej = New PerBod.SharpGroupBOx()
        Me.B12 = New PerBod.SharpButton()
        Me.Label6 = New PerBod.FlatLabel()
        Me.Gaj = New PerBod.SharpGroupBOx()
        Me.label76 = New PerBod.FlatLabel()
        Me.label75 = New PerBod.FlatLabel()
        Me.label74 = New PerBod.FlatLabel()
        Me.Label73 = New PerBod.FlatLabel()
        Me.Label72 = New PerBod.FlatLabel()
        Me.label71 = New PerBod.FlatLabel()
        Me.Label7 = New PerBod.FlatLabel()
        Me.B11 = New PerBod.SharpButton()
        Me.B10 = New PerBod.SharpButton()
        Me.B9 = New PerBod.SharpButton()
        Me.Gfc = New PerBod.SharpGroupBOx()
        Me.Label52 = New PerBod.FlatLabel()
        Me.label51 = New PerBod.FlatLabel()
        Me.B8 = New PerBod.SharpButton()
        Me.B7 = New PerBod.SharpButton()
        Me.Label5 = New PerBod.FlatLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Gmb = New PerBod.SharpGroupBOx()
        Me.B6 = New PerBod.SharpButton()
        Me.Label4 = New PerBod.FlatLabel()
        Me.Gpi = New PerBod.SharpGroupBOx()
        Me.B5 = New PerBod.SharpButton()
        Me.Label3 = New PerBod.FlatLabel()
        Me.Gimg = New PerBod.SharpGroupBOx()
        Me.B4 = New PerBod.SharpButton()
        Me.B3 = New PerBod.SharpButton()
        Me.Label2 = New PerBod.FlatLabel()
        Me.Gimc = New PerBod.SharpGroupBOx()
        Me.B2 = New PerBod.SharpButton()
        Me.B1 = New PerBod.SharpButton()
        Me.Label1 = New PerBod.FlatLabel()
        Me.Guser = New PerBod.SharpGroupBOx()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.napL = New PerBod.FlatLabel()
        Me.PoidsL = New PerBod.FlatLabel()
        Me.TailleL = New PerBod.FlatLabel()
        Me.SexeL = New PerBod.FlatLabel()
        Me.AgeL = New PerBod.FlatLabel()
        Me.NomL = New PerBod.FlatLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout()
        Me.Gdej.SuspendLayout()
        Me.Gaj.SuspendLayout()
        Me.Gfc.SuspendLayout()
        Me.Gmb.SuspendLayout()
        Me.Gpi.SuspendLayout()
        Me.Gimg.SuspendLayout()
        Me.Gimc.SuspendLayout()
        Me.Guser.SuspendLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.bar)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.Gdej)
        Me.FormSkin1.Controls.Add(Me.Gaj)
        Me.FormSkin1.Controls.Add(Me.Gfc)
        Me.FormSkin1.Controls.Add(Me.TextBox1)
        Me.FormSkin1.Controls.Add(Me.Gmb)
        Me.FormSkin1.Controls.Add(Me.Gpi)
        Me.FormSkin1.Controls.Add(Me.Gimg)
        Me.FormSkin1.Controls.Add(Me.Gimc)
        Me.FormSkin1.Controls.Add(Me.Guser)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(695, 556)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "PerBod"
        '
        'bar
        '
        Me.bar.Animate = True
        Me.bar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bar.Color = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.bar.GlowColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bar.HighlightColor = System.Drawing.Color.Silver
        Me.bar.Location = New System.Drawing.Point(109, 521)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(498, 23)
        Me.bar.TabIndex = 19
        Me.bar.Text = "SharpProgreSsBar2"
        Me.bar.UseWaitCursor = True
        Me.bar.Value = 0
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(662, 12)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(21, 22)
        Me.FlatButton1.TabIndex = 17
        Me.FlatButton1.Text = "x"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Gdej
        '
        Me.Gdej.Controls.Add(Me.B12)
        Me.Gdej.Controls.Add(Me.Label6)
        Me.Gdej.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Gdej.Location = New System.Drawing.Point(255, 409)
        Me.Gdej.Name = "Gdej"
        Me.Gdej.Size = New System.Drawing.Size(195, 101)
        Me.Gdej.TabIndex = 16
        Me.Gdej.Text = "DEJ"
        Me.Gdej.Visible = False
        '
        'B12
        '
        Me.B12.Color2 = False
        Me.B12.Enabled = False
        Me.B12.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B12.Location = New System.Drawing.Point(45, 63)
        Me.B12.Name = "B12"
        Me.B12.Size = New System.Drawing.Size(114, 23)
        Me.B12.TabIndex = 27
        Me.B12.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightPink
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(0, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = " BESOIN ÉNERGÉTIQUE JOURNALIER "
        Me.Label6.UseCompatibleTextRendering = True
        Me.Label6.Visible = False
        '
        'Gaj
        '
        Me.Gaj.Controls.Add(Me.label76)
        Me.Gaj.Controls.Add(Me.label75)
        Me.Gaj.Controls.Add(Me.label74)
        Me.Gaj.Controls.Add(Me.Label73)
        Me.Gaj.Controls.Add(Me.Label72)
        Me.Gaj.Controls.Add(Me.label71)
        Me.Gaj.Controls.Add(Me.Label7)
        Me.Gaj.Controls.Add(Me.B11)
        Me.Gaj.Controls.Add(Me.B10)
        Me.Gaj.Controls.Add(Me.B9)
        Me.Gaj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Gaj.Location = New System.Drawing.Point(464, 360)
        Me.Gaj.Name = "Gaj"
        Me.Gaj.Size = New System.Drawing.Size(210, 150)
        Me.Gaj.TabIndex = 15
        Me.Gaj.Text = "AJ"
        Me.Gaj.Visible = False
        '
        'label76
        '
        Me.label76.AutoSize = True
        Me.label76.BackColor = System.Drawing.Color.Transparent
        Me.label76.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.label76.ForeColor = System.Drawing.Color.White
        Me.label76.Location = New System.Drawing.Point(186, 122)
        Me.label76.Name = "label76"
        Me.label76.Size = New System.Drawing.Size(21, 13)
        Me.label76.TabIndex = 35
        Me.label76.Text = "g/j"
        Me.label76.Visible = False
        '
        'label75
        '
        Me.label75.AutoSize = True
        Me.label75.BackColor = System.Drawing.Color.Transparent
        Me.label75.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.label75.ForeColor = System.Drawing.Color.White
        Me.label75.Location = New System.Drawing.Point(186, 91)
        Me.label75.Name = "label75"
        Me.label75.Size = New System.Drawing.Size(21, 13)
        Me.label75.TabIndex = 34
        Me.label75.Text = "g/j"
        Me.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.label75.Visible = False
        '
        'label74
        '
        Me.label74.AutoSize = True
        Me.label74.BackColor = System.Drawing.Color.Transparent
        Me.label74.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.label74.ForeColor = System.Drawing.Color.White
        Me.label74.Location = New System.Drawing.Point(186, 62)
        Me.label74.Name = "label74"
        Me.label74.Size = New System.Drawing.Size(21, 13)
        Me.label74.TabIndex = 33
        Me.label74.Text = "g/j"
        Me.label74.Visible = False
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(12, 122)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(52, 13)
        Me.Label73.TabIndex = 32
        Me.Label73.Text = "Glucide :"
        Me.Label73.Visible = False
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label72.ForeColor = System.Drawing.Color.White
        Me.Label72.Location = New System.Drawing.Point(20, 91)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(44, 13)
        Me.Label72.TabIndex = 31
        Me.Label72.Text = "Lipide :"
        Me.Label72.Visible = False
        '
        'label71
        '
        Me.label71.AutoSize = True
        Me.label71.BackColor = System.Drawing.Color.Transparent
        Me.label71.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.label71.ForeColor = System.Drawing.Color.White
        Me.label71.Location = New System.Drawing.Point(8, 62)
        Me.label71.Name = "label71"
        Me.label71.Size = New System.Drawing.Size(56, 13)
        Me.label71.TabIndex = 30
        Me.label71.Text = "Protéine :"
        Me.label71.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SkyBlue
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(-13, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "         APPORT JOURNALIER (en Calories)                   "
        Me.Label7.UseCompatibleTextRendering = True
        Me.Label7.Visible = False
        '
        'B11
        '
        Me.B11.Color2 = False
        Me.B11.Enabled = False
        Me.B11.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B11.Location = New System.Drawing.Point(70, 120)
        Me.B11.Name = "B11"
        Me.B11.Size = New System.Drawing.Size(114, 23)
        Me.B11.TabIndex = 28
        Me.B11.Visible = False
        '
        'B10
        '
        Me.B10.Color2 = False
        Me.B10.Enabled = False
        Me.B10.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B10.Location = New System.Drawing.Point(70, 91)
        Me.B10.Name = "B10"
        Me.B10.Size = New System.Drawing.Size(114, 23)
        Me.B10.TabIndex = 27
        Me.B10.Visible = False
        '
        'B9
        '
        Me.B9.Color2 = False
        Me.B9.Enabled = False
        Me.B9.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B9.Location = New System.Drawing.Point(70, 62)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(114, 23)
        Me.B9.TabIndex = 26
        Me.B9.Visible = False
        '
        'Gfc
        '
        Me.Gfc.Controls.Add(Me.Label52)
        Me.Gfc.Controls.Add(Me.label51)
        Me.Gfc.Controls.Add(Me.B8)
        Me.Gfc.Controls.Add(Me.B7)
        Me.Gfc.Controls.Add(Me.Label5)
        Me.Gfc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Gfc.Location = New System.Drawing.Point(26, 360)
        Me.Gfc.Name = "Gfc"
        Me.Gfc.Size = New System.Drawing.Size(207, 150)
        Me.Gfc.TabIndex = 10
        Me.Gfc.Text = "FC Max"
        Me.Gfc.Visible = False
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(63, 104)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(80, 13)
        Me.Label52.TabIndex = 28
        Me.Label52.Text = "Selon Gellish :"
        Me.Label52.Visible = False
        '
        'label51
        '
        Me.label51.AutoSize = True
        Me.label51.BackColor = System.Drawing.Color.Transparent
        Me.label51.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.label51.ForeColor = System.Drawing.Color.White
        Me.label51.Location = New System.Drawing.Point(23, 62)
        Me.label51.Name = "label51"
        Me.label51.Size = New System.Drawing.Size(85, 13)
        Me.label51.TabIndex = 27
        Me.label51.Text = "Selon Astrand :"
        Me.label51.Visible = False
        '
        'B8
        '
        Me.B8.Color2 = False
        Me.B8.Enabled = False
        Me.B8.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B8.Location = New System.Drawing.Point(66, 120)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(114, 23)
        Me.B8.TabIndex = 26
        Me.B8.Visible = False
        '
        'B7
        '
        Me.B7.Color2 = False
        Me.B7.Enabled = False
        Me.B7.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B7.Location = New System.Drawing.Point(26, 78)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(114, 23)
        Me.B7.TabIndex = 25
        Me.B7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.15!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(-2, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "  FRÉQUENCE CARDIAQUE MAXIMALE  "
        Me.Label5.UseCompatibleTextRendering = True
        Me.Label5.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.WordWrap = False
        '
        'Gmb
        '
        Me.Gmb.Controls.Add(Me.B6)
        Me.Gmb.Controls.Add(Me.Label4)
        Me.Gmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Gmb.Location = New System.Drawing.Point(464, 222)
        Me.Gmb.Name = "Gmb"
        Me.Gmb.Size = New System.Drawing.Size(210, 116)
        Me.Gmb.TabIndex = 12
        Me.Gmb.Text = "MB"
        Me.Gmb.Visible = False
        '
        'B6
        '
        Me.B6.Color2 = False
        Me.B6.Enabled = False
        Me.B6.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B6.Location = New System.Drawing.Point(44, 65)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(114, 23)
        Me.B6.TabIndex = 25
        Me.B6.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightPink
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(-2, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "    MÉTABOLISME DE BASE (en Calories)                   "
        Me.Label4.UseCompatibleTextRendering = True
        Me.Label4.Visible = False
        '
        'Gpi
        '
        Me.Gpi.Controls.Add(Me.B5)
        Me.Gpi.Controls.Add(Me.Label3)
        Me.Gpi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Gpi.Location = New System.Drawing.Point(26, 222)
        Me.Gpi.Name = "Gpi"
        Me.Gpi.Size = New System.Drawing.Size(207, 116)
        Me.Gpi.TabIndex = 11
        Me.Gpi.Text = "PI"
        Me.Gpi.Visible = False
        '
        'B5
        '
        Me.B5.Color2 = False
        Me.B5.Enabled = False
        Me.B5.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B5.Location = New System.Drawing.Point(46, 70)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(114, 23)
        Me.B5.TabIndex = 23
        Me.B5.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(0, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "                  POIDS IDÉAL                   "
        Me.Label3.UseCompatibleTextRendering = True
        Me.Label3.Visible = False
        '
        'Gimg
        '
        Me.Gimg.Controls.Add(Me.B4)
        Me.Gimg.Controls.Add(Me.B3)
        Me.Gimg.Controls.Add(Me.Label2)
        Me.Gimg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Gimg.Location = New System.Drawing.Point(464, 84)
        Me.Gimg.Name = "Gimg"
        Me.Gimg.Size = New System.Drawing.Size(210, 123)
        Me.Gimg.TabIndex = 10
        Me.Gimg.Text = "IMG"
        Me.Gimg.Visible = False
        '
        'B4
        '
        Me.B4.Color2 = False
        Me.B4.Enabled = False
        Me.B4.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B4.Location = New System.Drawing.Point(26, 87)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(158, 23)
        Me.B4.TabIndex = 22
        Me.B4.Visible = False
        '
        'B3
        '
        Me.B3.Color2 = False
        Me.B3.Enabled = False
        Me.B3.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B3.Location = New System.Drawing.Point(46, 60)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(114, 23)
        Me.B3.TabIndex = 21
        Me.B3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCoral
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(0, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "         INDICE DE MASSE GRASSE     "
        Me.Label2.UseCompatibleTextRendering = True
        Me.Label2.Visible = False
        '
        'Gimc
        '
        Me.Gimc.Controls.Add(Me.B2)
        Me.Gimc.Controls.Add(Me.B1)
        Me.Gimc.Controls.Add(Me.Label1)
        Me.Gimc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Gimc.Location = New System.Drawing.Point(26, 84)
        Me.Gimc.Name = "Gimc"
        Me.Gimc.Size = New System.Drawing.Size(207, 123)
        Me.Gimc.TabIndex = 9
        Me.Gimc.Text = "IMC"
        Me.Gimc.Visible = False
        '
        'B2
        '
        Me.B2.Color2 = False
        Me.B2.Enabled = False
        Me.B2.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B2.Location = New System.Drawing.Point(26, 87)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(158, 23)
        Me.B2.TabIndex = 19
        Me.B2.Visible = False
        '
        'B1
        '
        Me.B1.Color2 = False
        Me.B1.Enabled = False
        Me.B1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.B1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.B1.Location = New System.Drawing.Point(46, 60)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(114, 23)
        Me.B1.TabIndex = 18
        Me.B1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSalmon
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "    INDICE DE MASSE CORPORELLE"
        Me.Label1.UseCompatibleTextRendering = True
        Me.Label1.Visible = False
        '
        'Guser
        '
        Me.Guser.Controls.Add(Me.P1)
        Me.Guser.Controls.Add(Me.napL)
        Me.Guser.Controls.Add(Me.PoidsL)
        Me.Guser.Controls.Add(Me.TailleL)
        Me.Guser.Controls.Add(Me.SexeL)
        Me.Guser.Controls.Add(Me.AgeL)
        Me.Guser.Controls.Add(Me.NomL)
        Me.Guser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guser.Location = New System.Drawing.Point(255, 101)
        Me.Guser.Name = "Guser"
        Me.Guser.Size = New System.Drawing.Size(190, 284)
        Me.Guser.TabIndex = 7
        Me.Guser.Text = "PerBod User"
        Me.Guser.Visible = False
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Transparent
        Me.P1.BackgroundImage = CType(resources.GetObject("P1.BackgroundImage"), System.Drawing.Image)
        Me.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P1.Location = New System.Drawing.Point(15, 36)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(148, 121)
        Me.P1.TabIndex = 13
        Me.P1.TabStop = False
        Me.P1.Visible = False
        '
        'napL
        '
        Me.napL.AutoSize = True
        Me.napL.BackColor = System.Drawing.Color.Transparent
        Me.napL.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.napL.ForeColor = System.Drawing.Color.White
        Me.napL.Location = New System.Drawing.Point(33, 253)
        Me.napL.Name = "napL"
        Me.napL.Size = New System.Drawing.Size(59, 13)
        Me.napL.TabIndex = 12
        Me.napL.Text = "FlatLabel6"
        Me.napL.Visible = False
        '
        'PoidsL
        '
        Me.PoidsL.AutoSize = True
        Me.PoidsL.BackColor = System.Drawing.Color.Transparent
        Me.PoidsL.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.PoidsL.ForeColor = System.Drawing.Color.White
        Me.PoidsL.Location = New System.Drawing.Point(33, 234)
        Me.PoidsL.Name = "PoidsL"
        Me.PoidsL.Size = New System.Drawing.Size(59, 13)
        Me.PoidsL.TabIndex = 11
        Me.PoidsL.Text = "FlatLabel5"
        Me.PoidsL.Visible = False
        '
        'TailleL
        '
        Me.TailleL.AutoSize = True
        Me.TailleL.BackColor = System.Drawing.Color.Transparent
        Me.TailleL.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TailleL.ForeColor = System.Drawing.Color.White
        Me.TailleL.Location = New System.Drawing.Point(33, 217)
        Me.TailleL.Name = "TailleL"
        Me.TailleL.Size = New System.Drawing.Size(59, 13)
        Me.TailleL.TabIndex = 10
        Me.TailleL.Text = "FlatLabel4"
        Me.TailleL.Visible = False
        '
        'SexeL
        '
        Me.SexeL.AutoSize = True
        Me.SexeL.BackColor = System.Drawing.Color.Transparent
        Me.SexeL.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SexeL.ForeColor = System.Drawing.Color.White
        Me.SexeL.Location = New System.Drawing.Point(33, 199)
        Me.SexeL.Name = "SexeL"
        Me.SexeL.Size = New System.Drawing.Size(59, 13)
        Me.SexeL.TabIndex = 9
        Me.SexeL.Text = "FlatLabel3"
        Me.SexeL.Visible = False
        '
        'AgeL
        '
        Me.AgeL.AutoSize = True
        Me.AgeL.BackColor = System.Drawing.Color.Transparent
        Me.AgeL.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.AgeL.ForeColor = System.Drawing.Color.White
        Me.AgeL.Location = New System.Drawing.Point(33, 180)
        Me.AgeL.Name = "AgeL"
        Me.AgeL.Size = New System.Drawing.Size(59, 13)
        Me.AgeL.TabIndex = 8
        Me.AgeL.Text = "FlatLabel2"
        Me.AgeL.Visible = False
        '
        'NomL
        '
        Me.NomL.AutoSize = True
        Me.NomL.BackColor = System.Drawing.Color.Transparent
        Me.NomL.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.NomL.ForeColor = System.Drawing.Color.White
        Me.NomL.Location = New System.Drawing.Point(33, 160)
        Me.NomL.Name = "NomL"
        Me.NomL.Size = New System.Drawing.Size(59, 13)
        Me.NomL.TabIndex = 7
        Me.NomL.Text = "FlatLabel1"
        Me.NomL.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 70
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 556)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PerBod"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.Gdej.ResumeLayout(False)
        Me.Gdej.PerformLayout()
        Me.Gaj.ResumeLayout(False)
        Me.Gaj.PerformLayout()
        Me.Gfc.ResumeLayout(False)
        Me.Gfc.PerformLayout()
        Me.Gmb.ResumeLayout(False)
        Me.Gmb.PerformLayout()
        Me.Gpi.ResumeLayout(False)
        Me.Gpi.PerformLayout()
        Me.Gimg.ResumeLayout(False)
        Me.Gimg.PerformLayout()
        Me.Gimc.ResumeLayout(False)
        Me.Gimc.PerformLayout()
        Me.Guser.ResumeLayout(False)
        Me.Guser.PerformLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents Guser As SharpGroupBOx
    Friend WithEvents P1 As PictureBox
    Friend WithEvents napL As FlatLabel
    Friend WithEvents PoidsL As FlatLabel
    Friend WithEvents TailleL As FlatLabel
    Friend WithEvents SexeL As FlatLabel
    Friend WithEvents AgeL As FlatLabel
    Friend WithEvents NomL As FlatLabel
    Friend WithEvents Gdej As SharpGroupBOx
    Friend WithEvents Gaj As SharpGroupBOx
    Friend WithEvents Gfc As SharpGroupBOx
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Gmb As SharpGroupBOx
    Friend WithEvents Gpi As SharpGroupBOx
    Friend WithEvents Gimg As SharpGroupBOx
    Friend WithEvents Gimc As SharpGroupBOx
    Friend WithEvents B5 As SharpButton
    Friend WithEvents Label3 As FlatLabel
    Friend WithEvents B4 As SharpButton
    Friend WithEvents B3 As SharpButton
    Friend WithEvents Label2 As FlatLabel
    Friend WithEvents B2 As SharpButton
    Friend WithEvents B1 As SharpButton
    Friend WithEvents Label1 As FlatLabel
    Friend WithEvents B6 As SharpButton
    Friend WithEvents Label4 As FlatLabel
    Friend WithEvents Label52 As FlatLabel
    Friend WithEvents label51 As FlatLabel
    Friend WithEvents B8 As SharpButton
    Friend WithEvents B7 As SharpButton
    Friend WithEvents Label5 As FlatLabel
    Friend WithEvents Label73 As FlatLabel
    Friend WithEvents Label72 As FlatLabel
    Friend WithEvents label71 As FlatLabel
    Friend WithEvents Label7 As FlatLabel
    Friend WithEvents B11 As SharpButton
    Friend WithEvents B10 As SharpButton
    Friend WithEvents B9 As SharpButton
    Friend WithEvents label76 As FlatLabel
    Friend WithEvents label75 As FlatLabel
    Friend WithEvents label74 As FlatLabel
    Friend WithEvents B12 As SharpButton
    Friend WithEvents Label6 As FlatLabel
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents bar As SharpProgreSsBar
    Friend WithEvents Timer1 As Timer
End Class

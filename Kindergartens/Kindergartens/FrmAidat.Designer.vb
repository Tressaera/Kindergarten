<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAidat
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAidat))
        Me.grpOgretmenAra = New System.Windows.Forms.GroupBox()
        Me.btntarihara = New System.Windows.Forms.Button()
        Me.txtveliara = New System.Windows.Forms.TextBox()
        Me.dttarihara = New System.Windows.Forms.DateTimePicker()
        Me.label17 = New System.Windows.Forms.Label()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.dtgridaidat = New System.Windows.Forms.DataGridView()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.btndonemara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnaidatsil = New System.Windows.Forms.Button()
        Me.cmbveli = New System.Windows.Forms.ComboBox()
        Me.btnaidatguncelle = New System.Windows.Forms.Button()
        Me.label15 = New System.Windows.Forms.Label()
        Me.btnaidatekle = New System.Windows.Forms.Button()
        Me.cmbodemeturu = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cmbgelirturu = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txttutar = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbgelir = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.AnaokuludbDataSet14 = New Kindergartens.AnaokuludbDataSet14()
        Me.VeliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeliTableAdapter = New Kindergartens.AnaokuludbDataSet14TableAdapters.VeliTableAdapter()
        Me.grpOgretmenAra.SuspendLayout()
        CType(Me.dtgridaidat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.AnaokuludbDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOgretmenAra
        '
        Me.grpOgretmenAra.Controls.Add(Me.btntarihara)
        Me.grpOgretmenAra.Controls.Add(Me.txtveliara)
        Me.grpOgretmenAra.Controls.Add(Me.dttarihara)
        Me.grpOgretmenAra.Controls.Add(Me.label17)
        Me.grpOgretmenAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgretmenAra.Controls.Add(Me.dtgridaidat)
        Me.grpOgretmenAra.Controls.Add(Me.label13)
        Me.grpOgretmenAra.Controls.Add(Me.label14)
        Me.grpOgretmenAra.Controls.Add(Me.btndonemara)
        Me.grpOgretmenAra.Controls.Add(Me.btnyenile)
        Me.grpOgretmenAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenAra.Location = New System.Drawing.Point(566, 18)
        Me.grpOgretmenAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Name = "grpOgretmenAra"
        Me.grpOgretmenAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Size = New System.Drawing.Size(943, 526)
        Me.grpOgretmenAra.TabIndex = 15
        Me.grpOgretmenAra.TabStop = False
        Me.grpOgretmenAra.Text = "Aidat Ara"
        '
        'btntarihara
        '
        Me.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btntarihara.Image = CType(resources.GetObject("btntarihara.Image"), System.Drawing.Image)
        Me.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntarihara.Location = New System.Drawing.Point(376, 49)
        Me.btntarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.btntarihara.Name = "btntarihara"
        Me.btntarihara.Size = New System.Drawing.Size(119, 37)
        Me.btntarihara.TabIndex = 57
        Me.btntarihara.Text = "Ara"
        Me.btntarihara.UseVisualStyleBackColor = False
        '
        'txtveliara
        '
        Me.txtveliara.Location = New System.Drawing.Point(143, 91)
        Me.txtveliara.Margin = New System.Windows.Forms.Padding(4)
        Me.txtveliara.Name = "txtveliara"
        Me.txtveliara.Size = New System.Drawing.Size(204, 26)
        Me.txtveliara.TabIndex = 56
        '
        'dttarihara
        '
        Me.dttarihara.Location = New System.Drawing.Point(143, 49)
        Me.dttarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarihara.Name = "dttarihara"
        Me.dttarihara.Size = New System.Drawing.Size(204, 26)
        Me.dttarihara.TabIndex = 55
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(0, 52)
        Me.label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(60, 25)
        Me.label17.TabIndex = 54
        Me.label17.Text = "Tarih:"
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(143, 16)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(204, 27)
        Me.cmbdonemara.TabIndex = 53
        '
        'dtgridaidat
        '
        Me.dtgridaidat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridaidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridaidat.Location = New System.Drawing.Point(8, 126)
        Me.dtgridaidat.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridaidat.Name = "dtgridaidat"
        Me.dtgridaidat.RowHeadersWidth = 51
        Me.dtgridaidat.Size = New System.Drawing.Size(927, 393)
        Me.dtgridaidat.TabIndex = 15
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(0, 91)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(139, 25)
        Me.label13.TabIndex = 51
        Me.label13.Text = "Veli Ad Soyad:"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(7, 17)
        Me.label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(82, 25)
        Me.label14.TabIndex = 49
        Me.label14.Text = "Dönem:"
        '
        'btndonemara
        '
        Me.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btndonemara.Image = CType(resources.GetObject("btndonemara.Image"), System.Drawing.Image)
        Me.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndonemara.Location = New System.Drawing.Point(376, 6)
        Me.btndonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.btndonemara.Name = "btndonemara"
        Me.btndonemara.Size = New System.Drawing.Size(119, 37)
        Me.btndonemara.TabIndex = 48
        Me.btndonemara.Text = "Ara"
        Me.btndonemara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(522, 23)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 47
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnaidatsil)
        Me.groupBox1.Controls.Add(Me.cmbveli)
        Me.groupBox1.Controls.Add(Me.btnaidatguncelle)
        Me.groupBox1.Controls.Add(Me.label15)
        Me.groupBox1.Controls.Add(Me.btnaidatekle)
        Me.groupBox1.Controls.Add(Me.cmbodemeturu)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.cmbdonem)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.cmbgelirturu)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txttutar)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.cmbgelir)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupBox1.Location = New System.Drawing.Point(13, 12)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(532, 450)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Aidat İşlemleri"
        '
        'btnaidatsil
        '
        Me.btnaidatsil.BackColor = System.Drawing.Color.IndianRed
        Me.btnaidatsil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnaidatsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaidatsil.Location = New System.Drawing.Point(368, 391)
        Me.btnaidatsil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaidatsil.Name = "btnaidatsil"
        Me.btnaidatsil.Size = New System.Drawing.Size(156, 52)
        Me.btnaidatsil.TabIndex = 25
        Me.btnaidatsil.Text = "SİL"
        Me.btnaidatsil.UseVisualStyleBackColor = False
        '
        'cmbveli
        '
        Me.cmbveli.DataSource = Me.VeliBindingSource
        Me.cmbveli.DisplayMember = "ADSOYAD"
        Me.cmbveli.FormattingEnabled = True
        Me.cmbveli.Location = New System.Drawing.Point(169, 21)
        Me.cmbveli.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbveli.Name = "cmbveli"
        Me.cmbveli.Size = New System.Drawing.Size(189, 27)
        Me.cmbveli.TabIndex = 31
        Me.cmbveli.ValueMember = "VeliID"
        '
        'btnaidatguncelle
        '
        Me.btnaidatguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnaidatguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnaidatguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaidatguncelle.Location = New System.Drawing.Point(187, 391)
        Me.btnaidatguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaidatguncelle.Name = "btnaidatguncelle"
        Me.btnaidatguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnaidatguncelle.TabIndex = 44
        Me.btnaidatguncelle.Text = "Güncelle"
        Me.btnaidatguncelle.UseVisualStyleBackColor = False
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(1, 22)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(139, 25)
        Me.label15.TabIndex = 30
        Me.label15.Text = "Veli Ad Soyad:"
        '
        'btnaidatekle
        '
        Me.btnaidatekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnaidatekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnaidatekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaidatekle.Location = New System.Drawing.Point(8, 391)
        Me.btnaidatekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaidatekle.Name = "btnaidatekle"
        Me.btnaidatekle.Size = New System.Drawing.Size(156, 52)
        Me.btnaidatekle.TabIndex = 27
        Me.btnaidatekle.Text = "Ekle"
        Me.btnaidatekle.UseVisualStyleBackColor = False
        '
        'cmbodemeturu
        '
        Me.cmbodemeturu.FormattingEnabled = True
        Me.cmbodemeturu.Items.AddRange(New Object() {"Kredi Kartı", "Nakit", "Havale", "EFT"})
        Me.cmbodemeturu.Location = New System.Drawing.Point(171, 283)
        Me.cmbodemeturu.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbodemeturu.Name = "cmbodemeturu"
        Me.cmbodemeturu.Size = New System.Drawing.Size(189, 27)
        Me.cmbodemeturu.TabIndex = 26
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(-1, 284)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(127, 25)
        Me.label6.TabIndex = 25
        Me.label6.Text = "Ödeme Türü:"
        '
        'cmbdonem
        '
        Me.cmbdonem.FormattingEnabled = True
        Me.cmbdonem.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonem.Location = New System.Drawing.Point(171, 335)
        Me.cmbdonem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonem.Name = "cmbdonem"
        Me.cmbdonem.Size = New System.Drawing.Size(189, 27)
        Me.cmbdonem.TabIndex = 24
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(3, 336)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 25)
        Me.label5.TabIndex = 23
        Me.label5.Text = "Dönem:"
        '
        'cmbgelirturu
        '
        Me.cmbgelirturu.Enabled = False
        Me.cmbgelirturu.FormattingEnabled = True
        Me.cmbgelirturu.Items.AddRange(New Object() {"Veli Ödemesi"})
        Me.cmbgelirturu.Location = New System.Drawing.Point(171, 235)
        Me.cmbgelirturu.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbgelirturu.Name = "cmbgelirturu"
        Me.cmbgelirturu.Size = New System.Drawing.Size(189, 27)
        Me.cmbgelirturu.TabIndex = 22
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(3, 236)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(163, 25)
        Me.label4.TabIndex = 21
        Me.label4.Text = "Gelir/Gider Türü:"
        '
        'txttutar
        '
        Me.txttutar.Location = New System.Drawing.Point(171, 181)
        Me.txttutar.Margin = New System.Windows.Forms.Padding(4)
        Me.txttutar.Name = "txttutar"
        Me.txttutar.Size = New System.Drawing.Size(189, 26)
        Me.txttutar.TabIndex = 20
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(1, 182)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(65, 25)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Tutar:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(171, 128)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(189, 26)
        Me.dttarih.TabIndex = 18
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(-1, 129)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 25)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Tarih:"
        '
        'cmbgelir
        '
        Me.cmbgelir.Enabled = False
        Me.cmbgelir.FormattingEnabled = True
        Me.cmbgelir.Items.AddRange(New Object() {"Gelir"})
        Me.cmbgelir.Location = New System.Drawing.Point(171, 74)
        Me.cmbgelir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbgelir.Name = "cmbgelir"
        Me.cmbgelir.Size = New System.Drawing.Size(189, 27)
        Me.cmbgelir.TabIndex = 16
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(1, 76)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 25)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Gelir/Gider:"
        '
        'AnaokuludbDataSet14
        '
        Me.AnaokuludbDataSet14.DataSetName = "AnaokuludbDataSet14"
        Me.AnaokuludbDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VeliBindingSource
        '
        Me.VeliBindingSource.DataMember = "Veli"
        Me.VeliBindingSource.DataSource = Me.AnaokuludbDataSet14
        '
        'VeliTableAdapter
        '
        Me.VeliTableAdapter.ClearBeforeFill = True
        '
        'FrmAidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Olive
        Me.ClientSize = New System.Drawing.Size(1924, 667)
        Me.Controls.Add(Me.grpOgretmenAra)
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAidat"
        Me.Text = "Aidat"
        Me.grpOgretmenAra.ResumeLayout(False)
        Me.grpOgretmenAra.PerformLayout()
        CType(Me.dtgridaidat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.AnaokuludbDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgretmenAra As GroupBox
    Private WithEvents btntarihara As Button
    Private WithEvents txtveliara As TextBox
    Private WithEvents dttarihara As DateTimePicker
    Private WithEvents label17 As Label
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents dtgridaidat As DataGridView
    Private WithEvents label13 As Label
    Private WithEvents label14 As Label
    Private WithEvents btndonemara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnaidatsil As Button
    Private WithEvents cmbveli As ComboBox
    Private WithEvents btnaidatguncelle As Button
    Private WithEvents label15 As Label
    Private WithEvents btnaidatekle As Button
    Private WithEvents cmbodemeturu As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents label5 As Label
    Private WithEvents cmbgelirturu As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents txttutar As TextBox
    Private WithEvents label3 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label2 As Label
    Private WithEvents cmbgelir As ComboBox
    Private WithEvents label1 As Label
    Friend WithEvents AnaokuludbDataSet14 As AnaokuludbDataSet14
    Friend WithEvents VeliBindingSource As BindingSource
    Friend WithEvents VeliTableAdapter As AnaokuludbDataSet14TableAdapters.VeliTableAdapter
End Class

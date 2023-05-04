<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGelirGider
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGelirGider))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grpOgretmenAra = New System.Windows.Forms.GroupBox()
        Me.btndonemara = New System.Windows.Forms.Button()
        Me.dtcikistarih = New System.Windows.Forms.DateTimePicker()
        Me.label15 = New System.Windows.Forms.Label()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.dtgridgelirgider = New System.Windows.Forms.DataGridView()
        Me.label13 = New System.Windows.Forms.Label()
        Me.dtgiristarih = New System.Windows.Forms.DateTimePicker()
        Me.label14 = New System.Windows.Forms.Label()
        Me.btntarihara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btngelirgidersil = New System.Windows.Forms.Button()
        Me.btngiderguncelle = New System.Windows.Forms.Button()
        Me.btngiderekle = New System.Windows.Forms.Button()
        Me.cmbOdemeTuru = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cmbgiderturu = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtfiyat = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbgider = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grpOgretmenAra.SuspendLayout()
        CType(Me.dtgridgelirgider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOgretmenAra
        '
        Me.grpOgretmenAra.Controls.Add(Me.btndonemara)
        Me.grpOgretmenAra.Controls.Add(Me.dtcikistarih)
        Me.grpOgretmenAra.Controls.Add(Me.label15)
        Me.grpOgretmenAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgretmenAra.Controls.Add(Me.dtgridgelirgider)
        Me.grpOgretmenAra.Controls.Add(Me.label13)
        Me.grpOgretmenAra.Controls.Add(Me.dtgiristarih)
        Me.grpOgretmenAra.Controls.Add(Me.label14)
        Me.grpOgretmenAra.Controls.Add(Me.btntarihara)
        Me.grpOgretmenAra.Controls.Add(Me.btnyenile)
        Me.grpOgretmenAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenAra.Location = New System.Drawing.Point(607, 29)
        Me.grpOgretmenAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Name = "grpOgretmenAra"
        Me.grpOgretmenAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Size = New System.Drawing.Size(808, 375)
        Me.grpOgretmenAra.TabIndex = 11
        Me.grpOgretmenAra.TabStop = False
        Me.grpOgretmenAra.Text = "Gelir-Gider Ara"
        '
        'btndonemara
        '
        Me.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btndonemara.Image = CType(resources.GetObject("btndonemara.Image"), System.Drawing.Image)
        Me.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndonemara.Location = New System.Drawing.Point(297, 78)
        Me.btndonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.btndonemara.Name = "btndonemara"
        Me.btndonemara.Size = New System.Drawing.Size(119, 42)
        Me.btndonemara.TabIndex = 55
        Me.btndonemara.Text = "Ara"
        Me.btndonemara.UseVisualStyleBackColor = False
        '
        'dtcikistarih
        '
        Me.dtcikistarih.Location = New System.Drawing.Point(121, 49)
        Me.dtcikistarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dtcikistarih.Name = "dtcikistarih"
        Me.dtcikistarih.Size = New System.Drawing.Size(167, 26)
        Me.dtcikistarih.TabIndex = 54
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(7, 52)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(106, 25)
        Me.label15.TabIndex = 53
        Me.label15.Text = "Çıkış Tarih:"
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(121, 90)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(167, 27)
        Me.cmbdonemara.TabIndex = 52
        '
        'dtgridgelirgider
        '
        Me.dtgridgelirgider.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgridgelirgider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridgelirgider.Location = New System.Drawing.Point(8, 119)
        Me.dtgridgelirgider.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridgelirgider.Name = "dtgridgelirgider"
        Me.dtgridgelirgider.RowHeadersWidth = 51
        Me.dtgridgelirgider.Size = New System.Drawing.Size(792, 252)
        Me.dtgridgelirgider.TabIndex = 15
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(7, 90)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(82, 25)
        Me.label13.TabIndex = 51
        Me.label13.Text = "Dönem:"
        '
        'dtgiristarih
        '
        Me.dtgiristarih.Location = New System.Drawing.Point(121, 15)
        Me.dtgiristarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgiristarih.Name = "dtgiristarih"
        Me.dtgiristarih.Size = New System.Drawing.Size(167, 26)
        Me.dtgiristarih.TabIndex = 50
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(7, 17)
        Me.label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(105, 25)
        Me.label14.TabIndex = 49
        Me.label14.Text = "Giriş Tarih:"
        '
        'btntarihara
        '
        Me.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btntarihara.Image = CType(resources.GetObject("btntarihara.Image"), System.Drawing.Image)
        Me.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntarihara.Location = New System.Drawing.Point(296, 11)
        Me.btntarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.btntarihara.Name = "btntarihara"
        Me.btntarihara.Size = New System.Drawing.Size(119, 52)
        Me.btntarihara.TabIndex = 48
        Me.btntarihara.Text = "Ara"
        Me.btntarihara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(457, 49)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 42)
        Me.btnyenile.TabIndex = 47
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btngelirgidersil)
        Me.groupBox1.Controls.Add(Me.btngiderguncelle)
        Me.groupBox1.Controls.Add(Me.btngiderekle)
        Me.groupBox1.Controls.Add(Me.cmbOdemeTuru)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.cmbdonem)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.cmbgiderturu)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtfiyat)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.cmbgider)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupBox1.Location = New System.Drawing.Point(20, 29)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(559, 374)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Gider İşlemleri"
        '
        'btngelirgidersil
        '
        Me.btngelirgidersil.BackColor = System.Drawing.Color.IndianRed
        Me.btngelirgidersil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btngelirgidersil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngelirgidersil.Location = New System.Drawing.Point(395, 320)
        Me.btngelirgidersil.Margin = New System.Windows.Forms.Padding(4)
        Me.btngelirgidersil.Name = "btngelirgidersil"
        Me.btngelirgidersil.Size = New System.Drawing.Size(156, 52)
        Me.btngelirgidersil.TabIndex = 25
        Me.btngelirgidersil.Text = "SİL"
        Me.btngelirgidersil.UseVisualStyleBackColor = False
        '
        'btngiderguncelle
        '
        Me.btngiderguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btngiderguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btngiderguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngiderguncelle.Location = New System.Drawing.Point(205, 320)
        Me.btngiderguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btngiderguncelle.Name = "btngiderguncelle"
        Me.btngiderguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btngiderguncelle.TabIndex = 44
        Me.btngiderguncelle.Text = "Güncelle"
        Me.btngiderguncelle.UseVisualStyleBackColor = False
        '
        'btngiderekle
        '
        Me.btngiderekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btngiderekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btngiderekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngiderekle.Location = New System.Drawing.Point(24, 320)
        Me.btngiderekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btngiderekle.Name = "btngiderekle"
        Me.btngiderekle.Size = New System.Drawing.Size(156, 52)
        Me.btngiderekle.TabIndex = 27
        Me.btngiderekle.Text = "Ekle"
        Me.btngiderekle.UseVisualStyleBackColor = False
        '
        'cmbOdemeTuru
        '
        Me.cmbOdemeTuru.FormattingEnabled = True
        Me.cmbOdemeTuru.Items.AddRange(New Object() {"Kredi Kartı", "Nakit", "Havale", "EFT"})
        Me.cmbOdemeTuru.Location = New System.Drawing.Point(171, 230)
        Me.cmbOdemeTuru.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOdemeTuru.Name = "cmbOdemeTuru"
        Me.cmbOdemeTuru.Size = New System.Drawing.Size(189, 27)
        Me.cmbOdemeTuru.TabIndex = 26
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(-1, 231)
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
        Me.cmbdonem.Location = New System.Drawing.Point(171, 282)
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
        Me.label5.Location = New System.Drawing.Point(3, 283)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 25)
        Me.label5.TabIndex = 23
        Me.label5.Text = "Dönem:"
        '
        'cmbgiderturu
        '
        Me.cmbgiderturu.FormattingEnabled = True
        Me.cmbgiderturu.Items.AddRange(New Object() {"Kira Masrafları", "Kırtasiye Masrafları", "Elektrik-Su-Doğalgaz", "Personel Maaşları", "Mutfak Masrafları", "Oyuncak Masrafları", "Veli Ödemesi"})
        Me.cmbgiderturu.Location = New System.Drawing.Point(171, 182)
        Me.cmbgiderturu.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbgiderturu.Name = "cmbgiderturu"
        Me.cmbgiderturu.Size = New System.Drawing.Size(189, 27)
        Me.cmbgiderturu.TabIndex = 22
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(3, 183)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(113, 25)
        Me.label4.TabIndex = 21
        Me.label4.Text = "Gider Türü:"
        '
        'txtfiyat
        '
        Me.txtfiyat.Location = New System.Drawing.Point(171, 128)
        Me.txtfiyat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfiyat.Name = "txtfiyat"
        Me.txtfiyat.Size = New System.Drawing.Size(189, 26)
        Me.txtfiyat.TabIndex = 20
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(1, 129)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(65, 25)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Tutar:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(171, 75)
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
        Me.label2.Location = New System.Drawing.Point(3, 75)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 25)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Tarih:"
        '
        'cmbgider
        '
        Me.cmbgider.FormattingEnabled = True
        Me.cmbgider.Items.AddRange(New Object() {"Gider", "Gelir"})
        Me.cmbgider.Location = New System.Drawing.Point(171, 21)
        Me.cmbgider.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbgider.Name = "cmbgider"
        Me.cmbgider.Size = New System.Drawing.Size(189, 27)
        Me.cmbgider.TabIndex = 16
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(1, 23)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 25)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Gelir/Gider:"
        '
        'chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chart1.Legends.Add(Legend2)
        Me.chart1.Location = New System.Drawing.Point(58, 479)
        Me.chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.chart1.Name = "chart1"
        Me.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Gelir"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Gider"
        Me.chart1.Series.Add(Series3)
        Me.chart1.Series.Add(Series4)
        Me.chart1.Size = New System.Drawing.Size(1245, 225)
        Me.chart1.TabIndex = 13
        Me.chart1.Text = "Gelir-Gider"
        '
        'FrmGelirGider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 781)
        Me.Controls.Add(Me.chart1)
        Me.Controls.Add(Me.grpOgretmenAra)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGelirGider"
        Me.Text = "Gelir Gider"
        Me.grpOgretmenAra.ResumeLayout(False)
        Me.grpOgretmenAra.PerformLayout()
        CType(Me.dtgridgelirgider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgretmenAra As GroupBox
    Private WithEvents btndonemara As Button
    Private WithEvents dtcikistarih As DateTimePicker
    Private WithEvents label15 As Label
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents dtgridgelirgider As DataGridView
    Private WithEvents label13 As Label
    Private WithEvents dtgiristarih As DateTimePicker
    Private WithEvents label14 As Label
    Private WithEvents btntarihara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btngelirgidersil As Button
    Private WithEvents btngiderguncelle As Button
    Private WithEvents btngiderekle As Button
    Private WithEvents cmbOdemeTuru As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents label5 As Label
    Private WithEvents cmbgiderturu As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents txtfiyat As TextBox
    Private WithEvents label3 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label2 As Label
    Private WithEvents cmbgider As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents chart1 As DataVisualization.Charting.Chart
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYemekListesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmYemekListesi))
        Me.grpOgretmenAra = New System.Windows.Forms.GroupBox()
        Me.btndonemara = New System.Windows.Forms.Button()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btntarihara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.dttarihara = New System.Windows.Forms.DateTimePicker()
        Me.dtgridyemeklistesi = New System.Windows.Forms.DataGridView()
        Me.label23 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnyemeklistesisil = New System.Windows.Forms.Button()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnYemekListesiGuncelle = New System.Windows.Forms.Button()
        Me.btnYemekListesiEkle = New System.Windows.Forms.Button()
        Me.rchikindi = New System.Windows.Forms.RichTextBox()
        Me.rchogle = New System.Windows.Forms.RichTextBox()
        Me.rchsabah = New System.Windows.Forms.RichTextBox()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.grpOgretmenAra.SuspendLayout()
        CType(Me.dtgridyemeklistesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOgretmenAra
        '
        Me.grpOgretmenAra.Controls.Add(Me.btndonemara)
        Me.grpOgretmenAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgretmenAra.Controls.Add(Me.label11)
        Me.grpOgretmenAra.Controls.Add(Me.btntarihara)
        Me.grpOgretmenAra.Controls.Add(Me.btnyenile)
        Me.grpOgretmenAra.Controls.Add(Me.dttarihara)
        Me.grpOgretmenAra.Controls.Add(Me.dtgridyemeklistesi)
        Me.grpOgretmenAra.Controls.Add(Me.label23)
        Me.grpOgretmenAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenAra.Location = New System.Drawing.Point(585, 34)
        Me.grpOgretmenAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Name = "grpOgretmenAra"
        Me.grpOgretmenAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Size = New System.Drawing.Size(823, 603)
        Me.grpOgretmenAra.TabIndex = 10
        Me.grpOgretmenAra.TabStop = False
        Me.grpOgretmenAra.Text = "Yemek Listesi Ara"
        '
        'btndonemara
        '
        Me.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btndonemara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndonemara.Location = New System.Drawing.Point(277, 70)
        Me.btndonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.btndonemara.Name = "btndonemara"
        Me.btndonemara.Size = New System.Drawing.Size(165, 34)
        Me.btndonemara.TabIndex = 41
        Me.btndonemara.Text = "Ara"
        Me.btndonemara.UseVisualStyleBackColor = False
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(81, 74)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(172, 27)
        Me.cmbdonemara.TabIndex = 40
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(-7, 75)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(82, 25)
        Me.label11.TabIndex = 39
        Me.label11.Text = "Dönem:"
        '
        'btntarihara
        '
        Me.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btntarihara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntarihara.Location = New System.Drawing.Point(277, 26)
        Me.btntarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.btntarihara.Name = "btntarihara"
        Me.btntarihara.Size = New System.Drawing.Size(165, 37)
        Me.btntarihara.TabIndex = 34
        Me.btntarihara.Text = "Ara"
        Me.btntarihara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(472, 43)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(149, 52)
        Me.btnyenile.TabIndex = 28
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'dttarihara
        '
        Me.dttarihara.Location = New System.Drawing.Point(81, 32)
        Me.dttarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarihara.Name = "dttarihara"
        Me.dttarihara.Size = New System.Drawing.Size(172, 26)
        Me.dttarihara.TabIndex = 18
        '
        'dtgridyemeklistesi
        '
        Me.dtgridyemeklistesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridyemeklistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridyemeklistesi.Location = New System.Drawing.Point(7, 143)
        Me.dtgridyemeklistesi.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridyemeklistesi.Name = "dtgridyemeklistesi"
        Me.dtgridyemeklistesi.RowHeadersWidth = 51
        Me.dtgridyemeklistesi.Size = New System.Drawing.Size(807, 434)
        Me.dtgridyemeklistesi.TabIndex = 15
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(-5, 32)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(60, 25)
        Me.label23.TabIndex = 13
        Me.label23.Text = "Tarih:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnyemeklistesisil)
        Me.groupBox1.Controls.Add(Me.cmbdonem)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.btnYemekListesiGuncelle)
        Me.groupBox1.Controls.Add(Me.btnYemekListesiEkle)
        Me.groupBox1.Controls.Add(Me.rchikindi)
        Me.groupBox1.Controls.Add(Me.rchogle)
        Me.groupBox1.Controls.Add(Me.rchsabah)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(9, 30)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(533, 607)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Yemek Listesi İşlemleri"
        '
        'btnyemeklistesisil
        '
        Me.btnyemeklistesisil.BackColor = System.Drawing.Color.IndianRed
        Me.btnyemeklistesisil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnyemeklistesisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyemeklistesisil.Location = New System.Drawing.Point(369, 513)
        Me.btnyemeklistesisil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyemeklistesisil.Name = "btnyemeklistesisil"
        Me.btnyemeklistesisil.Size = New System.Drawing.Size(156, 52)
        Me.btnyemeklistesisil.TabIndex = 25
        Me.btnyemeklistesisil.Text = "SİL"
        Me.btnyemeklistesisil.UseVisualStyleBackColor = False
        '
        'cmbdonem
        '
        Me.cmbdonem.FormattingEnabled = True
        Me.cmbdonem.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonem.Location = New System.Drawing.Point(167, 22)
        Me.cmbdonem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonem.Name = "cmbdonem"
        Me.cmbdonem.Size = New System.Drawing.Size(212, 27)
        Me.cmbdonem.TabIndex = 38
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(8, 23)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(82, 25)
        Me.label9.TabIndex = 37
        Me.label9.Text = "Dönem:"
        '
        'btnYemekListesiGuncelle
        '
        Me.btnYemekListesiGuncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnYemekListesiGuncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnYemekListesiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYemekListesiGuncelle.Location = New System.Drawing.Point(193, 513)
        Me.btnYemekListesiGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYemekListesiGuncelle.Name = "btnYemekListesiGuncelle"
        Me.btnYemekListesiGuncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnYemekListesiGuncelle.TabIndex = 25
        Me.btnYemekListesiGuncelle.Text = "Güncelle"
        Me.btnYemekListesiGuncelle.UseVisualStyleBackColor = False
        '
        'btnYemekListesiEkle
        '
        Me.btnYemekListesiEkle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnYemekListesiEkle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnYemekListesiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYemekListesiEkle.Location = New System.Drawing.Point(13, 513)
        Me.btnYemekListesiEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYemekListesiEkle.Name = "btnYemekListesiEkle"
        Me.btnYemekListesiEkle.Size = New System.Drawing.Size(156, 52)
        Me.btnYemekListesiEkle.TabIndex = 24
        Me.btnYemekListesiEkle.Text = "Ekle"
        Me.btnYemekListesiEkle.UseVisualStyleBackColor = False
        '
        'rchikindi
        '
        Me.rchikindi.Location = New System.Drawing.Point(181, 364)
        Me.rchikindi.Margin = New System.Windows.Forms.Padding(4)
        Me.rchikindi.Name = "rchikindi"
        Me.rchikindi.Size = New System.Drawing.Size(197, 96)
        Me.rchikindi.TabIndex = 20
        Me.rchikindi.Text = ""
        '
        'rchogle
        '
        Me.rchogle.Location = New System.Drawing.Point(181, 242)
        Me.rchogle.Margin = New System.Windows.Forms.Padding(4)
        Me.rchogle.Name = "rchogle"
        Me.rchogle.Size = New System.Drawing.Size(197, 96)
        Me.rchogle.TabIndex = 19
        Me.rchogle.Text = ""
        '
        'rchsabah
        '
        Me.rchsabah.Location = New System.Drawing.Point(181, 118)
        Me.rchsabah.Margin = New System.Windows.Forms.Padding(4)
        Me.rchsabah.Name = "rchsabah"
        Me.rchsabah.Size = New System.Drawing.Size(197, 96)
        Me.rchsabah.TabIndex = 18
        Me.rchsabah.Text = ""
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(169, 71)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(209, 26)
        Me.dttarih.TabIndex = 17
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(13, 74)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 25)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Tarih:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(13, 116)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 25)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Sabah:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(-1, 364)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 25)
        Me.label3.TabIndex = 17
        Me.label3.Text = "İkindi:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(8, 249)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 25)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Öğle:"
        '
        'FrmYemekListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(1597, 667)
        Me.Controls.Add(Me.grpOgretmenAra)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmYemekListesi"
        Me.Text = "Yemek Listesi"
        Me.grpOgretmenAra.ResumeLayout(False)
        Me.grpOgretmenAra.PerformLayout()
        CType(Me.dtgridyemeklistesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgretmenAra As GroupBox
    Private WithEvents btndonemara As Button
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents label11 As Label
    Private WithEvents btntarihara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents dttarihara As DateTimePicker
    Private WithEvents dtgridyemeklistesi As DataGridView
    Private WithEvents label23 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnyemeklistesisil As Button
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents label9 As Label
    Private WithEvents btnYemekListesiGuncelle As Button
    Private WithEvents btnYemekListesiEkle As Button
    Private WithEvents rchikindi As RichTextBox
    Private WithEvents rchogle As RichTextBox
    Private WithEvents rchsabah As RichTextBox
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
End Class

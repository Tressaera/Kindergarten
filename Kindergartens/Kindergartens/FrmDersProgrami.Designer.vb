<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDersProgrami
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDersProgrami))
        Me.grpOgretmenAra = New System.Windows.Forms.GroupBox()
        Me.btndonemara = New System.Windows.Forms.Button()
        Me.dtTarihara = New System.Windows.Forms.DateTimePicker()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.btntarihara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.dtgridDersprogrami = New System.Windows.Forms.DataGridView()
        Me.label23 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndersprogramiSil = New System.Windows.Forms.Button()
        Me.cmbders6 = New System.Windows.Forms.ComboBox()
        Me.btnDersProgramiGuncelle = New System.Windows.Forms.Button()
        Me.label16 = New System.Windows.Forms.Label()
        Me.cmbders5 = New System.Windows.Forms.ComboBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.cmbders4 = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cmbders3 = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cmbders2 = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.btnDersprogramiEkle = New System.Windows.Forms.Button()
        Me.cmbders1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label5 = New System.Windows.Forms.Label()
        Me.grpOgretmenAra.SuspendLayout()
        CType(Me.dtgridDersprogrami, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOgretmenAra
        '
        Me.grpOgretmenAra.Controls.Add(Me.btndonemara)
        Me.grpOgretmenAra.Controls.Add(Me.dtTarihara)
        Me.grpOgretmenAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgretmenAra.Controls.Add(Me.label13)
        Me.grpOgretmenAra.Controls.Add(Me.btntarihara)
        Me.grpOgretmenAra.Controls.Add(Me.btnyenile)
        Me.grpOgretmenAra.Controls.Add(Me.dtgridDersprogrami)
        Me.grpOgretmenAra.Controls.Add(Me.label23)
        Me.grpOgretmenAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenAra.Location = New System.Drawing.Point(610, 17)
        Me.grpOgretmenAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Name = "grpOgretmenAra"
        Me.grpOgretmenAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Size = New System.Drawing.Size(820, 503)
        Me.grpOgretmenAra.TabIndex = 9
        Me.grpOgretmenAra.TabStop = False
        Me.grpOgretmenAra.Text = "Ders Programı Ara"
        '
        'btndonemara
        '
        Me.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btndonemara.Image = CType(resources.GetObject("btndonemara.Image"), System.Drawing.Image)
        Me.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndonemara.Location = New System.Drawing.Point(349, 63)
        Me.btndonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.btndonemara.Name = "btndonemara"
        Me.btndonemara.Size = New System.Drawing.Size(140, 41)
        Me.btndonemara.TabIndex = 42
        Me.btndonemara.Text = "Ara"
        Me.btndonemara.UseVisualStyleBackColor = False
        '
        'dtTarihara
        '
        Me.dtTarihara.CustomFormat = ""
        Me.dtTarihara.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTarihara.Location = New System.Drawing.Point(100, 27)
        Me.dtTarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.dtTarihara.Name = "dtTarihara"
        Me.dtTarihara.Size = New System.Drawing.Size(240, 26)
        Me.dtTarihara.TabIndex = 41
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(100, 71)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(240, 27)
        Me.cmbdonemara.TabIndex = 40
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(4, 73)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(82, 25)
        Me.label13.TabIndex = 39
        Me.label13.Text = "Dönem:"
        '
        'btntarihara
        '
        Me.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btntarihara.Image = CType(resources.GetObject("btntarihara.Image"), System.Drawing.Image)
        Me.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntarihara.Location = New System.Drawing.Point(349, 16)
        Me.btntarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.btntarihara.Name = "btntarihara"
        Me.btntarihara.Size = New System.Drawing.Size(140, 41)
        Me.btntarihara.TabIndex = 34
        Me.btntarihara.Text = "Ara"
        Me.btntarihara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(522, 32)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(157, 52)
        Me.btnyenile.TabIndex = 28
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'dtgridDersprogrami
        '
        Me.dtgridDersprogrami.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridDersprogrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridDersprogrami.Location = New System.Drawing.Point(0, 111)
        Me.dtgridDersprogrami.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridDersprogrami.Name = "dtgridDersprogrami"
        Me.dtgridDersprogrami.RowHeadersWidth = 51
        Me.dtgridDersprogrami.Size = New System.Drawing.Size(812, 385)
        Me.dtgridDersprogrami.TabIndex = 15
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(3, 32)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(60, 25)
        Me.label23.TabIndex = 13
        Me.label23.Text = "Tarih:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btndersprogramiSil)
        Me.groupBox1.Controls.Add(Me.cmbders6)
        Me.groupBox1.Controls.Add(Me.btnDersProgramiGuncelle)
        Me.groupBox1.Controls.Add(Me.label16)
        Me.groupBox1.Controls.Add(Me.cmbders5)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.cmbders4)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.cmbders3)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.cmbders2)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.cmbdonem)
        Me.groupBox1.Controls.Add(Me.label15)
        Me.groupBox1.Controls.Add(Me.btnDersprogramiEkle)
        Me.groupBox1.Controls.Add(Me.cmbders1)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 13)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(521, 507)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Ders Programi İşlemleri"
        '
        'btndersprogramiSil
        '
        Me.btndersprogramiSil.BackColor = System.Drawing.Color.IndianRed
        Me.btndersprogramiSil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btndersprogramiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndersprogramiSil.Location = New System.Drawing.Point(351, 437)
        Me.btndersprogramiSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btndersprogramiSil.Name = "btndersprogramiSil"
        Me.btndersprogramiSil.Size = New System.Drawing.Size(156, 52)
        Me.btndersprogramiSil.TabIndex = 25
        Me.btndersprogramiSil.Text = "SİL"
        Me.btndersprogramiSil.UseVisualStyleBackColor = False
        '
        'cmbders6
        '
        Me.cmbders6.FormattingEnabled = True
        Me.cmbders6.Location = New System.Drawing.Point(97, 363)
        Me.cmbders6.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbders6.Name = "cmbders6"
        Me.cmbders6.Size = New System.Drawing.Size(235, 27)
        Me.cmbders6.TabIndex = 66
        '
        'btnDersProgramiGuncelle
        '
        Me.btnDersProgramiGuncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnDersProgramiGuncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnDersProgramiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDersProgramiGuncelle.Location = New System.Drawing.Point(177, 437)
        Me.btnDersProgramiGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDersProgramiGuncelle.Name = "btnDersProgramiGuncelle"
        Me.btnDersProgramiGuncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnDersProgramiGuncelle.TabIndex = 43
        Me.btnDersProgramiGuncelle.Text = "Güncelle"
        Me.btnDersProgramiGuncelle.UseVisualStyleBackColor = False
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label16.ForeColor = System.Drawing.Color.White
        Me.label16.Location = New System.Drawing.Point(-5, 361)
        Me.label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(80, 25)
        Me.label16.TabIndex = 65
        Me.label16.Text = "6.DERS:"
        '
        'cmbders5
        '
        Me.cmbders5.FormattingEnabled = True
        Me.cmbders5.Location = New System.Drawing.Point(97, 318)
        Me.cmbders5.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbders5.Name = "cmbders5"
        Me.cmbders5.Size = New System.Drawing.Size(235, 27)
        Me.cmbders5.TabIndex = 63
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(-5, 315)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(80, 25)
        Me.label11.TabIndex = 62
        Me.label11.Text = "5.DERS:"
        '
        'cmbders4
        '
        Me.cmbders4.FormattingEnabled = True
        Me.cmbders4.Location = New System.Drawing.Point(97, 265)
        Me.cmbders4.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbders4.Name = "cmbders4"
        Me.cmbders4.Size = New System.Drawing.Size(235, 27)
        Me.cmbders4.TabIndex = 60
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(-5, 262)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(80, 25)
        Me.label9.TabIndex = 59
        Me.label9.Text = "4.DERS:"
        '
        'cmbders3
        '
        Me.cmbders3.FormattingEnabled = True
        Me.cmbders3.Location = New System.Drawing.Point(97, 222)
        Me.cmbders3.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbders3.Name = "cmbders3"
        Me.cmbders3.Size = New System.Drawing.Size(235, 27)
        Me.cmbders3.TabIndex = 57
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(-5, 219)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 25)
        Me.label3.TabIndex = 56
        Me.label3.Text = "3.DERS:"
        '
        'cmbders2
        '
        Me.cmbders2.FormattingEnabled = True
        Me.cmbders2.Location = New System.Drawing.Point(97, 178)
        Me.cmbders2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbders2.Name = "cmbders2"
        Me.cmbders2.Size = New System.Drawing.Size(235, 27)
        Me.cmbders2.TabIndex = 54
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(-5, 176)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 25)
        Me.label2.TabIndex = 53
        Me.label2.Text = "2.DERS:"
        '
        'cmbdonem
        '
        Me.cmbdonem.FormattingEnabled = True
        Me.cmbdonem.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonem.Location = New System.Drawing.Point(76, 78)
        Me.cmbdonem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonem.Name = "cmbdonem"
        Me.cmbdonem.Size = New System.Drawing.Size(265, 27)
        Me.cmbdonem.TabIndex = 51
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(-5, 78)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(82, 25)
        Me.label15.TabIndex = 50
        Me.label15.Text = "Dönem:"
        '
        'btnDersprogramiEkle
        '
        Me.btnDersprogramiEkle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnDersprogramiEkle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnDersprogramiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDersprogramiEkle.Location = New System.Drawing.Point(11, 437)
        Me.btnDersprogramiEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDersprogramiEkle.Name = "btnDersprogramiEkle"
        Me.btnDersprogramiEkle.Size = New System.Drawing.Size(156, 52)
        Me.btnDersprogramiEkle.TabIndex = 26
        Me.btnDersprogramiEkle.Text = "Ekle"
        Me.btnDersprogramiEkle.UseVisualStyleBackColor = False
        '
        'cmbders1
        '
        Me.cmbders1.FormattingEnabled = True
        Me.cmbders1.Location = New System.Drawing.Point(97, 134)
        Me.cmbders1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbders1.Name = "cmbders1"
        Me.cmbders1.Size = New System.Drawing.Size(235, 27)
        Me.cmbders1.TabIndex = 40
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(-5, 132)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 25)
        Me.label1.TabIndex = 37
        Me.label1.Text = "1.DERS:"
        '
        'dttarih
        '
        Me.dttarih.CustomFormat = "d/M/yyyy"
        Me.dttarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttarih.Location = New System.Drawing.Point(76, 26)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(265, 26)
        Me.dttarih.TabIndex = 36
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(-5, 26)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 25)
        Me.label5.TabIndex = 35
        Me.label5.Text = "Tarih:"
        '
        'FrmDersProgrami
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(1924, 667)
        Me.Controls.Add(Me.grpOgretmenAra)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDersProgrami"
        Me.Text = "Ders Programı"
        Me.grpOgretmenAra.ResumeLayout(False)
        Me.grpOgretmenAra.PerformLayout()
        CType(Me.dtgridDersprogrami, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgretmenAra As GroupBox
    Private WithEvents btndonemara As Button
    Private WithEvents dtTarihara As DateTimePicker
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents label13 As Label
    Private WithEvents btntarihara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents dtgridDersprogrami As DataGridView
    Private WithEvents label23 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btndersprogramiSil As Button
    Public WithEvents cmbders6 As ComboBox
    Private WithEvents btnDersProgramiGuncelle As Button
    Private WithEvents label16 As Label
    Public WithEvents cmbders5 As ComboBox
    Private WithEvents label11 As Label
    Public WithEvents cmbders4 As ComboBox
    Private WithEvents label9 As Label
    Public WithEvents cmbders3 As ComboBox
    Private WithEvents label3 As Label
    Public WithEvents cmbders2 As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents label15 As Label
    Private WithEvents btnDersprogramiEkle As Button
    Public WithEvents cmbders1 As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label5 As Label
End Class

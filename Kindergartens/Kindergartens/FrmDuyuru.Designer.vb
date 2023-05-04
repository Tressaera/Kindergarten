<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDuyuru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDuyuru))
        Me.grpOgretmenAra = New System.Windows.Forms.GroupBox()
        Me.btndonemara = New System.Windows.Forms.Button()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.dttarihara = New System.Windows.Forms.DateTimePicker()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnTarihara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.dtgridduyurulistele = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnduyurusil = New System.Windows.Forms.Button()
        Me.btnduyuruguncelle = New System.Windows.Forms.Button()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnduyuruekle = New System.Windows.Forms.Button()
        Me.rchicerik = New System.Windows.Forms.RichTextBox()
        Me.txtbaslik = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.grpOgretmenAra.SuspendLayout()
        CType(Me.dtgridduyurulistele, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOgretmenAra
        '
        Me.grpOgretmenAra.Controls.Add(Me.btndonemara)
        Me.grpOgretmenAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgretmenAra.Controls.Add(Me.label10)
        Me.grpOgretmenAra.Controls.Add(Me.dttarihara)
        Me.grpOgretmenAra.Controls.Add(Me.label8)
        Me.grpOgretmenAra.Controls.Add(Me.btnTarihara)
        Me.grpOgretmenAra.Controls.Add(Me.btnyenile)
        Me.grpOgretmenAra.Controls.Add(Me.dtgridduyurulistele)
        Me.grpOgretmenAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenAra.Location = New System.Drawing.Point(535, 20)
        Me.grpOgretmenAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Name = "grpOgretmenAra"
        Me.grpOgretmenAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Size = New System.Drawing.Size(779, 565)
        Me.grpOgretmenAra.TabIndex = 9
        Me.grpOgretmenAra.TabStop = False
        Me.grpOgretmenAra.Text = "Duyuru Ara"
        '
        'btndonemara
        '
        Me.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btndonemara.Image = CType(resources.GetObject("btndonemara.Image"), System.Drawing.Image)
        Me.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndonemara.Location = New System.Drawing.Point(367, 55)
        Me.btndonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.btndonemara.Name = "btndonemara"
        Me.btndonemara.Size = New System.Drawing.Size(119, 37)
        Me.btndonemara.TabIndex = 47
        Me.btndonemara.Text = "Ara"
        Me.btndonemara.UseVisualStyleBackColor = False
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(89, 63)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(265, 27)
        Me.cmbdonemara.TabIndex = 46
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(8, 63)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(82, 25)
        Me.label10.TabIndex = 45
        Me.label10.Text = "Dönem:"
        '
        'dttarihara
        '
        Me.dttarihara.Location = New System.Drawing.Point(89, 23)
        Me.dttarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarihara.Name = "dttarihara"
        Me.dttarihara.Size = New System.Drawing.Size(265, 26)
        Me.dttarihara.TabIndex = 41
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(8, 23)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(60, 25)
        Me.label8.TabIndex = 40
        Me.label8.Text = "Tarih:"
        '
        'btnTarihara
        '
        Me.btnTarihara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnTarihara.Image = CType(resources.GetObject("btnTarihara.Image"), System.Drawing.Image)
        Me.btnTarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTarihara.Location = New System.Drawing.Point(367, 15)
        Me.btnTarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTarihara.Name = "btnTarihara"
        Me.btnTarihara.Size = New System.Drawing.Size(119, 37)
        Me.btnTarihara.TabIndex = 39
        Me.btnTarihara.Text = "Ara"
        Me.btnTarihara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(499, 22)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 38
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'dtgridduyurulistele
        '
        Me.dtgridduyurulistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridduyurulistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridduyurulistele.Location = New System.Drawing.Point(0, 98)
        Me.dtgridduyurulistele.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridduyurulistele.Name = "dtgridduyurulistele"
        Me.dtgridduyurulistele.RowHeadersWidth = 51
        Me.dtgridduyurulistele.Size = New System.Drawing.Size(756, 459)
        Me.dtgridduyurulistele.TabIndex = 15
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnduyurusil)
        Me.groupBox1.Controls.Add(Me.btnduyuruguncelle)
        Me.groupBox1.Controls.Add(Me.cmbdonem)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.btnduyuruekle)
        Me.groupBox1.Controls.Add(Me.rchicerik)
        Me.groupBox1.Controls.Add(Me.txtbaslik)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(20, 20)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(507, 587)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Duyuru İşlemleri"
        '
        'btnduyurusil
        '
        Me.btnduyurusil.BackColor = System.Drawing.Color.IndianRed
        Me.btnduyurusil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnduyurusil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnduyurusil.Location = New System.Drawing.Point(343, 513)
        Me.btnduyurusil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnduyurusil.Name = "btnduyurusil"
        Me.btnduyurusil.Size = New System.Drawing.Size(156, 52)
        Me.btnduyurusil.TabIndex = 26
        Me.btnduyurusil.Text = "SİL"
        Me.btnduyurusil.UseVisualStyleBackColor = False
        '
        'btnduyuruguncelle
        '
        Me.btnduyuruguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnduyuruguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnduyuruguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnduyuruguncelle.Location = New System.Drawing.Point(177, 513)
        Me.btnduyuruguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnduyuruguncelle.Name = "btnduyuruguncelle"
        Me.btnduyuruguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnduyuruguncelle.TabIndex = 25
        Me.btnduyuruguncelle.Text = "Güncelle"
        Me.btnduyuruguncelle.UseVisualStyleBackColor = False
        '
        'cmbdonem
        '
        Me.cmbdonem.FormattingEnabled = True
        Me.cmbdonem.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonem.Location = New System.Drawing.Point(143, 128)
        Me.cmbdonem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonem.Name = "cmbdonem"
        Me.cmbdonem.Size = New System.Drawing.Size(252, 27)
        Me.cmbdonem.TabIndex = 42
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(143, 76)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(252, 26)
        Me.dttarih.TabIndex = 38
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(8, 128)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(82, 25)
        Me.label11.TabIndex = 41
        Me.label11.Text = "Dönem:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(8, 79)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(60, 25)
        Me.label6.TabIndex = 37
        Me.label6.Text = "Tarih:"
        '
        'btnduyuruekle
        '
        Me.btnduyuruekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnduyuruekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnduyuruekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnduyuruekle.Location = New System.Drawing.Point(13, 513)
        Me.btnduyuruekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnduyuruekle.Name = "btnduyuruekle"
        Me.btnduyuruekle.Size = New System.Drawing.Size(156, 52)
        Me.btnduyuruekle.TabIndex = 24
        Me.btnduyuruekle.Text = "Ekle"
        Me.btnduyuruekle.UseVisualStyleBackColor = False
        '
        'rchicerik
        '
        Me.rchicerik.Location = New System.Drawing.Point(143, 164)
        Me.rchicerik.Margin = New System.Windows.Forms.Padding(4)
        Me.rchicerik.Name = "rchicerik"
        Me.rchicerik.Size = New System.Drawing.Size(243, 329)
        Me.rchicerik.TabIndex = 19
        Me.rchicerik.Text = ""
        '
        'txtbaslik
        '
        Me.txtbaslik.Location = New System.Drawing.Point(143, 22)
        Me.txtbaslik.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbaslik.Name = "txtbaslik"
        Me.txtbaslik.Size = New System.Drawing.Size(252, 26)
        Me.txtbaslik.TabIndex = 18
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(-5, 164)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(145, 25)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Duyuru İçeriği:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(-5, 22)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(147, 25)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Duyuru Başlığı:"
        '
        'FrmDuyuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.grpOgretmenAra)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDuyuru"
        Me.Text = "Duyuru"
        Me.grpOgretmenAra.ResumeLayout(False)
        Me.grpOgretmenAra.PerformLayout()
        CType(Me.dtgridduyurulistele, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgretmenAra As GroupBox
    Private WithEvents btndonemara As Button
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents label10 As Label
    Private WithEvents dttarihara As DateTimePicker
    Private WithEvents label8 As Label
    Private WithEvents btnTarihara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents dtgridduyurulistele As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnduyurusil As Button
    Private WithEvents btnduyuruguncelle As Button
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label11 As Label
    Private WithEvents label6 As Label
    Private WithEvents btnduyuruekle As Button
    Private WithEvents rchicerik As RichTextBox
    Private WithEvents txtbaslik As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class

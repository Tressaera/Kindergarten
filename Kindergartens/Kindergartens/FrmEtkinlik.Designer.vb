<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtkinlik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEtkinlik))
        Me.grpOgretmenAra = New System.Windows.Forms.GroupBox()
        Me.btndonemara = New System.Windows.Forms.Button()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.dttarihara = New System.Windows.Forms.DateTimePicker()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btntarihara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.dtgridetkinliklistele = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEtkinlikSil = New System.Windows.Forms.Button()
        Me.btnetkinlikguncelle = New System.Windows.Forms.Button()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnetkinlikekle = New System.Windows.Forms.Button()
        Me.rchbilgi = New System.Windows.Forms.RichTextBox()
        Me.txtbaslik = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.grpOgretmenAra.SuspendLayout()
        CType(Me.dtgridetkinliklistele, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpOgretmenAra.Controls.Add(Me.btntarihara)
        Me.grpOgretmenAra.Controls.Add(Me.btnyenile)
        Me.grpOgretmenAra.Controls.Add(Me.dtgridetkinliklistele)
        Me.grpOgretmenAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenAra.Location = New System.Drawing.Point(546, 21)
        Me.grpOgretmenAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Name = "grpOgretmenAra"
        Me.grpOgretmenAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Size = New System.Drawing.Size(759, 554)
        Me.grpOgretmenAra.TabIndex = 10
        Me.grpOgretmenAra.TabStop = False
        Me.grpOgretmenAra.Text = "Etkinlik Ara"
        '
        'btndonemara
        '
        Me.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btndonemara.Image = CType(resources.GetObject("btndonemara.Image"), System.Drawing.Image)
        Me.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndonemara.Location = New System.Drawing.Point(371, 70)
        Me.btndonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.btndonemara.Name = "btndonemara"
        Me.btndonemara.Size = New System.Drawing.Size(119, 33)
        Me.btndonemara.TabIndex = 53
        Me.btndonemara.Text = "Ara"
        Me.btndonemara.UseVisualStyleBackColor = False
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(88, 70)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(265, 27)
        Me.cmbdonemara.TabIndex = 52
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(7, 70)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(82, 25)
        Me.label10.TabIndex = 51
        Me.label10.Text = "Dönem:"
        '
        'dttarihara
        '
        Me.dttarihara.Location = New System.Drawing.Point(88, 17)
        Me.dttarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarihara.Name = "dttarihara"
        Me.dttarihara.Size = New System.Drawing.Size(265, 26)
        Me.dttarihara.TabIndex = 50
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(7, 17)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(60, 25)
        Me.label8.TabIndex = 49
        Me.label8.Text = "Tarih:"
        '
        'btntarihara
        '
        Me.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btntarihara.Image = CType(resources.GetObject("btntarihara.Image"), System.Drawing.Image)
        Me.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntarihara.Location = New System.Drawing.Point(371, 16)
        Me.btntarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.btntarihara.Name = "btntarihara"
        Me.btntarihara.Size = New System.Drawing.Size(119, 33)
        Me.btntarihara.TabIndex = 48
        Me.btntarihara.Text = "Ara"
        Me.btntarihara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(524, 37)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 41)
        Me.btnyenile.TabIndex = 47
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'dtgridetkinliklistele
        '
        Me.dtgridetkinliklistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridetkinliklistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridetkinliklistele.Location = New System.Drawing.Point(8, 117)
        Me.dtgridetkinliklistele.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridetkinliklistele.Name = "dtgridetkinliklistele"
        Me.dtgridetkinliklistele.RowHeadersWidth = 51
        Me.dtgridetkinliklistele.Size = New System.Drawing.Size(743, 430)
        Me.dtgridetkinliklistele.TabIndex = 15
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnEtkinlikSil)
        Me.groupBox1.Controls.Add(Me.btnetkinlikguncelle)
        Me.groupBox1.Controls.Add(Me.cmbdonem)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.btnetkinlikekle)
        Me.groupBox1.Controls.Add(Me.rchbilgi)
        Me.groupBox1.Controls.Add(Me.txtbaslik)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(9, 10)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(529, 587)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Etkinlik İşlemleri"
        '
        'btnEtkinlikSil
        '
        Me.btnEtkinlikSil.BackColor = System.Drawing.Color.IndianRed
        Me.btnEtkinlikSil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnEtkinlikSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEtkinlikSil.Location = New System.Drawing.Point(365, 513)
        Me.btnEtkinlikSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEtkinlikSil.Name = "btnEtkinlikSil"
        Me.btnEtkinlikSil.Size = New System.Drawing.Size(156, 52)
        Me.btnEtkinlikSil.TabIndex = 25
        Me.btnEtkinlikSil.Text = "SİL"
        Me.btnEtkinlikSil.UseVisualStyleBackColor = False
        '
        'btnetkinlikguncelle
        '
        Me.btnetkinlikguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnetkinlikguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnetkinlikguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnetkinlikguncelle.Location = New System.Drawing.Point(185, 513)
        Me.btnetkinlikguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnetkinlikguncelle.Name = "btnetkinlikguncelle"
        Me.btnetkinlikguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnetkinlikguncelle.TabIndex = 43
        Me.btnetkinlikguncelle.Text = "Güncelle"
        Me.btnetkinlikguncelle.UseVisualStyleBackColor = False
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
        'btnetkinlikekle
        '
        Me.btnetkinlikekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnetkinlikekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnetkinlikekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnetkinlikekle.Location = New System.Drawing.Point(8, 513)
        Me.btnetkinlikekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnetkinlikekle.Name = "btnetkinlikekle"
        Me.btnetkinlikekle.Size = New System.Drawing.Size(156, 52)
        Me.btnetkinlikekle.TabIndex = 24
        Me.btnetkinlikekle.Text = "Ekle"
        Me.btnetkinlikekle.UseVisualStyleBackColor = False
        '
        'rchbilgi
        '
        Me.rchbilgi.Location = New System.Drawing.Point(143, 161)
        Me.rchbilgi.Margin = New System.Windows.Forms.Padding(4)
        Me.rchbilgi.Name = "rchbilgi"
        Me.rchbilgi.Size = New System.Drawing.Size(252, 329)
        Me.rchbilgi.TabIndex = 19
        Me.rchbilgi.Text = ""
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
        Me.label2.Size = New System.Drawing.Size(127, 25)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Etkinlik Bilgi:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(-5, 22)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(145, 25)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Etkinlik Başlığı:"
        '
        'FrmEtkinlik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.grpOgretmenAra)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEtkinlik"
        Me.Text = "Etkinlik"
        Me.grpOgretmenAra.ResumeLayout(False)
        Me.grpOgretmenAra.PerformLayout()
        CType(Me.dtgridetkinliklistele, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents btntarihara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents dtgridetkinliklistele As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnEtkinlikSil As Button
    Private WithEvents btnetkinlikguncelle As Button
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label11 As Label
    Private WithEvents label6 As Label
    Private WithEvents btnetkinlikekle As Button
    Private WithEvents rchbilgi As RichTextBox
    Private WithEvents txtbaslik As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class

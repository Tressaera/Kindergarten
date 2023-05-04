<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmenİlacBildirimi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenİlacBildirimi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnİlacbildirimiSil = New System.Windows.Forms.Button()
        Me.btnilacbildirimguncelle = New System.Windows.Forms.Button()
        Me.btnilacbildirimiekle = New System.Windows.Forms.Button()
        Me.cmbadsoyad = New System.Windows.Forms.ComboBox()
        Me.cmbilacictimi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtgridİlacBildirimi = New System.Windows.Forms.DataGridView()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dttarihara = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgridİlacBildirimi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnİlacbildirimiSil)
        Me.GroupBox1.Controls.Add(Me.btnilacbildirimguncelle)
        Me.GroupBox1.Controls.Add(Me.btnilacbildirimiekle)
        Me.GroupBox1.Controls.Add(Me.cmbadsoyad)
        Me.GroupBox1.Controls.Add(Me.cmbilacictimi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dttarih)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "İlaç Bildirimi İşlemleri"
        '
        'btnİlacbildirimiSil
        '
        Me.btnİlacbildirimiSil.BackColor = System.Drawing.Color.Red
        Me.btnİlacbildirimiSil.FlatAppearance.BorderSize = 0
        Me.btnİlacbildirimiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnİlacbildirimiSil.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnİlacbildirimiSil.Image = CType(resources.GetObject("btnİlacbildirimiSil.Image"), System.Drawing.Image)
        Me.btnİlacbildirimiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnİlacbildirimiSil.Location = New System.Drawing.Point(362, 229)
        Me.btnİlacbildirimiSil.Name = "btnİlacbildirimiSil"
        Me.btnİlacbildirimiSil.Size = New System.Drawing.Size(156, 52)
        Me.btnİlacbildirimiSil.TabIndex = 4
        Me.btnİlacbildirimiSil.Text = "Sil"
        Me.btnİlacbildirimiSil.UseVisualStyleBackColor = False
        '
        'btnilacbildirimguncelle
        '
        Me.btnilacbildirimguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnilacbildirimguncelle.FlatAppearance.BorderSize = 0
        Me.btnilacbildirimguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnilacbildirimguncelle.Image = CType(resources.GetObject("btnilacbildirimguncelle.Image"), System.Drawing.Image)
        Me.btnilacbildirimguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnilacbildirimguncelle.Location = New System.Drawing.Point(183, 229)
        Me.btnilacbildirimguncelle.Name = "btnilacbildirimguncelle"
        Me.btnilacbildirimguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnilacbildirimguncelle.TabIndex = 4
        Me.btnilacbildirimguncelle.Text = "Güncelle"
        Me.btnilacbildirimguncelle.UseVisualStyleBackColor = False
        '
        'btnilacbildirimiekle
        '
        Me.btnilacbildirimiekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnilacbildirimiekle.FlatAppearance.BorderSize = 0
        Me.btnilacbildirimiekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnilacbildirimiekle.Image = CType(resources.GetObject("btnilacbildirimiekle.Image"), System.Drawing.Image)
        Me.btnilacbildirimiekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnilacbildirimiekle.Location = New System.Drawing.Point(6, 229)
        Me.btnilacbildirimiekle.Name = "btnilacbildirimiekle"
        Me.btnilacbildirimiekle.Size = New System.Drawing.Size(156, 52)
        Me.btnilacbildirimiekle.TabIndex = 4
        Me.btnilacbildirimiekle.Text = "Ekle"
        Me.btnilacbildirimiekle.UseVisualStyleBackColor = False
        '
        'cmbadsoyad
        '
        Me.cmbadsoyad.FormattingEnabled = True
        Me.cmbadsoyad.Location = New System.Drawing.Point(124, 89)
        Me.cmbadsoyad.Name = "cmbadsoyad"
        Me.cmbadsoyad.Size = New System.Drawing.Size(238, 26)
        Me.cmbadsoyad.TabIndex = 3
        '
        'cmbilacictimi
        '
        Me.cmbilacictimi.FormattingEnabled = True
        Me.cmbilacictimi.Location = New System.Drawing.Point(151, 158)
        Me.cmbilacictimi.Name = "cmbilacictimi"
        Me.cmbilacictimi.Size = New System.Drawing.Size(238, 26)
        Me.cmbilacictimi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(8, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "İlacını İçti mi?:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(8, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ad-Soyad:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(124, 38)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(265, 24)
        Me.dttarih.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarih:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtgridİlacBildirimi)
        Me.GroupBox2.Controls.Add(Me.btnyenile)
        Me.GroupBox2.Controls.Add(Me.btnara)
        Me.GroupBox2.Controls.Add(Me.dttarihara)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(564, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 518)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "İlaç Bildirimi Ara"
        '
        'dtgridİlacBildirimi
        '
        Me.dtgridİlacBildirimi.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgridİlacBildirimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridİlacBildirimi.Location = New System.Drawing.Point(3, 134)
        Me.dtgridİlacBildirimi.Name = "dtgridİlacBildirimi"
        Me.dtgridİlacBildirimi.RowHeadersWidth = 51
        Me.dtgridİlacBildirimi.RowTemplate.Height = 24
        Me.dtgridİlacBildirimi.Size = New System.Drawing.Size(759, 374)
        Me.dtgridİlacBildirimi.TabIndex = 3
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = CType(resources.GetObject("btnyenile.Image"), System.Drawing.Image)
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(232, 79)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(119, 52)
        Me.btnyenile.TabIndex = 2
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = CType(resources.GetObject("btnara.Image"), System.Drawing.Image)
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(88, 79)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(119, 52)
        Me.btnara.TabIndex = 2
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dttarihara
        '
        Me.dttarihara.Location = New System.Drawing.Point(124, 38)
        Me.dttarihara.Name = "dttarihara"
        Me.dttarihara.Size = New System.Drawing.Size(265, 24)
        Me.dttarihara.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(8, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tarih:"
        '
        'FrmOgretmenİlacBildirimi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(1401, 667)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmenİlacBildirimi"
        Me.Text = "İlaç Bildirimi İşlemleri"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgridİlacBildirimi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnİlacbildirimiSil As Button
    Friend WithEvents btnilacbildirimguncelle As Button
    Friend WithEvents btnilacbildirimiekle As Button
    Friend WithEvents cmbilacictimi As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dttarih As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnyenile As Button
    Friend WithEvents btnara As Button
    Friend WithEvents dttarihara As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbadsoyad As ComboBox
    Friend WithEvents dtgridİlacBildirimi As DataGridView
End Class

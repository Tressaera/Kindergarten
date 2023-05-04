<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmenYoklama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenYoklama))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnyoklamasil = New System.Windows.Forms.Button()
        Me.btnyoklamaguncelle = New System.Windows.Forms.Button()
        Me.btnyoklamaekle = New System.Windows.Forms.Button()
        Me.cmbokul = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmbadsoyad = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label23 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.dtgridyoklama = New System.Windows.Forms.DataGridView()
        Me.label7 = New System.Windows.Forms.Label()
        Me.dttarihara = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        CType(Me.dtgridyoklama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnyoklamasil)
        Me.GroupBox1.Controls.Add(Me.btnyoklamaguncelle)
        Me.GroupBox1.Controls.Add(Me.btnyoklamaekle)
        Me.GroupBox1.Controls.Add(Me.cmbokul)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.cmbadsoyad)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.dttarih)
        Me.GroupBox1.Controls.Add(Me.label23)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 314)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Yoklama İşlemleri"
        '
        'btnyoklamasil
        '
        Me.btnyoklamasil.BackColor = System.Drawing.Color.IndianRed
        Me.btnyoklamasil.Image = CType(resources.GetObject("btnyoklamasil.Image"), System.Drawing.Image)
        Me.btnyoklamasil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyoklamasil.Location = New System.Drawing.Point(355, 216)
        Me.btnyoklamasil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyoklamasil.Name = "btnyoklamasil"
        Me.btnyoklamasil.Size = New System.Drawing.Size(156, 52)
        Me.btnyoklamasil.TabIndex = 60
        Me.btnyoklamasil.Text = "SİL"
        Me.btnyoklamasil.UseVisualStyleBackColor = False
        '
        'btnyoklamaguncelle
        '
        Me.btnyoklamaguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnyoklamaguncelle.Image = CType(resources.GetObject("btnyoklamaguncelle.Image"), System.Drawing.Image)
        Me.btnyoklamaguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyoklamaguncelle.Location = New System.Drawing.Point(178, 216)
        Me.btnyoklamaguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyoklamaguncelle.Name = "btnyoklamaguncelle"
        Me.btnyoklamaguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnyoklamaguncelle.TabIndex = 67
        Me.btnyoklamaguncelle.Text = "Güncelle"
        Me.btnyoklamaguncelle.UseVisualStyleBackColor = False
        '
        'btnyoklamaekle
        '
        Me.btnyoklamaekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnyoklamaekle.Image = CType(resources.GetObject("btnyoklamaekle.Image"), System.Drawing.Image)
        Me.btnyoklamaekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyoklamaekle.Location = New System.Drawing.Point(9, 216)
        Me.btnyoklamaekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyoklamaekle.Name = "btnyoklamaekle"
        Me.btnyoklamaekle.Size = New System.Drawing.Size(156, 52)
        Me.btnyoklamaekle.TabIndex = 68
        Me.btnyoklamaekle.Text = "Ekle"
        Me.btnyoklamaekle.UseVisualStyleBackColor = False
        '
        'cmbokul
        '
        Me.cmbokul.FormattingEnabled = True
        Me.cmbokul.Items.AddRange(New Object() {"Evet", "Hayır"})
        Me.cmbokul.Location = New System.Drawing.Point(151, 152)
        Me.cmbokul.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbokul.Name = "cmbokul"
        Me.cmbokul.Size = New System.Drawing.Size(200, 26)
        Me.cmbokul.TabIndex = 66
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(1, 155)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(137, 25)
        Me.label1.TabIndex = 65
        Me.label1.Text = "Okula Geldimi"
        '
        'cmbadsoyad
        '
        Me.cmbadsoyad.FormattingEnabled = True
        Me.cmbadsoyad.Location = New System.Drawing.Point(117, 96)
        Me.cmbadsoyad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbadsoyad.Name = "cmbadsoyad"
        Me.cmbadsoyad.Size = New System.Drawing.Size(235, 26)
        Me.cmbadsoyad.TabIndex = 64
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Location = New System.Drawing.Point(1, 47)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 28)
        Me.label2.TabIndex = 63
        Me.label2.Text = "Tarih:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(117, 46)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(235, 24)
        Me.dttarih.TabIndex = 62
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(1, 100)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(105, 25)
        Me.label23.TabIndex = 61
        Me.label23.Text = "Ad-Soyad:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnara)
        Me.groupBox3.Controls.Add(Me.btnyenile)
        Me.groupBox3.Controls.Add(Me.dtgridyoklama)
        Me.groupBox3.Controls.Add(Me.label7)
        Me.groupBox3.Controls.Add(Me.dttarihara)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(559, 23)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Size = New System.Drawing.Size(741, 503)
        Me.groupBox3.TabIndex = 3
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = " Yoklama Ara"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = CType(resources.GetObject("btnara.Image"), System.Drawing.Image)
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(381, 18)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(119, 52)
        Me.btnara.TabIndex = 63
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = CType(resources.GetObject("btnyenile.Image"), System.Drawing.Image)
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(556, 18)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 62
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'dtgridyoklama
        '
        Me.dtgridyoklama.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridyoklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridyoklama.Location = New System.Drawing.Point(8, 91)
        Me.dtgridyoklama.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridyoklama.Name = "dtgridyoklama"
        Me.dtgridyoklama.RowHeadersWidth = 51
        Me.dtgridyoklama.Size = New System.Drawing.Size(725, 405)
        Me.dtgridyoklama.TabIndex = 56
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label7.Location = New System.Drawing.Point(8, 37)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(64, 28)
        Me.label7.TabIndex = 55
        Me.label7.Text = "Tarih:"
        '
        'dttarihara
        '
        Me.dttarihara.Location = New System.Drawing.Point(111, 37)
        Me.dttarihara.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarihara.Name = "dttarihara"
        Me.dttarihara.Size = New System.Drawing.Size(235, 24)
        Me.dttarihara.TabIndex = 54
        '
        'FrmOgretmenYoklama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1415, 554)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmenYoklama"
        Me.Text = "Öğretmen Yoklama"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.dtgridyoklama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btnyoklamasil As Button
    Private WithEvents btnyoklamaguncelle As Button
    Private WithEvents btnyoklamaekle As Button
    Private WithEvents cmbokul As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents cmbadsoyad As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label23 As Label
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents btnara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents dtgridyoklama As DataGridView
    Private WithEvents label7 As Label
    Private WithEvents dttarihara As DateTimePicker
End Class

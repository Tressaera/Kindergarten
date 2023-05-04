<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgrenci
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgrenci))
        Me.grpOgrenciAra = New System.Windows.Forms.GroupBox()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.btnara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.dtgridogrlistele = New System.Windows.Forms.DataGridView()
        Me.txtograra = New System.Windows.Forms.TextBox()
        Me.label23 = New System.Windows.Forms.Label()
        Me.grpOgrenciEkle = New System.Windows.Forms.GroupBox()
        Me.btnogrencisil = New System.Windows.Forms.Button()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.dtkayit = New System.Windows.Forms.DateTimePicker()
        Me.btnogrguncelle = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.btnogrekle = New System.Windows.Forms.Button()
        Me.cmbsinif = New System.Windows.Forms.ComboBox()
        Me.cmbcins = New System.Windows.Forms.ComboBox()
        Me.dtOgr = New System.Windows.Forms.DateTimePicker()
        Me.txtOgrTC = New System.Windows.Forms.TextBox()
        Me.txtOgrAd = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.grpOgrenciAra.SuspendLayout()
        CType(Me.dtgridogrlistele, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOgrenciEkle.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOgrenciAra
        '
        Me.grpOgrenciAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgrenciAra.Controls.Add(Me.label15)
        Me.grpOgrenciAra.Controls.Add(Me.btnara)
        Me.grpOgrenciAra.Controls.Add(Me.btnyenile)
        Me.grpOgrenciAra.Controls.Add(Me.dtgridogrlistele)
        Me.grpOgrenciAra.Controls.Add(Me.txtograra)
        Me.grpOgrenciAra.Controls.Add(Me.label23)
        Me.grpOgrenciAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgrenciAra.Location = New System.Drawing.Point(585, 12)
        Me.grpOgrenciAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgrenciAra.Name = "grpOgrenciAra"
        Me.grpOgrenciAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgrenciAra.Size = New System.Drawing.Size(847, 490)
        Me.grpOgrenciAra.TabIndex = 4
        Me.grpOgrenciAra.TabStop = False
        Me.grpOgrenciAra.Text = "Öğrenci Ara"
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(119, 63)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(179, 27)
        Me.cmbdonemara.TabIndex = 41
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(0, 65)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(87, 25)
        Me.label15.TabIndex = 40
        Me.label15.Text = "Dönemi:"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(307, 17)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(141, 52)
        Me.btnara.TabIndex = 39
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(472, 17)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 38
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'dtgridogrlistele
        '
        Me.dtgridogrlistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridogrlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridogrlistele.Location = New System.Drawing.Point(0, 94)
        Me.dtgridogrlistele.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridogrlistele.Name = "dtgridogrlistele"
        Me.dtgridogrlistele.RowHeadersWidth = 51
        Me.dtgridogrlistele.Size = New System.Drawing.Size(847, 396)
        Me.dtgridogrlistele.TabIndex = 15
        '
        'txtograra
        '
        Me.txtograra.Location = New System.Drawing.Point(119, 22)
        Me.txtograra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtograra.Name = "txtograra"
        Me.txtograra.Size = New System.Drawing.Size(179, 26)
        Me.txtograra.TabIndex = 14
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(-5, 22)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(105, 25)
        Me.label23.TabIndex = 13
        Me.label23.Text = "Ad-Soyad:"
        '
        'grpOgrenciEkle
        '
        Me.grpOgrenciEkle.Controls.Add(Me.btnogrencisil)
        Me.grpOgrenciEkle.Controls.Add(Me.cmbdonem)
        Me.grpOgrenciEkle.Controls.Add(Me.label13)
        Me.grpOgrenciEkle.Controls.Add(Me.dtkayit)
        Me.grpOgrenciEkle.Controls.Add(Me.btnogrguncelle)
        Me.grpOgrenciEkle.Controls.Add(Me.label7)
        Me.grpOgrenciEkle.Controls.Add(Me.btnogrekle)
        Me.grpOgrenciEkle.Controls.Add(Me.cmbsinif)
        Me.grpOgrenciEkle.Controls.Add(Me.cmbcins)
        Me.grpOgrenciEkle.Controls.Add(Me.dtOgr)
        Me.grpOgrenciEkle.Controls.Add(Me.txtOgrTC)
        Me.grpOgrenciEkle.Controls.Add(Me.txtOgrAd)
        Me.grpOgrenciEkle.Controls.Add(Me.label6)
        Me.grpOgrenciEkle.Controls.Add(Me.label5)
        Me.grpOgrenciEkle.Controls.Add(Me.label4)
        Me.grpOgrenciEkle.Controls.Add(Me.label3)
        Me.grpOgrenciEkle.Controls.Add(Me.label1)
        Me.grpOgrenciEkle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgrenciEkle.Location = New System.Drawing.Point(9, 12)
        Me.grpOgrenciEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgrenciEkle.Name = "grpOgrenciEkle"
        Me.grpOgrenciEkle.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgrenciEkle.Size = New System.Drawing.Size(543, 490)
        Me.grpOgrenciEkle.TabIndex = 3
        Me.grpOgrenciEkle.TabStop = False
        Me.grpOgrenciEkle.Text = "Öğrenci İşlemleri"
        '
        'btnogrencisil
        '
        Me.btnogrencisil.BackColor = System.Drawing.Color.IndianRed
        Me.btnogrencisil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnogrencisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogrencisil.Location = New System.Drawing.Point(376, 402)
        Me.btnogrencisil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogrencisil.Name = "btnogrencisil"
        Me.btnogrencisil.Size = New System.Drawing.Size(156, 52)
        Me.btnogrencisil.TabIndex = 25
        Me.btnogrencisil.Text = "SİL"
        Me.btnogrencisil.UseVisualStyleBackColor = False
        '
        'cmbdonem
        '
        Me.cmbdonem.FormattingEnabled = True
        Me.cmbdonem.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonem.Location = New System.Drawing.Point(153, 334)
        Me.cmbdonem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonem.Name = "cmbdonem"
        Me.cmbdonem.Size = New System.Drawing.Size(212, 27)
        Me.cmbdonem.TabIndex = 27
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(9, 336)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(87, 25)
        Me.label13.TabIndex = 26
        Me.label13.Text = "Dönemi:"
        '
        'dtkayit
        '
        Me.dtkayit.CustomFormat = "dd-MMMM-yy"
        Me.dtkayit.Enabled = False
        Me.dtkayit.Location = New System.Drawing.Point(156, 271)
        Me.dtkayit.Margin = New System.Windows.Forms.Padding(4)
        Me.dtkayit.Name = "dtkayit"
        Me.dtkayit.Size = New System.Drawing.Size(209, 26)
        Me.dtkayit.TabIndex = 25
        '
        'btnogrguncelle
        '
        Me.btnogrguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnogrguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnogrguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogrguncelle.Location = New System.Drawing.Point(193, 405)
        Me.btnogrguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogrguncelle.Name = "btnogrguncelle"
        Me.btnogrguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnogrguncelle.TabIndex = 24
        Me.btnogrguncelle.Text = "Güncelle"
        Me.btnogrguncelle.UseVisualStyleBackColor = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(9, 271)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(114, 25)
        Me.label7.TabIndex = 24
        Me.label7.Text = "Kayıt Tarihi:"
        '
        'btnogrekle
        '
        Me.btnogrekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnogrekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnogrekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogrekle.Location = New System.Drawing.Point(15, 405)
        Me.btnogrekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogrekle.Name = "btnogrekle"
        Me.btnogrekle.Size = New System.Drawing.Size(156, 52)
        Me.btnogrekle.TabIndex = 23
        Me.btnogrekle.Text = "Ekle"
        Me.btnogrekle.UseVisualStyleBackColor = False
        '
        'cmbsinif
        '
        Me.cmbsinif.FormattingEnabled = True
        Me.cmbsinif.Location = New System.Drawing.Point(151, 215)
        Me.cmbsinif.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsinif.Name = "cmbsinif"
        Me.cmbsinif.Size = New System.Drawing.Size(212, 27)
        Me.cmbsinif.TabIndex = 17
        '
        'cmbcins
        '
        Me.cmbcins.FormattingEnabled = True
        Me.cmbcins.Items.AddRange(New Object() {"Erkek ", "Kız"})
        Me.cmbcins.Location = New System.Drawing.Point(151, 169)
        Me.cmbcins.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbcins.Name = "cmbcins"
        Me.cmbcins.Size = New System.Drawing.Size(212, 27)
        Me.cmbcins.TabIndex = 16
        '
        'dtOgr
        '
        Me.dtOgr.CustomFormat = "dd-MMMM-yy"
        Me.dtOgr.Location = New System.Drawing.Point(151, 124)
        Me.dtOgr.Margin = New System.Windows.Forms.Padding(4)
        Me.dtOgr.Name = "dtOgr"
        Me.dtOgr.Size = New System.Drawing.Size(209, 26)
        Me.dtOgr.TabIndex = 15
        '
        'txtOgrTC
        '
        Me.txtOgrTC.Location = New System.Drawing.Point(151, 82)
        Me.txtOgrTC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOgrTC.Name = "txtOgrTC"
        Me.txtOgrTC.Size = New System.Drawing.Size(212, 26)
        Me.txtOgrTC.TabIndex = 14
        '
        'txtOgrAd
        '
        Me.txtOgrAd.Location = New System.Drawing.Point(151, 30)
        Me.txtOgrAd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOgrAd.Name = "txtOgrAd"
        Me.txtOgrAd.Size = New System.Drawing.Size(212, 26)
        Me.txtOgrAd.TabIndex = 12
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(9, 217)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(58, 25)
        Me.label6.TabIndex = 5
        Me.label6.Text = "Sınıf:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(4, 170)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(86, 25)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Cinsiyet:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(4, 124)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(137, 25)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Doğum Tarihi:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(9, 80)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 25)
        Me.label3.TabIndex = 2
        Me.label3.Text = "TC:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(9, 30)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(137, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Adı ve Soyadı:"
        '
        'FrmOgrenci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1472, 667)
        Me.Controls.Add(Me.grpOgrenciAra)
        Me.Controls.Add(Me.grpOgrenciEkle)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgrenci"
        Me.Text = "Öğrenci"
        Me.grpOgrenciAra.ResumeLayout(False)
        Me.grpOgrenciAra.PerformLayout()
        CType(Me.dtgridogrlistele, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOgrenciEkle.ResumeLayout(False)
        Me.grpOgrenciEkle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgrenciAra As GroupBox
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents label15 As Label
    Private WithEvents btnara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents dtgridogrlistele As DataGridView
    Private WithEvents txtograra As TextBox
    Private WithEvents label23 As Label
    Private WithEvents grpOgrenciEkle As GroupBox
    Private WithEvents btnogrencisil As Button
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents label13 As Label
    Private WithEvents dtkayit As DateTimePicker
    Private WithEvents btnogrguncelle As Button
    Private WithEvents label7 As Label
    Private WithEvents btnogrekle As Button
    Private WithEvents cmbsinif As ComboBox
    Public WithEvents cmbcins As ComboBox
    Private WithEvents dtOgr As DateTimePicker
    Private WithEvents txtOgrTC As TextBox
    Private WithEvents txtOgrAd As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
End Class

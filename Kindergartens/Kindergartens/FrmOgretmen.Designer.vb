<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmen))
        Me.grpOgretmenAra = New System.Windows.Forms.GroupBox()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.dtgridogretmenlistele = New System.Windows.Forms.DataGridView()
        Me.txtogretmenara = New System.Windows.Forms.TextBox()
        Me.label23 = New System.Windows.Forms.Label()
        Me.grpOgretmenEkle = New System.Windows.Forms.GroupBox()
        Me.txtogretmenkulad = New System.Windows.Forms.TextBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.rchogretmenadres = New System.Windows.Forms.RichTextBox()
        Me.txtogretmensifre = New System.Windows.Forms.TextBox()
        Me.mskogretmentel = New System.Windows.Forms.MaskedTextBox()
        Me.txtogretmenmaas = New System.Windows.Forms.TextBox()
        Me.dtOgretmen = New System.Windows.Forms.DateTimePicker()
        Me.txtogretmenTc = New System.Windows.Forms.TextBox()
        Me.txtOgretmenAd = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnogretmensil = New System.Windows.Forms.Button()
        Me.btnogretmenguncelle = New System.Windows.Forms.Button()
        Me.btnogretmenekle = New System.Windows.Forms.Button()
        Me.grpOgretmenAra.SuspendLayout()
        CType(Me.dtgridogretmenlistele, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOgretmenEkle.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOgretmenAra
        '
        Me.grpOgretmenAra.Controls.Add(Me.btnyenile)
        Me.grpOgretmenAra.Controls.Add(Me.dtgridogretmenlistele)
        Me.grpOgretmenAra.Controls.Add(Me.txtogretmenara)
        Me.grpOgretmenAra.Controls.Add(Me.label23)
        Me.grpOgretmenAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenAra.Location = New System.Drawing.Point(561, 11)
        Me.grpOgretmenAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Name = "grpOgretmenAra"
        Me.grpOgretmenAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenAra.Size = New System.Drawing.Size(907, 574)
        Me.grpOgretmenAra.TabIndex = 8
        Me.grpOgretmenAra.TabStop = False
        Me.grpOgretmenAra.Text = "Öğretmen Ara"
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(435, 21)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 38
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'dtgridogretmenlistele
        '
        Me.dtgridogretmenlistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridogretmenlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridogretmenlistele.Location = New System.Drawing.Point(0, 80)
        Me.dtgridogretmenlistele.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridogretmenlistele.Name = "dtgridogretmenlistele"
        Me.dtgridogretmenlistele.RowHeadersWidth = 51
        Me.dtgridogretmenlistele.Size = New System.Drawing.Size(899, 486)
        Me.dtgridogretmenlistele.TabIndex = 15
        '
        'txtogretmenara
        '
        Me.txtogretmenara.Location = New System.Drawing.Point(119, 32)
        Me.txtogretmenara.Margin = New System.Windows.Forms.Padding(4)
        Me.txtogretmenara.Name = "txtogretmenara"
        Me.txtogretmenara.Size = New System.Drawing.Size(212, 26)
        Me.txtogretmenara.TabIndex = 14
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(-5, 32)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(47, 25)
        Me.label23.TabIndex = 13
        Me.label23.Text = "Adı:"
        '
        'grpOgretmenEkle
        '
        Me.grpOgretmenEkle.Controls.Add(Me.btnogretmensil)
        Me.grpOgretmenEkle.Controls.Add(Me.btnogretmenguncelle)
        Me.grpOgretmenEkle.Controls.Add(Me.txtogretmenkulad)
        Me.grpOgretmenEkle.Controls.Add(Me.label19)
        Me.grpOgretmenEkle.Controls.Add(Me.rchogretmenadres)
        Me.grpOgretmenEkle.Controls.Add(Me.btnogretmenekle)
        Me.grpOgretmenEkle.Controls.Add(Me.txtogretmensifre)
        Me.grpOgretmenEkle.Controls.Add(Me.mskogretmentel)
        Me.grpOgretmenEkle.Controls.Add(Me.txtogretmenmaas)
        Me.grpOgretmenEkle.Controls.Add(Me.dtOgretmen)
        Me.grpOgretmenEkle.Controls.Add(Me.txtogretmenTc)
        Me.grpOgretmenEkle.Controls.Add(Me.txtOgretmenAd)
        Me.grpOgretmenEkle.Controls.Add(Me.label8)
        Me.grpOgretmenEkle.Controls.Add(Me.label9)
        Me.grpOgretmenEkle.Controls.Add(Me.label11)
        Me.grpOgretmenEkle.Controls.Add(Me.label12)
        Me.grpOgretmenEkle.Controls.Add(Me.label4)
        Me.grpOgretmenEkle.Controls.Add(Me.label3)
        Me.grpOgretmenEkle.Controls.Add(Me.label1)
        Me.grpOgretmenEkle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgretmenEkle.Location = New System.Drawing.Point(13, 11)
        Me.grpOgretmenEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenEkle.Name = "grpOgretmenEkle"
        Me.grpOgretmenEkle.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgretmenEkle.Size = New System.Drawing.Size(520, 590)
        Me.grpOgretmenEkle.TabIndex = 7
        Me.grpOgretmenEkle.TabStop = False
        Me.grpOgretmenEkle.Text = "Öğretmen İşlemleri"
        '
        'txtogretmenkulad
        '
        Me.txtogretmenkulad.Location = New System.Drawing.Point(139, 396)
        Me.txtogretmenkulad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtogretmenkulad.Name = "txtogretmenkulad"
        Me.txtogretmenkulad.Size = New System.Drawing.Size(212, 26)
        Me.txtogretmenkulad.TabIndex = 28
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label19.ForeColor = System.Drawing.Color.White
        Me.label19.Location = New System.Drawing.Point(-5, 399)
        Me.label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(124, 25)
        Me.label19.TabIndex = 27
        Me.label19.Text = "Kullanıcı AD:"
        '
        'rchogretmenadres
        '
        Me.rchogretmenadres.Location = New System.Drawing.Point(141, 161)
        Me.rchogretmenadres.Margin = New System.Windows.Forms.Padding(4)
        Me.rchogretmenadres.Name = "rchogretmenadres"
        Me.rchogretmenadres.Size = New System.Drawing.Size(209, 75)
        Me.rchogretmenadres.TabIndex = 24
        Me.rchogretmenadres.Text = ""
        '
        'txtogretmensifre
        '
        Me.txtogretmensifre.Location = New System.Drawing.Point(139, 448)
        Me.txtogretmensifre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtogretmensifre.Name = "txtogretmensifre"
        Me.txtogretmensifre.Size = New System.Drawing.Size(212, 26)
        Me.txtogretmensifre.TabIndex = 22
        '
        'mskogretmentel
        '
        Me.mskogretmentel.Location = New System.Drawing.Point(141, 362)
        Me.mskogretmentel.Margin = New System.Windows.Forms.Padding(4)
        Me.mskogretmentel.Mask = "(999) 000-0000"
        Me.mskogretmentel.Name = "mskogretmentel"
        Me.mskogretmentel.Size = New System.Drawing.Size(212, 26)
        Me.mskogretmentel.TabIndex = 21
        '
        'txtogretmenmaas
        '
        Me.txtogretmenmaas.Location = New System.Drawing.Point(141, 309)
        Me.txtogretmenmaas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtogretmenmaas.Name = "txtogretmenmaas"
        Me.txtogretmenmaas.Size = New System.Drawing.Size(212, 26)
        Me.txtogretmenmaas.TabIndex = 19
        '
        'dtOgretmen
        '
        Me.dtOgretmen.Location = New System.Drawing.Point(141, 112)
        Me.dtOgretmen.Margin = New System.Windows.Forms.Padding(4)
        Me.dtOgretmen.Name = "dtOgretmen"
        Me.dtOgretmen.Size = New System.Drawing.Size(209, 26)
        Me.dtOgretmen.TabIndex = 15
        '
        'txtogretmenTc
        '
        Me.txtogretmenTc.Location = New System.Drawing.Point(141, 70)
        Me.txtogretmenTc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtogretmenTc.Name = "txtogretmenTc"
        Me.txtogretmenTc.Size = New System.Drawing.Size(212, 26)
        Me.txtogretmenTc.TabIndex = 14
        '
        'txtOgretmenAd
        '
        Me.txtOgretmenAd.Location = New System.Drawing.Point(141, 21)
        Me.txtOgretmenAd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOgretmenAd.Name = "txtOgretmenAd"
        Me.txtOgretmenAd.Size = New System.Drawing.Size(212, 26)
        Me.txtOgretmenAd.TabIndex = 12
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(-5, 450)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(58, 25)
        Me.label8.TabIndex = 10
        Me.label8.Text = "Şifre:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(-5, 362)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(82, 25)
        Me.label9.TabIndex = 9
        Me.label9.Text = "Telefon:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(0, 306)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(63, 25)
        Me.label11.TabIndex = 7
        Me.label11.Text = "Maaş:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(-5, 159)
        Me.label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(68, 25)
        Me.label12.TabIndex = 6
        Me.label12.Text = "Adres:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(-5, 112)
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
        Me.label3.Location = New System.Drawing.Point(0, 68)
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
        Me.label1.Location = New System.Drawing.Point(0, 21)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(112, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "AD SOYAD:"
        '
        'btnogretmensil
        '
        Me.btnogretmensil.BackColor = System.Drawing.Color.IndianRed
        Me.btnogretmensil.Image = Global.Kindergartens.My.Resources.Resources.trash1
        Me.btnogretmensil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogretmensil.Location = New System.Drawing.Point(352, 522)
        Me.btnogretmensil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogretmensil.Name = "btnogretmensil"
        Me.btnogretmensil.Size = New System.Drawing.Size(156, 52)
        Me.btnogretmensil.TabIndex = 25
        Me.btnogretmensil.Text = "SİL"
        Me.btnogretmensil.UseVisualStyleBackColor = False
        '
        'btnogretmenguncelle
        '
        Me.btnogretmenguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnogretmenguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnogretmenguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogretmenguncelle.Location = New System.Drawing.Point(172, 522)
        Me.btnogretmenguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogretmenguncelle.Name = "btnogretmenguncelle"
        Me.btnogretmenguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnogretmenguncelle.TabIndex = 24
        Me.btnogretmenguncelle.Text = "Güncelle"
        Me.btnogretmenguncelle.UseVisualStyleBackColor = False
        '
        'btnogretmenekle
        '
        Me.btnogretmenekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnogretmenekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnogretmenekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogretmenekle.Location = New System.Drawing.Point(8, 522)
        Me.btnogretmenekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogretmenekle.Name = "btnogretmenekle"
        Me.btnogretmenekle.Size = New System.Drawing.Size(156, 52)
        Me.btnogretmenekle.TabIndex = 23
        Me.btnogretmenekle.Text = "Ekle"
        Me.btnogretmenekle.UseVisualStyleBackColor = False
        '
        'FrmOgretmen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1597, 667)
        Me.Controls.Add(Me.grpOgretmenAra)
        Me.Controls.Add(Me.grpOgretmenEkle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmen"
        Me.Text = "Öğretmen"
        Me.grpOgretmenAra.ResumeLayout(False)
        Me.grpOgretmenAra.PerformLayout()
        CType(Me.dtgridogretmenlistele, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOgretmenEkle.ResumeLayout(False)
        Me.grpOgretmenEkle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgretmenAra As GroupBox
    Private WithEvents btnyenile As Button
    Private WithEvents dtgridogretmenlistele As DataGridView
    Private WithEvents txtogretmenara As TextBox
    Private WithEvents label23 As Label
    Private WithEvents grpOgretmenEkle As GroupBox
    Private WithEvents btnogretmensil As Button
    Private WithEvents btnogretmenguncelle As Button
    Private WithEvents txtogretmenkulad As TextBox
    Private WithEvents label19 As Label
    Private WithEvents rchogretmenadres As RichTextBox
    Private WithEvents btnogretmenekle As Button
    Private WithEvents txtogretmensifre As TextBox
    Private WithEvents mskogretmentel As MaskedTextBox
    Private WithEvents txtogretmenmaas As TextBox
    Private WithEvents dtOgretmen As DateTimePicker
    Private WithEvents txtogretmenTc As TextBox
    Private WithEvents txtOgretmenAd As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
End Class

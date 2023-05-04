<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeli))
        Me.grpOgrenciAra = New System.Windows.Forms.GroupBox()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.dtgridvelilistele = New System.Windows.Forms.DataGridView()
        Me.txtveliara = New System.Windows.Forms.TextBox()
        Me.label23 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbogrenci = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cmbdonemi = New System.Windows.Forms.ComboBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.txtyillikfiyat = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtsifre = New System.Windows.Forms.TextBox()
        Me.txtkulad = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.rchadres = New System.Windows.Forms.RichTextBox()
        Me.msktel = New System.Windows.Forms.MaskedTextBox()
        Me.txtveliadsoyad = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.btnveliSil = New System.Windows.Forms.Button()
        Me.btnguncelle = New System.Windows.Forms.Button()
        Me.btnveliekle = New System.Windows.Forms.Button()
        Me.AnaokuludbDataSet8 = New Kindergartens.AnaokuludbDataSet8()
        Me.OgrenciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OgrenciTableAdapter = New Kindergartens.AnaokuludbDataSet8TableAdapters.OgrenciTableAdapter()
        Me.grpOgrenciAra.SuspendLayout()
        CType(Me.dtgridvelilistele, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.AnaokuludbDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOgrenciAra
        '
        Me.grpOgrenciAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgrenciAra.Controls.Add(Me.label18)
        Me.grpOgrenciAra.Controls.Add(Me.btnara)
        Me.grpOgrenciAra.Controls.Add(Me.btnyenile)
        Me.grpOgrenciAra.Controls.Add(Me.dtgridvelilistele)
        Me.grpOgrenciAra.Controls.Add(Me.txtveliara)
        Me.grpOgrenciAra.Controls.Add(Me.label23)
        Me.grpOgrenciAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpOgrenciAra.Location = New System.Drawing.Point(553, 14)
        Me.grpOgrenciAra.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOgrenciAra.Name = "grpOgrenciAra"
        Me.grpOgrenciAra.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOgrenciAra.Size = New System.Drawing.Size(997, 574)
        Me.grpOgrenciAra.TabIndex = 6
        Me.grpOgrenciAra.TabStop = False
        Me.grpOgrenciAra.Text = "Veli Ara"
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(135, 52)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(212, 27)
        Me.cmbdonemara.TabIndex = 45
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(1, 53)
        Me.label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(87, 25)
        Me.label18.TabIndex = 44
        Me.label18.Text = "Dönemi:"
        '
        'dtgridvelilistele
        '
        Me.dtgridvelilistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridvelilistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridvelilistele.Location = New System.Drawing.Point(4, 121)
        Me.dtgridvelilistele.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridvelilistele.Name = "dtgridvelilistele"
        Me.dtgridvelilistele.RowHeadersWidth = 51
        Me.dtgridvelilistele.Size = New System.Drawing.Size(985, 441)
        Me.dtgridvelilistele.TabIndex = 15
        '
        'txtveliara
        '
        Me.txtveliara.Location = New System.Drawing.Point(135, 16)
        Me.txtveliara.Margin = New System.Windows.Forms.Padding(4)
        Me.txtveliara.Name = "txtveliara"
        Me.txtveliara.Size = New System.Drawing.Size(212, 26)
        Me.txtveliara.TabIndex = 14
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(-5, 16)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(137, 25)
        Me.label23.TabIndex = 13
        Me.label23.Text = "Adı ve Soyadı:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnveliSil)
        Me.groupBox1.Controls.Add(Me.btnguncelle)
        Me.groupBox1.Controls.Add(Me.cmbogrenci)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.cmbdonemi)
        Me.groupBox1.Controls.Add(Me.label17)
        Me.groupBox1.Controls.Add(Me.txtyillikfiyat)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.btnveliekle)
        Me.groupBox1.Controls.Add(Me.txtsifre)
        Me.groupBox1.Controls.Add(Me.txtkulad)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.rchadres)
        Me.groupBox1.Controls.Add(Me.msktel)
        Me.groupBox1.Controls.Add(Me.txtveliadsoyad)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(19, 14)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(525, 561)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Veli İşlemleri"
        '
        'cmbogrenci
        '
        Me.cmbogrenci.DataSource = Me.OgrenciBindingSource
        Me.cmbogrenci.DisplayMember = "ADSOYAD"
        Me.cmbogrenci.FormattingEnabled = True
        Me.cmbogrenci.Location = New System.Drawing.Point(201, 66)
        Me.cmbogrenci.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbogrenci.Name = "cmbogrenci"
        Me.cmbogrenci.Size = New System.Drawing.Size(160, 27)
        Me.cmbogrenci.TabIndex = 45
        Me.cmbogrenci.ValueMember = "OgrID"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(-4, 71)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(193, 23)
        Me.label6.TabIndex = 44
        Me.label6.Text = "Öğrenci Adı ve Soyadı:"
        '
        'cmbdonemi
        '
        Me.cmbdonemi.FormattingEnabled = True
        Me.cmbdonemi.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemi.Location = New System.Drawing.Point(173, 410)
        Me.cmbdonemi.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemi.Name = "cmbdonemi"
        Me.cmbdonemi.Size = New System.Drawing.Size(191, 27)
        Me.cmbdonemi.TabIndex = 43
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(5, 411)
        Me.label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(87, 25)
        Me.label17.TabIndex = 42
        Me.label17.Text = "Dönemi:"
        '
        'txtyillikfiyat
        '
        Me.txtyillikfiyat.Location = New System.Drawing.Point(173, 352)
        Me.txtyillikfiyat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtyillikfiyat.Name = "txtyillikfiyat"
        Me.txtyillikfiyat.Size = New System.Drawing.Size(191, 26)
        Me.txtyillikfiyat.TabIndex = 40
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(5, 352)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(107, 25)
        Me.label10.TabIndex = 39
        Me.label10.Text = "Yıllık Fiyat:"
        '
        'txtsifre
        '
        Me.txtsifre.Location = New System.Drawing.Point(173, 308)
        Me.txtsifre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsifre.Name = "txtsifre"
        Me.txtsifre.Size = New System.Drawing.Size(191, 26)
        Me.txtsifre.TabIndex = 38
        '
        'txtkulad
        '
        Me.txtkulad.Location = New System.Drawing.Point(173, 266)
        Me.txtkulad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkulad.Name = "txtkulad"
        Me.txtkulad.Size = New System.Drawing.Size(191, 26)
        Me.txtkulad.TabIndex = 37
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(5, 305)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 25)
        Me.label2.TabIndex = 36
        Me.label2.Text = "Şifre:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(5, 263)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(127, 25)
        Me.label3.TabIndex = 35
        Me.label3.Text = "Kullanıcı Adı:"
        '
        'rchadres
        '
        Me.rchadres.Location = New System.Drawing.Point(173, 155)
        Me.rchadres.Margin = New System.Windows.Forms.Padding(4)
        Me.rchadres.Name = "rchadres"
        Me.rchadres.Size = New System.Drawing.Size(191, 82)
        Me.rchadres.TabIndex = 33
        Me.rchadres.Text = ""
        '
        'msktel
        '
        Me.msktel.Location = New System.Drawing.Point(173, 105)
        Me.msktel.Margin = New System.Windows.Forms.Padding(4)
        Me.msktel.Mask = "(999) 000-0000"
        Me.msktel.Name = "msktel"
        Me.msktel.Size = New System.Drawing.Size(191, 26)
        Me.msktel.TabIndex = 29
        '
        'txtveliadsoyad
        '
        Me.txtveliadsoyad.Location = New System.Drawing.Point(173, 20)
        Me.txtveliadsoyad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtveliadsoyad.Name = "txtveliadsoyad"
        Me.txtveliadsoyad.Size = New System.Drawing.Size(191, 26)
        Me.txtveliadsoyad.TabIndex = 27
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(5, 150)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(68, 25)
        Me.label8.TabIndex = 26
        Me.label8.Text = "Adres:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(5, 105)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(82, 25)
        Me.label9.TabIndex = 25
        Me.label9.Text = "Telefon:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(-5, 22)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(174, 25)
        Me.label11.TabIndex = 23
        Me.label11.Text = "Veli Adı ve Soyadı:"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(356, 21)
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
        Me.btnyenile.Location = New System.Drawing.Point(519, 21)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 38
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'btnveliSil
        '
        Me.btnveliSil.BackColor = System.Drawing.Color.IndianRed
        Me.btnveliSil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnveliSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnveliSil.Location = New System.Drawing.Point(361, 458)
        Me.btnveliSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnveliSil.Name = "btnveliSil"
        Me.btnveliSil.Size = New System.Drawing.Size(156, 52)
        Me.btnveliSil.TabIndex = 25
        Me.btnveliSil.Text = "SİL"
        Me.btnveliSil.UseVisualStyleBackColor = False
        '
        'btnguncelle
        '
        Me.btnguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnguncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguncelle.Location = New System.Drawing.Point(179, 458)
        Me.btnguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguncelle.Name = "btnguncelle"
        Me.btnguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnguncelle.TabIndex = 39
        Me.btnguncelle.Text = "Güncelle"
        Me.btnguncelle.UseVisualStyleBackColor = False
        '
        'btnveliekle
        '
        Me.btnveliekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnveliekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnveliekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnveliekle.Location = New System.Drawing.Point(15, 458)
        Me.btnveliekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnveliekle.Name = "btnveliekle"
        Me.btnveliekle.Size = New System.Drawing.Size(156, 52)
        Me.btnveliekle.TabIndex = 24
        Me.btnveliekle.Text = "Ekle"
        Me.btnveliekle.UseVisualStyleBackColor = False
        '
        'AnaokuludbDataSet8
        '
        Me.AnaokuludbDataSet8.DataSetName = "AnaokuludbDataSet8"
        Me.AnaokuludbDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OgrenciBindingSource
        '
        Me.OgrenciBindingSource.DataMember = "Ogrenci"
        Me.OgrenciBindingSource.DataSource = Me.AnaokuludbDataSet8
        '
        'OgrenciTableAdapter
        '
        Me.OgrenciTableAdapter.ClearBeforeFill = True
        '
        'FrmVeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1613, 667)
        Me.Controls.Add(Me.grpOgrenciAra)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeli"
        Me.Text = "Veli"
        Me.grpOgrenciAra.ResumeLayout(False)
        Me.grpOgrenciAra.PerformLayout()
        CType(Me.dtgridvelilistele, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.AnaokuludbDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents grpOgrenciAra As GroupBox
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents label18 As Label
    Private WithEvents btnara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents dtgridvelilistele As DataGridView
    Private WithEvents txtveliara As TextBox
    Private WithEvents label23 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnveliSil As Button
    Private WithEvents btnguncelle As Button
    Private WithEvents cmbogrenci As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents cmbdonemi As ComboBox
    Private WithEvents label17 As Label
    Private WithEvents txtyillikfiyat As TextBox
    Private WithEvents label10 As Label
    Private WithEvents btnveliekle As Button
    Private WithEvents txtsifre As TextBox
    Private WithEvents txtkulad As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents rchadres As RichTextBox
    Private WithEvents msktel As MaskedTextBox
    Private WithEvents txtveliadsoyad As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents label11 As Label
    Friend WithEvents AnaokuludbDataSet8 As AnaokuludbDataSet8
    Friend WithEvents OgrenciBindingSource As BindingSource
    Friend WithEvents OgrenciTableAdapter As AnaokuludbDataSet8TableAdapters.OgrenciTableAdapter
End Class

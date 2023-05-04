<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSinifBilgileri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSinifBilgileri))
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.txtsinifadiara = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.dtgsinif = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsinifsil = New System.Windows.Forms.Button()
        Me.cmbogretmen = New System.Windows.Forms.ComboBox()
        Me.btnsinifguncelle = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.cmbdonem = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtkontenjan = New System.Windows.Forms.TextBox()
        Me.btnsinifekle = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtsinifadi = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.AnaokuludbDataSet6 = New Kindergartens.AnaokuludbDataSet6()
        Me.OgretmenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OgretmenTableAdapter = New Kindergartens.AnaokuludbDataSet6TableAdapters.OgretmenTableAdapter()
        Me.groupBox3.SuspendLayout()
        CType(Me.dtgsinif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.AnaokuludbDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OgretmenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.cmbdonemara)
        Me.groupBox3.Controls.Add(Me.label8)
        Me.groupBox3.Controls.Add(Me.btnara)
        Me.groupBox3.Controls.Add(Me.btnyenile)
        Me.groupBox3.Controls.Add(Me.txtsinifadiara)
        Me.groupBox3.Controls.Add(Me.label5)
        Me.groupBox3.Controls.Add(Me.dtgsinif)
        Me.groupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(596, 36)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Size = New System.Drawing.Size(733, 462)
        Me.groupBox3.TabIndex = 36
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Sınıf Ara"
        '
        'cmbdonemara
        '
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonemara.Location = New System.Drawing.Point(119, 50)
        Me.cmbdonemara.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(212, 27)
        Me.cmbdonemara.TabIndex = 41
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(8, 52)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(82, 25)
        Me.label8.TabIndex = 40
        Me.label8.Text = "Dönem:"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = CType(resources.GetObject("btnara.Image"), System.Drawing.Image)
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(340, 15)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(119, 52)
        Me.btnara.TabIndex = 39
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = CType(resources.GetObject("btnyenile.Image"), System.Drawing.Image)
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(467, 15)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 38
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'txtsinifadiara
        '
        Me.txtsinifadiara.Location = New System.Drawing.Point(119, 20)
        Me.txtsinifadiara.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsinifadiara.Name = "txtsinifadiara"
        Me.txtsinifadiara.Size = New System.Drawing.Size(212, 26)
        Me.txtsinifadiara.TabIndex = 30
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(8, 17)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(92, 25)
        Me.label5.TabIndex = 29
        Me.label5.Text = "Sınıf Adı:"
        '
        'dtgsinif
        '
        Me.dtgsinif.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgsinif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgsinif.Location = New System.Drawing.Point(0, 80)
        Me.dtgsinif.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgsinif.Name = "dtgsinif"
        Me.dtgsinif.RowHeadersWidth = 51
        Me.dtgsinif.Size = New System.Drawing.Size(733, 374)
        Me.dtgsinif.TabIndex = 15
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnsinifsil)
        Me.groupBox1.Controls.Add(Me.cmbogretmen)
        Me.groupBox1.Controls.Add(Me.btnsinifguncelle)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.cmbdonem)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtkontenjan)
        Me.groupBox1.Controls.Add(Me.btnsinifekle)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtsinifadi)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(35, 30)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(495, 391)
        Me.groupBox1.TabIndex = 35
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Sınıf İşlemleri"
        '
        'btnsinifsil
        '
        Me.btnsinifsil.BackColor = System.Drawing.Color.IndianRed
        Me.btnsinifsil.Image = CType(resources.GetObject("btnsinifsil.Image"), System.Drawing.Image)
        Me.btnsinifsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsinifsil.Location = New System.Drawing.Point(328, 302)
        Me.btnsinifsil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsinifsil.Name = "btnsinifsil"
        Me.btnsinifsil.Size = New System.Drawing.Size(156, 52)
        Me.btnsinifsil.TabIndex = 25
        Me.btnsinifsil.Text = "SİL"
        Me.btnsinifsil.UseVisualStyleBackColor = False
        '
        'cmbogretmen
        '
        Me.cmbogretmen.DataSource = Me.OgretmenBindingSource
        Me.cmbogretmen.DisplayMember = "ADSOYAD"
        Me.cmbogretmen.FormattingEnabled = True
        Me.cmbogretmen.Location = New System.Drawing.Point(105, 219)
        Me.cmbogretmen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbogretmen.Name = "cmbogretmen"
        Me.cmbogretmen.Size = New System.Drawing.Size(212, 27)
        Me.cmbogretmen.TabIndex = 40
        Me.cmbogretmen.ValueMember = "OgretmenID"
        '
        'btnsinifguncelle
        '
        Me.btnsinifguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnsinifguncelle.Image = CType(resources.GetObject("btnsinifguncelle.Image"), System.Drawing.Image)
        Me.btnsinifguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsinifguncelle.Location = New System.Drawing.Point(164, 302)
        Me.btnsinifguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsinifguncelle.Name = "btnsinifguncelle"
        Me.btnsinifguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnsinifguncelle.TabIndex = 26
        Me.btnsinifguncelle.Text = "Güncelle"
        Me.btnsinifguncelle.UseVisualStyleBackColor = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(-5, 220)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(107, 25)
        Me.label10.TabIndex = 39
        Me.label10.Text = "Öğretmen:"
        '
        'cmbdonem
        '
        Me.cmbdonem.FormattingEnabled = True
        Me.cmbdonem.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        Me.cmbdonem.Location = New System.Drawing.Point(105, 156)
        Me.cmbdonem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbdonem.Name = "cmbdonem"
        Me.cmbdonem.Size = New System.Drawing.Size(212, 27)
        Me.cmbdonem.TabIndex = 36
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(-5, 158)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(82, 25)
        Me.label6.TabIndex = 35
        Me.label6.Text = "Dönem:"
        '
        'txtkontenjan
        '
        Me.txtkontenjan.Location = New System.Drawing.Point(105, 103)
        Me.txtkontenjan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkontenjan.Name = "txtkontenjan"
        Me.txtkontenjan.Size = New System.Drawing.Size(212, 26)
        Me.txtkontenjan.TabIndex = 26
        '
        'btnsinifekle
        '
        Me.btnsinifekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnsinifekle.Image = CType(resources.GetObject("btnsinifekle.Image"), System.Drawing.Image)
        Me.btnsinifekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsinifekle.Location = New System.Drawing.Point(4, 302)
        Me.btnsinifekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsinifekle.Name = "btnsinifekle"
        Me.btnsinifekle.Size = New System.Drawing.Size(156, 52)
        Me.btnsinifekle.TabIndex = 25
        Me.btnsinifekle.Text = "Ekle"
        Me.btnsinifekle.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(-5, 105)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(109, 25)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Kontenjan:"
        '
        'txtsinifadi
        '
        Me.txtsinifadi.Location = New System.Drawing.Point(105, 38)
        Me.txtsinifadi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsinifadi.Name = "txtsinifadi"
        Me.txtsinifadi.Size = New System.Drawing.Size(212, 26)
        Me.txtsinifadi.TabIndex = 14
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(-5, 36)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 25)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Sınıf Adı:"
        '
        'AnaokuludbDataSet6
        '
        Me.AnaokuludbDataSet6.DataSetName = "AnaokuludbDataSet6"
        Me.AnaokuludbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OgretmenBindingSource
        '
        Me.OgretmenBindingSource.DataMember = "Ogretmen"
        Me.OgretmenBindingSource.DataSource = Me.AnaokuludbDataSet6
        '
        'OgretmenTableAdapter
        '
        Me.OgretmenTableAdapter.ClearBeforeFill = True
        '
        'FrmSinifBilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1472, 667)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSinifBilgileri"
        Me.Text = "Sınıf Bilgileri"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.dtgsinif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.AnaokuludbDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OgretmenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox3 As GroupBox
    Private WithEvents cmbdonemara As ComboBox
    Private WithEvents label8 As Label
    Private WithEvents btnara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents txtsinifadiara As TextBox
    Private WithEvents label5 As Label
    Private WithEvents dtgsinif As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnsinifsil As Button
    Private WithEvents cmbogretmen As ComboBox
    Private WithEvents btnsinifguncelle As Button
    Private WithEvents label10 As Label
    Private WithEvents cmbdonem As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents txtkontenjan As TextBox
    Private WithEvents btnsinifekle As Button
    Private WithEvents label2 As Label
    Private WithEvents txtsinifadi As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents AnaokuludbDataSet6 As AnaokuludbDataSet6
    Friend WithEvents OgretmenBindingSource As BindingSource
    Friend WithEvents OgretmenTableAdapter As AnaokuludbDataSet6TableAdapters.OgretmenTableAdapter
End Class

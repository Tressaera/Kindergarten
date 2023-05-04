<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmenYemekBildirimi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenYemekBildirimi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbadsoyad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbyemekyedimi = New System.Windows.Forms.ComboBox()
        Me.btnyemekbildirimiekle = New System.Windows.Forms.Button()
        Me.btnyemekbildirimguncelle = New System.Windows.Forms.Button()
        Me.btnyemekbildirimsil = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dttarihara = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtgridyemekbildirim = New System.Windows.Forms.DataGridView()
        Me.AnaokuludbDataSet5 = New Kindergartens.AnaokuludbDataSet5()
        Me.OgrenciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OgrenciTableAdapter = New Kindergartens.AnaokuludbDataSet5TableAdapters.OgrenciTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgridyemekbildirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaokuludbDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnyemekbildirimsil)
        Me.GroupBox1.Controls.Add(Me.btnyemekbildirimguncelle)
        Me.GroupBox1.Controls.Add(Me.btnyemekbildirimiekle)
        Me.GroupBox1.Controls.Add(Me.cmbyemekyedimi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbadsoyad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dttarih)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 330)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Yemek Bildirimi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarih:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(191, 37)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(300, 24)
        Me.dttarih.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ad-Soyad:"
        '
        'cmbadsoyad
        '
        Me.cmbadsoyad.FormattingEnabled = True
        Me.cmbadsoyad.Location = New System.Drawing.Point(191, 86)
        Me.cmbadsoyad.Name = "cmbadsoyad"
        Me.cmbadsoyad.Size = New System.Drawing.Size(300, 26)
        Me.cmbadsoyad.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Yemeğini Yedi mi:"
        '
        'cmbyemekyedimi
        '
        Me.cmbyemekyedimi.FormattingEnabled = True
        Me.cmbyemekyedimi.Location = New System.Drawing.Point(191, 148)
        Me.cmbyemekyedimi.Name = "cmbyemekyedimi"
        Me.cmbyemekyedimi.Size = New System.Drawing.Size(300, 26)
        Me.cmbyemekyedimi.TabIndex = 2
        '
        'btnyemekbildirimiekle
        '
        Me.btnyemekbildirimiekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnyemekbildirimiekle.FlatAppearance.BorderSize = 0
        Me.btnyemekbildirimiekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyemekbildirimiekle.Image = CType(resources.GetObject("btnyemekbildirimiekle.Image"), System.Drawing.Image)
        Me.btnyemekbildirimiekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyemekbildirimiekle.Location = New System.Drawing.Point(12, 215)
        Me.btnyemekbildirimiekle.Name = "btnyemekbildirimiekle"
        Me.btnyemekbildirimiekle.Size = New System.Drawing.Size(147, 52)
        Me.btnyemekbildirimiekle.TabIndex = 3
        Me.btnyemekbildirimiekle.Text = "Ekle"
        Me.btnyemekbildirimiekle.UseVisualStyleBackColor = False
        '
        'btnyemekbildirimguncelle
        '
        Me.btnyemekbildirimguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnyemekbildirimguncelle.FlatAppearance.BorderSize = 0
        Me.btnyemekbildirimguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyemekbildirimguncelle.Image = CType(resources.GetObject("btnyemekbildirimguncelle.Image"), System.Drawing.Image)
        Me.btnyemekbildirimguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyemekbildirimguncelle.Location = New System.Drawing.Point(181, 215)
        Me.btnyemekbildirimguncelle.Name = "btnyemekbildirimguncelle"
        Me.btnyemekbildirimguncelle.Size = New System.Drawing.Size(147, 52)
        Me.btnyemekbildirimguncelle.TabIndex = 3
        Me.btnyemekbildirimguncelle.Text = "Güncelle"
        Me.btnyemekbildirimguncelle.UseVisualStyleBackColor = False
        '
        'btnyemekbildirimsil
        '
        Me.btnyemekbildirimsil.BackColor = System.Drawing.Color.Red
        Me.btnyemekbildirimsil.FlatAppearance.BorderSize = 0
        Me.btnyemekbildirimsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyemekbildirimsil.ForeColor = System.Drawing.Color.White
        Me.btnyemekbildirimsil.Image = CType(resources.GetObject("btnyemekbildirimsil.Image"), System.Drawing.Image)
        Me.btnyemekbildirimsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyemekbildirimsil.Location = New System.Drawing.Point(352, 215)
        Me.btnyemekbildirimsil.Name = "btnyemekbildirimsil"
        Me.btnyemekbildirimsil.Size = New System.Drawing.Size(147, 52)
        Me.btnyemekbildirimsil.TabIndex = 3
        Me.btnyemekbildirimsil.Text = "Sil"
        Me.btnyemekbildirimsil.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtgridyemekbildirim)
        Me.GroupBox2.Controls.Add(Me.btnyenile)
        Me.GroupBox2.Controls.Add(Me.btnara)
        Me.GroupBox2.Controls.Add(Me.dttarihara)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(566, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(798, 529)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Yemek Bildirimi Ara"
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.FlatAppearance.BorderSize = 0
        Me.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyenile.Image = CType(resources.GetObject("btnyenile.Image"), System.Drawing.Image)
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(360, 86)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(147, 52)
        Me.btnyenile.TabIndex = 3
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.FlatAppearance.BorderSize = 0
        Me.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnara.Image = CType(resources.GetObject("btnara.Image"), System.Drawing.Image)
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(191, 86)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(147, 52)
        Me.btnara.TabIndex = 3
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dttarihara
        '
        Me.dttarihara.Location = New System.Drawing.Point(191, 37)
        Me.dttarihara.Name = "dttarihara"
        Me.dttarihara.Size = New System.Drawing.Size(300, 24)
        Me.dttarihara.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tarih:"
        '
        'dtgridyemekbildirim
        '
        Me.dtgridyemekbildirim.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgridyemekbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridyemekbildirim.Location = New System.Drawing.Point(12, 143)
        Me.dtgridyemekbildirim.Name = "dtgridyemekbildirim"
        Me.dtgridyemekbildirim.RowHeadersWidth = 51
        Me.dtgridyemekbildirim.RowTemplate.Height = 24
        Me.dtgridyemekbildirim.Size = New System.Drawing.Size(780, 380)
        Me.dtgridyemekbildirim.TabIndex = 4
        '
        'AnaokuludbDataSet5
        '
        Me.AnaokuludbDataSet5.DataSetName = "AnaokuludbDataSet5"
        Me.AnaokuludbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OgrenciBindingSource
        '
        Me.OgrenciBindingSource.DataMember = "Ogrenci"
        Me.OgrenciBindingSource.DataSource = Me.AnaokuludbDataSet5
        '
        'OgrenciTableAdapter
        '
        Me.OgrenciTableAdapter.ClearBeforeFill = True
        '
        'FrmOgretmenYemekBildirimi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1444, 554)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmenYemekBildirimi"
        Me.Text = "Öğretmen Yemek Bildirimi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgridyemekbildirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaokuludbDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnyemekbildirimsil As Button
    Friend WithEvents btnyemekbildirimguncelle As Button
    Friend WithEvents btnyemekbildirimiekle As Button
    Friend WithEvents cmbyemekyedimi As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbadsoyad As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dttarih As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtgridyemekbildirim As DataGridView
    Friend WithEvents btnyenile As Button
    Friend WithEvents btnara As Button
    Friend WithEvents dttarihara As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents AnaokuludbDataSet5 As AnaokuludbDataSet5
    Friend WithEvents OgrenciBindingSource As BindingSource
    Friend WithEvents OgrenciTableAdapter As AnaokuludbDataSet5TableAdapters.OgrenciTableAdapter
End Class

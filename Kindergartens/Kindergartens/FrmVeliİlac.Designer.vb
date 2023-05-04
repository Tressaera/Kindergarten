<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVeliİlac
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliİlac))
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtgridilac = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.cmbadsoyad = New System.Windows.Forms.ComboBox()
        Me.btnilacguncelle = New System.Windows.Forms.Button()
        Me.btnilacekle = New System.Windows.Forms.Button()
        Me.rchaciklama = New System.Windows.Forms.RichTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtilac = New System.Windows.Forms.TextBox()
        Me.AnaokuludbDataSet11 = New Kindergartens.AnaokuludbDataSet11()
        Me.OgrenciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OgrenciTableAdapter = New Kindergartens.AnaokuludbDataSet11TableAdapters.OgrenciTableAdapter()
        Me.groupBox3.SuspendLayout()
        CType(Me.dtgridilac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.AnaokuludbDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.dtgridilac)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(585, 23)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Size = New System.Drawing.Size(716, 410)
        Me.groupBox3.TabIndex = 4
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "İlaç Listesi"
        '
        'dtgridilac
        '
        Me.dtgridilac.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridilac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridilac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgridilac.Location = New System.Drawing.Point(4, 21)
        Me.dtgridilac.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridilac.Name = "dtgridilac"
        Me.dtgridilac.RowHeadersWidth = 51
        Me.dtgridilac.Size = New System.Drawing.Size(708, 385)
        Me.dtgridilac.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnSil)
        Me.groupBox1.Controls.Add(Me.cmbadsoyad)
        Me.groupBox1.Controls.Add(Me.btnilacguncelle)
        Me.groupBox1.Controls.Add(Me.btnilacekle)
        Me.groupBox1.Controls.Add(Me.rchaciklama)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtilac)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(21, 23)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(523, 410)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "İlaç Ekle"
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.Color.IndianRed
        Me.btnSil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSil.Location = New System.Drawing.Point(367, 358)
        Me.btnSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(156, 52)
        Me.btnSil.TabIndex = 25
        Me.btnSil.Text = "SİL"
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'cmbadsoyad
        '
        Me.cmbadsoyad.DataSource = Me.OgrenciBindingSource
        Me.cmbadsoyad.DisplayMember = "ADSOYAD"
        Me.cmbadsoyad.FormattingEnabled = True
        Me.cmbadsoyad.Location = New System.Drawing.Point(188, 21)
        Me.cmbadsoyad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbadsoyad.Name = "cmbadsoyad"
        Me.cmbadsoyad.Size = New System.Drawing.Size(188, 26)
        Me.cmbadsoyad.TabIndex = 30
        Me.cmbadsoyad.ValueMember = "OgrID"
        '
        'btnilacguncelle
        '
        Me.btnilacguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnilacguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnilacguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnilacguncelle.Location = New System.Drawing.Point(188, 358)
        Me.btnilacguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnilacguncelle.Name = "btnilacguncelle"
        Me.btnilacguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnilacguncelle.TabIndex = 30
        Me.btnilacguncelle.Text = "Güncelle"
        Me.btnilacguncelle.UseVisualStyleBackColor = False
        '
        'btnilacekle
        '
        Me.btnilacekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnilacekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnilacekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnilacekle.Location = New System.Drawing.Point(8, 358)
        Me.btnilacekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnilacekle.Name = "btnilacekle"
        Me.btnilacekle.Size = New System.Drawing.Size(156, 52)
        Me.btnilacekle.TabIndex = 29
        Me.btnilacekle.Text = "Ekle"
        Me.btnilacekle.UseVisualStyleBackColor = False
        '
        'rchaciklama
        '
        Me.rchaciklama.Location = New System.Drawing.Point(188, 133)
        Me.rchaciklama.Margin = New System.Windows.Forms.Padding(4)
        Me.rchaciklama.Name = "rchaciklama"
        Me.rchaciklama.Size = New System.Drawing.Size(189, 165)
        Me.rchaciklama.TabIndex = 28
        Me.rchaciklama.Text = ""
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(-5, 25)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(180, 25)
        Me.label2.TabIndex = 26
        Me.label2.Text = "Öğrenci Ad-Soyad:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(-5, 118)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(97, 25)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Açıklama:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(-5, 64)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(82, 25)
        Me.label3.TabIndex = 23
        Me.label3.Text = "İlaç Adı:"
        '
        'txtilac
        '
        Me.txtilac.Location = New System.Drawing.Point(188, 64)
        Me.txtilac.Margin = New System.Windows.Forms.Padding(4)
        Me.txtilac.Name = "txtilac"
        Me.txtilac.Size = New System.Drawing.Size(189, 24)
        Me.txtilac.TabIndex = 24
        '
        'AnaokuludbDataSet11
        '
        Me.AnaokuludbDataSet11.DataSetName = "AnaokuludbDataSet11"
        Me.AnaokuludbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OgrenciBindingSource
        '
        Me.OgrenciBindingSource.DataMember = "Ogrenci"
        Me.OgrenciBindingSource.DataSource = Me.AnaokuludbDataSet11
        '
        'OgrenciTableAdapter
        '
        Me.OgrenciTableAdapter.ClearBeforeFill = True
        '
        'FrmVeliİlac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliİlac"
        Me.Text = "Veli İlaç"
        Me.groupBox3.ResumeLayout(False)
        CType(Me.dtgridilac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.AnaokuludbDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox3 As GroupBox
    Private WithEvents dtgridilac As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnSil As Button
    Private WithEvents cmbadsoyad As ComboBox
    Private WithEvents btnilacguncelle As Button
    Private WithEvents btnilacekle As Button
    Private WithEvents rchaciklama As RichTextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtilac As TextBox
    Friend WithEvents AnaokuludbDataSet11 As AnaokuludbDataSet11
    Friend WithEvents OgrenciBindingSource As BindingSource
    Friend WithEvents OgrenciTableAdapter As AnaokuludbDataSet11TableAdapters.OgrenciTableAdapter
End Class

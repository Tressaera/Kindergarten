<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmilac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmilac))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbsinif = New System.Windows.Forms.ComboBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.btnara = New System.Windows.Forms.Button()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.txtOgrenci = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.dtgridilac = New System.Windows.Forms.DataGridView()
        Me.AnaokuludbDataSet13 = New Kindergartens.AnaokuludbDataSet13()
        Me.SinifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinifTableAdapter = New Kindergartens.AnaokuludbDataSet13TableAdapters.SinifTableAdapter()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridilac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaokuludbDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cmbsinif)
        Me.groupBox1.Controls.Add(Me.label14)
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.btnyenile)
        Me.groupBox1.Controls.Add(Me.txtOgrenci)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.dtgridilac)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(145, 61)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(892, 481)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "İlaç Listesi"
        '
        'cmbsinif
        '
        Me.cmbsinif.DataSource = Me.SinifBindingSource
        Me.cmbsinif.DisplayMember = "Adi"
        Me.cmbsinif.FormattingEnabled = True
        Me.cmbsinif.Location = New System.Drawing.Point(224, 87)
        Me.cmbsinif.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsinif.Name = "cmbsinif"
        Me.cmbsinif.Size = New System.Drawing.Size(212, 27)
        Me.cmbsinif.TabIndex = 51
        Me.cmbsinif.ValueMember = "SinifID"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(9, 89)
        Me.label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(58, 25)
        Me.label14.TabIndex = 50
        Me.label14.Text = "Sınıf:"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(480, 70)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(176, 43)
        Me.btnara.TabIndex = 39
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(480, 12)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(176, 54)
        Me.btnyenile.TabIndex = 38
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'txtOgrenci
        '
        Me.txtOgrenci.Location = New System.Drawing.Point(224, 39)
        Me.txtOgrenci.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOgrenci.Name = "txtOgrenci"
        Me.txtOgrenci.Size = New System.Drawing.Size(212, 26)
        Me.txtOgrenci.TabIndex = 34
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(9, 39)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(202, 25)
        Me.label5.TabIndex = 33
        Me.label5.Text = "Öğrenci Ad ve Soyad:"
        '
        'dtgridilac
        '
        Me.dtgridilac.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridilac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridilac.Location = New System.Drawing.Point(8, 116)
        Me.dtgridilac.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridilac.Name = "dtgridilac"
        Me.dtgridilac.RowHeadersWidth = 51
        Me.dtgridilac.Size = New System.Drawing.Size(861, 358)
        Me.dtgridilac.TabIndex = 31
        '
        'AnaokuludbDataSet13
        '
        Me.AnaokuludbDataSet13.DataSetName = "AnaokuludbDataSet13"
        Me.AnaokuludbDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SinifBindingSource
        '
        Me.SinifBindingSource.DataMember = "Sinif"
        Me.SinifBindingSource.DataSource = Me.AnaokuludbDataSet13
        '
        'SinifTableAdapter
        '
        Me.SinifTableAdapter.ClearBeforeFill = True
        '
        'Frmilac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1924, 667)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmilac"
        Me.Text = "İlaç"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridilac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaokuludbDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents cmbsinif As ComboBox
    Private WithEvents label14 As Label
    Private WithEvents btnara As Button
    Private WithEvents btnyenile As Button
    Private WithEvents txtOgrenci As TextBox
    Private WithEvents label5 As Label
    Private WithEvents dtgridilac As DataGridView
    Friend WithEvents AnaokuludbDataSet13 As AnaokuludbDataSet13
    Friend WithEvents SinifBindingSource As BindingSource
    Friend WithEvents SinifTableAdapter As AnaokuludbDataSet13TableAdapters.SinifTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYoklamaListesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmYoklamaListesi))
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbsinif = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label23 = New System.Windows.Forms.Label()
        Me.dtgridYoklamaListesi = New System.Windows.Forms.DataGridView()
        Me.AnaokuludbDataSet12 = New Kindergartens.AnaokuludbDataSet12()
        Me.SinifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinifTableAdapter = New Kindergartens.AnaokuludbDataSet12TableAdapters.SinifTableAdapter()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridYoklamaListesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaokuludbDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 16
        Me.listBox1.Location = New System.Drawing.Point(988, 82)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(252, 468)
        Me.listBox1.TabIndex = 41
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(1031, 23)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(125, 55)
        Me.label5.TabIndex = 40
        Me.label5.Text = "Gelmeyen Öğrenci Listesi"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cmbsinif)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label23)
        Me.groupBox1.Controls.Add(Me.dtgridYoklamaListesi)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(28, 27)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(865, 534)
        Me.groupBox1.TabIndex = 39
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Yoklama Listesi"
        '
        'cmbsinif
        '
        Me.cmbsinif.DataSource = Me.SinifBindingSource
        Me.cmbsinif.DisplayMember = "Adi"
        Me.cmbsinif.FormattingEnabled = True
        Me.cmbsinif.Location = New System.Drawing.Point(100, 94)
        Me.cmbsinif.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsinif.Name = "cmbsinif"
        Me.cmbsinif.Size = New System.Drawing.Size(265, 25)
        Me.cmbsinif.TabIndex = 36
        Me.cmbsinif.ValueMember = "SinifID"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(32, 91)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 25)
        Me.label2.TabIndex = 34
        Me.label2.Text = "Sınıf:"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(419, 55)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(213, 52)
        Me.btnara.TabIndex = 33
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(105, 42)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(260, 23)
        Me.dttarih.TabIndex = 32
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(32, 43)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(60, 25)
        Me.label23.TabIndex = 30
        Me.label23.Text = "Tarih:"
        '
        'dtgridYoklamaListesi
        '
        Me.dtgridYoklamaListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridYoklamaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridYoklamaListesi.Location = New System.Drawing.Point(15, 134)
        Me.dtgridYoklamaListesi.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridYoklamaListesi.Name = "dtgridYoklamaListesi"
        Me.dtgridYoklamaListesi.RowHeadersWidth = 51
        Me.dtgridYoklamaListesi.Size = New System.Drawing.Size(823, 393)
        Me.dtgridYoklamaListesi.TabIndex = 0
        '
        'AnaokuludbDataSet12
        '
        Me.AnaokuludbDataSet12.DataSetName = "AnaokuludbDataSet12"
        Me.AnaokuludbDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SinifBindingSource
        '
        Me.SinifBindingSource.DataMember = "Sinif"
        Me.SinifBindingSource.DataSource = Me.AnaokuludbDataSet12
        '
        'SinifTableAdapter
        '
        Me.SinifTableAdapter.ClearBeforeFill = True
        '
        'FrmYoklamaListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmYoklamaListesi"
        Me.Text = "Yoklama Listesi"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridYoklamaListesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaokuludbDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents listBox1 As ListBox
    Private WithEvents label5 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents cmbsinif As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents btnara As Button
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label23 As Label
    Private WithEvents dtgridYoklamaListesi As DataGridView
    Friend WithEvents AnaokuludbDataSet12 As AnaokuludbDataSet12
    Friend WithEvents SinifBindingSource As BindingSource
    Friend WithEvents SinifTableAdapter As AnaokuludbDataSet12TableAdapters.SinifTableAdapter
End Class

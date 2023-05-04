<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOgretmenİlacİslem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenİlacİslem))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnara = New System.Windows.Forms.Button()
        Me.cmbsinif = New System.Windows.Forms.ComboBox()
        Me.SinifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnaokuludbDataSet1 = New Kindergartens.AnaokuludbDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgridviewİlac = New System.Windows.Forms.DataGridView()
        Me.SinifTableAdapter = New Kindergartens.AnaokuludbDataSet1TableAdapters.SinifTableAdapter()
        Me.AnaokuludbDataSet2 = New Kindergartens.AnaokuludbDataSet2()
        Me.SinifBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinifTableAdapter1 = New Kindergartens.AnaokuludbDataSet2TableAdapters.SinifTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaokuludbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgridviewİlac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaokuludbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinifBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnara)
        Me.GroupBox1.Controls.Add(Me.cmbsinif)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtgridviewİlac)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1163, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "İlaç Listesi"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnara.Image = CType(resources.GetObject("btnara.Image"), System.Drawing.Image)
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(938, 120)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(192, 52)
        Me.btnara.TabIndex = 3
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'cmbsinif
        '
        Me.cmbsinif.DataSource = Me.SinifBindingSource
        Me.cmbsinif.DisplayMember = "Adi"
        Me.cmbsinif.FormattingEnabled = True
        Me.cmbsinif.Location = New System.Drawing.Point(938, 34)
        Me.cmbsinif.Name = "cmbsinif"
        Me.cmbsinif.Size = New System.Drawing.Size(203, 26)
        Me.cmbsinif.TabIndex = 2
        Me.cmbsinif.ValueMember = "SinifID"
        '
        'SinifBindingSource
        '
        Me.SinifBindingSource.DataMember = "Sinif"
        Me.SinifBindingSource.DataSource = Me.AnaokuludbDataSet1
        '
        'AnaokuludbDataSet1
        '
        Me.AnaokuludbDataSet1.DataSetName = "AnaokuludbDataSet1"
        Me.AnaokuludbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(874, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sınıf:"
        '
        'dtgridviewİlac
        '
        Me.dtgridviewİlac.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgridviewİlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridviewİlac.Location = New System.Drawing.Point(7, 35)
        Me.dtgridviewİlac.Name = "dtgridviewİlac"
        Me.dtgridviewİlac.RowHeadersWidth = 51
        Me.dtgridviewİlac.RowTemplate.Height = 24
        Me.dtgridviewİlac.Size = New System.Drawing.Size(861, 430)
        Me.dtgridviewİlac.TabIndex = 0
        '
        'SinifTableAdapter
        '
        Me.SinifTableAdapter.ClearBeforeFill = True
        '
        'AnaokuludbDataSet2
        '
        Me.AnaokuludbDataSet2.DataSetName = "AnaokuludbDataSet2"
        Me.AnaokuludbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SinifBindingSource1
        '
        Me.SinifBindingSource1.DataMember = "Sinif"
        Me.SinifBindingSource1.DataSource = Me.AnaokuludbDataSet2
        '
        'SinifTableAdapter1
        '
        Me.SinifTableAdapter1.ClearBeforeFill = True
        '
        'FrmOgretmenİlacİslem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(1408, 667)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmenİlacİslem"
        Me.Text = "Öğretmen İlaç İşlem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaokuludbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgridviewİlac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaokuludbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinifBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnara As Button
    Friend WithEvents cmbsinif As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgridviewİlac As DataGridView
    Friend WithEvents AnaokuludbDataSet1 As AnaokuludbDataSet1
    Friend WithEvents SinifBindingSource As BindingSource
    Friend WithEvents SinifTableAdapter As AnaokuludbDataSet1TableAdapters.SinifTableAdapter
    Friend WithEvents AnaokuludbDataSet2 As AnaokuludbDataSet2
    Friend WithEvents SinifBindingSource1 As BindingSource
    Friend WithEvents SinifTableAdapter1 As AnaokuludbDataSet2TableAdapters.SinifTableAdapter
End Class

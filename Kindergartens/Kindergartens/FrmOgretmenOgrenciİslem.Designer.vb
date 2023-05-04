<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmenOgrenciİslem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenOgrenciİslem))
        Me.grpOgrenciAra = New System.Windows.Forms.GroupBox()
        Me.dtgridogrlistele = New System.Windows.Forms.DataGridView()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.btndonemiara = New System.Windows.Forms.Button()
        Me.btnsinifara = New System.Windows.Forms.Button()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.cmbsinifara = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnaokuludbDataSet7 = New Kindergartens.AnaokuludbDataSet7()
        Me.SinifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinifTableAdapter = New Kindergartens.AnaokuludbDataSet7TableAdapters.SinifTableAdapter()
        Me.grpOgrenciAra.SuspendLayout()
        CType(Me.dtgridogrlistele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaokuludbDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOgrenciAra
        '
        Me.grpOgrenciAra.Controls.Add(Me.dtgridogrlistele)
        Me.grpOgrenciAra.Controls.Add(Me.btnyenile)
        Me.grpOgrenciAra.Controls.Add(Me.btndonemiara)
        Me.grpOgrenciAra.Controls.Add(Me.btnsinifara)
        Me.grpOgrenciAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgrenciAra.Controls.Add(Me.cmbsinifara)
        Me.grpOgrenciAra.Controls.Add(Me.Label2)
        Me.grpOgrenciAra.Controls.Add(Me.Label1)
        Me.grpOgrenciAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpOgrenciAra.Location = New System.Drawing.Point(73, 15)
        Me.grpOgrenciAra.Name = "grpOgrenciAra"
        Me.grpOgrenciAra.Size = New System.Drawing.Size(1101, 512)
        Me.grpOgrenciAra.TabIndex = 0
        Me.grpOgrenciAra.TabStop = False
        Me.grpOgrenciAra.Text = "Öğrenci Ara"
        '
        'dtgridogrlistele
        '
        Me.dtgridogrlistele.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgridogrlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridogrlistele.Location = New System.Drawing.Point(5, 102)
        Me.dtgridogrlistele.Name = "dtgridogrlistele"
        Me.dtgridogrlistele.RowHeadersWidth = 51
        Me.dtgridogrlistele.RowTemplate.Height = 24
        Me.dtgridogrlistele.Size = New System.Drawing.Size(1090, 391)
        Me.dtgridogrlistele.TabIndex = 3
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = CType(resources.GetObject("btnyenile.Image"), System.Drawing.Image)
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(496, 38)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 2
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'btndonemiara
        '
        Me.btndonemiara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btndonemiara.Image = CType(resources.GetObject("btndonemiara.Image"), System.Drawing.Image)
        Me.btndonemiara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndonemiara.Location = New System.Drawing.Point(337, 65)
        Me.btndonemiara.Name = "btndonemiara"
        Me.btndonemiara.Size = New System.Drawing.Size(141, 37)
        Me.btndonemiara.TabIndex = 2
        Me.btndonemiara.Text = "Ara"
        Me.btndonemiara.UseVisualStyleBackColor = False
        '
        'btnsinifara
        '
        Me.btnsinifara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnsinifara.Image = CType(resources.GetObject("btnsinifara.Image"), System.Drawing.Image)
        Me.btnsinifara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsinifara.Location = New System.Drawing.Point(337, 20)
        Me.btnsinifara.Name = "btnsinifara"
        Me.btnsinifara.Size = New System.Drawing.Size(141, 37)
        Me.btnsinifara.TabIndex = 2
        Me.btnsinifara.Text = "Ara"
        Me.btnsinifara.UseVisualStyleBackColor = False
        '
        'cmbdonemara
        '
        Me.cmbdonemara.DataSource = Me.SinifBindingSource
        Me.cmbdonemara.DisplayMember = "Donem"
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Location = New System.Drawing.Point(131, 65)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(178, 27)
        Me.cmbdonemara.TabIndex = 1
        Me.cmbdonemara.ValueMember = "Donem"
        '
        'cmbsinifara
        '
        Me.cmbsinifara.FormattingEnabled = True
        Me.cmbsinifara.Location = New System.Drawing.Point(131, 26)
        Me.cmbsinifara.Name = "cmbsinifara"
        Me.cmbsinifara.Size = New System.Drawing.Size(178, 27)
        Me.cmbsinifara.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(32, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dönemi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sınıf:"
        '
        'AnaokuludbDataSet7
        '
        Me.AnaokuludbDataSet7.DataSetName = "AnaokuludbDataSet7"
        Me.AnaokuludbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SinifBindingSource
        '
        Me.SinifBindingSource.DataMember = "Sinif"
        Me.SinifBindingSource.DataSource = Me.AnaokuludbDataSet7
        '
        'SinifTableAdapter
        '
        Me.SinifTableAdapter.ClearBeforeFill = True
        '
        'FrmOgretmenOgrenciİslem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(1403, 667)
        Me.Controls.Add(Me.grpOgrenciAra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmenOgrenciİslem"
        Me.Text = "Öğretmen Öğrenci İşlem"
        Me.grpOgrenciAra.ResumeLayout(False)
        Me.grpOgrenciAra.PerformLayout()
        CType(Me.dtgridogrlistele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaokuludbDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOgrenciAra As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btndonemiara As Button
    Friend WithEvents btnsinifara As Button
    Friend WithEvents cmbdonemara As ComboBox
    Friend WithEvents cmbsinifara As ComboBox
    Friend WithEvents btnyenile As Button
    Friend WithEvents dtgridogrlistele As DataGridView
    Friend WithEvents AnaokuludbDataSet7 As AnaokuludbDataSet7
    Friend WithEvents SinifBindingSource As BindingSource
    Friend WithEvents SinifTableAdapter As AnaokuludbDataSet7TableAdapters.SinifTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmenVeliislem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenVeliislem))
        Me.grpOgrenciAra = New System.Windows.Forms.GroupBox()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dtgridvelilistele = New System.Windows.Forms.DataGridView()
        Me.cmbdonemara = New System.Windows.Forms.ComboBox()
        Me.txtveliadara = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnaokuludbDataSet9 = New Kindergartens.AnaokuludbDataSet9()
        Me.VeliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeliTableAdapter = New Kindergartens.AnaokuludbDataSet9TableAdapters.VeliTableAdapter()
        Me.grpOgrenciAra.SuspendLayout()
        CType(Me.dtgridvelilistele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaokuludbDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOgrenciAra
        '
        Me.grpOgrenciAra.Controls.Add(Me.btnyenile)
        Me.grpOgrenciAra.Controls.Add(Me.btnara)
        Me.grpOgrenciAra.Controls.Add(Me.dtgridvelilistele)
        Me.grpOgrenciAra.Controls.Add(Me.cmbdonemara)
        Me.grpOgrenciAra.Controls.Add(Me.txtveliadara)
        Me.grpOgrenciAra.Controls.Add(Me.Label2)
        Me.grpOgrenciAra.Controls.Add(Me.Label1)
        Me.grpOgrenciAra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpOgrenciAra.Location = New System.Drawing.Point(129, 15)
        Me.grpOgrenciAra.Name = "grpOgrenciAra"
        Me.grpOgrenciAra.Size = New System.Drawing.Size(1043, 501)
        Me.grpOgrenciAra.TabIndex = 0
        Me.grpOgrenciAra.TabStop = False
        Me.grpOgrenciAra.Text = "Veli Ara"
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = CType(resources.GetObject("btnyenile.Image"), System.Drawing.Image)
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(579, 37)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(171, 45)
        Me.btnyenile.TabIndex = 4
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = CType(resources.GetObject("btnara.Image"), System.Drawing.Image)
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(383, 37)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(171, 45)
        Me.btnara.TabIndex = 4
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dtgridvelilistele
        '
        Me.dtgridvelilistele.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgridvelilistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridvelilistele.Location = New System.Drawing.Point(7, 107)
        Me.dtgridvelilistele.Name = "dtgridvelilistele"
        Me.dtgridvelilistele.RowHeadersWidth = 51
        Me.dtgridvelilistele.RowTemplate.Height = 24
        Me.dtgridvelilistele.Size = New System.Drawing.Size(1039, 386)
        Me.dtgridvelilistele.TabIndex = 3
        '
        'cmbdonemara
        '
        Me.cmbdonemara.DataSource = Me.VeliBindingSource
        Me.cmbdonemara.DisplayMember = "Donemi"
        Me.cmbdonemara.FormattingEnabled = True
        Me.cmbdonemara.Location = New System.Drawing.Point(141, 77)
        Me.cmbdonemara.Name = "cmbdonemara"
        Me.cmbdonemara.Size = New System.Drawing.Size(220, 27)
        Me.cmbdonemara.TabIndex = 2
        Me.cmbdonemara.ValueMember = "Donemi"
        '
        'txtveliadara
        '
        Me.txtveliadara.Location = New System.Drawing.Point(141, 37)
        Me.txtveliadara.Name = "txtveliadara"
        Me.txtveliadara.Size = New System.Drawing.Size(220, 26)
        Me.txtveliadara.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dönemi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ad-Soyad:"
        '
        'AnaokuludbDataSet9
        '
        Me.AnaokuludbDataSet9.DataSetName = "AnaokuludbDataSet9"
        Me.AnaokuludbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VeliBindingSource
        '
        Me.VeliBindingSource.DataMember = "Veli"
        Me.VeliBindingSource.DataSource = Me.AnaokuludbDataSet9
        '
        'VeliTableAdapter
        '
        Me.VeliTableAdapter.ClearBeforeFill = True
        '
        'FrmOgretmenVeliislem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1371, 667)
        Me.Controls.Add(Me.grpOgrenciAra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmenVeliislem"
        Me.Text = "FrmOgretmenVeliislem"
        Me.grpOgrenciAra.ResumeLayout(False)
        Me.grpOgrenciAra.PerformLayout()
        CType(Me.dtgridvelilistele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaokuludbDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOgrenciAra As GroupBox
    Friend WithEvents dtgridvelilistele As DataGridView
    Friend WithEvents cmbdonemara As ComboBox
    Friend WithEvents txtveliadara As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnyenile As Button
    Friend WithEvents btnara As Button
    Friend WithEvents AnaokuludbDataSet9 As AnaokuludbDataSet9
    Friend WithEvents VeliBindingSource As BindingSource
    Friend WithEvents VeliTableAdapter As AnaokuludbDataSet9TableAdapters.VeliTableAdapter
End Class

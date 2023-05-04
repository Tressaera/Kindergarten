<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliÖdemeler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliÖdemeler))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label17 = New System.Windows.Forms.Label()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dtgridodemeler = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridodemeler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label17)
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.dtgridodemeler)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(297, 83)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(788, 500)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Ödemeler"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(185, 53)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(252, 24)
        Me.dttarih.TabIndex = 58
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(43, 55)
        Me.label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(60, 25)
        Me.label17.TabIndex = 57
        Me.label17.Text = "Tarih:"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(527, 42)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(119, 52)
        Me.btnara.TabIndex = 56
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dtgridodemeler
        '
        Me.dtgridodemeler.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridodemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridodemeler.Location = New System.Drawing.Point(0, 126)
        Me.dtgridodemeler.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridodemeler.Name = "dtgridodemeler"
        Me.dtgridodemeler.RowHeadersWidth = 51
        Me.dtgridodemeler.Size = New System.Drawing.Size(788, 374)
        Me.dtgridodemeler.TabIndex = 0
        '
        'FrmVeliÖdemeler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliÖdemeler"
        Me.Text = "Veli Ödemeler"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridodemeler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label17 As Label
    Private WithEvents btnara As Button
    Private WithEvents dtgridodemeler As DataGridView
End Class

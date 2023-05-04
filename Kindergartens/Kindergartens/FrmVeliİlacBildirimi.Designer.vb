<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliİlacBildirimi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliİlacBildirimi))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnara = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.dtgridilacbildirim = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridilacbildirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.dtgridilacbildirim)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(321, 56)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(740, 443)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "İlaç Bildirimi"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(388, 41)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(140, 52)
        Me.btnara.TabIndex = 44
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Location = New System.Drawing.Point(36, 53)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 28)
        Me.label2.TabIndex = 43
        Me.label2.Text = "Tarih:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(113, 52)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(265, 24)
        Me.dttarih.TabIndex = 42
        '
        'dtgridilacbildirim
        '
        Me.dtgridilacbildirim.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridilacbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridilacbildirim.Location = New System.Drawing.Point(8, 118)
        Me.dtgridilacbildirim.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridilacbildirim.Name = "dtgridilacbildirim"
        Me.dtgridilacbildirim.RowHeadersWidth = 51
        Me.dtgridilacbildirim.Size = New System.Drawing.Size(708, 318)
        Me.dtgridilacbildirim.TabIndex = 0
        '
        'FrmVeliİlacBildirimi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliİlacBildirimi"
        Me.Text = "Veli İlaç Bildirimi"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridilacbildirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnara As Button
    Private WithEvents label2 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents dtgridilacbildirim As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliDuyuru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliDuyuru))
        Me.rchicerik = New System.Windows.Forms.RichTextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtduyurubaslik = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnara = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.dtgridviewduyuru = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridviewduyuru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rchicerik
        '
        Me.rchicerik.Enabled = False
        Me.rchicerik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rchicerik.Location = New System.Drawing.Point(858, 87)
        Me.rchicerik.Margin = New System.Windows.Forms.Padding(4)
        Me.rchicerik.Name = "rchicerik"
        Me.rchicerik.Size = New System.Drawing.Size(405, 461)
        Me.rchicerik.TabIndex = 27
        Me.rchicerik.Text = ""
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(700, 87)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(145, 25)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Duyuru İçeriği:"
        '
        'txtduyurubaslik
        '
        Me.txtduyurubaslik.Enabled = False
        Me.txtduyurubaslik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtduyurubaslik.Location = New System.Drawing.Point(861, 39)
        Me.txtduyurubaslik.Margin = New System.Windows.Forms.Padding(4)
        Me.txtduyurubaslik.Name = "txtduyurubaslik"
        Me.txtduyurubaslik.Size = New System.Drawing.Size(252, 30)
        Me.txtduyurubaslik.TabIndex = 25
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(700, 39)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(147, 25)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Duyuru Başlığı:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.dtgridviewduyuru)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(21, 55)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(673, 473)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Duyuru"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(429, 21)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(140, 52)
        Me.btnara.TabIndex = 38
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Location = New System.Drawing.Point(25, 34)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 28)
        Me.label2.TabIndex = 37
        Me.label2.Text = "Tarih:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(103, 33)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(265, 24)
        Me.dttarih.TabIndex = 36
        '
        'dtgridviewduyuru
        '
        Me.dtgridviewduyuru.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridviewduyuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridviewduyuru.Location = New System.Drawing.Point(0, 80)
        Me.dtgridviewduyuru.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridviewduyuru.Name = "dtgridviewduyuru"
        Me.dtgridviewduyuru.RowHeadersWidth = 51
        Me.dtgridviewduyuru.Size = New System.Drawing.Size(673, 393)
        Me.dtgridviewduyuru.TabIndex = 0
        '
        'FrmVeliDuyuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(1356, 667)
        Me.Controls.Add(Me.rchicerik)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtduyurubaslik)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliDuyuru"
        Me.Text = "Veli Duyuru"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridviewduyuru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents rchicerik As RichTextBox
    Private WithEvents label3 As Label
    Private WithEvents txtduyurubaslik As TextBox
    Private WithEvents label1 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnara As Button
    Private WithEvents label2 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents dtgridviewduyuru As DataGridView
End Class

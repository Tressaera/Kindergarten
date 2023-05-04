<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliEtkinlik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliEtkinlik))
        Me.rchetkinlikbilgi = New System.Windows.Forms.RichTextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtetkinlikbaslik = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.dtgridEtkinlik = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridEtkinlik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rchetkinlikbilgi
        '
        Me.rchetkinlikbilgi.Enabled = False
        Me.rchetkinlikbilgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rchetkinlikbilgi.Location = New System.Drawing.Point(1031, 79)
        Me.rchetkinlikbilgi.Margin = New System.Windows.Forms.Padding(4)
        Me.rchetkinlikbilgi.Name = "rchetkinlikbilgi"
        Me.rchetkinlikbilgi.Size = New System.Drawing.Size(252, 457)
        Me.rchetkinlikbilgi.TabIndex = 27
        Me.rchetkinlikbilgi.Text = ""
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(891, 79)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(127, 25)
        Me.label5.TabIndex = 26
        Me.label5.Text = "Etkinlik Bilgi:"
        '
        'txtetkinlikbaslik
        '
        Me.txtetkinlikbaslik.Enabled = False
        Me.txtetkinlikbaslik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtetkinlikbaslik.Location = New System.Drawing.Point(1030, 36)
        Me.txtetkinlikbaslik.Margin = New System.Windows.Forms.Padding(4)
        Me.txtetkinlikbaslik.Name = "txtetkinlikbaslik"
        Me.txtetkinlikbaslik.Size = New System.Drawing.Size(252, 30)
        Me.txtetkinlikbaslik.TabIndex = 25
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(891, 34)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(145, 25)
        Me.label7.TabIndex = 24
        Me.label7.Text = "Etkinlik Başlığı:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.dtgridEtkinlik)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(13, 24)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(877, 550)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Etkinlik"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(460, 18)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(119, 52)
        Me.btnara.TabIndex = 49
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(143, 30)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(252, 24)
        Me.dttarih.TabIndex = 40
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(8, 32)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(60, 25)
        Me.label6.TabIndex = 39
        Me.label6.Text = "Tarih:"
        '
        'dtgridEtkinlik
        '
        Me.dtgridEtkinlik.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridEtkinlik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridEtkinlik.Location = New System.Drawing.Point(0, 78)
        Me.dtgridEtkinlik.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridEtkinlik.Name = "dtgridEtkinlik"
        Me.dtgridEtkinlik.RowHeadersWidth = 51
        Me.dtgridEtkinlik.Size = New System.Drawing.Size(869, 434)
        Me.dtgridEtkinlik.TabIndex = 0
        '
        'FrmVeliEtkinlik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1360, 667)
        Me.Controls.Add(Me.rchetkinlikbilgi)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtetkinlikbaslik)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliEtkinlik"
        Me.Text = "Veli Etkinlik"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridEtkinlik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents rchetkinlikbilgi As RichTextBox
    Private WithEvents label5 As Label
    Private WithEvents txtetkinlikbaslik As TextBox
    Private WithEvents label7 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnara As Button
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label6 As Label
    Private WithEvents dtgridEtkinlik As DataGridView
End Class

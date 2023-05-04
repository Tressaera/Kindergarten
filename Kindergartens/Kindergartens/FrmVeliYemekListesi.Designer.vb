<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliYemekListesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliYemekListesi))
        Me.rchikindi = New System.Windows.Forms.RichTextBox()
        Me.rchogle = New System.Windows.Forms.RichTextBox()
        Me.rchsabah = New System.Windows.Forms.RichTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnara = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.dtgridyemeklistesi = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridyemeklistesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rchikindi
        '
        Me.rchikindi.Enabled = False
        Me.rchikindi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rchikindi.Location = New System.Drawing.Point(1011, 343)
        Me.rchikindi.Margin = New System.Windows.Forms.Padding(4)
        Me.rchikindi.Name = "rchikindi"
        Me.rchikindi.Size = New System.Drawing.Size(197, 169)
        Me.rchikindi.TabIndex = 33
        Me.rchikindi.Text = ""
        '
        'rchogle
        '
        Me.rchogle.Enabled = False
        Me.rchogle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rchogle.Location = New System.Drawing.Point(1011, 171)
        Me.rchogle.Margin = New System.Windows.Forms.Padding(4)
        Me.rchogle.Name = "rchogle"
        Me.rchogle.Size = New System.Drawing.Size(197, 148)
        Me.rchogle.TabIndex = 32
        Me.rchogle.Text = ""
        '
        'rchsabah
        '
        Me.rchsabah.Enabled = False
        Me.rchsabah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rchsabah.Location = New System.Drawing.Point(1011, 22)
        Me.rchsabah.Margin = New System.Windows.Forms.Padding(4)
        Me.rchsabah.Name = "rchsabah"
        Me.rchsabah.Size = New System.Drawing.Size(197, 130)
        Me.rchsabah.TabIndex = 31
        Me.rchsabah.Text = ""
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(923, 26)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 25)
        Me.label1.TabIndex = 28
        Me.label1.Text = "Sabah:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(915, 343)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 25)
        Me.label3.TabIndex = 30
        Me.label3.Text = "İkindi:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(925, 187)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 25)
        Me.label4.TabIndex = 29
        Me.label4.Text = "Öğle:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.dtgridyemeklistesi)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(17, 26)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(899, 524)
        Me.groupBox1.TabIndex = 27
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Yemek Listesi"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(456, 42)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(140, 52)
        Me.btnara.TabIndex = 41
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Location = New System.Drawing.Point(52, 55)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 28)
        Me.label2.TabIndex = 40
        Me.label2.Text = "Tarih:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(129, 54)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(265, 24)
        Me.dttarih.TabIndex = 39
        '
        'dtgridyemeklistesi
        '
        Me.dtgridyemeklistesi.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridyemeklistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridyemeklistesi.Location = New System.Drawing.Point(0, 134)
        Me.dtgridyemeklistesi.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridyemeklistesi.Name = "dtgridyemeklistesi"
        Me.dtgridyemeklistesi.RowHeadersWidth = 51
        Me.dtgridyemeklistesi.Size = New System.Drawing.Size(893, 383)
        Me.dtgridyemeklistesi.TabIndex = 0
        '
        'FrmVeliYemekListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(1369, 667)
        Me.Controls.Add(Me.rchikindi)
        Me.Controls.Add(Me.rchogle)
        Me.Controls.Add(Me.rchsabah)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliYemekListesi"
        Me.Text = "Veli Yemek Listesi"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridyemeklistesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents rchikindi As RichTextBox
    Private WithEvents rchogle As RichTextBox
    Private WithEvents rchsabah As RichTextBox
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnara As Button
    Private WithEvents label2 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents dtgridyemeklistesi As DataGridView
End Class

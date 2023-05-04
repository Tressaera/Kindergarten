<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliYemekBildirim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliYemekBildirim))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label23 = New System.Windows.Forms.Label()
        Me.dtgridyemekbildirim = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridyemekbildirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label23)
        Me.groupBox1.Controls.Add(Me.dtgridyemekbildirim)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(287, 64)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(808, 538)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Yemek Bildirimi"
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(467, 46)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(165, 52)
        Me.btnara.TabIndex = 37
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(143, 57)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(251, 24)
        Me.dttarih.TabIndex = 36
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label23.ForeColor = System.Drawing.Color.White
        Me.label23.Location = New System.Drawing.Point(56, 57)
        Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(60, 25)
        Me.label23.TabIndex = 35
        Me.label23.Text = "Tarih:"
        '
        'dtgridyemekbildirim
        '
        Me.dtgridyemekbildirim.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridyemekbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridyemekbildirim.Location = New System.Drawing.Point(0, 105)
        Me.dtgridyemekbildirim.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridyemekbildirim.Name = "dtgridyemekbildirim"
        Me.dtgridyemekbildirim.RowHeadersWidth = 51
        Me.dtgridyemekbildirim.Size = New System.Drawing.Size(788, 410)
        Me.dtgridyemekbildirim.TabIndex = 0
        '
        'FrmVeliYemekBildirim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliYemekBildirim"
        Me.Text = "Veli Yemek Bildirim"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridyemekbildirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnara As Button
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label23 As Label
    Private WithEvents dtgridyemekbildirim As DataGridView
End Class

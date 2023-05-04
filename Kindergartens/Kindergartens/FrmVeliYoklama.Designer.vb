<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliYoklama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliYoklama))
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label17 = New System.Windows.Forms.Label()
        Me.btnara = New System.Windows.Forms.Button()
        Me.dtgridYoklama = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgridYoklama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(1026, 18)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(125, 55)
        Me.label5.TabIndex = 40
        Me.label5.Text = "Gelmeyen Öğrenci Listesi"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Plum
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label17)
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.dtgridYoklama)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(331, 83)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(720, 500)
        Me.groupBox1.TabIndex = 41
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Yoklama"
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
        Me.btnara.Location = New System.Drawing.Point(501, 42)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(119, 52)
        Me.btnara.TabIndex = 56
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'dtgridYoklama
        '
        Me.dtgridYoklama.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgridYoklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridYoklama.Location = New System.Drawing.Point(8, 118)
        Me.dtgridYoklama.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridYoklama.Name = "dtgridYoklama"
        Me.dtgridYoklama.RowHeadersWidth = 51
        Me.dtgridYoklama.Size = New System.Drawing.Size(704, 374)
        Me.dtgridYoklama.TabIndex = 0
        '
        'FrmVeliYoklama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliYoklama"
        Me.Text = "Veli Yoklama"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgridYoklama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label5 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label17 As Label
    Private WithEvents btnara As Button
    Private WithEvents dtgridYoklama As DataGridView
End Class

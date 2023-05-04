<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliDersProgramı
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliDersProgramı))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.dtgriddersprogrami = New System.Windows.Forms.DataGridView()
        Me.btnara = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgriddersprogrami, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnara)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.dtgriddersprogrami)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupBox1.Location = New System.Drawing.Point(54, 48)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(1168, 524)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Ders Programı"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Location = New System.Drawing.Point(45, 64)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 28)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Tarih:"
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(123, 64)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(265, 24)
        Me.dttarih.TabIndex = 1
        '
        'dtgriddersprogrami
        '
        Me.dtgriddersprogrami.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgriddersprogrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgriddersprogrami.Location = New System.Drawing.Point(8, 176)
        Me.dtgriddersprogrami.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgriddersprogrami.Name = "dtgriddersprogrami"
        Me.dtgriddersprogrami.RowHeadersWidth = 51
        Me.dtgriddersprogrami.Size = New System.Drawing.Size(1160, 341)
        Me.dtgriddersprogrami.TabIndex = 0
        '
        'btnara
        '
        Me.btnara.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnara.Image = Global.Kindergartens.My.Resources.Resources.search
        Me.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnara.Location = New System.Drawing.Point(449, 52)
        Me.btnara.Margin = New System.Windows.Forms.Padding(4)
        Me.btnara.Name = "btnara"
        Me.btnara.Size = New System.Drawing.Size(140, 52)
        Me.btnara.TabIndex = 35
        Me.btnara.Text = "Ara"
        Me.btnara.UseVisualStyleBackColor = False
        '
        'FrmVeliDersProgramı
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1372, 667)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliDersProgramı"
        Me.Text = "Veli Ders Programı"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgriddersprogrami, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnara As Button
    Private WithEvents label2 As Label
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents dtgriddersprogrami As DataGridView
End Class

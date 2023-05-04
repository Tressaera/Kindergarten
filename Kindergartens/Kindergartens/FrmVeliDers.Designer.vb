<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVeliDers
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliDers))
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.rchaciklama = New System.Windows.Forms.RichTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dtgdersgoruntule = New System.Windows.Forms.DataGridView()
        Me.groupBox3.SuspendLayout()
        CType(Me.dtgdersgoruntule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label2)
        Me.groupBox3.Controls.Add(Me.rchaciklama)
        Me.groupBox3.Controls.Add(Me.label1)
        Me.groupBox3.Controls.Add(Me.dtgdersgoruntule)
        Me.groupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(12, 12)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Size = New System.Drawing.Size(1125, 524)
        Me.groupBox3.TabIndex = 22
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Ders"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Location = New System.Drawing.Point(691, 201)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(104, 28)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Açıklama:"
        '
        'rchaciklama
        '
        Me.rchaciklama.Enabled = False
        Me.rchaciklama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rchaciklama.Location = New System.Drawing.Point(812, 143)
        Me.rchaciklama.Margin = New System.Windows.Forms.Padding(4)
        Me.rchaciklama.Name = "rchaciklama"
        Me.rchaciklama.Size = New System.Drawing.Size(285, 162)
        Me.rchaciklama.TabIndex = 17
        Me.rchaciklama.Text = ""
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label1.Location = New System.Drawing.Point(56, 37)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(278, 28)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Öğrencinin Gördüğü Dersler"
        '
        'dtgdersgoruntule
        '
        Me.dtgdersgoruntule.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgdersgoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgdersgoruntule.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgdersgoruntule.Location = New System.Drawing.Point(40, 80)
        Me.dtgdersgoruntule.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgdersgoruntule.Name = "dtgdersgoruntule"
        Me.dtgdersgoruntule.RowHeadersWidth = 51
        Me.dtgdersgoruntule.Size = New System.Drawing.Size(643, 437)
        Me.dtgdersgoruntule.TabIndex = 15
        '
        'FrmVeliDers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1613, 667)
        Me.Controls.Add(Me.groupBox3)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliDers"
        Me.Text = "Ders İşlemleri"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.dtgdersgoruntule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox3 As GroupBox
    Private WithEvents label2 As Label
    Private WithEvents rchaciklama As RichTextBox
    Public WithEvents label1 As Label
    Private WithEvents dtgdersgoruntule As DataGridView
End Class

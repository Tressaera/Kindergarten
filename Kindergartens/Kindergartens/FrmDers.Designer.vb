<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDers))
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.txtdersara = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.dtgdersgoruntule = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnderssil = New System.Windows.Forms.Button()
        Me.btndersekle = New System.Windows.Forms.Button()
        Me.btndersguncelle = New System.Windows.Forms.Button()
        Me.rchaciklama = New System.Windows.Forms.RichTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtDersad = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox3.SuspendLayout()
        CType(Me.dtgdersgoruntule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnyenile)
        Me.groupBox3.Controls.Add(Me.txtdersara)
        Me.groupBox3.Controls.Add(Me.label5)
        Me.groupBox3.Controls.Add(Me.dtgdersgoruntule)
        Me.groupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(565, 49)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox3.Size = New System.Drawing.Size(708, 489)
        Me.groupBox3.TabIndex = 11
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Ders Ara"
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(381, 21)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 38
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'txtdersara
        '
        Me.txtdersara.Location = New System.Drawing.Point(119, 34)
        Me.txtdersara.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdersara.Name = "txtdersara"
        Me.txtdersara.Size = New System.Drawing.Size(212, 26)
        Me.txtdersara.TabIndex = 30
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(8, 32)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(92, 25)
        Me.label5.TabIndex = 29
        Me.label5.Text = "Ders Adı:"
        '
        'dtgdersgoruntule
        '
        Me.dtgdersgoruntule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgdersgoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgdersgoruntule.Location = New System.Drawing.Point(0, 80)
        Me.dtgdersgoruntule.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgdersgoruntule.Name = "dtgdersgoruntule"
        Me.dtgdersgoruntule.RowHeadersWidth = 60
        Me.dtgdersgoruntule.Size = New System.Drawing.Size(700, 401)
        Me.dtgdersgoruntule.TabIndex = 15
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnderssil)
        Me.groupBox1.Controls.Add(Me.btndersekle)
        Me.groupBox1.Controls.Add(Me.btndersguncelle)
        Me.groupBox1.Controls.Add(Me.rchaciklama)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtDersad)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(13, 36)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(519, 391)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Ders İşlemleri"
        '
        'btnderssil
        '
        Me.btnderssil.BackColor = System.Drawing.Color.IndianRed
        Me.btnderssil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnderssil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnderssil.Location = New System.Drawing.Point(359, 303)
        Me.btnderssil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnderssil.Name = "btnderssil"
        Me.btnderssil.Size = New System.Drawing.Size(156, 52)
        Me.btnderssil.TabIndex = 25
        Me.btnderssil.Text = "SİL"
        Me.btnderssil.UseVisualStyleBackColor = False
        '
        'btndersekle
        '
        Me.btndersekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btndersekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btndersekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndersekle.Location = New System.Drawing.Point(8, 303)
        Me.btndersekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btndersekle.Name = "btndersekle"
        Me.btndersekle.Size = New System.Drawing.Size(156, 52)
        Me.btndersekle.TabIndex = 25
        Me.btndersekle.Text = "Ekle"
        Me.btndersekle.UseVisualStyleBackColor = False
        '
        'btndersguncelle
        '
        Me.btndersguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btndersguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btndersguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndersguncelle.Location = New System.Drawing.Point(189, 303)
        Me.btndersguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btndersguncelle.Name = "btndersguncelle"
        Me.btndersguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btndersguncelle.TabIndex = 26
        Me.btndersguncelle.Text = "Güncelle"
        Me.btndersguncelle.UseVisualStyleBackColor = False
        '
        'rchaciklama
        '
        Me.rchaciklama.Location = New System.Drawing.Point(105, 107)
        Me.rchaciklama.Margin = New System.Windows.Forms.Padding(4)
        Me.rchaciklama.Name = "rchaciklama"
        Me.rchaciklama.Size = New System.Drawing.Size(219, 117)
        Me.rchaciklama.TabIndex = 16
        Me.rchaciklama.Text = ""
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(-5, 105)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(97, 25)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Açıklama:"
        '
        'txtDersad
        '
        Me.txtDersad.Location = New System.Drawing.Point(105, 38)
        Me.txtDersad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDersad.Name = "txtDersad"
        Me.txtDersad.Size = New System.Drawing.Size(212, 26)
        Me.txtDersad.TabIndex = 14
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(-5, 36)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 25)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Ders Adı:"
        '
        'FrmDers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1382, 667)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDers"
        Me.Text = "Ders"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.dtgdersgoruntule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox3 As GroupBox
    Private WithEvents btnyenile As Button
    Private WithEvents txtdersara As TextBox
    Private WithEvents label5 As Label
    Private WithEvents dtgdersgoruntule As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnderssil As Button
    Private WithEvents btndersekle As Button
    Private WithEvents btndersguncelle As Button
    Private WithEvents rchaciklama As RichTextBox
    Private WithEvents label2 As Label
    Private WithEvents txtDersad As TextBox
    Private WithEvents label1 As Label
End Class

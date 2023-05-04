<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGaleri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGaleri))
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.btngeri = New System.Windows.Forms.Button()
        Me.btnileri = New System.Windows.Forms.Button()
        Me.pctresim = New System.Windows.Forms.PictureBox()
        Me.btnyenile = New System.Windows.Forms.Button()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtgridresim = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnResimSil = New System.Windows.Forms.Button()
        Me.txtresimyolu = New System.Windows.Forms.TextBox()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.label11 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.btnresimekle = New System.Windows.Forms.Button()
        Me.btnresimguncelle = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtResimAdi = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.groupBox5.SuspendLayout()
        CType(Me.pctresim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        CType(Me.dtgridresim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.btngeri)
        Me.groupBox5.Controls.Add(Me.btnileri)
        Me.groupBox5.Controls.Add(Me.pctresim)
        Me.groupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox5.Location = New System.Drawing.Point(267, 301)
        Me.groupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox5.Size = New System.Drawing.Size(776, 329)
        Me.groupBox5.TabIndex = 53
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Resim Görüntüle"
        '
        'btngeri
        '
        Me.btngeri.Location = New System.Drawing.Point(59, 279)
        Me.btngeri.Margin = New System.Windows.Forms.Padding(4)
        Me.btngeri.Name = "btngeri"
        Me.btngeri.Size = New System.Drawing.Size(133, 42)
        Me.btngeri.TabIndex = 2
        Me.btngeri.Text = "Geri"
        Me.btngeri.UseVisualStyleBackColor = True
        '
        'btnileri
        '
        Me.btnileri.Location = New System.Drawing.Point(551, 279)
        Me.btnileri.Margin = New System.Windows.Forms.Padding(4)
        Me.btnileri.Name = "btnileri"
        Me.btnileri.Size = New System.Drawing.Size(133, 42)
        Me.btnileri.TabIndex = 1
        Me.btnileri.Text = "İleri"
        Me.btnileri.UseVisualStyleBackColor = True
        '
        'pctresim
        '
        Me.pctresim.Location = New System.Drawing.Point(8, 23)
        Me.pctresim.Margin = New System.Windows.Forms.Padding(4)
        Me.pctresim.Name = "pctresim"
        Me.pctresim.Size = New System.Drawing.Size(748, 249)
        Me.pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctresim.TabIndex = 0
        Me.pctresim.TabStop = False
        '
        'btnyenile
        '
        Me.btnyenile.BackColor = System.Drawing.Color.SkyBlue
        Me.btnyenile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnyenile.Image = Global.Kindergartens.My.Resources.Resources._loop
        Me.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyenile.Location = New System.Drawing.Point(1284, 143)
        Me.btnyenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyenile.Name = "btnyenile"
        Me.btnyenile.Size = New System.Drawing.Size(132, 52)
        Me.btnyenile.TabIndex = 52
        Me.btnyenile.Text = "Yenile"
        Me.btnyenile.UseVisualStyleBackColor = False
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.dtgridresim)
        Me.groupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupBox4.Location = New System.Drawing.Point(563, 45)
        Me.groupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox4.Size = New System.Drawing.Size(713, 230)
        Me.groupBox4.TabIndex = 51
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Resim Listele"
        '
        'dtgridresim
        '
        Me.dtgridresim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridresim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridresim.Location = New System.Drawing.Point(8, 22)
        Me.dtgridresim.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridresim.Name = "dtgridresim"
        Me.dtgridresim.RowHeadersWidth = 51
        Me.dtgridresim.Size = New System.Drawing.Size(697, 208)
        Me.dtgridresim.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnResimSil)
        Me.groupBox1.Controls.Add(Me.txtresimyolu)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.btnresimekle)
        Me.groupBox1.Controls.Add(Me.btnresimguncelle)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtResimAdi)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupBox1.Location = New System.Drawing.Point(-33, 45)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(555, 230)
        Me.groupBox1.TabIndex = 50
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Resim İşlemleri"
        '
        'btnResimSil
        '
        Me.btnResimSil.BackColor = System.Drawing.Color.IndianRed
        Me.btnResimSil.Image = Global.Kindergartens.My.Resources.Resources.trash
        Me.btnResimSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResimSil.Location = New System.Drawing.Point(345, 171)
        Me.btnResimSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResimSil.Name = "btnResimSil"
        Me.btnResimSil.Size = New System.Drawing.Size(156, 52)
        Me.btnResimSil.TabIndex = 28
        Me.btnResimSil.Text = "SİL"
        Me.btnResimSil.UseVisualStyleBackColor = False
        '
        'txtresimyolu
        '
        Me.txtresimyolu.Location = New System.Drawing.Point(131, 113)
        Me.txtresimyolu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtresimyolu.Name = "txtresimyolu"
        Me.txtresimyolu.Size = New System.Drawing.Size(160, 26)
        Me.txtresimyolu.TabIndex = 34
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(131, 70)
        Me.dttarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(189, 26)
        Me.dttarih.TabIndex = 33
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(8, 70)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(60, 25)
        Me.label11.TabIndex = 32
        Me.label11.Text = "Tarih:"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(300, 113)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(45, 27)
        Me.button1.TabIndex = 29
        Me.button1.Text = "..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'btnresimekle
        '
        Me.btnresimekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnresimekle.Image = Global.Kindergartens.My.Resources.Resources.insert__2_
        Me.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnresimekle.Location = New System.Drawing.Point(13, 171)
        Me.btnresimekle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnresimekle.Name = "btnresimekle"
        Me.btnresimekle.Size = New System.Drawing.Size(156, 52)
        Me.btnresimekle.TabIndex = 28
        Me.btnresimekle.Text = "Ekle"
        Me.btnresimekle.UseVisualStyleBackColor = False
        '
        'btnresimguncelle
        '
        Me.btnresimguncelle.BackColor = System.Drawing.Color.LightCyan
        Me.btnresimguncelle.Image = Global.Kindergartens.My.Resources.Resources.update
        Me.btnresimguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnresimguncelle.Location = New System.Drawing.Point(177, 171)
        Me.btnresimguncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnresimguncelle.Name = "btnresimguncelle"
        Me.btnresimguncelle.Size = New System.Drawing.Size(156, 52)
        Me.btnresimguncelle.TabIndex = 45
        Me.btnresimguncelle.Text = "Güncelle"
        Me.btnresimguncelle.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(8, 22)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(104, 25)
        Me.label3.TabIndex = 21
        Me.label3.Text = "Resim Adi:"
        '
        'txtResimAdi
        '
        Me.txtResimAdi.Location = New System.Drawing.Point(131, 22)
        Me.txtResimAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResimAdi.Name = "txtResimAdi"
        Me.txtResimAdi.Size = New System.Drawing.Size(189, 26)
        Me.txtResimAdi.TabIndex = 22
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(8, 113)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(113, 25)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Resim Yolu:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmGaleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(1924, 667)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.btnyenile)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGaleri"
        Me.Text = "Galeri"
        Me.groupBox5.ResumeLayout(False)
        CType(Me.pctresim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        CType(Me.dtgridresim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox5 As GroupBox
    Private WithEvents btngeri As Button
    Private WithEvents btnileri As Button
    Private WithEvents pctresim As PictureBox
    Private WithEvents btnyenile As Button
    Private WithEvents groupBox4 As GroupBox
    Private WithEvents dtgridresim As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnResimSil As Button
    Private WithEvents txtresimyolu As TextBox
    Private WithEvents dttarih As DateTimePicker
    Private WithEvents label11 As Label
    Private WithEvents button1 As Button
    Private WithEvents btnresimekle As Button
    Private WithEvents btnresimguncelle As Button
    Private WithEvents label3 As Label
    Private WithEvents txtResimAdi As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

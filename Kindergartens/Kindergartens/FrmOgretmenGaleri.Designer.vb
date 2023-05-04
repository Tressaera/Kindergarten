<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmenGaleri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenGaleri))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnresimekle = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.dttarih = New System.Windows.Forms.DateTimePicker()
        Me.txtresimyolu = New System.Windows.Forms.TextBox()
        Me.txtResimAdi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnileri = New System.Windows.Forms.Button()
        Me.btngeri = New System.Windows.Forms.Button()
        Me.pctresim = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.groupBox1.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        CType(Me.pctresim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnresimekle)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.dttarih)
        Me.groupBox1.Controls.Add(Me.txtresimyolu)
        Me.groupBox1.Controls.Add(Me.txtResimAdi)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.groupBox1.Location = New System.Drawing.Point(16, 90)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(353, 230)
        Me.groupBox1.TabIndex = 51
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Resim Ekle"
        '
        'btnresimekle
        '
        Me.btnresimekle.BackColor = System.Drawing.Color.YellowGreen
        Me.btnresimekle.Image = CType(resources.GetObject("btnresimekle.Image"), System.Drawing.Image)
        Me.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnresimekle.Location = New System.Drawing.Point(131, 171)
        Me.btnresimekle.Name = "btnresimekle"
        Me.btnresimekle.Size = New System.Drawing.Size(191, 52)
        Me.btnresimekle.TabIndex = 4
        Me.btnresimekle.Text = "Ekle"
        Me.btnresimekle.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(300, 114)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(45, 27)
        Me.button1.TabIndex = 3
        Me.button1.Text = "..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'dttarih
        '
        Me.dttarih.Location = New System.Drawing.Point(131, 70)
        Me.dttarih.Name = "dttarih"
        Me.dttarih.Size = New System.Drawing.Size(189, 26)
        Me.dttarih.TabIndex = 2
        '
        'txtresimyolu
        '
        Me.txtresimyolu.Location = New System.Drawing.Point(131, 115)
        Me.txtresimyolu.Name = "txtresimyolu"
        Me.txtresimyolu.Size = New System.Drawing.Size(160, 26)
        Me.txtresimyolu.TabIndex = 1
        '
        'txtResimAdi
        '
        Me.txtResimAdi.Location = New System.Drawing.Point(131, 22)
        Me.txtResimAdi.Name = "txtResimAdi"
        Me.txtResimAdi.Size = New System.Drawing.Size(189, 26)
        Me.txtResimAdi.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resim Yolu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tarih:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resim Adi:"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.btnileri)
        Me.groupBox5.Controls.Add(Me.btngeri)
        Me.groupBox5.Controls.Add(Me.pctresim)
        Me.groupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.groupBox5.Location = New System.Drawing.Point(441, 76)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(729, 294)
        Me.groupBox5.TabIndex = 52
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Resim Görüntüle"
        '
        'btnileri
        '
        Me.btnileri.Location = New System.Drawing.Point(263, 234)
        Me.btnileri.Name = "btnileri"
        Me.btnileri.Size = New System.Drawing.Size(133, 42)
        Me.btnileri.TabIndex = 1
        Me.btnileri.Text = "İleri"
        Me.btnileri.UseVisualStyleBackColor = True
        '
        'btngeri
        '
        Me.btngeri.Location = New System.Drawing.Point(82, 234)
        Me.btngeri.Name = "btngeri"
        Me.btngeri.Size = New System.Drawing.Size(133, 42)
        Me.btngeri.TabIndex = 1
        Me.btngeri.Text = "Geri"
        Me.btngeri.UseVisualStyleBackColor = True
        '
        'pctresim
        '
        Me.pctresim.Image = CType(resources.GetObject("pctresim.Image"), System.Drawing.Image)
        Me.pctresim.Location = New System.Drawing.Point(7, 24)
        Me.pctresim.Name = "pctresim"
        Me.pctresim.Size = New System.Drawing.Size(713, 204)
        Me.pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctresim.TabIndex = 0
        Me.pctresim.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmOgretmenGaleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1395, 667)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOgretmenGaleri"
        Me.Text = "Öğretmen Galeri"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        CType(Me.pctresim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents btnresimekle As Button
    Friend WithEvents button1 As Button
    Friend WithEvents dttarih As DateTimePicker
    Friend WithEvents txtresimyolu As TextBox
    Friend WithEvents txtResimAdi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents groupBox5 As GroupBox
    Friend WithEvents btnileri As Button
    Friend WithEvents btngeri As Button
    Friend WithEvents pctresim As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGiris
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGiris))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblsaat = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnYönetici = New System.Windows.Forms.Button()
        Me.txtsifreyönetici = New System.Windows.Forms.TextBox()
        Me.txtkuladyönetici = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnögretmen = New System.Windows.Forms.Button()
        Me.txtsifreogretmen = New System.Windows.Forms.TextBox()
        Me.txtkuladogretmen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnveli = New System.Windows.Forms.Button()
        Me.txtsifreveli = New System.Windows.Forms.TextBox()
        Me.txtkuladveli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblsaat
        '
        Me.lblsaat.AutoSize = True
        Me.lblsaat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblsaat.ForeColor = System.Drawing.Color.White
        Me.lblsaat.Location = New System.Drawing.Point(842, 9)
        Me.lblsaat.Name = "lblsaat"
        Me.lblsaat.Size = New System.Drawing.Size(32, 32)
        Me.lblsaat.TabIndex = 1
        Me.lblsaat.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(589, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KULLANICI GİRİŞİ"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SlateBlue
        Me.GroupBox1.Controls.Add(Me.btnYönetici)
        Me.GroupBox1.Controls.Add(Me.txtsifreyönetici)
        Me.GroupBox1.Controls.Add(Me.txtkuladyönetici)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 260)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "YÖNETİCİ GİRİŞ"
        '
        'btnYönetici
        '
        Me.btnYönetici.BackColor = System.Drawing.Color.Blue
        Me.btnYönetici.FlatAppearance.BorderSize = 0
        Me.btnYönetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYönetici.ForeColor = System.Drawing.Color.White
        Me.btnYönetici.Location = New System.Drawing.Point(157, 159)
        Me.btnYönetici.Name = "btnYönetici"
        Me.btnYönetici.Size = New System.Drawing.Size(164, 50)
        Me.btnYönetici.TabIndex = 2
        Me.btnYönetici.Text = "Giriş Yap"
        Me.btnYönetici.UseVisualStyleBackColor = False
        '
        'txtsifreyönetici
        '
        Me.txtsifreyönetici.Location = New System.Drawing.Point(132, 90)
        Me.txtsifreyönetici.Name = "txtsifreyönetici"
        Me.txtsifreyönetici.Size = New System.Drawing.Size(218, 24)
        Me.txtsifreyönetici.TabIndex = 1
        Me.txtsifreyönetici.UseSystemPasswordChar = True
        '
        'txtkuladyönetici
        '
        Me.txtkuladyönetici.Location = New System.Drawing.Point(132, 41)
        Me.txtkuladyönetici.Name = "txtkuladyönetici"
        Me.txtkuladyönetici.Size = New System.Drawing.Size(218, 24)
        Me.txtkuladyönetici.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Şifre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kullanıcı Adı:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SlateBlue
        Me.GroupBox2.Controls.Add(Me.btnögretmen)
        Me.GroupBox2.Controls.Add(Me.txtsifreogretmen)
        Me.GroupBox2.Controls.Add(Me.txtkuladogretmen)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(404, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 260)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ÖĞRETMEN GİRİŞ"
        '
        'btnögretmen
        '
        Me.btnögretmen.BackColor = System.Drawing.Color.Blue
        Me.btnögretmen.FlatAppearance.BorderSize = 0
        Me.btnögretmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnögretmen.ForeColor = System.Drawing.Color.White
        Me.btnögretmen.Location = New System.Drawing.Point(157, 159)
        Me.btnögretmen.Name = "btnögretmen"
        Me.btnögretmen.Size = New System.Drawing.Size(164, 50)
        Me.btnögretmen.TabIndex = 2
        Me.btnögretmen.Text = "Giriş Yap"
        Me.btnögretmen.UseVisualStyleBackColor = False
        '
        'txtsifreogretmen
        '
        Me.txtsifreogretmen.Location = New System.Drawing.Point(132, 90)
        Me.txtsifreogretmen.Name = "txtsifreogretmen"
        Me.txtsifreogretmen.Size = New System.Drawing.Size(218, 24)
        Me.txtsifreogretmen.TabIndex = 1
        Me.txtsifreogretmen.UseSystemPasswordChar = True
        '
        'txtkuladogretmen
        '
        Me.txtkuladogretmen.Location = New System.Drawing.Point(132, 41)
        Me.txtkuladogretmen.Name = "txtkuladogretmen"
        Me.txtkuladogretmen.Size = New System.Drawing.Size(218, 24)
        Me.txtkuladogretmen.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Şifre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kullanıcı Adı:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SlateBlue
        Me.GroupBox3.Controls.Add(Me.btnveli)
        Me.GroupBox3.Controls.Add(Me.txtsifreveli)
        Me.GroupBox3.Controls.Add(Me.txtkuladveli)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(791, 310)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 260)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VELİ GİRİŞ"
        '
        'btnveli
        '
        Me.btnveli.BackColor = System.Drawing.Color.Blue
        Me.btnveli.FlatAppearance.BorderSize = 0
        Me.btnveli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnveli.ForeColor = System.Drawing.Color.White
        Me.btnveli.Location = New System.Drawing.Point(157, 159)
        Me.btnveli.Name = "btnveli"
        Me.btnveli.Size = New System.Drawing.Size(164, 50)
        Me.btnveli.TabIndex = 2
        Me.btnveli.Text = "Giriş Yap"
        Me.btnveli.UseVisualStyleBackColor = False
        '
        'txtsifreveli
        '
        Me.txtsifreveli.Location = New System.Drawing.Point(132, 90)
        Me.txtsifreveli.Name = "txtsifreveli"
        Me.txtsifreveli.Size = New System.Drawing.Size(218, 24)
        Me.txtsifreveli.TabIndex = 1
        Me.txtsifreveli.UseSystemPasswordChar = True
        '
        'txtkuladveli
        '
        Me.txtkuladveli.Location = New System.Drawing.Point(132, 41)
        Me.txtkuladveli.Name = "txtkuladveli"
        Me.txtkuladveli.Size = New System.Drawing.Size(218, 24)
        Me.txtkuladveli.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Şifre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Kullanıcı Adı:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmGiris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1166, 655)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblsaat)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGiris"
        Me.Text = "MİNİKLER KALESİ ANAOKUL OTOMASYONU"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblsaat As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnYönetici As Button
    Friend WithEvents txtsifreyönetici As TextBox
    Friend WithEvents txtkuladyönetici As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnögretmen As Button
    Friend WithEvents txtsifreogretmen As TextBox
    Friend WithEvents txtkuladogretmen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnveli As Button
    Friend WithEvents txtsifreveli As TextBox
    Friend WithEvents txtkuladveli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class

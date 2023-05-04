<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOgretmenPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOgretmenPanel))
        Me.pnlheaderleft = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlslidebar = New System.Windows.Forms.Panel()
        Me.btnGaleri = New System.Windows.Forms.Button()
        Me.btnİlacBildirimi = New System.Windows.Forms.Button()
        Me.btnyemekbildirimi = New System.Windows.Forms.Button()
        Me.btnetkinlikler = New System.Windows.Forms.Button()
        Me.btndersprogrami = New System.Windows.Forms.Button()
        Me.btnveli = New System.Windows.Forms.Button()
        Me.btnYoklama = New System.Windows.Forms.Button()
        Me.btnİlacİslemleri = New System.Windows.Forms.Button()
        Me.btnyemeklistesi = New System.Windows.Forms.Button()
        Me.btnduyurular = New System.Windows.Forms.Button()
        Me.btnders = New System.Windows.Forms.Button()
        Me.btnogrenci = New System.Windows.Forms.Button()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.lblyazi = New System.Windows.Forms.Label()
        Me.btncikis = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pnlcontainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlheaderleft.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlslidebar.SuspendLayout()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlheaderleft
        '
        Me.pnlheaderleft.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlheaderleft.Controls.Add(Me.label1)
        Me.pnlheaderleft.Controls.Add(Me.PictureBox1)
        Me.pnlheaderleft.Location = New System.Drawing.Point(0, 0)
        Me.pnlheaderleft.Name = "pnlheaderleft"
        Me.pnlheaderleft.Size = New System.Drawing.Size(241, 135)
        Me.pnlheaderleft.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label1.Location = New System.Drawing.Point(25, 90)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(186, 24)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Öğretmen Paneli"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlslidebar
        '
        Me.pnlslidebar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.pnlslidebar.Controls.Add(Me.btnGaleri)
        Me.pnlslidebar.Controls.Add(Me.btnİlacBildirimi)
        Me.pnlslidebar.Controls.Add(Me.btnyemekbildirimi)
        Me.pnlslidebar.Controls.Add(Me.btnetkinlikler)
        Me.pnlslidebar.Controls.Add(Me.btndersprogrami)
        Me.pnlslidebar.Controls.Add(Me.btnveli)
        Me.pnlslidebar.Controls.Add(Me.btnYoklama)
        Me.pnlslidebar.Controls.Add(Me.btnİlacİslemleri)
        Me.pnlslidebar.Controls.Add(Me.btnyemeklistesi)
        Me.pnlslidebar.Controls.Add(Me.btnduyurular)
        Me.pnlslidebar.Controls.Add(Me.btnders)
        Me.pnlslidebar.Controls.Add(Me.btnogrenci)
        Me.pnlslidebar.Location = New System.Drawing.Point(0, 133)
        Me.pnlslidebar.Name = "pnlslidebar"
        Me.pnlslidebar.Size = New System.Drawing.Size(241, 674)
        Me.pnlslidebar.TabIndex = 1
        '
        'btnGaleri
        '
        Me.btnGaleri.FlatAppearance.BorderSize = 0
        Me.btnGaleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGaleri.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnGaleri.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGaleri.Image = CType(resources.GetObject("btnGaleri.Image"), System.Drawing.Image)
        Me.btnGaleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGaleri.Location = New System.Drawing.Point(0, 487)
        Me.btnGaleri.Name = "btnGaleri"
        Me.btnGaleri.Size = New System.Drawing.Size(241, 38)
        Me.btnGaleri.TabIndex = 0
        Me.btnGaleri.Text = "Galeri"
        Me.btnGaleri.UseVisualStyleBackColor = True
        '
        'btnİlacBildirimi
        '
        Me.btnİlacBildirimi.FlatAppearance.BorderSize = 0
        Me.btnİlacBildirimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnİlacBildirimi.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnİlacBildirimi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnİlacBildirimi.Image = CType(resources.GetObject("btnİlacBildirimi.Image"), System.Drawing.Image)
        Me.btnİlacBildirimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnİlacBildirimi.Location = New System.Drawing.Point(0, 399)
        Me.btnİlacBildirimi.Name = "btnİlacBildirimi"
        Me.btnİlacBildirimi.Size = New System.Drawing.Size(241, 38)
        Me.btnİlacBildirimi.TabIndex = 0
        Me.btnİlacBildirimi.Text = "İlaç Bildirimi"
        Me.btnİlacBildirimi.UseVisualStyleBackColor = True
        '
        'btnyemekbildirimi
        '
        Me.btnyemekbildirimi.FlatAppearance.BorderSize = 0
        Me.btnyemekbildirimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyemekbildirimi.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnyemekbildirimi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnyemekbildirimi.Image = CType(resources.GetObject("btnyemekbildirimi.Image"), System.Drawing.Image)
        Me.btnyemekbildirimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyemekbildirimi.Location = New System.Drawing.Point(0, 311)
        Me.btnyemekbildirimi.Name = "btnyemekbildirimi"
        Me.btnyemekbildirimi.Size = New System.Drawing.Size(241, 38)
        Me.btnyemekbildirimi.TabIndex = 0
        Me.btnyemekbildirimi.Text = "Yemek Bildirimi"
        Me.btnyemekbildirimi.UseVisualStyleBackColor = True
        '
        'btnetkinlikler
        '
        Me.btnetkinlikler.FlatAppearance.BorderSize = 0
        Me.btnetkinlikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnetkinlikler.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnetkinlikler.ForeColor = System.Drawing.SystemColors.Control
        Me.btnetkinlikler.Image = CType(resources.GetObject("btnetkinlikler.Image"), System.Drawing.Image)
        Me.btnetkinlikler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnetkinlikler.Location = New System.Drawing.Point(0, 223)
        Me.btnetkinlikler.Name = "btnetkinlikler"
        Me.btnetkinlikler.Size = New System.Drawing.Size(241, 38)
        Me.btnetkinlikler.TabIndex = 0
        Me.btnetkinlikler.Text = "Etkinlikler"
        Me.btnetkinlikler.UseVisualStyleBackColor = True
        '
        'btndersprogrami
        '
        Me.btndersprogrami.FlatAppearance.BorderSize = 0
        Me.btndersprogrami.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndersprogrami.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btndersprogrami.ForeColor = System.Drawing.SystemColors.Control
        Me.btndersprogrami.Image = CType(resources.GetObject("btndersprogrami.Image"), System.Drawing.Image)
        Me.btndersprogrami.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndersprogrami.Location = New System.Drawing.Point(0, 135)
        Me.btndersprogrami.Name = "btndersprogrami"
        Me.btndersprogrami.Size = New System.Drawing.Size(241, 38)
        Me.btndersprogrami.TabIndex = 0
        Me.btndersprogrami.Text = "Ders Programı"
        Me.btndersprogrami.UseVisualStyleBackColor = True
        '
        'btnveli
        '
        Me.btnveli.FlatAppearance.BorderSize = 0
        Me.btnveli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnveli.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnveli.ForeColor = System.Drawing.SystemColors.Control
        Me.btnveli.Image = CType(resources.GetObject("btnveli.Image"), System.Drawing.Image)
        Me.btnveli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnveli.Location = New System.Drawing.Point(0, 47)
        Me.btnveli.Name = "btnveli"
        Me.btnveli.Size = New System.Drawing.Size(241, 38)
        Me.btnveli.TabIndex = 0
        Me.btnveli.Text = "Veli İşlemleri"
        Me.btnveli.UseVisualStyleBackColor = True
        '
        'btnYoklama
        '
        Me.btnYoklama.FlatAppearance.BorderSize = 0
        Me.btnYoklama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYoklama.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnYoklama.ForeColor = System.Drawing.SystemColors.Control
        Me.btnYoklama.Image = CType(resources.GetObject("btnYoklama.Image"), System.Drawing.Image)
        Me.btnYoklama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYoklama.Location = New System.Drawing.Point(0, 443)
        Me.btnYoklama.Name = "btnYoklama"
        Me.btnYoklama.Size = New System.Drawing.Size(241, 38)
        Me.btnYoklama.TabIndex = 0
        Me.btnYoklama.Text = "Yoklama"
        Me.btnYoklama.UseVisualStyleBackColor = True
        '
        'btnİlacİslemleri
        '
        Me.btnİlacİslemleri.FlatAppearance.BorderSize = 0
        Me.btnİlacİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnİlacİslemleri.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnİlacİslemleri.ForeColor = System.Drawing.SystemColors.Control
        Me.btnİlacİslemleri.Image = CType(resources.GetObject("btnİlacİslemleri.Image"), System.Drawing.Image)
        Me.btnİlacİslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnİlacİslemleri.Location = New System.Drawing.Point(0, 355)
        Me.btnİlacİslemleri.Name = "btnİlacİslemleri"
        Me.btnİlacİslemleri.Size = New System.Drawing.Size(241, 38)
        Me.btnİlacİslemleri.TabIndex = 0
        Me.btnİlacİslemleri.Text = "İlaç İşlemleri"
        Me.btnİlacİslemleri.UseVisualStyleBackColor = True
        '
        'btnyemeklistesi
        '
        Me.btnyemeklistesi.FlatAppearance.BorderSize = 0
        Me.btnyemeklistesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyemeklistesi.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnyemeklistesi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnyemeklistesi.Image = CType(resources.GetObject("btnyemeklistesi.Image"), System.Drawing.Image)
        Me.btnyemeklistesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyemeklistesi.Location = New System.Drawing.Point(0, 267)
        Me.btnyemeklistesi.Name = "btnyemeklistesi"
        Me.btnyemeklistesi.Size = New System.Drawing.Size(241, 38)
        Me.btnyemeklistesi.TabIndex = 0
        Me.btnyemeklistesi.Text = "Yemek Listesi"
        Me.btnyemeklistesi.UseVisualStyleBackColor = True
        '
        'btnduyurular
        '
        Me.btnduyurular.FlatAppearance.BorderSize = 0
        Me.btnduyurular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnduyurular.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnduyurular.ForeColor = System.Drawing.SystemColors.Control
        Me.btnduyurular.Image = CType(resources.GetObject("btnduyurular.Image"), System.Drawing.Image)
        Me.btnduyurular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnduyurular.Location = New System.Drawing.Point(0, 179)
        Me.btnduyurular.Name = "btnduyurular"
        Me.btnduyurular.Size = New System.Drawing.Size(241, 38)
        Me.btnduyurular.TabIndex = 0
        Me.btnduyurular.Text = "Duyurular"
        Me.btnduyurular.UseVisualStyleBackColor = True
        '
        'btnders
        '
        Me.btnders.FlatAppearance.BorderSize = 0
        Me.btnders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnders.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnders.ForeColor = System.Drawing.SystemColors.Control
        Me.btnders.Image = CType(resources.GetObject("btnders.Image"), System.Drawing.Image)
        Me.btnders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnders.Location = New System.Drawing.Point(0, 91)
        Me.btnders.Name = "btnders"
        Me.btnders.Size = New System.Drawing.Size(241, 38)
        Me.btnders.TabIndex = 0
        Me.btnders.Text = "Ders İşlemleri"
        Me.btnders.UseVisualStyleBackColor = True
        '
        'btnogrenci
        '
        Me.btnogrenci.FlatAppearance.BorderSize = 0
        Me.btnogrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnogrenci.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnogrenci.ForeColor = System.Drawing.SystemColors.Control
        Me.btnogrenci.Image = CType(resources.GetObject("btnogrenci.Image"), System.Drawing.Image)
        Me.btnogrenci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogrenci.Location = New System.Drawing.Point(0, 3)
        Me.btnogrenci.Name = "btnogrenci"
        Me.btnogrenci.Size = New System.Drawing.Size(241, 38)
        Me.btnogrenci.TabIndex = 0
        Me.btnogrenci.Text = "Öğrenci İşlemleri"
        Me.btnogrenci.UseVisualStyleBackColor = True
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.BlueViolet
        Me.pnlheader.Controls.Add(Me.lblyazi)
        Me.pnlheader.Controls.Add(Me.btncikis)
        Me.pnlheader.Controls.Add(Me.label3)
        Me.pnlheader.Location = New System.Drawing.Point(241, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(2000, 86)
        Me.pnlheader.TabIndex = 2
        '
        'lblyazi
        '
        Me.lblyazi.AutoSize = True
        Me.lblyazi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblyazi.ForeColor = System.Drawing.Color.Lavender
        Me.lblyazi.Location = New System.Drawing.Point(219, 37)
        Me.lblyazi.Name = "lblyazi"
        Me.lblyazi.Size = New System.Drawing.Size(92, 29)
        Me.lblyazi.TabIndex = 3
        Me.lblyazi.Text = "Label3"
        '
        'btncikis
        '
        Me.btncikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btncikis.Image = CType(resources.GetObject("btncikis.Image"), System.Drawing.Image)
        Me.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncikis.Location = New System.Drawing.Point(1239, 32)
        Me.btncikis.Name = "btncikis"
        Me.btncikis.Size = New System.Drawing.Size(137, 44)
        Me.btncikis.TabIndex = 1
        Me.btncikis.Text = "Çıkış Yap"
        Me.btncikis.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.SystemColors.Control
        Me.label3.Location = New System.Drawing.Point(887, 42)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(183, 24)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Ad Soyad Gelecek"
        '
        'pnlcontainer
        '
        Me.pnlcontainer.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.pnlcontainer.Location = New System.Drawing.Point(242, 85)
        Me.pnlcontainer.Name = "pnlcontainer"
        Me.pnlcontainer.Size = New System.Drawing.Size(2000, 714)
        Me.pnlcontainer.TabIndex = 3
        '
        'FrmOgretmenPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 794)
        Me.Controls.Add(Me.pnlcontainer)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.pnlslidebar)
        Me.Controls.Add(Me.pnlheaderleft)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(27, 90)
        Me.Name = "FrmOgretmenPanel"
        Me.Text = "Öğretmen Panel"
        Me.pnlheaderleft.ResumeLayout(False)
        Me.pnlheaderleft.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlslidebar.ResumeLayout(False)
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlheaderleft As Panel
    Friend WithEvents label1 As Label
    Private WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlslidebar As Panel
    Friend WithEvents pnlheader As Panel
    Friend WithEvents label3 As Label
    Friend WithEvents pnlcontainer As FlowLayoutPanel
    Friend WithEvents btncikis As Button
    Friend WithEvents btnGaleri As Button
    Friend WithEvents btnİlacBildirimi As Button
    Friend WithEvents btnyemekbildirimi As Button
    Friend WithEvents btnetkinlikler As Button
    Friend WithEvents btndersprogrami As Button
    Friend WithEvents btnveli As Button
    Friend WithEvents btnYoklama As Button
    Friend WithEvents btnİlacİslemleri As Button
    Friend WithEvents btnyemeklistesi As Button
    Friend WithEvents btnduyurular As Button
    Friend WithEvents btnders As Button
    Friend WithEvents btnogrenci As Button
    Friend WithEvents lblyazi As Label
End Class

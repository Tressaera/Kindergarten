<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVeliPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliPanel))
        Me.pnlcontainer = New System.Windows.Forms.Panel()
        Me.pnlheadertop = New System.Windows.Forms.Panel()
        Me.btncikis = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblyazi = New System.Windows.Forms.Label()
        Me.pnlslidebar = New System.Windows.Forms.Panel()
        Me.btnİlacBildirimi = New System.Windows.Forms.Button()
        Me.btnİlacislemleri = New System.Windows.Forms.Button()
        Me.btnYoklama = New System.Windows.Forms.Button()
        Me.btnÖdemeler = New System.Windows.Forms.Button()
        Me.btnGaleri = New System.Windows.Forms.Button()
        Me.btnYemekBildirimi = New System.Windows.Forms.Button()
        Me.btnYemekListesi = New System.Windows.Forms.Button()
        Me.btnEtkinlikler = New System.Windows.Forms.Button()
        Me.btnDuyurular = New System.Windows.Forms.Button()
        Me.btnDersprogrami = New System.Windows.Forms.Button()
        Me.btnDersler = New System.Windows.Forms.Button()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pctveli = New System.Windows.Forms.PictureBox()
        Me.pnlheadertop.SuspendLayout()
        Me.pnlslidebar.SuspendLayout()
        Me.pnlheader.SuspendLayout()
        CType(Me.pctveli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlcontainer
        '
        Me.pnlcontainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlcontainer.Location = New System.Drawing.Point(261, 66)
        Me.pnlcontainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlcontainer.Name = "pnlcontainer"
        Me.pnlcontainer.Size = New System.Drawing.Size(2000, 714)
        Me.pnlcontainer.TabIndex = 5
        '
        'pnlheadertop
        '
        Me.pnlheadertop.BackColor = System.Drawing.Color.DarkBlue
        Me.pnlheadertop.Controls.Add(Me.btncikis)
        Me.pnlheadertop.Controls.Add(Me.label3)
        Me.pnlheadertop.Controls.Add(Me.lblyazi)
        Me.pnlheadertop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheadertop.Location = New System.Drawing.Point(265, 0)
        Me.pnlheadertop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlheadertop.Name = "pnlheadertop"
        Me.pnlheadertop.Size = New System.Drawing.Size(1659, 86)
        Me.pnlheadertop.TabIndex = 4
        '
        'btncikis
        '
        Me.btncikis.FlatAppearance.BorderSize = 0
        Me.btncikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btncikis.Image = CType(resources.GetObject("btncikis.Image"), System.Drawing.Image)
        Me.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncikis.Location = New System.Drawing.Point(1215, 11)
        Me.btncikis.Margin = New System.Windows.Forms.Padding(4)
        Me.btncikis.Name = "btncikis"
        Me.btncikis.Size = New System.Drawing.Size(121, 44)
        Me.btncikis.TabIndex = 5
        Me.btncikis.Text = "Çıkış Yap"
        Me.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncikis.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Yellow
        Me.label3.Location = New System.Drawing.Point(888, 19)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(258, 28)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Ad Soyad Gelecek..."
        '
        'lblyazi
        '
        Me.lblyazi.AutoSize = True
        Me.lblyazi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblyazi.ForeColor = System.Drawing.SystemColors.Control
        Me.lblyazi.Location = New System.Drawing.Point(340, 22)
        Me.lblyazi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyazi.Name = "lblyazi"
        Me.lblyazi.Size = New System.Drawing.Size(0, 29)
        Me.lblyazi.TabIndex = 0
        '
        'pnlslidebar
        '
        Me.pnlslidebar.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlslidebar.Controls.Add(Me.btnİlacBildirimi)
        Me.pnlslidebar.Controls.Add(Me.btnİlacislemleri)
        Me.pnlslidebar.Controls.Add(Me.btnYoklama)
        Me.pnlslidebar.Controls.Add(Me.btnÖdemeler)
        Me.pnlslidebar.Controls.Add(Me.btnGaleri)
        Me.pnlslidebar.Controls.Add(Me.btnYemekBildirimi)
        Me.pnlslidebar.Controls.Add(Me.btnYemekListesi)
        Me.pnlslidebar.Controls.Add(Me.btnEtkinlikler)
        Me.pnlslidebar.Controls.Add(Me.btnDuyurular)
        Me.pnlslidebar.Controls.Add(Me.btnDersprogrami)
        Me.pnlslidebar.Controls.Add(Me.btnDersler)
        Me.pnlslidebar.Controls.Add(Me.pnlheader)
        Me.pnlslidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlslidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlslidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlslidebar.Name = "pnlslidebar"
        Me.pnlslidebar.Size = New System.Drawing.Size(265, 746)
        Me.pnlslidebar.TabIndex = 3
        '
        'btnİlacBildirimi
        '
        Me.btnİlacBildirimi.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnİlacBildirimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnİlacBildirimi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnİlacBildirimi.FlatAppearance.BorderSize = 0
        Me.btnİlacBildirimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnİlacBildirimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnİlacBildirimi.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnİlacBildirimi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnİlacBildirimi.Image = CType(resources.GetObject("btnİlacBildirimi.Image"), System.Drawing.Image)
        Me.btnİlacBildirimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnİlacBildirimi.Location = New System.Drawing.Point(0, 563)
        Me.btnİlacBildirimi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnİlacBildirimi.Name = "btnİlacBildirimi"
        Me.btnİlacBildirimi.Size = New System.Drawing.Size(265, 49)
        Me.btnİlacBildirimi.TabIndex = 10
        Me.btnİlacBildirimi.Text = "İlaç Bildirimi"
        Me.btnİlacBildirimi.UseVisualStyleBackColor = False
        '
        'btnİlacislemleri
        '
        Me.btnİlacislemleri.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnİlacislemleri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnİlacislemleri.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnİlacislemleri.FlatAppearance.BorderSize = 0
        Me.btnİlacislemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnİlacislemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnİlacislemleri.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnİlacislemleri.ForeColor = System.Drawing.SystemColors.Control
        Me.btnİlacislemleri.Image = CType(resources.GetObject("btnİlacislemleri.Image"), System.Drawing.Image)
        Me.btnİlacislemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnİlacislemleri.Location = New System.Drawing.Point(0, 519)
        Me.btnİlacislemleri.Margin = New System.Windows.Forms.Padding(4)
        Me.btnİlacislemleri.Name = "btnİlacislemleri"
        Me.btnİlacislemleri.Size = New System.Drawing.Size(265, 44)
        Me.btnİlacislemleri.TabIndex = 9
        Me.btnİlacislemleri.Text = "İlaç İşlemleri"
        Me.btnİlacislemleri.UseVisualStyleBackColor = False
        '
        'btnYoklama
        '
        Me.btnYoklama.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnYoklama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYoklama.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnYoklama.FlatAppearance.BorderSize = 0
        Me.btnYoklama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnYoklama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYoklama.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYoklama.ForeColor = System.Drawing.SystemColors.Control
        Me.btnYoklama.Image = CType(resources.GetObject("btnYoklama.Image"), System.Drawing.Image)
        Me.btnYoklama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYoklama.Location = New System.Drawing.Point(0, 475)
        Me.btnYoklama.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYoklama.Name = "btnYoklama"
        Me.btnYoklama.Size = New System.Drawing.Size(265, 44)
        Me.btnYoklama.TabIndex = 8
        Me.btnYoklama.Text = "Yoklama"
        Me.btnYoklama.UseVisualStyleBackColor = False
        '
        'btnÖdemeler
        '
        Me.btnÖdemeler.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnÖdemeler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnÖdemeler.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnÖdemeler.FlatAppearance.BorderSize = 0
        Me.btnÖdemeler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnÖdemeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnÖdemeler.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnÖdemeler.ForeColor = System.Drawing.SystemColors.Control
        Me.btnÖdemeler.Image = CType(resources.GetObject("btnÖdemeler.Image"), System.Drawing.Image)
        Me.btnÖdemeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnÖdemeler.Location = New System.Drawing.Point(0, 431)
        Me.btnÖdemeler.Margin = New System.Windows.Forms.Padding(4)
        Me.btnÖdemeler.Name = "btnÖdemeler"
        Me.btnÖdemeler.Size = New System.Drawing.Size(265, 44)
        Me.btnÖdemeler.TabIndex = 7
        Me.btnÖdemeler.Text = "Ödemeler"
        Me.btnÖdemeler.UseVisualStyleBackColor = False
        '
        'btnGaleri
        '
        Me.btnGaleri.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnGaleri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGaleri.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGaleri.FlatAppearance.BorderSize = 0
        Me.btnGaleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnGaleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGaleri.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGaleri.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGaleri.Image = CType(resources.GetObject("btnGaleri.Image"), System.Drawing.Image)
        Me.btnGaleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGaleri.Location = New System.Drawing.Point(0, 387)
        Me.btnGaleri.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGaleri.Name = "btnGaleri"
        Me.btnGaleri.Size = New System.Drawing.Size(265, 44)
        Me.btnGaleri.TabIndex = 6
        Me.btnGaleri.Text = "Galeri"
        Me.btnGaleri.UseVisualStyleBackColor = False
        '
        'btnYemekBildirimi
        '
        Me.btnYemekBildirimi.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnYemekBildirimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYemekBildirimi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnYemekBildirimi.FlatAppearance.BorderSize = 0
        Me.btnYemekBildirimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnYemekBildirimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYemekBildirimi.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYemekBildirimi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnYemekBildirimi.Image = CType(resources.GetObject("btnYemekBildirimi.Image"), System.Drawing.Image)
        Me.btnYemekBildirimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYemekBildirimi.Location = New System.Drawing.Point(0, 343)
        Me.btnYemekBildirimi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYemekBildirimi.Name = "btnYemekBildirimi"
        Me.btnYemekBildirimi.Size = New System.Drawing.Size(265, 44)
        Me.btnYemekBildirimi.TabIndex = 5
        Me.btnYemekBildirimi.Text = "  Yemek Bildirimi"
        Me.btnYemekBildirimi.UseVisualStyleBackColor = False
        '
        'btnYemekListesi
        '
        Me.btnYemekListesi.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnYemekListesi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYemekListesi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnYemekListesi.FlatAppearance.BorderSize = 0
        Me.btnYemekListesi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnYemekListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYemekListesi.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYemekListesi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnYemekListesi.Image = CType(resources.GetObject("btnYemekListesi.Image"), System.Drawing.Image)
        Me.btnYemekListesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYemekListesi.Location = New System.Drawing.Point(0, 299)
        Me.btnYemekListesi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYemekListesi.Name = "btnYemekListesi"
        Me.btnYemekListesi.Size = New System.Drawing.Size(265, 44)
        Me.btnYemekListesi.TabIndex = 4
        Me.btnYemekListesi.Text = "Yemek Listesi"
        Me.btnYemekListesi.UseVisualStyleBackColor = False
        '
        'btnEtkinlikler
        '
        Me.btnEtkinlikler.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEtkinlikler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEtkinlikler.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEtkinlikler.FlatAppearance.BorderSize = 0
        Me.btnEtkinlikler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnEtkinlikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEtkinlikler.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEtkinlikler.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEtkinlikler.Image = CType(resources.GetObject("btnEtkinlikler.Image"), System.Drawing.Image)
        Me.btnEtkinlikler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEtkinlikler.Location = New System.Drawing.Point(0, 255)
        Me.btnEtkinlikler.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEtkinlikler.Name = "btnEtkinlikler"
        Me.btnEtkinlikler.Size = New System.Drawing.Size(265, 44)
        Me.btnEtkinlikler.TabIndex = 3
        Me.btnEtkinlikler.Text = "Etkinlikler"
        Me.btnEtkinlikler.UseVisualStyleBackColor = False
        '
        'btnDuyurular
        '
        Me.btnDuyurular.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDuyurular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDuyurular.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDuyurular.FlatAppearance.BorderSize = 0
        Me.btnDuyurular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnDuyurular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuyurular.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDuyurular.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDuyurular.Image = CType(resources.GetObject("btnDuyurular.Image"), System.Drawing.Image)
        Me.btnDuyurular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuyurular.Location = New System.Drawing.Point(0, 211)
        Me.btnDuyurular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDuyurular.Name = "btnDuyurular"
        Me.btnDuyurular.Size = New System.Drawing.Size(265, 44)
        Me.btnDuyurular.TabIndex = 2
        Me.btnDuyurular.Text = "Duyurular"
        Me.btnDuyurular.UseVisualStyleBackColor = False
        '
        'btnDersprogrami
        '
        Me.btnDersprogrami.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDersprogrami.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDersprogrami.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDersprogrami.FlatAppearance.BorderSize = 0
        Me.btnDersprogrami.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnDersprogrami.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDersprogrami.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDersprogrami.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDersprogrami.Image = CType(resources.GetObject("btnDersprogrami.Image"), System.Drawing.Image)
        Me.btnDersprogrami.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDersprogrami.Location = New System.Drawing.Point(0, 167)
        Me.btnDersprogrami.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDersprogrami.Name = "btnDersprogrami"
        Me.btnDersprogrami.Size = New System.Drawing.Size(265, 44)
        Me.btnDersprogrami.TabIndex = 1
        Me.btnDersprogrami.Text = "Ders Programı"
        Me.btnDersprogrami.UseVisualStyleBackColor = False
        '
        'btnDersler
        '
        Me.btnDersler.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDersler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDersler.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDersler.FlatAppearance.BorderSize = 0
        Me.btnDersler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnDersler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDersler.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDersler.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDersler.Image = CType(resources.GetObject("btnDersler.Image"), System.Drawing.Image)
        Me.btnDersler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDersler.Location = New System.Drawing.Point(0, 123)
        Me.btnDersler.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDersler.Name = "btnDersler"
        Me.btnDersler.Size = New System.Drawing.Size(265, 44)
        Me.btnDersler.TabIndex = 0
        Me.btnDersler.Text = "Dersler"
        Me.btnDersler.UseVisualStyleBackColor = False
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlheader.Controls.Add(Me.label2)
        Me.pnlheader.Controls.Add(Me.label1)
        Me.pnlheader.Controls.Add(Me.pctveli)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(265, 123)
        Me.pnlheader.TabIndex = 0
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(57, 113)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(133, 1)
        Me.label2.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.label1.Font = New System.Drawing.Font("Bookman Old Style", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Yellow
        Me.label1.Location = New System.Drawing.Point(29, 84)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(180, 29)
        Me.label1.TabIndex = 4
        Me.label1.Text = "VELİ PANELİ"
        '
        'pctveli
        '
        Me.pctveli.BackColor = System.Drawing.Color.RoyalBlue
        Me.pctveli.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctveli.Image = CType(resources.GetObject("pctveli.Image"), System.Drawing.Image)
        Me.pctveli.Location = New System.Drawing.Point(80, 0)
        Me.pctveli.Margin = New System.Windows.Forms.Padding(4)
        Me.pctveli.Name = "pctveli"
        Me.pctveli.Size = New System.Drawing.Size(94, 82)
        Me.pctveli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctveli.TabIndex = 0
        Me.pctveli.TabStop = False
        '
        'FrmVeliPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 746)
        Me.Controls.Add(Me.pnlcontainer)
        Me.Controls.Add(Me.pnlheadertop)
        Me.Controls.Add(Me.pnlslidebar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmVeliPanel"
        Me.Text = "Veli Panel"
        Me.pnlheadertop.ResumeLayout(False)
        Me.pnlheadertop.PerformLayout()
        Me.pnlslidebar.ResumeLayout(False)
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        CType(Me.pctveli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlcontainer As Panel
    Private WithEvents pnlheadertop As Panel
    Private WithEvents btncikis As Button
    Private WithEvents label3 As Label
    Private WithEvents lblyazi As Label
    Private WithEvents pnlslidebar As Panel
    Private WithEvents btnİlacBildirimi As Button
    Private WithEvents btnİlacislemleri As Button
    Private WithEvents btnYoklama As Button
    Private WithEvents btnÖdemeler As Button
    Private WithEvents btnGaleri As Button
    Private WithEvents btnYemekBildirimi As Button
    Private WithEvents btnYemekListesi As Button
    Private WithEvents btnEtkinlikler As Button
    Private WithEvents btnDuyurular As Button
    Private WithEvents btnDersprogrami As Button
    Private WithEvents btnDersler As Button
    Private WithEvents pnlheader As Panel
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents pctveli As PictureBox
End Class

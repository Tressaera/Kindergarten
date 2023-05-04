<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmYönetici
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmYönetici))
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lbladsoyad = New System.Windows.Forms.Label()
        Me.lblyazi = New System.Windows.Forms.Label()
        Me.pnlcontainer = New System.Windows.Forms.Panel()
        Me.panelslidebar = New System.Windows.Forms.Panel()
        Me.pnlheaderleft = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btncikis = New System.Windows.Forms.Button()
        Me.btnGaleri = New System.Windows.Forms.Button()
        Me.btnaidat = New System.Windows.Forms.Button()
        Me.btngelirgiderislem = New System.Windows.Forms.Button()
        Me.btnYoklamalisteislem = New System.Windows.Forms.Button()
        Me.btnilacislem = New System.Windows.Forms.Button()
        Me.btnyemeklisteişlem = New System.Windows.Forms.Button()
        Me.btnetkinlikislem = New System.Windows.Forms.Button()
        Me.btnduyuruislem = New System.Windows.Forms.Button()
        Me.btndersprogramislem = New System.Windows.Forms.Button()
        Me.btndersislem = New System.Windows.Forms.Button()
        Me.btnsinifbilgiislem = New System.Windows.Forms.Button()
        Me.btnogretmenislem = New System.Windows.Forms.Button()
        Me.btnveliislem = New System.Windows.Forms.Button()
        Me.btnogrislem = New System.Windows.Forms.Button()
        Me.pctlogo = New System.Windows.Forms.PictureBox()
        Me.pnlheader.SuspendLayout()
        Me.panelslidebar.SuspendLayout()
        Me.pnlheaderleft.SuspendLayout()
        CType(Me.pctlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlheader.Controls.Add(Me.btncikis)
        Me.pnlheader.Controls.Add(Me.label4)
        Me.pnlheader.Controls.Add(Me.lbladsoyad)
        Me.pnlheader.Controls.Add(Me.lblyazi)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(267, 0)
        Me.pnlheader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1657, 62)
        Me.pnlheader.TabIndex = 6
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(1104, 0)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(3, 62)
        Me.label4.TabIndex = 2
        '
        'lbladsoyad
        '
        Me.lbladsoyad.AutoSize = True
        Me.lbladsoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbladsoyad.ForeColor = System.Drawing.SystemColors.Control
        Me.lbladsoyad.Location = New System.Drawing.Point(1115, 20)
        Me.lbladsoyad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladsoyad.Name = "lbladsoyad"
        Me.lbladsoyad.Size = New System.Drawing.Size(201, 24)
        Me.lbladsoyad.TabIndex = 1
        Me.lbladsoyad.Text = "Ad Soyad Gelecek..."
        '
        'lblyazi
        '
        Me.lblyazi.AutoSize = True
        Me.lblyazi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblyazi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblyazi.Location = New System.Drawing.Point(420, 11)
        Me.lblyazi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyazi.Name = "lblyazi"
        Me.lblyazi.Size = New System.Drawing.Size(0, 28)
        Me.lblyazi.TabIndex = 0
        Me.lblyazi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlcontainer
        '
        Me.pnlcontainer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlcontainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.pnlcontainer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pnlcontainer.Location = New System.Drawing.Point(267, 62)
        Me.pnlcontainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlcontainer.Name = "pnlcontainer"
        Me.pnlcontainer.Size = New System.Drawing.Size(2000, 714)
        Me.pnlcontainer.TabIndex = 5
        '
        'panelslidebar
        '
        Me.panelslidebar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.panelslidebar.Controls.Add(Me.btnGaleri)
        Me.panelslidebar.Controls.Add(Me.btnaidat)
        Me.panelslidebar.Controls.Add(Me.btngelirgiderislem)
        Me.panelslidebar.Controls.Add(Me.btnYoklamalisteislem)
        Me.panelslidebar.Controls.Add(Me.btnilacislem)
        Me.panelslidebar.Controls.Add(Me.btnyemeklisteişlem)
        Me.panelslidebar.Controls.Add(Me.btnetkinlikislem)
        Me.panelslidebar.Controls.Add(Me.btnduyuruislem)
        Me.panelslidebar.Controls.Add(Me.btndersprogramislem)
        Me.panelslidebar.Controls.Add(Me.btndersislem)
        Me.panelslidebar.Controls.Add(Me.btnsinifbilgiislem)
        Me.panelslidebar.Controls.Add(Me.btnogretmenislem)
        Me.panelslidebar.Controls.Add(Me.btnveliislem)
        Me.panelslidebar.Controls.Add(Me.btnogrislem)
        Me.panelslidebar.Controls.Add(Me.pnlheaderleft)
        Me.panelslidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelslidebar.Location = New System.Drawing.Point(0, 0)
        Me.panelslidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.panelslidebar.Name = "panelslidebar"
        Me.panelslidebar.Size = New System.Drawing.Size(267, 667)
        Me.panelslidebar.TabIndex = 4
        '
        'pnlheaderleft
        '
        Me.pnlheaderleft.Controls.Add(Me.pctlogo)
        Me.pnlheaderleft.Controls.Add(Me.label2)
        Me.pnlheaderleft.Controls.Add(Me.label1)
        Me.pnlheaderleft.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheaderleft.Location = New System.Drawing.Point(0, 0)
        Me.pnlheaderleft.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlheaderleft.Name = "pnlheaderleft"
        Me.pnlheaderleft.Size = New System.Drawing.Size(267, 99)
        Me.pnlheaderleft.TabIndex = 3
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(40, 91)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(179, 2)
        Me.label2.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label1.Location = New System.Drawing.Point(39, 65)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(176, 28)
        Me.label1.TabIndex = 3
        Me.label1.Text = "YÖNETİCİ PANELİ"
        '
        'btncikis
        '
        Me.btncikis.FlatAppearance.BorderSize = 0
        Me.btncikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btncikis.Image = Global.Kindergartens.My.Resources.Resources.signs
        Me.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncikis.Location = New System.Drawing.Point(1337, 11)
        Me.btncikis.Margin = New System.Windows.Forms.Padding(4)
        Me.btncikis.Name = "btncikis"
        Me.btncikis.Size = New System.Drawing.Size(119, 44)
        Me.btncikis.TabIndex = 6
        Me.btncikis.Text = "Çıkış Yap"
        Me.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncikis.UseVisualStyleBackColor = True
        '
        'btnGaleri
        '
        Me.btnGaleri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGaleri.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGaleri.FlatAppearance.BorderSize = 0
        Me.btnGaleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnGaleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGaleri.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGaleri.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGaleri.Image = Global.Kindergartens.My.Resources.Resources.camera
        Me.btnGaleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGaleri.Location = New System.Drawing.Point(0, 606)
        Me.btnGaleri.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGaleri.Name = "btnGaleri"
        Me.btnGaleri.Size = New System.Drawing.Size(267, 31)
        Me.btnGaleri.TabIndex = 0
        Me.btnGaleri.Text = "Galeri"
        Me.btnGaleri.UseVisualStyleBackColor = True
        '
        'btnaidat
        '
        Me.btnaidat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaidat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnaidat.FlatAppearance.BorderSize = 0
        Me.btnaidat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnaidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaidat.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnaidat.ForeColor = System.Drawing.SystemColors.Control
        Me.btnaidat.Image = Global.Kindergartens.My.Resources.Resources.bill
        Me.btnaidat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaidat.Location = New System.Drawing.Point(0, 567)
        Me.btnaidat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaidat.Name = "btnaidat"
        Me.btnaidat.Size = New System.Drawing.Size(267, 39)
        Me.btnaidat.TabIndex = 22
        Me.btnaidat.Text = "Aidat Ödemeleri"
        Me.btnaidat.UseVisualStyleBackColor = True
        '
        'btngelirgiderislem
        '
        Me.btngelirgiderislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngelirgiderislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btngelirgiderislem.FlatAppearance.BorderSize = 0
        Me.btngelirgiderislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btngelirgiderislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngelirgiderislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btngelirgiderislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btngelirgiderislem.Image = Global.Kindergartens.My.Resources.Resources.money
        Me.btngelirgiderislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngelirgiderislem.Location = New System.Drawing.Point(0, 528)
        Me.btngelirgiderislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btngelirgiderislem.Name = "btngelirgiderislem"
        Me.btngelirgiderislem.Size = New System.Drawing.Size(267, 39)
        Me.btngelirgiderislem.TabIndex = 19
        Me.btngelirgiderislem.Text = "Gider İşlemleri"
        Me.btngelirgiderislem.UseVisualStyleBackColor = True
        '
        'btnYoklamalisteislem
        '
        Me.btnYoklamalisteislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYoklamalisteislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnYoklamalisteislem.FlatAppearance.BorderSize = 0
        Me.btnYoklamalisteislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnYoklamalisteislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYoklamalisteislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYoklamalisteislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnYoklamalisteislem.Image = Global.Kindergartens.My.Resources.Resources.inspection
        Me.btnYoklamalisteislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYoklamalisteislem.Location = New System.Drawing.Point(0, 489)
        Me.btnYoklamalisteislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYoklamalisteislem.Name = "btnYoklamalisteislem"
        Me.btnYoklamalisteislem.Size = New System.Drawing.Size(267, 39)
        Me.btnYoklamalisteislem.TabIndex = 17
        Me.btnYoklamalisteislem.Text = "Yoklama Listesi"
        Me.btnYoklamalisteislem.UseVisualStyleBackColor = True
        '
        'btnilacislem
        '
        Me.btnilacislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnilacislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnilacislem.FlatAppearance.BorderSize = 0
        Me.btnilacislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnilacislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnilacislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnilacislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnilacislem.Image = Global.Kindergartens.My.Resources.Resources.pill
        Me.btnilacislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnilacislem.Location = New System.Drawing.Point(0, 450)
        Me.btnilacislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnilacislem.Name = "btnilacislem"
        Me.btnilacislem.Size = New System.Drawing.Size(267, 39)
        Me.btnilacislem.TabIndex = 18
        Me.btnilacislem.Text = "İlaç Listesi"
        Me.btnilacislem.UseVisualStyleBackColor = True
        '
        'btnyemeklisteişlem
        '
        Me.btnyemeklisteişlem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnyemeklisteişlem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnyemeklisteişlem.FlatAppearance.BorderSize = 0
        Me.btnyemeklisteişlem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnyemeklisteişlem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyemeklisteişlem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnyemeklisteişlem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnyemeklisteişlem.Image = Global.Kindergartens.My.Resources.Resources.eat
        Me.btnyemeklisteişlem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyemeklisteişlem.Location = New System.Drawing.Point(0, 411)
        Me.btnyemeklisteişlem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnyemeklisteişlem.Name = "btnyemeklisteişlem"
        Me.btnyemeklisteişlem.Size = New System.Drawing.Size(267, 39)
        Me.btnyemeklisteişlem.TabIndex = 9
        Me.btnyemeklisteişlem.Text = "Yemek Listesi"
        Me.btnyemeklisteişlem.UseVisualStyleBackColor = True
        '
        'btnetkinlikislem
        '
        Me.btnetkinlikislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnetkinlikislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnetkinlikislem.FlatAppearance.BorderSize = 0
        Me.btnetkinlikislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnetkinlikislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnetkinlikislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnetkinlikislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnetkinlikislem.Image = Global.Kindergartens.My.Resources.Resources.zumba
        Me.btnetkinlikislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnetkinlikislem.Location = New System.Drawing.Point(0, 372)
        Me.btnetkinlikislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnetkinlikislem.Name = "btnetkinlikislem"
        Me.btnetkinlikislem.Size = New System.Drawing.Size(267, 39)
        Me.btnetkinlikislem.TabIndex = 21
        Me.btnetkinlikislem.Text = "Etkinlik İşlemleri"
        Me.btnetkinlikislem.UseVisualStyleBackColor = True
        '
        'btnduyuruislem
        '
        Me.btnduyuruislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnduyuruislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnduyuruislem.FlatAppearance.BorderSize = 0
        Me.btnduyuruislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnduyuruislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnduyuruislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnduyuruislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnduyuruislem.Image = Global.Kindergartens.My.Resources.Resources.protest
        Me.btnduyuruislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnduyuruislem.Location = New System.Drawing.Point(0, 333)
        Me.btnduyuruislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnduyuruislem.Name = "btnduyuruislem"
        Me.btnduyuruislem.Size = New System.Drawing.Size(267, 39)
        Me.btnduyuruislem.TabIndex = 7
        Me.btnduyuruislem.Text = "Duyuru İşlemleri"
        Me.btnduyuruislem.UseVisualStyleBackColor = True
        '
        'btndersprogramislem
        '
        Me.btndersprogramislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndersprogramislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndersprogramislem.FlatAppearance.BorderSize = 0
        Me.btndersprogramislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btndersprogramislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndersprogramislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btndersprogramislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btndersprogramislem.Image = CType(resources.GetObject("btndersprogramislem.Image"), System.Drawing.Image)
        Me.btndersprogramislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndersprogramislem.Location = New System.Drawing.Point(0, 294)
        Me.btndersprogramislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btndersprogramislem.Name = "btndersprogramislem"
        Me.btndersprogramislem.Size = New System.Drawing.Size(267, 39)
        Me.btndersprogramislem.TabIndex = 16
        Me.btndersprogramislem.Text = "Ders Programı"
        Me.btndersprogramislem.UseVisualStyleBackColor = True
        '
        'btndersislem
        '
        Me.btndersislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndersislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndersislem.FlatAppearance.BorderSize = 0
        Me.btndersislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btndersislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndersislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btndersislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btndersislem.Image = CType(resources.GetObject("btndersislem.Image"), System.Drawing.Image)
        Me.btndersislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndersislem.Location = New System.Drawing.Point(0, 255)
        Me.btndersislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btndersislem.Name = "btndersislem"
        Me.btndersislem.Size = New System.Drawing.Size(267, 39)
        Me.btndersislem.TabIndex = 10
        Me.btndersislem.Text = "Ders İşlemleri"
        Me.btndersislem.UseVisualStyleBackColor = True
        '
        'btnsinifbilgiislem
        '
        Me.btnsinifbilgiislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsinifbilgiislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsinifbilgiislem.FlatAppearance.BorderSize = 0
        Me.btnsinifbilgiislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnsinifbilgiislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsinifbilgiislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsinifbilgiislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsinifbilgiislem.Image = Global.Kindergartens.My.Resources.Resources.teacher__1_
        Me.btnsinifbilgiislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsinifbilgiislem.Location = New System.Drawing.Point(0, 216)
        Me.btnsinifbilgiislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsinifbilgiislem.Name = "btnsinifbilgiislem"
        Me.btnsinifbilgiislem.Size = New System.Drawing.Size(267, 39)
        Me.btnsinifbilgiislem.TabIndex = 8
        Me.btnsinifbilgiislem.Text = "Sınıf Bilgileri"
        Me.btnsinifbilgiislem.UseVisualStyleBackColor = True
        '
        'btnogretmenislem
        '
        Me.btnogretmenislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnogretmenislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnogretmenislem.FlatAppearance.BorderSize = 0
        Me.btnogretmenislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnogretmenislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnogretmenislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnogretmenislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnogretmenislem.Image = CType(resources.GetObject("btnogretmenislem.Image"), System.Drawing.Image)
        Me.btnogretmenislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogretmenislem.Location = New System.Drawing.Point(0, 177)
        Me.btnogretmenislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogretmenislem.Name = "btnogretmenislem"
        Me.btnogretmenislem.Size = New System.Drawing.Size(267, 39)
        Me.btnogretmenislem.TabIndex = 5
        Me.btnogretmenislem.Text = "Öğretmen İşlemleri"
        Me.btnogretmenislem.UseVisualStyleBackColor = True
        '
        'btnveliislem
        '
        Me.btnveliislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnveliislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnveliislem.FlatAppearance.BorderSize = 0
        Me.btnveliislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnveliislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnveliislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnveliislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnveliislem.Image = Global.Kindergartens.My.Resources.Resources.family
        Me.btnveliislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnveliislem.Location = New System.Drawing.Point(0, 138)
        Me.btnveliislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnveliislem.Name = "btnveliislem"
        Me.btnveliislem.Size = New System.Drawing.Size(267, 39)
        Me.btnveliislem.TabIndex = 6
        Me.btnveliislem.Text = "Veli İşlemleri"
        Me.btnveliislem.UseVisualStyleBackColor = True
        '
        'btnogrislem
        '
        Me.btnogrislem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnogrislem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnogrislem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnogrislem.FlatAppearance.BorderSize = 0
        Me.btnogrislem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnogrislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnogrislem.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnogrislem.ForeColor = System.Drawing.SystemColors.Control
        Me.btnogrislem.Image = CType(resources.GetObject("btnogrislem.Image"), System.Drawing.Image)
        Me.btnogrislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnogrislem.Location = New System.Drawing.Point(0, 99)
        Me.btnogrislem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnogrislem.Name = "btnogrislem"
        Me.btnogrislem.Size = New System.Drawing.Size(267, 39)
        Me.btnogrislem.TabIndex = 4
        Me.btnogrislem.Text = "Öğrenci İşlemleri"
        Me.btnogrislem.UseVisualStyleBackColor = True
        '
        'pctlogo
        '
        Me.pctlogo.Image = CType(resources.GetObject("pctlogo.Image"), System.Drawing.Image)
        Me.pctlogo.Location = New System.Drawing.Point(4, 0)
        Me.pctlogo.Margin = New System.Windows.Forms.Padding(4)
        Me.pctlogo.Name = "pctlogo"
        Me.pctlogo.Size = New System.Drawing.Size(267, 62)
        Me.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctlogo.TabIndex = 5
        Me.pctlogo.TabStop = False
        '
        'FrmYönetici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 667)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.pnlcontainer)
        Me.Controls.Add(Me.panelslidebar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmYönetici"
        Me.Text = "Yönetici Panel"
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.panelslidebar.ResumeLayout(False)
        Me.pnlheaderleft.ResumeLayout(False)
        Me.pnlheaderleft.PerformLayout()
        CType(Me.pctlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlheader As Panel
    Private WithEvents btncikis As Button
    Private WithEvents label4 As Label
    Private WithEvents lbladsoyad As Label
    Private WithEvents lblyazi As Label
    Private WithEvents pnlcontainer As Panel
    Private WithEvents panelslidebar As Panel
    Private WithEvents btnGaleri As Button
    Private WithEvents btnaidat As Button
    Private WithEvents btngelirgiderislem As Button
    Private WithEvents btnYoklamalisteislem As Button
    Private WithEvents btnilacislem As Button
    Private WithEvents btnyemeklisteişlem As Button
    Private WithEvents btnetkinlikislem As Button
    Private WithEvents btnduyuruislem As Button
    Private WithEvents btndersprogramislem As Button
    Private WithEvents btndersislem As Button
    Private WithEvents btnsinifbilgiislem As Button
    Private WithEvents btnogretmenislem As Button
    Private WithEvents btnveliislem As Button
    Private WithEvents btnogrislem As Button
    Private WithEvents pnlheaderleft As Panel
    Private WithEvents pctlogo As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class

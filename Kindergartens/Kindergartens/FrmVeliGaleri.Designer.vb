<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeliGaleri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeliGaleri))
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.btngeri = New System.Windows.Forms.Button()
        Me.btnileri = New System.Windows.Forms.Button()
        Me.pctresim = New System.Windows.Forms.PictureBox()
        Me.groupBox5.SuspendLayout()
        CType(Me.pctresim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.btngeri)
        Me.groupBox5.Controls.Add(Me.btnileri)
        Me.groupBox5.Controls.Add(Me.pctresim)
        Me.groupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox5.Location = New System.Drawing.Point(249, 53)
        Me.groupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox5.Size = New System.Drawing.Size(864, 512)
        Me.groupBox5.TabIndex = 51
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Resim Görüntüle"
        '
        'btngeri
        '
        Me.btngeri.Location = New System.Drawing.Point(80, 411)
        Me.btngeri.Margin = New System.Windows.Forms.Padding(4)
        Me.btngeri.Name = "btngeri"
        Me.btngeri.Size = New System.Drawing.Size(133, 42)
        Me.btngeri.TabIndex = 2
        Me.btngeri.Text = "Geri"
        Me.btngeri.UseVisualStyleBackColor = True
        '
        'btnileri
        '
        Me.btnileri.Location = New System.Drawing.Point(557, 411)
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
        Me.pctresim.Size = New System.Drawing.Size(848, 380)
        Me.pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctresim.TabIndex = 0
        Me.pctresim.TabStop = False
        '
        'FrmVeliGaleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1363, 667)
        Me.Controls.Add(Me.groupBox5)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVeliGaleri"
        Me.Text = "Veli Galeri"
        Me.groupBox5.ResumeLayout(False)
        CType(Me.pctresim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox5 As GroupBox
    Private WithEvents btngeri As Button
    Private WithEvents btnileri As Button
    Private WithEvents pctresim As PictureBox
End Class

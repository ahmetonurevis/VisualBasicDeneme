<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.dgvMusteriler = New System.Windows.Forms.DataGridView()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnListele = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.dgvMusteriler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(69, 36)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(100, 20)
        Me.txtAd.TabIndex = 0
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(69, 77)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(100, 20)
        Me.txtSoyad.TabIndex = 0
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(69, 124)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefon.TabIndex = 0
        '
        'dgvMusteriler
        '
        Me.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMusteriler.Location = New System.Drawing.Point(205, 33)
        Me.dgvMusteriler.Name = "dgvMusteriler"
        Me.dgvMusteriler.Size = New System.Drawing.Size(583, 359)
        Me.dgvMusteriler.TabIndex = 1
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(205, 405)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 23)
        Me.btnEkle.TabIndex = 2
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.Location = New System.Drawing.Point(286, 405)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(75, 23)
        Me.btnGuncelle.TabIndex = 3
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(367, 405)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(75, 23)
        Me.btnSil.TabIndex = 4
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnListele
        '
        Me.btnListele.Location = New System.Drawing.Point(448, 405)
        Me.btnListele.Name = "btnListele"
        Me.btnListele.Size = New System.Drawing.Size(75, 23)
        Me.btnListele.TabIndex = 5
        Me.btnListele.Text = "Listele"
        Me.btnListele.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Soyad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Telefon:"
        '
        'btnAra
        '
        Me.btnAra.Location = New System.Drawing.Point(701, 4)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(75, 23)
        Me.btnAra.TabIndex = 9
        Me.btnAra.Text = "Ara"
        Me.btnAra.UseVisualStyleBackColor = True
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(565, 6)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(100, 20)
        Me.txtAra.TabIndex = 10
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtAra)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnListele)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.dgvMusteriler)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvMusteriler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents dgvMusteriler As DataGridView
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnListele As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAra As Button
    Friend WithEvents txtAra As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

Imports System.Data.SqlClient

Public Class Form1

    Dim baglanti As New SqlConnection("Server=DESKTOP-5E114JO\SQLEXPRESS;Database=MusteriDB;Integrated Security=True")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NotifyIcon1.Icon = SystemIcons.Information
        NotifyIcon1.Text = "Müşteri Yönetim Sistemi"
        NotifyIcon1.Visible = True


        Dim menu As New ContextMenuStrip()
        menu.Items.Add("Göster", Nothing, AddressOf ShowApp)
        menu.Items.Add("Çıkış", Nothing, AddressOf CloseApp)
        NotifyIcon1.ContextMenuStrip = menu


        Me.Hide()
    End Sub


    Private Sub ShowApp(sender As Object, e As EventArgs)
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub


    Private Sub CloseApp(sender As Object, e As EventArgs)
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub

    ' Verileri Listeleme Metodu
    Sub VerileriListele()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("SELECT * FROM Musteriler", baglanti)
        da.Fill(dt)
        dgvMusteriler.DataSource = dt
    End Sub

    ' Müşteri Ekleme
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If txtAd.Text = "" Or txtSoyad.Text = "" Or txtTelefon.Text = "" Then
            MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        baglanti.Open()
        Dim komut As New SqlCommand("INSERT INTO Musteriler (Ad, Soyad, Telefon) VALUES (@Ad, @Soyad, @Telefon)", baglanti)
        komut.Parameters.AddWithValue("@Ad", txtAd.Text)
        komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text)
        komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text)
        komut.ExecuteNonQuery()
        baglanti.Close()
        VerileriListele()
    End Sub

    ' Müşteri Güncelleme
    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If dgvMusteriler.CurrentRow IsNot Nothing Then
            baglanti.Open()
            Dim komut As New SqlCommand("UPDATE Musteriler SET Ad=@Ad, Soyad=@Soyad, Telefon=@Telefon WHERE ID=@ID", baglanti)
            komut.Parameters.AddWithValue("@Ad", txtAd.Text)
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text)
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text)
            komut.Parameters.AddWithValue("@ID", dgvMusteriler.CurrentRow.Cells(0).Value)
            komut.ExecuteNonQuery()
            baglanti.Close()
            VerileriListele()
        End If
    End Sub

    ' Müşteri Silme
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If dgvMusteriler.CurrentRow IsNot Nothing Then
            Dim onay As DialogResult = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If onay = DialogResult.Yes Then
                baglanti.Open()
                Dim komut As New SqlCommand("DELETE FROM Musteriler WHERE ID=@ID", baglanti)
                komut.Parameters.AddWithValue("@ID", dgvMusteriler.CurrentRow.Cells(0).Value)
                komut.ExecuteNonQuery()
                baglanti.Close()
                VerileriListele()
            End If
        End If
    End Sub

    ' Müşteri Listeleme
    Private Sub btnListele_Click(sender As Object, e As EventArgs) Handles btnListele.Click
        VerileriListele()
    End Sub

    ' DataGridView'de Seçili Veriyi TextBox'lara Getir
    Private Sub dgvMusteriler_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMusteriler.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMusteriler.Rows(e.RowIndex)
            txtAd.Text = row.Cells(1).Value.ToString()
            txtSoyad.Text = row.Cells(2).Value.ToString()
            txtTelefon.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    ' Arama Fonksiyonu
    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("SELECT * FROM Musteriler WHERE Ad LIKE @Ad OR Soyad LIKE @Soyad OR Telefon LIKE @Telefon", baglanti)
        da.SelectCommand.Parameters.AddWithValue("@Ad", "%" & txtAra.Text & "%")
        da.SelectCommand.Parameters.AddWithValue("@Soyad", "%" & txtAra.Text & "%")
        da.SelectCommand.Parameters.AddWithValue("@Telefon", "%" & txtAra.Text & "%")
        da.Fill(dt)
        dgvMusteriler.DataSource = dt
    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub
End Class

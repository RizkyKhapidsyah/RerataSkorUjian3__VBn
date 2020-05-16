Public Class Form1

    Private Sub tombolHitung_Click(sender As Object, e As EventArgs) Handles tombolHitung.Click
        'variabel-variabel untuk memuat skor ujian dan reratanya
        Dim dblSkor1 As Double
        Dim dblSkor2 As Double
        Dim dblSkor3 As Double
        Dim dblRerata As Double

        'konstanta-konstanta
        Const BANYAK_SKOR As Integer = 3
        Const dblSKOR_TINGGI As Double = 95.0
        Try
            'menyalin isi TextBox ke variabel
            dblSkor1 = CDbl(teksSkor1.Text)
            dblSkor2 = CDbl(teksSkor2.Text)
            dblSkor3 = CDbl(teksSkor3.Text)

            'menghitung rerata
            dblRerata = (dblSkor1 + dblSkor2 + dblSkor3) / BANYAK_SKOR

            'menampilkan rerata, dibulatkan ke 2 dijit di belakang titik desimal
            labelRerata.Text = dblRerata.ToString("n2")

            'menampilkan nilai huruf
            If dblRerata < 60 Then
                labelNilai.Text = "E"
            ElseIf dblRerata < 70 Then
                labelNilai.Text = "D"
            ElseIf dblRerata < 80 Then
                labelNilai.Text = "C"
            ElseIf dblRerata < 90 Then
                labelNilai.Text = "B"
            ElseIf dblRerata <= 100 Then
                labelNilai.Text = "A"
            Else
                labelNilai.Text = "Skor tak valid"
            End If

            'Jika skor tinggi, berikan pujian kepada siswa
            'Sebaliknya, berikan penghiburan
            If dblRerata > dblSKOR_TINGGI Then
                labelPesan.Text = "Selamat! Anda berhasil!"
            Else
                labelPesan.Text = "Tetap semangat!"
            End If
        Catch
            'menampilkan pesan error
            labelPesan.Text = "Skor harus numerik"
        End Try
    End Sub

    Private Sub tombolBersihkan_Click(sender As Object, e As EventArgs) Handles tombolBersihkan.Click
        teksSkor1.Text = String.Empty
        teksSkor2.Text = String.Empty
        teksSkor3.Text = String.Empty
        labelRerata.Text = String.Empty
        labelPesan.Text = String.Empty
        labelNilai.Text = String.Empty

        'mengatur fokus kembali ke teksSkor1
        teksSkor1.Focus()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub
End Class

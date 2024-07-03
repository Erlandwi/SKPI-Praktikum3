Public Class Form1







    Private Sub Bthitung_Click(sender As Object, e As EventArgs) Handles Bthitung.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String
        harga = Txtharga.Text
        jumlah = Txtjumlah.Text

        total = harga * jumlah

        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Pinggang"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Pena"
        Else
            diskon = 0
            bonus = "Tidak Ada"
        End If

        bayar = total - diskon

        Txttotalharga.Text = total
        Txtdiskon.Text = diskon
        Txttotalbayar.Text = bayar
        Txtbonus.Text = bonus
    End Sub

    Private Sub Btulang_Click(sender As Object, e As EventArgs) Handles Btulang.Click
        Txtnabar.Clear()
        Txtharga.Clear()
        Txtjumlah.Clear()
        Txttotalharga.Clear()
        Txtdiskon.Clear()
        Txttotalbayar.Clear()
        Txtbonus.Clear()
    End Sub
    Private Sub Btkeluar_Click(sender As Object, e As EventArgs) Handles Btkeluar.Click

    End Sub
End Class

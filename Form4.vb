Imports login.productdetails

Public Class Form4
    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles btnertiga.Click
        product_name = lblertiga.Text
        product_seat = lblertigaseat.Text
        product_price = txtertigaprice.Text
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btninnova.Click
        product_name = lblinnova.Text
        product_seat = lblinnovaseat.Text
        product_price = txtinnovaprice.Text
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btnnexon.Click
        product_name = lblnexon.Text
        product_seat = lblnexonseat.Text
        product_price = txtnexonprice.Text
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles btnaltroz.Click
        product_name = lblaltroz.Text
        product_seat = lblaltrozseat.Text
        product_price = txtaltrozprice.Text
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles btnswift.Click
        product_name = lblswift.Text
        product_seat = lblswiftseat.Text
        product_price = txtswiftprice.Text
        Form5.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles pbxinnova.MouseHover
        gbinnova.Visible = True
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pbxinnova.MouseLeave
        gbinnova.Visible = False
    End Sub
    Private Sub Pbxnexon_MouseHover(sender As Object, e As EventArgs) Handles Pbxnexon.MouseHover
        gbxnexon.Visible = True
    End Sub

    Private Sub Pbxnexon_MouseLeave(sender As Object, e As EventArgs) Handles Pbxnexon.MouseLeave
        gbxnexon.Visible = False
    End Sub
    Private Sub Pbxswift_MouseHover(sender As Object, e As EventArgs) Handles Pbxswift.MouseHover
        gbxswift.Visible = True
    End Sub

    Private Sub Pbxswift_MouseLeave(sender As Object, e As EventArgs) Handles Pbxswift.MouseLeave
        gbxswift.Visible = False
    End Sub
    Private Sub Pbxertiga_MouseHover(sender As Object, e As EventArgs) Handles Pbxertiga.MouseHover
        gbxertiga.Visible = True
    End Sub

    Private Sub Pbxertiga_MouseLeave(sender As Object, e As EventArgs) Handles Pbxertiga.MouseLeave
        gbxertiga.Visible = False
    End Sub
    Private Sub Pbxaltroz_MouseHover(sender As Object, e As EventArgs) Handles Pbxaltroz.MouseHover
        gbxaltroz.Visible = True
    End Sub

    Private Sub Pbxaltroz_MouseLeave(sender As Object, e As EventArgs) Handles Pbxaltroz.MouseLeave
        gbxaltroz.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

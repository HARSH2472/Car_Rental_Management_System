Imports System.Data.SqlClient

Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtvechname.Text = "" Or txtmodel.Text = "" Or txtcolor.Text = "" Or cmbbrand.SelectedItem = "" Or cmbfueltype.SelectedItem = "" Then
            MessageBox.Show("PLEASE ENTER ALL REQURIED DETAILS")
        Else
            Dim con As New SqlConnection("Data Source=LAPTOP-IO52UU0P\SQLEXPRESS;Initial Catalog=table2;Integrated Security=True")
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[Table2]
           ([VechileNo]
           ,[Brand]
           ,[Model]
           ,[Color]
           ,[FuelType])
     VALUES
           ('" + txtvechname.Text + "','" + cmbbrand.Text + "','" + txtmodel.Text + "','" + txtcolor.Text + "','" + cmbfueltype.Text + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You Have Add Car Successfully")
            con.Close()
            Me.CardetailsDataGridView.Rows.Add(txtvechname.Text, cmbbrand.SelectedItem, txtmodel.Text, txtcolor.Text, cmbfueltype.SelectedItem)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtvechname.Text = ""
        cmbbrand.SelectedText = ""
        txtmodel.Text = ""
        txtcolor.Text = ""
        cmbfueltype.SelectedText = ""
        txtvechname.Focus()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_KeyDown(sender As Object, e As KeyEventArgs) Handles Button5.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
End Class
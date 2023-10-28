Imports System.Data.SqlClient
Imports login.Customerdetails

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtname.Text = "" Or txtmobile.Text = "" Or txtmail.Text = "" Or txtaddress.Text = "" Then
            MessageBox.Show("PLEASE ENTER ALL REQURIED DETAILS")
        Else
            Dim con As New SqlConnection("Data Source=LAPTOP-IO52UU0P\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[userreg]
           ([name]
           ,[mobile]
           ,[email]
           ,[address])
     VALUES
           ('" + txtname.Text + "','" + txtmobile.Text + "','" + txtmail.Text + "','" + txtaddress.Text + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You Have Registered Successfully")
            con.Close()
            customer_email = txtmail.Text
            Form3.Show()
            Me.Hide()
        End If

        txtname.Text = ""
        txtmobile.Text = ""
        txtmail.Text = ""
        txtaddress.Text = ""
        txtname.Focus()
    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
End Class
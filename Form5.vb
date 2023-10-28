Imports System.Data.SqlClient
Imports login.Customerdetails


Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtfname.Text = "" Or txtpan.Text = "" Or txtadhar.Text = "" Or txthi.Text = "" Or txtlicense.Text = "" Or txtphone.Text = "" Then
            MessageBox.Show("PLEASE ENTER ALL REQURIED DETAILS")
            txtfname.Text = ""
            txtpan.Text = ""
            txtadhar.Text = ""
            txthi.Text = ""
            txtlicense.Text = ""
            txtphone.Text = ""
            txtfname.Focus()

        ElseIf chkbox.Checked = False Then
            MessageBox.Show("PLEASE READ THE T&C AND CHECK THE CHECKBOX")

            txtfname.Text = ""
            txtpan.Text = ""
            txtadhar.Text = ""
            txthi.Text = ""
            txtlicense.Text = ""
            txtphone.Text = ""
            txtfname.Focus()
        Else
            Dim con As New SqlConnection("Data Source=LAPTOP-IO52UU0P\SQLEXPRESS;Initial Catalog=table3;Integrated Security=True")
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[Table3]
           ([Fullname]
           ,[Pancard]
           ,[Adharcard]
           ,[HealthInsurance]
           ,[LicenseNo]
           ,[PhoneNo])
     VALUES
           ('" + txtfname.Text + "','" + txtpan.Text + "','" + txtadhar.Text + "','" + txthi.Text + "','" + txtlicense.Text + "','" + txtphone.Text + "')", con)

            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You Have Submitted Your Details Succesfully")
            con.Close()
            customer_name = txtfname.Text
            customer_no = txtphone.Text
            txtfname.Text = ""
            txtpan.Text = ""
            txtadhar.Text = ""
            txthi.Text = ""
            txtlicense.Text = ""
            txtphone.Text = ""
            txtfname.Focus()
            Form7.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfname.Focus()
        customer_name = txtfname.Text
        customer_no = txtphone.Text
    End Sub
End Class
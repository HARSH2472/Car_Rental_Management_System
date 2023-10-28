Imports login.productdetails
Imports login.Customerdetails
Imports System.Data.SqlClient


Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcarname.Text = product_name
        txtcarseat.Text = product_seat
        txtcarprice.Text = product_price
        txtcustomername.Text = customer_name
        txtcustomerno.Text = customer_no
        txtcustomeremail.Text = customer_email
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtcarname.Text = "" Or txtcarseat.Text = "" Or txtcarprice.Text = "" Or txtreturnloc.Text = "" Or txtdaysonrent.Text = "" Or txtcustomername.Text = "" Or txtcustomerno.Text = "" Or txtcustomeremail.Text = "" Or txtcity.Text = "" Or txtpincode.Text = "" Or txtcustomeradr.Text = "") Then
            MessageBox.Show("PLEASE ENTER ALL REQURIED DETAILS")
            txtcarname.Text = ""
            txtcarseat.Text = ""
            txtcarprice.Text = ""
            txtreturnloc.Text = ""
            txtdaysonrent.Text = ""
            txtcustomername.Text = ""
            txtcustomerno.Text = ""
            txtcustomeremail.Text = ""
            txtcity.Text = ""
            txtpincode.Text = ""
            txtcustomeradr.Text = ""
            txtcarname.Focus()
        Else
            Dim con As New SqlConnection("Data Source=LAPTOP-IO52UU0P\SQLEXPRESS;Initial Catalog=FINALBILL;Integrated Security=True")
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[FinalBill]
           ([CARNAME]
           ,[CARSEAT]
           ,[CARPRICE]
           ,[RETURNLOCATION]
           ,[DAYSONRENT]
           ,[TOTALPRICE]
           ,[CUSTOMERNAME]
           ,[CONTACTNO]
           ,[EMAIL]
           ,[CITY]
           ,[PINCODE]
           ,[CUSTOMERADDRESS])
     VALUES
            ('" + txtcarname.Text + "' , '" + txtcarseat.Text + "','" + txtcarprice.Text + "','" + txtreturnloc.Text + "','" + txtdaysonrent.Text + "','" + txttotalprice.Text + "','" + txtcustomername.Text + "','" + txtcustomerno.Text + "','" + txtcustomeremail.Text + "','" + txtcity.Text + "','" + txtpincode.Text + "','" + txtcustomeradr.Text + "')", con)
            con.Open()
            Dim unused = cmd.ExecuteNonQuery()
            MessageBox.Show("You Have Book Your Car Succesfully")
            con.Close()
            txtcarname.Text = ""
            txtcarseat.Text = ""
            txtcarprice.Text = ""
            txtreturnloc.Text = ""
            txtdaysonrent.Text = ""
            txttotalprice.Text = ""
            txtcustomername.Text = ""
            txtcustomerno.Text = ""
            txtcustomeremail.Text = ""
            txtcity.Text = ""
            txtpincode.Text = ""
            txtcustomeradr.Text = ""
            txtcarname.Focus()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtdaysonrent.Text = "" Then
            MessageBox.Show("Please Enter The Days")
        Else
            txttotalprice.Text = (txtcarprice.Text * txtdaysonrent.Text)
        End If
    End Sub
End Class
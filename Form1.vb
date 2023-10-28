Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusername.Text = "admin" And txtpass.Text = "admin123" Then
            MessageBox.Show("You Have Successfully Login")
            Form6.Show()
            Me.Hide()
            txtusername.Text = ""
            txtpass.Text = ""
            txtusername.Focus()
        ElseIf (txtusername.Text = "" And txtpass.Text = "") Then
            MessageBox.Show("Please Enter Valid USER ID And PASSOWRD")
            txtusername.Text = ""
            txtpass.Text = ""
            txtusername.Focus()
        ElseIf txtusername.Text = "" Then
            MessageBox.Show("Please Enter Valid USER ID")
            txtusername.Text = ""
            txtpass.Text = ""
            txtusername.Focus()
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Please Enter Valid PASSWORD")
            txtusername.Text = ""
            txtpass.Text = ""
            txtusername.Focus()
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub
End Class

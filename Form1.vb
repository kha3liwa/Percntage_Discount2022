Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtDiscount.Text > "" Or txtSalary.Text > "" Then
            Dim discount, salary, percentage As Double
            discount = txtDiscount.Text
            salary = txtSalary.Text
            percentage = discount / salary * 100
            Me.txtPercentage.Text = "%" + Convert.ToString(percentage)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtSal.Text > "" Or txtPerc.Text > "" Then
            Dim all_value, perc, after_perc, final, eend, minsNum As Double
            all_value = txtSal.Text '780
            perc = txtPerc.Text '.20
            after_perc = 100 - perc '100-.20=80
            final = after_perc * 0.01 '80*0.01=.8
            eend = final * all_value '.8*780=624
            minsNum = all_value - eend '780-624=156
            Me.txtDis.Text = Convert.ToDouble(minsNum)
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.txtDiscount.Text = ""
        Me.txtPercentage.Text = ""
        Me.txtSalary.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.txtDis.Text = ""
        Me.txtPerc.Text = ""
        Me.txtSal.Text = ""
    End Sub
    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        'If Char.IsNumber(e.KeyChar) = False Then
        '    e.Handled = True
        'End If
    End Sub
    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
    End Sub
    Private Sub txtPerc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPerc.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
    End Sub
    Private Sub txtSal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSal.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
    End Sub
End Class


Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        If IsNumeric(txtGroupSize.Text) Then
            intGroup = Convert.ToInt32(txtGroupSize.Text)
            If intGroup > 0 And intGroup <= 20 Then
                If radSuperHero.Checked Then
                    decRegistration = decSuperHero
                ElseIf radAutographs.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If
                decTotalCost = (intGroup * decRegistration)
                lblTotal.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            MsgBox("enter a reasonal number between 1 and 20", , "Invalid Number Error")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTotal.Text = ""
        txtGroupSize.Focus()
        radSuperHero.Checked = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupSize.Clear()
        lblTotal.Text = ""
        radSuperHero.Checked = True
        radAutographs.Checked = False
        radConvention.Checked = False
        txtGroupSize.Focus()
    End Sub

End Class

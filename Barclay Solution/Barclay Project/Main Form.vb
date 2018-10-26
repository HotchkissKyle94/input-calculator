'Name:              Barclay Candies calculator
'Purpose:           Calculate and display candies purchased 
'
'Programmer:        Kyle Hotchkiss on 07/15/2018


Option Explicit On
Option Infer On
Option Strict On

Public Class frmMain

    Const strPrice As String = "Enter a price: "

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Static dmlTaxRate As Double = 0.05
        Dim dblTotal As Double
        Dim strCost As String
        Dim dblPrice As Double
        Dim blnIsParse As Boolean
        Dim dblSalesTax As Double

        strCost = InputBox(strPrice, "Barclay Candies")

        Do While strCost <> String.Empty
            blnIsParse = Double.TryParse(strCost, dblPrice)
            If blnIsParse Then
                lstPrices.Items.Add(Format(dblPrice, "c2"))
                dblSalesTax = (dblPrice * dmlTaxRate) + dblPrice
                dblTotal += dblSalesTax
                lblPrice.Text = dblTotal.ToString("c2")
            Else
                MessageBox.Show("Enter a valid number",
                                "Barclay Candies",
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Information)
            End If
            strCost = InputBox(strPrice, "Barclay Candies")
        Loop


    End Sub
End Class

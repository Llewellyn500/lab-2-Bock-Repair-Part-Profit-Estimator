Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' Module-level variables
    Private totalNetProfit As Decimal
    Private totalQuantity As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click
        Try
            ' Parse input values
            Dim retailPrice As Decimal = Decimal.Parse(RetailPriceTextBox.Text)
            Dim wholesaleCost As Decimal = Decimal.Parse(WholesaleCostTextBox.Text)
            Dim quantity As Integer = Integer.Parse(QuantityTextBox.Text)

            ' Calculate gross profit
            Dim grossProfit As Decimal = quantity * (retailPrice - wholesaleCost)

            ' Calculate storage charges
            Dim storageCharges As Decimal = 0.05D * grossProfit

            ' Calculate net profit
            Dim netProfit As Decimal = grossProfit - storageCharges

            ' Display results in the respective text boxes
            GrossProfitTextBox.Text = grossProfit.ToString("C")
            StorageChargesTextBox.Text = storageCharges.ToString("C")
            NetProfitTextBox.Text = netProfit.ToString("C")

            ' Accumulate total net profit and quantity
            totalNetProfit += netProfit
            totalQuantity += quantity

            ' Disable Compute button and enable Reset Form button
            ComputeBtn.Enabled = False
            ResetFormBtn.Enabled = True

            ' Set focus to Part Identifier TextBox control
            PartIdentifierTextBox.Focus()

        Catch ex As Exception
            ' Handle any exceptions that may occur
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try

    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub TotalNetProfitBtn_Click(sender As Object, e As EventArgs) Handles TotalNetProfitBtn.Click
        Try
            ' Calculate average net profit
            Dim averageNetProfit As Decimal = totalNetProfit / totalQuantity

            ' Display message box with the total net profit, total quantity, and average net profit
            MessageBox.Show("Total Net Profit: " & totalNetProfit.ToString("C") & Environment.NewLine &
                            "Total Quantity of Parts: " & totalQuantity.ToString() & Environment.NewLine &
                            "Average Net Profit: " & averageNetProfit.ToString("C"), "Total Net Profit Summary")

        Catch ex As Exception
            ' Handle any exceptions that may occur
            If totalQuantity = 0 Then
                MessageBox.Show("No parts estimates have been made yet.", "No Parts Estimates")
            Else
                MessageBox.Show("An error occurred while calculating the total net profit.", "Error")
            End If
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = ComputeBtn ' Map Compute Button to Enter key
        Me.CancelButton = ResetFormBtn ' Map Reset Form Button to Esc key
        ToolTip1.SetToolTip(RetailPriceTextBox, "Enter the retail price of the repair part.")
        ToolTip1.SetToolTip(WholesaleCostTextBox, "Enter the wholesale cost of the repair part.")
        ToolTip1.SetToolTip(QuantityTextBox, "Enter the quantity of repair parts.")
    End Sub

    Private Sub ResetFormBtn_Click(sender As Object, e As EventArgs) Handles ResetFormBtn.Click
        ' Clear all input and output controls
        PartIdentifierTextBox.Clear()
        RetailPriceTextBox.Clear()
        WholesaleCostTextBox.Clear()
        QuantityTextBox.Clear()
        GrossProfitTextBox.Clear()
        StorageChargesTextBox.Clear()
        NetProfitTextBox.Clear()

        ' Enable Compute button and disable Reset Form button
        ComputeBtn.Enabled = True
        ResetFormBtn.Enabled = False

        ' Set focus to Part Identifier TextBox control
        PartIdentifierTextBox.Focus()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub RetailPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles RetailPriceTextBox.TextChanged
        'display dolar sign and keep the cursor to the right of the dollar sign
        Dim selectionStart As Integer = RetailPriceTextBox.SelectionStart

        ' Format the text as currency with a dollar sign
        'RetailPriceTextBox.Text = FormatCurrency(RetailPriceTextBox.Text, 2, TriState.True, TriState.True, TriState.True)

        ' Set the selection start position back to the correct position
        RetailPriceTextBox.SelectionStart = selectionStart
    End Sub

    Private Sub NetProfitTextBox_TextChanged(sender As Object, e As EventArgs) Handles NetProfitTextBox.TextChanged
        ' NetProfitTextBox.Text = FormatCurrency(NetProfitTextBox.Text, 2, TriState.True, TriState.True, TriState.True)
    End Sub
End Class

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' Module-level variables
    Private totalNetProfit As Decimal
    Private totalQuantity As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click
        Try
            Dim RetailPrice, WholesaleCost As Decimal
            Dim Quantity As Integer

            'Accept and parse values
            RetailPrice = Decimal.Parse(RetailPriceTextBox.Text, Globalization.NumberStyles.Currency)
            WholesaleCost = Decimal.Parse(WholesaleCostTextBox.Text)
            Quantity = Integer.Parse(QuantityTextBox.Text)

            'perform calculations
            GrossProfitTextBox.Text = QuantityTextBox.Text * (RetailPriceTextBox.Text - WholesaleCostTextBox.Text)
            StorageChargesTextBox.Text = GrossProfitTextBox.Text * 0.05
            NetProfitTextBox.Text = GrossProfitTextBox.Text - StorageChargesTextBox.Text

            ' Disable Compute Button and enable Reset Form Button
            ComputeBtn.Enabled = False
            ResetFormBtn.Enabled = True

        Catch ex As Exception
            'show error message for invalid input
            MessageBox.Show("Error in Retail Price, Wholesale Cost, or Quantity")
        End Try

    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub TotalNetProfitBtn_Click(sender As Object, e As EventArgs) Handles TotalNetProfitBtn.Click
        Try
            ' Check if any parts estimates have been made
            If totalQuantity = 0 Then
                MessageBox.Show("No parts estimates have been made yet.")
                Return
            End If

            ' Compute average net profit
            Dim averageNetProfit As Decimal = totalNetProfit / totalQuantity

            ' Display the total net profit, total quantity, and average net profit
            Dim message As String = $"Total Net Profit: {totalNetProfit:C}" & vbCrLf &
                                    $"Total Quantity: {totalQuantity}" & vbCrLf &
                                    $"Average Net Profit: {averageNetProfit:C}"
            MessageBox.Show(message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
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
        RetailPriceTextBox.Clear()
        WholesaleCostTextBox.Clear()
        QuantityTextBox.Clear()
        GrossProfitTextBox.Clear()
        StorageChargesTextBox.Clear()
        NetProfitTextBox.Clear()
        PartIdentifierTextBox.Clear()
        PartDescriptionTextBox.Clear()

        ' Reset module-level variables
        totalNetProfit = 0
        totalQuantity = 0

        ' Enable Compute Button and disable Reset Form Button
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
        RetailPriceTextBox.Text = FormatCurrency(RetailPriceTextBox.Text, 2, TriState.True, TriState.True, TriState.True)

        ' Set the selection start position back to the correct position
        RetailPriceTextBox.SelectionStart = selectionStart
    End Sub

    Private Sub NetProfitTextBox_TextChanged(sender As Object, e As EventArgs) Handles NetProfitTextBox.TextChanged
        NetProfitTextBox.Text = FormatCurrency(NetProfitTextBox.Text, 2, TriState.True, TriState.True, TriState.True)
    End Sub
End Class

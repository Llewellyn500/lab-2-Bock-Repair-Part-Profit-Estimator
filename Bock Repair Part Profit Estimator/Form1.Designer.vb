<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        PartDescriptionTextBox = New TextBox()
        PartIdentifierTextBox = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        WholesaleCostTextBox = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        RetailPriceTextBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        QuantityTextBox = New TextBox()
        GrossProfitTextBox = New TextBox()
        StorageChargesTextBox = New TextBox()
        NetProfitTextBox = New TextBox()
        ComputeBtn = New Button()
        ResetFormBtn = New Button()
        TotalNetProfitBtn = New Button()
        ExitBtn = New Button()
        ToolTip1 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PartDescriptionTextBox)
        GroupBox1.Controls.Add(PartIdentifierTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.HotTrack
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(374, 95)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Part Information"
        ' 
        ' PartDescriptionTextBox
        ' 
        PartDescriptionTextBox.Location = New Point(118, 61)
        PartDescriptionTextBox.Name = "PartDescriptionTextBox"
        PartDescriptionTextBox.Size = New Size(241, 23)
        PartDescriptionTextBox.TabIndex = 3
        ' 
        ' PartIdentifierTextBox
        ' 
        PartIdentifierTextBox.Location = New Point(118, 28)
        PartIdentifierTextBox.Name = "PartIdentifierTextBox"
        PartIdentifierTextBox.Size = New Size(241, 23)
        PartIdentifierTextBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(6, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 1
        Label2.Text = "Part Description:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(6, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 0
        Label1.Text = "Part Identifier:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(WholesaleCostTextBox)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(RetailPriceTextBox)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.ForeColor = SystemColors.HotTrack
        GroupBox2.Location = New Point(12, 113)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(259, 223)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Price, Cost, Storage, Profit"
        ' 
        ' WholesaleCostTextBox
        ' 
        WholesaleCostTextBox.Location = New Point(118, 57)
        WholesaleCostTextBox.Name = "WholesaleCostTextBox"
        WholesaleCostTextBox.Size = New Size(135, 23)
        WholesaleCostTextBox.TabIndex = 5
        WholesaleCostTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(6, 189)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 15)
        Label8.TabIndex = 3
        Label8.Text = "Net Profit:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(6, 154)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 15)
        Label7.TabIndex = 3
        Label7.Text = "Storage Charges:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(6, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 15)
        Label6.TabIndex = 3
        Label6.Text = "Gross Profit:"
        ' 
        ' RetailPriceTextBox
        ' 
        RetailPriceTextBox.Location = New Point(118, 29)
        RetailPriceTextBox.Name = "RetailPriceTextBox"
        RetailPriceTextBox.Size = New Size(135, 23)
        RetailPriceTextBox.TabIndex = 4
        RetailPriceTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(6, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 3
        Label5.Text = "Quantity:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(6, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 2
        Label4.Text = "Wholesale Cost:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(6, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 1
        Label3.Text = "Retail Price:"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(216, 199)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(49, 23)
        QuantityTextBox.TabIndex = 6
        QuantityTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' GrossProfitTextBox
        ' 
        GrossProfitTextBox.Location = New Point(130, 232)
        GrossProfitTextBox.Name = "GrossProfitTextBox"
        GrossProfitTextBox.ReadOnly = True
        GrossProfitTextBox.Size = New Size(135, 23)
        GrossProfitTextBox.TabIndex = 7
        GrossProfitTextBox.TabStop = False
        GrossProfitTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' StorageChargesTextBox
        ' 
        StorageChargesTextBox.Location = New Point(130, 264)
        StorageChargesTextBox.Name = "StorageChargesTextBox"
        StorageChargesTextBox.ReadOnly = True
        StorageChargesTextBox.Size = New Size(135, 23)
        StorageChargesTextBox.TabIndex = 8
        StorageChargesTextBox.TabStop = False
        StorageChargesTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' NetProfitTextBox
        ' 
        NetProfitTextBox.Location = New Point(130, 299)
        NetProfitTextBox.Name = "NetProfitTextBox"
        NetProfitTextBox.ReadOnly = True
        NetProfitTextBox.Size = New Size(135, 23)
        NetProfitTextBox.TabIndex = 9
        NetProfitTextBox.TabStop = False
        NetProfitTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ComputeBtn
        ' 
        ComputeBtn.Location = New Point(285, 142)
        ComputeBtn.Name = "ComputeBtn"
        ComputeBtn.Size = New Size(101, 32)
        ComputeBtn.TabIndex = 10
        ComputeBtn.Text = "Compute"
        ComputeBtn.UseVisualStyleBackColor = True
        ' 
        ' ResetFormBtn
        ' 
        ResetFormBtn.Enabled = False
        ResetFormBtn.Location = New Point(285, 187)
        ResetFormBtn.Name = "ResetFormBtn"
        ResetFormBtn.Size = New Size(101, 32)
        ResetFormBtn.TabIndex = 11
        ResetFormBtn.Text = "Reset Form"
        ResetFormBtn.UseVisualStyleBackColor = True
        ' 
        ' TotalNetProfitBtn
        ' 
        TotalNetProfitBtn.Location = New Point(285, 232)
        TotalNetProfitBtn.Name = "TotalNetProfitBtn"
        TotalNetProfitBtn.Size = New Size(101, 42)
        TotalNetProfitBtn.TabIndex = 12
        TotalNetProfitBtn.Text = "Total Net" & vbCrLf & "Profit"
        TotalNetProfitBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(285, 285)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(101, 32)
        ExitBtn.TabIndex = 13
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 350)
        Controls.Add(ExitBtn)
        Controls.Add(TotalNetProfitBtn)
        Controls.Add(ResetFormBtn)
        Controls.Add(ComputeBtn)
        Controls.Add(NetProfitTextBox)
        Controls.Add(StorageChargesTextBox)
        Controls.Add(GrossProfitTextBox)
        Controls.Add(QuantityTextBox)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Repair Parts Profit Estimator"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PartDescriptionTextBox As TextBox
    Friend WithEvents PartIdentifierTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents WholesaleCostTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RetailPriceTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents GrossProfitTextBox As TextBox
    Friend WithEvents StorageChargesTextBox As TextBox
    Friend WithEvents NetProfitTextBox As TextBox
    Friend WithEvents ComputeBtn As Button
    Friend WithEvents ResetFormBtn As Button
    Friend WithEvents TotalNetProfitBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTranID = New System.Windows.Forms.TextBox()
        Me.txtBasicAmount = New System.Windows.Forms.TextBox()
        Me.txtCancelAmount = New System.Windows.Forms.TextBox()
        Me.txtTranAmount = New System.Windows.Forms.TextBox()
        Me.txtMerchantID = New System.Windows.Forms.TextBox()
        Me.txtAuthKey = New System.Windows.Forms.TextBox()
        Me.txtTranAuthKey = New System.Windows.Forms.TextBox()
        Me.chkIsRefundCancel = New System.Windows.Forms.CheckBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction ID Debit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Basic Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cancel Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tran Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Merchant ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Authkey"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tran Authkey"
        '
        'txtTranID
        '
        Me.txtTranID.Location = New System.Drawing.Point(191, 47)
        Me.txtTranID.Name = "txtTranID"
        Me.txtTranID.Size = New System.Drawing.Size(100, 20)
        Me.txtTranID.TabIndex = 7
        '
        'txtBasicAmount
        '
        Me.txtBasicAmount.Location = New System.Drawing.Point(191, 82)
        Me.txtBasicAmount.Name = "txtBasicAmount"
        Me.txtBasicAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtBasicAmount.TabIndex = 8
        '
        'txtCancelAmount
        '
        Me.txtCancelAmount.Location = New System.Drawing.Point(191, 110)
        Me.txtCancelAmount.Name = "txtCancelAmount"
        Me.txtCancelAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtCancelAmount.TabIndex = 9
        '
        'txtTranAmount
        '
        Me.txtTranAmount.Location = New System.Drawing.Point(191, 141)
        Me.txtTranAmount.Name = "txtTranAmount"
        Me.txtTranAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTranAmount.TabIndex = 10
        '
        'txtMerchantID
        '
        Me.txtMerchantID.Location = New System.Drawing.Point(191, 178)
        Me.txtMerchantID.Name = "txtMerchantID"
        Me.txtMerchantID.Size = New System.Drawing.Size(100, 20)
        Me.txtMerchantID.TabIndex = 11
        Me.txtMerchantID.Text = "4"
        '
        'txtAuthKey
        '
        Me.txtAuthKey.Location = New System.Drawing.Point(191, 212)
        Me.txtAuthKey.Name = "txtAuthKey"
        Me.txtAuthKey.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthKey.TabIndex = 12
        Me.txtAuthKey.Text = "Redbus_demo"
        '
        'txtTranAuthKey
        '
        Me.txtTranAuthKey.Location = New System.Drawing.Point(191, 242)
        Me.txtTranAuthKey.Name = "txtTranAuthKey"
        Me.txtTranAuthKey.Size = New System.Drawing.Size(100, 20)
        Me.txtTranAuthKey.TabIndex = 13
        Me.txtTranAuthKey.Text = "Redbus_demo_CR"
        '
        'chkIsRefundCancel
        '
        Me.chkIsRefundCancel.AutoSize = True
        Me.chkIsRefundCancel.Location = New System.Drawing.Point(191, 288)
        Me.chkIsRefundCancel.Name = "chkIsRefundCancel"
        Me.chkIsRefundCancel.Size = New System.Drawing.Size(97, 17)
        Me.chkIsRefundCancel.TabIndex = 14
        Me.chkIsRefundCancel.Text = "Refund Cancel"
        Me.chkIsRefundCancel.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(191, 324)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 15
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.chkIsRefundCancel)
        Me.Controls.Add(Me.txtTranAuthKey)
        Me.Controls.Add(Me.txtAuthKey)
        Me.Controls.Add(Me.txtMerchantID)
        Me.Controls.Add(Me.txtTranAmount)
        Me.Controls.Add(Me.txtCancelAmount)
        Me.Controls.Add(Me.txtBasicAmount)
        Me.Controls.Add(Me.txtTranID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTranID As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTranAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtMerchantID As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthKey As System.Windows.Forms.TextBox
    Friend WithEvents txtTranAuthKey As System.Windows.Forms.TextBox
    Friend WithEvents chkIsRefundCancel As System.Windows.Forms.CheckBox
    Friend WithEvents btnTest As System.Windows.Forms.Button

End Class

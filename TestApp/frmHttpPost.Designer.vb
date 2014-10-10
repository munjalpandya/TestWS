<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHttpPost
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
        Me.btnVINTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVINTest
        '
        Me.btnVINTest.Location = New System.Drawing.Point(48, 57)
        Me.btnVINTest.Name = "btnVINTest"
        Me.btnVINTest.Size = New System.Drawing.Size(75, 23)
        Me.btnVINTest.TabIndex = 0
        Me.btnVINTest.Text = "Verify VIN"
        Me.btnVINTest.UseVisualStyleBackColor = True
        '
        'frmHttpPost
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.btnVINTest)
        Me.Name = "frmHttpPost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmHttpPost"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVINTest As System.Windows.Forms.Button
End Class

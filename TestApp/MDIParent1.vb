Imports System.Windows.Forms

Public Class MDIParent1

    Private m_ChildFormNumber As Integer

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles PGITesting.Click
        ' Create a new instance of the child form.
        Dim PGITesting As New Form1
        ' Make it a child of this MDI form before showing it.
        PGITesting.MdiParent = Me

        PGITesting.Show()

    End Sub

    Private Sub httpPost_Click(sender As System.Object, e As System.EventArgs) Handles httpPost.Click
        ' Create a new instance of the child form.
        Dim httpPost As New frmHttpPost
        ' Make it a child of this MDI form before showing it.
        httpPost.MdiParent = Me

        httpPost.Show()

    End Sub
End Class

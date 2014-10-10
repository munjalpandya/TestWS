Imports System.Net
Imports System.Collections.Specialized
Public Class frmHttpPost

    Private Sub frmHttpPost_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVINTest_Click(sender As System.Object, e As System.EventArgs) Handles btnVINTest.Click
        Try
            Dim strURL As String = "http://api.vehiclehistory.co/query.php"

            Dim arrResponse As Byte()

            Dim wrVIN As New WebClient()

            Dim nvVIN As New NameValueCollection()

            nvVIN("vin") = "1VXBR12EXCP901213"
            nvVIN("key") = "test"
            nvVIN("format") = "xml"

            arrResponse = wrVIN.UploadValues(strURL, "POST", nvVIN)

            MsgBox(arrResponse, MsgBoxStyle.OkCancel)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        
    End Sub
End Class
Imports TestApp.PGI
Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Dim objOSSWebServices As PGITransactionServicesVer2SoapClient

        Dim strParamXML As String = ""

        Dim dstXML As DataSet = Nothing

        Dim intTransactionIDDebit As Integer = Val(txtTranID.Text.Trim)
        Dim dblBasicAmount As Double = Val(txtBasicAmount.Text.Trim)
        Dim dblCancelAmount As Double = Val(txtCancelAmount.Text.Trim)
        Dim dblTranAmount As Double = Val(txtTranAmount.Text.Trim)
        Dim intMerchantID As Integer = Val(txtMerchantID.Text.Trim)

        'Dim blnRefundCancel As Boolean

        Try

            objOSSWebServices = New PGITransactionServicesVer2SoapClient

            strParamXML = ""
            strParamXML = strParamXML & "<AddDistTranRefundCancel "
            strParamXML = strParamXML & " intTransactionIDDebit=""" & intTransactionIDDebit & """"
            strParamXML = strParamXML & " dblBasicAmount=""" & dblBasicAmount & """"
            strParamXML = strParamXML & " dblCancelAmount=""" & dblCancelAmount & """"
            strParamXML = strParamXML & " dblTranAmount=""" & dblTranAmount & """"
            strParamXML = strParamXML & " intMerchantID=""" & intMerchantID & """"
            strParamXML = strParamXML & " strAuthKey=""" & txtAuthKey.Text.Trim & """"
            strParamXML = strParamXML & " strAuthKeyTran=""" & txtTranAuthKey.Text.Trim & """"
            strParamXML = strParamXML & " intInterfaceID=""" & 1 & """"
            strParamXML = strParamXML & " />"

            'txtRequestXML.Text = strParamXML

            If chkIsRefundCancel.Checked = True Then
                strParamXML = objOSSWebServices.AddAgentTransactionRefund(strParamXML)
            Else
                strParamXML = objOSSWebServices.AddAgentTransactionCancel(strParamXML)
            End If

            MsgBox(strParamXML)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not objOSSWebServices Is Nothing Then
                objOSSWebServices.Close()
                objOSSWebServices = Nothing
            End If
            If Not dstXML Is Nothing Then dstXML = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox(Integer.Parse(Regex.Replace(txtString.Text, "[^\d]", "")))
    End Sub
End Class

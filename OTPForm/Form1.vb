Imports OtpNet
Imports System.Text
Public Class Form1
    Dim otp As New OTP.OTPService
    Dim key As String = "softwel123"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim verify As Boolean
        verify = otp.VerifyOTP(txtVerifyOTP.Text, key)
        If verify Then
            MsgBox("OTP Verified Successfully." & vbCrLf & "Remaining Time in Seconds: " & otp.RemainingTimeInSecond(key))
        Else
            MsgBox("OTP Doesnot Match.")
        End If
    End Sub
    ''' <summary>
    ''' 120- 2minutes of validity of current OTP code.
    ''' After 2 minutes New OTP can be generated.
    ''' </summary>
    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim otp As New Totp(Encoding.UTF8.GetBytes(key), 120, OtpHashMode.Sha256)
        txtOTP.Text = otp.ComputeTotp()
        MsgBox("Remaining Time in Seconds: " & otp.RemainingSeconds)
    End Sub
End Class

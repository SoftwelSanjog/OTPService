Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports OtpNet

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://softwel.com.np/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class OTPService
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function ComputeOTP(ByVal key As String) As String
        Dim OTPCode As String = String.Empty
        Try
            Dim TOTP = New Totp(Encoding.UTF8.GetBytes(key), 120, OtpHashMode.Sha256)
            OTPCode = TOTP.ComputeTotp
        Catch ex As Exception

        End Try
        Return OTPCode
    End Function
    <WebMethod()>
    Public Function VerifyOTP(ByVal otpcode As String, ByVal key As String) As Boolean
        Dim tot As Totp = New Totp(Encoding.UTF8.GetBytes(key), 120, OtpHashMode.Sha256)
        Dim timestepmatched As Long
        Return tot.VerifyTotp(otpcode, timestepmatched)
    End Function
    <WebMethod()>
    Public Function RemainingTimeInSecond(ByVal key As String) As Long
        Dim tot As Totp = New Totp(Encoding.UTF8.GetBytes(key), 120, OtpHashMode.Sha256)
        Return tot.RemainingSeconds
    End Function
End Class
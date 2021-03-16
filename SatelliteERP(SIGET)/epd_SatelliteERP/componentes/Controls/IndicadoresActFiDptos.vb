Imports System.IO

Public Class IndicadoresActFiDptos


    Public Sub loadControls(ByVal Transferidos As Integer, ByVal Proceso As Integer, ByVal SinTransferencia As Integer, ByVal Total As Integer, ByVal Departamento As String, ByVal Ubicacion As String)
        lblTransferidos.Text = Transferidos
        lblProceso.Text = Proceso
        lblSinTransferencia.Text = SinTransferencia
        lblTotal.Text = Total
        txtDepartamento.Text = Departamento
    End Sub

    Public Function Base64ToImage(base64String As String) As Image

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim Picture As Image = Image.FromStream(ms, True)
        Return Picture
    End Function

End Class

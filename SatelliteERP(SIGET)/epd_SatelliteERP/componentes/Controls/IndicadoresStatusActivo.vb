Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class IndicadoresStatusActivo
    Property dt As New DataTable

    Public Sub loadControls(ByVal Departamento As String)
        txtDepartamento.Text = Departamento
        If dt.Rows.Count > 0 Then
            Chart1.Series("Series1").XValueMember = "nombreEstado"
            Chart1.Series("Series1").YValueMembers = "total"

            Chart1.DataSource = dt
        End If
    End Sub

    Public Function Base64ToImage(base64String As String) As Image

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim Picture As Image = Image.FromStream(ms, True)
        Return Picture
    End Function

    Private Sub IndicadoresStatusActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class

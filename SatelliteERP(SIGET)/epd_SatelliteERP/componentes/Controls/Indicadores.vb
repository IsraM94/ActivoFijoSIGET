Imports System.IO

Public Class Indicadores
    'Private _obj As New Operaciones_Produccion

    'Sub New(ByVal obj As Operaciones_Produccion)
    '	_obj = obj
    '       ' This call is required by the designer.
    '       InitializeComponent()

    '       ' Add any initialization after the InitializeComponent() call.

    '   End Sub

    Public Sub loadControls(ByVal DiasMaximo As Integer, ByVal PromedioDias As Integer, ByVal NoSeleccionados As Integer, ByVal NoTotalVacio As Integer, ByVal Image As String, ByVal Ciclo As String, ByVal Grupo As String, ByVal DiasRojo As Double, ByVal DiasAmarillo As Double, ByVal DiasVerde As Double)
		lblMaximoDias.Text = DiasMaximo
		lblSeleccionados.Text = NoSeleccionados
		lblPromedioDias.Text = PromedioDias
		lblTotal.Text = NoTotalVacio
		txtCiclo.Text = Ciclo
		txtGrupo.Text = Grupo
		If Image = "" Then
			pbGroup.Image = My.Resources.imagekpi
		Else
			Try
				pbGroup.Image = Base64ToImage(Image)
			Catch ex As Exception
				pbGroup.Image = My.Resources.imagekpi
			End Try
		End If

        If DiasMaximo >= DiasRojo Then
            pbIndicador.Image = My.Resources.Rojo
        ElseIf DiasMaximo >= DiasAmarillo Then
            pbIndicador.Image = My.Resources.Amarillo
        ElseIf DiasMaximo <= DiasVerde And DiasMaximo > 0 And DiasMaximo < DiasRojo And DiasMaximo < DiasAmarillo Then
            pbIndicador.Image = My.Resources.alerts
		Else
			pbIndicador.Image = My.Resources.Rojo
		End If

	End Sub

	Public Function Base64ToImage(base64String As String) As Image

		Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
		Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

		ms.Write(imageBytes, 0, imageBytes.Length)
		Dim Picture As Image = Image.FromStream(ms, True)
		Return Picture
	End Function
End Class

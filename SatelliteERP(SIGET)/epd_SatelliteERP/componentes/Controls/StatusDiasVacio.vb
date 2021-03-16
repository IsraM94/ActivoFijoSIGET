Public Class StatusDiasVacio
    'Private _obj As New Operaciones_Produccion

    'Sub New(ByVal obj As Operaciones_Produccion)
    '    _obj = obj
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    'End Sub
    Public Sub loadControls(ByVal CodigoAnimal As String, ByVal nombre As String, ByVal diasvacio As Integer)
		txtCodigo.Text = CodigoAnimal
		txtNombre.Text = nombre
		txtDias.Text = diasvacio

		If diasvacio > 10 Then
			pbIndicador.Image = My.Resources.Rojo
		ElseIf diasvacio > 5 Then
			pbIndicador.Image = My.Resources.Amarillo
		Else
			pbIndicador.Image = My.Resources.alerts
		End If
    End Sub
End Class

Public Class CxC
	Private _ID_Solicitud As Long = 0
	Private _Obj As Generic_RequestPending
	Sub New(ByVal obj As Generic_RequestPending)
		' This call is required by the designer.
		InitializeComponent()
		_Obj = obj
		' Add any initialization after the InitializeComponent() call.
	End Sub
	Private Sub CxC_Click(sender As Object, e As EventArgs) Handles Me.Click, txtCliente.Click, txtComentario.Click, txtCredito.Click, txtEmpleado.Click, Label1.Click, Label11.Click, Label12.Click, Label3.Click, Label6.Click, Label7.Click, Label8.Click, lblFecha.Click, lblID_Solicitud.Click, lblMonto.Click, txtTipo.Click, Label2.Click
		Me.BackColor = Color.LightGreen
	End Sub

	Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
		If MessageBox.Show("¿Está seguro que desea aprobar esta solicitud?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
			Dim resp As Integer = 0
			resp = Procesar(True)
			If resp = 1 Then
				MessageBox.Show("Solicitud Aprobada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
				_Obj.LoadCxC()
			Else
				MessageBox.Show("Ocurrio un error al procesar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End If
	End Sub

	Private Sub cmdDenegar_Click(sender As Object, e As EventArgs) Handles cmdDenegar.Click
		If MessageBox.Show("¿Está seguro que desea denegar esta solicitud?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
			Dim resp As Integer = 0
			resp = Procesar(False)
			If resp = 1 Then
				MessageBox.Show("Solicitud denegada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
				_Obj.LoadCxC()
			Else
				MessageBox.Show("Ocurrio un error al denegar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End If
	End Sub

	Private Function Procesar(ByVal Aprobar As Boolean) As Integer
		Dim resp As Integer = 0
		Using objsql As New Financiero_SQLServer
			resp = objsql.ERP_Finance_RequestUpdate(_ID_Solicitud, _SystemUser, Aprobar)
		End Using
		Return resp
	End Function
	Public Sub LoadData(ByVal ID_Solicitud As Long, ByVal Fecha As String, ByVal Monto As Double, ByVal Credit As String, ByVal Catalog As String, ByVal Empleado As String, ByVal cliente As String, ByVal comentario As String)
		_ID_Solicitud = ID_Solicitud
		lblID_Solicitud.Text = ID_Solicitud
		lblFecha.Text = Fecha
		lblMonto.Text = Monto.ToString("$###,###,##0.00")
		txtCredito.Text = Credit
		txtTipo.Text = Catalog
		txtEmpleado.Text = Empleado
		txtCliente.Text = cliente
		txtComentario.Text = comentario
	End Sub

	Private Sub CxC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class

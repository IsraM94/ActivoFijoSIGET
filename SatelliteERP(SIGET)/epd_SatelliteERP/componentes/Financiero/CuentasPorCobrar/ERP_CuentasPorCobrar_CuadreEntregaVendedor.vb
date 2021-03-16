Public Class ERP_CuentasPorCobrar_CuadreEntregaVendedor

	Private _DT_Data As New DataTable
	Private _DT_EMpleados As DataTable

	Private Sub LoadEmpleados()
		Using objsql As New HumanResources_SQLServer
			_DT_EMpleados = objsql.GetEmploye(_ID_Company)
		End Using
		cbVendedor.DataSource = _DT_EMpleados
		cbVendedor.ValueMember = "Id_employee"
		cbVendedor.DisplayMember = "Contact"
		cbVendedor.SelectedIndex = -1
	End Sub
	Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
		Dim id_Vendedor As Long = 0
		Dim fecha As Date
		If cbVendedor.SelectedIndex = -1 Then
			MessageBox.Show("Seleccione un vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		fecha = DateTimePicker1.Value
		id_Vendedor = cbVendedor.SelectedValue
		Using objsql As New Financiero_SQLServer
			_DT_Data = objsql.ERP_Prod_SP_ProductionOrderDeliveryCustomer(fecha, id_Vendedor)
		End Using
		If _DT_Data.Rows.Count > 0 Then
			dgvProducts.DataSource = _DT_Data
		Else
			MessageBox.Show("No existen entregas para el vendedor seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

	End Sub

	Private Sub ERP_CuentasPorCobrar_CuadreEntregaVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadEmpleados()
		dgvProducts.AutoGenerateColumns = False
	End Sub

	Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
		If Not dgvProducts.CurrentRow Is Nothing Then
			For Each row As DataGridViewRow In dgvProducts.Rows
				If Not IsNumeric(row.Cells("CantidadEntregada").Value) Then
                    MessageBox.Show("Por favor ingrese un valor numérico para el producto:" & row.Cells("Description").Value & ", del cliente: " & row.Cells("Name_Company").Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
				End If
			Next row
			Dim resp As Integer = 0
			Using objsql As New Financiero_SQLServer
				Try
					For Each row As DataGridViewRow In dgvProducts.Rows
						resp = objsql.ERP_Prod_SP_ProductionOrderDeliveryCustomerUpdate(row.Cells("ID_TransactionDetail").Value, row.Cells("CantidadEntregada").Value).Rows(0).Item(0)
					Next row
				Catch ex As Exception
					resp = 0
				End Try
			End Using
			If resp = 1 Then
                MessageBox.Show("Proceso finalizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _DT_Data = New DataTable
				dgvProducts.DataSource = _DT_Data
			Else
                MessageBox.Show("Ocurrió un error al realizar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
		End If
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

    Private Sub GbClientes_Enter(sender As Object, e As EventArgs) Handles GbClientes.Enter

    End Sub

    Private Sub dgvProducts_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvProducts.CellValidating
        If dgvProducts.Columns(e.ColumnIndex).Name = "CantidadEntregada" Then
            If Not IsNumeric(e.FormattedValue) Then
                e.Cancel = True
                dgvProducts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                dgvProducts.Refresh()
                dgvProducts.RefreshEdit()

            End If

        End If
    End Sub

#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region
End Class
Public Class Generic_SeleccionarProducto
    Private objSqlGeneric As New Generic_SQLServer
	Private _dtCustomerMaster As DataTable
	Property IS_Bodega As Boolean = False
	Property rowSelection As DataRow
	Property Id_Customer_FK As Long = 0
    Property ID_Stowage As Long = 0
    Property UnidadMedidaSend As String = ""
    Property Producto As String = ""
    Property ShowPrice As Boolean = False
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.No
        Close()
    End Sub
    Private Sub GetProduct()
        _dtCustomerMaster = objSqlGeneric.GetProduct(Data_Id_Company, txtWhere.Text)
        DGW_Products.ReadOnly = True
		DGW_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		DGW_Products.MultiSelect = False
		DGW_Products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
		DGW_Products.AllowUserToResizeColumns = False
		DGW_Products.AllowUserToAddRows = False
		DGW_Products.AllowUserToDeleteRows = False
        DGW_Products.Font = New Font("Segoe UI", 11)
        DGW_Products.AutoGenerateColumns = False
        DGW_Products.Columns(0).Width = 110
        DGW_Products.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_Products.Columns(1).Width = 150
        DGW_Products.Columns(2).Width = 400
        DGW_Products.Columns(3).Width = 90
        DGW_Products.Columns(4).Width = 120
        'DGW_Custom.Columns(6).Width = 120
        'DGW_Custom.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGW_Custom.Columns(6).DefaultCellStyle.Format = "c"
        If Id_Customer_FK = 0 Then
			DGW_Products.DataSource = _dtCustomerMaster
		Else
			Dim dv As New DataView
			dv = New DataView(_dtCustomerMaster, "Id_Customer_FK  = " & Id_Customer_FK.ToString, "", DataViewRowState.CurrentRows)
			DGW_Products.DataSource = dv
		End If
	End Sub
	Private Sub GetProductsByStowage()
		Using objSQl As New Operaciones_SQLServer
            _dtCustomerMaster = objSQl.ERP_Inventory_GetProducts_Stowage(Data_Id_Company, txtWhere.Text, ID_Stowage)
            DGW_Products.ReadOnly = True
			DGW_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			DGW_Products.MultiSelect = False
			DGW_Products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
			DGW_Products.AllowUserToResizeColumns = False
            DGW_Products.AllowUserToAddRows = False
            DGW_Products.Font = New Font("Segoe UI", 11)
            DGW_Products.AllowUserToDeleteRows = False
			REM  DGW_Custom.DefaultCellStyle.Font.Size = 11
			DGW_Products.AutoGenerateColumns = False
			DGW_Products.Columns(0).Width = 110
			DGW_Products.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGW_Products.Columns(1).Width = 150
            DGW_Products.Columns(2).Width = 400
            DGW_Products.Columns(3).Width = 90
            DGW_Products.Columns(4).Width = 120
            'DGW_Custom.Columns(6).Width = 120
            'DGW_Custom.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'DGW_Custom.Columns(6).DefaultCellStyle.Format = "c"
            DGW_Products.DataSource = _dtCustomerMaster

		End Using
	End Sub
	Private Sub txtWhere_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWhere.KeyPress

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Down
                DGW_Products.Focus()
            Case Keys.Enter
                If DGW_Products.Focused Then
                    If DGW_Products.RowCount > 0 Then
                        If DGW_Products.SelectedRows.Count > 0 Then
                            For Each row As DataRow In _dtCustomerMaster.Select("Id_Product=" & DGW_Products.CurrentRow.Cells(0).Value)
                                _rowSelection = row
                                Me.DialogResult = DialogResult.OK
                                Close()
                            Next
                        End If


                    End If
                End If
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Generic_SeleccionarProducto_Load(sender As Object, e As EventArgs) Handles Me.Load
        DGW_Products.ReadOnly = True
        DGW_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_Products.MultiSelect = False
        DGW_Products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_Products.AllowUserToResizeColumns = False
        DGW_Products.AllowUserToAddRows = False
        DGW_Products.AllowUserToDeleteRows = False
        DGW_Products.Font = New Font("Segoe UI", 11)
        DGW_Products.AutoGenerateColumns = False
        DGW_Products.Columns(0).Width = 110
        DGW_Products.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_Products.Columns(1).Width = 400
        DGW_Products.Columns(2).Width = 90
        DGW_Products.Columns(3).Width = 120
        If ShowPrice Then
            DGW_Products.Columns("Price_Sale").Visible = True
        End If
    End Sub

    Private Sub cmdSeleccionar_Click(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click
        DGW_Products.Focus()
        If DGW_Products.Focused Then
            If DGW_Products.RowCount > 0 Then
                If DGW_Products.SelectedRows.Count > 0 Then
                    For Each row As DataRow In _dtCustomerMaster.Select("Id_Product=" & DGW_Products.CurrentRow.Cells(0).Value)
                        _rowSelection = row
                        Try
                            UnidadMedidaSend = row.Item("Name_UnitMeasure").ToString
                        Catch ex As Exception
                            UnidadMedidaSend = ""
                        End Try

                        Try
                            Producto = row.Item("Name_Product").ToString
                        Catch ex As Exception
                            Producto = ""
                        End Try
                        Me.DialogResult = DialogResult.OK
                        Close()
                    Next
                End If
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

    Private Sub txtWhere_TextChanged(sender As Object, e As EventArgs) Handles txtWhere.TextChanged
        If txtWhere.Text.ToString.Length > 0 Then
            If _IS_Bodega Then
                GetProductsByStowage()
            Else
                GetProduct()
            End If
        Else
            If _IS_Bodega Then
                GetProductsByStowage()
            Else
                GetProduct()
            End If
        End If
    End Sub

    Private Sub DGW_Products_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Products.CellDoubleClick
        DGW_Products.Focus()
        If DGW_Products.Focused Then
            If DGW_Products.RowCount > 0 Then
                If DGW_Products.SelectedRows.Count > 0 Then
                    For Each row As DataRow In _dtCustomerMaster.Select("Id_Product=" & DGW_Products.CurrentRow.Cells(0).Value)
                        _rowSelection = row
                        Try
                            UnidadMedidaSend = row.Item("Name_UnitMeasure").ToString
                        Catch ex As Exception
                            UnidadMedidaSend = ""
                        End Try

                        Try
                            Producto = row.Item("Name_Product").ToString
                        Catch ex As Exception
                            Producto = ""
                        End Try

                        Me.DialogResult = DialogResult.OK
                        Close()
                    Next
                End If
            End If
        End If
    End Sub
#End Region
End Class
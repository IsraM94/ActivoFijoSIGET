Public Class Generic_SeleccionarCliente
    Private objSqlGeneric As New Generic_SQLServer
    Private _dtCustomerMaster As DataTable
    Property rowSelection As DataRow
	Property Is_CustumerProvider As Boolean = False
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.No
        Close()
    End Sub


	Private Sub GetCustomer()
        If Not Is_CustumerProvider Then
            _dtCustomerMaster = objSqlGeneric.GetCustomerMaster(Data_Id_Company, "%" & txtWhere.Text & "%")
        Else
            _dtCustomerMaster = objSqlGeneric.GetCustomerMaster_Provider(Data_Id_Company, "%" & txtWhere.Text & "%")
        End If
        DGW_Custom.Font = New Font("Segoe UI", 11)
        DGW_Custom.ReadOnly = True
		DGW_Custom.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		DGW_Custom.MultiSelect = False
		DGW_Custom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
		DGW_Custom.AllowUserToResizeColumns = False
		DGW_Custom.AllowUserToAddRows = False
		DGW_Custom.AllowUserToDeleteRows = False
        REM  DGW_Custom.DefaultCellStyle.Font.Size = 11

        DGW_Custom.AutoGenerateColumns = False
		DGW_Custom.Columns(0).Width = 110
		DGW_Custom.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DGW_Custom.Columns(1).Width = 400
		DGW_Custom.Columns(2).Width = 90
		DGW_Custom.Columns(3).Width = 120
		DGW_Custom.Columns(4).Width = 120
		DGW_Custom.Columns(5).Width = 120
		DGW_Custom.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DGW_Custom.Columns(5).DefaultCellStyle.Format = "c"
        'DGW_Custom.Columns(6).Width = 120
        'DGW_Custom.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGW_Custom.Columns(6).DefaultCellStyle.Format = "c"


        DGW_Custom.DataSource = _dtCustomerMaster
	End Sub

	Private Sub txtWhere_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWhere.KeyPress
        If e.KeyChar = vbCr Then
            GetCustomer()
        End If
        If (txtWhere.Text.ToString.Length > 1) Then
            GetCustomer()
        End If


    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Down
                DGW_Custom.Focus()
            Case Keys.Enter
                If DGW_Custom.Focused Then
                    If Not DGW_Custom.CurrentRow Is Nothing Then ' validar gridview que no este vacio
                        REM    MessageBox.Show("entro " & DGW_Custom.CurrentRow.Cells(0).Value)
                        Dim id As Integer = DGW_Custom.CurrentRow.Cells(0).Value
                        Dim Consulta As String = "Id_Customer = " & DGW_Custom.CurrentRow.Cells(0).Value & ""
                        If id <> 0 Then
                            For Each row As DataRow In _dtCustomerMaster.Select(Consulta)
                                If Not row Is Nothing Then
                                    _rowSelection = row
                                    Me.DialogResult = DialogResult.OK
                                    Close()
                                End If
                            Next row
                        Else
                            MessageBox.Show("Por favor seleccione un proveedor", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    End If
                End If
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

	Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
		GetCustomer()
	End Sub

	Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        If DGW_Custom.CurrentRow Is Nothing Then
            MessageBox.Show("Tiene que seleccionar un registro, por favor", "SatellitePOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim id As Integer = DGW_Custom.CurrentRow.Cells(0).Value
		Dim Consulta As String = "Id_Customer = " & id & ""
        If id <> 0 Then
            For Each row As DataRow In _dtCustomerMaster.Select(Consulta)
                If Not row Is Nothing Then
                    _rowSelection = row
                    Me.DialogResult = DialogResult.OK
                    Close()
                End If
            Next row
        Else
            MessageBox.Show("Por favor seleccione un proveedor o cliente", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub Generic_SeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGW_Custom.Font = New Font("Segoe UI", 11)
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


    Private Sub DGW_Custom_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Custom.CellDoubleClick
        If DGW_Custom.CurrentRow Is Nothing Then
            MessageBox.Show("Tiene que seleccionar un registro, por favor", "SatellitePOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim id As Integer = DGW_Custom.CurrentRow.Cells(0).Value
        Dim Consulta As String = "Id_Customer = " & id & ""
        If id <> 0 Then
            For Each row As DataRow In _dtCustomerMaster.Select(Consulta)
                If Not row Is Nothing Then
                    _rowSelection = row
                    Me.DialogResult = DialogResult.OK
                    Close()
                End If
            Next row
        Else
            MessageBox.Show("Por favor seleccione un proveedor o cliente", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
#End Region
End Class
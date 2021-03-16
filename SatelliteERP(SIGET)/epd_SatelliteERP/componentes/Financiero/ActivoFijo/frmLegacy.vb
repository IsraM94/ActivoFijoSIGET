Public Class frmLegacy
    Private _DT_Employee As DataTable
    Private _DT_Product_Legacy As DataTable
    Private _DT_Product_Legacy_Find As DataTable
    Dim objGeneric As New Generic_SQLServer

    Property OpcionSeleccionada As Funcion
    Enum Funcion
        Agregar
        Actualizar
    End Enum

    Private Sub frmLegacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _DT_Employee = objGeneric.GetEmployee(Data_Id_Company)
        cbxResponsable.DataSource = _DT_Employee
        cbxResponsable.DisplayMember = "Contact"
        cbxResponsable.ValueMember = "Id_employee"
        dgvProducto.DataSource = _DT_Product_Legacy

        dgvProducto.AutoGenerateColumns = False
        dgvProducto.Font = New Font("Segoe UI", 11)
        dgvProducto.Columns(0).Width = 100
        dgvProducto.Columns(1).Width = 250
        dgvProducto.Columns(2).Width = 140
        dgvProducto.Columns(3).Width = 100
        dgvProducto.Columns(4).Width = 100

        dgvProducto.ReadOnly = True
        dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducto.MultiSelect = False
        dgvProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvProducto.AllowUserToResizeColumns = False
        dgvProducto.AllowUserToAddRows = False
        dgvProducto.AllowUserToDeleteRows = False
        txtCodBar.Focus()
        chkConsulta.Checked = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using obj As New Financiero_CreaActivoFijo
            obj.OpcionSeleccionada = Financiero_CreaActivoFijo.Funcion.Actualizar
            ' row = _DT_Product_Legacy_Find.Rows ' _tableFixedAssetsMaster.Select("ID_FixedAssets=" & DG_FixedAssets.CurrentRow.Cells(1).Value)

            _DT_Product_Legacy_Find = objGeneric.GetERP_Generic_FromXLS_Get(txtCodBar.Text)
            If _DT_Product_Legacy_Find.Rows.Count > 0 Then

                Dim Produto As DataRow = _DT_Product_Legacy_Find.Rows(0)
                If Not Produto("ID_FixedAssets").ToString = "" Then
                    If MessageBox.Show("Archivo importado anteriormente y asignado a: " + Produto("employee") + ", ¿desea modificarlo?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
                If Not chkConsulta.Checked Then
                    Produto.BeginEdit()
                    Produto("Id_ResponsiblePerson_FK") = cbxResponsable.SelectedValue
                    Produto.EndEdit()
                Else
                    obj.Is_Consulta = False
                End If
                obj.rowRegistroActual = Produto

                obj.ID_Legacy = Produto("ID_Legacy")
                If obj.ShowDialog = DialogResult.OK Then
                    Dim arreglo As String() = obj.Respuesta.Split("|")
                    If arreglo(0).ToUpper.Trim = "OK" Then
                        objGeneric.GetERP_Generic_FromXLS_Actualiza(txtCodBar.Text, arreglo(1).Trim)
                    End If

                    If _DT_Product_Legacy Is Nothing Then
                        _DT_Product_Legacy = _DT_Product_Legacy_Find
                    Else
                        For Each reg As DataRow In _DT_Product_Legacy_Find.Rows
                            Dim dv As DataView = New DataView(_DT_Product_Legacy)
                            dv.RowFilter = String.Format("Number_Purchase='{0}'", reg("Number_Purchase"))
                            If dv.Count = 0 Then
                                _DT_Product_Legacy.ImportRow(reg)
                            End If

                        Next
                    End If
                    _DT_Product_Legacy_Find = objGeneric.GetERP_Generic_FromXLS_Get(txtCodBar.Text)
                    dgvProducto.DataSource = _DT_Product_Legacy_Find
                    txtCodBar.Text = ""
                    txtCodBar.Focus()
                End If
            Else
                MessageBox.Show("Registro no existe en la Base Legacy")
                txtCodBar.Focus()
            End If
        End Using

    End Sub

    Private Sub btnPrintCodeBar_Click(sender As Object, e As EventArgs) Handles btnPrintCodeBar.Click
        Try
            If Not _DT_Product_Legacy.Rows.Count = 0 Then
                Dim dsCodeBar As New dsCodeBar.CodeBarDataTable
                For Each aImprir As DataRow In _DT_Product_Legacy.Rows

                    'Dim reg As dsCodeBar.CodeBarRow = dsCodeBar.NewCodeBarRow
                    'reg.Code = aImprir("Number_Purchase")
                    'reg.ID_Code = aImprir("Number_Purchase")
                    'dsCodeBar.Rows.Add(reg)
                    Dim objCodeBarCLS As New clsCodeBarImpr
                    objCodeBarCLS.codeBarValue = aImprir("Number_Purchase")
                    objCodeBarCLS.Print()
                Next
            End If
        Catch ex As Exception
            ' Luis controlar el error
        End Try

        'Dim objCodeBar As New frmViCodeBar
        'objCodeBar.DT_CodeBar = dsCodeBar
        'objCodeBar.ShowDialog()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub cmdDiscount_Click(sender As Object, e As EventArgs) Handles cmdDiscount.Click
        Dim dt As New DataTable
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_Finance_FixedAssetByEmploye(_ID_Company, cbxResponsable.SelectedValue)
        End Using
        If dt.Rows.Count > 0 Then
            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSetFixedAsster", "epd_SatelliteERP.Reporte_InventarioActivos.rdlc")
                objPartidaContable.ShowDialog()
            End Using
        Else
            MessageBox.Show("El empleado seleccionado no cuenta con registro de activos", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_Finance_FixedAssetByEmployeLegacy(_ID_Company, cbxResponsable.SelectedValue)
        End Using
        If dt.Rows.Count > 0 Then
            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSetFixedAsster", "epd_SatelliteERP.Reporte_InventarioActivosLegacy.rdlc")
                objPartidaContable.ShowDialog()
            End Using
        Else
            MessageBox.Show("El empleado seleccionado no cuenta con registro de activos", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub dgvProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellContentClick

    End Sub
#End Region

End Class
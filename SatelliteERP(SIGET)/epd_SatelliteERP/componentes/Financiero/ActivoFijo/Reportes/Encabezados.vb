Imports System.Data
Imports System.Data.OleDb
Public Class Encabezados
    Private _DT_Modulo As New DataTable
    Private objDatos As New Financiero_SQLServer

    Private objSql As New Financiero_SQLServer
    Private _tableFixedAssetsMaster As DataTable
    Private _tableGenericReport As DataTable

    Property idHeader As Long
    Property moduloId As Long
    Property nombre As String
    Property descripcion As String

    Private Sub GetDataGenericReportHeader(ByVal Tipo As String)
        _tableGenericReport = objSql.ERP_RRHH_Getgeneric_Report_DefineField()
        dgv_GenericReports.AutoGenerateColumns = False
        dgv_GenericReports.Columns(0).Width = 75
        dgv_GenericReports.Columns(1).Width = 250
        dgv_GenericReports.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_GenericReports.Columns(2).Width = 350
        dgv_GenericReports.Columns(3).Width = 100
        dgv_GenericReports.Columns(4).Width = 120
        dgv_GenericReports.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_GenericReports.Columns(5).Width = 120
        dgv_GenericReports.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_GenericReports.Columns(5).DefaultCellStyle.Format = "c"
        dgv_GenericReports.Columns(6).Width = 120
        dgv_GenericReports.Columns(7).DataPropertyName = Nothing
        dgv_GenericReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_GenericReports.MultiSelect = False
        dgv_GenericReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_GenericReports.AllowUserToAddRows = False
        dgv_GenericReports.AllowUserToDeleteRows = False

        dgv_GenericReports.DataSource = _tableGenericReport
    End Sub

    Private Sub GetDataGenericReportHeader(ByVal i As Long)
        _tableGenericReport = objSql.ERP_Generic_SP_Get_Generic_Report_DefineField_Update(i)
        dgv_GenericReports.AutoGenerateColumns = False
        dgv_GenericReports.Columns(0).Width = 75
        dgv_GenericReports.Columns(1).Width = 250
        dgv_GenericReports.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_GenericReports.Columns(2).Width = 350
        dgv_GenericReports.Columns(3).Width = 100
        dgv_GenericReports.Columns(4).Width = 120
        dgv_GenericReports.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_GenericReports.Columns(5).Width = 120
        dgv_GenericReports.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_GenericReports.Columns(5).DefaultCellStyle.Format = "c"
        dgv_GenericReports.Columns(6).Width = 120
        dgv_GenericReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_GenericReports.MultiSelect = False
        dgv_GenericReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_GenericReports.AllowUserToAddRows = False
        dgv_GenericReports.AllowUserToDeleteRows = False
        dgv_GenericReports.DataSource = _tableGenericReport
    End Sub

    Private Sub Encabezados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DT_Modulo = objDatos.GetModulo()
        If Not _DT_Modulo Is Nothing Then
            cmb_id_Modulo_FK.DataSource = _DT_Modulo
            cmb_id_Modulo_FK.DisplayMember = "Name"
            cmb_id_Modulo_FK.ValueMember = "id_Module"
            cmb_id_Modulo_FK.SelectedIndex = -1
        End If
        dgv_GenericReports.AutoResizeColumnHeadersHeight()

        If (OpcionSeleccionada = Funcion.Agregar) Then
            GetDataGenericReportHeader("")
        End If
        If (OpcionSeleccionada = Funcion.Actualizar) Then
            cmb_id_Modulo_FK.SelectedValue = _moduloId
            txtName_Header.Text = nombre
            txtDescrip_Header.Text = descripcion
            GetDataGenericReportHeader(idHeader)
        End If
    End Sub
    Property OpcionSeleccionada As Funcion
    Enum Funcion
        Agregar
        Actualizar
    End Enum
    Private objDatos2 As New Generic_SQLServer
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If Not (txtName_Header.Text.Trim = "") Then
            If Not (txtDescrip_Header.Text.Trim = "") Then

                Dim resultado As Integer = 0
                Dim campos As Integer = 0
                Dim resp As Integer = 0

                If OpcionSeleccionada = Funcion.Agregar Then
                    resultado = objDatos2.ERP_RRHH_InsertReportHeaders(txtName_Header.Text, txtDescrip_Header.Text, cmb_id_Modulo_FK.SelectedValue)
                    If resultado > 0 Then
                        If Not dgv_GenericReports.CurrentRow Is Nothing Then
                            For Each dgvr As DataGridViewRow In dgv_GenericReports.Rows
                                If Not dgvr Is Nothing Then
                                    If IsNumeric(dgvr.Cells("Id_Define_Field").Value) Then
                                        If (dgvr.Cells("is_Active").Value) Then
                                            resp = objDatos2.ERP_RRHH_InsertReportDetail(resultado, dgvr.Cells("Id_Define_Field").Value)
                                        End If
                                    End If
                                End If
                            Next
                        End If
                        DialogResult = DialogResult.OK
                        If resp = 1 Then
                            MessageBox.Show("El registro se agregó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            DialogResult = DialogResult.OK
                        Else
                            MessageBox.Show("Ocurrio un error al agregar el detalle", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        Close()
                    ElseIf resultado = -1 Then
                        MessageBox.Show("Ya existe", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Sub
                    Else
                        MessageBox.Show("No se pudo agregar el registro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                ElseIf OpcionSeleccionada = Funcion.Actualizar Then
                    resultado = objDatos2.ERP_RRHH_UpdateReportHeaders(idHeader, txtName_Header.Text, txtDescrip_Header.Text, cmb_id_Modulo_FK.SelectedValue)
                    If resultado = 1 Then
                        If Not dgv_GenericReports.CurrentRow Is Nothing Then
                            For Each dgvr As DataGridViewRow In dgv_GenericReports.Rows
                                If Not dgvr Is Nothing Then
                                    If IsNumeric(dgvr.Cells("Id_Define_Field").Value) Then
                                        Try
                                            If (dgvr.Cells("is_Active").Value) Then
                                                resp = objDatos2.ERP_RRHH_UpdateReportDetail(idHeader, dgvr.Cells("Id_Define_Field").Value, True)
                                            End If
                                        Catch ex As Exception
                                            resp = objDatos2.ERP_RRHH_UpdateReportDetail(idHeader, dgvr.Cells("Id_Define_Field").Value, 0)
                                        End Try
                                    End If
                                End If
                            Next
                            DialogResult = DialogResult.OK
                            If resp = 1 Then
                                MessageBox.Show("El registro se actualizo correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                DialogResult = DialogResult.OK
                            Else
                                MessageBox.Show("Ocurrio un error al agregar el detalle", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            Close()
                        ElseIf resultado = 2 Then
                            MessageBox.Show("Ya existe ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Exit Sub
                        Else
                            MessageBox.Show("No se pudo actualizar el registro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    ElseIf (resultado = 2) Then
                        MessageBox.Show("Nombre del reporte ya existe, cambielo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Ingresa una descripcion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtDescrip_Header.Focus()
                End If
            Else
                MessageBox.Show("Ingresa un nombre de encabezado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtName_Header.Focus()
            End If
        Else
            MessageBox.Show("Selecciona un modulo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmb_id_Modulo_FK.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For Each Row As DataGridViewRow In dgv_GenericReports.Rows
                Row.Cells("is_Active").Value = True
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            For Each Row As DataGridViewRow In dgv_GenericReports.Rows
                Row.Cells("is_Active").Value = False
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
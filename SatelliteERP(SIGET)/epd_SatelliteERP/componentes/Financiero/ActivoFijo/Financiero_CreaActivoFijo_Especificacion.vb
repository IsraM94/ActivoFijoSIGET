Public Class Financiero_CreaActivoFijo_Especificacion
    Private objSqlGeneric As New Generic_SQLServer
    Private _dtActivoFijo_Especificacion As DataTable
    Private _dtActivoFijo_SetEspecificacion As DataTable
    Private _dtActivoFijo_ModEspecificacion As DataTable
    Property TableRegSinGuardar As DataTable
    Private _FixedType As Int64

    Public Property ID_FixedType() As Int64
        Get
            Return _FixedType
        End Get
        Set(ByVal value As Int64)
            _FixedType = value
        End Set
    End Property

    Private _ID_Fixed As String
    Public Property ID_Fixed() As String
        Get
            Return _ID_Fixed
        End Get
        Set(ByVal value As String)
            _ID_Fixed = value
        End Set
    End Property

    Private Sub Financiero_CreaActivoFijo_Especificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtActivoFijo_Especificacion = objSqlGeneric.GetERP_FixedAssets_SP_GetType_Define(_FixedType, _ID_Fixed)
        If _ID_Fixed <> 0 Or (TableRegSinGuardar Is Nothing And _ID_Fixed = 0) Then
            If _ID_Fixed = 0 Then
                TableRegSinGuardar = New DataTable

                TableRegSinGuardar.Columns.Add("ID_FixedAssets_Type_Define", GetType(Integer))
                TableRegSinGuardar.Columns.Add("Etiqueta", GetType(String))
                TableRegSinGuardar.Columns.Add("ID_Type", GetType(Integer))
                TableRegSinGuardar.Columns.Add("Informacion", GetType(String))
            End If
            If _dtActivoFijo_Especificacion.Rows.Count > 0 Then
                For Each reg_def As DataRow In _dtActivoFijo_Especificacion.Rows
                    Dim control As New UC_Especificacion
                    control.Name = reg_def("ID_FixedAssets_Type_Define")
                    control.Etiqueta = reg_def("Campo_Descripcion")
                    control.Informacion = reg_def("Campo_Valor").ToString()
                    control.ID_Type = reg_def("ID_FixedAssets_Type_Define")
                    control.ID_Fixed = IIf(IsDBNull(reg_def("ID_FixedAssets")), -1, reg_def("ID_FixedAssets"))
                    control.ID_Fixed_Details = IIf(IsDBNull(reg_def("ID_FixedAssets_Type_Details")), -1, reg_def("ID_FixedAssets_Type_Details"))

                    flp_Campos.Controls.Add(control)
                Next
            Else
                MessageBox.Show("No hay especificaciones Generales para este Activo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Else
                ' Crear definicion de tabla
                If TableRegSinGuardar Is Nothing Then
                TableRegSinGuardar = New DataTable
                TableRegSinGuardar.Columns.Add("ID_FixedAssets_Type_Define", GetType(Integer))
                TableRegSinGuardar.Columns.Add("Etiqueta", GetType(String))
                TableRegSinGuardar.Columns.Add("ID_Type", GetType(Integer))
                TableRegSinGuardar.Columns.Add("Informacion", GetType(String))
            Else
                For Each row As DataRow In TableRegSinGuardar.Rows
                    Dim control As New UC_Especificacion
                    control.Name = row("ID_FixedAssets_Type_Define")
                    control.ID_Type = row("ID_Type")
                    control.Etiqueta = row("Etiqueta")
                    control.Informacion = row("Informacion").ToString()
                    flp_Campos.Controls.Add(control)
                Next
            End If

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ctrl As Control
        Dim msj As String = String.Empty
        Try
            TableRegSinGuardar.Rows.Clear()
        Catch ex As Exception

        End Try
        For Each ctrl In flp_Campos.Controls
            If (ctrl.GetType() Is GetType(UC_Especificacion)) Then
                Dim tEspecificacion As UC_Especificacion = CType(ctrl, UC_Especificacion)
                If Not _ID_Fixed = 0 Then
                    tEspecificacion.BackColor = Color.LightYellow
                    If tEspecificacion.ID_Fixed_Details = -1 Then
                        _dtActivoFijo_SetEspecificacion = objSqlGeneric.GetERP_FixedAssets_SP_SetType_Define(tEspecificacion.Etiqueta, tEspecificacion.ID_Type, tEspecificacion.Informacion, _FixedType, _ID_Fixed)
                        msj = "Guardados"

                    Else
                        _dtActivoFijo_ModEspecificacion = objSqlGeneric.GetERP_FixedAssets_SP_ModType_Define(tEspecificacion.Etiqueta, tEspecificacion.ID_Type, tEspecificacion.Informacion, _FixedType, _ID_Fixed, tEspecificacion.ID_Fixed_Details)
                        msj = "Modificados"
                    End If
                Else
                    REM  TableRegSinGuardar = New DataTable

                    TableRegSinGuardar.Rows.Add(tEspecificacion.Name, tEspecificacion.Etiqueta, tEspecificacion.ID_Type, tEspecificacion.Informacion)
                End If

            End If
        Next
        MessageBox.Show(String.Format("Registros {0} exitosamente", msj))
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
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
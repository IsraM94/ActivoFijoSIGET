Imports System.IO

Public Class Financiero_Procesos_DepreciacionAgregarAc
    Private DsData As New DataSet
    Dim BanderaDepre As Boolean = True
    Private objSql2 As New Generic_SQLServer

    Private objSql As New Financiero_SQLServer


    Public _DataActivo As DataTable


    Private Sub Financiero_ProcesosDepreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGBuscarActivos.AutoGenerateColumns = False
        DGBuscarActivos.Font = New Font("Segoe UI", 11)
        DGBuscarActivos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGBuscarActivos.ReadOnly = True
        DGBuscarActivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGBuscarActivos.MultiSelect = True
        DGBuscarActivos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGBuscarActivos.AllowUserToAddRows = False
        DGBuscarActivos.AllowUserToDeleteRows = False
        DGBuscarActivos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DGBuscarActivos.DataSource = _DataActivo
    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs)
        Close()
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


    Private Sub btnAgregarActivosA_Click(sender As Object, e As EventArgs) Handles btnAgregarActivosA.Click
        Try
            Dim contador As Integer = 0

            For Each Seleccion As DataGridViewRow In DGBuscarActivos.SelectedRows
                'Añadir los valores obtenidos de la fila seleccionada
                'al segundo datagridview
                _DataActivo.Rows.Add(ObtenerValoresFilaGrid(Seleccion))
                'eliminar la fila del DataGridView origen
                'DataGridView1.Rows.Remove(Seleccion)
            Next
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Function ObtenerValoresFilaGrid(ByVal fila As DataGridViewRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.DGBuscarActivos.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        For Ndx As Integer = 0 To Contenido.Length - 1
            Contenido(Ndx) = fila.Cells(Ndx).Value
        Next
        Return Contenido
    End Function

    Function ObtenerValoresFila(ByVal fila As DataRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.DGBuscarActivos.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        For Ndx As Integer = 0 To Contenido.Length - 1
            Contenido(Ndx) = fila.Item(Ndx).Value
        Next
        Return Contenido
    End Function
End Class
Public Class ERP_CuentasPorPagar_ListaLineasCreditos
    Property DT_LineasCredito As DataTable
    Property RowSeleccion As Integer = -1
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.No
        Close()
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        For i As Integer = 0 To DT_LineasCredito.Rows.Count - 1
            If DT_LineasCredito.Rows(i)("ID_AccountsPayableList") = DGVListaLineaCredito.CurrentRow.Cells(0).Value Then
                RowSeleccion = i
                Exit For
            End If
        Next
        DialogResult = DialogResult.OK

        Close()
    End Sub

    Private Sub ERP_CuentasPorCobrar_ListaLineasCreditos_Load(sender As Object, e As EventArgs) Handles Me.Load

        DGVListaLineaCredito.AutoGenerateColumns = False
        DGVListaLineaCredito.Font = New Font("Segoe UI", 11)
        DGVListaLineaCredito.Columns(0).Width = 100
        DGVListaLineaCredito.Columns(1).Width = 275
        DGVListaLineaCredito.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVListaLineaCredito.Columns(2).Width = 90
        DGVListaLineaCredito.Columns(3).Width = 160
        DGVListaLineaCredito.Columns(4).Width = 220
        DGVListaLineaCredito.Columns(5).Width = 120
        DGVListaLineaCredito.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVListaLineaCredito.Columns(5).DefaultCellStyle.Format = "c"
        DGVListaLineaCredito.Columns(6).Width = 120
        DGVListaLineaCredito.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVListaLineaCredito.Columns(6).DefaultCellStyle.Format = "c"
        DGVListaLineaCredito.ReadOnly = True
        DGVListaLineaCredito.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaLineaCredito.MultiSelect = False
        DGVListaLineaCredito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGVListaLineaCredito.AllowUserToResizeColumns = False
        DGVListaLineaCredito.AllowUserToAddRows = False
        DGVListaLineaCredito.AllowUserToDeleteRows = False
        DGVListaLineaCredito.DataSource = DT_LineasCredito

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
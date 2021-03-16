Public Class ERP_InventorySuggestedShopping

	Private Sub ERP_InventorySuggestedShopping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		fillDGV()
	End Sub
	Public Sub fillDGV()
		Dim dt As New DataTable
        Using ObjSQl As New Operaciones_SQLServer
            dgvSugerido.DataSource = ObjSQl.GetSugeridos
            dgvSugerido.AutoGenerateColumns = False
            dgvSugerido.Font = New Font("Segoe UI", 11)
            dgvSugerido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

            dgvSugerido.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvSugerido.MultiSelect = False
            REM dgvSugerido.AllowUserToResizeColumns = False
            dgvSugerido.AllowUserToAddRows = False
            dgvSugerido.AllowUserToDeleteRows = False
            dgvSugerido.Columns(0).Width = 50
            dgvSugerido.Columns(0).ReadOnly = False
            dgvSugerido.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSugerido.Columns(1).Width = 90
            dgvSugerido.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvSugerido.Columns(1).ReadOnly = True
            dgvSugerido.Columns(2).Width = 250
            dgvSugerido.Columns(2).ReadOnly = True
            dgvSugerido.Columns(3).Width = 265
            dgvSugerido.Columns(3).ReadOnly = True
            dgvSugerido.Columns(4).Width = 250
            dgvSugerido.Columns(4).ReadOnly = True
            dgvSugerido.Columns(5).Width = 90
            dgvSugerido.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvSugerido.Columns(5).DefaultCellStyle.Format = "#,###"
            dgvSugerido.Columns(5).ReadOnly = True
        End Using
    End Sub

	Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARToolStripMenuItem.Click
		If Not dgvSugerido.CurrentRow Is Nothing Then
			Using objChange As New ERP_Inventory_Dialog_SuggestedChange
				objChange.Article = dgvSugerido.CurrentRow.Cells("Name_Product").Value
				objChange.Sugerido = dgvSugerido.CurrentRow.Cells("Sugerido").Value
				If objChange.ShowDialog() = DialogResult.OK Then
					dgvSugerido.CurrentRow.Cells("Sugerido").Value = objChange.Sugerido
				End If
			End Using
		End If
	End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        If Not dgvSugerido.CurrentRow Is Nothing Then
            Using Obj As New ERP_Inventory_ProgressBarSuggested
                Obj.Type = ERP_Inventory_ProgressBarSuggested.Process.Generic ' orden de compra generica
                Obj.data = dgvSugerido
                Obj.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
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
End Class
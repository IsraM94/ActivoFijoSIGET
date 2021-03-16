Imports System.Text.RegularExpressions
Public Class Production_AnimalsToSacrifice

    Private _DT_Animal As New DataTable
    Property ID_Lot As Long = 0
    Private _DT_Production As New DataTable
    Property ID_Etapa As Long = 0
    Property NameLote As String = ""
    Property IS_ProductSelect As Boolean = False
    Property ID_StowageCurrent As Long = 0
    Property IS_Products As Boolean = False
    Property ID_ProductFinal As Long = 0

    Property FinalizarLote As Boolean = True

    Private Sub LoadAnimals()
        Using ObjSQL As New Operaciones_SQLServer
            If IS_ProductSelect Then
                _DT_Animal = ObjSQL.ERP_Prod_SP_Select_AnimalsLotMother(ID_Lot)
            Else
                _DT_Animal = ObjSQL.ERP_Prod_SP_Select_AnimalsLot(ID_Lot)
            End If
        End Using
        If IS_Products Then
            Me.Size = New System.Drawing.Size(815, 304)
            dgvProduction.Visible = False
            cmdprint.Location = New Point(298, 231)
            cmdCancel.Location = New Point(402, 231)
            GroupBox1.Size = New System.Drawing.Size(796, 287)
        End If
        dgvDetails.DataSource = _DT_Animal
        dgvDetails.AutoGenerateColumns = False
    End Sub

    Private Sub LoadData()
        Using ObjSQL As New Operaciones_SQLServer
            _DT_Production = ObjSQL.ERP_Prod_SP_Select_ProcessOutput(ID_Etapa, 1)
        End Using
        dgvProduction.DataSource = _DT_Production
        dgvProduction.AutoGenerateColumns = False
    End Sub

    Private Sub Production_Sacrifice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDetails.AutoGenerateColumns = False
        dgvProduction.AutoGenerateColumns = False
        LoadAnimals()
        LoadData()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If Not dgvDetails.CurrentRow Is Nothing Then
            Dim ID_Animal As Long = dgvDetails.CurrentRow.Cells("id_animal").Value
            Using obj As New Production_SacrificeDetails
                If IS_Products Then
                    obj.IS_Product = 1
                End If
                obj.NameAnimal = dgvDetails.CurrentRow.Cells("NameAnimal").Value
                obj.Checked = dgvDetails.CurrentRow.Cells("Procesar").Value
                obj.PesoAnimal = dgvDetails.CurrentRow.Cells("Peso").Value
                obj.TipoAnimal = dgvDetails.CurrentRow.Cells("CodigoTipo").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    For Each row As DataRow In _DT_Animal.Rows
                        If row("id_animal") = ID_Animal Then
                            row("Peso") = obj.PesoAnimal
                            row("CodigoTipo") = obj.TipoAnimal
                            row("Tipo") = obj.NameTipoAnimal
                            row("Procesar") = obj.Checked
                        End If
                    Next
                    dgvDetails.DataSource = _DT_Animal
                    dgvDetails.AutoGenerateColumns = False
                End If
            End Using
        End If
    End Sub

    Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
        If Not dgvDetails.CurrentRow Is Nothing Then
            Dim ID_Header As Long = 0
            Dim ID_Stowage As Long = ID_StowageCurrent
            Dim respT As Integer = 0
            Dim ID_Product As Long = 0
            Dim Quantity As Double = 0
            Dim IS_Lote As Boolean = True
            Dim Cantidad As Double = 0
            Dim respuesta As Integer = 0
            If Not dgvDetails.CurrentRow Is Nothing Then
                If IS_Products Then

                    For Each row As DataRow In _DT_Animal.Rows
                        Using objSQL As New Operaciones_SQLServer
                            If Not IsNumeric(row("Peso")) Then
                                MessageBox.Show("Por favor ingrese la cantidad generada del producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End If
                        End Using
                    Next row

                    If FinalizarLote Then
                        For Each row As DataRow In _DT_Animal.Rows
                            Using objSQL As New Operaciones_SQLServer
                                respuesta = objSQL.ERP_Production_UpdateProductionBatchCompletion(row("Peso"), row("id_animal"), ID_Lot)
                            End Using
                        Next
                    End If

                    If (respuesta = 1 And FinalizarLote = True) Or (FinalizarLote = False) Then
                        Using objSQL As New Operaciones_SQLServer

                            ID_Header = objSQL.SP_ERP_Inventory_Add_InventoryHeader(_ID_Company, _ID_Customer, ID_Stowage, 0, "N/A", Now.Date, IS_Lote, ID_Lot, vbNull, vbNull, vbNull, vbNull)
                        End Using

                        If ID_Header > 0 Then
                            Using ObjSQL As New Operaciones_SQLServer
                                For Each row As DataRow In _DT_Animal.Rows
                                    If Not row Is Nothing Then
                                        Dim ID_ProductoGenerado = row("id_animal")
                                        Cantidad = row("Peso")
                                        respT = ObjSQL.SP_ERP_Inventory_Add_Inventory(ID_Header, ID_ProductFinal, ID_Stowage, Cantidad, 0, 0, 0, 0, 0)
                                        Cantidad = 0

                                    End If
                                Next row
                            End Using
                        End If
                        If respT = 1 Then
                            MessageBox.Show("Proceso finalizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                            Exit Sub
                        Else
                            MessageBox.Show("Ocurrió un error al realizar el proceso, contacte a Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End If
            If Not dgvProduction.CurrentRow Is Nothing Then


                Dim sacrifice As Boolean = False
                For Each row As DataRow In _DT_Animal.Rows
                    If Not row Is Nothing Then
                        If row("Procesar") Then
                            sacrifice = True
                        End If
                    End If
                Next row

                If Not sacrifice Then
                    MessageBox.Show("Por favor seleccione al menos un animal para sacrificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'validar que todos los productos tengan cantidad
                For Each rowProduction As DataRow In _DT_Production.Rows
                    If Not rowProduction Is Nothing Then
                        If rowProduction("Cantidad") <= 0 Or Not IsNumeric(rowProduction("Cantidad")) Then
                            MessageBox.Show("Ingrese la cantidad de producto para el código: " & rowProduction("Id_Product"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                    End If
                Next rowProduction

                Dim respSacrifice As Integer = 0
                Using objsql As New Operaciones_SQLServer

                    For Each row As DataRow In _DT_Animal.Rows
                        If Not row Is Nothing Then
                            If row("Procesar") Then
                                respSacrifice = objsql.ERP_Production_UpdateSacrificeAnimals(row("Peso"), row("id_animal"), ID_Lot)
                            End If
                        End If
                    Next row
                End Using


                Using objSQL As New Operaciones_SQLServer
                    ID_Header = objSQL.SP_ERP_Inventory_Add_InventoryHeader(_ID_Company, _ID_Customer, ID_Stowage, 0, "N/A", Now.Date, IS_Lote, ID_Lot, vbNull, vbNull, vbNull, vbNull)
                End Using
                '----------------------------------------------------------
                Dim resp As Integer = 0
                If ID_Header > 0 Then
                    Dim ID_Producto As Long = 0
                    For Each rowProduction As DataRow In _DT_Production.Rows
                        If Not rowProduction Is Nothing Then
                            Using ObjSQL As New Operaciones_SQLServer
                                ID_Producto = rowProduction("Id_Product")
                                Cantidad = rowProduction("Cantidad")
                                resp = ObjSQL.SP_ERP_Inventory_Add_Inventory(ID_Header, ID_Producto, ID_Stowage, Cantidad, 0, 0, 0, 0, 0)
                                Cantidad = 0
                            End Using
                        End If
                    Next rowProduction
                End If
                If resp = 1 Then
                    MessageBox.Show("Proceso finalizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Ocurrió un error al realizar el proceso, contacte a Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Not dgvProduction.CurrentRow Is Nothing Then
            Dim ID_Product As Long = dgvProduction.CurrentRow.Cells("Id_Product").Value
            Using obj As New Production_Quantity
                obj.NameProduct = dgvProduction.CurrentRow.Cells("Name_Product").Value
                obj.Quantity = dgvProduction.CurrentRow.Cells("Cantidad").Value
                If obj.ShowDialog() = DialogResult.OK Then
                    For Each row As DataRow In _DT_Production.Rows
                        If row("Id_Product") = ID_Product Then
                            row("Cantidad") = obj.Quantity
                        End If
                    Next row
                End If
            End Using
        End If
    End Sub
    Dim txtEdit As TextBox
    Private Sub dataGridView1_EditingControlShowing(ByVal sender As Object,
         ByVal e As DataGridViewEditingControlShowingEventArgs) _
         Handles dgvProduction.EditingControlShowing
        txtEdit = e.Control
        'remove any existing handler
        RemoveHandler txtEdit.KeyPress, AddressOf txtEdit_Keypress
        AddHandler txtEdit.KeyPress, AddressOf txtEdit_Keypress
    End Sub
    Private Sub txtEdit_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If txtEdit.Text.Contains(".") Then
                    If txtEdit.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgvProduction_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduction.CellLeave

    End Sub

    Private Sub dgvProduction_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduction.CellEndEdit
        Try
            If dgvProduction.CurrentRow.Cells("Cantidad").Value = 0D Or dgvProduction.CurrentRow.Cells("Cantidad").Value.ToString = "" Then
                dgvProduction.CurrentRow.Cells("Cantidad").Value = 0
            End If
        Catch ex As Exception
            dgvProduction.CurrentRow.Cells("Cantidad").Value = 0
        End Try

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
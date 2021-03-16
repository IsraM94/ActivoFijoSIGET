Public Class Production_Procesar
	Private _dt As New DataTable
	Private _Pantalla As Boolean = True
	Private _id_Proceso As Long = 0
	Private _Id_CicloAct As Integer = 0
	Private _Id_CicloRef As Integer = 0
	Property IS_StageAlarm As Boolean = False
	Private Property _id_Lote As Long

	Private _Procesar As Boolean = False
	Public Property Pantalla As Boolean
		Get
			Return _Pantalla
		End Get
		Set(value As Boolean)
			_Pantalla = value
		End Set
	End Property

	Public Property Id_Lote As Long
		Get
			Return _id_Lote
		End Get
		Set(value As Long)
			_id_Lote = value
		End Set
	End Property

	Public Property Id_Proceso As Long
		Get
			Return _id_Proceso
		End Get
		Set(value As Long)
			_id_Proceso = value
		End Set
	End Property

	Public Property CicloAct As Integer
		Get
			Return _Id_CicloAct
		End Get
		Set(value As Integer)
			_Id_CicloAct = value
		End Set
	End Property

	Public Property CicloRef As Integer
		Get
			Return _Id_CicloRef
		End Get
		Set(value As Integer)
			_Id_CicloRef = value
		End Set
	End Property

	Private Sub Production_Procesar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		filldgv()
		dgvDetails.AutoGenerateColumns = False
		dgvDetails.Font = New Font("Segoe UI", 11)
		dgvDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
		dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvDetails.MultiSelect = False
		dgvDetails.AllowUserToResizeColumns = False
		dgvDetails.AllowUserToAddRows = False
		dgvDetails.AllowUserToDeleteRows = False
		dgvDetails.Columns(1).Visible = False
		If IS_StageAlarm Then
			cmdprint.Enabled = False
		Else
			cmdprint.Enabled = True
		End If

	End Sub

	Private Sub filldgv()
		Dim ds As New DataSet
		Using objsql As New Produccion_SQLProcess
			ds = objsql.Production_GetAnimalsEtapa(Id_Proceso, Id_Lote, CicloAct)
		End Using
        If Id_Proceso = 2 Or Id_Proceso = 39 Then
            dgvDetails.ReadOnly = True
            dgvDetails.ContextMenuStrip.Visible = True
        Else
            dgvDetails.ReadOnly = False
			dgvDetails.ContextMenuStrip.Visible = False
			cmsEdit.Enabled = False
			cmsEdit.Visible = False
		End If
		If Not ds Is Nothing Then
			If ds.Tables.Count > 0 Then
				_dt = ds.Tables(0)
				_dt.Columns.Add("ID_Father", Type.GetType("System.Int64"))
				_dt.Columns.Add("Procesar", Type.GetType("System.Int32"))

				dgvDetails.DataSource = _dt
			End If
		End If
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
		If (Pantalla) Then
			Dim ID_Barraco As Long = 0
			If CicloAct <> 4 Then
				For Each row As DataGridViewRow In dgvDetails.Rows
					If row.Cells("Procesado").Value Then
						Using objsql As New Produccion_SQLProcess
							Try
								ID_Barraco = row.Cells("ID_Father").Value
							Catch ex As Exception
								ID_Barraco = 0
							End Try
							objsql.Production_ProcessProducts(row.Cells("ID_Animal").Value, Id_Proceso, Id_Lote, CicloRef, ID_Barraco)
						End Using
					End If
				Next row
				MessageBox.Show("Proceso finalizado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Me.DialogResult = DialogResult.OK
				_Procesar = True
				Me.Close()
			End If
		Else
			If CicloAct = 4 Then
				For Each row As DataGridViewRow In dgvDetails.Rows
					Using obj As New Production_AddPesos
						If row.Cells("Procesado").Value Then
                            obj.IdAnimalP = row.Cells("ID_Animal").Value
                            obj.Id_LoteP = Id_Lote
							obj.NombreMadre = row.Cells("unidadMedida").Value
							If Not obj.ShowDialog() = DialogResult.OK Then
								Exit Sub
							End If

							If (obj.BanderaData) Then
								Using objsql As New Produccion_SQLProcess
									objsql.Production_ProcessProducts(row.Cells("Producto").Value, Id_Proceso, Id_Lote, CicloRef, 0)
								End Using
							End If
						Else
							Exit Sub
						End If

					End Using
				Next
                Me.DialogResult = DialogResult.OK
                _Procesar = True
            End If
		End If
	End Sub

	Private Sub cmdCompletarEtapa_Click(sender As Object, e As EventArgs) Handles cmdCompletarEtapa.Click
		Dim ID_Animal As Long = 0
		Dim ReasonOfExit As String = ""
		Dim Ciclo As Long = 1
		Using objsql As New Produccion_SQLProcess

			ReasonOfExit = "Salida de animal forzada etapa(Inseminación)"
			'Ciclo = 1 ' Temporal
			'         For Each row As DataGridViewRow In dgvDetails.Rows
			'	ID_Animal = row.Cells("ID_Animal").Value
			'	If Not row.Cells("Procesado").Value Then
			'		objsql.ERP_Prod_SP_Insert_ProcessOutputAnimals(Id_Lote, ID_Animal, ReasonOfExit, Ciclo)
			'	End If
			'Next row
			cmdprint_Click(sender, e)
			If _Procesar Then
				objsql.Production_CompletedPhase(Id_Lote, True)
				objsql.ERP_Prod_SP_Update_ProcessActive(Id_Lote)
			End If

		End Using


	End Sub

	Private Sub Seleccionar_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
		If Not dgvDetails.CurrentRow Is Nothing Then
			Dim ID_Animals As Long = dgvDetails.CurrentRow.Cells("ID_Animal").Value
			Using objSelect As New Production_SacrificeDetails
				objSelect.IS_Father = True
				If objSelect.ShowDialog() = DialogResult.OK Then
					For Each row As DataRow In _dt.Rows
						If row("ID_Animal") = ID_Animals Then
							row("ID_Father") = objSelect.TipoAnimal
							row("Procesar") = objSelect.Checked
							dgvDetails.CurrentRow.Cells("Procesado").Value = objSelect.Checked
							dgvDetails.CurrentRow.Cells("ID_Father").Value = objSelect.TipoAnimal
						End If
					Next row
				End If
			End Using
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
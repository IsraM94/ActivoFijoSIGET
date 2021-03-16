Public Class Production_AddPesos

    Private _IdAnimal As Long
    Private _Id_Lotes As Integer
    Private TiposNacimientos As New DataTable("Nacimientos")
    Private PesosAnimales As New DataTable("Pesos")
    Property NombreMadre As String = ""
    Public Property IdAnimalP As Long
        Get
            Return _IdAnimal
        End Get
        Set(value As Long)
            _IdAnimal = value
        End Set
    End Property
    Public Property Id_LoteP As Integer
        Get
            Return _Id_Lotes
        End Get
        Set(value As Integer)
            _Id_Lotes = value
        End Set
    End Property

	Public Property BanderaData As Boolean

    Private Sub Production_AddPesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text &= " (" & NombreMadre & ")"
        PesosAnimales.Columns.Add("Id_Animal")
        PesosAnimales.Columns.Add("Id_Lote")
        PesosAnimales.Columns.Add("Id_TipoNacimiento")
        PesosAnimales.Columns.Add("T Nac")
        PesosAnimales.Columns.Add("Peso")
        dgvPesos.DataSource = PesosAnimales
        dgvPesos.Columns(0).Visible = False
        dgvPesos.Columns(1).Visible = False
        dgvPesos.Columns(2).Visible = False


        dgvPesos.AutoGenerateColumns = False
        dgvPesos.Font = New Font("Segoe UI", 11)
        dgvPesos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvPesos.ReadOnly = True
        dgvPesos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPesos.MultiSelect = False
        dgvPesos.AllowUserToResizeColumns = False
        dgvPesos.AllowUserToAddRows = False
        dgvPesos.AllowUserToDeleteRows = False
        dgvPesos.Columns(3).Width = 150
        dgvPesos.Columns(4).Width = 140
        dgvPesos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        filldgv()


    End Sub

    Private Sub filldgv()
        Dim dtType As New DataTable("Data")
        Dim dtAnimal As New DataTable("DataAnimal")
        Using objsql As New Produccion_SQLProcess

            dtTYpe = objsql.Production_GetTipoNacimiento()
            dtAnimal = objsql.Production_GetPesosAnimales(IdAnimalP, Id_LoteP)
        End Using
        Try
            If Not dtType Is Nothing Then
                If dtType.Rows.Count > 0 Then
                    cbNacimiento.DataSource = dtType
                    cbNacimiento.DisplayMember = "Nacimiento"
                    cbNacimiento.ValueMember = "ID"
                    For Each data As DataRow In dtAnimal.Rows
                        PesosAnimales.Rows.Add(IdAnimalP, Id_LoteP, data("id_typebirth").ToString, data("Nacimiento"), data("weightAnimal").ToString)
                        dgvPesos.DataSource = PesosAnimales
                    Next

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BanderaData = False
        Me.DialogResult=DialogResult.Cancel
        Me.Close()
    End Sub



	Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
		Try
			If (txtTemperatura.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar la temperatura de la Madre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtTemperatura.Focus()
				Exit Sub
			End If

			If (txtTiempoParto.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el tiempo de parto de la Madre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtTiempoParto.Focus()
				Exit Sub
			End If

			Using objsql As New Produccion_SQLProcess
				objsql.Production_UpdateAnimalData(IdAnimalP, Id_LoteP, txtTemperatura.Text.ToString, txtTiempoParto.Text.ToString)
			End Using

			For Each row As DataGridViewRow In dgvPesos.Rows
				Using objsql As New Produccion_SQLProcess
                    objsql.Production_AddPesosAnimales(Long.Parse(row.Cells(0).Value), Long.Parse(row.Cells(1).Value), Integer.Parse(row.Cells(2).Value), Double.Parse(row.Cells(4).Value))
                End Using
			Next row
			BanderaData = True
            MessageBox.Show("Proceso finalizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
		Catch ex As Exception
            MessageBox.Show("El proceso no se ha realizado exitosamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
		End Try

	End Sub

	Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
		dgvPesos.Rows.Remove(dgvPesos.CurrentRow)
	End Sub

	Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
		Using ObjValidate As New Validaciones
			e.Handled = ObjValidate.JustNumbers(sender, e)
		End Using
	End Sub

	Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
		If (txtPeso.Text.ToString <> "") Then
			Try
				If (Convert.ToDouble(txtPeso.Text)) Then
					PesosAnimales.Rows.Add(IdAnimalP, Id_LoteP, cbNacimiento.SelectedItem(0).ToString, cbNacimiento.SelectedItem(1).ToString, txtPeso.Text.ToString)
					dgvPesos.DataSource = PesosAnimales
					txtPeso.Text = ""
				End If
			Catch ex As Exception

			End Try
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
Public Class ShowLog


    Private _Ds_VisorLogTables As DataTable
    Private _Ds_VisorLogColumnas As DataTable
    Private _Ds_VisorLog As DataTable
    Private Tabla As String = ""
    Private Campo As String = ""
    Private Busquedad As String = ""
    Private Registros As Integer = 0
    Private fechainicio As Date
    Private fechafin As Date
    Private Sub ShowLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ObjGeneric As New Generic_SQLServer
            _Ds_VisorLogTables = ObjGeneric.ERP_VisorLogTables()
        End Using
        If (_Ds_VisorLogTables.Rows.Count > 0) Then
            cmbTablesHist.DataSource = _Ds_VisorLogTables
            cmbTablesHist.DisplayMember = "tableHist"
            cmbTablesHist.ValueMember = "idTable"
            cmbTablesHist.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbTablesHist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTablesHist.SelectedIndexChanged
        Try
            If (cmbTablesHist.SelectedIndex > -1) Then

                Using ObjGeneric As New Generic_SQLServer
                    _Ds_VisorLogColumnas = ObjGeneric.ERP_VisorColumn(cmbTablesHist.SelectedItem(0))
                    Dim TableAll As DataTable = _Ds_VisorLogColumnas.Clone()
                    TableAll.Rows.Clear()
                    TableAll.Rows.Add(" ")
                    TableAll.Merge(_Ds_VisorLogColumnas)

                    If (_Ds_VisorLogColumnas.Rows.Count > 0) Then
                        cmbCampos.DataSource = TableAll
                        cmbCampos.DisplayMember = "name"
                        'cmbCampos.ValueMember = "idTable"
                        cmbCampos.SelectedIndex = -1
                        cmbCampos.Update()
                    End If
                End Using
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        fechainicio = dtpinicio.Value
        fechafin = dtpfin.Value


        If (cmbTablesHist.SelectedIndex = -1) Then
            MessageBox.Show("Debe de Seleccionar una tabla para mostrarla informacion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbTablesHist.Focus()
            Exit Sub
        End If

        Tabla = cmbTablesHist.Text

        If txtRegistros.Text = "" Then
            Registros = 1000
        Else
            Registros = txtRegistros.Text
        End If

        If cmbCampos.Text.ToString.Trim  <> "" Then
            Campo = cmbCampos.Text
            If txtBusquedad.Text.ToString = "" Then
                MessageBox.Show("Debe de ingresar un valor para realizar la busquedad", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtBusquedad.Focus()
                Exit Sub
            End If
            Busquedad = txtBusquedad.Text.ToString
            Using ObjGeneric As New Generic_SQLServer
                _Ds_VisorLog = ObjGeneric.ERP_VisorColumnData(Tabla, Campo, Busquedad, Registros, fechainicio, fechafin)
            End Using
        Else
            Using ObjGeneric As New Generic_SQLServer
                _Ds_VisorLog = ObjGeneric.ERP_VisorLog(Tabla, Registros, fechainicio, fechafin)
            End Using
        End If



        Try
            If (_Ds_VisorLog.Rows.Count > 0) Then
                DataGridView1.DataSource = _Ds_VisorLog
                DataGridView1.Update()

                Dim headertext As String = DataGridView1.Columns(3).HeaderText

                Dim distinctDT As DataTable = _Ds_VisorLog.DefaultView.ToTable(True, headertext)

                ' row = DataGridView1.Select()
                Dim COLORrOW As New Color
                For i As Integer = 0 To distinctDT.Rows.Count - 1

                    Try
                        Dim rows As List(Of DataGridViewRow) = (From item In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                                                                Let clave = Convert.ToString(If(item.Cells(headertext).Value, String.Empty))
                                                                Where clave = distinctDT.Rows(i).Item(0)
                                                                Select item).ToList
                        If (i Mod 2 = 0) Then
                            COLORrOW = Color.White
                        Else
                            COLORrOW = Color.LightGray
                        End If

                        For Each row3 As DataGridViewRow In rows
                            row3.DefaultCellStyle.BackColor = COLORrOW
                        Next
                    Catch ex As Exception

                    End Try
                Next
            Else
                MessageBox.Show("No hay registros para mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = Nothing 
            End If
        Catch ex As Exception
            MessageBox.Show("No hay registros para mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtRegistros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegistros.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
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

    Private Sub cmbCampos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCampos.SelectedIndexChanged
        Try
            If (cmbCampos.Text.ToString.Trim = "") Then
                txtBusquedad.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
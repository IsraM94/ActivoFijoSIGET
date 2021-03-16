Public Class Production_EtapaInseminacion
    Private _dt As New DataTable
    Private _DT_Animales As New DataTable
    Private _Id_Process As Integer = 0
    Private _Id_lot As Integer = 0
    Public Property Id_Process As Integer
        Get
            Return _Id_Process
        End Get
        Set(value As Integer)
            _Id_Process = value
        End Set
    End Property

    Public Property Id_lot As Integer
        Get
            Return _Id_lot
        End Get
        Set(value As Integer)
            _Id_lot = value
        End Set
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter, GroupBox2.Enter

    End Sub

    Private Sub Production_EtapaInseminacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCB()
        _DT_Animales.Columns.Add("ID")
        _DT_Animales.Columns.Add("CodigoAnimal")
        _DT_Animales.Columns.Add("NombreAnimal")

        dgvDetails.AutoGenerateColumns = True
        dgvDetails.Font = New Font("Segoe UI", 11)
        dgvDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvDetails.ReadOnly = True
        dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetails.MultiSelect = False
        dgvDetails.AllowUserToResizeColumns = False
        dgvDetails.AllowUserToAddRows = False
        dgvDetails.AllowUserToDeleteRows = False


    End Sub

    Private Sub FillCB()
        Dim ds As New DataSet
        Using objsql As New Produccion_SQLProcess
            ds = objsql.Production_GetListProducts(1, 1)
        End Using
        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 Then
                _dt = ds.Tables(0)
                cbAnimal.DataSource = _dt
                cbAnimal.DisplayMember = "Animal"
                cbAnimal.ValueMember = "ID_Animal"
                cbAnimal.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click, Button1.Click

        Dim id As Long = cbAnimal.SelectedValue
        Dim estado As Boolean = True
        For Each row As DataRow In _dt.Rows
            If Not row Is Nothing Then
                If row("ID_animal") = id Then
                    For Each row2 As DataRow In _DT_Animales.Rows
                        If row2("ID") = id Then
                            estado = False
                        End If
                    Next row2
                    If estado Then
                        _DT_Animales.Rows.Add(row("ID_Animal"), row("CodigoAnimal"), row("NameAnimal"))
                        dgvDetails.DataSource = _DT_Animales
                        estado = True
                    End If
                End If
            End If
        Next row
        dgvDetails.Columns(0).Width = 100
        dgvDetails.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvDetails.Columns(1).Width = 200
        dgvDetails.Columns(2).Width = 200
    End Sub

    Private Sub cmdClean_Click(sender As Object, e As EventArgs) Handles cmdClean.Click, Button5.Click
        _DT_Animales = New DataTable
        _DT_Animales.Columns.Add("ID")
        _DT_Animales.Columns.Add("CodigoAnimal")
        _DT_Animales.Columns.Add("NombreAnimal")
        dgvDetails.DataSource = _DT_Animales
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
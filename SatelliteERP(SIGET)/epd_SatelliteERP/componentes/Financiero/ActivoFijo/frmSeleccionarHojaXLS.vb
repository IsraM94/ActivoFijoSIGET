Public Class frmSeleccionarHojaXLS
    Private _hojaSeleccionada As String
    Public ReadOnly Property HojaSeleccionada() As String
        Get
            Return _hojaSeleccionada
        End Get
    End Property
    Private _filename As String
    Public Property filename() As String
        Get
            Return _filename
        End Get
        Set(ByVal value As String)
            _filename = value
        End Set
    End Property
    Private _infoXLS As DataTable
    Public ReadOnly Property infoXLS() As DataTable
        Get
            Return _infoXLS
        End Get
    End Property
    Private Sub frmSeleccionarHojaXLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim myConnection As New System.Data.OleDb.OleDbConnection((Convert.ToString("Provider=Microsoft.ACE.OLEDB.12.0; " + "data source='") & _filename) + "';" + "Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"" ")
            myConnection.Open()
            Dim mySheets As DataTable = myConnection.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            Dim ds As New DataSet()
            Dim dt As DataTable
            If mySheets.Rows.Count = 1 Then
                _hojaSeleccionada = mySheets.Rows(0)("TABLE_NAME").ToString()
                _infoXLS = InfoFromXLS(_filename, _hojaSeleccionada)
                Me.DialogResult = DialogResult.OK
            End If
            For i As Integer = 0 To mySheets.Rows.Count

                cbxHoja.DataSource = mySheets
                cbxHoja.DisplayMember = "TABLE_NAME"
                cbxHoja.ValueMember = "TABLE_NAME"
                'dt = makeDataTableFromSheetName(_filename, mySheets.Rows(i)("TABLE_NAME").ToString())
                'ds.Tables.Add(dt)
            Next
        Catch ex As Exception
            MessageBox.Show ("El archivo no corresponde","Satellite ERP",MessageBoxButtons.OK, MessageBoxIcon.Error )
            Close 
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        _hojaSeleccionada = cbxHoja.SelectedValue
        _infoXLS = InfoFromXLS(_filename, _hojaSeleccionada)
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Function InfoFromXLS(filename As String, sheetName As String) As DataTable
        Dim myConnection As New System.Data.OleDb.OleDbConnection((Convert.ToString("Provider=Microsoft.ACE.OLEDB.12.0; " + "data source='") & filename) + "';" + "Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"" ")

        Dim dtImport As New DataTable()
        Dim myImportCommand As New System.Data.OleDb.OleDbDataAdapter(Convert.ToString(String.Format("select * from [{0}]", sheetName)), myConnection)
        myImportCommand.Fill(dtImport)
        Return dtImport
    End Function

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
Imports System.Windows.Forms

Public Class ERP_Mantenimiento_DialogSearch

    Enum Process
        Clientes
        Proveedores
    End Enum

#Region "Property"
    Property Search As Process
    Property DGVContainer As DataGridView
    Property DT_Products As New DataTable

#End Region

    Private Sub ERP_Mantenimiento_DialogSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Select()
        Select Case _Search
            Case Process.Clientes
                GBSearch.Text = "Búsqueda de Clientes"
            Case Process.Proveedores
                GBSearch.Text = "Búsqueda de Proveedores"
        End Select
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DGVContainer.DataSource = DT_Products
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim Busqueda As String = txtSearch.Text.Trim
        Using objSql As New Generic_SQLServer
            Select Case _Search
                Case Process.Clientes
                    _DGVContainer.DataSource = objSql.SearchCustomers(_ID_Company, Busqueda, 1)
                Case Process.Proveedores
                    _DGVContainer.DataSource = objSql.SearchCustomers(_ID_Company, Busqueda, 2)
            End Select


        End Using
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

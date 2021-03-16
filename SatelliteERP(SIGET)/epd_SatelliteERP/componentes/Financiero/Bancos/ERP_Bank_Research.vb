Imports System.Windows.Forms

Public Class ERP_Bank_Research
    Property RowSelection As Integer
    Private _DT_ListaBancos As DataTable
    Private objGeneric As New Generic_SQLServer

    Public Event EventDatosDigitados(ByVal StringDigitado As String)

    Enum Process
        Clientes
        Proveedores
    End Enum

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub ERP_Bank_Research_Load(sender As Object, e As EventArgs) Handles Me.Load
        _DT_ListaBancos = objGeneric.Generic_GetBankCatalog(Data_Id_Company)
        DGV_ChooseBank.AutoGenerateColumns = False
        DGV_ChooseBank.Font = New Font("Segoe UI", 11)
        DGV_ChooseBank.Columns(0).Width = 90
        DGV_ChooseBank.Columns(1).Width = 250
        DGV_ChooseBank.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV_ChooseBank.ReadOnly = True
        DGV_ChooseBank.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_ChooseBank.MultiSelect = False
        DGV_ChooseBank.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGV_ChooseBank.AllowUserToResizeColumns = False
        DGV_ChooseBank.AllowUserToAddRows = False
        DGV_ChooseBank.AllowUserToDeleteRows = False
        DGV_ChooseBank.DataSource = _DT_ListaBancos
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        For i As Integer = 0 To _DT_ListaBancos.Rows.Count - 1
            If _DT_ListaBancos.Rows(i)("ID_BankCatalog") = DGV_ChooseBank.CurrentRow.Cells(0).Value Then
                RowSelection = _DT_ListaBancos.Rows(i)("ID_BankCatalog")
                Exit For
            End If
        Next
        Me.DialogResult = DialogResult.OK
        Me.Close()
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

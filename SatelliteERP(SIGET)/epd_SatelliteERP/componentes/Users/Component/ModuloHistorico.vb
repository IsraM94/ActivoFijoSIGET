Public Class ModuloHistorico
    Private objUsersDB As New Generic_SQLServer
    Private AccessUserNameDT As DataTable
    Private dtDeparment As DataTable
    Private dtCollectingAgency As DataTable
    Private dtMunicipality As DataTable
    Private dtCountry As DataTable
    Private dtUnitMeasure As DataTable
    Private objGeneric As New Generic_SQLServer

    Private _DT_Employee As DataTable
    Private Sub getHistorico()
        Try
            _DT_Employee = objGeneric.GetERP_getHistorico()
            If _DT_Employee IsNot Nothing Then
                DG_SystemUsers.AutoGenerateColumns = False
                DG_SystemUsers.Font = New Font("Segoe UI", 11)
                DG_SystemUsers.ReadOnly = True
                DG_SystemUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DG_SystemUsers.MultiSelect = False
                DG_SystemUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                DG_SystemUsers.AllowUserToResizeColumns = False
                DG_SystemUsers.AllowUserToAddRows = False
                DG_SystemUsers.AllowUserToDeleteRows = False
                'dgvemployee.DataSource = _tableInvoiceHeader

                DG_SystemUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                DG_SystemUsers.DataSource = _DT_Employee
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema mientras se procesaba la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ModuloUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        getHistorico()
    End Sub

    Private Sub cmdCreate_CategoryMaintenance_Click(sender As Object, e As EventArgs) Handles cmdAccessUsers.Click
        getHistorico()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdModifyUsers.Click
        Using obj As New Config_InsertUserAccesos
            'obj.GroupBox1.Text = "Configuración Modificar Usuarios"
            obj._isInsert = False
            obj._id_username = DG_SystemUsers.CurrentRow.Cells("ID_UserName").Value
            obj._username = DG_SystemUsers.CurrentRow.Cells("UserName").Value
            If obj.ShowDialog() = DialogResult.OK Then
                getHistorico()
            End If

        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdCreateAccessUsers.Click
        Using obj As New Config_InsertUserAccesos
            If obj.ShowDialog() = DialogResult.OK Then
                getHistorico()
            End If
        End Using
    End Sub


    Private Sub DeleteUsers_Click(sender As Object, e As EventArgs) Handles DeleteUsers.Click
        Dim mensaje As String = "¿Está seguro(a) que quiere eliminar el siguiente usuario: " & vbCrLf &
                "Nombre : " & DG_SystemUsers.CurrentRow.Cells(1).Value & vbCrLf & "?"

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objUsersDB.ERP_Config_DeleteAccessUserName(DG_SystemUsers.CurrentRow.Cells(0).Value) = "OK" Then
                'GetAccessUserName()
            Else
                MessageBox.Show("Error en eliminación de usuario.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub DeactiveUsers_Click(sender As Object, e As EventArgs) Handles DeactiveUsers.Click

        Dim mensaje As String = "¿Está seguro(a) que quiere desactivar el siguiente usuario: " & vbCrLf &
        "Nombre : " & DG_SystemUsers.CurrentRow.Cells(1).Value & vbCrLf & "?"

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objUsersDB.ERP_Config_DeactivateAccessUserName(DG_SystemUsers.CurrentRow.Cells(0).Value) = "OK" Then
                'GetAccessUserName()
            Else
                MessageBox.Show("Error en desactivación de usuario.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class

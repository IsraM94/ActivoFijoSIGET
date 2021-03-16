Public Class ERP_Inventory_Dialog_TypesRequisition

    Private objDatos As New Requisiciones_SQLServer
    Property id_TypeRequisition As Long = 0
    Property TypeRequisition As String
    REM Property Title As String

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSaveTipoRequisicion.Click

        If txtTypeRequisition.Text = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTypeRequisition.Focus()
            Exit Sub
        End If
        If id_TypeRequisition > 0 Then ' Es modificacion

            Dim resp As String = objDatos.SP_Inventory_UpdateRequisitionType(id_TypeRequisition, txtTypeRequisition.Text)

            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()

            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
        Else
            Dim resp As String = objDatos.SP_Inventory_InsertRequisitionTypes(txtTypeRequisition.Text)

            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        End If

    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub

    Private Sub ERP_Inventory_Dialog_TypesRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If id_TypeRequisition > 0 Then

            GroupTiposRequisciones.Text = "Modificar Tipo de requisición"
            txtTypeRequisition.Text = TypeRequisition
            REM GroupTiposRequisciones.Text = Title
        End If
    End Sub

    Private Sub GroupTiposRequisciones_Enter(sender As Object, e As EventArgs) Handles GroupTiposRequisciones.Enter

    End Sub
End Class
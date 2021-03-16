Public Class Configurar_Monto_Adquisicion
    Private objSqlGeneric As New Generic_SQLServer
    Private objSql As New Financiero_SQLServer
    Property _descripcion As String
    Property _cantidad As Long = 0

    Private Sub Configurar_Monto_Adquisicion_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _cantidad <> 0 Then
            txtMonto.Text = _cantidad
            txtDescripcionMonto.Text = _descripcion



        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If (txtMonto.Text.Trim = "") Then
            MessageBox.Show("Ingrese un monto", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If Not IsNumeric(txtMonto.Text.Trim) Then
            MessageBox.Show("Ingrese un valor númerico en el monto", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If (txtDescripcionMonto.Text.Trim = "") Then
            MessageBox.Show("Ingrese una descripción", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim resp As String = objSql.SetMontoAquisicionUpdate(txtMonto.Text, txtDescripcionMonto.Text)
        If resp = "OK" Then
            DialogResult = DialogResult.OK
            MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Else
            If resp.Split("|")(0) = "ER" Then
                MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Else
                '    MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If




    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub


End Class
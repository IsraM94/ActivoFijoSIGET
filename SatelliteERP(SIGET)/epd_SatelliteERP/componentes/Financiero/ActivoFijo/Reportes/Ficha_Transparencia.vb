Public Class Ficha_Transparencia
    Public Property id_tipo As Long = 0
    Public Property Monto As Double = 0
    Private Sub cmdEnviar_Click(sender As Object, e As EventArgs) Handles cmdEnviar.Click
        If cmb_TipoActivo.SelectedIndex = -1 Then
            MessageBox.Show("Selecione el tipo de activo", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If (txtMontoAdquisicion.Text.Trim = "") Then
            MessageBox.Show("Ingrese un monto", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        If Not IsNumeric(txtMontoAdquisicion.Text.Trim) Then
            MessageBox.Show("Ingrese un valor númerico en el monto", "información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        id_tipo = cmb_TipoActivo.SelectedValue
        Monto = txtMontoAdquisicion.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LOadData()
        Dim dt As New DataTable
        Using obj As New Generic_SQLServer
            dt = obj.ERP_FixedAssets_SP_GetType(_ID_Company)
        End Using
        cmb_TipoActivo.DataSource = dt
        cmb_TipoActivo.ValueMember = "Id_FixedAssetsType"
        cmb_TipoActivo.DisplayMember = "Name_FixedAssetsType"
        cmb_TipoActivo.SelectedIndex = -1
    End Sub

    Private Sub Ficha_Transparencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOadData()
    End Sub
End Class
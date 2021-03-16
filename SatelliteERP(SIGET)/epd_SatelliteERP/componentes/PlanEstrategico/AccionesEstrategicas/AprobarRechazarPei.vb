Public Class AprobarRechazarPei

#Region "Properties"
    Private objsql As New POA_SQLServer

    Property IdPEI As Integer = 0
    Property Anio As String = ""
    Property Gerencia As String = ""
    Property Id_DepartamentoPOA As Integer = 0
    Property Autorizacion As Boolean = False
    Property TipoAutorizacion As Boolean = False

    Private NombreArchivo As String = ""
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region


    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Dim resp As String = ""
        If txtObservacion.Text.ToString.Trim = "" Then
            MessageBox.Show("Debe ingresar el motivo del rechazo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObservacion.Focus()
            Exit Sub
        End If

        If Autorizacion Then
            If MessageBox.Show("¿Esta seguro de enviar a Aprobación el PEI para el Quinquenio: " & Anio.ToString & " para " & Gerencia.ToString & " ?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                resp = objsql.ERP_StrategicPlan_ProcessAproRechaPEI(Id_DepartamentoPOA, IdPEI, txtObservacion.Text.ToString, 2)

                If resp = "OK" Then
                    MessageBox.Show("Información Procesada Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Error al procesar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DialogResult = System.Windows.Forms.DialogResult.No
                    Me.Close()
                End If
            End If
            Exit Sub
        End If

        If MessageBox.Show("Esta seguro de APROBAR el PEI " & Anio.ToString & " para: " & Gerencia, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            If TipoAutorizacion Then
                resp = objsql.ERP_StrategicPlan_ProcessAproRechaPEI(Id_DepartamentoPOA, IdPEI, txtObservacion.Text.ToString, 6)
            Else
                resp = objsql.ERP_StrategicPlan_ProcessAproRechaPEI(Id_DepartamentoPOA, IdPEI, txtObservacion.Text.ToString, 3)
            End If

            If resp = "OK" Then
                MessageBox.Show("Información Procesada Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Error al procesar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                DialogResult = System.Windows.Forms.DialogResult.No
                Me.Close()
            End If

        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click

        If txtObservacion.Text.ToString.Trim = "" Then
            MessageBox.Show("Debe ingresar el motivo del rechazo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObservacion.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Esta seguro de RECHAZAR el PEI - " & Anio.ToString & " para: " & Gerencia, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim resp As String
            If TipoAutorizacion Then
                resp = objsql.ERP_StrategicPlan_ProcessAproRechaPEI(Id_DepartamentoPOA, IdPEI, txtObservacion.Text.ToString, 7)
            Else
                resp = objsql.ERP_StrategicPlan_ProcessAproRechaPEI(Id_DepartamentoPOA, IdPEI, txtObservacion.Text.ToString, 4)
            End If
            If resp = "OK" Then
                MessageBox.Show("Información Procesada Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Error al procesar la información", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                DialogResult = System.Windows.Forms.DialogResult.No
                Me.Close()
            End If

        End If
    End Sub

    Private Sub AprobarRechazarPei_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Autorizacion Then
            btnRechazar.Visible = False
            btnAprobar.Text = "Enviar Aprobación"
            GroupBox1.Text = "Envió de PEI a Autorización"
        End If
    End Sub
End Class
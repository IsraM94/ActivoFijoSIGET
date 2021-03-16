Public Class POA_InsertUnidadLider

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private _Inactivas As Boolean = False
    Private dtGerencia As DataTable
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _name As String = ""
    Property _id_unitfree As Long
    Property _Gerencia As String = ""

    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _isInsert = False Then
            btnGrabar.Text = "Editar"
        End If

        dtGerencia = objsql.ERP_StrategicPlan_GetManagement()
        comboListGerencia.DataSource = dtGerencia
        comboListGerencia.DisplayMember = "Name"
        comboListGerencia.ValueMember = "ID_Deparment"

        txt_POA_AddUnidadLider.Focus()
        txt_POA_AddUnidadLider.Text = _name
        comboListGerencia.Text = _Gerencia
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddUnidadLider.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddUnidadLider.Focus()
            Exit Sub
        End If
        If txtSiglas.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSiglas.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_Insertfreeunit(txt_POA_AddUnidadLider.Text, txtSiglas.Text.ToString.Trim, comboListGerencia.SelectedValue)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_Updatefreeunit(_id_unitfree, txt_POA_AddUnidadLider.Text, txtSiglas.Text.ToString.Trim, comboListGerencia.SelectedValue)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
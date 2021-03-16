Public Class POA_InsertGerencia

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtManagement As New DataTable
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _id_Management As Long
    Property _servicio As String = ""
    Property _Padre As Boolean = 0
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

        dtManagement = objsql.ERP_StrategicPlan_GetManagementPadre
        Dim dataSelect As DataTable = dtManagement.Clone
        dataSelect.Rows.Add(0, "Seleccione")


        For Each Info As DataRow In dtManagement.Rows
            dataSelect.ImportRow(Info)
        Next

        comboListPadre.DataSource = dataSelect
        comboListPadre.DisplayMember = "Name"
        comboListPadre.ValueMember = "Id_Deparment"

        txt_POA_AddGerencia.Focus()
        txt_POA_AddGerencia.Text = _name.ToString
        txt_POA_Siglas.Text = _description.ToString
        comboListPadre.Text = _servicio.ToString

        chkPadre.Checked = _Padre
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddGerencia.Text = "" Or txt_POA_Siglas.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddGerencia.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InsertManagement(txt_POA_AddGerencia.Text, txt_POA_Siglas.Text, comboListPadre.SelectedValue, chkPadre.Checked)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateManagement(_id_Management, txt_POA_AddGerencia.Text, txt_POA_Siglas.Text, comboListPadre.SelectedValue, chkPadre.Checked)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
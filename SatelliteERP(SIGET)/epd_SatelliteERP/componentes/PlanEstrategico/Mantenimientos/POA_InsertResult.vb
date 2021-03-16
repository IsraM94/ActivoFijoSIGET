Public Class POA_InsertResult

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _dtEjes As DataTable
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True

    Property _VerResultado As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _id_result As Long
    Property _ejesestrategicos As String = ""

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

        _dtEjes = objsql.ERP_StrategicPlan_GetStrategicAxes(1, 0)
        comboListEjesExtrategicos.DataSource = _dtEjes
        comboListEjesExtrategicos.DisplayMember = "Name"
        comboListEjesExtrategicos.ValueMember = "ID_StrategicAxes"

        txt_POA_AddResult.Focus()
        txt_POA_AddResult.Text = _name
        comboListEjesExtrategicos.Text = _ejesestrategicos

        If Not _VerResultado Then
            txt_POA_AddResult.Enabled = False
            btnGrabar.Visible = False
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddResult.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddResult.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InsertResult(txt_POA_AddResult.Text, "", comboListEjesExtrategicos.SelectedValue)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateResult(_id_result, txt_POA_AddResult.Text, "", comboListEjesExtrategicos.SelectedValue)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
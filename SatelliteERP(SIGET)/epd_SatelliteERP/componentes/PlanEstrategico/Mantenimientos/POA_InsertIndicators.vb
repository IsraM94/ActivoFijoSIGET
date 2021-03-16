Public Class POA_InsertIndicators

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _dtEjes As DataTable
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _VerIndicador As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _id_Indicador As Long
    Property _Result As String = ""

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

        _dtEjes = objsql.ERP_StrategicPlan_GetResult(1, 0)
        comboListResultados.DataSource = _dtEjes
        comboListResultados.DisplayMember = "Name"
        comboListResultados.ValueMember = "ID_Result"

        txt_POA_AddIndicador.Focus()
        txt_POA_AddIndicador.Text = _name
        txt_POA_DescripcionIndicador.Text = _description
        comboListResultados.Text = _Result

        If Not _VerIndicador Then
            txt_POA_AddIndicador.Enabled = False
            btnGrabar.Visible = False
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddIndicador.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddIndicador.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_Insertindicators(comboListResultados.SelectedValue, txt_POA_AddIndicador.Text, txt_POA_DescripcionIndicador.Text)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_Updateindicators(_id_Indicador, comboListResultados.SelectedValue, txt_POA_AddIndicador.Text, txt_POA_DescripcionIndicador.Text)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
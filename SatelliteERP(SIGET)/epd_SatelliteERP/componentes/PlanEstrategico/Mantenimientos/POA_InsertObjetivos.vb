Public Class POA_InsertObjetivos

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _id_Objective As Long
    Property _View As Boolean = False
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
        If _View Then
            txt_POA_AddObjetivo.Enabled = False
            txt_POA_AddDescripcion.Enabled = False
            btnGrabar.Visible = False
        End If
        txt_POA_AddObjetivo.Focus()
        txt_POA_AddObjetivo.Text = _name
        txt_POA_AddDescripcion.Text = _description
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddObjetivo.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddObjetivo.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_Insertobjective(txt_POA_AddObjetivo.Text, txt_POA_AddDescripcion.Text)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateObjective(_id_Objective, txt_POA_AddObjetivo.Text, txt_POA_AddDescripcion.Text)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
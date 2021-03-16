Public Class POA_InsertFilosofiaInstitucional

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtCollectingServices As DataTable
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _id_Philosophy As Long
    Property _mision As String = ""
    Property _vision As String = ""
    Property _valores As String = ""
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

        txt_POA_AddMision.Focus()
        txt_POA_AddMision.Text = _mision
        txt_POA_AddVision.Text = _vision
        txt_POA_Valores.Text = _valores

        If _View Then
            txt_POA_AddMision.ReadOnly = True
            txt_POA_AddVision.ReadOnly = True
            txt_POA_Valores.ReadOnly = True
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddMision.Text = "" Or txt_POA_AddVision.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddMision.Focus()

            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InsertInstitutionalPhilosophy(txt_POA_AddVision.Text, txt_POA_AddMision.Text, txt_POA_Valores.Text)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateInstitutionalPhilosophy(_id_Philosophy, txt_POA_AddVision.Text, txt_POA_AddMision.Text, txt_POA_Valores.Text)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
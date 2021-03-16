Public Class POA_InsertProbabilidad

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _Probabilidad As Integer
    Property _Descripcion As String = ""
    Property _id_Probabilidad As Long

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

        txt_POA_AddProbabilidad.Focus()
        txt_POA_AddProbabilidad.Text = _Probabilidad
        txt_POA_DescripcionProbabilidad.Text = _Descripcion
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddProbabilidad.Text = "" Or txt_POA_DescripcionProbabilidad.Text = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddProbabilidad.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InsertProbabilityOccurrence(txt_POA_AddProbabilidad.Text, txt_POA_DescripcionProbabilidad.Text)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateProbabilityOccurrence(_id_Probabilidad, txt_POA_AddProbabilidad.Text, txt_POA_DescripcionProbabilidad.Text)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub txt_POA_AddProbabilidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_POA_AddProbabilidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
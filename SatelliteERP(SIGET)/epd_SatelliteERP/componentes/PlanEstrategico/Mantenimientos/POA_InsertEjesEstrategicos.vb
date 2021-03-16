Public Class POA_InsertEjesEstrategicos

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _VerEje As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _id_strategicAxes As Long
    Property _CodigoEje As String = ""
    Property _IdUnidadLider As Integer = 0
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

        Try
            Using objDatos As New POA_SQLServer
                Dim dtGerencia As New DataTable
                dtGerencia = objDatos.ERP_StrategicPlan_GetUnitLider(0)
                CB_UnidadLider.DataSource = dtGerencia
                CB_UnidadLider.DisplayMember = "Name"
                CB_UnidadLider.ValueMember = "Id_FreeUnit"
            End Using
        Catch ex As Exception
            Dim aaa As String = ""
            End Try


        txtCodigo.Enabled = False
        txtCodigo.Text = _CodigoEje
        txt_POA_AddEjeEstrategico.Focus()
        txt_POA_AddEjeEstrategico.Text = _name
        CB_UnidadLider.SelectedValue = _IdUnidadLider
        If Not _VerEje Then
            txt_POA_AddEjeEstrategico.Enabled = False
            btnGrabar.Visible = False
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddEjeEstrategico.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddEjeEstrategico.Focus()
            Exit Sub
        End If

        If CB_UnidadLider.SelectedValue <= 0 Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CB_UnidadLider.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InsertStrategicAxes(txt_POA_AddEjeEstrategico.Text, "", CB_UnidadLider.SelectedValue)
            txtCodigo.Text = dt
            txt_POA_AddEjeEstrategico.Text = ""
        Else
            Dim dt As String
            Dim Tipo As Integer = 0

            If rbEstrategico.Checked Then
                Tipo = 1
            End If
            If rbApoyo.Checked Then
                Tipo = 2
            End If
            dt = objsql.ERP_StrategicPlan_UpdateStrategicAxes(_id_strategicAxes, txt_POA_AddEjeEstrategico.Text, "", CB_UnidadLider.SelectedValue)

            DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
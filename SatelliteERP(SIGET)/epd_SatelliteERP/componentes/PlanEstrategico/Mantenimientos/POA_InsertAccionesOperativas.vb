Public Class POA_InsertAccionesOperativas

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtCollectingServices As DataTable
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _id_OperationalAction As Long
    Property _acciontrategica As String
    Property _fecha As String = ""
    Property _Indicador As String = ""
    Property _Vista As Boolean = False
    Property _AnioAc As Integer
    Property _Id_UnidadLider As Integer

    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using objDatos As New POA_SQLServer
            Try
                Dim dtTipoMedicion As DataTable = objDatos.ERP_StrategicPlan_MeasureType()
                CB_TipoMedicion.DataSource = dtTipoMedicion
                CB_TipoMedicion.DisplayMember = "NameMeasure"
                CB_TipoMedicion.ValueMember = "Id_MeasureType"
            Catch ex As Exception
                Dim aaa As String = ""
            End Try


            Try
                Dim dtUnidad As New DataTable
                dtUnidad = objDatos.ERP_StrategicPlan_GetUnitLider(0)
                CB_UnidadLider.DataSource = dtUnidad
                CB_UnidadLider.DisplayMember = "Name"
                CB_UnidadLider.ValueMember = "Id_FreeUnit"
            Catch ex As Exception
                Dim aaa As String = ""
                End Try
            End Using

        If _isInsert = False Then
            btnGrabar.Text = "Editar"
        End If

        dtCollectingServices = objsql.ERP_StrategicPlan_GetStrategicActions(1, 0)
        comboListAccionesEstrategicas.DataSource = dtCollectingServices
        comboListAccionesEstrategicas.DisplayMember = "Name"
        comboListAccionesEstrategicas.ValueMember = "ID_StrategicActions"


        txt_POA_AddAccionesOperativas.Focus()
        txt_POA_AddAccionesOperativas.Text = _name
        comboListAccionesEstrategicas.Text = _acciontrategica
        CB_UnidadLider.SelectedValue = _Id_UnidadLider
        Try
            If _acciontrategica = "" Or _acciontrategica = Nothing Then
                comboListAccionesEstrategicas.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
        txtAnio.Text = _AnioAc

        If _Vista Then
            txt_POA_AddAccionesOperativas.Enabled = False
            comboListAccionesEstrategicas.Enabled = False
            CB_TipoMedicion.Enabled = False
            CB_UnidadLider.Enabled = False
            txtAnio.Enabled = False
            btnGrabar.Visible = False
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddAccionesOperativas.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AddAccionesOperativas.Focus()
            Exit Sub
        End If

        If txtDescripcion.Text.ToString.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Exit Sub
        End If


        Try
            If comboListAccionesEstrategicas.SelectedValue <= 0 Then
                MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                comboListAccionesEstrategicas.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        If IsNumeric(txtAnio.Text) Then
            If txtAnio.Text.Length < 4 Or txtAnio.Text.Length > 4 Then
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnio.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAnio.Focus()
            Exit Sub
        End If
        Dim Bandera As Boolean = False
        For i As Integer = Date.Now.Year - 25 To Date.Now.Year + 10
            If txtAnio.Text.ToString.Trim = i.ToString Then
                Bandera = True
                Exit For
            End If
        Next
        If Not Bandera Then
            MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAnio.Focus()
            Exit Sub
        End If
        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InsertOperationalAction(comboListAccionesEstrategicas.SelectedValue, txt_POA_AddAccionesOperativas.Text, txtDescripcion.Text.ToString.Trim, CB_TipoMedicion.SelectedValue, Date.Now, "", CB_UnidadLider.SelectedValue, txtAnio.Text.ToString)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateOperationalAction(_id_OperationalAction, comboListAccionesEstrategicas.SelectedValue, txt_POA_AddAccionesOperativas.Text, txtDescripcion.Text.ToString.Trim, CB_TipoMedicion.SelectedValue, Date.Now, "", CB_UnidadLider.SelectedValue, txtAnio.Text.ToString)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
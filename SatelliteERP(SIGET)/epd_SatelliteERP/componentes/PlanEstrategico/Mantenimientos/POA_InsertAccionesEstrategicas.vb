Public Class POA_InsertAccionesEstrategicas

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtCollectingServices As DataTable
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True

    Property _VerAccion As Boolean = True
    Property _name As String = ""
    Property _description As String = ""
    Property _id_StrategicActions As Long
    Property _result As String
    Property _UnidadLider As String = ""
    Property _TipoMedicion As String = ""
    Property _Fecha As String = ""
    Property _Indicador As String = ""

    Property _AnioInicial As Decimal = 0

    Property _Anio1 As Decimal = 0
    Property _Anio2 As Decimal = 0
    Property _Anio3 As Decimal = 0
    Property _Anio4 As Decimal = 0
    Property _Anio5 As Decimal = 0

    Property _Quinquenio As Integer = 0


    Property _AccionApoyo As Boolean = False

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

        Using objDatos As New POA_SQLServer
            Try
                Dim dtGerencia As New DataTable
                dtGerencia = objDatos.ERP_StrategicPlan_GetUnitLider(0)
                CB_UnidadLider.DataSource = dtGerencia
                CB_UnidadLider.DisplayMember = "Name"
                CB_UnidadLider.ValueMember = "Id_FreeUnit"
            Catch ex As Exception
                Dim aaa As String = ""
            End Try

            Try
                Dim dtAxes As DataTable = objDatos.ERP_StrategicPlan_GetStrategicAxes(1, 0)
                cbEjes.DataSource = dtAxes
                cbEjes.DisplayMember = "Name"
                cbEjes.ValueMember = "Id_StrategicAxes"
                cbEjes.SelectedIndex = 0
                cbEjes_SelectedIndexChanged(Nothing, Nothing)
            Catch ex As Exception
                Dim aaa As String = ""
            End Try
        End Using

        txt_POA_AddEjeEstrategico.Focus()
        txt_POA_AddEjeEstrategico.Text = _name
        comboListResultados.Text = _result
        CB_UnidadLider.Text = _UnidadLider
        txtQuinquenio.Text = _Quinquenio
        txtDescripcion.Text = _description

        Try
            chkAccionApoyo.Checked = _AccionApoyo
        Catch ex As Exception

        End Try
        txtAnio1.Text = _Anio1
        txtAnio2.Text = _Anio2
        txtAnio3.Text = _Anio3
        txtAnio4.Text = _Anio4
        txtAnio5.Text = _Anio5
        If Not _VerAccion Then
            txt_POA_AddEjeEstrategico.Enabled = False
            txtDescripcion.Enabled = False
            btnGrabar.Visible = False
        End If

        txtQuinquenio.Text = _AnioInicial
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AddEjeEstrategico.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_POA_AddEjeEstrategico.Focus()
            Exit Sub
        End If

        If txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescripcion.Focus()
            Exit Sub
        End If

        If comboListResultados.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar un Resultado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            comboListResultados.Focus()
            Exit Sub
        End If

        If CB_UnidadLider.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar una Unidad Lider.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            CB_UnidadLider.Focus()
            Exit Sub
        End If

        If txtQuinquenio.Text.ToString.Trim = "" Then
            MessageBox.Show("Debe ingresar el Quinquenio.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuinquenio.Focus()
            Exit Sub
        End If

        If IsNumeric(txtQuinquenio.Text) Then
            If txtQuinquenio.Text.Length < 4 Or txtQuinquenio.Text.Length > 4 Then
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQuinquenio.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuinquenio.Focus()
            Exit Sub
        End If
        Dim Bandera As Boolean = False
        For i As Integer = Date.Now.Year - 25 To Date.Now.Year + 10
            If txtQuinquenio.Text.ToString.Trim = i.ToString Then
                Bandera = True
                Exit For
            End If
        Next

        If Not Bandera Then
            MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuinquenio.Focus()
            Exit Sub
        End If

        If txtAnio1.Text.ToString.Trim = "" Then
            txtAnio1.Text = "0"
        End If

        If txtAnio2.Text.ToString.Trim = "" Then
            txtAnio2.Text = "0"
        End If

        If txtAnio3.Text.ToString.Trim = "" Then
            txtAnio3.Text = "0"
        End If

        If txtAnio4.Text.ToString.Trim = "" Then
            txtAnio4.Text = "0"
        End If

        If txtAnio5.Text.ToString.Trim = "" Then
            txtAnio5.Text = "0"
        End If


        If (Convert.ToDecimal(txtAnio1.Text.ToString) + Convert.ToDecimal(txtAnio2.Text.ToString) + Convert.ToDecimal(txtAnio3.Text.ToString) + Convert.ToDecimal(txtAnio4.Text.ToString) + Convert.ToDecimal(txtAnio5.Text.ToString)) <> 100 Then
            MessageBox.Show("La suma de los años es diferente al 100%, favor revisar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InserStrategicActions(txt_POA_AddEjeEstrategico.Text.ToString.Trim, txtDescripcion.Text.ToString, comboListResultados.SelectedValue, CB_UnidadLider.SelectedValue, 1, Date.Now, "", txtAnio1.Text.ToString, txtAnio2.Text.ToString, txtAnio3.Text.ToString, txtAnio4.Text.ToString, txtAnio5.Text.ToString, txtQuinquenio.Text.ToString, chkAccionApoyo.Checked)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateStrategicActions(_id_StrategicActions, comboListResultados.SelectedValue, txt_POA_AddEjeEstrategico.Text.ToString.Trim, txtDescripcion.Text.ToString, CB_UnidadLider.SelectedValue, 1, Date.Now, "", txtAnio1.Text.ToString, txtAnio2.Text.ToString, txtAnio3.Text.ToString, txtAnio4.Text.ToString, txtAnio5.Text.ToString, txtQuinquenio.Text.ToString, chkAccionApoyo.Checked)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cbEjes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEjes.SelectedIndexChanged
        Try

            If cbEjes.SelectedIndex >= 0 Then
                dtCollectingServices = objsql.ERP_StrategicPlan_GetResultAxes(1, cbEjes.SelectedValue)
                comboListResultados.DataSource = dtCollectingServices
                comboListResultados.DisplayMember = "Name"
                comboListResultados.ValueMember = "ID_Result"
                comboListResultados.SelectedIndex = 0

                Dim dsEncargado As Integer = objsql.ERP_StrategicPlan_GetLiderAxes(cbEjes.SelectedValue)
                CB_UnidadLider.SelectedValue = dsEncargado
            Else
                comboListResultados.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAnio1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio1.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnio2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio2.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnio3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio3.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnio4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio4.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnio5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio5.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuinquenio_TextChanged(sender As Object, e As EventArgs) Handles txtQuinquenio.TextChanged
        Try
            If IsNumeric(txtQuinquenio.Text.ToString) Then
                If txtQuinquenio.Text.ToString.Trim.Length > 3 And txtQuinquenio.Text.ToString.Trim.Length < 5 Then
                    lblanio1.Text = "Año " & (Convert.ToInt32(txtQuinquenio.Text.ToString) + 0).ToString
                    lblanio2.Text = "Año " & (Convert.ToInt32(txtQuinquenio.Text.ToString) + 1).ToString
                    lblanio3.Text = "Año " & (Convert.ToInt32(txtQuinquenio.Text.ToString) + 2).ToString
                    lblanio4.Text = "Año " & (Convert.ToInt32(txtQuinquenio.Text.ToString) + 3).ToString
                    lblanio5.Text = "Año " & (Convert.ToInt32(txtQuinquenio.Text.ToString) + 4).ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQuinquenio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuinquenio.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CB_UnidadLider_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_UnidadLider.SelectedIndexChanged

    End Sub
End Class
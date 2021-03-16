Imports System.Globalization

Public Class POA_InsertAccionesNoProgramadas

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtCollectingServices As DataTable
    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _isInsert As Boolean = True
    Property _accion As String = ""
    Property _mesInicio As String
    Property _fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
    Property _presupuesto As Double = 0
    Property _unidadLider As String = ""
    Property _Administrador As String = ""
    Property _IdAcciones As Long

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
                Dim dtGerencia As DataTable = objDatos.ERP_StrategicPlan_GetUnitLider(_Id_DptoPlani)
                CB_UnidadLider.DataSource = dtGerencia
                CB_UnidadLider.DisplayMember = "Name"
                CB_UnidadLider.ValueMember = "Id_FreeUnit"
            Catch ex As Exception
                Dim aaa As String = ""
            End Try
            Try
                Dim dtMes As DataTable = objDatos.ERP_StrategicPlan_getMeses()
                Dim dtMesFinal As DataTable = objDatos.ERP_StrategicPlan_getMeses()

                CB_MesInicio.DataSource = dtMes
                CB_MesInicio.DisplayMember = "Mes"
                CB_MesInicio.ValueMember = "IdMes"

                cbMesFinal.DataSource = dtMesFinal
                cbMesFinal.DisplayMember = "Mes"
                cbMesFinal.ValueMember = "IdMes"

            Catch ex As Exception
                Dim aaa As String = ""
            End Try
        End Using

        txt_POA_AccioneDesarrollada.Focus()
        txt_POA_AccioneDesarrollada.Text = _accion
        CB_MesInicio.Text = _mesInicio
        txt_POA_Presupuesto.Text = _presupuesto
        CB_UnidadLider.Text = _unidadLider
        txt_POA_Administrador.Text = _Administrador
        Try
            cbMesFinal.SelectedValue = Convert.ToDateTime(_fecha).Month
            txtAnio.Text = Convert.ToDateTime(_fecha).Year
        Catch ex As Exception

        End Try
    End Sub

    Public Function MonthName(ByVal month As Integer) As String
        Dim dtinfo As DateTimeFormatInfo = New CultureInfo("es-ES", False).DateTimeFormat
        Return dtinfo.GetMonthName(month)
    End Function
    'para saber el ultimo dia del mes
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txt_POA_AccioneDesarrollada.Text = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_AccioneDesarrollada.Focus()
            Exit Sub
        End If

        If txtAnio.Visible = True Then
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
        End If

        If txt_POA_Presupuesto.Text = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_Presupuesto.Focus()
            Exit Sub
        End If
        If txt_POA_Administrador.Text = "" Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_POA_Administrador.Focus()
            Exit Sub
        End If


        Dim Fecha As Date = UltimoDiaDelMes("01-" & cbMesFinal.SelectedValue & "-" & txtAnio.Text.ToString)

        If _isInsert Then
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_InsertProgrammedAction(_Id_DptoPlani, txt_POA_AccioneDesarrollada.Text, CB_MesInicio.SelectedValue, Fecha, txt_POA_Presupuesto.Text, CB_UnidadLider.SelectedValue, txt_POA_Administrador.Text)
        Else
            Dim dt As String
            dt = objsql.ERP_StrategicPlan_UpdateProgrammedAction(_Id_DptoPlani, _IdAcciones, txt_POA_AccioneDesarrollada.Text, CB_MesInicio.SelectedValue, Fecha, txt_POA_Presupuesto.Text, CB_UnidadLider.SelectedValue, txt_POA_Administrador.Text)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Public Sub condicion(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If


        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt_POA_Presupuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_POA_Presupuesto.KeyPress
        Call condicion(txt_POA_Presupuesto, e)
    End Sub

End Class
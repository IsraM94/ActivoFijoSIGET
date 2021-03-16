Public Class SeleccionarMesAnio

#Region "Properties"
    Private objsql As New POA_SQLServer
    Property MesReportado As String = ""
    Property IdMesReportado As Integer = 0
    Property AnioInicio As Integer = 0
    Property AnioFin As Integer = 0
    Property CuadroEstadistico As Boolean = False
    Property VistaFin As Boolean = False
    Property VistaMeses As Boolean = False
    Property IdGerenciaReporte As Integer = 0
    Property Gerencia As String = ""
    Property Planificacion As Boolean = True

#End Region

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            MesReportado = comboMeses.SelectedItem(1).ToString
            IdMesReportado = comboMeses.SelectedItem(0).ToString
        Catch ex As Exception

        End Try
        If Not (ValidarAnios(txtAnioInicio)) Then
            Exit Sub
        End If
        If VistaFin Then
            If Not (ValidarAnios(txtAnioFin)) Then

                Exit Sub
            Else
                If AnioInicio > AnioFin Then
                    MessageBox.Show("El Año Fin debe ser Mayor al Año Inicio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If AnioFin - AnioInicio > 5 Then
                    MessageBox.Show("Solamente se pueden mostrar 5 Años", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


            End If
        End If

        Try
            IdGerenciaReporte = cbGerencia.SelectedItem(0).ToString
            Gerencia = cbGerencia.SelectedItem(1).ToString
        Catch ex As Exception

        End Try

        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub SeleccionarAnio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbGerencia.Visible = False
        lblGerencia.Visible = False

        If CuadroEstadistico Then
            Try
                cbGerencia.Visible = True
                lblGerencia.Visible = True
                Dim dataInfo As DataTable
                Using obj As New POA_SQLServer
                    dataInfo = obj.ERP_StrategicPlan_GetManagement()
                End Using
                Dim dataSelect As DataTable = dataInfo.Clone
                If Planificacion Then
                    dataSelect.Rows.Add("0", "Seleccione")
                End If
                For Each Info As DataRow In dataInfo.Rows
                    If Planificacion Then
                        dataSelect.ImportRow(Info)
                    Else
                        If Info("Id_Deparment") = _Id_DepartmentGlobal Then
                            dataSelect.ImportRow(Info)
                        End If
                    End If
                Next

                cbGerencia.DataSource = dataSelect
                cbGerencia.DisplayMember = "Name"
                cbGerencia.ValueMember = "Id_Deparment"
            Catch ex As Exception

            End Try
        End If

        Try
            If VistaFin Then
                lblAnioFin.Visible = True
                txtAnioFin.Visible = True
            End If
            lblMeses.Visible = False
            comboMeses.Visible = False
            If VistaMeses Then
                lblMeses.Visible = True
                comboMeses.Visible = True
                Dim dataInfo As DataTable = objsql.ERP_StrategicPlan_getMeses

                Dim dataSelect As DataTable = dataInfo.Clone

                For Each Info As DataRow In dataInfo.Rows
                    dataSelect.ImportRow(Info)
                Next

                comboMeses.DataSource = dataSelect
                comboMeses.DisplayMember = "Mes"
                comboMeses.ValueMember = "IdMEs"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Function ValidarAnios(ByVal Anio As TextBox) As Boolean
        Try
            If IsNumeric(Anio.Text) Then
                If Anio.Text.Length < 4 Or Anio.Text.Length > 4 Then
                    MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Anio.Focus()
                    Return False
                    Exit Function
                End If
            Else
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Anio.Focus()
                Return False
                Exit Function
            End If
            Dim Bandera As Boolean = False
            For i As Integer = Date.Now.Year - 25 To Date.Now.Year + 10
                If Anio.Text.ToString.Trim = i.ToString Then
                    Bandera = True
                    Exit For
                End If
            Next

            If Not Bandera Then
                MessageBox.Show("Favor ingrese un año correcto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Anio.Focus()
                Return False
                Exit Function
            End If
            If Anio.Name = "txtAnioFin" Then
                AnioFin = Anio.Text.ToString
            Else
                AnioInicio = Anio.Text.ToString
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
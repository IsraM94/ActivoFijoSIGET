Public Class SeleccionarAnio

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtObjetivos As New DataTable
    Private dtEjes As New DataTable
    Property Anio As Long = 0
    Property Tipo As String = ""
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
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

                Anio = txtAnio.Text.ToString
            End If



            Tipo = cbTipo.SelectedValue

            DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAnio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        Try
            txtAnio.Visible = True
            lblAnio.Visible = True
            If cbTipo.SelectedValue = 3 Or cbTipo.SelectedValue = 4 Then
                txtAnio.Visible = False
                lblAnio.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SeleccionarAnio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt.Columns.Add("IdRe")
        dt.Columns.Add("Descripcion")

        If _VerTodos Then
            dt.Rows.Add("1", "Plan Estratégico Institucional (PEI) por Gerencia")
            dt.Rows.Add("2", "Plan Operativo Anual (POA) por Gerencia")
            dt.Rows.Add("3", "Plan Estratégico Institucional (PEI) General")
            dt.Rows.Add("4", "Plan Operativo Anual (POA) General")
        Else
            dt.Rows.Add("1", "Plan Estratégico Institucional (PEI) por Gerencia")
            dt.Rows.Add("2", "Plan Operativo Anual (POA) por Gerencia")
        End If

        cbTipo.DataSource = dt
        cbTipo.ValueMember = "IdRe"
        cbTipo.DisplayMember = "Descripcion"
    End Sub

End Class
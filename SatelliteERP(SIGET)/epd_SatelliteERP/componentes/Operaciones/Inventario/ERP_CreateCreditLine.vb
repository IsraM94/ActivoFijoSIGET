Public Class ERP_PayCreditLine

#Region "Property"

    Property ActiveLine As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private TotalDays As Integer = 0
    Property Valor As String = ""
    Property Saldo As String = ""
    Property concepto As String = ""
    Property Vigencia As String = ""
	Property ID_CreditLine As Long = 0
	Property Id_Customer As Long = 0
	Property ID_TypeCreditLine As Long = 0
	Property DateStart As DateTime = Nothing
	Property DateEnd As DateTime = Nothing
	Property DaysInvoiceExpiration As Integer = 0
	Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion

#End Region
    Private ValorOtorgado As Double = 0
    Private DeudaOrginal As Double = 0
    Private Sub ERP_PayCreditLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DatePickerEnd.Value = Me.DatePickerEnd.Value.AddMonths(1)
        chkActivo.Checked = True
        FillCBCreditLine()
        Select Case _OpcionSeleccionada
            Case funcion.Actualizar
                txtValor.Text = CType(_Valor, Decimal).ToString("#0.00")
                txtConcepto.Text = _concepto
                txtSaldo.Text = CType(Saldo, Decimal).ToString("#0.00")
                DeudaOrginal = _Valor - Saldo
                ValorOtorgado = _Valor
                txtDeudaActual.Text = DeudaOrginal.ToString("#0.00")
                CbCreditLine.SelectedValue = _ID_TypeCreditLine
                DatePickerStart.Value = _DateStart
                DatePickerEnd.Value = _DateEnd
                TxtVigencia.Text = _Vigencia
				chkActivo.Checked = _ActiveLine
				txtDiasVencimientoFactura.Text = _DaysInvoiceExpiration
		End Select
    End Sub

#Region "combo Box"

    Private Sub FillCBCreditLine()
        Using objDatos As New Generic_SQLServer
            _DT_CreditLine = objDatos.GetTypeCreditLine()
            If _DT_CreditLine.Rows.Count Then
                Try
                    CbCreditLine.DataSource = _DT_CreditLine
                    CbCreditLine.DisplayMember = "TypeCreditLine"
                    CbCreditLine.ValueMember = "ID_TypeCreditLine"
                    CbCreditLine.SelectedValue = -1
                Catch ex As ArgumentException
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                Catch ex As Exception
                    Using objLog As New ProcessGeneral
                        objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Using
                End Try
            End If
        End Using
    End Sub

#End Region

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resultado As Integer = 0
        If txtValor.Text.Trim = "" Then
            MessageBox.Show("Digite el monto de la línea de crédito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtValor.Select()
            Exit Sub
        End If
        If txtConcepto.Text.Trim = "" Then
            MessageBox.Show("Digite el concepto de la línea de crédito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtConcepto.Select()
            Exit Sub
        End If
        If CbCreditLine.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione un tipo de línea de crédito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If DatePickerEnd.Value < DatePickerStart.Value Then
			MessageBox.Show("La fecha final no puede ser menor a la fecha inicial.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		If txtDiasVencimientoFactura.Text.Trim = "" Then
            MessageBox.Show("Digite los días de vencimiento para facturación.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDiasVencimientoFactura.Select()
			Exit Sub
		End If
		If Not IsNumeric(txtDiasVencimientoFactura.Text.Trim) Then
            MessageBox.Show("Digite los días de vencimiento para facturación.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDiasVencimientoFactura.Select()
			Exit Sub
		End If

		_DaysInvoiceExpiration = txtDiasVencimientoFactura.Text.Trim
		_Valor = txtValor.Text.Trim
        _concepto = txtConcepto.Text.Trim
        _ID_TypeCreditLine = CbCreditLine.SelectedValue
        _Vigencia = TxtVigencia.Text.Trim
        _DateStart = DatePickerStart.Value
        _DateEnd = DatePickerEnd.Value
        _ActiveLine = chkActivo.Checked
        Saldo = txtSaldo.Text
        Select Case _OpcionSeleccionada
            Case funcion.Actualizar
                Using objDatos As New Generic_SQLServer
					resultado = objDatos.SetCreditLine(_ID_CreditLine, _ID_TypeCreditLine, _Id_Customer, _Valor, Saldo, _concepto, _Vigencia, _DateStart, _DateEnd, _ActiveLine, _DaysInvoiceExpiration)
					If resultado = 1 Then
						MessageBox.Show("El registro se actualizó correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
						DialogResult = DialogResult.OK
						Close()
					ElseIf resultado = 2 Then
                        MessageBox.Show("Existe una línea de crédito con el mismo concepto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub 
                    End If
                End Using
            Case funcion.Agregar
                Using objDatos As New Generic_SQLServer
					resultado = objDatos.InsertCreditLine(_ID_TypeCreditLine, _Id_Customer, _Valor, Saldo, _concepto, _Vigencia, _DateStart, _DateEnd, _ActiveLine, Data_Id_Company, _DaysInvoiceExpiration)
					If resultado = 1 Then
						MessageBox.Show("El registro se agregó correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
						DialogResult = DialogResult.OK
						Close()
					ElseIf resultado = 2 Then
                        MessageBox.Show("Existe una línea de crédito con el mismo concepto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
        End Select

	End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DatePickerEnd_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerEnd.ValueChanged
        TotalDays = (DatePickerEnd.Value - DatePickerStart.Value).TotalDays
        TxtVigencia.Text = TotalDays
    End Sub

    Private Sub DatePickerStart_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerStart.ValueChanged
        TotalDays = (DatePickerEnd.Value - DatePickerStart.Value).TotalDays
        TxtVigencia.Text = TotalDays
    End Sub


    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        Using objval As New Validaciones
            e.Handled = objval.Validar_Money(sender, e, txtValor)
        End Using
    End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
        'Using objval As New Validaciones
        '    e.Handled = objval.JustLettersAndPunctuation(sender, e)
        'End Using
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Select Case _OpcionSeleccionada
            Case funcion.Agregar
                txtSaldo.Text = txtValor.Text
                txtDeudaActual.Text = "0.00"
            Case Else
                Try
                    txtSaldo.Text = (CType(txtValor.Text, Decimal) - DeudaOrginal).ToString("#0.00")
                Catch ex As Exception
                    txtSaldo.Text = "0.00"
                End Try

        End Select

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region
End Class
Public Class Financiero_CrearCuentaContable

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub
#Region "Property"
    Private _DT_AccountingCount As DataTable
    Property Id_Account As Long = Nothing
    Property Id_Company_FK As Long = Data_Id_Company
    Property Id_TypeAccount_FK As Long = Nothing
    Property Is_Detail As Boolean = False
    Property CuentaContable As String = ""
    Property NoCuentaContable As String = ""
    Property OpcionSeleccionada As funcion
    Property Id_CashFlow As Long
    Enum funcion
        Agregar
        Actualizar
    End Enum
#End Region
    Private Sub ERP_AccountingCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBTypeAcount()
        If OpcionSeleccionada = funcion.Agregar Then
            If NoCuentaContable <> "" Then
                txtNoCuentaContable.Text = NoCuentaContable.Trim & "."
            End If

        End If
        If txtNoCuentaContable.Text.Split(".").Length = Data_LevelBalance Then
            ' Muestra Flujo de efectivo
            CB_FlujoEfectivo.Enabled = True
            Using objDatos As New Financiero_SQLServer
                Dim dt As DataTable = objDatos.GetCashFlow_Select(Data_Id_Company)
                CB_FlujoEfectivo.DataSource = dt
                CB_FlujoEfectivo.ValueMember = "ID_CashFlow"
                CB_FlujoEfectivo.DisplayMember = "Description"
                CB_FlujoEfectivo.SelectedValue = _Id_CashFlow

            End Using
        End If
        If Not Id_CashFlow = -1 Then
            CB_FlujoEfectivo.SelectedValue = _Id_CashFlow
        End If
    End Sub
    Private Sub FillCBTypeAcount()
        Using objDatos As New Financiero_SQLServer
            Try
                _DT_AccountingCount = objDatos.GetTypeAcount(Data_Id_Company)
                If _DT_AccountingCount.Rows.Count <> 0 Then
                    comboListTypeAcount.DataSource = _DT_AccountingCount
                    comboListTypeAcount.DisplayMember = "Tipo de Cuenta"
                    comboListTypeAcount.ValueMember = "Id_TypeAccount"
                    comboListTypeAcount.SelectedIndex = -1
                    Select Case _OpcionSeleccionada
                        Case funcion.Actualizar
                            comboListTypeAcount.SelectedValue = Id_TypeAccount_FK
                            txtCuentaContable.Text = _CuentaContable
                            txtNoCuentaContable.Text = _NoCuentaContable
                            txtNoCuentaContable.ReadOnly = True
                            checkMovimientoDirecto.Checked = _Is_Detail
                    End Select
                End If
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End Using
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resultado As Integer = 0
        If txtNoCuentaContable.Text.Trim = "" Then
            MessageBox.Show("Por favor introduzca el numero de cuenta contable.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNoCuentaContable.Select()
            Exit Sub
        End If
        If txtCuentaContable.Text.Trim = "" Then
            MessageBox.Show("Por favor introduzca el nombre de la cuenta contable.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtCuentaContable.Select()
            Exit Sub
        End If
        If comboListTypeAcount.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione el tipo de cuenta contable.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If Not _NoCuentaContable = txtNoCuentaContable.Text.Substring(0, _NoCuentaContable.Length) Then
            MessageBox.Show("La cuenta padre no corresponde a selecionada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        _CuentaContable = txtCuentaContable.Text.Trim
        _NoCuentaContable = txtNoCuentaContable.Text.Trim
        _Id_TypeAccount_FK = comboListTypeAcount.SelectedValue
        _Id_CashFlow = CB_FlujoEfectivo.SelectedValue
        Select Case _OpcionSeleccionada
            Case funcion.Actualizar
                Using objDatos As New Financiero_SQLServer
                    If checkMovimientoDirecto.Checked = True Then
                        _Is_Detail = True
                    Else
                        _Is_Detail = False
                    End If
                    resultado = objDatos.SetAccountingCatalog(_Id_Account, Data_Id_Company, Id_TypeAccount_FK, Is_Detail, NoCuentaContable, _CuentaContable, _Id_CashFlow)
                    If resultado = 1 Then
                        MessageBox.Show("El registro se actualizo correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ElseIf resultado = 2 Then
                        MessageBox.Show("Al parecer ya existe una cuenta con el mismo nombre, por favor verifique.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCuentaContable.Select()

                    Else
                        MessageBox.Show("No se pudo actualizar el registro, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            Case funcion.Agregar
                Using objDatos As New Financiero_SQLServer
                    If checkMovimientoDirecto.Checked = True Then
                        _Is_Detail = True
                    Else
                        _Is_Detail = False
                    End If
                    resultado = objDatos.InsertAccountingCatalog(Data_Id_Company, _Id_TypeAccount_FK, _Is_Detail, NoCuentaContable, _CuentaContable)
                    If resultado = 1 Then
                        MessageBox.Show("El registro se agrego correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ElseIf resultado = 2 Then
                        MessageBox.Show("Al parecer ya existe una cuenta con el mismo nombre, por favor verifique.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCuentaContable.Select()
                    Else
                        MessageBox.Show("No se pudo agregar el registro, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
        End Select
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtNoCuentaContable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoCuentaContable.KeyPress
        Using ObjValidacion As New Validaciones
            e.Handled = ObjValidacion.JustNumbersAndPoint(sender, e)
        End Using
    End Sub

    Private Sub txtCuentaContable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaContable.KeyPress
        Using ObjValidacion As New Validaciones
            e.Handled = ObjValidacion.JustLetters(sender, e)
        End Using
    End Sub

    Private Sub checkMovimientoDirecto_CheckedChanged(sender As Object, e As EventArgs) Handles checkMovimientoDirecto.CheckedChanged
        If checkMovimientoDirecto.Checked Then
            CB_FlujoEfectivo.Enabled = True
            Using objDatos As New Financiero_SQLServer
                Dim dt As DataTable = objDatos.GetCashFlow_Select(Data_Id_Company)
                CB_FlujoEfectivo.DataSource = dt
                CB_FlujoEfectivo.ValueMember = "ID_CashFlow"
                CB_FlujoEfectivo.DisplayMember = "Description"
                CB_FlujoEfectivo.SelectedValue = _Id_CashFlow

            End Using
        Else
            CB_FlujoEfectivo.Enabled = False
        End If
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
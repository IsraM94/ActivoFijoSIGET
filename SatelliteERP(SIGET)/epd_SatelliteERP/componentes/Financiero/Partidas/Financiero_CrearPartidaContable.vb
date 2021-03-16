Public Class Financiero_CrearPartidaContable
    Property TableCuentaContable As DataTable
    Private process As New ProcessGeneral
    Private _tbClassificationItemType As DataTable
    Private objSql As New Financiero_SQLServer
    Private _IdPartidaContable As Long
    Private _Text_TypeItem As String
    Enum TipoIngresoInfo
        NuevoRegistro
        Modificacion
        Copia
        Reversion
    End Enum
    Property TipoIngreso As TipoIngresoInfo

    Public Property IdPartidaContable As Long
        Get
            Return _IdPartidaContable
        End Get
        Set(value As Long)
            _IdPartidaContable = value
            txtPartida_NoPartida.Text = _IdPartidaContable
        End Set
    End Property
    Public Property Text_TypeItem As String
        Set(value As String)
            _Text_TypeItem = value
        End Set
        Get
            Return _Text_TypeItem
        End Get
    End Property
    Public Property ConceptItem As String
        Set(value As String)
            txtConcept.Text = value
        End Set
        Get
            Return txtConcept.Text
        End Get
    End Property
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub Financiero_CrearPartidadContable_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim filterExp As String = "Is_Detail = 1"
        Dim sortExp As String = "NumeroCuentaContable"
        Dim drarray() As DataRow
        Dim i As Integer
        drarray = _TableCuentaContable.Select(filterExp, sortExp, DataViewRowState.CurrentRows)
        comboListAccount.Items.Clear()
        For i = 0 To (drarray.Length - 1)
            comboListAccount.Items.Add(drarray(i)("NumeroCuentaContable").ToString & "-" & drarray(i)("NombreCuentaContable").ToString)
        Next
        _tbClassificationItemType = objSql.GetClassificationItemType(Data_Id_Company)
        CB_TypeItem.DataSource = _tbClassificationItemType
        CB_TypeItem.DisplayMember = "Name_ClassificationItemType"
        CB_TypeItem.ValueMember = "Id_ClassificationItemType"
        If _IdPartidaContable <> 0 Then
            CB_TypeItem.Text = _Text_TypeItem
            If TipoIngreso = TipoIngresoInfo.Modificacion Then
                CB_TypeItem.Enabled = False
                txtConcept.ReadOnly = True
            End If
            Dim dt As DataTable = objSql.GetFinance_AccountingIitemBody(Data_Id_Company, _IdPartidaContable)
            Try


                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        For Each row As DataRow In dt.Rows
                            Dim objSubItem As ListViewItem = lvDetails.Items.Add(row("NumberAccount"))
                            objSubItem.SubItems.Add(row("NombreCuentaContable"))
                            objSubItem.SubItems.Add(row("Concept_AccountingIitemBody"))
                            If row("Item_Charge") > 0 Then
                                objSubItem.SubItems.Add(row("Item_Charge"))
                                If TipoIngreso = TipoIngresoInfo.Reversion Then
                                    objSubItem.SubItems.Add(" ")
                                    objSubItem.SubItems.Add(row("Item_Charge"))
                                Else
                                    objSubItem.SubItems.Add(row("Item_Charge"))
                                    objSubItem.SubItems.Add(" ")
                                End If

                            Else
                                objSubItem.SubItems.Add(row("Iteml_Deposit"))
                                If TipoIngreso = TipoIngresoInfo.Reversion Then
                                    objSubItem.SubItems.Add(row("Iteml_Deposit"))
                                    objSubItem.SubItems.Add(" ")
                                Else
                                    objSubItem.SubItems.Add(" ")
                                    objSubItem.SubItems.Add(row("Iteml_Deposit"))
                                End If

                            End If
                            objSubItem.SubItems.Add(row("Is_Deductible"))
                            objSubItem.SubItems.Add(row("ID_CostCenter_FK"))
                            If TipoIngreso = TipoIngresoInfo.Modificacion Then
                                objSubItem.SubItems.Add(row("Id_AccountingIitemBody"))
                            End If
                        Next
                        IsMontosCuadrados()
                    End If
                End If
            Catch ex As Exception
                Process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                MessageBox.Show("La partida no puede ser procesada en este momento, si el problema persiste llama a soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
            End Try
            If TipoIngreso = TipoIngresoInfo.Copia Or TipoIngreso = TipoIngresoInfo.Reversion Then
                IdPartidaContable = 0
            End If
            If TipoIngreso = TipoIngresoInfo.Reversion Then
                cmdSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        ' Validacion de seleccion de cuenta
        If Not comboListAccount.Text.Length = 0 Then
            Using obj As New Financiero_CrearPartidaContablesMontos
                obj.StartPosition = FormStartPosition.CenterParent
                If obj.ShowDialog = DialogResult.OK Then
                    '' Adicion de registro
                    Dim DatosCuenta() As String = comboListAccount.Text.Split("-")
                    Dim objSubItem As ListViewItem = lvDetails.Items.Add(DatosCuenta(0))
                    objSubItem.SubItems.Add(DatosCuenta(1))
                    objSubItem.SubItems.Add(obj.Concept)
                    objSubItem.SubItems.Add(obj.Amount)
                    If obj.IsDebit Then
                        objSubItem.SubItems.Add(obj.Amount)
                        objSubItem.SubItems.Add(" ")
                    Else
                        objSubItem.SubItems.Add(" ")
                        objSubItem.SubItems.Add(obj.Amount)
                    End If
                    objSubItem.SubItems.Add(obj.IsDeductible)
                    objSubItem.SubItems.Add(obj.ID_CostCenter)
                    IsMontosCuadrados()
                End If
            End Using
        End If
    End Sub
    Private Function IsMontosCuadrados() As Boolean
        txtTotalDebe.Text = 0
        txtMontoHacer.Text = 0
        For Each items As ListViewItem In lvDetails.Items
            If Not items.SubItems(4).Text.Trim = "" Then
                txtTotalDebe.Text = CType(txtTotalDebe.Text, Decimal) + CType(items.SubItems(4).Text.Trim, Decimal)
            Else
                txtMontoHacer.Text = CType(txtMontoHacer.Text, Decimal) + CType(items.SubItems(5).Text.Trim, Decimal)

            End If
        Next

    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If lvDetails.Items.Count = 0 Then
            MessageBox.Show("La partida no puede almacenarce sin datos.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not CType(txtMontoHacer.Text, Decimal) = CType(txtTotalDebe.Text, Decimal) Then
            MessageBox.Show("La partida contable no esta cuadrada, por ese motivo no se mayorizara.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Using objInsertar As New Financiero_SQLServer
            REM            For Each row As Dat  
            Dim resp As String
            If CType(txtPartida_NoPartida.Text, Long) = 0 Then
                resp = objInsertar.SetAccountingIitemHeading(Data_Id_Company, CB_TypeItem.SelectedValue, Data_BusinessDay, txtConcept.Text.Trim)
            Else
                resp = "OK|" & CType(txtPartida_NoPartida.Text, Long)
            End If
            If resp.Substring(0, 2) = "OK" Then
                Dim Id_AccountingIitemHeading As Long = resp.Split("|")(1)
                Dim Id_Account As Long = 0

                For Each items As ListViewItem In lvDetails.Items
                    Id_Account = 0
                    For Each row As DataRow In TableCuentaContable.Select("NumeroCuentaContable ='" & items.SubItems(0).Text & "'")
                        Id_Account = row("Id_Account")
                    Next
                    Dim IdLineaPartida As Long = 0
                    Try
                        IdLineaPartida = CType(items.SubItems(8).Text, Long)
                    Catch ex As Exception
                        IdLineaPartida = 0
                    End Try
                    If IdLineaPartida = 0 Then
                        Dim item_change As Decimal = 0
                        Dim item_deposit As Decimal = 0
                        If Not items.SubItems(4).Text.Trim = "" Then
                            item_change = items.SubItems(4).Text.Trim
                        End If
                        If Not items.SubItems(5).Text.Trim = "" Then
                            item_deposit = items.SubItems(5).Text.Trim
                        End If
                        objInsertar.SetAccountingIitemBody(Id_AccountingIitemHeading, Id_Account, items.SubItems(0).Text, items.SubItems(2).Text, item_change, item_deposit, items.SubItems(6).Text = "True", items.SubItems(7).Text)
                    Else
                        ' Verificar si se dejara actualizar los montos
                    End If
                Next
                objSql.GeFinance_AccountingIitemValidate(Data_Id_Company, Id_AccountingIitemHeading)
                If TipoIngreso = TipoIngresoInfo.Reversion Then
                    Dim resp1 As String = objSql.SetFinance_AccountingItem_Posting(Data_Id_Company, Id_AccountingIitemHeading)
                    If Not resp1.Substring(0, 2) = "OK" Then
                        MessageBox.Show(resp1.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                End If
            End If
            DialogResult = DialogResult.OK
            Close()
        End Using
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
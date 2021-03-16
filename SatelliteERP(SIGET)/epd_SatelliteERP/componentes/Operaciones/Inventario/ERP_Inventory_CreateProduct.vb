Imports System.IO

Public Class ERP_Inventory_CreateProduct
    Property objCustomerRow As DataRow
    Private _DT_Providers As DataTable = Nothing
    Private _DT_UnitMeasure As DataTable = Nothing
    Private _DT_TypeProducts As DataTable = Nothing
    Private _DT_Category As DataTable = Nothing
    Private _DT_Line As DataTable = Nothing
    Private _DT_Marca As DataTable = Nothing
    Private objSqlOperaciones As New Operaciones_SQLServer
    Private openFileDialog As New OpenFileDialog
	Property base64String As String = ""

	Private _Length As Long = 5
#Region "Property"
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
    Property Id_Product As Long
    Property Id_Company As Long = 1
    Property Id_Customer As Long
    Property ID_Provider As Integer
    Property Description As String
    Property BarCode As String

    Property _NumberPurchase As String
    Property ID_Unit As Integer
    Property PurchasePrice As Double
    Property PriceSale As Double
    Property ID_Line As Integer
    Property ID_Marca As Integer
    Property ID_Category As Integer
    Property Id_ProductCondition As Integer
    Property Price_LastPpurchase As Double
    Property Price_Average As Double
    Property IsExempt As Boolean = False
	Property picture As Byte()

	Private imageData As Byte()
	Property IS_Recipe As Boolean = False
	Property IS_RawMaterial As Boolean = False
	Property IS_Mixed As Boolean = False
	Property IS_FinalProduct As Boolean = False
	Property Conversion As Long = 0

    Property IS_SubProduct As Boolean = False

    Property _ProductoName As String

#End Region

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        If cbProvider.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If txtNombreProducto.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el nombre del artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDescription.Select()
            Exit Sub
        End If
        If txtDescription.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese la descripción del artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDescription.Select()
            Exit Sub
        End If
        If txtDescription.Text.Trim.Length <= _Length Then
            MessageBox.Show("La descripción del artículo debe ser mayor a: " & _Length & " Carácteres", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDescription.Select()
            Exit Sub
        End If
        If txtBarCode.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el código de barras del artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtBarCode.Select()
            Exit Sub
        End If
        If cbTipo.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione un tipo de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If cbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione una categoría para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If cbUnit.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione la unidad de medida del artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If cbMarca.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione una marca para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If txtPurchasePrice.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el precio de la última compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtPurchasePrice.Select()
            Exit Sub
        End If
        If cbLine.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione una línea para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If txtPrice_Average.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el precio medio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If txtPriceSale.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese le precio de Descargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtPriceSale.Select()
            Exit Sub
        End If
        If base64String.ToString = "" Then
            If MessageBox.Show("No ha seleccionado una imagen para el producto, ¿Desea continuar?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                base64String = ConvertBase64(My.Resources.file)
            Else
                Exit Sub
            End If
        End If


        _ID_Provider = cbProvider.SelectedValue
        _ProductoName = txtNombreProducto.Text
        _Description = txtDescription.Text.Trim
        _NumberPurchase = txtNumberPurchase.Text.ToString.Trim
        _BarCode = txtBarCode.Text.Trim
        _ID_Unit = cbUnit.SelectedValue
        _PurchasePrice = txtPurchasePrice.Text.Trim
        _PriceSale = txtPriceSale.Text.Trim
        _ID_Line = cbLine.SelectedValue
        _ID_Marca = cbMarca.SelectedValue
        _ID_Category = cbCategory.SelectedValue
        _Price_LastPpurchase = txtPurchasePrice.Text.Trim
        _Price_Average = txtPrice_Average.Text.Trim
        _Id_ProductCondition = cbTipo.SelectedValue

        If checkIsExempt.Checked = True Then
            _IsExempt = True
        End If
        If chkRecipe.Checked Then
            IS_Recipe = True
        End If
        If rb_RawMaterial.Checked Then
            IS_RawMaterial = True
        ElseIf rb_Mixed.Checked Then
            IS_Mixed = True

        ElseIf rb_FinalProduct.Checked Then
            IS_FinalProduct = True
        End If
        If chkSubProducto.Checked Then
            IS_SubProduct = True
        Else
            IS_SubProduct = False
        End If

        If chkUnitMeasure.Checked Then
            If cbConversion.SelectedIndex = -1 Then
                MessageBox.Show("Por favor seleccione la unidad de conversión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If

        If chkUnitMeasure.Checked Then
            Conversion = cbConversion.SelectedValue
        Else
            Conversion = 0
        End If

        Select Case _OpcionSeleccionada
            Case funcion.Agregar
                Using ObjSQL As New Operaciones_SQLServer
                    Dim resp As Integer = ObjSQL.AddProducts(_Id_Company, _ID_Provider, _Id_ProductCondition, _ID_Line, _ID_Unit, _IsExempt, _ProductoName, _Description, _BarCode, _PriceSale, _Price_LastPpurchase, _Price_Average, _ID_Category, _ID_Marca, base64String, IS_Recipe, IS_RawMaterial, IS_Mixed, IS_FinalProduct, IS_SubProduct, Conversion, _NumberPurchase)
                    If resp = 1 Then
                        MessageBox.Show("Artículo agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtDescription.Text = ""
                        txtNumberPurchase.Text = ""
                        txtBarCode.Text = ""
                        txtPriceSale.Text = ""
                        txtPurchasePrice.Text = ""
                        txtPurchasePrice.Text = ""
                        txtPrice_Average.Text = ""
                        checkIsExempt.Checked = False
                        'cbUnit.SelectedIndex = -1
                        Me.DialogResult = DialogResult.OK
                        Close()
                    ElseIf resp = 2 Then
                        MessageBox.Show("Al parecer ya existe el Producto, por favor verifique", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Ocurrió un error al agregar el producto, por favor contacte a Soporte Técnico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Case funcion.Actualizar
                Using ObjSQL As New Operaciones_SQLServer
                    Dim resp As Integer = ObjSQL.SetProducts(Id_Product, _Id_Company, _ID_Provider, _Id_ProductCondition, _ID_Line, _ID_Unit, _IsExempt, _ProductoName, _Description, _BarCode, _PriceSale, _Price_LastPpurchase, _Price_Average, _ID_Category, _ID_Marca, base64String, IS_Recipe, IS_RawMaterial, IS_Mixed, IS_FinalProduct, IS_SubProduct, Conversion, _NumberPurchase)
                    If resp = 1 Then
                        MessageBox.Show("Artículo actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtDescription.Text = ""
                        txtNumberPurchase.Text = ""
                        txtBarCode.Text = ""
                        txtPriceSale.Text = ""
                        txtPurchasePrice.Text = ""
                        txtPurchasePrice.Text = ""
                        txtPrice_Average.Text = ""
                        checkIsExempt.Checked = False
                        'cbUnit.SelectedIndex = -1
                        Me.DialogResult = DialogResult.OK
                        Close()
                    ElseIf resp = 2 Then
                        MessageBox.Show("Al parecer ya existe el producto, por favor verifique", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Ocurrió un error al agregar el producto, por favor contacte a Soporte Técnico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
        End Select

    End Sub

#Region "Fill CB"
    Private Function FillCBProviders() As Boolean
        Dim resp As Boolean = False
        Using ObjSQl As New Operaciones_SQLServer
            _DT_Providers = ObjSQl.GetProviders(_Id_Company)
        End Using
        Dim dt_Providers As New DataTable
        dt_Providers.Columns.Add("ID", Type.GetType("System.Int64"))
        dt_Providers.Columns.Add("Description", Type.GetType("System.String"))
        For Each row As DataRow In _DT_Providers.Rows
            If Not row Is Nothing Then
                If Not IsDBNull(row("Is_LegalEntity")) Then
                    'If row("Is_LegalEntity") Then
                    Try
                        dt_Providers.Rows.Add(row("Id_Customer"), row("Name_Company"))
                    Catch ex As Exception

                    End Try
                    'End If
                End If
            End If
        Next row

        If dt_Providers.Rows.Count > 0 Then
            Try
                resp = True
                cbProvider.DataSource = dt_Providers
                cbProvider.DisplayMember = "Description"
                cbProvider.ValueMember = "ID"
                cbProvider.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
        Return resp
    End Function
    Private Function filCBUnitMeasure() As Boolean
        Dim resp As Boolean = False
        Using ObjSQL As New Operaciones_SQLServer
            _DT_UnitMeasure = ObjSQL.GetUnitMeasure(_Id_Company)
        End Using
        If _DT_UnitMeasure.Rows.Count <> 0 Then
            Try
                resp = True
                cbUnit.DataSource = _DT_UnitMeasure
                cbUnit.DisplayMember = "Name_UnitMeasure"
                cbUnit.ValueMember = "Id_UnitMeasure"
                cbUnit.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
        Return resp
    End Function

    Private Sub fillcbTypeProduct()
        Using ObjSQL As New Operaciones_SQLServer
            _DT_TypeProducts = ObjSQL.GetTypeProduct
        End Using
        If _DT_TypeProducts.Rows.Count <> 0 Then
            Try
                cbTipo.DataSource = _DT_TypeProducts
                cbTipo.DisplayMember = "Name_Condition"
                cbTipo.ValueMember = "Id_ProductCondition"
                cbTipo.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
    End Sub
    Private Sub FillcbCategory()
        Using ObjSQL As New Operaciones_SQLServer
            _DT_Category = ObjSQL.GetCategory(_Id_Company)
        End Using
        If _DT_Category.Rows.Count <> 0 Then
            Try
                RemoveHandler cbCategory.SelectedIndexChanged, AddressOf cbCategory_SelectedIndexChanged
                cbCategory.DataSource = _DT_Category
                cbCategory.DisplayMember = "Description"
                cbCategory.ValueMember = "ID"
                cbCategory.SelectedIndex = -1
                AddHandler cbCategory.SelectedIndexChanged, AddressOf cbCategory_SelectedIndexChanged
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
    End Sub
    Private Sub FillcbLine()
        Using ObjSQ As New Operaciones_SQLServer
            _DT_Line = ObjSQ.GetLine(_Id_Company, cbCategory.SelectedValue)
        End Using
        If _DT_Line.Rows.Count > 0 Then
            Try
                cbLine.DataSource = _DT_Line
                cbLine.DisplayMember = "Description"
                cbLine.ValueMember = "ID"
                cbLine.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        Else
            Try
                _DT_Line.Rows.Clear()
                cbLine.DataSource = _DT_Line
                cbLine.DisplayMember = "Description"
                cbLine.ValueMember = "ID"
                cbLine.SelectedIndex = -1
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub FillcbMarca()
        Using ObjSQL As New Operaciones_SQLServer
            _DT_Marca = ObjSQL.GetMarca(_Id_Company, "", 2)
        End Using
        If _DT_Marca.Rows.Count <> 0 Then
            Try
                cbMarca.DataSource = _DT_Marca
                cbMarca.DisplayMember = "Description"
                cbMarca.ValueMember = "ID"
                cbMarca.SelectedIndex = -1
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region


    Private Sub LoadConversion()
        Dim dt As New DataTable
        Using objsql As New Operaciones_SQLServer
            dt = objsql.ERP_Generic_GET_ConversionUnit(Id_Company)
        End Using
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                cbConversion.DataSource = dt
                cbConversion.DisplayMember = "Conversion"
                cbConversion.ValueMember = "ID_ConversionUnit"
                cbConversion.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub ERP_ConfigurationProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnabledRecipe()
        LoadConversion()

        If IS_SubProduct Then
            chkSubProducto.Checked = True
        End If
        If Conversion <> 0 Then
            chkUnitMeasure.Checked = True
            cbConversion.SelectedValue = Conversion
        End If

        If chkUnitMeasure.Checked Then
            cbConversion.Enabled = True
        Else
            cbConversion.Enabled = False
            cbConversion.SelectedIndex = -1
        End If

        If FillCBProviders() Then
            filCBUnitMeasure()
            fillcbTypeProduct()
            FillcbCategory()
            FillcbMarca()
        End If
        Select Case OpcionSeleccionada
            Case funcion.Actualizar
                cmdSiguiente.Text = "Guardar"
                GroupBox1.Text = "Actualización de Productos"
                'cbProvider.Enabled = False
                cbProvider.SelectedValue = _ID_Provider
                txtNombreProducto.Text = _ProductoName
                txtDescription.Text = _Description
                txtNumberPurchase.Text = _NumberPurchase
                txtBarCode.Text = _BarCode
                cbTipo.SelectedValue = Id_ProductCondition
                cbUnit.SelectedValue = _ID_Unit
                cbCategory.SelectedValue = _ID_Category
                cbLine.SelectedValue = _ID_Line
                cbMarca.SelectedValue = _ID_Marca
                txtPurchasePrice.Text = _PurchasePrice.ToString("#0.0000")
                txtPrice_Average.Text = _Price_Average.ToString("#0.0000")
                txtPriceSale.Text = _PriceSale.ToString("#0.0000")
                checkIsExempt.Checked = _IsExempt
                chkRecipe.Checked = IS_Recipe
                rb_RawMaterial.Checked = IS_RawMaterial
                rb_Mixed.Checked = IS_Mixed
                rb_FinalProduct.Checked = IS_FinalProduct
                If Not base64String = "" Then
                    pbImage.Image = Base64ToImage(base64String)
                Else
                    pbImage.Image = My.Resources.file
                End If
        End Select
    End Sub




    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        If Not cbCategory.SelectedIndex = -1 Then
            REM  _ID_Line = cbCategory.SelectedValue
            FillcbLine()
        End If
    End Sub


    Private Sub pbImage_Click(sender As Object, e As EventArgs) Handles pbImage.Click
        Dim image As Image
        If openFileDialog.ShowDialog = DialogResult.OK Then
            image = Image.FromFile(openFileDialog.FileName)
            Using m As New MemoryStream()
                image.Save(m, image.RawFormat)
                pbImage.Image = Image.FromFile(openFileDialog.FileName)
                Dim imageBytes As Byte() = m.ToArray()
                base64String = Convert.ToBase64String(imageBytes)
            End Using
        End If
    End Sub

    Private Function ConvertBase64(ByVal image As Image) As String
        Dim resp As String = ""
        Using m As New MemoryStream()
            image.Save(m, image.RawFormat)
            Dim imageBytes As Byte() = m.ToArray()
            resp = Convert.ToBase64String(imageBytes)
        End Using
        Return resp
    End Function

    Private Function Base64ToImage(ByVal base64string As String) As System.Drawing.Image
        Dim img As System.Drawing.Image
        Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
        Dim b64 As String = base64string.Replace(" ", "+")
        Dim b() As Byte
        b = Convert.FromBase64String(b64)
        MS = New System.IO.MemoryStream(b)
        img = System.Drawing.Image.FromStream(MS)
        Return img
    End Function


    Private Sub chkRecipe_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecipe.CheckedChanged
        EnabledRecipe()
    End Sub

    Private Sub EnabledRecipe()
        If chkRecipe.Checked Then
            rb_Mixed.Enabled = False
            rb_RawMaterial.Enabled = False
            rb_FinalProduct.Enabled = False
            rb_Mixed.Checked = False
            rb_RawMaterial.Checked = False
            rb_FinalProduct.Checked = False
        Else
            rb_Mixed.Enabled = True
            rb_RawMaterial.Enabled = True
            rb_FinalProduct.Enabled = True
            rb_FinalProduct.Checked = True
        End If
    End Sub

    Private Sub chkUnitMeasure_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnitMeasure.CheckedChanged
        If chkUnitMeasure.Checked Then
            cbConversion.Enabled = True
        Else
            cbConversion.Enabled = False
            cbConversion.SelectedIndex = -1
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using obj As New precios
            If txtPriceSale.Text.Trim = "" Then
                obj.Precio = 0

            ElseIf Not IsNumeric(txtPriceSale.Text.Trim) Then
                obj.Precio = 0
            Else
                obj.Precio = txtPriceSale.Text.Trim
            End If
            obj.ShowDialog()
            txtPriceSale.Text = obj.Precio.ToString("###0.0000")
        End Using
    End Sub

    Private Sub txtPurchasePrice_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasePrice.TextChanged

    End Sub

    Private Sub txtPurchasePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPurchasePrice.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtPurchasePrice)
            End If
        End Using
    End Sub



    Private Sub txtPrice_Average_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice_Average.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtPrice_Average)
            End If
        End Using
    End Sub

    Private Sub txtPriceSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceSale.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, txtPriceSale)
            End If
        End Using
    End Sub
    Public Event DropDownOpened As EventHandler

    Private abierto As Integer = 1
    Private abierto2 As Integer = 1

    Private Sub cbProvider_DropDown(sender As Object, e As EventArgs) Handles cbProvider.DropDown
        abierto2 = 0
    End Sub

    Private Sub cbProvider_DropDownClosed(sender As Object, e As EventArgs) Handles cbProvider.DropDownClosed
        abierto2 = 1
    End Sub

    Private Sub cbProvider_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProvider.KeyPress
        If (abierto2 = 0) Then
            e.Handled = True
        End If
    End Sub


#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown  ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove  ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp  ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Using objView As New Operacion_Procesos
            objView.tabControl = 5
            objView.StartPosition = FormStartPosition.CenterParent
            objView.ShowDialog()
            '_dtMarca = objSqlOperaciones.GetMarca(Data_Id_Company)
            'cbxMarca.DataSource = _dtMarca
            'cbxMarca.DisplayMember = "Description"
            'cbxMarca.ValueMember = "ID"
            'cbxMarca.SelectedIndex = -1

        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ''''Dim _dtMarca As DataTable
        ''''Using objView As New Operacion_Procesos
        ''''    objView.tabControl = 5
        ''''    objView.StartPosition = FormStartPosition.CenterParent
        ''''    objView.ShowDialog()
        ''''    FillcbMarca()
        ''''End Using


        Using objAdd As New ERP_Mantenimiento_Marcas
            objAdd.Id_Company_FK = _Id_Company
            objAdd.id_Marca = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                FillcbMarca()
            End If
        End Using
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'Using objView As New Operacion_Procesos
        '    objView.tabControl = 6
        '    objView.StartPosition = FormStartPosition.CenterParent
        '    objView.ShowDialog()
        '    FillcbCategory()
        'End Using

        Using objAdd As New ERP_Mantenimiento_Category
            objAdd.Id_Company_FK = _Id_Company
            objAdd.id_Categoria = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                FillcbCategory()
            End If
        End Using
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ''Using objView As New Operacion_Procesos
        ''    objView.tabControl = 7
        ''    objView.StartPosition = FormStartPosition.CenterParent
        ''    objView.ShowDialog()
        ''    FillcbLine()
        ''End Using

        Using objAdd As New ERP_Mantenimiento_Line
            objAdd.Id_Company_FK = _Id_Company
            objAdd.id_Categoria = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                FillcbLine()
            End If
        End Using
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Using objAdd As New ERP_Mantenimiento_MeasureUnit
            objAdd.Id_Company_FK = _Id_Company
            objAdd.id_UnitMeasure = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                filCBUnitMeasure()
            End If
        End Using
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Using Objcreate As New ERP_ClientesCuentasPorCobrar
            'La siget solicito que todo fuera ingreso de proveedores
            Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
                Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
            If Objcreate.ShowDialog() = DialogResult.OK Then
                FillCBProviders()
            End If
        End Using

    End Sub


#End Region
End Class
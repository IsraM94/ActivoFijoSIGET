Imports System.Drawing.Imaging
Imports System.IO

Public Class Financiero_CreaActivoFijo
    Private objSqlGeneric As New Generic_SQLServer
    Private objSql As New Financiero_SQLServer
    Private objSqlHumanResources As New HumanResources_SQLServer
    Private objSqlOperaciones As New Operaciones_SQLServer
    Private _dtCustomerMaster As DataTable
    Private _dtTypeCustomer As DataTable
    Private _dtContactEmploye As DataTable
    Private _dtixedAssetsType As DataTable
    Private _dtixedAssetsType_sub As DataTable
    Private _dtDepreciation As DataTable
    Private _dtLocation As DataTable
    Private _dtEstado As DataTable
    Private _dtMarca As DataTable
    Private _dtModelo As DataTable
    Private _dtColor As DataTable

    Private _dtMaterial As DataTable

    Property Is_Tangible As Boolean = True
    Property Is_Consulta As Boolean = True
    Property rowRegistroActual As DataRow
    Property rowRegistroActual2 As DataRow
    Property ID_Legacy As String = ""
    Private ID_Fixed As Int64
    Private Observations As String
    Property OpcionSeleccionada As Funcion
    Property id_FixedAsset_FK As Long
    Private TableRegSinGuardar As DataTable
    Private numberimage As Integer = 0
    Property id_fixedasset_table As Long = 0
    Property isActualizar As Integer


    Enum Funcion
        Agregar
        Actualizar
    End Enum
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.No
        Close()
    End Sub

    Property base64String As Byte()
    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()

        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function
    Private Function Base64ToImage(ByVal base64string As String) As System.Drawing.Image
        Dim img As System.Drawing.Image
        Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream

        MS = New System.IO.MemoryStream(UnicodeStringToBytes(base64string))
        img = System.Drawing.Image.FromStream(MS)
        Return img
    End Function

    Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function
    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        Dim ofd As New OpenFileDialog
        'ofd.Filter = "IMAGEN JPG | *.jpg |IMAGEN PNG | *.png |Todos | *.*"
        ofd.Filter = "IMAGENES | *.jpg; *.png ; *.jpeg; *.gif; *.diff"
        ofd.Multiselect = True
        If ofd.ShowDialog = DialogResult.OK Then
            ' FLP_Imagenes.Controls.Clear()
            For Each m As String In ofd.FileNames

                Dim mpnl As New Panel
                mpnl.Width = 150
                mpnl.Height = 190

                Dim mPic As New PictureBox
                Try
                    mPic.Image = Image.FromFile(m)
                Catch ex As Exception
                    MessageBox.Show("Fallo de memoria")
                End Try
                mPic.Width = 150
                mPic.Height = 150
                mPic.BorderStyle = BorderStyle.FixedSingle
                mPic.SizeMode = PictureBoxSizeMode.Zoom

                'Para agregar a la base
                Dim picStream As New MemoryStream
                mPic.Image.Save(picStream, ImageFormat.Gif)
                Dim PicByte As Byte() = picStream.ToArray
                '

                mpnl.Controls.Add(mPic)
                mpnl.Name = numberimage
                numberimage = numberimage + 1
                Dim ml As New Label
                ml.AutoSize = True
                ml.Width = 150
                ml.Height = 40
                ml.BorderStyle = BorderStyle.FixedSingle
                ml.Text = (m)
                ml.Location = New Point(0, mPic.Height)
                mpnl.Controls.Add(ml)
                Dim res As Integer = objSql.ERP_FixedAssets_MasterImage_Insert(txtNumeroActivoFijo.Text, PicByte) 'Ingresa una imagen

                FLP_Imagenes.Controls.Add(mpnl)

                AddHandler mPic.Click, AddressOf pbxVistas_Click

            Next
        End If

    End Sub

    Private Sub Menu_Imagenes_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menu_Imagenes.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Vista"
                'vistaImagen(e.mPic)
                Exit Sub
            Case "Eliminar"
                MessageBox.Show("Eliminar")
                pbxVistas_Click(sender, e)
                Exit Sub
            Case "Agregar"
                btnAgregarImagen_Click(sender, e)
                Exit Sub
        End Select
    End Sub

    Dim mPic As PictureBox

    Private Sub pbxVistas_Click(sender As Object, e As EventArgs)

        Using pp As New ERP_VistaImagen
            Try
                pp.imagen.Image = sender.Image
                pp.idFKimage = sender.Name.ToString
                pp.id_FixedAsset_FK = id_fixedasset_table
                pp.ShowDialog()
                llenarFLW()
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Function llenarFLW()
        FLP_Imagenes.Controls.Clear()
        For Each row As DataRow In objSql.ERP_FixedAssets_Masterimage_Select(id_fixedasset_table).Rows

            Dim val As Byte() = (row("Image"))
            'pbImage.Image = Bytes2Image(val)

            Dim mpnl As New Panel
            mpnl.Width = 150
            mpnl.Height = 190

            mPic = New PictureBox
            mPic.Image = Bytes2Image(val)
            mPic.Name = (row("ID_MasterImage"))
            mPic.Width = 150
            mPic.Height = 150
            mPic.ContextMenuStrip = Menu_Imagenes
            mPic.BorderStyle = BorderStyle.FixedSingle
            mPic.SizeMode = PictureBoxSizeMode.Zoom

            Dim ml As New Label
            ml.AutoSize = True
            ml.Width = 150
            ml.Height = 40
            ml.BorderStyle = BorderStyle.FixedSingle
            ml.Text = (row("ID_MasterImage"))
            ml.Location = New Point(0, mPic.Height)

            mpnl.Controls.Add(mPic)

            FLP_Imagenes.Controls.Add(mpnl)

            AddHandler mPic.Click, AddressOf pbxVistas_Click

        Next
    End Function

    Private Sub Financiero_CreaActivoFijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpcionSeleccionada = Funcion.Actualizar Then
            CB_Depreciation.Enabled = False
            cmdSave.Text = "Modificar"
            txtValorResidual.Enabled = False
            'txtBarras.ReadOnly = True
            btnAgregarImagen.Enabled = True
            btnAgregarImagenCamara.Enabled = True
            FLP_Imagenes.Enabled = True
            llenarFLW()

            _dtLocation = objSqlHumanResources.GetLocation(Data_Id_Company)
            CB_Location.DataSource = _dtLocation
            CB_Location.DisplayMember = "Name_Location"
            CB_Location.ValueMember = "Id_Location"

            'pbImage.Image = Base64ToImage(base64String)
        Else
            txtBarras.Text = "Automatico"
            CB_Depreciation.Enabled = False
            cmdSave.Text = "Guardar"
            txtValorResidual.Enabled = True
            txtBarras.Enabled = True
        End If

        Dim dt As New DataTable
        Using obj As New Generic_SQLServer
            dt = obj.SP_ERP_Inventory_GetLocationPrimary()
        End Using
        cmb_UbicaconPrimaria.DataSource = dt
        cmb_UbicaconPrimaria.ValueMember = "ID_Location"
        cmb_UbicaconPrimaria.DisplayMember = "NameLocation"
        cmb_UbicaconPrimaria.SelectedIndex = -1

        _dtCustomerMaster = objSqlGeneric.GetCustomerMaster(Data_Id_Company)
        CB_CustomerMaster.DataSource = _dtCustomerMaster
        CB_CustomerMaster.DisplayMember = "Name_Company"
        CB_CustomerMaster.ValueMember = "Id_Customer"
        CB_CustomerMaster.SelectedIndex = -1

        _dtTypeCustomer = objSqlGeneric.GetTypeCustomer(Data_Id_Company)
        CB_TypeCustomer.DataSource = _dtTypeCustomer
        CB_TypeCustomer.DisplayMember = "DescriptionCustomer"
        CB_TypeCustomer.ValueMember = "Id_TypeCustomer"
        CB_TypeCustomer.SelectedIndex = -1

        _dtContactEmploye = objSqlHumanResources.GetEmploye(Data_Id_Company)
        CB_ContactEmploye.DataSource = _dtContactEmploye
        CB_ContactEmploye.DisplayMember = "Contact"
        CB_ContactEmploye.ValueMember = "Id_employee"
        CB_ContactEmploye.SelectedIndex = -1

        _dtixedAssetsType = objSql.GetFixedAssetsType(Data_Id_Company)
        Dim dtNew As DataTable
        dtNew = _dtixedAssetsType.Clone()
        Dim rows As DataRow()
        If Is_Tangible Then
            rows = _dtixedAssetsType.Select("Is_Tangible='SI'")
        Else
            chkCapitalizable.Visible = False
            chkCapitalizable.Checked = False
            rows = _dtixedAssetsType.Select("Is_Tangible='NO'")
        End If
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        CB_FixedAssetsType.DataSource = dtNew
        CB_FixedAssetsType.DisplayMember = "Name_FixedAssetsType"
        CB_FixedAssetsType.ValueMember = "Id_FixedAssetsType"
        CB_FixedAssetsType.SelectedIndex = -1

        _dtDepreciation = objSqlGeneric.GetDepreciation(Data_Id_Company)
        CB_Depreciation.DataSource = _dtDepreciation
        CB_Depreciation.DisplayMember = "Name_Depreciation"
        CB_Depreciation.ValueMember = "Id_Depreciation"
        'CB_Depreciation.SelectedIndex = -1
        _dtMarca = objSqlOperaciones.GetMarca(Data_Id_Company, "", 1)
        cbxMarca.DataSource = _dtMarca
        cbxMarca.DisplayMember = "Description"
        cbxMarca.ValueMember = "ID"
        cbxMarca.SelectedIndex = -1

        _dtEstado = objSqlHumanResources.GetEstados()
        cmbEstado.DataSource = _dtEstado
        cmbEstado.DisplayMember = "nombreEstado"
        cmbEstado.ValueMember = "id_estado"
        cmbEstado.SelectedIndex = -1

        _dtColor = objSqlHumanResources.GetColor()
        CB_Color.DataSource = _dtColor
        CB_Color.DisplayMember = "color"
        CB_Color.ValueMember = "id_color"
        CB_Color.SelectedIndex = -1


        _dtMaterial = objSqlHumanResources.GetMaterials()
        CB_Material.DataSource = _dtMaterial
        CB_Material.DisplayMember = "material"
        CB_Material.ValueMember = "id_material"
        CB_Material.SelectedIndex = -1
        If Not rowRegistroActual Is Nothing Then
            ' Poner datos de registro a modificar
            Try
                id_fixedasset_table = Long.Parse(rowRegistroActual.Item(0).ToString)
                txtNumeroActivoFijo.Text = rowRegistroActual.Item(0).ToString
                txtBarras.Text = rowRegistroActual.Item("Number_Purchase")
                txtNameActive.Text = rowRegistroActual.Item("Name_FiexdAssets")
                llenarFLW()
                Try
                    chkCapitalizable.Checked = Convert.ToBoolean(rowRegistroActual.Item("Capitalizable"))
                Catch ex2 As Exception
                    chkCapitalizable.Checked = False
                End Try
                txtDescription.Text = rowRegistroActual.Item("Description").ToString
                CB_CustomerMaster.SelectedValue = rowRegistroActual.Item("ID_Provider_FK").ToString
                CB_TypeCustomer.SelectedValue = rowRegistroActual.Item("Id_TypeCustomerCustomer_FK").ToString
                CB_ContactEmploye.SelectedValue = rowRegistroActual.Item("Id_ResponsiblePerson_FK").ToString
                CB_FixedAssetsType.SelectedValue = rowRegistroActual.Item("Id_FixedAssetsType").ToString
                cmb_UbicaconPrimaria.SelectedValue = rowRegistroActual.Item("Id_LocationPrimary").ToString
            Catch ex As Exception

            End Try

            Try
                CB_Color.SelectedValue = rowRegistroActual.Item("color")
            Catch ex As Exception
                CB_Color.SelectedValue = -1
            End Try
            Try
                CB_Material.SelectedValue = rowRegistroActual.Item("material")
            Catch ex As Exception
                CB_Material.SelectedValue = -1
            End Try
            Try
                txtNoFactura.Text = rowRegistroActual.Item("Invoice_numbers")
            Catch ex As Exception
                Try
                    txtNoFactura.Text = rowRegistroActual.Item("numero_documento_compra")
                Catch ex2 As Exception
                    txtNoFactura.Text = ""
                End Try
            End Try

            cmbEstado.SelectedValue = rowRegistroActual.Item("id_estado_FK")

            If rowRegistroActual.Table.Columns.Contains("ID_FixedAssets_Sub") Then
                LlenaCbxSub(Data_Id_Company, IIf(rowRegistroActual.Item("Id_FixedAssetsType").ToString = "", 0, rowRegistroActual.Item("Id_FixedAssetsType")))
                CB_FixedAssetsType_Sub.SelectedValue = rowRegistroActual.Item("ID_FixedAssets_Sub")
            End If
            DTP_DateFactura.Value = rowRegistroActual.Item("Date_Acquisition")
            CB_Depreciation.SelectedValue = rowRegistroActual.Item("Id_Depreciation_FK")
            CB_Location.SelectedValue = rowRegistroActual.Item("Id_Location_FK")
            ID_Fixed = IIf(rowRegistroActual.Item("Id_FixedAssetsType").ToString = "", 0, rowRegistroActual.Item("Id_FixedAssetsType"))
            txtValorResidual.Text = rowRegistroActual.Item("ResidualValue")
            Try
                txtObservaciones.Text = rowRegistroActual.Item("Observations")
            Catch ex As Exception
                txtObservaciones.Text = ""
            End Try
            Try
                txtValorFactura.Text = Convert.ToDecimal(rowRegistroActual.Item("Amount_Acquired")).ToString("N")
            Catch ex As Exception
                txtValorFactura.Text = ""
            End Try
            cbxMarca.SelectedValue = rowRegistroActual.Item("ID_Marca")
            If Not cbxMarca.SelectedValue Is Nothing Then
                LlenaCbxModelo(_ID_Company, rowRegistroActual.Item("ID_Marca"))
            End If

            cbxModelo.SelectedValue = rowRegistroActual.Item("ID_Modelo")
            txtSerie.Text = rowRegistroActual.Item("Numero_Serie").ToString()
            Try
                ID_Legacy = rowRegistroActual.Item("ID_Legacy")
            Catch ex As Exception
                ID_Legacy = ""
            End Try

        End If
        cmdSave.Enabled = True
        If Not Is_Consulta Then
            cmdSave.Enabled = False
        End If


    End Sub
    Private _Respuesta As String
    Public ReadOnly Property Respuesta() As String
        Get
            Return _Respuesta
        End Get
    End Property
    Public Sub NumerosyDecimal(ByVal CajaTexto As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Shared Function ConvertImageToByteArray(ByVal imageIn As System.Drawing.Image) As Byte()
        Dim ms As New IO.MemoryStream()
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Return ms.ToArray()
    End Function

    Public Shared Function ConvertByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New IO.MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resp As String
        'If txtBarras.Text.Trim = "" Then
        '    MessageBox.Show("Ingresa el codigo de barra")
        '    txtBarras.Focus()
        '    Exit Sub
        'End If
        If txtNameActive.Text.Trim = "" Then
            MessageBox.Show("Ingresa nombre activo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            txtNameActive.Focus()
            Exit Sub
        End If
        If txtDescription.Text.Trim = "" Then
            MessageBox.Show("Ingresa una descripción", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)


            txtDescription.Focus()
            Exit Sub
        End If


        If CB_CustomerMaster.SelectedIndex = -1 Then

            MessageBox.Show("Seleccione un Proveedor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            CB_CustomerMaster.Focus()
            Exit Sub
        End If
        If CB_TypeCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de pago", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)


            CB_TypeCustomer.Focus()
            Exit Sub
        End If

        If txtValorFactura.Text.Trim = "" Then
            MessageBox.Show("Ingresa una valor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtValorFactura.Focus()
            Exit Sub
        End If

        If CB_Location.SelectedIndex = -1 Then
            MessageBox.Show("Ingresa una ubicación Secundaria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)


            CB_Location.Focus()
            Exit Sub
        End If

        If CB_ContactEmploye.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un empleado responsable", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            CB_ContactEmploye.Focus()
            Exit Sub
        End If



        If CB_FixedAssetsType.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un tipo de activo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            CB_FixedAssetsType.Focus()
            Exit Sub
        End If

        If (Is_Tangible) Then
            If CB_FixedAssetsType_Sub.SelectedIndex = -1 Then
                MessageBox.Show("Selecciona un Sub Tipo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

                CB_FixedAssetsType_Sub.Focus()
                Exit Sub
            End If
        End If
        If cbxMarca.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona una Marca", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)


            cbxMarca.Focus()
            Exit Sub
        End If

        If cbxModelo.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un Modelo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            cbxModelo.Focus()
            Exit Sub
        End If

        If cmbEstado.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un Sub Estado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbEstado.Focus()
            Exit Sub
        End If

        If CB_Color.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un Color", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            CB_Color.Focus()
            Exit Sub
        End If

        If CB_Material.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un Material", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            CB_Material.Focus()
            Exit Sub
        End If


        If txtValorResidual.Text.Trim <> "" Then
            resp = objSql.SetFixedAssets_Master_Insert(Data_Id_Company, CB_CustomerMaster.SelectedValue, CB_TypeCustomer.SelectedValue,
                                                                 CB_Depreciation.SelectedValue, CB_Location.SelectedValue, CB_ContactEmploye.SelectedValue,
                                                                 txtNameActive.Text, txtDescription.Text, txtBarras.Text, DTP_DateFactura.Value,
                                                                 txtValorResidual.Text, txtValorFactura.Text, CB_FixedAssetsType_Sub.SelectedValue, CB_FixedAssetsType.SelectedValue,
                                                                 cbxMarca.SelectedValue, cbxModelo.SelectedValue, txtSerie.Text, ID_Legacy,
                                                                 txtObservaciones.Text, cmbEstado.SelectedValue, CB_Color.SelectedValue,
                                                                 CB_Material.SelectedValue, txtNoFactura.Text, chkCapitalizable.Checked)
            Dim resp1() As String = resp.Split("|")
            If resp1(0) = "OK" Then
                If ID_Fixed = 0 Then
                    If Not TableRegSinGuardar Is Nothing Then
                        For Each row As DataRow In TableRegSinGuardar.Rows
                            objSqlGeneric.GetERP_FixedAssets_SP_SetType_Define(row("Etiqueta"), row("ID_Type"), row("Informacion"), CB_FixedAssetsType.SelectedValue, resp1(1))
                        Next
                    End If

                End If
                MessageBox.Show("El registro se guardó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
            Else
                ' Verificar el error Fabio
                MessageBox.Show("Error al ingresar el registro, por favor intente de nuevo o llamar a Soporte Técnico", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Falta valor residual", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            txtValorResidual.Focus()
            resp = ""
        End If

        _Respuesta = resp

        REM MessageBox.Show(String.Format("Registros {0}", resp))

    End Sub

    Private Sub cmdEspecificaciones_Click(sender As Object, e As EventArgs) Handles cmdEspecificaciones.Click
        If Not CB_FixedAssetsType.SelectedValue - 1 Then
            Dim objEspecificacion As New Financiero_CreaActivoFijo_Especificacion()
            objEspecificacion.ID_FixedType = CB_FixedAssetsType.SelectedValue
            objEspecificacion.ID_Fixed = txtNumeroActivoFijo.Text
            If Not TableRegSinGuardar Is Nothing Then
                objEspecificacion.TableRegSinGuardar = TableRegSinGuardar
            End If
            If objEspecificacion.ShowDialog() = DialogResult.OK Then
                If ID_Fixed = 0 Then
                    TableRegSinGuardar = objEspecificacion.TableRegSinGuardar
                End If
            End If

        Else
            MessageBox.Show("Tiene que seleccionar un tipo de activo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub CB_FixedAssetsType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FixedAssetsType.SelectedIndexChanged
        If Not CB_FixedAssetsType.ValueMember = "" Then
            LlenaCbxSub(Data_Id_Company, sender.SelectedValue)
        End If
    End Sub

    Private Sub LlenaCbxSub(ByVal id_Company As Long, FixedAssetsType As Int64)


        If Not CB_FixedAssetsType.ValueMember = "" Then
            _dtixedAssetsType_sub = objSql.GetFixedAssetsType_Sub(Data_Id_Company, CB_FixedAssetsType.SelectedValue)
            If _dtixedAssetsType_sub.Rows.Count > 0 Then
                CB_FixedAssetsType_Sub.Enabled = True
                CB_FixedAssetsType_Sub.SelectedIndex = -1
            Else
                CB_FixedAssetsType_Sub.Enabled = False
                CB_FixedAssetsType_Sub.Text = "Sin tipo"
                CB_FixedAssetsType_Sub.SelectedIndex = -1
            End If
            CB_FixedAssetsType_Sub.DataSource = _dtixedAssetsType_sub
            CB_FixedAssetsType_Sub.ValueMember = "Id_FixedAssetsType_Sub"
            CB_FixedAssetsType_Sub.DisplayMember = "Name_FixedAssetsType"
            CB_FixedAssetsType_Sub.SelectedIndex = -1
            CB_FixedAssetsType_Sub.Text = String.Empty
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBarras.Text.Trim <> "" And txtBarras.Text.ToString <> "Automatico" Then
            Dim objCodeBarCLS As New clsCodeBarImpr
            objCodeBarCLS.codeBarValue = txtBarras.Text
            objCodeBarCLS.Print()

        Else
            MessageBox.Show("Falta Código de barras", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtBarras.Focus()
        End If
        'Dim dsCodeBar As New dsCodeBar.CodeBarDataTable


        '    Dim reg As dsCodeBar.CodeBarRow = dsCodeBar.NewCodeBarRow
        'reg.Code = txtBarras.Text
        'reg.ID_Code = txtBarras.Text
        'dsCodeBar.Rows.Add(reg)

        'Dim objCodeBar As New frmViCodeBar
        'objCodeBar.DT_CodeBar = dsCodeBar
        'PictureBox1.Image = objCodeBar.CodeBar
        'objCodeBar.ShowDialog()




    End Sub

    Private Sub cbxMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMarca.SelectedIndexChanged
        If Not cbxMarca.ValueMember = "" Then
            LlenaCbxModelo(Data_Id_Company, cbxMarca.SelectedValue)
        End If
    End Sub

    Private Sub LlenaCbxModelo(ByVal id_Company As Long, ID_Marca As Integer)


        If Not CB_FixedAssetsType.ValueMember = "" Then
            _dtModelo = objSqlOperaciones.GetModelo(Data_Id_Company, ID_Marca)
            cbxModelo.DataSource = _dtModelo
            cbxModelo.ValueMember = "ID"
            cbxModelo.DisplayMember = "Description"
            cbxModelo.SelectedIndex = -1
            cbxModelo.Text = String.Empty
        End If
    End Sub

    Private Sub txtValorFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorFactura.KeyPress
        'NumerosyDecimal(txtValorFactura, e)

        Dim tb As TextBox = DirectCast(sender, TextBox)


        Dim separadorDecimal As String =
           Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return

            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse
                  ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    tb.SelectedText = "0"
                End If

                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If

        If (Convert.ToInt32(e.KeyChar) = 8) Then
            Return


        ElseIf (e.KeyChar = "-"c) Then

            If (tb.SelectionLength = 0) Then

                If (tb.Text.IndexOf("-"c) >= 0) Then
                    e.Handled = True
                    Return
                End If


                e.Handled = (tb.SelectionStart <> 0)
            End If

        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then

            e.Handled = True
            Return

        End If

        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If


        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub

    Private Sub txtValorResidual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorResidual.KeyPress
        NumerosyDecimal(txtValorResidual, e)
    End Sub

    Private Sub txtBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarras.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAgregarImagenCamara_Click(sender As Object, e As EventArgs) Handles btnAgregarImagenCamara.Click
        ''ABRIR ERP_Camara
        Try
            Using pp As New ERP_Camara
                pp.id_FixedAsset_FK = id_fixedasset_table
                pp.ShowDialog()
                llenarFLW()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error, verifique que tiene una cámara instalada en su computadora", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Using objAdd As New ERP_Mantenimiento_Marcas
            objAdd.Id_Company_FK = _ID_Company
            objAdd.id_Marca = 0
            If objAdd.ShowDialog() = DialogResult.OK Then
                _dtMarca = objSqlOperaciones.GetMarca(Data_Id_Company)
                cbxMarca.DataSource = _dtMarca
                cbxMarca.DisplayMember = "Description"
                cbxMarca.ValueMember = "ID"
                cbxMarca.SelectedIndex = -1
            End If
        End Using
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Using objAdd As New ERP_Inventary_Modelo

            If objAdd.ShowDialog() = DialogResult.OK Then
                LlenaCbxModelo(Data_Id_Company, cbxMarca.SelectedValue)
            End If
        End Using

    End Sub

    Private Sub txtValorFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorFactura.KeyDown

    End Sub

    Private Sub txtValorFactura_TextChanged(sender As Object, e As EventArgs) Handles txtValorFactura.TextChanged
        Dim valRes As Double
        Try
            valRes = CDbl(txtValorFactura.Text) * 0.1
        Catch ex As Exception
            valRes = 0
        End Try

        txtValorResidual.Text = valRes
    End Sub
    Public Event DropDownOpened As EventHandler

    Private abierto As Integer = 1
    Private abierto2 As Integer = 1
    Private Sub cbxMarca_DropDown(sender As Object, e As EventArgs) Handles cbxMarca.DropDown
        abierto = 0
    End Sub

    Private Sub cbxMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxMarca.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxMarca_DropDownClosed(sender As Object, e As EventArgs) Handles cbxMarca.DropDownClosed
        abierto = 1
    End Sub

    Private Sub cbxModelo_DropDown(sender As Object, e As EventArgs) Handles cbxModelo.DropDown
        abierto2 = 0
    End Sub

    Private Sub cbxModelo_DropDownClosed(sender As Object, e As EventArgs) Handles cbxModelo.DropDownClosed
        abierto2 = 1
    End Sub

    Private Sub cbxModelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxModelo.KeyPress
        If (abierto2 = 0) Then
            e.Handled = True
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


    Private Sub cmb_UbicaconPrimaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_UbicaconPrimaria.SelectedIndexChanged
        Try
            CB_Location.SelectedIndex = -1
            CB_Location.Items.Clear()

        Catch ex As Exception

        End Try
        Try
            If (cmb_UbicaconPrimaria.SelectedIndex >= 0) Then

                _dtLocation = objSqlHumanResources.GetLocationByPrimary(Data_Id_Company, cmb_UbicaconPrimaria.SelectedValue)
                CB_Location.DataSource = _dtLocation
                CB_Location.DisplayMember = "Name_Location"
                CB_Location.ValueMember = "Id_Location"
                CB_Location.SelectedIndex = -1
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Using Objcreate As New ERP_ClientesCuentasPorCobrar
            'La siget solicito que todo fuera ingreso de proveedores
            Objcreate.TipoConsulta = ERP_ClientesCuentasPorCobrar.Proceso.Proveedores
            Objcreate.OpcionSeleccionada = ERP_ClientesCuentasPorCobrar.Funcion.Agregar
            If Objcreate.ShowDialog() = DialogResult.OK Then
                Try
                    _dtCustomerMaster = objSqlGeneric.GetCustomerMaster(Data_Id_Company)
                    CB_CustomerMaster.DataSource = _dtCustomerMaster
                    CB_CustomerMaster.DisplayMember = "Name_Company"
                    CB_CustomerMaster.ValueMember = "Id_Customer"
                    CB_CustomerMaster.SelectedIndex = -1
                Catch ex As Exception

                End Try
            End If
        End Using
    End Sub
#End Region

End Class
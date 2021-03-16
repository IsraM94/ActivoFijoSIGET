<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Financiero_CreaActivoFijo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Menu_Imagenes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CB_Depreciation = New System.Windows.Forms.ComboBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.label50 = New System.Windows.Forms.Label()
        Me.txtNumeroActivoFijo = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNameActive = New System.Windows.Forms.TextBox()
        Me.CB_CustomerMaster = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoFactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorFactura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_TypeCustomer = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_Location = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_ContactEmploye = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorResidual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBarras = New System.Windows.Forms.TextBox()
        Me.FLP_Imagenes = New System.Windows.Forms.FlowLayoutPanel()
        Me.CB_FixedAssetsType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdEspecificaciones = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTP_DateFactura = New System.Windows.Forms.DateTimePicker()
        Me.CB_FixedAssetsType_Sub = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxModelo = New System.Windows.Forms.ComboBox()
        Me.cbxMarca = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btnAgregarImagen = New System.Windows.Forms.Button()
        Me.btnAgregarImagenCamara = New System.Windows.Forms.Button()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_Color = New System.Windows.Forms.ComboBox()
        Me.CB_Material = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.cmb_UbicaconPrimaria = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkCapitalizable = New System.Windows.Forms.CheckBox()
        Me.Menu_Imagenes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_Imagenes
        '
        Me.Menu_Imagenes.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu_Imagenes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.VistaToolStripMenuItem, Me.AdicionarToolStripMenuItem})
        Me.Menu_Imagenes.Name = "Menu_Imagenes"
        Me.Menu_Imagenes.Size = New System.Drawing.Size(118, 70)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'VistaToolStripMenuItem
        '
        Me.VistaToolStripMenuItem.Name = "VistaToolStripMenuItem"
        Me.VistaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.VistaToolStripMenuItem.Text = "Vista"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AdicionarToolStripMenuItem.Text = "Agregar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = " "
        '
        'CB_Depreciation
        '
        Me.CB_Depreciation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Depreciation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Depreciation.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Depreciation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Depreciation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Depreciation.FormattingEnabled = True
        Me.CB_Depreciation.Location = New System.Drawing.Point(166, 330)
        Me.CB_Depreciation.Name = "CB_Depreciation"
        Me.CB_Depreciation.Size = New System.Drawing.Size(351, 29)
        Me.CB_Depreciation.TabIndex = 13
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(11, 333)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(145, 21)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Tipo Depreciación : "
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.label50.Location = New System.Drawing.Point(642, 29)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(54, 25)
        Me.label50.TabIndex = 19
        Me.label50.Text = "No.  :"
        '
        'txtNumeroActivoFijo
        '
        Me.txtNumeroActivoFijo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumeroActivoFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumeroActivoFijo.Enabled = False
        Me.txtNumeroActivoFijo.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtNumeroActivoFijo.Location = New System.Drawing.Point(699, 27)
        Me.txtNumeroActivoFijo.Name = "txtNumeroActivoFijo"
        Me.txtNumeroActivoFijo.Size = New System.Drawing.Size(202, 24)
        Me.txtNumeroActivoFijo.TabIndex = 2
        Me.txtNumeroActivoFijo.Text = "0"
        Me.txtNumeroActivoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(562, 709)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 26
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(702, 710)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nombre Activo :"
        '
        'txtNameActive
        '
        Me.txtNameActive.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNameActive.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameActive.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtNameActive.Location = New System.Drawing.Point(166, 59)
        Me.txtNameActive.MaxLength = 200
        Me.txtNameActive.Name = "txtNameActive"
        Me.txtNameActive.Size = New System.Drawing.Size(740, 24)
        Me.txtNameActive.TabIndex = 3
        '
        'CB_CustomerMaster
        '
        Me.CB_CustomerMaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_CustomerMaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_CustomerMaster.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_CustomerMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_CustomerMaster.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_CustomerMaster.FormattingEnabled = True
        Me.CB_CustomerMaster.Location = New System.Drawing.Point(166, 132)
        Me.CB_CustomerMaster.Name = "CB_CustomerMaster"
        Me.CB_CustomerMaster.Size = New System.Drawing.Size(358, 33)
        Me.CB_CustomerMaster.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label4.Location = New System.Drawing.Point(40, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Descripción :"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtDescription.Location = New System.Drawing.Point(167, 89)
        Me.txtDescription.MaxLength = 300
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(739, 37)
        Me.txtDescription.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label5.Location = New System.Drawing.Point(46, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "No. Factura :"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNoFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoFactura.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtNoFactura.Location = New System.Drawing.Point(167, 170)
        Me.txtNoFactura.MaxLength = 50
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(119, 24)
        Me.txtNoFactura.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label6.Location = New System.Drawing.Point(294, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 25)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Valor :"
        '
        'txtValorFactura
        '
        Me.txtValorFactura.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValorFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorFactura.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtValorFactura.Location = New System.Drawing.Point(366, 170)
        Me.txtValorFactura.MaxLength = 9
        Me.txtValorFactura.Name = "txtValorFactura"
        Me.txtValorFactura.Size = New System.Drawing.Size(123, 24)
        Me.txtValorFactura.TabIndex = 8
        Me.txtValorFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label7.Location = New System.Drawing.Point(600, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 25)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Fecha Factura :"
        '
        'CB_TypeCustomer
        '
        Me.CB_TypeCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_TypeCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_TypeCustomer.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_TypeCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TypeCustomer.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_TypeCustomer.FormattingEnabled = True
        Me.CB_TypeCustomer.Location = New System.Drawing.Point(699, 133)
        Me.CB_TypeCustomer.Name = "CB_TypeCustomer"
        Me.CB_TypeCustomer.Size = New System.Drawing.Size(207, 33)
        Me.CB_TypeCustomer.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label8.Location = New System.Drawing.Point(637, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 25)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Tipo : "
        '
        'CB_Location
        '
        Me.CB_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Location.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Location.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_Location.FormattingEnabled = True
        Me.CB_Location.Location = New System.Drawing.Point(167, 244)
        Me.CB_Location.Name = "CB_Location"
        Me.CB_Location.Size = New System.Drawing.Size(740, 33)
        Me.CB_Location.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(23, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 25)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Ubicación Sec : "
        '
        'CB_ContactEmploye
        '
        Me.CB_ContactEmploye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_ContactEmploye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_ContactEmploye.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_ContactEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ContactEmploye.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_ContactEmploye.FormattingEnabled = True
        Me.CB_ContactEmploye.Location = New System.Drawing.Point(166, 283)
        Me.CB_ContactEmploye.Name = "CB_ContactEmploye"
        Me.CB_ContactEmploye.Size = New System.Drawing.Size(740, 33)
        Me.CB_ContactEmploye.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label10.Location = New System.Drawing.Point(30, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 25)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Responsable : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label1.Location = New System.Drawing.Point(565, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Valor Residual :"
        '
        'txtValorResidual
        '
        Me.txtValorResidual.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValorResidual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorResidual.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtValorResidual.Location = New System.Drawing.Point(702, 322)
        Me.txtValorResidual.Name = "txtValorResidual"
        Me.txtValorResidual.Size = New System.Drawing.Size(204, 24)
        Me.txtValorResidual.TabIndex = 14
        Me.txtValorResidual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label12.Location = New System.Drawing.Point(28, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 25)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Código Barra :"
        '
        'txtBarras
        '
        Me.txtBarras.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBarras.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtBarras.Location = New System.Drawing.Point(168, 27)
        Me.txtBarras.MaxLength = 20
        Me.txtBarras.Name = "txtBarras"
        Me.txtBarras.ReadOnly = True
        Me.txtBarras.Size = New System.Drawing.Size(272, 24)
        Me.txtBarras.TabIndex = 1
        '
        'FLP_Imagenes
        '
        Me.FLP_Imagenes.AutoScroll = True
        Me.FLP_Imagenes.BackColor = System.Drawing.Color.White
        Me.FLP_Imagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FLP_Imagenes.Enabled = False
        Me.FLP_Imagenes.Location = New System.Drawing.Point(165, 601)
        Me.FLP_Imagenes.Name = "FLP_Imagenes"
        Me.FLP_Imagenes.Size = New System.Drawing.Size(736, 88)
        Me.FLP_Imagenes.TabIndex = 24
        '
        'CB_FixedAssetsType
        '
        Me.CB_FixedAssetsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_FixedAssetsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_FixedAssetsType.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_FixedAssetsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FixedAssetsType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FixedAssetsType.FormattingEnabled = True
        Me.CB_FixedAssetsType.Location = New System.Drawing.Point(165, 365)
        Me.CB_FixedAssetsType.Name = "CB_FixedAssetsType"
        Me.CB_FixedAssetsType.Size = New System.Drawing.Size(351, 29)
        Me.CB_FixedAssetsType.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(57, 365)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 21)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Tipo Activo : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 601)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 21)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Imágenes Activo : "
        '
        'cmdEspecificaciones
        '
        Me.cmdEspecificaciones.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdEspecificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEspecificaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdEspecificaciones.Location = New System.Drawing.Point(605, 397)
        Me.cmdEspecificaciones.Name = "cmdEspecificaciones"
        Me.cmdEspecificaciones.Size = New System.Drawing.Size(299, 30)
        Me.cmdEspecificaciones.TabIndex = 25
        Me.cmdEspecificaciones.Text = "Especificaciones"
        Me.cmdEspecificaciones.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(605, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(299, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Imprimir Código Barra"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DTP_DateFactura
        '
        Me.DTP_DateFactura.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DateFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DateFactura.Location = New System.Drawing.Point(728, 171)
        Me.DTP_DateFactura.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTP_DateFactura.Name = "DTP_DateFactura"
        Me.DTP_DateFactura.Size = New System.Drawing.Size(178, 27)
        Me.DTP_DateFactura.TabIndex = 9
        '
        'CB_FixedAssetsType_Sub
        '
        Me.CB_FixedAssetsType_Sub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_FixedAssetsType_Sub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_FixedAssetsType_Sub.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_FixedAssetsType_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FixedAssetsType_Sub.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FixedAssetsType_Sub.FormattingEnabled = True
        Me.CB_FixedAssetsType_Sub.Location = New System.Drawing.Point(165, 400)
        Me.CB_FixedAssetsType_Sub.Name = "CB_FixedAssetsType_Sub"
        Me.CB_FixedAssetsType_Sub.Size = New System.Drawing.Size(351, 29)
        Me.CB_FixedAssetsType_Sub.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 21)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Sub Tipo Activo : "
        '
        'cbxModelo
        '
        Me.cbxModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxModelo.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxModelo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModelo.FormattingEnabled = True
        Me.cbxModelo.Location = New System.Drawing.Point(605, 439)
        Me.cbxModelo.Name = "cbxModelo"
        Me.cbxModelo.Size = New System.Drawing.Size(301, 29)
        Me.cbxModelo.TabIndex = 18
        '
        'cbxMarca
        '
        Me.cbxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxMarca.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMarca.FormattingEnabled = True
        Me.cbxMarca.Location = New System.Drawing.Point(165, 439)
        Me.cbxMarca.Name = "cbxMarca"
        Me.cbxMarca.Size = New System.Drawing.Size(351, 29)
        Me.cbxMarca.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label17.Location = New System.Drawing.Point(19, 707)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(154, 25)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Número de Serie :"
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerie.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtSerie.Location = New System.Drawing.Point(174, 710)
        Me.txtSerie.MaxLength = 60
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(347, 24)
        Me.txtSerie.TabIndex = 25
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(29, 480)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 21)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.Gainsboro
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtObservaciones.Location = New System.Drawing.Point(165, 477)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(739, 37)
        Me.txtObservaciones.TabIndex = 19
        '
        'btnAgregarImagen
        '
        Me.btnAgregarImagen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarImagen.Enabled = False
        Me.btnAgregarImagen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAgregarImagen.FlatAppearance.BorderSize = 0
        Me.btnAgregarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarImagen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarImagen.Location = New System.Drawing.Point(18, 625)
        Me.btnAgregarImagen.Name = "btnAgregarImagen"
        Me.btnAgregarImagen.Size = New System.Drawing.Size(128, 29)
        Me.btnAgregarImagen.TabIndex = 22
        Me.btnAgregarImagen.Text = "Agregar"
        Me.btnAgregarImagen.UseVisualStyleBackColor = False
        '
        'btnAgregarImagenCamara
        '
        Me.btnAgregarImagenCamara.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarImagenCamara.Enabled = False
        Me.btnAgregarImagenCamara.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAgregarImagenCamara.FlatAppearance.BorderSize = 0
        Me.btnAgregarImagenCamara.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarImagenCamara.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarImagenCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarImagenCamara.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarImagenCamara.Location = New System.Drawing.Point(18, 660)
        Me.btnAgregarImagenCamara.Name = "btnAgregarImagenCamara"
        Me.btnAgregarImagenCamara.Size = New System.Drawing.Size(129, 29)
        Me.btnAgregarImagenCamara.TabIndex = 23
        Me.btnAgregarImagenCamara.Text = "Camara"
        Me.btnAgregarImagenCamara.UseVisualStyleBackColor = False
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstado.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(165, 520)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(359, 29)
        Me.cmbEstado.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(84, 520)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 21)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Estado : "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(82, 439)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 24)
        Me.LinkLabel1.TabIndex = 77
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Marca: "
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(522, 439)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(84, 24)
        Me.LinkLabel2.TabIndex = 78
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Modelo: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label15.Location = New System.Drawing.Point(85, 558)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 25)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Color : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label16.Location = New System.Drawing.Point(547, 554)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 25)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Material :"
        '
        'CB_Color
        '
        Me.CB_Color.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Color.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Color.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Color.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Color.FormattingEnabled = True
        Me.CB_Color.Location = New System.Drawing.Point(165, 558)
        Me.CB_Color.Name = "CB_Color"
        Me.CB_Color.Size = New System.Drawing.Size(359, 29)
        Me.CB_Color.TabIndex = 22
        '
        'CB_Material
        '
        Me.CB_Material.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Material.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Material.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Material.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Material.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Material.FormattingEnabled = True
        Me.CB_Material.Location = New System.Drawing.Point(628, 554)
        Me.CB_Material.Name = "CB_Material"
        Me.CB_Material.Size = New System.Drawing.Size(279, 29)
        Me.CB_Material.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.LinkLabel5)
        Me.GroupBox1.Controls.Add(Me.cmb_UbicaconPrimaria)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.chkCapitalizable)
        Me.GroupBox1.Controls.Add(Me.CB_Material)
        Me.GroupBox1.Controls.Add(Me.CB_Color)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.btnAgregarImagenCamara)
        Me.GroupBox1.Controls.Add(Me.btnAgregarImagen)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtSerie)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cbxMarca)
        Me.GroupBox1.Controls.Add(Me.cbxModelo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CB_FixedAssetsType_Sub)
        Me.GroupBox1.Controls.Add(Me.DTP_DateFactura)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdEspecificaciones)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CB_FixedAssetsType)
        Me.GroupBox1.Controls.Add(Me.FLP_Imagenes)
        Me.GroupBox1.Controls.Add(Me.txtBarras)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtValorResidual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CB_ContactEmploye)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CB_Location)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CB_TypeCustomer)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtValorFactura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNoFactura)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CB_CustomerMaster)
        Me.GroupBox1.Controls.Add(Me.txtNameActive)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtNumeroActivoFijo)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.CB_Depreciation)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 761)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activo Fijo"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(28, 135)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(127, 25)
        Me.LinkLabel5.TabIndex = 102
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Proveedor:"
        '
        'cmb_UbicaconPrimaria
        '
        Me.cmb_UbicaconPrimaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconPrimaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconPrimaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconPrimaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_UbicaconPrimaria.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmb_UbicaconPrimaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconPrimaria.FormattingEnabled = True
        Me.cmb_UbicaconPrimaria.Location = New System.Drawing.Point(167, 203)
        Me.cmb_UbicaconPrimaria.Name = "cmb_UbicaconPrimaria"
        Me.cmb_UbicaconPrimaria.Size = New System.Drawing.Size(740, 33)
        Me.cmb_UbicaconPrimaria.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label20.Location = New System.Drawing.Point(14, 213)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 25)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Ubicación Prim : "
        '
        'chkCapitalizable
        '
        Me.chkCapitalizable.AutoSize = True
        Me.chkCapitalizable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCapitalizable.Location = New System.Drawing.Point(553, 522)
        Me.chkCapitalizable.Name = "chkCapitalizable"
        Me.chkCapitalizable.Size = New System.Drawing.Size(117, 25)
        Me.chkCapitalizable.TabIndex = 21
        Me.chkCapitalizable.Text = "Capitalizable"
        Me.chkCapitalizable.UseVisualStyleBackColor = True
        '
        'Financiero_CreaActivoFijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(945, 785)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Financiero_CreaActivoFijo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financiero_CreaActivoFijo"
        Me.Menu_Imagenes.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Menu_Imagenes As ContextMenuStrip
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Private WithEvents CB_Depreciation As ComboBox
    Private WithEvents label49 As Label
    Private WithEvents label50 As Label
    Private WithEvents txtNumeroActivoFijo As TextBox
    Private WithEvents cmdSave As Button
    Private WithEvents cmdCancel As Button
    Private WithEvents Label2 As Label
    Private WithEvents txtNameActive As TextBox
    Private WithEvents CB_CustomerMaster As ComboBox
    Private WithEvents Label4 As Label
    Private WithEvents txtDescription As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents txtNoFactura As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents txtValorFactura As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents CB_TypeCustomer As ComboBox
    Private WithEvents Label8 As Label
    Private WithEvents CB_Location As ComboBox
    Private WithEvents Label9 As Label
    Private WithEvents CB_ContactEmploye As ComboBox
    Private WithEvents Label10 As Label
    Private WithEvents Label1 As Label
    Private WithEvents txtValorResidual As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtBarras As TextBox
    Friend WithEvents FLP_Imagenes As FlowLayoutPanel
    Private WithEvents CB_FixedAssetsType As ComboBox
    Private WithEvents Label13 As Label
    Private WithEvents Label11 As Label
    Friend WithEvents cmdEspecificaciones As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DTP_DateFactura As DateTimePicker
    Private WithEvents CB_FixedAssetsType_Sub As ComboBox
    Private WithEvents Label14 As Label
    Private WithEvents cbxModelo As ComboBox
    Private WithEvents cbxMarca As ComboBox
    Private WithEvents Label17 As Label
    Private WithEvents txtSerie As TextBox
    Private WithEvents Label18 As Label
    Private WithEvents txtObservaciones As TextBox
    Private WithEvents btnAgregarImagen As Button
    Private WithEvents btnAgregarImagenCamara As Button
    Private WithEvents cmbEstado As ComboBox
    Private WithEvents Label19 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Private WithEvents Label15 As Label
    Private WithEvents Label16 As Label
    Private WithEvents CB_Color As ComboBox
    Private WithEvents CB_Material As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCapitalizable As CheckBox
    Private WithEvents Label20 As Label
    Friend WithEvents cmb_UbicaconPrimaria As ComboBox
    Friend WithEvents LinkLabel5 As LinkLabel
End Class

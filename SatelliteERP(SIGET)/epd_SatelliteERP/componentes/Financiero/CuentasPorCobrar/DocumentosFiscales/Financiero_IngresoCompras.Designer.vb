<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_IngresoCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoDocumento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_PeriodoFacturacion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCesc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCotrans = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFovial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRetencion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalExentas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_FormaPago = New System.Windows.Forms.ComboBox()
        Me.txtNIT = New System.Windows.Forms.TextBox()
        Me.txtNRC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtID_Customer = New System.Windows.Forms.TextBox()
        Me.label50 = New System.Windows.Forms.Label()
        Me.label49 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtNoDocumento)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CB_PeriodoFacturacion)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdGuardar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CB_FormaPago)
        Me.GroupBox1.Controls.Add(Me.txtNIT)
        Me.GroupBox1.Controls.Add(Me.txtNRC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.txtID_Customer)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 415)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra - Crédito Fiscal"
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoDocumento.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDocumento.Location = New System.Drawing.Point(188, 134)
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Size = New System.Drawing.Size(202, 26)
        Me.txtNoDocumento.TabIndex = 9
        Me.txtNoDocumento.Text = "0"
        Me.txtNoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 21)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "No. Documento :"
        '
        'CB_PeriodoFacturacion
        '
        Me.CB_PeriodoFacturacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CB_PeriodoFacturacion.FormattingEnabled = True
        Me.CB_PeriodoFacturacion.Items.AddRange(New Object() {"2017-01", "2017-02", "2017-03", "2017-04", "2017-05"})
        Me.CB_PeriodoFacturacion.Location = New System.Drawing.Point(571, 132)
        Me.CB_PeriodoFacturacion.Name = "CB_PeriodoFacturacion"
        Me.CB_PeriodoFacturacion.Size = New System.Drawing.Size(176, 33)
        Me.CB_PeriodoFacturacion.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(416, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 21)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Periodo Facturación:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(189, 171)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(652, 46)
        Me.TextBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción Compra :"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdGuardar.FlatAppearance.BorderSize = 0
        Me.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(641, 374)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(98, 29)
        Me.cmdGuardar.TabIndex = 15
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCesc)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCotrans)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtFovial)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtRetencion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTotalVenta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTotalExentas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtIva)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(831, 136)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'txtCesc
        '
        Me.txtCesc.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCesc.Location = New System.Drawing.Point(673, 79)
        Me.txtCesc.MaxLength = 14
        Me.txtCesc.Name = "txtCesc"
        Me.txtCesc.Size = New System.Drawing.Size(145, 22)
        Me.txtCesc.TabIndex = 13
        Me.txtCesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(606, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "CESC:"
        Me.ToolTip1.SetToolTip(Me.Label12, "Contribucion especial a las Comunicaciones")
        '
        'txtCotrans
        '
        Me.txtCotrans.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCotrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCotrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCotrans.Location = New System.Drawing.Point(673, 51)
        Me.txtCotrans.MaxLength = 14
        Me.txtCotrans.Name = "txtCotrans"
        Me.txtCotrans.Size = New System.Drawing.Size(145, 22)
        Me.txtCotrans.TabIndex = 11
        Me.txtCotrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(594, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Cotrans:"
        '
        'txtFovial
        '
        Me.txtFovial.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFovial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFovial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFovial.Location = New System.Drawing.Point(673, 23)
        Me.txtFovial.MaxLength = 14
        Me.txtFovial.Name = "txtFovial"
        Me.txtFovial.Size = New System.Drawing.Size(145, 22)
        Me.txtFovial.TabIndex = 9
        Me.txtFovial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(609, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fovial:"
        '
        'txtRetencion
        '
        Me.txtRetencion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetencion.Location = New System.Drawing.Point(432, 58)
        Me.txtRetencion.MaxLength = 14
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.Size = New System.Drawing.Size(145, 22)
        Me.txtRetencion.TabIndex = 7
        Me.txtRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(297, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Retención (1%):"
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.Location = New System.Drawing.Point(672, 107)
        Me.txtTotalVenta.MaxLength = 14
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(145, 22)
        Me.txtTotalVenta.TabIndex = 15
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(568, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Venta Total:"
        '
        'txtTotalExentas
        '
        Me.txtTotalExentas.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalExentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalExentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalExentas.Location = New System.Drawing.Point(147, 58)
        Me.txtTotalExentas.MaxLength = 14
        Me.txtTotalExentas.Name = "txtTotalExentas"
        Me.txtTotalExentas.Size = New System.Drawing.Size(145, 22)
        Me.txtTotalExentas.TabIndex = 3
        Me.txtTotalExentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ventas Exentas:"
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(434, 25)
        Me.txtIva.MaxLength = 14
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(145, 22)
        Me.txtIva.TabIndex = 5
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(380, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "IVA:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(147, 25)
        Me.txtSubTotal.MaxLength = 14
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(145, 22)
        Me.txtSubTotal.TabIndex = 1
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "SubTotal:"
        '
        'CB_FormaPago
        '
        Me.CB_FormaPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_FormaPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_FormaPago.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_FormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FormaPago.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FormaPago.FormattingEnabled = True
        Me.CB_FormaPago.Items.AddRange(New Object() {"CONTADO", "CREDITO", "CHEQUE"})
        Me.CB_FormaPago.Location = New System.Drawing.Point(699, 91)
        Me.CB_FormaPago.Name = "CB_FormaPago"
        Me.CB_FormaPago.Size = New System.Drawing.Size(142, 29)
        Me.CB_FormaPago.TabIndex = 7
        '
        'txtNIT
        '
        Me.txtNIT.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNIT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIT.Location = New System.Drawing.Point(386, 94)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.ReadOnly = True
        Me.txtNIT.Size = New System.Drawing.Size(171, 26)
        Me.txtNIT.TabIndex = 5
        Me.txtNIT.TabStop = False
        '
        'txtNRC
        '
        Me.txtNRC.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNRC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNRC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRC.Location = New System.Drawing.Point(188, 97)
        Me.txtNRC.Name = "txtNRC"
        Me.txtNRC.ReadOnly = True
        Me.txtNRC.Size = New System.Drawing.Size(153, 26)
        Me.txtNRC.TabIndex = 3
        Me.txtNRC.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NIT : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "N.R.C : "
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRazonSocial.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(188, 59)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(653, 26)
        Me.txtRazonSocial.TabIndex = 1
        Me.txtRazonSocial.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre cliente:"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(743, 374)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 16
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'txtID_Customer
        '
        Me.txtID_Customer.BackColor = System.Drawing.Color.Gainsboro
        Me.txtID_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID_Customer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID_Customer.Location = New System.Drawing.Point(631, 24)
        Me.txtID_Customer.Name = "txtID_Customer"
        Me.txtID_Customer.Size = New System.Drawing.Size(202, 26)
        Me.txtID_Customer.TabIndex = 9
        Me.txtID_Customer.TabStop = False
        Me.txtID_Customer.Text = "0"
        Me.txtID_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(532, 29)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(93, 21)
        Me.label50.TabIndex = 8
        Me.label50.Text = "No. Cliente :"
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(563, 97)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(129, 21)
        Me.label49.TabIndex = 6
        Me.label49.Text = "Forma de Pago  : "
        '
        'Financiero_IngresoCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(869, 435)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_IngresoCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financiero_DocumentoFiscal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label3 As Label
    Private WithEvents txtRazonSocial As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents txtID_Customer As TextBox
    Private WithEvents label50 As Label
    Private WithEvents label49 As Label
    Private WithEvents txtNIT As TextBox
    Private WithEvents txtNRC As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents CB_FormaPago As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRetencion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalExentas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label8 As Label
    Private WithEvents cmdGuardar As Button
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtCesc As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtCotrans As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFovial As TextBox
    Friend WithEvents Label9 As Label
    Private WithEvents Label13 As Label
    Friend WithEvents CB_PeriodoFacturacion As ComboBox
    Private WithEvents txtNoDocumento As TextBox
    Private WithEvents Label14 As Label
End Class

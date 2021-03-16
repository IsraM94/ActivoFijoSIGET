<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_ConfirmTransfer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FLP_Imagenes = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbResponsableAnterior = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionTransferecian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmbMotivoTransferencia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNuevoResponsable = New System.Windows.Forms.ComboBox()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.btnDenegarTrasferencia = New System.Windows.Forms.Button()
        Me.btnConfirmarTrasferencia = New System.Windows.Forms.Button()
        Me.txtActivoFijo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmb_UbicaconPrimaria = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_Location = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmb_UbicaconPrimaria)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CB_Location)
        Me.GroupBox1.Controls.Add(Me.FLP_Imagenes)
        Me.GroupBox1.Controls.Add(Me.cmbResponsableAnterior)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionTransferecian)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.cmbMotivoTransferencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbNuevoResponsable)
        Me.GroupBox1.Controls.Add(Me.lblResponsable)
        Me.GroupBox1.Controls.Add(Me.btnDenegarTrasferencia)
        Me.GroupBox1.Controls.Add(Me.btnConfirmarTrasferencia)
        Me.GroupBox1.Controls.Add(Me.txtActivoFijo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 659)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Confirmar Transferencias"
        '
        'FLP_Imagenes
        '
        Me.FLP_Imagenes.AutoScroll = True
        Me.FLP_Imagenes.BackColor = System.Drawing.Color.White
        Me.FLP_Imagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FLP_Imagenes.Location = New System.Drawing.Point(32, 461)
        Me.FLP_Imagenes.Name = "FLP_Imagenes"
        Me.FLP_Imagenes.Size = New System.Drawing.Size(797, 138)
        Me.FLP_Imagenes.TabIndex = 60
        '
        'cmbResponsableAnterior
        '
        Me.cmbResponsableAnterior.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbResponsableAnterior.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbResponsableAnterior.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbResponsableAnterior.Enabled = False
        Me.cmbResponsableAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbResponsableAnterior.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbResponsableAnterior.FormattingEnabled = True
        Me.cmbResponsableAnterior.Location = New System.Drawing.Point(218, 88)
        Me.cmbResponsableAnterior.Name = "cmbResponsableAnterior"
        Me.cmbResponsableAnterior.Size = New System.Drawing.Size(611, 29)
        Me.cmbResponsableAnterior.TabIndex = 72
        '
        'txtDescripcionTransferecian
        '
        Me.txtDescripcionTransferecian.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcionTransferecian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionTransferecian.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTransferecian.Location = New System.Drawing.Point(219, 327)
        Me.txtDescripcionTransferecian.MaxLength = 250
        Me.txtDescripcionTransferecian.Multiline = True
        Me.txtDescripcionTransferecian.Name = "txtDescripcionTransferecian"
        Me.txtDescripcionTransferecian.Size = New System.Drawing.Size(610, 102)
        Me.txtDescripcionTransferecian.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(21, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 25)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Fotografías del Activo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(20, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 25)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Motivo Transferencia:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 272)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(201, 25)
        Me.LinkLabel1.TabIndex = 70
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Razón Transferencia: "
        '
        'cmbMotivoTransferencia
        '
        Me.cmbMotivoTransferencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMotivoTransferencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMotivoTransferencia.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbMotivoTransferencia.Enabled = False
        Me.cmbMotivoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMotivoTransferencia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMotivoTransferencia.FormattingEnabled = True
        Me.cmbMotivoTransferencia.Location = New System.Drawing.Point(219, 272)
        Me.cmbMotivoTransferencia.Name = "cmbMotivoTransferencia"
        Me.cmbMotivoTransferencia.Size = New System.Drawing.Size(610, 29)
        Me.cmbMotivoTransferencia.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Nuevo Responsable:"
        '
        'cmbNuevoResponsable
        '
        Me.cmbNuevoResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNuevoResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNuevoResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbNuevoResponsable.Enabled = False
        Me.cmbNuevoResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbNuevoResponsable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNuevoResponsable.FormattingEnabled = True
        Me.cmbNuevoResponsable.Location = New System.Drawing.Point(219, 135)
        Me.cmbNuevoResponsable.Name = "cmbNuevoResponsable"
        Me.cmbNuevoResponsable.Size = New System.Drawing.Size(610, 29)
        Me.cmbNuevoResponsable.TabIndex = 64
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.BackColor = System.Drawing.SystemColors.Control
        Me.lblResponsable.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblResponsable.Location = New System.Drawing.Point(17, 88)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(195, 25)
        Me.lblResponsable.TabIndex = 67
        Me.lblResponsable.Text = "Responsable Anterior:"
        '
        'btnDenegarTrasferencia
        '
        Me.btnDenegarTrasferencia.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDenegarTrasferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDenegarTrasferencia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDenegarTrasferencia.Location = New System.Drawing.Point(279, 614)
        Me.btnDenegarTrasferencia.Name = "btnDenegarTrasferencia"
        Me.btnDenegarTrasferencia.Size = New System.Drawing.Size(246, 30)
        Me.btnDenegarTrasferencia.TabIndex = 63
        Me.btnDenegarTrasferencia.Text = "DENEGAR TRANSFERENCIA"
        Me.btnDenegarTrasferencia.UseVisualStyleBackColor = False
        '
        'btnConfirmarTrasferencia
        '
        Me.btnConfirmarTrasferencia.BackColor = System.Drawing.Color.Gainsboro
        Me.btnConfirmarTrasferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarTrasferencia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnConfirmarTrasferencia.Location = New System.Drawing.Point(531, 613)
        Me.btnConfirmarTrasferencia.Name = "btnConfirmarTrasferencia"
        Me.btnConfirmarTrasferencia.Size = New System.Drawing.Size(246, 30)
        Me.btnConfirmarTrasferencia.TabIndex = 63
        Me.btnConfirmarTrasferencia.Text = "CONFIRMAR TRANSFERENCIA"
        Me.btnConfirmarTrasferencia.UseVisualStyleBackColor = False
        '
        'txtActivoFijo
        '
        Me.txtActivoFijo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtActivoFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActivoFijo.Enabled = False
        Me.txtActivoFijo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivoFijo.Location = New System.Drawing.Point(221, 47)
        Me.txtActivoFijo.MaxLength = 50
        Me.txtActivoFijo.Name = "txtActivoFijo"
        Me.txtActivoFijo.ReadOnly = True
        Me.txtActivoFijo.Size = New System.Drawing.Size(608, 26)
        Me.txtActivoFijo.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(108, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Activo Fijo:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(175, 614)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Frozen = True
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 50
        '
        'cmb_UbicaconPrimaria
        '
        Me.cmb_UbicaconPrimaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconPrimaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconPrimaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconPrimaria.Enabled = False
        Me.cmb_UbicaconPrimaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_UbicaconPrimaria.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmb_UbicaconPrimaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconPrimaria.FormattingEnabled = True
        Me.cmb_UbicaconPrimaria.Location = New System.Drawing.Point(218, 181)
        Me.cmb_UbicaconPrimaria.Name = "cmb_UbicaconPrimaria"
        Me.cmb_UbicaconPrimaria.Size = New System.Drawing.Size(611, 33)
        Me.cmb_UbicaconPrimaria.TabIndex = 94
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label20.Location = New System.Drawing.Point(65, 191)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 25)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "Ubicación Prim : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(74, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 25)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Ubicación Sec : "
        '
        'CB_Location
        '
        Me.CB_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Location.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Location.Enabled = False
        Me.CB_Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Location.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_Location.FormattingEnabled = True
        Me.CB_Location.Location = New System.Drawing.Point(218, 222)
        Me.CB_Location.Name = "CB_Location"
        Me.CB_Location.Size = New System.Drawing.Size(611, 33)
        Me.CB_Location.TabIndex = 91
        '
        'ERP_ConfirmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(868, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_ConfirmTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_ConfirmTransfer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents txtActivoFijo As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Button1 As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnConfirmarTrasferencia As Button
    Private WithEvents txtDescripcionTransferecian As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Private WithEvents cmbMotivoTransferencia As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents cmbNuevoResponsable As ComboBox
    Private WithEvents lblResponsable As Label
    Private WithEvents cmbResponsableAnterior As ComboBox
    Friend WithEvents FLP_Imagenes As FlowLayoutPanel
    Friend WithEvents btnDenegarTrasferencia As Button
    Private WithEvents Label4 As Label
    Friend WithEvents cmb_UbicaconPrimaria As ComboBox
    Private WithEvents Label20 As Label
    Private WithEvents Label9 As Label
    Private WithEvents CB_Location As ComboBox
End Class

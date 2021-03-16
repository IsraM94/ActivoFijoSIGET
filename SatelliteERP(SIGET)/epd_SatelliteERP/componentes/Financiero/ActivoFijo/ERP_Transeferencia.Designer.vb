<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Transeferencia
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
        Me.cmb_UbicaconPrimaria = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_Location = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcionTransferecian = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtActivoFijo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FLP_Imagenes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbMotivoTransferencia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.cmbTransferirA = New System.Windows.Forms.ComboBox()
        Me.lblResponsable = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionTransferecian)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtActivoFijo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FLP_Imagenes)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbMotivoTransferencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.btnTransferir)
        Me.GroupBox1.Controls.Add(Me.cmbTransferirA)
        Me.GroupBox1.Controls.Add(Me.lblResponsable)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 667)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transferencia de Activos"
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
        Me.cmb_UbicaconPrimaria.Location = New System.Drawing.Point(157, 160)
        Me.cmb_UbicaconPrimaria.Name = "cmb_UbicaconPrimaria"
        Me.cmb_UbicaconPrimaria.Size = New System.Drawing.Size(611, 33)
        Me.cmb_UbicaconPrimaria.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label20.Location = New System.Drawing.Point(4, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 25)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "Ubicación Prim : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(13, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 25)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Ubicación Sec : "
        '
        'CB_Location
        '
        Me.CB_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Location.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Location.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_Location.FormattingEnabled = True
        Me.CB_Location.Location = New System.Drawing.Point(157, 201)
        Me.CB_Location.Name = "CB_Location"
        Me.CB_Location.Size = New System.Drawing.Size(611, 33)
        Me.CB_Location.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(19, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 25)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Fotografías de Activo:"
        '
        'txtDescripcionTransferecian
        '
        Me.txtDescripcionTransferecian.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcionTransferecian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionTransferecian.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTransferecian.Location = New System.Drawing.Point(157, 326)
        Me.txtDescripcionTransferecian.MaxLength = 250
        Me.txtDescripcionTransferecian.Multiline = True
        Me.txtDescripcionTransferecian.Name = "txtDescripcionTransferecian"
        Me.txtDescripcionTransferecian.Size = New System.Drawing.Size(611, 87)
        Me.txtDescripcionTransferecian.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(21, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 25)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Descripción de la transferencia:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(24, 255)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(205, 25)
        Me.LinkLabel1.TabIndex = 62
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Motivo Transferencia:"
        '
        'txtActivoFijo
        '
        Me.txtActivoFijo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtActivoFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActivoFijo.Enabled = False
        Me.txtActivoFijo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivoFijo.Location = New System.Drawing.Point(157, 44)
        Me.txtActivoFijo.MaxLength = 50
        Me.txtActivoFijo.Name = "txtActivoFijo"
        Me.txtActivoFijo.ReadOnly = True
        Me.txtActivoFijo.Size = New System.Drawing.Size(611, 26)
        Me.txtActivoFijo.TabIndex = 0
        Me.txtActivoFijo.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(41, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Activo Fijo:"
        '
        'FLP_Imagenes
        '
        Me.FLP_Imagenes.AutoScroll = True
        Me.FLP_Imagenes.BackColor = System.Drawing.Color.White
        Me.FLP_Imagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FLP_Imagenes.Location = New System.Drawing.Point(17, 460)
        Me.FLP_Imagenes.Name = "FLP_Imagenes"
        Me.FLP_Imagenes.Size = New System.Drawing.Size(756, 153)
        Me.FLP_Imagenes.TabIndex = 5
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
        Me.Button1.Location = New System.Drawing.Point(670, 619)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbMotivoTransferencia
        '
        Me.cmbMotivoTransferencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMotivoTransferencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMotivoTransferencia.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbMotivoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMotivoTransferencia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMotivoTransferencia.FormattingEnabled = True
        Me.cmbMotivoTransferencia.ItemHeight = 21
        Me.cmbMotivoTransferencia.Location = New System.Drawing.Point(228, 254)
        Me.cmbMotivoTransferencia.Name = "cmbMotivoTransferencia"
        Me.cmbMotivoTransferencia.Size = New System.Drawing.Size(540, 29)
        Me.cmbMotivoTransferencia.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(33, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Transferir A:"
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResponsable.Enabled = False
        Me.txtResponsable.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.Location = New System.Drawing.Point(157, 79)
        Me.txtResponsable.MaxLength = 50
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.ReadOnly = True
        Me.txtResponsable.Size = New System.Drawing.Size(611, 26)
        Me.txtResponsable.TabIndex = 1
        '
        'btnTransferir
        '
        Me.btnTransferir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnTransferir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnTransferir.FlatAppearance.BorderSize = 0
        Me.btnTransferir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransferir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferir.Location = New System.Drawing.Point(566, 619)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(98, 29)
        Me.btnTransferir.TabIndex = 7
        Me.btnTransferir.Text = "Transferir"
        Me.btnTransferir.UseVisualStyleBackColor = False
        '
        'cmbTransferirA
        '
        Me.cmbTransferirA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTransferirA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTransferirA.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbTransferirA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTransferirA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransferirA.FormattingEnabled = True
        Me.cmbTransferirA.ItemHeight = 21
        Me.cmbTransferirA.Location = New System.Drawing.Point(157, 115)
        Me.cmbTransferirA.Name = "cmbTransferirA"
        Me.cmbTransferirA.Size = New System.Drawing.Size(612, 29)
        Me.cmbTransferirA.TabIndex = 2
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.BackColor = System.Drawing.SystemColors.Control
        Me.lblResponsable.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblResponsable.Location = New System.Drawing.Point(24, 80)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(126, 25)
        Me.lblResponsable.TabIndex = 20
        Me.lblResponsable.Text = "Responsable: "
        '
        'ERP_Transeferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(803, 691)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Transeferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_Transeferencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents txtResponsable As TextBox
    Private WithEvents btnTransferir As Button
    Private WithEvents cmbTransferirA As ComboBox
    Private WithEvents lblResponsable As Label
    Private WithEvents Label1 As Label
    Private WithEvents cmbMotivoTransferencia As ComboBox
    Private WithEvents Button1 As Button
    Friend WithEvents FLP_Imagenes As FlowLayoutPanel
    Private WithEvents txtActivoFijo As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Private WithEvents Label2 As Label
    Private WithEvents txtDescripcionTransferecian As TextBox
    Private WithEvents Label4 As Label
    Friend WithEvents cmb_UbicaconPrimaria As ComboBox
    Private WithEvents Label20 As Label
    Private WithEvents Label9 As Label
    Private WithEvents CB_Location As ComboBox
End Class

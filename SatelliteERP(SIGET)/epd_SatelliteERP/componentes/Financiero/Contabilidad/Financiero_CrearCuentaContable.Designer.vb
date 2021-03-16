<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_CrearCuentaContable
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_TipoDeCambio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_FlujoEfectivo = New System.Windows.Forms.ComboBox()
        Me.lblTypeAcount = New System.Windows.Forms.Label()
        Me.checkMovimientoDirecto = New System.Windows.Forms.CheckBox()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblNoCuentaContable = New System.Windows.Forms.Label()
        Me.txtNoCuentaContable = New System.Windows.Forms.TextBox()
        Me.comboListTypeAcount = New System.Windows.Forms.ComboBox()
        Me.lblCuentaContable = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_TipoDeCambio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CB_FlujoEfectivo)
        Me.GroupBox1.Controls.Add(Me.lblTypeAcount)
        Me.GroupBox1.Controls.Add(Me.checkMovimientoDirecto)
        Me.GroupBox1.Controls.Add(Me.txtCuentaContable)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.lblNoCuentaContable)
        Me.GroupBox1.Controls.Add(Me.txtNoCuentaContable)
        Me.GroupBox1.Controls.Add(Me.comboListTypeAcount)
        Me.GroupBox1.Controls.Add(Me.lblCuentaContable)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 308)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración Catálogo de Contabilidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Tipo de Cambio :"
        '
        'CB_TipoDeCambio
        '
        Me.CB_TipoDeCambio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_TipoDeCambio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_TipoDeCambio.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_TipoDeCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TipoDeCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TipoDeCambio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TipoDeCambio.FormattingEnabled = True
        Me.CB_TipoDeCambio.Items.AddRange(New Object() {"Corriente", "Histoco"})
        Me.CB_TipoDeCambio.Location = New System.Drawing.Point(206, 210)
        Me.CB_TipoDeCambio.Name = "CB_TipoDeCambio"
        Me.CB_TipoDeCambio.Size = New System.Drawing.Size(317, 29)
        Me.CB_TipoDeCambio.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Flujo Efectivo :"
        '
        'CB_FlujoEfectivo
        '
        Me.CB_FlujoEfectivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_FlujoEfectivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_FlujoEfectivo.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_FlujoEfectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FlujoEfectivo.Enabled = False
        Me.CB_FlujoEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_FlujoEfectivo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FlujoEfectivo.FormattingEnabled = True
        Me.CB_FlujoEfectivo.Location = New System.Drawing.Point(206, 175)
        Me.CB_FlujoEfectivo.Name = "CB_FlujoEfectivo"
        Me.CB_FlujoEfectivo.Size = New System.Drawing.Size(317, 29)
        Me.CB_FlujoEfectivo.TabIndex = 34
        '
        'lblTypeAcount
        '
        Me.lblTypeAcount.AutoSize = True
        Me.lblTypeAcount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeAcount.Location = New System.Drawing.Point(53, 140)
        Me.lblTypeAcount.Name = "lblTypeAcount"
        Me.lblTypeAcount.Size = New System.Drawing.Size(149, 25)
        Me.lblTypeAcount.TabIndex = 33
        Me.lblTypeAcount.Text = "Tipo de Cuenta :"
        '
        'checkMovimientoDirecto
        '
        Me.checkMovimientoDirecto.AutoSize = True
        Me.checkMovimientoDirecto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.checkMovimientoDirecto.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkMovimientoDirecto.Location = New System.Drawing.Point(23, 110)
        Me.checkMovimientoDirecto.Margin = New System.Windows.Forms.Padding(2)
        Me.checkMovimientoDirecto.Name = "checkMovimientoDirecto"
        Me.checkMovimientoDirecto.Size = New System.Drawing.Size(178, 29)
        Me.checkMovimientoDirecto.TabIndex = 3
        Me.checkMovimientoDirecto.Text = "Cuenta Aplicativa"
        Me.checkMovimientoDirecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkMovimientoDirecto.UseVisualStyleBackColor = True
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContable.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaContable.Location = New System.Drawing.Point(208, 75)
        Me.txtCuentaContable.MaxLength = 50
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ShortcutsEnabled = False
        Me.txtCuentaContable.Size = New System.Drawing.Size(316, 26)
        Me.txtCuentaContable.TabIndex = 2
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
        Me.cmdCancel.Location = New System.Drawing.Point(425, 257)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
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
        Me.cmdSave.Location = New System.Drawing.Point(321, 257)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lblNoCuentaContable
        '
        Me.lblNoCuentaContable.AutoSize = True
        Me.lblNoCuentaContable.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblNoCuentaContable.Location = New System.Drawing.Point(7, 38)
        Me.lblNoCuentaContable.Name = "lblNoCuentaContable"
        Me.lblNoCuentaContable.Size = New System.Drawing.Size(201, 25)
        Me.lblNoCuentaContable.TabIndex = 20
        Me.lblNoCuentaContable.Text = "No. Cuenta Contable : "
        '
        'txtNoCuentaContable
        '
        Me.txtNoCuentaContable.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNoCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoCuentaContable.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuentaContable.Location = New System.Drawing.Point(208, 38)
        Me.txtNoCuentaContable.MaxLength = 50
        Me.txtNoCuentaContable.Name = "txtNoCuentaContable"
        Me.txtNoCuentaContable.ShortcutsEnabled = False
        Me.txtNoCuentaContable.Size = New System.Drawing.Size(180, 26)
        Me.txtNoCuentaContable.TabIndex = 1
        '
        'comboListTypeAcount
        '
        Me.comboListTypeAcount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListTypeAcount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListTypeAcount.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListTypeAcount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboListTypeAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListTypeAcount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListTypeAcount.FormattingEnabled = True
        Me.comboListTypeAcount.Location = New System.Drawing.Point(206, 140)
        Me.comboListTypeAcount.Name = "comboListTypeAcount"
        Me.comboListTypeAcount.Size = New System.Drawing.Size(317, 29)
        Me.comboListTypeAcount.TabIndex = 4
        '
        'lblCuentaContable
        '
        Me.lblCuentaContable.AutoSize = True
        Me.lblCuentaContable.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaContable.Location = New System.Drawing.Point(40, 75)
        Me.lblCuentaContable.Name = "lblCuentaContable"
        Me.lblCuentaContable.Size = New System.Drawing.Size(167, 25)
        Me.lblCuentaContable.TabIndex = 25
        Me.lblCuentaContable.Text = "Cuenta Contable  :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(321, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 131)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Financiero_CrearCuentaContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(568, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_CrearCuentaContable"
        Me.Text = "Finaciero_CrearCuentaoContable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents lblTypeAcount As Label
    Friend WithEvents checkMovimientoDirecto As CheckBox
    Private WithEvents txtCuentaContable As TextBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents lblNoCuentaContable As Label
    Private WithEvents txtNoCuentaContable As TextBox
    Private WithEvents comboListTypeAcount As ComboBox
    Private WithEvents lblCuentaContable As Label
    Private WithEvents Label1 As Label
    Private WithEvents CB_FlujoEfectivo As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents CB_TipoDeCambio As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

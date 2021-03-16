<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_CrearPartidaContable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Financiero_CrearPartidaContable))
        Me.txtPartida_NoPartida = New System.Windows.Forms.TextBox()
        Me.comboListAccount = New System.Windows.Forms.ComboBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.label50 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtTotalDebe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMontoHacer = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lvDetails = New System.Windows.Forms.ListView()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Concepto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Parcial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Debe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Haber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_TypeItem = New System.Windows.Forms.ComboBox()
        Me.txtConcept = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.IL_Banderas = New System.Windows.Forms.ImageList(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPartida_NoPartida
        '
        Me.txtPartida_NoPartida.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPartida_NoPartida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPartida_NoPartida.Enabled = False
        Me.txtPartida_NoPartida.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida_NoPartida.Location = New System.Drawing.Point(536, 22)
        Me.txtPartida_NoPartida.Name = "txtPartida_NoPartida"
        Me.txtPartida_NoPartida.Size = New System.Drawing.Size(202, 26)
        Me.txtPartida_NoPartida.TabIndex = 22
        Me.txtPartida_NoPartida.Text = "0"
        Me.txtPartida_NoPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'comboListAccount
        '
        Me.comboListAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListAccount.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListAccount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListAccount.FormattingEnabled = True
        Me.comboListAccount.Location = New System.Drawing.Point(185, 125)
        Me.comboListAccount.Name = "comboListAccount"
        Me.comboListAccount.Size = New System.Drawing.Size(478, 29)
        Me.comboListAccount.TabIndex = 21
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(39, 129)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(140, 21)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Cuenta Contable  : "
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(479, 27)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(45, 21)
        Me.label50.TabIndex = 19
        Me.label50.Text = "No.  :"
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.FlatAppearance.BorderSize = 0
        Me.cmdAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(669, 125)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(69, 29)
        Me.cmdAdd.TabIndex = 24
        Me.cmdAdd.Text = "add"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebe.Location = New System.Drawing.Point(534, 460)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.Size = New System.Drawing.Size(101, 26)
        Me.txtTotalDebe.TabIndex = 26
        Me.txtTotalDebe.Text = "0"
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(382, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Sumas Iguales  :"
        '
        'txtMontoHacer
        '
        Me.txtMontoHacer.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMontoHacer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoHacer.Enabled = False
        Me.txtMontoHacer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoHacer.Location = New System.Drawing.Point(640, 460)
        Me.txtMontoHacer.Name = "txtMontoHacer"
        Me.txtMontoHacer.Size = New System.Drawing.Size(98, 26)
        Me.txtMontoHacer.TabIndex = 27
        Me.txtMontoHacer.Text = "0"
        Me.txtMontoHacer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lvDetails)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 158)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(723, 293)
        Me.FlowLayoutPanel1.TabIndex = 28
        '
        'lvDetails
        '
        Me.lvDetails.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.Cuenta, Me.Concepto, Me.Parcial, Me.Debe, Me.Haber, Me.IDItem})
        Me.lvDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lvDetails.FullRowSelect = True
        Me.lvDetails.GridLines = True
        Me.lvDetails.HoverSelection = True
        Me.lvDetails.Location = New System.Drawing.Point(3, 3)
        Me.lvDetails.Name = "lvDetails"
        Me.lvDetails.Size = New System.Drawing.Size(720, 290)
        Me.lvDetails.TabIndex = 0
        Me.lvDetails.UseCompatibleStateImageBehavior = False
        Me.lvDetails.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "Codigo"
        Me.codigo.Width = 109
        '
        'Cuenta
        '
        Me.Cuenta.Text = "Cuenta"
        Me.Cuenta.Width = 166
        '
        'Concepto
        '
        Me.Concepto.Text = "Concepto"
        Me.Concepto.Width = 154
        '
        'Parcial
        '
        Me.Parcial.Text = "Parcial"
        Me.Parcial.Width = 101
        '
        'Debe
        '
        Me.Debe.Text = "Debe"
        Me.Debe.Width = 95
        '
        'Haber
        '
        Me.Haber.Text = "Haber"
        Me.Haber.Width = 93
        '
        'IDItem
        '
        Me.IDItem.Text = "ID Item"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_TypeItem)
        Me.GroupBox1.Controls.Add(Me.txtConcept)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtPartida_NoPartida)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Controls.Add(Me.txtMontoHacer)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.txtTotalDebe)
        Me.GroupBox1.Controls.Add(Me.comboListAccount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 537)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Partida Contable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tipo Partida  : "
        '
        'CB_TypeItem
        '
        Me.CB_TypeItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_TypeItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_TypeItem.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_TypeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TypeItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TypeItem.FormattingEnabled = True
        Me.CB_TypeItem.Location = New System.Drawing.Point(186, 90)
        Me.CB_TypeItem.Name = "CB_TypeItem"
        Me.CB_TypeItem.Size = New System.Drawing.Size(477, 29)
        Me.CB_TypeItem.TabIndex = 38
        '
        'txtConcept
        '
        Me.txtConcept.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConcept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConcept.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcept.Location = New System.Drawing.Point(188, 59)
        Me.txtConcept.Name = "txtConcept"
        Me.txtConcept.Size = New System.Drawing.Size(550, 26)
        Me.txtConcept.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Concepto General:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(640, 500)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
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
        Me.cmdSave.Location = New System.Drawing.Point(536, 500)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'IL_Banderas
        '
        Me.IL_Banderas.ImageStream = CType(resources.GetObject("IL_Banderas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL_Banderas.TransparentColor = System.Drawing.Color.Transparent
        Me.IL_Banderas.Images.SetKeyName(0, "Roja-Bandera.png")
        Me.IL_Banderas.Images.SetKeyName(1, "Verde-Bandera.png")
        Me.IL_Banderas.Images.SetKeyName(2, "Amarillo-bandera.png")
        Me.IL_Banderas.Images.SetKeyName(3, "Azul-Bandera.png")
        '
        'Financiero_CrearPartidaContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(779, 557)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_CrearPartidaContable"
        Me.Text = "Financiero_CrearPartidadContable"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtPartida_NoPartida As TextBox
    Private WithEvents comboListAccount As ComboBox
    Private WithEvents label49 As Label
    Private WithEvents label50 As Label
    Private WithEvents cmdAdd As Button
    Private WithEvents txtTotalDebe As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtMontoHacer As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Friend WithEvents lvDetails As ListView
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents Cuenta As ColumnHeader
    Friend WithEvents Parcial As ColumnHeader
    Friend WithEvents Debe As ColumnHeader
    Friend WithEvents Haber As ColumnHeader
    Friend WithEvents Concepto As ColumnHeader
    Private WithEvents txtConcept As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents CB_TypeItem As ComboBox
    Friend WithEvents IL_Banderas As ImageList
    Friend WithEvents IDItem As ColumnHeader
End Class

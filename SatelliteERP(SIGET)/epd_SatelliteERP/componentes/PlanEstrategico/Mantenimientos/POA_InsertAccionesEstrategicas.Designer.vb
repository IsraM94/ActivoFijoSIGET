<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POA_InsertAccionesEstrategicas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.chkAccionApoyo = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQuinquenio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtAnio5 = New System.Windows.Forms.TextBox()
        Me.lblanio5 = New System.Windows.Forms.Label()
        Me.txtAnio4 = New System.Windows.Forms.TextBox()
        Me.lblanio4 = New System.Windows.Forms.Label()
        Me.txtAnio3 = New System.Windows.Forms.TextBox()
        Me.lblanio3 = New System.Windows.Forms.Label()
        Me.txtAnio2 = New System.Windows.Forms.TextBox()
        Me.lblanio2 = New System.Windows.Forms.Label()
        Me.txtAnio1 = New System.Windows.Forms.TextBox()
        Me.lblanio1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEjes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_UnidadLider = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboListResultados = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_POA_AddEjeEstrategico = New System.Windows.Forms.TextBox()
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupDatosUsuario.SuspendLayout()
        Me.CMSCreditLine.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmdCancel.Location = New System.Drawing.Point(644, 601)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.Controls.Add(Me.chkAccionApoyo)
        Me.GroupDatosUsuario.Controls.Add(Me.Label11)
        Me.GroupDatosUsuario.Controls.Add(Me.txtQuinquenio)
        Me.GroupDatosUsuario.Controls.Add(Me.Label10)
        Me.GroupDatosUsuario.Controls.Add(Me.txtDescripcion)
        Me.GroupDatosUsuario.Controls.Add(Me.txtAnio5)
        Me.GroupDatosUsuario.Controls.Add(Me.lblanio5)
        Me.GroupDatosUsuario.Controls.Add(Me.txtAnio4)
        Me.GroupDatosUsuario.Controls.Add(Me.lblanio4)
        Me.GroupDatosUsuario.Controls.Add(Me.txtAnio3)
        Me.GroupDatosUsuario.Controls.Add(Me.lblanio3)
        Me.GroupDatosUsuario.Controls.Add(Me.txtAnio2)
        Me.GroupDatosUsuario.Controls.Add(Me.lblanio2)
        Me.GroupDatosUsuario.Controls.Add(Me.txtAnio1)
        Me.GroupDatosUsuario.Controls.Add(Me.lblanio1)
        Me.GroupDatosUsuario.Controls.Add(Me.Label6)
        Me.GroupDatosUsuario.Controls.Add(Me.cbEjes)
        Me.GroupDatosUsuario.Controls.Add(Me.Label3)
        Me.GroupDatosUsuario.Controls.Add(Me.CB_UnidadLider)
        Me.GroupDatosUsuario.Controls.Add(Me.Label2)
        Me.GroupDatosUsuario.Controls.Add(Me.comboListResultados)
        Me.GroupDatosUsuario.Controls.Add(Me.Label1)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_AddEjeEstrategico)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(3, 32)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(749, 564)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Acciones Estratégicas"
        '
        'chkAccionApoyo
        '
        Me.chkAccionApoyo.AutoSize = True
        Me.chkAccionApoyo.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccionApoyo.Location = New System.Drawing.Point(138, 453)
        Me.chkAccionApoyo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAccionApoyo.Name = "chkAccionApoyo"
        Me.chkAccionApoyo.Size = New System.Drawing.Size(173, 29)
        Me.chkAccionApoyo.TabIndex = 6
        Me.chkAccionApoyo.Text = "Acción de Apoyo"
        Me.chkAccionApoyo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(14, 484)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 25)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Quinquenio"
        '
        'txtQuinquenio
        '
        Me.txtQuinquenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuinquenio.Location = New System.Drawing.Point(19, 513)
        Me.txtQuinquenio.MaxLength = 4
        Me.txtQuinquenio.Name = "txtQuinquenio"
        Me.txtQuinquenio.Size = New System.Drawing.Size(107, 31)
        Me.txtQuinquenio.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(14, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(300, 25)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Descripcion Acciones Estratégicas:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(19, 193)
        Me.txtDescripcion.MaxLength = 2000
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(706, 94)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtAnio5
        '
        Me.txtAnio5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio5.Location = New System.Drawing.Point(649, 513)
        Me.txtAnio5.MaxLength = 2000
        Me.txtAnio5.Name = "txtAnio5"
        Me.txtAnio5.Size = New System.Drawing.Size(76, 31)
        Me.txtAnio5.TabIndex = 12
        '
        'lblanio5
        '
        Me.lblanio5.AutoSize = True
        Me.lblanio5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblanio5.Location = New System.Drawing.Point(647, 484)
        Me.lblanio5.Name = "lblanio5"
        Me.lblanio5.Size = New System.Drawing.Size(61, 25)
        Me.lblanio5.TabIndex = 46
        Me.lblanio5.Text = "Año 5"
        '
        'txtAnio4
        '
        Me.txtAnio4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio4.Location = New System.Drawing.Point(516, 513)
        Me.txtAnio4.MaxLength = 2000
        Me.txtAnio4.Name = "txtAnio4"
        Me.txtAnio4.Size = New System.Drawing.Size(76, 31)
        Me.txtAnio4.TabIndex = 11
        '
        'lblanio4
        '
        Me.lblanio4.AutoSize = True
        Me.lblanio4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblanio4.Location = New System.Drawing.Point(514, 484)
        Me.lblanio4.Name = "lblanio4"
        Me.lblanio4.Size = New System.Drawing.Size(61, 25)
        Me.lblanio4.TabIndex = 44
        Me.lblanio4.Text = "Año 4"
        '
        'txtAnio3
        '
        Me.txtAnio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio3.Location = New System.Drawing.Point(379, 513)
        Me.txtAnio3.MaxLength = 2000
        Me.txtAnio3.Name = "txtAnio3"
        Me.txtAnio3.Size = New System.Drawing.Size(76, 31)
        Me.txtAnio3.TabIndex = 10
        '
        'lblanio3
        '
        Me.lblanio3.AutoSize = True
        Me.lblanio3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblanio3.Location = New System.Drawing.Point(377, 484)
        Me.lblanio3.Name = "lblanio3"
        Me.lblanio3.Size = New System.Drawing.Size(61, 25)
        Me.lblanio3.TabIndex = 42
        Me.lblanio3.Text = "Año 3"
        '
        'txtAnio2
        '
        Me.txtAnio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio2.Location = New System.Drawing.Point(266, 513)
        Me.txtAnio2.MaxLength = 2000
        Me.txtAnio2.Name = "txtAnio2"
        Me.txtAnio2.Size = New System.Drawing.Size(76, 31)
        Me.txtAnio2.TabIndex = 9
        '
        'lblanio2
        '
        Me.lblanio2.AutoSize = True
        Me.lblanio2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblanio2.Location = New System.Drawing.Point(264, 484)
        Me.lblanio2.Name = "lblanio2"
        Me.lblanio2.Size = New System.Drawing.Size(61, 25)
        Me.lblanio2.TabIndex = 40
        Me.lblanio2.Text = "Año 2"
        '
        'txtAnio1
        '
        Me.txtAnio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio1.Location = New System.Drawing.Point(148, 513)
        Me.txtAnio1.MaxLength = 2000
        Me.txtAnio1.Name = "txtAnio1"
        Me.txtAnio1.Size = New System.Drawing.Size(76, 31)
        Me.txtAnio1.TabIndex = 8
        '
        'lblanio1
        '
        Me.lblanio1.AutoSize = True
        Me.lblanio1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblanio1.Location = New System.Drawing.Point(146, 484)
        Me.lblanio1.Name = "lblanio1"
        Me.lblanio1.Size = New System.Drawing.Size(61, 25)
        Me.lblanio1.TabIndex = 38
        Me.lblanio1.Text = "Año 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(83, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 25)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Ejes:"
        '
        'cbEjes
        '
        Me.cbEjes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEjes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEjes.BackColor = System.Drawing.Color.Gainsboro
        Me.cbEjes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEjes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEjes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEjes.FormattingEnabled = True
        Me.cbEjes.Location = New System.Drawing.Point(138, 307)
        Me.cbEjes.Name = "cbEjes"
        Me.cbEjes.Size = New System.Drawing.Size(587, 33)
        Me.cbEjes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(8, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Unidad Lider:"
        '
        'CB_UnidadLider
        '
        Me.CB_UnidadLider.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_UnidadLider.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_UnidadLider.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_UnidadLider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_UnidadLider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_UnidadLider.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_UnidadLider.FormattingEnabled = True
        Me.CB_UnidadLider.Location = New System.Drawing.Point(138, 405)
        Me.CB_UnidadLider.Name = "CB_UnidadLider"
        Me.CB_UnidadLider.Size = New System.Drawing.Size(587, 33)
        Me.CB_UnidadLider.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(26, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Resultados:"
        '
        'comboListResultados
        '
        Me.comboListResultados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListResultados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListResultados.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListResultados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboListResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListResultados.FormattingEnabled = True
        Me.comboListResultados.Location = New System.Drawing.Point(138, 355)
        Me.comboListResultados.Name = "comboListResultados"
        Me.comboListResultados.Size = New System.Drawing.Size(587, 33)
        Me.comboListResultados.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Acción a Ejecutar"
        '
        'txt_POA_AddEjeEstrategico
        '
        Me.txt_POA_AddEjeEstrategico.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_AddEjeEstrategico.Location = New System.Drawing.Point(19, 57)
        Me.txt_POA_AddEjeEstrategico.MaxLength = 2000
        Me.txt_POA_AddEjeEstrategico.Multiline = True
        Me.txt_POA_AddEjeEstrategico.Name = "txt_POA_AddEjeEstrategico"
        Me.txt_POA_AddEjeEstrategico.Size = New System.Drawing.Size(706, 94)
        Me.txt_POA_AddEjeEstrategico.TabIndex = 1
        '
        'CMSCreditLine
        '
        Me.CMSCreditLine.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMSCreditLine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSCreditLine.Name = "CMSCreditLine"
        Me.CMSCreditLine.Size = New System.Drawing.Size(126, 70)
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ActualizarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GroupDatosUsuario)
        Me.GroupBox1.Controls.Add(Me.btnGrabar)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 635)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " PEI Agregar Acciones Estratégicas"
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGrabar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatAppearance.BorderSize = 0
        Me.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(526, 601)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(98, 28)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'POA_InsertAccionesEstrategicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(768, 659)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "POA_InsertAccionesEstrategicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.GroupDatosUsuario.ResumeLayout(False)
        Me.GroupDatosUsuario.PerformLayout()
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupDatosUsuario As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_POA_AddEjeEstrategico As TextBox
    Private WithEvents btnGrabar As Button
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents comboListResultados As ComboBox
    Private WithEvents Label3 As Label
    Private WithEvents CB_UnidadLider As ComboBox
    Private WithEvents Label6 As Label
    Private WithEvents cbEjes As ComboBox
    Friend WithEvents txtAnio5 As TextBox
    Private WithEvents lblanio5 As Label
    Friend WithEvents txtAnio4 As TextBox
    Private WithEvents lblanio4 As Label
    Friend WithEvents txtAnio3 As TextBox
    Private WithEvents lblanio3 As Label
    Friend WithEvents txtAnio2 As TextBox
    Private WithEvents lblanio2 As Label
    Friend WithEvents txtAnio1 As TextBox
    Private WithEvents lblanio1 As Label
    Private WithEvents Label11 As Label
    Friend WithEvents txtQuinquenio As TextBox
    Private WithEvents Label10 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents chkAccionApoyo As CheckBox
End Class

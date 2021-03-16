<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POA_InsertAccionesOperativas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_UnidadLider = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_TipoMedicion = New System.Windows.Forms.ComboBox()
        Me.comboListAccionesEstrategicas = New System.Windows.Forms.ComboBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txt_POA_AddAccionesOperativas = New System.Windows.Forms.TextBox()
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
        Me.cmdCancel.Location = New System.Drawing.Point(701, 483)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.Controls.Add(Me.Label1)
        Me.GroupDatosUsuario.Controls.Add(Me.txtDescripcion)
        Me.GroupDatosUsuario.Controls.Add(Me.txtAnio)
        Me.GroupDatosUsuario.Controls.Add(Me.Label7)
        Me.GroupDatosUsuario.Controls.Add(Me.Label6)
        Me.GroupDatosUsuario.Controls.Add(Me.CB_UnidadLider)
        Me.GroupDatosUsuario.Controls.Add(Me.Label4)
        Me.GroupDatosUsuario.Controls.Add(Me.Label2)
        Me.GroupDatosUsuario.Controls.Add(Me.CB_TipoMedicion)
        Me.GroupDatosUsuario.Controls.Add(Me.comboListAccionesEstrategicas)
        Me.GroupDatosUsuario.Controls.Add(Me.lblValor)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_AddAccionesOperativas)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(20, 32)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(782, 447)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Acciones de Apoyo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(2, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Descripción Acción de Apoyo:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(254, 155)
        Me.txtDescripcion.MaxLength = 5000
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(518, 103)
        Me.txtDescripcion.TabIndex = 42
        '
        'txtAnio
        '
        Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(249, 392)
        Me.txtAnio.MaxLength = 200
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(127, 31)
        Me.txtAnio.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(193, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 25)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(118, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Unidad Lider:"
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
        Me.CB_UnidadLider.Location = New System.Drawing.Point(249, 353)
        Me.CB_UnidadLider.Name = "CB_UnidadLider"
        Me.CB_UnidadLider.Size = New System.Drawing.Size(524, 33)
        Me.CB_UnidadLider.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(80, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Tipo de Medición:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(48, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Acciones Estratégicas:"
        '
        'CB_TipoMedicion
        '
        Me.CB_TipoMedicion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_TipoMedicion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_TipoMedicion.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_TipoMedicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TipoMedicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_TipoMedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TipoMedicion.FormattingEnabled = True
        Me.CB_TipoMedicion.Location = New System.Drawing.Point(249, 314)
        Me.CB_TipoMedicion.Name = "CB_TipoMedicion"
        Me.CB_TipoMedicion.Size = New System.Drawing.Size(524, 33)
        Me.CB_TipoMedicion.TabIndex = 5
        '
        'comboListAccionesEstrategicas
        '
        Me.comboListAccionesEstrategicas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListAccionesEstrategicas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListAccionesEstrategicas.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListAccionesEstrategicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboListAccionesEstrategicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListAccionesEstrategicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListAccionesEstrategicas.FormattingEnabled = True
        Me.comboListAccionesEstrategicas.Location = New System.Drawing.Point(250, 275)
        Me.comboListAccionesEstrategicas.Name = "comboListAccionesEstrategicas"
        Me.comboListAccionesEstrategicas.Size = New System.Drawing.Size(524, 33)
        Me.comboListAccionesEstrategicas.TabIndex = 4
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblValor.Location = New System.Drawing.Point(13, 43)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(232, 25)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Nombre Acción de Apoyo:"
        '
        'txt_POA_AddAccionesOperativas
        '
        Me.txt_POA_AddAccionesOperativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_AddAccionesOperativas.Location = New System.Drawing.Point(254, 40)
        Me.txt_POA_AddAccionesOperativas.MaxLength = 5000
        Me.txt_POA_AddAccionesOperativas.Multiline = True
        Me.txt_POA_AddAccionesOperativas.Name = "txt_POA_AddAccionesOperativas"
        Me.txt_POA_AddAccionesOperativas.Size = New System.Drawing.Size(518, 103)
        Me.txt_POA_AddAccionesOperativas.TabIndex = 1
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 518)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " POA Agregar Acciones de Apoyo"
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
        Me.btnGrabar.Location = New System.Drawing.Point(584, 483)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(98, 28)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'POA_InsertAccionesOperativas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(828, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "POA_InsertAccionesOperativas"
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
    Friend WithEvents txt_POA_AddAccionesOperativas As TextBox
    Private WithEvents lblValor As Label
    Private WithEvents btnGrabar As Button
    Private WithEvents Label2 As Label
    Private WithEvents comboListAccionesEstrategicas As ComboBox
    Private WithEvents Label4 As Label
    Private WithEvents CB_TipoMedicion As ComboBox
    Private WithEvents Label6 As Label
    Private WithEvents CB_UnidadLider As ComboBox
    Friend WithEvents txtAnio As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
End Class

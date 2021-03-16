<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POA_InsertAccionesNoProgramadas
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.cbMesFinal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_MesInicio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_POA_Administrador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_UnidadLider = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_POA_Presupuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txt_POA_AccioneDesarrollada = New System.Windows.Forms.TextBox()
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
        Me.cmdCancel.Location = New System.Drawing.Point(676, 482)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.Controls.Add(Me.Label5)
        Me.GroupDatosUsuario.Controls.Add(Me.txtAnio)
        Me.GroupDatosUsuario.Controls.Add(Me.cbMesFinal)
        Me.GroupDatosUsuario.Controls.Add(Me.Label4)
        Me.GroupDatosUsuario.Controls.Add(Me.CB_MesInicio)
        Me.GroupDatosUsuario.Controls.Add(Me.Label2)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_Administrador)
        Me.GroupDatosUsuario.Controls.Add(Me.Label3)
        Me.GroupDatosUsuario.Controls.Add(Me.CB_UnidadLider)
        Me.GroupDatosUsuario.Controls.Add(Me.Label7)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_Presupuesto)
        Me.GroupDatosUsuario.Controls.Add(Me.Label1)
        Me.GroupDatosUsuario.Controls.Add(Me.lblValor)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_POA_AccioneDesarrollada)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(20, 32)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(754, 445)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Acciones No Programadas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(14, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 25)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Año"
        '
        'txtAnio
        '
        Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(277, 283)
        Me.txtAnio.MaxLength = 100
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(459, 31)
        Me.txtAnio.TabIndex = 45
        '
        'cbMesFinal
        '
        Me.cbMesFinal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMesFinal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMesFinal.BackColor = System.Drawing.Color.Gainsboro
        Me.cbMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMesFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMesFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMesFinal.FormattingEnabled = True
        Me.cbMesFinal.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbMesFinal.Location = New System.Drawing.Point(277, 241)
        Me.cbMesFinal.Name = "cbMesFinal"
        Me.cbMesFinal.Size = New System.Drawing.Size(459, 33)
        Me.cbMesFinal.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(14, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Mes de Inicio"
        '
        'CB_MesInicio
        '
        Me.CB_MesInicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_MesInicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_MesInicio.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_MesInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MesInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_MesInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_MesInicio.FormattingEnabled = True
        Me.CB_MesInicio.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CB_MesInicio.Location = New System.Drawing.Point(277, 202)
        Me.CB_MesInicio.Name = "CB_MesInicio"
        Me.CB_MesInicio.Size = New System.Drawing.Size(459, 33)
        Me.CB_MesInicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(14, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Administrador de la Acción"
        '
        'txt_POA_Administrador
        '
        Me.txt_POA_Administrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Administrador.Location = New System.Drawing.Point(277, 404)
        Me.txt_POA_Administrador.MaxLength = 150
        Me.txt_POA_Administrador.Name = "txt_POA_Administrador"
        Me.txt_POA_Administrador.Size = New System.Drawing.Size(459, 31)
        Me.txt_POA_Administrador.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(14, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Unidad Lider"
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
        Me.CB_UnidadLider.Location = New System.Drawing.Point(277, 364)
        Me.CB_UnidadLider.Name = "CB_UnidadLider"
        Me.CB_UnidadLider.Size = New System.Drawing.Size(459, 33)
        Me.CB_UnidadLider.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(14, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 25)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Presupuesto"
        '
        'txt_POA_Presupuesto
        '
        Me.txt_POA_Presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_Presupuesto.Location = New System.Drawing.Point(277, 325)
        Me.txt_POA_Presupuesto.MaxLength = 100
        Me.txt_POA_Presupuesto.Name = "txt_POA_Presupuesto"
        Me.txt_POA_Presupuesto.Size = New System.Drawing.Size(459, 31)
        Me.txt_POA_Presupuesto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(14, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mes de Inicio"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblValor.Location = New System.Drawing.Point(14, 60)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(181, 25)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Accion Desarrollada"
        '
        'txt_POA_AccioneDesarrollada
        '
        Me.txt_POA_AccioneDesarrollada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POA_AccioneDesarrollada.Location = New System.Drawing.Point(277, 57)
        Me.txt_POA_AccioneDesarrollada.MaxLength = 2000
        Me.txt_POA_AccioneDesarrollada.Multiline = True
        Me.txt_POA_AccioneDesarrollada.Name = "txt_POA_AccioneDesarrollada"
        Me.txt_POA_AccioneDesarrollada.Size = New System.Drawing.Size(462, 127)
        Me.txt_POA_AccioneDesarrollada.TabIndex = 1
        '
        'CMSCreditLine
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 521)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " POA Acciones No Programadas"
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
        Me.btnGrabar.Location = New System.Drawing.Point(558, 482)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(98, 28)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'POA_InsertAccionesNoProgramadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(811, 545)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "POA_InsertAccionesNoProgramadas"
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
    Friend WithEvents txt_POA_AccioneDesarrollada As TextBox
    Private WithEvents lblValor As Label
    Private WithEvents btnGrabar As Button
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents txt_POA_Administrador As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents CB_UnidadLider As ComboBox
    Private WithEvents Label7 As Label
    Friend WithEvents txt_POA_Presupuesto As TextBox
    Private WithEvents CB_MesInicio As ComboBox
    Private WithEvents cbMesFinal As ComboBox
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents txtAnio As TextBox
End Class

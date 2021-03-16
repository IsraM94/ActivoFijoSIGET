<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeleccionarMesAnio
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
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGerencia = New System.Windows.Forms.Label()
        Me.cbGerencia = New System.Windows.Forms.ComboBox()
        Me.txtAnioFin = New System.Windows.Forms.TextBox()
        Me.lblAnioFin = New System.Windows.Forms.Label()
        Me.txtAnioInicio = New System.Windows.Forms.TextBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblMeses = New System.Windows.Forms.Label()
        Me.comboMeses = New System.Windows.Forms.ComboBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
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
        Me.cmdCancel.Location = New System.Drawing.Point(395, 193)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
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
        Me.GroupBox1.Controls.Add(Me.lblGerencia)
        Me.GroupBox1.Controls.Add(Me.cbGerencia)
        Me.GroupBox1.Controls.Add(Me.txtAnioFin)
        Me.GroupBox1.Controls.Add(Me.lblAnioFin)
        Me.GroupBox1.Controls.Add(Me.txtAnioInicio)
        Me.GroupBox1.Controls.Add(Me.lblAnio)
        Me.GroupBox1.Controls.Add(Me.lblMeses)
        Me.GroupBox1.Controls.Add(Me.comboMeses)
        Me.GroupBox1.Controls.Add(Me.btnGrabar)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección del Mes / Año"
        '
        'lblGerencia
        '
        Me.lblGerencia.AutoSize = True
        Me.lblGerencia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGerencia.Location = New System.Drawing.Point(5, 151)
        Me.lblGerencia.Name = "lblGerencia"
        Me.lblGerencia.Size = New System.Drawing.Size(87, 25)
        Me.lblGerencia.TabIndex = 48
        Me.lblGerencia.Text = "Gerencia"
        Me.lblGerencia.Visible = False
        '
        'cbGerencia
        '
        Me.cbGerencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGerencia.FormattingEnabled = True
        Me.cbGerencia.Location = New System.Drawing.Point(98, 144)
        Me.cbGerencia.Name = "cbGerencia"
        Me.cbGerencia.Size = New System.Drawing.Size(395, 33)
        Me.cbGerencia.TabIndex = 47
        Me.cbGerencia.Visible = False
        '
        'txtAnioFin
        '
        Me.txtAnioFin.Location = New System.Drawing.Point(364, 98)
        Me.txtAnioFin.Name = "txtAnioFin"
        Me.txtAnioFin.Size = New System.Drawing.Size(129, 33)
        Me.txtAnioFin.TabIndex = 45
        Me.txtAnioFin.Visible = False
        '
        'lblAnioFin
        '
        Me.lblAnioFin.AutoSize = True
        Me.lblAnioFin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnioFin.Location = New System.Drawing.Point(277, 106)
        Me.lblAnioFin.Name = "lblAnioFin"
        Me.lblAnioFin.Size = New System.Drawing.Size(81, 25)
        Me.lblAnioFin.TabIndex = 46
        Me.lblAnioFin.Text = " Año Fin"
        Me.lblAnioFin.Visible = False
        '
        'txtAnioInicio
        '
        Me.txtAnioInicio.Location = New System.Drawing.Point(98, 98)
        Me.txtAnioInicio.Name = "txtAnioInicio"
        Me.txtAnioInicio.Size = New System.Drawing.Size(132, 33)
        Me.txtAnioInicio.TabIndex = 43
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(-5, 106)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(102, 25)
        Me.lblAnio.TabIndex = 44
        Me.lblAnio.Text = " Año Inicio"
        '
        'lblMeses
        '
        Me.lblMeses.AutoSize = True
        Me.lblMeses.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblMeses.Location = New System.Drawing.Point(15, 45)
        Me.lblMeses.Name = "lblMeses"
        Me.lblMeses.Size = New System.Drawing.Size(51, 25)
        Me.lblMeses.TabIndex = 41
        Me.lblMeses.Text = "Mes:"
        '
        'comboMeses
        '
        Me.comboMeses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboMeses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboMeses.BackColor = System.Drawing.Color.Gainsboro
        Me.comboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMeses.FormattingEnabled = True
        Me.comboMeses.Location = New System.Drawing.Point(72, 42)
        Me.comboMeses.Name = "comboMeses"
        Me.comboMeses.Size = New System.Drawing.Size(421, 33)
        Me.comboMeses.TabIndex = 42
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
        Me.btnGrabar.Location = New System.Drawing.Point(257, 193)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(118, 28)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Aceptar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'SeleccionarMesAnio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(523, 258)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SeleccionarMesAnio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnGrabar As Button
    Private WithEvents lblMeses As Label
    Private WithEvents comboMeses As ComboBox
    Friend WithEvents txtAnioInicio As TextBox
    Friend WithEvents lblAnio As Label
    Friend WithEvents txtAnioFin As TextBox
    Friend WithEvents lblAnioFin As Label
    Friend WithEvents lblGerencia As Label
    Friend WithEvents cbGerencia As ComboBox
End Class

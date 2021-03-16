<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Finance_ReportsPayableAccountsfilter
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
        Me.GBFiltroBankPettyCash = New System.Windows.Forms.GroupBox()
        Me.GBFiltroDate = New System.Windows.Forms.GroupBox()
        Me.mcFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.mcFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.chk_RangoFechas = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_TodasFechas = New System.Windows.Forms.RadioButton()
        Me.GBFiltroBankFilter = New System.Windows.Forms.GroupBox()
        Me.chk_SeleccionarProveedores = New System.Windows.Forms.RadioButton()
        Me.chk_TodoProveedores = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GBFiltroBankPettyCash.SuspendLayout()
        Me.GBFiltroDate.SuspendLayout()
        Me.GBFiltroBankFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBFiltroBankPettyCash
        '
        Me.GBFiltroBankPettyCash.BackColor = System.Drawing.SystemColors.Control
        Me.GBFiltroBankPettyCash.Controls.Add(Me.GBFiltroDate)
        Me.GBFiltroBankPettyCash.Controls.Add(Me.GBFiltroBankFilter)
        Me.GBFiltroBankPettyCash.Controls.Add(Me.cmdCancel)
        Me.GBFiltroBankPettyCash.Controls.Add(Me.cmdSave)
        Me.GBFiltroBankPettyCash.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltroBankPettyCash.Location = New System.Drawing.Point(12, 12)
        Me.GBFiltroBankPettyCash.Name = "GBFiltroBankPettyCash"
        Me.GBFiltroBankPettyCash.Size = New System.Drawing.Size(657, 390)
        Me.GBFiltroBankPettyCash.TabIndex = 31
        Me.GBFiltroBankPettyCash.TabStop = False
        Me.GBFiltroBankPettyCash.Text = "Reporte de Cuentas por Pagar"
        '
        'GBFiltroDate
        '
        Me.GBFiltroDate.Controls.Add(Me.mcFechaFinal)
        Me.GBFiltroDate.Controls.Add(Me.mcFechaInicio)
        Me.GBFiltroDate.Controls.Add(Me.chk_RangoFechas)
        Me.GBFiltroDate.Controls.Add(Me.Label3)
        Me.GBFiltroDate.Controls.Add(Me.Label2)
        Me.GBFiltroDate.Controls.Add(Me.chk_TodasFechas)
        Me.GBFiltroDate.Location = New System.Drawing.Point(29, 176)
        Me.GBFiltroDate.Name = "GBFiltroDate"
        Me.GBFiltroDate.Size = New System.Drawing.Size(596, 160)
        Me.GBFiltroDate.TabIndex = 31
        Me.GBFiltroDate.TabStop = False
        Me.GBFiltroDate.Text = "Filtro Fecha"
        '
        'mcFechaFinal
        '
        Me.mcFechaFinal.CustomFormat = "dd - MM  - yyyy"
        Me.mcFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.mcFechaFinal.Enabled = False
        Me.mcFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mcFechaFinal.Location = New System.Drawing.Point(361, 108)
        Me.mcFechaFinal.Margin = New System.Windows.Forms.Padding(0)
        Me.mcFechaFinal.Name = "mcFechaFinal"
        Me.mcFechaFinal.Size = New System.Drawing.Size(164, 29)
        Me.mcFechaFinal.TabIndex = 74
        '
        'mcFechaInicio
        '
        Me.mcFechaInicio.CustomFormat = "dd - MM  - yyyy"
        Me.mcFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.mcFechaInicio.Enabled = False
        Me.mcFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mcFechaInicio.Location = New System.Drawing.Point(361, 67)
        Me.mcFechaInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.mcFechaInicio.Name = "mcFechaInicio"
        Me.mcFechaInicio.Size = New System.Drawing.Size(164, 29)
        Me.mcFechaInicio.TabIndex = 74
        '
        'chk_RangoFechas
        '
        Me.chk_RangoFechas.AutoSize = True
        Me.chk_RangoFechas.Location = New System.Drawing.Point(20, 65)
        Me.chk_RangoFechas.Name = "chk_RangoFechas"
        Me.chk_RangoFechas.Size = New System.Drawing.Size(175, 29)
        Me.chk_RangoFechas.TabIndex = 27
        Me.chk_RangoFechas.Text = "Rango de fechas"
        Me.chk_RangoFechas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Fecha Fin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha Inicio:"
        '
        'chk_TodasFechas
        '
        Me.chk_TodasFechas.AutoSize = True
        Me.chk_TodasFechas.Checked = True
        Me.chk_TodasFechas.Location = New System.Drawing.Point(20, 27)
        Me.chk_TodasFechas.Name = "chk_TodasFechas"
        Me.chk_TodasFechas.Size = New System.Drawing.Size(169, 29)
        Me.chk_TodasFechas.TabIndex = 26
        Me.chk_TodasFechas.TabStop = True
        Me.chk_TodasFechas.Text = "Todas las fechas"
        Me.chk_TodasFechas.UseVisualStyleBackColor = True
        '
        'GBFiltroBankFilter
        '
        Me.GBFiltroBankFilter.Controls.Add(Me.chk_SeleccionarProveedores)
        Me.GBFiltroBankFilter.Controls.Add(Me.chk_TodoProveedores)
        Me.GBFiltroBankFilter.Controls.Add(Me.Label1)
        Me.GBFiltroBankFilter.Controls.Add(Me.cbProveedores)
        Me.GBFiltroBankFilter.Location = New System.Drawing.Point(29, 43)
        Me.GBFiltroBankFilter.Name = "GBFiltroBankFilter"
        Me.GBFiltroBankFilter.Size = New System.Drawing.Size(596, 115)
        Me.GBFiltroBankFilter.TabIndex = 31
        Me.GBFiltroBankFilter.TabStop = False
        Me.GBFiltroBankFilter.Text = "Filtro Proveedores"
        '
        'chk_SeleccionarProveedores
        '
        Me.chk_SeleccionarProveedores.AutoSize = True
        Me.chk_SeleccionarProveedores.Location = New System.Drawing.Point(20, 65)
        Me.chk_SeleccionarProveedores.Name = "chk_SeleccionarProveedores"
        Me.chk_SeleccionarProveedores.Size = New System.Drawing.Size(230, 29)
        Me.chk_SeleccionarProveedores.TabIndex = 27
        Me.chk_SeleccionarProveedores.Text = "Seleccionar Proveedor"
        Me.chk_SeleccionarProveedores.UseVisualStyleBackColor = True
        '
        'chk_TodoProveedores
        '
        Me.chk_TodoProveedores.AutoSize = True
        Me.chk_TodoProveedores.Checked = True
        Me.chk_TodoProveedores.Location = New System.Drawing.Point(20, 27)
        Me.chk_TodoProveedores.Name = "chk_TodoProveedores"
        Me.chk_TodoProveedores.Size = New System.Drawing.Size(230, 29)
        Me.chk_TodoProveedores.TabIndex = 26
        Me.chk_TodoProveedores.TabStop = True
        Me.chk_TodoProveedores.Text = "Todos los proveedores"
        Me.chk_TodoProveedores.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Proveedor:"
        '
        'cbProveedores
        '
        Me.cbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProveedores.BackColor = System.Drawing.Color.Gainsboro
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.Enabled = False
        Me.cbProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProveedores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(361, 66)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(219, 29)
        Me.cbProveedores.TabIndex = 1
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
        Me.cmdCancel.Location = New System.Drawing.Point(343, 352)
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
        Me.cmdSave.Location = New System.Drawing.Point(239, 352)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Generar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'ERP_Finance_ReportsPayableAccountsfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(682, 414)
        Me.Controls.Add(Me.GBFiltroBankPettyCash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Finance_ReportsPayableAccountsfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento_Generic_Municipality"
        Me.GBFiltroBankPettyCash.ResumeLayout(False)
        Me.GBFiltroDate.ResumeLayout(False)
        Me.GBFiltroDate.PerformLayout()
        Me.GBFiltroBankFilter.ResumeLayout(False)
        Me.GBFiltroBankFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBFiltroBankPettyCash As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents Label1 As Label
    Private WithEvents cbProveedores As ComboBox
    Friend WithEvents GBFiltroDate As GroupBox
    Friend WithEvents chk_RangoFechas As RadioButton
    Friend WithEvents chk_TodasFechas As RadioButton
    Friend WithEvents GBFiltroBankFilter As GroupBox
    Friend WithEvents chk_SeleccionarProveedores As RadioButton
    Friend WithEvents chk_TodoProveedores As RadioButton
    Friend WithEvents mcFechaFinal As DateTimePicker
    Friend WithEvents mcFechaInicio As DateTimePicker
    Private WithEvents Label3 As Label
    Private WithEvents Label2 As Label
End Class

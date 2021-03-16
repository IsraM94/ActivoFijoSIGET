<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MatrizProceso
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
        Me.CMSCreditLine = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.DG_Indicadores = New System.Windows.Forms.DataGridView()
        Me.IdIndi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_indicatorProces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameResultProces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeIndicadores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_Result = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Resultproces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameResultadoproces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ProcessResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_Ejes = New System.Windows.Forms.DataGridView()
        Me.IDStrategicAxes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameEjesProces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeEje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ProcessAxes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txt_Quinquenio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboListObjetivo = New System.Windows.Forms.ComboBox()
        Me.CMSCreditLine.SuspendLayout()
        Me.GroupDatosUsuario.SuspendLayout()
        CType(Me.DG_Indicadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Ejes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMSCreditLine
        '
        Me.CMSCreditLine.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMSCreditLine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSCreditLine.Name = "CMSCreditLine"
        Me.CMSCreditLine.Size = New System.Drawing.Size(143, 76)
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.ActualizarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'GroupDatosUsuario
        '
        Me.GroupDatosUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.GroupDatosUsuario.Controls.Add(Me.Label3)
        Me.GroupDatosUsuario.Controls.Add(Me.Label1)
        Me.GroupDatosUsuario.Controls.Add(Me.lblAnio)
        Me.GroupDatosUsuario.Controls.Add(Me.Button1)
        Me.GroupDatosUsuario.Controls.Add(Me.cmdGuardar)
        Me.GroupDatosUsuario.Controls.Add(Me.cmdCancelar)
        Me.GroupDatosUsuario.Controls.Add(Me.DG_Indicadores)
        Me.GroupDatosUsuario.Controls.Add(Me.DG_Result)
        Me.GroupDatosUsuario.Controls.Add(Me.DG_Ejes)
        Me.GroupDatosUsuario.Controls.Add(Me.btnSeleccionar)
        Me.GroupDatosUsuario.Controls.Add(Me.cmdCancel)
        Me.GroupDatosUsuario.Controls.Add(Me.lblValor)
        Me.GroupDatosUsuario.Controls.Add(Me.txt_Quinquenio)
        Me.GroupDatosUsuario.Controls.Add(Me.Label2)
        Me.GroupDatosUsuario.Controls.Add(Me.comboListObjetivo)
        Me.GroupDatosUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatosUsuario.Location = New System.Drawing.Point(8, 10)
        Me.GroupDatosUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Name = "GroupDatosUsuario"
        Me.GroupDatosUsuario.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupDatosUsuario.Size = New System.Drawing.Size(1050, 866)
        Me.GroupDatosUsuario.TabIndex = 0
        Me.GroupDatosUsuario.TabStop = False
        Me.GroupDatosUsuario.Text = "Datos Proceso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(15, 597)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(534, 32)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Indicadores Asignados al Resultado seleccionado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(10, 363)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 32)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Resultados Asignados al EJE seleccionado"
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(521, 101)
        Me.lblAnio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(0, 32)
        Me.lblAnio.TabIndex = 39
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
        Me.Button1.Location = New System.Drawing.Point(738, 576)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(292, 50)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Acciones del Resultado"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.cmdGuardar.Location = New System.Drawing.Point(740, 804)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(131, 50)
        Me.cmdGuardar.TabIndex = 36
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(898, 804)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(131, 50)
        Me.cmdCancelar.TabIndex = 37
        Me.cmdCancelar.Text = "Cerrar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'DG_Indicadores
        '
        Me.DG_Indicadores.AllowUserToAddRows = False
        Me.DG_Indicadores.AllowUserToDeleteRows = False
        Me.DG_Indicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Indicadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIndi, Me.ID_indicatorProces, Me.NameResultProces, Me.PorcentajeIndicadores})
        Me.DG_Indicadores.Location = New System.Drawing.Point(16, 634)
        Me.DG_Indicadores.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Indicadores.Name = "DG_Indicadores"
        Me.DG_Indicadores.RowHeadersVisible = False
        Me.DG_Indicadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Indicadores.Size = New System.Drawing.Size(1025, 160)
        Me.DG_Indicadores.TabIndex = 34
        '
        'IdIndi
        '
        Me.IdIndi.DataPropertyName = "ID_indicator"
        Me.IdIndi.HeaderText = "Id"
        Me.IdIndi.Name = "IdIndi"
        Me.IdIndi.Visible = False
        '
        'ID_indicatorProces
        '
        Me.ID_indicatorProces.DataPropertyName = "codeIndicator"
        Me.ID_indicatorProces.HeaderText = "Codigo"
        Me.ID_indicatorProces.Name = "ID_indicatorProces"
        '
        'NameResultProces
        '
        Me.NameResultProces.DataPropertyName = "Name"
        Me.NameResultProces.HeaderText = "Indicadores"
        Me.NameResultProces.Name = "NameResultProces"
        Me.NameResultProces.Width = 600
        '
        'PorcentajeIndicadores
        '
        Me.PorcentajeIndicadores.DataPropertyName = "Percentage"
        Me.PorcentajeIndicadores.HeaderText = "Porcentaje"
        Me.PorcentajeIndicadores.Name = "PorcentajeIndicadores"
        Me.PorcentajeIndicadores.Width = 150
        '
        'DG_Result
        '
        Me.DG_Result.AllowUserToAddRows = False
        Me.DG_Result.AllowUserToDeleteRows = False
        Me.DG_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Result.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.ID_Resultproces, Me.NameResultadoproces, Me.PorcentajeResult, Me.ID_ProcessResult})
        Me.DG_Result.Location = New System.Drawing.Point(16, 404)
        Me.DG_Result.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Result.Name = "DG_Result"
        Me.DG_Result.RowHeadersVisible = False
        Me.DG_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Result.Size = New System.Drawing.Size(1025, 160)
        Me.DG_Result.TabIndex = 33
        '
        'Id
        '
        Me.Id.DataPropertyName = "ID_Result"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'ID_Resultproces
        '
        Me.ID_Resultproces.DataPropertyName = "codeResult"
        Me.ID_Resultproces.HeaderText = "Codigo"
        Me.ID_Resultproces.Name = "ID_Resultproces"
        '
        'NameResultadoproces
        '
        Me.NameResultadoproces.DataPropertyName = "Name"
        Me.NameResultadoproces.HeaderText = "Resultado"
        Me.NameResultadoproces.Name = "NameResultadoproces"
        Me.NameResultadoproces.Width = 600
        '
        'PorcentajeResult
        '
        Me.PorcentajeResult.DataPropertyName = "Percentage"
        Me.PorcentajeResult.HeaderText = "Porcentaje"
        Me.PorcentajeResult.Name = "PorcentajeResult"
        Me.PorcentajeResult.Width = 150
        '
        'ID_ProcessResult
        '
        Me.ID_ProcessResult.DataPropertyName = "ID_ProcessResult"
        Me.ID_ProcessResult.HeaderText = "ID_ProcessResult"
        Me.ID_ProcessResult.Name = "ID_ProcessResult"
        Me.ID_ProcessResult.Visible = False
        '
        'DG_Ejes
        '
        Me.DG_Ejes.AllowUserToAddRows = False
        Me.DG_Ejes.AllowUserToDeleteRows = False
        Me.DG_Ejes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Ejes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDStrategicAxes, Me.Codigo, Me.NameEjesProces, Me.PorcentajeEje, Me.ID_ProcessAxes})
        Me.DG_Ejes.Location = New System.Drawing.Point(16, 156)
        Me.DG_Ejes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Ejes.Name = "DG_Ejes"
        Me.DG_Ejes.RowHeadersVisible = False
        Me.DG_Ejes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Ejes.Size = New System.Drawing.Size(1025, 198)
        Me.DG_Ejes.TabIndex = 30
        '
        'IDStrategicAxes
        '
        Me.IDStrategicAxes.DataPropertyName = "ID_Eje"
        Me.IDStrategicAxes.HeaderText = "Id"
        Me.IDStrategicAxes.Name = "IDStrategicAxes"
        Me.IDStrategicAxes.Visible = False
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "CodeAxes"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'NameEjesProces
        '
        Me.NameEjesProces.DataPropertyName = "Eje"
        Me.NameEjesProces.HeaderText = "Ejes Estratégicos "
        Me.NameEjesProces.Name = "NameEjesProces"
        Me.NameEjesProces.Width = 650
        '
        'PorcentajeEje
        '
        Me.PorcentajeEje.DataPropertyName = "Percentage"
        Me.PorcentajeEje.HeaderText = "Porcentaje"
        Me.PorcentajeEje.Name = "PorcentajeEje"
        Me.PorcentajeEje.Width = 150
        '
        'ID_ProcessAxes
        '
        Me.ID_ProcessAxes.DataPropertyName = "ID_ProcessAxes"
        Me.ID_ProcessAxes.HeaderText = "ID_ProcessAxes"
        Me.ID_ProcessAxes.Name = "ID_ProcessAxes"
        Me.ID_ProcessAxes.Visible = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(680, 92)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(151, 48)
        Me.btnSeleccionar.TabIndex = 4
        Me.btnSeleccionar.Text = "Agregar EJE"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
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
        Me.cmdCancel.Location = New System.Drawing.Point(857, 92)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(169, 48)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Eliminar EJE"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblValor.Location = New System.Drawing.Point(15, 101)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(142, 32)
        Me.lblValor.TabIndex = 29
        Me.lblValor.Text = "Quinquenio"
        '
        'txt_Quinquenio
        '
        Me.txt_Quinquenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quinquenio.Location = New System.Drawing.Point(325, 97)
        Me.txt_Quinquenio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Quinquenio.MaxLength = 150
        Me.txt_Quinquenio.Name = "txt_Quinquenio"
        Me.txt_Quinquenio.Size = New System.Drawing.Size(175, 37)
        Me.txt_Quinquenio.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 32)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Objetivo Estrategico:"
        '
        'comboListObjetivo
        '
        Me.comboListObjetivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListObjetivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListObjetivo.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListObjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboListObjetivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListObjetivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListObjetivo.FormattingEnabled = True
        Me.comboListObjetivo.Location = New System.Drawing.Point(325, 38)
        Me.comboListObjetivo.Margin = New System.Windows.Forms.Padding(4)
        Me.comboListObjetivo.Name = "comboListObjetivo"
        Me.comboListObjetivo.Size = New System.Drawing.Size(711, 38)
        Me.comboListObjetivo.TabIndex = 27
        '
        'MatrizProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1070, 887)
        Me.Controls.Add(Me.GroupDatosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MatrizProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        Me.CMSCreditLine.ResumeLayout(False)
        Me.GroupDatosUsuario.ResumeLayout(False)
        Me.GroupDatosUsuario.PerformLayout()
        CType(Me.DG_Indicadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Result, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Ejes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMSCreditLine As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupDatosUsuario As GroupBox
    Private WithEvents Label3 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents lblAnio As Label
    Private WithEvents Button1 As Button
    Private WithEvents cmdGuardar As Button
    Private WithEvents cmdCancelar As Button
    Friend WithEvents DG_Indicadores As DataGridView
    Friend WithEvents DG_Result As DataGridView
    Friend WithEvents DG_Ejes As DataGridView
    Private WithEvents btnSeleccionar As Button
    Private WithEvents cmdCancel As Button
    Private WithEvents lblValor As Label
    Friend WithEvents txt_Quinquenio As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents comboListObjetivo As ComboBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents ID_Resultproces As DataGridViewTextBoxColumn
    Friend WithEvents NameResultadoproces As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeResult As DataGridViewTextBoxColumn
    Friend WithEvents ID_ProcessResult As DataGridViewTextBoxColumn
    Friend WithEvents IdIndi As DataGridViewTextBoxColumn
    Friend WithEvents ID_indicatorProces As DataGridViewTextBoxColumn
    Friend WithEvents NameResultProces As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeIndicadores As DataGridViewTextBoxColumn
    Friend WithEvents IDStrategicAxes As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents NameEjesProces As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeEje As DataGridViewTextBoxColumn
    Friend WithEvents ID_ProcessAxes As DataGridViewTextBoxColumn
End Class

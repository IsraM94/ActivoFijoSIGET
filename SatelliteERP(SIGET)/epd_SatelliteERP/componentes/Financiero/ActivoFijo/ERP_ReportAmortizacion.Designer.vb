<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_ReportAmortizacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTangible = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.dgHeader = New System.Windows.Forms.DataGridView()
        Me.id_headerFK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.daterProcess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionBD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Reporte = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkTangible)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdClasificacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.gbFiltros)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_Reporte)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(780, 582)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte"
        '
        'chkTangible
        '
        Me.chkTangible.AutoSize = True
        Me.chkTangible.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTangible.Location = New System.Drawing.Point(135, 119)
        Me.chkTangible.Name = "chkTangible"
        Me.chkTangible.Size = New System.Drawing.Size(15, 14)
        Me.chkTangible.TabIndex = 90
        Me.chkTangible.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Tangible: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label2.Location = New System.Drawing.Point(17, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Clasificación:"
        '
        'cmdClasificacion
        '
        Me.cmdClasificacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmdClasificacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdClasificacion.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdClasificacion.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmdClasificacion.FormattingEnabled = True
        Me.cmdClasificacion.Items.AddRange(New Object() {"Status Depreciacion Activo Fijo", "Activos Modificados por Fecha Depreciacion.", "Total de Activos Fijos Depreciados por Encabezado"})
        Me.cmdClasificacion.Location = New System.Drawing.Point(135, 159)
        Me.cmdClasificacion.Name = "cmdClasificacion"
        Me.cmdClasificacion.Size = New System.Drawing.Size(606, 33)
        Me.cmdClasificacion.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label1.Location = New System.Drawing.Point(65, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Status:"
        '
        'cbStatus
        '
        Me.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Enabled = False
        Me.cbStatus.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Todos", "Depreciado", "No Depreciado"})
        Me.cbStatus.Location = New System.Drawing.Point(135, 68)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(606, 33)
        Me.cbStatus.TabIndex = 85
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(679, 533)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 29)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.dgHeader)
        Me.gbFiltros.Location = New System.Drawing.Point(38, 200)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(703, 315)
        Me.gbFiltros.TabIndex = 83
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros del Reporte"
        '
        'dgHeader
        '
        Me.dgHeader.AllowUserToAddRows = False
        Me.dgHeader.AllowUserToDeleteRows = False
        Me.dgHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHeader.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_headerFK, Me.daterProcess, Me.DescriptionBD})
        Me.dgHeader.Location = New System.Drawing.Point(19, 25)
        Me.dgHeader.Name = "dgHeader"
        Me.dgHeader.ReadOnly = True
        Me.dgHeader.Size = New System.Drawing.Size(678, 284)
        Me.dgHeader.TabIndex = 0
        '
        'id_headerFK
        '
        Me.id_headerFK.DataPropertyName = "id_header"
        Me.id_headerFK.HeaderText = "IdHeader"
        Me.id_headerFK.Name = "id_headerFK"
        Me.id_headerFK.ReadOnly = True
        Me.id_headerFK.Visible = False
        '
        'daterProcess
        '
        Me.daterProcess.DataPropertyName = "dateDepreciation"
        Me.daterProcess.HeaderText = "Fecha Depreciación"
        Me.daterProcess.Name = "daterProcess"
        Me.daterProcess.ReadOnly = True
        Me.daterProcess.Width = 200
        '
        'DescriptionBD
        '
        Me.DescriptionBD.DataPropertyName = "descriptiondepre"
        Me.DescriptionBD.HeaderText = "Descripción "
        Me.DescriptionBD.Name = "DescriptionBD"
        Me.DescriptionBD.ReadOnly = True
        Me.DescriptionBD.Width = 425
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
        Me.cmdCancel.Location = New System.Drawing.Point(344, 521)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(118, 41)
        Me.cmdCancel.TabIndex = 2
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
        Me.cmdSave.Location = New System.Drawing.Point(217, 521)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(118, 41)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Reporte"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label5.Location = New System.Drawing.Point(51, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Reporte:"
        '
        'cb_Reporte
        '
        Me.cb_Reporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Reporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Reporte.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Reporte.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cb_Reporte.FormattingEnabled = True
        Me.cb_Reporte.Items.AddRange(New Object() {"Status Depreciacion Activo Fijo", "Activos Modificados por Fecha Depreciacion.", "Total de Activos Fijos Depreciados por Encabezado"})
        Me.cb_Reporte.Location = New System.Drawing.Point(135, 29)
        Me.cb_Reporte.Name = "cb_Reporte"
        Me.cb_Reporte.Size = New System.Drawing.Size(606, 33)
        Me.cb_Reporte.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(-134, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Ubicación : "
        '
        'ERP_ReportAmortizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(802, 608)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_ReportAmortizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_ReportTrasnfer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        CType(Me.dgHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents Label5 As Label
    Private WithEvents cb_Reporte As ComboBox
    Private WithEvents Label9 As Label
    Friend WithEvents gbFiltros As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgHeader As DataGridView
    Private WithEvents Label1 As Label
    Private WithEvents cbStatus As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents cmdClasificacion As ComboBox
    Friend WithEvents id_headerFK As DataGridViewTextBoxColumn
    Friend WithEvents daterProcess As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionBD As DataGridViewTextBoxColumn
    Friend WithEvents chkTangible As CheckBox
    Private WithEvents Label4 As Label
End Class

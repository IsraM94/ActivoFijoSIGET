<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Financiero_Buscar_Bienes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblCodigoBarra = New System.Windows.Forms.Label()
        Me.dgv_Bienes = New System.Windows.Forms.DataGridView()
        Me.id_bien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_adquisicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_adquisicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Bienes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.lblCodigoBarra)
        Me.GroupBox1.Controls.Add(Me.dgv_Bienes)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 383)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bienes"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(93, 339)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(357, 26)
        Me.txtBuscar.TabIndex = 52
        '
        'lblCodigoBarra
        '
        Me.lblCodigoBarra.AutoSize = True
        Me.lblCodigoBarra.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblCodigoBarra.Location = New System.Drawing.Point(15, 337)
        Me.lblCodigoBarra.Name = "lblCodigoBarra"
        Me.lblCodigoBarra.Size = New System.Drawing.Size(72, 25)
        Me.lblCodigoBarra.TabIndex = 51
        Me.lblCodigoBarra.Text = "Buscar:"
        '
        'dgv_Bienes
        '
        Me.dgv_Bienes.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgv_Bienes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Bienes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_bien, Me.Codigo, Me.bien, Me.numero_serie, Me.clasificacion, Me.sub_clasificacion, Me.fecha_adquisicion, Me.valor_adquisicion, Me.ubicacion})
        Me.dgv_Bienes.Location = New System.Drawing.Point(6, 32)
        Me.dgv_Bienes.Name = "dgv_Bienes"
        Me.dgv_Bienes.ReadOnly = True
        Me.dgv_Bienes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Bienes.Size = New System.Drawing.Size(858, 290)
        Me.dgv_Bienes.TabIndex = 0
        '
        'id_bien
        '
        Me.id_bien.DataPropertyName = "id_bien"
        Me.id_bien.FillWeight = 76.80492!
        Me.id_bien.HeaderText = "Id"
        Me.id_bien.Name = "id_bien"
        Me.id_bien.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 163.0311!
        Me.Codigo.HeaderText = "Codigo Bien"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 212
        '
        'bien
        '
        Me.bien.DataPropertyName = "bien"
        Me.bien.FillWeight = 109.4714!
        Me.bien.HeaderText = "Nombre bien"
        Me.bien.Name = "bien"
        Me.bien.ReadOnly = True
        Me.bien.Width = 143
        '
        'numero_serie
        '
        Me.numero_serie.DataPropertyName = "numero_serie"
        Me.numero_serie.FillWeight = 72.67368!
        Me.numero_serie.HeaderText = "Numero Serie"
        Me.numero_serie.Name = "numero_serie"
        Me.numero_serie.ReadOnly = True
        Me.numero_serie.Width = 94
        '
        'clasificacion
        '
        Me.clasificacion.DataPropertyName = "clasificacion"
        Me.clasificacion.FillWeight = 78.0189!
        Me.clasificacion.HeaderText = "clasificacion"
        Me.clasificacion.Name = "clasificacion"
        Me.clasificacion.ReadOnly = True
        Me.clasificacion.Width = 102
        '
        'sub_clasificacion
        '
        Me.sub_clasificacion.DataPropertyName = "sub_clasificacion"
        Me.sub_clasificacion.HeaderText = "Sub Clasificacion"
        Me.sub_clasificacion.Name = "sub_clasificacion"
        Me.sub_clasificacion.ReadOnly = True
        '
        'fecha_adquisicion
        '
        Me.fecha_adquisicion.DataPropertyName = "fecha_adquisicion"
        Me.fecha_adquisicion.HeaderText = "Fecha Adquisicion"
        Me.fecha_adquisicion.Name = "fecha_adquisicion"
        Me.fecha_adquisicion.ReadOnly = True
        '
        'valor_adquisicion
        '
        Me.valor_adquisicion.DataPropertyName = "valor_adquisicion"
        Me.valor_adquisicion.HeaderText = "Valor Adquisicion"
        Me.valor_adquisicion.Name = "valor_adquisicion"
        Me.valor_adquisicion.ReadOnly = True
        '
        'ubicacion
        '
        Me.ubicacion.DataPropertyName = "ubicacion"
        Me.ubicacion.HeaderText = "Ubicacion"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.ReadOnly = True
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(766, 338)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ERP_Financiero_Buscar_Bienes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(894, 409)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Financiero_Buscar_Bienes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_Financiero_Buscar_Bienes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Bienes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_Bienes As DataGridView
    Private WithEvents cmdCancel As Button
    Friend WithEvents id_bien As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents bien As DataGridViewTextBoxColumn
    Friend WithEvents numero_serie As DataGridViewTextBoxColumn
    Friend WithEvents clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents sub_clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents fecha_adquisicion As DataGridViewTextBoxColumn
    Friend WithEvents valor_adquisicion As DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As DataGridViewTextBoxColumn
    Private WithEvents txtBuscar As TextBox
    Private WithEvents lblCodigoBarra As Label
End Class

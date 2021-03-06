<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_PreviewAmortizacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgPreview = New System.Windows.Forms.DataGridView()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.transferido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Babbra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_ResponsiblePerson_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAdquisicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diastrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgPreview)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1055, 477)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procesar Amortización Activo Fijo"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(315, 41)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 25)
        Me.lblTotal.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 25)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Total de Activos a Amortizar:"
        '
        'dgPreview
        '
        Me.dgPreview.AllowUserToAddRows = False
        Me.dgPreview.AllowUserToDeleteRows = False
        Me.dgPreview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPreview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transferido, Me.Babbra, Me.Id_ResponsiblePerson_FK, Me.FechaAdquisicion, Me.color, Me.diastrans, Me.DescripcionEstado, Me.Modelo, Me.Marca, Me.NoSerie})
        Me.dgPreview.EnableHeadersVisualStyles = False
        Me.dgPreview.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPreview.Location = New System.Drawing.Point(6, 73)
        Me.dgPreview.Name = "dgPreview"
        Me.dgPreview.ReadOnly = True
        Me.dgPreview.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPreview.RowHeadersVisible = False
        Me.dgPreview.ShowCellErrors = False
        Me.dgPreview.ShowCellToolTips = False
        Me.dgPreview.ShowEditingIcon = False
        Me.dgPreview.ShowRowErrors = False
        Me.dgPreview.Size = New System.Drawing.Size(1043, 357)
        Me.dgPreview.TabIndex = 73
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
        Me.cmdCancel.Location = New System.Drawing.Point(450, 442)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 72
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'transferido
        '
        Me.transferido.DataPropertyName = "clasificacion"
        Me.transferido.HeaderText = "Clasificacion"
        Me.transferido.Name = "transferido"
        Me.transferido.ReadOnly = True
        Me.transferido.Width = 300
        '
        'Babbra
        '
        Me.Babbra.DataPropertyName = "Codigo"
        Me.Babbra.HeaderText = "Codigo"
        Me.Babbra.Name = "Babbra"
        Me.Babbra.ReadOnly = True
        Me.Babbra.Width = 150
        '
        'Id_ResponsiblePerson_FK
        '
        Me.Id_ResponsiblePerson_FK.DataPropertyName = "Descripcion"
        Me.Id_ResponsiblePerson_FK.HeaderText = "Nombre Activo"
        Me.Id_ResponsiblePerson_FK.Name = "Id_ResponsiblePerson_FK"
        Me.Id_ResponsiblePerson_FK.ReadOnly = True
        Me.Id_ResponsiblePerson_FK.Width = 300
        '
        'FechaAdquisicion
        '
        Me.FechaAdquisicion.DataPropertyName = "FechaAdquisicion"
        Me.FechaAdquisicion.HeaderText = "Fecha Adquisicion"
        Me.FechaAdquisicion.Name = "FechaAdquisicion"
        Me.FechaAdquisicion.ReadOnly = True
        Me.FechaAdquisicion.Width = 150
        '
        'color
        '
        Me.color.DataPropertyName = "CostoAdquisicion"
        Me.color.HeaderText = "Monto Adquisicion"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        Me.color.Width = 150
        '
        'diastrans
        '
        Me.diastrans.DataPropertyName = "VidaUtil"
        Me.diastrans.HeaderText = "Vida Util"
        Me.diastrans.Name = "diastrans"
        Me.diastrans.ReadOnly = True
        '
        'DescripcionEstado
        '
        Me.DescripcionEstado.DataPropertyName = "FechaAmortizacion"
        Me.DescripcionEstado.HeaderText = "Fecha Amortizacion"
        Me.DescripcionEstado.Name = "DescripcionEstado"
        Me.DescripcionEstado.ReadOnly = True
        Me.DescripcionEstado.Width = 150
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "CuotaSemestral"
        Me.Modelo.HeaderText = "Cuota Semestral"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 150
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "AmortizacionAcumulada"
        Me.Marca.HeaderText = "Amortizacion Acumulada"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 150
        '
        'NoSerie
        '
        Me.NoSerie.DataPropertyName = "ValorLibros"
        Me.NoSerie.HeaderText = "Valor Libros"
        Me.NoSerie.Name = "NoSerie"
        Me.NoSerie.ReadOnly = True
        Me.NoSerie.Width = 150
        '
        'ERP_PreviewAmortizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1079, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_PreviewAmortizacion"
        Me.Text = "ERP_PreviewDepreciacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Friend WithEvents dgPreview As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents transferido As DataGridViewTextBoxColumn
    Friend WithEvents Babbra As DataGridViewTextBoxColumn
    Friend WithEvents Id_ResponsiblePerson_FK As DataGridViewTextBoxColumn
    Friend WithEvents FechaAdquisicion As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents diastrans As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionEstado As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents NoSerie As DataGridViewTextBoxColumn
End Class

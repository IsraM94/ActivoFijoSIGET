<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Financiero_Procesos_DepreciacionAgregarAc

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
        Me.PnAgregarActivos = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregarActivosA = New System.Windows.Forms.Button()
        Me.btnCerrarActivos = New System.Windows.Forms.Button()
        Me.DGBuscarActivos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.PnAgregarActivos.SuspendLayout()
        CType(Me.DGBuscarActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.PnAgregarActivos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 562)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Activos Fijos"
        '
        'PnAgregarActivos
        '
        Me.PnAgregarActivos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnAgregarActivos.Controls.Add(Me.Label6)
        Me.PnAgregarActivos.Controls.Add(Me.btnAgregarActivosA)
        Me.PnAgregarActivos.Controls.Add(Me.btnCerrarActivos)
        Me.PnAgregarActivos.Controls.Add(Me.DGBuscarActivos)
        Me.PnAgregarActivos.Location = New System.Drawing.Point(6, 26)
        Me.PnAgregarActivos.Name = "PnAgregarActivos"
        Me.PnAgregarActivos.Size = New System.Drawing.Size(632, 526)
        Me.PnAgregarActivos.TabIndex = 76
        Me.PnAgregarActivos.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 464)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(391, 50)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Seleccione los Activos para agregarlos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al proceso de Depreciación."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregarActivosA
        '
        Me.btnAgregarActivosA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarActivosA.Location = New System.Drawing.Point(188, 405)
        Me.btnAgregarActivosA.Name = "btnAgregarActivosA"
        Me.btnAgregarActivosA.Size = New System.Drawing.Size(129, 31)
        Me.btnAgregarActivosA.TabIndex = 78
        Me.btnAgregarActivosA.Text = "Agregar Activos"
        Me.btnAgregarActivosA.UseVisualStyleBackColor = True
        '
        'btnCerrarActivos
        '
        Me.btnCerrarActivos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarActivos.Location = New System.Drawing.Point(323, 405)
        Me.btnCerrarActivos.Name = "btnCerrarActivos"
        Me.btnCerrarActivos.Size = New System.Drawing.Size(129, 31)
        Me.btnCerrarActivos.TabIndex = 77
        Me.btnCerrarActivos.Text = "Cerrar"
        Me.btnCerrarActivos.UseVisualStyleBackColor = True
        '
        'DGBuscarActivos
        '
        Me.DGBuscarActivos.AllowUserToAddRows = False
        Me.DGBuscarActivos.AllowUserToDeleteRows = False
        Me.DGBuscarActivos.AllowUserToOrderColumns = True
        Me.DGBuscarActivos.AllowUserToResizeColumns = False
        Me.DGBuscarActivos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBuscarActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGBuscarActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBuscarActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.FechaVencimiento})
        Me.DGBuscarActivos.Location = New System.Drawing.Point(5, 3)
        Me.DGBuscarActivos.Name = "DGBuscarActivos"
        Me.DGBuscarActivos.ReadOnly = True
        Me.DGBuscarActivos.RowHeadersVisible = False
        Me.DGBuscarActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBuscarActivos.Size = New System.Drawing.Size(624, 370)
        Me.DGBuscarActivos.TabIndex = 76
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_FixedAssets"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdActivo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Number_Purchase"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name_FiexdAssets"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NombreActivo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 240
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Amount_Acquired"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto Adquisicion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.DataPropertyName = "FechaMaxDepreciacion"
        Me.FechaVencimiento.HeaderText = "Depreciacion Final"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        Me.FechaVencimiento.Width = 170
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'Financiero_Procesos_DepreciacionAgregarAc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(670, 605)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_Procesos_DepreciacionAgregarAc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_ReportTrasnfer"
        Me.GroupBox1.ResumeLayout(False)
        Me.PnAgregarActivos.ResumeLayout(False)
        Me.PnAgregarActivos.PerformLayout()
        CType(Me.DGBuscarActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PnAgregarActivos As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAgregarActivosA As Button
    Friend WithEvents btnCerrarActivos As Button
    Friend WithEvents DGBuscarActivos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As DataGridViewTextBoxColumn
End Class

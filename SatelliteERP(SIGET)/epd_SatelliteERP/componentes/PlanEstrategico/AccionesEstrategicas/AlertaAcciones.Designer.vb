<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlertaAcciones
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.dgEstrategicas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgOperativas = New System.Windows.Forms.DataGridView()
        Me.CodigoAccionE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAccionE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgEstrategicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgOperativas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdCancel.Location = New System.Drawing.Point(911, 464)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cerrar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'dgEstrategicas
        '
        Me.dgEstrategicas.AllowUserToAddRows = False
        Me.dgEstrategicas.AllowUserToDeleteRows = False
        Me.dgEstrategicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEstrategicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoAccionE, Me.NombreAccionE, Me.ResultadoE, Me.UnidadE, Me.FechaE})
        Me.dgEstrategicas.Location = New System.Drawing.Point(6, 32)
        Me.dgEstrategicas.Name = "dgEstrategicas"
        Me.dgEstrategicas.ReadOnly = True
        Me.dgEstrategicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstrategicas.Size = New System.Drawing.Size(1009, 205)
        Me.dgEstrategicas.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.dgOperativas)
        Me.GroupBox1.Controls.Add(Me.dgEstrategicas)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1021, 496)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones Estratégicas y de Apoyo por Vencer."
        '
        'dgOperativas
        '
        Me.dgOperativas.AllowUserToAddRows = False
        Me.dgOperativas.AllowUserToDeleteRows = False
        Me.dgOperativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOperativas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgOperativas.Location = New System.Drawing.Point(6, 253)
        Me.dgOperativas.Name = "dgOperativas"
        Me.dgOperativas.ReadOnly = True
        Me.dgOperativas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOperativas.Size = New System.Drawing.Size(1009, 205)
        Me.dgOperativas.TabIndex = 31
        '
        'CodigoAccionE
        '
        Me.CodigoAccionE.DataPropertyName = "CodigoAccion"
        Me.CodigoAccionE.HeaderText = "Codigo"
        Me.CodigoAccionE.Name = "CodigoAccionE"
        Me.CodigoAccionE.ReadOnly = True
        '
        'NombreAccionE
        '
        Me.NombreAccionE.DataPropertyName = "Name"
        Me.NombreAccionE.HeaderText = "Accion Estratégica"
        Me.NombreAccionE.Name = "NombreAccionE"
        Me.NombreAccionE.ReadOnly = True
        Me.NombreAccionE.Width = 400
        '
        'ResultadoE
        '
        Me.ResultadoE.DataPropertyName = "result"
        Me.ResultadoE.HeaderText = "Resultado"
        Me.ResultadoE.Name = "ResultadoE"
        Me.ResultadoE.ReadOnly = True
        Me.ResultadoE.Width = 215
        '
        'UnidadE
        '
        Me.UnidadE.DataPropertyName = "UnidadLider"
        Me.UnidadE.HeaderText = "Unidad Lider"
        Me.UnidadE.Name = "UnidadE"
        Me.UnidadE.ReadOnly = True
        Me.UnidadE.Width = 150
        '
        'FechaE
        '
        Me.FechaE.DataPropertyName = "FechaVencimiento"
        Me.FechaE.HeaderText = "Fecha de Vencimiento"
        Me.FechaE.Name = "FechaE"
        Me.FechaE.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoAccion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Accion Estratégica"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "result"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Resultado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 215
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UnidadLider"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unidad Lider"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaVencimiento"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha de Vencimiento"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'AlertaAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1045, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AlertaAcciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_CreditLine"
        CType(Me.dgEstrategicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgOperativas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgEstrategicas As DataGridView
    Friend WithEvents dgOperativas As DataGridView
    Friend WithEvents CodigoAccionE As DataGridViewTextBoxColumn
    Friend WithEvents NombreAccionE As DataGridViewTextBoxColumn
    Friend WithEvents ResultadoE As DataGridViewTextBoxColumn
    Friend WithEvents UnidadE As DataGridViewTextBoxColumn
    Friend WithEvents FechaE As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class

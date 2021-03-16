<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Inventory_SelectReportFixedAssetsLegacy
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
        Me.gbElegirReporteEmpleados = New System.Windows.Forms.GroupBox()
        Me.cmdReporteLegacy = New System.Windows.Forms.Button()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdReporteInventario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbElegirReporteEmpleados.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbElegirReporteEmpleados
        '
        Me.gbElegirReporteEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.gbElegirReporteEmpleados.Controls.Add(Me.cmdReporteLegacy)
        Me.gbElegirReporteEmpleados.Controls.Add(Me.cmbEmpleados)
        Me.gbElegirReporteEmpleados.Controls.Add(Me.cmdCancel)
        Me.gbElegirReporteEmpleados.Controls.Add(Me.cmdReporteInventario)
        Me.gbElegirReporteEmpleados.Controls.Add(Me.Label1)
        Me.gbElegirReporteEmpleados.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbElegirReporteEmpleados.Location = New System.Drawing.Point(12, 12)
        Me.gbElegirReporteEmpleados.Name = "gbElegirReporteEmpleados"
        Me.gbElegirReporteEmpleados.Size = New System.Drawing.Size(646, 158)
        Me.gbElegirReporteEmpleados.TabIndex = 31
        Me.gbElegirReporteEmpleados.TabStop = False
        Me.gbElegirReporteEmpleados.Text = "Elegir Tipo de Reporte"
        '
        'cmdReporteLegacy
        '
        Me.cmdReporteLegacy.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdReporteLegacy.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdReporteLegacy.FlatAppearance.BorderSize = 0
        Me.cmdReporteLegacy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporteLegacy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporteLegacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReporteLegacy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReporteLegacy.Location = New System.Drawing.Point(236, 111)
        Me.cmdReporteLegacy.Name = "cmdReporteLegacy"
        Me.cmdReporteLegacy.Size = New System.Drawing.Size(174, 29)
        Me.cmdReporteLegacy.TabIndex = 32
        Me.cmdReporteLegacy.Text = "Reporte Legacy"
        Me.cmdReporteLegacy.UseVisualStyleBackColor = False
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleados.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(117, 47)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(523, 33)
        Me.cmbEmpleados.TabIndex = 31
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
        Me.cmdCancel.Location = New System.Drawing.Point(462, 111)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(174, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdReporteInventario
        '
        Me.cmdReporteInventario.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdReporteInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdReporteInventario.FlatAppearance.BorderSize = 0
        Me.cmdReporteInventario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporteInventario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporteInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReporteInventario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReporteInventario.Location = New System.Drawing.Point(14, 111)
        Me.cmdReporteInventario.Name = "cmdReporteInventario"
        Me.cmdReporteInventario.Size = New System.Drawing.Size(174, 29)
        Me.cmdReporteInventario.TabIndex = 29
        Me.cmdReporteInventario.Text = "Reporte Activos"
        Me.cmdReporteInventario.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Empleado :"
        '
        'ERP_Inventory_SelectReportFixedAssetsLegacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(670, 183)
        Me.Controls.Add(Me.gbElegirReporteEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Inventory_SelectReportFixedAssetsLegacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento_Generic_Municipality"
        Me.gbElegirReporteEmpleados.ResumeLayout(False)
        Me.gbElegirReporteEmpleados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbElegirReporteEmpleados As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdReporteInventario As Button
    Friend WithEvents cmbEmpleados As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents cmdReporteLegacy As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario_Saldo_Existencia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdFiltroCancel = New System.Windows.Forms.Button()
        Me.cmdFiltrarSaldo = New System.Windows.Forms.Button()
        Me.label49 = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmbAnio)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdFiltroCancel)
        Me.GroupBox1.Controls.Add(Me.cmdFiltrarSaldo)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 215)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccciona filtro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(25, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Año:"
        '
        'cmdFiltroCancel
        '
        Me.cmdFiltroCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdFiltroCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroCancel.FlatAppearance.BorderSize = 0
        Me.cmdFiltroCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltroCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltroCancel.Location = New System.Drawing.Point(240, 166)
        Me.cmdFiltroCancel.Name = "cmdFiltroCancel"
        Me.cmdFiltroCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdFiltroCancel.TabIndex = 30
        Me.cmdFiltroCancel.Text = "Cancelar"
        Me.cmdFiltroCancel.UseVisualStyleBackColor = False
        '
        'cmdFiltrarSaldo
        '
        Me.cmdFiltrarSaldo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdFiltrarSaldo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdFiltrarSaldo.FlatAppearance.BorderSize = 0
        Me.cmdFiltrarSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltrarSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltrarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrarSaldo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltrarSaldo.Location = New System.Drawing.Point(123, 166)
        Me.cmdFiltrarSaldo.Name = "cmdFiltrarSaldo"
        Me.cmdFiltrarSaldo.Size = New System.Drawing.Size(98, 29)
        Me.cmdFiltrarSaldo.TabIndex = 29
        Me.cmdFiltrarSaldo.Text = "Continuar"
        Me.cmdFiltrarSaldo.UseVisualStyleBackColor = False
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(24, 58)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(51, 25)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Mes:"
        '
        'cmbMes
        '
        Me.cmbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMes.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbMes.Location = New System.Drawing.Point(95, 50)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(239, 33)
        Me.cmbMes.TabIndex = 88
        '
        'cmbAnio
        '
        Me.cmbAnio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAnio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAnio.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(95, 94)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(239, 33)
        Me.cmbAnio.TabIndex = 89
        '
        'Inventario_Saldo_Existencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(378, 237)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventario_Saldo_Existencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario_Saldo_Existencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents cmdFiltroCancel As Button
    Private WithEvents cmdFiltrarSaldo As Button
    Private WithEvents label49 As Label
    Private WithEvents cmbMes As ComboBox
    Private WithEvents cmbAnio As ComboBox
End Class

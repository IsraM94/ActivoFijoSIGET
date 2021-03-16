<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_CrearPartidaContablesMontos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_IsDeductible = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_CentroCosto = New System.Windows.Forms.ComboBox()
        Me.txtConcept = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbHaber = New System.Windows.Forms.RadioButton()
        Me.rbDebe = New System.Windows.Forms.RadioButton()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAcept = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CB_IsDeductible)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_CentroCosto)
        Me.GroupBox1.Controls.Add(Me.txtConcept)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbHaber)
        Me.GroupBox1.Controls.Add(Me.rbDebe)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdAcept)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 293)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Montos"
        '
        'CB_IsDeductible
        '
        Me.CB_IsDeductible.AutoSize = True
        Me.CB_IsDeductible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_IsDeductible.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.CB_IsDeductible.Location = New System.Drawing.Point(191, 209)
        Me.CB_IsDeductible.Name = "CB_IsDeductible"
        Me.CB_IsDeductible.Size = New System.Drawing.Size(136, 29)
        Me.CB_IsDeductible.TabIndex = 37
        Me.CB_IsDeductible.Text = "Es Deducible"
        Me.CB_IsDeductible.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Centro de Costo:"
        '
        'CB_CentroCosto
        '
        Me.CB_CentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CentroCosto.FormattingEnabled = True
        Me.CB_CentroCosto.Location = New System.Drawing.Point(58, 86)
        Me.CB_CentroCosto.Name = "CB_CentroCosto"
        Me.CB_CentroCosto.Size = New System.Drawing.Size(269, 33)
        Me.CB_CentroCosto.TabIndex = 35
        '
        'txtConcept
        '
        Me.txtConcept.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConcept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConcept.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcept.Location = New System.Drawing.Point(58, 145)
        Me.txtConcept.Name = "txtConcept"
        Me.txtConcept.Size = New System.Drawing.Size(266, 26)
        Me.txtConcept.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Concepto :"
        '
        'rbHaber
        '
        Me.rbHaber.AutoSize = True
        Me.rbHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbHaber.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbHaber.Location = New System.Drawing.Point(205, 33)
        Me.rbHaber.Name = "rbHaber"
        Me.rbHaber.Size = New System.Drawing.Size(80, 29)
        Me.rbHaber.TabIndex = 32
        Me.rbHaber.TabStop = True
        Me.rbHaber.Text = "Haber"
        Me.rbHaber.UseVisualStyleBackColor = True
        '
        'rbDebe
        '
        Me.rbDebe.AutoSize = True
        Me.rbDebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDebe.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbDebe.Location = New System.Drawing.Point(86, 33)
        Me.rbDebe.Name = "rbDebe"
        Me.rbDebe.Size = New System.Drawing.Size(73, 29)
        Me.rbDebe.TabIndex = 31
        Me.rbDebe.TabStop = True
        Me.rbDebe.Text = "Debe"
        Me.rbDebe.UseVisualStyleBackColor = True
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
        Me.cmdCancel.Location = New System.Drawing.Point(228, 249)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAcept
        '
        Me.cmdAcept.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAcept.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdAcept.FlatAppearance.BorderSize = 0
        Me.cmdAcept.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdAcept.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdAcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAcept.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcept.Location = New System.Drawing.Point(124, 249)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(98, 29)
        Me.cmdAcept.TabIndex = 29
        Me.cmdAcept.Text = "Aceptar"
        Me.cmdAcept.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(154, 177)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(170, 26)
        Me.txtMonto.TabIndex = 26
        Me.txtMonto.Text = "0"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Montos :"
        '
        'Financiero_CrearPartidaContablesMontos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(399, 314)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_CrearPartidaContablesMontos"
        Me.Text = "Financiero_CrearPartidadContablesMontos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdAcept As Button
    Private WithEvents txtMonto As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents rbHaber As RadioButton
    Friend WithEvents rbDebe As RadioButton
    Private WithEvents txtConcept As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents CB_CentroCosto As ComboBox
    Friend WithEvents CB_IsDeductible As CheckBox
End Class

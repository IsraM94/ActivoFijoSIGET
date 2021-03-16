<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_DocumentoCheques
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Bank = New System.Windows.Forms.ComboBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
        Me.label50 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_Bank)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdContinue)
        Me.GroupBox1.Controls.Add(Me.txtNoCheque)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 191)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Numero Cheque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Banco  :"
        '
        'CB_Bank
        '
        Me.CB_Bank.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Bank.FormattingEnabled = True
        Me.CB_Bank.Location = New System.Drawing.Point(12, 48)
        Me.CB_Bank.Name = "CB_Bank"
        Me.CB_Bank.Size = New System.Drawing.Size(357, 33)
        Me.CB_Bank.TabIndex = 1
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(14, 110)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(167, 26)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.Text = "0"
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Cuenta  :"
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
        Me.cmdCancel.Location = New System.Drawing.Point(273, 152)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdContinue
        '
        Me.cmdContinue.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdContinue.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdContinue.FlatAppearance.BorderSize = 0
        Me.cmdContinue.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdContinue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContinue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinue.Location = New System.Drawing.Point(172, 152)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.Size = New System.Drawing.Size(98, 29)
        Me.cmdContinue.TabIndex = 4
        Me.cmdContinue.Text = "Aceptar"
        Me.cmdContinue.UseVisualStyleBackColor = False
        '
        'txtNoCheque
        '
        Me.txtNoCheque.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNoCheque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoCheque.Enabled = False
        Me.txtNoCheque.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCheque.Location = New System.Drawing.Point(202, 110)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(167, 26)
        Me.txtNoCheque.TabIndex = 3
        Me.txtNoCheque.Text = "0"
        Me.txtNoCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(198, 84)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(98, 21)
        Me.label50.TabIndex = 19
        Me.label50.Text = "No. Cheque :"
        '
        'Financiero_DocumentoCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(410, 215)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_DocumentoCheques"
        Me.Text = "Financiero_DocumentoFiscalDigiteNumero"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdContinue As Button
    Private WithEvents txtNoCheque As TextBox
    Private WithEvents label50 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents CB_Bank As ComboBox
    Private WithEvents txtCuenta As TextBox
    Private WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_DocumentoFiscalDigiteNumero
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
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.txtNoDocumento = New System.Windows.Forms.TextBox()
        Me.label50 = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblProdLa = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblProdLa)
        Me.GroupBox1.Controls.Add(Me.lblProducto)
        Me.GroupBox1.Controls.Add(Me.lblUnidad)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdContinue)
        Me.GroupBox1.Controls.Add(Me.txtNoDocumento)
        Me.GroupBox1.Controls.Add(Me.label50)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 146)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Número Documento"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.Location = New System.Drawing.Point(290, 69)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(0, 21)
        Me.lblUnidad.TabIndex = 31
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
        Me.cmdCancel.Location = New System.Drawing.Point(177, 97)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
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
        Me.cmdContinue.Location = New System.Drawing.Point(76, 97)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.Size = New System.Drawing.Size(98, 29)
        Me.cmdContinue.TabIndex = 29
        Me.cmdContinue.Text = "Continuar"
        Me.cmdContinue.UseVisualStyleBackColor = False
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoDocumento.Enabled = False
        Me.txtNoDocumento.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDocumento.Location = New System.Drawing.Point(73, 65)
        Me.txtNoDocumento.MaxLength = 7
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Size = New System.Drawing.Size(202, 26)
        Me.txtNoDocumento.TabIndex = 22
        Me.txtNoDocumento.Text = "0"
        Me.txtNoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label50
        '
        Me.label50.AutoSize = True
        Me.label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label50.Location = New System.Drawing.Point(16, 70)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(45, 21)
        Me.label50.TabIndex = 19
        Me.label50.Text = "No.  :"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(85, 28)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(0, 21)
        Me.lblProducto.TabIndex = 32
        '
        'lblProdLa
        '
        Me.lblProdLa.AutoSize = True
        Me.lblProdLa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdLa.Location = New System.Drawing.Point(6, 27)
        Me.lblProdLa.Name = "lblProdLa"
        Me.lblProdLa.Size = New System.Drawing.Size(76, 21)
        Me.lblProdLa.TabIndex = 33
        Me.lblProdLa.Text = "Producto:"
        Me.lblProdLa.Visible = False
        '
        'Financiero_DocumentoFiscalDigiteNumero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(493, 170)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_DocumentoFiscalDigiteNumero"
        Me.Text = "Financiero_DocumentoFiscalDigiteNumero"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdContinue As Button
    Private WithEvents txtNoDocumento As TextBox
    Private WithEvents label50 As Label
    Private WithEvents lblUnidad As Label
    Private WithEvents lblProducto As Label
    Private WithEvents lblProdLa As Label
End Class

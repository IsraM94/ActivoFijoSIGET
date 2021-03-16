<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_PreviewDocFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Financiero_PreviewDocFiscal))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PPC_ConfigFactura = New System.Windows.Forms.PrintPreviewControl()
        Me.cmdMas = New System.Windows.Forms.Button()
        Me.cmdMenos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PPC_ConfigFactura
        '
        Me.PPC_ConfigFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPC_ConfigFactura.Location = New System.Drawing.Point(0, 0)
        Me.PPC_ConfigFactura.Name = "PPC_ConfigFactura"
        Me.PPC_ConfigFactura.Size = New System.Drawing.Size(616, 470)
        Me.PPC_ConfigFactura.TabIndex = 0
        '
        'cmdMas
        '
        Me.cmdMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMas.Location = New System.Drawing.Point(0, 0)
        Me.cmdMas.Name = "cmdMas"
        Me.cmdMas.Size = New System.Drawing.Size(58, 42)
        Me.cmdMas.TabIndex = 1
        Me.cmdMas.Text = "+"
        Me.cmdMas.UseVisualStyleBackColor = True
        '
        'cmdMenos
        '
        Me.cmdMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMenos.Location = New System.Drawing.Point(58, 0)
        Me.cmdMenos.Name = "cmdMenos"
        Me.cmdMenos.Size = New System.Drawing.Size(58, 42)
        Me.cmdMenos.TabIndex = 2
        Me.cmdMenos.Text = "-"
        Me.cmdMenos.UseVisualStyleBackColor = True
        '
        'Financiero_PreviewDocFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 470)
        Me.Controls.Add(Me.cmdMenos)
        Me.Controls.Add(Me.cmdMas)
        Me.Controls.Add(Me.PPC_ConfigFactura)
        Me.Name = "Financiero_PreviewDocFiscal"
        Me.Text = "Financiero_PreviewDocFiscal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PPC_ConfigFactura As PrintPreviewControl
    Friend WithEvents cmdMas As Button
    Friend WithEvents cmdMenos As Button
End Class

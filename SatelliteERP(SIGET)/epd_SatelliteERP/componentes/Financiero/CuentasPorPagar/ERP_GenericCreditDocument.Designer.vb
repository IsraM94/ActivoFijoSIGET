<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_GenericCreditDocument
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
        Me.components = New System.ComponentModel.Container()
        Me.Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSdgvCustomer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdReporte = New System.Windows.Forms.Button()
        Me.GbClientes = New System.Windows.Forms.GroupBox()
        Me.chkInvoice = New System.Windows.Forms.CheckBox()
        Me.txtCreditDocument = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.CMSdgvCustomer.SuspendLayout()
        Me.GbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Eliminar
        '
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(126, 22)
        Me.Eliminar.Text = "Eliminar"
        '
        'CMSdgvCustomer
        '
        Me.CMSdgvCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Actualizar, Me.Eliminar})
        Me.CMSdgvCustomer.Name = "CMSdgvProducts"
        Me.CMSdgvCustomer.Size = New System.Drawing.Size(127, 70)
        '
        'Nuevo
        '
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(126, 22)
        Me.Nuevo.Text = "Nuevo"
        '
        'Actualizar
        '
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(126, 22)
        Me.Actualizar.Text = "Actualizar"
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
        Me.cmdCancel.Location = New System.Drawing.Point(858, 499)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(193, 37)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.FlatAppearance.BorderSize = 0
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(334, 195)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(124, 37)
        Me.cmdSearch.TabIndex = 6
        Me.cmdSearch.Text = "Grabar"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdReporte
        '
        Me.cmdReporte.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdReporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdReporte.FlatAppearance.BorderSize = 0
        Me.cmdReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReporte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReporte.Location = New System.Drawing.Point(659, 499)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(193, 37)
        Me.cmdReporte.TabIndex = 7
        Me.cmdReporte.Text = "Reporte Preview"
        Me.cmdReporte.UseVisualStyleBackColor = False
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.chkInvoice)
        Me.GbClientes.Controls.Add(Me.txtCreditDocument)
        Me.GbClientes.Controls.Add(Me.Label1)
        Me.GbClientes.Controls.Add(Me.cmdReporte)
        Me.GbClientes.Controls.Add(Me.cmd_Cancelar)
        Me.GbClientes.Controls.Add(Me.cmdSearch)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 12)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(607, 238)
        Me.GbClientes.TabIndex = 41
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Tipo Documento de Crédito"
        '
        'chkInvoice
        '
        Me.chkInvoice.AutoSize = True
        Me.chkInvoice.Location = New System.Drawing.Point(232, 128)
        Me.chkInvoice.Name = "chkInvoice"
        Me.chkInvoice.Size = New System.Drawing.Size(119, 29)
        Me.chkInvoice.TabIndex = 12
        Me.chkInvoice.Text = "Es Factura"
        Me.chkInvoice.UseVisualStyleBackColor = True
        '
        'txtCreditDocument
        '
        Me.txtCreditDocument.Location = New System.Drawing.Point(304, 70)
        Me.txtCreditDocument.Name = "txtCreditDocument"
        Me.txtCreditDocument.Size = New System.Drawing.Size(284, 33)
        Me.txtCreditDocument.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo de Documento de Crédito:"
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_Cancelar.FlatAppearance.BorderSize = 0
        Me.cmd_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmd_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmd_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Cancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cancelar.Location = New System.Drawing.Point(461, 195)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(124, 37)
        Me.cmd_Cancelar.TabIndex = 6
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = False
        '
        'ERP_GenericCreditDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(631, 264)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_GenericCreditDocument"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_GenericCustomerClients"
        Me.CMSdgvCustomer.ResumeLayout(False)
        Me.GbClientes.ResumeLayout(False)
        Me.GbClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSdgvCustomer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Actualizar As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSearch As Button
    Private WithEvents cmdReporte As Button
    Friend WithEvents GbClientes As GroupBox
    Friend WithEvents chkInvoice As CheckBox
    Friend WithEvents txtCreditDocument As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents cmd_Cancelar As Button
End Class

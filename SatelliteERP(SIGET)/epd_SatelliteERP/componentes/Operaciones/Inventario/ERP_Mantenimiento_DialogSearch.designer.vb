<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Mantenimiento_DialogSearch
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
        Me.GBSearch = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GBSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBSearch
        '
        Me.GBSearch.BackColor = System.Drawing.SystemColors.Control
        Me.GBSearch.Controls.Add(Me.cmdCancel)
        Me.GBSearch.Controls.Add(Me.cmdOk)
        Me.GBSearch.Controls.Add(Me.txtSearch)
        Me.GBSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSearch.Location = New System.Drawing.Point(10, 11)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(495, 162)
        Me.GBSearch.TabIndex = 32
        Me.GBSearch.TabStop = False
        Me.GBSearch.Text = "Búsqueda"
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
        Me.cmdCancel.Location = New System.Drawing.Point(371, 110)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatAppearance.BorderSize = 0
        Me.cmdOk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(267, 110)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(98, 29)
        Me.cmdOk.TabIndex = 29
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(24, 54)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.ShortcutsEnabled = False
        Me.txtSearch.Size = New System.Drawing.Size(445, 26)
        Me.txtSearch.TabIndex = 26
        '
        'ERP_Mantenimiento_DialogSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(516, 187)
        Me.Controls.Add(Me.GBSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ERP_Mantenimiento_DialogSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_Mantenimiento_DialogSearch"
        Me.GBSearch.ResumeLayout(False)
        Me.GBSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBSearch As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdOk As Button
    Private WithEvents txtSearch As TextBox
End Class

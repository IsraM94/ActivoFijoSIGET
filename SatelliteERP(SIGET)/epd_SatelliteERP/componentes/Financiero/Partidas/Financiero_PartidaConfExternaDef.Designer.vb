<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_PartidaConfExternaDef
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
        Me.CB_CC = New System.Windows.Forms.ComboBox()
        Me.rbHaber = New System.Windows.Forms.RadioButton()
        Me.rbDebe = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConcept = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAcept = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CB_CC)
        Me.GroupBox1.Controls.Add(Me.rbHaber)
        Me.GroupBox1.Controls.Add(Me.rbDebe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtConcept)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdAcept)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 282)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Centro de Costo"
        '
        'CB_CC
        '
        Me.CB_CC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_CC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_CC.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_CC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_CC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_CC.FormattingEnabled = True
        Me.CB_CC.Location = New System.Drawing.Point(56, 109)
        Me.CB_CC.Name = "CB_CC"
        Me.CB_CC.Size = New System.Drawing.Size(266, 29)
        Me.CB_CC.TabIndex = 3
        '
        'rbHaber
        '
        Me.rbHaber.AutoSize = True
        Me.rbHaber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbHaber.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbHaber.Location = New System.Drawing.Point(217, 40)
        Me.rbHaber.Name = "rbHaber"
        Me.rbHaber.Size = New System.Drawing.Size(80, 29)
        Me.rbHaber.TabIndex = 2
        Me.rbHaber.TabStop = True
        Me.rbHaber.Text = "Haber"
        Me.rbHaber.UseVisualStyleBackColor = True
        '
        'rbDebe
        '
        Me.rbDebe.AutoSize = True
        Me.rbDebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDebe.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rbDebe.Location = New System.Drawing.Point(98, 40)
        Me.rbDebe.Name = "rbDebe"
        Me.rbDebe.Size = New System.Drawing.Size(73, 29)
        Me.rbDebe.TabIndex = 1
        Me.rbDebe.TabStop = True
        Me.rbDebe.Text = "Debe"
        Me.rbDebe.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Centro de Costo:"
        '
        'txtConcept
        '
        Me.txtConcept.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConcept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConcept.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcept.Location = New System.Drawing.Point(56, 166)
        Me.txtConcept.Name = "txtConcept"
        Me.txtConcept.Size = New System.Drawing.Size(266, 26)
        Me.txtConcept.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Concepto :"
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
        Me.cmdCancel.Location = New System.Drawing.Point(224, 240)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 6
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
        Me.cmdAcept.Location = New System.Drawing.Point(120, 240)
        Me.cmdAcept.Name = "cmdAcept"
        Me.cmdAcept.Size = New System.Drawing.Size(98, 29)
        Me.cmdAcept.TabIndex = 5
        Me.cmdAcept.Text = "Aceptar"
        Me.cmdAcept.UseVisualStyleBackColor = False
        '
        'Financiero_PartidaConfExternaDef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(404, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Financiero_PartidaConfExternaDef"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPartida2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtConcept As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Private WithEvents cmdAcept As System.Windows.Forms.Button
    Friend WithEvents rbHaber As System.Windows.Forms.RadioButton
    Friend WithEvents rbDebe As System.Windows.Forms.RadioButton
    Private WithEvents CB_CC As System.Windows.Forms.ComboBox
End Class

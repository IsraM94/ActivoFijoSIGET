<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComboBox_EPD
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblEtiqueta = New System.Windows.Forms.Label()
        Me.cbData = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.AutoSize = True
        Me.lblEtiqueta.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtiqueta.Location = New System.Drawing.Point(20, 2)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(83, 26)
        Me.lblEtiqueta.TabIndex = 2
        Me.lblEtiqueta.Text = "Etiqueta"
        '
        'cbData
        '
        Me.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbData.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbData.FormattingEnabled = True
        Me.cbData.Location = New System.Drawing.Point(20, 31)
        Me.cbData.Name = "cbData"
        Me.cbData.Size = New System.Drawing.Size(451, 31)
        Me.cbData.TabIndex = 3
        '
        'ComboBox_EPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cbData)
        Me.Controls.Add(Me.lblEtiqueta)
        Me.Name = "ComboBox_EPD"
        Me.Size = New System.Drawing.Size(480, 74)
        Me.Tag = "2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEtiqueta As Label
    Friend WithEvents cbData As ComboBox
End Class

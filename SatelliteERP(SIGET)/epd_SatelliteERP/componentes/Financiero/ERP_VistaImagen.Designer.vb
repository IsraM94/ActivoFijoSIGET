<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_VistaImagen
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarImagen = New System.Windows.Forms.Button()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnEliminarImagen)
        Me.GroupBox2.Controls.Add(Me.pbxImagen)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 622)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activo Fijo Imagen"
        '
        'btnEliminarImagen
        '
        Me.btnEliminarImagen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarImagen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnEliminarImagen.Location = New System.Drawing.Point(7, 586)
        Me.btnEliminarImagen.Name = "btnEliminarImagen"
        Me.btnEliminarImagen.Size = New System.Drawing.Size(408, 30)
        Me.btnEliminarImagen.TabIndex = 78
        Me.btnEliminarImagen.Text = "Eliminar"
        Me.btnEliminarImagen.UseVisualStyleBackColor = False
        '
        'pbxImagen
        '
        Me.pbxImagen.Location = New System.Drawing.Point(7, 31)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(608, 542)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImagen.TabIndex = 77
        Me.pbxImagen.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 803)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 21)
        Me.Label20.TabIndex = 76
        Me.Label20.Text = "id image"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.TextBox2.Location = New System.Drawing.Point(177, 849)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(347, 24)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label22.Location = New System.Drawing.Point(23, 845)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(149, 25)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Número de Serie:"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(644, 844)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 29)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(540, 844)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 29)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Grabar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancelar.Location = New System.Drawing.Point(421, 586)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(194, 30)
        Me.btnCancelar.TabIndex = 79
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'ERP_VistaImagen
        '
        Me.AcceptButton = Me.btnEliminarImagen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(645, 646)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_VistaImagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_VistaImagen"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents Label20 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents Label22 As Label
    Private WithEvents Button6 As Button
    Private WithEvents Button7 As Button
    Friend WithEvents pbxImagen As PictureBox
    Friend WithEvents btnEliminarImagen As Button
    Friend WithEvents btnCancelar As Button
End Class

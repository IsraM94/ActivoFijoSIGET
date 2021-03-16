<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Camara
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.cmbDevice = New System.Windows.Forms.ComboBox()
        Me.btnCamara = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 622)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activo Fijo Imagen"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(7, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(408, 30)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Capturar"
        Me.Button1.UseVisualStyleBackColor = False
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
        'cmbDevice
        '
        Me.cmbDevice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDevice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDevice.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDevice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDevice.FormattingEnabled = True
        Me.cmbDevice.Location = New System.Drawing.Point(351, 661)
        Me.cmbDevice.Name = "cmbDevice"
        Me.cmbDevice.Size = New System.Drawing.Size(242, 29)
        Me.cmbDevice.TabIndex = 78
        '
        'btnCamara
        '
        Me.btnCamara.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCamara.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCamara.Location = New System.Drawing.Point(163, 684)
        Me.btnCamara.Name = "btnCamara"
        Me.btnCamara.Size = New System.Drawing.Size(136, 30)
        Me.btnCamara.TabIndex = 81
        Me.btnCamara.Text = "Camara"
        Me.btnCamara.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(6, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(608, 550)
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(432, 218)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'ERP_Camara
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(645, 646)
        Me.Controls.Add(Me.cmbDevice)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCamara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Camara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_Camara"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancelar As Button
    Private WithEvents Label20 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents Label22 As Label
    Private WithEvents Button6 As Button
    Private WithEvents Button7 As Button
    Private WithEvents cmbDevice As ComboBox
    Friend WithEvents btnCamara As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

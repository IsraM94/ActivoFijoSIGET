<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mantenimiento_FixedAssetSubType
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_IsTangible = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.label49 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtSubTypeName = New System.Windows.Forms.TextBox()
        Me.comboListCollectingFixedAssetsType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cb_IsTangible)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtSubTypeName)
        Me.GroupBox1.Controls.Add(Me.comboListCollectingFixedAssetsType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 332)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración Sub Tipos de Activo Fijo"
        '
        'cb_IsTangible
        '
        Me.cb_IsTangible.AutoSize = True
        Me.cb_IsTangible.Location = New System.Drawing.Point(222, 264)
        Me.cb_IsTangible.Name = "cb_IsTangible"
        Me.cb_IsTangible.Size = New System.Drawing.Size(15, 14)
        Me.cb_IsTangible.TabIndex = 31
        Me.cb_IsTangible.UseVisualStyleBackColor = True
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
        Me.cmdCancel.Location = New System.Drawing.Point(380, 286)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(276, 286)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(61, 69)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(150, 25)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Tipo Activo Fijo: "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(220, 150)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(256, 100)
        Me.txtDescripcion.TabIndex = 26
        '
        'txtSubTypeName
        '
        Me.txtSubTypeName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSubTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubTypeName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTypeName.Location = New System.Drawing.Point(220, 110)
        Me.txtSubTypeName.MaxLength = 100
        Me.txtSubTypeName.Name = "txtSubTypeName"
        Me.txtSubTypeName.Size = New System.Drawing.Size(256, 26)
        Me.txtSubTypeName.TabIndex = 26
        '
        'comboListCollectingFixedAssetsType
        '
        Me.comboListCollectingFixedAssetsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboListCollectingFixedAssetsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboListCollectingFixedAssetsType.BackColor = System.Drawing.Color.Gainsboro
        Me.comboListCollectingFixedAssetsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboListCollectingFixedAssetsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboListCollectingFixedAssetsType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListCollectingFixedAssetsType.FormattingEnabled = True
        Me.comboListCollectingFixedAssetsType.Location = New System.Drawing.Point(220, 69)
        Me.comboListCollectingFixedAssetsType.Name = "comboListCollectingFixedAssetsType"
        Me.comboListCollectingFixedAssetsType.Size = New System.Drawing.Size(258, 29)
        Me.comboListCollectingFixedAssetsType.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Es Tangible:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Descripción Sub Tipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre Sub Tipo:"
        '
        'Mantenimiento_FixedAssetSubType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(572, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mantenimiento_FixedAssetSubType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento_Generic_Municipality"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents label49 As Label
    Private WithEvents txtSubTypeName As TextBox
    Private WithEvents comboListCollectingFixedAssetsType As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents cb_IsTangible As CheckBox
    Private WithEvents Label3 As Label
End Class

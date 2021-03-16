<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_Mantenimiento_WorkLocation
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_UbicaconPrimaria = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label49 = New System.Windows.Forms.Label()
        Me.txtAddressLocation = New System.Windows.Forms.TextBox()
        Me.txtWorkLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_UbicaconPrimaria)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Controls.Add(Me.txtAddressLocation)
        Me.GroupBox1.Controls.Add(Me.txtWorkLocation)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 319)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Ubicación de Trabajo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 25)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Ubicación Primaria: "
        '
        'cmb_UbicaconPrimaria
        '
        Me.cmb_UbicaconPrimaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconPrimaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconPrimaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconPrimaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconPrimaria.FormattingEnabled = True
        Me.cmb_UbicaconPrimaria.Location = New System.Drawing.Point(212, 32)
        Me.cmb_UbicaconPrimaria.Name = "cmb_UbicaconPrimaria"
        Me.cmb_UbicaconPrimaria.Size = New System.Drawing.Size(523, 33)
        Me.cmb_UbicaconPrimaria.TabIndex = 1
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
        Me.cmdCancel.Location = New System.Drawing.Point(354, 264)
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
        Me.cmdSave.Location = New System.Drawing.Point(233, 264)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Dirección de Trabajo:"
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label49.Location = New System.Drawing.Point(4, 82)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(193, 25)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Ubicación de Trabajo:"
        '
        'txtAddressLocation
        '
        Me.txtAddressLocation.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAddressLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddressLocation.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLocation.Location = New System.Drawing.Point(212, 131)
        Me.txtAddressLocation.MaxLength = 300
        Me.txtAddressLocation.Multiline = True
        Me.txtAddressLocation.Name = "txtAddressLocation"
        Me.txtAddressLocation.Size = New System.Drawing.Size(523, 107)
        Me.txtAddressLocation.TabIndex = 3
        '
        'txtWorkLocation
        '
        Me.txtWorkLocation.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWorkLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWorkLocation.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkLocation.Location = New System.Drawing.Point(212, 73)
        Me.txtWorkLocation.MaxLength = 100
        Me.txtWorkLocation.Multiline = True
        Me.txtWorkLocation.Name = "txtWorkLocation"
        Me.txtWorkLocation.Size = New System.Drawing.Size(523, 52)
        Me.txtWorkLocation.TabIndex = 2
        '
        'ERP_Mantenimiento_WorkLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(788, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Mantenimiento_WorkLocation"
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
    Private WithEvents txtWorkLocation As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtAddressLocation As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents cmb_UbicaconPrimaria As ComboBox
End Class

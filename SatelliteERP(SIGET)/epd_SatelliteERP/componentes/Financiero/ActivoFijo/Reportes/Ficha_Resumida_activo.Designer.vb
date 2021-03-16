<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ficha_Resumida_activo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_Responsable = New System.Windows.Forms.ComboBox()
        Me.cmb_Unidad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_UbicaconSecundaria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_UbicaconPrimaria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdEnviar = New System.Windows.Forms.Button()
        Me.label49 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_Responsable)
        Me.GroupBox1.Controls.Add(Me.cmb_Unidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_UbicaconSecundaria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_UbicaconPrimaria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdEnviar)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 281)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccciona filtro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(321, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 25)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Reporte de Ficha Resumida de Activos"
        '
        'cmb_Responsable
        '
        Me.cmb_Responsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Responsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Responsable.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_Responsable.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_Responsable.FormattingEnabled = True
        Me.cmb_Responsable.Location = New System.Drawing.Point(215, 189)
        Me.cmb_Responsable.Name = "cmb_Responsable"
        Me.cmb_Responsable.Size = New System.Drawing.Size(690, 33)
        Me.cmb_Responsable.TabIndex = 41
        '
        'cmb_Unidad
        '
        Me.cmb_Unidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Unidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Unidad.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_Unidad.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_Unidad.FormattingEnabled = True
        Me.cmb_Unidad.Location = New System.Drawing.Point(214, 144)
        Me.cmb_Unidad.Name = "cmb_Unidad"
        Me.cmb_Unidad.Size = New System.Drawing.Size(690, 33)
        Me.cmb_Unidad.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(128, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Unidad:"
        '
        'cmb_UbicaconSecundaria
        '
        Me.cmb_UbicaconSecundaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconSecundaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconSecundaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconSecundaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconSecundaria.FormattingEnabled = True
        Me.cmb_UbicaconSecundaria.Location = New System.Drawing.Point(214, 99)
        Me.cmb_UbicaconSecundaria.Name = "cmb_UbicaconSecundaria"
        Me.cmb_UbicaconSecundaria.Size = New System.Drawing.Size(690, 33)
        Me.cmb_UbicaconSecundaria.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(30, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Ubicación Primaria: "
        '
        'cmb_UbicaconPrimaria
        '
        Me.cmb_UbicaconPrimaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_UbicaconPrimaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_UbicaconPrimaria.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_UbicaconPrimaria.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_UbicaconPrimaria.FormattingEnabled = True
        Me.cmb_UbicaconPrimaria.Location = New System.Drawing.Point(214, 51)
        Me.cmb_UbicaconPrimaria.Name = "cmb_UbicaconPrimaria"
        Me.cmb_UbicaconPrimaria.Size = New System.Drawing.Size(690, 33)
        Me.cmb_UbicaconPrimaria.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(85, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Responsable:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(806, 237)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancelar.TabIndex = 30
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdEnviar
        '
        Me.cmdEnviar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdEnviar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEnviar.FlatAppearance.BorderSize = 0
        Me.cmdEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEnviar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviar.Location = New System.Drawing.Point(689, 237)
        Me.cmdEnviar.Name = "cmdEnviar"
        Me.cmdEnviar.Size = New System.Drawing.Size(98, 29)
        Me.cmdEnviar.TabIndex = 29
        Me.cmdEnviar.Text = "Continuar"
        Me.cmdEnviar.UseVisualStyleBackColor = False
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(6, 101)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(199, 25)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Ubicación Secundaria:"
        '
        'Ficha_Resumida_activo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(935, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ficha_Resumida_activo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha_Resumida_activo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_UbicaconPrimaria As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents cmdCancelar As Button
    Private WithEvents cmdEnviar As Button
    Private WithEvents label49 As Label
    Friend WithEvents cmb_Responsable As ComboBox
    Friend WithEvents cmb_Unidad As ComboBox
    Private WithEvents Label3 As Label
    Friend WithEvents cmb_UbicaconSecundaria As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents Label4 As Label
End Class

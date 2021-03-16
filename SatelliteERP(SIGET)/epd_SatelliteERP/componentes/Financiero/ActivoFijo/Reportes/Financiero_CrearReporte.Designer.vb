<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Financiero_CrearReporte
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
        Me.PanelFecha = New System.Windows.Forms.Panel()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlDepartamento = New System.Windows.Forms.Panel()
        Me.cmbDepartmento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.PanelID = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_persona = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Reporte = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Location = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.PanelFecha.SuspendLayout()
        Me.pnlDepartamento.SuspendLayout()
        Me.PanelID.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PanelFecha)
        Me.GroupBox1.Controls.Add(Me.pnlDepartamento)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.PanelID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_Reporte)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CB_Location)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(529, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'PanelFecha
        '
        Me.PanelFecha.Controls.Add(Me.dtpFechaFinal)
        Me.PanelFecha.Controls.Add(Me.dtpFechaInicial)
        Me.PanelFecha.Controls.Add(Me.Label4)
        Me.PanelFecha.Controls.Add(Me.Label3)
        Me.PanelFecha.Location = New System.Drawing.Point(48, 145)
        Me.PanelFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFecha.Name = "PanelFecha"
        Me.PanelFecha.Size = New System.Drawing.Size(447, 81)
        Me.PanelFecha.TabIndex = 63
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Location = New System.Drawing.Point(116, 49)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(232, 26)
        Me.dtpFechaFinal.TabIndex = 58
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Location = New System.Drawing.Point(116, 17)
        Me.dtpFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(232, 26)
        Me.dtpFechaInicial.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Fecha Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Fecha Inicial:"
        '
        'pnlDepartamento
        '
        Me.pnlDepartamento.Controls.Add(Me.cmbDepartmento)
        Me.pnlDepartamento.Controls.Add(Me.Label6)
        Me.pnlDepartamento.Location = New System.Drawing.Point(46, 147)
        Me.pnlDepartamento.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDepartamento.Name = "pnlDepartamento"
        Me.pnlDepartamento.Size = New System.Drawing.Size(447, 81)
        Me.pnlDepartamento.TabIndex = 66
        '
        'cmbDepartmento
        '
        Me.cmbDepartmento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDepartmento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartmento.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbDepartmento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartmento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartmento.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbDepartmento.FormattingEnabled = True
        Me.cmbDepartmento.Location = New System.Drawing.Point(131, 20)
        Me.cmbDepartmento.Name = "cmbDepartmento"
        Me.cmbDepartmento.Size = New System.Drawing.Size(303, 33)
        Me.cmbDepartmento.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label6.Location = New System.Drawing.Point(3, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 25)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Departamento:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(395, 245)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancel.TabIndex = 65
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
        Me.cmdSave.Location = New System.Drawing.Point(291, 245)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 64
        Me.cmdSave.Text = "Excel"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'PanelID
        '
        Me.PanelID.Controls.Add(Me.Label2)
        Me.PanelID.Controls.Add(Me.cmb_persona)
        Me.PanelID.Location = New System.Drawing.Point(46, 147)
        Me.PanelID.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelID.Name = "PanelID"
        Me.PanelID.Size = New System.Drawing.Size(447, 81)
        Me.PanelID.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Persona:"
        '
        'cmb_persona
        '
        Me.cmb_persona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_persona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_persona.BackColor = System.Drawing.Color.Gainsboro
        Me.cmb_persona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_persona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_persona.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmb_persona.FormattingEnabled = True
        Me.cmb_persona.Location = New System.Drawing.Point(131, 17)
        Me.cmb_persona.Name = "cmb_persona"
        Me.cmb_persona.Size = New System.Drawing.Size(303, 33)
        Me.cmb_persona.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label5.Location = New System.Drawing.Point(33, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Reporte:"
        '
        'cb_Reporte
        '
        Me.cb_Reporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Reporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Reporte.BackColor = System.Drawing.Color.Gainsboro
        Me.cb_Reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Reporte.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cb_Reporte.FormattingEnabled = True
        Me.cb_Reporte.Location = New System.Drawing.Point(135, 40)
        Me.cb_Reporte.Name = "cb_Reporte"
        Me.cb_Reporte.Size = New System.Drawing.Size(360, 33)
        Me.cb_Reporte.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Tipo Filtro:"
        '
        'CB_Location
        '
        Me.CB_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Location.BackColor = System.Drawing.Color.Gainsboro
        Me.CB_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Location.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.CB_Location.FormattingEnabled = True
        Me.CB_Location.Location = New System.Drawing.Point(135, 93)
        Me.CB_Location.Name = "CB_Location"
        Me.CB_Location.Size = New System.Drawing.Size(360, 33)
        Me.CB_Location.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(-134, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Ubicación : "
        '
        'Financiero_CrearReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(547, 314)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Financiero_CrearReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financiero_CrearReporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelFecha.ResumeLayout(False)
        Me.PanelFecha.PerformLayout()
        Me.pnlDepartamento.ResumeLayout(False)
        Me.pnlDepartamento.PerformLayout()
        Me.PanelID.ResumeLayout(False)
        Me.PanelID.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label9 As Label
    Friend WithEvents pnlDepartamento As Panel
    Private WithEvents cmbDepartmento As ComboBox
    Private WithEvents Label6 As Label
    Private WithEvents cmdCancel As Button
    Friend WithEvents PanelFecha As Panel
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents cmdSave As Button
    Friend WithEvents PanelID As Panel
    Private WithEvents Label2 As Label
    Private WithEvents cmb_persona As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents CB_Location As ComboBox
    Private WithEvents Label5 As Label
    Private WithEvents cb_Reporte As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowLog
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
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtRegistros = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbCampos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTablesHist = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker()
        Me.txtBusquedad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbControles.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbControles
        '
        Me.gbControles.BackColor = System.Drawing.SystemColors.Control
        Me.gbControles.Controls.Add(Me.btnClose)
        Me.gbControles.Controls.Add(Me.txtRegistros)
        Me.gbControles.Controls.Add(Me.Label6)
        Me.gbControles.Controls.Add(Me.btnBuscar)
        Me.gbControles.Controls.Add(Me.cmbCampos)
        Me.gbControles.Controls.Add(Me.Label5)
        Me.gbControles.Controls.Add(Me.cmbTablesHist)
        Me.gbControles.Controls.Add(Me.Label4)
        Me.gbControles.Controls.Add(Me.Label3)
        Me.gbControles.Controls.Add(Me.dtpfin)
        Me.gbControles.Controls.Add(Me.Label2)
        Me.gbControles.Controls.Add(Me.dtpinicio)
        Me.gbControles.Controls.Add(Me.txtBusquedad)
        Me.gbControles.Controls.Add(Me.Label1)
        Me.gbControles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbControles.Location = New System.Drawing.Point(12, 12)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Size = New System.Drawing.Size(784, 227)
        Me.gbControles.TabIndex = 0
        Me.gbControles.TabStop = False
        Me.gbControles.Text = "Filtros"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(393, 180)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 41)
        Me.btnClose.TabIndex = 91
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtRegistros
        '
        Me.txtRegistros.Location = New System.Drawing.Point(650, 90)
        Me.txtRegistros.Name = "txtRegistros"
        Me.txtRegistros.Size = New System.Drawing.Size(76, 26)
        Me.txtRegistros.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "# Registros"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(269, 180)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 41)
        Me.btnBuscar.TabIndex = 88
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cmbCampos
        '
        Me.cmbCampos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCampos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCampos.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampos.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbCampos.FormattingEnabled = True
        Me.cmbCampos.Items.AddRange(New Object() {"Fecha de Transferencias", "Por Estado de activo"})
        Me.cmbCampos.Location = New System.Drawing.Point(194, 86)
        Me.cmbCampos.Name = "cmbCampos"
        Me.cmbCampos.Size = New System.Drawing.Size(294, 33)
        Me.cmbCampos.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Seleccione un Campo"
        '
        'cmbTablesHist
        '
        Me.cmbTablesHist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTablesHist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTablesHist.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbTablesHist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTablesHist.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.cmbTablesHist.FormattingEnabled = True
        Me.cmbTablesHist.Items.AddRange(New Object() {"Fecha de Transferencias", "Por Estado de activo"})
        Me.cmbTablesHist.Location = New System.Drawing.Point(194, 48)
        Me.cmbTablesHist.Name = "cmbTablesHist"
        Me.cmbTablesHist.Size = New System.Drawing.Size(529, 33)
        Me.cmbTablesHist.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Seleccione una Tabla"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de Fin"
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfin.Location = New System.Drawing.Point(524, 132)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(200, 26)
        Me.dtpfin.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de Inicio"
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(193, 133)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(200, 26)
        Me.dtpinicio.TabIndex = 2
        '
        'txtBusquedad
        '
        Me.txtBusquedad.Location = New System.Drawing.Point(194, 16)
        Me.txtBusquedad.Name = "txtBusquedad"
        Me.txtBusquedad.Size = New System.Drawing.Size(529, 26)
        Me.txtBusquedad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Palabra de Busquedad"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(784, 393)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(778, 368)
        Me.DataGridView1.TabIndex = 4
        '
        'ShowLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(806, 650)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbControles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShowLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShowLog"
        Me.gbControles.ResumeLayout(False)
        Me.gbControles.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbControles As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpinicio As DateTimePicker
    Friend WithEvents txtBusquedad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Private WithEvents cmbTablesHist As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents cmbCampos As ComboBox
    Friend WithEvents Label5 As Label
    Private WithEvents btnBuscar As Button
    Friend WithEvents txtRegistros As TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents btnClose As Button
End Class

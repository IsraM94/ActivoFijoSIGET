<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Production_AddPesos
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPesos = New System.Windows.Forms.DataGridView()
        Me.MenuOpcion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbNacimiento = New System.Windows.Forms.ComboBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTiempoParto = New System.Windows.Forms.TextBox()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvPesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuOpcion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nacimiento:"
        '
        'dgvPesos
        '
        Me.dgvPesos.AllowUserToAddRows = False
        Me.dgvPesos.AllowUserToDeleteRows = False
        Me.dgvPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesos.ContextMenuStrip = Me.MenuOpcion
        Me.dgvPesos.EnableHeadersVisualStyles = False
        Me.dgvPesos.Location = New System.Drawing.Point(82, 117)
        Me.dgvPesos.Name = "dgvPesos"
        Me.dgvPesos.ReadOnly = True
        Me.dgvPesos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPesos.RowHeadersVisible = False
        Me.dgvPesos.Size = New System.Drawing.Size(295, 183)
        Me.dgvPesos.TabIndex = 3
        '
        'MenuOpcion
        '
        Me.MenuOpcion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarToolStripMenuItem})
        Me.MenuOpcion.Name = "MenuOpcion"
        Me.MenuOpcion.Size = New System.Drawing.Size(107, 26)
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Peso:"
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnProcesar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnProcesar.FlatAppearance.BorderSize = 0
        Me.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(112, 441)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(112, 35)
        Me.btnProcesar.TabIndex = 33
        Me.btnProcesar.Text = "Continuar"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnProcesar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 487)
        Me.Panel1.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.cbNacimiento)
        Me.GroupBox2.Controls.Add(Me.txtPeso)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgvPesos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 306)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Crías"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(269, 64)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregar.TabIndex = 44
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cbNacimiento
        '
        Me.cbNacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNacimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNacimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.cbNacimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNacimiento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNacimiento.FormattingEnabled = True
        Me.cbNacimiento.Location = New System.Drawing.Point(121, 26)
        Me.cbNacimiento.Name = "cbNacimiento"
        Me.cbNacimiento.Size = New System.Drawing.Size(250, 29)
        Me.cbNacimiento.TabIndex = 43
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPeso.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(119, 66)
        Me.txtPeso.MaxLength = 20
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ShortcutsEnabled = False
        Me.txtPeso.Size = New System.Drawing.Size(145, 26)
        Me.txtPeso.TabIndex = 42
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTiempoParto)
        Me.GroupBox1.Controls.Add(Me.txtTemperatura)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 109)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Madre"
        '
        'txtTiempoParto
        '
        Me.txtTiempoParto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTiempoParto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTiempoParto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoParto.Location = New System.Drawing.Point(152, 65)
        Me.txtTiempoParto.MaxLength = 20
        Me.txtTiempoParto.Name = "txtTiempoParto"
        Me.txtTiempoParto.ShortcutsEnabled = False
        Me.txtTiempoParto.Size = New System.Drawing.Size(225, 26)
        Me.txtTiempoParto.TabIndex = 41
        Me.txtTiempoParto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTemperatura
        '
        Me.txtTemperatura.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTemperatura.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(152, 26)
        Me.txtTemperatura.MaxLength = 20
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.ShortcutsEnabled = False
        Me.txtTemperatura.Size = New System.Drawing.Size(225, 26)
        Me.txtTemperatura.TabIndex = 40
        Me.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 26)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Temperatura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Tiempo Parto:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(230, 441)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 35)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Production_AddPesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(443, 509)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Production_AddPesos"
        Me.Text = "Agregar Pesos"
        CType(Me.dgvPesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuOpcion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
	Friend WithEvents dgvPesos As DataGridView
	Friend WithEvents Label2 As Label
	Private WithEvents btnProcesar As Button
	Friend WithEvents Panel1 As Panel
	Private WithEvents btnCancelar As Button
	Friend WithEvents MenuOpcion As ContextMenuStrip
	Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents GroupBox1 As GroupBox
	Private WithEvents txtPeso As TextBox
	Private WithEvents txtTiempoParto As TextBox
	Private WithEvents txtTemperatura As TextBox
	Private WithEvents cbNacimiento As ComboBox
	Private WithEvents btnAgregar As Button
End Class

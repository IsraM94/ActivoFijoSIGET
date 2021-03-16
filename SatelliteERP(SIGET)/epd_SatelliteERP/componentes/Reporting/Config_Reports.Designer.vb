<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config_Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config_Reports))
        Me.PPD_prueba = New System.Windows.Forms.PrintPreviewDialog()
        Me.TLP_Padres = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmdTesting = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdGeneraPartida = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PPC_Documents = New System.Windows.Forms.PrintPreviewControl()
        Me.Campo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TLP_Padres.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PPD_prueba
        '
        Me.PPD_prueba.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD_prueba.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD_prueba.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD_prueba.Enabled = True
        Me.PPD_prueba.Icon = CType(resources.GetObject("PPD_prueba.Icon"), System.Drawing.Icon)
        Me.PPD_prueba.Name = "PPD_prueba"
        Me.PPD_prueba.Visible = False
        '
        'TLP_Padres
        '
        Me.TLP_Padres.BackColor = System.Drawing.Color.SteelBlue
        Me.TLP_Padres.ColumnCount = 2
        Me.TLP_Padres.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Padres.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TLP_Padres.Controls.Add(Me.ListView1, 1, 1)
        Me.TLP_Padres.Controls.Add(Me.PPC_Documents, 0, 1)
        Me.TLP_Padres.Controls.Add(Me.Panel1, 0, 0)
        Me.TLP_Padres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Padres.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Padres.Name = "TLP_Padres"
        Me.TLP_Padres.RowCount = 2
        Me.TLP_Padres.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TLP_Padres.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Padres.Size = New System.Drawing.Size(735, 542)
        Me.TLP_Padres.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Partida Contable", "Libro Mayor"})
        Me.ComboBox1.Location = New System.Drawing.Point(23, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'cmdTesting
        '
        Me.cmdTesting.Location = New System.Drawing.Point(392, 39)
        Me.cmdTesting.Name = "cmdTesting"
        Me.cmdTesting.Size = New System.Drawing.Size(100, 32)
        Me.cmdTesting.TabIndex = 1
        Me.cmdTesting.Text = "cmdTesting"
        Me.cmdTesting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo Reporte"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Titulo", "Linea"})
        Me.ComboBox2.Location = New System.Drawing.Point(200, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Campos Disponibles"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(417, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 32)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdGeneraPartida
        '
        Me.cmdGeneraPartida.Location = New System.Drawing.Point(105, 74)
        Me.cmdGeneraPartida.Name = "cmdGeneraPartida"
        Me.cmdGeneraPartida.Size = New System.Drawing.Size(100, 32)
        Me.cmdGeneraPartida.TabIndex = 7
        Me.cmdGeneraPartida.Text = "Partida"
        Me.cmdGeneraPartida.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.cmdGeneraPartida)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmdTesting)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 113)
        Me.Panel1.TabIndex = 1
        '
        'PPC_Documents
        '
        Me.PPC_Documents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPC_Documents.Location = New System.Drawing.Point(3, 122)
        Me.PPC_Documents.Name = "PPC_Documents"
        Me.PPC_Documents.Size = New System.Drawing.Size(582, 417)
        Me.PPC_Documents.TabIndex = 0
        '
        'Campo
        '
        Me.Campo.Text = "Campo"
        Me.Campo.Width = 139
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Campo})
        Me.ListView1.Location = New System.Drawing.Point(591, 122)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(132, 417)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Config_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 542)
        Me.Controls.Add(Me.TLP_Padres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Config_Reports"
        Me.Text = "Config_Reports"
        Me.TLP_Padres.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PPD_prueba As PrintPreviewDialog
    Friend WithEvents TLP_Padres As TableLayoutPanel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Campo As ColumnHeader
    Friend WithEvents PPC_Documents As PrintPreviewControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdGeneraPartida As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdTesting As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class

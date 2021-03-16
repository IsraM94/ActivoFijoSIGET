<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generic_RequestPending
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
        Me.GbClientes = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FLPCxC = New System.Windows.Forms.FlowLayoutPanel()
        Me.FLPCheck = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GbClientes.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbClientes
        '
        Me.GbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.GbClientes.Controls.Add(Me.TableLayoutPanel1)
        Me.GbClientes.Controls.Add(Me.cmdCancel)
        Me.GbClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbClientes.Location = New System.Drawing.Point(12, 8)
        Me.GbClientes.Name = "GbClientes"
        Me.GbClientes.Size = New System.Drawing.Size(903, 564)
        Me.GbClientes.TabIndex = 46
        Me.GbClientes.TabStop = False
        Me.GbClientes.Text = "Solicitudes Pendientes de aprobar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FLPCxC, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FLPCheck, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 46)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.193277!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.80672!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(891, 512)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(448, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 35)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cheques"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 35)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuentas por Cobrar"
        '
        'FLPCxC
        '
        Me.FLPCxC.AutoScroll = True
        Me.FLPCxC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLPCxC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLPCxC.Location = New System.Drawing.Point(3, 44)
        Me.FLPCxC.Name = "FLPCxC"
        Me.FLPCxC.Size = New System.Drawing.Size(439, 465)
        Me.FLPCxC.TabIndex = 2
        '
        'FLPCheck
        '
        Me.FLPCheck.AutoScroll = True
        Me.FLPCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLPCheck.Location = New System.Drawing.Point(448, 44)
        Me.FLPCheck.Name = "FLPCheck"
        Me.FLPCheck.Size = New System.Drawing.Size(440, 465)
        Me.FLPCheck.TabIndex = 3
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
        Me.cmdCancel.Location = New System.Drawing.Point(789, 17)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(84, 26)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Salir"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Generic_RequestPending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(927, 584)
        Me.Controls.Add(Me.GbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Generic_RequestPending"
        Me.Text = "Generic_RequestPending"
        Me.GbClientes.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbClientes As GroupBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents FLPCxC As FlowLayoutPanel
	Friend WithEvents FLPCheck As FlowLayoutPanel
	Private WithEvents cmdCancel As Button
End Class

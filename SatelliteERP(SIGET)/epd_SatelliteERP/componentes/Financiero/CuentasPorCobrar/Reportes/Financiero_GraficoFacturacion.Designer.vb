<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financiero_GraficoFacturacion
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.PieChart1 = New Nexus.Windows.Forms.PieChart()
        Me.trkRadius = New System.Windows.Forms.TrackBar()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Timers.Timer()
        CType(Me.trkRadius, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PieChart1
        '
        Me.PieChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PieChart1.Items.Add(New Nexus.Windows.Forms.PieChartItem(10.0R, System.Drawing.Color.Gray, "", "", 0!))
        Me.PieChart1.Items.Add(New Nexus.Windows.Forms.PieChartItem(10.0R, System.Drawing.Color.Gray, "", "", 0!))
        Me.PieChart1.Location = New System.Drawing.Point(0, 0)
        Me.PieChart1.Name = "PieChart1"
        Me.PieChart1.Radius = 200.0!
        Me.PieChart1.Size = New System.Drawing.Size(566, 453)
        Me.PieChart1.TabIndex = 1
        Me.PieChart1.Text = "PieChart1"
        Me.PieChart1.Thickness = 10.0!
        '
        'trkRadius
        '
        Me.trkRadius.Location = New System.Drawing.Point(345, 18)
        Me.trkRadius.Maximum = 1500
        Me.trkRadius.Minimum = 10
        Me.trkRadius.Name = "trkRadius"
        Me.trkRadius.Size = New System.Drawing.Size(218, 45)
        Me.trkRadius.TabIndex = 38
        Me.trkRadius.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trkRadius.Value = 10
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(343, -1)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 13)
        Me.label4.TabIndex = 37
        Me.label4.Text = "Radius"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.SynchronizingObject = Me
        '
        'Financiero_GraficoFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.trkRadius)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.PieChart1)
        Me.Name = "Financiero_GraficoFacturacion"
        Me.Size = New System.Drawing.Size(566, 453)
        CType(Me.trkRadius, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PieChart1 As Nexus.Windows.Forms.PieChart
    Private WithEvents trkRadius As TrackBar
    Private WithEvents label4 As Label
    Friend WithEvents Timer1 As Timers.Timer
End Class

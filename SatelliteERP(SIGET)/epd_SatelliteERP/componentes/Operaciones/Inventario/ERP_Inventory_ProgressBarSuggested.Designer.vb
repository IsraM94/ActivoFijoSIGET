<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Inventory_ProgressBarSuggested
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
		Me.pbSuggest = New System.Windows.Forms.ProgressBar()
		Me.bwProgressUploadFiles = New System.ComponentModel.BackgroundWorker()
		Me.lblProgress = New System.Windows.Forms.Label()
		Me.lblPorcentaje = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'pbSuggest
		'
		Me.pbSuggest.Location = New System.Drawing.Point(34, 27)
		Me.pbSuggest.Name = "pbSuggest"
		Me.pbSuggest.Size = New System.Drawing.Size(448, 52)
		Me.pbSuggest.TabIndex = 0
		'
		'bwProgressUploadFiles
		'
		'
		'lblProgress
		'
		Me.lblProgress.AutoSize = True
		Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
		Me.lblProgress.Location = New System.Drawing.Point(421, 82)
		Me.lblProgress.Name = "lblProgress"
		Me.lblProgress.Size = New System.Drawing.Size(32, 20)
		Me.lblProgress.TabIndex = 7
		Me.lblProgress.Text = "0%"
		'
		'lblPorcentaje
		'
		Me.lblPorcentaje.AutoSize = True
		Me.lblPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
		Me.lblPorcentaje.Location = New System.Drawing.Point(45, 82)
		Me.lblPorcentaje.Name = "lblPorcentaje"
		Me.lblPorcentaje.Size = New System.Drawing.Size(31, 20)
		Me.lblPorcentaje.TabIndex = 6
		Me.lblPorcentaje.Text = "1/1"
		'
		'ERP_Inventory_ProgressBarSuggested
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(504, 103)
		Me.Controls.Add(Me.lblProgress)
		Me.Controls.Add(Me.lblPorcentaje)
		Me.Controls.Add(Me.pbSuggest)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "ERP_Inventory_ProgressBarSuggested"
		Me.Text = "ERP_Inventory_ProgressBarSuggested"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pbSuggest As ProgressBar
	Friend WithEvents bwProgressUploadFiles As System.ComponentModel.BackgroundWorker
	Friend WithEvents lblProgress As Label
	Friend WithEvents lblPorcentaje As Label
End Class

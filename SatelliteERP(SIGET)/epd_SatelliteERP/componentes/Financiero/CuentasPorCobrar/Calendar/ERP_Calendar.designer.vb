<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_Calendar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ERP_Calendar))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New Pabo.Calendar.MonthCalendar()
        Me.ImgLCalendar = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
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
        Me.cmdCancel.Location = New System.Drawing.Point(776, 713)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.ActiveMonth.Month = 4
        Me.MonthCalendar1.ActiveMonth.Year = 2016
        Me.MonthCalendar1.Culture = New System.Globalization.CultureInfo("es-SV")
        Me.MonthCalendar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MonthCalendar1.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar1.Header.BackColor1 = System.Drawing.SystemColors.HotTrack
        Me.MonthCalendar1.Header.BackColor2 = System.Drawing.Color.Gray
        Me.MonthCalendar1.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar1.ImageList = Me.ImgLCalendar
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 12)
        Me.MonthCalendar1.MaxDate = New Date(2026, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar1.MinDate = New Date(2006, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar1.Month.BackgroundImage = Nothing
        Me.MonthCalendar1.Month.Colors.Days.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar1.Month.Colors.Weekend.BackColor1 = System.Drawing.Color.Brown
        Me.MonthCalendar1.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.SelectionMode = Pabo.Calendar.mcSelectionMode.One
        Me.MonthCalendar1.ShowFooter = False
        Me.MonthCalendar1.Size = New System.Drawing.Size(862, 695)
        Me.MonthCalendar1.TabIndex = 1
        Me.MonthCalendar1.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Weekdays.Format = Pabo.Calendar.mcDayFormat.[Long]
        Me.MonthCalendar1.Weekdays.TextColor = System.Drawing.Color.Black
        Me.MonthCalendar1.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'ImgLCalendar
        '
        Me.ImgLCalendar.ImageStream = CType(resources.GetObject("ImgLCalendar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgLCalendar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgLCalendar.Images.SetKeyName(0, "arrows Left.png")
        Me.ImgLCalendar.Images.SetKeyName(1, "arrowRigth.png")
        '
        'ERP_Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(882, 745)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ERP_Calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_Calendar"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As Pabo.Calendar.MonthCalendar
    Friend WithEvents ImgLCalendar As System.Windows.Forms.ImageList
End Class

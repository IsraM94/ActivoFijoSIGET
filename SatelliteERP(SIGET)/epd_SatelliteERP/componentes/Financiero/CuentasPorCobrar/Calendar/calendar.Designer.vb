<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calendar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calendar))
        Me.ImgLCalendar = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MonthCalendar3 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar4 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar1 = New Pabo.Calendar.MonthCalendar()
        Me.MonthCalendar2 = New Pabo.Calendar.MonthCalendar()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImgLCalendar
        '
        Me.ImgLCalendar.ImageStream = CType(resources.GetObject("ImgLCalendar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgLCalendar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgLCalendar.Images.SetKeyName(0, "arrows Left.png")
        Me.ImgLCalendar.Images.SetKeyName(1, "arrowRigth.png")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MonthCalendar3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MonthCalendar4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MonthCalendar1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MonthCalendar2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1196, 697)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MonthCalendar3
        '
        Me.MonthCalendar3.ActiveMonth.Month = 1
        Me.MonthCalendar3.ActiveMonth.Year = 2016
        Me.MonthCalendar3.Culture = New System.Globalization.CultureInfo("es-SV")
        Me.MonthCalendar3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MonthCalendar3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthCalendar3.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar3.Header.BackColor1 = System.Drawing.SystemColors.HotTrack
        Me.MonthCalendar3.Header.BackColor2 = System.Drawing.Color.Gray
        Me.MonthCalendar3.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar3.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar3.ImageList = Nothing
        Me.MonthCalendar3.Location = New System.Drawing.Point(3, 351)
        Me.MonthCalendar3.MaxDate = New Date(2026, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar3.MinDate = New Date(2006, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar3.Month.BackgroundImage = Nothing
        Me.MonthCalendar3.Month.Colors.Days.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar3.Month.Colors.Weekend.BackColor1 = System.Drawing.Color.Brown
        Me.MonthCalendar3.Month.DateAlign = Pabo.Calendar.mcItemAlign.TopCenter
        Me.MonthCalendar3.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar3.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar3.Name = "MonthCalendar3"
        Me.MonthCalendar3.SelectionMode = Pabo.Calendar.mcSelectionMode.One
        Me.MonthCalendar3.ShowFooter = False
        Me.MonthCalendar3.Size = New System.Drawing.Size(592, 343)
        Me.MonthCalendar3.TabIndex = 6
        Me.MonthCalendar3.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar3.Weekdays.Format = Pabo.Calendar.mcDayFormat.[Long]
        Me.MonthCalendar3.Weekdays.TextColor = System.Drawing.Color.Black
        Me.MonthCalendar3.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MonthCalendar4
        '
        Me.MonthCalendar4.ActiveMonth.Month = 1
        Me.MonthCalendar4.ActiveMonth.Year = 2016
        Me.MonthCalendar4.Culture = New System.Globalization.CultureInfo("es-SV")
        Me.MonthCalendar4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MonthCalendar4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthCalendar4.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar4.Header.BackColor1 = System.Drawing.SystemColors.HotTrack
        Me.MonthCalendar4.Header.BackColor2 = System.Drawing.Color.Gray
        Me.MonthCalendar4.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar4.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar4.ImageList = Nothing
        Me.MonthCalendar4.Location = New System.Drawing.Point(601, 351)
        Me.MonthCalendar4.MaxDate = New Date(2026, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar4.MinDate = New Date(2006, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar4.Month.BackgroundImage = Nothing
        Me.MonthCalendar4.Month.Colors.Days.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar4.Month.Colors.Weekend.BackColor1 = System.Drawing.Color.Brown
        Me.MonthCalendar4.Month.DateAlign = Pabo.Calendar.mcItemAlign.TopCenter
        Me.MonthCalendar4.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar4.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar4.Name = "MonthCalendar4"
        Me.MonthCalendar4.SelectionMode = Pabo.Calendar.mcSelectionMode.One
        Me.MonthCalendar4.ShowFooter = False
        Me.MonthCalendar4.Size = New System.Drawing.Size(592, 343)
        Me.MonthCalendar4.TabIndex = 5
        Me.MonthCalendar4.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar4.Weekdays.Format = Pabo.Calendar.mcDayFormat.[Long]
        Me.MonthCalendar4.Weekdays.TextColor = System.Drawing.Color.Black
        Me.MonthCalendar4.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.ActiveMonth.Month = 1
        Me.MonthCalendar1.ActiveMonth.Year = 2016
        Me.MonthCalendar1.Culture = New System.Globalization.CultureInfo("es-SV")
        Me.MonthCalendar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthCalendar1.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar1.Header.BackColor1 = System.Drawing.SystemColors.HotTrack
        Me.MonthCalendar1.Header.BackColor2 = System.Drawing.Color.Gray
        Me.MonthCalendar1.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar1.ImageList = Nothing
        Me.MonthCalendar1.Location = New System.Drawing.Point(3, 3)
        Me.MonthCalendar1.MaxDate = New Date(2026, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar1.MinDate = New Date(2006, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar1.Month.BackgroundImage = Nothing
        Me.MonthCalendar1.Month.Colors.Days.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar1.Month.Colors.Weekend.BackColor1 = System.Drawing.Color.Brown
        Me.MonthCalendar1.Month.DateAlign = Pabo.Calendar.mcItemAlign.TopCenter
        Me.MonthCalendar1.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.SelectionMode = Pabo.Calendar.mcSelectionMode.One
        Me.MonthCalendar1.ShowFooter = False
        Me.MonthCalendar1.Size = New System.Drawing.Size(592, 342)
        Me.MonthCalendar1.TabIndex = 3
        Me.MonthCalendar1.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Weekdays.Format = Pabo.Calendar.mcDayFormat.[Long]
        Me.MonthCalendar1.Weekdays.TextColor = System.Drawing.Color.Black
        Me.MonthCalendar1.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.ActiveMonth.Month = 1
        Me.MonthCalendar2.ActiveMonth.Year = 2016
        Me.MonthCalendar2.Culture = New System.Globalization.CultureInfo("es-SV")
        Me.MonthCalendar2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MonthCalendar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthCalendar2.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar2.Header.BackColor1 = System.Drawing.SystemColors.HotTrack
        Me.MonthCalendar2.Header.BackColor2 = System.Drawing.Color.Gray
        Me.MonthCalendar2.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar2.ImageList = Nothing
        Me.MonthCalendar2.Location = New System.Drawing.Point(601, 3)
        Me.MonthCalendar2.MaxDate = New Date(2026, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar2.MinDate = New Date(2006, 4, 12, 9, 12, 59, 832)
        Me.MonthCalendar2.Month.BackgroundImage = Nothing
        Me.MonthCalendar2.Month.Colors.Days.BackColor1 = System.Drawing.Color.Silver
        Me.MonthCalendar2.Month.Colors.Weekend.BackColor1 = System.Drawing.Color.Brown
        Me.MonthCalendar2.Month.DateAlign = Pabo.Calendar.mcItemAlign.TopCenter
        Me.MonthCalendar2.Month.DateFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.SelectionMode = Pabo.Calendar.mcSelectionMode.One
        Me.MonthCalendar2.ShowFooter = False
        Me.MonthCalendar2.Size = New System.Drawing.Size(592, 342)
        Me.MonthCalendar2.TabIndex = 4
        Me.MonthCalendar2.Weekdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Weekdays.Format = Pabo.Calendar.mcDayFormat.[Long]
        Me.MonthCalendar2.Weekdays.TextColor = System.Drawing.Color.Black
        Me.MonthCalendar2.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "calendar"
        Me.Size = New System.Drawing.Size(1196, 697)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImgLCalendar As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MonthCalendar3 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar4 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar1 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MonthCalendar2 As Pabo.Calendar.MonthCalendar
End Class

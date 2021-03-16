<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ERP_MenuMetro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ERP_MenuMetro))
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelClockHours = New System.Windows.Forms.Label()
        Me.LabelClockDate = New System.Windows.Forms.Label()
        Me.LabelClockNumberDay = New System.Windows.Forms.Label()
        Me.LabelClockNameDay = New System.Windows.Forms.Label()
        Me.TimerColorChange = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlRestore = New System.Windows.Forms.Panel()
        Me.pnlBackup = New System.Windows.Forms.Panel()
        Me.pnlConfiguration = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.pnlAccounts = New System.Windows.Forms.Panel()
        Me.pnlPlanificacion = New System.Windows.Forms.Panel()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlRRHH = New System.Windows.Forms.Panel()
        Me.pnlFinansas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.pnlConfiguration.SuspendLayout()
        Me.pnlInventory.SuspendLayout()
        Me.pnlFinansas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMainTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblMainTitle.Location = New System.Drawing.Point(701, 599)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(0, 37)
        Me.lblMainTitle.TabIndex = 14
        Me.lblMainTitle.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.LabelClockHours)
        Me.Panel1.Controls.Add(Me.LabelClockDate)
        Me.Panel1.Controls.Add(Me.LabelClockNumberDay)
        Me.Panel1.Controls.Add(Me.LabelClockNameDay)
        Me.Panel1.Location = New System.Drawing.Point(747, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 256)
        Me.Panel1.TabIndex = 26
        '
        'LabelClockHours
        '
        Me.LabelClockHours.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClockHours.ForeColor = System.Drawing.Color.Red
        Me.LabelClockHours.Location = New System.Drawing.Point(3, 216)
        Me.LabelClockHours.Name = "LabelClockHours"
        Me.LabelClockHours.Size = New System.Drawing.Size(250, 32)
        Me.LabelClockHours.TabIndex = 5
        Me.LabelClockHours.Text = "09:23:32 Horas"
        Me.LabelClockHours.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelClockDate
        '
        Me.LabelClockDate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClockDate.ForeColor = System.Drawing.Color.Blue
        Me.LabelClockDate.Location = New System.Drawing.Point(3, 168)
        Me.LabelClockDate.Name = "LabelClockDate"
        Me.LabelClockDate.Size = New System.Drawing.Size(250, 42)
        Me.LabelClockDate.TabIndex = 4
        Me.LabelClockDate.Text = "Enero, 2016"
        Me.LabelClockDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelClockNumberDay
        '
        Me.LabelClockNumberDay.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClockNumberDay.ForeColor = System.Drawing.Color.Red
        Me.LabelClockNumberDay.Location = New System.Drawing.Point(3, 45)
        Me.LabelClockNumberDay.Name = "LabelClockNumberDay"
        Me.LabelClockNumberDay.Size = New System.Drawing.Size(253, 120)
        Me.LabelClockNumberDay.TabIndex = 3
        Me.LabelClockNumberDay.Text = "21"
        Me.LabelClockNumberDay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelClockNameDay
        '
        Me.LabelClockNameDay.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClockNameDay.Location = New System.Drawing.Point(3, 5)
        Me.LabelClockNameDay.Name = "LabelClockNameDay"
        Me.LabelClockNameDay.Size = New System.Drawing.Size(250, 37)
        Me.LabelClockNameDay.TabIndex = 2
        Me.LabelClockNameDay.Text = "JUEVES"
        Me.LabelClockNameDay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerColorChange
        '
        Me.TimerColorChange.Enabled = True
        Me.TimerColorChange.Interval = 2000
        '
        'TimerClock
        '
        Me.TimerClock.Enabled = True
        Me.TimerClock.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(349, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 37)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Electricidad y Telecomunicaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(385, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 37)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Superintendencia General de"
        '
        'pnlRestore
        '
        Me.pnlRestore.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlRestore.BackgroundImage = CType(resources.GetObject("pnlRestore.BackgroundImage"), System.Drawing.Image)
        Me.pnlRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlRestore.Location = New System.Drawing.Point(510, 434)
        Me.pnlRestore.Name = "pnlRestore"
        Me.pnlRestore.Size = New System.Drawing.Size(125, 125)
        Me.pnlRestore.TabIndex = 24
        '
        'pnlBackup
        '
        Me.pnlBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.pnlBackup.BackgroundImage = CType(resources.GetObject("pnlBackup.BackgroundImage"), System.Drawing.Image)
        Me.pnlBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBackup.Enabled = False
        Me.pnlBackup.Location = New System.Drawing.Point(379, 434)
        Me.pnlBackup.Name = "pnlBackup"
        Me.pnlBackup.Size = New System.Drawing.Size(125, 125)
        Me.pnlBackup.TabIndex = 23
        '
        'pnlConfiguration
        '
        Me.pnlConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pnlConfiguration.BackgroundImage = CType(resources.GetObject("pnlConfiguration.BackgroundImage"), System.Drawing.Image)
        Me.pnlConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlConfiguration.Controls.Add(Me.Label5)
        Me.pnlConfiguration.Enabled = False
        Me.pnlConfiguration.Location = New System.Drawing.Point(510, 172)
        Me.pnlConfiguration.Name = "pnlConfiguration"
        Me.pnlConfiguration.Size = New System.Drawing.Size(125, 125)
        Me.pnlConfiguration.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Configuración"
        '
        'pnlReports
        '
        Me.pnlReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.pnlReports.BackgroundImage = CType(resources.GetObject("pnlReports.BackgroundImage"), System.Drawing.Image)
        Me.pnlReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlReports.Location = New System.Drawing.Point(379, 303)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(256, 125)
        Me.pnlReports.TabIndex = 21
        '
        'pnlUser
        '
        Me.pnlUser.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlUser.BackgroundImage = CType(resources.GetObject("pnlUser.BackgroundImage"), System.Drawing.Image)
        Me.pnlUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlUser.Enabled = False
        Me.pnlUser.Location = New System.Drawing.Point(379, 172)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(125, 125)
        Me.pnlUser.TabIndex = 20
        '
        'pnlAccounts
        '
        Me.pnlAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.pnlAccounts.BackgroundImage = CType(resources.GetObject("pnlAccounts.BackgroundImage"), System.Drawing.Image)
        Me.pnlAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAccounts.Location = New System.Drawing.Point(143, 434)
        Me.pnlAccounts.Name = "pnlAccounts"
        Me.pnlAccounts.Size = New System.Drawing.Size(125, 125)
        Me.pnlAccounts.TabIndex = 19
        '
        'pnlPlanificacion
        '
        Me.pnlPlanificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlPlanificacion.BackgroundImage = CType(resources.GetObject("pnlPlanificacion.BackgroundImage"), System.Drawing.Image)
        Me.pnlPlanificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPlanificacion.Enabled = False
        Me.pnlPlanificacion.Location = New System.Drawing.Point(12, 434)
        Me.pnlPlanificacion.Name = "pnlPlanificacion"
        Me.pnlPlanificacion.Size = New System.Drawing.Size(125, 125)
        Me.pnlPlanificacion.TabIndex = 18
        '
        'pnlInventory
        '
        Me.pnlInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlInventory.BackgroundImage = CType(resources.GetObject("pnlInventory.BackgroundImage"), System.Drawing.Image)
        Me.pnlInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlInventory.Controls.Add(Me.Label4)
        Me.pnlInventory.Enabled = False
        Me.pnlInventory.Location = New System.Drawing.Point(143, 172)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(125, 125)
        Me.pnlInventory.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Inventario"
        '
        'pnlRRHH
        '
        Me.pnlRRHH.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.pnlRRHH.BackgroundImage = CType(resources.GetObject("pnlRRHH.BackgroundImage"), System.Drawing.Image)
        Me.pnlRRHH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlRRHH.Enabled = False
        Me.pnlRRHH.Location = New System.Drawing.Point(12, 303)
        Me.pnlRRHH.Name = "pnlRRHH"
        Me.pnlRRHH.Size = New System.Drawing.Size(256, 125)
        Me.pnlRRHH.TabIndex = 16
        '
        'pnlFinansas
        '
        Me.pnlFinansas.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.pnlFinansas.BackgroundImage = CType(resources.GetObject("pnlFinansas.BackgroundImage"), System.Drawing.Image)
        Me.pnlFinansas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFinansas.Controls.Add(Me.Label3)
        Me.pnlFinansas.Enabled = False
        Me.pnlFinansas.Location = New System.Drawing.Point(12, 172)
        Me.pnlFinansas.Name = "pnlFinansas"
        Me.pnlFinansas.Size = New System.Drawing.Size(125, 125)
        Me.pnlFinansas.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Activo Fijo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(747, 434)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 21)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'ERP_MenuMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1041, 599)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMainTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRestore)
        Me.Controls.Add(Me.pnlBackup)
        Me.Controls.Add(Me.pnlConfiguration)
        Me.Controls.Add(Me.pnlReports)
        Me.Controls.Add(Me.pnlUser)
        Me.Controls.Add(Me.pnlAccounts)
        Me.Controls.Add(Me.pnlPlanificacion)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.pnlRRHH)
        Me.Controls.Add(Me.pnlFinansas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ERP_MenuMetro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERP_MenuMetro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnlConfiguration.ResumeLayout(False)
        Me.pnlConfiguration.PerformLayout()
        Me.pnlInventory.ResumeLayout(False)
        Me.pnlInventory.PerformLayout()
        Me.pnlFinansas.ResumeLayout(False)
        Me.pnlFinansas.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblMainTitle As Label
    Private WithEvents pnlRestore As Panel
    Private WithEvents pnlBackup As Panel
    Private WithEvents pnlConfiguration As Panel
    Private WithEvents pnlReports As Panel
    Private WithEvents pnlUser As Panel
    Private WithEvents pnlAccounts As Panel
    Private WithEvents pnlInventory As Panel
    Private WithEvents pnlRRHH As Panel
    Private WithEvents Panel1 As Panel
    Private WithEvents LabelClockHours As Label
    Private WithEvents LabelClockDate As Label
    Private WithEvents LabelClockNumberDay As Label
    Private WithEvents LabelClockNameDay As Label
    Friend WithEvents TimerColorChange As Timer
    Friend WithEvents TimerClock As Timer
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents pnlFinansas As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents pnlPlanificacion As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

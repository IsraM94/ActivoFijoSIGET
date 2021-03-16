<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP_PayCreditLine
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDeudaActual = New System.Windows.Forms.TextBox()
        Me.txtDiasVencimientoFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.CbCreditLine = New System.Windows.Forms.ComboBox()
        Me.lblCreditLine = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtVigencia = New System.Windows.Forms.TextBox()
        Me.lblVigencia = New System.Windows.Forms.Label()
        Me.DatePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.DatePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblDateStart = New System.Windows.Forms.Label()
        Me.lblDateEnd = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDeudaActual)
        Me.GroupBox1.Controls.Add(Me.txtDiasVencimientoFactura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.CbCreditLine)
        Me.GroupBox1.Controls.Add(Me.lblCreditLine)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.lblConcepto)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 310)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Línea de Crédito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(260, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Deuda: "
        '
        'txtDeudaActual
        '
        Me.txtDeudaActual.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDeudaActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeudaActual.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeudaActual.Location = New System.Drawing.Point(342, 110)
        Me.txtDeudaActual.MaxLength = 15
        Me.txtDeudaActual.Name = "txtDeudaActual"
        Me.txtDeudaActual.ReadOnly = True
        Me.txtDeudaActual.ShortcutsEnabled = False
        Me.txtDeudaActual.Size = New System.Drawing.Size(112, 26)
        Me.txtDeudaActual.TabIndex = 14
        Me.txtDeudaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasVencimientoFactura
        '
        Me.txtDiasVencimientoFactura.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDiasVencimientoFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiasVencimientoFactura.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasVencimientoFactura.Location = New System.Drawing.Point(245, 237)
        Me.txtDiasVencimientoFactura.MaxLength = 3
        Me.txtDiasVencimientoFactura.Name = "txtDiasVencimientoFactura"
        Me.txtDiasVencimientoFactura.ShortcutsEnabled = False
        Me.txtDiasVencimientoFactura.Size = New System.Drawing.Size(127, 26)
        Me.txtDiasVencimientoFactura.TabIndex = 5
        Me.txtDiasVencimientoFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(19, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Días Vencimiento Factura:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(317, 32)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(137, 29)
        Me.chkActivo.TabIndex = 1
        Me.chkActivo.Text = "Línea Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'CbCreditLine
        '
        Me.CbCreditLine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbCreditLine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbCreditLine.BackColor = System.Drawing.Color.Gainsboro
        Me.CbCreditLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCreditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbCreditLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCreditLine.FormattingEnabled = True
        Me.CbCreditLine.Location = New System.Drawing.Point(122, 191)
        Me.CbCreditLine.Name = "CbCreditLine"
        Me.CbCreditLine.Size = New System.Drawing.Size(354, 29)
        Me.CbCreditLine.TabIndex = 4
        '
        'lblCreditLine
        '
        Me.lblCreditLine.AutoSize = True
        Me.lblCreditLine.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblCreditLine.Location = New System.Drawing.Point(58, 189)
        Me.lblCreditLine.Name = "lblCreditLine"
        Me.lblCreditLine.Size = New System.Drawing.Size(58, 25)
        Me.lblCreditLine.TabIndex = 0
        Me.lblCreditLine.Text = "Tipo :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtVigencia)
        Me.GroupBox2.Controls.Add(Me.lblVigencia)
        Me.GroupBox2.Controls.Add(Me.DatePickerStart)
        Me.GroupBox2.Controls.Add(Me.DatePickerEnd)
        Me.GroupBox2.Controls.Add(Me.lblDateStart)
        Me.GroupBox2.Controls.Add(Me.lblDateEnd)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(481, 42)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(244, 178)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vigencia del Crédito"
        '
        'TxtVigencia
        '
        Me.TxtVigencia.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtVigencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtVigencia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVigencia.Location = New System.Drawing.Point(130, 131)
        Me.TxtVigencia.MaxLength = 5
        Me.TxtVigencia.Name = "TxtVigencia"
        Me.TxtVigencia.ReadOnly = True
        Me.TxtVigencia.ShortcutsEnabled = False
        Me.TxtVigencia.Size = New System.Drawing.Size(93, 26)
        Me.TxtVigencia.TabIndex = 8
        Me.TxtVigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVigencia
        '
        Me.lblVigencia.AutoSize = True
        Me.lblVigencia.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblVigencia.Location = New System.Drawing.Point(20, 131)
        Me.lblVigencia.Name = "lblVigencia"
        Me.lblVigencia.Size = New System.Drawing.Size(62, 25)
        Me.lblVigencia.TabIndex = 0
        Me.lblVigencia.Text = "Días : "
        '
        'DatePickerStart
        '
        Me.DatePickerStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePickerStart.Location = New System.Drawing.Point(106, 35)
        Me.DatePickerStart.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePickerStart.Name = "DatePickerStart"
        Me.DatePickerStart.Size = New System.Drawing.Size(118, 29)
        Me.DatePickerStart.TabIndex = 6
        '
        'DatePickerEnd
        '
        Me.DatePickerEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePickerEnd.Location = New System.Drawing.Point(106, 81)
        Me.DatePickerEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePickerEnd.Name = "DatePickerEnd"
        Me.DatePickerEnd.Size = New System.Drawing.Size(118, 29)
        Me.DatePickerEnd.TabIndex = 7
        '
        'lblDateStart
        '
        Me.lblDateStart.AutoSize = True
        Me.lblDateStart.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblDateStart.Location = New System.Drawing.Point(5, 35)
        Me.lblDateStart.Name = "lblDateStart"
        Me.lblDateStart.Size = New System.Drawing.Size(78, 25)
        Me.lblDateStart.TabIndex = 0
        Me.lblDateStart.Text = "Desde : "
        '
        'lblDateEnd
        '
        Me.lblDateEnd.AutoSize = True
        Me.lblDateEnd.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblDateEnd.Location = New System.Drawing.Point(5, 82)
        Me.lblDateEnd.Name = "lblDateEnd"
        Me.lblDateEnd.Size = New System.Drawing.Size(78, 25)
        Me.lblDateEnd.TabIndex = 0
        Me.lblDateEnd.Text = "Vence : "
        '
        'txtConcepto
        '
        Me.txtConcepto.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConcepto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(122, 149)
        Me.txtConcepto.MaxLength = 100
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ShortcutsEnabled = False
        Me.txtConcepto.Size = New System.Drawing.Size(332, 26)
        Me.txtConcepto.TabIndex = 3
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(19, 149)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(97, 25)
        Me.lblConcepto.TabIndex = 0
        Me.lblConcepto.Text = "Concepto:"
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
        Me.cmdCancel.Location = New System.Drawing.Point(606, 267)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(98, 28)
        Me.cmdCancel.TabIndex = 10
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
        Me.cmdSave.Location = New System.Drawing.Point(493, 267)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 28)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Grabar"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(48, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saldo: "
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblValor.Location = New System.Drawing.Point(39, 73)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(77, 25)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Monto: "
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(122, 111)
        Me.txtSaldo.MaxLength = 15
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.ShortcutsEnabled = False
        Me.txtSaldo.Size = New System.Drawing.Size(127, 26)
        Me.txtSaldo.TabIndex = 2
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(122, 73)
        Me.txtValor.MaxLength = 15
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ShortcutsEnabled = False
        Me.txtValor.Size = New System.Drawing.Size(127, 26)
        Me.txtValor.TabIndex = 1
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ERP_PayCreditLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(758, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ERP_PayCreditLine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERP_PayCreditLine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents CbCreditLine As ComboBox
    Private WithEvents lblCreditLine As Label
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents TxtVigencia As TextBox
    Private WithEvents lblVigencia As Label
    Friend WithEvents DatePickerStart As DateTimePicker
    Friend WithEvents DatePickerEnd As DateTimePicker
    Private WithEvents lblDateStart As Label
    Private WithEvents lblDateEnd As Label
    Private WithEvents txtConcepto As TextBox
    Private WithEvents lblConcepto As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdSave As Button
    Private WithEvents lblValor As Label
    Private WithEvents txtValor As TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Private WithEvents Label1 As Label
    Private WithEvents txtSaldo As TextBox
	Private WithEvents Label2 As Label
	Private WithEvents txtDiasVencimientoFactura As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents txtDeudaActual As TextBox
End Class

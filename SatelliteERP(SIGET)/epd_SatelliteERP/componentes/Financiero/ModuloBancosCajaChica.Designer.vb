<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModuloBancosCajaChica
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.VistaGeneral = New System.Windows.Forms.TabPage()
        Me.gbStudentDetails = New System.Windows.Forms.GroupBox()
        Me.saldoBancos = New System.Windows.Forms.TabPage()
        Me.TLP_PlanDePagos = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_Bank = New System.Windows.Forms.DataGridView()
        Me.ID_BankCatalog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_BankCatalog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance_Bank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Transaction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCuotaClienteMora = New System.Windows.Forms.Button()
        Me.Movimientos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_MovementBank = New System.Windows.Forms.DataGridView()
        Me.ID_BankMovements = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Bank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankMovement_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankMovement_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankMovement_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Movement_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cheques = New System.Windows.Forms.TabPage()
        Me.TLP_Clientes = New System.Windows.Forms.TableLayoutPanel()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.ID_Customer_FK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Is_Supplier = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tipo_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Comercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel_Oficina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCrearCliente = New System.Windows.Forms.Button()
        Me.SaldosCajaChica = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGVCajaChica = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MovimientosCajaChica = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGVMovementPettyCash = New System.Windows.Forms.DataGridView()
        Me.ID_PettyCash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paidTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inConceptOf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_Users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Create_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovementType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ConfiguraciondeCheques = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmd_ConfigCheque_Config = New System.Windows.Forms.Button()
        Me.cmd_ConfigCF_ZoomMAS = New System.Windows.Forms.Button()
        Me.cmd_ConfigCF_ZoomMenos = New System.Windows.Forms.Button()
        Me.Panel_ConfiguracionCheque = New System.Windows.Forms.Panel()
        Me.PPC_ConfigCheque = New System.Windows.Forms.PrintPreviewControl()
        Me.tcMain.SuspendLayout()
        Me.VistaGeneral.SuspendLayout()
        Me.saldoBancos.SuspendLayout()
        Me.TLP_PlanDePagos.SuspendLayout()
        CType(Me.DG_Bank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Movimientos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_MovementBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Cheques.SuspendLayout()
        Me.TLP_Clientes.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.SaldosCajaChica.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGVCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.MovimientosCajaChica.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DGVMovementPettyCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.ConfiguraciondeCheques.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.Panel_ConfiguracionCheque.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcMain.Controls.Add(Me.VistaGeneral)
        Me.tcMain.Controls.Add(Me.saldoBancos)
        Me.tcMain.Controls.Add(Me.Movimientos)
        Me.tcMain.Controls.Add(Me.Cheques)
        Me.tcMain.Controls.Add(Me.SaldosCajaChica)
        Me.tcMain.Controls.Add(Me.MovimientosCajaChica)
        Me.tcMain.Controls.Add(Me.ConfiguraciondeCheques)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMain.HotTrack = True
        Me.tcMain.Location = New System.Drawing.Point(0, 0)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.TabIndex = 1
        Me.tcMain.TabStop = False
        '
        'VistaGeneral
        '
        Me.VistaGeneral.BackColor = System.Drawing.Color.White
        Me.VistaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VistaGeneral.Controls.Add(Me.gbStudentDetails)
        Me.VistaGeneral.Location = New System.Drawing.Point(4, 35)
        Me.VistaGeneral.Name = "VistaGeneral"
        Me.VistaGeneral.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.VistaGeneral.Size = New System.Drawing.Size(1087, 540)
        Me.VistaGeneral.TabIndex = 0
        Me.VistaGeneral.Text = "Vista General"
        '
        'gbStudentDetails
        '
        Me.gbStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbStudentDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudentDetails.ForeColor = System.Drawing.Color.Black
        Me.gbStudentDetails.Location = New System.Drawing.Point(3, 3)
        Me.gbStudentDetails.Name = "gbStudentDetails"
        Me.gbStudentDetails.Size = New System.Drawing.Size(1079, 532)
        Me.gbStudentDetails.TabIndex = 0
        Me.gbStudentDetails.TabStop = False
        Me.gbStudentDetails.Text = "Vista Principal"
        '
        'saldoBancos
        '
        Me.saldoBancos.Controls.Add(Me.TLP_PlanDePagos)
        Me.saldoBancos.Location = New System.Drawing.Point(4, 35)
        Me.saldoBancos.Name = "saldoBancos"
        Me.saldoBancos.Size = New System.Drawing.Size(1087, 540)
        Me.saldoBancos.TabIndex = 5
        Me.saldoBancos.Text = "Saldo Bancos"
        Me.saldoBancos.UseVisualStyleBackColor = True
        '
        'TLP_PlanDePagos
        '
        Me.TLP_PlanDePagos.ColumnCount = 1
        Me.TLP_PlanDePagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_PlanDePagos.Controls.Add(Me.DG_Bank, 0, 1)
        Me.TLP_PlanDePagos.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
        Me.TLP_PlanDePagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_PlanDePagos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_PlanDePagos.Location = New System.Drawing.Point(0, 0)
        Me.TLP_PlanDePagos.Name = "TLP_PlanDePagos"
        Me.TLP_PlanDePagos.RowCount = 2
        Me.TLP_PlanDePagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_PlanDePagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_PlanDePagos.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_PlanDePagos.TabIndex = 3
        '
        'DG_Bank
        '
        Me.DG_Bank.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_Bank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_BankCatalog, Me.Name_BankCatalog, Me.Balance_Bank, Me.Last_Transaction})
        Me.DG_Bank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Bank.EnableHeadersVisualStyles = False
        Me.DG_Bank.Location = New System.Drawing.Point(3, 78)
        Me.DG_Bank.Name = "DG_Bank"
        Me.DG_Bank.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_Bank.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DG_Bank.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Bank.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_Bank.ShowCellErrors = False
        Me.DG_Bank.ShowCellToolTips = False
        Me.DG_Bank.ShowEditingIcon = False
        Me.DG_Bank.ShowRowErrors = False
        Me.DG_Bank.Size = New System.Drawing.Size(1081, 459)
        Me.DG_Bank.TabIndex = 3
        '
        'ID_BankCatalog
        '
        Me.ID_BankCatalog.DataPropertyName = "ID_BankCatalog"
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ID_BankCatalog.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID_BankCatalog.HeaderText = "Correlativo"
        Me.ID_BankCatalog.Name = "ID_BankCatalog"
        Me.ID_BankCatalog.Width = 107
        '
        'Name_BankCatalog
        '
        Me.Name_BankCatalog.DataPropertyName = "Name_BankCatalog"
        Me.Name_BankCatalog.HeaderText = "Nombre del Banco"
        Me.Name_BankCatalog.Name = "Name_BankCatalog"
        Me.Name_BankCatalog.Width = 114
        '
        'Balance_Bank
        '
        Me.Balance_Bank.DataPropertyName = "Balance_Bank"
        Me.Balance_Bank.HeaderText = "Saldo Banco"
        Me.Balance_Bank.Name = "Balance_Bank"
        Me.Balance_Bank.Width = 179
        '
        'Last_Transaction
        '
        Me.Last_Transaction.DataPropertyName = "Last_Transaction"
        Me.Last_Transaction.HeaderText = "Ultima Transacción"
        Me.Last_Transaction.Name = "Last_Transaction"
        Me.Last_Transaction.Width = 160
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdCuotaClienteMora)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'cmdCuotaClienteMora
        '
        Me.cmdCuotaClienteMora.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCuotaClienteMora.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCuotaClienteMora.FlatAppearance.BorderSize = 0
        Me.cmdCuotaClienteMora.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuotaClienteMora.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCuotaClienteMora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCuotaClienteMora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuotaClienteMora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCuotaClienteMora.Location = New System.Drawing.Point(3, 3)
        Me.cmdCuotaClienteMora.Name = "cmdCuotaClienteMora"
        Me.cmdCuotaClienteMora.Size = New System.Drawing.Size(132, 66)
        Me.cmdCuotaClienteMora.TabIndex = 43
        Me.cmdCuotaClienteMora.Text = "Reporte de Saldos Bancos"
        Me.cmdCuotaClienteMora.UseVisualStyleBackColor = False
        '
        'Movimientos
        '
        Me.Movimientos.Controls.Add(Me.TableLayoutPanel1)
        Me.Movimientos.Location = New System.Drawing.Point(4, 35)
        Me.Movimientos.Name = "Movimientos"
        Me.Movimientos.Size = New System.Drawing.Size(1087, 540)
        Me.Movimientos.TabIndex = 8
        Me.Movimientos.Text = "Movimientos Bancos"
        Me.Movimientos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DG_MovementBank, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'DG_MovementBank
        '
        Me.DG_MovementBank.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_MovementBank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_BankMovements, Me.Name_Bank, Me.BankMovement_Description, Me.BankMovement_Amount, Me.BankMovement_Type, Me.TipoMovimiento, Me.Movement_date})
        Me.DG_MovementBank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_MovementBank.EnableHeadersVisualStyles = False
        Me.DG_MovementBank.Location = New System.Drawing.Point(3, 78)
        Me.DG_MovementBank.Name = "DG_MovementBank"
        Me.DG_MovementBank.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_MovementBank.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DG_MovementBank.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_MovementBank.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_MovementBank.ShowCellErrors = False
        Me.DG_MovementBank.ShowCellToolTips = False
        Me.DG_MovementBank.ShowEditingIcon = False
        Me.DG_MovementBank.ShowRowErrors = False
        Me.DG_MovementBank.Size = New System.Drawing.Size(1081, 459)
        Me.DG_MovementBank.TabIndex = 3
        '
        'ID_BankMovements
        '
        Me.ID_BankMovements.DataPropertyName = "ID_BankMovements"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ID_BankMovements.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID_BankMovements.HeaderText = "Correlativo"
        Me.ID_BankMovements.Name = "ID_BankMovements"
        Me.ID_BankMovements.Width = 107
        '
        'Name_Bank
        '
        Me.Name_Bank.DataPropertyName = "Name_BankCatalog"
        Me.Name_Bank.HeaderText = "Nombre del Banco"
        Me.Name_Bank.Name = "Name_Bank"
        Me.Name_Bank.Width = 114
        '
        'BankMovement_Description
        '
        Me.BankMovement_Description.DataPropertyName = "BankMovement_Description"
        Me.BankMovement_Description.HeaderText = "Descripción del movimiento"
        Me.BankMovement_Description.Name = "BankMovement_Description"
        Me.BankMovement_Description.Width = 179
        '
        'BankMovement_Amount
        '
        Me.BankMovement_Amount.DataPropertyName = "BankMovement_Amount"
        Me.BankMovement_Amount.HeaderText = "Monto del Movimiento"
        Me.BankMovement_Amount.Name = "BankMovement_Amount"
        Me.BankMovement_Amount.Width = 160
        '
        'BankMovement_Type
        '
        Me.BankMovement_Type.DataPropertyName = "BankMovement_Type"
        Me.BankMovement_Type.HeaderText = "BankMovement_Type"
        Me.BankMovement_Type.Name = "BankMovement_Type"
        Me.BankMovement_Type.Visible = False
        '
        'TipoMovimiento
        '
        Me.TipoMovimiento.DataPropertyName = "TipoMovimiento"
        Me.TipoMovimiento.HeaderText = "Tipo Movimiento"
        Me.TipoMovimiento.Name = "TipoMovimiento"
        '
        'Movement_date
        '
        Me.Movement_date.DataPropertyName = "Movement_date"
        Me.Movement_date.HeaderText = "Fecha Movimiento"
        Me.Movement_date.Name = "Movement_date"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 66)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Reporte de Movimientos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(140, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 66)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Remesa Entrada"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(277, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 66)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Remesa Salida"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Cheques
        '
        Me.Cheques.Controls.Add(Me.TLP_Clientes)
        Me.Cheques.Location = New System.Drawing.Point(4, 35)
        Me.Cheques.Name = "Cheques"
        Me.Cheques.Size = New System.Drawing.Size(1087, 540)
        Me.Cheques.TabIndex = 9
        Me.Cheques.Text = "Cheques"
        Me.Cheques.UseVisualStyleBackColor = True
        '
        'TLP_Clientes
        '
        Me.TLP_Clientes.ColumnCount = 1
        Me.TLP_Clientes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Clientes.Controls.Add(Me.DGVClientes, 0, 1)
        Me.TLP_Clientes.Controls.Add(Me.FlowLayoutPanel5, 0, 0)
        Me.TLP_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Clientes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_Clientes.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Clientes.Name = "TLP_Clientes"
        Me.TLP_Clientes.RowCount = 2
        Me.TLP_Clientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TLP_Clientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Clientes.Size = New System.Drawing.Size(1087, 540)
        Me.TLP_Clientes.TabIndex = 3
        '
        'DGVClientes
        '
        Me.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Customer_FK, Me.Is_Supplier, Me.Tipo_Cliente, Me.Cliente_RazonSocial, Me.Nombre_Comercial, Me.Tel_Oficina, Me.CorreoContacto})
        Me.DGVClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVClientes.EnableHeadersVisualStyles = False
        Me.DGVClientes.Location = New System.Drawing.Point(3, 88)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVClientes.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGVClientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVClientes.ShowCellErrors = False
        Me.DGVClientes.ShowCellToolTips = False
        Me.DGVClientes.ShowEditingIcon = False
        Me.DGVClientes.ShowRowErrors = False
        Me.DGVClientes.Size = New System.Drawing.Size(1081, 449)
        Me.DGVClientes.TabIndex = 2
        '
        'ID_Customer_FK
        '
        Me.ID_Customer_FK.DataPropertyName = "Id_Customer"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ID_Customer_FK.DefaultCellStyle = DataGridViewCellStyle5
        Me.ID_Customer_FK.HeaderText = "Correlativo"
        Me.ID_Customer_FK.Name = "ID_Customer_FK"
        Me.ID_Customer_FK.Width = 107
        '
        'Is_Supplier
        '
        Me.Is_Supplier.DataPropertyName = "Is_Supplier"
        Me.Is_Supplier.FalseValue = "0"
        Me.Is_Supplier.HeaderText = "Es Proveedor"
        Me.Is_Supplier.Name = "Is_Supplier"
        Me.Is_Supplier.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Is_Supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Is_Supplier.TrueValue = "1"
        Me.Is_Supplier.Width = 120
        '
        'Tipo_Cliente
        '
        Me.Tipo_Cliente.DataPropertyName = "DescriptionCustomer"
        Me.Tipo_Cliente.HeaderText = "Tipo Cliente"
        Me.Tipo_Cliente.Name = "Tipo_Cliente"
        Me.Tipo_Cliente.Width = 114
        '
        'Cliente_RazonSocial
        '
        Me.Cliente_RazonSocial.DataPropertyName = "Name_Company"
        Me.Cliente_RazonSocial.HeaderText = "Cliente / Razón social"
        Me.Cliente_RazonSocial.Name = "Cliente_RazonSocial"
        Me.Cliente_RazonSocial.Width = 179
        '
        'Nombre_Comercial
        '
        Me.Nombre_Comercial.DataPropertyName = "Commercial_Name"
        Me.Nombre_Comercial.HeaderText = "Nombre Comercial"
        Me.Nombre_Comercial.Name = "Nombre_Comercial"
        Me.Nombre_Comercial.Width = 160
        '
        'Tel_Oficina
        '
        Me.Tel_Oficina.DataPropertyName = "OfficePhone"
        Me.Tel_Oficina.HeaderText = "Tel. Oficina"
        Me.Tel_Oficina.Name = "Tel_Oficina"
        Me.Tel_Oficina.Width = 108
        '
        'CorreoContacto
        '
        Me.CorreoContacto.DataPropertyName = "Email_Contact"
        Me.CorreoContacto.HeaderText = "Correo Contacto"
        Me.CorreoContacto.Name = "CorreoContacto"
        Me.CorreoContacto.Width = 143
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.cmdCrearCliente)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(1081, 79)
        Me.FlowLayoutPanel5.TabIndex = 1
        '
        'cmdCrearCliente
        '
        Me.cmdCrearCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmdCrearCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCrearCliente.FlatAppearance.BorderSize = 0
        Me.cmdCrearCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCrearCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCrearCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCrearCliente.Location = New System.Drawing.Point(3, 3)
        Me.cmdCrearCliente.Name = "cmdCrearCliente"
        Me.cmdCrearCliente.Size = New System.Drawing.Size(112, 66)
        Me.cmdCrearCliente.TabIndex = 35
        Me.cmdCrearCliente.Text = "Generacion de Cheques"
        Me.cmdCrearCliente.UseVisualStyleBackColor = False
        '
        'SaldosCajaChica
        '
        Me.SaldosCajaChica.Controls.Add(Me.TableLayoutPanel3)
        Me.SaldosCajaChica.Location = New System.Drawing.Point(4, 35)
        Me.SaldosCajaChica.Name = "SaldosCajaChica"
        Me.SaldosCajaChica.Size = New System.Drawing.Size(1087, 540)
        Me.SaldosCajaChica.TabIndex = 10
        Me.SaldosCajaChica.Text = "Saldos Caja Chica"
        Me.SaldosCajaChica.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DGVCajaChica, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'DGVCajaChica
        '
        Me.DGVCajaChica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCajaChica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DGVCajaChica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCajaChica.EnableHeadersVisualStyles = False
        Me.DGVCajaChica.Location = New System.Drawing.Point(3, 78)
        Me.DGVCajaChica.Name = "DGVCajaChica"
        Me.DGVCajaChica.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCajaChica.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGVCajaChica.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVCajaChica.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVCajaChica.ShowCellErrors = False
        Me.DGVCajaChica.ShowCellToolTips = False
        Me.DGVCajaChica.ShowEditingIcon = False
        Me.DGVCajaChica.ShowRowErrors = False
        Me.DGVCajaChica.Size = New System.Drawing.Size(1081, 459)
        Me.DGVCajaChica.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_BankCatalog"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 107
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name_BankCatalog"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre del Banco"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 114
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Balance_Bank"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Saldo Banco"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 179
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Last_Transaction"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Última Transacción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 160
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.Button7)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.Location = New System.Drawing.Point(3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(131, 66)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "Reporte de Saldos"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'MovimientosCajaChica
        '
        Me.MovimientosCajaChica.Controls.Add(Me.TableLayoutPanel2)
        Me.MovimientosCajaChica.Location = New System.Drawing.Point(4, 35)
        Me.MovimientosCajaChica.Name = "MovimientosCajaChica"
        Me.MovimientosCajaChica.Size = New System.Drawing.Size(1087, 540)
        Me.MovimientosCajaChica.TabIndex = 11
        Me.MovimientosCajaChica.Text = "Movimientos Caja Chica"
        Me.MovimientosCajaChica.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DGVMovementPettyCash, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'DGVMovementPettyCash
        '
        Me.DGVMovementPettyCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVMovementPettyCash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_PettyCash, Me.paidTo, Me.amount, Me.inConceptOf, Me.Create_Users, Me.Create_date, Me.MovementType})
        Me.DGVMovementPettyCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVMovementPettyCash.EnableHeadersVisualStyles = False
        Me.DGVMovementPettyCash.Location = New System.Drawing.Point(3, 78)
        Me.DGVMovementPettyCash.Name = "DGVMovementPettyCash"
        Me.DGVMovementPettyCash.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVMovementPettyCash.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGVMovementPettyCash.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVMovementPettyCash.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVMovementPettyCash.ShowCellErrors = False
        Me.DGVMovementPettyCash.ShowCellToolTips = False
        Me.DGVMovementPettyCash.ShowEditingIcon = False
        Me.DGVMovementPettyCash.ShowRowErrors = False
        Me.DGVMovementPettyCash.Size = New System.Drawing.Size(1081, 459)
        Me.DGVMovementPettyCash.TabIndex = 3
        '
        'ID_PettyCash
        '
        Me.ID_PettyCash.DataPropertyName = "Id_BankMovements"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.ID_PettyCash.DefaultCellStyle = DataGridViewCellStyle9
        Me.ID_PettyCash.HeaderText = "Correlativo"
        Me.ID_PettyCash.Name = "ID_PettyCash"
        Me.ID_PettyCash.Width = 107
        '
        'paidTo
        '
        Me.paidTo.DataPropertyName = "BankMovement_Payedto"
        Me.paidTo.HeaderText = "Pagado a"
        Me.paidTo.Name = "paidTo"
        Me.paidTo.Width = 114
        '
        'amount
        '
        Me.amount.DataPropertyName = "BankMovement_Amount"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle10
        Me.amount.HeaderText = "Monto Pagado"
        Me.amount.Name = "amount"
        Me.amount.Width = 179
        '
        'inConceptOf
        '
        Me.inConceptOf.DataPropertyName = "BankMovement_Description"
        Me.inConceptOf.HeaderText = "En Concepto de:"
        Me.inConceptOf.Name = "inConceptOf"
        Me.inConceptOf.Width = 160
        '
        'Create_Users
        '
        Me.Create_Users.DataPropertyName = "Create_Users"
        Me.Create_Users.HeaderText = "Usuario Creo"
        Me.Create_Users.Name = "Create_Users"
        Me.Create_Users.Visible = False
        '
        'Create_date
        '
        Me.Create_date.DataPropertyName = "Movement_Date"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Create_date.DefaultCellStyle = DataGridViewCellStyle11
        Me.Create_date.HeaderText = "Fecha Movimiento"
        Me.Create_date.Name = "Create_date"
        '
        'MovementType
        '
        Me.MovementType.DataPropertyName = "tipomovimiento"
        Me.MovementType.HeaderText = "Tipo de Movimiento"
        Me.MovementType.Name = "MovementType"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button6)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 66)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Reporte de Movimientos Caja Chica"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(176, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 66)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Entrada Caja Chica"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(313, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 66)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Salida Caja Chica"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ConfiguraciondeCheques
        '
        Me.ConfiguraciondeCheques.Controls.Add(Me.TableLayoutPanel4)
        Me.ConfiguraciondeCheques.Location = New System.Drawing.Point(4, 35)
        Me.ConfiguraciondeCheques.Name = "ConfiguraciondeCheques"
        Me.ConfiguraciondeCheques.Size = New System.Drawing.Size(1087, 540)
        Me.ConfiguraciondeCheques.TabIndex = 12
        Me.ConfiguraciondeCheques.Text = "Conf. Cheques"
        Me.ConfiguraciondeCheques.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel_ConfiguracionCheque, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1087, 540)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.cmd_ConfigCheque_Config)
        Me.FlowLayoutPanel6.Controls.Add(Me.cmd_ConfigCF_ZoomMAS)
        Me.FlowLayoutPanel6.Controls.Add(Me.cmd_ConfigCF_ZoomMenos)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(1081, 69)
        Me.FlowLayoutPanel6.TabIndex = 1
        '
        'cmd_ConfigCheque_Config
        '
        Me.cmd_ConfigCheque_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigCheque_Config.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigCheque_Config.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigCheque_Config.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCheque_Config.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCheque_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigCheque_Config.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigCheque_Config.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_ConfigCheque_Config.Location = New System.Drawing.Point(3, 3)
        Me.cmd_ConfigCheque_Config.Name = "cmd_ConfigCheque_Config"
        Me.cmd_ConfigCheque_Config.Size = New System.Drawing.Size(108, 66)
        Me.cmd_ConfigCheque_Config.TabIndex = 33
        Me.cmd_ConfigCheque_Config.Text = "Configurar Cheque"
        Me.cmd_ConfigCheque_Config.UseVisualStyleBackColor = False
        '
        'cmd_ConfigCF_ZoomMAS
        '
        Me.cmd_ConfigCF_ZoomMAS.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMAS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigCF_ZoomMAS.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigCF_ZoomMAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_ConfigCF_ZoomMAS.Location = New System.Drawing.Point(117, 3)
        Me.cmd_ConfigCF_ZoomMAS.Name = "cmd_ConfigCF_ZoomMAS"
        Me.cmd_ConfigCF_ZoomMAS.Size = New System.Drawing.Size(108, 66)
        Me.cmd_ConfigCF_ZoomMAS.TabIndex = 35
        Me.cmd_ConfigCF_ZoomMAS.Text = "+"
        Me.cmd_ConfigCF_ZoomMAS.UseVisualStyleBackColor = False
        '
        'cmd_ConfigCF_ZoomMenos
        '
        Me.cmd_ConfigCF_ZoomMenos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.BorderSize = 0
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMenos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmd_ConfigCF_ZoomMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ConfigCF_ZoomMenos.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConfigCF_ZoomMenos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_ConfigCF_ZoomMenos.Location = New System.Drawing.Point(231, 3)
        Me.cmd_ConfigCF_ZoomMenos.Name = "cmd_ConfigCF_ZoomMenos"
        Me.cmd_ConfigCF_ZoomMenos.Size = New System.Drawing.Size(106, 66)
        Me.cmd_ConfigCF_ZoomMenos.TabIndex = 36
        Me.cmd_ConfigCF_ZoomMenos.Text = "-"
        Me.cmd_ConfigCF_ZoomMenos.UseVisualStyleBackColor = False
        '
        'Panel_ConfiguracionCheque
        '
        Me.Panel_ConfiguracionCheque.Controls.Add(Me.PPC_ConfigCheque)
        Me.Panel_ConfiguracionCheque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ConfiguracionCheque.Location = New System.Drawing.Point(3, 78)
        Me.Panel_ConfiguracionCheque.Name = "Panel_ConfiguracionCheque"
        Me.Panel_ConfiguracionCheque.Size = New System.Drawing.Size(1081, 459)
        Me.Panel_ConfiguracionCheque.TabIndex = 2
        '
        'PPC_ConfigCheque
        '
        Me.PPC_ConfigCheque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPC_ConfigCheque.Location = New System.Drawing.Point(0, 0)
        Me.PPC_ConfigCheque.Name = "PPC_ConfigCheque"
        Me.PPC_ConfigCheque.Size = New System.Drawing.Size(1081, 459)
        Me.PPC_ConfigCheque.TabIndex = 3
        '
        'ModuloBancosCajaChica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcMain)
        Me.Name = "ModuloBancosCajaChica"
        Me.Size = New System.Drawing.Size(1095, 579)
        Me.tcMain.ResumeLayout(False)
        Me.VistaGeneral.ResumeLayout(False)
        Me.saldoBancos.ResumeLayout(False)
        Me.TLP_PlanDePagos.ResumeLayout(False)
        CType(Me.DG_Bank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Movimientos.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DG_MovementBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Cheques.ResumeLayout(False)
        Me.TLP_Clientes.ResumeLayout(False)
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.SaldosCajaChica.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DGVCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.MovimientosCajaChica.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DGVMovementPettyCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ConfiguraciondeCheques.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.Panel_ConfiguracionCheque.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tcMain As TabControl
    Private WithEvents VistaGeneral As TabPage
    Private WithEvents gbStudentDetails As GroupBox
    Friend WithEvents saldoBancos As TabPage
    Friend WithEvents Movimientos As TabPage
    Friend WithEvents Cheques As TabPage
    Friend WithEvents TLP_Clientes As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Private WithEvents cmdCrearCliente As Button
    Friend WithEvents TLP_PlanDePagos As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Private WithEvents cmdCuotaClienteMora As Button
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents DG_Bank As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DG_MovementBank As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button3 As Button
    Friend WithEvents ID_BankMovements As DataGridViewTextBoxColumn
    Friend WithEvents Name_Bank As DataGridViewTextBoxColumn
    Friend WithEvents BankMovement_Description As DataGridViewTextBoxColumn
    Friend WithEvents BankMovement_Amount As DataGridViewTextBoxColumn
    Friend WithEvents BankMovement_Type As DataGridViewTextBoxColumn
    Friend WithEvents TipoMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents Movement_date As DataGridViewTextBoxColumn
    Friend WithEvents SaldosCajaChica As TabPage
    Friend WithEvents MovimientosCajaChica As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DGVMovementPettyCash As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Private WithEvents Button4 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DGVCajaChica As DataGridView
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Private WithEvents Button7 As Button
    Friend WithEvents ConfiguraciondeCheques As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Private WithEvents cmd_ConfigCheque_Config As Button
    Private WithEvents cmd_ConfigCF_ZoomMAS As Button
    Private WithEvents cmd_ConfigCF_ZoomMenos As Button
    Friend WithEvents Panel_ConfiguracionCheque As Panel
    Friend WithEvents PPC_ConfigCheque As PrintPreviewControl
    Private WithEvents Button5 As Button
    Private WithEvents Button6 As Button
    Friend WithEvents ID_PettyCash As DataGridViewTextBoxColumn
    Friend WithEvents paidTo As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents inConceptOf As DataGridViewTextBoxColumn
    Friend WithEvents Create_Users As DataGridViewTextBoxColumn
    Friend WithEvents Create_date As DataGridViewTextBoxColumn
    Friend WithEvents MovementType As DataGridViewTextBoxColumn
    Friend WithEvents ID_BankCatalog As DataGridViewTextBoxColumn
    Friend WithEvents Name_BankCatalog As DataGridViewTextBoxColumn
    Friend WithEvents Balance_Bank As DataGridViewTextBoxColumn
    Friend WithEvents Last_Transaction As DataGridViewTextBoxColumn
    Friend WithEvents ID_Customer_FK As DataGridViewTextBoxColumn
    Friend WithEvents Is_Supplier As DataGridViewCheckBoxColumn
    Friend WithEvents Tipo_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Cliente_RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Comercial As DataGridViewTextBoxColumn
    Friend WithEvents Tel_Oficina As DataGridViewTextBoxColumn
    Friend WithEvents CorreoContacto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

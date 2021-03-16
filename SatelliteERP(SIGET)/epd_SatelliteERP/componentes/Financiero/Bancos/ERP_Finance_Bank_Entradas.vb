Public Class ERP_Finance_Bank_Entradas
    Private objDatos As New Generic_SQLServer
    Private dtDepartment As DataTable
    Private _Id_Deparment As Long = 0
    Property ispettyCash As Boolean = False
    Property movementType As Integer = 0
    Property Id_Bank As Long
    Property Name_Deparment As String
    Private actualamount As Double

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub GetData()
        If ispettyCash Then
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 1)
            Label4.Text = "Pagado a:"
            txtPagadoa.Focus()
        Else
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 0)
            label4.Visible = False
            txtpagadoa.Visible = False
        End If

        cbBancos.DataSource = dtDepartment
        cbBancos.ValueMember = "Id_BankCatalog"
        cbBancos.DisplayMember = "Name_BankCatalog"

        For Each row As DataRow In dtDepartment.Rows
            If row.Item("id_BankCatalog") = cbBancos.SelectedValue Then
                actualamount = row.Item("Balance_Bank").ToString
                txtActualAmount.Text = Format(actualamount, "$ #,##0.00")
            End If
        Next row

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Id_Bank = cbBancos.SelectedValue

        If txtDescription.Text <> "" Then
            If txtAmountMovement.Text <> "" Then
                If Id_Bank > 0 Then ' Es modificacion
                    If ispettyCash = False Then
                        If movementType = 2 Then
                            If txtAmountMovement.Text > actualamount Then
                                MessageBox.Show("El monto no puede ser mayor que el saldo actual del banco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, "", txtDescription.Text, txtAmountMovement.Text, False) = "OK" Then
                                    DialogResult = DialogResult.OK
                                    Close()
                                Else
                                    MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        Else
                            If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, "", txtDescription.Text, txtAmountMovement.Text, False) = "OK" Then
                                DialogResult = DialogResult.OK
                                Close()
                            Else
                                MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                    Else
                        If txtPagadoa.Text = "" Then
                            MessageBox.Show("Error, no puede dejar campos en blanco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPagadoa.Focus()
                            Exit Sub
                        End If
                        If movementType = 4 Then
                                If txtAmountMovement.Text > actualamount Then
                                    MessageBox.Show("El monto no puede ser mayor que el saldo actual de caja chica", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, txtPagadoa.Text, txtDescription.Text, txtAmountMovement.Text, True) = "OK" Then
                                        DialogResult = DialogResult.OK
                                        Close()
                                    Else
                                        MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                End If
                            Else
                                If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, txtPagadoa.Text, txtDescription.Text, txtAmountMovement.Text, True) = "OK" Then
                                    DialogResult = DialogResult.OK
                                    Close()
                                Else
                                    MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If

                            End If
                        End If

                        Else
                    MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Error, no puede dejar campos en blanco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAmountMovement.Focus()
            End If
        Else
            MessageBox.Show("Error, no puede dejar campos en blanco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescription.Focus()
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub

    Private Sub txtNameBank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountMovement.KeyPress
        'If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack And e.KeyChar <> "." Then
        '    e.Handled = True
        'End If

        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.keyChar) Then
                e.handled = objValidaciones.Validar_Money(sender, e, txtAmountMovement)
            End If
        End Using
    End Sub

    Private Sub cbBancos_SelectedvalueChanged(sender As Object, e As EventArgs) Handles cbBancos.SelectedValueChanged
        If ispettyCash Then
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 1)
        Else
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 0)
        End If

        For Each row As DataRow In dtDepartment.Rows
            If row.Item("Id_BankCatalog").ToString = cbBancos.SelectedValue.ToString Then

                actualamount = row.Item("Balance_Bank").ToString
                txtActualAmount.Text = Format(actualamount, "$ #,##0.00")
            End If
        Next
    End Sub

    Private Sub ERP_Finance_Bank_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

End Class
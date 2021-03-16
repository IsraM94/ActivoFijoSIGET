Public Class Financiero_DocumentoCheques
    Private objGeneric As New Generic_SQLServer

    Property BankAccount As String
    Property Id_BankCatalog As Long
    Property CheckNumber As String
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.No
        Close()
    End Sub

    Private Sub cmdContinue_Click(sender As Object, e As EventArgs) Handles cmdContinue.Click
        If CB_Bank.SelectedValue <= 0 Then
            MessageBox.Show("Tiene que seleccionar un banco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        If txtCuenta.Text = "" Then
            MessageBox.Show("Tiene que digitar Numero de cuenta", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtNoCheque.Text = "" Then
            MessageBox.Show("Tiene que digitar Numero de cheque", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        CheckNumber = txtNoCheque.Text
        Id_BankCatalog = CB_Bank.SelectedValue
        BankAccount = txtCuenta.Text
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Financiero_DocumentoFiscalDigiteNumero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = objGeneric.Generic_GetBankCatalog(Data_Id_Company)
        CB_Bank.DisplayMember = "Name_BankCatalog"
        CB_Bank.ValueMember = "ID_BankCatalog"
        CB_Bank.DataSource = dt
        txtNoCheque.Enabled = True
        txtCuenta.Enabled = True
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
Public Class ERP_GenericCreditDocument

    Property Id_Company_FK As Long = 0
    Property id_DocumentType As Long = 0
    Private _Id_Rubro As Long = 0
    Private _DT_Clientes As New DataTable
    Private _TypeCustomer As Long = 0
    Property id_CreditDocument As Long = 0
    Property Name_CreditDocument As String = ""
    Property is_invoice = False
    Property objDatos As New Generic_SQLServer

    Private Sub ERP_GenericCreditDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCreditDocument.Text = Name_CreditDocument
        If (IsDBNull(is_invoice)) Then
            is_invoice = False
        End If
        chkInvoice.Checked = is_invoice
        txtCreditDocument.Focus()
    End Sub
    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If txtCreditDocument.Text = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCreditDocument.Focus()
            Exit Sub
        End If
        If id_CreditDocument > 0 Then ' Es modificacion
            If objDatos.ERP_AR_SetCreditDocument(id_CreditDocument, Id_Company_FK, chkInvoice.Checked, txtCreditDocument.Text) = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If objDatos.ERP_AR_InsertCreditDocument(Id_Company_FK, chkInvoice.Checked, txtCreditDocument.Text) = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
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
Public Class Matenimiento_FixedAssetType
    Private objDatos As New Generic_SQLServer

    Property id As Integer
    Property nombreTipoActivo As String
    Property descripcionTipoActivo As String
    Property isTangible As Boolean
    Property vidaUtil As Integer
    Property AccountingAccount As String

    Property OpcionSeleccionada As Funcion
    Enum Funcion
        Agregar
        Actualizar
    End Enum
    Private Sub Matenimiento_FixedAssetType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpcionSeleccionada = Funcion.Actualizar Then
            'cmdDiscount.Enabled = True
            txtNombreTipoActivo.Text = nombreTipoActivo
            txtDescripcion.Text = descripcionTipoActivo
            txtVidaUtil.Text = vidaUtil
            chkIsTangible.Checked = isTangible
            txtAccountingAccount.Text = AccountingAccount
            cmdSave.Text = "Modificar"
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resultado As String = ""

        If txtNombreTipoActivo.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese un nombre", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNombreTipoActivo.Focus()
            Exit Sub
        End If


        If (txtDescripcion.Text.Trim = "") Then
            MessageBox.Show("Ingrese una descripcion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDescripcion.Focus()
            Exit Sub
        End If

        If txtVidaUtil.Text = "" Then
            MessageBox.Show("Ingresa una vida util mayor que 0 años", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtVidaUtil.Clear()
            txtVidaUtil.Focus()
            Exit Sub
        End If
        Try
            If CInt(txtVidaUtil.Text) = 0 Then
                MessageBox.Show("Ingresa una vida util mayor que 0 años", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtVidaUtil.Clear()
                txtVidaUtil.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Ingresa una vida util mayor que 0 años", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtVidaUtil.Clear()
            txtVidaUtil.Focus()
            Exit Sub
        End Try

        If (txtAccountingAccount.Text.Trim = "") Then
            MessageBox.Show("Ingresa una cuenta contable", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtAccountingAccount.Clear()
            txtAccountingAccount.Focus()
            Exit Sub
        End If
        If OpcionSeleccionada = Funcion.Agregar Then
            Dim resp As String = objDatos.ERP_FixedAssets_SP_InsertType(_ID_Company, txtNombreTipoActivo.Text, txtDescripcion.Text, txtVidaUtil.Text, chkIsTangible.Checked, txtAccountingAccount.Text)
            If resp = "OK" Then
                MessageBox.Show("El registro se agregó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al inserto datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


            End If
        ElseIf OpcionSeleccionada = Funcion.Actualizar Then
            Dim resp As String = objDatos.ERP_FixedAssets_SP_UpdateType(id, _ID_Company, txtNombreTipoActivo.Text, txtDescripcion.Text, txtVidaUtil.Text, chkIsTangible.Checked, txtAccountingAccount.Text)
            If resp = "OK" Then
                MessageBox.Show("El registro se actualizo correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
 
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
    Dim _JustNumbers As Boolean = True
    Private Sub txtVidaUtil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVidaUtil.KeyPress

        'Using ObjValidate As New Validaciones
        '    If _JustNumbers Then
        '        e.Handled = ObjValidate.JustNumbers(sender, e)
        '    End If
        'End Using

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
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
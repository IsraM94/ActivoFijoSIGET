Public Class Financiero_DocumentoFiscalDigiteNumero
    Private _NumeroFactura As Decimal
    Private objValidaciones As New Validaciones
    Property UnidadSend As String = ""
    Property NombreProducto As String = ""
    Public Property NumeroFactura() As Decimal
        Get
            Return _NumeroFactura
        End Get
        Set(ByVal value As Decimal)
            _NumeroFactura = value
        End Set
    End Property

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.No
        Close()
    End Sub

    Private Sub cmdContinue_Click(sender As Object, e As EventArgs) Handles cmdContinue.Click

        If txtNoDocumento.Text = "" Then
            MessageBox.Show("El Valor tiene que ser mayor a cero", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not IsNumeric(txtNoDocumento.Text) Then
            MessageBox.Show("El Valor tiene que ser mayor a cero", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not CType(txtNoDocumento.Text, Long) > 0 Then
            MessageBox.Show("El Valor tiene que ser mayor a cero", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        _NumeroFactura = txtNoDocumento.Text
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Financiero_DocumentoFiscalDigiteNumero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUnidad.Text = UnidadSend
        txtNoDocumento.Text = _NumeroFactura
        txtNoDocumento.Enabled = True
        If NombreProducto <> "" Then
            lblProdLa.Visible = True
            lblProducto.Text = NombreProducto
        End If

    End Sub
    Private Sub txtNoDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoDocumento.KeyPress
        If GroupBox1.Text = "Cantidad Productos" Then
            e.Handled = objValidaciones.Validar_Money(sender, e, txtNoDocumento)

            'If Char.IsControl(e.KeyChar) = False Then
            '    If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            '        If Me.txtNoDocumento.Text.Contains(".") Then
            '            If Me.txtNoDocumento.Text.Split(".")(1).Length < 2 Then
            '                If Char.IsDigit(e.KeyChar) = False Then
            '                    e.Handled = True
            '                End If
            '            Else
            '                e.Handled = True
            '            End If
            '        End If
            '    Else
            '        e.Handled = True
            '    End If
            'End If
        Else

            If Char.IsControl(e.KeyChar) = False Then
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                End If
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
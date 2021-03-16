Public Class DigitaPeriodo
    Property Periodo As String
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If CB_Ano.SelectedIndex = -1 Then
            MessageBox.Show("Tiene que seleccionar un A♫o, por favor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CB_Mes.SelectedIndex = -1 Then
            MessageBox.Show("Tiene que seleccionar un mes, por favor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Periodo = CB_Ano.Text & (CB_Mes.SelectedIndex + 1).ToString("00")
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub


    Private Sub Producto_Temp_Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_Ano.Items.Clear()
        For i As Integer = 0 To 10
            CB_Ano.Items.Add(Now.AddYears(-i).ToString("yyyy"))
        Next

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
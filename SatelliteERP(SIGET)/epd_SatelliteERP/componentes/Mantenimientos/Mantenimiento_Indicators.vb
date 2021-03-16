Public Class Mantenimiento_Indicators
    Private objDatos As New Generic_SQLServer
    Private dtIndicator As DataTable
    Property Id_Indicator As Long
    Property Name_Indicator As String
    Property Value_Indicator As Integer
    Private Sub Mantenimiento_Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub
    Private Sub GetData()
        txtNameIndicator.Text = _Name_Indicator
        txtValueIndicator.Text = _Value_Indicator
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resp As String = objDatos.ERP_Config_SetDataIndicators(Id_Indicator, txtValueIndicator.Text)
        If resp = "OK" Then
            DialogResult = DialogResult.OK
            MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Else
            If resp.Split("|")(0) = "ER" Then
                MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()

    End Sub
    Private Sub txtValueIndicator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValueIndicator.KeyPress
        Using objValidaciones As New Validaciones
            If e.KeyChar = "." Then
                e.Handled = True
            Else
                If Not Char.IsControl(e.KeyChar) Then
                    e.Handled = objValidaciones.JustNumbers(sender, e)
                End If
            End If
        End Using
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
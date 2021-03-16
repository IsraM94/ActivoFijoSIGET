Imports System.IO

Public Class Financiero_Procesos_AmortizacionRechazo
    Property Observacion As String = ""

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs)
        Close()
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


    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        If MessageBox.Show("¿Esta seguro de Rechazar la Depreciación?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            If txtRechazar.Text.ToString.Trim = "" Then
                MessageBox.Show("Debe de ingresar una observacion", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Observacion = txtRechazar.Text.ToString
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub
End Class
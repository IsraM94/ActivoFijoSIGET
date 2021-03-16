Public Class Mantenimiento_Generic_Bank
    Private objDatos As New Generic_SQLServer
    Private dtDeparment As DataTable
    Private _Id_Deparment As Long = 0
    Property Id_Bank As Long
    Property Id_Company_FK As Long
    Property Name_Bank As String
    Property Name_Deparment As String

    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetData()
    End Sub
    Private Sub GetData()
        txtNameBank.Text = _Name_Bank
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtNameBank.Text <> "" Then
            If Id_Bank > 0 Then ' Es modificacion
                Dim resp As String = objDatos.SetBank(Id_Bank, Data_Id_Company, txtNameBank.Text)
                If resp = "OK" Then
                    DialogResult = DialogResult.OK
                    MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                Else
                    If resp.Split("|")(0) = "ER" Then
                        MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                End If
            Else
                Dim resp As String = objDatos.InsertBank(Data_Id_Company, txtNameBank.Text)
                If resp = "OK" Then
                    DialogResult = DialogResult.OK
                    MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                Else
                    If resp.Split("|")(0) = "ER" Then
                        MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                End If
            End If
        Else

            MessageBox.Show("Error, no puede dejar campos en blanco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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
Public Class Mantenimiento_Generic_UnitMeasure
    Private objDatos As New Generic_SQLServer
    Property Id_UnitMeasure As Long
    Property Name_UnitMeasure As String
    Property Unit_Conversion As Decimal
    Private Sub Mantenimiento_Generic_UnitMeasure_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetData()
    End Sub
    Private Sub GetData()
        txtNameUnitMeasure.Text = _Name_UnitMeasure
        txtValue.Text = _Unit_Conversion
    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtNameUnitMeasure.Text = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNameUnitMeasure.Focus()
            Exit Sub
        End If

        If Id_UnitMeasure > 0 Then ' Es modificacion
            Dim resp As String = objDatos.SetUnitMeasure(Id_UnitMeasure, Data_Id_Company, txtNameUnitMeasure.Text, txtValue.Text)
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
            Dim resp As String = objDatos.InsertUnitMeasure(Data_Id_Company, txtNameUnitMeasure.Text, txtValue.Text)
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
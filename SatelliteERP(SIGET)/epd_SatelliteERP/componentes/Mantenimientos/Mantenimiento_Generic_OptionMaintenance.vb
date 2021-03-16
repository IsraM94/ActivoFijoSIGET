Public Class Mantenimiento_Generic_OptionMaintenance
    Private objDatos As New Generic_SQLServer
    Private dtCategory As DataTable
    Property Id_Category As Long = 0
    Property Id_OptionMaintenance As Long
    Property Id_Company_FK As Long
    Property Name_OptionMaintenance As String
    Property Name_Deparment As String

    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Data_Id_Company
        dtCategory = objDatos.GetCategoryMaintenance(Data_Id_Company)
        comboListCategory.DataSource = dtCategory
        comboListCategory.DisplayMember = "CategoryMaintenance_Description"
        comboListCategory.ValueMember = "Id_CategoryMaintenance"
        GetData()
    End Sub
    Private Sub GetData()
        REM        Property Id_CollectingAgency_FK As Long
        txtNameOption.Text = Name_OptionMaintenance
        comboListCategory.SelectedValue = Id_Category
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        _Id_Category = comboListCategory.SelectedValue
        If _Id_Category > 0 And txtNameOption.Text <> "" Then

            If Id_OptionMaintenance > 0 Then ' Es modificacion
                Dim resp As String = objDatos.SetOptionMaintenance(Id_OptionMaintenance, _Id_Category, txtNameOption.Text)
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
                Dim resp As String = objDatos.InsertOptionMaintenance(_Id_Category, txtNameOption.Text)
                If resp = "OK" Then
                    DialogResult = DialogResult.OK
                    MessageBox.Show("Registro insertar exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Close()
                Else
                    If resp.Split("|")(0) = "ER" Then
                        MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                End If
            End If
        Else

            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
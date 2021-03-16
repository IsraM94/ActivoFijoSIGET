Public Class ERP_Mantenimiento_WorkPosition

    Private objDatos As New Generic_SQLServer
    Private objSQL As New Operaciones_SQLServer
    Private dtLinea As DataTable
    Private _dtComboUbicacion As DataTable
    Property Id_Company_FK As Long
    Property _isInsert As Boolean
    Property Name_WorkPosition As String
    Property id_Workposition As Long = 0
    Property id_Ubicacion As Long = 0
    Property Is_CustomerService As Boolean = False
    Property Title As String
    Property ID_Schedule_FK As Long = 0
    Property is_boss As Long
    Private dt As DataTable

    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' dt = objDatos.ERP_RRHH_GetSchedule(_ID_Company)

        If id_Workposition <> 0 Then
            txtWorkPosition.Text = Name_WorkPosition
            GroupBox1.Text = Title
            chkIsBoss.Checked = Is_CustomerService
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtWorkPosition.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese la posición de trabajo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtWorkPosition.Focus()
            Exit Sub
        End If

        If IsNumeric(txtWorkPosition.Text.Trim) Then
            MessageBox.Show("La posición de trabajo no debe ser numérica", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtWorkPosition.Focus()
            Exit Sub
        End If
        If IsNumeric(txtWorkPosition.Text.Trim) Then
            MessageBox.Show("Por favor ingrese una posición de trabajo válida", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtWorkPosition.Focus()
            Exit Sub
        End If
        Name_WorkPosition = txtWorkPosition.Text.Trim

        If id_Workposition > 0 Then ' Es modificacion
            Dim resp As String = objDatos.ERP_RRHH_SetWorkPosition(id_Workposition, Data_Id_Company, Name_WorkPosition, chkIsBoss.Checked)

            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then

                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Else
                    '    MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else

            Dim resp As String = objDatos.ERP_RRHH_InsertWorkPosition(Data_Id_Company, Name_WorkPosition, chkIsBoss.Checked)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Else
                    '    MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
#End Region


End Class
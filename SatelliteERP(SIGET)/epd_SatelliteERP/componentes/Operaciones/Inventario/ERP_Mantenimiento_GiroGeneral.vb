Public Class ERP_Mantenimiento_GiroGeneral
    Private objDatos As New Generic_SQLServer
    Private dtCategorias As DataTable
    Property Id_Company_FK As Long
    Property Name_OutletCatalog As String
    Property id_OutletCatalog As Long = 0
    Property Title As String
    Property TypeSystem As String

    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        If id_OutletCatalog <> 0 Then
            txtNameGiroGeneral.Text = Name_OutletCatalog
            GroupBox1.Text = Title
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtNameGiroGeneral.Text = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNameGiroGeneral.Focus()
            Exit Sub
        End If
        If id_OutletCatalog > 0 Then ' Es modificacion
            Dim resp As String = objDatos.ERP_Generic_SP_UpdateCompanyCategory(id_OutletCatalog, Id_Company_FK, txtNameGiroGeneral.Text)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actuazar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
        Else
            Dim resp As String = objDatos.ERP_Generic_SP_InsertCompanyCategory(Id_Company_FK, txtNameGiroGeneral.Text)
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
#End Region
End Class
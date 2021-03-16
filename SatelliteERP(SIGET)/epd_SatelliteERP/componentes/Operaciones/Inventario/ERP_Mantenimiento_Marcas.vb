Public Class ERP_Mantenimiento_Marcas
    Private objDatos As New Generic_SQLServer
    Private dtMarcas As DataTable
    Property Id_Company_FK As Long
    Property Name_Marcas As String
    Property id_Marca As Long = 0
    Property Title As String

    Property is_fixedAssets As Boolean

    Property is_products As Boolean

    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        If id_Marca <> 0 Then
            txtNameMarca.Text = Name_Marcas
            GroupBox1.Text = Title
            If is_fixedAssets = True Then
                chkActivos.Checked = True
            Else
                chkActivos.Checked = False
            End If
            If is_products = True Then
                chkProductos.Checked = True
            Else
                chkProductos.Checked = False
            End If


        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtNameMarca.Text = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNameMarca.Focus()
            Exit Sub
        End If

        If chkActivos.Checked = False And chkProductos.Checked = False Then
            MessageBox.Show("Debe elegir por lo menos una opción para mostrar la marca", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If id_Marca > 0 Then ' Es modificacion
            Dim resp As String = objDatos.SetMarca(Id_Company_FK, id_Marca, txtNameMarca.Text, chkActivos.Checked, chkProductos.Checked)
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
            Dim resp As String = objDatos.InsertMarca(Id_Company_FK, txtNameMarca.Text, chkActivos.Checked, chkProductos.Checked)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    id_Marca = resp.Split("|")(4)
                    If (resp.Split("|")(2) = 1) Then
                        If (MessageBox.Show("La marca ya existe, registrada como Activo Fijo, desea agregarlo tambien como Producto?, ", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = vbOK) Then
                            resp = objDatos.SetMarcaFijoProducto(Id_Company_FK, id_Marca, 0, 1)
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
                        End If

                    ElseIf (resp.Split("|")(3) = 1) Then
                        If (MessageBox.Show("La marca ya existe, registrada como Producto, desea agregarlo tambien como Activo Fijo?, ", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = vbOK) Then
                            resp = objDatos.SetMarcaFijoProducto(Id_Company_FK, id_Marca, 1, 0)
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
                        End If
                    End If

                    'Else
                    '    MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
        'If id_Marca > 0 Then ' Es modificacion
        '    If objDatos.SetMarca(Id_Company_FK, id_Marca, txtNameMarca.Text, chkActivos.Checked, chkProductos.Checked) = "OK" Then
        '        DialogResult = DialogResult.OK
        '        MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Close()
        '    Else
        '        MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'Else
        '    If objDatos.InsertMarca(Id_Company_FK, txtNameMarca.Text, chkActivos.Checked, chkProductos.Checked) = "OK" Then
        '        DialogResult = DialogResult.OK
        '        MessageBox.Show("Registro insertado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Close()
        '    Else
        '        MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'End If
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
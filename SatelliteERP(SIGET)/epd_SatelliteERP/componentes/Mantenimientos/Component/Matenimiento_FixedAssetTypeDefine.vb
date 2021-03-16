Public Class Matenimiento_FixedAssetTypeDefine
    Private objDatos As New Generic_SQLServer
    Private dtFixedAssetTypeFeine As DataTable

    Property ID_FixedAssets_Type_Define As Long
    Property Id_FixedAssetsType As Long
    Property Name_Def As String
    Property isActive As Boolean

    Property OpcionSeleccionada As Funcion
    Enum Funcion
        Agregar
        Actualizar
    End Enum
    Private _DT_ As New DataTable

    Private Sub Matenimiento_FixedAssetTypeDefine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DT_ = objDatos.GetFixedAsset()
        If Not _DT_ Is Nothing Then
            cmb_typeAssetFixed.DataSource = _DT_
            cmb_typeAssetFixed.DisplayMember = "Name_FixedAssetsType"
            cmb_typeAssetFixed.ValueMember = "Id_FixedAssetsType"
            cmb_typeAssetFixed.SelectedIndex = -1
        End If

        If OpcionSeleccionada = Funcion.Actualizar Then
            'cmdDiscount.Enabled = True

            cmb_typeAssetFixed.SelectedValue = _Id_FixedAssetsType
            txtName_Def.Text = _Name_Def
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resultado As String = ""
        If cmb_typeAssetFixed.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione un Tipo Activo Fijo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If (txtName_Def.Text.Trim = "") Then
            MessageBox.Show("Ingrese un nombre", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        _Id_FixedAssetsType = cmb_typeAssetFixed.SelectedValue
        _Name_Def = txtName_Def.Text


        If OpcionSeleccionada = Funcion.Agregar Then
            Dim resp As String = objDatos.InsertFixedAssetTypeDefine(_Id_FixedAssetsType, _Name_Def)
            If resp = "OK" Then
                MessageBox.Show("El registro se inserto correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
        ElseIf OpcionSeleccionada = Funcion.Actualizar Then
            Dim resp As String = objDatos.SetFixedAssetTypeDefine(_ID_FixedAssets_Type_Define, _Id_FixedAssetsType, _Name_Def)
            If resp = "OK" Then
                MessageBox.Show("El registro se actualizo correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
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
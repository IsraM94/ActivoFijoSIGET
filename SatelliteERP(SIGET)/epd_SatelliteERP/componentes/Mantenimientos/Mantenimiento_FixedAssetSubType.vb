Public Class Mantenimiento_FixedAssetSubType
    Private objDatos As New Generic_SQLServer
    Private obj As New Financiero_SQLServer
    Private dtFixedAssets As DataTable
    Property _Id_FixedAssetType As Long = 0
    Property Id_FixedAssetSubType As Long = 0
    Property FixedAssetType As String
    Property Name_FixedAssetSubType As String
    Property Description_FixedAssetSubType As String
    Property Is_Tangible As Boolean



    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtFixedAssets = obj.GetFixedAssetsType(Data_Id_Company)
        comboListCollectingFixedAssetsType.DataSource = dtFixedAssets
        comboListCollectingFixedAssetsType.DisplayMember = "Name_FixedAssetsType"
        comboListCollectingFixedAssetsType.ValueMember = "Id_FixedAssetsType"
        If Id_FixedAssetSubType > 0 Then
            GetData()
        End If

    End Sub
    Private Sub GetData()
        REM        Property Id_CollectingAgency_FK As Long

        txtSubTypeName.Text = Name_FixedAssetSubType
        txtDescripcion.Text = Description_FixedAssetSubType
        cb_IsTangible.Checked = Is_Tangible
        comboListCollectingFixedAssetsType.Text = FixedAssetType
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        _Id_FixedAssetType = comboListCollectingFixedAssetsType.SelectedValue

        If comboListCollectingFixedAssetsType.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            comboListCollectingFixedAssetsType.Focus()
            Exit Sub
        End If
        If txtSubTypeName.Text.Trim = "" Then
            MessageBox.Show("No puede dejar campos vacíos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSubTypeName.Focus()
            Exit Sub
        End If
        If Id_FixedAssetSubType > 0 Then ' Es modificacion
            Dim resp As String = obj.ModifyFixedAssetsSubTypes(Data_Id_Company, Id_FixedAssetSubType, _Id_FixedAssetType, txtSubTypeName.Text, txtDescripcion.Text, cb_IsTangible.Checked)
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
            Dim resp As String = obj.CreateFixedAssetsSubTypes(Data_Id_Company, _Id_FixedAssetType, txtSubTypeName.Text, txtDescripcion.Text, cb_IsTangible.Checked)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro ingresado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
#End Region
End Class
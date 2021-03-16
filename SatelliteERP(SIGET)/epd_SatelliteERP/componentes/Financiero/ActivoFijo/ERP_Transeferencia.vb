Imports System.IO
Public Class ERP_Transeferencia
    Private objDatos As New Generic_SQLServer
    Private objSqlHumanResources As New HumanResources_SQLServer
    Private objSql As New Financiero_SQLServer
    Private op As New Operaciones_SQLServer
    Property ID_FixedAssets As Integer
    Property Id_employee As Integer
    Property ActivoFijo As String
    Property fechaIncial As Date
    Private Sub ERP_Transeferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtResponsable.Text = objDatos.Get_ResponsableFixedAssets(ID_FixedAssets)
        txtActivoFijo.Text = ActivoFijo.ToString()
        Dim data As New DataTable
        data = objDatos.GetEmployee(_ID_Company, Id_employee)
        If (data.Rows.Count > 0) Then

            cmbTransferirA.DataSource = data
            cmbTransferirA.DisplayMember = "Contact"
            cmbTransferirA.ValueMember = "Id_employee"
            cmbTransferirA.SelectedIndex = -1

        End If

        Try
            Dim dt As New DataTable
            Using obj As New Generic_SQLServer
                dt = obj.SP_ERP_Inventory_GetLocationPrimary()
            End Using
            cmb_UbicaconPrimaria.DataSource = dt
            cmb_UbicaconPrimaria.ValueMember = "ID_Location"
            cmb_UbicaconPrimaria.DisplayMember = "NameLocation"
            cmb_UbicaconPrimaria.SelectedIndex = -1
        Catch ex As Exception

        End Try

        updateMotivo()

        llenarFLW()
    End Sub


    Private Function updateMotivo()
        cmbMotivoTransferencia.DataSource = op.ERP_SP_Inventory_GetReason()
        cmbMotivoTransferencia.DisplayMember = "name_reason"
        cmbMotivoTransferencia.ValueMember = "id_reason"
        cmbMotivoTransferencia.SelectedIndex = -1
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Dim mPic As PictureBox
    Function llenarFLW()
        FLP_Imagenes.Controls.Clear()
        For Each row As DataRow In objSql.ERP_FixedAssets_Masterimage_Select(ID_FixedAssets).Rows

            Dim val As Byte() = (row("Image"))
            'pbImage.Image = Bytes2Image(val)

            Dim mpnl As New Panel
            mpnl.Width = 150
            mpnl.Height = 190

            mPic = New PictureBox
            mPic.Image = Bytes2Image(val)
            mPic.Name = (row("ID_MasterImage"))
            mPic.Width = 150
            mPic.Height = 150
            mPic.BorderStyle = BorderStyle.FixedSingle
            mPic.SizeMode = PictureBoxSizeMode.Zoom

            Dim ml As New Label
            ml.AutoSize = True
            ml.Width = 150
            ml.Height = 40
            ml.BorderStyle = BorderStyle.FixedSingle
            ml.Text = (row("ID_MasterImage"))
            ml.Location = New Point(0, mPic.Height)

            mpnl.Controls.Add(mPic)

            FLP_Imagenes.Controls.Add(mpnl)
        Next row
    End Function

    Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Using objAdd As New ERP_Reason
            If objAdd.ShowDialog() = DialogResult.OK Then
                updateMotivo()
            End If
        End Using
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click

        If cmbTransferirA.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione a quien se va transferir", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbTransferirA.Focus()
            Exit Sub
        End If

        Try
            If IsNothing(cmb_UbicaconPrimaria.SelectedValue) Or cmb_UbicaconPrimaria.SelectedValue.ToString.Trim = "" Or cmb_UbicaconPrimaria.SelectedValue.ToString.Trim = "0" Or cmb_UbicaconPrimaria.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una ubicación Primaria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cmb_UbicaconPrimaria.Focus()
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar una ubicación Primaria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_UbicaconPrimaria.Focus()
            Exit Sub
        End Try
        Try
            If IsNothing(CB_Location.SelectedValue) Or CB_Location.SelectedValue.ToString.Trim = "" Or CB_Location.SelectedValue.ToString.Trim = "0" Or cmb_UbicaconPrimaria.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una ubicación Secundaria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                CB_Location.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar una ubicación Secundaria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            CB_Location.Focus()
            Exit Sub
        End Try

        If cmbMotivoTransferencia.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el motivo de transferir", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)

            cmbMotivoTransferencia.Focus()
            Exit Sub
        End If


        If txtDescripcionTransferecian.Text.ToString.Trim = "" Then
            MessageBox.Show("Ingrese una descripción de la transferencia", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtDescripcionTransferecian.Focus()
            Exit Sub
        End If

        If Not MessageBox.Show("Desea Transferir el activo Fijo?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Exit Sub
        End If

        Dim res As Integer = objSql.ERP_InventoryTrasnsersFixedAsset(Id_employee, fechaIncial, cmbTransferirA.SelectedValue, cmbMotivoTransferencia.SelectedValue, ID_FixedAssets, txtDescripcionTransferecian.Text, False, cmb_UbicaconPrimaria.SelectedValue, CB_Location.SelectedValue)
        If res = 1 Then
            MessageBox.Show("Activo Fijo en proceso de asignación de " & txtResponsable.Text & "A: " & cmbTransferirA.Text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al transferir el activo fijo de " & txtResponsable.Text & " A: " & cmbTransferirA.Text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private abierto As Integer = 1
    Private abierto2 As Integer = 1

    Private Sub cmbTransferirA_DropDown(sender As Object, e As EventArgs) Handles cmbTransferirA.DropDown
        abierto = 0
    End Sub

    Private Sub cmbTransferirA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTransferirA.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbTransferirA_DropDownClosed(sender As Object, e As EventArgs) Handles cmbTransferirA.DropDownClosed
        abierto = 1
    End Sub

    Private Sub cmbMotivoTransferencia_DropDown(sender As Object, e As EventArgs) Handles cmbMotivoTransferencia.DropDown
        abierto2 = 0
    End Sub

    Private Sub cmbMotivoTransferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMotivoTransferencia.KeyPress
        If (abierto2 = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbMotivoTransferencia_DropDownClosed(sender As Object, e As EventArgs) Handles cmbMotivoTransferencia.DropDownClosed
        abierto2 = 1
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

    Private Sub cmb_UbicaconPrimaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_UbicaconPrimaria.SelectedIndexChanged
        Try
            CB_Location.SelectedIndex = -1
            CB_Location.Items.Clear()

        Catch ex As Exception

        End Try

        If (cmb_UbicaconPrimaria.SelectedIndex >= 0) Then
            Try
                Dim _dtLocation As New DataTable
                _dtLocation = objSqlHumanResources.GetLocationByPrimary(Data_Id_Company, cmb_UbicaconPrimaria.SelectedValue)
                CB_Location.DataSource = _dtLocation
                CB_Location.DisplayMember = "Name_Location"
                CB_Location.ValueMember = "Id_Location"
                CB_Location.SelectedIndex = -1
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
End Class
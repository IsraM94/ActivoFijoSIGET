Imports System.IO
Public Class ERP_ConfirmTransfer
    Property idAntiguoDueno As Integer
    Property idNuevoDueno As Integer
    Property idMotivoTrans As Integer
    Property ID_FixedAssets As Integer
    Property Aprobacion As Boolean = False
    Property id_trans As Integer
    Property descripcionTrans As String
    Property activoFijo As String
    Property IdLocationPrimary As Integer
    Property IdLocationSecundary As Integer
    Property Autorizacion As Boolean = False
    Private objDatos As New Generic_SQLServer
    Private objSql As New Financiero_SQLServer
    Private objSqlHumanResources As New HumanResources_SQLServer
    Private op As New Operaciones_SQLServer
    Private GetEmployees As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub ERP_ConfirmTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GetEmployees = objDatos.GetEmployee(_ID_Company)

        cmbResponsableAnterior.DataSource = objDatos.GetEmployee(_ID_Company)
        cmbResponsableAnterior.DisplayMember = "Contact"
        cmbResponsableAnterior.ValueMember = "Id_employee"
        cmbResponsableAnterior.SelectedIndex = -1
        cmbResponsableAnterior.SelectedValue = idAntiguoDueno

        cmbNuevoResponsable.DataSource = objDatos.GetEmployee(_ID_Company)
        cmbNuevoResponsable.DisplayMember = "Contact"
        cmbNuevoResponsable.ValueMember = "Id_employee"
        cmbNuevoResponsable.SelectedIndex = -1
        cmbNuevoResponsable.SelectedValue = idNuevoDueno



        Try
            Dim dt As New DataTable
            Using obj As New Generic_SQLServer
                dt = obj.SP_ERP_Inventory_GetLocationPrimary()
            End Using
            cmb_UbicaconPrimaria.DataSource = dt
            cmb_UbicaconPrimaria.ValueMember = "ID_Location"
            cmb_UbicaconPrimaria.DisplayMember = "NameLocation"
            cmb_UbicaconPrimaria.SelectedValue = IdLocationPrimary
        Catch ex As Exception

        End Try

        Try
            Dim _dtLocation As New DataTable
            _dtLocation = objSqlHumanResources.GetLocationByPrimary(Data_Id_Company, IdLocationPrimary)
            CB_Location.DataSource = _dtLocation
            CB_Location.DisplayMember = "Name_Location"
            CB_Location.ValueMember = "Id_Location"
            CB_Location.SelectedValue = IdLocationSecundary
        Catch ex As Exception

        End Try

        updateMotivo()
        cmbMotivoTransferencia.SelectedValue = idMotivoTrans

        txtDescripcionTransferecian.Text = descripcionTrans
        txtActivoFijo.Text = activoFijo.ToString()
        'MessageBox.Show(id_trans)

        llenarFLW()

        If Aprobacion Then
            txtDescripcionTransferecian.Enabled = False
            LinkLabel1.Enabled = False
        End If

        If Autorizacion Then
            btnConfirmarTrasferencia.Text = "Autorizar Transferencia"
            btnDenegarTrasferencia.Text = "Denegar Transferencia"
        End If



    End Sub

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
    Dim mPic As PictureBox
    Sub llenarFLW()
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


        Next
    End Sub

    Private Function updateMotivo()
        cmbMotivoTransferencia.DataSource = op.ERP_SP_Inventory_GetReason()
        cmbMotivoTransferencia.DisplayMember = "name_reason"
        cmbMotivoTransferencia.ValueMember = "id_reason"
        cmbMotivoTransferencia.SelectedIndex = -1
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Using objAdd As New ERP_Reason
            If objAdd.ShowDialog() = DialogResult.OK Then
                updateMotivo()
            End If
        End Using
    End Sub

    Private Sub btnConfirmarTrasferencia_Click(sender As Object, e As EventArgs) Handles btnConfirmarTrasferencia.Click
        If Autorizacion Then
            If MessageBox.Show("Esta seguro de Autorizar la Transferencia?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim Res As Integer = objSql.ERP_SetInventoryTrasnfer(id_trans, cmbNuevoResponsable.SelectedValue, ID_FixedAssets, cmbResponsableAnterior.SelectedValue, txtDescripcionTransferecian.Text, 3, cmb_UbicaconPrimaria.SelectedValue, CB_Location.SelectedValue)
                If Res = 1 Then
                    MessageBox.Show("Autorizacion realizada correctamente. Activo Fijo asignado DE: " & cmbResponsableAnterior.Text & vbCrLf & "A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al AUtorizar el movimiento del activo fijo de " & cmbResponsableAnterior.Text & vbCrLf & " A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If MessageBox.Show("Esta seguro de realizar la Transferencia?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim Res As Integer = objSql.ERP_SetInventoryTrasnfer(id_trans, cmbNuevoResponsable.SelectedValue, ID_FixedAssets, cmbResponsableAnterior.SelectedValue, txtDescripcionTransferecian.Text, 5, cmb_UbicaconPrimaria.SelectedValue, CB_Location.SelectedValue)
                If Res = 1 Then
                    MessageBox.Show("Activo Fijo transferido DE: " & cmbResponsableAnterior.Text & vbCrLf & "A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    REM Generacion de reporte
                    Dim ds As New DataSet
                    Using objSQL As New Financiero_SQLServer
                        ds = objSQL.ERP_GetActivoInventoryTrasnferReport(ID_FixedAssets, id_trans, 0)
                    End Using
                    MessageBox.Show("Favor Guardar El Formato de Movimento de Activo Fijo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If (Not ds Is Nothing) Then
                        If (ds.Tables.Count > 0) Then
                            If (ds.Tables(0).Rows.Count > 0) Then
                                Dim dt As New DataTable
                                dt = ds.Tables(0)
                                Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_TransferenciaActivoFijo.rdlc")
                                    objPartidaContable.ShowDialog()
                                End Using
                            End If
                        End If
                    End If


                Else
                    MessageBox.Show("Error al transferir el activo fijo de " & cmbResponsableAnterior.Text & vbCrLf & " A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private abierto As Integer = 1
    Private Sub cmbNuevoResponsable_DropDown(sender As Object, e As EventArgs) Handles cmbNuevoResponsable.DropDown
        abierto = 0
    End Sub

    Private Sub cmbNuevoResponsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbNuevoResponsable.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbNuevoResponsable_DropDownClosed(sender As Object, e As EventArgs) Handles cmbNuevoResponsable.DropDownClosed
        abierto = 1
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

    Private Sub btnDenegarTrasferencia_Click(sender As Object, e As EventArgs) Handles btnDenegarTrasferencia.Click
        If Autorizacion Then
            If MessageBox.Show("Esta seguro de Denegar la Autorización?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim res As Integer = objSql.ERP_SetInventoryTrasnfer(id_trans, cmbNuevoResponsable.SelectedValue, ID_FixedAssets, cmbResponsableAnterior.SelectedValue, txtDescripcionTransferecian.Text, 4, 0)
                If res = 1 Then
                    MessageBox.Show("Denegación de Autorización de activo de: " & cmbResponsableAnterior.Text & vbCrLf & "A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al denegar la autorización fijo de " & cmbResponsableAnterior.Text & vbCrLf & " A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If MessageBox.Show("Esta seguro de Denegar la Transferencia?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim res As Integer = objSql.ERP_SetInventoryTrasnfer(id_trans, cmbNuevoResponsable.SelectedValue, ID_FixedAssets, cmbResponsableAnterior.SelectedValue, txtDescripcionTransferecian.Text, 6, 0)
                If res = 1 Then
                    MessageBox.Show("Denegación de Transferencia de activo de: " & cmbResponsableAnterior.Text & vbCrLf & "A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al denegar el activo fijo de " & cmbResponsableAnterior.Text & vbCrLf & " A: " & cmbNuevoResponsable.Text, "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
#End Region

End Class
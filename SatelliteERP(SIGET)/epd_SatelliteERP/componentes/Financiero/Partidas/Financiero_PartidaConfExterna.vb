Public Class Financiero_PartidaConfExterna
    Property ID_AccountingItem As Long = 1
    Private _ID_AccountingCatalog As Long = 0
    Private _ID_ClassificationItemType As Long = 0
    Private _DT_DgvDetails As New DataTable
    Private _DT_DgvDatainsert As New DataTable

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If cbListAccount.SelectedIndex <> -1 Then
            Using objCdC As New Financiero_PartidaConfExternaDef
                objCdC.StartPosition = FormStartPosition.CenterParent
                objCdC.DT_DataSQL = _DT_DgvDetails
                'objCdC.DT_DataInsert = _DT_DgvDatainsert
                objCdC.ID_AccountingItemAdd = ID_AccountingItem
                objCdC.ID_AccountingCatalog = cbListAccount.SelectedValue
                objCdC.AccountingCatalog = cbListAccount.Text
                objCdC.DT_DataInsert = _DT_DgvDatainsert
                objCdC.ShowDialog()
                _DT_DgvDatainsert = objCdC.DT_DataInsert
                dgvDetails.DataSource = objCdC.DT_DataSQL
            End Using
        Else
            MessageBox.Show("Por favor seleccion una cuenta contable", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FormPartida1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillInfo()
        FillCBType()
        FilltypeAccounting()
        FillDgv()
    End Sub


    Private Sub FillInfo()
        Dim DT_InfoGeneral As New DataTable
        Try
            Using objSql As New Generic_SQLServer
                REM DT_InfoGeneral = objSql.GetModulesAccountingItem(Data_Id_Company, ID_AccountingItem)
            End Using
            txtPartida_NoPartida.Text = DT_InfoGeneral.Rows(0).Item("Id_ModulesAccountingitem")
            txtConcept.Text = DT_InfoGeneral.Rows(0).Item("Description")
        Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub

    Private Sub FillCBType()
        Dim DT_InfoType As New DataTable
        Try
            Using objSql As New Financiero_SQLServer
                REM Este procedimiento almacenado ya existia previamente
                REM  DT_InfoType = objSql.GetFinanceClassificationItemType(Data_Id_Company)
            End Using
            CB_TypeItem.DataSource = DT_InfoType
            CB_TypeItem.DisplayMember = "Name_ClassificationItemType"
            CB_TypeItem.ValueMember = "Id_ClassificationItemType"
            CB_TypeItem.SelectedValue = "Id_ClassificationItemType_Fk"
        Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub


    Private Sub FilltypeAccounting()
        Dim DT_InfoType As New DataTable
        Try
            Using objSql As New Generic_SQLServer
                REM Este procedimiento almacenado ya existia previamente
                REM DT_InfoType = objSql.GetAccountingCatalogIsDetails(Data_Id_Company)
            End Using
            cbListAccount.DataSource = DT_InfoType
            cbListAccount.DisplayMember = "NombreCuentaContable"
            cbListAccount.ValueMember = "Id_Account"
            cbListAccount.SelectedIndex = -1
        Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
    End Sub

    Private Sub FillDgv()

        Try
            Using objsql As New Generic_SQLServer
                REM _DT_DgvDetails = objsql.GetModulesAccountingItemDetail(Data_Id_Company, ID_AccountingItem)
            End Using
            dgvDetails.DataSource = _DT_DgvDetails

        Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
        _DT_DgvDatainsert = _DT_DgvDetails.Clone
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim resultado As String = Nothing
        Try
            Using objSql As New Generic_SQLServer
                For Each row As DataRow In _DT_DgvDatainsert.Rows
                    If row IsNot Nothing Then
                        REM    resultado = objSql.InsertModelAccountingCatalogDetail(row.Item(1), row.Item(2), row.Item(3), row.Item(4), row.Item(5), row.Item(6), row.Item(7))
                    End If
                Next row
            End Using
            If resultado = "OK" Then
                MessageBox.Show("La información se almacenó correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As ArgumentException
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        Catch ex As Exception
            Using objLog As New ProcessGeneral
                objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            End Using
        End Try
        FillDgv()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim Id_Row As New Long
        Dim Resp As New DialogResult
        Dim resultado As String = Nothing
        If dgvDetails.CurrentRow IsNot Nothing Then
            Try
                Resp = MessageBox.Show("Desea eliminar el Registro Seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Resp = System.Windows.Forms.DialogResult.Yes Then
                    Id_Row = dgvDetails.CurrentRow.Cells(0).Value
                    If Id_Row = 0 Then
                        dgvDetails.Rows.Remove(dgvDetails.CurrentRow)
                        resultado = "OK"
                    Else
                        Using objsql As New Generic_SQLServer
                            REM      resultado = objsql.DelModelAccountintItemDetails(Id_Row, Data_Id_Company)
                        End Using
                    End If
                    If resultado = "OK" Then
                        MessageBox.Show("El registro ha sido eliminado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FillDgv()
                    End If
                End If
            Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            Catch ex As Exception
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End If
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
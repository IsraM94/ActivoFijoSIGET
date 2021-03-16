Public Class Financiero_PartidaConfExternaDef

    Private _Concept As String = Nothing
    Private _ID_CostCenter As Long = 0
    Private _Debit As Boolean = False
    Private _Credit As Boolean = False
    REM
    Property DT_DataSQL As New DataTable
    Property ID_AccountingItemAdd As Long
    Property ID_AccountingCatalog As Long = 0
    Property DT_DataInsert As New DataTable
    Private _CostCenter As String = Nothing
    Property AccountingCatalog As String = Nothing

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub cmdAcept_Click(sender As Object, e As EventArgs) Handles cmdAcept.Click
        ' validaciones: faltan algunas de textbox, solo tiene las basicas
        If CB_CC.SelectedIndex <> -1 Then
            If txtConcept.Text.Trim <> "" Then
                If rbDebe.Checked = True Or rbHaber.Checked = True Then
                    _Concept = txtConcept.Text.Trim
                    _ID_CostCenter = CB_CC.SelectedValue
                    _CostCenter = CB_CC.Text
                    If rbDebe.Checked = True Then
                        _Debit = True
                    ElseIf rbHaber.Checked = True Then
                        _Credit = True
                    End If
                    DT_DataSQL.Rows.Add(0, ID_AccountingItemAdd, _Concept, AccountingCatalog, _CostCenter, _Debit, _Credit, Data_Id_Company)
                    DT_DataInsert.Rows.Add(0, ID_AccountingItemAdd, _Concept, ID_AccountingCatalog, _ID_CostCenter, _Debit, _Credit, Data_Id_Company)
                    Me.DialogResult = DialogResult.OK
                    Close()
                Else
                    MessageBox.Show("Por favor Seleccione un tipo: debe o haber", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Por favor Ingrese el concepto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor seleccion un centro de costo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FormPartida2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCBCC()
    End Sub

    Private Sub FillCBCC()
        Dim DT_CC As New DataTable
        Try
            Using objsql As New Generic_SQLServer
                REM   DT_CC = objsql.GetCostCenter(Data_Id_Company)
            End Using
            CB_CC.DataSource = DT_CC
            CB_CC.DisplayMember = "Name_CostCenter"
            CB_CC.ValueMember = "Id_CostCenter"
            CB_CC.SelectedIndex = -1
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
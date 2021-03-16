Public Class Financiero_CrearPartidaContablesMontos
    Property Amount As Decimal = 0.0
    Property IsDebit As Boolean = True
    Property Concept As String
    Property IsDeductible As Boolean = False
    Property ID_CostCenter As Long = 0
    Dim objSql As New Generic_SQLServer

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub
    Private Sub cmdAcept_Click(sender As Object, e As EventArgs) Handles cmdAcept.Click
        ' validaciones
        If CB_CentroCosto.SelectedIndex = -1 Then
            MessageBox.Show("Tiene que seleccionar un departamento de centro de costos, por favor.", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtConcept.Text.Trim.Length = 0 Then
            MessageBox.Show("Tiene que digitar un concepto, por favor.", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConcept.Focus()
            Exit Sub
        End If

        Try
            _Amount = txtMonto.Text
        Catch ex As Exception
            _Amount = 0
        End Try

        If _Amount <= 0 Then
            MessageBox.Show("El Monto no puede ser cero, por favor.", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMonto.Focus()
            Exit Sub
        End If
        _Concept = txtConcept.Text
        _IsDebit = rbDebe.Checked
        IsDeductible = CB_IsDeductible.Checked
        ID_CostCenter = CB_CentroCosto.SelectedValue
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub
    Private Sub Financiero_CrearPartidaContablesMontos_Load(sender As Object, e As EventArgs) Handles Me.Load
        rbDebe.Checked = _IsDebit
        rbHaber.Checked = Not _IsDebit
        Dim dt As DataTable
        dt = objSql.GetCostCenter(Data_Id_Company)
        CB_CentroCosto.DataSource = dt
        CB_CentroCosto.DisplayMember = "Name_CostCenter"
        CB_CentroCosto.ValueMember = "ID_CostCenter"
        CB_CentroCosto.SelectedIndex = -1

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
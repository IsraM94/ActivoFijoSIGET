Public Class ERP_CreditLine

#Region "Properties"

    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_CreditLine As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property value As String = ""
    Property concept As String = ""
    Property Vigency As String = ""
    Property ID_CreditLine As Long = 0
    Property Id_Customer As Long = 0
    Property ID_TypeCreditLine As Long = 0
    Property Cliente As String = ""
    Property IdCliente As Long = 0
    Property DUI As String = ""
    Property Telefono As String = ""
    Property Email As String = ""
    Property DateStartLine As DateTime = Nothing
    Property DateEndLine As DateTime = Nothing
    Property DescriptionBackwardness As String = ""
    Property DescriptionInactive As String = ""
    Property IS_Seleccion As Boolean = False
    Property LineaCreditoRetorno As Long = 0
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion

#End Region

    Private Sub ERP_CreditLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RbActivas.Checked = True
        lblNameClient.Text = _Cliente
        lblNDocument.Text = _DUI
        lblEmail.Text = _Email
        lblTelefono.Text = _Telefono
        If IS_Seleccion Then
            RbActivas.Enabled = False
            RbAtrasadas.Enabled = False
            RbInactivas.Enabled = False
            cmdSelecionar.Visible = True
            CMSCreditLine.Visible = False
        End If
        fillDGV()
    End Sub

#Region "Fill dgv"

    Private Sub fillDGV()
        Using objDatos As New Generic_SQLServer
            Try
                _DT_CreditLine = objDatos.GetCreditLine(Data_Id_Company, Id_Customer, _Activas, _Inactivas, _Atrasadas)
                If _DT_CreditLine IsNot Nothing Then
                    dgvCreditLine.AutoGenerateColumns = False
                    dgvCreditLine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    dgvCreditLine.Font = New Font("Segoe UI", 11)
                    dgvCreditLine.RowHeadersVisible=false
                    dgvCreditLine.Columns(0).Width = 100
                    dgvCreditLine.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvCreditLine.Columns(1).Width = 500
                    dgvCreditLine.Columns(2).Width = 200
                    dgvCreditLine.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    dgvCreditLine.Columns(3).Width = 120
                    dgvCreditLine.Columns(4).Width = 120
                    dgvCreditLine.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    dgvCreditLine.Columns(5).Width = 120
                    dgvCreditLine.Columns(6).Width = 120
                    dgvCreditLine.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    dgvCreditLine.Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvCreditLine.Columns("Valor").DefaultCellStyle.Format = "C2"

                    dgvCreditLine.Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvCreditLine.Columns("Saldo").DefaultCellStyle.Format = "C2"

                    dgvCreditLine.ReadOnly = True
                    dgvCreditLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvCreditLine.MultiSelect = False

                    dgvCreditLine.AllowUserToResizeColumns = False
                    dgvCreditLine.AllowUserToAddRows = False
                    dgvCreditLine.AllowUserToDeleteRows = False
                    dgvCreditLine.DataSource = _DT_CreditLine
                    If dgvCreditLine.RowCount < 1 Then
                        ActualizarToolStripMenuItem.Enabled = False
                        EliminarToolStripMenuItem.Enabled = False
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

        End Using
    End Sub


#End Region

#Region "Radio Buton"

    Private Sub RadioActivas_CheckedChanged(sender As Object, e As EventArgs) Handles RbActivas.CheckedChanged
        If RbActivas.Checked = True Then
            _Activas = True
            _Inactivas = False
            _Atrasadas = False
            fillDGV()
        End If
    End Sub

    Private Sub RadioInactivas_CheckedChanged(sender As Object, e As EventArgs) Handles RbInactivas.CheckedChanged
        If RbInactivas.Checked = True Then
            _Activas = False
            _Inactivas = True
            _Atrasadas = False
            fillDGV()
        End If
    End Sub

    Private Sub RadioAtrasadas_CheckedChanged(sender As Object, e As EventArgs) Handles RbAtrasadas.CheckedChanged
        If RbAtrasadas.Checked = True Then
            _Activas = False
            _Inactivas = False
            _Atrasadas = True
            fillDGV()
        End If
    End Sub

#End Region

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Using objCreate As New ERP_PayCreditLine
            objCreate.OpcionSeleccionada = ERP_PayCreditLine.funcion.Agregar
            objCreate.Id_Customer = Id_Customer
            If objCreate.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                fillDGV()
				If dgvCreditLine.RowCount < 1 Then
					ActualizarToolStripMenuItem.Enabled = False
					EliminarToolStripMenuItem.Enabled = False
				Else
					ActualizarToolStripMenuItem.Enabled = True
					EliminarToolStripMenuItem.Enabled = True
				End If
            End If
        End Using
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Using objCreate As New ERP_PayCreditLine
            Try
                objCreate.OpcionSeleccionada = ERP_PayCreditLine.funcion.Actualizar
                objCreate.ID_CreditLine = dgvCreditLine.CurrentRow.Cells("Id_LineaDeCredito").Value
                objCreate.Id_Customer = Id_Customer
                objCreate.Valor = dgvCreditLine.CurrentRow.Cells("Valor").Value
                Try
                    objCreate.Saldo = dgvCreditLine.CurrentRow.Cells("Saldo").Value
                Catch ex As Exception
                    objCreate.Saldo = 0.00
                End Try
                objCreate.concepto = dgvCreditLine.CurrentRow.Cells("Concepto").Value
                objCreate.ID_TypeCreditLine = dgvCreditLine.CurrentRow.Cells("ID_TypeCreditLine_FK").Value
                objCreate.DateStart = dgvCreditLine.CurrentRow.Cells("DateStart").Value
                objCreate.DateEnd = dgvCreditLine.CurrentRow.Cells("DateEnd").Value
                objCreate.Vigencia = dgvCreditLine.CurrentRow.Cells("Vigencia").Value
				objCreate.ActiveLine = dgvCreditLine.CurrentRow.Cells("Inactive").Value
				objCreate.DaysInvoiceExpiration = dgvCreditLine.CurrentRow.Cells("DaysInvoiceExpiration").Value
			Catch ex As ArgumentException
                Using objLog As New ProcessGeneral
                    objLog.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
            If objCreate.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                fillDGV()
            End If
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Using objDatos As New Generic_SQLServer
            If dgvCreditLine.CurrentRow IsNot Nothing Then
                _ID_CreditLine = dgvCreditLine.CurrentRow.Cells("Id_LineaDeCredito").Value
                Dim value As String = dgvCreditLine.CurrentRow.Cells("Concepto").Value
                If MessageBox.Show("¿Desea eliminar el registro " & value & "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim resultado As String = objDatos.DelCreditLine(_ID_CreditLine)
                    If resultado = "OK" Then
                        MessageBox.Show("El registro se eliminó satisfactoriamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        fillDGV()
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub cmdSelecionar_Click(sender As Object, e As EventArgs) Handles cmdSelecionar.Click
        If dgvCreditLine.CurrentRow IsNot Nothing Then
            LineaCreditoRetorno = dgvCreditLine.CurrentRow.Cells("Id_LineaDeCredito").Value
            DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Tiene que seleccionar un registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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
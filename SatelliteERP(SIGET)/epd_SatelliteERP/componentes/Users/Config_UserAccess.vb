Public Class Config_UserAccess

#Region "Properties"

    Private _Inactivas As Boolean = False
    Private _Activas As Boolean = False
    Private _Atrasadas As Boolean = False
    Private _DT_AccessUsers As DataTable = Nothing
    Private _DT_TypeCreditLine As DataTable = Nothing
    Property _username As String
    Property IS_Seleccion As Boolean = False
    Property LineaCreditoRetorno As Long = 0
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion

#End Region

    Private Sub Config_UserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_ConfigAccess_BuscarUsuario.Focus()
        If (_username <> "") Then
            txt_ConfigAccess_BuscarUsuario.Text = _username
        End If
        fillDGV()
    End Sub

#Region "Fill dgv"

    Private Sub fillDGV()
        Using objDatos As New Generic_SQLServer
            Try
                _DT_AccessUsers = objDatos.ERP_Config_GetUserAccess(txt_ConfigAccess_BuscarUsuario.Text)
                If _DT_AccessUsers IsNot Nothing Then
                    dgvCreditLine.AutoGenerateColumns = False
                    dgvCreditLine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    dgvCreditLine.Font = New Font("Segoe UI", 11)
                    dgvCreditLine.RowHeadersVisible = False
                    dgvCreditLine.Columns(0).Width = 100
                    dgvCreditLine.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvCreditLine.Columns(1).Width = 600
                    dgvCreditLine.Columns(2).Width = 350

                    dgvCreditLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvCreditLine.MultiSelect = False

                    dgvCreditLine.AllowUserToResizeColumns = False
                    dgvCreditLine.AllowUserToAddRows = False
                    dgvCreditLine.AllowUserToDeleteRows = False
                    dgvCreditLine.DataSource = _DT_AccessUsers
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

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using objDatos As New Generic_SQLServer
            Dim resp As String = ""
            Dim active As Boolean
            Try
                For Each row As DataGridViewRow In dgvCreditLine.Rows
                    active = False
                    If row.Cells(3).Value.ToString = Nothing Then
                    Else
                        active = Convert.ToBoolean(Convert.ToInt32(row.Cells(3).Value.ToString))
                    End If

                    resp = objDatos.ERP_Config_SetUserAccess(txt_ConfigAccess_BuscarUsuario.Text, Convert.ToInt64(row.Cells(0).Value.ToString), active)
                Next
                MessageBox.Show("Guardado correctamente", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
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

    Private Sub dgvCreditLine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCreditLine.CellContentClick

    End Sub
#End Region
End Class
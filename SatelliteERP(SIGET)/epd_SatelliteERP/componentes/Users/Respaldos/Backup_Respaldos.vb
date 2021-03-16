Imports System.Data.SqlClient

Public Class Backup_Respaldos
    Private objDatos As New Generic_SQLServer
    Private dtDepartament As DataTable
    Property Id_Departament As Long
    Property Name_Departament As String
    Private Sub Mantenimiento_Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub
    Private Sub GetData()
        cmbserver.Items.Add(objDatos.Server)
        cmbdatabase.Items.Add(objDatos.BaseDeDatos)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        DialogResult = DialogResult.None
        Close()

    End Sub
    Sub blank(ByVal str As String)
        If cmbserver.Text = "" Or cmbdatabase.Text = "" Then
            MsgBox("Server Name & Database Blank Field")
            Exit Sub
        Else
            If str = "backup" Then
                SaveFileDialog1.FileName = cmbdatabase.Text & "_" & Now.ToString("yyyyMMdd_HHmm")
                If Not SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    Exit Sub
                End If
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                    Dim s As String
                    s = SaveFileDialog1.FileName
                    objDatos.query("backup database " & cmbdatabase.Text & " to disk='" & s & "'")
                ElseIf str = "restore" Then
                    OpenFileDialog1.ShowDialog()
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                objDatos.query("RESTORE DATABASE " & cmbdatabase.Text & " FROM disk='" & OpenFileDialog1.FileName & "'")
            End If
        End If
    End Sub

    Private Sub cmbbackup_Click(sender As Object, e As EventArgs) Handles cmbbackup.Click
        blank("backup")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            MessageBox.Show("Proceso finalizado, por favor verifique si archivo se generó correctametne", "SatellitePOS", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
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
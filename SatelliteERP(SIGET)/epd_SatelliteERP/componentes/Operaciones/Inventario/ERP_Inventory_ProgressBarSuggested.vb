Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Public Class ERP_Inventory_ProgressBarSuggested
    Property data As DataGridView
    Property ID_Customer As Integer = 0
    Property Type As Process
    Private _Resp As Integer = 0
    Enum Process
        Generic
        GenerateUser
    End Enum

    Private Sub ERP_Inventory_ProgressBarSuggested_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
		bwProgressUploadFiles.WorkerReportsProgress = True
		bwProgressUploadFiles.WorkerSupportsCancellation = True
		bwProgressUploadFiles.RunWorkerAsync()
	End Sub
	Private Sub bwProgressUploadFiles_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwProgressUploadFiles.DoWork
		Dim TotalEDC As Integer = _data.Rows.Count
		Dim Count As Integer = 0
		Dim Porcentaje As Double = 100 / TotalEDC
		Dim Orden As Long = 0
		Using objsql As New Operaciones_SQLServer
			Orden = objsql.ERP_SP_Inventory_GenerateOrder(ID_Customer)
		End Using

		For Each row As DataGridViewRow In data.Rows
            If Not row Is Nothing Then
				Using ObjSQL As New Operaciones_SQLServer
					Select Case Type
						Case Process.GenerateUser
                            _Resp = ObjSQL.ERP_SP_Inventory_GenerateOrderDetails(Orden, row.Cells("id_Product").Value, row.Cells("Cantidad").Value)
                            Count += 1
							bwProgressUploadFiles.ReportProgress(Count * Porcentaje)
					End Select
				End Using
			End If
        Next row
        lblProgress.Text = Count.ToString + "/" + TotalEDC.ToString
	End Sub

	Private Sub bwProgressUploadFiles_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwProgressUploadFiles.ProgressChanged
		If Not e.ProgressPercentage > 100 Then
			Me.pbSuggest.Value = e.ProgressPercentage.ToString
			lblPorcentaje.Text = e.ProgressPercentage.ToString & "%"
		End If
	End Sub
    Private Sub bwProgressUploadFiles_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwProgressUploadFiles.RunWorkerCompleted
        If _Resp = 0 Then
            MessageBox.Show("Ocurrio un error al generar la orden, por favor contacte a soporte tecnico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            MessageBox.Show("Proceso finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class
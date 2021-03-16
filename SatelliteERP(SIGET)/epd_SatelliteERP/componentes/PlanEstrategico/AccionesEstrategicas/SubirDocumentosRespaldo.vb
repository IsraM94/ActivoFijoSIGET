Public Class SubirDocumentosRespaldo

#Region "Properties"
    Private objsql As New POA_SQLServer
    Property Anio As Integer = 0
    Private RutaArchivo As String = ""
    Private NombreArchivo As String = ""

    Property _Documentos As Boolean = False
    Property _PEI As Boolean = False
    Property _POA As Boolean = False
    Property _MAPA As Boolean = False
    Property _Id_Encabezado As Integer = 0
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region

    Private Sub Config_InsertUserAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _Documentos Then
            txtObservacion.Enabled = False
            txt_Ruta.Enabled = False
            btnArchivos.Enabled = False

            Try
                Dim dt As New DataTable
                Dim dt3 As New DataTable
                Using objDatos As New POA_SQLServer
                    If _PEI Then
                        dt3 = objDatos.ERP_StrategicPlan_GetDocumentRespaldoPEIPOA(_Id_Encabezado, "PEI", 0)
                    End If
                    If _POA Then
                        dt3 = objDatos.ERP_StrategicPlan_GetDocumentRespaldoPEIPOA(_Id_Encabezado, "POA", 0)
                    End If
                    If _MAPA Then
                        dt3 = objDatos.ERP_StrategicPlan_GetDocumentRespaldoPEIPOA(_Id_Encabezado, "MAPA", 0)
                    End If
                End Using

                If dt3.Rows.Count > 0 Then
                    For Each data As DataRow In dt3.Rows
                        txtObservacion.Text = data("Observacion").ToString
                        NombreArchivo = data("NombreArchivo").ToString
                        txt_Ruta.Text = NombreArchivo
                        RutaArchivo = data("RutaArchivo").ToString
                    Next
                Else
                    MessageBox.Show("No hay avance para el Mes seleccionado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
                btnGrabar.Text = "Descargar Archivo"
            Catch ex As Exception
                Using obj As New ProcessGeneral
                    obj.AlmacenarLog(4, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        End If
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If _Documentos Then
            DescargarArchivo()
            Exit Sub
        End If

        If txt_Ruta.Text.ToString.Trim = "" Or txt_Ruta.Text = " " Then
            MessageBox.Show("No puede dejar campos en blanco.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Ruta.Focus()
            Exit Sub
        End If

        If txtObservacion.Text.ToString.Trim = "" Then
            MessageBox.Show("Debe de ingresar una descripción.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtObservacion.Focus()
            Exit Sub
        End If

        Dim dt As String

        If _PEI Then
            dt = objsql.ERP_StrategicPlan_ProcessArchivosPOAPEI(_Id_Encabezado, RutaArchivo, NombreArchivo, txtObservacion.Text.ToString, "PEI", 0)
        End If

        If _POA Then
            dt = objsql.ERP_StrategicPlan_ProcessArchivosPOAPEI(_Id_Encabezado, RutaArchivo, NombreArchivo, txtObservacion.Text.ToString, "POA", Anio)
        End If

        If _MAPA Then
            dt = objsql.ERP_StrategicPlan_ProcessArchivosPOAPEI(_Id_Encabezado, RutaArchivo, NombreArchivo, txtObservacion.Text.ToString, "MAPA", Anio)
        End If

        MessageBox.Show("Información Procesada Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnArchivos.Click
        Dim saveFileDialog1 As OpenFileDialog = New OpenFileDialog()
        saveFileDialog1.Filter = "All files (*.*)|*.*|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Word|*.doc|Excel|*.xls|PDF|*.pdf"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()
        NombreArchivo = saveFileDialog1.SafeFileName
        txt_Ruta.Text = NombreArchivo
        RutaArchivo = saveFileDialog1.FileName
    End Sub

    Private Sub txt_Avance_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DescargarArchivo()
        Try
            If NombreArchivo.ToString.Trim = "" Then
                MessageBox.Show("No hay documentos de ejecución", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Try
                Dim Escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

                Dim dlGuardar As New SaveFileDialog
                dlGuardar.InitialDirectory = Escritorio
                dlGuardar.Filter = "Todos (*.*)|*.*"
                dlGuardar.FilterIndex = 1
                Try
                    dlGuardar.DefaultExt = NombreArchivo.ToString.Split(".")(1).ToString
                Catch ex As Exception

                End Try
                dlGuardar.FileName = Date.Now.Date.ToString("ddMMyyyy").ToString & "_" & NombreArchivo.ToString
                dlGuardar.OverwritePrompt = True
                dlGuardar.Title = "Guardar Documento Respaldo Ejecución"
                If dlGuardar.ShowDialog = DialogResult.OK Then

                    My.Computer.Network.DownloadFile(RutaArchivo.ToString, dlGuardar.FileName)
                    MessageBox.Show("Archivo descargado Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                If (ex.ToString.Contains("ya existe un archivo")) Then
                    MessageBox.Show("Ya existe un archivo con el mismo nombre", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se puede decargar el archivo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Using process As New ProcessGeneral
                    process.AlmacenarLog(5, ex.Message, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Using
            End Try
        Catch ex As Exception

        End Try
    End Sub
End Class
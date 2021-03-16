Public Class MatrizProcesoEjes

#Region "Properties"
    Private objsql As New POA_SQLServer
    Private dtObjetivos As New DataTable
    Private dtEjes As New DataTable
    Property _isInsert As Boolean = True
    Property _name As String = ""

    Property _description As String = ""
    Property _id_Management As Long
    Property _servicio As String = ""
    Property _ideje As Long = 0
    Property _nameeje As String = ""
    Property _CodeAxesFi As String = ""
    Enum funcion
        Actualizar
        Agregar
    End Enum
    Property OpcionSeleccionada As funcion
#End Region


    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        _ideje = DG_BuscarEjes.CurrentRow.Cells("IdE").Value
        _nameeje = DG_BuscarEjes.CurrentRow.Cells("NameEjes").Value
        _CodeAxesFi = DG_BuscarEjes.CurrentRow.Cells("CodeAxesF").Value
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GetEjes(ByVal text As String)
        Using objDatos As New POA_SQLServer
            Try
                dtEjes = objDatos.ERP_StrategicPlan_SearchAxes(text)
                If dtEjes IsNot Nothing Then
                    DG_BuscarEjes.AutoGenerateColumns = False
                    DG_BuscarEjes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    DG_BuscarEjes.Font = New Font("Segoe UI", 11)
                    DG_BuscarEjes.RowHeadersVisible = False
                    DG_BuscarEjes.Columns(0).Width = 75
                    DG_BuscarEjes.Columns(1).Width = 90
                    DG_BuscarEjes.Columns(2).Width = 600

                    DG_BuscarEjes.ReadOnly = True
                    DG_BuscarEjes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DG_BuscarEjes.MultiSelect = False

                    DG_BuscarEjes.AllowUserToResizeColumns = False
                    DG_BuscarEjes.AllowUserToAddRows = False
                    DG_BuscarEjes.AllowUserToDeleteRows = False
                    DG_BuscarEjes.DataSource = dtEjes
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

    Private Sub txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_Buscar.TextChanged
        GetEjes(txt_Buscar.Text)
    End Sub
End Class
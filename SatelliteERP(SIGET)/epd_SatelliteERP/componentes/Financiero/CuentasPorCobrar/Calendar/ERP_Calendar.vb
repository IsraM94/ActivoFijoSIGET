Public Class ERP_Calendar

    Dim lblDayz As Label
    Dim y As Int32 = 0
    Dim x As Int32
    Dim ndayz As Int32
    Dim Dayofweek, CurrentCulture As String
    Dim provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Public Event EventCalendar(ByVal respPago As DialogResult)
    Property OpcionCuenta As TipoCuenta

    Enum TipoCuenta
        Cuenta_Cobrar
        Cuenta_pagar
        Todas_Cuentas
    End Enum

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub ERP_Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case OpcionCuenta
            Case TipoCuenta.Cuenta_Cobrar
                FillAccountsReceivable()
            Case TipoCuenta.Cuenta_pagar
                FillAccountsPayable()
            Case TipoCuenta.Todas_Cuentas
                FillAccountsReceivable()
                FillAccountsPayable()
        End Select

    End Sub

    Private Sub MonthCalendar1_DayClick(sender As Object, e As Pabo.Calendar.DayClickEventArgs) Handles MonthCalendar1.DayClick
        Dim Currentdate As String = MonthCalendar1.SelectedDates.Item(0).ToString
        Using objCalendarDetails As New ERP_CalendarDetalles
            objCalendarDetails.Fecha = Currentdate
            Select Case OpcionCuenta
                Case TipoCuenta.Cuenta_Cobrar
                    objCalendarDetails.DetalleTipo = ERP_CalendarDetalles.Tipoconsulta.Detalles_Cuenta_Cobrar

                    RaiseEvent EventCalendar(objCalendarDetails.ShowDialog())
                Case TipoCuenta.Cuenta_pagar
                    objCalendarDetails.DetalleTipo = ERP_CalendarDetalles.Tipoconsulta.Detalles_Cuenta_Pagar
                    RaiseEvent EventCalendar(objCalendarDetails.ShowDialog())
            End Select
        End Using
    End Sub

    Private Sub FillAccountsReceivable()
        Dim Dt_fechas As New DataTable
        Try
            Using objcobros As New Generic_SQLServer
                Dt_fechas = objcobros.GetQuotasAccountsReceivable(Data_Id_Company)
            End Using
            For Each row As DataRow In Dt_fechas.Rows
                If row IsNot Nothing Then
                    Dim cobro As New Pabo.Calendar.DateItem
                    cobro.Date = CType(row.Item("PaymentDate"), Date)
                    cobro.Text = "Cuentas por cobrar"
                    cobro.TextColor = Color.Black
                    cobro.BackColor1 = Color.Green
                    cobro.Image = ImgLCalendar.Images(0)
                    MonthCalendar1.AddDateInfo(cobro)
                End If
            Next row
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

    Private Sub FillAccountsPayable()
        Dim Dt_fechas As New DataTable
        Try
            Using objcobros As New Generic_SQLServer
                Dt_fechas = objcobros.GetQuotasAccountsPayable(Data_Id_Company)
            End Using
            For Each row As DataRow In Dt_fechas.Rows
                If row IsNot Nothing Then
                    Dim cobro As New Pabo.Calendar.DateItem
                    cobro.Date = CType(row.Item("PaymentDate"), Date)
                    cobro.Text = "Cuentas por Pagar"
                    cobro.TextColor = Color.Black
                    cobro.BackColor1 = Color.OrangeRed
                    cobro.Image = ImgLCalendar.Images(1)
                    MonthCalendar1.AddDateInfo(cobro)
                End If
            Next row
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
Public Class calendar

    Dim lblDayz As Label
    Dim y As Int32 = 0
    Dim x As Int32
    Dim ndayz As Int32
    Dim Dayofweek, CurrentCulture As String
    Dim provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Property OpcionCuenta As TipoCuenta
    Public Property CalendarDimensions As Size
    Public Event EventCalendar(ByVal respPago As DialogResult)

    Enum TipoCuenta
        Cuenta_Cobrar
        Cuenta_pagar
        Todas_Cuentas
    End Enum

    Private Sub MonthCalendar1_DayClick(sender As Object, e As Pabo.Calendar.DayClickEventArgs) Handles MonthCalendar1.DayClick, MonthCalendar2.DayClick, MonthCalendar3.DayClick, MonthCalendar4.DayClick
        Dim currentdate As String = ""

        Try
            If MonthCalendar1.Capture Then
                currentdate = MonthCalendar1.SelectedDates.Item(0).ToString
            Else
                If MonthCalendar2.Capture Then
                    currentdate = MonthCalendar2.SelectedDates.Item(0).ToString
                Else
                    If MonthCalendar3.Capture Then
                        currentdate = MonthCalendar3.SelectedDates.Item(0).ToString
                    Else
                        If MonthCalendar4.Capture Then
                            currentdate = MonthCalendar4.SelectedDates.Item(0).ToString
                        End If
                    End If
                End If
            End If



            Using objCalendarDetails As New ERP_CalendarDetalles
                objCalendarDetails.Fecha = Currentdate
                Select Case OpcionCuenta
                    Case TipoCuenta.Cuenta_Cobrar
                        objCalendarDetails.DetalleTipo = ERP_CalendarDetalles.Tipoconsulta.Detalles_Cuenta_Cobrar
                        Dim RESP As DialogResult = objCalendarDetails.ShowDialog()
                        REM RaiseEvent EventCalendar(RESP)
                        FillAccountsReceivable()
                    Case TipoCuenta.Cuenta_pagar
                        objCalendarDetails.DetalleTipo = ERP_CalendarDetalles.Tipoconsulta.Detalles_Cuenta_Pagar
                        RaiseEvent EventCalendar(objCalendarDetails.ShowDialog())

                        FillAccountsPayable()
                End Select
            End Using
            Select Case OpcionCuenta
                Case TipoCuenta.Cuenta_Cobrar
                    FillAccountsReceivable()
                Case TipoCuenta.Cuenta_pagar
                    FillAccountsPayable()
            End Select
        Catch ex As Exception
            REM validar fechas sin eventos
        End Try
    End Sub
    Dim Dt_FillAccountsReceivable As New DataTable

    Private Sub FillAccountsReceivable()
        If Not Dt_FillAccountsReceivable Is Nothing Then
            For Each row As DataRow In Dt_FillAccountsReceivable.Rows
                Dim pp As Pabo.Calendar.DateItem() = MonthCalendar1.GetDateInfo(CType(row.Item("PaymentDate"), Date))
                For Each xx As Pabo.Calendar.DateItem In pp
                    xx.Text = ""
                    xx.TextColor = Color.Black
                    xx.BackColor1 = Color.FromArgb(212, 212, 212)
                    xx.Image = Nothing
                Next

                Dim x As String = pp.Count
                REM MonthCalendar1.AddDateInfo(cobro)
                REM MonthCalendar2.AddDateInfo(cobro)
                REM MonthCalendar4.AddDateInfo(cobro)
                REM MonthCalendar3.AddDateInfo(cobro)
            Next
        End If

        Dim orangedate As New Date
        Try
            Using objcobros As New Generic_SQLServer
                Dt_FillAccountsReceivable = objcobros.GetQuotasAccountsReceivable(Data_Id_Company)
            End Using
            For Each row As DataRow In Dt_FillAccountsReceivable.Rows
                If row IsNot Nothing Then
                    Dim pp As Pabo.Calendar.DateItem() = MonthCalendar1.GetDateInfo(CType(row.Item("PaymentDate"), Date))
                    If pp.Count <> 0 Then
                        For Each xx As Pabo.Calendar.DateItem In pp
                            xx.Text = "Cuentas por cobrar"
                            xx.TextColor = Color.Black
                            xx.BackColor1 = Color.LightSlateGray
                            xx.Image = ImgLCalendar.Images(1)
                            orangedate = DateAdd(DateInterval.Day, 4, Date.Today)
                            If row.Item("PaymentDate") < Date.Today Then
                                xx.TextColor = Color.Black
                                xx.BackColor1 = Color.Red
                            Else
                                If row.Item("PaymentDate") < orangedate Then
                                    xx.TextColor = Color.Black
                                    xx.BackColor1 = Color.Orange
                                Else
                                    xx.TextColor = Color.White
                                    xx.BackColor1 = Color.Green
                                End If
                            End If
                        Next
                    Else
                        Dim cobro As New Pabo.Calendar.DateItem
                        cobro.Date = CType(row.Item("PaymentDate"), Date)
                        cobro.Text = "Cuentas por cobrar"
                        orangedate = DateAdd(DateInterval.Day, 4, Date.Today)
                        If row.Item("PaymentDate") < Date.Today Then
                            cobro.TextColor = Color.Black
                            cobro.BackColor1 = Color.Red
                        Else
                            If row.Item("PaymentDate") < orangedate Then
                                cobro.TextColor = Color.Black
                                cobro.BackColor1 = Color.Orange
                            Else
                                cobro.TextColor = Color.White
                                cobro.BackColor1 = Color.Green
                            End If
                        End If
                        cobro.Image = ImgLCalendar.Images(0)
                        MonthCalendar1.AddDateInfo(cobro)
                        MonthCalendar2.AddDateInfo(cobro)
                        MonthCalendar4.AddDateInfo(cobro)
                        MonthCalendar3.AddDateInfo(cobro)
                    End If
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
        MonthCalendar1.Refresh()
        MonthCalendar2.Refresh()
        MonthCalendar3.Refresh()
        MonthCalendar4.Refresh()

    End Sub
    Dim Dt_fechasAccountsPayable As DataTable
    Private Sub FillAccountsPayable()
        If Not Dt_fechasAccountsPayable Is Nothing Then
            For Each row As DataRow In Dt_fechasAccountsPayable.Rows
                Dim pp As Pabo.Calendar.DateItem() = MonthCalendar1.GetDateInfo(CType(row.Item("PaymentDate"), Date))
                For Each xx As Pabo.Calendar.DateItem In pp
                    xx.Text = ""
                    xx.TextColor = Color.Black
                    xx.BackColor1 = Color.FromArgb(212, 212, 212)
                    xx.Image = Nothing
                Next

                Dim x As String = pp.Count
                REM MonthCalendar1.AddDateInfo(cobro)
                REM MonthCalendar2.AddDateInfo(cobro)
                REM MonthCalendar4.AddDateInfo(cobro)
                REM MonthCalendar3.AddDateInfo(cobro)
            Next
        End If

        Dim Dt_fechas As New DataTable

        Dim orangedate As New Date
        REM Dim color As Color =
        Try
            Using objcobros As New Generic_SQLServer
                Dt_fechas = objcobros.GetQuotasAccountsPayable(Data_Id_Company)
            End Using
            Dt_fechasAccountsPayable = Dt_fechas
            For Each row As DataRow In Dt_fechas.Rows
                If row IsNot Nothing Then
                    Dim pp As Pabo.Calendar.DateItem() = MonthCalendar1.GetDateInfo(CType(row.Item("PaymentDate"), Date))
                    If pp.Count <> 0 Then
                        For Each xx As Pabo.Calendar.DateItem In pp
                            xx.Text = "Cuentas por Pagar"
                            xx.TextColor = Color.Black
                            xx.BackColor1 = Color.LightSlateGray
                            xx.Image = ImgLCalendar.Images(1)
                            orangedate = DateAdd(DateInterval.Day, 4, Date.Today)
                            If row.Item("PaymentDate") < Date.Today Then
                                xx.TextColor = Color.Black
                                xx.BackColor1 = Color.Red
                            Else
                                If row.Item("PaymentDate") < orangedate Then
                                    xx.TextColor = Color.Black
                                    xx.BackColor1 = Color.Orange
                                Else
                                    xx.TextColor = Color.White
                                    xx.BackColor1 = Color.Green
                                End If
                            End If
                        Next
                    Else
                        Dim cobro As New Pabo.Calendar.DateItem
                        cobro.Date = CType(row.Item("PaymentDate"), Date)
                        cobro.Text = "Cuentas por Pagar"
                        orangedate = DateAdd(DateInterval.Day, 4, Date.Today)
                        If row.Item("PaymentDate") < Date.Today Then
                            cobro.TextColor = Color.Black
                            cobro.BackColor1 = Color.Red
                        Else
                            If row.Item("PaymentDate") < orangedate Then
                                cobro.TextColor = Color.Black
                                cobro.BackColor1 = Color.Orange
                            Else
                                cobro.TextColor = Color.White
                                cobro.BackColor1 = Color.Green
                            End If
                        End If
                        cobro.Image = ImgLCalendar.Images(1)
                        MonthCalendar1.AddDateInfo(cobro)
                        MonthCalendar2.AddDateInfo(cobro)
                        MonthCalendar4.AddDateInfo(cobro)
                        MonthCalendar3.AddDateInfo(cobro)

                    End If


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
        MonthCalendar1.Refresh()
        MonthCalendar2.Refresh()
        MonthCalendar3.Refresh()
        MonthCalendar4.Refresh()
    End Sub

    Private Sub calendar_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MonthCalendar2.CalendarDimensions = New System.Drawing.Size(3, 2)
        'MonthCalendar1.PreferredSize = New System.Drawing.Size(3, 2)
        'MonthCalendar1.Size = New System.Drawing.Size(3, 2)
        Select Case OpcionCuenta
            Case TipoCuenta.Cuenta_Cobrar
                FillAccountsReceivable()
                MonthCalendar1.SelectDate(Now)
                MonthCalendar2.SelectDate(Now.AddMonths(1))
                MonthCalendar3.SelectDate(Now.AddMonths(2))
                MonthCalendar4.SelectDate(Now.AddMonths(3))

            Case TipoCuenta.Cuenta_pagar
                FillAccountsPayable()
                MonthCalendar1.SelectDate(Now)
                MonthCalendar2.SelectDate(Now.AddMonths(1))
                MonthCalendar3.SelectDate(Now.AddMonths(2))
                MonthCalendar4.SelectDate(Now.AddMonths(3))

            Case TipoCuenta.Todas_Cuentas
                FillAccountsReceivable()
                FillAccountsPayable()
                MonthCalendar1.SelectDate(Now)
                MonthCalendar2.SelectDate(Now.AddMonths(1))
                MonthCalendar3.SelectDate(Now.AddMonths(2))
                MonthCalendar4.SelectDate(Now.AddMonths(3))
        End Select
    End Sub

End Class

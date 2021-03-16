Public Class FormDinamico
    Dim dt As New DataTable
    Dim posxMayor As Integer = 0
    Dim posyMayor As Integer = 0
    Private posx As Integer = 0
    Private posy As Integer = 0

    Private _Correlativo As Integer
    Public Property Correlativo As Integer
        Get
            Return _Correlativo
        End Get
        Set(value As Integer)
            _Correlativo = value
        End Set
    End Property

    Private Sub FormDinamico_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Using objSQL As New Generic_SQLServer
            dt = objSQL.Campos(Correlativo)
        End Using
        posyMayor = 0
        PnObject.Controls.Clear()
        Dim TabIndexD As Integer = 0
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    TabIndexD += 1
                    If Not row Is Nothing Then
                        posy = row("Y")
                        If (posyMayor <= row("Y")) Then
                            posy = row("Y")
                            posyMayor = row("Y")
                        End If
                        If row("ID_TypeOBject_FK") = 1 Then
                            Dim obj As New TextCaja_EPD
                            obj.LoadControl(row("Title"), "", row("MaxLength"), row("Multiline"), row("JustNumbers"), row("JustLetters"), row("ReadOnly"), row("Enabled"), row("WordWrap"), row("Column"), row("Style"), row("Font"), TabIndexD)
                            With obj
                                .Location = New Point(row("X"), row("Y"))
                            End With

                            PnObject.Controls.Add(obj)
                        ElseIf row("ID_TypeOBject_FK") = 2 Then
                            Dim dataCB As New DataTable
                            'Using objSQL As New SQLProcess
                            '    Dim ID_Campo As Long = row("ID_Campo")
                            '    ' dataCB = objSQL.DataCB(ID_Campo)
                            'End Using
                            Dim obj_CB As New ComboBox_EPD
                            obj_CB.LoadControl(row("Titulo"), dataCB, row("Column"))
                            With obj_CB
                                .Location = New Point(row("X"), row("Y"))
                            End With
                            PnObject.Controls.Add(obj_CB)
                        ElseIf row("ID_TypeOBject_FK") = 5 Then
                            Dim objLabel As New Label
                            objLabel.Text = row("Title")
                            objLabel.Text = row("Title")
                            objLabel.Font = New Font(row("Style").ToString, row("Font"))
                            objLabel.Width = row("Width")
                            objLabel.Height = row("Height")
                            With objLabel
                                .Location = New Point(row("X"), row("Y"))
                            End With
                            PnObject.Controls.Add(objLabel)
                        End If
                    End If
                Next row

                Dim objButton As Button = New Button()
                AddHandler objButton.Click, AddressOf ProcesarInfo
                objButton.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                objButton.Location = New System.Drawing.Point(260, posyMayor + 120)
                objButton.Name = "btnCrearForm"
                objButton.Size = New System.Drawing.Size(127, 53)
                objButton.TabIndex = 13
                objButton.Text = "Procesar"
                objButton.UseVisualStyleBackColor = True

                PnObject.Controls.Add(objButton)
                Dim Ctl As Control

        
            End If
        End If
    End Sub

    Public Sub ProcesarInfo(ByVal sender As Object, ByVal e As EventArgs)
        Dim Ctl As Control
        Dim x As Integer
        Dim Query As String = ""
        Dim Columns As String = "[Id_Process],"
        Dim Values As String = Correlativo.ToString + ","
        Dim resp As String = ""
        For x = PnObject.Controls.Count - 1 To 0 Step -1
            Ctl = PnObject.Controls.Item(x)
            If TypeOf (Ctl) Is TextCaja_EPD Then
                Dim Control As TextCaja_EPD = Ctl
                If (Control.ReturnValue.ToString = "") Then
                    MessageBox.Show("Complete campo " & Control.NameControl.Replace("[", "").Replace("]", ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Control.Focus()
                    Return
                Else
                    Values &= "'" & Control.ReturnValue & "'" & ","
                    Columns &= Control.NameControl & ","
                End If
            ElseIf TypeOf (Ctl) Is ComboBox_EPD Then
                Dim Control As ComboBox_EPD = Ctl
                If Control.ReturnValue <= 0 Then
                    MessageBox.Show("seleeccione una opción del campo " & Control.NameControl.Replace("[", "").Replace("]", ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                Else
                    Columns &= Control.NameControl & ","
                    Values &= Control.ReturnValue & ","
                End If
            End If
        Next x

        Using objQuery As New Query
            Query = objQuery.QueryInsert("Production_Form_Details", Columns, Values)
        End Using

        'MessageBox.Show(Query)
        Using objSQl As New Generic_SQLServer
            resp = objSQl.AddRegistro(Query)
        End Using
        If resp = "OK" Then
            MessageBox.Show("Registro ingresado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For x = 0 To PnObject.Controls.Count - 1
                Ctl = PnObject.Controls.Item(x)
                If TypeOf (Ctl) Is TextCaja_EPD Then
                    Dim Control As TextCaja_EPD = Ctl

                    Control.txtCampo.Text = ""
                End If
            Next x
        Else
            MessageBox.Show("Ocurrio un error al almacenar el registro", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
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
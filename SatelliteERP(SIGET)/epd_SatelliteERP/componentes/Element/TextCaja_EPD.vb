Public Class TextCaja_EPD
    'Private dragging As Boolean
    'Private posicionX, posicionY As Integer
    Public Property JustNumbers As Boolean = False
    Public Property JustLetters As Boolean = False
    Public Property NameControl As String = ""

    Public Property F_ReadOnly As Boolean = False
    Private _EntradaNumeros As Integer = 0
    Private _EntradaLetras As Integer = 0
    Public Property EntradaNumeros As Integer
        Get
            Return _EntradaNumeros
        End Get
        Set(value As Integer)
            _EntradaNumeros = value
        End Set
    End Property

    Public Property EntradaLetras As Integer
        Get
            Return _EntradaLetras
        End Get
        Set(value As Integer)
            _EntradaLetras = value
        End Set
    End Property




    Public Sub LoadControl(ByVal Label As String, ByVal value As String, ByVal MaxLength As Integer, ByVal Multiline As Boolean, ByVal JustNumbers As Boolean, ByVal JustLetters As Boolean, ByVal ReadOnly_ As Boolean, ByVal Enable As Boolean, ByVal WordWrap As Boolean, ByVal Column As String, ByVal Fuente As String, ByVal SizeFont As Double, ByVal TabIndexD As Integer)
        lblEtiqueta.Text = Label
        txtCampo.MaxLength = MaxLength
        txtCampo.Text = value
        txtCampo.Multiline = Multiline
        txtCampo.ReadOnly = ReadOnly_
        txtCampo.Enabled = Enable
        txtCampo.TabIndex = TabIndexD
        txtCampo.WordWrap = WordWrap
        txtCampo.Font = New System.Drawing.Font(Fuente, SizeFont, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtCampo.Size = New System.Drawing.Size(430, 34)
        _JustNumbers = JustNumbers
        _JustLetters = JustLetters
        NameControl = Column
        F_ReadOnly = ReadOnly_

    End Sub
    Public Function ReturnValue() As String
        Return txtCampo.Text.Trim
    End Function

    Private Sub txtCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCampo.KeyPress
        Using ObjValidate As New Validaciones
            If _JustNumbers And JustLetters Then
                e.Handled = False
            Else
                If _JustNumbers Then
                    e.Handled = ObjValidate.JustNumbers(sender, e)
                ElseIf _JustLetters Then
                    e.Handled = ObjValidate.JustLetters(sender, e)
                End If
            End If
        End Using
    End Sub


    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        Me.Controls.Clear()
    End Sub
End Class

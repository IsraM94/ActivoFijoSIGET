Public Class ComboBox_EPD

    Public Property NameControl As String = ""
    'Private dragging As Boolean
    'Private posicionX, posicionY As Integer

    Public Sub LoadControl(ByVal Label As String, ByVal Data As DataTable, ByVal Column As String)
        lblEtiqueta.Text = Label
        cbData.DataSource = Data
        cbData.DisplayMember = "Descripcion"
        cbData.ValueMember = "ID"
        cbData.SelectedIndex = -1
        NameControl = Column
    End Sub

    Public Function ReturnValue() As Long
        Return cbData.SelectedValue
    End Function

    'Private Sub TextCaja_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

    '    dragging = True
    '    posicionX = e.X
    '    posicionY = e.Y
    'End Sub

    'Private Sub TextCaja_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
    '    If dragging = True Then
    '        MyBase.Location = New Point(MyBase.Location.X + e.X -
    '        posicionX, MyBase.Location.Y + e.Y - posicionY)
    '        Me.Refresh()
    '    End If
    'End Sub

    'Private Sub TextCaja_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
    '    dragging = False
    'End Sub
End Class

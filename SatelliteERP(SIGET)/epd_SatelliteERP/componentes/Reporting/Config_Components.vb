Public Class Config_Components
    Property ConfigField As New Reporting_Field
    Private Sub Config_Components_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allFonts As New Drawing.Text.InstalledFontCollection
        Dim fontFamiliesList() As FontFamily = allFonts.Families()
        For Each fontFamilies As FontFamily In fontFamiliesList
            CB_Font.Items.Add(fontFamilies.Name)
        Next

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim styles As FontStyle = FontStyle.Regular

        If (CK_Bold.Checked) Then
            styles = styles Or FontStyle.Bold
        End If

        If (CK_Italic.Checked) Then
            styles = styles Or FontStyle.Italic
        End If

        If (CK_Underline.Checked) Then
            styles = styles Or FontStyle.Underline
        End If

        ConfigField.Font = New Font(CB_Font.Text, CType(CB_Size.Text, Single), styles)
        If Not txtX.Text = "" Then
            ConfigField.X = txtX.Text
        End If

        If Not TxtY.Text = "" Then
            ConfigField.Y = TxtY.Text
        End If

        If CB_Aling.Text = "Centro" Then
            ConfigField.Aling = StringAlignment.Center
        ElseIf CB_Aling.Text = "Izquierda" Then
            ConfigField.Aling = StringAlignment.Far
        Else
            ConfigField.Aling = StringAlignment.Near
        End If
        Close()

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
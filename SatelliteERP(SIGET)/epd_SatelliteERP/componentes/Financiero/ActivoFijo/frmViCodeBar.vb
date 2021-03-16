Public Class frmViCodeBar


    Public Property DT_CodeBar() As dsCodeBar.CodeBarDataTable
        Get
            Return dsCodeBar.CodeBar
        End Get
        Set(ByVal value As dsCodeBar.CodeBarDataTable)
            For Each info As DataRow In value.Rows

                info.BeginEdit()
                '    info("IMG_Code") = imageToByte(objCodeBar.createbarcode(info("ID_Code")))

                info.EndEdit()
                dsCodeBar.AcceptChanges()
                dsCodeBar.CodeBar.ImportRow(info)
            Next

        End Set
    End Property

    Private _image As Image
    Public Property CodeBar() As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
        End Set
    End Property
    Private Sub frmViCodeBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.ReportViewer1.LocalReport.DataSources.Add(_dataCodeBar)
        ' Me.ReportViewer1.RefreshReport()
    End Sub
    Private Function imageToByte(codeBarImg As Image) As Byte()
        _image = codeBarImg
        Dim ms = New IO.MemoryStream()
        codeBarImg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) ' Use appropriate format here
        Dim bytes = ms.ToArray()
        Return bytes
    End Function

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
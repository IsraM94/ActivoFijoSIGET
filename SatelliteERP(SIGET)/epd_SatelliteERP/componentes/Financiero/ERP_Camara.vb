Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Video.FFMPEG
'Imports System.IO
Imports System.Drawing.Imaging
Imports System.IO

Public Class ERP_Camara
    Private Dispositivo As FilterInfoCollection
    Private FuenteDeVideo As VideoCaptureDevice
    Private objSql As New Financiero_SQLServer
    'Dim ESCRITOR As New VideoFileWriter()
    Property id_FixedAsset_FK As Long
    Dim BMP As Bitmap
    Private Sub ERP_Camara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        'VideoSourcePlayer1.Stop()
        'VideoSourcePlayer1.SignalToStop()
        Dispositivo = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In Dispositivo
            cmbDevice.Items.Add(x.Name)
        Next
        cmbDevice.SelectedIndex = 0
        FuenteDeVideo = New VideoCaptureDevice(Dispositivo(cmbDevice.SelectedIndex).MonikerString)
        AddHandler FuenteDeVideo.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
        FuenteDeVideo.Start()
        'VideoSourcePlayer1.VideoSource = FuenteDeVideo
        'VideoSourcePlayer1.Start()

        'btnCamara_Click(sender, e)

    End Sub
    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        'If ButtonVIDEO.BackColor = Color.Black Then 'SI NO ESTA GRABANDO ......
        '    BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PONE LOS DATOS EN EL BITMAP
        '    PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
        'Else ' SI ESTAS GRABANDO...
        Try
            BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PON LOS DATOS EN EL BITMAP
            PictureBox2.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
            'ESCRITOR.WriteVideoFrame(BMP) 'LOS GUARDA EN LA MEMORIA
        Catch ex As Exception
        End Try


        'End If
    End Sub
    Private Sub btnCamara_Click(sender As Object, e As EventArgs) Handles btnCamara.Click
        FuenteDeVideo = New VideoCaptureDevice(Dispositivo(cmbDevice.SelectedIndex).MonikerString)
        'VideoSourcePlayer1.VideoSource = FuenteDeVideo
        'VideoSourcePlayer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        '    Dim img As Bitmap = VideoSourcePlayer1.GetCurrentVideoFrame()
        '    PictureBox1.Image = img
        'FuenteDeVideo.Stop()
        PictureBox1.Image = PictureBox2.Image
        Try
            Dim picStream As New MemoryStream
            PictureBox1.Image.Save(picStream, ImageFormat.Bmp)
            Dim PicByte As Byte() = picStream.ToArray
            Dim res As Integer = objSql.ERP_FixedAssets_MasterImage_Insert(id_FixedAsset_FK, PicByte) 'Ingresa una imagen
            MessageBox.Show("Foto tomada con exito", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'VideoSourcePlayer1.Stop()
            'VideoSourcePlayer1.SignalToStop()
            FuenteDeVideo.Stop()
            Close()
        Catch ex As Exception
            MessageBox.Show("Problemas con dispositivo", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        '    Dim picStream As New MemoryStream
        '    PictureBox1.Image.Save(picStream, ImageFormat.Gif)
        '    Dim PicByte As Byte() = picStream.ToArray
        '    Dim res As Integer = objSql.ERP_FixedAssets_MasterImage_Insert(id_FixedAsset_FK, PicByte) 'Ingresa una imagen
        '    MessageBox.Show("Foto tomada con exito", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    'VideoSourcePlayer1.Stop()
        '    'VideoSourcePlayer1.SignalToStop()
        '    Close()
        'Catch ex As Exception
        '    MessageBox.Show("Problemas con dispositivo", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FuenteDeVideo.Stop()
        'VideoSourcePlayer1.Stop()
        'VideoSourcePlayer1.SignalToStop()
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
Public Class CrearCodeBar
    'Private b = New BarcodeLib.Barcode()
    Private barcodeimage As String
    Dim dt As String = ""
    Public Function createbarcode(Valor As String) As Image
        Dim b = New BarcodeLib.Barcode()

        Dim temp As New Bitmap(1, 1)
        temp.SetPixel(0, 0, System.Drawing.SystemColors.Control)
        'pictureBox1.Image = DirectCast(temp, Image)


        Dim W As Integer = Convert.ToInt32(300)
        Dim H As Integer = Convert.ToInt32(60)

        Dim type As BarcodeLib.TYPE = BarcodeLib.TYPE.UNSPECIFIED
        type = BarcodeLib.TYPE.CODE39

        Try
            If type <> BarcodeLib.TYPE.UNSPECIFIED Then
                'To generate label
                b.IncludeLabel = True

                '===== Encoding performed here =====
                '===================================
                'pictureBox1.Image = b.Encode(type, dt.Trim(), Me.b.ForeColor, Me.b.BackColor, W, H)
                Dim img As Image = b.Encode(type, Valor, b.ForeColor, b.BackColor, W, H)
                Return img

            End If

            '  pictureBox1.Width = pictureBox1.Image.Width
            ' pictureBox1.Height = pictureBox1.Image.Height


            ' BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;

            ' PNG 

            ' savetype = BarcodeLib.SaveTypes.PNG;

            'Environment.CurrentDirectory = "barcodeimages/";

            ' b.SaveImage(barcodeimage, savetype);

            ' pictureBox1.Image.Save(imgsavepath + barcodeimage)

            'bhawanabothara@gmail.com
            'lov$4vvr


        Catch ex As Exception
            'Application.[Exit]()
        End Try
        Return Nothing
    End Function


End Class

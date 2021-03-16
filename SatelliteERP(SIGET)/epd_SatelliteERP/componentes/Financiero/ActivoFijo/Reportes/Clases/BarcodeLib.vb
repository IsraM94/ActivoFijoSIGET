Imports System.Collections
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging

' Barcode Library
' * 
' * Written by: Brad Barnhill
' *       Date: September 21, 2007
' * 
' * This library was designed to give developers an easy class to use when they need
' * to generate barcode images from a string of data.
' 

Namespace BarcodeLib
#Region "Enums"
    Public Enum TYPE As Integer
        UNSPECIFIED
        UPCA
        UPCE
        UPC_SUPPLEMENTAL_2DIGIT
        UPC_SUPPLEMENTAL_5DIGIT
        EAN13
        EAN8
        Interleaved2of5
        Standard2of5
        Industrial2of5
        CODE39
        CODE39Extended
        Codabar
        PostNet
        BOOKLAND
        ISBN
        JAN13
        MSI_Mod10
        MSI_2Mod10
        MSI_Mod11
        MSI_Mod11_Mod10
        Modified_Plessey
        CODE11
        USD8
        UCC12
        UCC13
        LOGMARS
        CODE128
        CODE128A
        CODE128B
        CODE128C
        ITF14
        CODE93
    End Enum
    Public Enum SaveTypes As Integer
        JPG
        BMP
        PNG
        GIF
        TIFF
        UNSPECIFIED
    End Enum
#End Region
    ''' <summary>
    ''' This class was designed to give developers and easy way to generate a barcode image from a string of data.
    ''' </summary>
    Public Class Barcode
        Implements IDisposable

#Region "Variables"
        Private Raw_Data As String = ""
        Private Formatted_Data As String = ""
        Private Encoded_Value As String = ""
        Private _Country_Assigning_Manufacturer_Code As String = "N/A"
        Private Encoded_Type As TYPE = TYPE.UNSPECIFIED
        Private _Encoded_Image As Image = Nothing
        Private _ForeColor As Color = Color.Black
        Private _BackColor As Color = Color.White
        Private _Width As Integer = 300
        Private _Height As Integer = 150
        Private _IncludeLabel As Boolean = False
        Private _EncodingTime As Double = 0
        Private _XML As String = ""
        Private _ImageFormat As ImageFormat = ImageFormat.Jpeg
#End Region

#Region "Constructors"

        Public Sub New()
        End Sub
        'Barcode
        ''' <summary>
        ''' Constructor. Populates the raw data. No whitespace will be added before or after the barcode.
        ''' </summary>
        ''' <param name="data">String to be encoded.</param>
        Public Sub New(data As String)
            'constructor
            Me.Raw_Data = data
        End Sub
        'Barcode
        Public Sub New(data As String, iType As TYPE)
            Me.Raw_Data = data
            Me.Encoded_Type = iType
        End Sub
#End Region

#Region "Properties"
        ''' <summary>
        ''' Gets the formatted data.
        ''' </summary>
        Public ReadOnly Property FormattedData() As String
            Get
                Return Formatted_Data
            End Get
        End Property
        'FormattedData
        ''' <summary>
        ''' Gets or sets the raw data to encode.
        ''' </summary>
        Public Property RawData() As String
            Get
                Return Raw_Data
            End Get
            Set
                Raw_Data = Value
            End Set
        End Property
        'RawData
        ''' <summary>
        ''' Gets the encoded value.
        ''' </summary>
        Public ReadOnly Property EncodedValue() As String
            Get
                Return Encoded_Value
            End Get
        End Property
        'EncodedValue
        ''' <summary>
        ''' Gets the Country that assigned the Manufacturer Code.
        ''' </summary>
        Public ReadOnly Property Country_Assigning_Manufacturer_Code() As String
            Get
                Return _Country_Assigning_Manufacturer_Code
            End Get
        End Property
        'Country_Assigning_Manufacturer_Code
        ''' <summary>
        ''' Gets or sets the Encoded Type (ex. UPC-A, EAN-13 ... etc)
        ''' </summary>
        Public Property EncodedType() As TYPE
            Get
                Return Encoded_Type
            End Get
            Set
                Encoded_Type = Value
            End Set
        End Property
        'EncodedType
        ''' <summary>
        ''' Gets the Image of the generated barcode.
        ''' </summary>
        Public ReadOnly Property EncodedImage() As Image
            Get
                Return _Encoded_Image
            End Get
        End Property
        'EncodedImage
        ''' <summary>
        ''' Gets or sets the color of the bars. (Default is black)
        ''' </summary>
        Public Property ForeColor() As Color
            Get
                Return Me._ForeColor
            End Get
            Set
                Me._ForeColor = Value
            End Set
        End Property
        'ForeColor
        ''' <summary>
        ''' Gets or sets the background color. (Default is white)
        ''' </summary>
        Public Property BackColor() As Color
            Get
                Return Me._BackColor
            End Get
            Set
                Me._BackColor = Value
            End Set
        End Property
        'BackColor
        ''' <summary>
        ''' Gets or sets the width of the image to be drawn. (Default is 300 pixels)
        ''' </summary>
        Public Property Width() As Integer
            Get
                Return _Width
            End Get
            Set
                _Width = Value
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets the height of the image to be drawn. (Default is 150 pixels)
        ''' </summary>
        Public Property Height() As Integer
            Get
                Return _Height
            End Get
            Set
                _Height = Value
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets whether a label should be drawn below the image.
        ''' </summary>
        Public Property IncludeLabel() As Boolean
            Get
                Return Me._IncludeLabel
            End Get
            Set
                Me._IncludeLabel = Value
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets the amount of time in milliseconds that it took to encode and draw the barcode.
        ''' </summary>
        Public Property EncodingTime() As Double
            Get
                Return _EncodingTime
            End Get
            Set
                _EncodingTime = Value
            End Set
        End Property
        ''' <summary>
        ''' Gets the XML representation of the Barcode data and image.
        ''' </summary>
        Public ReadOnly Property XML() As String
            Get
                Return _XML
            End Get
        End Property
        ''' <summary>
        ''' Gets or sets the image format to use when encoding and returning images. (Jpeg is default)
        ''' </summary>
        Public Property ImageFormat() As ImageFormat
            Get
                Return _ImageFormat
            End Get
            Set
                _ImageFormat = Value
            End Set
        End Property
#End Region

#Region "Functions"
#Region "General Encode"
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="StringToEncode">Raw data to encode.</param>
        ''' <param name="Width">Width of the resulting barcode.(pixels)</param>
        ''' <param name="Height">Height of the resulting barcode.(pixels)</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Function Encode(iType As TYPE, StringToEncode As String, Width As Integer, Height As Integer) As Image
            Me.Width = Width
            Me.Height = Height
            Return Encode(iType, StringToEncode)
        End Function
        'Encode(TYPE, string, int, int)
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="StringToEncode">Raw data to encode.</param>
        ''' <param name="DrawColor">Foreground color</param>
        ''' <param name="BackColor">Background color</param>
        ''' <param name="Width">Width of the resulting barcode.(pixels)</param>
        ''' <param name="Height">Height of the resulting barcode.(pixels)</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Function Encode(iType As TYPE, StringToEncode As String, ForeColor As Color, BackColor As Color, Width As Integer, Height As Integer) As Image
            Me.Width = Width
            Me.Height = Height
            Return Encode(iType, StringToEncode, ForeColor, BackColor)
        End Function
        'Encode(TYPE, string, Color, Color, int, int)
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="StringToEncode">Raw data to encode.</param>
        ''' <param name="DrawColor">Foreground color</param>
        ''' <param name="BackColor">Background color</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Function Encode(iType As TYPE, StringToEncode As String, ForeColor As Color, BackColor As Color) As Image
            Me.BackColor = BackColor
            Me.ForeColor = ForeColor
            Return Encode(iType, StringToEncode)
        End Function
        '(Image)Encode(Type, string, Color, Color)
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="StringToEncode">Raw data to encode.</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Function Encode(iType As TYPE, StringToEncode As String) As Image
            Raw_Data = StringToEncode
            Return Encode(iType)
        End Function
        '(Image)Encode(TYPE, string)
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        Friend Function Encode(iType As TYPE) As Image
            Encoded_Type = iType
            Return Encode()
        End Function
        'Encode()
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.
        ''' </summary>
        Friend Function Encode() As Image
            Dim dtStartTime As DateTime = DateTime.Now

            'make sure there is something to encode
            If Raw_Data.Trim() = "" Then
                Throw New Exception("EENCODE-1: Input data not allowed to be blank.")
            End If

            If Me.EncodedType = TYPE.UNSPECIFIED Then
                Throw New Exception("EENCODE-2: Symbology type not allowed to be unspecified.")
            End If

            Me.Encoded_Value = ""
            Me._Country_Assigning_Manufacturer_Code = "N/A"

            Dim ibarcode As Code39
            Select Case Me.Encoded_Type

                Case TYPE.CODE39
                    'Encode_Code39();
                    ibarcode = New Code39(Raw_Data)
                    Exit Select
                Case Else

                    Throw New Exception("EENCODE-2: Unsupported encoding type specified.")
            End Select
            'switch
            Try
                Encoded_Value = ibarcode.Encoded_Value
            Catch ex As NotImplementedException
                Encoded_Value = ""
            End Try

            Raw_Data = ibarcode.RawData
            Formatted_Data = ibarcode.FormattedData
            _EncodingTime = DirectCast(DateTime.Now - dtStartTime, TimeSpan).TotalMilliseconds

            _Encoded_Image = DirectCast(Generate_Image(), Image)

            _XML = GetXML()

            Return EncodedImage
        End Function
        'Encode
#End Region
#Region "Image Functions"
        ''' <summary>
        ''' Gets a bitmap representation of the encoded data.
        ''' </summary>
        ''' <returns>Bitmap of encoded value.</returns>
        Private Function Generate_Image() As Bitmap
            If Encoded_Value = "" Then
                Throw New Exception("EGENERATE_IMAGE-1: Must be encoded first.")
            End If
            Dim b As Bitmap = Nothing

            Select Case Me.Encoded_Type
                Case TYPE.ITF14
                    If True Then
                        b = New Bitmap(Width, Height)

                        Dim bearerwidth As Integer = CInt((b.Width) / 12.05)
                        Dim iquietzone As Integer = Convert.ToInt32(b.Width * 0.05)
                        Dim iBarWidth As Integer = (b.Width - (bearerwidth * 2) - (iquietzone * 2)) / Encoded_Value.Length
                        Dim shiftAdjustment As Integer = ((b.Width - (bearerwidth * 2) - (iquietzone * 2)) Mod Encoded_Value.Length) / 2

                        If iBarWidth <= 0 OrElse iquietzone <= 0 Then
                            Throw New Exception("EGENERATE_IMAGE-3: Image size specified not large enough to draw image. (Bar size determined to be less than 1 pixel or quiet zone determined to be less than 1 pixel)")
                        End If

                        'draw image
                        Dim pos As Integer = 0

                        Using g As Graphics = Graphics.FromImage(b)
                            'fill background
                            g.Clear(BackColor)

                            'lines are fBarWidth wide so draw the appropriate color line vertically
                            Using pen As New Pen(ForeColor, iBarWidth)
                                pen.Alignment = PenAlignment.Right

                                While pos < Encoded_Value.Length
                                    'lines are 2px wide so draw the appropriate color line vertically
                                    If Encoded_Value(pos) = "1"c Then
                                        g.DrawLine(pen, New Point((pos * iBarWidth) + shiftAdjustment + bearerwidth + iquietzone, 0), New Point((pos * iBarWidth) + shiftAdjustment + bearerwidth + iquietzone, Height))
                                    End If

                                    pos += 1
                                End While
                                'while
                                'bearer bars
                                pen.Width = CSng(b.Height) / 8
                                pen.Color = ForeColor
                                pen.Alignment = PenAlignment.Inset
                                g.DrawLine(pen, New Point(0, 0), New Point(b.Width, 0))
                                'top
                                g.DrawLine(pen, New Point(0, b.Height), New Point(b.Width, b.Height))
                                'bottom
                                g.DrawLine(pen, New Point(0, 0), New Point(0, b.Height))
                                'left
                                'right
                                g.DrawLine(pen, New Point(b.Width, 0), New Point(b.Width, b.Height))
                                'using
                            End Using
                        End Using
                        'using
                        If IncludeLabel Then
                            Label_ITF14(DirectCast(b, Image))
                        End If

                        Exit Select
                    End If
                'case
                Case TYPE.PostNet
                    If True Then
                        b = New Bitmap(Encoded_Value.Length * 4, 20)

                        'draw image
                        For y As Integer = b.Height - 1 To 1 Step -1
                            Dim x As Integer = 0
                            If y < b.Height / 2 Then
                                'top
                                While x < b.Width
                                    If Encoded_Value(x / 4) = "1"c Then
                                        'draw bar
                                        b.SetPixel(x, y, ForeColor)
                                        b.SetPixel(x + 1, y, ForeColor)
                                        b.SetPixel(x + 2, y, BackColor)
                                        b.SetPixel(x + 3, y, BackColor)
                                    Else
                                        'if
                                        'draw space
                                        b.SetPixel(x, y, BackColor)
                                        b.SetPixel(x + 1, y, BackColor)
                                        b.SetPixel(x + 2, y, BackColor)
                                        b.SetPixel(x + 3, y, BackColor)
                                    End If
                                    'else
                                    x += 4
                                    'while
                                End While
                            Else
                                'if
                                'bottom
                                While x < b.Width
                                    b.SetPixel(x, y, ForeColor)
                                    b.SetPixel(x + 1, y, ForeColor)
                                    b.SetPixel(x + 2, y, BackColor)
                                    b.SetPixel(x + 3, y, BackColor)
                                    x += 4
                                    'while
                                End While
                                'else 
                            End If
                        Next
                        'for
                        Exit Select
                    End If
                Case Else
                    'case
                    If True Then
                        b = New Bitmap(Width, Height)

                        Dim iBarWidth As Integer = Width / Encoded_Value.Length
                        Dim shiftAdjustment As Integer = (Width Mod Encoded_Value.Length) / 2

                        If iBarWidth <= 0 Then
                            Throw New Exception("EGENERATE_IMAGE-2: Image size specified not large enough to draw image. (Bar size determined to be less than 1 pixel)")
                        End If

                        'draw image
                        Dim pos As Integer = 0

                        Using g As Graphics = Graphics.FromImage(b)
                            'clears the image and colors the entire background
                            g.Clear(BackColor)

                            'lines are fBarWidth wide so draw the appropriate color line vertically
                            Using pen As New Pen(ForeColor, iBarWidth)
                                pen.Alignment = PenAlignment.Right

                                While pos < Encoded_Value.Length
                                    If Encoded_Value(pos) = "1"c Then
                                        g.DrawLine(pen, New Point(pos * iBarWidth + shiftAdjustment, 0), New Point(pos * iBarWidth + shiftAdjustment, Height))
                                    End If

                                    pos += 1
                                    'while
                                End While
                                'using
                            End Using
                        End Using
                        'using
                        If IncludeLabel Then
                            Label_Generic(DirectCast(b, Image))
                        End If

                        Exit Select
                    End If
                    'case
            End Select
            'switch
            _Encoded_Image = DirectCast(b, Image)

            Return b
        End Function
        'Generate_Image
        ''' <summary>
        ''' Gets the bytes that represent the image.
        ''' </summary>
        ''' <param name="savetype">File type to put the data in before returning the bytes.</param>
        ''' <returns>Bytes representing the encoded image.</returns>
        Public Function GetImageData(savetype As SaveTypes) As Byte()
            Dim imageData As Byte() = Nothing

            Try
                If _Encoded_Image IsNot Nothing Then
                    'Save the image to a memory stream so that we can get a byte array!      
                    Using ms As New MemoryStream()
                        SaveImage(ms, savetype)
                        imageData = ms.ToArray()
                        ms.Flush()
                        ms.Close()
                        'using
                    End Using
                    'if
                End If
                'try
            Catch ex As Exception
                Throw New Exception("EGETIMAGEDATA-1: Could not retrieve image data. " + ex.Message)
            End Try
            'catch  
            Return imageData
        End Function
        ''' <summary>
        ''' Saves an encoded image to a specified file and type.
        ''' </summary>
        ''' <param name="Filename">Filename to save to.</param>
        ''' <param name="FileType">Format to use.</param>
        Public Sub SaveImage(Filename As String, FileType As SaveTypes)
            Try
                If _Encoded_Image IsNot Nothing Then
                    Dim imageformat__1 As System.Drawing.Imaging.ImageFormat
                    Select Case FileType
                        Case SaveTypes.BMP
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Bmp
                            Exit Select
                        Case SaveTypes.GIF
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Gif
                            Exit Select
                        Case SaveTypes.JPG
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Jpeg
                            Exit Select
                        Case SaveTypes.PNG
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Png
                            Exit Select
                        Case SaveTypes.TIFF
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Tiff
                            Exit Select
                        Case Else
                            imageformat__1 = ImageFormat
                            Exit Select
                    End Select
                    'switch
                    DirectCast(_Encoded_Image, Bitmap).Save(Filename, imageformat__1)
                    'if
                End If
                'try
            Catch ex As Exception
                Throw New Exception("ESAVEIMAGE-1: Could not save image." & vbLf & vbLf & "=======================" & vbLf & vbLf + ex.Message)
            End Try
            'catch
        End Sub
        'SaveImage(string, SaveTypes)
        ''' <summary>
        ''' Saves an encoded image to a specified stream.
        ''' </summary>
        ''' <param name="stream">Stream to write image to.</param>
        ''' <param name="FileType">Format to use.</param>
        Public Sub SaveImage(stream As Stream, FileType As SaveTypes)
            Try
                If _Encoded_Image IsNot Nothing Then
                    Dim imageformat__1 As System.Drawing.Imaging.ImageFormat
                    Select Case FileType
                        Case SaveTypes.BMP
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Bmp
                            Exit Select
                        Case SaveTypes.GIF
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Gif
                            Exit Select
                        Case SaveTypes.JPG
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Jpeg
                            Exit Select
                        Case SaveTypes.PNG
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Png
                            Exit Select
                        Case SaveTypes.TIFF
                            imageformat__1 = System.Drawing.Imaging.ImageFormat.Tiff
                            Exit Select
                        Case Else
                            imageformat__1 = ImageFormat
                            Exit Select
                    End Select
                    'switch
                    DirectCast(_Encoded_Image, Bitmap).Save(stream, imageformat__1)
                    'if
                End If
                'try
            Catch ex As Exception
                Throw New Exception("ESAVEIMAGE-2: Could not save image." & vbLf & vbLf & "=======================" & vbLf & vbLf + ex.Message)
            End Try
            'catch
        End Sub
        'SaveImage(Stream, SaveTypes)
#End Region
#Region "Label Generation"
        Private Function Label_ITF14(img As Image) As Image
            Try
                Dim font As System.Drawing.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)

                Using g As Graphics = Graphics.FromImage(img)
                    g.DrawImage(img, CSng(0), CSng(0))

                    g.SmoothingMode = SmoothingMode.HighQuality
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality
                    g.CompositingQuality = CompositingQuality.HighQuality

                    'color a white box at the bottom of the barcode to hold the string of data
                    g.FillRectangle(New SolidBrush(Me.BackColor), New Rectangle(0, img.Height - 16, img.Width, 16))

                    'draw datastring under the barcode image
                    Dim f As New StringFormat()
                    f.Alignment = StringAlignment.Center
                    g.DrawString(Me.Raw_Data, font, New SolidBrush(Me.ForeColor), CSng(img.Width / 2), img.Height - 16, f)

                    Dim pen As New Pen(ForeColor, CSng(img.Height) / 16)
                    pen.Alignment = PenAlignment.Inset
                    g.DrawLine(pen, New Point(0, img.Height - 20), New Point(img.Width, img.Height - 20))
                    'bottom
                    g.Save()
                End Using
                'using
                Return img
                'try
            Catch ex As Exception
                Throw New Exception("ELABEL_ITF14-1: " + ex.Message)
            End Try
            'catch
        End Function
        Private Function Label_Generic(img As Image) As Image
            Try
                Dim font As System.Drawing.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)

                Using g As Graphics = Graphics.FromImage(img)
                    g.DrawImage(img, CSng(0), CSng(0))

                    g.SmoothingMode = SmoothingMode.HighQuality
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality
                    g.CompositingQuality = CompositingQuality.HighQuality

                    'color a background color box at the bottom of the barcode to hold the string of data
                    g.FillRectangle(New SolidBrush(Me.BackColor), New Rectangle(0, img.Height - 16, img.Width, 16))

                    'draw datastring under the barcode image
                    Dim f As New StringFormat()
                    f.Alignment = StringAlignment.Center

                    Dim strLabelText As String = If((Me.FormattedData.Trim() <> ""), Me.FormattedData, Me.RawData)

                    g.DrawString(strLabelText, font, New SolidBrush(Me.ForeColor), CSng(img.Width / 2), img.Height - 16, f)

                    g.Save()
                End Using
                'using
                Return img
                'try
            Catch ex As Exception
                Throw New Exception("ELABEL_GENERIC-1: " + ex.Message)
            End Try
            'catch
        End Function
        'Label_Generic
#End Region
#End Region
#Region "Misc"
        Friend Shared Function CheckNumericOnly(Data As String) As Boolean
            'This function takes a string of data and breaks it into parts and trys to do Int64.TryParse
            'This will verify that only numeric data is contained in the string passed in.  The complexity below
            'was done to ensure that the minimum number of interations and checks could be performed.

            '9223372036854775808 is the largest number a 64bit number(signed) can hold so ... make sure its less than that by one place
            Dim STRING_LENGTHS As Integer = 18

            Dim temp As String = Data
            Dim strings As String() = New String((Data.Length / STRING_LENGTHS) + ((If((Data.Length Mod STRING_LENGTHS = 0), 0, 1)) - 1)) {}

            Dim i As Integer = 0
            While i < strings.Length
                If temp.Length >= STRING_LENGTHS Then
                    strings(System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)) = temp.Substring(0, STRING_LENGTHS)
                    temp = temp.Substring(STRING_LENGTHS)
                Else
                    'if
                    strings(System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)) = temp.Substring(0)
                End If
            End While

            For Each s As String In strings
                Dim value As Long = 0
                If Not Int64.TryParse(s, value) Then
                    Return False
                End If
            Next
            'foreach
            Return True
        End Function
        'CheckNumericOnly
        Private Function GetXML() As String
            If EncodedValue = "" Then
                Throw New Exception("EGETXML-1: Could not retrieve XML due to the barcode not being encoded first.  Please call Encode first.")
            Else
                Try
                    Using xml As New BarcodeXML()
                        Dim row As BarcodeXML.BarcodeRow = xml.Barcode.NewBarcodeRow()
                        row.Type = EncodedType.ToString()
                        row.RawData = RawData
                        row.EncodedValue = EncodedValue
                        row.EncodingTime = EncodingTime
                        row.IncludeLabel = IncludeLabel
                        row.Forecolor = ColorTranslator.ToHtml(ForeColor)
                        row.Backcolor = ColorTranslator.ToHtml(BackColor)
                        row.CountryAssigningManufacturingCode = Country_Assigning_Manufacturer_Code
                        row.ImageWidth = Width
                        row.ImageHeight = Height

                        'get image in base 64
                        Using ms As New MemoryStream()
                            EncodedImage.Save(ms, ImageFormat)
                            row.Image = Convert.ToBase64String(ms.ToArray(), Base64FormattingOptions.None)
                        End Using
                        'using
                        xml.Barcode.AddBarcodeRow(row)

                        Dim sw As New StringWriter()
                        xml.WriteXml(sw, XmlWriteMode.WriteSchema)
                        Return sw.ToString()
                        'using
                    End Using
                    'try
                Catch ex As Exception
                    Throw New Exception("EGETXML-2: " + ex.Message)
                    'catch
                End Try
            End If
            'else
        End Function
        Public Shared Function GetImageFromXML(internalXML As BarcodeXML) As Image
            Try
                'converting the base64 string to byte array
                Dim imageContent As [Byte]() = New [Byte](internalXML.Barcode(0).Image.Length - 1) {}

                'loading it to memory stream and then to image object
                Using ms As New MemoryStream(Convert.FromBase64String(internalXML.Barcode(0).Image))
                    Return Image.FromStream(ms)
                    'using
                End Using
                'try
            Catch ex As Exception
                Throw New Exception("EGETIMAGEFROMXML-1: " + ex.Message)
            End Try
            'catch
        End Function
#End Region

#Region "Static Methods"
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="Data">Raw data to encode.</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Shared Function DoEncode(iType As TYPE, Data As String) As Image
            Using b As New Barcode()
                Return b.Encode(iType, Data)
            End Using
            'using
        End Function
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="Data">Raw data to encode.</param>
        ''' <param name="XML">XML representation of the data and the image of the barcode.</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Shared Function DoEncode(iType As TYPE, Data As String, ByRef XML As String) As Image
            Using b As New Barcode()
                Dim i As Image = b.Encode(iType, Data)
                XML = b.XML
                Return i
            End Using
            'using
        End Function
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="Data">Raw data to encode.</param>
        ''' <param name="IncludeLabel">Include the label at the bottom of the image with data encoded.</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Shared Function DoEncode(iType As TYPE, Data As String, IncludeLabel As Boolean) As Image
            Using b As New Barcode()
                b.IncludeLabel = IncludeLabel
                Return b.Encode(iType, Data)
            End Using
            'using
        End Function
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="data">Raw data to encode.</param>
        ''' <param name="IncludeLabel">Include the label at the bottom of the image with data encoded.</param>
        ''' <param name="Width">Width of the resulting barcode.(pixels)</param>
        ''' <param name="Height">Height of the resulting barcode.(pixels)</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Shared Function DoEncode(iType As TYPE, Data As String, IncludeLabel As Boolean, Width As Integer, Height As Integer) As Image
            Using b As New Barcode()
                b.IncludeLabel = IncludeLabel
                Return b.Encode(iType, Data, Width, Height)
            End Using
            'using
        End Function
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="Data">Raw data to encode.</param>
        ''' <param name="IncludeLabel">Include the label at the bottom of the image with data encoded.</param>
        ''' <param name="DrawColor">Foreground color</param>
        ''' <param name="BackColor">Background color</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Shared Function DoEncode(iType As TYPE, Data As String, IncludeLabel As Boolean, DrawColor As Color, BackColor As Color) As Image
            Using b As New Barcode()
                b.IncludeLabel = IncludeLabel
                Return b.Encode(iType, Data, DrawColor, BackColor)
            End Using
            'using
        End Function
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="Data">Raw data to encode.</param>
        ''' <param name="IncludeLabel">Include the label at the bottom of the image with data encoded.</param>
        ''' <param name="DrawColor">Foreground color</param>
        ''' <param name="BackColor">Background color</param>
        ''' <param name="Width">Width of the resulting barcode.(pixels)</param>
        ''' <param name="Height">Height of the resulting barcode.(pixels)</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Shared Function DoEncode(iType As TYPE, Data As String, IncludeLabel As Boolean, DrawColor As Color, BackColor As Color, Width As Integer,
            Height As Integer) As Image
            Using b As New Barcode()
                b.IncludeLabel = IncludeLabel
                Return b.Encode(iType, Data, DrawColor, BackColor, Width, Height)
            End Using
            'using
        End Function
        ''' <summary>
        ''' Encodes the raw data into binary form representing bars and spaces.  Also generates an Image of the barcode.
        ''' </summary>
        ''' <param name="iType">Type of encoding to use.</param>
        ''' <param name="Data">Raw data to encode.</param>
        ''' <param name="IncludeLabel">Include the label at the bottom of the image with data encoded.</param>
        ''' <param name="DrawColor">Foreground color</param>
        ''' <param name="BackColor">Background color</param>
        ''' <param name="Width">Width of the resulting barcode.(pixels)</param>
        ''' <param name="Height">Height of the resulting barcode.(pixels)</param>
        ''' <param name="XML">XML representation of the data and the image of the barcode.</param>
        ''' <returns>Image representing the barcode.</returns>
        Public Shared Function DoEncode(iType As TYPE, Data As String, IncludeLabel As Boolean, DrawColor As Color, BackColor As Color, Width As Integer,
            Height As Integer, ByRef XML As String) As Image
            Using b As New Barcode()
                b.IncludeLabel = IncludeLabel
                Dim i As Image = b.Encode(iType, Data, DrawColor, BackColor, Width, Height)
                XML = b.XML
                Return i
            End Using
            'using
        End Function
#End Region

#Region "IDisposable Members"

        Public Sub Dispose()
            Try
                'try
            Catch ex As Exception
                Throw New Exception("EDISPOSE-1: " + ex.Message)
            End Try
            'catch
        End Sub

        Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
            DirectCast(_Encoded_Image, IDisposable).Dispose()
        End Sub

#End Region
    End Class
    'Barcode Class
End Namespace
'Barcode namespace

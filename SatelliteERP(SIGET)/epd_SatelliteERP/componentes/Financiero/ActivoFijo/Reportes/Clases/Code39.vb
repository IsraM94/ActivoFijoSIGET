
Imports System.Collections.Generic
Imports System.Text

Namespace BarcodeLib
    Class Code39
        Inherits BarcodeCommon

        Private C39_Code As New System.Collections.Hashtable()
        'is initialized by init_Code39()
        Private ExtC39_Translation As New System.Collections.Hashtable()
        Private _AllowExtended As Boolean = False

        ''' <summary>
        ''' Encodes with Code39.
        ''' </summary>
        ''' <param name="input">Data to encode.</param>
        Public Sub New(input As String)
            Raw_Data = input
        End Sub
        'Code39
        ''' <summary>
        ''' Encodes with Code39.
        ''' </summary>
        ''' <param name="input">Data to encode.</param>
        ''' <param name="AllowExtended">Allow Extended Code 39 (Full Ascii mode).</param>
        Public Sub New(input As String, AllowExtended As Boolean)
            Raw_Data = input
            _AllowExtended = AllowExtended
        End Sub

        ''' <summary>
        ''' Encode the raw data using the Code 39 algorithm.
        ''' </summary>
        Private Function Encode_Code39() As String
            Me.init_Code39()
            Me.init_ExtendedCode39()

            Dim strFormattedData As String = "*" + Raw_Data.Replace("*", "") + "*"

            If _AllowExtended Then
                InsertExtendedCharsIfNeeded(strFormattedData)
            End If

            Me.FormattedData = strFormattedData

            Dim result As String = ""
            For Each c As Char In Me.FormattedData
                Try
                    result += C39_Code(c).ToString()
                    'whitespace
                    result += "0"
                    'try
                Catch
                    If _AllowExtended Then
                        Throw New Exception("EC39-1: Invalid data.")
                    Else
                        Throw New Exception("EC39-1: Invalid data. (Try using Extended Code39)")
                    End If
                    'catch
                End Try
            Next
            'foreach
            result = result.Substring(0, result.Length - 1)

            'clear the hashtable so it no longer takes up memory
            Me.C39_Code.Clear()

            Return result
        End Function
        'Encode_Code39
        Private Sub init_Code39()
            C39_Code.Clear()
            C39_Code.Add("0"c, "101001101101")
            C39_Code.Add("1"c, "110100101011")
            C39_Code.Add("2"c, "101100101011")
            C39_Code.Add("3"c, "110110010101")
            C39_Code.Add("4"c, "101001101011")
            C39_Code.Add("5"c, "110100110101")
            C39_Code.Add("6"c, "101100110101")
            C39_Code.Add("7"c, "101001011011")
            C39_Code.Add("8"c, "110100101101")
            C39_Code.Add("9"c, "101100101101")
            C39_Code.Add("A"c, "110101001011")
            C39_Code.Add("B"c, "101101001011")
            C39_Code.Add("C"c, "110110100101")
            C39_Code.Add("D"c, "101011001011")
            C39_Code.Add("E"c, "110101100101")
            C39_Code.Add("F"c, "101101100101")
            C39_Code.Add("G"c, "101010011011")
            C39_Code.Add("H"c, "110101001101")
            C39_Code.Add("I"c, "101101001101")
            C39_Code.Add("J"c, "101011001101")
            C39_Code.Add("K"c, "110101010011")
            C39_Code.Add("L"c, "101101010011")
            C39_Code.Add("M"c, "110110101001")
            C39_Code.Add("N"c, "101011010011")
            C39_Code.Add("O"c, "110101101001")
            C39_Code.Add("P"c, "101101101001")
            C39_Code.Add("Q"c, "101010110011")
            C39_Code.Add("R"c, "110101011001")
            C39_Code.Add("S"c, "101101011001")
            C39_Code.Add("T"c, "101011011001")
            C39_Code.Add("U"c, "110010101011")
            C39_Code.Add("V"c, "100110101011")
            C39_Code.Add("W"c, "110011010101")
            C39_Code.Add("X"c, "100101101011")
            C39_Code.Add("Y"c, "110010110101")
            C39_Code.Add("Z"c, "100110110101")
            C39_Code.Add("-"c, "100101011011")
            C39_Code.Add("."c, "110010101101")
            C39_Code.Add(" "c, "100110101101")
            C39_Code.Add("$"c, "100100100101")
            C39_Code.Add("/"c, "100100101001")
            C39_Code.Add("+"c, "100101001001")
            C39_Code.Add("%"c, "101001001001")
            C39_Code.Add("*"c, "100101101101")
        End Sub
        'init_Code39
        Private Sub init_ExtendedCode39()
            ExtC39_Translation.Clear()
            ExtC39_Translation.Add(Convert.ToChar(0).ToString(), "%U")
            ExtC39_Translation.Add(Convert.ToChar(1).ToString(), "$A")
            ExtC39_Translation.Add(Convert.ToChar(2).ToString(), "$B")
            ExtC39_Translation.Add(Convert.ToChar(3).ToString(), "$C")
            ExtC39_Translation.Add(Convert.ToChar(4).ToString(), "$D")
            ExtC39_Translation.Add(Convert.ToChar(5).ToString(), "$E")
            ExtC39_Translation.Add(Convert.ToChar(6).ToString(), "$F")
            ExtC39_Translation.Add(Convert.ToChar(7).ToString(), "$G")
            ExtC39_Translation.Add(Convert.ToChar(8).ToString(), "$H")
            ExtC39_Translation.Add(Convert.ToChar(9).ToString(), "$I")
            ExtC39_Translation.Add(Convert.ToChar(10).ToString(), "$J")
            ExtC39_Translation.Add(Convert.ToChar(11).ToString(), "$K")
            ExtC39_Translation.Add(Convert.ToChar(12).ToString(), "$L")
            ExtC39_Translation.Add(Convert.ToChar(13).ToString(), "$M")
            ExtC39_Translation.Add(Convert.ToChar(14).ToString(), "$N")
            ExtC39_Translation.Add(Convert.ToChar(15).ToString(), "$O")
            ExtC39_Translation.Add(Convert.ToChar(16).ToString(), "$P")
            ExtC39_Translation.Add(Convert.ToChar(17).ToString(), "$Q")
            ExtC39_Translation.Add(Convert.ToChar(18).ToString(), "$R")
            ExtC39_Translation.Add(Convert.ToChar(19).ToString(), "$S")
            ExtC39_Translation.Add(Convert.ToChar(20).ToString(), "$T")
            ExtC39_Translation.Add(Convert.ToChar(21).ToString(), "$U")
            ExtC39_Translation.Add(Convert.ToChar(22).ToString(), "$V")
            ExtC39_Translation.Add(Convert.ToChar(23).ToString(), "$W")
            ExtC39_Translation.Add(Convert.ToChar(24).ToString(), "$X")
            ExtC39_Translation.Add(Convert.ToChar(25).ToString(), "$Y")
            ExtC39_Translation.Add(Convert.ToChar(26).ToString(), "$Z")
            ExtC39_Translation.Add(Convert.ToChar(27).ToString(), "%A")
            ExtC39_Translation.Add(Convert.ToChar(28).ToString(), "%B")
            ExtC39_Translation.Add(Convert.ToChar(29).ToString(), "%C")
            ExtC39_Translation.Add(Convert.ToChar(30).ToString(), "%D")
            ExtC39_Translation.Add(Convert.ToChar(31).ToString(), "%E")
            ExtC39_Translation.Add("!", "/A")
            ExtC39_Translation.Add("""", "/B")
            ExtC39_Translation.Add("#", "/C")
            ExtC39_Translation.Add("$", "/D")
            ExtC39_Translation.Add("%", "/E")
            ExtC39_Translation.Add("&", "/F")
            ExtC39_Translation.Add("'", "/G")
            ExtC39_Translation.Add("(", "/H")
            ExtC39_Translation.Add(")", "/I")
            ExtC39_Translation.Add("*", "/J")
            ExtC39_Translation.Add("+", "/K")
            ExtC39_Translation.Add(",", "/L")
            ExtC39_Translation.Add("/", "/O")
            ExtC39_Translation.Add(":", "/Z")
            ExtC39_Translation.Add(";", "%F")
            ExtC39_Translation.Add("<", "%G")
            ExtC39_Translation.Add("=", "%H")
            ExtC39_Translation.Add(">", "%I")
            ExtC39_Translation.Add("?", "%J")
            ExtC39_Translation.Add("[", "%K")
            ExtC39_Translation.Add("\", "%L")
            ExtC39_Translation.Add("]", "%M")
            ExtC39_Translation.Add("^", "%N")
            ExtC39_Translation.Add("_", "%O")
            ExtC39_Translation.Add("{", "%P")
            ExtC39_Translation.Add("|", "%Q")
            ExtC39_Translation.Add("}", "%R")
            ExtC39_Translation.Add("~", "%S")
            ExtC39_Translation.Add("`", "%W")
            ExtC39_Translation.Add("@", "%V")
            ExtC39_Translation.Add("a", "+A")
            ExtC39_Translation.Add("b", "+B")
            ExtC39_Translation.Add("c", "+C")
            ExtC39_Translation.Add("d", "+D")
            ExtC39_Translation.Add("e", "+E")
            ExtC39_Translation.Add("f", "+F")
            ExtC39_Translation.Add("g", "+G")
            ExtC39_Translation.Add("h", "+H")
            ExtC39_Translation.Add("i", "+I")
            ExtC39_Translation.Add("j", "+J")
            ExtC39_Translation.Add("k", "+K")
            ExtC39_Translation.Add("l", "+L")
            ExtC39_Translation.Add("m", "+M")
            ExtC39_Translation.Add("n", "+N")
            ExtC39_Translation.Add("o", "+O")
            ExtC39_Translation.Add("p", "+P")
            ExtC39_Translation.Add("q", "+Q")
            ExtC39_Translation.Add("r", "+R")
            ExtC39_Translation.Add("s", "+S")
            ExtC39_Translation.Add("t", "+T")
            ExtC39_Translation.Add("u", "+U")
            ExtC39_Translation.Add("v", "+V")
            ExtC39_Translation.Add("w", "+W")
            ExtC39_Translation.Add("x", "+X")
            ExtC39_Translation.Add("y", "+Y")
            ExtC39_Translation.Add("z", "+Z")
            ExtC39_Translation.Add(Convert.ToChar(127).ToString(), "%T")
            'also %X, %Y, %Z 
        End Sub
        Private Sub InsertExtendedCharsIfNeeded(ByRef FormattedData As String)
            Dim output As String = ""
            For Each c As Char In Raw_Data
                Try
                    Dim s As String = C39_Code(c).ToString()
                    output += c
                    'try
                Catch
                    'insert extended substitution
                    Dim oTrans As Object = ExtC39_Translation(c.ToString())
                    output += oTrans.ToString()
                    'catch
                End Try
            Next
            'foreach
            FormattedData = output
        End Sub

#Region "IBarcode Members"

        Public ReadOnly Property Encoded_Value() As String
            Get
                Return Encode_Code39()
            End Get
        End Property

        'Private ReadOnly Property IBarcode_Encoded_Value As String Implements IBarcode.Encoded_Value
        '    Get
        '        Throw New NotImplementedException()
        '    End Get
        'End Property

        'Private ReadOnly Property IBarcode_RawData As String Implements IBarcode.RawData
        '    Get
        '        Throw New NotImplementedException()
        '    End Get
        'End Property

        'Private ReadOnly Property IBarcode_FormattedData As String Implements IBarcode.FormattedData
        '    Get
        '        Throw New NotImplementedException()
        '    End Get
        'End Property

#End Region
    End Class
    'class
End Namespace
'namespace


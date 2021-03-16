Imports System.Collections.Generic
Imports System.Text

Namespace BarcodeLib
    MustInherit Class BarcodeCommon
        Protected Raw_Data As String = ""
        Protected Formatted_Data As String = ""

        Public ReadOnly Property RawData() As String
            Get
                Return Me.Raw_Data
            End Get
        End Property

        Public Property FormattedData() As String
            Get
                Return Me.Formatted_Data
            End Get
            Set
                Me.Formatted_Data = Value
            End Set
        End Property
    End Class
    'BarcodeVariables abstract class
End Namespace
'namespace
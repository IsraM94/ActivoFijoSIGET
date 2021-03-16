Imports System.Collections.Generic
Imports System.Text

Namespace BarcodeLib
    Interface IBarcode
        ReadOnly Property Encoded_Value() As String
        'Encoded_Value
        ReadOnly Property RawData() As String
        'Raw_Data
        ReadOnly Property FormattedData() As String
        'FormattedData
    End Interface
    'interface
End Namespace
'namespace

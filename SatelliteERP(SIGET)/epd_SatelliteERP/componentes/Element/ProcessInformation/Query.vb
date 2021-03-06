Public Class Query : Implements IDisposable


    Public Function QueryInsert(ByVal Table As String, ByVal Columns As String, ByVal Values As String) As String
        Dim Query As String = ""
        Query = "Insert into " & Table & " (" & Columns.Substring(0, Columns.Length - 1) & ") values (" & Values.Substring(0, Values.Length - 1) & ")"
        Return Query
    End Function

    Public Function QueryAddColumn(ByVal Table As String, ByVal Columns As String, ByVal Length As Integer) As String
        Dim Query As String = ""
        Query = " ALTER TABLE " & Table & " add " & Columns & "  VARCHAR(" & Length & ");"
        Return Query
    End Function


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

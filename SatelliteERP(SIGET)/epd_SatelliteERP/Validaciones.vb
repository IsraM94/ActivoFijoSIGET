Imports System.Text.RegularExpressions

Public Class Validaciones : Implements IDisposable

    Public Function JustLetters(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim Respuesta As Boolean = True
        If Char.IsLetter(e.KeyChar) Then
            Respuesta = False
        ElseIf Char.IsControl(e.KeyChar) Then
            Respuesta = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            Respuesta = False
        Else
            Respuesta = True
        End If
        Return Respuesta
    End Function
    Public Function ValidatePhone(ByVal Phone As String) As Boolean
        Dim rgx As New Regex("^\(?([2,7]{1})\)?\(?([0-9]{3})\)?[-. ]?([0-9]{4})$")
        If Not Phone = "" Then
            If Not rgx.IsMatch(Phone) Then
                Return False
            End If
        End If
        Return True
    End Function
    Public Function ValidateEmail(ByVal Email As String) As Boolean
        Dim rgx As New Regex("^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$")
        If Not Email = "" Then
            If Not rgx.IsMatch(Email) Then
                Return False
            End If
        End If
        Return True
    End Function
    Public Function ValidateDUI(ByVal DUI As String) As Boolean
        Dim rgx As New Regex("\d{8}-\d{1}")
        If Not DUI = "" Then
            If Not rgx.IsMatch(DUI) Then
                Return False
            End If
        End If
        Return True
    End Function
    Public Function ValidateNIT(ByVal NIT As String) As Boolean
        Dim rgx As New Regex("\d{4}-\d{6}-\d{3}-\d{1}")
        If Not NIT = "" Then
            If Not rgx.IsMatch(NIT) Then
                Return False
            End If
        End If
        Return True
    End Function

    Public Function ValidateNumberShares(ByVal NumberShares As String) As Boolean
        Dim rgx As New Regex("[^d{4} - a-zA-Z]")
        If Not NumberShares = "" Then
            If Not rgx.IsMatch(NumberShares) Then
                Return False
            End If
        End If
        Return True
    End Function
    Public Function ValidateTelephone(ByVal Telephone As String) As Boolean
        Dim rgx As New Regex("\d{4}-\d{4}")
        If Not Telephone = "" Then
            If Not rgx.IsMatch(Telephone) Then
                Return False
            End If
        End If
        Return True
    End Function
    Public Function JustLettersAndPunctuation(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim Respuesta As Boolean = True
        If Char.IsLetter(e.KeyChar) Or (e.KeyChar) Like "[,]" Or (e.KeyChar) Like "[.]" Or (e.KeyChar) Like "[:]" Or (e.KeyChar) Like "[;]" Then
            Respuesta = False
        ElseIf Char.IsControl(e.KeyChar) Then
            Respuesta = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            Respuesta = False
        Else
            Respuesta = True
        End If
        Return Respuesta
    End Function
    Public Function JustSimbol(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim Respuesta As Boolean = True
        If Char.IsLetter(e.KeyChar) Like "[+]" Or (e.KeyChar) Like "[-]" Or (e.KeyChar) Like "[+]" Then
            Respuesta = False
        ElseIf Char.IsControl(e.KeyChar) Then
            Respuesta = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            Respuesta = False
        Else
            Respuesta = True
        End If
        Return Respuesta
    End Function
    Public Function JustLetterAndComa(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim Respuesta As Boolean = True
        If Char.IsLetter(e.KeyChar) Or (e.KeyChar) Like "[,]" Then
            Respuesta = False
        ElseIf Char.IsControl(e.KeyChar) Then
            Respuesta = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            Respuesta = False
        Else
            Respuesta = True
        End If
        Return Respuesta
    End Function

    Public Function JustNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim Respuesta As Boolean = True
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            Respuesta = False
        ElseIf Char.IsControl(e.KeyChar) Then
            Respuesta = False
        Else
            Respuesta = True
        End If
        Return Respuesta
    End Function
	Public Function JustNumbersAndPoint(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
		Dim Respuesta As Boolean = True
		If Char.IsDigit(e.KeyChar) Or (e.KeyChar) Like "[.]" Then
			Respuesta = False
		ElseIf Char.IsControl(e.KeyChar) Then
			Respuesta = False
		Else
			Respuesta = True
		End If
		Return Respuesta
	End Function

	Public Function JustNumbersAndGuion(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
		Dim Respuesta As Boolean = True
		If Char.IsDigit(e.KeyChar) Or (e.KeyChar) Like "[-]" Then
			Respuesta = False
		ElseIf Char.IsControl(e.KeyChar) Then
			Respuesta = False
		Else
			Respuesta = True
		End If
		Return Respuesta
	End Function

	Public Function Money(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim Respuesta As Boolean = True
        If Char.IsDigit(e.KeyChar) Or (e.KeyChar) Like "[.]" Then
            Respuesta = False
        ElseIf Char.IsControl(e.KeyChar) Then
            Respuesta = False
        Else
            Respuesta = True
        End If
        Return Respuesta
    End Function
#Region "Validaciones"
    Public Function Validar_Money(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal Control As TextBox) As Boolean
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Control.Text.Contains(".") Then
					If Control.Text.Split(".")(1).Length < 4 Then
						If Char.IsDigit(e.KeyChar) = False Then
							e.Handled = True
						End If
					Else
						e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
        Return e.Handled
    End Function
#End Region
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
Module ModuloValidaciones

    Public Function EsRFCValido(rfc As String) As Boolean

        If String.IsNullOrWhiteSpace(rfc) Then
            Return False
        End If

        If rfc.Length <> 13 Then
            Return False
        End If

        If rfc <> rfc.ToUpper() Then
            Return False
        End If

        Return True

    End Function

    Public Function EsNombreValido(nombre As String) As Boolean

        If String.IsNullOrWhiteSpace(nombre) Then
            Return False
        End If

        If nombre.Length > 60 Then
            Return False
        End If

        For Each c As Char In nombre
            If Char.IsDigit(c) Then
                Return False
            End If
        Next

        Return True

    End Function

    Public Function EsSalarioValido(salario As Decimal) As Boolean

        Return salario > 0 And salario <= 500000

    End Function

    Public Function EsTurnoValido(turno As String) As Boolean

        Return turno = "Matutino" OrElse
               turno = "Vespertino" OrElse
               turno = "Nocturno"

    End Function

    Public Function EsBonoValido(pct As Integer) As Boolean

        Return pct >= 5 And pct <= 40

    End Function

    Public Function FormatearMoneda(valor As Decimal) As String

        Return valor.ToString("C2")

    End Function

End Module
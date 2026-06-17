Public Class Gerente
    Inherits Empleado

    Private _bono As Decimal
    Private _personasACargo As Integer

    Public Sub New(nombre As String,
                   apellido As String,
                   rfc As String,
                   salarioBase As Decimal,
                   bono As Decimal,
                   personasACargo As Integer)

        MyBase.New(nombre, apellido, rfc, salarioBase)

        Me.Bono = bono
        Me.PersonasACargo = personasACargo

    End Sub

    Public Property Bono As Decimal
        Get
            Return _bono
        End Get
        Set(value As Decimal)

            If value < 0 Then
                Throw New Exception("El bono no puede ser negativo.")
            End If

            _bono = value

        End Set
    End Property

    Public Property PersonasACargo As Integer
        Get
            Return _personasACargo
        End Get
        Set(value As Integer)

            If value < 0 Then
                Throw New Exception("Las personas a cargo no pueden ser negativas.")
            End If

            _personasACargo = value

        End Set
    End Property

    Public Overrides Function CalcularPagoMensual() As Decimal

        Return SalarioBase + Bono

    End Function

    Public Overrides Function ObtenerFicha() As String

        Return MyBase.ObtenerFicha() &
               vbCrLf & "Tipo: Gerente" &
               vbCrLf & "Bono: " &
               ModuloValidaciones.FormatearMoneda(Bono) &
               vbCrLf & "Personas a Cargo: " &
               PersonasACargo &
               vbCrLf & "Pago Mensual: " &
               ModuloValidaciones.FormatearMoneda(CalcularPagoMensual())

    End Function

End Class

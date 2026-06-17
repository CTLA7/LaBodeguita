Public MustInherit Class Empleado

    Private _nombre As String
    Private _apellido As String
    Private _rfc As String
    Private _salarioBase As Decimal

    Public Sub New(nombre As String,
                   apellido As String,
                   rfc As String,
                   salarioBase As Decimal)

        _nombre = nombre
        _apellido = apellido
        _rfc = rfc
        _salarioBase = salarioBase

    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property RFC As String
        Get
            Return _rfc
        End Get
        Set(value As String)
            _rfc = value
        End Set
    End Property

    Public Property SalarioBase As Decimal
        Get
            Return _salarioBase
        End Get
        Set(value As Decimal)
            _salarioBase = value
        End Set
    End Property

    Public ReadOnly Property Id As String
        Get
            Return RFC
        End Get
    End Property

    Public MustOverride Function CalcularPagoMensual() As Decimal

    Public Overridable Function ObtenerFicha() As String

        Return "Nombre: " & Nombre &
               vbCrLf & "Apellido: " & Apellido &
               vbCrLf & "RFC: " & RFC &
               vbCrLf & "Salario Base: " &
               ModuloValidaciones.FormatearMoneda(SalarioBase)

    End Function

End Class

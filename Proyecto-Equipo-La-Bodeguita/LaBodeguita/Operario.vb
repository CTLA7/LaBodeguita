Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Operario
    Inherits Empleado

    Private _turno As String
    Private _horasExtra As Integer

    Public Sub New(nombre As String, apellido As String, rfc As String, salarioBase As Decimal, turno As String, horasExtra As Integer)
        MyBase.New(nombre, apellido, rfc, salarioBase)

        Me.Turno = turno
        Me.HorasExtra = horasExtra
    End Sub

    Public Property Turno As String
        Get
            Return _turno
        End Get
        Set(value As String)
            If value = "Matutino" OrElse value = "Vespertino" OrElse value = "Nocturno" Then
                _turno = value
            Else
                Throw New Exception("Turno inválido")
            End If
        End Set
    End Property

    Public Property HorasExtra As Integer
        Get
            Return _horasExtra
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _horasExtra = value
            Else
                Throw New Exception("Horas extra no pueden ser negativas")
            End If
        End Set
    End Property

    Public Overrides Function CalcularPagoMensual() As Decimal
        Return SalarioBase + (_horasExtra * 100D)
    End Function

    Public Overrides Function ObtenerFicha() As String
        Return "OPERARIO: " & Nombre & " " & Apellido &
               " | RFC: " & Me.RFC &
               " | Salario: " & SalarioBase.ToString("C") &
               " | Turno: " & _turno &
               " | Horas Extra: " & _horasExtra &
               " | Pago Mensual: " & CalcularPagoMensual().ToString("C")
    End Function
End Class
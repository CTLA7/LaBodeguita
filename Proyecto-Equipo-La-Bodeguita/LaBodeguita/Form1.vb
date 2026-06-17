Public Class Form1

    Private empleados As New List(Of Empleado)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvEmpleados.Columns.Clear()

        dgvEmpleados.Columns.Add("Nombre", "Nombre")
        dgvEmpleados.Columns.Add("RFC", "RFC")
        dgvEmpleados.Columns.Add("Tipo", "Tipo")
        dgvEmpleados.Columns.Add("Pago", "Pago Mensual")

        lblTotalEmpleados.Text = "Total Empleados: 0"
        lblTotalNomina.Text = "Nómina Total: $0.00"

    End Sub

    Private Sub ActualizarTotales()

        lblTotalEmpleados.Text = "Total Empleados: " & empleados.Count

        Dim totalNomina As Decimal = 0

        For Each emp As Empleado In empleados
            totalNomina += emp.CalcularPagoMensual()
        Next

        lblTotalNomina.Text = "Nómina Total: " & totalNomina.ToString("C")

    End Sub

    Private Sub btnAgregarGerente_Click(sender As Object, e As EventArgs) Handles btnAgregarGerente.Click

        ' Abrir el formulario de detalle para crear un gerente
        Using f As New FormDetalle()
            Dim res = f.ShowDialog()
            If res = DialogResult.OK AndAlso f.EmpleadoCreado IsNot Nothing Then
                Dim g As Empleado = f.EmpleadoCreado
                empleados.Add(g)

                dgvEmpleados.Rows.Add(
                    g.Nombre,
                    g.RFC,
                    "Gerente",
                    g.CalcularPagoMensual())

                ActualizarTotales()
            End If
        End Using

    End Sub

    Private Sub btnAgregarOperario_Click(sender As Object, e As EventArgs) Handles btnAgregarOperario.Click

        ' Abrir el formulario de operario para crear un operario
        Using f As New FormOperario()
            Dim res = f.ShowDialog()
            If res = DialogResult.OK AndAlso f.EmpleadoCreado IsNot Nothing Then
                Dim o As Operario = f.EmpleadoCreado
                empleados.Add(o)

                dgvEmpleados.Rows.Add(
                    o.Nombre,
                    o.RFC,
                    "Operario",
                    o.CalcularPagoMensual())

                ActualizarTotales()
            End If
        End Using

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If dgvEmpleados.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un empleado.")
            Return
        End If

        Dim indice As Integer = dgvEmpleados.SelectedRows(0).Index

        empleados.RemoveAt(indice)
        dgvEmpleados.Rows.RemoveAt(indice)

        ActualizarTotales()

    End Sub

    Private Sub btnVerDetalle_Click(sender As Object, e As EventArgs) Handles btnVerDetalle.Click

        If dgvEmpleados.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un empleado.")
            Return
        End If

        Dim indice As Integer = dgvEmpleados.SelectedRows(0).Index

        MessageBox.Show(empleados(indice).ObtenerFicha(), "Detalle del Empleado")

    End Sub

End Class
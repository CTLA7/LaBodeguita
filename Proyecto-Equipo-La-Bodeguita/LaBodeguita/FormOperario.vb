Public Class FormOperario

    ' Propiedad que expondrá el operario creado al formulario llamador
    Public Property EmpleadoCreado As Operario

    Private Sub FormOperario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTurno.Items.Add("Matutino")
        cmbTurno.Items.Add("Vespertino")
        cmbTurno.Items.Add("Nocturno")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim nombre As String = txtNombre.Text
            Dim apellido As String = txtApellido.Text
            Dim id As String = txtId.Text
            Dim salario As Decimal = Decimal.Parse(txtSalario.Text)

            If cmbTurno.SelectedItem Is Nothing Then
                MessageBox.Show("Seleccione un turno.")
                Return
            End If

            Dim turno As String = cmbTurno.SelectedItem.ToString()
            Dim horasExtra As Integer = Integer.Parse(txtHorasExtra.Text)

            EmpleadoCreado = New Operario(
                nombre,
                apellido,
                id,
                salario,
                turno,
                horasExtra
            )

            lblResultado.Text = EmpleadoCreado.ObtenerFicha()

            ' Establecer resultado OK para que el formulario llamador pueda obtener el objeto
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtApellido.Clear()
        txtId.Clear()
        txtSalario.Clear()
        txtHorasExtra.Clear()

        cmbTurno.SelectedIndex = -1

        lblResultado.Text = ""
    End Sub

End Class

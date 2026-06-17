Public Class FormDetalle

    Public Property EmpleadoCreado As Empleado

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            EmpleadoCreado = New Gerente(
                txtNombre.Text,
                txtApellido.Text,
                txtRFC.Text,
                Decimal.Parse(txtSalario.Text),
                Decimal.Parse(txtBono.Text),
                Integer.Parse(txtPersonasCargo.Text))

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class
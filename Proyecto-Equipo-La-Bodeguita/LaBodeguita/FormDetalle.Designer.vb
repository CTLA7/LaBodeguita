<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtRFC = New TextBox()
        txtSalario = New TextBox()
        txtBono = New TextBox()
        txtPersonasCargo = New TextBox()
        txtHorasExtra = New TextBox()
        cmbTurno = New ComboBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 2
        Label3.Text = "RFC"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 3
        Label4.Text = "Salario Base"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 4
        Label5.Text = "Bono"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 15)
        Label6.TabIndex = 5
        Label6.Text = "Personas a Cargo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(43, 309)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 6
        Label7.Text = "Turno"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(43, 278)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 15)
        Label8.TabIndex = 7
        Label8.Text = "Horas Extra"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(241, 61)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(180, 23)
        txtNombre.TabIndex = 8
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(241, 95)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(180, 23)
        txtApellido.TabIndex = 9
        ' 
        ' txtRFC
        ' 
        txtRFC.Location = New Point(241, 135)
        txtRFC.Name = "txtRFC"
        txtRFC.Size = New Size(177, 23)
        txtRFC.TabIndex = 10
        ' 
        ' txtSalario
        ' 
        txtSalario.Location = New Point(241, 174)
        txtSalario.Name = "txtSalario"
        txtSalario.Size = New Size(177, 23)
        txtSalario.TabIndex = 11
        ' 
        ' txtBono
        ' 
        txtBono.Location = New Point(241, 208)
        txtBono.Name = "txtBono"
        txtBono.Size = New Size(177, 23)
        txtBono.TabIndex = 12
        ' 
        ' txtPersonasCargo
        ' 
        txtPersonasCargo.Location = New Point(241, 238)
        txtPersonasCargo.Name = "txtPersonasCargo"
        txtPersonasCargo.Size = New Size(177, 23)
        txtPersonasCargo.TabIndex = 13
        ' 
        ' txtHorasExtra
        ' 
        txtHorasExtra.Location = New Point(241, 270)
        txtHorasExtra.Name = "txtHorasExtra"
        txtHorasExtra.Size = New Size(177, 23)
        txtHorasExtra.TabIndex = 15
        ' 
        ' cmbTurno
        ' 
        cmbTurno.FormattingEnabled = True
        cmbTurno.Items.AddRange(New Object() {"Matutino", "", "Vespertino", "", "Nocturno"})
        cmbTurno.Location = New Point(241, 309)
        cmbTurno.Name = "cmbTurno"
        cmbTurno.Size = New Size(180, 23)
        cmbTurno.TabIndex = 16
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(98, 370)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 17
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(294, 373)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 18
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FormDetalle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(877, 450)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(cmbTurno)
        Controls.Add(txtHorasExtra)
        Controls.Add(txtPersonasCargo)
        Controls.Add(txtBono)
        Controls.Add(txtSalario)
        Controls.Add(txtRFC)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormDetalle"
        Text = "FormDetalle"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents txtBono As TextBox
    Friend WithEvents txtPersonasCargo As TextBox
    Friend WithEvents txtHorasExtra As TextBox
    Friend WithEvents cmbTurno As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class

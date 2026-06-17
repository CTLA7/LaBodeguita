<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOperario
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
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtId = New TextBox()
        txtSalario = New TextBox()
        txtHorasExtra = New TextBox()
        cmbTurno = New ComboBox()
        btnGuardar = New Button()
        btnLimpiar = New Button()
        lblResultado = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(196, 50)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(175, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(196, 95)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(175, 23)
        txtApellido.TabIndex = 1
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(196, 138)
        txtId.Name = "txtId"
        txtId.Size = New Size(175, 23)
        txtId.TabIndex = 2
        ' 
        ' txtSalario
        ' 
        txtSalario.Location = New Point(196, 180)
        txtSalario.Name = "txtSalario"
        txtSalario.Size = New Size(175, 23)
        txtSalario.TabIndex = 3
        ' 
        ' txtHorasExtra
        ' 
        txtHorasExtra.Location = New Point(196, 218)
        txtHorasExtra.Name = "txtHorasExtra"
        txtHorasExtra.Size = New Size(175, 23)
        txtHorasExtra.TabIndex = 4
        ' 
        ' cmbTurno
        ' 
        cmbTurno.FormattingEnabled = True
        cmbTurno.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno"})
        cmbTurno.Location = New Point(196, 268)
        cmbTurno.Name = "cmbTurno"
        cmbTurno.Size = New Size(175, 23)
        cmbTurno.TabIndex = 5
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(481, 50)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(105, 37)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(481, 94)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(105, 37)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(514, 168)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(41, 15)
        lblResultado.TabIndex = 8
        lblResultado.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(114, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(88, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 10
        Label2.Text = "nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(88, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 11
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(88, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(18, 15)
        Label4.TabIndex = 12
        Label4.Text = "ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(84, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 13
        Label5.Text = "Salario"
        Label5.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(88, 276)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 14
        Label6.Text = "Turno"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(84, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 15
        Label7.Text = "Horas extras"
        ' 
        ' FormOperario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(875, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblResultado)
        Controls.Add(btnLimpiar)
        Controls.Add(btnGuardar)
        Controls.Add(cmbTurno)
        Controls.Add(txtHorasExtra)
        Controls.Add(txtSalario)
        Controls.Add(txtId)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Name = "FormOperario"
        Text = "FormOperario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents txtHorasExtra As TextBox
    Friend WithEvents cmbTurno As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

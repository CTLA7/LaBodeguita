<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAgregarGerente = New Button()
        btnAgregarOperario = New Button()
        btnEliminar = New Button()
        btnVerDetalle = New Button()
        dgvEmpleados = New DataGridView()
        lblTotalEmpleados = New Label()
        lblTotalNomina = New Label()
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAgregarGerente
        ' 
        btnAgregarGerente.Location = New Point(118, 65)
        btnAgregarGerente.Name = "btnAgregarGerente"
        btnAgregarGerente.Size = New Size(131, 23)
        btnAgregarGerente.TabIndex = 0
        btnAgregarGerente.Text = "btnAgregarGerente"
        btnAgregarGerente.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarOperario
        ' 
        btnAgregarOperario.Location = New Point(118, 122)
        btnAgregarOperario.Name = "btnAgregarOperario"
        btnAgregarOperario.Size = New Size(131, 23)
        btnAgregarOperario.TabIndex = 1
        btnAgregarOperario.Text = "btnAgregarOperario"
        btnAgregarOperario.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(118, 176)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(131, 23)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "btnEliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnVerDetalle
        ' 
        btnVerDetalle.Location = New Point(118, 229)
        btnVerDetalle.Name = "btnVerDetalle"
        btnVerDetalle.Size = New Size(131, 23)
        btnVerDetalle.TabIndex = 3
        btnVerDetalle.Text = "btnVerDetalle"
        btnVerDetalle.UseVisualStyleBackColor = True
        ' 
        ' dgvEmpleados
        ' 
        dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmpleados.Location = New Point(291, 246)
        dgvEmpleados.Name = "dgvEmpleados"
        dgvEmpleados.Size = New Size(240, 150)
        dgvEmpleados.TabIndex = 4
        ' 
        ' lblTotalEmpleados
        ' 
        lblTotalEmpleados.AutoSize = True
        lblTotalEmpleados.Location = New Point(304, 69)
        lblTotalEmpleados.Name = "lblTotalEmpleados"
        lblTotalEmpleados.Size = New Size(104, 15)
        lblTotalEmpleados.TabIndex = 5
        lblTotalEmpleados.Text = "lblTotalEmpleados"
        ' 
        ' lblTotalNomina
        ' 
        lblTotalNomina.AutoSize = True
        lblTotalNomina.Location = New Point(440, 69)
        lblTotalNomina.Name = "lblTotalNomina"
        lblTotalNomina.Size = New Size(89, 15)
        lblTotalNomina.TabIndex = 6
        lblTotalNomina.Text = "lblTotalNomina"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotalNomina)
        Controls.Add(lblTotalEmpleados)
        Controls.Add(dgvEmpleados)
        Controls.Add(btnVerDetalle)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregarOperario)
        Controls.Add(btnAgregarGerente)
        Name = "Form1"
        Text = "Form1"
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregarGerente As Button
    Friend WithEvents btnAgregarOperario As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVerDetalle As Button
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents lblTotalEmpleados As Label
    Friend WithEvents lblTotalNomina As Label

End Class

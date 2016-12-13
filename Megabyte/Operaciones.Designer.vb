<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_OPERACIONES
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
        Me.BTN_REGEQUIPO = New System.Windows.Forms.Button()
        Me.BTN_REGSERVICIO = New System.Windows.Forms.Button()
        Me.BTN_REGCLIENTES = New System.Windows.Forms.Button()
        Me.BTN_CONCLIENTES = New System.Windows.Forms.Button()
        Me.BTN_CONEQUIPO = New System.Windows.Forms.Button()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_REGEQUIPO
        '
        Me.BTN_REGEQUIPO.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGEQUIPO.Location = New System.Drawing.Point(37, 71)
        Me.BTN_REGEQUIPO.Name = "BTN_REGEQUIPO"
        Me.BTN_REGEQUIPO.Size = New System.Drawing.Size(114, 58)
        Me.BTN_REGEQUIPO.TabIndex = 0
        Me.BTN_REGEQUIPO.Text = "Registrar Equipo"
        Me.BTN_REGEQUIPO.UseVisualStyleBackColor = True
        '
        'BTN_REGSERVICIO
        '
        Me.BTN_REGSERVICIO.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGSERVICIO.Location = New System.Drawing.Point(178, 71)
        Me.BTN_REGSERVICIO.Name = "BTN_REGSERVICIO"
        Me.BTN_REGSERVICIO.Size = New System.Drawing.Size(114, 58)
        Me.BTN_REGSERVICIO.TabIndex = 1
        Me.BTN_REGSERVICIO.Text = "Registrar Servicio"
        Me.BTN_REGSERVICIO.UseVisualStyleBackColor = True
        '
        'BTN_REGCLIENTES
        '
        Me.BTN_REGCLIENTES.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGCLIENTES.Location = New System.Drawing.Point(37, 156)
        Me.BTN_REGCLIENTES.Name = "BTN_REGCLIENTES"
        Me.BTN_REGCLIENTES.Size = New System.Drawing.Size(114, 58)
        Me.BTN_REGCLIENTES.TabIndex = 2
        Me.BTN_REGCLIENTES.Text = "Registrar Clientes"
        Me.BTN_REGCLIENTES.UseVisualStyleBackColor = True
        '
        'BTN_CONCLIENTES
        '
        Me.BTN_CONCLIENTES.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONCLIENTES.Location = New System.Drawing.Point(178, 156)
        Me.BTN_CONCLIENTES.Name = "BTN_CONCLIENTES"
        Me.BTN_CONCLIENTES.Size = New System.Drawing.Size(114, 58)
        Me.BTN_CONCLIENTES.TabIndex = 3
        Me.BTN_CONCLIENTES.Text = "Consultar Clientes"
        Me.BTN_CONCLIENTES.UseVisualStyleBackColor = True
        '
        'BTN_CONEQUIPO
        '
        Me.BTN_CONEQUIPO.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONEQUIPO.Location = New System.Drawing.Point(326, 71)
        Me.BTN_CONEQUIPO.Name = "BTN_CONEQUIPO"
        Me.BTN_CONEQUIPO.Size = New System.Drawing.Size(114, 58)
        Me.BTN_CONEQUIPO.TabIndex = 4
        Me.BTN_CONEQUIPO.Text = "Consultar Equipos"
        Me.BTN_CONEQUIPO.UseVisualStyleBackColor = True
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CERRAR.Location = New System.Drawing.Point(345, 244)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(114, 36)
        Me.BTN_CERRAR.TabIndex = 5
        Me.BTN_CERRAR.Text = "Cerrar Sesión"
        Me.BTN_CERRAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Menu de Operaciones"
        '
        'FRM_OPERACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 309)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.Controls.Add(Me.BTN_CONEQUIPO)
        Me.Controls.Add(Me.BTN_CONCLIENTES)
        Me.Controls.Add(Me.BTN_REGCLIENTES)
        Me.Controls.Add(Me.BTN_REGSERVICIO)
        Me.Controls.Add(Me.BTN_REGEQUIPO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_OPERACIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Megabyte Computación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_REGEQUIPO As System.Windows.Forms.Button
    Friend WithEvents BTN_REGSERVICIO As System.Windows.Forms.Button
    Friend WithEvents BTN_REGCLIENTES As System.Windows.Forms.Button
    Friend WithEvents BTN_CONCLIENTES As System.Windows.Forms.Button
    Friend WithEvents BTN_CONEQUIPO As System.Windows.Forms.Button
    Friend WithEvents BTN_CERRAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

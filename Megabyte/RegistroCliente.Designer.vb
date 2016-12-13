<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_REGCLIENTE
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_TELEFONO = New System.Windows.Forms.TextBox()
        Me.TXT_CALLE = New System.Windows.Forms.TextBox()
        Me.TXT_COLONIA = New System.Windows.Forms.TextBox()
        Me.TXT_EMAIL = New System.Windows.Forms.TextBox()
        Me.TXT_NUMERO = New System.Windows.Forms.TextBox()
        Me.TXT_CP = New System.Windows.Forms.TextBox()
        Me.BTN_REGISTAR = New System.Windows.Forms.Button()
        Me.BTN_REGRESAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Calle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Colonia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-Mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(283, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "C.P."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(262, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Numero"
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(99, 26)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(153, 30)
        Me.TXT_NOMBRE.TabIndex = 1
        '
        'TXT_TELEFONO
        '
        Me.TXT_TELEFONO.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TELEFONO.Location = New System.Drawing.Point(99, 70)
        Me.TXT_TELEFONO.Name = "TXT_TELEFONO"
        Me.TXT_TELEFONO.Size = New System.Drawing.Size(153, 30)
        Me.TXT_TELEFONO.TabIndex = 2
        '
        'TXT_CALLE
        '
        Me.TXT_CALLE.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CALLE.Location = New System.Drawing.Point(99, 118)
        Me.TXT_CALLE.Name = "TXT_CALLE"
        Me.TXT_CALLE.Size = New System.Drawing.Size(153, 30)
        Me.TXT_CALLE.TabIndex = 3
        '
        'TXT_COLONIA
        '
        Me.TXT_COLONIA.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COLONIA.Location = New System.Drawing.Point(99, 161)
        Me.TXT_COLONIA.Name = "TXT_COLONIA"
        Me.TXT_COLONIA.Size = New System.Drawing.Size(153, 30)
        Me.TXT_COLONIA.TabIndex = 5
        '
        'TXT_EMAIL
        '
        Me.TXT_EMAIL.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EMAIL.Location = New System.Drawing.Point(99, 203)
        Me.TXT_EMAIL.Name = "TXT_EMAIL"
        Me.TXT_EMAIL.Size = New System.Drawing.Size(153, 30)
        Me.TXT_EMAIL.TabIndex = 7
        '
        'TXT_NUMERO
        '
        Me.TXT_NUMERO.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NUMERO.Location = New System.Drawing.Point(327, 121)
        Me.TXT_NUMERO.Name = "TXT_NUMERO"
        Me.TXT_NUMERO.Size = New System.Drawing.Size(83, 30)
        Me.TXT_NUMERO.TabIndex = 4
        '
        'TXT_CP
        '
        Me.TXT_CP.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CP.Location = New System.Drawing.Point(327, 161)
        Me.TXT_CP.Name = "TXT_CP"
        Me.TXT_CP.Size = New System.Drawing.Size(83, 30)
        Me.TXT_CP.TabIndex = 6
        '
        'BTN_REGISTAR
        '
        Me.BTN_REGISTAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGISTAR.Location = New System.Drawing.Point(293, 208)
        Me.BTN_REGISTAR.Name = "BTN_REGISTAR"
        Me.BTN_REGISTAR.Size = New System.Drawing.Size(117, 47)
        Me.BTN_REGISTAR.TabIndex = 8
        Me.BTN_REGISTAR.Text = "Registar"
        Me.BTN_REGISTAR.UseVisualStyleBackColor = True
        '
        'BTN_REGRESAR
        '
        Me.BTN_REGRESAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGRESAR.Location = New System.Drawing.Point(338, 301)
        Me.BTN_REGRESAR.Name = "BTN_REGRESAR"
        Me.BTN_REGRESAR.Size = New System.Drawing.Size(104, 36)
        Me.BTN_REGRESAR.TabIndex = 9
        Me.BTN_REGRESAR.Text = "Regresar"
        Me.BTN_REGRESAR.UseVisualStyleBackColor = True
        '
        'FRM_REGCLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 349)
        Me.Controls.Add(Me.BTN_REGRESAR)
        Me.Controls.Add(Me.BTN_REGISTAR)
        Me.Controls.Add(Me.TXT_CP)
        Me.Controls.Add(Me.TXT_NUMERO)
        Me.Controls.Add(Me.TXT_EMAIL)
        Me.Controls.Add(Me.TXT_COLONIA)
        Me.Controls.Add(Me.TXT_CALLE)
        Me.Controls.Add(Me.TXT_TELEFONO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_REGCLIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CALLE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_COLONIA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NUMERO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CP As System.Windows.Forms.TextBox
    Friend WithEvents BTN_REGISTAR As System.Windows.Forms.Button
    Friend WithEvents BTN_REGRESAR As System.Windows.Forms.Button
End Class

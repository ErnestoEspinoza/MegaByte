<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RegistroEquipos
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
        Me.TXT_MODELO = New System.Windows.Forms.TextBox()
        Me.TXT_COLOR = New System.Windows.Forms.TextBox()
        Me.TXT_NUMSERIE = New System.Windows.Forms.TextBox()
        Me.CB_CLIENTE = New System.Windows.Forms.ComboBox()
        Me.CB_TIPOEQUIPO = New System.Windows.Forms.ComboBox()
        Me.CB_MARCA = New System.Windows.Forms.ComboBox()
        Me.BTN_REGISTRAR = New System.Windows.Forms.Button()
        Me.BTN_REGRESAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Equipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numero de Serie"
        '
        'TXT_MODELO
        '
        Me.TXT_MODELO.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MODELO.Location = New System.Drawing.Point(165, 194)
        Me.TXT_MODELO.Name = "TXT_MODELO"
        Me.TXT_MODELO.Size = New System.Drawing.Size(133, 32)
        Me.TXT_MODELO.TabIndex = 4
        '
        'TXT_COLOR
        '
        Me.TXT_COLOR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COLOR.Location = New System.Drawing.Point(165, 255)
        Me.TXT_COLOR.Name = "TXT_COLOR"
        Me.TXT_COLOR.Size = New System.Drawing.Size(133, 32)
        Me.TXT_COLOR.TabIndex = 5
        '
        'TXT_NUMSERIE
        '
        Me.TXT_NUMSERIE.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NUMSERIE.Location = New System.Drawing.Point(165, 307)
        Me.TXT_NUMSERIE.Name = "TXT_NUMSERIE"
        Me.TXT_NUMSERIE.Size = New System.Drawing.Size(133, 32)
        Me.TXT_NUMSERIE.TabIndex = 6
        '
        'CB_CLIENTE
        '
        Me.CB_CLIENTE.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_CLIENTE.FormattingEnabled = True
        Me.CB_CLIENTE.Location = New System.Drawing.Point(165, 29)
        Me.CB_CLIENTE.Name = "CB_CLIENTE"
        Me.CB_CLIENTE.Size = New System.Drawing.Size(133, 33)
        Me.CB_CLIENTE.TabIndex = 1
        '
        'CB_TIPOEQUIPO
        '
        Me.CB_TIPOEQUIPO.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TIPOEQUIPO.FormattingEnabled = True
        Me.CB_TIPOEQUIPO.Location = New System.Drawing.Point(165, 81)
        Me.CB_TIPOEQUIPO.Name = "CB_TIPOEQUIPO"
        Me.CB_TIPOEQUIPO.Size = New System.Drawing.Size(133, 33)
        Me.CB_TIPOEQUIPO.TabIndex = 2
        '
        'CB_MARCA
        '
        Me.CB_MARCA.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_MARCA.FormattingEnabled = True
        Me.CB_MARCA.Location = New System.Drawing.Point(165, 138)
        Me.CB_MARCA.Name = "CB_MARCA"
        Me.CB_MARCA.Size = New System.Drawing.Size(133, 33)
        Me.CB_MARCA.TabIndex = 3
        '
        'BTN_REGISTRAR
        '
        Me.BTN_REGISTRAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGISTRAR.Location = New System.Drawing.Point(174, 357)
        Me.BTN_REGISTRAR.Name = "BTN_REGISTRAR"
        Me.BTN_REGISTRAR.Size = New System.Drawing.Size(115, 45)
        Me.BTN_REGISTRAR.TabIndex = 7
        Me.BTN_REGISTRAR.Text = "Registrar"
        Me.BTN_REGISTRAR.UseVisualStyleBackColor = True
        '
        'BTN_REGRESAR
        '
        Me.BTN_REGRESAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGRESAR.Location = New System.Drawing.Point(248, 459)
        Me.BTN_REGRESAR.Name = "BTN_REGRESAR"
        Me.BTN_REGRESAR.Size = New System.Drawing.Size(91, 36)
        Me.BTN_REGRESAR.TabIndex = 8
        Me.BTN_REGRESAR.Text = "Regresar"
        Me.BTN_REGRESAR.UseVisualStyleBackColor = True
        '
        'FRM_RegistroEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 507)
        Me.Controls.Add(Me.BTN_REGRESAR)
        Me.Controls.Add(Me.BTN_REGISTRAR)
        Me.Controls.Add(Me.CB_MARCA)
        Me.Controls.Add(Me.CB_TIPOEQUIPO)
        Me.Controls.Add(Me.CB_CLIENTE)
        Me.Controls.Add(Me.TXT_NUMSERIE)
        Me.Controls.Add(Me.TXT_COLOR)
        Me.Controls.Add(Me.TXT_MODELO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_RegistroEquipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_MODELO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_COLOR As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NUMSERIE As System.Windows.Forms.TextBox
    Friend WithEvents CB_CLIENTE As System.Windows.Forms.ComboBox
    Friend WithEvents CB_TIPOEQUIPO As System.Windows.Forms.ComboBox
    Friend WithEvents CB_MARCA As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_REGISTRAR As System.Windows.Forms.Button
    Friend WithEvents BTN_REGRESAR As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_INICIO
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LB_LOGIN = New System.Windows.Forms.Label()
        Me.LB_USER = New System.Windows.Forms.Label()
        Me.LB_PASS = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BTN_INICIAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Megabyte.My.Resources.Resources.Megabyte
        Me.PictureBox1.Location = New System.Drawing.Point(186, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LB_LOGIN
        '
        Me.LB_LOGIN.AutoSize = True
        Me.LB_LOGIN.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_LOGIN.Location = New System.Drawing.Point(254, 192)
        Me.LB_LOGIN.Name = "LB_LOGIN"
        Me.LB_LOGIN.Size = New System.Drawing.Size(201, 44)
        Me.LB_LOGIN.TabIndex = 1
        Me.LB_LOGIN.Text = "Inicio de sesión"
        '
        'LB_USER
        '
        Me.LB_USER.AutoSize = True
        Me.LB_USER.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_USER.Location = New System.Drawing.Point(219, 251)
        Me.LB_USER.Name = "LB_USER"
        Me.LB_USER.Size = New System.Drawing.Size(97, 39)
        Me.LB_USER.TabIndex = 2
        Me.LB_USER.Text = "Usuario"
        '
        'LB_PASS
        '
        Me.LB_PASS.AutoSize = True
        Me.LB_PASS.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PASS.Location = New System.Drawing.Point(182, 298)
        Me.LB_PASS.Name = "LB_PASS"
        Me.LB_PASS.Size = New System.Drawing.Size(134, 39)
        Me.LB_PASS.TabIndex = 3
        Me.LB_PASS.Text = "Contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(312, 258)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 32)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(312, 305)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 32)
        Me.TextBox2.TabIndex = 5
        '
        'BTN_INICIAR
        '
        Me.BTN_INICIAR.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INICIAR.Location = New System.Drawing.Point(312, 358)
        Me.BTN_INICIAR.Name = "BTN_INICIAR"
        Me.BTN_INICIAR.Size = New System.Drawing.Size(110, 43)
        Me.BTN_INICIAR.TabIndex = 6
        Me.BTN_INICIAR.Text = "Iniciar"
        Me.BTN_INICIAR.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SALIR.Location = New System.Drawing.Point(576, 428)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(110, 43)
        Me.BTN_SALIR.TabIndex = 7
        Me.BTN_SALIR.Text = "Salir"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'FRM_INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 494)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_INICIAR)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LB_PASS)
        Me.Controls.Add(Me.LB_USER)
        Me.Controls.Add(Me.LB_LOGIN)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_INICIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Megabyte Computación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LB_LOGIN As System.Windows.Forms.Label
    Friend WithEvents LB_USER As System.Windows.Forms.Label
    Friend WithEvents LB_PASS As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BTN_INICIAR As System.Windows.Forms.Button
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button

End Class

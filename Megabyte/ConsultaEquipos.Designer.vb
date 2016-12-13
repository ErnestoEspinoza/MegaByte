<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_CONEQUIPO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_TIPOCON = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CB_TIPOEQUIPO = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CB_ESTADO = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CB_CLIENTE = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CB_MARCA = New System.Windows.Forms.ComboBox()
        Me.BTN_CONSULTAR = New System.Windows.Forms.Button()
        Me.BTN_MODIFICAR = New System.Windows.Forms.Button()
        Me.BTN_REPARAR = New System.Windows.Forms.Button()
        Me.BTN_ENTREGAR = New System.Windows.Forms.Button()
        Me.BTN_REGRESAR = New System.Windows.Forms.Button()
        Me.TipodeEquiposData = New Megabyte.TipodeEquiposData()
        Me.TiposdeequiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipos_de_equiposTableAdapter = New Megabyte.TipodeEquiposDataTableAdapters.tipos_de_equiposTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TipodeEquiposData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposdeequiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 197)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 386)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Consulta"
        '
        'CB_TIPOCON
        '
        Me.CB_TIPOCON.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TIPOCON.FormattingEnabled = True
        Me.CB_TIPOCON.Location = New System.Drawing.Point(133, 15)
        Me.CB_TIPOCON.Name = "CB_TIPOCON"
        Me.CB_TIPOCON.Size = New System.Drawing.Size(121, 32)
        Me.CB_TIPOCON.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 119)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fecha"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(127, 69)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 27)
        Me.DateTimePicker2.TabIndex = 5
        Me.DateTimePicker2.Value = New Date(2016, 12, 10, 17, 52, 6, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(14, 69)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 27)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Value = New Date(2016, 12, 10, 17, 52, 6, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CB_TIPOEQUIPO)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(296, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 72)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Equipo"
        '
        'CB_TIPOEQUIPO
        '
        Me.CB_TIPOEQUIPO.DataSource = Me.TiposdeequiposBindingSource
        Me.CB_TIPOEQUIPO.FormattingEnabled = True
        Me.CB_TIPOEQUIPO.Location = New System.Drawing.Point(18, 29)
        Me.CB_TIPOEQUIPO.Name = "CB_TIPOEQUIPO"
        Me.CB_TIPOEQUIPO.Size = New System.Drawing.Size(121, 32)
        Me.CB_TIPOEQUIPO.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CB_ESTADO)
        Me.GroupBox3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(460, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 72)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado"
        '
        'CB_ESTADO
        '
        Me.CB_ESTADO.FormattingEnabled = True
        Me.CB_ESTADO.Location = New System.Drawing.Point(18, 29)
        Me.CB_ESTADO.Name = "CB_ESTADO"
        Me.CB_ESTADO.Size = New System.Drawing.Size(121, 32)
        Me.CB_ESTADO.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CB_CLIENTE)
        Me.GroupBox4.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(296, 93)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 72)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'CB_CLIENTE
        '
        Me.CB_CLIENTE.FormattingEnabled = True
        Me.CB_CLIENTE.Location = New System.Drawing.Point(18, 29)
        Me.CB_CLIENTE.Name = "CB_CLIENTE"
        Me.CB_CLIENTE.Size = New System.Drawing.Size(121, 32)
        Me.CB_CLIENTE.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CB_MARCA)
        Me.GroupBox5.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(460, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(158, 72)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Marca"
        '
        'CB_MARCA
        '
        Me.CB_MARCA.FormattingEnabled = True
        Me.CB_MARCA.Location = New System.Drawing.Point(18, 29)
        Me.CB_MARCA.Name = "CB_MARCA"
        Me.CB_MARCA.Size = New System.Drawing.Size(121, 32)
        Me.CB_MARCA.TabIndex = 0
        '
        'BTN_CONSULTAR
        '
        Me.BTN_CONSULTAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONSULTAR.Location = New System.Drawing.Point(650, 63)
        Me.BTN_CONSULTAR.Name = "BTN_CONSULTAR"
        Me.BTN_CONSULTAR.Size = New System.Drawing.Size(123, 66)
        Me.BTN_CONSULTAR.TabIndex = 8
        Me.BTN_CONSULTAR.Text = "Consultar"
        Me.BTN_CONSULTAR.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(650, 208)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(123, 50)
        Me.BTN_MODIFICAR.TabIndex = 9
        Me.BTN_MODIFICAR.Text = "Modificar"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_REPARAR
        '
        Me.BTN_REPARAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REPARAR.Location = New System.Drawing.Point(650, 287)
        Me.BTN_REPARAR.Name = "BTN_REPARAR"
        Me.BTN_REPARAR.Size = New System.Drawing.Size(123, 50)
        Me.BTN_REPARAR.TabIndex = 10
        Me.BTN_REPARAR.Text = "Reparar"
        Me.BTN_REPARAR.UseVisualStyleBackColor = True
        '
        'BTN_ENTREGAR
        '
        Me.BTN_ENTREGAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ENTREGAR.Location = New System.Drawing.Point(650, 373)
        Me.BTN_ENTREGAR.Name = "BTN_ENTREGAR"
        Me.BTN_ENTREGAR.Size = New System.Drawing.Size(123, 50)
        Me.BTN_ENTREGAR.TabIndex = 11
        Me.BTN_ENTREGAR.Text = "Entregar"
        Me.BTN_ENTREGAR.UseVisualStyleBackColor = True
        '
        'BTN_REGRESAR
        '
        Me.BTN_REGRESAR.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGRESAR.Location = New System.Drawing.Point(650, 546)
        Me.BTN_REGRESAR.Name = "BTN_REGRESAR"
        Me.BTN_REGRESAR.Size = New System.Drawing.Size(123, 37)
        Me.BTN_REGRESAR.TabIndex = 12
        Me.BTN_REGRESAR.Text = "Regresar"
        Me.BTN_REGRESAR.UseVisualStyleBackColor = True
        '
        'TipodeEquiposData
        '
        Me.TipodeEquiposData.DataSetName = "TipodeEquiposData"
        Me.TipodeEquiposData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposdeequiposBindingSource
        '
        Me.TiposdeequiposBindingSource.DataMember = "tipos_de_equipos"
        Me.TiposdeequiposBindingSource.DataSource = Me.TipodeEquiposData
        '
        'Tipos_de_equiposTableAdapter
        '
        Me.Tipos_de_equiposTableAdapter.ClearBeforeFill = True
        '
        'FRM_CONEQUIPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 607)
        Me.Controls.Add(Me.BTN_REGRESAR)
        Me.Controls.Add(Me.BTN_ENTREGAR)
        Me.Controls.Add(Me.BTN_REPARAR)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_CONSULTAR)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CB_TIPOCON)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_CONEQUIPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Equipos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.TipodeEquiposData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposdeequiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_TIPOCON As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_TIPOEQUIPO As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_ESTADO As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_CLIENTE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_MARCA As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_CONSULTAR As System.Windows.Forms.Button
    Friend WithEvents BTN_MODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTN_REPARAR As System.Windows.Forms.Button
    Friend WithEvents BTN_ENTREGAR As System.Windows.Forms.Button
    Friend WithEvents BTN_REGRESAR As System.Windows.Forms.Button
    Friend WithEvents TipodeEquiposData As TipodeEquiposData
    Friend WithEvents TiposdeequiposBindingSource As BindingSource
    Friend WithEvents Tipos_de_equiposTableAdapter As TipodeEquiposDataTableAdapters.tipos_de_equiposTableAdapter
End Class

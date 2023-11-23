<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehiculo
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
        Me.components = New System.ComponentModel.Container()
        Me.panContenedor = New System.Windows.Forms.Panel()
        Me.panCentro = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grpRepostaje = New System.Windows.Forms.GroupBox()
        Me.chkObligatorioKms = New System.Windows.Forms.CheckBox()
        Me.chkRepostaje = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpOtros = New System.Windows.Forms.GroupBox()
        Me.txtPMA = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkExterno = New System.Windows.Forms.CheckBox()
        Me.chkRenting = New System.Windows.Forms.CheckBox()
        Me.txtTara = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.grpSeguro = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCompañia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblOK = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panPie = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panTitulo = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tmrOK = New System.Windows.Forms.Timer(Me.components)
        Me.panContenedor.SuspendLayout()
        Me.panCentro.SuspendLayout()
        Me.grpRepostaje.SuspendLayout()
        Me.grpOtros.SuspendLayout()
        Me.grpSeguro.SuspendLayout()
        Me.panPie.SuspendLayout()
        Me.panTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panContenedor
        '
        Me.panContenedor.BackColor = System.Drawing.Color.DarkGray
        Me.panContenedor.Controls.Add(Me.panCentro)
        Me.panContenedor.Controls.Add(Me.panPie)
        Me.panContenedor.Controls.Add(Me.panTitulo)
        Me.panContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panContenedor.Name = "panContenedor"
        Me.panContenedor.Padding = New System.Windows.Forms.Padding(2)
        Me.panContenedor.Size = New System.Drawing.Size(897, 696)
        Me.panContenedor.TabIndex = 185
        '
        'panCentro
        '
        Me.panCentro.BackColor = System.Drawing.SystemColors.Control
        Me.panCentro.Controls.Add(Me.Label18)
        Me.panCentro.Controls.Add(Me.grpRepostaje)
        Me.panCentro.Controls.Add(Me.grpOtros)
        Me.panCentro.Controls.Add(Me.chkActivo)
        Me.panCentro.Controls.Add(Me.grpSeguro)
        Me.panCentro.Controls.Add(Me.Label7)
        Me.panCentro.Controls.Add(Me.cboTipo)
        Me.panCentro.Controls.Add(Me.txtDescripcion)
        Me.panCentro.Controls.Add(Me.Label4)
        Me.panCentro.Controls.Add(Me.txtMatricula)
        Me.panCentro.Controls.Add(Me.Label12)
        Me.panCentro.Controls.Add(Me.txtObservaciones)
        Me.panCentro.Controls.Add(Me.Label8)
        Me.panCentro.Controls.Add(Me.lblOK)
        Me.panCentro.Controls.Add(Me.lblTitulo)
        Me.panCentro.Controls.Add(Me.txtCodigo)
        Me.panCentro.Controls.Add(Me.Label13)
        Me.panCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panCentro.Location = New System.Drawing.Point(2, 32)
        Me.panCentro.Name = "panCentro"
        Me.panCentro.Size = New System.Drawing.Size(893, 627)
        Me.panCentro.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(268, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(214, 15)
        Me.Label18.TabIndex = 212
        Me.Label18.Text = "* NO PONER GUIONES NI ESPACIOS"
        '
        'grpRepostaje
        '
        Me.grpRepostaje.Controls.Add(Me.chkObligatorioKms)
        Me.grpRepostaje.Controls.Add(Me.chkRepostaje)
        Me.grpRepostaje.Controls.Add(Me.Label16)
        Me.grpRepostaje.Controls.Add(Me.txtDeposito)
        Me.grpRepostaje.Controls.Add(Me.Label3)
        Me.grpRepostaje.Location = New System.Drawing.Point(493, 239)
        Me.grpRepostaje.Name = "grpRepostaje"
        Me.grpRepostaje.Size = New System.Drawing.Size(377, 170)
        Me.grpRepostaje.TabIndex = 211
        Me.grpRepostaje.TabStop = False
        Me.grpRepostaje.Text = " GASOIL "
        '
        'chkObligatorioKms
        '
        Me.chkObligatorioKms.AutoSize = True
        Me.chkObligatorioKms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkObligatorioKms.Location = New System.Drawing.Point(24, 77)
        Me.chkObligatorioKms.Name = "chkObligatorioKms"
        Me.chkObligatorioKms.Size = New System.Drawing.Size(208, 21)
        Me.chkObligatorioKms.TabIndex = 211
        Me.chkObligatorioKms.TabStop = False
        Me.chkObligatorioKms.Text = "OBLIGATORIO PONER KMS"
        Me.chkObligatorioKms.UseVisualStyleBackColor = True
        '
        'chkRepostaje
        '
        Me.chkRepostaje.AutoSize = True
        Me.chkRepostaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRepostaje.Location = New System.Drawing.Point(24, 33)
        Me.chkRepostaje.Name = "chkRepostaje"
        Me.chkRepostaje.Size = New System.Drawing.Size(232, 21)
        Me.chkRepostaje.TabIndex = 199
        Me.chkRepostaje.TabStop = False
        Me.chkRepostaje.Text = "TIENE REPOSTAJE PERMITIDO"
        Me.chkRepostaje.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(173, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 17)
        Me.Label16.TabIndex = 210
        Me.Label16.Text = "litros"
        '
        'txtDeposito
        '
        Me.txtDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDeposito.Location = New System.Drawing.Point(111, 118)
        Me.txtDeposito.MaxLength = 4
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(56, 23)
        Me.txtDeposito.TabIndex = 3
        Me.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "DEPOSITO:"
        '
        'grpOtros
        '
        Me.grpOtros.Controls.Add(Me.txtPMA)
        Me.grpOtros.Controls.Add(Me.Label17)
        Me.grpOtros.Controls.Add(Me.chkExterno)
        Me.grpOtros.Controls.Add(Me.chkRenting)
        Me.grpOtros.Controls.Add(Me.txtTara)
        Me.grpOtros.Controls.Add(Me.Label6)
        Me.grpOtros.Location = New System.Drawing.Point(493, 419)
        Me.grpOtros.Name = "grpOtros"
        Me.grpOtros.Size = New System.Drawing.Size(377, 191)
        Me.grpOtros.TabIndex = 209
        Me.grpOtros.TabStop = False
        Me.grpOtros.Text = " PARAMETROS "
        '
        'txtPMA
        '
        Me.txtPMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPMA.Location = New System.Drawing.Point(81, 72)
        Me.txtPMA.MaxLength = 7
        Me.txtPMA.Name = "txtPMA"
        Me.txtPMA.Size = New System.Drawing.Size(100, 23)
        Me.txtPMA.TabIndex = 202
        Me.txtPMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(24, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 17)
        Me.Label17.TabIndex = 203
        Me.Label17.Text = "PMA:"
        '
        'chkExterno
        '
        Me.chkExterno.AutoSize = True
        Me.chkExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExterno.Location = New System.Drawing.Point(24, 149)
        Me.chkExterno.Name = "chkExterno"
        Me.chkExterno.Size = New System.Drawing.Size(245, 21)
        Me.chkExterno.TabIndex = 198
        Me.chkExterno.TabStop = False
        Me.chkExterno.Text = "EXTERNO (NO ES DE VISANFER)"
        Me.chkExterno.UseVisualStyleBackColor = True
        '
        'chkRenting
        '
        Me.chkRenting.AutoSize = True
        Me.chkRenting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRenting.Location = New System.Drawing.Point(24, 110)
        Me.chkRenting.Name = "chkRenting"
        Me.chkRenting.Size = New System.Drawing.Size(185, 21)
        Me.chkRenting.TabIndex = 200
        Me.chkRenting.TabStop = False
        Me.chkRenting.Text = "VEHICULO DE RENTING"
        Me.chkRenting.UseVisualStyleBackColor = True
        '
        'txtTara
        '
        Me.txtTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTara.Location = New System.Drawing.Point(81, 37)
        Me.txtTara.MaxLength = 7
        Me.txtTara.Name = "txtTara"
        Me.txtTara.Size = New System.Drawing.Size(100, 23)
        Me.txtTara.TabIndex = 4
        Me.txtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "TARA:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(793, 69)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(77, 21)
        Me.chkActivo.TabIndex = 197
        Me.chkActivo.TabStop = False
        Me.chkActivo.Text = "ACTIVO"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'grpSeguro
        '
        Me.grpSeguro.Controls.Add(Me.Label14)
        Me.grpSeguro.Controls.Add(Me.txtPoliza)
        Me.grpSeguro.Controls.Add(Me.txtImporte)
        Me.grpSeguro.Controls.Add(Me.Label5)
        Me.grpSeguro.Controls.Add(Me.Label11)
        Me.grpSeguro.Controls.Add(Me.dtpInicio)
        Me.grpSeguro.Controls.Add(Me.dtpFinal)
        Me.grpSeguro.Controls.Add(Me.Label10)
        Me.grpSeguro.Controls.Add(Me.Label9)
        Me.grpSeguro.Controls.Add(Me.txtCompañia)
        Me.grpSeguro.Location = New System.Drawing.Point(28, 419)
        Me.grpSeguro.Name = "grpSeguro"
        Me.grpSeguro.Size = New System.Drawing.Size(443, 192)
        Me.grpSeguro.TabIndex = 208
        Me.grpSeguro.TabStop = False
        Me.grpSeguro.Text = " DATOS SEGURO "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(250, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 17)
        Me.Label14.TabIndex = 208
        Me.Label14.Text = "-"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPoliza
        '
        Me.txtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPoliza.Location = New System.Drawing.Point(131, 35)
        Me.txtPoliza.MaxLength = 100
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(285, 23)
        Me.txtPoliza.TabIndex = 204
        Me.txtPoliza.TabStop = False
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtImporte.Location = New System.Drawing.Point(131, 146)
        Me.txtImporte.MaxLength = 7
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(106, 23)
        Me.txtImporte.TabIndex = 206
        Me.txtImporte.TabStop = False
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(33, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "PERIODO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(33, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 207
        Me.Label11.Text = "IMPORTE:"
        '
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(131, 109)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(111, 23)
        Me.dtpInicio.TabIndex = 0
        Me.dtpInicio.TabStop = False
        '
        'dtpFinal
        '
        Me.dtpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(269, 109)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(111, 23)
        Me.dtpFinal.TabIndex = 186
        Me.dtpFinal.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(33, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "POLIZA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(33, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 17)
        Me.Label9.TabIndex = 203
        Me.Label9.Text = "COMPAÑIA:"
        '
        'txtCompañia
        '
        Me.txtCompañia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCompañia.Location = New System.Drawing.Point(131, 72)
        Me.txtCompañia.MaxLength = 100
        Me.txtCompañia.Name = "txtCompañia"
        Me.txtCompañia.Size = New System.Drawing.Size(285, 23)
        Me.txtCompañia.TabIndex = 202
        Me.txtCompañia.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(561, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "TIPO:"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"CAMION CON GRUA", "CAMION SIN GRUA", "HORMIGONERA", "CABEZA TRACTORA", "FURGONETA", "TURISMO", "CARRETILLA", "REMOLQUE", "OTROS"})
        Me.cboTipo.Location = New System.Drawing.Point(621, 123)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(249, 24)
        Me.cboTipo.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(159, 180)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(711, 23)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "DESCRIPCION:"
        '
        'txtMatricula
        '
        Me.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMatricula.Location = New System.Drawing.Point(159, 124)
        Me.txtMatricula.MaxLength = 10
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(106, 23)
        Me.txtMatricula.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(25, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 179
        Me.Label12.Text = "MATRICULA:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtObservaciones.Location = New System.Drawing.Point(28, 262)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(443, 144)
        Me.txtObservaciones.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(25, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 17)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "OBSERVACIONES:"
        '
        'lblOK
        '
        Me.lblOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOK.ForeColor = System.Drawing.Color.White
        Me.lblOK.Location = New System.Drawing.Point(221, 0)
        Me.lblOK.Name = "lblOK"
        Me.lblOK.Size = New System.Drawing.Size(451, 27)
        Me.lblOK.TabIndex = 36
        Me.lblOK.Text = "REGISTRO GRABADO CORRECTAMENTE"
        Me.lblOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOK.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(893, 36)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "MODIFICACION DE DATOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCodigo.Location = New System.Drawing.Point(159, 68)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(66, 23)
        Me.txtCodigo.TabIndex = 174
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(25, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 175
        Me.Label13.Text = "CODIGO:"
        '
        'panPie
        '
        Me.panPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.panPie.Controls.Add(Me.Label1)
        Me.panPie.Controls.Add(Me.Label2)
        Me.panPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panPie.Location = New System.Drawing.Point(2, 659)
        Me.panPie.Name = "panPie"
        Me.panPie.Size = New System.Drawing.Size(893, 35)
        Me.panPie.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ESC - SALIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(719, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "F5 - GRABAR"
        '
        'panTitulo
        '
        Me.panTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.panTitulo.Controls.Add(Me.Label15)
        Me.panTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo.Location = New System.Drawing.Point(2, 2)
        Me.panTitulo.Name = "panTitulo"
        Me.panTitulo.Size = New System.Drawing.Size(893, 30)
        Me.panTitulo.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(407, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "VEHICULO"
        '
        'tmrOK
        '
        Me.tmrOK.Interval = 1000
        '
        'frmVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.panContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVehiculo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS DEL VEHICULO"
        Me.panContenedor.ResumeLayout(False)
        Me.panCentro.ResumeLayout(False)
        Me.panCentro.PerformLayout()
        Me.grpRepostaje.ResumeLayout(False)
        Me.grpRepostaje.PerformLayout()
        Me.grpOtros.ResumeLayout(False)
        Me.grpOtros.PerformLayout()
        Me.grpSeguro.ResumeLayout(False)
        Me.grpSeguro.PerformLayout()
        Me.panPie.ResumeLayout(False)
        Me.panPie.PerformLayout()
        Me.panTitulo.ResumeLayout(False)
        Me.panTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panContenedor As Panel
    Friend WithEvents panCentro As Panel
    Friend WithEvents txtDeposito As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTara As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblOK As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents panPie As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panTitulo As Panel
    Private WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkRenting As CheckBox
    Friend WithEvents chkRepostaje As CheckBox
    Friend WithEvents chkExterno As CheckBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents grpOtros As GroupBox
    Friend WithEvents grpSeguro As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPoliza As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCompañia As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents grpRepostaje As GroupBox
    Friend WithEvents chkObligatorioKms As CheckBox
    Friend WithEvents txtPMA As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tmrOK As Timer
    Friend WithEvents Label18 As Label
End Class

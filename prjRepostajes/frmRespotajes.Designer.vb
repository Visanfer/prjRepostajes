<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRespotajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRespotajes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.lblTextoContador = New System.Windows.Forms.Label()
        Me.cmdRefresca = New System.Windows.Forms.Button()
        Me.grpGasolineros = New System.Windows.Forms.GroupBox()
        Me.cmdBorrarGasolinero = New System.Windows.Forms.Button()
        Me.cmdGrabaGasolinero = New System.Windows.Forms.Button()
        Me.lstGasolineros = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpVehiculos = New System.Windows.Forms.GroupBox()
        Me.txtLitrosMaximos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPedirKilometros = New System.Windows.Forms.CheckBox()
        Me.cmdNuevoVehiculos = New System.Windows.Forms.Button()
        Me.txtIdxVehiculo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesMatricula = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.chkMatriculaActiva = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdGrabaVehiculos = New System.Windows.Forms.Button()
        Me.lstVehiculos = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grdLineas = New FlexCell.Grid()
        Me.cmdGasolineros = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdEstadisticas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdSaldos = New System.Windows.Forms.Button()
        Me.cmdVehiculos = New System.Windows.Forms.Button()
        Me.lblPrograma = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdHistorial = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.grpGasolineros.SuspendLayout()
        Me.grpVehiculos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(766, 29)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "ULTIMOS 50 REPOSTAJES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblContador)
        Me.Panel2.Controls.Add(Me.lblTextoContador)
        Me.Panel2.Controls.Add(Me.cmdRefresca)
        Me.Panel2.Controls.Add(Me.grpGasolineros)
        Me.Panel2.Controls.Add(Me.grpVehiculos)
        Me.Panel2.Controls.Add(Me.grdLineas)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(222, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 647)
        Me.Panel2.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 21)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "F1 - METER APUNTE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContador
        '
        Me.lblContador.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContador.Location = New System.Drawing.Point(609, 353)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(142, 26)
        Me.lblContador.TabIndex = 161
        Me.lblContador.Text = "0.00"
        Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextoContador
        '
        Me.lblTextoContador.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTextoContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTextoContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoContador.Location = New System.Drawing.Point(3, 353)
        Me.lblTextoContador.Name = "lblTextoContador"
        Me.lblTextoContador.Size = New System.Drawing.Size(766, 26)
        Me.lblTextoContador.TabIndex = 160
        Me.lblTextoContador.Text = "CONTADOR DEL SURTIDOR"
        Me.lblTextoContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRefresca
        '
        Me.cmdRefresca.BackColor = System.Drawing.Color.Gray
        Me.cmdRefresca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRefresca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefresca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresca.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRefresca.Location = New System.Drawing.Point(730, 3)
        Me.cmdRefresca.Name = "cmdRefresca"
        Me.cmdRefresca.Size = New System.Drawing.Size(39, 29)
        Me.cmdRefresca.TabIndex = 159
        Me.cmdRefresca.Text = "R"
        Me.cmdRefresca.UseVisualStyleBackColor = False
        '
        'grpGasolineros
        '
        Me.grpGasolineros.Controls.Add(Me.cmdBorrarGasolinero)
        Me.grpGasolineros.Controls.Add(Me.cmdGrabaGasolinero)
        Me.grpGasolineros.Controls.Add(Me.lstGasolineros)
        Me.grpGasolineros.Location = New System.Drawing.Point(30, 74)
        Me.grpGasolineros.Name = "grpGasolineros"
        Me.grpGasolineros.Size = New System.Drawing.Size(766, 255)
        Me.grpGasolineros.TabIndex = 149
        Me.grpGasolineros.TabStop = False
        Me.grpGasolineros.Text = " RELACION GASOLINEROS QUE SON CHOFER "
        Me.grpGasolineros.Visible = False
        '
        'cmdBorrarGasolinero
        '
        Me.cmdBorrarGasolinero.BackColor = System.Drawing.Color.Gray
        Me.cmdBorrarGasolinero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBorrarGasolinero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBorrarGasolinero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrarGasolinero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdBorrarGasolinero.Location = New System.Drawing.Point(617, 219)
        Me.cmdBorrarGasolinero.Name = "cmdBorrarGasolinero"
        Me.cmdBorrarGasolinero.Size = New System.Drawing.Size(104, 30)
        Me.cmdBorrarGasolinero.TabIndex = 167
        Me.cmdBorrarGasolinero.Text = "BORRAR"
        Me.cmdBorrarGasolinero.UseVisualStyleBackColor = False
        '
        'cmdGrabaGasolinero
        '
        Me.cmdGrabaGasolinero.BackColor = System.Drawing.Color.Gray
        Me.cmdGrabaGasolinero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGrabaGasolinero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabaGasolinero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabaGasolinero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGrabaGasolinero.Location = New System.Drawing.Point(617, 19)
        Me.cmdGrabaGasolinero.Name = "cmdGrabaGasolinero"
        Me.cmdGrabaGasolinero.Size = New System.Drawing.Size(104, 30)
        Me.cmdGrabaGasolinero.TabIndex = 158
        Me.cmdGrabaGasolinero.Text = "NUEVO"
        Me.cmdGrabaGasolinero.UseVisualStyleBackColor = False
        '
        'lstGasolineros
        '
        Me.lstGasolineros.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstGasolineros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstGasolineros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lstGasolineros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGasolineros.FullRowSelect = True
        Me.lstGasolineros.GridLines = True
        Me.lstGasolineros.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstGasolineros.HideSelection = False
        Me.lstGasolineros.Location = New System.Drawing.Point(6, 19)
        Me.lstGasolineros.MultiSelect = False
        Me.lstGasolineros.Name = "lstGasolineros"
        Me.lstGasolineros.Size = New System.Drawing.Size(605, 230)
        Me.lstGasolineros.TabIndex = 154
        Me.lstGasolineros.UseCompatibleStateImageBehavior = False
        Me.lstGasolineros.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "USER"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "GASOLINERO"
        Me.ColumnHeader8.Width = 350
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CHOFER"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PASSWORD"
        Me.ColumnHeader3.Width = 100
        '
        'grpVehiculos
        '
        Me.grpVehiculos.Controls.Add(Me.txtLitrosMaximos)
        Me.grpVehiculos.Controls.Add(Me.Label3)
        Me.grpVehiculos.Controls.Add(Me.chkPedirKilometros)
        Me.grpVehiculos.Controls.Add(Me.cmdNuevoVehiculos)
        Me.grpVehiculos.Controls.Add(Me.txtIdxVehiculo)
        Me.grpVehiculos.Controls.Add(Me.Label8)
        Me.grpVehiculos.Controls.Add(Me.txtDesMatricula)
        Me.grpVehiculos.Controls.Add(Me.txtMatricula)
        Me.grpVehiculos.Controls.Add(Me.chkMatriculaActiva)
        Me.grpVehiculos.Controls.Add(Me.Label2)
        Me.grpVehiculos.Controls.Add(Me.Label5)
        Me.grpVehiculos.Controls.Add(Me.cmdGrabaVehiculos)
        Me.grpVehiculos.Controls.Add(Me.lstVehiculos)
        Me.grpVehiculos.Location = New System.Drawing.Point(3, 387)
        Me.grpVehiculos.Name = "grpVehiculos"
        Me.grpVehiculos.Size = New System.Drawing.Size(766, 255)
        Me.grpVehiculos.TabIndex = 148
        Me.grpVehiculos.TabStop = False
        Me.grpVehiculos.Text = " VEHICULOS AUTORIZADOS "
        '
        'txtLitrosMaximos
        '
        Me.txtLitrosMaximos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLitrosMaximos.Location = New System.Drawing.Point(652, 89)
        Me.txtLitrosMaximos.MaxLength = 30
        Me.txtLitrosMaximos.Name = "txtLitrosMaximos"
        Me.txtLitrosMaximos.Size = New System.Drawing.Size(96, 20)
        Me.txtLitrosMaximos.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(649, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "LITROS MAX.:"
        '
        'chkPedirKilometros
        '
        Me.chkPedirKilometros.AutoSize = True
        Me.chkPedirKilometros.Location = New System.Drawing.Point(606, 181)
        Me.chkPedirKilometros.Name = "chkPedirKilometros"
        Me.chkPedirKilometros.Size = New System.Drawing.Size(124, 17)
        Me.chkPedirKilometros.TabIndex = 157
        Me.chkPedirKilometros.Text = "Pedir Kms obligatorio"
        Me.chkPedirKilometros.UseVisualStyleBackColor = True
        '
        'cmdNuevoVehiculos
        '
        Me.cmdNuevoVehiculos.BackColor = System.Drawing.Color.LightGreen
        Me.cmdNuevoVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNuevoVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNuevoVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevoVehiculos.Location = New System.Drawing.Point(568, 34)
        Me.cmdNuevoVehiculos.Name = "cmdNuevoVehiculos"
        Me.cmdNuevoVehiculos.Size = New System.Drawing.Size(78, 20)
        Me.cmdNuevoVehiculos.TabIndex = 156
        Me.cmdNuevoVehiculos.Text = "<--- nuevo"
        Me.cmdNuevoVehiculos.UseVisualStyleBackColor = False
        '
        'txtIdxVehiculo
        '
        Me.txtIdxVehiculo.Enabled = False
        Me.txtIdxVehiculo.Location = New System.Drawing.Point(516, 34)
        Me.txtIdxVehiculo.Name = "txtIdxVehiculo"
        Me.txtIdxVehiculo.Size = New System.Drawing.Size(46, 20)
        Me.txtIdxVehiculo.TabIndex = 154
        Me.txtIdxVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(513, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "IDX"
        '
        'txtDesMatricula
        '
        Me.txtDesMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesMatricula.Location = New System.Drawing.Point(516, 137)
        Me.txtDesMatricula.MaxLength = 50
        Me.txtDesMatricula.Name = "txtDesMatricula"
        Me.txtDesMatricula.Size = New System.Drawing.Size(232, 20)
        Me.txtDesMatricula.TabIndex = 151
        '
        'txtMatricula
        '
        Me.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMatricula.Location = New System.Drawing.Point(516, 89)
        Me.txtMatricula.MaxLength = 30
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(130, 20)
        Me.txtMatricula.TabIndex = 149
        '
        'chkMatriculaActiva
        '
        Me.chkMatriculaActiva.AutoSize = True
        Me.chkMatriculaActiva.Location = New System.Drawing.Point(516, 181)
        Me.chkMatriculaActiva.Name = "chkMatriculaActiva"
        Me.chkMatriculaActiva.Size = New System.Drawing.Size(68, 17)
        Me.chkMatriculaActiva.TabIndex = 153
        Me.chkMatriculaActiva.Text = "Activado"
        Me.chkMatriculaActiva.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(513, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "DESCRIPCION:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(513, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "MATRICULA:"
        '
        'cmdGrabaVehiculos
        '
        Me.cmdGrabaVehiculos.BackColor = System.Drawing.Color.Gray
        Me.cmdGrabaVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGrabaVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabaVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabaVehiculos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGrabaVehiculos.Location = New System.Drawing.Point(513, 219)
        Me.cmdGrabaVehiculos.Name = "cmdGrabaVehiculos"
        Me.cmdGrabaVehiculos.Size = New System.Drawing.Size(104, 30)
        Me.cmdGrabaVehiculos.TabIndex = 148
        Me.cmdGrabaVehiculos.Text = "GRABAR"
        Me.cmdGrabaVehiculos.UseVisualStyleBackColor = False
        '
        'lstVehiculos
        '
        Me.lstVehiculos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstVehiculos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader2, Me.ColumnHeader12})
        Me.lstVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehiculos.FullRowSelect = True
        Me.lstVehiculos.GridLines = True
        Me.lstVehiculos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstVehiculos.HideSelection = False
        Me.lstVehiculos.Location = New System.Drawing.Point(6, 19)
        Me.lstVehiculos.MultiSelect = False
        Me.lstVehiculos.Name = "lstVehiculos"
        Me.lstVehiculos.Size = New System.Drawing.Size(501, 230)
        Me.lstVehiculos.TabIndex = 147
        Me.lstVehiculos.UseCompatibleStateImageBehavior = False
        Me.lstVehiculos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 1
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MATRI."
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DESCRIPCION"
        Me.ColumnHeader7.Width = 285
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "*KMS"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MAX"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 40
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ACT."
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 40
        '
        'grdLineas
        '
        Me.grdLineas.BackColorBkg = System.Drawing.SystemColors.ControlLightLight
        Me.grdLineas.BorderStyle = FlexCell.Grid.BorderStyleEnum.FixedSingle
        Me.grdLineas.CheckedImage = CType(resources.GetObject("grdLineas.CheckedImage"), System.Drawing.Bitmap)
        Me.grdLineas.Cols = 8
        Me.grdLineas.ExtendLastCol = True
        Me.grdLineas.Location = New System.Drawing.Point(3, 35)
        Me.grdLineas.MultiSelect = False
        Me.grdLineas.Name = "grdLineas"
        Me.grdLineas.Rows = 2
        Me.grdLineas.ScrollBars = FlexCell.Grid.ScrollBarsEnum.Vertical
        Me.grdLineas.SelectionBorderColor = System.Drawing.Color.Gray
        Me.grdLineas.SelectionMode = FlexCell.Grid.SelectionModeEnum.ByRow
        Me.grdLineas.Size = New System.Drawing.Size(766, 318)
        Me.grdLineas.TabIndex = 147
        Me.grdLineas.TabStop = False
        Me.grdLineas.UncheckedImage = CType(resources.GetObject("grdLineas.UncheckedImage"), System.Drawing.Bitmap)
        '
        'cmdGasolineros
        '
        Me.cmdGasolineros.BackColor = System.Drawing.Color.LightBlue
        Me.cmdGasolineros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGasolineros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGasolineros.Location = New System.Drawing.Point(3, 58)
        Me.cmdGasolineros.Name = "cmdGasolineros"
        Me.cmdGasolineros.Size = New System.Drawing.Size(196, 49)
        Me.cmdGasolineros.TabIndex = 36
        Me.cmdGasolineros.Text = "GASOLINEROS-CHOFER"
        Me.cmdGasolineros.UseVisualStyleBackColor = False
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.LightBlue
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(3, 593)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(196, 49)
        Me.cmdSalir.TabIndex = 34
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdEstadisticas
        '
        Me.cmdEstadisticas.BackColor = System.Drawing.Color.LightBlue
        Me.cmdEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEstadisticas.Location = New System.Drawing.Point(3, 113)
        Me.cmdEstadisticas.Name = "cmdEstadisticas"
        Me.cmdEstadisticas.Size = New System.Drawing.Size(196, 49)
        Me.cmdEstadisticas.TabIndex = 29
        Me.cmdEstadisticas.Text = "CONSUMOS"
        Me.cmdEstadisticas.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmdHistorial)
        Me.Panel1.Controls.Add(Me.cmdSaldos)
        Me.Panel1.Controls.Add(Me.cmdGasolineros)
        Me.Panel1.Controls.Add(Me.cmdSalir)
        Me.Panel1.Controls.Add(Me.cmdEstadisticas)
        Me.Panel1.Controls.Add(Me.cmdVehiculos)
        Me.Panel1.Location = New System.Drawing.Point(12, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 647)
        Me.Panel1.TabIndex = 33
        '
        'cmdSaldos
        '
        Me.cmdSaldos.BackColor = System.Drawing.Color.LightBlue
        Me.cmdSaldos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSaldos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSaldos.Location = New System.Drawing.Point(3, 223)
        Me.cmdSaldos.Name = "cmdSaldos"
        Me.cmdSaldos.Size = New System.Drawing.Size(196, 49)
        Me.cmdSaldos.TabIndex = 37
        Me.cmdSaldos.Text = "SALDO SURTIDOR"
        Me.cmdSaldos.UseVisualStyleBackColor = False
        Me.cmdSaldos.Visible = False
        '
        'cmdVehiculos
        '
        Me.cmdVehiculos.BackColor = System.Drawing.Color.LightBlue
        Me.cmdVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdVehiculos.Location = New System.Drawing.Point(3, 3)
        Me.cmdVehiculos.Name = "cmdVehiculos"
        Me.cmdVehiculos.Size = New System.Drawing.Size(196, 49)
        Me.cmdVehiculos.TabIndex = 28
        Me.cmdVehiculos.Text = "VEHICULOS"
        Me.cmdVehiculos.UseVisualStyleBackColor = False
        '
        'lblPrograma
        '
        Me.lblPrograma.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPrograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrograma.Location = New System.Drawing.Point(12, 11)
        Me.lblPrograma.Name = "lblPrograma"
        Me.lblPrograma.Size = New System.Drawing.Size(704, 56)
        Me.lblPrograma.TabIndex = 32
        Me.lblPrograma.Text = "CONTROL DE GASOIL"
        Me.lblPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(710, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(286, 56)
        Me.lblTitulo.TabIndex = 31
        Me.lblTitulo.Text = "VISANFER, S.A."
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'cmdHistorial
        '
        Me.cmdHistorial.BackColor = System.Drawing.Color.LightBlue
        Me.cmdHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdHistorial.Location = New System.Drawing.Point(3, 168)
        Me.cmdHistorial.Name = "cmdHistorial"
        Me.cmdHistorial.Size = New System.Drawing.Size(196, 49)
        Me.cmdHistorial.TabIndex = 38
        Me.cmdHistorial.Text = "HISTORIAL VEHICULO"
        Me.cmdHistorial.UseVisualStyleBackColor = False
        '
        'frmRespotajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblPrograma)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmRespotajes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Repostajes"
        Me.Panel2.ResumeLayout(False)
        Me.grpGasolineros.ResumeLayout(False)
        Me.grpVehiculos.ResumeLayout(False)
        Me.grpVehiculos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdGasolineros As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdEstadisticas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdVehiculos As Button
    Friend WithEvents lblPrograma As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents grdLineas As FlexCell.Grid
    Friend WithEvents grpGasolineros As GroupBox
    Friend WithEvents grpVehiculos As GroupBox
    Friend WithEvents lstVehiculos As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents cmdGrabaVehiculos As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents chkMatriculaActiva As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesMatricula As TextBox
    Friend WithEvents lstGasolineros As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents cmdNuevoVehiculos As Button
    Friend WithEvents txtIdxVehiculo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkPedirKilometros As CheckBox
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents cmdGrabaGasolinero As Button
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents cmdBorrarGasolinero As Button
    Friend WithEvents cmdRefresca As Button
    Friend WithEvents lblContador As Label
    Friend WithEvents lblTextoContador As Label
    Friend WithEvents cmdSaldos As Button
    Friend WithEvents txtLitrosMaximos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdHistorial As Button
End Class

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
        Me.grdLineas = New FlexCell.Grid()
        Me.cmdGasolineros = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdEstadisticas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblBarraContenido = New System.Windows.Forms.Label()
        Me.cmdRefrescaContenido = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblPorContenido = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cmdHistorial = New System.Windows.Forms.Button()
        Me.cmdSaldos = New System.Windows.Forms.Button()
        Me.cmdVehiculos = New System.Windows.Forms.Button()
        Me.lblPrograma = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.grpGasolineros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel2.Controls.Add(Me.grpGasolineros)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblContador)
        Me.Panel2.Controls.Add(Me.lblTextoContador)
        Me.Panel2.Controls.Add(Me.cmdRefresca)
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
        Me.Label4.Location = New System.Drawing.Point(33, 622)
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
        Me.lblContador.Location = New System.Drawing.Point(609, 619)
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
        Me.lblTextoContador.Location = New System.Drawing.Point(3, 619)
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
        Me.grpGasolineros.Location = New System.Drawing.Point(3, 389)
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
        'grdLineas
        '
        Me.grdLineas.BackColorBkg = System.Drawing.SystemColors.ControlLightLight
        Me.grdLineas.BorderStyle = FlexCell.BorderStyleEnum.FixedSingle
        Me.grdLineas.CheckedImage = CType(resources.GetObject("grdLineas.CheckedImage"), System.Drawing.Bitmap)
        Me.grdLineas.Cols = 8
        Me.grdLineas.ExtendLastCol = True
        Me.grdLineas.Location = New System.Drawing.Point(3, 35)
        Me.grdLineas.MultiSelect = False
        Me.grdLineas.Name = "grdLineas"
        Me.grdLineas.Rows = 2
        Me.grdLineas.ScrollBars = FlexCell.ScrollBarsEnum.Vertical
        Me.grdLineas.SelectionBorderColor = System.Drawing.Color.Gray
        Me.grdLineas.SelectionMode = FlexCell.SelectionModeEnum.ByRow
        Me.grdLineas.Size = New System.Drawing.Size(766, 584)
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
        Me.Panel1.Controls.Add(Me.GroupBox1)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.cmdRefrescaContenido)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.lblPorContenido)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 307)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ESTADO DEPOSITO "
        '
        'lblHasta
        '
        Me.lblHasta.BackColor = System.Drawing.Color.Moccasin
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHasta.Location = New System.Drawing.Point(9, 273)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(178, 24)
        Me.lblHasta.TabIndex = 143
        Me.lblHasta.Text = "- - -"
        Me.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblBarraContenido)
        Me.Panel3.Location = New System.Drawing.Point(54, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(110, 211)
        Me.Panel3.TabIndex = 142
        '
        'lblBarraContenido
        '
        Me.lblBarraContenido.BackColor = System.Drawing.Color.IndianRed
        Me.lblBarraContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBarraContenido.Location = New System.Drawing.Point(-7, 0)
        Me.lblBarraContenido.Name = "lblBarraContenido"
        Me.lblBarraContenido.Size = New System.Drawing.Size(121, 209)
        Me.lblBarraContenido.TabIndex = 140
        Me.lblBarraContenido.Visible = False
        '
        'cmdRefrescaContenido
        '
        Me.cmdRefrescaContenido.BackColor = System.Drawing.Color.LightBlue
        Me.cmdRefrescaContenido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRefrescaContenido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefrescaContenido.Location = New System.Drawing.Point(6, 16)
        Me.cmdRefrescaContenido.Name = "cmdRefrescaContenido"
        Me.cmdRefrescaContenido.Size = New System.Drawing.Size(23, 21)
        Me.cmdRefrescaContenido.TabIndex = 141
        Me.cmdRefrescaContenido.Text = "R"
        Me.cmdRefrescaContenido.UseVisualStyleBackColor = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Moccasin
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(15, 146)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(33, 13)
        Me.Label41.TabIndex = 138
        Me.Label41.Text = "0.5 -"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Moccasin
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(26, 252)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(22, 13)
        Me.Label40.TabIndex = 137
        Me.Label40.Text = "0 -"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Moccasin
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(26, 45)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(22, 13)
        Me.Label39.TabIndex = 136
        Me.Label39.Text = "1 -"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPorContenido
        '
        Me.lblPorContenido.BackColor = System.Drawing.Color.Moccasin
        Me.lblPorContenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorContenido.Location = New System.Drawing.Point(50, 25)
        Me.lblPorContenido.Name = "lblPorContenido"
        Me.lblPorContenido.Size = New System.Drawing.Size(121, 23)
        Me.lblPorContenido.TabIndex = 135
        Me.lblPorContenido.Text = "- - -"
        Me.lblPorContenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Moccasin
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(6, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(184, 282)
        Me.Label38.TabIndex = 140
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'cmdSaldos
        '
        Me.cmdSaldos.BackColor = System.Drawing.Color.LightBlue
        Me.cmdSaldos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSaldos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSaldos.Location = New System.Drawing.Point(3, 223)
        Me.cmdSaldos.Name = "cmdSaldos"
        Me.cmdSaldos.Size = New System.Drawing.Size(196, 49)
        Me.cmdSaldos.TabIndex = 37
        Me.cmdSaldos.Text = "DATOS SURTIDOR"
        Me.cmdSaldos.UseVisualStyleBackColor = False
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
        'frmRespotajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
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
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents lstGasolineros As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents cmdGrabaGasolinero As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents cmdBorrarGasolinero As Button
    Friend WithEvents cmdRefresca As Button
    Friend WithEvents lblContador As Label
    Friend WithEvents lblTextoContador As Label
    Friend WithEvents cmdSaldos As Button
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdHistorial As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lblPorContenido As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents cmdRefrescaContenido As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblBarraContenido As Label
    Friend WithEvents lblHasta As Label
End Class

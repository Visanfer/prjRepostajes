<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehiculos))
        Me.panContenedor = New System.Windows.Forms.Panel()
        Me.panCentro = New System.Windows.Forms.Panel()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.grdLineas = New FlexCell.Grid()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.chkExternos = New System.Windows.Forms.CheckBox()
        Me.chkAnulados = New System.Windows.Forms.CheckBox()
        Me.chkFurgoneta = New System.Windows.Forms.CheckBox()
        Me.chkHormigonera = New System.Windows.Forms.CheckBox()
        Me.chkCamion_SinGrua = New System.Windows.Forms.CheckBox()
        Me.chkTurismos = New System.Windows.Forms.CheckBox()
        Me.chkCamion_Grua = New System.Windows.Forms.CheckBox()
        Me.panPie = New System.Windows.Forms.Panel()
        Me.lblF1 = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.panTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panContenedor.SuspendLayout()
        Me.panCentro.SuspendLayout()
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
        Me.panContenedor.Size = New System.Drawing.Size(815, 741)
        Me.panContenedor.TabIndex = 155
        '
        'panCentro
        '
        Me.panCentro.BackColor = System.Drawing.SystemColors.Control
        Me.panCentro.Controls.Add(Me.lblFiltro)
        Me.panCentro.Controls.Add(Me.grdLineas)
        Me.panCentro.Controls.Add(Me.chkOtros)
        Me.panCentro.Controls.Add(Me.chkExternos)
        Me.panCentro.Controls.Add(Me.chkAnulados)
        Me.panCentro.Controls.Add(Me.chkFurgoneta)
        Me.panCentro.Controls.Add(Me.chkHormigonera)
        Me.panCentro.Controls.Add(Me.chkCamion_SinGrua)
        Me.panCentro.Controls.Add(Me.chkTurismos)
        Me.panCentro.Controls.Add(Me.chkCamion_Grua)
        Me.panCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panCentro.Location = New System.Drawing.Point(2, 32)
        Me.panCentro.Name = "panCentro"
        Me.panCentro.Size = New System.Drawing.Size(811, 672)
        Me.panCentro.TabIndex = 155
        '
        'lblFiltro
        '
        Me.lblFiltro.BackColor = System.Drawing.Color.White
        Me.lblFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiltro.ForeColor = System.Drawing.Color.Black
        Me.lblFiltro.Location = New System.Drawing.Point(10, 71)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(791, 20)
        Me.lblFiltro.TabIndex = 153
        '
        'grdLineas
        '
        Me.grdLineas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLineas.BackColorBkg = System.Drawing.SystemColors.ControlLightLight
        Me.grdLineas.BorderStyle = FlexCell.BorderStyleEnum.FixedSingle
        Me.grdLineas.CheckedImage = CType(resources.GetObject("grdLineas.CheckedImage"), System.Drawing.Bitmap)
        Me.grdLineas.Cols = 8
        Me.grdLineas.DefaultFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grdLineas.ExtendLastCol = True
        Me.grdLineas.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grdLineas.Location = New System.Drawing.Point(10, 91)
        Me.grdLineas.MultiSelect = False
        Me.grdLineas.Name = "grdLineas"
        Me.grdLineas.Rows = 2
        Me.grdLineas.ScrollBars = FlexCell.ScrollBarsEnum.Vertical
        Me.grdLineas.SelectionBorderColor = System.Drawing.Color.Gray
        Me.grdLineas.SelectionMode = FlexCell.SelectionModeEnum.ByRow
        Me.grdLineas.Size = New System.Drawing.Size(791, 575)
        Me.grdLineas.TabIndex = 152
        Me.grdLineas.TabStop = False
        Me.grdLineas.UncheckedImage = CType(resources.GetObject("grdLineas.UncheckedImage"), System.Drawing.Bitmap)
        '
        'chkOtros
        '
        Me.chkOtros.AutoSize = True
        Me.chkOtros.Location = New System.Drawing.Point(323, 44)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(64, 17)
        Me.chkOtros.TabIndex = 9
        Me.chkOtros.Text = "OTROS"
        Me.chkOtros.UseVisualStyleBackColor = True
        '
        'chkExternos
        '
        Me.chkExternos.AutoSize = True
        Me.chkExternos.Location = New System.Drawing.Point(638, 44)
        Me.chkExternos.Name = "chkExternos"
        Me.chkExternos.Size = New System.Drawing.Size(161, 17)
        Me.chkExternos.TabIndex = 8
        Me.chkExternos.Text = "VER TAMBIEN EXTERNOS"
        Me.chkExternos.UseVisualStyleBackColor = True
        '
        'chkAnulados
        '
        Me.chkAnulados.AutoSize = True
        Me.chkAnulados.Location = New System.Drawing.Point(638, 19)
        Me.chkAnulados.Name = "chkAnulados"
        Me.chkAnulados.Size = New System.Drawing.Size(161, 17)
        Me.chkAnulados.TabIndex = 7
        Me.chkAnulados.Text = "VER TAMBIEN ANULADOS"
        Me.chkAnulados.UseVisualStyleBackColor = True
        '
        'chkFurgoneta
        '
        Me.chkFurgoneta.AutoSize = True
        Me.chkFurgoneta.Location = New System.Drawing.Point(17, 44)
        Me.chkFurgoneta.Name = "chkFurgoneta"
        Me.chkFurgoneta.Size = New System.Drawing.Size(93, 17)
        Me.chkFurgoneta.TabIndex = 6
        Me.chkFurgoneta.Text = "FURGONETA"
        Me.chkFurgoneta.UseVisualStyleBackColor = True
        '
        'chkHormigonera
        '
        Me.chkHormigonera.AutoSize = True
        Me.chkHormigonera.Location = New System.Drawing.Point(154, 44)
        Me.chkHormigonera.Name = "chkHormigonera"
        Me.chkHormigonera.Size = New System.Drawing.Size(108, 17)
        Me.chkHormigonera.TabIndex = 5
        Me.chkHormigonera.Text = "HORMIGONERA"
        Me.chkHormigonera.UseVisualStyleBackColor = True
        '
        'chkCamion_SinGrua
        '
        Me.chkCamion_SinGrua.AutoSize = True
        Me.chkCamion_SinGrua.Location = New System.Drawing.Point(154, 19)
        Me.chkCamion_SinGrua.Name = "chkCamion_SinGrua"
        Me.chkCamion_SinGrua.Size = New System.Drawing.Size(123, 17)
        Me.chkCamion_SinGrua.TabIndex = 4
        Me.chkCamion_SinGrua.Text = "CAMION SIN GRUA"
        Me.chkCamion_SinGrua.UseVisualStyleBackColor = True
        '
        'chkTurismos
        '
        Me.chkTurismos.AutoSize = True
        Me.chkTurismos.Location = New System.Drawing.Point(323, 19)
        Me.chkTurismos.Name = "chkTurismos"
        Me.chkTurismos.Size = New System.Drawing.Size(76, 17)
        Me.chkTurismos.TabIndex = 3
        Me.chkTurismos.Text = "TURISMO"
        Me.chkTurismos.UseVisualStyleBackColor = True
        '
        'chkCamion_Grua
        '
        Me.chkCamion_Grua.AutoSize = True
        Me.chkCamion_Grua.Location = New System.Drawing.Point(17, 19)
        Me.chkCamion_Grua.Name = "chkCamion_Grua"
        Me.chkCamion_Grua.Size = New System.Drawing.Size(102, 17)
        Me.chkCamion_Grua.TabIndex = 2
        Me.chkCamion_Grua.Text = "CAMION GRUA"
        Me.chkCamion_Grua.UseVisualStyleBackColor = True
        '
        'panPie
        '
        Me.panPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.panPie.Controls.Add(Me.lblF1)
        Me.panPie.Controls.Add(Me.lblIntro)
        Me.panPie.Controls.Add(Me.lblSalir)
        Me.panPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panPie.Location = New System.Drawing.Point(2, 704)
        Me.panPie.Name = "panPie"
        Me.panPie.Size = New System.Drawing.Size(811, 35)
        Me.panPie.TabIndex = 154
        '
        'lblF1
        '
        Me.lblF1.AutoSize = True
        Me.lblF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblF1.ForeColor = System.Drawing.Color.White
        Me.lblF1.Location = New System.Drawing.Point(703, 9)
        Me.lblF1.Name = "lblF1"
        Me.lblF1.Size = New System.Drawing.Size(96, 17)
        Me.lblF1.TabIndex = 10
        Me.lblF1.Text = "F1 - NUEVO"
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblIntro.ForeColor = System.Drawing.Color.White
        Me.lblIntro.Location = New System.Drawing.Point(282, 9)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(250, 17)
        Me.lblIntro.TabIndex = 9
        Me.lblIntro.Text = "INTRO - SELECCIONA VEHICULO"
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalir.ForeColor = System.Drawing.Color.White
        Me.lblSalir.Location = New System.Drawing.Point(14, 10)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(98, 17)
        Me.lblSalir.TabIndex = 7
        Me.lblSalir.Text = "ESC - SALIR"
        '
        'panTitulo
        '
        Me.panTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.panTitulo.Controls.Add(Me.lblTitulo)
        Me.panTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo.Location = New System.Drawing.Point(2, 2)
        Me.panTitulo.Name = "panTitulo"
        Me.panTitulo.Size = New System.Drawing.Size(811, 30)
        Me.panTitulo.TabIndex = 153
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(118, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(544, 16)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "BUSCADOR DE VEHICULOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.panContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(537, 636)
        Me.Name = "frmVehiculos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCADOR DE VEHICULOS"
        Me.panContenedor.ResumeLayout(False)
        Me.panCentro.ResumeLayout(False)
        Me.panCentro.PerformLayout()
        Me.panPie.ResumeLayout(False)
        Me.panPie.PerformLayout()
        Me.panTitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panContenedor As Panel
    Friend WithEvents panCentro As Panel
    Friend WithEvents panPie As Panel
    Friend WithEvents lblIntro As Label
    Friend WithEvents lblSalir As Label
    Friend WithEvents panTitulo As Panel
    Private WithEvents lblTitulo As Label
    Friend WithEvents lblF1 As Label
    Friend WithEvents chkHormigonera As CheckBox
    Friend WithEvents chkCamion_SinGrua As CheckBox
    Friend WithEvents chkTurismos As CheckBox
    Friend WithEvents chkCamion_Grua As CheckBox
    Friend WithEvents chkAnulados As CheckBox
    Friend WithEvents chkFurgoneta As CheckBox
    Friend WithEvents chkExternos As CheckBox
    Friend WithEvents chkOtros As CheckBox
    Friend WithEvents grdLineas As FlexCell.Grid
    Friend WithEvents lblFiltro As Label
End Class

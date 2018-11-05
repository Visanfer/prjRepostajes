<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsumos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsumos))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdLineas = New FlexCell.Grid()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 619)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(766, 30)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "ESC - SALIR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdLineas
        '
        Me.grdLineas.BackColorBkg = System.Drawing.SystemColors.ControlLightLight
        Me.grdLineas.BorderStyle = FlexCell.Grid.BorderStyleEnum.FixedSingle
        Me.grdLineas.CheckedImage = CType(resources.GetObject("grdLineas.CheckedImage"), System.Drawing.Bitmap)
        Me.grdLineas.Cols = 8
        Me.grdLineas.ExtendLastCol = True
        Me.grdLineas.Location = New System.Drawing.Point(13, 114)
        Me.grdLineas.MultiSelect = False
        Me.grdLineas.Name = "grdLineas"
        Me.grdLineas.Rows = 2
        Me.grdLineas.ScrollBars = FlexCell.Grid.ScrollBarsEnum.Vertical
        Me.grdLineas.SelectionBorderColor = System.Drawing.Color.Gray
        Me.grdLineas.SelectionMode = FlexCell.Grid.SelectionModeEnum.ByRow
        Me.grdLineas.Size = New System.Drawing.Size(766, 502)
        Me.grdLineas.TabIndex = 165
        Me.grdLineas.TabStop = False
        Me.grdLineas.UncheckedImage = CType(resources.GetObject("grdLineas.UncheckedImage"), System.Drawing.Bitmap)
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(13, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(766, 29)
        Me.lblTitulo.TabIndex = 164
        Me.lblTitulo.Text = "CONSUMO TOTAL POR MATRICULAS Y FECHAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCargar)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 66)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " SELECCIONAR FECHAS "
        '
        'cmdCargar
        '
        Me.cmdCargar.Location = New System.Drawing.Point(261, 23)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(130, 37)
        Me.cmdCargar.TabIndex = 2
        Me.cmdCargar.Text = "CARGAR"
        Me.cmdCargar.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(144, 31)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(111, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(18, 31)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(111, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'frmConsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 658)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdLineas)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(808, 696)
        Me.MinimumSize = New System.Drawing.Size(808, 696)
        Me.Name = "frmConsumos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE CONSUMOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents grdLineas As FlexCell.Grid
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdCargar As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
End Class

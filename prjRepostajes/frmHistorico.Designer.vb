<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistorico))
        Me.grdLineas = New FlexCell.Grid()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'grdLineas
        '
        Me.grdLineas.BackColorBkg = System.Drawing.SystemColors.ControlLightLight
        Me.grdLineas.BorderStyle = FlexCell.Grid.BorderStyleEnum.FixedSingle
        Me.grdLineas.CheckedImage = CType(resources.GetObject("grdLineas.CheckedImage"), System.Drawing.Bitmap)
        Me.grdLineas.Cols = 8
        Me.grdLineas.ExtendLastCol = True
        Me.grdLineas.Location = New System.Drawing.Point(12, 41)
        Me.grdLineas.MultiSelect = False
        Me.grdLineas.Name = "grdLineas"
        Me.grdLineas.Rows = 2
        Me.grdLineas.ScrollBars = FlexCell.Grid.ScrollBarsEnum.Vertical
        Me.grdLineas.SelectionBorderColor = System.Drawing.Color.Gray
        Me.grdLineas.SelectionMode = FlexCell.Grid.SelectionModeEnum.ByRow
        Me.grdLineas.Size = New System.Drawing.Size(524, 538)
        Me.grdLineas.TabIndex = 166
        Me.grdLineas.TabStop = False
        Me.grdLineas.UncheckedImage = CType(resources.GetObject("grdLineas.UncheckedImage"), System.Drawing.Bitmap)
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(524, 29)
        Me.lblTitulo.TabIndex = 167
        Me.lblTitulo.Text = "DETALLE LOS ULTIMOS 6 MESES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 582)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(524, 30)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "ESC - SALIR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'frmHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.grdLineas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmHistorico"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORICO REPOSTAJES"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdLineas As FlexCell.Grid
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class

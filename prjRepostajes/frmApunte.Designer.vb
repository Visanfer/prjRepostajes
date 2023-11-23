<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmApunte
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.txtLitros = New System.Windows.Forms.TextBox()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.lblAvisoF1 = New System.Windows.Forms.Label()
        Me.txtKilometros = New System.Windows.Forms.TextBox()
        Me.lblKilometros = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(524, 30)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "ESC - SALIR                  F5 - GRABAR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMatricula
        '
        Me.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMatricula.Location = New System.Drawing.Point(107, 47)
        Me.txtMatricula.MaxLength = 30
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(130, 20)
        Me.txtMatricula.TabIndex = 0
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(20, 50)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(72, 13)
        Me.lblMatricula.TabIndex = 169
        Me.lblMatricula.Text = "MATRICULA:"
        '
        'txtLitros
        '
        Me.txtLitros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLitros.Location = New System.Drawing.Point(107, 91)
        Me.txtLitros.MaxLength = 30
        Me.txtLitros.Name = "txtLitros"
        Me.txtLitros.Size = New System.Drawing.Size(130, 20)
        Me.txtLitros.TabIndex = 2
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Location = New System.Drawing.Point(20, 94)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(49, 13)
        Me.lblLitros.TabIndex = 171
        Me.lblLitros.Text = "LITROS:"
        '
        'lblAviso
        '
        Me.lblAviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.Location = New System.Drawing.Point(256, 47)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(280, 64)
        Me.lblAviso.TabIndex = 172
        Me.lblAviso.Text = "* METE UN REPOSTAJE INMEDIATAMENTE ANTERIOR AL APUNTE SELECCIONADO"
        Me.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvisoF1
        '
        Me.lblAvisoF1.BackColor = System.Drawing.SystemColors.Info
        Me.lblAvisoF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvisoF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvisoF1.Location = New System.Drawing.Point(12, 2)
        Me.lblAvisoF1.Name = "lblAvisoF1"
        Me.lblAvisoF1.Size = New System.Drawing.Size(524, 24)
        Me.lblAvisoF1.TabIndex = 173
        Me.lblAvisoF1.Text = "F1 - METER LITROS DE LA HOJA"
        Me.lblAvisoF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKilometros
        '
        Me.txtKilometros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKilometros.Location = New System.Drawing.Point(107, 69)
        Me.txtKilometros.MaxLength = 30
        Me.txtKilometros.Name = "txtKilometros"
        Me.txtKilometros.Size = New System.Drawing.Size(130, 20)
        Me.txtKilometros.TabIndex = 1
        '
        'lblKilometros
        '
        Me.lblKilometros.AutoSize = True
        Me.lblKilometros.Location = New System.Drawing.Point(20, 73)
        Me.lblKilometros.Name = "lblKilometros"
        Me.lblKilometros.Size = New System.Drawing.Size(80, 13)
        Me.lblKilometros.TabIndex = 175
        Me.lblKilometros.Text = "KILOMETROS:"
        '
        'frmApunte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKilometros)
        Me.Controls.Add(Me.lblKilometros)
        Me.Controls.Add(Me.lblAvisoF1)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.txtLitros)
        Me.Controls.Add(Me.lblLitros)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(564, 213)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(564, 213)
        Me.Name = "frmApunte"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA/MODIFICACION REPOSTAJE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents lblMatricula As Label
    Friend WithEvents txtLitros As TextBox
    Friend WithEvents lblLitros As Label
    Friend WithEvents lblAviso As Label
    Friend WithEvents lblAvisoF1 As Label
    Friend WithEvents txtKilometros As TextBox
    Friend WithEvents lblKilometros As Label
End Class

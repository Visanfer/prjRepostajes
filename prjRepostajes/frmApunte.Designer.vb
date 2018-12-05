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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLitros = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "MATRICULA:"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "LITROS:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 64)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "* METE UN REPOSTAJE INMEDIATAMENTE ANTERIOR AL APUNTE SELECCIONADO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Info
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(524, 24)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "F1 - METER LITROS DE LA HOJA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKilometros
        '
        Me.txtKilometros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKilometros.Location = New System.Drawing.Point(107, 69)
        Me.txtKilometros.MaxLength = 30
        Me.txtKilometros.Name = "txtKilometros"
        Me.txtKilometros.Size = New System.Drawing.Size(130, 20)
        Me.txtKilometros.TabIndex = 1
        Me.txtKilometros.Visible = False
        '
        'lblKilometros
        '
        Me.lblKilometros.AutoSize = True
        Me.lblKilometros.Location = New System.Drawing.Point(20, 73)
        Me.lblKilometros.Name = "lblKilometros"
        Me.lblKilometros.Size = New System.Drawing.Size(80, 13)
        Me.lblKilometros.TabIndex = 175
        Me.lblKilometros.Text = "KILOMETROS:"
        Me.lblKilometros.Visible = False
        '
        'frmApunte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKilometros)
        Me.Controls.Add(Me.lblKilometros)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLitros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label5)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLitros As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKilometros As TextBox
    Friend WithEvents lblKilometros As Label
End Class

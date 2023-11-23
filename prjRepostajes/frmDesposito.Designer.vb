<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesposito
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
        Me.lstCargas = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpGasolineros = New System.Windows.Forms.GroupBox()
        Me.txtCarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdGrabaCarga = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblContenido = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaCarga = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraCarga = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraEstimado = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEstimado = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpGasolineros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCargas
        '
        Me.lstCargas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstCargas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCargas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader8})
        Me.lstCargas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCargas.FullRowSelect = True
        Me.lstCargas.GridLines = True
        Me.lstCargas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstCargas.HideSelection = False
        Me.lstCargas.Location = New System.Drawing.Point(6, 19)
        Me.lstCargas.MultiSelect = False
        Me.lstCargas.Name = "lstCargas"
        Me.lstCargas.Size = New System.Drawing.Size(378, 230)
        Me.lstCargas.TabIndex = 154
        Me.lstCargas.UseCompatibleStateImageBehavior = False
        Me.lstCargas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "FECHA"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "CARGA"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 200
        '
        'grpGasolineros
        '
        Me.grpGasolineros.Controls.Add(Me.dtpHoraCarga)
        Me.grpGasolineros.Controls.Add(Me.dtpFechaCarga)
        Me.grpGasolineros.Controls.Add(Me.Label5)
        Me.grpGasolineros.Controls.Add(Me.txtCarga)
        Me.grpGasolineros.Controls.Add(Me.Label3)
        Me.grpGasolineros.Controls.Add(Me.cmdGrabaCarga)
        Me.grpGasolineros.Controls.Add(Me.lstCargas)
        Me.grpGasolineros.Location = New System.Drawing.Point(17, 98)
        Me.grpGasolineros.Name = "grpGasolineros"
        Me.grpGasolineros.Size = New System.Drawing.Size(549, 255)
        Me.grpGasolineros.TabIndex = 150
        Me.grpGasolineros.TabStop = False
        Me.grpGasolineros.Text = " LISTADO DE CARGAS DEL DEPOSITO "
        '
        'txtCarga
        '
        Me.txtCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarga.Location = New System.Drawing.Point(413, 74)
        Me.txtCarga.MaxLength = 30
        Me.txtCarga.Name = "txtCarga"
        Me.txtCarga.Size = New System.Drawing.Size(96, 20)
        Me.txtCarga.TabIndex = 160
        Me.txtCarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "LITROS:"
        '
        'cmdGrabaCarga
        '
        Me.cmdGrabaCarga.BackColor = System.Drawing.Color.Gray
        Me.cmdGrabaCarga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGrabaCarga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabaCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabaCarga.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGrabaCarga.Location = New System.Drawing.Point(390, 19)
        Me.cmdGrabaCarga.Name = "cmdGrabaCarga"
        Me.cmdGrabaCarga.Size = New System.Drawing.Size(143, 30)
        Me.cmdGrabaCarga.TabIndex = 158
        Me.cmdGrabaCarga.Text = "METER CARGA"
        Me.cmdGrabaCarga.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpHoraEstimado)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEstimado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCapacidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnGrabar)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 80)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " DATOS DEL DEPOSITO "
        '
        'txtSaldo
        '
        Me.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo.Location = New System.Drawing.Point(14, 50)
        Me.txtSaldo.MaxLength = 30
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(96, 20)
        Me.txtSaldo.TabIndex = 162
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "LITROS ESTIMADOS QUE HAY"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapacidad.Location = New System.Drawing.Point(14, 27)
        Me.txtCapacidad.MaxLength = 30
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(96, 20)
        Me.txtCapacidad.TabIndex = 160
        Me.txtCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "CAPACIDAD TOTAL"
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.Gray
        Me.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGrabar.Location = New System.Drawing.Point(428, 44)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(105, 30)
        Me.btnGrabar.TabIndex = 159
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblContenido)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 54)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 20)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "CONTENIDO ACTUAL DEL DEPOSITO "
        '
        'lblContenido
        '
        Me.lblContenido.BackColor = System.Drawing.Color.Lime
        Me.lblContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContenido.Location = New System.Drawing.Point(352, 14)
        Me.lblContenido.Name = "lblContenido"
        Me.lblContenido.Size = New System.Drawing.Size(181, 33)
        Me.lblContenido.TabIndex = 163
        Me.lblContenido.Text = "1250 litros "
        Me.lblContenido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "FECHA:"
        '
        'dtpFechaCarga
        '
        Me.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCarga.Location = New System.Drawing.Point(413, 124)
        Me.dtpFechaCarga.Name = "dtpFechaCarga"
        Me.dtpFechaCarga.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaCarga.TabIndex = 163
        '
        'dtpHoraCarga
        '
        Me.dtpHoraCarga.CustomFormat = "HH:mm"
        Me.dtpHoraCarga.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraCarga.Location = New System.Drawing.Point(413, 144)
        Me.dtpHoraCarga.Name = "dtpHoraCarga"
        Me.dtpHoraCarga.ShowUpDown = True
        Me.dtpHoraCarga.Size = New System.Drawing.Size(96, 20)
        Me.dtpHoraCarga.TabIndex = 164
        '
        'dtpHoraEstimado
        '
        Me.dtpHoraEstimado.CustomFormat = "HH:mm"
        Me.dtpHoraEstimado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraEstimado.Location = New System.Drawing.Point(310, 50)
        Me.dtpHoraEstimado.Name = "dtpHoraEstimado"
        Me.dtpHoraEstimado.ShowUpDown = True
        Me.dtpHoraEstimado.Size = New System.Drawing.Size(96, 20)
        Me.dtpHoraEstimado.TabIndex = 167
        '
        'dtpFechaEstimado
        '
        Me.dtpFechaEstimado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEstimado.Location = New System.Drawing.Point(310, 30)
        Me.dtpFechaEstimado.Name = "dtpFechaEstimado"
        Me.dtpFechaEstimado.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaEstimado.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "FECHA:"
        '
        'frmDesposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpGasolineros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(597, 450)
        Me.MinimumSize = New System.Drawing.Size(597, 450)
        Me.Name = "frmDesposito"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTION DEPOSITO"
        Me.grpGasolineros.ResumeLayout(False)
        Me.grpGasolineros.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCargas As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents grpGasolineros As GroupBox
    Friend WithEvents cmdGrabaCarga As Button
    Friend WithEvents txtCarga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblContenido As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpHoraCarga As DateTimePicker
    Friend WithEvents dtpFechaCarga As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpHoraEstimado As DateTimePicker
    Friend WithEvents dtpFechaEstimado As DateTimePicker
    Friend WithEvents Label6 As Label
End Class

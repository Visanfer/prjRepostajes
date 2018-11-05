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
        Me.lstVehiculos = New System.Windows.Forms.ListView()
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstVehiculos
        '
        Me.lstVehiculos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lstVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstVehiculos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader24, Me.ColumnHeader25})
        Me.lstVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehiculos.GridLines = True
        Me.lstVehiculos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstVehiculos.HideSelection = False
        Me.lstVehiculos.Location = New System.Drawing.Point(12, 12)
        Me.lstVehiculos.MultiSelect = False
        Me.lstVehiculos.Name = "lstVehiculos"
        Me.lstVehiculos.Size = New System.Drawing.Size(497, 550)
        Me.lstVehiculos.TabIndex = 1
        Me.lstVehiculos.UseCompatibleStateImageBehavior = False
        Me.lstVehiculos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "MATRICULA"
        Me.ColumnHeader24.Width = 100
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "DESCRIPCION"
        Me.ColumnHeader25.Width = 370
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 565)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(497, 24)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "INTRO - SELECCIONAR VEHICULO            ESC - SALIR"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lstVehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(537, 636)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(537, 636)
        Me.Name = "frmVehiculos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCADOR DE VEHICULOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstVehiculos As ListView
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents Label20 As Label
End Class

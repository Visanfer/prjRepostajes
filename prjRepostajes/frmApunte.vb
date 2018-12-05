Option Explicit On

Imports prjControl

Public Class frmApunte

    Public mbEditarApunte As Boolean = False
    Public msMatricula As String = 0
    Public mnLitros As Double = 0
    Public mnKilometros As Long = 0

    Public Sub mrCargar()
        If msMatricula.Length > 0 Then txtMatricula.Text = msMatricula
        If mnLitros > 0 Then txtLitros.Text = mnLitros
        If mnKilometros > 0 Then txtKilometros.Text = mnKilometros
        If mbEditarApunte Then
            lblKilometros.Visible = True
            txtKilometros.Visible = True
        End If
        Me.ShowDialog()
    End Sub

    Private Sub frmApunte_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.F1
                txtMatricula.Text = "0002VIS"
                txtLitros.Focus()
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                mnLitros = 0
                Me.Close()
            Case Keys.F5
                mrGrabar()
        End Select

    End Sub

    Private Sub mrGrabar()

        msMatricula = txtMatricula.Text
        mnLitros = mfnDouble(txtLitros.Text)
        mnKilometros = mfnLong(txtKilometros.Text)
        Me.Close()

    End Sub

End Class
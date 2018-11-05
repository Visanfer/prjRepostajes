Option Explicit On

Imports prjControl

Public Class frmApunte

    Public msMatricula As String = 0
    Public mnLitros As Double = 0

    Public Sub mrCargar()
        If msMatricula.Length > 0 Then txtMatricula.Text = msMatricula
        If mnLitros > 0 Then txtLitros.Text = mnLitros
        Me.ShowDialog()
    End Sub

    Private Sub frmApunte_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Escape
                Me.Close()
            Case Keys.F5
                mrGrabar
        End Select

    End Sub

    Private Sub mrGrabar()

        msMatricula = txtMatricula.Text
        mnLitros = mfnDouble(txtLitros.Text)
        Me.Close()

    End Sub

End Class
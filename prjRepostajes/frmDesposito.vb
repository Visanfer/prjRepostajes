Option Explicit On

Public Class frmDesposito

    Public mnIdDeposito As Integer = 0

    Public Sub mrCargar()
        mrCargaDatos()
        mrCargaCargas()
        Me.ShowDialog()
    End Sub

    Private Sub mrCargaDatos()

        Dim loDesposito As New clsDeposito
        loDesposito.mnIdDeposito = mnIdDeposito
        loDesposito.mrRecuperaDatos()

        txtCapacidad.Text = Format(loDesposito.mnCapacidad, "0")
        txtSaldo.Text = Format(loDesposito.mnLitrosSaldo, "0")
        'lblFechaSaldo.Text = "(" & Format(loDesposito.mdFechaSaldo, "dd/MM/yyyy HH:mm:ss") & ")"
        dtpFechaEstimado.Value = loDesposito.mdFechaSaldo
        dtpHoraEstimado.Value = loDesposito.mdFechaSaldo
        lblContenido.Text = Format(loDesposito.mfnContenidoActual(), "0") & " litros"

        dtpFechaCarga.Value = Now
        dtpHoraCarga.Value = Now

    End Sub

    Private Sub mrCargaCargas()

        Dim loDesposito As New clsDeposito
        loDesposito.mnIdDeposito = mnIdDeposito
        loDesposito.mrRecuperaCargas()

        lstCargas.BeginUpdate()
        lstCargas.Items.Clear()
        For Each loRegistro In loDesposito.moDatos.Rows
            Dim loItem As New ListViewItem
            loItem.Text = Format(loRegistro("fechahora"), "dd/MM/yyyy HH:mm:ss")
            loItem.SubItems.Add(Format(loRegistro("litros"), "0"))
            lstCargas.Items.Add(loItem)
        Next
        lstCargas.EndUpdate()

    End Sub

    Private Sub frmDesposito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        mrGrabarSaldo()
    End Sub

    Private Sub mrGrabarSaldo()

        Dim loDesposito As New clsDeposito
        loDesposito.mnIdDeposito = mnIdDeposito
        loDesposito.mrRecuperaDatos()

        loDesposito.mnCapacidad = Val(txtCapacidad.Text)
        loDesposito.mnLitrosSaldo = Val(txtSaldo.Text)
        loDesposito.mdFechaSaldo = CDate(dtpFechaEstimado.Text & " " & dtpHoraEstimado.Text)
        loDesposito.mrGrabaDatos()

        mrCargaDatos()

    End Sub

    Private Sub mrGrabaCarga()

        Dim lnLitros As Double = Val(txtCarga.Text)

        If lnLitros > 0 Then

            Dim loCarga As New clsCarga
            loCarga.mnIdDeposito = mnIdDeposito
            loCarga.mnLitros = lnLitros
            loCarga.mdFechaHora = CDate(dtpFechaCarga.Text & " " & dtpHoraCarga.Text)
            loCarga.mrGrabaDatos()

            mrCargaCargas()

        Else
            MsgBox("DEBES INDICAR LOS LITROS QUE SE HAN CARGADO", MsgBoxStyle.Exclamation, "Visanfer.Net")
            txtCarga.Focus()
        End If

    End Sub

    Private Sub cmdGrabaCarga_Click(sender As Object, e As EventArgs) Handles cmdGrabaCarga.Click
        mrGrabaCarga()
    End Sub

End Class
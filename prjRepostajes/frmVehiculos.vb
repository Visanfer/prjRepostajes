Option Explicit On

Public Class frmVehiculos

    Public mnVehiculoSeleccionado As Integer = 0
    Private mbPrimeraVez As Boolean = True

    Public Sub mrCargar()

        Me.ShowDialog()

    End Sub

    Private Sub mrCargaVehiculos()

        Dim loBusVehiculos As New clsBusRepostajes
        loBusVehiculos.mrRecuperaMatriculas()

        lstVehiculos.BeginUpdate()

        For Each loRow As DataRow In loBusVehiculos.moGrupoDatos.Tables("matriculas").Rows
            Dim loItem As New ListViewItem
            loItem.Text = loRow("idmatricula")
            loItem.SubItems.Add(loRow("matricula"))
            loItem.SubItems.Add(loRow("descripcion"))
            lstVehiculos.Items.Add(loItem)
        Next

        lstVehiculos.EndUpdate()

        lstVehiculos.Focus()
        SendKeys.Send("{LEFT}")
        SendKeys.Send("{DOWN}")

    End Sub

    Private Sub frmVehiculos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                mrSelecciona
        End Select

    End Sub

    Private Sub mrSelecciona()

        Dim loItem As ListViewItem = lstVehiculos.SelectedItems(0)
        mnVehiculoSeleccionado = Val(loItem.Text)
        Me.Close()

    End Sub

    Private Sub frmVehiculos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If mbPrimeraVez Then
            mbPrimeraVez = False
            mrCargaVehiculos()
        End If

    End Sub

End Class
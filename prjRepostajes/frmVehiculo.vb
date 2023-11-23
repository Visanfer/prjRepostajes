Option Explicit On

Imports prjControl

Public Class frmVehiculo

    Public moVehiculo As clsMatricula
    Public mbRegistroGrabado As Boolean = False

    Public Sub mrCargar()
        mrRellenaCampos()
        Me.ShowDialog()
    End Sub

    Private Sub frmVehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
            Case Keys.F5
                mrGrabar()
        End Select

    End Sub

    Private Function mfsMatricula() As String

        Dim lsMatricula As String = txtMatricula.Text
        lsMatricula = lsMatricula.Replace("-", "")
        lsMatricula = lsMatricula.Replace(" ", "")

        Return lsMatricula.ToUpper

    End Function

    Private Sub mrGrabar()

        moVehiculo.mnIdMatricula = Val(txtCodigo.Text)
        moVehiculo.msMatricula = mfsMatricula()
        moVehiculo.msDescripcion = txtDescripcion.Text
        moVehiculo.mnActivo = IIf(chkActivo.Checked, 1, 0)
        moVehiculo.mnTipo = cboTipo.SelectedIndex + 1
        moVehiculo.msObservaciones = txtObservaciones.Text

        moVehiculo.mnRepostajePermitido = IIf(chkRepostaje.Checked, 1, 0)
        moVehiculo.mnObligatorioKms = IIf(chkObligatorioKms.Checked, 1, 0)
        moVehiculo.mnLitrosMaximos = Val(txtDeposito.Text)

        moVehiculo.msPoliza = txtPoliza.Text
        moVehiculo.msAseguradora = txtCompañia.Text
        moVehiculo.mdInicioSeguro = dtpInicio.Value
        moVehiculo.mdFinalSeguro = dtpFinal.Value
        moVehiculo.mnImporteSeguro = mfnDouble(txtImporte.Text)

        moVehiculo.mnTara = Val(txtTara.Text)
        moVehiculo.mnPMA = Val(txtPMA.Text)
        moVehiculo.mnRenting = IIf(chkRenting.Checked, 1, 0)
        moVehiculo.mnExterno = IIf(chkExterno.Checked, 1, 0)
        'moVehiculo.mnReparto = IIf(chkReparto.Checked, 1, 0)

        If moVehiculo.msMatricula.Length = 0 Then
            MsgBox("DEBES PONER LA MATRICULA DEL VEHICULO.", MsgBoxStyle.Information, "Visanfer.Net")
            txtMatricula.Focus()
            Exit Sub
        End If

        ' debo comprobar que la matricula no exista
        If moVehiculo.mnIdMatricula = 0 Then
            Dim loVehiculo As New clsMatricula
            loVehiculo.msMatricula = moVehiculo.msMatricula
            loVehiculo.mrRecuperaDatos()
            If Not loVehiculo.mbEsNuevo Then
                MsgBox("ATENCIÓN, ESTA MATRICULA YA ESTÁ REGISTRADA EN EL SISTEMA.", MsgBoxStyle.Information, "Visanfer.Net")
                txtMatricula.Focus()
                Exit Sub
            End If
        End If

        If moVehiculo.msDescripcion.Length = 0 Then
            MsgBox("DEBES PONER ALGUNA DESCRIPCION.", MsgBoxStyle.Information, "Visanfer.Net")
            txtDescripcion.Focus()
            Exit Sub
        End If

        If moVehiculo.mnTipo = 0 Then
            MsgBox("DEBES INDICAR EL TIPO DE VEHICULO.", MsgBoxStyle.Information, "Visanfer.Net")
            cboTipo.Focus()
            Exit Sub
        End If

        moVehiculo.mrGrabaDatos()
        mrRellenaCampos()

        lblOK.Visible = True
        tmrOK.Enabled = True
        mbRegistroGrabado = True
        'MsgBox("DATOS GRABADOS.", MsgBoxStyle.Information, "Visanfer.Net")

    End Sub

    Private Sub mrRellenaCampos()

        If moVehiculo.mbEsNuevo Then
            lblTitulo.Text = "NUEVO REGISTRO"
            lblTitulo.BackColor = Color.Green
            lblTitulo.ForeColor = Color.Black
        Else
            ' VUELO A LEER PARA TENER LA ULTIMA VERSION
            moVehiculo.mrRecuperaDatos()
            lblTitulo.Text = "MODIFICACION DE REGISTRO"
            lblTitulo.BackColor = Color.Red
            lblTitulo.ForeColor = Color.White
        End If

        txtCodigo.Text = moVehiculo.mnIdMatricula
        txtMatricula.Text = moVehiculo.msMatricula
        txtDescripcion.Text = moVehiculo.msDescripcion
        chkActivo.Checked = (moVehiculo.mnActivo = 1)
        cboTipo.SelectedIndex = moVehiculo.mnTipo - 1
        txtObservaciones.Text = moVehiculo.msObservaciones

        chkRepostaje.Checked = (moVehiculo.mnRepostajePermitido = 1)
        chkObligatorioKms.Checked = (moVehiculo.mnObligatorioKms = 1)
        txtDeposito.Text = moVehiculo.mnLitrosMaximos

        txtPoliza.Text = moVehiculo.msPoliza
        txtCompañia.Text = moVehiculo.msAseguradora
        dtpInicio.Text = Format(moVehiculo.mdInicioSeguro, "dd/MM/yyyy")
        dtpFinal.Text = Format(moVehiculo.mdFinalSeguro, "dd/MM/yyyy")
        txtImporte.Text = Format(moVehiculo.mnImporteSeguro, "0.00")

        txtTara.Text = moVehiculo.mnTara
        txtPMA.Text = moVehiculo.mnPMA
        chkRenting.Checked = (moVehiculo.mnRenting = 1)
        chkExterno.Checked = (moVehiculo.mnExterno = 1)
        'chkReparto.Checked = (moVehiculo.mnReparto = 1)

    End Sub

    Private Sub tmrOK_Tick(sender As Object, e As EventArgs) Handles tmrOK.Tick
        tmrOK.Enabled = False
        lblOK.Visible = False
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
End Class
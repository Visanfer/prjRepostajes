Option Explicit On

Imports prjControl

Public Class frmRespotajes

    Public mnEmpresa As Integer
    Private moBusRepostajes As clsBusRepostajes
    Private mbPrimeraVez As Boolean = True

    Public Sub mrCargar(ByVal loUsuario As clsUsuario)

        goUsuario = loUsuario
        ' **** recupero los datos del profile **************
        modRepostajes.goProfile.mrRecuperaDatos()
        ' **************************************************

        mrSituaControles()
        mrPreparaGrid()

        Me.ShowDialog()

    End Sub

    Private Sub mrSituaControles()

        grpGasolineros.Top = grpVehiculos.Top
        grpGasolineros.Left = grpVehiculos.Left

    End Sub

    Private Sub mrPreparaGrid()

        ' GRID DE Los articulos *******************
        grdLineas.Visible = False
        grdLineas.Row(0).Visible = True
        grdLineas.Rows = 1

        grdLineas.DisplayRowNumber = False
        grdLineas.Cols = 9

        'grdLineas.EnterKeyMoveTo = FlexCell.Grid.MoveToEnum.NextRow
        grdLineas.SelectionMode = FlexCell.Grid.SelectionModeEnum.ByRow
        grdLineas.AllowUserSort = False
        grdLineas.DisplayFocusRect = False
        grdLineas.AllowUserResizing = False
        grdLineas.ExtendLastCol = True
        grdLineas.FixedRowColStyle = FlexCell.Grid.FixedRowColStyleEnum.Flat
        grdLineas.BorderStyle = FlexCell.Grid.BorderStyleEnum.FixedSingle
        grdLineas.DateFormat = FlexCell.Grid.DateFormatEnum.DMY
        grdLineas.BackColorSel = Color.Navy
        grdLineas.BackColorFixed = Color.FromKnownColor(KnownColor.ControlLight)
        grdLineas.CellBorderColorFixed = Color.Black
        grdLineas.GridColor = Color.FromArgb(148, 190, 231)

        grdLineas.Cell(0, 0).Text = ""
        grdLineas.Cell(0, 1).Text = "COD"
        grdLineas.Cell(0, 2).Text = "FECHA"
        grdLineas.Cell(0, 3).Text = "MATRICULA"
        grdLineas.Cell(0, 4).Text = "KMS."
        grdLineas.Cell(0, 5).Text = "LITROS"
        grdLineas.Cell(0, 6).Text = "LLENO"
        grdLineas.Cell(0, 7).Text = "GASOLINERO"
        grdLineas.Cell(0, 8).Text = "DESCRIPCION"

        grdLineas.Column(0).Visible = False
        grdLineas.Column(1).Visible = False

        grdLineas.Column(0).Width = 0
        grdLineas.Column(1).Width = 30
        grdLineas.Column(2).Width = 130
        grdLineas.Column(3).Width = 75
        grdLineas.Column(4).Width = 75
        grdLineas.Column(5).Width = 60
        grdLineas.Column(6).Width = 50
        grdLineas.Column(7).Width = 200
        grdLineas.Column(8).Width = 100

        grdLineas.Column(0).Alignment = FlexCell.Grid.AlignmentEnum.RightCenter
        grdLineas.Column(1).Alignment = FlexCell.Grid.AlignmentEnum.RightCenter
        grdLineas.Column(2).Alignment = FlexCell.Grid.AlignmentEnum.CenterCenter
        grdLineas.Column(3).Alignment = FlexCell.Grid.AlignmentEnum.CenterCenter
        grdLineas.Column(4).Alignment = FlexCell.Grid.AlignmentEnum.RightCenter
        grdLineas.Column(5).Alignment = FlexCell.Grid.AlignmentEnum.RightCenter
        grdLineas.Column(6).Alignment = FlexCell.Grid.AlignmentEnum.CenterCenter
        grdLineas.Column(7).Alignment = FlexCell.Grid.AlignmentEnum.LeftCenter
        grdLineas.Column(8).Alignment = FlexCell.Grid.AlignmentEnum.LeftCenter

        grdLineas.Visible = True

    End Sub

    Private Sub frmRespotajes_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If goUsuario Is Nothing Then
            goUsuario = New clsUsuario
            goUsuario.mrBloquear(gnLlave)
        End If
        Me.Text = goUsuario.msNombre

        If mbPrimeraVez Then
            mbPrimeraVez = False
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub mrBorraGasolinero()

        If lstGasolineros.SelectedItems.Count = 0 Then Exit Sub

        Dim lsRes As MsgBoxResult = MsgBox("Realmente deseas borrar este registro",
                                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Visanfer.Net")
        If lsRes = MsgBoxResult.No Then Exit Sub

        Dim loGasolinero As New clsGasolinero
        loGasolinero.mnIdUsuario = mfnInt32(lstGasolineros.SelectedItems(0).Text)
        loGasolinero.mrBorraDatos()

        mrCargaGasolineros()

        lstGasolineros.Focus()
        SendKeys.Send("{HOME}")
        SendKeys.Send("{LEFT}")

    End Sub

    Private Sub mrNuevoGasolineroChofer()

        prjUsuarios.goUsuario = goUsuario
        prjChoferes.goUsuario = goUsuario

        Dim loBusUsuario As New prjUsuarios.clsBusUsuarios
        loBusUsuario.mnLlaveBusqueda = 141
        loBusUsuario.msActivos = "S"
        loBusUsuario.mrBuscaUsuarios()

        Dim loBuscaUsuario As New prjUsuarios.frmBusUsuarios
        loBuscaUsuario.mbSeleccionaUsuario = True
        loBuscaUsuario.mrCargar(loBusUsuario)

        If loBuscaUsuario.mnUsuarioSeleccionado > 0 Then
            Dim loGasolinero As New clsGasolinero
            loGasolinero.mnIdUsuario = loBuscaUsuario.mnUsuarioSeleccionado

            Dim loBusChofer As New prjChoferes.frmChoferes
            loBusChofer.mbBuscarChofer = True
            loBusChofer.mrCargar(mnEmpresa, goUsuario)

            If loBusChofer.mnChoferSeleccionado > 0 Then

                loGasolinero.mnIdChofer = loBusChofer.mnChoferSeleccionado
                loGasolinero.mbEsNuevo = True
                loGasolinero.mrGrabaDatos()

                mrCargaGasolineros()

                lstGasolineros.Focus()
                SendKeys.Send("{HOME}")
                SendKeys.Send("{LEFT}")

            End If

        End If

    End Sub

    Private Sub mrNuevoApunte()

        Dim loFormularioApunte As New frmApunte
        loFormularioApunte.mrCargar()
        If (loFormularioApunte.msMatricula.Length > 0) AndAlso (loFormularioApunte.mnLitros > 0) Then

            loFormularioApunte.msMatricula = loFormularioApunte.msMatricula.Replace("-", "")
            loFormularioApunte.msMatricula = loFormularioApunte.msMatricula.Replace(".", "")
            loFormularioApunte.msMatricula = loFormularioApunte.msMatricula.Replace(" ", "")

            Dim loMatricula As New clsMatricula
            loMatricula.msMatricula = loFormularioApunte.msMatricula
            loMatricula.mrRecuperaDatos()
            If loMatricula.mbEsNuevo Then
                MsgBox("LA MATRICULA METIDA NO ES CORRECTA", MsgBoxStyle.Critical, "Visanfer.Net")
            Else
                Dim ldFechaApunte As Date = CDate(grdLineas.Cell(grdLineas.ActiveCell.Row, 2).Text)
                ldFechaApunte = DateAdd(DateInterval.Second, -1, ldFechaApunte)

                Dim loRepostaje As New clsRepostaje
                loRepostaje.msMatricula = loMatricula.msMatricula
                loRepostaje.mdFechaHora = ldFechaApunte
                loRepostaje.mnGasolinero = prjRepostajes.goUsuario.mnCodigo
                loRepostaje.mnKilometros = 0
                loRepostaje.mnLitros = loFormularioApunte.mnLitros
                loRepostaje.mnLleno = 0
                loRepostaje.mrGrabaDatos()

                ' refresco los datos del repostaje
                mrCargaRepostajes()
            End If

        End If

    End Sub

    Private Sub mrEstadistica()

        Dim loEstadistica As New clsEstadistica
        loEstadistica.msMatricula = grdLineas.Cell(grdLineas.ActiveCell.Row, 3).Text
        loEstadistica.mrCalculaEstadistica()

        MsgBox(loEstadistica.msResultado & vbCrLf &
               "Cons.Medio=" & Format(loEstadistica.mnConsumoMedio, "0.00") & "litros a los 100kms" & vbCrLf &
               "Cons.Global=" & Format(loEstadistica.mnConsumoMedioGlobal, "0.00") & "litros a los 100kms")

    End Sub

    Private Sub frmRespotajes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.F1
                If grdLineas.Focused Then mrNuevoApunte()
            Case Keys.F6
                If grdLineas.Focused Then mrBorraApunte()
            Case Keys.Enter
                If grdLineas.Focused Then mrEditaRepostaje()
            Case Keys.F5
                mrCargaRepostajes()
            Case Keys.F9
                If grdLineas.Focused Then mrEstadistica()
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub mrEditaRepostaje()

        If prjRepostajes.goUsuario.mnCodigo <> 206 Then Exit Sub

        Dim loFormularioApunte As New frmApunte
        loFormularioApunte.msMatricula = grdLineas.Cell(grdLineas.ActiveCell.Row, 3).Text
        loFormularioApunte.mnLitros = mfnDouble(grdLineas.Cell(grdLineas.ActiveCell.Row, 5).Text)
        loFormularioApunte.mrCargar()
        If (loFormularioApunte.mnLitros > 0) Then

            Dim loRepostaje As New clsRepostaje
            loRepostaje.mnIdRepostaje = mfnInt32(grdLineas.Cell(grdLineas.ActiveCell.Row, 0).Text)
            loRepostaje.mrRecuperaDatos()
            loRepostaje.mnLitros = loFormularioApunte.mnLitros
            loRepostaje.mrGrabaDatos()

            ' refresco los datos del repostaje
            mrCargaRepostajes()

        End If


    End Sub

    Private Sub mrBorraApunte()

        If prjRepostajes.goUsuario.mnCodigo <> 206 Then Exit Sub

        Dim lsRes As MsgBoxResult = MsgBox("¿Realmente deseas borrar el apunte?", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Visanfer.Net")
        If lsRes = MsgBoxResult.Yes Then
            Dim loRepostaje As New clsRepostaje
            loRepostaje.mnIdRepostaje = mfnInt32(grdLineas.Cell(grdLineas.ActiveCell.Row, 0).Text)
            loRepostaje.mrBorraDatos()
            mrCargaRepostajes()
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub mrCargaRepostajes()

        moBusRepostajes = New clsBusRepostajes
        'moBusRepostajes.mrRecuperaRepostajes(50)
        moBusRepostajes.mrRecuperaEstado(30)

        grdLineas.Visible = False
        grdLineas.Rows = 1

        Dim loRegistros() As DataRow = moBusRepostajes.moGrupoDatos.Tables("repostajes").Select("", "fechahora desc")
        For lnI As Integer = 0 To loRegistros.Length - 1

            Application.DoEvents()
            grdLineas.Rows = grdLineas.Rows + 1

            Dim lnLinea As Integer = grdLineas.Rows - 1
            Dim loRow As DataRow = loRegistros(lnI)

            grdLineas.Cell(lnLinea, 0).Text = loRow("id_repostaje")
            grdLineas.Cell(lnLinea, 1).Text = loRow("id_repostaje")
            grdLineas.Cell(lnLinea, 2).Text = Format(loRow("fechahora"), "dd/MM/yyyy HH:mm:ss")
            grdLineas.Cell(lnLinea, 3).Text = loRow("matricula")
            grdLineas.Cell(lnLinea, 4).Text = Format(loRow("kilometros"), "#,###")
            grdLineas.Cell(lnLinea, 5).Text = Format(loRow("litros"), "0.00")
            grdLineas.Cell(lnLinea, 7).Text = loRow("nom") & ""
            grdLineas.Cell(lnLinea, 8).Text = loRow("descripcion") & ""

            If loRow("id_repostaje") = 0 Then

                grdLineas.Cell(lnLinea, 3).Text = "CONTADOR"
                grdLineas.Cell(lnLinea, 4).Text = Format(loRow("litros"), "0.00")
                grdLineas.Cell(lnLinea, 5).Text = ""

                grdLineas.Cell(lnLinea, 2).BackColor = Color.LightBlue
                grdLineas.Cell(lnLinea, 3).BackColor = Color.LightBlue
                grdLineas.Cell(lnLinea, 4).BackColor = Color.LightBlue
                grdLineas.Cell(lnLinea, 5).BackColor = Color.LightBlue
                grdLineas.Cell(lnLinea, 6).BackColor = Color.LightBlue
                grdLineas.Cell(lnLinea, 7).BackColor = Color.LightBlue
                grdLineas.Cell(lnLinea, 8).BackColor = Color.LightBlue
            Else
                If loRow("lleno") = 1 Then
                    grdLineas.Cell(lnLinea, 6).BackColor = Color.LightGreen
                    grdLineas.Cell(lnLinea, 6).Text = "SI"
                Else
                    grdLineas.Cell(lnLinea, 6).BackColor = Color.Pink
                    grdLineas.Cell(lnLinea, 6).Text = "NO"
                End If
            End If

        Next

        ' AHORA RECORRO EL GRID PARA CALCULAR LAS DIFERENCIAS
        Dim lnSaldoAnterior As Double = 0
        Dim lnSaldoActual As Double = 0
        Dim lnSumatorio As Double = 0

        For lnJ As Integer = grdLineas.Rows - 1 To 1 Step -1

            If grdLineas.Cell(lnJ, 0).Text = "0" Then
                lnSaldoActual = mfnDouble(grdLineas.Cell(lnJ, 4).Text)
                If (lnSumatorio > 0) AndAlso (lnSaldoAnterior > 0) Then
                    If (lnSaldoActual - lnSaldoAnterior) <> lnSumatorio Then
                        grdLineas.Cell(lnJ, 5).Text = Format(lnSaldoActual - lnSaldoAnterior - lnSumatorio, "0.00")
                        grdLineas.Cell(lnJ, 5).BackColor = Color.Red
                        grdLineas.Cell(lnJ, 5).ForeColor = Color.White
                        grdLineas.Cell(lnJ, 5).FontBold = True
                    Else
                        grdLineas.Cell(lnJ, 5).Text = ""
                    End If
                End If
                lnSaldoAnterior = lnSaldoActual
                lnSumatorio = 0
            Else
                lnSumatorio = lnSumatorio + mfnDouble(grdLineas.Cell(lnJ, 5).Text)
            End If

        Next
        grdLineas.Visible = True


        ' LEO EL ESTADO DEL ULTIMO SALDO DEL CONTADOR
        Dim loSaldo As New clsSaldo
        loSaldo.mrRecuperaUltimoSaldo()
        lblContador.Text = Format(loSaldo.mnContador, "0.00")
        lblTextoContador.Text = "CONTADOR DEL SURTIDOR (" & Format(loSaldo.mdFechaHora, "dd/MM/yyyy HH:mm:ss") & ")"


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        mrCargaRepostajes()
        mrCargaVehiculos()
    End Sub

    Private Sub mrCargaVehiculos()

        moBusRepostajes.mrRecuperaMatriculas()

        lstVehiculos.BeginUpdate()
        lstVehiculos.Items.Clear()

        For Each loRow As DataRow In moBusRepostajes.moGrupoDatos.Tables("matriculas").Rows
            Dim loItem As New ListViewItem
            loItem.Tag = loRow("idmatricula")
            loItem.Text = loRow("activo")
            loItem.SubItems.Add(loRow("matricula"))
            loItem.SubItems.Add(loRow("descripcion"))
            loItem.SubItems.Add(IIf(loRow("obligatoriokms") = 1, "OBL", ""))
            loItem.SubItems.Add(loRow("litrosmaximos"))
            loItem.SubItems.Add(IIf(loRow("activo") = 1, "SI", "NO"))
            lstVehiculos.Items.Add(loItem)
        Next

        lstVehiculos.EndUpdate()

    End Sub

    Private Sub mrCargaGasolineros()

        moBusRepostajes.mrRecuperaGasolineros()

        lstGasolineros.BeginUpdate()
        lstGasolineros.Items.Clear()

        For Each loRow As DataRow In moBusRepostajes.moGrupoDatos.Tables("gasolineros").Rows
            Dim loItem As New ListViewItem
            loItem.Tag = loRow("idusuario")
            loItem.Text = loRow("idusuario")
            loItem.SubItems.Add(loRow("nom"))
            loItem.SubItems.Add(loRow("idchofer"))
            loItem.SubItems.Add(loRow("cla"))
            lstGasolineros.Items.Add(loItem)
        Next

        lstGasolineros.EndUpdate()

    End Sub

    Private Sub cmdVehiculos_Click(sender As Object, e As EventArgs) Handles cmdVehiculos.Click
        grpGasolineros.Visible = False
        grpVehiculos.Visible = True
        mrCargaVehiculos()
    End Sub

    Private Sub cmdGasolineros_Click(sender As Object, e As EventArgs) Handles cmdGasolineros.Click
        grpVehiculos.Visible = False
        grpGasolineros.Visible = True
        mrCargaGasolineros()
    End Sub

    Private Sub cmdNuevoVehiculos_Click(sender As Object, e As EventArgs) Handles cmdNuevoVehiculos.Click
        txtIdxVehiculo.Text = ""
        txtMatricula.Text = ""
        txtLitrosMaximos.Text = ""
        txtDesMatricula.Text = ""
        chkMatriculaActiva.Checked = True
    End Sub

    Private Sub cmdGrabaVehiculos_Click(sender As Object, e As EventArgs) Handles cmdGrabaVehiculos.Click
        mrGrabaMatricula
    End Sub

    Private Sub mrGrabaMatricula()

        Dim loMatricula As New clsMatricula
        loMatricula.mnIdMatricula = mfnInt32(txtIdxVehiculo.Text)
        loMatricula.msMatricula = Trim(txtMatricula.Text)
        loMatricula.msDescripcion = Trim(txtDesMatricula.Text)
        loMatricula.mnLitrosMaximos = mfnInteger(txtLitrosMaximos.Text)
        loMatricula.mnActivo = IIf(chkMatriculaActiva.Checked, 1, 0)
        loMatricula.mnObligatorioKms = IIf(chkPedirKilometros.Checked, 1, 0)
        loMatricula.mbEsNuevo = (loMatricula.mnIdMatricula = 0)
        If loMatricula.mbEsNuevo Then
            loMatricula.mrRecuperaMatricula()
            If Not loMatricula.mbEsNuevo Then
                MsgBox("ESTA MATRICULA ESTÁ YA METIDA", MsgBoxStyle.Exclamation, "Visanfer.Net")
                Exit Sub
            End If
        End If
        loMatricula.mrGrabaDatos()

        mrCargaVehiculos()

        lstVehiculos.Focus()
        SendKeys.Send("{HOME}")
        SendKeys.Send("{LEFT}")

    End Sub

    Private Sub lstVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVehiculos.SelectedIndexChanged
        If lstVehiculos.SelectedItems.Count = 0 Then Exit Sub
        txtIdxVehiculo.Text = lstVehiculos.SelectedItems(0).Tag
        chkMatriculaActiva.Checked = IIf(lstVehiculos.SelectedItems(0).Text = "1", True, False)
        chkPedirKilometros.Checked = IIf(lstVehiculos.SelectedItems(0).SubItems(3).Text = "OBL", True, False)
        txtMatricula.Text = lstVehiculos.SelectedItems(0).SubItems(1).Text
        txtLitrosMaximos.Text = lstVehiculos.SelectedItems(0).SubItems(4).Text
        txtDesMatricula.Text = lstVehiculos.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub cmdGrabaGasolinero_Click(sender As Object, e As EventArgs) Handles cmdGrabaGasolinero.Click
        mrNuevoGasolineroChofer()
    End Sub

    Private Sub cmdBorrarGasolinero_Click(sender As Object, e As EventArgs) Handles cmdBorrarGasolinero.Click
        mrBorraGasolinero
    End Sub

    Private Sub cmdRefresca_Click(sender As Object, e As EventArgs) Handles cmdRefresca.Click
        mrCargaRepostajes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdEstadisticas_Click(sender As Object, e As EventArgs) Handles cmdEstadisticas.Click
        Dim loConsumos As New frmConsumos
        loConsumos.mnEmpresa = mnEmpresa
        loConsumos.mrCargar()
    End Sub

End Class

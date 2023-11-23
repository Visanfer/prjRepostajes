Option Explicit On

Imports prjControl

Public Class frmHistorico

    Public mnIdMatricula As Integer = 0
    Public msDesde As String = ""
    Public msHasta As String = ""

    Dim mbPrimeraVez As Boolean = True

    Public Sub mrCargar()
        mrPreparaGrid()
        Me.ShowDialog()
    End Sub

    Private Sub mrPreparaGrid()

        ' GRID DE Los articulos *******************
        grdLineas.Visible = False
        grdLineas.Row(0).Visible = True
        grdLineas.Rows = 1

        grdLineas.DisplayRowNumber = False
        grdLineas.Cols = 6

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
        grdLineas.Cell(0, 1).Text = "MATRICULA"
        grdLineas.Cell(0, 2).Text = "DESCRIPCION"
        grdLineas.Cell(0, 3).Text = "TOTAL LITROS"
        grdLineas.Cell(0, 4).Text = "TOTAL KMS"
        grdLineas.Cell(0, 5).Text = "CONSUMO"

        grdLineas.Column(0).Visible = False

        grdLineas.Column(0).Width = 0
        grdLineas.Column(1).Width = 0
        grdLineas.Column(2).Width = 150
        grdLineas.Column(3).Width = 100
        grdLineas.Column(4).Width = 100
        grdLineas.Column(5).Width = 100

        grdLineas.Column(0).Alignment = FlexCell.Grid.AlignmentEnum.LeftCenter
        grdLineas.Column(1).Alignment = FlexCell.Grid.AlignmentEnum.LeftCenter
        grdLineas.Column(2).Alignment = FlexCell.Grid.AlignmentEnum.LeftCenter
        grdLineas.Column(3).Alignment = FlexCell.Grid.AlignmentEnum.RightCenter
        grdLineas.Column(4).Alignment = FlexCell.Grid.AlignmentEnum.RightCenter
        grdLineas.Column(5).Alignment = FlexCell.Grid.AlignmentEnum.RightCenter

        grdLineas.Visible = True

    End Sub

    Private Sub mrCargaDatos()

        Dim loVehiculo As New clsMatricula
        loVehiculo.mnIdMatricula = mnIdMatricula
        loVehiculo.mrRecuperaDatos()

        lblTitulo.Text = loVehiculo.msMatricula & " - " & loVehiculo.msDescripcion

        Dim ldDesde As Date = DateAdd(DateInterval.Year, -10, Now)
        Dim ldHasta As Date = Now

        If msDesde.Length > 0 Then
            ldDesde = CDate(msDesde)
            ldHasta = CDate(msHasta)
        End If

        Dim loBusRepostajes As New clsBusRepostajes
        loBusRepostajes.mrRecuperaConsumosMatricula(loVehiculo.msMatricula, ldDesde, ldHasta)

        grdLineas.Visible = False
        grdLineas.Rows = 1

        Dim lnTotalLitros As Double = 0
        Dim lnPrimerLitros As Double = 0
        Dim lnPrimerKms As Int64 = 0
        Dim lnTotalKms As Int64 = 0

        For Each loRow As DataRow In loBusRepostajes.moGrupoDatos.Tables("consumos").Rows

            Dim lnConsumo As Double = 0

            Application.DoEvents()
            grdLineas.Rows = grdLineas.Rows + 1

            Dim lnLinea As Integer = grdLineas.Rows - 1

            If lnLinea = 1 Then
                lnPrimerKms = loRow("kilometros")
                lnPrimerLitros = loRow("litros")
            Else
                Dim lnKilometrajeAnterior As Integer = loBusRepostajes.moGrupoDatos.Tables("consumos").Rows(lnLinea - 2)("kilometros")
                Dim lnKmsRecorridos As Int64 = loRow("kilometros") - lnKilometrajeAnterior
                lnConsumo = loRow("litros") * 100 / lnKmsRecorridos
            End If

            grdLineas.Cell(lnLinea, 0).Text = loRow("id_repostaje")
            grdLineas.Cell(lnLinea, 1).Text = loRow("matricula")
            grdLineas.Cell(lnLinea, 2).Text = Format(loRow("fechahora"), "dd/MM/yyyy HH:mm:ss")
            grdLineas.Cell(lnLinea, 3).Text = Format(loRow("litros"), "0.00")
            grdLineas.Cell(lnLinea, 4).Text = Format(loRow("kilometros"), "0")
            If lnConsumo = 0 Then
                grdLineas.Cell(lnLinea, 5).Text = ""
            Else
                grdLineas.Cell(lnLinea, 5).Text = Format(lnConsumo, "0.00") & " l/100 kms"
            End If
            If (loRow("lleno") = 1) Then grdLineas.Cell(lnLinea, 3).BackColor = Color.LightGreen

            lnTotalLitros = lnTotalLitros + loRow("litros")
            lnTotalKms = loRow("kilometros")
        Next

        lnTotalKms = lnTotalKms - lnPrimerKms
        Dim lnConsumoGlobal As Double = (lnTotalLitros - lnPrimerLitros) * 100 / lnTotalKms


        ' *** añado una linea con el total
        grdLineas.Rows = grdLineas.Rows + 1
        grdLineas.Cell(grdLineas.Rows - 1, 2).Text = "TOTALES"
        grdLineas.Cell(grdLineas.Rows - 1, 3).Text = Format(lnTotalLitros, "0.00")
        grdLineas.Cell(grdLineas.Rows - 1, 4).Text = Format(lnTotalKms, "0")
        If lnTotalKms > 0 Then
            grdLineas.Cell(grdLineas.Rows - 1, 5).Text = Format(lnConsumoGlobal, "0.00") & " l/100 kms"
        End If


        grdLineas.Cell(grdLineas.Rows - 1, 2).FontBold = True
        grdLineas.Cell(grdLineas.Rows - 1, 3).FontBold = True
        grdLineas.Cell(grdLineas.Rows - 1, 4).FontBold = True
        grdLineas.Cell(grdLineas.Rows - 1, 5).FontBold = True
        grdLineas.Cell(grdLineas.Rows - 1, 2).BackColor = Color.Beige
        grdLineas.Cell(grdLineas.Rows - 1, 3).BackColor = Color.Beige
        grdLineas.Cell(grdLineas.Rows - 1, 4).BackColor = Color.Beige
        grdLineas.Cell(grdLineas.Rows - 1, 5).BackColor = Color.Beige
        ' ********************************

        grdLineas.Visible = True

    End Sub

    Private Sub frmHistorico_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Enter
                mrEditaRepostaje()
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                mrBorraApunte
        End Select

    End Sub

    Private Sub mrBorraApunte()

        Dim lsResult As MsgBoxResult = MsgBox("¿Realmente quieres borrar este apunte?", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Visanfer.Net")
        If lsResult = MsgBoxResult.Yes Then
            Dim loRepostaje As New clsRepostaje
            loRepostaje.mnIdRepostaje = Val(grdLineas.Cell(grdLineas.ActiveCell.Row, 0).Text)
            loRepostaje.mrBorraDatos()
            ' refresco el grid *********************************
            mrCargaDatos()
        End If

    End Sub

    Private Sub mrEditaRepostaje()

        Dim loFormularioApunte As New frmApunte
        loFormularioApunte.msMatricula = grdLineas.Cell(grdLineas.ActiveCell.Row, 1).Text
        loFormularioApunte.mnLitros = mfnDouble(grdLineas.Cell(grdLineas.ActiveCell.Row, 3).Text)
        loFormularioApunte.mnKilometros = mfnLong(grdLineas.Cell(grdLineas.ActiveCell.Row, 4).Text)
        'loFormularioApunte.mbEditarApunte = True
        loFormularioApunte.mrCargar()
        If (loFormularioApunte.mnLitros > 0) Then

            Dim loRepostaje As New clsRepostaje
            loRepostaje.mnIdRepostaje = mfnInt32(grdLineas.Cell(grdLineas.ActiveCell.Row, 0).Text)
            loRepostaje.mrRecuperaDatos()
            loRepostaje.mnLitros = loFormularioApunte.mnLitros
            loRepostaje.mnKilometros = loFormularioApunte.mnKilometros
            loRepostaje.mrGrabaDatos()

            mrCargaDatos()

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        mrCargaDatos()
    End Sub

    Private Sub frmHistorico_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If mbPrimeraVez Then
            mbPrimeraVez = False
            Timer1.Enabled = True
        End If

    End Sub

End Class
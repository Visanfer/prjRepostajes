Option Explicit On

Imports prjControl

Public Class frmConsumos

    Public mnEmpresa As Integer

    Public Sub mrCargar()
        dtpDesde.Value = DateAdd(DateInterval.Year, -1, Now)
        mrPreparaGrid()
        Me.ShowDialog()
    End Sub

    Private Sub frmConsumos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyValue
            Case Keys.F9
                mrHistorialVehiculo()
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub

    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        mrCargarDatos
    End Sub

    Private Sub mrPreparaGrid()

        ' GRID DE Los articulos *******************
        grdLineas.Visible = False
        grdLineas.Row(0).Visible = True
        grdLineas.Rows = 1

        grdLineas.DisplayRowNumber = False
        grdLineas.Cols = 6

        'grdLineas.EnterKeyMoveTo = FlexCell.MoveToEnum.NextRow
        grdLineas.SelectionMode = FlexCell.SelectionModeEnum.ByRow
        grdLineas.AllowUserSort = False
        grdLineas.DisplayFocusRect = False
        grdLineas.AllowUserResizing = False
        grdLineas.ExtendLastCol = True
        grdLineas.FixedRowColStyle = FlexCell.FixedRowColStyleEnum.Flat
        grdLineas.BorderStyle = FlexCell.BorderStyleEnum.FixedSingle
        grdLineas.DateFormat = FlexCell.DateFormatEnum.DMY
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
        grdLineas.Column(1).Width = 100
        grdLineas.Column(2).Width = 300
        grdLineas.Column(3).Width = 100
        grdLineas.Column(4).Width = 100
        grdLineas.Column(5).Width = 100

        grdLineas.Column(0).Alignment = FlexCell.AlignmentEnum.LeftCenter
        grdLineas.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        grdLineas.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        grdLineas.Column(3).Alignment = FlexCell.AlignmentEnum.RightCenter
        grdLineas.Column(4).Alignment = FlexCell.AlignmentEnum.RightCenter
        grdLineas.Column(5).Alignment = FlexCell.AlignmentEnum.RightCenter

        grdLineas.Visible = True

    End Sub

    Private Sub mrHistorialVehiculo()

        Dim lnIdMatricula As Integer = mfnInt32(grdLineas.Cell(grdLineas.ActiveCell.Row, 0).Text)
        If lnIdMatricula > 0 Then
            Dim loHistorico As New frmHistorico
            loHistorico.mnIdMatricula = lnIdMatricula
            loHistorico.msDesde = dtpDesde.Value
            loHistorico.msHasta = dtpHasta.Value
            loHistorico.mrCargar()
        Else
            MsgBox("NO HAY DATOS PARA ESTE VEHICULO")
        End If

    End Sub

    Private Sub mrCargarDatos()

        Dim loBusRepostajes As New clsBusRepostajes
        loBusRepostajes.mrRecuperaConsumos(dtpDesde.Value, dtpHasta.Value)

        grdLineas.Visible = False
        grdLineas.Rows = 1

        For Each loRow As DataRow In loBusRepostajes.moGrupoDatos.Tables("consumos").Rows

            Application.DoEvents()
            grdLineas.Rows = grdLineas.Rows + 1

            Dim lnLinea As Integer = grdLineas.Rows - 1

            grdLineas.Cell(lnLinea, 0).Text = IIf(IsDBNull(loRow("idmatricula")), 0, loRow("idmatricula"))
            grdLineas.Cell(lnLinea, 1).Text = loRow("matricula")
            grdLineas.Cell(lnLinea, 2).Text = IIf(IsDBNull(loRow("descripcion")), "", loRow("descripcion"))
            grdLineas.Cell(lnLinea, 3).Text = Format(loRow("total"), "0.00")

            If loRow("totalkms") = 0 Then
                grdLineas.Cell(lnLinea, 4).Text = ""
                grdLineas.Cell(lnLinea, 5).Text = ""
            Else

                grdLineas.Cell(lnLinea, 4).Text = Format(loRow("totalkms"), "0.00")

                Dim loEstadistica As New clsEstadistica
                loEstadistica.msMatricula = loRow("matricula")
                loEstadistica.mrCalculaEstadistica()

                grdLineas.Cell(lnLinea, 5).Text = Format(loEstadistica.mnConsumoMedio, "0.00") & " Litros/100Kms"
                If loEstadistica.mnCorrecto = 1 Then
                    grdLineas.Cell(lnLinea, 5).BackColor = Color.LightGreen
                Else
                    grdLineas.Cell(lnLinea, 5).BackColor = Color.LightPink
                End If
            End If

        Next

        grdLineas.Visible = True

    End Sub

    Private Sub grdLineas_GotFocus(sender As Object, e As EventArgs) Handles grdLineas.GotFocus
        Dim loGrid As FlexCell.Grid = sender
        If loGrid.SelectionMode = FlexCell.SelectionModeEnum.ByRow Then
            loGrid.Locked = True
            loGrid.BackColorActiveCellSel = loGrid.BackColorSel
        Else
            loGrid.Locked = False
            loGrid.BackColorActiveCellSel = Color.White
        End If
    End Sub
End Class
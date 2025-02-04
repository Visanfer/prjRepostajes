Option Explicit On
Imports FlexCell

Public Class frmVehiculos

    Public mnVehiculoSeleccionado As Integer = 0
    Public mbModoEditor As Boolean = True

    ' Filtros del buscados *****************************
    Public mbVerCamionGrua As Boolean = True
    Public mbVerCamionSinGrua As Boolean = True
    Public mbVerHormigoneras As Boolean = True
    Public mbVerTurismos As Boolean = True
    Public mbVerFurgonetas As Boolean = True
    Public mbVerOtros As Boolean = True
    Public mbVerAnulados As Boolean = True
    Public mbVerExternos As Boolean = True

    Private mbPrimeraVez As Boolean = True
    Private moBusVehiculos As clsBusRepostajes

    Public Sub mrCargar()
        If mbModoEditor Then
            lblIntro.Text = "INTRO - EDITA VEHICULO"
        Else
            lblF1.Visible = False
            lblFiltro.Top = 10
            grdLineas.Top = 30
            grdLineas.Height = 630
        End If
        mrRellenaFiltro()
        mrPreparaGrid()
        Me.ShowDialog()
    End Sub

    Private Sub mrRellenaFiltro()

        chkCamion_Grua.Checked = mbVerCamionGrua
        chkCamion_SinGrua.Checked = mbVerCamionSinGrua
        chkHormigonera.Checked = mbVerHormigoneras
        chkTurismos.Checked = mbVerTurismos
        chkFurgoneta.Checked = mbVerFurgonetas
        chkOtros.Checked = mbVerOtros
        chkAnulados.Checked = mbVerAnulados
        chkExternos.Checked = mbVerExternos

    End Sub

    Private Sub mrRellenaGrid()

        Dim lsSql As String = ""

        If lblFiltro.Text.Length > 0 Then lsSql = lsSql & " and matricula like '%" & lblFiltro.Text & "%'"
        If Not chkAnulados.Checked Then lsSql = lsSql & " and activo = 1"
        If Not chkExternos.Checked Then lsSql = lsSql & " and externo = 0"

        Dim lsTipos As String = ""
        If chkCamion_Grua.Checked Then lsTipos = lsTipos & ",1"
        If chkCamion_SinGrua.Checked Then lsTipos = lsTipos & ",2,4"
        If chkHormigonera.Checked Then lsTipos = lsTipos & ",3"
        If chkTurismos.Checked Then lsTipos = lsTipos & ",6"
        If chkFurgoneta.Checked Then lsTipos = lsTipos & ",5"
        If chkOtros.Checked Then lsTipos = lsTipos & ",7,8,9"
        If lsTipos.Length > 0 Then
            lsTipos = lsTipos.Substring(1, lsTipos.Length - 1)
            lsSql = lsSql & " and tipo in (" & lsTipos & ")"
        End If
        If lsSql.Length > 0 Then lsSql = lsSql.Substring(5, lsSql.Length - 5)

        Dim loVehiculos() As DataRow = moBusVehiculos.moGrupoDatos.Tables("matriculas").Select(lsSql, "matricula asc")

        grdLineas.Visible = False

        grdLineas.Rows = 1
        grdLineas.Rows = loVehiculos.Length + 1

        Dim lnLinea As Integer = 1
        For Each loRow As DataRow In loVehiculos

            Dim loVehiculo As New clsMatricula
            loVehiculo.mrCargaDatos(loRow)
            mrPintaLinea(lnLinea, loVehiculo)
            lnLinea = lnLinea + 1

        Next

        grdLineas.Visible = True
        grdLineas.Focus()

        If grdLineas.Rows > 1 Then grdLineas.Range(1, 0, 1, 0).SelectCells()

    End Sub

    Private Sub mrPintaLinea(ByVal lnLinea As Integer, ByVal loVehiculo As clsMatricula)

        grdLineas.Cell(lnLinea, 0).Text = loVehiculo.mnIdMatricula
        grdLineas.Cell(lnLinea, 1).Text = loVehiculo.msMatricula
        grdLineas.Cell(lnLinea, 2).Text = loVehiculo.msDescripcion
        grdLineas.Cell(lnLinea, 3).Text = loVehiculo.mfsTipo()
        If loVehiculo.mnExterno = 1 Then
            grdLineas.Cell(lnLinea, 4).BackColor = Color.Pink
            grdLineas.Cell(lnLinea, 4).Text = "EXT"
        End If

        If loVehiculo.mnActivo = 0 Then
            grdLineas.Cell(lnLinea, 1).FontStrikeout = True
            grdLineas.Cell(lnLinea, 2).FontStrikeout = True
            grdLineas.Cell(lnLinea, 3).FontStrikeout = True

            grdLineas.Cell(lnLinea, 1).FontBold = True
            grdLineas.Cell(lnLinea, 2).FontBold = True
            grdLineas.Cell(lnLinea, 3).FontBold = True

            grdLineas.Cell(lnLinea, 1).ForeColor = Color.Red
            grdLineas.Cell(lnLinea, 2).ForeColor = Color.Red
            grdLineas.Cell(lnLinea, 3).ForeColor = Color.Red
        End If

    End Sub

    Private Sub mrPreparaGrid()

        ' GRID DE Los articulos *******************
        grdLineas.Visible = False
        grdLineas.Row(0).Visible = True
        grdLineas.Rows = 1

        grdLineas.DisplayRowNumber = False
        grdLineas.Cols = 5

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
        grdLineas.Cell(0, 3).Text = "TIPO"
        grdLineas.Cell(0, 4).Text = "PROP"

        grdLineas.Column(0).Visible = False

        grdLineas.Column(0).Width = 0
        grdLineas.Column(1).Width = 100
        grdLineas.Column(2).Width = 300
        grdLineas.Column(3).Width = 200
        grdLineas.Column(4).Width = 50

        grdLineas.Column(0).Alignment = FlexCell.AlignmentEnum.RightCenter
        grdLineas.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        grdLineas.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        grdLineas.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        grdLineas.Column(4).Alignment = FlexCell.AlignmentEnum.CenterCenter

        grdLineas.Visible = True

    End Sub

    Private Sub grdLineas_KeyDown(Sender As Object, e As KeyEventArgs) Handles grdLineas.KeyDown

        Select Case e.KeyData
            Case 8
                If lblFiltro.Text.Length > 0 Then lblFiltro.Text = lblFiltro.Text.Substring(0, lblFiltro.Text.Length - 1)
            Case 48 To 57
                lblFiltro.Text = lblFiltro.Text & (e.KeyData - 48).ToString
            Case 96 To 105
                lblFiltro.Text = lblFiltro.Text & (e.KeyData - 96).ToString
            Case 65 To 90
                lblFiltro.Text = lblFiltro.Text & Chr(e.KeyData)
        End Select

    End Sub

    Private Sub frmVehiculos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                If mbModoEditor Then
                    mrEditaVehiculo()
                Else
                    mrSelecciona()
                End If
            Case Keys.F1
                If mbModoEditor Then mrNuevoRegistro()

        End Select

    End Sub

    Private Sub mrNuevoRegistro()

        Dim loEdita As New frmVehiculo
        loEdita.moVehiculo = New clsMatricula
        loEdita.mrCargar()

        ' si ha grabado el registro entonces refresco la pantalla
        If loEdita.mbRegistroGrabado Then
            moBusVehiculos.mrRecuperaMatriculas()
            mrRellenaGrid()
        End If

    End Sub

    Private Sub mrEditaVehiculo()

        Dim lnLinea As Integer = grdLineas.ActiveCell.Row

        Dim loEdita As New frmVehiculo
        loEdita.moVehiculo = New clsMatricula
        loEdita.moVehiculo.mnIdMatricula = Val(grdLineas.Cell(lnLinea, 0).Text)
        loEdita.moVehiculo.mrRecuperaDatos()
        loEdita.mrCargar()

        ' si ha grabado el registro entonces refresco la pantalla
        If loEdita.mbRegistroGrabado Then mrPintaLinea(lnLinea, loEdita.moVehiculo)

    End Sub

    Private Sub mrSelecciona()

        Dim lnLinea As Integer = grdLineas.ActiveCell.Row
        mnVehiculoSeleccionado = Val(grdLineas.Cell(lnLinea, 0).Text)
        Me.Close()

    End Sub

    Private Sub frmVehiculos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If mbPrimeraVez Then
            mbPrimeraVez = False

            moBusVehiculos = New clsBusRepostajes
            moBusVehiculos.mrRecuperaMatriculas()
            mrRellenaGrid()
        End If

    End Sub

    Private Sub mrLeeCheck(sender As Object, e As EventArgs) Handles chkCamion_Grua.CheckedChanged, chkFurgoneta.CheckedChanged, chkCamion_SinGrua.CheckedChanged,
            chkHormigonera.CheckedChanged, chkTurismos.CheckedChanged, chkOtros.CheckedChanged, chkAnulados.CheckedChanged, chkExternos.CheckedChanged
        If Not moBusVehiculos Is Nothing Then mrRellenaGrid()
    End Sub

    Private Sub lblFiltro_TextChanged(sender As Object, e As EventArgs) Handles lblFiltro.TextChanged
        mrRellenaGrid()
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
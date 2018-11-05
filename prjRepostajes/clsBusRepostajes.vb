Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsBusRepostajes

    ''' <summary>
    ''' Clase de busqueda de repostajes  ....
    ''' </summary>

    Public mcolRepostajes As Collection
    Public mcolMatriculas As Collection
    Public mcolGasolineros As Collection

    Public moGrupoDatos As New DataSet

    Public Sub mrRecuperaConsumos(ByVal ldDesde As Date, ByVal ldHasta As Date)

        Dim lsSql As String

        lsSql = "select repostajes.matricula,repostajes_matriculas.descripcion,sum(litros) as total, max(kilometros) as totalkms" &
            " from repostajes left join repostajes_matriculas on repostajes.matricula=repostajes_matriculas.matricula" &
            " where date(fechahora)>='" & Format(ldDesde, formatoFecha) &
            "' and date(fechahora)<='" & Format(ldHasta, formatoFecha) &
            "' group by repostajes.matricula order by total desc;"

        Dim loDatos As DataTable = New clsControlBD().mfoRecuperaDatos(False, lsSql, "consumos")
        If moGrupoDatos.Tables.Contains("consumos") Then moGrupoDatos.Tables.Remove("consumos")
        moGrupoDatos.Tables.Add(loDatos.Copy)

    End Sub


    Public Sub mrRecuperaGasolineros()

        Dim lsSql As String
        'Dim loGasolinero As clsGasolinero

        lsSql = "select repostajes_gasolineros.*, usuarios.nom, usuarios.cla, usuarios.act from repostajes_gasolineros left join usuarios" &
            " on repostajes_gasolineros.idusuario=usuarios.cod order by idusuario desc"

        Dim loDatos As DataTable = New clsControlBD().mfoRecuperaDatos(False, lsSql, "gasolineros")
        If moGrupoDatos.Tables.Contains("gasolineros") Then moGrupoDatos.Tables.Remove("gasolineros")
        moGrupoDatos.Tables.Add(loDatos.Copy)

        'mcolGasolineros = New Collection
        'For Each loRow As DataRow In loDatos.Rows
        '    loGasolinero = New clsGasolinero
        '    loGasolinero.mrCargaDatos(loRow)
        '    loGasolinero.mbEsNuevo = False
        '    mcolGasolineros.Add(loGasolinero, loGasolinero.mpsCodigo)
        'Next

    End Sub

    Public Sub mrRecuperaMatriculas()

        Dim lsSql As String
        'Dim loMatricula As clsMatricula

        lsSql = "select * from repostajes_matriculas order by idmatricula desc"

        Dim loDatos As DataTable = New clsControlBD().mfoRecuperaDatos(False, lsSql, "matriculas")
        If moGrupoDatos.Tables.Contains("matriculas") Then moGrupoDatos.Tables.Remove("matriculas")
        moGrupoDatos.Tables.Add(loDatos.Copy)

        'mcolMatriculas = New Collection
        'For Each loRow As DataRow In loDatos.Rows
        '    loMatricula = New clsMatricula
        '    loMatricula.mrCargaDatos(loRow)
        '    loMatricula.mbEsNuevo = False
        '    mcolMatriculas.Add(loMatricula, loMatricula.mpsCodigo)
        'Next

    End Sub

    Public Sub mrRecuperaRepostajes(ByVal lnLimite As Integer)

        Dim lsSql As String

        lsSql = "select * from repostajes left join usuarios" &
            " on repostajes.gasolinero = usuarios.cod order by id_repostaje desc"
        If lnLimite > 0 Then lsSql = lsSql & " limit " & lnLimite

        Dim loDatos As DataTable = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")
        If moGrupoDatos.Tables.Contains("repostajes") Then moGrupoDatos.Tables.Remove("repostajes")
        moGrupoDatos.Tables.Add(loDatos.Copy)

    End Sub

    Public Sub mrRecuperaEstado(ByVal lnDias As Integer)

        Dim ldDesde As Date = DateAdd(DateInterval.Day, lnDias * -1, Now)
        Dim lsSql As String

        lsSql = "select * from repostajes left join usuarios" &
            " on repostajes.gasolinero = usuarios.cod" &
            " left join repostajes_matriculas on repostajes.matricula=repostajes_matriculas.matricula" &
            " where date(fechahora)>'" & Format(ldDesde, "yyyy/MM/dd") & "'"

        Dim loDatos As DataTable = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")
        If moGrupoDatos.Tables.Contains("repostajes") Then moGrupoDatos.Tables.Remove("repostajes")
        moGrupoDatos.Tables.Add(loDatos.Copy)

        ' ahora leo los saldos y los mezclo
        lsSql = "select * from repostajes_saldos left join usuarios" &
            " on repostajes_saldos.idgasolinero = usuarios.cod where date(fechahora)>'" & Format(ldDesde, "yyyy/MM/dd") & "'"
        Dim loSaldos As DataTable = New clsControlBD().mfoRecuperaDatos(False, lsSql, "saldos")

        For Each loRow As DataRow In loSaldos.Rows
            Dim loNuevo As DataRow = moGrupoDatos.Tables("repostajes").NewRow
            loNuevo(0) = 0
            loNuevo(1) = loRow(1)
            loNuevo(2) = loRow(2)
            loNuevo(3) = ""
            loNuevo(4) = 0
            loNuevo(5) = loRow(3)
            loNuevo(6) = 0
            loNuevo(7) = loRow(4)
            loNuevo(8) = loRow(5)
            loNuevo(9) = loRow(6)
            loNuevo(10) = loRow(7)
            loNuevo(11) = loRow(8)
            loNuevo(12) = loRow(9)
            loNuevo(13) = loRow(10)
            moGrupoDatos.Tables("repostajes").Rows.Add(loNuevo)
        Next

    End Sub

End Class

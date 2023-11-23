Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsMatricula
    Public mnIdMatricula As Integer
    Public msMatricula As String = ""
    Public msDescripcion As String = ""
    Public mnActivo As Integer = 1
    Public mnObligatorioKms As Integer = 0
    Public mnLitrosMaximos As Integer = 0
    Public mnTipo As Integer = 0
    Public msObservaciones As String = ""
    Public mnRepostajePermitido As Integer = 0
    Public msPoliza As String = ""
    Public msAseguradora As String = ""
    Public mnImporteSeguro As Double = 0
    Public mdInicioSeguro As Date = Now
    Public mdFinalSeguro As Date = Now
    Public mnTara As Integer = 0
    Public mnPMA As Integer = 0
    Public mnRenting As Integer = 0
    Public mnExterno As Integer = 0
    Public mnReparto As Integer = 0

    Public msResultadoEstadistica As String = ""
    Public msValoresEstadistica As String = ""

    Public mbEsNuevo As Boolean = True
    Public moDatos As DataTable

    Public Function mpsCodigo() As String
        mpsCodigo = "clsMatricula-" & mnIdMatricula
    End Function

    Public Sub mrRecuperaMatricula()

        Dim lsSql As String = "select * from repostajes_matriculas where matricula = '" & msMatricula & "'"
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from repostajes_matriculas where idmatricula = " & mnIdMatricula
        If mnIdMatricula = 0 AndAlso msMatricula.Length > 0 Then
            lsSql = "select * from repostajes_matriculas where matricula = '" & msMatricula & "'"
        End If
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)



        mnIdMatricula = mfnInteger(loRecord("idmatricula") & "")
        msMatricula = Trim(loRecord("matricula") & "")
        msDescripcion = Trim(loRecord("descripcion") & "")
        mnActivo = mfnInteger(loRecord("activo") & "")
        mnObligatorioKms = mfnInteger(loRecord("obligatoriokms") & "")
        mnLitrosMaximos = mfnInteger(loRecord("litrosmaximos") & "")

        ' campos nuevos **************************************
        mnTipo = mfnInteger(loRecord("tipo") & "")
        msObservaciones = Trim(loRecord("observaciones") & "")
        mnRepostajePermitido = mfnInteger(loRecord("repostaje") & "")
        msPoliza = Trim(loRecord("poliza") & "")
        msAseguradora = Trim(loRecord("aseguradora") & "")
        mnImporteSeguro = mfnDouble(loRecord("importeseguro") & "")
        mdInicioSeguro = mfdFecha(loRecord("inicioseguro") & "")
        mdFinalSeguro = mfdFecha(loRecord("finalseguro") & "")
        mnTara = mfnInteger(loRecord("tara") & "")
        mnPMA = mfnInteger(loRecord("pma") & "")
        mnRenting = mfnInteger(loRecord("renting") & "")
        mnExterno = mfnInteger(loRecord("externo") & "")
        mnReparto = mfnInteger(loRecord("reparto") & "")

        'If New clsControlBD().mfbExisteCampo("repostajes_matriculas", "tipo") Then
        'End If

    End Sub

    Public Function mfsTipo() As String

        Select Case mnTipo
            Case 1
                Return "CAMION CON GRUA"
            Case 2
                Return "CAMION SIN GRUA"
            Case 3
                Return "HORMIGONERA"
            Case 4
                Return "CABEZA TRACTORA"
            Case 5
                Return "FURGONETA"
            Case 6
                Return "TURISMO"
            Case 7
                Return "CARRETILLA"
            Case 8
                Return "REMOLQUE"
            Case 9
                Return "OTROS"
            Case Else
                Return ""
        End Select

    End Function

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes_matriculas(matricula,descripcion,activo,obligatoriokms,litrosmaximos," &
                        "tipo,observaciones,repostaje,poliza,aseguradora,importeseguro,inicioseguro,finalseguro,tara," &
                        "pma,renting,externo,reparto) values ('" &
                        msMatricula & "','" &
                        msDescripcion & "'," &
                        mnActivo & "," &
                        mnObligatorioKms & "," &
                        mnLitrosMaximos & "," &
                        mnTipo & ",'" &
                        msObservaciones & "'," &
                        mnRepostajePermitido & ",'" &
                        msPoliza & "','" &
                        msAseguradora & "'," &
                        mfsFormatoDoble(mnImporteSeguro, 2) & ",'" &
                        Format(mdInicioSeguro, formatoFecha) & "','" &
                        Format(mdFinalSeguro, formatoFecha) & "'," &
                        mnTara & "," &
                        mnPMA & "," &
                        mnRenting & "," &
                        mnExterno & "," &
                        mnReparto & "); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdMatricula = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update repostajes_matriculas set matricula = '" & msMatricula &
                    "', descripcion = '" & msDescripcion &
                    "', activo = " & mnActivo &
                    ", obligatoriokms = " & mnObligatorioKms &
                    ", litrosmaximos = " & mnLitrosMaximos &
                    ", tipo = " & mnTipo &
                    ", observaciones = '" & msObservaciones &
                    "', repostaje = " & mnRepostajePermitido &
                    ", poliza = '" & msPoliza &
                    "', aseguradora = '" & msAseguradora &
                    "', importeseguro = " & mfsFormatoDoble(mnImporteSeguro, 2) &
                    ", inicioseguro = '" & Format(mdInicioSeguro, formatoFecha) &
                    "', finalseguro = '" & Format(mdFinalSeguro, formatoFecha) &
                    "', tara = " & mnTara &
                    ", pma = " & mnPMA &
                    ", renting = " & mnRenting &
                    ", externo = " & mnExterno &
                    ", reparto = " & mnReparto &
                    " where idmatricula = " & mnIdMatricula
            loComando = New MySqlCommand(lsSql, lconConexion)
            loComando.ExecuteNonQuery()
        End If
        lconConexion.Close()

        mbEsNuevo = False

    End Sub

    Public Sub mrBorraDatos()

        Dim lconConexion As MySqlConnection = prjControl.mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        Dim lsSql As String
        Dim loComando As New MySqlCommand()

        lsSql = "delete from repostajes_matriculas where idmatricula = " & mnIdMatricula
        mbEsNuevo = True

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

End Class

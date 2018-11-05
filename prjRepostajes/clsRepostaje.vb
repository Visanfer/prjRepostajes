Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsRepostaje
    Public mnIdRepostaje As Integer
    Public mnGasolinero As Integer
    Public mdFechaHora As DateTime = Now
    Public msMatricula As String
    Public mnKilometros As Integer
    Public mnLitros As Double
    Public mnLleno As Integer
    Public msImei As String

    Public mbEsNuevo As Boolean = True
    Public moDatos As DataTable

    Public Function mpsCodigo() As String
        mpsCodigo = "clsRepostaje-" & mnIdRepostaje
    End Function

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from repostajes where id_repostaje = " & mnIdRepostaje
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnIdRepostaje = mfnInteger(loRecord("id_repostaje") & "")
        mnGasolinero = mfnInteger(loRecord("gasolinero") & "")
        mdFechaHora = CDate(loRecord("fechahora") & "")
        msMatricula = Trim(loRecord("matricula") & "")
        mnKilometros = mfnInteger(loRecord("kilometros") & "")
        mnLitros = mfnInteger(loRecord("litros") & "")
        mnLleno = mfnInteger(loRecord("lleno") & "")
        msImei = Trim(loRecord("imei") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes(gasolinero,fechahora,matricula,kilometros,litros,lleno,imei) values (" &
                        mnGasolinero & ",'" &
                        Format(mdFechaHora, "yyyy/MM/dd HH:mm:ss") & "','" &
                        msMatricula & "'," &
                        mnKilometros & "," &
                        mfsFormatoDoble(mnLitros, 2) & "," &
                        mnLleno & ",'" &
                        msImei & "'); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdRepostaje = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update repostajes set gasolinero = " & mnGasolinero &
                    ", fechahora = '" & Format(mdFechaHora, "yyyy/MM/dd HH:mm:ss") &
                    "', matricula = '" & msMatricula &
                    "', kilometros = " & mnKilometros &
                    ", litros = " & mfsFormatoDoble(mnLitros, 2) &
                    ", lleno = " & mnLleno &
                    ", imei = '" & msImei &
                    "' where id_repostaje = " & mnIdRepostaje
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

        lsSql = "delete from repostajes where id_repostaje = " & mnIdRepostaje
        mbEsNuevo = True

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

End Class

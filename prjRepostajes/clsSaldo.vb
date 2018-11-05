Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsSaldo
    ''' <summary>
    ''' clase saldo
    ''' </summary>

    Public mnIdSaldo As Integer
    Public mnIdGasolinero As Integer
    Public mdFechaHora As DateTime
    Public mnContador As Double
    Public msImei As String

    Public mbEsNuevo As Boolean = True
    Public moDatos As DataTable

    Public Function mpsCodigo() As String
        mpsCodigo = "clsSaldo-" & mnIdSaldo
    End Function

    Public Sub mrRecuperaUltimoSaldo()

        Dim lsSql As String = "select * from repostajes_saldos order by idsaldo desc limit 1"
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "saldos")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from repostajes_saldos where idsaldo = " & mnIdSaldo
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "saldos")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnIdSaldo = mfnInteger(loRecord("idsaldo") & "")
        mnIdGasolinero = mfnInteger(loRecord("idgasolinero") & "")
        mdFechaHora = CDate(loRecord("fechahora") & "")
        mnContador = mfnDouble(loRecord("contador") & "")
        msImei = Trim(loRecord("imei") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes_saldos(idgasolinero,fechahora,contador,imei) values (" &
                        mnIdGasolinero & ",'" &
                        Format(Now, "yyyy/MM/dd HH:mm:ss") & "'," &
                        mfsFormatoDoble(mnContador, 2) & ",'" &
                        msImei & "'); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdSaldo = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update repostajes_saldos set idgasolinero = " & mnIdGasolinero &
                    ", fechahora = '" & Format(mdFechaHora, "yyyy/MM/dd HH:mm:ss") &
                    ", contador = " & mfsFormatoDoble(mnContador, 2) &
                    ", imei = '" & msImei &
                    "' where repostajes_saldos = " & mnIdSaldo
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

        lsSql = "delete from repostajes_saldos where idgasolinero = " & mnIdGasolinero
        mbEsNuevo = True

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

End Class

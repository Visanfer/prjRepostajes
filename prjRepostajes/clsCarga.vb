Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

''' <summary>
''' CREATE TABLE `repostajes_cargas` (
'''   `idcarga` int(11) Not NULL AUTO_INCREMENT,
'''   `iddeposito` int(11) Not NULL,
'''   `fechahora` datetime DEFAULT NULL,
'''   `litros` double DEFAULT NULL,
'''   PRIMARY KEY(`idcarga`)
''' ) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;
''' </summary>

Public Class clsCarga

    Public mnIdCarga As Integer = 0
    Public mnIdDeposito As Integer = 0
    Public mdFechaHora As Date = Now
    Public mnLitros As Double = 0

    Public mbEsNuevo As Boolean = True
    Public moDatos As DataTable

    Public Function mpsCodigo() As String
        mpsCodigo = "clsCarga-" & mnIdCarga
    End Function

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnIdCarga = mfnInteger(loRecord("idcarga") & "")
        mnIdDeposito = mfnInteger(loRecord("iddeposito") & "")
        mdFechaHora = CDate(loRecord("fechahora") & "")
        mnLitros = mfnDouble(loRecord("litros") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes_cargas(iddeposito,litros,fechahora) values (" &
                        mnIdDeposito & ",'" &
                        mfsFormatoDoble(mnLitros, 2) & "','" &
                        Format(mdFechaHora, "yyyy/MM/dd HH:mm:ss") & "'); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdDeposito = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update repostajes_cargas set iddeposito = " & mnIdDeposito &
                    ", litros = " & mfsFormatoDoble(mnLitros, 2) &
                    ", fechahora = '" & Format(mdFechaHora, "yyyy/MM/dd HH:mm:ss") &
                    "' where iddeposito = " & mnIdDeposito
            loComando = New MySqlCommand(lsSql, lconConexion)
            loComando.ExecuteNonQuery()
        End If
        lconConexion.Close()

        mbEsNuevo = False

    End Sub

End Class

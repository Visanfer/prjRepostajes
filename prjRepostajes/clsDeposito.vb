Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

''' <summary>
''' CREATE TABLE `repostajes_deposito` (
'''   `iddeposito` int(11) Not NULL AUTO_INCREMENT,  
'''   `capacidad` double DEFAULT NULL,
'''   `litrossaldo` double DEFAULT NULL,
'''   `fechasaldo` datetime DEFAULT NULL,
'''   PRIMARY KEY(`iddeposito`)
''' ) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;
''' </summary>

Public Class clsDeposito

    Public mnIdDeposito As Integer = 0
    Public mnCapacidad As Double = 0
    Public mnLitrosSaldo As Double = 0
    Public mdFechaSaldo As Date = Now

    Public mbEsNuevo As Boolean = True
    Public moDatos As DataTable

    Public Function mpsCodigo() As String
        mpsCodigo = "clsDeposito-" & mnIdDeposito
    End Function

    Public Sub mrRecuperaUltimoSaldo()

        Dim lsSql As String = "select * from repostajes_deposito order by iddeposito desc limit 1"
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "deposito")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from repostajes_deposito where iddeposito = " & mnIdDeposito
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "deposito")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnIdDeposito = mfnInteger(loRecord("iddeposito") & "")
        mnCapacidad = mfnDouble(loRecord("capacidad") & "")
        mnLitrosSaldo = mfnDouble(loRecord("litrossaldo") & "")
        mdFechaSaldo = CDate(loRecord("fechasaldo") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes_deposito(iddeposito,capacidad,litrossaldo,fechasaldo) values (" &
                        mnIdDeposito & ",'" &
                        mfsFormatoDoble(mnCapacidad, 2) & "','" &
                        mfsFormatoDoble(mnLitrosSaldo, 2) & "','" &
                        Format(mdFechaSaldo, "yyyy/MM/dd HH:mm:ss") & "'); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdDeposito = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update repostajes_deposito set iddeposito = " & mnIdDeposito &
                    ", capacidad = " & mfsFormatoDoble(mnCapacidad, 2) &
                    ", litrossaldo = " & mfsFormatoDoble(mnLitrosSaldo, 2) &
                    ", fechasaldo = '" & Format(mdFechaSaldo, "yyyy/MM/dd HH:mm:ss") &
                    "' where iddeposito = " & mnIdDeposito
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

        lsSql = "delete from repostajes_deposito where iddeposito = " & mnIdDeposito
        mbEsNuevo = True

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

    Public Sub mrRecuperaCargas()

        Dim lsSql As String

        lsSql = "select * from repostajes_cargas where iddeposito = " & mnIdDeposito &
            " order by idcarga desc"

        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "cargas")

    End Sub

    Public Function mfnRepostajes() As Double

        Dim lnRepostajes As Double = 0
        Dim lsSql As String

        lsSql = "select sum(litros) as total from repostajes where fechahora > '" & Format(mdFechaSaldo, "yyyy/MM/dd HH:mm:ss") & "'"

        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")

        If moDatos.Rows.Count > 0 AndAlso Not IsDBNull(moDatos.Rows(0)("total")) Then
            lnRepostajes = moDatos.Rows(0)("total")
        End If

        Return lnRepostajes

        Return 0

    End Function

    Public Function mfnCargas() As Double

        Dim lnCargas As Double = 0
        Dim lsSql As String

        lsSql = "select sum(litros) as total from repostajes_cargas where iddeposito = " & mnIdDeposito &
            " and fechahora > '" & Format(mdFechaSaldo, "yyyy/MM/dd HH:mm:ss") & "'"

        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "cargas")

        If moDatos.Rows.Count > 0 AndAlso Not IsDBNull(moDatos.Rows(0)("total")) Then
            lnCargas = moDatos.Rows(0)("total")
        End If

        Return lnCargas

    End Function

    Public Function mfnContenidoActual() As Double

        If mbEsNuevo Then mrRecuperaDatos()
        Return mnLitrosSaldo + mfnCargas() - mfnRepostajes()

    End Function

End Class

Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsGasolinero
    Public mnIdUsuario As Integer
    Public mnIdChofer As Integer

    Public mbEsNuevo As Boolean = True
    Public moDatos As DataTable

    Public Function mpsCodigo() As String
        mpsCodigo = "clsGasolinero-" & mnIdUsuario
    End Function

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from repostajes_gasolineros where idusuario = " & mnIdUsuario
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnIdUsuario = mfnInteger(loRecord("idusuario") & "")
        mnIdChofer = mfnInteger(loRecord("idchofer") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes_gasolineros(idusuario,idchofer) values (" &
                        mnIdUsuario & "," &
                        mnIdChofer & ")"
        Else
            lsSql = "update repostajes_gasolineros set idchofer = " & mnIdChofer &
                    " where idusuario = " & mnIdUsuario
        End If
        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

        mbEsNuevo = False

    End Sub

    Public Sub mrBorraDatos()

        Dim lconConexion As MySqlConnection = prjControl.mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        Dim lsSql As String
        Dim loComando As New MySqlCommand()

        lsSql = "delete from repostajes_gasolineros where idusuario = " & mnIdUsuario
        mbEsNuevo = True

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

End Class

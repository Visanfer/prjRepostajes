﻿Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsChofer
    ''' <summary>
    ''' Esto es una prueba
    ''' </summary>
    Public mnIdChofer As Integer
    Public msDescripcion As String = ""
    Public mnActivo As Integer = 1

    Public mbEsNuevo As Boolean = True
    Public moDatos As DataTable

    Public Function mpsCodigo() As String
        mpsCodigo = "clsChofer-" & mnIdChofer
    End Function

    Public Sub mrRecuperaDatos()

        Dim lsSql As String = "select * from repostajes_chofer where idchofer = " & mnIdChofer
        moDatos = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")

        mbEsNuevo = True
        For Each loRow As DataRow In moDatos.Rows
            mrCargaDatos(loRow)
            mbEsNuevo = False
        Next

    End Sub

    Public Sub mrCargaDatos(ByVal loRecord As DataRow)
        mnIdChofer = mfnInteger(loRecord("idchofer") & "")
        msDescripcion = Trim(loRecord("descripcion") & "")
        mnActivo = mfnInteger(loRecord("activo") & "")
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes_chofer(descripcion,activo) values ('" &
                        msDescripcion & "'," &
                        mnActivo & "); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdChofer = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update repostajes_chofer set descripcion = '" & msDescripcion &
                    "', activo = " & mnActivo &
                    " where idchofer = " & mnIdChofer
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

        lsSql = "delete from repostajes_chofer where idchofer = " & mnIdChofer
        mbEsNuevo = True

        loComando = New MySqlCommand(lsSql, lconConexion)
        loComando.ExecuteNonQuery()
        lconConexion.Close()

    End Sub

End Class

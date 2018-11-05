Option Explicit On

Imports prjControl
Imports MySql.Data.MySqlClient

Public Class clsMatricula
    Public mnIdMatricula As Integer
    Public msMatricula As String = ""
    Public msDescripcion As String = ""
    Public mnActivo As Integer = 1
    Public mnObligatorioKms As Integer = 1
    Public mnLitrosMaximos As Integer = 0

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
    End Sub

    Public Sub mrGrabaDatos()

        Dim lsSql As String
        Dim loComando As New MySqlCommand

        Dim lconConexion As MySqlConnection = mfconConexionSQL(False)
        If lconConexion.State = ConnectionState.Closed Then Exit Sub

        If mbEsNuevo Then
            lsSql = "insert into repostajes_matriculas(matricula,descripcion,activo,obligatoriokms,litrosmaximos) values ('" &
                        msMatricula & "','" &
                        msDescripcion & "'," &
                        mnActivo & "," &
                        mnObligatorioKms & "," &
                        mnLitrosMaximos & "); SELECT LAST_INSERT_ID();"
            loComando = New MySqlCommand(lsSql, lconConexion)
            mnIdMatricula = Convert.ToInt64(loComando.ExecuteScalar())
        Else
            lsSql = "update repostajes_matriculas set matricula = '" & msMatricula &
                    "', descripcion = '" & msDescripcion &
                    "', activo = " & mnActivo &
                    ", obligatoriokms = " & mnObligatorioKms &
                    ", litrosmaximos = " & mnLitrosMaximos &
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

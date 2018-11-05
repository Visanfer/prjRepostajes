Option Explicit On

Imports prjControl

Public Class clsEstadistica

    Public msMatricula As String = ""
    Public mnCorrecto As Integer = 1
    Public mnConsumoMedio As Double = 1
    Public mnConsumoMedioGlobal As Double = 1
    Public msResultado As String = ""

    Public Sub mrCalculaEstadistica()

        Dim lnKilometrosIniciales As Integer = 0
        Dim lnKilometrosFinales As Integer = 0
        Dim lnPrimerRepostaje As Double = 0
        Dim lnLitrosTotales As Double = 0
        Dim lnLleno As Integer = 0

        ' aqui debo calcular los valores del consumo del vehiculo
        Dim lsSql As String = "select * from repostajes where matricula = '" & msMatricula & "' order by id_repostaje"
        Dim loDatos As DataTable = New clsControlBD().mfoRecuperaDatos(False, lsSql, "repostajes")

        Dim lnRegistro As Integer = 1
        For Each loRow As DataRow In loDatos.Rows

            ' se activa con el primero deposito lleno ******************
            If (lnLleno = 0 AndAlso loRow("lleno") = 1) Then lnLleno = 1
            ' ***********************************************************

            If lnPrimerRepostaje = 0 Then lnPrimerRepostaje = loRow("litros")

            If lnLleno Then
                If lnKilometrosIniciales = 0 Then lnKilometrosIniciales = loRow("kilometros")
                lnKilometrosFinales = loRow("kilometros")
                lnLitrosTotales = lnLitrosTotales + loRow("litros")
            End If

            ' si estamos en el ultimo registro, entonces miro el consumo medio del tramo
            If (loDatos.Rows.Count > 1) AndAlso (lnRegistro = loDatos.Rows.Count) Then
                Dim lnAnterior As Integer = loDatos.Rows(lnRegistro - 2)("kilometros")
                Dim lnActual As Integer = loRow("kilometros")
                Dim lnLitros As Double = loRow("litros")

                mnConsumoMedio = lnLitros * 100 / (lnActual - lnAnterior)
            End If

            lnRegistro = lnRegistro + 1

        Next

        If (loDatos.Rows.Count > 1) Then

            mnConsumoMedioGlobal = (lnLitrosTotales - lnPrimerRepostaje) * 100 / (lnKilometrosFinales - lnKilometrosIniciales)

            If Math.Abs(mnConsumoMedio - mnConsumoMedioGlobal) < 10 Then
                mnCorrecto = 1
                msResultado = "TODO EN ORDEN"
            Else
                mnCorrecto = 0
                msResultado = "CONSUMO ANOMALO"
            End If

        Else
            mnCorrecto = 1
            msResultado = "TODAVIA NO HAY SUFICIENTES DATOS PARA ANALIZAR EL CONSUMO"
        End If

    End Sub


End Class

Option Explicit On

Imports System.Text
Imports prjControl

Public Module modRepostajes

    Public goProfile As New clsProfileLocal
    Public goUsuario As New clsUsuario()

    Public Sub Main()

        goUsuario = New clsUsuario
        goUsuario.mnCodigo = 206
        goUsuario.mrRecuperaDatos()

        Dim loPrincipal As New frmRespotajes
        loPrincipal.mnEmpresa = 1
        loPrincipal.mrCargar(goUsuario)
    End Sub

End Module

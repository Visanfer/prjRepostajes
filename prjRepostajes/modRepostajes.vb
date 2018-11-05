Option Explicit On

Imports System.Text
Imports prjControl

Public Module modRepostajes

    Public goProfile As New clsProfile
    Public goUsuario As New clsUsuario()

    Public Sub Main()
        Dim loPrincipal As New frmRespotajes
        loPrincipal.mnEmpresa = 1
        loPrincipal.mrCargar(Nothing)
    End Sub

End Module

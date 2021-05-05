Public Class Pelajar

    Private strNoMatrik As String

    Sub New(ByVal strNoMatrik As String)

        Me.strNoMatrik = strNoMatrik

    End Sub

    Public Function Politeknik() As String
        Dim strKodPoli As String = strNoMatrik.Substring(0, 2)
        '(0,2) tu (0,..) start with index 0. (..,2) tu sbanyak 2 huruf

        If strKodPoli = "18" Then
            Return "PTSS"
        Else
            Return "Bukan PTSS"
        End If

    End Function

    Public Function Program() As String

        Dim strKodProgram As String = strNoMatrik.Substring(2, 3)
        '(2,3) tu (2,..) start with index ke2. (..,3) sbanyak 3 huruf

        If strKodProgram = "DDT" Then
            Return "Diploma Teknologi Maklumat(DDT)"
        Else
            Return "BUKAN DDT"
        End If
    End Function

    Public Function Ambilan() As String
        Dim strKodAmbilanTahun As String = strNoMatrik.Substring(5, 3)
        Dim strKodAmbilanSem As String = strNoMatrik.Substring(8, 1)

        If strKodAmbilanTahun = "19F" Then
            If strKodAmbilanSem = "1" Then
                Return "Jun 2019"
            ElseIf strKodAmbilanSem = "2" Then
                Return "Dec 2019"
            End If
        Else
            Return "Not Sesi 2019"
        End If

    End Function
End Class

Module Module1
    Public DtaSet As New DataSet()

    'TO ACCEPT ONLY NUMBERS
    Public Function AllowNumbers(ByVal kcode As String) As Boolean

        If (kcode >= 48 And kcode <= 57) Or kcode = 8 Or kcode = 46 Then
            AllowNumbers = False
        Else
            AllowNumbers = True
        End If
    End Function

    'TO ACCEPT ONLY Character
    Public Function AllowCharacter(ByVal kcode As String) As Boolean
        If (kcode >= 65 And kcode <= 90) Or kcode >= 97 And kcode <= 122 Or kcode = 8 Or kcode = 32 Or kcode = 46 Then

            AllowCharacter = False
        Else

            AllowCharacter = True

        End If
    End Function
End Module

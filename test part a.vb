Module Module1

    Sub Main()
        Dim mychar, BiNum As String
        Dim count As Integer
        Dim validBinaryString As Boolean

        mychar = ""
        count = 0
        BiNum = ""
        validBinaryString = True

        Console.WriteLine("PLEASE ENTER BINARY NUMBER :")
        BiNum = Console.ReadLine

        If Len(BiNum) < 1 Or Len(BiNum) > 8 Then
            validBinaryString = False
        Else
            For count = 1 To Len(BiNum)
                mychar = Mid(BiNum, count, 1)
                If mychar = "1" Then
                    validBinaryString = True
                ElseIf mychar = "0" Then
                    validBinaryString = True
                Else
                    validBinaryString = False
                End If
            Next
        End If
        If validBinaryString = False Then
            Console.WriteLine("NOT A BINARY NUMBER :")
        End If
        Console.ReadKey()
    End Sub

End Module

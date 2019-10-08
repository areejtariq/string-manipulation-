Module Module1

    Sub Main()
        Dim str1 As String
        Dim cr As Char
        Dim temp As String
        Dim a As Char

        str1 = ("")
        cr = ("")
        temp = ("")
        a = ("")

        Console.WriteLine("ENTER STRING PLEASE")
        str1 = Console.ReadLine

        Console.WriteLine("ENTER CHARACTER TO REMOVE")
        cr = Console.ReadLine

        For i = 1 To Len(str1)
            a = Mid(str1, i, 1)
            If a <> cr Then
                temp = temp & a
            End If
        Next

        Console.WriteLine(temp)

        Console.ReadKey()

      




    End Sub

End Module

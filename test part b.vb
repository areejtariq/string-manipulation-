Module Module1

    Sub Main()

        Dim BiNum As String
        Dim count As Integer
        Dim mychar As Char
        Dim validbinarystring As Boolean
        Dim length As Integer


        Console.Write("ENTER YOUR BINARY NUMBER: ")
        BiNum = Console.ReadLine

        validbinarystring = True

        For count = 1 To Len(BiNum)
            mychar = Mid(BiNum, count, 1)
            If mychar <> "1" Or mychar <> "0" Then
                validbinarystring = False
            End If
        Next
        Console.Write("NOT A VALID BINARY NUMBER ...")

        validbinarystring = True
        For count = 1 To Len(BiNum)
            length = Len(BiNum)
            If length > 8 Or length < 1 Then
                validbinarystring = False
            End If
        Next
        Console.Write("NOT A VALID BINARY NUMBER ...")
        Console.ReadKey()
    End Sub

End Module

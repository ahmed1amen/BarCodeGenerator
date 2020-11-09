Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports Microsoft.VisualBasic.CompilerServices

Module Module1
    Public Function Code128(ByVal TheText As String, ByVal CodeLetter As String) As Image
        Dim num As Integer
        Dim num2 As Integer
        Dim expression As String = ""
        If ((CodeLetter = "A") Or (CodeLetter = "a")) Then
            num2 = &H67
            expression = "00101111011"
        End If
        If ((CodeLetter = "B") Or (CodeLetter = "b")) Then
            num2 = &H68
            expression = "00101101111"
        End If
        If ((CodeLetter = "C") Or (CodeLetter = "c")) Then
            num2 = &H69
            expression = "00101100011"
        End If
        Dim num3 As Integer = Strings.Len(TheText)
        num = 1
        Do While (num <= num3)
            num2 = (num2 + ((Strings.Asc(Strings.Mid(TheText, num, 1)) - &H20) * num))
            Select Case Strings.Asc(Strings.Mid(TheText, num, 1))
                Case &H20
                    expression = (expression & "00100110011")
                    Exit Select
                Case &H21
                    expression = (expression & "00110010011")
                    Exit Select
                Case &H22
                    expression = (expression & "00110011001")
                    Exit Select
                Case &H23
                    expression = (expression & "01101100111")
                    Exit Select
                Case &H24
                    expression = (expression & "01101110011")
                    Exit Select
                Case &H25
                    expression = (expression & "01110110011")
                    Exit Select
                Case &H26
                    expression = (expression & "01100110111")
                    Exit Select
                Case &H27
                    expression = (expression & "01100111011")
                    Exit Select
                Case 40
                    expression = (expression & "01110011011")
                    Exit Select
                Case &H29
                    expression = (expression & "00110110111")
                    Exit Select
                Case &H2A
                    expression = (expression & "00110111011")
                    Exit Select
                Case &H2B
                    expression = (expression & "00111011011")
                    Exit Select
                Case &H2C
                    expression = (expression & "01001100011")
                    Exit Select
                Case &H2D
                    expression = (expression & "01100100011")
                    Exit Select
                Case &H2E
                    expression = (expression & "01100110001")
                    Exit Select
                Case &H2F
                    expression = (expression & "01000110011")
                    Exit Select
                Case &H30
                    expression = (expression & "01100010011")
                    Exit Select
                Case &H31
                    expression = (expression & "01100011001")
                    Exit Select
                Case 50
                    expression = (expression & "00110001101")
                    Exit Select
                Case &H33
                    expression = (expression & "00110100011")
                    Exit Select
                Case &H34
                    expression = (expression & "00110110001")
                    Exit Select
                Case &H35
                    expression = (expression & "00100011011")
                    Exit Select
                Case &H36
                    expression = (expression & "00110001011")
                    Exit Select
                Case &H37
                    expression = (expression & "00010010001")
                    Exit Select
                Case &H38
                    expression = (expression & "00010110011")
                    Exit Select
                Case &H39
                    expression = (expression & "00011010011")
                    Exit Select
                Case &H3A
                    expression = (expression & "00011011001")
                    Exit Select
                Case &H3B
                    expression = (expression & "00010011011")
                    Exit Select
                Case 60
                    expression = (expression & "00011001011")
                    Exit Select
                Case &H3D
                    expression = (expression & "00011001101")
                    Exit Select
                Case &H3E
                    expression = (expression & "00100100111")
                    Exit Select
                Case &H3F
                    expression = (expression & "00100111001")
                    Exit Select
                Case &H40
                    expression = (expression & "00111001001")
                    Exit Select
                Case &H41
                    expression = (expression & "01011100111")
                    Exit Select
                Case &H42
                    expression = (expression & "01110100111")
                    Exit Select
                Case &H43
                    expression = (expression & "01110111001")
                    Exit Select
                Case &H44
                    expression = (expression & "01001110111")
                    Exit Select
                Case &H45
                    expression = (expression & "01110010111")
                    Exit Select
                Case 70
                    expression = (expression & "01110011101")
                    Exit Select
                Case &H47
                    expression = (expression & "00101110111")
                    Exit Select
                Case &H48
                    expression = (expression & "00111010111")
                    Exit Select
                Case &H49
                    expression = (expression & "00111011101")
                    Exit Select
                Case &H4A
                    expression = (expression & "01001000111")
                    Exit Select
                Case &H4B
                    expression = (expression & "01001110001")
                    Exit Select
                Case &H4C
                    expression = (expression & "01110010001")
                    Exit Select
                Case &H4D
                    expression = (expression & "01000100111")
                    Exit Select
                Case &H4E
                    expression = (expression & "01000111001")
                    Exit Select
                Case &H4F
                    expression = (expression & "01110001001")
                    Exit Select
                Case 80
                    expression = (expression & "00010001001")
                    Exit Select
                Case &H51
                    expression = (expression & "00101110001")
                    Exit Select
                Case &H52
                    expression = (expression & "00111010001")
                    Exit Select
                Case &H53
                    expression = (expression & "00100010111")
                    Exit Select
                Case &H54
                    expression = (expression & "00100011101")
                    Exit Select
                Case &H55
                    expression = (expression & "00100010001")
                    Exit Select
                Case &H56
                    expression = (expression & "00010100111")
                    Exit Select
                Case &H57
                    expression = (expression & "00010111001")
                    Exit Select
                Case &H58
                    expression = (expression & "00011101001")
                    Exit Select
                Case &H59
                    expression = (expression & "00010010111")
                    Exit Select
                Case 90
                    expression = (expression & "00010011101")
                    Exit Select
                Case &H5B
                    expression = (expression & "00011100101")
                    Exit Select
                Case &H5C
                    expression = (expression & "00010000101")
                    Exit Select
                Case &H5D
                    expression = (expression & "00110111101")
                    Exit Select
                Case &H5E
                    expression = (expression & "00001110101")
                    Exit Select
                Case &H5F
                    expression = (expression & "01011001111")
                    Exit Select
                Case &H60
                    expression = (expression & "01011110011")
                    Exit Select
                Case &H61
                    expression = (expression & "01101001111")
                    Exit Select
                Case &H62
                    expression = (expression & "01101111001")
                    Exit Select
                Case &H63
                    expression = (expression & "01111010011")
                    Exit Select
                Case 100
                    expression = (expression & "01111011001")
                    Exit Select
                Case &H65
                    expression = (expression & "01001101111")
                    Exit Select
                Case &H66
                    expression = (expression & "01001111011")
                    Exit Select
                Case &H67
                    expression = (expression & "01100101111")
                    Exit Select
                Case &H68
                    expression = (expression & "01100111101")
                    Exit Select
                Case &H69
                    expression = (expression & "01111001011")
                    Exit Select
                Case &H6A
                    expression = (expression & "01111001101")
                    Exit Select
                Case &H6B
                    expression = (expression & "00111101101")
                    Exit Select
                Case &H6C
                    expression = (expression & "00110101111")
                    Exit Select
                Case &H6D
                    expression = (expression & "00001000101")
                    Exit Select
                Case 110
                    expression = (expression & "00111101011")
                    Exit Select
                Case &H6F
                    expression = (expression & "01110000101")
                    Exit Select
                Case &H70
                    expression = (expression & "01011000011")
                    Exit Select
                Case &H71
                    expression = (expression & "01101000011")
                    Exit Select
                Case &H72
                    expression = (expression & "01101100001")
                    Exit Select
                Case &H73
                    expression = (expression & "01000011011")
                    Exit Select
                Case &H74
                    expression = (expression & "01100001011")
                    Exit Select
                Case &H75
                    expression = (expression & "01100001101")
                    Exit Select
                Case &H76
                    expression = (expression & "00001011011")
                    Exit Select
                Case &H77
                    expression = (expression & "00001101011")
                    Exit Select
                Case 120
                    expression = (expression & "00001101101")
                    Exit Select
                Case &H79
                    expression = (expression & "00100100001")
                    Exit Select
                Case &H7A
                    expression = (expression & "00100001001")
                    Exit Select
                Case &H7B
                    expression = (expression & "00001001001")
                    Exit Select
                Case &H7C
                    expression = (expression & "01010000111")
                    Exit Select
                Case &H7D
                    expression = (expression & "01011100001")
                    Exit Select
                Case &H7E
                    expression = (expression & "01110100001")
                    Exit Select
                Case &H7F
                    expression = (expression & "01000010111")
                    Exit Select
                Case &H80
                    expression = (expression & "01000011101")
                    Exit Select
                Case &H81
                    expression = (expression & "00001010111")
                    Exit Select
                Case 130
                    expression = (expression & "00001011101")
                    Exit Select
                Case &H83
                    expression = (expression & "01000100001")
                    Exit Select
                Case &H84
                    expression = (expression & "01000010001")
                    Exit Select
                Case &H85
                    expression = (expression & "00010100001")
                    Exit Select
                Case &H86
                    expression = (expression & "00001010001")
                    Exit Select
                Case &H87
                    expression = (expression & "00101111011")
                    Exit Select
                Case &H88
                    expression = (expression & "00101101111")
                    Exit Select
                Case &H89
                    expression = (expression & "00101100011")
                    Exit Select
                Case &H8A
                    expression = (expression & "0011100010100")
                    Exit Select
            End Select
            num += 1
        Loop
        Select Case (num2 Mod &H67)
            Case 0
                expression = (expression & "00100110011")
                Exit Select
            Case 1
                expression = (expression & "00110010011")
                Exit Select
            Case 2
                expression = (expression & "00110011001")
                Exit Select
            Case 3
                expression = (expression & "01101100111")
                Exit Select
            Case 4
                expression = (expression & "01101110011")
                Exit Select
            Case 5
                expression = (expression & "01110110011")
                Exit Select
            Case 6
                expression = (expression & "01100110111")
                Exit Select
            Case 7
                expression = (expression & "01100111011")
                Exit Select
            Case 8
                expression = (expression & "01110011011")
                Exit Select
            Case 9
                expression = (expression & "00110110111")
                Exit Select
            Case 10
                expression = (expression & "00110111011")
                Exit Select
            Case 11
                expression = (expression & "00111011011")
                Exit Select
            Case 12
                expression = (expression & "01001100011")
                Exit Select
            Case 13
                expression = (expression & "01100100011")
                Exit Select
            Case 14
                expression = (expression & "01100110001")
                Exit Select
            Case 15
                expression = (expression & "01000110011")
                Exit Select
            Case &H10
                expression = (expression & "01100010011")
                Exit Select
            Case &H11
                expression = (expression & "01100011001")
                Exit Select
            Case &H12
                expression = (expression & "00110001101")
                Exit Select
            Case &H13
                expression = (expression & "00110100011")
                Exit Select
            Case 20
                expression = (expression & "00110110001")
                Exit Select
            Case &H15
                expression = (expression & "00100011011")
                Exit Select
            Case &H16
                expression = (expression & "00110001011")
                Exit Select
            Case &H17
                expression = (expression & "00010010001")
                Exit Select
            Case &H18
                expression = (expression & "00010110011")
                Exit Select
            Case &H19
                expression = (expression & "00011010011")
                Exit Select
            Case &H1A
                expression = (expression & "00011011001")
                Exit Select
            Case &H1B
                expression = (expression & "00010011011")
                Exit Select
            Case &H1C
                expression = (expression & "00011001011")
                Exit Select
            Case &H1D
                expression = (expression & "00011001101")
                Exit Select
            Case 30
                expression = (expression & "00100100111")
                Exit Select
            Case &H1F
                expression = (expression & "00100111001")
                Exit Select
            Case &H20
                expression = (expression & "00111001001")
                Exit Select
            Case &H21
                expression = (expression & "01011100111")
                Exit Select
            Case &H22
                expression = (expression & "01110100111")
                Exit Select
            Case &H23
                expression = (expression & "01110111001")
                Exit Select
            Case &H24
                expression = (expression & "01001110111")
                Exit Select
            Case &H25
                expression = (expression & "01110010111")
                Exit Select
            Case &H26
                expression = (expression & "01110011101")
                Exit Select
            Case &H27
                expression = (expression & "00101110111")
                Exit Select
            Case 40
                expression = (expression & "00111010111")
                Exit Select
            Case &H29
                expression = (expression & "00111011101")
                Exit Select
            Case &H2A
                expression = (expression & "01001000111")
                Exit Select
            Case &H2B
                expression = (expression & "01001110001")
                Exit Select
            Case &H2C
                expression = (expression & "01110010001")
                Exit Select
            Case &H2D
                expression = (expression & "01000100111")
                Exit Select
            Case &H2E
                expression = (expression & "01000111001")
                Exit Select
            Case &H2F
                expression = (expression & "01110001001")
                Exit Select
            Case &H30
                expression = (expression & "00010001001")
                Exit Select
            Case &H31
                expression = (expression & "00101110001")
                Exit Select
            Case 50
                expression = (expression & "00111010001")
                Exit Select
            Case &H33
                expression = (expression & "00100010111")
                Exit Select
            Case &H34
                expression = (expression & "00100011101")
                Exit Select
            Case &H35
                expression = (expression & "00100010001")
                Exit Select
            Case &H36
                expression = (expression & "00010100111")
                Exit Select
            Case &H37
                expression = (expression & "00010111001")
                Exit Select
            Case &H38
                expression = (expression & "00011101001")
                Exit Select
            Case &H39
                expression = (expression & "00010010111")
                Exit Select
            Case &H3A
                expression = (expression & "00010011101")
                Exit Select
            Case &H3B
                expression = (expression & "00011100101")
                Exit Select
            Case 60
                expression = (expression & "00010000101")
                Exit Select
            Case &H3D
                expression = (expression & "00110111101")
                Exit Select
            Case &H3E
                expression = (expression & "00001110101")
                Exit Select
            Case &H3F
                expression = (expression & "01011001111")
                Exit Select
            Case &H40
                expression = (expression & "01011110011")
                Exit Select
            Case &H41
                expression = (expression & "01101001111")
                Exit Select
            Case &H42
                expression = (expression & "01101111001")
                Exit Select
            Case &H43
                expression = (expression & "01111010011")
                Exit Select
            Case &H44
                expression = (expression & "01111011001")
                Exit Select
            Case &H45
                expression = (expression & "01001101111")
                Exit Select
            Case 70
                expression = (expression & "01001111011")
                Exit Select
            Case &H47
                expression = (expression & "01100101111")
                Exit Select
            Case &H48
                expression = (expression & "01100111101")
                Exit Select
            Case &H49
                expression = (expression & "01111001011")
                Exit Select
            Case &H4A
                expression = (expression & "01111001101")
                Exit Select
            Case &H4B
                expression = (expression & "00111101101")
                Exit Select
            Case &H4C
                expression = (expression & "00110101111")
                Exit Select
            Case &H4D
                expression = (expression & "00001000101")
                Exit Select
            Case &H4E
                expression = (expression & "00111101011")
                Exit Select
            Case &H4F
                expression = (expression & "01110000101")
                Exit Select
            Case 80
                expression = (expression & "01011000011")
                Exit Select
            Case &H51
                expression = (expression & "01101000011")
                Exit Select
            Case &H52
                expression = (expression & "01101100001")
                Exit Select
            Case &H53
                expression = (expression & "01000011011")
                Exit Select
            Case &H54
                expression = (expression & "01100001011")
                Exit Select
            Case &H55
                expression = (expression & "01100001101")
                Exit Select
            Case &H56
                expression = (expression & "00001011011")
                Exit Select
            Case &H57
                expression = (expression & "00001101011")
                Exit Select
            Case &H58
                expression = (expression & "00001101101")
                Exit Select
            Case &H59
                expression = (expression & "00100100001")
                Exit Select
            Case 90
                expression = (expression & "00100001001")
                Exit Select
            Case &H5B
                expression = (expression & "00001001001")
                Exit Select
            Case &H5C
                expression = (expression & "01010000111")
                Exit Select
            Case &H5D
                expression = (expression & "01011100001")
                Exit Select
            Case &H5E
                expression = (expression & "01110100001")
                Exit Select
            Case &H5F
                expression = (expression & "01000010111")
                Exit Select
            Case &H60
                expression = (expression & "01000011101")
                Exit Select
            Case &H61
                expression = (expression & "00001010111")
                Exit Select
            Case &H62
                expression = (expression & "00001011101")
                Exit Select
            Case &H63
                expression = (expression & "01000100001")
                Exit Select
            Case 100
                expression = (expression & "01000010001")
                Exit Select
            Case &H65
                expression = (expression & "00010100001")
                Exit Select
            Case &H66
                expression = (expression & "00001010001")
                Exit Select
        End Select
        expression = (expression & "0011100010100")
        Dim image As New Bitmap(Strings.Len(expression), 300, PixelFormat.Format24bppRgb)
        Dim graphics As Graphics = Graphics.FromImage(image)
        Dim rect As New Rectangle(0, 0, image.Width, image.Height)
        Dim brush As Brush = New LinearGradientBrush(rect, Color.White, Color.White, LinearGradientMode.ForwardDiagonal)
        graphics.FillRectangle(brush, rect)
        Dim num5 As Integer = Strings.Len(expression)
        num = 1
        Do While (num <= num5)
            Dim pen As Pen
            Dim point As Point
            Dim point2 As Point
            Dim pen2 As Pen
            Dim point3 As Point
            Dim point4 As Point
            If (Strings.Mid(expression, num, 1) = "0") Then
                pen = New Pen(Color.Black, 1.0!)
                point = New Point(num, &H37)
                point2 = New Point(num, &H4B)
                graphics.DrawLine(pen, point, point2)
                pen2 = New Pen(Color.Black, 1.0!)
                point3 = New Point(num, 5)
                point4 = New Point(num, &H19)
                graphics.DrawLine(pen2, point3, point4)
            Else
                pen = New Pen(Color.White, 1.0!)
                point = New Point(num, &H37)
                point2 = New Point(num, &H4B)
                graphics.DrawLine(pen, point, point2)
                pen2 = New Pen(Color.White, 1.0!)
                point3 = New Point(num, 5)
                point4 = New Point(num, &H19)
                graphics.DrawLine(pen2, point3, point4)
            End If
            num += 1
        Loop
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H4B))
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H19))
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H4B))
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H19))
        Return image
    End Function




    Public Function Code128X(ByVal TheText As String, ByVal CodeLetter As String) As Image
        Dim num As Integer
        Dim num2 As Integer
        Dim expression As String = ""
        If ((CodeLetter = "A") Or (CodeLetter = "a")) Then
            num2 = &H67
            expression = "00101111011"
        End If
        If ((CodeLetter = "B") Or (CodeLetter = "b")) Then
            num2 = &H68
            expression = "00101101111"
        End If
        If ((CodeLetter = "C") Or (CodeLetter = "c")) Then
            num2 = &H69
            expression = "00101100011"
        End If
        Dim num3 As Integer = Strings.Len(TheText)
        num = 1
        Do While (num <= num3)
            num2 = (num2 + ((Strings.Asc(Strings.Mid(TheText, num, 1)) - &H20) * num))
            Select Case Strings.Asc(Strings.Mid(TheText, num, 1))
                Case &H20
                    expression = (expression & "00100110011")
                    Exit Select
                Case &H21
                    expression = (expression & "00110010011")
                    Exit Select
                Case &H22
                    expression = (expression & "00110011001")
                    Exit Select
                Case &H23
                    expression = (expression & "01101100111")
                    Exit Select
                Case &H24
                    expression = (expression & "01101110011")
                    Exit Select
                Case &H25
                    expression = (expression & "01110110011")
                    Exit Select
                Case &H26
                    expression = (expression & "01100110111")
                    Exit Select
                Case &H27
                    expression = (expression & "01100111011")
                    Exit Select
                Case 40
                    expression = (expression & "01110011011")
                    Exit Select
                Case &H29
                    expression = (expression & "00110110111")
                    Exit Select
                Case &H2A
                    expression = (expression & "00110111011")
                    Exit Select
                Case &H2B
                    expression = (expression & "00111011011")
                    Exit Select
                Case &H2C
                    expression = (expression & "01001100011")
                    Exit Select
                Case &H2D
                    expression = (expression & "01100100011")
                    Exit Select
                Case &H2E
                    expression = (expression & "01100110001")
                    Exit Select
                Case &H2F
                    expression = (expression & "01000110011")
                    Exit Select
                Case &H30
                    expression = (expression & "01100010011")
                    Exit Select
                Case &H31
                    expression = (expression & "01100011001")
                    Exit Select
                Case 50
                    expression = (expression & "00110001101")
                    Exit Select
                Case &H33
                    expression = (expression & "00110100011")
                    Exit Select
                Case &H34
                    expression = (expression & "00110110001")
                    Exit Select
                Case &H35
                    expression = (expression & "00100011011")
                    Exit Select
                Case &H36
                    expression = (expression & "00110001011")
                    Exit Select
                Case &H37
                    expression = (expression & "00010010001")
                    Exit Select
                Case &H38
                    expression = (expression & "00010110011")
                    Exit Select
                Case &H39
                    expression = (expression & "00011010011")
                    Exit Select
                Case &H3A
                    expression = (expression & "00011011001")
                    Exit Select
                Case &H3B
                    expression = (expression & "00010011011")
                    Exit Select
                Case 60
                    expression = (expression & "00011001011")
                    Exit Select
                Case &H3D
                    expression = (expression & "00011001101")
                    Exit Select
                Case &H3E
                    expression = (expression & "00100100111")
                    Exit Select
                Case &H3F
                    expression = (expression & "00100111001")
                    Exit Select
                Case &H40
                    expression = (expression & "00111001001")
                    Exit Select
                Case &H41
                    expression = (expression & "01011100111")
                    Exit Select
                Case &H42
                    expression = (expression & "01110100111")
                    Exit Select
                Case &H43
                    expression = (expression & "01110111001")
                    Exit Select
                Case &H44
                    expression = (expression & "01001110111")
                    Exit Select
                Case &H45
                    expression = (expression & "01110010111")
                    Exit Select
                Case 70
                    expression = (expression & "01110011101")
                    Exit Select
                Case &H47
                    expression = (expression & "00101110111")
                    Exit Select
                Case &H48
                    expression = (expression & "00111010111")
                    Exit Select
                Case &H49
                    expression = (expression & "00111011101")
                    Exit Select
                Case &H4A
                    expression = (expression & "01001000111")
                    Exit Select
                Case &H4B
                    expression = (expression & "01001110001")
                    Exit Select
                Case &H4C
                    expression = (expression & "01110010001")
                    Exit Select
                Case &H4D
                    expression = (expression & "01000100111")
                    Exit Select
                Case &H4E
                    expression = (expression & "01000111001")
                    Exit Select
                Case &H4F
                    expression = (expression & "01110001001")
                    Exit Select
                Case 80
                    expression = (expression & "00010001001")
                    Exit Select
                Case &H51
                    expression = (expression & "00101110001")
                    Exit Select
                Case &H52
                    expression = (expression & "00111010001")
                    Exit Select
                Case &H53
                    expression = (expression & "00100010111")
                    Exit Select
                Case &H54
                    expression = (expression & "00100011101")
                    Exit Select
                Case &H55
                    expression = (expression & "00100010001")
                    Exit Select
                Case &H56
                    expression = (expression & "00010100111")
                    Exit Select
                Case &H57
                    expression = (expression & "00010111001")
                    Exit Select
                Case &H58
                    expression = (expression & "00011101001")
                    Exit Select
                Case &H59
                    expression = (expression & "00010010111")
                    Exit Select
                Case 90
                    expression = (expression & "00010011101")
                    Exit Select
                Case &H5B
                    expression = (expression & "00011100101")
                    Exit Select
                Case &H5C
                    expression = (expression & "00010000101")
                    Exit Select
                Case &H5D
                    expression = (expression & "00110111101")
                    Exit Select
                Case &H5E
                    expression = (expression & "00001110101")
                    Exit Select
                Case &H5F
                    expression = (expression & "01011001111")
                    Exit Select
                Case &H60
                    expression = (expression & "01011110011")
                    Exit Select
                Case &H61
                    expression = (expression & "01101001111")
                    Exit Select
                Case &H62
                    expression = (expression & "01101111001")
                    Exit Select
                Case &H63
                    expression = (expression & "01111010011")
                    Exit Select
                Case 100
                    expression = (expression & "01111011001")
                    Exit Select
                Case &H65
                    expression = (expression & "01001101111")
                    Exit Select
                Case &H66
                    expression = (expression & "01001111011")
                    Exit Select
                Case &H67
                    expression = (expression & "01100101111")
                    Exit Select
                Case &H68
                    expression = (expression & "01100111101")
                    Exit Select
                Case &H69
                    expression = (expression & "01111001011")
                    Exit Select
                Case &H6A
                    expression = (expression & "01111001101")
                    Exit Select
                Case &H6B
                    expression = (expression & "00111101101")
                    Exit Select
                Case &H6C
                    expression = (expression & "00110101111")
                    Exit Select
                Case &H6D
                    expression = (expression & "00001000101")
                    Exit Select
                Case 110
                    expression = (expression & "00111101011")
                    Exit Select
                Case &H6F
                    expression = (expression & "01110000101")
                    Exit Select
                Case &H70
                    expression = (expression & "01011000011")
                    Exit Select
                Case &H71
                    expression = (expression & "01101000011")
                    Exit Select
                Case &H72
                    expression = (expression & "01101100001")
                    Exit Select
                Case &H73
                    expression = (expression & "01000011011")
                    Exit Select
                Case &H74
                    expression = (expression & "01100001011")
                    Exit Select
                Case &H75
                    expression = (expression & "01100001101")
                    Exit Select
                Case &H76
                    expression = (expression & "00001011011")
                    Exit Select
                Case &H77
                    expression = (expression & "00001101011")
                    Exit Select
                Case 120
                    expression = (expression & "00001101101")
                    Exit Select
                Case &H79
                    expression = (expression & "00100100001")
                    Exit Select
                Case &H7A
                    expression = (expression & "00100001001")
                    Exit Select
                Case &H7B
                    expression = (expression & "00001001001")
                    Exit Select
                Case &H7C
                    expression = (expression & "01010000111")
                    Exit Select
                Case &H7D
                    expression = (expression & "01011100001")
                    Exit Select
                Case &H7E
                    expression = (expression & "01110100001")
                    Exit Select
                Case &H7F
                    expression = (expression & "01000010111")
                    Exit Select
                Case &H80
                    expression = (expression & "01000011101")
                    Exit Select
                Case &H81
                    expression = (expression & "00001010111")
                    Exit Select
                Case 130
                    expression = (expression & "00001011101")
                    Exit Select
                Case &H83
                    expression = (expression & "01000100001")
                    Exit Select
                Case &H84
                    expression = (expression & "01000010001")
                    Exit Select
                Case &H85
                    expression = (expression & "00010100001")
                    Exit Select
                Case &H86
                    expression = (expression & "00001010001")
                    Exit Select
                Case &H87
                    expression = (expression & "00101111011")
                    Exit Select
                Case &H88
                    expression = (expression & "00101101111")
                    Exit Select
                Case &H89
                    expression = (expression & "00101100011")
                    Exit Select
                Case &H8A
                    expression = (expression & "0011100010100")
                    Exit Select
            End Select
            num += 1
        Loop
        Select Case (num2 Mod &H67)
            Case 0
                expression = (expression & "00100110011")
                Exit Select
            Case 1
                expression = (expression & "00110010011")
                Exit Select
            Case 2
                expression = (expression & "00110011001")
                Exit Select
            Case 3
                expression = (expression & "01101100111")
                Exit Select
            Case 4
                expression = (expression & "01101110011")
                Exit Select
            Case 5
                expression = (expression & "01110110011")
                Exit Select
            Case 6
                expression = (expression & "01100110111")
                Exit Select
            Case 7
                expression = (expression & "01100111011")
                Exit Select
            Case 8
                expression = (expression & "01110011011")
                Exit Select
            Case 9
                expression = (expression & "00110110111")
                Exit Select
            Case 10
                expression = (expression & "00110111011")
                Exit Select
            Case 11
                expression = (expression & "00111011011")
                Exit Select
            Case 12
                expression = (expression & "01001100011")
                Exit Select
            Case 13
                expression = (expression & "01100100011")
                Exit Select
            Case 14
                expression = (expression & "01100110001")
                Exit Select
            Case 15
                expression = (expression & "01000110011")
                Exit Select
            Case &H10
                expression = (expression & "01100010011")
                Exit Select
            Case &H11
                expression = (expression & "01100011001")
                Exit Select
            Case &H12
                expression = (expression & "00110001101")
                Exit Select
            Case &H13
                expression = (expression & "00110100011")
                Exit Select
            Case 20
                expression = (expression & "00110110001")
                Exit Select
            Case &H15
                expression = (expression & "00100011011")
                Exit Select
            Case &H16
                expression = (expression & "00110001011")
                Exit Select
            Case &H17
                expression = (expression & "00010010001")
                Exit Select
            Case &H18
                expression = (expression & "00010110011")
                Exit Select
            Case &H19
                expression = (expression & "00011010011")
                Exit Select
            Case &H1A
                expression = (expression & "00011011001")
                Exit Select
            Case &H1B
                expression = (expression & "00010011011")
                Exit Select
            Case &H1C
                expression = (expression & "00011001011")
                Exit Select
            Case &H1D
                expression = (expression & "00011001101")
                Exit Select
            Case 30
                expression = (expression & "00100100111")
                Exit Select
            Case &H1F
                expression = (expression & "00100111001")
                Exit Select
            Case &H20
                expression = (expression & "00111001001")
                Exit Select
            Case &H21
                expression = (expression & "01011100111")
                Exit Select
            Case &H22
                expression = (expression & "01110100111")
                Exit Select
            Case &H23
                expression = (expression & "01110111001")
                Exit Select
            Case &H24
                expression = (expression & "01001110111")
                Exit Select
            Case &H25
                expression = (expression & "01110010111")
                Exit Select
            Case &H26
                expression = (expression & "01110011101")
                Exit Select
            Case &H27
                expression = (expression & "00101110111")
                Exit Select
            Case 40
                expression = (expression & "00111010111")
                Exit Select
            Case &H29
                expression = (expression & "00111011101")
                Exit Select
            Case &H2A
                expression = (expression & "01001000111")
                Exit Select
            Case &H2B
                expression = (expression & "01001110001")
                Exit Select
            Case &H2C
                expression = (expression & "01110010001")
                Exit Select
            Case &H2D
                expression = (expression & "01000100111")
                Exit Select
            Case &H2E
                expression = (expression & "01000111001")
                Exit Select
            Case &H2F
                expression = (expression & "01110001001")
                Exit Select
            Case &H30
                expression = (expression & "00010001001")
                Exit Select
            Case &H31
                expression = (expression & "00101110001")
                Exit Select
            Case 50
                expression = (expression & "00111010001")
                Exit Select
            Case &H33
                expression = (expression & "00100010111")
                Exit Select
            Case &H34
                expression = (expression & "00100011101")
                Exit Select
            Case &H35
                expression = (expression & "00100010001")
                Exit Select
            Case &H36
                expression = (expression & "00010100111")
                Exit Select
            Case &H37
                expression = (expression & "00010111001")
                Exit Select
            Case &H38
                expression = (expression & "00011101001")
                Exit Select
            Case &H39
                expression = (expression & "00010010111")
                Exit Select
            Case &H3A
                expression = (expression & "00010011101")
                Exit Select
            Case &H3B
                expression = (expression & "00011100101")
                Exit Select
            Case 60
                expression = (expression & "00010000101")
                Exit Select
            Case &H3D
                expression = (expression & "00110111101")
                Exit Select
            Case &H3E
                expression = (expression & "00001110101")
                Exit Select
            Case &H3F
                expression = (expression & "01011001111")
                Exit Select
            Case &H40
                expression = (expression & "01011110011")
                Exit Select
            Case &H41
                expression = (expression & "01101001111")
                Exit Select
            Case &H42
                expression = (expression & "01101111001")
                Exit Select
            Case &H43
                expression = (expression & "01111010011")
                Exit Select
            Case &H44
                expression = (expression & "01111011001")
                Exit Select
            Case &H45
                expression = (expression & "01001101111")
                Exit Select
            Case 70
                expression = (expression & "01001111011")
                Exit Select
            Case &H47
                expression = (expression & "01100101111")
                Exit Select
            Case &H48
                expression = (expression & "01100111101")
                Exit Select
            Case &H49
                expression = (expression & "01111001011")
                Exit Select
            Case &H4A
                expression = (expression & "01111001101")
                Exit Select
            Case &H4B
                expression = (expression & "00111101101")
                Exit Select
            Case &H4C
                expression = (expression & "00110101111")
                Exit Select
            Case &H4D
                expression = (expression & "00001000101")
                Exit Select
            Case &H4E
                expression = (expression & "00111101011")
                Exit Select
            Case &H4F
                expression = (expression & "01110000101")
                Exit Select
            Case 80
                expression = (expression & "01011000011")
                Exit Select
            Case &H51
                expression = (expression & "01101000011")
                Exit Select
            Case &H52
                expression = (expression & "01101100001")
                Exit Select
            Case &H53
                expression = (expression & "01000011011")
                Exit Select
            Case &H54
                expression = (expression & "01100001011")
                Exit Select
            Case &H55
                expression = (expression & "01100001101")
                Exit Select
            Case &H56
                expression = (expression & "00001011011")
                Exit Select
            Case &H57
                expression = (expression & "00001101011")
                Exit Select
            Case &H58
                expression = (expression & "00001101101")
                Exit Select
            Case &H59
                expression = (expression & "00100100001")
                Exit Select
            Case 90
                expression = (expression & "00100001001")
                Exit Select
            Case &H5B
                expression = (expression & "00001001001")
                Exit Select
            Case &H5C
                expression = (expression & "01010000111")
                Exit Select
            Case &H5D
                expression = (expression & "01011100001")
                Exit Select
            Case &H5E
                expression = (expression & "01110100001")
                Exit Select
            Case &H5F
                expression = (expression & "01000010111")
                Exit Select
            Case &H60
                expression = (expression & "01000011101")
                Exit Select
            Case &H61
                expression = (expression & "00001010111")
                Exit Select
            Case &H62
                expression = (expression & "00001011101")
                Exit Select
            Case &H63
                expression = (expression & "01000100001")
                Exit Select
            Case 100
                expression = (expression & "01000010001")
                Exit Select
            Case &H65
                expression = (expression & "00010100001")
                Exit Select
            Case &H66
                expression = (expression & "00001010001")
                Exit Select
        End Select
        expression = (expression & "0011100010100")
        Dim image As New Bitmap(Strings.Len(expression), 300, PixelFormat.Format24bppRgb)
        Dim graphics As Graphics = Graphics.FromImage(image)
        Dim rect As New Rectangle(0, 0, image.Width, image.Height)
        Dim brush As Brush = New LinearGradientBrush(rect, Color.White, Color.White, LinearGradientMode.ForwardDiagonal)
        graphics.FillRectangle(brush, rect)
        Dim num5 As Integer = Strings.Len(expression)
        num = 1
        Do While (num <= num5)
            Dim pen As Pen
            Dim point As Point
            Dim point2 As Point
            Dim pen2 As Pen
            Dim point3 As Point
            Dim point4 As Point
            If (Strings.Mid(expression, num, 1) = "0") Then
                pen = New Pen(Color.Black, 1.0!)
                point = New Point(num, &H37)
                point2 = New Point(num, &H4B)
                graphics.DrawLine(pen, point, point2)
                pen2 = New Pen(Color.Black, 1.0!)
                point3 = New Point(num, 5)
                point4 = New Point(num, &H19)
                graphics.DrawLine(pen2, point3, point4)
            Else
                pen = New Pen(Color.White, 1.0!)
                point = New Point(num, &H37)
                point2 = New Point(num, &H4B)
                graphics.DrawLine(pen, point, point2)
                pen2 = New Pen(Color.White, 1.0!)
                point3 = New Point(num, 5)
                point4 = New Point(num, &H19)
                graphics.DrawLine(pen2, point3, point4)
            End If
            num += 1
        Loop
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H4B))
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H19))
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H4B))
        graphics.DrawString((Form1.TextBox1.Text & " L.E"), New Font("times new roman", 10.0!, FontStyle.Bold), New SolidBrush(Color.Black), New Point(0, &H19))
        Return image
    End Function
    Public Function Toc(ByVal Text2CStr As String) As String
        Dim start As Integer = 1
        Dim str2 As String = ""
        Dim inputStr As String = ""
        Do While True
            inputStr = Strings.Mid(Text2CStr, start, 2)
            str2 = (str2 & Conversions.ToString(Strings.Chr(CInt(Math.Round(CDbl((Conversion.Val(inputStr) + 32)))))))
            start = (start + 2)
            inputStr = Strings.Mid(Text2CStr, start, 1)
            If ((start >= Strings.Len(Text2CStr)) OrElse (inputStr = "")) Then
                Return str2
            End If
        Loop
    End Function



End Module

Public Class SixSixSix

    Dim firstNumber As Decimal

    Dim secondNumber As Decimal

    Dim operation As String

    Dim number As Decimal

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'Enter
        If operation = "plus" Then
            number = firstNumber + secondNumber
        End If

        If operation = "minus" Then
            number = firstNumber - secondNumber
        End If

        If operation = "divide" Then
            number = firstNumber / secondNumber
        End If

        If operation = "multiply" Then
            number = firstNumber * secondNumber
        End If

        MessageBox.Show(CStr(number))

        which = 1
        TextBox1.Text = CStr(number)

        Me.Text = CStr(number)
    End Sub

    Dim which = 1

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        number = 0
        TextBox1.Text = CStr(number)
        firstNumber = 0
        secondNumber = 0
        which = 1
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = FormatNumber(firstNumber, j - i)
            Else
                firstNumber = firstNumber * 10 + 0
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = FormatNumber(secondNumber, j - i)
            Else
                secondNumber = secondNumber * 10 + 0
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 1 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 1
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 1 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 1
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 2 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 2
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 2 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 2
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 3 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 3
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 3 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 3
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 4 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 4
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 4 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 4
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 5 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 5
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 5 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 5
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 6 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 6
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 6 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 6
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 7 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 7
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 7 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 7
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 8 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 8
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 8 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 8
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If which = 1 Then
            If (TextBox1.Text.Contains(".")) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                firstNumber = firstNumber + 9 / Math.Pow(10, (j - i))
            Else
                firstNumber = firstNumber * 10 + 9
            End If
            TextBox1.Text = CStr(firstNumber)
            secondNumber = 0

        ElseIf which = 2 Then
            If (TextBox1.Text.Contains(".") And secondNumber <> 0) Then
                Dim i = TextBox1.Text.IndexOf(".")
                Dim j = TextBox1.Text.Length
                secondNumber = secondNumber + 9 / Math.Pow(10, (j - i))
            Else
                secondNumber = secondNumber * 10 + 9
            End If
            TextBox1.Text = CStr(secondNumber)

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Plus
        operation = "plus"
        which = 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        operation = "minus"
        which = 2
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        operation = "multiply"
        which = 2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        operation = "divide"
        which = 2
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (Not TextBox1.Text.Contains(".")) Then
            If which = 1 Then
                TextBox1.Text = CStr(firstNumber) + "."
            ElseIf which = 2 Then
                TextBox1.Text = CStr(secondNumber) + "."
            End If
        End If
    End Sub
End Class

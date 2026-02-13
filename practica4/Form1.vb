Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sumar.Click

        Dim Numero1 As Integer = Integer.Parse(Me.numero1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.numero2.Text)

        Dim resultado As Integer = Numero1 + Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Restar.Click
        Dim Numero1 As Integer = Integer.Parse(Me.numero1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.numero2.Text)

        Dim resultado As Integer = Numero1 - Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        Dim Numero1 As Integer = Integer.Parse(Me.numero1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.numero2.Text)

        Dim resultado As Integer = Numero1 * Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim Numero1 As Integer = Integer.Parse(Me.numero1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.numero2.Text)

        Dim resultado As Integer = Numero1 / Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        numero1.Text = numero1.Text & "0"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        numero1.Text = numero1.Text & "1"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        numero1.Text = numero1.Text & "2"
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        numero1.Text = numero1.Text & "3"
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        numero1.Text = numero1.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        numero1.Text = numero1.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        numero1.Text = numero1.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        numero1.Text = numero1.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        numero1.Text = numero1.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        numero1.Text = numero1.Text & "9"
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        numero1.Text = ""
    End Sub
End Class

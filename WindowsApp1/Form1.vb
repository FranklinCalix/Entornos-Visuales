Public Class Form1
    Private Sub SUMA_Click(sender As Object, e As EventArgs) Handles SUMA.Click
        Dim val1 As Integer = Val(TextBox1.Text)
        Dim val2 As Integer = Val(TextBox2.Text)
        Dim result As Integer = val1 + val2

        TextBox3.Text = result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RESTA.Click
        Dim val1 As Integer = Val(TextBox1.Text)
        Dim val2 As Integer = Val(TextBox2.Text)
        Dim result As Integer = val1 - val2

        TextBox3.Text = result
    End Sub

    Private Sub MULTI_Click(sender As Object, e As EventArgs) Handles MULTI.Click
        Dim val1 As Integer = Val(TextBox1.Text)
        Dim val2 As Integer = Val(TextBox2.Text)
        Dim result As Integer = val1 * val2

        TextBox3.Text = result
    End Sub

    Private Sub DIV_Click(sender As Object, e As EventArgs) Handles DIV.Click
        Dim val1 As Integer = Val(TextBox1.Text)
        Dim val2 As Integer = Val(TextBox2.Text)
        Dim result As Integer = val1 / val2

        TextBox3.Text = result
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        End
    End Sub
End Class

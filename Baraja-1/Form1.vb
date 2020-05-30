Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim palo() As String = {"Picas", "Corazones", "Diamantes", "Tréboles"}
        Dim carta() As String = {"As", "Dos", "Tres", "Cuatro", "Cinc", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Jota", "Reina", "Rey"}
        Dim ipalo, icarta As Integer

        ipalo = Int(Rnd() * 4)
        icarta = Int(Rnd() * 13)

        TextBox1.Text = carta(icarta) + " de  " + palo(ipalo)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class

Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim CambioSigno As Double
    Dim BotonOperacion As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        EvaluaRestriccionParaIngresar()
        TextBox_result.Text &= "0"
    End Sub

    Private Sub Button_igual_Click(sender As Object, e As EventArgs) Handles Button_igual.Click
        RealizarOperacion()
        Operacion = ""
    End Sub

    Private Sub Button_mas_Click(sender As Object, e As EventArgs) Handles Button_mas.Click
        RealizarOperacion()
        Operacion = "+"
        TextBox1.Text = TextBox1.Text & " " & ValorResultado & " " & Operacion
    End Sub

    Private Sub Button_menos_Click(sender As Object, e As EventArgs) Handles Button_menos.Click
        RealizarOperacion()
        Operacion = "-"
    End Sub

    Private Sub Button_multi_Click(sender As Object, e As EventArgs) Handles Button_multi.Click
        RealizarOperacion()
        Operacion = "*"
    End Sub

    Private Sub Button_div_Click(sender As Object, e As EventArgs) Handles Button_div.Click
        RealizarOperacion()
        Operacion = "/"
    End Sub

    Private Sub Button_punt_Click(sender As Object, e As EventArgs) Handles Button_punt.Click
        EvaluaRestriccionParaIngresar()
        If InStr(TextBox_result.Text, ".", CompareMethod.Text) = 0 Then
            TextBox_result.Text &= "."
        End If
    End Sub

    Private Sub Button_CambioSigno_Click(sender As Object, e As EventArgs) Handles Button_CambioSigno.Click
        CambioSigno = Val(TextBox_result.Text) * -1
        TextBox_result.Text = CambioSigno
    End Sub


    Private Sub Button_limp_Click(sender As Object, e As EventArgs) Handles Button_limp.Click
        TextBox_result.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing

    End Sub
    Public Sub RealizarOperacion()
        BotonOperacion = True
        Valor2 = Val(TextBox_result.Text) 'Valor2 = lo que haya en la caja de texto
        If ValorResultado IsNot Nothing Then 'Si ValorRsultado no esta vacio
            Select Case Operacion 'Se elije un case dependiendo del operador selecionado
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                    TextBox1.Text = ValorResultado & " +"
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado = ValorResultado / Valor2

            End Select
            TextBox_result.Text = ValorResultado 'La caja de texto mostrara el resultado
        Else
            ValorResultado = Valor2 'Si ValorResultado esta vacio, ValorResultado = Valor2
        End If

    End Sub

    Public Sub EvaluaRestriccionParaIngresar()
        If BotonOperacion = True Then 'Si se invoco "RealizarOperacion"
            TextBox_result.Text = "" 'Se limpia la caja de texto
            BotonOperacion = False 'Bandera=false 
        ElseIf TextBox_result.Text = "0" Then 'Si en la caja de texto hay 0
            TextBox_result.Text = "" 'Entonces no hay nada y al ingresar algo este desaparece
        End If
    End Sub
End Class

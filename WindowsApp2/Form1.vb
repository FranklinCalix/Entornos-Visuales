Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim pUnitario As Integer = TextpUnidad.Text 'Casilla precio initario
        Dim Cantidad As Integer = TextCant.Text 'Casilla cantidad
        Dim SubTotal As Integer = pUnitario * Cantidad  'Casilla subTotal
        Dim aplicaDescuento As Boolean = DescuentoChek.Checked  'Activar/Desactivar Descuento
        Dim aplicaISV As Boolean = ISVChek.Checked  'Activar/Desactivar ISV

        If aplicaDescuento = True Then
            TextISV.Text = 500
            ISVChek.Enabled = False
        End If

        TextSubTotal.Text = SubTotal

        TextTotal.Text = SubTotal

        TextDescuento.Text = 200



    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click

        TextpUnidad.Clear()
        TextCant.Clear()
        TextSubTotal.Clear()
        TextTotal.Clear()
        TextDescuento.Clear()
        TextISV.Clear()
        'DescuentoChek = False

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub TextpUnidad_TextChanged(sender As Object, e As EventArgs) Handles TextpUnidad.TextChanged

    End Sub


End Class

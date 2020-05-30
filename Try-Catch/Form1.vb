Imports System.ComponentModel

Public Class Form1
    Private Sub ButtonValidar_Click(sender As Object, e As EventArgs) Handles ButtonValidar.Click

        'Try Catch
        'validatechildren -> boton
        'Validating -> cajas de texto
        Try
            'Si las casillas estan vacias


            '-----------------------------------------------------------'Val(TextBoxPrecio.Text) > 0
            If Me.ValidateChildren And TextBoxProducto.Text <> String.Empty And TextBoxPrecio.Text <> String.Empty And Val(TextBoxCantidad.Text) - Int(Val(TextBoxCantidad.Text)) = 0 And TextBoxCantidad.Text <> String.Empty Then
                MessageBox.Show("Productos ingresado", "Formulario ProductoS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBoxProducto_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Producto")
        End If
    End Sub

    Private Sub TextBoxPrecio_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Precio")
        End If
    End Sub

    Private Sub TextBoxCantidad_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxCantidad.Validating
        If Val(TextBoxCantidad.Text) - Int(Val(TextBoxCantidad.Text)) = 0 And TextBoxCantidad.Text <> String.Empty Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    Private Sub TextBoxProducto_MouseHover(sender As Object, e As EventArgs) Handles TextBoxProducto.MouseHover
        ToolTip1.SetToolTip(TextBoxProducto, "Ingrese un producto")
        ToolTip1.ToolTipTitle = "Producto"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub TextBoxPrecio_MouseHover(sender As Object, e As EventArgs) Handles TextBoxPrecio.MouseHover
        ToolTip1.SetToolTip(TextBoxPrecio, "Ingrese un precio")
        ToolTip1.ToolTipTitle = "Precio"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBoxCantidad_MouseHover(sender As Object, e As EventArgs) Handles TextBoxCantidad.MouseHover
        ToolTip1.SetToolTip(TextBoxCantidad, "Ingrese una cantidad (Entero)")
        ToolTip1.ToolTipTitle = "Cantidad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim itemid As Integer
        Dim itenmnombre As String

        itemid = ComboBox1.SelectedIndex
        itenmnombre = ComboBox1.SelectedItem.ToString

        Select Case itemid
            Case 0
                MsgBox(itenmnombre)
            Case 1
                MsgBox(itenmnombre)
            Case 2
                MsgBox(itenmnombre)
            Case 3
                MsgBox(itenmnombre)
            Case 4
                MsgBox(itenmnombre)
            Case 5
                MsgBox(itenmnombre)
            Case Else
                MsgBox("Seleciona un valor correcto.")

        End Select


    End Sub
End Class

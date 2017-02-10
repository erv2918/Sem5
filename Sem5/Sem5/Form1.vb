Public Class Form1
    Dim Palabra As String = " "
    Private Sub btnFuncion1_Click(sender As Object, e As EventArgs) Handles btnFuncion1.Click
        txtResultado.Text = Ejercicio1(txtPalabra.Text)
    End Sub

    Function Ejercicio1(palabra As String) As String
        Dim invierte As String = StrReverse(palabra)
        Return invierte
    End Function

    Private Sub txtCerrar_Click(sender As Object, e As EventArgs) Handles txtCerrar.Click
        End
    End Sub

    Private Sub btnFuncion2_Click(sender As Object, e As EventArgs) Handles btnFuncion2.Click

    End Sub
    Function Ejercicio2(palabra As String, letra As Char) As Integer
        Dim posicion As Integer = -1

        Return posicion
    End Function
End Class

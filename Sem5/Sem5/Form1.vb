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
        Dim vec() As String = Split(txtPalabra.Text, ",")
        txtResultado.Text = Ejercicio2(vec(0), vec(1))
    End Sub
    Function Ejercicio2(palabra As String, letra As String) As Integer
        Dim posicion As Integer = -1
        Dim index As Integer = 1
        Dim bandera As Boolean = False
        While index <= palabra.Length And bandera = False
            If letra = Mid(palabra, index, 1) Then
                posicion = index
                bandera = True
            End If
            index += 1
        End While

        Return posicion
    End Function
End Class

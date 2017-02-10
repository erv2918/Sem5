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
    Function Ejercicio5(palabra1 As String, palabra2 As String) As Integer
        Dim result = 0
        If palabra1.Length = palabra2.Length Then
            Dim index As Integer = 1
            While palabra1.Chars(index) = palabra2.Chars(index) And index < palabra1.Length - 1
                index += 1
            End While
            If index = palabra1.Length - 1 Then
                result = 1
            End If
        End If
        Return result
    End Function

    Private Sub btnFuncion5_Click(sender As Object, e As EventArgs) Handles btnFuncion5.Click
        Dim vec() As String = Split(txtPalabra.Text, ",")
        txtResultado.Text = Ejercicio5(vec(0), vec(1))
    End Sub
End Class

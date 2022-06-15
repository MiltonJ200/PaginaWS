Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim sh As New ServiceReference1.WebService1SoapClient()
        Label1.Text = "Bienvenido: " + sh.Hora

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sh As New ServiceReference1.WebService1SoapClient()

        Dim a As Integer = Val(TextBox1.Text)
        Dim b As Integer = Val(TextBox2.Text)

        Label2.Text = sh.Sumar(a, b)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sh As New ServiceReference1.WebService1SoapClient()

        Dim a As Integer = Val(TextBox1.Text)
        Dim b As Integer = Val(TextBox2.Text)

        Label2.Text = sh.Restar(a, b)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sh As New ServiceReference1.WebService1SoapClient()

        Dim a As Integer = Val(TextBox1.Text)
        Dim b As Integer = Val(TextBox2.Text)

        Label2.Text = sh.Multiplicar(a, b)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sh As New ServiceReference1.WebService1SoapClient()

        Dim a As Integer = Convert.ToDouble(TextBox1.Text)
        Dim b As Integer = Convert.ToDouble(TextBox2.Text)

        If b = 0 Then
            Label2.Text = "No puedes dividir entre 0, pruebe con otro valor."
        Else
            Label2.Text = sh.Dividir(a, b)
        End If
    End Sub
End Class
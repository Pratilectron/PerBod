Public Class Form1

    Private Sub form1_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = False

        Nom1.Text = ""
        Nom1.Focus()
        Age1.Text = ""
        Sexe1.Text = ""
        Taille1.Text = ""
        Poids1.Text = ""

    End Sub
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        Dim a = Nom1.Text
        Dim b = Age1.Text
        Dim c = Sexe1.Text
        Dim d = Taille1.Text
        Dim f = Poids1.Text

        If a = "" Or b = "" Or c = "" Or d = "" Or f = "" Then
            MsgBox("Respectez tous les cases")
        Else
            FlatButton1.Visible = False
            bar1.Visible = True
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        bar1.Value += 1

        If bar1.Value = 100 Then
            FlatButton1.Visible = True
            bar1.Visible = False
            Timer1.Enabled = False
            Form2.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        help.Show()
    End Sub

    Private Sub Nom1_keypress(sender As Object, ByVal e As EventArgs) Handles Nom1.TextChanged


        If System.Text.RegularExpressions.Regex.IsMatch(Nom1.Text, "[  ^ 0-9]") Then
            Nom1.Clear()
        End If

    End Sub


    Private Sub Age1_keypress(sender As Object, ByVal e As KeyPressEventArgs) Handles Age1.KeyPress, Taille1.KeyPress, Poids1.KeyPress

        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> ChrW(46)))) Then
            e.Handled = True
        End If

    End Sub
End Class

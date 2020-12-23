Public Class Form2

    '-------------------------------------------------------------------------------------
    Dim tt, tts, imc, img, mbH, mbF, FCMAstrand, FCMGellish, FCMGellish2, DEJ, pr, li, gl As Double

    Public Nom = Form1.Nom1.Text
    Public age = Form1.Age1.Text
    Public sexe = Form1.Sexe1.Text
    Public taille = Form1.Taille1.Text
    Public poids = Form1.Poids1.Text
    Public nap = Form1.track1.Value

    Public Sub imcFunction()

        tt = taille / 100
        tts = tt * tt
        imc = Conversion.Int(poids / tts)
        B1.Text = imc & "%"

        If imc > 40 Then B2.Text = "Obésité morbide ou massive"
        If imc <= 40 Then B2.Text = "Obésité sévère"
        If imc <= 35 Then B2.Text = "Obésité modérée"
        If imc <= 30 Then B2.Text = "Surpoids"
        If imc <= 25 Then B2.Text = "Corpulence normale"
        If imc <= 18.5 Then B2.Text = "Maigreur"
        If imc < 16.5 Then B2.Text = "Famine"

    End Sub

    Public Sub imgFunction()

        If (sexe = "Homme") Then

            img = (1.2 * imc) + (0.23 * age) - (10.83 * 1) - 5.4
            B3.Text = Conversion.Int(img) & "%"
            If img < 15 Then B4.Text = "Trop maigre"
            If img >= 15 Then B4.Text = "Normale"
            If img > 20 Then B4.Text = "Ayant trop de graisse"

        ElseIf (sexe = "Femme") Then

            img = (1.2 * imc) + (0.23 * age) - (10.83 * 0) - 5.4
            B3.Text = Conversion.Int(img) & "%"
            If img < 25 Then B4.Text = "Trop maigre"
            If img >= 25 Then B4.Text = "Normale"
            If img > 30 Then B4.Text = "Ayant trop de graisse"

        End If

    End Sub

    Public Sub piFunction()

        If (sexe = "Homme") Then
            B5.Text = Conversion.Int(taille - 100 - ((taille - 150) / 4)) & " Kg"

        ElseIf (sexe = "Femme") Then
            B5.Text = Conversion.Int(taille - 100 - ((taille - 150) / 2.5)) & " Kg"
        End If

    End Sub

    Public Sub mbFunction()

        tt = taille / 100
        tts = tt * tt

        If (sexe = "Homme") Then
            mbH = (9.74 * poids) + (172.9 * tt) - (4.737 * age) + 667.051
            B6.Text = Conversion.Int(mbH)

        ElseIf (sexe = "Femme") Then
            mbF = (13.707 * poids) + (492.3 * tt) - (6.673 * age) + 77.607
            B6.Text = Conversion.Int(mbF)
        End If

    End Sub

    Public Sub fcFunction()

        Dim k As Double = age * age

        If (sexe = "Homme") Then
            FCMAstrand = 220 - age
            B7.Text = Conversion.Int(FCMAstrand)

        ElseIf (sexe = "Femme") Then
            FCMAstrand = 226 - age
            B7.Text = Conversion.Int(FCMAstrand)

        End If


        FCMGellish = 206.9 - (0.67 * age)
        FCMGellish2 = 191.5 - (0.007 * k)

        If age >= 35 Or age <= 75 Then B8.Text = Conversion.Int(FCMGellish2)

        If age > 75 Then B8.Text = Conversion.Int(FCMGellish)

        If age < 30 Then B8.Text = Conversion.Int(FCMGellish)

    End Sub

    Public Sub dejFunction()

        tt = taille / 100

        mbH = (9.74 * poids) + (172.9 * tt) - (4.737 * age) + 667.051
        mbF = (13.707 * poids) + (492.3 * tt) - (6.673 * age) + 77.607

        If (sexe = "Homme") Then

            If nap = 0 Then
                DEJ = mbH * 1.375
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)

            ElseIf nap = 1 Then
                DEJ = mbH * 1.56
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)


            ElseIf nap = 2 Then
                DEJ = mbH * 1.64
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)

            ElseIf nap = 3 Then
                DEJ = mbH * 1.82
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)

            End If

        End If

        If (sexe = "Femme") Then

            If nap = 0 Then
                DEJ = mbF * 1.375
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)

            ElseIf nap = 1 Then
                DEJ = mbF * 1.56
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)

            ElseIf nap = 2 Then
                DEJ = mbF * 1.64
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)

            ElseIf nap = 3 Then
                DEJ = mbF * 1.82
                pr = poids * 2.4
                li = (DEJ * 0.2) / 9
                gl = (DEJ - ((pr * 4) + (li * 9))) / 4

                B12.Text = Conversion.Int(DEJ)
                B9.Text = Conversion.Int(pr)
                B10.Text = Conversion.Int(li)
                B11.Text = Conversion.Int(gl)
            End If

        End If

    End Sub
    '-------------------------------------------------------------------------------------

    Private Sub form2_load(sender As Object, e As EventArgs) Handles MyBase.Load

        NomL.Text = "Nom : " + Nom
        AgeL.Text = "Âge : " + age + " ans"
        SexeL.Text = "Sexe : " + sexe
        TailleL.Text = "Taille : " + taille + " cm"
        PoidsL.Text = "Poids : " + poids + " Kg"

        napL.TextAlign = ContentAlignment.MiddleCenter

        If nap = 0 Then
            napL.Text = "NAP : Sédentaire"
        ElseIf nap = 1 Then
            napL.Text = "NAP : Légère"
        ElseIf nap = 2 Then
            napL.Text = "NAP : Modérée"
        ElseIf nap = 3 Then
            napL.Text = "NAP : Intense"
        End If

        imcFunction()
        imgFunction()
        piFunction()
        mbFunction()
        fcFunction()
        dejFunction()

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub FlatButton1_hover(sender As Object, e As EventArgs) Handles FlatButton1.MouseEnter
        FlatButton1.BaseColor = Color.FromArgb(168, 35, 35)
        FlatButton1.TextColor = Color.FromArgb(243, 243, 243)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        bar.Value += 1
        Dim ba = bar.Value

#Region "Guser"
        If ba = 5 Then
            Guser.Visible = True
        ElseIf ba = 7 Then
            P1.Visible = True
        ElseIf ba = 9 Then
            NomL.Visible = True
        ElseIf ba = 10 Then
            AgeL.Visible = True
        ElseIf ba = 11 Then
            SexeL.Visible = True
        ElseIf ba = 13 Then
            TailleL.Visible = True
        ElseIf ba = 14 Then
            PoidsL.Visible = True
        ElseIf ba = 15 Then
            napL.Visible = True
        End If
#End Region

#Region "Gimc"
        If ba = 20 Then
            Gimc.Visible = True
        ElseIf ba = 24 Then
            Label1.Visible = True
        ElseIf ba = 27 Then
            B1.Visible = True
        ElseIf ba = 30 Then
            B2.Visible = True
        End If
#End Region

#Region "Gimg"
        If ba = 34 Then
            Gimg.Visible = True
        ElseIf ba = 37 Then
            Label2.Visible = True
        ElseIf ba = 40 Then
            B3.Visible = True
        ElseIf ba = 43 Then
            B4.Visible = True
        End If
#End Region

#Region "Gpi"
        If ba = 46 Then
            Gpi.Visible = True
        ElseIf ba = 48 Then
            Label3.Visible = True
        ElseIf ba = 51 Then
            B5.Visible = True
        End If
#End Region

#Region "Gmb"
        If ba = 55 Then
            Gmb.Visible = True
        ElseIf ba = 58 Then
            Label4.Visible = True
        ElseIf ba = 61 Then
            B6.Visible = True
        End If
#End Region

#Region "Gfc"
        If ba = 65 Then
            Gfc.Visible = True
        ElseIf ba = 68 Then
            Label5.Visible = True
        ElseIf ba = 71 Then
            label51.Visible = True
        ElseIf ba = 73 Then
            B7.Visible = True
        ElseIf ba = 76 Then
            Label52.Visible = True
        ElseIf ba = 79 Then
            B8.Visible = True
        End If
#End Region

#Region "Gdej"
        If ba = 82 Then
            Gdej.Visible = True
        ElseIf ba = 84 Then
            Label6.Visible = True
        ElseIf ba = 86 Then
            B12.Visible = True
        End If
#End Region

#Region "Gaj"
        If ba = 89 Then
            Gaj.Visible = True
        ElseIf ba = 91 Then
            Label7.Visible = True
        ElseIf ba = 92 Then
            label71.Visible = True
        ElseIf ba = 93 Then
            B9.Visible = True
            label74.Visible = True
        ElseIf ba = 94 Then
            Label72.Visible = True
        ElseIf ba = 95 Then
            B10.Visible = True
            label75.Visible = True
        ElseIf ba = 96 Then
            Label73.Visible = True
        ElseIf ba = 98 Then
            B11.Visible = True
            label76.Visible = True
        End If
#End Region

        If ba = 100 Then
            bar.Visible = False
        End If

    End Sub
End Class
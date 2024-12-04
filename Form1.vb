Imports System.Runtime.Intrinsics.X86

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAfiiche_Click(sender As Object, e As EventArgs) Handles btnAfiiche.Click



    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim l As livre
        l.ISBN = txtSBN.Text
        l.Titre = txtTitre.Text
        l.auteur = txtAuteur.Text
        If ajouterlivre(l) Then
            MessageBox.Show("ajout du livre avec ssucces ")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé ")
        End If

    End Sub

    Private Sub txtSBN_TextChanged(sender As Object, e As EventArgs) Handles txtSBN.TextChanged

    End Sub

    Private Sub txtTitre_TextChanged(sender As Object, e As EventArgs) Handles txtTitre.TextChanged

    End Sub
End Class

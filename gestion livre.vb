Module gestion_livre
    Public Structure livre
        Dim ISBN As Integer
        Dim Titre As String
        Dim auteur As String
    End Structure
    Public bibliotheque(100) As livre
    Dim nb As Integer = 0
    Function ajouterlivre(l As livre) As Boolean
        If nb < bibliotheque.Length Then
            bibliotheque(nb) = l
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub afficher_livre(l1 As ListBox,)

End Module

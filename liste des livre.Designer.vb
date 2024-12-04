<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liste_des_livre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lstauteur = New TextBox()
        lsttitre = New TextBox()
        lstisbn = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(55, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 22)
        Label1.TabIndex = 6
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(270, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 22)
        Label2.TabIndex = 7
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(458, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 22)
        Label3.TabIndex = 8
        Label3.Text = "auteur"
        ' 
        ' lstauteur
        ' 
        lstauteur.Location = New Point(419, 90)
        lstauteur.Multiline = True
        lstauteur.Name = "lstauteur"
        lstauteur.Size = New Size(125, 272)
        lstauteur.TabIndex = 9
        ' 
        ' lsttitre
        ' 
        lsttitre.Location = New Point(224, 90)
        lsttitre.Multiline = True
        lsttitre.Name = "lsttitre"
        lsttitre.Size = New Size(125, 272)
        lsttitre.TabIndex = 10
        ' 
        ' lstisbn
        ' 
        lstisbn.Location = New Point(28, 90)
        lstisbn.Multiline = True
        lstisbn.Name = "lstisbn"
        lstisbn.Size = New Size(107, 272)
        lstisbn.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(597, 212)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 35)
        Button1.TabIndex = 12
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' liste_des_livre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(708, 450)
        Controls.Add(Button1)
        Controls.Add(lstisbn)
        Controls.Add(lsttitre)
        Controls.Add(lstauteur)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "liste_des_livre"
        Text = "liste_des_livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstauteur As TextBox
    Friend WithEvents lsttitre As TextBox
    Friend WithEvents lstisbn As TextBox
    Friend WithEvents Button1 As Button
End Class

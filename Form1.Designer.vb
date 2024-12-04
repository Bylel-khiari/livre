<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAfiiche = New Button()
        btnAjouter = New Button()
        txtSBN = New TextBox()
        txtTitre = New TextBox()
        txtAuteur = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnAfiiche
        ' 
        btnAfiiche.Location = New Point(391, 191)
        btnAfiiche.Name = "btnAfiiche"
        btnAfiiche.Size = New Size(143, 53)
        btnAfiiche.TabIndex = 0
        btnAfiiche.Text = "Afficher"
        btnAfiiche.UseVisualStyleBackColor = True
        ' 
        ' btnAjouter
        ' 
        btnAjouter.Location = New Point(391, 42)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(143, 53)
        btnAjouter.TabIndex = 1
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = True
        ' 
        ' txtSBN
        ' 
        txtSBN.Location = New Point(109, 55)
        txtSBN.Name = "txtSBN"
        txtSBN.Size = New Size(205, 27)
        txtSBN.TabIndex = 2
        ' 
        ' txtTitre
        ' 
        txtTitre.Location = New Point(109, 130)
        txtTitre.Name = "txtTitre"
        txtTitre.Size = New Size(205, 27)
        txtTitre.TabIndex = 3
        ' 
        ' txtAuteur
        ' 
        txtAuteur.Location = New Point(109, 207)
        txtAuteur.Name = "txtAuteur"
        txtAuteur.Size = New Size(205, 27)
        txtAuteur.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(44, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 22)
        Label1.TabIndex = 5
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(44, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 22)
        Label2.TabIndex = 6
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(32, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 22)
        Label3.TabIndex = 7
        Label3.Text = "auteur"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(546, 266)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAuteur)
        Controls.Add(txtTitre)
        Controls.Add(txtSBN)
        Controls.Add(btnAjouter)
        Controls.Add(btnAfiiche)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAfiiche As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents txtSBN As TextBox
    Friend WithEvents txtTitre As TextBox
    Friend WithEvents txtAuteur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class

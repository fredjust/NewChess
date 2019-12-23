Imports System.Math     'pour la fonction min

Public Class BoardStates

    'LES DONNEES BRUTES UNIQUEMENT
    'COLLECTION DES DIFFERENTS ETATS DU PLATEAU SOUS FORME DE SIGNATURE,temps,caseOFF,caseON,Nombre de pièce

    Private FromNameFile As String = ""
    Private tailledufichier As Long = 0

    Public Enum StateColor As Byte
        Normal = 0
        twoModif = 1
        DoubleOnOff = 2
        NullTime = 3
        CoupPossible = 4
        CoupRetenu = 5
        CoupRejete = 6
        CoupProche = 7
        Start = 195

    End Enum

    'Type pour les données brutes
    Public Class aState
        Public Signature As String      'signature de la forme 195.195.195.195.195.195.195.195
        Public Temps As UInteger        'temps de stabilité de la position MAX
        Public SquareOn As String       'case qui s'est allumé depuis la dernière position
        Public SquareOff As String      'case qui s'est étent depuis la derniere position
        Public NbPieces As Byte         'nombre de pièce sur l'échiquier au moment 
        Public aColor As StateColor     'pour savoir si l'état comporte plusieurs modification
        Public FEN As String            'la FEN de la position
        Public moveUCI As String        'deplacement sous la forme g1f3 ayant permit d'arriver dans cette position
        Public Diff As String           'Case en erreur
    End Class

    'collection des etats du plateau
    Public col_States As New Collection



#Region "PRIVATE SUB"

    ' renvoie le nombre de pièce sur une colonne
    Private Function Nb_Piece_Sur_Colonne(ByVal Numero_Colonne As Byte) As Byte
        Dim a As Byte = 0 'compteur temporaire du nombre de piece
        Dim x As Byte
        Dim z As Byte

        z = Numero_Colonne
        Do
            x = Int(z / 2)
            If z = 2 * x + 1 Then a = a + 1
            z = x
        Loop While z > 0
        Nb_Piece_Sur_Colonne = a

    End Function

    ' renvoie le nombre de pièce sur l'échiquier
    Private Function Nb_Piece_Sur_Plateau(ByVal rec As String) As Byte
        Dim colonnes() As String
        Dim tempo As Byte = 0 'compteur du nombre de pièce

        colonnes = rec.Split(".")
        For i = 0 To 7
            tempo = tempo + Nb_Piece_Sur_Colonne(colonnes(i))
        Next
        Return tempo
    End Function

    'cherche les cases qui s'allument et s'éteingnent entre deux enregistrements
    'place la case sous forme de texte dans SquareOn et Off exemple :  e2
    Private Sub FindOnOff(ByVal Signature_Actuelle As String, _
                          ByVal Signature_Precedente As String, _
                          ByRef Cases_qui_Sallument As String, ByRef Cases_qui_Seteingnent As String)

        Dim iLigne As Integer 'compte de boucle sur la ligne
        Dim icolonne As Byte 'compteur de boucle sur la colonne
        Dim new_pos(9) As String
        Dim last_pos(9) As String
        Dim last_byte As Byte
        Dim new_byte As Byte

        Cases_qui_Seteingnent = ""
        Cases_qui_Sallument = ""

        last_pos = Split(Signature_Actuelle, ".") 'recupère les 8 bytes de la positions précedente
        new_pos = Split(Signature_Precedente, ".") 'récupère les 8 bytes de la position 

        For icolonne = 1 To 8
            new_byte = new_pos(icolonne - 1) 'bytes des colonnes
            last_byte = last_pos(icolonne - 1)
            If (new_byte <> last_byte) Then 'si les deux colonnes sont différentes
                For iLigne = 7 To 0 Step -1
                    If (new_byte And (2 ^ iLigne)) <> (last_byte And (2 ^ iLigne)) Then   'si la case est diffétente
                        If (new_byte And (2 ^ iLigne)) Then  's'il s'agit d'une extinction
                            Cases_qui_Seteingnent &= Chr(96 + icolonne) & (iLigne + 1).ToString & " "
                        Else
                            Cases_qui_Sallument &= Chr(96 + icolonne) & (iLigne + 1).ToString & " "
                        End If
                    End If
                Next
            End If
        Next

        Cases_qui_Seteingnent = Trim(Cases_qui_Seteingnent)
        Cases_qui_Sallument = Trim(Cases_qui_Sallument)

    End Sub

    'ALLUME UNE CASE
    'nom de la case  de la forme e2
    'sur une signature 
    Private Function Allume_Case(ByVal Nom_Case As String, ByVal Une_Signature As String) As String
        Dim Index_de_la_Case As Byte
        Dim colonne As Byte
        Dim ligne As Byte
        Dim LesColonnes As String()

        If Len(Nom_Case) <> 2 Then Return Une_Signature

        Index_de_la_Case = Index_Case(Nom_Case) 'index de la case

        colonne = Index_de_la_Case Mod 10
        ligne = Index_de_la_Case \ 10

        LesColonnes = Une_Signature.Split(".")

        LesColonnes(colonne - 1) = LesColonnes(colonne - 1) + Math.Pow(2, (ligne) - 1)

        Return (Join(LesColonnes, "."))

    End Function

    'ETEINT UNE CASE
    'nom de la case de la forme e2
    'sur une signature 
    Private Function Eteint_Case(ByVal Nom_Case As String, ByVal Une_Signature As String) As String
        Dim sqIndex As Byte
        Dim colonne As Byte
        Dim ligne As Byte
        Dim LesColonnes As String()

        If Len(Nom_Case) <> 2 Then Return Une_Signature

        sqIndex = Index_Case(Nom_Case) 'index de la case

        colonne = sqIndex Mod 10
        ligne = sqIndex \ 10

        LesColonnes = Une_Signature.Split(".")

        LesColonnes(colonne - 1) = LesColonnes(colonne - 1) - Math.Pow(2, (ligne) - 1)

        Return (Join(LesColonnes, "."))



    End Function

    'ajoute un ETAT
    Private Sub Ajoute_Etat(ByVal Signature As String, _
        ByVal Temps As Long, _
        ByVal sqOff As String, _
        ByVal sqOn As String, _
        Optional ByVal modif As Byte = StateColor.Normal)

        Dim NewState As New aState 'le nouvelle etat que l'on va ajouter

        With NewState
            .Signature = Signature
            .SquareOff = sqOff
            .SquareOn = sqOn
            .Temps = Temps
            .NbPieces = Nb_Piece_Sur_Plateau(Signature)
            .aColor = modif
        End With

        'ajoute le nouvel etat à la collection
        col_States.Add(NewState)

    End Sub

#End Region



#Region "PUBLIC SUB"

    'renvoie l'INDEX d'une case a partir de son nom 
    'SquareIndex(xy)=10*y+x
    ' exemple :
    '   SquareIndex(a1)=11
    '   SquareIndex(h8)=88
    'ou 0 en cas d'erreur
    Public Function Index_Case(ByVal Nom_case As String) As Byte
        Dim lettre As Char
        Dim colonne As Byte
        Dim ligne As Byte

        If Nom_case.Length <> 2 Then Return 0

        lettre = Nom_case.Substring(0, 1) 'recupere la lettre
        colonne = Asc(lettre) - 96 'recupere le numero de colonne

        If colonne < 1 Or colonne > 8 Then Return 0

        ligne = Nom_case.Substring(1, 1) 'recupere le numero de ligne

        If ligne < 1 Or ligne > 8 Then Return 0

        Return ligne * 10 + colonne

    End Function

    'ajoute un etat dans la collection a partir d'une signature
    'regarde les différences avec l'état précédent pour calculer les cases qui s'allument et s'éteingnent
    'compte le nombre de pièce sur l'échiquier
    'en cas de double différence ajoute 3 états au lieu d'un <= TODO a regarder ??
    Public Function Ajoute_Signature(ByVal signature As String, ByVal temps As Long) As Boolean

        Dim NewState As New aState 'le nouvelle etat que l'on va ajouter
        Dim LastState As New aState 'l'état précédent pour chercher les différences
        Dim SquareOn As String = ""
        Dim SquareOff As String = ""
        Dim modif As StateColor

        If temps = 0 Then modif = StateColor.NullTime Else modif = StateColor.Normal

        If signature.Split(".").Count <> 9 Then
            Return False
        End If

        'TODO A NE PAS FAIRE ICI
        signature = signature.Substring(0, signature.Length - 2)
        If signature = "195.195.195.195.195.195.195.195" Then
            'efface toutes les anciennes positions
            col_States.Clear()

            Debug.Print("CLEAR POSITION")
        End If

        If col_States.Count = 0 Then 'si c'est le premier enregistrement

            Ajoute_Etat(signature, temps, "", "")

        Else        'cherche les différenes avec l'état précédent

            'récupère l'enregistrement précédent
            LastState = col_States.Item(col_States.Count)

            'cherche les différences
            FindOnOff(signature, LastState.Signature, SquareOn, SquareOff)


            If SquareOff <> "" And SquareOn <> "" Then 'si plusieurs cases changent sur un seul enregistrement 

                Ajoute_Etat(Eteint_Case(SquareOff, LastState.Signature), temps, SquareOff, "", StateColor.twoModif)
                Ajoute_Etat(Allume_Case(SquareOn, LastState.Signature), temps, "", SquareOn, StateColor.twoModif)
                Ajoute_Etat(Allume_Case(SquareOn, Eteint_Case(SquareOff, LastState.Signature)), temps, SquareOff, SquareOn, StateColor.twoModif)

            Else    'une seule modification

                If Len(SquareOff) > 2 Or Len(SquareOn) > 2 Then
                    Ajoute_Etat(signature, temps, SquareOff, SquareOn, StateColor.DoubleOnOff)
                Else
                    Ajoute_Etat(signature, temps, SquareOff, SquareOn, modif)
                End If

            End If

        End If
        Return True
    End Function

    'Permet de changer l'orientation de base du plateau
    Private Function Modif_Orientation(ByVal UneSignature As String, _
                                     ByVal InvDG As Boolean, _
                                     ByVal InvHB As Boolean, _
                                     ByVal Rot90 As Boolean) As String
        ' UneSignature contient 195.195.195. ...
        Dim theCol As String() 'contient "195" "195" "195"
        Dim theByte(8) As Byte 'contient 195 195 195
        Dim thebits(8, 8) As Byte
        Dim thebits_2(8, 8) As Byte
        Dim NewSignature As String = "" 'contient la nouvelle signature
        Dim tempoByte As Byte


        'If UneSignature.EndsWith(".") Then
        '    UneSignature = UneSignature.Substring(0, UneSignature.Length - 2) 'enlève le . de la fin 
        'End If

        theCol = UneSignature.Split(".") 'sépare les différents string 

        'décompose les bytes en tableau de bit
        For i = 0 To 7
            theByte(i) = theCol(i) 'converti "195" en 195
            For j = 0 To 7
                thebits(i, j) = IIf(theByte(i) And (2 ^ j), 1, 0)
                thebits_2(i, j) = thebits(i, j)
            Next
        Next

        'les lignes deviennent des colonnes
        If Rot90 Then
            For i = 0 To 7
                For j = 0 To 7
                    thebits_2(i, j) = thebits(j, i)
                Next
            Next
        End If

        'on inverse les colonnes
        If InvDG And Not InvHB Then
            For i = 0 To 7
                tempoByte = 0
                For j = 0 To 7
                    tempoByte += (2 ^ j) * thebits_2(7 - i, j)
                Next
                NewSignature = NewSignature & tempoByte & "."
            Next
            NewSignature = NewSignature.Substring(0, NewSignature.Length - 1)
            Return NewSignature
        End If

        'on inverse les lignes
        If InvHB And Not InvDG Then
            For i = 0 To 7
                tempoByte = 0
                For j = 0 To 7
                    tempoByte += (2 ^ j) * thebits_2(i, 7 - j)
                Next
                NewSignature = NewSignature & tempoByte & "."
            Next
            NewSignature = NewSignature.Substring(0, NewSignature.Length - 1)
            Return NewSignature
        End If

        'on inverse les lignes et les colonnes
        If InvHB And InvDG Then
            For i = 0 To 7
                tempoByte = 0
                For j = 0 To 7
                    tempoByte += (2 ^ j) * thebits_2(7 - i, 7 - j)
                Next
                NewSignature = NewSignature & tempoByte & "."
            Next
            NewSignature = NewSignature.Substring(0, NewSignature.Length - 1)
            Return NewSignature
        End If


        'si on a rien retourné on construit la nouvelle signature
        For i = 0 To 7
            tempoByte = 0
            For j = 0 To 7
                tempoByte += (2 ^ j) * thebits_2(i, j)
            Next
            NewSignature = NewSignature & tempoByte & "."
        Next
        NewSignature = NewSignature.Substring(0, NewSignature.Length - 1)
        Return NewSignature

    End Function

    'rempli la collection a partir d'un fichier
    'return 0 si pas d'erreur
    Public Function LoadFromFile(ByVal NameFile As String, _
                                 ByVal InvDG As Boolean, _
                                 ByVal InvHB As Boolean, _
                                 ByVal Rot90 As Boolean) As Boolean
        'Optional ByVal InvDG As Boolean = False, _
        'Optional ByVal InvHB As Boolean = False, _
        'Optional ByVal Rot90 As Boolean = False) As Boolean
        Dim RecTempo() As String                'tableau de toute les lignes
        Dim RecordsInFile As String = ""        'texte complet du fichier
        Dim iLigne As UInteger = 0              'compteur de ligne
        Dim LaSignature As String = ""          'signature de la position
        Dim LeTemps As ULong = 0                'temps de la position



        'efface toutes les anciennes positions
        col_States.Clear()

        If NameFile = "" Then Return False

        If Not My.Computer.FileSystem.FileExists(NameFile) Then Return False

        Try
            RecordsInFile = My.Computer.FileSystem.ReadAllText(NameFile)
        Catch ex As Exception
            Return False
        End Try

        'supprime les répétitions de retour chariot
        RecordsInFile.Replace(Chr(10) + Chr(13) + Chr(10) + Chr(13), Chr(10) + Chr(13))

        RecTempo = RecordsInFile.Split(Chr(10) + Chr(13)) 'sépare les différentes lignes

        While iLigne < RecTempo.Length - 2

            's'il n'y a aucune modif je l'appelle quand meme pour supprimer facilement les . en bout de ligne
            'car cela supprime aussi les .CRLF de trop
            '15 ms au lieu de 0 avec simplement .Substring(0, .Length - 2)
            LaSignature = Modif_Orientation(RecTempo(iLigne), InvDG, InvHB, Rot90)

            Try
                LeTemps = CInt(RecTempo(iLigne + 1).Replace(".0", ""))
            Catch ex As Exception
                LeTemps = 0
            End Try

            Ajoute_Signature(LaSignature, LeTemps)
            iLigne = iLigne + 2
        End While

        Return True
    End Function


    'Cherche et renvoie le numéro de ligne correspondant a l'état initial
    'parmis les 30 premiers enregistrement
    'TODO plus rapide en remontant et en s'arretant dès le premier trouvé
    Public Function idStateOne() As Byte
        Dim iLigne As Byte = 1
        Dim Depart As Byte = 0

        If col_States.Count <> 0 Then

            For iLigne = 1 To Min(30, col_States.Count - 1)
                If col_States.Item(iLigne).signature = "195.195.195.195.195.195.195.195" Then
                    col_States.Item(iLigne).acolor = StateColor.Start
                    col_States.Item(iLigne).temps = 0
                    Depart = iLigne
                End If
            Next
        End If
        Return Depart
    End Function

    'Regarde si une case c'est allumé sur une période
    Public Function switched_ON(ByVal aSquare As String, ByVal id_from As Integer, ByVal id_to As Integer) As Boolean

        For idState = id_from To Min(id_to, col_States.Count)
            If InStr(col_States(idState).SquareOn, aSquare) <> 0 Then Return True
        Next

        Return False

    End Function

    'Regarde si une case c'est éteint sur une période
    Public Function switched_OFF(ByVal aSquare As String, ByVal id_from As Integer, ByVal id_to As Integer) As Boolean

        For idState = id_from To Min(id_to, col_States.Count)
            If InStr(col_States(idState).SquareOff, aSquare) <> 0 Then Return True
        Next

        Return False

    End Function

    'Regarde si une case c'est éteint ou allumé sur une période
    Public Function switched(ByVal aSquare As String, ByVal id_from As Integer, ByVal id_to As Integer) As Boolean

        For idState = id_from To id_to
            If InStr(col_States(idState).SquareOn, aSquare) <> 0 _
                Or InStr(col_States(idState).SquareOff, aSquare) <> 0 Then Return True
        Next

        Return False

    End Function

#End Region

End Class

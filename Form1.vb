Imports System.Math
Imports System
Imports System.Threading
'Imports System.IO.Ports
Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class Form1

    'Type pour les données brutes
    Dim ETATS As New BoardStates

    'type de donnée pour stocker une position
    Dim POSITIONS As New GamePositions

    'objet pour vérifier les coups
    Public PARTIE As New ObjFenMoves

    'option pour modifier la recherche des coups
    Public Structure Option_Recherche
        Public Nb_signatures_comparees As Byte          'recherche parmis les x suivantes
        Public Distance_max_pour_coup_proche As Byte    'nombre de case maximum d'écart 
        Public Num_derniere_Ligne As UInteger           'pour limiter la recherche pour simuler le live
        Public Zap_Verif_case_depart As Boolean         'ne pas vérifier que la case de départ s'est eteinte
        Public Zap_Verif_case_arrivee As Boolean        'ne pas vérifier que la case d'arrivé s'est allumée
        Public Couleur_Position As Byte                 'couleur pour afficher les noeuds suivants cf PositionColor ENUM
        Public Re_calculer As Boolean                   'recalcul les fils de chaque noeud
        Public Voir_Orphelin As Boolean                 'affiche les orphelins dans la treeview
    End Structure

    'stock les options
    Dim LesOptions As Option_Recherche

    'pour choisir facilement une couleur pour Option_Recherche.Couleur_Position
    Public Enum PositionColor As Byte
        noir = 0
        rouge = 1
        vert = 2
        bleu = 3
    End Enum

    Public Const PasEncoreRechercher As SByte = -1
    Public intTimeStart As Integer = 0
    Public c_pgn_live_pgn As String = "c:\pgn\live.pgn"
   


    'tableau contenant les couleurs
    Dim LesCouleurs(5) As System.Drawing.Color



#Region "GESTION LIST VIEW ETAT"

    'TRANSFERT DES DONNEES MEMOIRES EN ITEM VB DANS LA LISTVIEW

    'ajoute un ETAT dans la list view
    Public Sub Add_ItemToListView(ByVal UnEtat As BoardStates.aState)
        Dim NbLigne As Integer

        NbLigne = lvRec.Items.Count + 1
        lvRec.Items.Insert(NbLigne - 1, NbLigne)    'numéro de l'état

        NbLigne = lvRec.Items.Count - 1
        lvRec.Items(NbLigne).SubItems.Add(UnEtat.Signature)
        lvRec.Items(NbLigne).SubItems.Add(UnEtat.Temps)
        lvRec.Items(NbLigne).SubItems.Add(UnEtat.SquareOff)
        lvRec.Items(NbLigne).SubItems.Add(UnEtat.SquareOn)
        lvRec.Items(NbLigne).SubItems.Add(UnEtat.NbPieces)

        Select Case UnEtat.aColor
            Case BoardStates.StateColor.twoModif
                lvRec.Items(NbLigne).ForeColor = Color.Cyan

            Case BoardStates.StateColor.DoubleOnOff
                lvRec.Items(NbLigne).ForeColor = Color.Yellow

            Case BoardStates.StateColor.Start
                lvRec.Items(NbLigne).ForeColor = Color.Blue

            Case BoardStates.StateColor.NullTime
                lvRec.Items(NbLigne).ForeColor = Color.BlueViolet

            Case BoardStates.StateColor.Start
                lvRec.Items(NbLigne).ForeColor = Color.Green

        End Select


    End Sub

    'remplis la listview avec tous les ETATS 
    'efface la liste juste avant
    Public Sub Refresh_ListView()
        Dim iEtat As UInteger

        lvRec.Items.Clear()

        For iEtat = 1 To ETATS.col_States.Count
            Add_ItemToListView(ETATS.col_States.Item(iEtat))
        Next

    End Sub

   

    'affiche les cercles rouges et vert lorsqu'on défile les positions
    Private Sub lvRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvRec.KeyUp
        DrawSymbol()
    End Sub

#End Region

#Region "GESTION LIST VIEW MOVE"

    'ajoute une position dans la lvMove
    'on doit ajouter les positions dans l'ordre
    'TODO reprendre le code dans mon ancien programme
    Public Sub Add_Pos_lvMoves(ByVal idPos As Integer)
        'si c'est un coup blancs on ajoute une ligne
        'si c'est un coup noirs on le rajoute à la derniere ligne

    End Sub

#End Region


#Region "GESTION TREE VIEW POSITION"

    'procedure recursive qui s'auto appelle
    'trouve le noeud ayant pour clé "thekey" dans l'ensemble de tous les noeuds et le renvoie dans "FindNode"
    Public Sub Find_Node_By_Key(ByVal myNodes As TreeNodeCollection, ByVal thekey As String, _
                                ByRef FindNode As TreeNode, ByRef isFind As Boolean)
        Dim Child As TreeNode

        If myNodes.ContainsKey(thekey) Then
            FindNode = myNodes(thekey)
            isFind = True
        Else
            If isFind = False Then
                For Each Child In myNodes
                    Find_Node_By_Key(Child.Nodes, thekey, FindNode, isFind)
                Next
            End If
        End If

    End Sub

    'ajoute un noeud dans la treeview sous le noeud ayant pour clé "keyParent"
    Public Sub Add_child_Node(ByRef tvw As TreeView, ByVal keyParent As String, _
                       ByVal key As String, ByVal text As String, _
                       Optional ByVal ColorPos As Byte = 0)
        Dim aNode As New TreeNode
        Dim NewNode As New TreeNode
        Dim isFind As Boolean

        isFind = False

        Find_Node_By_Key(tvw.Nodes, keyParent, aNode, isFind)

        NewNode = aNode.Nodes.Add(key, text)
        NewNode.Tag = key
        NewNode.ForeColor = LesCouleurs(ColorPos)

    End Sub


    'ajoute une position dans la treeview
    Public Sub Add_Pos_Tv(ByVal laPosition As GamePositions.aPosition)
        Dim aText As String = ""
        Dim nbCoup As String

        nbCoup = (laPosition.NumCoup - 1) \ 2 + 1

        Select Case laPosition.NumCoup Mod 2
            Case 0
                aText = " " & laPosition.moveSAN & "'"
            Case 1
                aText = nbCoup & ". " & laPosition.moveSAN & ","
        End Select

        Add_child_Node(tvPos, laPosition.idParent & "k", laPosition.id & "k", aText, laPosition.Couleur)


    End Sub

    'remplit la TreeView avec les positions
    'efface tous les noeuds auparavant
    Public Sub Refresh_TreeView()
        Dim iPos As Integer
        Dim unePos As GamePositions.aPosition

        'efface tous les noeuds
        tvPos.Nodes.Clear()

        tvPos.Nodes.Add("1k", "Start")
        tvPos.Nodes(0).Tag = "1k"

        For iPos = 2 To POSITIONS.col_Position.Count - 1
            unePos = POSITIONS.col_Position.Item(iPos)

            If unePos.nbFils > 0 Or LesOptions.Voir_Orphelin Then 'n'affiche pas les orphelins de niveau 1       
                Add_Pos_Tv(unePos)
            End If

        Next

        'la dernière on l'affiche tous le temps
        'si elle existe
        If POSITIONS.col_Position.Count > 0 Then
            unePos = POSITIONS.col_Position.Item(POSITIONS.col_Position.Count)
            Add_Pos_Tv(unePos)
        End If

        tvPos.Nodes(0).ExpandAll()

    End Sub

#End Region


#Region "DIVERS"

    'initialise les variables options
    Public Sub Init_Option()

        With LesOptions
            .Distance_max_pour_coup_proche = 1
            .Nb_signatures_comparees = 20
            .Num_derniere_Ligne = 0
            .Zap_Verif_case_arrivee = False
            .Zap_Verif_case_depart = False
            .Couleur_Position = 0
            .Re_calculer = False
            .Voir_Orphelin = False
        End With

        mnuOpSuivant.Text = "Nb suivant (" & LesOptions.Nb_signatures_comparees.ToString & ")"

        LesCouleurs(0) = Color.Black
        LesCouleurs(1) = Color.Red
        LesCouleurs(2) = Color.Green
        LesCouleurs(3) = Color.Blue

    End Sub

    'Recupère les infos de la partie dans un fichier INI
    Private Sub LoadInfoPgn()

        With InfoGame
            .IniFile = "c:\pgn\Chessboard.ini" 'Application.StartupPath & "\Chessboard.ini"
            If .IniSection = "" Then .IniSection = "GameInfo"
            'If Cls_Ini.INISectionExist(.IniFile, .IniSection) Then
            .Black = Cls_Ini.INIRead(.IniFile, .IniSection, "Black", "BLACK Player")
            .White = Cls_Ini.INIRead(.IniFile, .IniSection, "White", "WHITE Player")
            .BlackElo = Cls_Ini.INIRead(.IniFile, .IniSection, "BlackElo", "1399")
            .WhiteElo = Cls_Ini.INIRead(.IniFile, .IniSection, "WhiteElo", "1399")
            .Date_str = Cls_Ini.INIRead(.IniFile, .IniSection, "Date", CStr(Now.Year.ToString & "/" & Now.Month.ToString & "/" & Now.Day.ToString))
            .Result = Cls_Ini.INIRead(.IniFile, .IniSection, "Result", "*")
            .Round = Cls_Ini.INIRead(.IniFile, .IniSection, "Round", "1")
            .Event_str = Cls_Ini.INIRead(.IniFile, .IniSection, "Event", "ARD Chess")
            .Site = Cls_Ini.INIRead(.IniFile, .IniSection, "Site", "Here")
            .LocalPIECE = "TCFDR"
            .TimeControl = "900"
            'End If
        End With

    End Sub

    'affecte une couleur pour l'affichage des noeuds suivants
    Public Sub Set_Color(ByVal LaCouleur As Byte)
        LesOptions.Couleur_Position = LaCouleur
    End Sub


    'ouvre une boite de dialogue et renvoie le nom d'un fichier
    Public Function NameFile() As String
        Dim nomfichier As String = ""

        On Error GoTo ErrorHandler

        With OpenFileDialog1
            'On spécifie l'extension de fichiers visibles
            .FileName = ""
            .Filter = "ARD Files (*.*) | *.*"
            'On affiche et teste le retour du dialogue
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                'On récupère le nom du fichier
                nomfichier = .FileName
            End If
        End With

        Return nomfichier

        Exit Function
ErrorHandler:

        MsgBox("Error in Function NameFile : " & vbCrLf & Err.Description)

    End Function

#End Region



#Region "FONCTION DE RECHERCHE"

    'Initialise le nombre de fils de chaque position à -1 pour forcer le recalcul
    Public Sub Efface_Nb_Fils_Trouve()
        For iPos = 1 To POSITIONS.col_Position.Count
            POSITIONS.col_Position.Item(iPos).nbFils = PasEncoreRechercher
        Next
    End Sub

    'Cherche l'etat initial 
    Public Sub Cherche_Premier()
        Dim iLigne As Byte = 1

        iLigne = ETATS.idStateOne
        POSITIONS.New_Game(iLigne)

    End Sub

    'recherche les fils de toutes les positions qui n'ont pas encore été calculé
    Public Sub Find_Child()

        'Dim OnTrouve As Boolean = True

        If POSITIONS.col_Position.Count = 0 Then Cherche_Premier()

        For iPos = 1 To POSITIONS.col_Position.Count
            If POSITIONS.col_Position.Item(iPos).nbFils = PasEncoreRechercher Then
                Find_Next_Pos(iPos)
            End If
        Next

    End Sub

    'Recherche et créer les fils en boucle
    Public Sub Find_All_Child()

        Dim Eureka As Boolean = True
        Dim lastindex As Integer = 1
        Dim firstfind As Boolean = True

        If POSITIONS.col_Position.Count = 0 Then
            Cherche_Premier()
        Else
            'on doit recalculer la dernière position trouvé
            POSITIONS.col_Position.Item(POSITIONS.col_Position.Count).nbFils = PasEncoreRechercher
        End If


        While Eureka  'tant qu'on trouve des nouveaux fils
            For iPos = lastindex To POSITIONS.col_Position.Count 'depuis le dernier noeud trouvé
                firstfind = True
                Eureka = False
                If POSITIONS.col_Position.Item(iPos).nbFils = PasEncoreRechercher Then
                    Find_Next_Pos(iPos)
                    Eureka = True
                    If firstfind Then       'on stock l'index du premier nouveau noeud trouvé
                        lastindex = iPos
                        firstfind = False
                    End If
                End If
            Next
        End While

    End Sub

    ' recherche depuis une POSITION (correspondant à un ETAT)
    ' dans les ETATS suivant (jusqu'a nbMAX) 
    ' des ETATS correspondant à la signature d'un coup légal
    ' créer alors une nouvelle POSITION
    ' renvoie le nombre de fils trouvé pour la position
    Public Function Find_Next_Pos(ByVal idPosition As UInteger) As Byte

        Dim CoupsEnString As String
        Dim LesCoups As String()
        Dim LeCoup As String()
        Dim Nb_Child_Find As Integer = 0
        Dim aPos As GamePositions.aPosition
        Dim NewFen As String
        Dim idStateStart As Integer
        Dim NbLigneSuivante As Byte
        Dim TempsEntreCoup As UInteger
        Dim iEtat As Byte
        Dim iSignature As UInteger

        Dim nbMAX As Byte
        Dim nbLigneMax As UInteger

        nbMAX = LesOptions.Nb_signatures_comparees
        nbLigneMax = LesOptions.Num_derniere_Ligne

        'position sur laquelle on se place
        aPos = POSITIONS.col_Position.Item(idPosition)
        'état sur lequel on se place
        idStateStart = aPos.idState

        If idStateStart = 0 Then Return 0

        PARTIE.SetFEN(aPos.FEN)

        'récupère les signatures possibles de tous les coups 
        'renvoyer sous la forme d'un STRING contenenant les signatures et le coups
        'sous la forme forme : 195.195...195 a1h8 Th8|195.195...195 a1h8 Th8
        CoupsEnString = PARTIE.Get_All_Signs()

        LesCoups = CoupsEnString.Split("|") 'sépare les signatures

        If idStateStart > ETATS.col_States.Count Then Return 0

        For iSignature = 0 To LesCoups.Count - 1 'pour chaque signature possible

            'temps de reflexion total pour jouer le coup et déplacer la pièce
            'on commence par y mettre le temps de stabilité de la position 
            TempsEntreCoup = ETATS.col_States.Item(idStateStart).temps

            'sépare la signature des coups UCI et SAN
            LeCoup = LesCoups(iSignature).Split(" ")

            'on regarde dans combien de ligne suivante 
            NbLigneSuivante = Min(ETATS.col_States.Count - idStateStart, nbMAX)

            'pour tester l'algo avec un nombre de ligne limité
            If nbLigneMax <> 0 Then
                NbLigneSuivante = Min(nbLigneMax - idStateStart + 1, nbMAX)
            End If

            For iEtat = 1 To NbLigneSuivante

                'égalité parfaite des signatures
                If ETATS.col_States.Item(idStateStart + iEtat).signature = LeCoup(0) Then

                    'vérifions que la case de départ s'est éteinte et que la case d'arrivée s'est allumé
                    'ou que ses vérifications sont ignorées
                    If (LesOptions.Zap_Verif_case_depart Or ETATS.switched_OFF(LeCoup(1).Substring(0, 2), idStateStart, idStateStart + iEtat)) _
                        And (LesOptions.Zap_Verif_case_arrivee Or ETATS.switched_ON(LeCoup(1).Substring(2, 2), idStateStart + 1, idStateStart + iEtat)) Then

                        PARTIE.MakeMove(LeCoup(1))  'effectue le déplacement
                        NewFen = PARTIE.GetFEN      'pour récupérer le FEN
                        PARTIE.SetFEN(aPos.FEN)     'avant de remètre l'ancien FEN

                        'on tente d'ajouter cette nouvelle position si ce n'est pas un doublon
                        If POSITIONS.Ajoute_Position(idPosition, idStateStart + iEtat, NewFen, TempsEntreCoup, LeCoup(1), LeCoup(2), LesOptions.Couleur_Position) Then
                            Nb_Child_Find += 1
                        End If

                    End If

                End If

                'ajoute le temps de stabilité pour l'état suivant 
                'car le temps de stabilité de ce coup est compté dans le prochain coup
                TempsEntreCoup += ETATS.col_States.Item(idStateStart + iEtat).temps

            Next iEtat
        Next iSignature

        'affecte le nombre de fils trouvé au noeud parent
        POSITIONS.col_Position.Item(idPosition).nbFils = Nb_Child_Find


        'affecte aux fils trouvés le nombre de frère qu'ils ont
        For iEtat = 1 To Min(Nb_Child_Find, POSITIONS.col_Position.Count - idPosition)
            POSITIONS.col_Position.Item(idPosition + iEtat).nbfrere = Nb_Child_Find - 1
        Next iEtat

        ''si on a trouvé aucun fils
        'If Nb_Child_Find = 0 Then
        '    'si il n'y a pas de frère
        '    If POSITIONS.col_Position.Item(idPosition).nbfrere = 0 Then
        '        'si il y a plus de 30 ligne apres
        '        If ETATS.col_States.Count - idStateStart > nbMAX Then
        '            Calc_Proche_Pos(idPosition, 15, 1)
        '        End If
        '    End If
        'End If

        Return Nb_Child_Find

    End Function



    'calcule la distance (nombre de cases différentes) entre deux signatures
    'place dans case différente la case qui diffère
    Public Function Distance(ByVal Signature1 As String, ByVal signature2 As String) As Byte
        Dim colonne1 As String()
        Dim colonne2 As String()
        Dim Byte1 As Byte
        Dim byte2 As Byte
        Dim diff As Byte = 0

        If signature2 = "" Then Return 255

        colonne1 = Signature1.Split(".")
        colonne2 = signature2.Split(".")

        For iCol = 7 To 0 Step -1
            If colonne1(iCol) <> colonne2(iCol) Then
                Byte1 = colonne1(iCol)
                byte2 = colonne2(iCol)
                For j = 0 To 7
                    If (Byte1 And (2 ^ j)) <> (byte2 And (2 ^ j)) Then   'si la case est diffétente
                        diff += 1

                        'CaseDifferente &= Chr(iCol + 97) & (j + 1) & " "
                        'ligne = sqIndex \ 10 'récupère la ligne
                        'lettre = Chr(iCol + 96) 'recupere le numero de colonne
                    End If
                Next
            End If
        Next
        'CaseDifferente = Trim(CaseDifferente)
        'Debug.Assert(diff > 1)
        'Debug.Assert(CaseDifferente <> "")
        Return diff
    End Function

    'CALCULE LES ETATS NON PARFAITEMENT EGAUX
    'recherche tous les coups possible depuis une position
    'calcule la différence avec chacune des xNext signatures suivantes 
    'et retient celle qui sont inférieur à DistanceMax
    Public Function Calc_Proche_Pos(ByVal idPosition As UInteger, ByVal xNext As Byte, ByVal DistanceMax As Byte) As Byte

        Dim CoupsEnString As String
        Dim LesCoups As String()
        Dim LeCoup As String()
        Dim Nb_Child_Find As Integer = 0
        Dim aPos As GamePositions.aPosition
        Dim NewFen As String
        Dim idStateStart As Integer
        Dim laDistance As Byte
        Dim TempsEntreCoup As UInteger


        'position sur laquelle on se place
        aPos = POSITIONS.col_Position.Item(idPosition)
        idStateStart = aPos.idState

        PARTIE.SetFEN(aPos.FEN)

        CoupsEnString = PARTIE.Get_All_Signs()  'récupère les signatures possibles de tous les coups sous la forme forme : 195.195...195 a1h8|195.195...195 a1h8

        'Try
        LesCoups = CoupsEnString.Split("|") 'sépare le rec

        For iSignature = 0 To LesCoups.Count - 1 'pour chaque signature possible

            'temps de reflexion total pour jouer le coup et déplacer la pièce
            'on commence par y mettre le temps de stabilité de la position 
            TempsEntreCoup = ETATS.col_States.Item(idStateStart).temps

            'sépare la signature des coups UCI et SAN
            LeCoup = LesCoups(iSignature).Split(" ")

            For iEtat = 1 To Min(ETATS.col_States.Count - idStateStart, xNext) 'cherche dans les xNext signatures suivantes

                laDistance = Distance(ETATS.col_States.Item(idStateStart + iEtat).signature, LeCoup(0))

                If laDistance <= DistanceMax Then 'si la distance est inférieur à la limite

                    'vérifions que la case de départ s'est éteinte 
                    'If ETATS.switched_OFF(LeCoup(1).Substring(0, 2), idStateStart, idStateStart + iEtat) Then

                    PARTIE.MakeMove(LeCoup(1))  'effectue le déplacement
                    NewFen = PARTIE.GetFEN      'pour récupérer le FEN
                    PARTIE.SetFEN(aPos.FEN)     'avatn de remètre l'ancien

                    If POSITIONS.Ajoute_Position(idPosition, idStateStart + iEtat, NewFen, TempsEntreCoup, LeCoup(1), LeCoup(2), PositionColor.rouge) Then
                        Nb_Child_Find += 1
                    End If

                    'End If

                End If

                'ajoute le temps de stabilité pour l'état suivant 
                'car le temps de stabilité de ce coup est compté dans le prochain coup
                TempsEntreCoup += ETATS.col_States.Item(idStateStart).temps

            Next iEtat
        Next iSignature

        'affecte le nombre de fils trouvé au noeud parent
        POSITIONS.col_Position.Item(idPosition).nbFils = Nb_Child_Find

        'affecte aux fils trouvés le nombre de frère qu'ils ont
        For iEtat = 1 To Min(Nb_Child_Find, POSITIONS.col_Position.Count - idPosition)
            POSITIONS.col_Position.Item(idPosition + iEtat).nbfrere = Nb_Child_Find - 1
        Next iEtat

        Return Nb_Child_Find

        'Catch ex As Exception
        '    MsgBox("erreur dans Calc_Next_Pos")
        '    POSITIONS.col_Position.Item(idPosition).nbFils = 0
        'End Try

    End Function




#End Region


#Region "FONCTION DE DESSIN"

    Dim backBuffer As New Bitmap(My.Resources.board90)
    Dim aGraphic As Graphics = Graphics.FromImage(backBuffer)

#Region "Les Images PNG"
    Dim wp As New Bitmap(My.Resources.wp)
    Dim wr As New Bitmap(My.Resources.wr)
    Dim wn As New Bitmap(My.Resources.wn)
    Dim wb As New Bitmap(My.Resources.wb)
    Dim wq As New Bitmap(My.Resources.wq)
    Dim wk As New Bitmap(My.Resources.wk)

    Dim bp As New Bitmap(My.Resources.bp)
    Dim br As New Bitmap(My.Resources.br)
    Dim bn As New Bitmap(My.Resources.bn)
    Dim bb As New Bitmap(My.Resources.bb)
    Dim bq As New Bitmap(My.Resources.bq)
    Dim bk As New Bitmap(My.Resources.bk)

    Dim bboard As New Bitmap(My.Resources.board90)
    Dim bHaut As New Bitmap(My.Resources.bHaut)
    Dim bCote As New Bitmap(My.Resources.bcote)

    Dim greenCircle As New Bitmap(My.Resources.vert)
    Dim redCircle As New Bitmap(My.Resources.rouge)
    Dim blueCircle As New Bitmap(My.Resources.bleu)
    Dim GreenCross As New Bitmap(My.Resources.pg)
#End Region

    Dim PieceSize As Integer

    'dessine l'échiquier puis  les pièces
    Private Sub DrawPiece(Optional ByVal aFEN As String = "")
        Dim rect As Rectangle
        Dim pt As Point


        If Me.WindowState <> FormWindowState.Minimized Then

            PictureBox1.Top = 10
            PictureBox1.Left = 10

            PictureBox1.Height = Me.ClientSize.Height - 20
            PictureBox1.Width = Me.ClientSize.Height - 20

            PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)

            backBuffer = New Bitmap(PictureBox1.Width, PictureBox1.Height)
            aGraphic = Graphics.FromImage(backBuffer)

            pt.X = 1 : pt.Y = 1 : aGraphic.DrawImage(bHaut, pt)                        'dessine le bord haut
            pt.X = 1 : pt.Y = PictureBox1.Height - 17 : aGraphic.DrawImage(bHaut, pt)  'dessine le bord bas
            pt.X = 1 : pt.Y = 1 : aGraphic.DrawImage(bCote, pt)                        'dessine le bord gauche
            pt.X = PictureBox1.Width - 17 : pt.Y = 1 : aGraphic.DrawImage(bCote, pt)   'dessine le bord droit

            pt.X = bHaut.Width - 1 : pt.Y = 1 : aGraphic.DrawImage(bHaut, pt)                        'dessine le bord haut
            pt.X = bHaut.Width - 1 : pt.Y = PictureBox1.Height - 17 : aGraphic.DrawImage(bHaut, pt)  'dessine le bord bas
            pt.X = 1 : pt.Y = bCote.Height - 1 : aGraphic.DrawImage(bCote, pt)                        'dessine le bord gauche
            pt.X = PictureBox1.Width - 17 : pt.Y = bCote.Height - 1 : aGraphic.DrawImage(bCote, pt)   'dessine le bord droit

            rect.X = 0 : rect.Y = 0
            rect.Width = PictureBox1.Width - 1 : rect.Height = PictureBox1.Height - 1
            aGraphic.DrawRectangle(Pens.Brown, rect)                                   'dessine le filet exterieur 

            rect.X = 17 : rect.Y = 17
            rect.Width = PictureBox1.Width - 35 : rect.Height = PictureBox1.Height - 35
            aGraphic.DrawRectangle(Pens.Black, rect)                                   'dessine le filet intérieur

            rect.X = 18 : rect.Y = 18
            rect.Width = PictureBox1.Width - 36 : rect.Height = PictureBox1.Height - 36
            aGraphic.DrawImage(bboard, rect)                                           'dessine l'échiquier

            PieceSize = (PictureBox1.Height - 36) / 8



            With TabControl1
                .Top = 10
                .Left = PictureBox1.Left + PictureBox1.Width + 10
                .Height = Me.ClientSize.Height - .Top - 10
                .Width = Me.ClientSize.Width - (PictureBox1.Width + 30)
            End With



            PictureBox1.Image = backBuffer

            Dim LaPiece As Char
            For i = 11 To 88
                LaPiece = PARTIE.Board10x10(i)
                If LaPiece <> " " And LaPiece <> "*" Then
                    PutPiece(i, LaPiece)
                End If
            Next

        End If
    End Sub

    'retourne le bitmap correspondant à la piece d'une notation FEN
    Private Function bmpPiece(ByVal name As Char) As Bitmap
        Select Case name
            Case "P"
                Return wp
            Case "R"
                Return wr
            Case "N"
                Return wn
            Case "B"
                Return wb
            Case "Q"
                Return wq
            Case "K"
                Return wk

            Case "p"
                Return bp
            Case "r"
                Return br
            Case "n"
                Return bn
            Case "b"
                Return bb
            Case "q"
                Return bq
            Case "k"
                Return bk

            Case "1"
                Return redCircle
            Case "2"
                Return greenCircle
            Case "3"
                Return blueCircle
            Case "4"
                Return GreenCross


        End Select
    End Function

    'retourne la position X de la case
    Private Function Xsqi(ByVal sqi As Byte) As Integer
        Dim colonne As Byte
        Dim ligne As Byte

        colonne = sqi Mod 10
        ligne = sqi \ 10

        Return 18 + (colonne - 1) * PieceSize

    End Function

    'retourne la position Y de la case
    Private Function Ysqi(ByVal sqi As Byte) As Integer
        Dim colonne As Byte
        Dim ligne As Byte

        colonne = sqi Mod 10
        ligne = sqi \ 10

        Return 18 + (8 - ligne) * PieceSize

    End Function

    'dessine une pièce sur une case
    Private Sub PutPiece(ByVal sqIndex As Byte, ByVal Initiale As Char)
        Dim rect As Rectangle
        rect.X = Xsqi(sqIndex)
        rect.Y = Ysqi(sqIndex)
        rect.Width = PieceSize
        rect.Height = PieceSize

        aGraphic.DrawImage(bmpPiece(Initiale), rect)

    End Sub

    'affiche sur l'échiquier une position
    Public Sub Draw_Position(ByVal idPosition As Integer)
        PARTIE.SetFEN(POSITIONS.col_Position(idPosition).FEN)
        DrawPiece()
    End Sub

    'dessine un symbole sur une case
    Private Sub PutSymbol(ByVal sqIndex As Byte, ByVal Initiale As Char)
        Dim rect As Rectangle
        Dim p As Graphics = PictureBox1.CreateGraphics
        rect.X = Xsqi(sqIndex)
        rect.Y = Ysqi(sqIndex)
        rect.Width = PieceSize
        rect.Height = PieceSize

        p.DrawImage(bmpPiece(Initiale), rect)

    End Sub

    'Lorsqu'on clic sur un item de la listview
    'Affiche les symbole sur une case
    Public Sub DrawSymbol()
        Dim sqOn As String
        Dim sqOff As String
        Dim sqOnI As Byte
        Dim sqOffI As Byte

        On Error Resume Next

        sqOn = lvRec.SelectedItems(0).SubItems(3).Text
        sqOff = lvRec.SelectedItems(0).SubItems(4).Text
        If sqOn <> "" Then sqOnI = ETATS.Index_Case(sqOn)
        If sqOff <> "" Then sqOffI = ETATS.Index_Case(sqOff)
        PutSymbol(sqOnI, "1")
        PutSymbol(sqOffI, "2")
    End Sub

#End Region



#Region "EVENEMENT FORM"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Option()
        LoadInfoPgn()
        PictureBox1.Top = 10
        PictureBox1.Left = 10
        pbReduire.Top = 10
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Static MustRedraw As Boolean
        pbReduire.Visible = False

        Select Case Me.WindowState
            Case FormWindowState.Maximized
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                DrawPiece()
                MustRedraw = True
                pbReduire.Visible = True
                pbReduire.Left = Me.ClientSize.Width - pbReduire.Width - 10
            Case FormWindowState.Minimized
                MustRedraw = True
            Case FormWindowState.Normal
                If MustRedraw Then
                    DrawPiece()
                    MustRedraw = False
                End If
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        End Select
    End Sub

    Private Sub Form1_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Static WindowsSize As Integer
        If Me.WindowState = FormWindowState.Normal Then
            If WindowsSize <> Me.Width + Me.Height Then
                DrawPiece()
                WindowsSize = Me.Width + Me.Height
            End If
        End If
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        DrawPiece()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        wp.Dispose()
        wr.Dispose()
        wn.Dispose()
        wb.Dispose()
        wq.Dispose()
        wk.Dispose()

        bp.Dispose()
        br.Dispose()
        bn.Dispose()
        bb.Dispose()
        bq.Dispose()
        bk.Dispose()

        bboard.Dispose()
        bHaut.Dispose()
        bCote.Dispose()

        greenCircle.Dispose()
        redCircle.Dispose()
        blueCircle.Dispose()
        GreenCross.Dispose()
    End Sub

#End Region

#Region "Evenement Bouton reduire"

    Private Sub pbReduire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReduire.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

#End Region

#Region "EVENEMENT TREE VIEW"

    'Dessine la position lorsqu'on clic sur un noeud de la Treeview
    Private Sub tvPos_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvPos.AfterSelect
        Dim aTag As String
        Dim aPos As Integer

        'On Error Resume Next

        aTag = tvPos.SelectedNode.Tag

        aTag = aTag.Replace("k", "")

        Draw_Position(aTag)
        aPos = aTag

        tvPos.SelectedNode.EnsureVisible()

        sbArbre.Text = "Pos " & aTag

        With POSITIONS.col_Position(aPos)
            sbArbre.Text &= " Etat " & .idState
            sbArbre.Text &= " Fils : " & .nbFils
            sbArbre.Text &= " Fre : " & .nbFrere
            sbArbre.Text &= " tps : " & .TempsReflexion
            sbArbre.Text &= " uci : " & .moveuci
            'sbArbre.Text &= " Proche : " & .CaseProche
        End With

    End Sub


    'Renvoi le PGN correspondant au dernier noeud
    Public Function PGN_Of_Node(Optional ByVal nbCoupRetard As Byte = 0) As String
        Dim PGNgame As String = ""
        Dim tempo As String = ""

        With InfoGame
            PGNgame = "[Event ""?""]".Replace("?", .Event_str) & vbCrLf
            PGNgame &= "[Site ""?""]".Replace("?", .Site) & vbCrLf
            PGNgame &= "[Date ""?""]".Replace("?", .Date_str) & vbCrLf
            PGNgame &= "[Round ""?""]".Replace("?", .Round) & vbCrLf
            PGNgame &= "[White ""?""]".Replace("?", .White) & vbCrLf
            PGNgame &= "[Black ""?""]".Replace("?", .Black) & vbCrLf
            PGNgame &= "[Result ""?""]".Replace("?", .Result) & vbCrLf
            PGNgame &= "[WhiteElo ""?""]".Replace("?", .WhiteElo) & vbCrLf
            PGNgame &= "[BlackElo ""?""]".Replace("?", .BlackElo) & vbCrLf
            If .TimeControl <> "" Then
                PGNgame &= "[TimeControl ""?""]".Replace("?", .TimeControl) & vbCrLf
            End If
            PGNgame &= vbCrLf
        End With

        Dim LastNode As New TreeNode
        Dim isFind As Boolean = False

        Find_Node_By_Key(tvPos.Nodes, POSITIONS.col_Position.Count & "k", LastNode, isFind)

        On Error Resume Next
        'For i = 1 To nbCoupRetard
        '    LastNode = LastNode.Parent
        'Next


        tempo = LastNode.FullPath
        tempo = tempo.Replace("'\", vbCrLf)
        tempo = tempo.Replace(",\", "")
        tempo = tempo.Replace("Start\", "")
        tempo = tempo.Replace("'", "")
        tempo = tempo.Replace(",", "")

        Return PGNgame & tempo & " " & InfoGame.Result
    End Function

#End Region



#Region "EVENEMENT SUR LES MENUS"

    'affecte -1 au noeud selectionné pour forcer son recalcul
    Private Sub menuRecalculer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRecalculer.Click
        Dim aTag As String
        Dim aPos As UInteger

        aTag = tvPos.SelectedNode.Tag
        aTag = aTag.Replace("k", "")
        aPos = aTag
        POSITIONS.col_Position(aPos).nbfils = PasEncoreRechercher
    End Sub

    'efface tous les noeuds
    Private Sub menuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuClear.Click
        POSITIONS.col_Position.Clear()
        tvPos.Nodes.Clear()
    End Sub

    'lance une recherche en boucle
    Private Sub menuTous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuTous.Click

        intTimeStart = Environment.TickCount
        Find_All_Child()
        Debug.Print("temps recherche : " & Environment.TickCount - intTimeStart)
        intTimeStart = Environment.TickCount
        Refresh_TreeView()
        Refresh_ListView()
        Draw_Position(POSITIONS.col_Position.Count)
        Debug.Print("temps affichage : " & Environment.TickCount - intTimeStart)

        'TODO attention l'enregistrement est automatique !

        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)

        Try
            My.Computer.FileSystem.WriteAllText(c_pgn_live_pgn, PGN_Of_Node(2), False, utf8WithoutBom)
        Catch ex As Exception
            Exit Sub
        End Try



    End Sub

    'lance une recherche en boucle en la limitant à la ligne de la liste sélectionnée
    Private Sub menuTousLimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuTousLimit.Click
        POSITIONS.col_Position.Clear()
        LesOptions.Num_derniere_Ligne = lvRec.SelectedItems(0).Index
        Find_All_Child()
        Refresh_TreeView()
        Refresh_ListView()
        LesOptions.Num_derniere_Ligne = 0
    End Sub

    'affiche l'état dans la liste correspondant au noeud sélectionné
    Private Sub menuVoirEtat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuVoirEtat.Click
        Dim aTag As String
        Dim aPos As UInteger
        Dim lvItem As Integer

        aTag = tvPos.SelectedNode.Tag
        aTag = aTag.Replace("k", "")
        aPos = aTag
        lvItem = POSITIONS.col_Position(aPos).idState
        lvRec.Items(lvItem - 1).Selected = True
        lvRec.Items(lvItem - 1).EnsureVisible()
        lvRec.Items(lvItem - 1).Focused = True
        TabControl1.SelectTab(1)
    End Sub

    'copie dans le presse papier la position FEN du noeud sélectionné
    Private Sub menuCopierFEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCopierFEN.Click
        Dim aTag As String

        aTag = tvPos.SelectedNode.Tag
        aTag = aTag.Replace("k", "")
        Clipboard.SetText(POSITIONS.col_Position(CInt(aTag)).FEN)

    End Sub

    'lance une recherche coup proche sur le noeud sélectionné
    Private Sub menuCoupProche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCoupProche.Click
        Dim aTag As String
        On Error GoTo ErrorHandler 'si aucun noeud sélectionné
        aTag = tvPos.SelectedNode.Tag
        aTag = aTag.Replace("k", "")
        Calc_Proche_Pos(aTag, 15, 1)
        Refresh_TreeView()

ErrorHandler:

    End Sub


    'ouvre un fichier et l'affiche dans la listview
    Private Sub menuOuvreDonnees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuOuvreDonnees.Click
        Dim NomFichier As String

        NomFichier = NameFile()
        If NomFichier <> "" Then
            intTimeStart = Environment.TickCount
            ETATS.LoadFromFile(NomFichier, menuInvGD.Checked, menuInvHB.Checked, menuRot90.Checked)
            Debug.Print("temps chargement : " & Environment.TickCount - intTimeStart)
            Refresh_ListView()
            sbEnregistrement.Text = NomFichier
            If menuEnBoucle.Checked Then
                If MsgBox("attention ce fichier sera ouvert toutes les 10 secondes", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    TimerOpenFile.Enabled = True
                End If
            End If
        End If
    End Sub

    'décoche tous les menus couleurs
    Private Sub uncheck_all()
        mnuOpCoulBleu.Checked = False
        mnuOpCoulNoir.Checked = False
        mnuOpCoulRouge.Checked = False
        mnuOpCoulVert.Checked = False
    End Sub

    'choisi une couleur
    Private Sub mnuOpCoulNoir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpCoulNoir.Click
        uncheck_all()
        sender.Checked = True
        LesOptions.Couleur_Position = PositionColor.noir
    End Sub

    'choisi une couleur
    Private Sub mnuOpCoulRouge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpCoulRouge.Click
        uncheck_all()
        sender.Checked = True
        LesOptions.Couleur_Position = PositionColor.rouge
    End Sub

    'choisi une couleur
    Private Sub mnuOpCoulVert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpCoulVert.Click
        uncheck_all()
        sender.Checked = True
        LesOptions.Couleur_Position = PositionColor.vert
    End Sub

    'choisi une couleur
    Private Sub mnuOpCoulBleu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpCoulBleu.Click
        uncheck_all()
        sender.Checked = True
        LesOptions.Couleur_Position = PositionColor.bleu
    End Sub

    'bascule l'option
    Private Sub mnuVerifCaseDepart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerifCaseDepart.Click
        sender.Checked = Not sender.Checked
        LesOptions.Zap_Verif_case_depart = Not sender.Checked
    End Sub

    'bascule l'option
    Private Sub mnuVerifCaseArrivee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerifCaseArrivee.Click
        sender.Checked = Not sender.Checked
        LesOptions.Zap_Verif_case_arrivee = Not sender.Checked
    End Sub

    'demande le nombre de signature à comparer
    Private Sub mnuOpSuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpSuivant.Click
        'si on ne rentre pas un nombre dans la boite cela plante 
        On Error Resume Next
        'mais on passe en conservant l'ancienne valeur
        LesOptions.Nb_signatures_comparees = InputBox("Nombre de signature à comparer !,", , 20)
        mnuOpSuivant.Text = "Nb suivant (" & LesOptions.Nb_signatures_comparees.ToString & ")"
    End Sub

    'relance une recherche complete en forcant un recacule de toutes les positons
    Private Sub mnuReTous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReTous.Click
        Efface_Nb_Fils_Trouve()
        LesOptions.Re_calculer = True
        Find_All_Child()
        Refresh_TreeView()
        'Refresh_ListView()
    End Sub

    'bascule l'option permmetant d'afficher les noeuds sans fils
    Private Sub mnuVoirOrphelin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVoirOrphelin.Click
        sender.Checked = Not sender.Checked
        LesOptions.Voir_Orphelin = sender.Checked
        Refresh_TreeView()
    End Sub

    'copie dans le presse papier la partie complète en PGN correspondant au dernier noeud 
    Private Sub mneCopierPGN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mneCopierPGN.Click
        Clipboard.SetText(PGN_Of_Node(2))
    End Sub

    'lance la recherche sur les positions pas encore calculée
    Private Sub menuCoupSuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCoupSuivant.Click
        Find_Child()
        Refresh_TreeView()
    End Sub

    'affiche la feuille pour modifier les infos de la partie
    Private Sub menuInformationPartie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInformationPartie.Click
        LoadInfoPgn()
        frmPgnInfo.Show()
    End Sub

    'sauvegarde la partie correspondant au dernier noeud
    Private Sub menuSauvePartie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSauvePartie.Click
        Dim NumFile As Integer
        Dim TheFileName As String = ""

        While My.Computer.FileSystem.FileExists("c:\GAME\game" & NumFile.ToString & ".pgn")
            NumFile += 1
        End While

        TheFileName = "c:\GAME\game" & NumFile.ToString & ".pgn"

        Try
            My.Computer.FileSystem.WriteAllText(TheFileName, PGN_Of_Node, True)
        Catch ex As Exception

            MsgBox("Impossible de sauvegarder : " & TheFileName, MsgBoxStyle.Exclamation, "ERREUR")

        End Try


    End Sub

#End Region

#Region "FONCTION INUTILE"

    '' recherche depuis une POSITION (correspondant à un ETAT)
    '' dans les ETATS suivant (jusuqu'a nbMAX) 
    '' des ETATS correspondant à la signature d'un coup légal
    '' les renvoie alors dans States_found
    'Public Function Get_Next_idPos(ByVal idPosition As UInteger, _
    '                        ByRef States_found As Collection, _
    '                        Optional ByVal nbMAX As Byte = 30) As Byte

    '    Dim LesRecs As String
    '    Dim RecPossibles As String()
    '    Dim LeCoup As String()

    '    Dim aPos As GamePositions.aPosition

    '    Dim idStateStart As Integer
    '    Dim NbLigneSuivante As Byte

    '    Dim aCandidat As Etat_candidat


    '    'position sur laquelle on se place
    '    aPos = POSITIONS.col_Position.Item(idPosition)
    '    'état sur lequel on se place
    '    idStateStart = aPos.idState
    '    'on place la position dans l'état de la position
    '    PARTIE.SetFEN(aPos.FEN)

    '    'récupère les signatures possibles de tous les coups 
    '    'renvoyer sous la forme d'un STRING contenenant les signatures et le coups
    '    ' sous la forme forme : 195.195...195 a1h8 Th8|195.195...195 a1h8 Th8
    '    LesRecs = PARTIE.Get_All_Signs()

    '    'Try
    '    RecPossibles = LesRecs.Split("|") 'sépare les signatures

    '    For iSignature = 0 To RecPossibles.Count - 1 'pour chaque signature possible
    '        LeCoup = RecPossibles(iSignature).Split(" ") 'sépare la signature des coups UCI et SAN

    '        'on regarde dans combien de ligne suivante 
    '        NbLigneSuivante = Min(ETATS.col_States.Count - idStateStart, nbMAX)

    '        For iEtat = 1 To NbLigneSuivante

    '            'égalité parfaite des signatures
    '            If ETATS.col_States.Item(idStateStart + iEtat).signature = LeCoup(0) Then

    '                With aCandidat
    '                    .idEtat = idStateStart + iEtat
    '                    .UCI = LeCoup(1)
    '                    .SAN = LeCoup(2)
    '                    .sqOff = ETATS.switched_OFF(LeCoup(1).Substring(0, 2), idStateStart, idStateStart + iEtat)
    '                    .SqOn = ETATS.switched_ON(LeCoup(1).Substring(2, 2), idStateStart + 1, idStateStart + iEtat)
    '                End With
    '                States_found.Add(aCandidat)
    '            End If

    '        Next iEtat
    '    Next iSignature

    '    Return States_found.Count
    'End Function

    'calcule le nombre de cases différentes entre deux positions

#End Region


    
    Private Sub menuEnBoucle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEnBoucle.Click
        menuEnBoucle.Checked = Not menuEnBoucle.Checked
        TimerOpenFile.Enabled = False
    End Sub

    'envoie le fichier sur le serveur FTP
    Private Sub SendFTP()
        Try 'Instance d'essaie qui retournera une erreur en cas de problème

            Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp_serveur"), System.Net.FtpWebRequest) 'On renseigne la futur destination du fichier à envoyer
            request.Credentials = New NetworkCredential("user_name", "password") 'On rentre les identifiant et mot de passe

            request.Method = System.Net.WebRequestMethods.Ftp.UploadFile 'On indique qu'on veut upload un fichier

            Dim files() As Byte = File.ReadAllBytes(c_pgn_live_pgn) 'On indique le chemin du fichier à upload

            Dim strz As Stream = request.GetRequestStream() 'On créer un stream qui va nous permettre d'envoyer le fichier

            strz.Write(files, 0, files.Length) 'On envoie le fichier

            strz.Close() 'On ferme la connection
            strz.Dispose() 'On supprime la connection

        Catch ex As Exception 'Une erreur c'est produite, on récupère l'erreur et on l'affiche.
            Debug.Print("Erreur :" & vbCrLf & ex.ToString)
        End Try
    End Sub

    'Ouvre le fichier automatiquement 
    'lorsqu"il est envoyé par un raspberry pi
    Private Sub TimerOpenFile_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerOpenFile.Tick
        'Dim infoReader As System.IO.FileInfo
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Static NouveauCalculNecessaire As Boolean = False
        Static compteur As Byte = 0
        'Static tailledufichier As Long = 0
        Static nombredesignature As Integer = 0
        Dim tempo As Long = 0

        pbArbre.Value = compteur * 10
        compteur += 1
        If compteur < 11 Then Exit Sub
        compteur = 0

        If menuEnBoucle.Checked = True Then
            'infoReader = My.Computer.FileSystem.GetFileInfo("\\RASPBERRYPI\DossierDeParties\Ronde_001.ARD") '"C:\pgn\live.ard")
            'tempo = infoReader.Length
            'If tempo = tailledufichier Then
            'le fichier n'a pas changé depuis la derniere ouverture
            If NouveauCalculNecessaire = True Then
                'si on ne l'a pas déjà calculé    
                If menuCalculComplet.Checked Then
                    POSITIONS.col_Position.Clear()
                    tvPos.Nodes.Clear()
                End If
                Find_All_Child()
                Refresh_TreeView()
                Refresh_ListView()
                Draw_Position(POSITIONS.col_Position.Count)

                Try
                    My.Computer.FileSystem.WriteAllText(c_pgn_live_pgn, PGN_Of_Node, False, utf8WithoutBom)
                Catch ex As Exception
                    Exit Sub
                End Try



                NouveauCalculNecessaire = False
                sbArbre.Text = "CALCUL POSITION"
            Else
                sbArbre.Text = "SAME FILE"

            End If
            'Else
            'le fichier a changé on le charge uniquement 
            If ETATS.LoadFromFile(OpenFileDialog1.FileName, menuInvGD.Checked, menuInvHB.Checked, menuRot90.Checked) Then '"\\RASPBERRYPI\DossierDeParties\Ronde_001.ARD"
                Refresh_ListView()
                If nombredesignature = lvRec.Items.Count Then
                    NouveauCalculNecessaire = False
                Else
                    NouveauCalculNecessaire = True
                    nombredesignature = lvRec.Items.Count
                End If

                'tailledufichier = tempo
                sbArbre.Text = "LOAD NEW FILE"
            End If
        End If
        'End If
    End Sub


    Private Sub menu1sec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu1sec.Click
        TimerOpenFile.Interval = 100
    End Sub

    Private Sub menu10sec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu10sec.Click
        TimerOpenFile.Interval = 1000
    End Sub

    Private Sub menu3ec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu3ec.Click
        TimerOpenFile.Interval = 300
    End Sub

    Private Sub menu5sec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu5sec.Click
        TimerOpenFile.Interval = 500
    End Sub

    Private Sub menu30sec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu30sec.Click
        TimerOpenFile.Interval = 3000
    End Sub

    Private Sub menuInvGD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInvGD.Click
        menuInvGD.Checked = Not menuInvGD.Checked
    End Sub

    Private Sub menuInvHB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInvHB.Click
        menuInvHB.Checked = Not menuInvHB.Checked
    End Sub

    Private Sub menuRot90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRot90.Click
        menuRot90.Checked = Not menuRot90.Checked
    End Sub

    Private Sub menuNum1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuNum1.Click
        menuNumero.Text = "Numéro 1"
        c_pgn_live_pgn = "c:\pgn\live1.pgn"
        InfoGame.IniSection = "GameInfo1"
        LoadInfoPgn()
    End Sub

    Private Sub menuNum2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuNum2.Click
        menuNumero.Text = "Numéro 2"
        c_pgn_live_pgn = "c:\pgn\live2.pgn"
        InfoGame.IniSection = "GameInfo2"
        LoadInfoPgn()
    End Sub

    Private Sub menuNum3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuNum3.Click
        menuNumero.Text = "Numéro 3"
        c_pgn_live_pgn = "c:\pgn\live3.pgn"
        InfoGame.IniSection = "GameInfo3"
        LoadInfoPgn()
    End Sub

    Private Sub menuCalculComplet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculComplet.Click
        menuCalculComplet.Checked = Not menuCalculComplet.Checked
    End Sub


    Private Sub lvRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRec.SelectedIndexChanged

    End Sub
End Class









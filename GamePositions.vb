Public Class GamePositions


    'POSITION CALCULEES A PARTIR DES ETATS ET DES COUPS LEGAUX


    'FEN de la position initial des échecs classique
    Public Const InitFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1"


    Public Last_Position As aPosition

    'type de donnée pour stocker une position
    'TODO pas besoin d'une class ici un simple type utilisateur devrait suffire mais je n'y arrive pas ?! 
    Public Class aPosition
        Public id As Integer            'numéro de la position
        Public idState As UInteger      'index de l'état corresondant
        Public FEN As String            'FEN de la position
        Public moveSAN As String        'deplacement sous la forme Cf3 ayant permit d'arriver dans cette position
        Public moveUCI As String        'deplacement sous la forme g1f3 ayant permit d'arriver dans cette position
        Public NumCoup As Byte          'numéro du coup
        Public TempsReflexion           'temps mis par le joueur pour joueur ce coup <=> temps de stabilité de la position précédente + intermédiare
        Public idParent As UInteger     'numéro du coup parent
        Public Valid As Byte            'la position est il validé=100/supposé/en attente
        Public nbFils As SByte          'nombre de fils trouvé -1 pas encore cherché
        Public nbFrere As Byte          'nombre de position de meme niveau ayant le meme pere
        Public Eval As SByte            'evaluation de la position -100 à +100
        'Public CaseProche As String    'case différente en cas de coup proche IMPOSSIBLE DE TROUVER FACILEMENT LA CASE DIFFERENTE DANS CERTAIN CAS
        Public Couleur As Byte          'couleur pour l'affichage de la position
        Public Key As String            'clé qui a permi d'ajouter la position actuellement key = moveUCI & idParent permet d'éviter les doublons
    End Class

    'collection des positions
    Public col_Position As New Collection


#Region "PUBLIC SUB"


    'vide les positions
    'créer la premiere position avec le FEN de départ sur l'état passé en paramètre
    'l'id de la premier position est 1
    Public Sub New_Game(ByVal iState As UInteger)
        Dim FisrtPos As New aPosition

        col_Position.Clear()

        With FisrtPos
            .id = 1
            .Eval = 0
            .FEN = InitFEN
            .idState = iState
            .NumCoup = 0
            .moveSAN = ""
            .moveUCI = ""
            .Valid = 100
            .idParent = 0
            .nbFils = -1
            .TempsReflexion = 0
            '.CaseProche = ""
            .Key = "start"
        End With

        col_Position.Add(FisrtPos, FisrtPos.Key)

        Last_Position = col_Position.Item(col_Position.Count)


    End Sub

    'ajoute une position 
    'a partir de la position parent
    'correspondant a un etat
    'mouvement SAN et UCI
    Public Function Ajoute_Position(ByVal idParent As UInteger, ByVal iState As ULong, _
                       ByVal FEN As String, ByVal TempsReflexion As UInteger, _
                       Optional ByVal UCI As String = "",
                       Optional ByVal SAN As String = "", _
                       Optional ByVal Couleur As Byte = 0) As Boolean

        Dim newPos As New aPosition

        With newPos
            .id = col_Position.Count + 1    'ajoute un Id à la position TODO a voir l'utilité réel si pas doublon avec key
            .idParent = idParent
            .idState = iState
            .FEN = FEN
            .moveSAN = SAN
            .moveUCI = UCI
            .Valid = 0
            .Eval = 0
            .nbFils = -1                                            'pas encore calculé
            .nbFrere = 0
            .NumCoup = col_Position.Item(idParent).NumCoup + 1      'coup suivant de celui du parent
            .TempsReflexion = TempsReflexion
            '.CaseProche = CaseProche
            .Couleur = Couleur
            .Key = .moveUCI & .idParent.ToString
        End With

        'vérifions qu'il ne s'agit pas d'un doublon
        'meme deplacement
        'meme parent
        If Not col_Position.Contains(newPos.Key) Then
            col_Position.Add(newPos, newPos.Key)
            Last_Position = col_Position.Item(col_Position.Count)
            Return True
        Else
            Return False
        End If

    End Function

    'remplace la derniere position 
    'a partir de la position parent
    'correspondant a un etat
    'mouvement SAN et UCI

    'Public Function Remplace_Position(ByVal idParent As UInteger, ByVal iState As ULong, _
    '                   ByVal FEN As String, _
    '                   ByVal TempsReflexion As UInteger, _
    '                   Optional ByVal UCI As String = "", Optional ByVal SAN As String = "") As Boolean

    '    Dim newPos As New aPosition


    '    If Not col_Position.Contains(newPos.moveUCI & newPos.idParent.ToString) Then

    '        newPos = col_Position.Item(col_Position.Count)

    '        With newPos
    '            '.id = col_Position.Count + 1
    '            '.idParent = idParent
    '            .idState = iState
    '            .FEN = FEN
    '            .moveSAN = SAN
    '            .moveUCI = UCI
    '            '.Valid = 0
    '            '.Eval = 0
    '            .nbFils = -1                                            'pas encore calculé
    '            '.nbFrere = 0
    '            '.NumCoup = col_Position.Item(idParent).NumCoup + 1      'coup suivant de celui du parent
    '            .TempsReflexion = TempsReflexion
    '        End With

    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function

#End Region

End Class

Module mGameInfo

    'permet de remplir l'entete d'un fichier PGN
    Public Structure InfoPGN
        Dim Event_str As String
        Dim Site As String
        Dim Round As String
        Dim Date_str As String
        Dim White As String
        Dim Black As String
        Dim WhiteElo As String
        Dim BlackElo As String
        Dim Result As String
        Dim TimeControl As String
        Dim LocalPIECE As String
        Dim IniFile As String
        Dim IniSection As String
    End Structure

    Public Structure Theme_Color
        Dim Dark_Square As Color
        Dim Light_Square As Color
        Dim Dark_highlight As Color
        Dim Ligh_highlight As Color
    End Structure

    Public Const NumberOfTheme As Byte = 2
    Public ThemesColor(NumberOfTheme) As Theme_Color
    Public NumColorTheme As Byte

    Public InfoGame As New InfoPGN

    Public rect_ChessBoardOnScreen As Rectangle 'emplacement de l'échiquier a l'écran 
    Public str_IniFile As String = ""

    'permet de stocker le timecode de la dernière reception de data via le port série
    Public LastReceive As Integer

    '************************************************************************************************
    '
    '                                       FONCTIONS AUTONOMES
    '
    '************************************************************************************************




    '************************************************************************************************
    '
    ' UTILISE LA COULEUR D'UN PIXEL POUR SAVOIR SI UNE PIECE NOIRE OU BLANCHE S'Y TROUVE
    '
    ' aColor couleur RVB du pixel
    '
    ' Renvoie TRUE si les conditions sont vérifiées (pixel blanc noir ou gris)
    ' Renvoie FALSE si la case est vide
    '************************************************************************************************
    Public Function pieceOnsquare(ByVal aColor As Color) As Boolean
        Dim R As Integer = aColor.R
        Dim G As Integer = aColor.G
        Dim B As Integer = aColor.B

        'si le pixel est suffisement blanc
        If R < 56 And G < 56 And B < 56 Then Return True

        'si le pixel est suffisement noir
        If R > 200 And G > 200 And B > 200 Then Return True

        'si le pixel est suffisement gris
        If Math.Abs(R - G) < 10 And Math.Abs(R - B) < 10 And Math.Abs(G - B) < 10 Then Return True

        Return False

    End Function


    '************************************************************************************************
    '
    ' RENVOIE LA SIGNATURE D'UN ECHIQUIER AFFICHE SUR L'ECRAN
    '
    ' renvoie TRUE si elle a changée
    '
    ' reverse_chessboard = true lorsque les noirs sont en bas
    ' rect_board est l'emplacement de l'échquier 
    ' State_Result contient la signature dans tous les cas
    '************************************************************************************************
    Public Function getScreenState(ByVal rect_board As Rectangle, ByRef State_Result As String, Optional ByVal reverse_chessboard As Boolean = False) As Boolean

        Dim myBmp As New Bitmap(rect_board.Width, rect_board.Height)
        Dim g As Graphics = Graphics.FromImage(myBmp)
        g.CopyFromScreen(rect_board.Location, Point.Empty, myBmp.Size)
        g.Dispose()
        Dim sqColor As Color
        Dim sSquare As Byte = rect_board.Width \ 8

        Dim strState As String = ""

        Dim bRow As Byte

        If reverse_chessboard Then 'les noirs sont en bas
            For colonne = 7 To 0 Step -1
                bRow = 0
                For ligne = 0 To 7
                    sqColor = myBmp.GetPixel(sSquare * colonne + sSquare \ 2, sSquare * ligne + sSquare \ 2)
                    If pieceOnsquare(sqColor) Then 'une piece se trouve sur la case
                        bRow += 2 ^ ligne ' on augmente l'octet de la colonne du bit correspondant
                    End If
                Next
                strState &= bRow
                strState &= "."
            Next
        Else 'les blancs sont en bas
            For colonne = 0 To 7
                bRow = 0
                For ligne = 7 To 0 Step -1
                    sqColor = myBmp.GetPixel(sSquare * colonne + sSquare \ 2, sSquare * ligne + sSquare \ 2)
                    If pieceOnsquare(sqColor) Then 'une piece se trouve sur la case
                        bRow += 2 ^ (7 - ligne) ' on augmente l'octet de la colonne du bit correspondant
                    End If
                Next
                strState &= bRow
                strState &= "."
            Next
        End If

        strState = strState.Substring(0, strState.Length - 1) 'supprime le dernier point

        myBmp.Dispose()

        If strState <> State_Result Then
            Debug.Print(strState)
            State_Result = strState
            Return True
        Else
            Return False
        End If

    End Function

    '************************************************************************************************
    ' RENVOIE ALEATOIREMENT +1 ou -1
    '************************************************************************************************
    Public Function Sigma() As Integer
        If Rnd() > 0.5 Then
            Return 1
        Else
            Return -1
        End If
    End Function

    '************************************************************************************************
    ' RENVOIE UN NOMBRE ALEATOIRE ENTRE lb et ub
    '************************************************************************************************
    Public Function Alea(ByVal lb As Integer, ByVal ub As Integer) As Integer
        Return Int((ub - lb + 1) * Rnd() + lb)
    End Function


    '************************************************************************************************
    ' ATTENDS ET STOP L'EXECUTION ENTRE 100 et 300 ms OU DE temps_ms
    '************************************************************************************************
    Public Sub waitPlease(Optional ByVal temps_ms As Integer = 0)
        If temps_ms = 0 Then
            System.Threading.Thread.Sleep(Alea(100, 300))
        Else
            System.Threading.Thread.Sleep(temps_ms)
        End If

    End Sub



End Module

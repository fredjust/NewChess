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

    Public InfoGame As New InfoPGN

    Public echiquier As Rectangle
    Public IniFile As String = ""

    'permet de stocker le timecode de la dernière reception de data via le port série
    Public LastReceive As Integer

End Module

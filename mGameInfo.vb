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

    Public echiquier As Rectangle
    Public IniFile As String = ""

    'permet de stocker le timecode de la dernière reception de data via le port série
    Public LastReceive As Integer

End Module

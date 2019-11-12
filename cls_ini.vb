Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text

'GESTION DES FICHIERS INI
'elles n'est pas de moi
'toujours très pratique les fichiers INI pour sauvegarder des trucs

Public Class Cls_Ini

#Region "Natives Methods"

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32

    <DllImport("kernel32")> _
    Private Shared Function GetPrivateProfileString(ByVal Section As String, ByVal Key As Integer, ByVal Value As String, <MarshalAs(UnmanagedType.LPArray)> ByVal Result As Byte(), ByVal Size As Integer, ByVal FileName As String) As Integer
    End Function

    <DllImport("kernel32")> _
    Private Shared Function GetPrivateProfileString(ByVal Section As Integer, ByVal Key As String, ByVal Value As String, <MarshalAs(UnmanagedType.LPArray)> ByVal Result As Byte(), ByVal Size As Integer, ByVal FileName As String) As Integer
    End Function

    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

#End Region

#Region "Méthodes publiques"

    'Suppression de section
    Public Shared Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
        Dim lpKeyName As String = Nothing
        Dim lpString As String = Nothing
        WritePrivateProfileString(SectionName, lpKeyName, lpString, INIPath)
    End Sub

    'Suppression de clé
    Public Shared Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String)
        Dim lpString As String = Nothing
        WritePrivateProfileString(SectionName, KeyName, lpString, INIPath)
    End Sub

    'Lecture sections (Clés/Valeurs)
    Public Shared Function INIRead(ByVal INIPath As String) As String
        Return INIRead(INIPath, Nothing, Nothing, "")
    End Function

    'Lecture Clés/Valeurs d'une section spécifiée
    Public Shared Function INIRead(ByVal INIPath As String, ByVal SectionName As String) As String
        Return INIRead(INIPath, SectionName, Nothing, "")
    End Function

    'Lecture Valeur d'une section et clé spécifiée
    Public Shared Function INIRead(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String) As String
        Return INIRead(INIPath, SectionName, KeyName, "")
    End Function

    'Lecture Valeur d'une section et clé spécifiée (retourne vaneur par défaut si elle n'existe pas)
    Public Shared Function INIRead(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String, ByVal DefaultValue As String) As String
        Dim lpReturnedString As String = Strings.Space(2048)
        Dim length As Integer = GetPrivateProfileString(SectionName, KeyName, DefaultValue, lpReturnedString, lpReturnedString.Length, INIPath)
        If length > 0 Then
            Return lpReturnedString.Substring(0, length)
        End If
        Return ""
    End Function

    'Ecriture Clés/Valeurs dans une section spécifiée
    Public Shared Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String, ByVal TheValue As String)
        WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub

    'Détecte si section spécifiée existe
    Public Shared Function INISectionExist(ByVal INIPath As String, ByVal SectionName As String) As Boolean
        For Each sect In INISectionNames(INIPath)
            If sect.ToLower = SectionName.ToLower Then
                Return True
            End If
        Next
        Return False
    End Function

    'Retourne tous les noms des sections existantes dans le fichier de configuration
    Public Shared Function INISectionNames(ByVal INIPath As String) As String()
        Dim maxsize As Integer = 500
        While True
            Dim bytes As Byte() = New Byte(maxsize - 1) {}
            Dim size As Integer = GetPrivateProfileString(0, "", "", bytes, maxsize, INIPath)
            If size < maxsize - 2 Then
                Dim Selected As String = Encoding.ASCII.GetString(bytes, 0, size - (If(size > 0, 1, 0)))
                Return Selected.Split(New Char() {ControlChars.NullChar})
            End If
            maxsize *= 2
        End While
        Return Nothing
    End Function

    'Retourne toutes les clés existantes d'une section spécifiée
    Public Shared Function INIEntryNames(ByVal INIPath As String, ByVal section As String) As String()
        Dim maxsize As Integer = 500
        While True
            Dim bytes As Byte() = New Byte(maxsize - 1) {}
            Dim size As Integer = GetPrivateProfileString(section, 0, "", bytes, maxsize, INIPath)
            If size < maxsize - 2 Then
                Dim entries As String = Encoding.ASCII.GetString(bytes, 0, size - (If(size > 0, 1, 0)))
                Return entries.Split(New Char() {ControlChars.NullChar})
            End If
            maxsize *= 2
        End While
        Return Nothing
    End Function

#End Region

End Class
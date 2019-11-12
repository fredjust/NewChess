Public Class frmPgnInfo

    'Enregistre les infos dans un fichier INI

    'coche la bonne case en fonction du résultat
    Private Sub rbCheck()
        Select Case InfoGame.Result
            Case "1-0"
                rbWhiteWin.Checked = True
            Case "1/2-1/2"
                rbDrawGame.Checked = True
            Case "0-1"
                rbBlackWin.Checked = True
            Case "*"
                rbNoResult.Checked = True
        End Select
    End Sub

    'renvoie le resultat PGN
    Private Function txtResult() As String
        txtResult = "*"
        If rbBlackWin.Checked Then
            txtResult = "0-1"
        End If
        If rbWhiteWin.Checked Then
            txtResult = "1-0"
        End If
        If rbDrawGame.Checked Then
            txtResult = "1/2-1/2"
        End If
        If rbNoResult.Checked Then
            txtResult = "*"
        End If
    End Function

    'renvoie 180+2
    Private Function strTimeControl() As String

        Dim strMin As String = ""
        Dim strSec As String = ""

        If nudMin.Value <> 0 Then
            strMin = (nudMin.Value * 60).ToString
        End If

        If nudSec.Value <> 0 Then
            strSec = "+" & nudSec.Value.ToString
        End If

        Return strMin & strSec

    End Function

    'modifie les infos de la partie avec les valeurs affichées a l'écran
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        With InfoGame
            .White = txtWhite.Text
            Cls_Ini.INIWrite(.IniFile, .IniSection, "White", .White)
            .Black = txtBlack.Text
            Cls_Ini.INIWrite(.IniFile, .IniSection, "Black", .Black)
            .Date_str = dtpDate.Text
            Cls_Ini.INIWrite(.IniFile, .IniSection, "Date", .Date_str)
            .Event_str = txtEvent.Text
            Cls_Ini.INIWrite(.IniFile, .IniSection, "Event", .Event_str)
            .Round = nudRound.Value
            Cls_Ini.INIWrite(.IniFile, .IniSection, "Round", .Round)
            .Site = txtSite.Text
            Cls_Ini.INIWrite(.IniFile, .IniSection, "Site", .Site)
            .Result = txtResult()
            Cls_Ini.INIWrite(.IniFile, .IniSection, "Result", .Result)
            .WhiteElo = txtEloWhite.Text
            Cls_Ini.INIWrite(.IniFile, .IniSection, "WhiteElo", .WhiteElo)
            .BlackElo = txtEloBlack.Text
            Cls_Ini.INIWrite(.IniFile, .IniSection, "BlackElo", .BlackElo)

            .TimeControl = strTimeControl()

        End With




        Me.Close()

    End Sub

    'cancel on ferme sans rien changer
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    'a l'ouverture on recupère les infos pour les afficher
    Private Sub frmPgnInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lestemps As String()

        lestemps = InfoGame.TimeControl.Split("+")
        nudMin.Value = lestemps(0) \ 60
        If UBound(lestemps) = 1 Then
            nudSec.Value = lestemps(1)
        Else
            nudSec.Value = 0
        End If

        With InfoGame
            txtBlack.Text = .Black
            txtEloBlack.Text = .BlackElo
            txtWhite.Text = .White
            txtEloWhite.Text = .WhiteElo
            txtEvent.Text = .Event_str
            nudRound.Value = .Round
            dtpDate.Text = .Date_str
            txtSite.Text = .Site
            rbCheck()
        End With
    End Sub

    Private Sub nudMin_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudMin.Enter
        nudMin.Select(0, 10)
    End Sub

    Private Sub nudSec_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudSec.Enter
        nudSec.Select(0, 10)
    End Sub

    Private Sub nudRound_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudRound.Enter
        nudRound.Select(0, 10)
    End Sub

End Class
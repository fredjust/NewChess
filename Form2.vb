Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.BackColor = ThemesColor(NumColorTheme).Ligh_highlight
        Label2.BackColor = ThemesColor(NumColorTheme).Dark_Square
        Label3.BackColor = ThemesColor(NumColorTheme).Dark_highlight
        Label4.BackColor = ThemesColor(NumColorTheme).Light_Square
    End Sub

    Private Sub Form2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim w As Integer



        Me.Width = Me.Height
        w = Me.ClientSize.Height

        With Label1
            .Top = 0
            .Left = 0
            .Width = w \ 2
            .Height = w \ 2
        End With
        With Label2
            .Top = 0
            .Left = w \ 2
            .Width = w \ 2
            .Height = w \ 2
        End With

        With Label3
            .Top = w \ 2
            .Left = 0
            .Width = w \ 2
            .Height = w \ 2
        End With

        With Label4
            .Top = w \ 2
            .Left = w \ 2
            .Width = w \ 2
            .Height = w \ 2
        End With
    End Sub
End Class
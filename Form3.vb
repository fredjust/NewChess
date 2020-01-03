Public Class Form3

    Dim resizeForm As Boolean
    Dim pos1 As Point
    Dim pos2 As Point

   
    
    'Change la transparance de la feuille avec les touches + et - du pavé numérique
    Private Sub Form3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case 107
                Me.Opacity += 0.05
            Case 109
                Me.Opacity -= 0.05
        End Select
        If Me.Opacity < 0.2 Then Me.Opacity = 0.2
        If Me.Opacity > 0.9 Then Me.Opacity = 0.9
        DrawLine()
    End Sub

    'commence le redimessionement de la fenetre
    Private Sub Form3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        If e.X > Me.Width * 0.875 And e.Y > Me.Height * 0.875 Then 'si on est dans la case a8
            resizeForm = True
        Else
            resizeForm = False
        End If

        pos1 = Cursor.Position

    End Sub

    'déplace la fenetre
    '4 fois moins vite si on appuie sur SHIFT
    Private Sub Form3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim NewPos As Point
        Dim Rcoeff As Byte

        If My.Computer.Keyboard.ShiftKeyDown Then
            Rcoeff = 4
        Else
            Rcoeff = 1
        End If

        If e.Button = Windows.Forms.MouseButtons.Left Then

            pos2 = Cursor.Position

            If resizeForm Then
                Me.Width += (pos2.X - pos1.X) / Rcoeff
            Else
                NewPos.X = Location.X + (pos2.X - pos1.X) / Rcoeff
                NewPos.Y = Location.Y + (pos2.Y - pos1.Y) / Rcoeff
                Location = NewPos
            End If

        End If

        pos1 = Cursor.Position

        DrawLine()

    End Sub


    Private Sub DrawLine()
        Dim gr As Graphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        Dim SquareWidth As Byte

        Me.Height = Me.Width

        SquareWidth = Me.Width \ 8

        Label1.Top = SquareWidth + 1
        Label1.Left = SquareWidth + 1
        Label1.Text = SquareWidth & "x" & SquareWidth

        lblClose.Left = SquareWidth * 8 - lblClose.Width - 1

        gr = Me.CreateGraphics()
        For l = 0 To 7
            gr.DrawLine(pen, l * SquareWidth, 0, l * SquareWidth, 8 * SquareWidth)
            gr.DrawLine(pen, 0, l * SquareWidth, 8 * SquareWidth, l * SquareWidth)
        Next

        gr.DrawLine(pen, 8 * SquareWidth - 1, 0, 8 * SquareWidth - 1, 8 * SquareWidth)
        gr.DrawLine(pen, 0, 8 * SquareWidth - 1, 8 * SquareWidth, 8 * SquareWidth - 1)

    End Sub


 
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblClose.Top = 1

        With rect_ChessBoardOnScreen
            Me.Location = .Location
            Me.Width = .Width
            Me.Height = .Height
        End With

    End Sub



    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        With rect_ChessBoardOnScreen
            .Width = Me.Width
            .Height = Me.Width
            .Location = Me.Location
        End With
        Cls_Ini.INIWrite(str_IniFile, "liscreen", "Width", Me.Width)
        Cls_Ini.INIWrite(str_IniFile, "liscreen", "left", rect_ChessBoardOnScreen.Location.X)
        Cls_Ini.INIWrite(str_IniFile, "liscreen", "top", rect_ChessBoardOnScreen.Location.Y)






        Me.Close()

        Form1.CheckBoardColor()

    End Sub

    Private Sub Form3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.Width = CInt(Me.Width / 8) * 8
        Me.Height = Me.Width
        DrawLine()
    End Sub

    
    Private Sub Form3_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        DrawLine()
    End Sub
End Class
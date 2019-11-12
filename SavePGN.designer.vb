<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPgnInfo
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtWhite = New System.Windows.Forms.TextBox()
        Me.txtBlack = New System.Windows.Forms.TextBox()
        Me.txtEvent = New System.Windows.Forms.TextBox()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.txtEloWhite = New System.Windows.Forms.TextBox()
        Me.txtEloBlack = New System.Windows.Forms.TextBox()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.lblSite = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.rbWhiteWin = New System.Windows.Forms.RadioButton()
        Me.rbDrawGame = New System.Windows.Forms.RadioButton()
        Me.rbBlackWin = New System.Windows.Forms.RadioButton()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.rbNoResult = New System.Windows.Forms.RadioButton()
        Me.lblTimeControl = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.nudMin = New System.Windows.Forms.NumericUpDown()
        Me.nudSec = New System.Windows.Forms.NumericUpDown()
        Me.nudRound = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtWhite
        '
        Me.txtWhite.Location = New System.Drawing.Point(56, 64)
        Me.txtWhite.MaxLength = 255
        Me.txtWhite.Name = "txtWhite"
        Me.txtWhite.Size = New System.Drawing.Size(182, 22)
        Me.txtWhite.TabIndex = 40
        Me.txtWhite.Text = "WHITE Player"
        '
        'txtBlack
        '
        Me.txtBlack.Location = New System.Drawing.Point(56, 90)
        Me.txtBlack.MaxLength = 255
        Me.txtBlack.Name = "txtBlack"
        Me.txtBlack.Size = New System.Drawing.Size(182, 22)
        Me.txtBlack.TabIndex = 60
        Me.txtBlack.Text = "BLACK Player"
        '
        'txtEvent
        '
        Me.txtEvent.Location = New System.Drawing.Point(56, 12)
        Me.txtEvent.MaxLength = 255
        Me.txtEvent.Name = "txtEvent"
        Me.txtEvent.Size = New System.Drawing.Size(91, 22)
        Me.txtEvent.TabIndex = 10
        Me.txtEvent.Text = "ARD Chess"
        '
        'lblWhite
        '
        Me.lblWhite.AutoSize = True
        Me.lblWhite.Location = New System.Drawing.Point(15, 67)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(44, 17)
        Me.lblWhite.TabIndex = 4
        Me.lblWhite.Text = "White"
        '
        'lblBlack
        '
        Me.lblBlack.AutoSize = True
        Me.lblBlack.Location = New System.Drawing.Point(15, 93)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(42, 17)
        Me.lblBlack.TabIndex = 5
        Me.lblBlack.Text = "Black"
        '
        'txtEloWhite
        '
        Me.txtEloWhite.Location = New System.Drawing.Point(244, 64)
        Me.txtEloWhite.MaxLength = 4
        Me.txtEloWhite.Name = "txtEloWhite"
        Me.txtEloWhite.Size = New System.Drawing.Size(31, 22)
        Me.txtEloWhite.TabIndex = 50
        Me.txtEloWhite.Text = "1399"
        Me.txtEloWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEloBlack
        '
        Me.txtEloBlack.Location = New System.Drawing.Point(244, 90)
        Me.txtEloBlack.MaxLength = 4
        Me.txtEloBlack.Name = "txtEloBlack"
        Me.txtEloBlack.Size = New System.Drawing.Size(31, 22)
        Me.txtEloBlack.TabIndex = 70
        Me.txtEloBlack.Text = "1399"
        Me.txtEloBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Location = New System.Drawing.Point(15, 15)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(44, 17)
        Me.lblEvent.TabIndex = 8
        Me.lblEvent.Text = "Event"
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.Location = New System.Drawing.Point(153, 15)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(32, 17)
        Me.lblSite.TabIndex = 9
        Me.lblSite.Text = "Site"
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(198, 12)
        Me.txtSite.MaxLength = 255
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(77, 22)
        Me.txtSite.TabIndex = 20
        Me.txtSite.Text = "Here"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(15, 44)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 17)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(56, 38)
        Me.dtpDate.MinDate = New Date(1973, 3, 15, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(91, 22)
        Me.dtpDate.TabIndex = 6
        Me.dtpDate.TabStop = False
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Location = New System.Drawing.Point(151, 40)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(50, 17)
        Me.lblRound.TabIndex = 13
        Me.lblRound.Text = "Round"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(15, 144)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(48, 17)
        Me.lblResult.TabIndex = 15
        Me.lblResult.Text = "Result"
        '
        'rbWhiteWin
        '
        Me.rbWhiteWin.AutoSize = True
        Me.rbWhiteWin.Location = New System.Drawing.Point(59, 142)
        Me.rbWhiteWin.Name = "rbWhiteWin"
        Me.rbWhiteWin.Size = New System.Drawing.Size(58, 21)
        Me.rbWhiteWin.TabIndex = 112
        Me.rbWhiteWin.Text = "1 - 0"
        Me.rbWhiteWin.UseVisualStyleBackColor = True
        '
        'rbDrawGame
        '
        Me.rbDrawGame.AutoSize = True
        Me.rbDrawGame.Location = New System.Drawing.Point(111, 142)
        Me.rbDrawGame.Name = "rbDrawGame"
        Me.rbDrawGame.Size = New System.Drawing.Size(49, 21)
        Me.rbDrawGame.TabIndex = 114
        Me.rbDrawGame.Text = "1/2"
        Me.rbDrawGame.UseVisualStyleBackColor = True
        '
        'rbBlackWin
        '
        Me.rbBlackWin.AutoSize = True
        Me.rbBlackWin.Location = New System.Drawing.Point(159, 142)
        Me.rbBlackWin.Name = "rbBlackWin"
        Me.rbBlackWin.Size = New System.Drawing.Size(58, 21)
        Me.rbBlackWin.TabIndex = 116
        Me.rbBlackWin.Text = "0 - 1"
        Me.rbBlackWin.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(200, 178)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 20
        Me.cmdOK.TabStop = False
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(18, 178)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.TabStop = False
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'rbNoResult
        '
        Me.rbNoResult.AutoSize = True
        Me.rbNoResult.Checked = True
        Me.rbNoResult.Location = New System.Drawing.Point(211, 142)
        Me.rbNoResult.Name = "rbNoResult"
        Me.rbNoResult.Size = New System.Drawing.Size(45, 21)
        Me.rbNoResult.TabIndex = 118
        Me.rbNoResult.TabStop = True
        Me.rbNoResult.Text = " ? "
        Me.rbNoResult.UseVisualStyleBackColor = True
        '
        'lblTimeControl
        '
        Me.lblTimeControl.AutoSize = True
        Me.lblTimeControl.Location = New System.Drawing.Point(15, 119)
        Me.lblTimeControl.Name = "lblTimeControl"
        Me.lblTimeControl.Size = New System.Drawing.Size(84, 17)
        Me.lblTimeControl.TabIndex = 24
        Me.lblTimeControl.Text = "TimeControl"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(151, 119)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(46, 17)
        Me.lblMin.TabIndex = 26
        Me.lblMin.Text = "min + "
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(251, 119)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(30, 17)
        Me.lblSec.TabIndex = 28
        Me.lblSec.Text = "sec"
        '
        'nudMin
        '
        Me.nudMin.Location = New System.Drawing.Point(84, 117)
        Me.nudMin.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(48, 22)
        Me.nudMin.TabIndex = 80
        Me.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMin.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudSec
        '
        Me.nudSec.Location = New System.Drawing.Point(190, 117)
        Me.nudSec.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSec.Name = "nudSec"
        Me.nudSec.Size = New System.Drawing.Size(48, 22)
        Me.nudSec.TabIndex = 90
        Me.nudSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudRound
        '
        Me.nudRound.Location = New System.Drawing.Point(198, 38)
        Me.nudRound.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudRound.Name = "nudRound"
        Me.nudRound.Size = New System.Drawing.Size(77, 22)
        Me.nudRound.TabIndex = 30
        Me.nudRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmPgnInfo
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(288, 211)
        Me.Controls.Add(Me.nudRound)
        Me.Controls.Add(Me.nudSec)
        Me.Controls.Add(Me.nudMin)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblTimeControl)
        Me.Controls.Add(Me.rbNoResult)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.rbBlackWin)
        Me.Controls.Add(Me.rbDrawGame)
        Me.Controls.Add(Me.rbWhiteWin)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblRound)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.lblSite)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.txtEloBlack)
        Me.Controls.Add(Me.txtEloWhite)
        Me.Controls.Add(Me.lblBlack)
        Me.Controls.Add(Me.lblWhite)
        Me.Controls.Add(Me.txtEvent)
        Me.Controls.Add(Me.txtBlack)
        Me.Controls.Add(Me.txtWhite)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmPgnInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PGN info"
        Me.TopMost = True
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWhite As System.Windows.Forms.TextBox
    Friend WithEvents txtBlack As System.Windows.Forms.TextBox
    Friend WithEvents txtEvent As System.Windows.Forms.TextBox
    Friend WithEvents lblWhite As System.Windows.Forms.Label
    Friend WithEvents lblBlack As System.Windows.Forms.Label
    Friend WithEvents txtEloWhite As System.Windows.Forms.TextBox
    Friend WithEvents txtEloBlack As System.Windows.Forms.TextBox
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents lblSite As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRound As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents rbWhiteWin As System.Windows.Forms.RadioButton
    Friend WithEvents rbDrawGame As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlackWin As System.Windows.Forms.RadioButton
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents rbNoResult As System.Windows.Forms.RadioButton
    Friend WithEvents lblTimeControl As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents nudMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRound As System.Windows.Forms.NumericUpDown
End Class

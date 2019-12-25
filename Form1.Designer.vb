<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lvMoves = New System.Windows.Forms.ListView()
        Me.chCoup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chWhite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBlack = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sst_move = New System.Windows.Forms.StatusStrip()
        Me.sbFormulaire = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuPartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNouvellePartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInformationPartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuSauvePartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JeJoueLesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoueBlancs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJoueNoirs = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckMoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThèmesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTheme1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTheme2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuTheme3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvRec = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sst_etat = New System.Windows.Forms.StatusStrip()
        Me.sbEnregistrement = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnu_LV = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOuvreDonnees = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSauveDonnees = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EffacerAprèsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEffaceDonnees = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrientationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRot90 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInvGD = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInvHB = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortSérieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCOM_Find = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCOM_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCOM_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCOM_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCOM_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCOM_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSerialInit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSerialClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tvPos = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuCopierFEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mneCopierPGN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuCoupProche = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVoirEtat = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRecalculer = New System.Windows.Forms.ToolStripMenuItem()
        Me.sst_TV = New System.Windows.Forms.StatusStrip()
        Me.pbArbre = New System.Windows.Forms.ToolStripProgressBar()
        Me.sbArbre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnu_TV = New System.Windows.Forms.MenuStrip()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEnPGN = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEffaceOrphelin = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCoupSuivant = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTous = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTousLimit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuReTous = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpSuivant = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpCouleur = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpCoulNoir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpCoulRouge = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpCoulVert = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpCoulBleu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVerifCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVerifCaseDepart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVerifCaseArrivee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVoirOrphelin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCalculComplet = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pnl_LV_move = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerLichess = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCheckMove = New System.Windows.Forms.Timer(Me.components)
        Me.pbReduire = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuInvBN = New System.Windows.Forms.ToolStripMenuItem()
        Me.sst_move.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.sst_etat.SuspendLayout()
        Me.mnu_LV.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.sst_TV.SuspendLayout()
        Me.mnu_TV.SuspendLayout()
        Me.pnl_LV_move.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pbReduire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvMoves
        '
        Me.lvMoves.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCoup, Me.chWhite, Me.chBlack})
        Me.lvMoves.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMoves.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMoves.FullRowSelect = True
        Me.lvMoves.GridLines = True
        Me.lvMoves.HideSelection = False
        Me.lvMoves.Location = New System.Drawing.Point(0, 24)
        Me.lvMoves.MultiSelect = False
        Me.lvMoves.Name = "lvMoves"
        Me.lvMoves.Size = New System.Drawing.Size(220, 531)
        Me.lvMoves.TabIndex = 18
        Me.lvMoves.UseCompatibleStateImageBehavior = False
        Me.lvMoves.View = System.Windows.Forms.View.Details
        '
        'chCoup
        '
        Me.chCoup.Text = "n°"
        Me.chCoup.Width = 40
        '
        'chWhite
        '
        Me.chWhite.Text = "Blancs"
        Me.chWhite.Width = 100
        '
        'chBlack
        '
        Me.chBlack.Text = "Noirs"
        Me.chBlack.Width = 100
        '
        'sst_move
        '
        Me.sst_move.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbFormulaire})
        Me.sst_move.Location = New System.Drawing.Point(0, 555)
        Me.sst_move.Name = "sst_move"
        Me.sst_move.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.sst_move.Size = New System.Drawing.Size(220, 22)
        Me.sst_move.TabIndex = 16
        Me.sst_move.Text = "StatusStrip2"
        '
        'sbFormulaire
        '
        Me.sbFormulaire.Name = "sbFormulaire"
        Me.sbFormulaire.Size = New System.Drawing.Size(119, 17)
        Me.sbFormulaire.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPartie, Me.EcranToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(220, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuPartie
        '
        Me.menuPartie.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNouvellePartie, Me.menuInformationPartie, Me.ToolStripMenuItem1, Me.menuSauvePartie})
        Me.menuPartie.Name = "menuPartie"
        Me.menuPartie.Size = New System.Drawing.Size(49, 20)
        Me.menuPartie.Text = "Partie"
        '
        'menuNouvellePartie
        '
        Me.menuNouvellePartie.Enabled = False
        Me.menuNouvellePartie.Name = "menuNouvellePartie"
        Me.menuNouvellePartie.Size = New System.Drawing.Size(142, 22)
        Me.menuNouvellePartie.Text = "Nouvelle"
        '
        'menuInformationPartie
        '
        Me.menuInformationPartie.Name = "menuInformationPartie"
        Me.menuInformationPartie.Size = New System.Drawing.Size(142, 22)
        Me.menuInformationPartie.Text = "Informations"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(139, 6)
        '
        'menuSauvePartie
        '
        Me.menuSauvePartie.Name = "menuSauvePartie"
        Me.menuSauvePartie.Size = New System.Drawing.Size(142, 22)
        Me.menuSauvePartie.Text = "Sauvegarder"
        '
        'EcranToolStripMenuItem
        '
        Me.EcranToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigToolStripMenuItem, Me.JeJoueLesToolStripMenuItem, Me.CheckMoveToolStripMenuItem, Me.ThèmesToolStripMenuItem})
        Me.EcranToolStripMenuItem.Name = "EcranToolStripMenuItem"
        Me.EcranToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.EcranToolStripMenuItem.Text = "Adversaire"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConfigToolStripMenuItem.Text = "Configurer"
        '
        'JeJoueLesToolStripMenuItem
        '
        Me.JeJoueLesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuJoueBlancs, Me.menuJoueNoirs})
        Me.JeJoueLesToolStripMenuItem.Name = "JeJoueLesToolStripMenuItem"
        Me.JeJoueLesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JeJoueLesToolStripMenuItem.Text = "Je joue les ..."
        '
        'menuJoueBlancs
        '
        Me.menuJoueBlancs.Checked = True
        Me.menuJoueBlancs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuJoueBlancs.Name = "menuJoueBlancs"
        Me.menuJoueBlancs.Size = New System.Drawing.Size(152, 22)
        Me.menuJoueBlancs.Text = "Blancs"
        '
        'menuJoueNoirs
        '
        Me.menuJoueNoirs.Name = "menuJoueNoirs"
        Me.menuJoueNoirs.Size = New System.Drawing.Size(152, 22)
        Me.menuJoueNoirs.Text = "Noirs"
        '
        'CheckMoveToolStripMenuItem
        '
        Me.CheckMoveToolStripMenuItem.Name = "CheckMoveToolStripMenuItem"
        Me.CheckMoveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CheckMoveToolStripMenuItem.Text = "Activer"
        '
        'ThèmesToolStripMenuItem
        '
        Me.ThèmesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuTheme1, Me.menuTheme2, Me.ToolStripMenuItem6, Me.menuTheme3})
        Me.ThèmesToolStripMenuItem.Name = "ThèmesToolStripMenuItem"
        Me.ThèmesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThèmesToolStripMenuItem.Text = "Thèmes"
        '
        'menuTheme1
        '
        Me.menuTheme1.Name = "menuTheme1"
        Me.menuTheme1.Size = New System.Drawing.Size(169, 22)
        Me.menuTheme1.Text = "Lichess défaut"
        '
        'menuTheme2
        '
        Me.menuTheme2.Name = "menuTheme2"
        Me.menuTheme2.Size = New System.Drawing.Size(169, 22)
        Me.menuTheme2.Text = "Lichess bleu"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(166, 6)
        '
        'menuTheme3
        '
        Me.menuTheme3.Name = "menuTheme3"
        Me.menuTheme3.Size = New System.Drawing.Size(169, 22)
        Me.menuTheme3.Text = "Chess.com défaut"
        '
        'lvRec
        '
        Me.lvRec.BackColor = System.Drawing.Color.Black
        Me.lvRec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRec.ForeColor = System.Drawing.Color.White
        Me.lvRec.FullRowSelect = True
        Me.lvRec.GridLines = True
        Me.lvRec.HideSelection = False
        Me.lvRec.Location = New System.Drawing.Point(20, 55)
        Me.lvRec.Name = "lvRec"
        Me.lvRec.Size = New System.Drawing.Size(337, 393)
        Me.lvRec.TabIndex = 15
        Me.lvRec.UseCompatibleStateImageBehavior = False
        Me.lvRec.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "N°"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Rec"
        Me.ColumnHeader2.Width = 40
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Off"
        Me.ColumnHeader4.Width = 30
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "On"
        Me.ColumnHeader5.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nb"
        Me.ColumnHeader7.Width = 30
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "FEN"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Move"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Diff"
        '
        'sst_etat
        '
        Me.sst_etat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbEnregistrement})
        Me.sst_etat.Location = New System.Drawing.Point(0, 555)
        Me.sst_etat.Name = "sst_etat"
        Me.sst_etat.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.sst_etat.Size = New System.Drawing.Size(419, 22)
        Me.sst_etat.TabIndex = 7
        Me.sst_etat.Text = "StatusStrip3"
        '
        'sbEnregistrement
        '
        Me.sbEnregistrement.Name = "sbEnregistrement"
        Me.sbEnregistrement.Size = New System.Drawing.Size(119, 17)
        Me.sbEnregistrement.Text = "ToolStripStatusLabel2"
        '
        'mnu_LV
        '
        Me.mnu_LV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.OrientationToolStripMenuItem, Me.PortSérieToolStripMenuItem})
        Me.mnu_LV.Location = New System.Drawing.Point(0, 0)
        Me.mnu_LV.Name = "mnu_LV"
        Me.mnu_LV.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnu_LV.Size = New System.Drawing.Size(419, 24)
        Me.mnu_LV.TabIndex = 6
        Me.mnu_LV.Text = "MenuStrip2"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOuvreDonnees, Me.menuSauveDonnees, Me.ActualiserToolStripMenuItem, Me.ToolStripMenuItem3, Me.EffacerAprèsToolStripMenuItem, Me.menuEffaceDonnees})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.FichierToolStripMenuItem.Text = "Données"
        '
        'menuOuvreDonnees
        '
        Me.menuOuvreDonnees.Name = "menuOuvreDonnees"
        Me.menuOuvreDonnees.Size = New System.Drawing.Size(160, 22)
        Me.menuOuvreDonnees.Text = "Ouvrir un fichier"
        '
        'menuSauveDonnees
        '
        Me.menuSauveDonnees.Enabled = False
        Me.menuSauveDonnees.Name = "menuSauveDonnees"
        Me.menuSauveDonnees.Size = New System.Drawing.Size(160, 22)
        Me.menuSauveDonnees.Text = "Sauvegarder"
        '
        'ActualiserToolStripMenuItem
        '
        Me.ActualiserToolStripMenuItem.Name = "ActualiserToolStripMenuItem"
        Me.ActualiserToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ActualiserToolStripMenuItem.Text = "Actualiser"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(157, 6)
        '
        'EffacerAprèsToolStripMenuItem
        '
        Me.EffacerAprèsToolStripMenuItem.Name = "EffacerAprèsToolStripMenuItem"
        Me.EffacerAprèsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EffacerAprèsToolStripMenuItem.Text = "Effacer après"
        '
        'menuEffaceDonnees
        '
        Me.menuEffaceDonnees.Enabled = False
        Me.menuEffaceDonnees.Name = "menuEffaceDonnees"
        Me.menuEffaceDonnees.Size = New System.Drawing.Size(160, 22)
        Me.menuEffaceDonnees.Text = "Effacer tout"
        '
        'OrientationToolStripMenuItem
        '
        Me.OrientationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRot90, Me.menuInvGD, Me.menuInvHB, Me.menuInvBN})
        Me.OrientationToolStripMenuItem.Name = "OrientationToolStripMenuItem"
        Me.OrientationToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.OrientationToolStripMenuItem.Text = "Inversions"
        '
        'menuRot90
        '
        Me.menuRot90.Name = "menuRot90"
        Me.menuRot90.Size = New System.Drawing.Size(153, 22)
        Me.menuRot90.Text = "Ligne/Colonne"
        '
        'menuInvGD
        '
        Me.menuInvGD.Name = "menuInvGD"
        Me.menuInvGD.Size = New System.Drawing.Size(153, 22)
        Me.menuInvGD.Text = "Gauche/Droite"
        '
        'menuInvHB
        '
        Me.menuInvHB.Name = "menuInvHB"
        Me.menuInvHB.Size = New System.Drawing.Size(153, 22)
        Me.menuInvHB.Text = "Haut/Bas"
        '
        'PortSérieToolStripMenuItem
        '
        Me.PortSérieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCOM_Find, Me.menuSerialInit, Me.menuSerialClose})
        Me.PortSérieToolStripMenuItem.Name = "PortSérieToolStripMenuItem"
        Me.PortSérieToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PortSérieToolStripMenuItem.Text = "Port Série"
        '
        'menuCOM_Find
        '
        Me.menuCOM_Find.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCOM_1, Me.menuCOM_2, Me.menuCOM_3, Me.menuCOM_4, Me.menuCOM_5})
        Me.menuCOM_Find.Name = "menuCOM_Find"
        Me.menuCOM_Find.Size = New System.Drawing.Size(122, 22)
        Me.menuCOM_Find.Text = "Chercher"
        '
        'menuCOM_1
        '
        Me.menuCOM_1.Name = "menuCOM_1"
        Me.menuCOM_1.Size = New System.Drawing.Size(102, 22)
        Me.menuCOM_1.Text = "COM"
        Me.menuCOM_1.Visible = False
        '
        'menuCOM_2
        '
        Me.menuCOM_2.Name = "menuCOM_2"
        Me.menuCOM_2.Size = New System.Drawing.Size(102, 22)
        Me.menuCOM_2.Text = "COM"
        Me.menuCOM_2.Visible = False
        '
        'menuCOM_3
        '
        Me.menuCOM_3.Name = "menuCOM_3"
        Me.menuCOM_3.Size = New System.Drawing.Size(102, 22)
        Me.menuCOM_3.Text = "COM"
        Me.menuCOM_3.Visible = False
        '
        'menuCOM_4
        '
        Me.menuCOM_4.Name = "menuCOM_4"
        Me.menuCOM_4.Size = New System.Drawing.Size(102, 22)
        Me.menuCOM_4.Text = "COM"
        Me.menuCOM_4.Visible = False
        '
        'menuCOM_5
        '
        Me.menuCOM_5.Name = "menuCOM_5"
        Me.menuCOM_5.Size = New System.Drawing.Size(102, 22)
        Me.menuCOM_5.Text = "COM"
        Me.menuCOM_5.Visible = False
        '
        'menuSerialInit
        '
        Me.menuSerialInit.Enabled = False
        Me.menuSerialInit.Name = "menuSerialInit"
        Me.menuSerialInit.Size = New System.Drawing.Size(122, 22)
        Me.menuSerialInit.Text = "Initialiser"
        '
        'menuSerialClose
        '
        Me.menuSerialClose.Enabled = False
        Me.menuSerialClose.Name = "menuSerialClose"
        Me.menuSerialClose.Size = New System.Drawing.Size(122, 22)
        Me.menuSerialClose.Text = "Fermer"
        '
        'tvPos
        '
        Me.tvPos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvPos.HideSelection = False
        Me.tvPos.Indent = 10
        Me.tvPos.Location = New System.Drawing.Point(43, 26)
        Me.tvPos.Margin = New System.Windows.Forms.Padding(2)
        Me.tvPos.Name = "tvPos"
        Me.tvPos.Size = New System.Drawing.Size(323, 527)
        Me.tvPos.TabIndex = 15
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCopierFEN, Me.mneCopierPGN, Me.ToolStripMenuItem5, Me.menuCoupProche, Me.menuVoirEtat, Me.menuRecalculer})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 120)
        '
        'menuCopierFEN
        '
        Me.menuCopierFEN.Name = "menuCopierFEN"
        Me.menuCopierFEN.Size = New System.Drawing.Size(143, 22)
        Me.menuCopierFEN.Text = "Copier FEN"
        '
        'mneCopierPGN
        '
        Me.mneCopierPGN.Name = "mneCopierPGN"
        Me.mneCopierPGN.Size = New System.Drawing.Size(143, 22)
        Me.mneCopierPGN.Text = "Copier PGN"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(140, 6)
        '
        'menuCoupProche
        '
        Me.menuCoupProche.Name = "menuCoupProche"
        Me.menuCoupProche.Size = New System.Drawing.Size(143, 22)
        Me.menuCoupProche.Text = "Coup Proche"
        '
        'menuVoirEtat
        '
        Me.menuVoirEtat.Name = "menuVoirEtat"
        Me.menuVoirEtat.Size = New System.Drawing.Size(143, 22)
        Me.menuVoirEtat.Text = "Voir Etat"
        '
        'menuRecalculer
        '
        Me.menuRecalculer.Name = "menuRecalculer"
        Me.menuRecalculer.Size = New System.Drawing.Size(143, 22)
        Me.menuRecalculer.Text = "Recalculer"
        '
        'sst_TV
        '
        Me.sst_TV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbArbre, Me.sbArbre})
        Me.sst_TV.Location = New System.Drawing.Point(0, 555)
        Me.sst_TV.Name = "sst_TV"
        Me.sst_TV.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.sst_TV.Size = New System.Drawing.Size(445, 22)
        Me.sst_TV.TabIndex = 2
        Me.sst_TV.Text = "StatusStrip1"
        '
        'pbArbre
        '
        Me.pbArbre.Name = "pbArbre"
        Me.pbArbre.Size = New System.Drawing.Size(100, 16)
        '
        'sbArbre
        '
        Me.sbArbre.Name = "sbArbre"
        Me.sbArbre.Size = New System.Drawing.Size(48, 17)
        Me.sbArbre.Text = "sbArbre"
        '
        'mnu_TV
        '
        Me.mnu_TV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PositionToolStripMenuItem, Me.CoupsToolStripMenuItem, Me.mnuOptions})
        Me.mnu_TV.Location = New System.Drawing.Point(0, 0)
        Me.mnu_TV.Name = "mnu_TV"
        Me.mnu_TV.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnu_TV.Size = New System.Drawing.Size(445, 24)
        Me.mnu_TV.TabIndex = 1
        Me.mnu_TV.Text = "MenuStrip3"
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEnPGN, Me.menuEffaceOrphelin})
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PositionToolStripMenuItem.Text = "Position"
        '
        'menuEnPGN
        '
        Me.menuEnPGN.Enabled = False
        Me.menuEnPGN.Name = "menuEnPGN"
        Me.menuEnPGN.Size = New System.Drawing.Size(179, 22)
        Me.menuEnPGN.Text = "Convertir en PGN"
        '
        'menuEffaceOrphelin
        '
        Me.menuEffaceOrphelin.Enabled = False
        Me.menuEffaceOrphelin.Name = "menuEffaceOrphelin"
        Me.menuEffaceOrphelin.Size = New System.Drawing.Size(179, 22)
        Me.menuEffaceOrphelin.Text = "Effacer les orphelins"
        '
        'CoupsToolStripMenuItem
        '
        Me.CoupsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCoupSuivant, Me.menuTous, Me.menuTousLimit, Me.ToolStripMenuItem4, Me.mnuReTous, Me.ToolStripMenuItem2, Me.menuClear})
        Me.CoupsToolStripMenuItem.Name = "CoupsToolStripMenuItem"
        Me.CoupsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.CoupsToolStripMenuItem.Text = "Coups"
        '
        'menuCoupSuivant
        '
        Me.menuCoupSuivant.Name = "menuCoupSuivant"
        Me.menuCoupSuivant.Size = New System.Drawing.Size(146, 22)
        Me.menuCoupSuivant.Text = "Suivant"
        '
        'menuTous
        '
        Me.menuTous.Name = "menuTous"
        Me.menuTous.Size = New System.Drawing.Size(146, 22)
        Me.menuTous.Text = "Tous"
        '
        'menuTousLimit
        '
        Me.menuTousLimit.Name = "menuTousLimit"
        Me.menuTousLimit.Size = New System.Drawing.Size(146, 22)
        Me.menuTousLimit.Text = "Tous => ligne"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(143, 6)
        '
        'mnuReTous
        '
        Me.mnuReTous.Name = "mnuReTous"
        Me.mnuReTous.Size = New System.Drawing.Size(146, 22)
        Me.mnuReTous.Text = "RE Tous"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(143, 6)
        '
        'menuClear
        '
        Me.menuClear.Name = "menuClear"
        Me.menuClear.Size = New System.Drawing.Size(146, 22)
        Me.menuClear.Text = "CLEAR"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpSuivant, Me.mnuOpCouleur, Me.mnuVerifCase, Me.mnuVoirOrphelin, Me.menuCalculComplet})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(61, 20)
        Me.mnuOptions.Text = "Options"
        '
        'mnuOpSuivant
        '
        Me.mnuOpSuivant.Name = "mnuOpSuivant"
        Me.mnuOpSuivant.Size = New System.Drawing.Size(160, 22)
        Me.mnuOpSuivant.Text = "Nb Suivants (30)"
        '
        'mnuOpCouleur
        '
        Me.mnuOpCouleur.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpCoulNoir, Me.mnuOpCoulRouge, Me.mnuOpCoulVert, Me.mnuOpCoulBleu})
        Me.mnuOpCouleur.Name = "mnuOpCouleur"
        Me.mnuOpCouleur.Size = New System.Drawing.Size(160, 22)
        Me.mnuOpCouleur.Text = "Couleur"
        '
        'mnuOpCoulNoir
        '
        Me.mnuOpCoulNoir.Checked = True
        Me.mnuOpCoulNoir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuOpCoulNoir.Name = "mnuOpCoulNoir"
        Me.mnuOpCoulNoir.Size = New System.Drawing.Size(108, 22)
        Me.mnuOpCoulNoir.Text = "Noir"
        '
        'mnuOpCoulRouge
        '
        Me.mnuOpCoulRouge.Name = "mnuOpCoulRouge"
        Me.mnuOpCoulRouge.Size = New System.Drawing.Size(108, 22)
        Me.mnuOpCoulRouge.Text = "Rouge"
        '
        'mnuOpCoulVert
        '
        Me.mnuOpCoulVert.Name = "mnuOpCoulVert"
        Me.mnuOpCoulVert.Size = New System.Drawing.Size(108, 22)
        Me.mnuOpCoulVert.Text = "Vert"
        '
        'mnuOpCoulBleu
        '
        Me.mnuOpCoulBleu.Name = "mnuOpCoulBleu"
        Me.mnuOpCoulBleu.Size = New System.Drawing.Size(108, 22)
        Me.mnuOpCoulBleu.Text = "Bleu"
        '
        'mnuVerifCase
        '
        Me.mnuVerifCase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVerifCaseDepart, Me.mnuVerifCaseArrivee})
        Me.mnuVerifCase.Name = "mnuVerifCase"
        Me.mnuVerifCase.Size = New System.Drawing.Size(160, 22)
        Me.mnuVerifCase.Text = "Vérifier Case"
        '
        'mnuVerifCaseDepart
        '
        Me.mnuVerifCaseDepart.Checked = True
        Me.mnuVerifCaseDepart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuVerifCaseDepart.Name = "mnuVerifCaseDepart"
        Me.mnuVerifCaseDepart.Size = New System.Drawing.Size(111, 22)
        Me.mnuVerifCaseDepart.Text = "Départ"
        '
        'mnuVerifCaseArrivee
        '
        Me.mnuVerifCaseArrivee.Checked = True
        Me.mnuVerifCaseArrivee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuVerifCaseArrivee.Name = "mnuVerifCaseArrivee"
        Me.mnuVerifCaseArrivee.Size = New System.Drawing.Size(111, 22)
        Me.mnuVerifCaseArrivee.Text = "Arrivée"
        '
        'mnuVoirOrphelin
        '
        Me.mnuVoirOrphelin.Name = "mnuVoirOrphelin"
        Me.mnuVoirOrphelin.Size = New System.Drawing.Size(160, 22)
        Me.mnuVoirOrphelin.Text = "Voir Orphelin"
        '
        'menuCalculComplet
        '
        Me.menuCalculComplet.Checked = True
        Me.menuCalculComplet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuCalculComplet.Name = "menuCalculComplet"
        Me.menuCalculComplet.Size = New System.Drawing.Size(160, 22)
        Me.menuCalculComplet.Text = "Calcul Complet"
        '
        'pnl_LV_move
        '
        Me.pnl_LV_move.Controls.Add(Me.lvMoves)
        Me.pnl_LV_move.Controls.Add(Me.sst_move)
        Me.pnl_LV_move.Controls.Add(Me.MenuStrip1)
        Me.pnl_LV_move.Location = New System.Drawing.Point(471, 13)
        Me.pnl_LV_move.Name = "pnl_LV_move"
        Me.pnl_LV_move.Size = New System.Drawing.Size(220, 577)
        Me.pnl_LV_move.TabIndex = 16
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(697, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.mnu_LV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvRec)
        Me.SplitContainer1.Panel1.Controls.Add(Me.sst_etat)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.mnu_TV)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tvPos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.sst_TV)
        Me.SplitContainer1.Size = New System.Drawing.Size(868, 577)
        Me.SplitContainer1.SplitterDistance = 419
        Me.SplitContainer1.TabIndex = 17
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'TimerLichess
        '
        '
        'TimerCheckMove
        '
        Me.TimerCheckMove.Enabled = True
        Me.TimerCheckMove.Interval = 1000
        '
        'pbReduire
        '
        Me.pbReduire.BackColor = System.Drawing.SystemColors.Control
        Me.pbReduire.BackgroundImage = CType(resources.GetObject("pbReduire.BackgroundImage"), System.Drawing.Image)
        Me.pbReduire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbReduire.Location = New System.Drawing.Point(1614, 13)
        Me.pbReduire.Name = "pbReduire"
        Me.pbReduire.Size = New System.Drawing.Size(26, 17)
        Me.pbReduire.TabIndex = 13
        Me.pbReduire.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 447)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'menuInvBN
        '
        Me.menuInvBN.Name = "menuInvBN"
        Me.menuInvBN.Size = New System.Drawing.Size(153, 22)
        Me.menuInvBN.Text = "Blancs/Noirs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1640, 665)
        Me.Controls.Add(Me.pbReduire)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnl_LV_move)
        Me.MainMenuStrip = Me.mnu_LV
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "ChessboARDuino v2"
        Me.sst_move.ResumeLayout(False)
        Me.sst_move.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sst_etat.ResumeLayout(False)
        Me.sst_etat.PerformLayout()
        Me.mnu_LV.ResumeLayout(False)
        Me.mnu_LV.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.sst_TV.ResumeLayout(False)
        Me.sst_TV.PerformLayout()
        Me.mnu_TV.ResumeLayout(False)
        Me.mnu_TV.PerformLayout()
        Me.pnl_LV_move.ResumeLayout(False)
        Me.pnl_LV_move.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pbReduire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbReduire As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuPartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNouvellePartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuInformationPartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSauvePartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_LV As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOuvreDonnees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSauveDonnees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuEffaceDonnees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortSérieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCOM_Find As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSerialInit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSerialClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_TV As System.Windows.Forms.MenuStrip
    Friend WithEvents PositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnPGN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEffaceOrphelin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCoupSuivant As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sst_TV As System.Windows.Forms.StatusStrip
    Friend WithEvents sbArbre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tvPos As System.Windows.Forms.TreeView
    Friend WithEvents lvMoves As System.Windows.Forms.ListView
    Friend WithEvents chCoup As System.Windows.Forms.ColumnHeader
    Friend WithEvents chWhite As System.Windows.Forms.ColumnHeader
    Friend WithEvents chBlack As System.Windows.Forms.ColumnHeader
    Friend WithEvents sst_move As System.Windows.Forms.StatusStrip
    Friend WithEvents sbFormulaire As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lvRec As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents sst_etat As System.Windows.Forms.StatusStrip
    Friend WithEvents sbEnregistrement As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuCopierFEN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCoupProche As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuVoirEtat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTousLimit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRecalculer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpSuivant As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpCouleur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpCoulNoir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpCoulRouge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpCoulVert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpCoulBleu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVerifCase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVerifCaseDepart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVerifCaseArrivee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReTous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuVoirOrphelin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mneCopierPGN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pbArbre As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents OrientationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInvGD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInvHB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRot90 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCalculComplet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_LV_move As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuCOM_1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCOM_2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCOM_3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCOM_4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCOM_5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ActualiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EcranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckMoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerLichess As System.Windows.Forms.Timer
    Friend WithEvents TimerCheckMove As System.Windows.Forms.Timer
    Friend WithEvents EffacerAprèsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JeJoueLesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoueBlancs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJoueNoirs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThèmesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTheme1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTheme2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuTheme3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInvBN As System.Windows.Forms.ToolStripMenuItem

End Class

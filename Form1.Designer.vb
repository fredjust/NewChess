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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvMoves = New System.Windows.Forms.ListView()
        Me.chCoup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chWhite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBlack = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.sbFormulaire = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuPartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNouvellePartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInformationPartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuSauvePartie = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNumero = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNum1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNum2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNum3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvRec = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.sbEnregistrement = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOuvreDonnees = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSauveDonnees = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEnBoucle = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEffaceDonnees = New System.Windows.Forms.ToolStripMenuItem()
        Me.FréquenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu1sec = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu3ec = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu5sec = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu10sec = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu30sec = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrientationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRot90 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInvGD = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInvHB = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortSérieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InitialiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tvPos = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuCopierFEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mneCopierPGN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuCoupProche = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVoirEtat = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRecalculer = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pbArbre = New System.Windows.Forms.ToolStripProgressBar()
        Me.sbArbre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbReduire = New System.Windows.Forms.PictureBox()
        Me.TimerOpenFile = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReduire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(564, 25)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(364, 455)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvMoves)
        Me.TabPage1.Controls.Add(Me.StatusStrip2)
        Me.TabPage1.Controls.Add(Me.MenuStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(356, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Formulaire"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvMoves
        '
        Me.lvMoves.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCoup, Me.chWhite, Me.chBlack})
        Me.lvMoves.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvMoves.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMoves.FullRowSelect = True
        Me.lvMoves.GridLines = True
        Me.lvMoves.HideSelection = False
        Me.lvMoves.Location = New System.Drawing.Point(2, 26)
        Me.lvMoves.MultiSelect = False
        Me.lvMoves.Name = "lvMoves"
        Me.lvMoves.Size = New System.Drawing.Size(288, 379)
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
        Me.chWhite.Width = 164
        '
        'chBlack
        '
        Me.chBlack.Text = "Noirs"
        Me.chBlack.Width = 140
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbFormulaire})
        Me.StatusStrip2.Location = New System.Drawing.Point(2, 405)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip2.Size = New System.Drawing.Size(352, 22)
        Me.StatusStrip2.TabIndex = 16
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'sbFormulaire
        '
        Me.sbFormulaire.Name = "sbFormulaire"
        Me.sbFormulaire.Size = New System.Drawing.Size(119, 17)
        Me.sbFormulaire.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPartie, Me.menuNumero})
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(352, 24)
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
        'menuNumero
        '
        Me.menuNumero.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNum1, Me.menuNum2, Me.menuNum3})
        Me.menuNumero.Name = "menuNumero"
        Me.menuNumero.Size = New System.Drawing.Size(63, 20)
        Me.menuNumero.Text = "Numéro"
        '
        'menuNum1
        '
        Me.menuNum1.Name = "menuNum1"
        Me.menuNum1.Size = New System.Drawing.Size(80, 22)
        Me.menuNum1.Text = "1"
        '
        'menuNum2
        '
        Me.menuNum2.Name = "menuNum2"
        Me.menuNum2.Size = New System.Drawing.Size(80, 22)
        Me.menuNum2.Text = "2"
        '
        'menuNum3
        '
        Me.menuNum3.Name = "menuNum3"
        Me.menuNum3.Size = New System.Drawing.Size(80, 22)
        Me.menuNum3.Text = "3"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvRec)
        Me.TabPage2.Controls.Add(Me.StatusStrip3)
        Me.TabPage2.Controls.Add(Me.MenuStrip2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(356, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Enregistrement"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvRec
        '
        Me.lvRec.BackColor = System.Drawing.Color.Black
        Me.lvRec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRec.ForeColor = System.Drawing.Color.White
        Me.lvRec.FullRowSelect = True
        Me.lvRec.GridLines = True
        Me.lvRec.HideSelection = False
        Me.lvRec.Location = New System.Drawing.Point(2, 26)
        Me.lvRec.Name = "lvRec"
        Me.lvRec.Size = New System.Drawing.Size(352, 379)
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
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
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
        '
        'StatusStrip3
        '
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbEnregistrement})
        Me.StatusStrip3.Location = New System.Drawing.Point(2, 405)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip3.Size = New System.Drawing.Size(352, 22)
        Me.StatusStrip3.TabIndex = 7
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'sbEnregistrement
        '
        Me.sbEnregistrement.Name = "sbEnregistrement"
        Me.sbEnregistrement.Size = New System.Drawing.Size(119, 17)
        Me.sbEnregistrement.Text = "ToolStripStatusLabel2"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.OrientationToolStripMenuItem, Me.PortSérieToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(2, 2)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(352, 24)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOuvreDonnees, Me.menuSauveDonnees, Me.ToolStripMenuItem3, Me.menuEnBoucle, Me.menuEffaceDonnees, Me.FréquenceToolStripMenuItem})
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
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(157, 6)
        '
        'menuEnBoucle
        '
        Me.menuEnBoucle.Name = "menuEnBoucle"
        Me.menuEnBoucle.Size = New System.Drawing.Size(160, 22)
        Me.menuEnBoucle.Text = "Boucler"
        '
        'menuEffaceDonnees
        '
        Me.menuEffaceDonnees.Enabled = False
        Me.menuEffaceDonnees.Name = "menuEffaceDonnees"
        Me.menuEffaceDonnees.Size = New System.Drawing.Size(160, 22)
        Me.menuEffaceDonnees.Text = "Effacer tout"
        '
        'FréquenceToolStripMenuItem
        '
        Me.FréquenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu1sec, Me.menu3ec, Me.menu5sec, Me.menu10sec, Me.menu30sec})
        Me.FréquenceToolStripMenuItem.Name = "FréquenceToolStripMenuItem"
        Me.FréquenceToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FréquenceToolStripMenuItem.Text = "Fréquence"
        '
        'menu1sec
        '
        Me.menu1sec.Name = "menu1sec"
        Me.menu1sec.Size = New System.Drawing.Size(106, 22)
        Me.menu1sec.Text = "1 sec"
        '
        'menu3ec
        '
        Me.menu3ec.Name = "menu3ec"
        Me.menu3ec.Size = New System.Drawing.Size(106, 22)
        Me.menu3ec.Text = "3 sec"
        '
        'menu5sec
        '
        Me.menu5sec.Name = "menu5sec"
        Me.menu5sec.Size = New System.Drawing.Size(106, 22)
        Me.menu5sec.Text = "5 sec"
        '
        'menu10sec
        '
        Me.menu10sec.Name = "menu10sec"
        Me.menu10sec.Size = New System.Drawing.Size(106, 22)
        Me.menu10sec.Text = "10 sec"
        '
        'menu30sec
        '
        Me.menu30sec.Name = "menu30sec"
        Me.menu30sec.Size = New System.Drawing.Size(106, 22)
        Me.menu30sec.Text = "30 sec"
        '
        'OrientationToolStripMenuItem
        '
        Me.OrientationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRot90, Me.menuInvGD, Me.menuInvHB})
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
        Me.PortSérieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChercherToolStripMenuItem, Me.InitialiserToolStripMenuItem, Me.FermerToolStripMenuItem})
        Me.PortSérieToolStripMenuItem.Name = "PortSérieToolStripMenuItem"
        Me.PortSérieToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PortSérieToolStripMenuItem.Text = "Port Série"
        '
        'ChercherToolStripMenuItem
        '
        Me.ChercherToolStripMenuItem.Enabled = False
        Me.ChercherToolStripMenuItem.Name = "ChercherToolStripMenuItem"
        Me.ChercherToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ChercherToolStripMenuItem.Text = "Chercher"
        '
        'InitialiserToolStripMenuItem
        '
        Me.InitialiserToolStripMenuItem.Enabled = False
        Me.InitialiserToolStripMenuItem.Name = "InitialiserToolStripMenuItem"
        Me.InitialiserToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.InitialiserToolStripMenuItem.Text = "Initialiser"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Enabled = False
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.tvPos)
        Me.TabPage3.Controls.Add(Me.StatusStrip1)
        Me.TabPage3.Controls.Add(Me.MenuStrip3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(356, 429)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Arbre"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tvPos
        '
        Me.tvPos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvPos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvPos.HideSelection = False
        Me.tvPos.Indent = 10
        Me.tvPos.Location = New System.Drawing.Point(0, 24)
        Me.tvPos.Margin = New System.Windows.Forms.Padding(2)
        Me.tvPos.Name = "tvPos"
        Me.tvPos.Size = New System.Drawing.Size(356, 383)
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbArbre, Me.sbArbre})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 407)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(356, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
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
        'MenuStrip3
        '
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PositionToolStripMenuItem, Me.CoupsToolStripMenuItem, Me.mnuOptions})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(356, 24)
        Me.MenuStrip3.TabIndex = 1
        Me.MenuStrip3.Text = "MenuStrip3"
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
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 447)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pbReduire
        '
        Me.pbReduire.BackColor = System.Drawing.SystemColors.Control
        Me.pbReduire.BackgroundImage = CType(resources.GetObject("pbReduire.BackgroundImage"), System.Drawing.Image)
        Me.pbReduire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbReduire.Location = New System.Drawing.Point(944, 11)
        Me.pbReduire.Name = "pbReduire"
        Me.pbReduire.Size = New System.Drawing.Size(26, 17)
        Me.pbReduire.TabIndex = 13
        Me.pbReduire.TabStop = False
        '
        'TimerOpenFile
        '
        Me.TimerOpenFile.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1639, 618)
        Me.Controls.Add(Me.pbReduire)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "ChessboARDuino v2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReduire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbReduire As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuPartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNouvellePartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuInformationPartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSauvePartie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOuvreDonnees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSauveDonnees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuEffaceDonnees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortSérieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChercherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InitialiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents PositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnPGN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEffaceOrphelin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCoupSuivant As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sbArbre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tvPos As System.Windows.Forms.TreeView
    Friend WithEvents lvMoves As System.Windows.Forms.ListView
    Friend WithEvents chCoup As System.Windows.Forms.ColumnHeader
    Friend WithEvents chWhite As System.Windows.Forms.ColumnHeader
    Friend WithEvents chBlack As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents sbFormulaire As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lvRec As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
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
    Friend WithEvents menuEnBoucle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerOpenFile As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pbArbre As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents FréquenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu1sec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu3ec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu5sec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu10sec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu30sec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrientationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInvGD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInvHB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRot90 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNumero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNum1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNum2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNum3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCalculComplet As System.Windows.Forms.ToolStripMenuItem

End Class

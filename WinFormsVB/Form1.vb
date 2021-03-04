
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

'Namespace IE_WinForms
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
		Private WithEvents FileNew As System.Windows.Forms.MenuItem
		Private WithEvents FileClose As System.Windows.Forms.MenuItem
		Private WithEvents FileExport As System.Windows.Forms.MenuItem
		Private WithEvents FileImport As System.Windows.Forms.MenuItem
		Private WithEvents ImportBRep As System.Windows.Forms.MenuItem
		Private WithEvents ExportImage As System.Windows.Forms.MenuItem
		Private WithEvents File As System.Windows.Forms.MenuItem
		Private WithEvents Window As System.Windows.Forms.MenuItem
		Private WithEvents DNew As System.Windows.Forms.ToolBarButton
		Private WithEvents imageList1 As System.Windows.Forms.ImageList
		Private WithEvents About As System.Windows.Forms.ToolBarButton
		Private WithEvents myStatusBar As System.Windows.Forms.StatusBar
		Private WithEvents ImportIges As System.Windows.Forms.MenuItem
		Private WithEvents ImportStep As System.Windows.Forms.MenuItem
		Private WithEvents ExportBRep As System.Windows.Forms.MenuItem
		Private WithEvents ExportIges As System.Windows.Forms.MenuItem
		Private WithEvents ExportStep As System.Windows.Forms.MenuItem
		Private WithEvents ExportStl As System.Windows.Forms.MenuItem
		Private WithEvents ExportVrml As System.Windows.Forms.MenuItem
		Private WithEvents components As System.ComponentModel.IContainer
		Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents View As System.Windows.Forms.MenuItem
		Private WithEvents Help As System.Windows.Forms.MenuItem
		Private WithEvents HelpAbout As System.Windows.Forms.MenuItem
		Private WithEvents ViewToolbar As System.Windows.Forms.MenuItem
		Private WithEvents ViewStatusBar As System.Windows.Forms.MenuItem
		Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents WindowCascade As System.Windows.Forms.MenuItem
		Private WithEvents WindowTile As System.Windows.Forms.MenuItem

		Protected myModelFormat As IE_WinForms.ModelFormat
		Private WithEvents wireframe As System.Windows.Forms.ToolBarButton
		Private WithEvents shading As System.Windows.Forms.ToolBarButton
		Private WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
		Private WithEvents color As System.Windows.Forms.ToolBarButton
		Private WithEvents transparency As System.Windows.Forms.ToolBarButton
		Private WithEvents delete As System.Windows.Forms.ToolBarButton
		Private WithEvents material As System.Windows.Forms.ToolBarButton
		Private WithEvents ZoomAll As System.Windows.Forms.ToolBarButton
		Private WithEvents ZoomWin As System.Windows.Forms.ToolBarButton
		Private WithEvents ZoomProg As System.Windows.Forms.ToolBarButton
		Private WithEvents Pan As System.Windows.Forms.ToolBarButton
		Private WithEvents PanGlo As System.Windows.Forms.ToolBarButton
		Private WithEvents Front As System.Windows.Forms.ToolBarButton
		Private WithEvents Back As System.Windows.Forms.ToolBarButton
		Private WithEvents VTOP As System.Windows.Forms.ToolBarButton
		Private WithEvents VBOTTOM As System.Windows.Forms.ToolBarButton
		Private WithEvents VRIGHT As System.Windows.Forms.ToolBarButton
		Private WithEvents VLEFT As System.Windows.Forms.ToolBarButton
		Private WithEvents Axo As System.Windows.Forms.ToolBarButton
		Private WithEvents Rot As System.Windows.Forms.ToolBarButton
		Private WithEvents Reset As System.Windows.Forms.ToolBarButton
		Private WithEvents HlrOn As System.Windows.Forms.ToolBarButton
		Private WithEvents HlrOff As System.Windows.Forms.ToolBarButton
		Private WithEvents toolBarTool As System.Windows.Forms.ToolBar
		Private WithEvents toolBarView As System.Windows.Forms.ToolBar
		Protected Shared myNbOfChildren As Integer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
        Form1.myNbOfChildren = 0
        End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.File = New System.Windows.Forms.MenuItem()
        Me.FileNew = New System.Windows.Forms.MenuItem()
        Me.FileExport = New System.Windows.Forms.MenuItem()
        Me.ImportBRep = New System.Windows.Forms.MenuItem()
        Me.ImportIges = New System.Windows.Forms.MenuItem()
        Me.ImportStep = New System.Windows.Forms.MenuItem()
        Me.FileImport = New System.Windows.Forms.MenuItem()
        Me.ExportBRep = New System.Windows.Forms.MenuItem()
        Me.ExportIges = New System.Windows.Forms.MenuItem()
        Me.ExportStep = New System.Windows.Forms.MenuItem()
        Me.ExportStl = New System.Windows.Forms.MenuItem()
        Me.ExportVrml = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.ExportImage = New System.Windows.Forms.MenuItem()
        Me.FileClose = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.View = New System.Windows.Forms.MenuItem()
        Me.ViewToolbar = New System.Windows.Forms.MenuItem()
        Me.ViewStatusBar = New System.Windows.Forms.MenuItem()
        Me.Window = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.WindowCascade = New System.Windows.Forms.MenuItem()
        Me.WindowTile = New System.Windows.Forms.MenuItem()
        Me.Help = New System.Windows.Forms.MenuItem()
        Me.HelpAbout = New System.Windows.Forms.MenuItem()
        Me.toolBarTool = New System.Windows.Forms.ToolBar()
        Me.DNew = New System.Windows.Forms.ToolBarButton()
        Me.About = New System.Windows.Forms.ToolBarButton()
        Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.wireframe = New System.Windows.Forms.ToolBarButton()
        Me.shading = New System.Windows.Forms.ToolBarButton()
        Me.color = New System.Windows.Forms.ToolBarButton()
        Me.material = New System.Windows.Forms.ToolBarButton()
        Me.transparency = New System.Windows.Forms.ToolBarButton()
        Me.delete = New System.Windows.Forms.ToolBarButton()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.myStatusBar = New System.Windows.Forms.StatusBar()
        Me.toolBarView = New System.Windows.Forms.ToolBar()
        Me.ZoomAll = New System.Windows.Forms.ToolBarButton()
        Me.ZoomWin = New System.Windows.Forms.ToolBarButton()
        Me.ZoomProg = New System.Windows.Forms.ToolBarButton()
        Me.Pan = New System.Windows.Forms.ToolBarButton()
        Me.PanGlo = New System.Windows.Forms.ToolBarButton()
        Me.Front = New System.Windows.Forms.ToolBarButton()
        Me.Back = New System.Windows.Forms.ToolBarButton()
        Me.VTOP = New System.Windows.Forms.ToolBarButton()
        Me.VBOTTOM = New System.Windows.Forms.ToolBarButton()
        Me.VLEFT = New System.Windows.Forms.ToolBarButton()
        Me.VRIGHT = New System.Windows.Forms.ToolBarButton()
        Me.Axo = New System.Windows.Forms.ToolBarButton()
        Me.Rot = New System.Windows.Forms.ToolBarButton()
        Me.Reset = New System.Windows.Forms.ToolBarButton()
        Me.HlrOn = New System.Windows.Forms.ToolBarButton()
        Me.HlrOff = New System.Windows.Forms.ToolBarButton()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.File, Me.View, Me.Window, Me.Help})
        '
        'File
        '
        Me.File.Index = 0
        Me.File.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileNew, Me.FileExport, Me.FileImport, Me.FileClose, Me.menuItem2, Me.menuItem1})
        Me.File.Text = "&File"
        '
        'FileNew
        '
        Me.FileNew.Index = 0
        Me.FileNew.Text = "&New"
        '
        'FileExport
        '
        Me.FileExport.Index = 1
        Me.FileExport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ImportBRep, Me.ImportIges, Me.ImportStep})
        Me.FileExport.Text = "&Import"
        Me.FileExport.Visible = False
        '
        'ImportBRep
        '
        Me.ImportBRep.Index = 0
        Me.ImportBRep.Text = "&BRep ..."
        '
        'ImportIges
        '
        Me.ImportIges.Index = 1
        Me.ImportIges.Text = "&Iges ..."
        '
        'ImportStep
        '
        Me.ImportStep.Index = 2
        Me.ImportStep.Text = "&Step ..."
        '
        'FileImport
        '
        Me.FileImport.Index = 2
        Me.FileImport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ExportBRep, Me.ExportIges, Me.ExportStep, Me.ExportStl, Me.ExportVrml, Me.menuItem3, Me.ExportImage})
        Me.FileImport.Text = "&Export"
        Me.FileImport.Visible = False
        '
        'ExportBRep
        '
        Me.ExportBRep.Enabled = False
        Me.ExportBRep.Index = 0
        Me.ExportBRep.Text = "&BRep ..."
        '
        'ExportIges
        '
        Me.ExportIges.Enabled = False
        Me.ExportIges.Index = 1
        Me.ExportIges.Text = "&Iges ..."
        '
        'ExportStep
        '
        Me.ExportStep.Enabled = False
        Me.ExportStep.Index = 2
        Me.ExportStep.Text = "&Step ..."
        '
        'ExportStl
        '
        Me.ExportStl.Enabled = False
        Me.ExportStl.Index = 3
        Me.ExportStl.Text = "&Stl ..."
        '
        'ExportVrml
        '
        Me.ExportVrml.Enabled = False
        Me.ExportVrml.Index = 4
        Me.ExportVrml.Text = "&Vrml ..."
        '
        'menuItem3
        '
        Me.menuItem3.Index = 5
        Me.menuItem3.Text = "-"
        '
        'ExportImage
        '
        Me.ExportImage.Index = 6
        Me.ExportImage.Text = "Image ..."
        '
        'FileClose
        '
        Me.FileClose.Enabled = False
        Me.FileClose.Index = 3
        Me.FileClose.Text = "&Close"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 4
        Me.menuItem2.Text = "-"
        '
        'menuItem1
        '
        Me.menuItem1.Index = 5
        Me.menuItem1.Text = "&Quit"
        '
        'View
        '
        Me.View.Index = 1
        Me.View.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ViewToolbar, Me.ViewStatusBar})
        Me.View.Text = "&View"
        '
        'ViewToolbar
        '
        Me.ViewToolbar.Checked = True
        Me.ViewToolbar.Index = 0
        Me.ViewToolbar.Text = "&Toolbar"
        '
        'ViewStatusBar
        '
        Me.ViewStatusBar.Checked = True
        Me.ViewStatusBar.Index = 1
        Me.ViewStatusBar.Text = "&Statusbar"
        '
        'Window
        '
        Me.Window.Index = 2
        Me.Window.MdiList = True
        Me.Window.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem4, Me.WindowCascade, Me.WindowTile})
        Me.Window.Text = "&Window"
        Me.Window.Visible = False
        '
        'menuItem4
        '
        Me.menuItem4.Index = 0
        Me.menuItem4.Text = "&New 3d View"
        '
        'WindowCascade
        '
        Me.WindowCascade.Index = 1
        Me.WindowCascade.Text = "&Cascade"
        '
        'WindowTile
        '
        Me.WindowTile.Index = 2
        Me.WindowTile.Text = "&Tile"
        '
        'Help
        '
        Me.Help.Index = 3
        Me.Help.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HelpAbout})
        Me.Help.Text = "&Help"
        '
        'HelpAbout
        '
        Me.HelpAbout.Index = 0
        Me.HelpAbout.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.HelpAbout.Text = "&About"
        '
        'toolBarTool
        '
        Me.toolBarTool.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.toolBarTool.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.DNew, Me.About, Me.toolBarButton1, Me.wireframe, Me.shading, Me.color, Me.material, Me.transparency, Me.delete})
        Me.toolBarTool.DropDownArrows = True
        Me.toolBarTool.ImageList = Me.imageList1
        Me.toolBarTool.Location = New System.Drawing.Point(0, 0)
        Me.toolBarTool.Name = "toolBarTool"
        Me.toolBarTool.ShowToolTips = True
        Me.toolBarTool.Size = New System.Drawing.Size(560, 28)
        Me.toolBarTool.TabIndex = 1
        '
        'DNew
        '
        Me.DNew.ImageIndex = 0
        Me.DNew.Name = "DNew"
        Me.DNew.ToolTipText = "New"
        Me.DNew.Visible = CType(configurationAppSettings.GetValue("New.Visible", GetType(Boolean)), Boolean)
        '
        'About
        '
        Me.About.ImageIndex = 1
        Me.About.Name = "About"
        Me.About.ToolTipText = "About(F1)"
        Me.About.Visible = CType(configurationAppSettings.GetValue("About.Visible", GetType(Boolean)), Boolean)
        '
        'toolBarButton1
        '
        Me.toolBarButton1.Name = "toolBarButton1"
        Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'wireframe
        '
        Me.wireframe.Enabled = CType(configurationAppSettings.GetValue("wireframe.Enabled", GetType(Boolean)), Boolean)
        Me.wireframe.ImageIndex = 2
        Me.wireframe.Name = "wireframe"
        Me.wireframe.Pushed = CType(configurationAppSettings.GetValue("wireframe.Pushed", GetType(Boolean)), Boolean)
        Me.wireframe.ToolTipText = "Wireframe"
        Me.wireframe.Visible = CType(configurationAppSettings.GetValue("wireframe.Visible", GetType(Boolean)), Boolean)
        '
        'shading
        '
        Me.shading.Enabled = CType(configurationAppSettings.GetValue("shading.Enabled", GetType(Boolean)), Boolean)
        Me.shading.ImageIndex = 3
        Me.shading.Name = "shading"
        Me.shading.Pushed = CType(configurationAppSettings.GetValue("shading.Pushed", GetType(Boolean)), Boolean)
        Me.shading.ToolTipText = "Shading"
        Me.shading.Visible = CType(configurationAppSettings.GetValue("shading.Visible", GetType(Boolean)), Boolean)
        '
        'color
        '
        Me.color.Enabled = CType(configurationAppSettings.GetValue("color.Enabled", GetType(Boolean)), Boolean)
        Me.color.ImageIndex = 4
        Me.color.Name = "color"
        Me.color.ToolTipText = "Color"
        Me.color.Visible = CType(configurationAppSettings.GetValue("color.Visible", GetType(Boolean)), Boolean)
        '
        'material
        '
        Me.material.Enabled = CType(configurationAppSettings.GetValue("material.Enabled", GetType(Boolean)), Boolean)
        Me.material.ImageIndex = 5
        Me.material.Name = "material"
        Me.material.ToolTipText = "Material"
        Me.material.Visible = CType(configurationAppSettings.GetValue("material.Visible", GetType(Boolean)), Boolean)
        '
        'transparency
        '
        Me.transparency.Enabled = CType(configurationAppSettings.GetValue("transparency.Enabled", GetType(Boolean)), Boolean)
        Me.transparency.ImageIndex = 6
        Me.transparency.Name = "transparency"
        Me.transparency.ToolTipText = "Transparency"
        Me.transparency.Visible = CType(configurationAppSettings.GetValue("transparency.Visible", GetType(Boolean)), Boolean)
        '
        'delete
        '
        Me.delete.Enabled = CType(configurationAppSettings.GetValue("delete.Enabled", GetType(Boolean)), Boolean)
        Me.delete.ImageIndex = 7
        Me.delete.Name = "delete"
        Me.delete.ToolTipText = "Delete"
        Me.delete.Visible = CType(configurationAppSettings.GetValue("delete.Visible", GetType(Boolean)), Boolean)
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
        Me.imageList1.Images.SetKeyName(4, "")
        Me.imageList1.Images.SetKeyName(5, "")
        Me.imageList1.Images.SetKeyName(6, "")
        Me.imageList1.Images.SetKeyName(7, "")
        Me.imageList1.Images.SetKeyName(8, "")
        Me.imageList1.Images.SetKeyName(9, "")
        Me.imageList1.Images.SetKeyName(10, "")
        Me.imageList1.Images.SetKeyName(11, "")
        Me.imageList1.Images.SetKeyName(12, "")
        Me.imageList1.Images.SetKeyName(13, "")
        Me.imageList1.Images.SetKeyName(14, "")
        Me.imageList1.Images.SetKeyName(15, "")
        Me.imageList1.Images.SetKeyName(16, "")
        Me.imageList1.Images.SetKeyName(17, "")
        Me.imageList1.Images.SetKeyName(18, "")
        Me.imageList1.Images.SetKeyName(19, "")
        Me.imageList1.Images.SetKeyName(20, "")
        Me.imageList1.Images.SetKeyName(21, "")
        Me.imageList1.Images.SetKeyName(22, "")
        Me.imageList1.Images.SetKeyName(23, "")
        '
        'myStatusBar
        '
        Me.myStatusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.myStatusBar.Location = New System.Drawing.Point(0, 363)
        Me.myStatusBar.Name = "myStatusBar"
        Me.myStatusBar.Size = New System.Drawing.Size(560, 22)
        Me.myStatusBar.TabIndex = 3
        '
        'toolBarView
        '
        Me.toolBarView.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.toolBarView.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ZoomAll, Me.ZoomWin, Me.ZoomProg, Me.Pan, Me.PanGlo, Me.Front, Me.Back, Me.VTOP, Me.VBOTTOM, Me.VLEFT, Me.VRIGHT, Me.Axo, Me.Rot, Me.Reset, Me.HlrOn, Me.HlrOff})
        Me.toolBarView.DropDownArrows = True
        Me.toolBarView.ImageList = Me.imageList1
        Me.toolBarView.Location = New System.Drawing.Point(0, 28)
        Me.toolBarView.Name = "toolBarView"
        Me.toolBarView.ShowToolTips = True
        Me.toolBarView.Size = New System.Drawing.Size(560, 28)
        Me.toolBarView.TabIndex = 5
        Me.toolBarView.Visible = False
        Me.toolBarView.Wrappable = False
        '
        'ZoomAll
        '
        Me.ZoomAll.ImageIndex = 8
        Me.ZoomAll.Name = "ZoomAll"
        Me.ZoomAll.ToolTipText = "FitAll"
        '
        'ZoomWin
        '
        Me.ZoomWin.ImageIndex = 9
        Me.ZoomWin.Name = "ZoomWin"
        Me.ZoomWin.ToolTipText = "Zoom Window"
        '
        'ZoomProg
        '
        Me.ZoomProg.ImageIndex = 10
        Me.ZoomProg.Name = "ZoomProg"
        Me.ZoomProg.ToolTipText = "Dynamic Zooming"
        '
        'Pan
        '
        Me.Pan.ImageIndex = 11
        Me.Pan.Name = "Pan"
        Me.Pan.ToolTipText = "Dynamic Panning"
        '
        'PanGlo
        '
        Me.PanGlo.ImageIndex = 12
        Me.PanGlo.Name = "PanGlo"
        Me.PanGlo.ToolTipText = "GlobalPanning"
        '
        'Front
        '
        Me.Front.ImageIndex = 13
        Me.Front.Name = "Front"
        Me.Front.ToolTipText = "Front"
        '
        'Back
        '
        Me.Back.ImageIndex = 14
        Me.Back.Name = "Back"
        Me.Back.ToolTipText = "Back"
        '
        'VTOP
        '
        Me.VTOP.ImageIndex = 15
        Me.VTOP.Name = "VTOP"
        Me.VTOP.ToolTipText = "Top"
        '
        'VBOTTOM
        '
        Me.VBOTTOM.ImageIndex = 16
        Me.VBOTTOM.Name = "VBOTTOM"
        Me.VBOTTOM.ToolTipText = "Bottom"
        '
        'VLEFT
        '
        Me.VLEFT.ImageIndex = 17
        Me.VLEFT.Name = "VLEFT"
        Me.VLEFT.ToolTipText = "Left"
        '
        'VRIGHT
        '
        Me.VRIGHT.ImageIndex = 18
        Me.VRIGHT.Name = "VRIGHT"
        Me.VRIGHT.ToolTipText = "Right"
        '
        'Axo
        '
        Me.Axo.ImageIndex = 19
        Me.Axo.Name = "Axo"
        Me.Axo.ToolTipText = "Axo"
        '
        'Rot
        '
        Me.Rot.ImageIndex = 20
        Me.Rot.Name = "Rot"
        Me.Rot.ToolTipText = "Dynamic Rotation"
        '
        'Reset
        '
        Me.Reset.ImageIndex = 21
        Me.Reset.Name = "Reset"
        Me.Reset.ToolTipText = "Reset"
        '
        'HlrOn
        '
        Me.HlrOn.ImageIndex = 22
        Me.HlrOn.Name = "HlrOn"
        Me.HlrOn.Pushed = True
        Me.HlrOn.ToolTipText = "Hidden On"
        '
        'HlrOff
        '
        Me.HlrOff.ImageIndex = 23
        Me.HlrOff.Name = "HlrOff"
        Me.HlrOff.ToolTipText = "Hidden Off"
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Application
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 385)
        Me.Controls.Add(Me.toolBarView)
        Me.Controls.Add(Me.myStatusBar)
        Me.Controls.Add(Me.toolBarTool)
        Me.IsMdiContainer = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Sample Import / Export VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Private Shared Sub Main()
			Application.Run(New Form1())
		End Sub

    Private Sub menuItem2_Click(sender As Object, e As System.EventArgs) Handles FileNew.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.OnNewFile()
    End Sub

    Private Sub menuItem3_Click(sender As Object, e As System.EventArgs) Handles FileClose.Click
        If Me.MdiChildren.Length > 0 Then
            Me.ActiveMdiChild.Close()
        End If

    End Sub

    Private Sub ImportBRep_Click(sender As Object, e As System.EventArgs) Handles ImportBRep.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = ModelFormat.BREP
        curForm.ImportModel(Me.myModelFormat)
    End Sub

    Private Sub toolBar1_ButtonClick(sender As Object, e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBarTool.ButtonClick
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        Select Case toolBarTool.Buttons.IndexOf(e.Button)
            Case 0
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.OnNewFile()
                Exit Select
            Case 1
                Dim myDlg As New AboutDialog()
                myDlg.ShowDialog(Me)
                Exit Select

            Case 2
                'just separator
                Exit Select
            Case 3
                If curForm Is Nothing Then
                    Return
                End If
                curForm.SetDisplayMode(0)
                'wireframe
                Me.wireframe.Enabled = False
                Me.shading.Enabled = True
                Me.transparency.Enabled = False
                Exit Select
            Case 4
                If curForm Is Nothing Then
                    Return
                End If
                curForm.SetDisplayMode(1)
                'shading
                Me.shading.Enabled = False
                Me.wireframe.Enabled = True
                Me.transparency.Enabled = True
                Exit Select
            Case 5
                If curForm Is Nothing Then
                    Return
                End If
                curForm.ChangeColor(True)
                Exit Select
            Case 6
                If curForm Is Nothing Then
                    Return
                End If
                Dim m As New MaterialDialog()
                m.View = curForm.View
                m.ShowDialog(curForm)
                Exit Select
            Case 7
                If curForm Is Nothing Then
                    Return
                End If
                Dim t As IE_WinForms.TransparencyDialog = New TransparencyDialog()
                t.View = curForm.View
                t.ShowDialog(curForm)
                Exit Select
            Case 8
                If curForm Is Nothing Then
                    Return
                End If
                curForm.DeleteObjects()
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub toolBar1_MouseHover(sender As Object, e As System.EventArgs)
        Me.myStatusBar.Text = "Document toolbar"
    End Sub

    Private Sub toolBar1_MouseLeave(sender As Object, e As System.EventArgs)
        Me.myStatusBar.Text = ""
    End Sub

    Private Sub ImportIges_Click(sender As Object, e As System.EventArgs) Handles ImportIges.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.IGES
        curForm.ImportModel(Me.myModelFormat)
    End Sub

    Private Sub ImportStep_Click(sender As Object, e As System.EventArgs) Handles ImportStep.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.[STEP]
        curForm.ImportModel(Me.myModelFormat)
    End Sub

    Private Sub ExportBRep_Click(sender As Object, e As System.EventArgs) Handles ExportBRep.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.BREP
        curForm.ExportModel(Me.myModelFormat)
    End Sub

    Private Sub ExportIges_Click(sender As Object, e As System.EventArgs) Handles ExportIges.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.IGES
        curForm.ExportModel(Me.myModelFormat)
    End Sub

    Private Sub ExportStep_Click(sender As Object, e As System.EventArgs) Handles ExportStep.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.[STEP]
        curForm.ExportModel(Me.myModelFormat)
    End Sub

    Private Sub ExportStl_Click(sender As Object, e As System.EventArgs) Handles ExportStl.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.STL
        curForm.ExportModel(Me.myModelFormat)
    End Sub

    Private Sub ExportVrml_Click(sender As Object, e As System.EventArgs) Handles ExportVrml.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.VRML
        curForm.ExportModel(Me.myModelFormat)
    End Sub

    Private Sub ExportImage_Click(sender As Object, e As System.EventArgs) Handles ExportImage.Click
        Dim curForm As Form2 = DirectCast(Me.ActiveMdiChild, Form2)
        If curForm Is Nothing Then
            Return
        End If
        Me.myModelFormat = IE_WinForms.ModelFormat.IMAGE
        curForm.ExportModel(Me.myModelFormat)
    End Sub

    Private Sub HelpAbout_Click(sender As Object, e As System.EventArgs) Handles HelpAbout.Click
        Dim myDlg As New AboutDialog()
        myDlg.ShowDialog(Me)
    End Sub

    Private Sub ViewToolbar_Click(sender As Object, e As System.EventArgs) Handles ViewToolbar.Click

        If Me.ViewToolbar.Checked Then
            If Me.MdiChildren.Length > 0 Then
                Me.DNew.Visible = False
                Me.About.Visible = False
            Else
                Me.toolBarTool.Hide()
            End If
            Me.ViewToolbar.Checked = False
        Else
            If Me.MdiChildren.Length > 0 Then
                Me.DNew.Visible = True
                Me.About.Visible = True
            Else
                Me.toolBarTool.Show()
            End If
            Me.ViewToolbar.Checked = True
        End If

    End Sub

    Private Sub ViewStatusBar_Click(sender As Object, e As System.EventArgs) Handles ViewStatusBar.Click
        If Me.ViewStatusBar.Checked Then
            Me.myStatusBar.Hide()
            Me.ViewStatusBar.Checked = False
        Else
            Me.myStatusBar.Show()
            Me.ViewStatusBar.Checked = True
        End If
    End Sub

    Public Sub OnNewFile()
        Dim newForm As New Form2()
        newForm.MdiParent = Me
        IE_WinForms.Form1.myNbOfChildren = IE_WinForms.Form1.myNbOfChildren + 1
        newForm.SetIndex(IE_WinForms.Form1.myNbOfChildren, 1)
        newForm.Show()
        newForm.InitView()
        newForm.InitV3D()
        Me.FileExport.Visible = True
        Me.FileImport.Visible = True
        Me.Window.Visible = True
        Me.wireframe.Visible = True
        Me.shading.Visible = True
        Me.color.Visible = True
        Me.material.Visible = True
        Me.transparency.Visible = True
        Me.delete.Visible = True
        Me.Cursor = System.Windows.Forms.Cursors.[Default]
        Me.toolBarView.Visible = True
    End Sub

    Private Sub FileImport_Popup(sender As Object, e As System.EventArgs) Handles FileImport.Popup
        Dim curForm As IE_WinForms.Form2 = DirectCast(Me.ActiveMdiChild, IE_WinForms.Form2)
        If curForm Is Nothing Then
            Return
        End If
        If curForm.View.IsObjectSelected() Then
            Me.ExportBRep.Enabled = True
            Me.ExportIges.Enabled = True
            Me.ExportStep.Enabled = True
            Me.ExportVrml.Enabled = True
            Me.ExportStl.Enabled = True
        End If

    End Sub

    Private Sub menuItem1_Click(sender As Object, e As System.EventArgs) Handles menuItem1.Click
        Me.Close()
    End Sub

    Private Sub File_Popup(sender As Object, e As System.EventArgs) Handles File.Popup
        If Me.MdiChildren.Length > 0 Then
            Me.FileClose.Enabled = True
        Else
            Me.FileClose.Enabled = False
            Me.FileExport.Visible = False
            Me.FileImport.Visible = False
        End If
    End Sub

    Private Sub menuItem4_Click(sender As Object, e As System.EventArgs) Handles menuItem4.Click
        Dim curForm As IE_WinForms.Form2 = DirectCast(Me.ActiveMdiChild, IE_WinForms.Form2)
        Dim newView As IE_WinForms.Form2 = New Form2()
        newView.MdiParent = Me
        newView.Show()
        newView.InitView()
        newView.SetContext(curForm.View)
        newView.View.CreateNewView(newView.Handle)
        newView.SetNextIndex(curForm)
    End Sub

    Private Sub WindowCascade_Click(sender As Object, e As System.EventArgs) Handles WindowCascade.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub WindowTile_Click(sender As Object, e As System.EventArgs) Handles WindowTile.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Public Sub SelectionChanged()
        If Me.MdiChildren.Length = 0 Then
            Return
        End If
        Dim curForm As IE_WinForms.Form2 = DirectCast(Me.ActiveMdiChild, IE_WinForms.Form2)
        If curForm Is Nothing Then
            Return
        End If
        Select Case curForm.View.DisplayMode()
            Case -1
                Me.shading.Enabled = False
                Me.wireframe.Enabled = False
                Exit Select
            Case 0
                Me.wireframe.Enabled = False
                Me.shading.Enabled = True
                Me.transparency.Enabled = False
                Exit Select
            Case 1
                Me.wireframe.Enabled = True
                Me.shading.Enabled = False
                Me.transparency.Enabled = True
                Exit Select
            Case 10
                Me.wireframe.Enabled = True
                Me.shading.Enabled = True
                Me.transparency.Enabled = True
                Exit Select
            Case Else
                Exit Select
        End Select
        Dim IsSelected As Boolean = curForm.View.IsObjectSelected()
        If IsSelected Then
            Me.color.Enabled = True
            Me.material.Enabled = True
            Me.delete.Enabled = True
        Else
            Me.color.Enabled = False
            Me.material.Enabled = False
            Me.transparency.Enabled = False
            Me.delete.Enabled = False
        End If
        If curForm.DegenerateMode Then
            Me.HlrOff.Pushed = False
            Me.HlrOn.Pushed = True
        Else
            Me.HlrOff.Pushed = True
            Me.HlrOn.Pushed = False
        End If
        If curForm.Mode = IE_WinForms.CurrentAction3d.CurAction3d_WindowZooming Then
            Me.ZoomWin.Pushed = False
        End If

    End Sub

    Public ReadOnly Property StatusBar() As StatusBar
        Get
            Return Me.myStatusBar
        End Get
    End Property

    Public Sub OnFileClose()
        If Me.MdiChildren.Length <= 1 Then
            Me.FileClose.Enabled = False
            Me.Window.Visible = False
            Me.wireframe.Visible = False
            Me.shading.Visible = False
            Me.color.Visible = False
            Me.material.Visible = False
            Me.transparency.Visible = False
            Me.delete.Visible = False
            Me.toolBarView.Visible = False
        End If
    End Sub

    Private Sub toolBarView_ButtonClick(sender As Object, e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBarView.ButtonClick
        Dim curForm As IE_WinForms.Form2 = DirectCast(Me.ActiveMdiChild, IE_WinForms.Form2)
        If curForm Is Nothing Then
            Return
        End If
        Select Case toolBarView.Buttons.IndexOf(e.Button)
            Case 0
                curForm.View.ZoomAllView()
                Exit Select
            Case 1
                curForm.Mode = CurrentAction3d.CurAction3d_WindowZooming
                Me.ZoomWin.Pushed = True
                Exit Select
            Case 2
                curForm.Mode = CurrentAction3d.CurAction3d_DynamicZooming
                Exit Select
            Case 3
                curForm.Mode = CurrentAction3d.CurAction3d_DynamicPanning
                Exit Select
            Case 4
                curForm.Zoom = curForm.View.Scale()
                curForm.Mode = CurrentAction3d.CurAction3d_GlobalPanning
                Exit Select
            Case 5
                curForm.View.FrontView()
                Exit Select
            Case 6
                curForm.View.BackView()
                Exit Select
            Case 7
                curForm.View.TopView()
                Exit Select
            Case 8
                curForm.View.BottomView()
                Exit Select
            Case 9
                curForm.View.LeftView()
                Exit Select
            Case 10
                curForm.View.RightView()
                Exit Select
            Case 11
                curForm.View.AxoView()
                Exit Select
            Case 12
                curForm.Mode = CurrentAction3d.CurAction3d_DynamicRotation
                Exit Select
            Case 13
                curForm.View.Reset()
                Exit Select
            Case 14
                curForm.View.SetDegenerateModeOn()
                curForm.DegenerateMode = True
                Me.HlrOff.Pushed = False
                Me.HlrOn.Pushed = True
                Exit Select
            Case 15
                curForm.View.SetDegenerateModeOff()
                curForm.DegenerateMode = False
                Me.HlrOn.Pushed = False
                Me.HlrOff.Pushed = True
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles MyBase.Activated
        If Me.toolBarView.Visible Then
            Me.SelectionChanged()
        End If
    End Sub

    Private Sub toolBarView_MouseHover(sender As Object, e As System.EventArgs) Handles toolBarView.MouseHover
        Me.myStatusBar.Text = "View toolbar"
    End Sub

    Private Sub toolBarView_MouseLeave(sender As Object, e As System.EventArgs) Handles toolBarView.MouseLeave
        Me.myStatusBar.Text = ""
    End Sub

	End Class

'End Namespace


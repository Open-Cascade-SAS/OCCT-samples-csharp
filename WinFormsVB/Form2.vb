Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

'Namespace IE_WinForms
    Public Enum CurrentAction3d
        CurAction3d_Nothing
        CurAction3d_DynamicZooming
        CurAction3d_WindowZooming
        CurAction3d_DynamicPanning
        CurAction3d_GlobalPanning
        CurAction3d_DynamicRotation
    End Enum
    Public Enum CurrentPressedKey
        CurPressedKey_Nothing
        CurPressedKey_Ctrl
        CurPressedKey_Shift
    End Enum
    Public Enum ModelFormat
        BREP
        [STEP]
        IGES
        VRML
        STL
        IMAGE
    End Enum
    ''' <summary>
    ''' Summary description for Form2.
    ''' </summary>
    Public Class Form2
        Inherits System.Windows.Forms.Form
        Private components As System.ComponentModel.IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' Create OCCT proxy object
            '
            myOCCTProxy = New OCCTProxy()
            myCurrentMode = CurrentAction3d.CurAction3d_Nothing
            myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Nothing
            myDegenerateModeIsOn = True
            IsRectVisible = False
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.Resources.ResourceManager(GetType(Form2))
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.myPopup = New System.Windows.Forms.ContextMenu()
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.myPopupObject = New System.Windows.Forms.ContextMenu()
            Me.ContextWireframe = New System.Windows.Forms.MenuItem()
            Me.ContextShading = New System.Windows.Forms.MenuItem()
            Me.ContextColor = New System.Windows.Forms.MenuItem()
            Me.ContextMaterial = New System.Windows.Forms.MenuItem()
            Me.ContMatBrass = New System.Windows.Forms.MenuItem()
            Me.ContMenBronze = New System.Windows.Forms.MenuItem()
            Me.ContMenCopper = New System.Windows.Forms.MenuItem()
            Me.ContMenGold = New System.Windows.Forms.MenuItem()
            Me.ContMenPewt = New System.Windows.Forms.MenuItem()
            Me.ContMenPlaster = New System.Windows.Forms.MenuItem()
            Me.ContMenPlastic = New System.Windows.Forms.MenuItem()
            Me.ContMenSilver = New System.Windows.Forms.MenuItem()
            Me.ContMenTranc = New System.Windows.Forms.MenuItem()
            Me.ContMenDelete = New System.Windows.Forms.MenuItem()
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList1.ImageStream = DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            ' 
            ' myPopup
            ' 
            Me.myPopup.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
            ' 
            ' menuItem1
            ' 
            Me.menuItem1.Index = 0
            Me.menuItem1.Text = "Change &Background"
            AddHandler Me.menuItem1.Click, AddressOf Me.menuItem1_Click
            ' 
            ' myPopupObject
            ' 
            Me.myPopupObject.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ContextWireframe, Me.ContextShading, Me.ContextColor, Me.ContextMaterial, Me.ContMenTranc, Me.ContMenDelete})
            AddHandler Me.myPopupObject.Popup, AddressOf Me.myPopupObject_Popup
            ' 
            ' ContextWireframe
            ' 
            Me.ContextWireframe.Index = 0
            Me.ContextWireframe.Text = "Wireframe"
            AddHandler Me.ContextWireframe.Click, AddressOf Me.ContextWireframe_Click
            ' 
            ' ContextShading
            ' 
            Me.ContextShading.Index = 1
            Me.ContextShading.Text = "Shading"
            AddHandler Me.ContextShading.Click, AddressOf Me.ContextShading_Click
            ' 
            ' ContextColor
            ' 
            Me.ContextColor.Index = 2
            Me.ContextColor.Text = "Color"
            AddHandler Me.ContextColor.Click, AddressOf Me.ContextColor_Click
            ' 
            ' ContextMaterial
            ' 
            Me.ContextMaterial.Index = 3
            Me.ContextMaterial.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ContMatBrass, Me.ContMenBronze, Me.ContMenCopper, Me.ContMenGold, Me.ContMenPewt, Me.ContMenPlaster, _
             Me.ContMenPlastic, Me.ContMenSilver})
            Me.ContextMaterial.Text = "Material"
            ' 
            ' ContMatBrass
            ' 
            Me.ContMatBrass.Index = 0
            Me.ContMatBrass.Text = "&Brass"
            AddHandler Me.ContMatBrass.Click, AddressOf Me.ContMatBrass_Click
            ' 
            ' ContMenBronze
            ' 
            Me.ContMenBronze.Index = 1
            Me.ContMenBronze.Text = "&Bronze"
            AddHandler Me.ContMenBronze.Click, AddressOf Me.ContMenBronze_Click
            ' 
            ' ContMenCopper
            ' 
            Me.ContMenCopper.Index = 2
            Me.ContMenCopper.Text = "&Copper"
            AddHandler Me.ContMenCopper.Click, AddressOf Me.ContMenCopper_Click
            ' 
            ' ContMenGold
            ' 
            Me.ContMenGold.Index = 3
            Me.ContMenGold.Text = "&Gold"
            AddHandler Me.ContMenGold.Click, AddressOf Me.ContMenGold_Click
            ' 
            ' ContMenPewt
            ' 
            Me.ContMenPewt.Index = 4
            Me.ContMenPewt.Text = "&Pewter"
            AddHandler Me.ContMenPewt.Click, AddressOf Me.ContMenPewt_Click
            ' 
            ' ContMenPlaster
            ' 
            Me.ContMenPlaster.Index = 5
            Me.ContMenPlaster.Text = "&Plaster"
            AddHandler Me.ContMenPlaster.Click, AddressOf Me.ContMenPlaster_Click
            ' 
            ' ContMenPlastic
            ' 
            Me.ContMenPlastic.Index = 6
            Me.ContMenPlastic.Text = "&Plastic"
            AddHandler Me.ContMenPlastic.Click, AddressOf Me.ContMenPlastic_Click
            ' 
            ' ContMenSilver
            ' 
            Me.ContMenSilver.Index = 7
            Me.ContMenSilver.Text = "&Silver"
            AddHandler Me.ContMenSilver.Click, AddressOf Me.ContMenSilver_Click
            ' 
            ' ContMenTranc
            ' 
            Me.ContMenTranc.Index = 4
            Me.ContMenTranc.Text = "&Trancparency"
            AddHandler Me.ContMenTranc.Click, AddressOf Me.ContMenTranc_Click
            ' 
            ' ContMenDelete
            ' 
            Me.ContMenDelete.Index = 5
            Me.ContMenDelete.Text = "&Delete"
            AddHandler Me.ContMenDelete.Click, AddressOf Me.ContMenDelete_Click
            ' 
            ' Form2
            ' 
            Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(320, 261)
            Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Name = "Form2"
            Me.Text = "Document"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            AddHandler Me.KeyDown, AddressOf Me.Form2_KeyDown
            AddHandler Me.MouseDown, AddressOf Me.Form2_MouseDown
            AddHandler Me.SizeChanged, AddressOf Me.Form2_SizeChanged
            AddHandler Me.MouseUp, AddressOf Me.Form2_MouseUp
            AddHandler Me.KeyUp, AddressOf Me.Form2_KeyUp
            AddHandler Me.Closed, AddressOf Me.Form2_Closed
            AddHandler Me.Paint, AddressOf Me.Form2_Paint
            AddHandler Me.MouseMove, AddressOf Me.Form2_MouseMove
        End Sub
#End Region

        Private imageList1 As System.Windows.Forms.ImageList
        Private myPopup As System.Windows.Forms.ContextMenu
        Private myPopupObject As System.Windows.Forms.ContextMenu
        Private ContextWireframe As System.Windows.Forms.MenuItem
        Private ContextShading As System.Windows.Forms.MenuItem
        Private ContextColor As System.Windows.Forms.MenuItem
        Private ContextMaterial As System.Windows.Forms.MenuItem
        Private ContMatBrass As System.Windows.Forms.MenuItem
        Private ContMenBronze As System.Windows.Forms.MenuItem
        Private ContMenCopper As System.Windows.Forms.MenuItem
        Private ContMenGold As System.Windows.Forms.MenuItem
        Private ContMenPewt As System.Windows.Forms.MenuItem
        Private ContMenPlaster As System.Windows.Forms.MenuItem
        Private ContMenPlastic As System.Windows.Forms.MenuItem
        Private ContMenSilver As System.Windows.Forms.MenuItem
        Private ContMenTranc As System.Windows.Forms.MenuItem
        Private ContMenDelete As System.Windows.Forms.MenuItem
        Private menuItem1 As System.Windows.Forms.MenuItem

        Private myOCCTProxy As OCCTProxy
        Private myDocumentIndex As Integer, myViewIndex As Integer

        Public Sub InitV3D()
            If Not myOCCTProxy.InitViewer(Me.Handle) Then
                MessageBox.Show("Fatal Error during the graphic initialisation", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        End Sub

        Public Function ImportBRep(filename As System.String) As Boolean
            Return myOCCTProxy.ImportBrep(filename)
        End Function

        Private Sub Form2_SizeChanged(sender As Object, e As System.EventArgs)
            myOCCTProxy.UpdateView()
        End Sub

        Private Sub Form2_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
            myOCCTProxy.RedrawView()
            myOCCTProxy.UpdateView()
        End Sub

        Protected myCurrentMode As CurrentAction3d
        Protected myCurrentPressedKey As CurrentPressedKey
        Protected myCurZoom As Single
        ' ~ Quantity_Factor
        Protected myDegenerateModeIsOn As Boolean
        Protected myXmin As Integer
        Protected myYmin As Integer
        Protected myXmax As Integer
        Protected myYmax As Integer
        Protected theButtonDownX As Integer
        Protected theButtonDownY As Integer
        ' for erasing of rectangle
        Protected theRectDownX As Integer
        Protected theRectDownY As Integer
        Protected IsRectVisible As Boolean

        Private Sub Form2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Select Case e.Button
                Case MouseButtons.Left
                    myXmin = e.X
                    myYmin = e.Y
                    myXmax = e.X
                    myYmax = e.Y
                    If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Ctrl Then
                        ' start the dinamic zooming....
                        myCurrentMode = CurrentAction3d.CurAction3d_DynamicZooming
                    Else
                        Select Case myCurrentMode
                            Case CurrentAction3d.CurAction3d_Nothing
                                If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Shift Then
                                    MultiDragEvent(myXmax, myYmax, -1)
                                Else
                                    DragEvent(myXmax, myYmax, -1)
                                End If
                                Exit Select
                            Case CurrentAction3d.CurAction3d_DynamicRotation
                                If Not myDegenerateModeIsOn Then
                                    myOCCTProxy.SetDegenerateModeOn()
                                End If
                                'start the rotation
                                myOCCTProxy.StartRotation(e.X, e.Y)
                                Exit Select
                            Case IE_WinForms.CurrentAction3d.CurAction3d_WindowZooming
                                Me.Cursor = System.Windows.Forms.Cursors.Hand
                                Exit Select
                            Case Else
                                Exit Select
                        End Select
                    End If
                    Exit Select
                Case MouseButtons.Right
                    'MessageBox.Show("right mouse button is down");
                    If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Ctrl Then
                        If Not myDegenerateModeIsOn Then
                            myOCCTProxy.SetDegenerateModeOn()
                        End If
                        myOCCTProxy.StartRotation(e.X, e.Y)
                    Else
                        Popup(e.X, e.Y)
                    End If
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub

        Private Sub Form2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.Shift Then
                myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Shift
            ElseIf e.Control Then
                myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Ctrl
            End If
        End Sub

        Private Sub Form2_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Nothing
        End Sub

        Protected Sub MultiDragEvent(x As Integer, y As Integer, theState As Integer)
            If theState = -1 Then
                theButtonDownX = x
                theButtonDownY = y
            ElseIf theState = 1 Then
                myOCCTProxy.ShiftSelect(Math.Min(theButtonDownX, x), Math.Min(theButtonDownY, y), Math.Max(theButtonDownX, x), Math.Max(theButtonDownY, y))
            End If
        End Sub

        Protected Sub DragEvent(x As Integer, y As Integer, theState As Integer)
            If theState = -1 Then
                'mouse is down
                theButtonDownX = x
                theButtonDownY = y
            ElseIf theState = 1 Then
                'mouse is up
                myOCCTProxy.[Select](Math.Min(theButtonDownX, x), Math.Min(theButtonDownY, y), Math.Max(theButtonDownX, x), Math.Max(theButtonDownY, y))
            End If
        End Sub

        Protected Sub Popup(x As Integer, y As Integer)
            Dim p As System.Drawing.Point = New Point(x, y)
            If Me.myOCCTProxy.IsObjectSelected() Then
                Me.myPopupObject.Show(Me, p)
            Else
                Me.myPopup.Show(Me, p)
            End If
        End Sub

        Private Sub Form2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Select Case e.Button
                Case MouseButtons.Left
                    If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Ctrl Then
                        Return
                    End If
                    Select Case myCurrentMode
                        Case CurrentAction3d.CurAction3d_Nothing
                            If e.X = myXmin AndAlso e.Y = myYmin Then
                                myXmax = e.X
                                myYmax = e.Y
                                If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Shift Then
                                    MultiInputEvent(myXmax, myYmax)
                                Else
                                    InputEvent(myXmax, myYmax)
                                End If
                            Else
                                myXmax = e.X
                                myYmax = e.Y
                                DrawRectangle(False)
                                If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Shift Then
                                    MultiDragEvent(myXmax, myYmax, 1)
                                Else
                                    DragEvent(myXmax, myYmax, 1)
                                End If
                            End If
                            Exit Select
                        Case CurrentAction3d.CurAction3d_DynamicZooming
                            myCurrentMode = CurrentAction3d.CurAction3d_Nothing
                            Exit Select
                        Case CurrentAction3d.CurAction3d_WindowZooming
                            myXmax = e.X
                            myYmax = e.Y
                            DrawRectangle(False)
                            Dim ValZWMin As Integer = 1
                            If Math.Abs(myXmax - myXmin) > ValZWMin AndAlso Math.Abs(myXmax - myYmax) > ValZWMin Then
                                myOCCTProxy.WindowFitAll(myXmin, myYmin, myXmax, myYmax)
                            End If
                            Me.Cursor = System.Windows.Forms.Cursors.[Default]
                            Dim f As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
                            f.SelectionChanged()
                            myCurrentMode = CurrentAction3d.CurAction3d_Nothing
                            Exit Select
                        Case CurrentAction3d.CurAction3d_DynamicPanning
                            myCurrentMode = CurrentAction3d.CurAction3d_Nothing
                            Exit Select
                        Case CurrentAction3d.CurAction3d_GlobalPanning
                            myOCCTProxy.Place(e.X, e.Y, myCurZoom)
                            myCurrentMode = CurrentAction3d.CurAction3d_Nothing
                            Exit Select
                        Case CurrentAction3d.CurAction3d_DynamicRotation
                            myCurrentMode = CurrentAction3d.CurAction3d_Nothing
                            If Not myDegenerateModeIsOn Then
                                myOCCTProxy.SetDegenerateModeOff()
                                myDegenerateModeIsOn = False
                            Else
                                myOCCTProxy.SetDegenerateModeOn()
                                myDegenerateModeIsOn = True
                            End If
                            Exit Select
                        Case Else
                            Exit Select

                    End Select
                    Exit Select
                Case MouseButtons.Right
                    If Not myDegenerateModeIsOn Then
                        myOCCTProxy.SetDegenerateModeOff()
                        myDegenerateModeIsOn = False
                    Else
                        myOCCTProxy.SetDegenerateModeOn()
                        myDegenerateModeIsOn = True
                    End If
                    Exit Select
                Case Else
                    Exit Select
            End Select

            Dim parent As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
            parent.SelectionChanged()
        End Sub

        Protected Sub MultiInputEvent(x As Integer, y As Integer)
            myOCCTProxy.ShiftSelect()
        End Sub

        Protected Sub InputEvent(x As Integer, y As Integer)
            myOCCTProxy.[Select]()
        End Sub

        Private Sub DrawRectangle(draw As Boolean)
            Dim gr As Graphics = Graphics.FromHwnd(Me.Handle)
            Dim p As System.Drawing.Pen = Nothing
            If Me.IsRectVisible OrElse (Not draw) Then
                'erase the rect
                Dim r As Integer = myOCCTProxy.GetBGColR()
                Dim g As Integer = myOCCTProxy.GetBGColG()
                Dim b As Integer = myOCCTProxy.GetBGColB()
                p = New Pen(System.Drawing.Color.FromArgb(r, g, b))
                Me.IsRectVisible = False
                Me.myOCCTProxy.UpdateView()
            ElseIf draw Then
                p = New Pen(System.Drawing.Color.White)
                Me.IsRectVisible = True
            End If
            If p Is Nothing Then
                Return
            End If
            Dim x As Integer = Math.Min(Me.myXmin, Me.myXmax)
            Dim y As Integer = Math.Min(Me.myYmin, Me.myYmax)
            gr.DrawRectangle(p, x, y, Math.Abs(myXmax - myXmin), Math.Abs(myYmax - myYmin))
            Me.theRectDownX = Math.Max(Me.myXmin, Me.myXmax)
            Me.theRectDownY = Math.Max(Me.myYmin, Me.myYmax)
        End Sub

        Private Sub Form2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                'left button is pressed
                If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Ctrl Then
                    myOCCTProxy.Zoom(myXmax, myYmax, e.X, e.Y)
                    myXmax = e.X
                    myYmax = e.Y
                Else
                    Select Case myCurrentMode
                        Case CurrentAction3d.CurAction3d_Nothing
                            DrawRectangle(False)
                            myXmax = e.X
                            myYmax = e.Y
                            DrawRectangle(True)
                            Exit Select
                        Case CurrentAction3d.CurAction3d_DynamicZooming
                            myOCCTProxy.Zoom(myXmax, myYmax, e.X, e.Y)
                            myXmax = e.X
                            myYmax = e.Y
                            Exit Select
                        Case CurrentAction3d.CurAction3d_WindowZooming
                            DrawRectangle(False)
                            myXmax = e.X
                            myYmax = e.Y
                            DrawRectangle(True)
                            'add brush here
                            Exit Select
                        Case CurrentAction3d.CurAction3d_DynamicPanning
                            myOCCTProxy.Pan(e.X - myXmax, myYmax - e.Y)
                            myXmax = e.X
                            myYmax = e.Y
                            Exit Select
                        Case CurrentAction3d.CurAction3d_GlobalPanning
                            Exit Select
                        Case CurrentAction3d.CurAction3d_DynamicRotation
                            myOCCTProxy.Rotation(e.X, e.Y)
                            myOCCTProxy.RedrawView()
                            Exit Select
                        Case Else
                            Exit Select
                    End Select
                End If
                ' e.Button == MouseButtons.Left
            ElseIf e.Button = MouseButtons.Middle Then
                If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Ctrl Then
                    myOCCTProxy.Pan(e.X - myXmax, myYmax - e.Y)
                    myXmax = e.X
                    myYmax = e.Y
                End If
                'e.Button=MouseButtons.Middle
            ElseIf e.Button = MouseButtons.Right Then
                'right button is pressed
                If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Ctrl Then
                    myOCCTProxy.Rotation(e.X, e.Y)
                End If
            Else
                ' no buttons are pressed
                myXmax = e.X
                myYmax = e.Y
                If myCurrentPressedKey = CurrentPressedKey.CurPressedKey_Shift Then
                    MultiMoveEvent(e.X, e.Y)
                Else
                    MoveEvent(e.X, e.Y)
                End If
            End If


        End Sub

        Protected Sub MultiMoveEvent(x As Integer, y As Integer)
            myOCCTProxy.MoveTo(x, y)
        End Sub

        Protected Sub MoveEvent(x As Integer, y As Integer)
            myOCCTProxy.MoveTo(x, y)
        End Sub

        Public Sub SetDisplayMode(aMode As Integer)
            myOCCTProxy.SetDisplayMode(aMode)
        End Sub

        Public Sub ChangeColor(IsObjectColor As Boolean)
            Dim r As Integer, g As Integer, b As Integer
            If IsObjectColor Then
                r = myOCCTProxy.GetObjColR()
                g = myOCCTProxy.GetObjColG()
                b = myOCCTProxy.GetObjColB()
            Else
                r = myOCCTProxy.GetBGColR()
                g = myOCCTProxy.GetBGColG()
                b = myOCCTProxy.GetBGColB()
            End If
            Dim ColDlg As System.Windows.Forms.ColorDialog = New ColorDialog()
            ColDlg.Color = System.Drawing.Color.FromArgb(r, g, b)
            If ColDlg.ShowDialog() = DialogResult.OK Then
                Dim c As Color = ColDlg.Color
                r = c.R
                g = c.G
                b = c.B
                If IsObjectColor Then
                    myOCCTProxy.SetColor(r, g, b)
                Else
                    myOCCTProxy.SetBackgroundColor(r, g, b)
                End If
            End If
            Me.myOCCTProxy.UpdateCurrentViewer()

        End Sub

        Public Sub DeleteObjects()
            myOCCTProxy.EraseObjects()
            Dim parent As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
            parent.SelectionChanged()
        End Sub
        Public Sub ImportModel(format As IE_WinForms.ModelFormat)
            Dim theformat As Integer = 10
            Dim openDialog As System.Windows.Forms.OpenFileDialog = New OpenFileDialog()

            Dim DataDir As String = Environment.GetEnvironmentVariable("CSF_OCCTDataPath")

            Dim filter As String = ""

            Select Case format
                Case ModelFormat.BREP
                    openDialog.InitialDirectory = (DataDir & Convert.ToString("\occ"))
                    theformat = 0
                    filter = "BREP Files (*.brep *.rle)|*.brep; *.rle"
                    Exit Select
                Case IE_WinForms.ModelFormat.[STEP]
                    openDialog.InitialDirectory = (DataDir & Convert.ToString("\step"))
                    theformat = 1
                    filter = "STEP Files (*.stp *.step)|*.stp; *.step"
                    Exit Select
                Case IE_WinForms.ModelFormat.IGES
                    openDialog.InitialDirectory = (DataDir & Convert.ToString("\iges"))
                    theformat = 2
                    filter = "IGES Files (*.igs *.iges)|*.igs; *.iges"
                    Exit Select
                Case Else
                    Exit Select
            End Select
            openDialog.Filter = filter & Convert.ToString("|All files (*.*)|*.*")
            If openDialog.ShowDialog() = DialogResult.OK Then
                Dim filename As String = openDialog.FileName
                If filename = "" Then
                    Return
                End If
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                If Not myOCCTProxy.TranslateModel(filename, theformat, True) Then
                    MessageBox.Show("Cann't read this file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Me.Cursor = System.Windows.Forms.Cursors.[Default]
            End If
            Me.myOCCTProxy.ZoomAllView()
        End Sub

        Public Sub ExportModel(format As ModelFormat)
            Dim theformat As Integer = 10
            Dim saveDialog As System.Windows.Forms.SaveFileDialog = New SaveFileDialog()
            Dim DataDir As String = Environment.GetEnvironmentVariable("CSF_OCCTDataPath")
            Dim filter As String = ""
            Select Case format
                Case IE_WinForms.ModelFormat.BREP
                    saveDialog.InitialDirectory = (DataDir & Convert.ToString("\occ"))
                    theformat = 0
                    filter = "BREP Files (*.brep *.rle)|*.brep; *.rle"
                    Exit Select
                Case IE_WinForms.ModelFormat.[STEP]
                    saveDialog.InitialDirectory = (DataDir & Convert.ToString("\step"))
                    theformat = 1
                    filter = "STEP Files (*.stp *.step)|*.step; *.stp"
                    Exit Select
                Case IE_WinForms.ModelFormat.IGES
                    saveDialog.InitialDirectory = (DataDir & Convert.ToString("\iges"))
                    theformat = 2
                    filter = "IGES Files (*.igs *.iges)| *.iges; *.igs"
                    Exit Select
                Case IE_WinForms.ModelFormat.VRML
                    saveDialog.InitialDirectory = (DataDir & Convert.ToString("\vrml"))
                    theformat = 3
                    filter = "VRML Files (*.vrml)|*.vrml"
                    Exit Select
                Case IE_WinForms.ModelFormat.STL
                    saveDialog.InitialDirectory = (DataDir & Convert.ToString("\stl"))
                    theformat = 4
                    filter = "STL Files (*.stl)|*.stl"
                    Exit Select
                Case IE_WinForms.ModelFormat.IMAGE
                    saveDialog.InitialDirectory = (DataDir & Convert.ToString("\images"))
                    theformat = 5
                    filter = "Images Files (*.bmp *.gif)| *.bmp; *.gif"
                    Exit Select
                Case Else
                    Exit Select
            End Select
            saveDialog.Filter = filter
            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim filename As String = saveDialog.FileName
                If filename = "" Then
                    Return
                End If
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                If Not myOCCTProxy.TranslateModel(filename, theformat, False) Then
                    MessageBox.Show("Cann't write this file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Me.Cursor = System.Windows.Forms.Cursors.[Default]
            End If
        End Sub

        Private Sub ContextColor_Click(sender As Object, e As System.EventArgs)
            Me.ChangeColor(True)
        End Sub

        Private Sub menuItem1_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.ChangeColor(False)
        End Sub

        Private Sub ContextWireframe_Click(sender As Object, e As System.EventArgs)
            Me.SetDisplayMode(0)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Dim parent As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
            parent.SelectionChanged()
        End Sub

        Private Sub ContextShading_Click(sender As Object, e As System.EventArgs)
            Me.SetDisplayMode(1)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Dim parent As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
            parent.SelectionChanged()
        End Sub

        Private Sub ContMenTranc_Click(sender As Object, e As System.EventArgs)
            Dim dlg As IE_WinForms.TransparencyDialog = New TransparencyDialog()
            dlg.View = Me.myOCCTProxy
            dlg.ShowDialog(Me)
        End Sub

        Private Sub ContMenDelete_Click(sender As Object, e As System.EventArgs)
            Me.DeleteObjects()
        End Sub

        Private Sub ContMatBrass_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(0)
        End Sub

        Private Sub ContMenBronze_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(1)
        End Sub

        Private Sub ContMenCopper_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(2)
        End Sub

        Private Sub ContMenGold_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(3)
        End Sub

        Private Sub ContMenPewt_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(4)
        End Sub

        Private Sub ContMenPlaster_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(5)
        End Sub

        Private Sub ContMenPlastic_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(6)
        End Sub

        Private Sub ContMenSilver_Click(sender As Object, e As System.EventArgs)
            Me.myOCCTProxy.UpdateCurrentViewer()
            Me.myOCCTProxy.SetMaterial(7)
        End Sub

        Private Sub toolBar1_MouseHover(sender As Object, e As System.EventArgs)
            Dim parent As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
            parent.StatusBar.Text = "View toolbar"

        End Sub

        Private Sub toolBar1_MouseLeave(sender As Object, e As System.EventArgs)
            Dim parent As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
            parent.StatusBar.Text = ""
        End Sub

        Private Sub myPopupObject_Popup(sender As Object, e As System.EventArgs)
            Dim mode As Integer = Me.myOCCTProxy.DisplayMode()
            Select Case mode
                Case -1
                    Exit Select
                Case 0
                    Me.ContextWireframe.Enabled = False
                    Me.ContextShading.Enabled = True
                    Me.ContMenTranc.Enabled = False
                    Exit Select
                Case 1
                    Me.ContextShading.Enabled = False
                    Me.ContextWireframe.Enabled = True
                    Me.ContMenTranc.Enabled = True
                    Exit Select
                Case 10
                    Me.ContextShading.Enabled = True


                    Me.ContextWireframe.Enabled = True
                    Me.ContMenTranc.Enabled = True
                    Exit Select
                Case Else
                    Exit Select

            End Select
        End Sub

        Public Property View() As OCCTProxy
            Get
                Return Me.myOCCTProxy
            End Get
            Set(value As OCCTProxy)
                Me.myOCCTProxy = value
            End Set
        End Property

        Public Sub InitView()
            Me.myOCCTProxy.InitOCCTProxy()
        End Sub

        Public Sub SetIndex(documentIndex As Integer, viewIndex As Integer)
            Me.myDocumentIndex = documentIndex
            Me.myViewIndex = viewIndex
            Me.Text = System.[String].Format("Document {0}:{1}", documentIndex, viewIndex)
        End Sub

        Public Sub SetNextIndex(other As Form2)
            SetIndex(other.myDocumentIndex, other.myViewIndex + 1)
        End Sub

        Public Sub SetContext(View As OCCTProxy)
            Me.myOCCTProxy.SetAISContext(View)
        End Sub

        Private Sub Form2_Closed(sender As Object, e As System.EventArgs)
            Dim parent As IE_WinForms.Form1 = DirectCast(Me.ParentForm, IE_WinForms.Form1)
            parent.OnFileClose()
        End Sub

        Public Property Mode() As CurrentAction3d
            Get
                Return Me.myCurrentMode
            End Get
            Set(value As CurrentAction3d)
                Me.myCurrentMode = value
            End Set
        End Property

        Public WriteOnly Property Zoom() As Single
            Set(value As Single)
                Me.myCurZoom = value
            End Set
        End Property

        Public Property DegenerateMode() As Boolean
            Get
                Return Me.myDegenerateModeIsOn
            End Get
            Set(value As Boolean)
                Me.myDegenerateModeIsOn = value
            End Set
        End Property

    End Class

'End Namespace

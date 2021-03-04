
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

'Namespace IE_WinForms
    ''' <summary>
    ''' Summary description for MaterialDialog.
    ''' </summary>
    Public Class MaterialDialog
        Inherits System.Windows.Forms.Form
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            Me.myView = Nothing
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
            Dim resources As New System.Resources.ResourceManager(GetType(MaterialDialog))
            Me.BTN_PLASTER = New System.Windows.Forms.Button()
            Me.BTN_BRASS = New System.Windows.Forms.Button()
            Me.BTN_BRONZE = New System.Windows.Forms.Button()
            Me.BTN_COPPER = New System.Windows.Forms.Button()
            Me.BTN_GOLD = New System.Windows.Forms.Button()
            Me.BTN_PEWTER = New System.Windows.Forms.Button()
            Me.BTN_PLASTIC = New System.Windows.Forms.Button()
            Me.BTN_SILVER = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' BTN_PLASTER
            ' 
            Me.BTN_PLASTER.Location = New System.Drawing.Point(16, 8)
            Me.BTN_PLASTER.Name = "BTN_PLASTER"
            Me.BTN_PLASTER.Size = New System.Drawing.Size(80, 24)
            Me.BTN_PLASTER.TabIndex = 0
            Me.BTN_PLASTER.Text = "Plaster"
            AddHandler Me.BTN_PLASTER.Click, AddressOf Me.button1_Click
            ' 
            ' BTN_BRASS
            ' 
            Me.BTN_BRASS.Location = New System.Drawing.Point(16, 40)
            Me.BTN_BRASS.Name = "BTN_BRASS"
            Me.BTN_BRASS.Size = New System.Drawing.Size(80, 24)
            Me.BTN_BRASS.TabIndex = 1
            Me.BTN_BRASS.Text = "Brass"
            AddHandler Me.BTN_BRASS.Click, AddressOf Me.BTN_BRASS_Click
            ' 
            ' BTN_BRONZE
            ' 
            Me.BTN_BRONZE.Location = New System.Drawing.Point(16, 72)
            Me.BTN_BRONZE.Name = "BTN_BRONZE"
            Me.BTN_BRONZE.Size = New System.Drawing.Size(80, 24)
            Me.BTN_BRONZE.TabIndex = 2
            Me.BTN_BRONZE.Text = "Bronze"
            AddHandler Me.BTN_BRONZE.Click, AddressOf Me.BTN_BRONZE_Click
            ' 
            ' BTN_COPPER
            ' 
            Me.BTN_COPPER.Location = New System.Drawing.Point(16, 104)
            Me.BTN_COPPER.Name = "BTN_COPPER"
            Me.BTN_COPPER.Size = New System.Drawing.Size(80, 24)
            Me.BTN_COPPER.TabIndex = 3
            Me.BTN_COPPER.Text = "Copper"
            AddHandler Me.BTN_COPPER.Click, AddressOf Me.BTN_COPPER_Click
            ' 
            ' BTN_GOLD
            ' 
            Me.BTN_GOLD.Location = New System.Drawing.Point(16, 136)
            Me.BTN_GOLD.Name = "BTN_GOLD"
            Me.BTN_GOLD.Size = New System.Drawing.Size(80, 24)
            Me.BTN_GOLD.TabIndex = 4
            Me.BTN_GOLD.Text = "Gold"
            AddHandler Me.BTN_GOLD.Click, AddressOf Me.BTN_GOLD_Click
            ' 
            ' BTN_PEWTER
            ' 
            Me.BTN_PEWTER.Location = New System.Drawing.Point(16, 168)
            Me.BTN_PEWTER.Name = "BTN_PEWTER"
            Me.BTN_PEWTER.Size = New System.Drawing.Size(80, 24)
            Me.BTN_PEWTER.TabIndex = 5
            Me.BTN_PEWTER.Text = "Pewter"
            AddHandler Me.BTN_PEWTER.Click, AddressOf Me.BTN_PEWTER_Click
            ' 
            ' BTN_PLASTIC
            ' 
            Me.BTN_PLASTIC.Location = New System.Drawing.Point(16, 200)
            Me.BTN_PLASTIC.Name = "BTN_PLASTIC"
            Me.BTN_PLASTIC.Size = New System.Drawing.Size(80, 24)
            Me.BTN_PLASTIC.TabIndex = 6
            Me.BTN_PLASTIC.Text = "Plastic"
            AddHandler Me.BTN_PLASTIC.Click, AddressOf Me.BTN_PLASTIC_Click
            ' 
            ' BTN_SILVER
            ' 
            Me.BTN_SILVER.Location = New System.Drawing.Point(16, 232)
            Me.BTN_SILVER.Name = "BTN_SILVER"
            Me.BTN_SILVER.Size = New System.Drawing.Size(80, 24)
            Me.BTN_SILVER.TabIndex = 7
            Me.BTN_SILVER.Text = "Silver"
            AddHandler Me.BTN_SILVER.Click, AddressOf Me.BTN_SILVER_Click
            ' 
            ' MaterialDialog
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(112, 273)
            Me.Controls.Add(Me.BTN_SILVER)
            Me.Controls.Add(Me.BTN_PLASTIC)
            Me.Controls.Add(Me.BTN_PEWTER)
            Me.Controls.Add(Me.BTN_GOLD)
            Me.Controls.Add(Me.BTN_COPPER)
            Me.Controls.Add(Me.BTN_BRONZE)
            Me.Controls.Add(Me.BTN_BRASS)
            Me.Controls.Add(Me.BTN_PLASTER)
            Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MaterialDialog"
            Me.Text = "MaterialDialog"
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private BTN_PLASTER As System.Windows.Forms.Button
        Private BTN_BRASS As System.Windows.Forms.Button
        Private BTN_BRONZE As System.Windows.Forms.Button
        Private BTN_COPPER As System.Windows.Forms.Button
        Private BTN_GOLD As System.Windows.Forms.Button
        Private BTN_PEWTER As System.Windows.Forms.Button
        Private BTN_PLASTIC As System.Windows.Forms.Button
        Private BTN_SILVER As System.Windows.Forms.Button

        Private myMaterial As Integer
        Private myView As OCCTProxy

        Private Sub button1_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 5
            ChangeMaterial()
        End Sub

        Private Sub BTN_BRASS_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 0
            ChangeMaterial()
        End Sub

        Private Sub BTN_BRONZE_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 1
            ChangeMaterial()
        End Sub

        Private Sub BTN_COPPER_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 2
            ChangeMaterial()
        End Sub

        Private Sub BTN_GOLD_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 3
            ChangeMaterial()
        End Sub

        Private Sub BTN_PEWTER_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 4
            ChangeMaterial()
        End Sub

        Private Sub BTN_PLASTIC_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 6
            ChangeMaterial()
        End Sub

        Private Sub BTN_SILVER_Click(sender As Object, e As System.EventArgs)
            Me.myMaterial = 7
            ChangeMaterial()
        End Sub

        Public Property Material() As Integer
            Get
                Return Me.myMaterial
            End Get
            Set(value As Integer)
                Me.myMaterial = value
            End Set
        End Property

        Public Sub ChangeMaterial()
            If myView Is Nothing Then
                Return
            End If
            myView.SetMaterial(Me.myMaterial)

        End Sub

        Public WriteOnly Property View() As OCCTProxy
            Set(value As OCCTProxy)
                Me.myView = value
            End Set
        End Property

    End Class
'End Namespace

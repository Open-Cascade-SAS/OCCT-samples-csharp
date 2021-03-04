
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

'Namespace IE_WinForms
    ''' <summary>
    ''' Summary description for TransparencyDialog.
    ''' </summary>
    Public Class TransparencyDialog
        Inherits System.Windows.Forms.Form
        Private MyTransparency As System.Windows.Forms.NumericUpDown
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
        Private myView As OCCTProxy

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            myView = Nothing
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
            Dim resources As New System.Resources.ResourceManager(GetType(TransparencyDialog))
            Me.MyTransparency = New System.Windows.Forms.NumericUpDown()
            DirectCast(Me.MyTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' MyTransparency
            ' 
            Me.MyTransparency.Location = New System.Drawing.Point(16, 16)
            Me.MyTransparency.Maximum = New System.Decimal(New Integer() {10, 0, 0, 0})
            Me.MyTransparency.Name = "MyTransparency"
            Me.MyTransparency.Size = New System.Drawing.Size(96, 20)
            Me.MyTransparency.TabIndex = 0
            AddHandler Me.MyTransparency.ValueChanged, AddressOf Me.MyTransparency_ValueChanged
            ' 
            ' TransparencyDialog
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(128, 53)
            Me.Controls.Add(Me.MyTransparency)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "TransparencyDialog"
            Me.Text = "TransparencyDialog"
            DirectCast(Me.MyTransparency, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private Sub MyTransparency_ValueChanged(sender As Object, e As System.EventArgs)
            If Me.myView Is Nothing Then
                Return
            End If
            Dim transp As Integer = CInt(Me.MyTransparency.Value)
            Me.myView.SetTransparency(transp)
        End Sub

        Public WriteOnly Property View() As OCCTProxy
            Set(value As OCCTProxy)
                Me.myView = value
            End Set
        End Property

    End Class
'End Namespace


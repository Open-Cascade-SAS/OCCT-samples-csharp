<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutDialog))
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.myVersion = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(-6, 191)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(296, 24)
        Me.label4.TabIndex = 11
        Me.label4.Text = "http://www.opencascade.com"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(10, 159)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(280, 23)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Copyright (C) 2004-2013, Open CASCADE S.A.S"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'myVersion
        '
        Me.myVersion.Location = New System.Drawing.Point(2, 23)
        Me.myVersion.Name = "myVersion"
        Me.myVersion.Size = New System.Drawing.Size(288, 16)
        Me.myVersion.TabIndex = 9
        Me.myVersion.Text = "Open CASCADE Technology "
        Me.myVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(288, 24)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Import/Export Sample,"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(82, 239)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(128, 24)
        Me.button1.TabIndex = 7
        Me.button1.Text = "OK"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(45, 55)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(196, 102)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'AboutDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.myVersion)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "AboutDialog"
        Me.Text = "About Import/Export Sample"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents myVersion As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
End Class

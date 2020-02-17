<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PictureBox1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PictureBox1))
        Me.PicBox2 = New System.Windows.Forms.PictureBox()
        Me.PicBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.PicBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicBox2
        '
        Me.PicBox2.Image = CType(resources.GetObject("PicBox2.Image"), System.Drawing.Image)
        Me.PicBox2.Location = New System.Drawing.Point(16, 40)
        Me.PicBox2.Name = "PicBox2"
        Me.PicBox2.Size = New System.Drawing.Size(233, 276)
        Me.PicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox2.TabIndex = 0
        Me.PicBox2.TabStop = False
        '
        'PicBox3
        '
        Me.PicBox3.Location = New System.Drawing.Point(266, 40)
        Me.PicBox3.Name = "PicBox3"
        Me.PicBox3.Size = New System.Drawing.Size(233, 276)
        Me.PicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox3.TabIndex = 1
        Me.PicBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "This Picture From Properties"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "This Picture From Coding"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Location = New System.Drawing.Point(-1, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(516, 54)
        Me.Panel2.TabIndex = 23
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(432, 11)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 33)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "E&xit"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(514, 395)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PicBox3)
        Me.Controls.Add(Me.PicBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PictureBox1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PictureBox1"
        CType(Me.PicBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class

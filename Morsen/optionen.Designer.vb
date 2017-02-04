<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class optionen
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkopt1 = New System.Windows.Forms.CheckBox()
        Me.checkopt3 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.checkopt4 = New System.Windows.Forms.CheckBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "An"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(13, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DOT Länge"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(13, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DASH Länge"
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 2
        Me.TrackBar1.Location = New System.Drawing.Point(202, 199)
        Me.TrackBar1.Maximum = 6
        Me.TrackBar1.Minimum = 2
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.Value = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Zeit für Eingabe eines Buchstaben"
        '
        'checkopt1
        '
        Me.checkopt1.AutoSize = True
        Me.checkopt1.Checked = True
        Me.checkopt1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkopt1.Location = New System.Drawing.Point(16, 33)
        Me.checkopt1.Name = "checkopt1"
        Me.checkopt1.Size = New System.Drawing.Size(140, 17)
        Me.checkopt1.TabIndex = 9
        Me.checkopt1.Text = "kontinuierliches Morsen:"
        Me.checkopt1.UseVisualStyleBackColor = True
        '
        'checkopt3
        '
        Me.checkopt3.AutoSize = True
        Me.checkopt3.Checked = True
        Me.checkopt3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkopt3.Location = New System.Drawing.Point(16, 59)
        Me.checkopt3.Name = "checkopt3"
        Me.checkopt3.Size = New System.Drawing.Size(163, 17)
        Me.checkopt3.TabIndex = 9
        Me.checkopt3.Text = "Standard DOT/DASH Länge"
        Me.checkopt3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Countdown Zeit (in Sekunden)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(203, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "kurz                   lang"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(173, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TrackBar2
        '
        Me.TrackBar2.LargeChange = 100
        Me.TrackBar2.Location = New System.Drawing.Point(202, 253)
        Me.TrackBar2.Maximum = 500
        Me.TrackBar2.Minimum = 10
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar2.SmallChange = 10
        Me.TrackBar2.TabIndex = 13
        Me.TrackBar2.Value = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(203, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "10                      500"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(166, 253)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 13)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.Text = "120"
        '
        'TrackBar4
        '
        Me.TrackBar4.LargeChange = 1
        Me.TrackBar4.Location = New System.Drawing.Point(82, 89)
        Me.TrackBar4.Maximum = 5
        Me.TrackBar4.Minimum = 1
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(224, 45)
        Me.TrackBar4.TabIndex = 13
        Me.TrackBar4.Value = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "kurz                                                       lang"
        '
        'TrackBar3
        '
        Me.TrackBar3.LargeChange = 2
        Me.TrackBar3.Location = New System.Drawing.Point(82, 138)
        Me.TrackBar3.Minimum = 2
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(224, 45)
        Me.TrackBar3.TabIndex = 13
        Me.TrackBar3.Value = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "kurz                                                       lang"
        '
        'checkopt4
        '
        Me.checkopt4.AutoSize = True
        Me.checkopt4.Checked = True
        Me.checkopt4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkopt4.Location = New System.Drawing.Point(16, 298)
        Me.checkopt4.Name = "checkopt4"
        Me.checkopt4.Size = New System.Drawing.Size(86, 17)
        Me.checkopt4.TabIndex = 16
        Me.checkopt4.Text = "Tonausgabe"
        Me.checkopt4.UseVisualStyleBackColor = True
        '
        'optionen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 401)
        Me.Controls.Add(Me.checkopt4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar4)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.checkopt3)
        Me.Controls.Add(Me.checkopt1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "optionen"
        Me.Text = "Optionen | JTS Morsen"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents checkopt1 As System.Windows.Forms.CheckBox
    Friend WithEvents checkopt3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TrackBar4 As System.Windows.Forms.TrackBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents checkopt4 As System.Windows.Forms.CheckBox
End Class

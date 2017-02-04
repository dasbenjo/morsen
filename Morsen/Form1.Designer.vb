<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtStart = New System.Windows.Forms.Button()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.btloeschen = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetzwerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlphabetAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buzzer = New System.Windows.Forms.PictureBox()
        Me.IntroCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Buzzer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtStart
        '
        Me.BtStart.Location = New System.Drawing.Point(12, 27)
        Me.BtStart.Name = "BtStart"
        Me.BtStart.Size = New System.Drawing.Size(147, 39)
        Me.BtStart.TabIndex = 0
        Me.BtStart.Text = "Start"
        Me.BtStart.UseVisualStyleBackColor = True
        '
        'tb1
        '
        Me.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb1.Enabled = False
        Me.tb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.Location = New System.Drawing.Point(12, 72)
        Me.tb1.Multiline = True
        Me.tb1.Name = "tb1"
        Me.tb1.ReadOnly = True
        Me.tb1.Size = New System.Drawing.Size(637, 72)
        Me.tb1.TabIndex = 1
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'tb2
        '
        Me.tb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tb2.Enabled = False
        Me.tb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2.Location = New System.Drawing.Point(12, 145)
        Me.tb2.Multiline = True
        Me.tb2.Name = "tb2"
        Me.tb2.ReadOnly = True
        Me.tb2.Size = New System.Drawing.Size(637, 265)
        Me.tb2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "verbleibende Zeit:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "120"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sekunden"
        Me.Label3.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 500
        '
        'btloeschen
        '
        Me.btloeschen.Location = New System.Drawing.Point(165, 27)
        Me.btloeschen.Name = "btloeschen"
        Me.btloeschen.Size = New System.Drawing.Size(147, 39)
        Me.btloeschen.TabIndex = 1
        Me.btloeschen.Text = "Text löschen"
        Me.btloeschen.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(679, 610)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(326, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Morsen.My.Resources.Resources.alphabet
        Me.PictureBox1.Location = New System.Drawing.Point(679, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(326, 506)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Morsen.My.Resources.Resources.header
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.AnsichtToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetzwerkToolStripMenuItem, Me.OptionenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'NetzwerkToolStripMenuItem
        '
        Me.NetzwerkToolStripMenuItem.Enabled = False
        Me.NetzwerkToolStripMenuItem.Name = "NetzwerkToolStripMenuItem"
        Me.NetzwerkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NetzwerkToolStripMenuItem.Text = "Netzwerk"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OptionenToolStripMenuItem.Text = "Optionen"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'AnsichtToolStripMenuItem
        '
        Me.AnsichtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlphabetAnzeigenToolStripMenuItem})
        Me.AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem"
        Me.AnsichtToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AnsichtToolStripMenuItem.Text = "Ansicht"
        '
        'AlphabetAnzeigenToolStripMenuItem
        '
        Me.AlphabetAnzeigenToolStripMenuItem.Checked = True
        Me.AlphabetAnzeigenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AlphabetAnzeigenToolStripMenuItem.Name = "AlphabetAnzeigenToolStripMenuItem"
        Me.AlphabetAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AlphabetAnzeigenToolStripMenuItem.Text = "Morsetabelle anzeigen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HilfeToolStripMenuItem1, Me.ÜberToolStripMenuItem1})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'HilfeToolStripMenuItem1
        '
        Me.HilfeToolStripMenuItem1.Name = "HilfeToolStripMenuItem1"
        Me.HilfeToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.HilfeToolStripMenuItem1.Text = "Hilfe"
        '
        'ÜberToolStripMenuItem1
        '
        Me.ÜberToolStripMenuItem1.Name = "ÜberToolStripMenuItem1"
        Me.ÜberToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.ÜberToolStripMenuItem1.Text = "Über"
        '
        'Buzzer
        '
        Me.Buzzer.Enabled = False
        Me.Buzzer.Image = Global.Morsen.My.Resources.Resources.Morsetaste
        Me.Buzzer.Location = New System.Drawing.Point(12, 416)
        Me.Buzzer.Name = "Buzzer"
        Me.Buzzer.Size = New System.Drawing.Size(637, 320)
        Me.Buzzer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buzzer.TabIndex = 9
        Me.Buzzer.TabStop = False
        '
        'IntroCheck
        '
        Me.IntroCheck.Enabled = True
        Me.IntroCheck.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(318, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 42)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "10"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(374, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 42)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sekunden"
        Me.Label5.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.btloeschen)
        Me.Controls.Add(Me.BtStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Buzzer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "Form1"
        Me.Text = "JTS Morsen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Buzzer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtStart As System.Windows.Forms.Button
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents btloeschen As System.Windows.Forms.Button
    Friend WithEvents AlphabetAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Buzzer As System.Windows.Forms.PictureBox
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntroCheck As System.Windows.Forms.Timer
    Friend WithEvents NetzwerkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

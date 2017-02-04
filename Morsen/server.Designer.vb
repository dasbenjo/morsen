<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class server
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmdconnect = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbadresse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbservermorsen = New System.Windows.Forms.TextBox()
        Me.tbhistory = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtchat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioclient = New System.Windows.Forms.RadioButton()
        Me.radioserver = New System.Windows.Forms.RadioButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdconnect)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbadresse)
        Me.SplitContainer1.Panel1.Enabled = False
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbservermorsen)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbhistory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtchat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(646, 320)
        Me.SplitContainer1.SplitterDistance = 253
        Me.SplitContainer1.TabIndex = 2
        '
        'cmdconnect
        '
        Me.cmdconnect.Location = New System.Drawing.Point(9, 129)
        Me.cmdconnect.Name = "cmdconnect"
        Me.cmdconnect.Size = New System.Drawing.Size(106, 23)
        Me.cmdconnect.TabIndex = 8
        Me.cmdconnect.Text = "Server verbinden"
        Me.cmdconnect.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(6, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Mit Server verbunden"
        Me.Label6.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bestehendem" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Server beitreten"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LAN IP-Adresse (Bsp.: 192.168.2.100)"
        '
        'tbadresse
        '
        Me.tbadresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbadresse.Location = New System.Drawing.Point(8, 68)
        Me.tbadresse.Name = "tbadresse"
        Me.tbadresse.Size = New System.Drawing.Size(234, 20)
        Me.tbadresse.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(3, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Server erfolgreich gestartet"
        '
        'tbservermorsen
        '
        Me.tbservermorsen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbservermorsen.Enabled = False
        Me.tbservermorsen.Location = New System.Drawing.Point(3, 173)
        Me.tbservermorsen.Multiline = True
        Me.tbservermorsen.Name = "tbservermorsen"
        Me.tbservermorsen.Size = New System.Drawing.Size(383, 114)
        Me.tbservermorsen.TabIndex = 0
        '
        'tbhistory
        '
        Me.tbhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbhistory.Enabled = False
        Me.tbhistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbhistory.Location = New System.Drawing.Point(3, 29)
        Me.tbhistory.Multiline = True
        Me.tbhistory.Name = "tbhistory"
        Me.tbhistory.Size = New System.Drawing.Size(383, 94)
        Me.tbhistory.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "LAN IP-Adresse:"
        '
        'txtchat
        '
        Me.txtchat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtchat.Enabled = False
        Me.txtchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchat.Location = New System.Drawing.Point(3, 129)
        Me.txtchat.Name = "txtchat"
        Me.txtchat.Size = New System.Drawing.Size(383, 38)
        Me.txtchat.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Eigener selbst gehosteter Server"
        '
        'radioclient
        '
        Me.radioclient.AutoSize = True
        Me.radioclient.Location = New System.Drawing.Point(20, 29)
        Me.radioclient.Name = "radioclient"
        Me.radioclient.Size = New System.Drawing.Size(86, 17)
        Me.radioclient.TabIndex = 3
        Me.radioclient.Text = "Client Modus"
        Me.radioclient.UseVisualStyleBackColor = True
        '
        'radioserver
        '
        Me.radioserver.AutoSize = True
        Me.radioserver.Checked = True
        Me.radioserver.Location = New System.Drawing.Point(272, 29)
        Me.radioserver.Name = "radioserver"
        Me.radioserver.Size = New System.Drawing.Size(91, 17)
        Me.radioserver.TabIndex = 3
        Me.radioserver.TabStop = True
        Me.radioserver.Text = "Server Modus"
        Me.radioserver.UseVisualStyleBackColor = True
        '
        'server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(670, 385)
        Me.Controls.Add(Me.radioserver)
        Me.Controls.Add(Me.radioclient)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "server"
        Me.Text = "Netzwerk | JTS Morsen"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbadresse As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdconnect As System.Windows.Forms.Button
    Friend WithEvents txtchat As System.Windows.Forms.TextBox
    Friend WithEvents tbservermorsen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioclient As System.Windows.Forms.RadioButton
    Friend WithEvents radioserver As System.Windows.Forms.RadioButton
    Friend WithEvents tbhistory As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

'Copyright (C) 2015 Benjamin Witte

'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.




Public Class Form1
    'Variablen:
    Dim x1 As Integer = 0 'Variable für Timer 1
    Dim x2 As Integer = 0 'Variable für Timer 2

    'Beim öffnen vom Programm:
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        var.opt1 = My.Settings.opt1
        var.opt2 = My.Settings.opt2
        var.opt3 = My.Settings.opt3
        var.dot = My.Settings.dot
        var.dash = My.Settings.dash
        var.opt4 = My.Settings.opt4
        var.opt5 = My.Settings.opt5

        'einmal piepen, um beep zu laden
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        'Funktion für Anpassung der Elemente an Größe
        anpassen()

        'deaktivieren der Netzwerk Funktion
        NetzwerkToolStripMenuItem.Enabled = True
        My.Computer.Audio.Stop()
    End Sub

    Function anpassen()
        tb2.Height = Me.Height * 0.36
        Buzzer.Location = New Point(Buzzer.Location.X, (tb2.Location.Y + tb2.Height + 10))
        PictureBox1.Height = Me.Height * 0.66
        PictureBox2.Location = New Point(PictureBox2.Location.X, (PictureBox1.Location.Y + PictureBox1.Height + 30))
        PictureBox2.Height = Me.Height * 0.1
        'Breite
        PictureBox1.Width = Me.Width * 0.32
        PictureBox2.Width = Me.Width * 0.32
    End Function


    'Startbutton
    Private Sub BtStart_Click(sender As Object, e As EventArgs) Handles BtStart.Click
        Timer3.Enabled = True
        Label1.Show()
        Label2.Text = var.opt2
        Label2.Show()
        Label3.Show()
        Cursor.Position = New Point(Buzzer.Location.X + 150, Buzzer.Location.Y + 100)
        Cursor.Hide()
        Timer4.Enabled = True
        BtStart.Text = "Drücke ESC für Stopp"
        btloeschen.Hide()
        Buzzer.Enabled = True
    End Sub

    'Aktion wenn Morsetaste gedrückt wird
    Private Sub tb1_MouseDown(sender As Object, e As MouseEventArgs) Handles Buzzer.MouseDown
        If var.opt4 = True Then
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        End If
        morsegeschwindigkeit()
        Timer1.Enabled = True
        Timer2.Enabled = False
        Buzzer.Image = My.Resources.Morsetaste2
    End Sub

    Function morsegeschwindigkeit()
        'automatische Berechnung der Morsegeschwindigkeit
    End Function

    'Aktion wenn Morsetaste losgelassen wird
    Private Sub tb1_MouseUp(sender As Object, e As MouseEventArgs) Handles Buzzer.MouseUp
        Buzzer.Image = My.Resources.Morsetaste
        Timer1.Enabled = False
        Timer2.Enabled = True 'prüfen ob Buchstabe vorbei ist
        If x1 < var.dot + 1 Then
            tb1.Text = tb1.Text + ". "
        Else
            tb1.Text = tb1.Text + "_ "
        End If
        'Timer zurücksetzen
        x1 = 0
        'Tonausgabe beenden
        My.Computer.Audio.Stop()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x1 = x1 + 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        x2 = x2 + 1
        If x2 = var.opt3 Then 'Länge für Dauer von Buchstabe
            x2 = 0 'Variable zurücksetzen
            buchstabe() 'Funktion Berechnung Buchstabe
            'Wenn Server aktiv dann weitersenden
            If server.Label6.Visible = True Then
                server.SendMessage()
            End If
            'Strichcode Textbox wird zurückgesetzt
            tb1.Text = ""
        End If
    End Sub




    'Funktion für Berechnung von Buchstaben
    Function buchstabe()
        If tb1.Text = ". " Then
            tb2.Text = tb2.Text + "E"
        ElseIf tb1.Text = "_ " Then
            tb2.Text = tb2.Text + "T"
        ElseIf tb1.Text = "" Then
            If var.opt1 = True Then
                tb2.Text = tb2.Text + " "
            Else : tb2.Text = tb2.Text + ""
            End If
        ElseIf tb1.Text = "_ _ " Then
            tb2.Text = tb2.Text + "M"
        ElseIf tb1.Text = "_ . " Then
            tb2.Text = tb2.Text + "N"
        ElseIf tb1.Text = ". _ " Then
            tb2.Text = tb2.Text + "A"
        ElseIf tb1.Text = ". . " Then
            tb2.Text = tb2.Text + "I"
        ElseIf tb1.Text = "_ _ _ " Then
            tb2.Text = tb2.Text + "O"
        ElseIf tb1.Text = "_ _ . " Then
            tb2.Text = tb2.Text + "G"
        ElseIf tb1.Text = "_ . _ " Then
            tb2.Text = tb2.Text + "K"
        ElseIf tb1.Text = "_ . . " Then
            tb2.Text = tb2.Text + "D"
        ElseIf tb1.Text = ". _ _ " Then
            tb2.Text = tb2.Text + "W"
        ElseIf tb1.Text = ". _ . " Then
            tb2.Text = tb2.Text + "R"
        ElseIf tb1.Text = ". . _ " Then
            tb2.Text = tb2.Text + "U"
        ElseIf tb1.Text = ". . . " Then
            tb2.Text = tb2.Text + "S"
        ElseIf tb1.Text = "_ . . . " Then
            tb2.Text = tb2.Text + "B"
        ElseIf tb1.Text = ". _ _ _ " Then
            tb2.Text = tb2.Text + "J"
        ElseIf tb1.Text = "_ . . _ " Then
            tb2.Text = tb2.Text + "X"
        ElseIf tb1.Text = ". . . . " Then
            tb2.Text = tb2.Text + "H"
        ElseIf tb1.Text = ". _ _ . " Then
            tb2.Text = tb2.Text + "P"
        ElseIf tb1.Text = "_ . _ . " Then
            tb2.Text = tb2.Text + "C"
        ElseIf tb1.Text = ". _ . _ " Then
            tb2.Text = tb2.Text + "Ä"
        ElseIf tb1.Text = "_ . _ _ " Then
            tb2.Text = tb2.Text + "Y"
        ElseIf tb1.Text = ". _ . . " Then
            tb2.Text = tb2.Text + "L"
        ElseIf tb1.Text = "_ _ . . " Then
            tb2.Text = tb2.Text + "Z"
        ElseIf tb1.Text = ". . _ _ " Then
            tb2.Text = tb2.Text + "Ü"
        ElseIf tb1.Text = "_ _ . _ " Then
            tb2.Text = tb2.Text + "Q"
        ElseIf tb1.Text = ". . _ . " Then
            tb2.Text = tb2.Text + "F"
        ElseIf tb1.Text = ". . . _ " Then
            tb2.Text = tb2.Text + "V"
        ElseIf tb1.Text = "_ _ _ . " Then
            tb2.Text = tb2.Text + "Ö"
        ElseIf tb1.Text = "_ _ _ _ " Then
            tb2.Text = tb2.Text + "CH"
        ElseIf tb1.Text = "_ _ _ _ _ " Then
            tb2.Text = tb2.Text + "0"
        ElseIf tb1.Text = ". _ _ _ _ " Then
            tb2.Text = tb2.Text + "1"
        ElseIf tb1.Text = ". . _ _ _ " Then
            tb2.Text = tb2.Text + "2"
        ElseIf tb1.Text = ". . . _ _ " Then
            tb2.Text = tb2.Text + "3"
        ElseIf tb1.Text = ". . . . _ " Then
            tb2.Text = tb2.Text + "4"
        ElseIf tb1.Text = ". . . . . " Then
            tb2.Text = tb2.Text + "5"
        ElseIf tb1.Text = "_ . . . . " Then
            tb2.Text = tb2.Text + "6"
        ElseIf tb1.Text = "_ _ . . . " Then
            tb2.Text = tb2.Text + "7"
        ElseIf tb1.Text = "_ _ _ . . " Then
            tb2.Text = tb2.Text + "8"
        ElseIf tb1.Text = "_ _ _ _ . " Then
            tb2.Text = tb2.Text + "9"
        ElseIf tb1.Text = "_ . . . . _ " Then
            tb2.Text = tb2.Text + "-"
        ElseIf tb1.Text = "_ . . _ . " Then
            tb2.Text = tb2.Text + "/"
        ElseIf tb1.Text = ". _ . _ . _ " Then
            tb2.Text = tb2.Text + "."
        ElseIf tb1.Text = ". . . _ _ . . " Then
            tb2.Text = tb2.Text + "ß"
        ElseIf tb1.Text = ". . . . . . . . " Then
            If tb2.Text = "" Then
                tb2.Text = ""
            Else
                tb2.Text = tb2.Text.Remove(tb2.Text.Length - 1, 1)
            End If

        ElseIf tb1.Text = "_ . . . _ " Then
            tb2.Text = tb2.Text + " "
        Else : tb2.Text = tb2.Text + "?"

        End If

    End Function


    'Countdown Timer
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label2.Text = Convert.ToInt32(Label2.Text) - 1
        Label4.Text = Convert.ToInt32(Label4.Text) - 1

        If Convert.ToInt32(Label2.Text) = 0 Then 'wenn bei 0 angelangt hört der Timer auf
            final()

        ElseIf Convert.ToInt32(Label2.Text) = 10 Then
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = True
            Label4.Text = "10"
            Label5.Visible = True
        End If
    End Sub

    'Funktion entweder Abbruch oder ende Countdown
    Function final()
        Timer4.Enabled = False
        Timer3.Enabled = False
        Timer2.Enabled = False
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Cursor.Show()
        BtStart.Text = "Start"
        btloeschen.Show()
        Buzzer.Enabled = False
        tb1.Text = ""
        Label4.Visible = False
        Label5.Visible = False
        My.Computer.Audio.Stop()
    End Function

    'oberes Menü
    Private Sub OptionenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionenToolStripMenuItem.Click
        optionen.Show()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Timer für Cursor Position
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Cursor.Position = New Point(Buzzer.Location.X + 150, Buzzer.Location.Y + 100)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Timer4.Enabled = True Then
                final()
            End If

        ElseIf e.KeyCode = Keys.Delete Then
            tb2.Text = ""
        ElseIf e.KeyCode = Keys.Back Then
            If tb2.Text = "" Then
                tb2.Text = ""
            Else
                tb2.Text = tb2.Text.Remove(tb2.Text.Length - 1, 1)
            End If
        End If
    End Sub

    'Text Löschen mit Button
    Private Sub btloeschen_Click(sender As Object, e As EventArgs) Handles btloeschen.Click
        tb2.Text = ""
    End Sub

    Private Sub AlphabetAnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlphabetAnzeigenToolStripMenuItem.Click
        If PictureBox1.Visible = True Then
            PictureBox1.Hide()
            AlphabetAnzeigenToolStripMenuItem.Checked = False
        Else : PictureBox1.Show()
            AlphabetAnzeigenToolStripMenuItem.Checked = True
        End If

    End Sub


    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        anpassen()
    End Sub


    Private Sub ÜberToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÜberToolStripMenuItem1.Click
        ueber.Show()
    End Sub

    Private Sub HilfeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HilfeToolStripMenuItem1.Click
        intro.Show()
        intro.Checkshowup.Visible = False
        intro.Text = "Hilfe | JTS Morsen"
    End Sub

    'Startet Intro/Einführung
    Private Sub IntroCheck_Tick(sender As Object, e As EventArgs) Handles IntroCheck.Tick
        'Einführung wird geöffnet (abhängig von Einstellung)
        If var.opt5 = True Then
            intro.Show()

        End If
        IntroCheck.Enabled = False
        My.Computer.Audio.Stop()
    End Sub

    Private Sub NetzwerkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetzwerkToolStripMenuItem.Click
        'server.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Server wird gestoppt und geschlossen
        var.stopserver = True
        server.Close()
        Application.Exit()
    End Sub
End Class

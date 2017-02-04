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

Public Class optionen

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub



    Private Sub checkopt1_CheckedChanged(sender As Object, e As EventArgs) Handles checkopt1.CheckedChanged
        If checkopt1.Checked = False Then
            var.opt1 = False
            My.Settings.opt1 = var.opt1
            Label1.Text = "Aus"
        Else : var.opt1 = True
            My.Settings.opt1 = var.opt1
            Label1.Text = "An"
        End If
    End Sub


    Private Sub checkopt3_CheckedChanged(sender As Object, e As EventArgs) Handles checkopt3.CheckedChanged
        If checkopt3.Checked = False Then
            Label2.Enabled = True
            Label3.Enabled = True
            Label8.Enabled = True
            Label9.Enabled = True
            TrackBar3.Enabled = True
            TrackBar4.Enabled = True
        Else : var.dot = 1
            var.dash = 5
            My.Settings.dot = var.dot
            My.Settings.dash = var.dash
            Label2.Enabled = False
            Label3.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
            TrackBar4.Enabled = False
            TrackBar3.Enabled = False
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        var.opt3 = TrackBar1.Value 'Zeit für Eingabe eines Buchstaben
        My.Settings.opt3 = var.opt3
    End Sub

    'OK Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Textbox eingabe speichern
        Me.Hide()
    End Sub


    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        var.opt2 = TrackBar2.Value 'Countdown Zeit (in Sekunden)
        TextBox3.Text = TrackBar2.Value
        My.Settings.opt2 = var.opt2
    End Sub

    'Änderung DOT Länge
    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        var.dot = TrackBar4.Value
        My.Settings.dot = var.dot
    End Sub
    'Änderung DASH Länge
    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        var.dash = TrackBar3.Value
        My.Settings.dash = var.dash
    End Sub

    'Richtige Einstellungen laden
    Private Sub optionen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar3.Value = var.dash
        TrackBar4.Value = var.dot
        TrackBar2.Value = var.opt2 'Countdown Zeit (in Sekunden)
        TextBox3.Text = TrackBar2.Value
        TrackBar1.Value = var.opt3  'Zeit für Eingabe eines Buchstaben
        If var.dot = 1 And var.dash = 5 Then
            Label2.Enabled = False
            Label3.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
            TrackBar4.Enabled = False
            TrackBar3.Enabled = False
            checkopt3.Checked = True

        Else : Label2.Enabled = True
            Label3.Enabled = True
            Label8.Enabled = True
            Label9.Enabled = True
            TrackBar3.Enabled = True
            TrackBar4.Enabled = True
        End If
        'If var.opt1 = True Then
        '    checkopt1.Checked = False
        '    Label1.Text = "Aus"
        'Else : checkopt1.Checked = True
        '    Label1.Text = "An"
        'End If
    End Sub
    ' Ton Einstellung An oder Aus
    Private Sub checkopt4_CheckedChanged(sender As Object, e As EventArgs) Handles checkopt4.CheckedChanged
        If checkopt4.Checked = False Then
            var.opt4 = False
            checkopt4.Checked = False
        Else
            var.opt4 = True
            checkopt4.Checked = True
        End If
    End Sub
End Class
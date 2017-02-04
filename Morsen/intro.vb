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


Public Class intro
    ' Variablen:
    Dim counter As Integer = 1
    Private Sub Checkshowup_CheckedChanged(sender As Object, e As EventArgs) Handles Checkshowup.CheckedChanged
        My.Settings.opt5 = False
    End Sub

    Private Sub intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If counter = 1 Then
            Label3.Visible = True
            PictureBox4.Visible = True
            PictureBox6.Visible = True
            counter = 2
        ElseIf counter = 2 Then
            PictureBox6.Visible = False
            Label5.Visible = True
            PictureBox3.Visible = True
            counter = 3
        ElseIf counter = 3 Then
            PictureBox7.Visible = True
            Label7.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
            counter = 4
        ElseIf counter = 4 Then
            PictureBox8.Visible = True
            Label6.Visible = True
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            counter = 5
        ElseIf counter = 5 Then
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            Label4.Visible = True
            PictureBox2.Visible = True
            Button1.Enabled = False
        End If
    End Sub
End Class
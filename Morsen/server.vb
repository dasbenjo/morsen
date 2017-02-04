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



Public Class server
    'SERVER Code
    Private Server As TCPControl


    Private Sub server_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Wenn Server beendet werden soll
        If var.stopserver = True Then
            Server.IsListening = False
        End If
        var.server = True
        'Wenn Server nur "minimiert" werden soll
        If var.stopserver = False Then
            e.Cancel = True
            Me.Visible = False
        End If
    End Sub

    Private Sub server_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        var.stopserver = False
        Label4.Text = Label4.Text + Convert.ToString(System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0))
        If var.server = False Then
            Server = New TCPControl
            tbservermorsen.Text = ":: SERVER gestartet ::" & vbCrLf

            AddHandler Server.MessageReceived, AddressOf OnLineReceived
        End If
    End Sub

    ' ALLOW THREAD TO COMMUNICATE WITH FORM CONTROL
    Private Delegate Sub UpdateTextDelegate(TB As TextBox, txt As String)

    ' UPDATE TEXTBOX
    Private Sub UpdateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.Text = txt 'TB.AppendText(txt & vbCrLf)
            tbhistory.Text = tbhistory.Text + txtchat.Text + "  "
            buchstabe()
        End If
    End Sub

    ' UPDATE TEXT WHEN DATA IS RECEIVED
    Private Sub OnLineReceived(sender As TCPControl, Data As String)
        UpdateText(txtchat, Data)

    End Sub


    'Client Code
    Private Client As TCPControlClient



    Private Sub cmdConnect_Click(sender As System.Object, e As System.EventArgs) Handles cmdconnect.Click
        If tbadresse.Text = "" Then
            Dim IPADDR As System.Net.IPAddress
            IPADDR = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0)
            tbadresse.Text = IPADDR.ToString()
        End If
        Client = New TCPControlClient(tbadresse.Text, 64555)
        If Client.Client.Connected Then
            Label6.Visible = True
            cmdconnect.Enabled = False
            tbadresse.Enabled = False
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Label6.Visible = True Then
            If Client.Client.Connected = True Then
                Client.DataStream.Close()
                Client.Client.Close()
            End If
        End If
        
    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendMessage()
    End Sub

    Public Sub SendMessage()
        If Client.Client.Connected = True Then Client.Send(Form1.tb1.Text)
    End Sub


    Private Sub radioclient_CheckedChanged(sender As Object, e As EventArgs) Handles radioserver.CheckedChanged, radioclient.CheckedChanged
        If radioclient.Checked = True Then
            SplitContainer1.Panel1.Enabled = True
            SplitContainer1.Panel2.Enabled = False
        Else
            SplitContainer1.Panel1.Enabled = False
            SplitContainer1.Panel2.Enabled = True
        End If
    End Sub


    'Funktion zur Berechnung des Buchstabens
    Function buchstabe()
        If txtchat.Text = ". " Then
            tbservermorsen.Text = tbservermorsen.Text + "E"
        ElseIf txtchat.Text = "_ " Then
            tbservermorsen.Text = tbservermorsen.Text + "T"
        ElseIf txtchat.Text = "" Then
            If var.opt1 = True Then
                tbservermorsen.Text = tbservermorsen.Text + " "
            Else : tbservermorsen.Text = tbservermorsen.Text + ""
            End If
        ElseIf txtchat.Text = "_ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "M"
        ElseIf txtchat.Text = "_ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "N"
        ElseIf txtchat.Text = ". _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "A"
        ElseIf txtchat.Text = ". . " Then
            tbservermorsen.Text = tbservermorsen.Text + "I"
        ElseIf txtchat.Text = "_ _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "O"
        ElseIf txtchat.Text = "_ _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "G"
        ElseIf txtchat.Text = "_ . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "K"
        ElseIf txtchat.Text = "_ . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "D"
        ElseIf txtchat.Text = ". _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "W"
        ElseIf txtchat.Text = ". _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "R"
        ElseIf txtchat.Text = ". . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "U"
        ElseIf txtchat.Text = ". . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "S"
        ElseIf txtchat.Text = "_ . . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "B"
        ElseIf txtchat.Text = ". _ _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "J"
        ElseIf txtchat.Text = "_ . . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "X"
        ElseIf txtchat.Text = ". . . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "H"
        ElseIf txtchat.Text = ". _ _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "P"
        ElseIf txtchat.Text = "_ . _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "C"
        ElseIf txtchat.Text = ". _ . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "Ä"
        ElseIf txtchat.Text = "_ . _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "Y"
        ElseIf txtchat.Text = ". _ . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "L"
        ElseIf txtchat.Text = "_ _ . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "Z"
        ElseIf txtchat.Text = ". . _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "Ü"
        ElseIf txtchat.Text = "_ _ . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "Q"
        ElseIf txtchat.Text = ". . _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "F"
        ElseIf txtchat.Text = ". . . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "V"
        ElseIf txtchat.Text = "_ _ _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "Ö"
        ElseIf txtchat.Text = "_ _ _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "CH"
        ElseIf txtchat.Text = "_ _ _ _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "0"
        ElseIf txtchat.Text = ". _ _ _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "1"
        ElseIf txtchat.Text = ". . _ _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "2"
        ElseIf txtchat.Text = ". . . _ _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "3"
        ElseIf txtchat.Text = ". . . . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "4"
        ElseIf txtchat.Text = ". . . . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "5"
        ElseIf txtchat.Text = "_ . . . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "6"
        ElseIf txtchat.Text = "_ _ . . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "7"
        ElseIf txtchat.Text = "_ _ _ . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "8"
        ElseIf txtchat.Text = "_ _ _ _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "9"
        ElseIf txtchat.Text = "_ . . . . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "-"
        ElseIf txtchat.Text = "_ . . _ . " Then
            tbservermorsen.Text = tbservermorsen.Text + "/"
        ElseIf txtchat.Text = ". _ . _ . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + "."
        ElseIf txtchat.Text = ". . . _ _ . . " Then
            tbservermorsen.Text = tbservermorsen.Text + "ß"
        ElseIf txtchat.Text = ". . . . . . . . " Then
            If tbservermorsen.Text = "" Then
                tbservermorsen.Text = ""
            Else
                tbservermorsen.Text = tbservermorsen.Text.Remove(tbservermorsen.Text.Length - 1, 1)
            End If

        ElseIf txtchat.Text = "_ . . . _ " Then
            tbservermorsen.Text = tbservermorsen.Text + " "
        Else : tbservermorsen.Text = tbservermorsen.Text + "?"

        End If

    End Function


End Class
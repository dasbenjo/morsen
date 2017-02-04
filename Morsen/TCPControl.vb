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



Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class TCPControl
    Public Event MessageReceived(sender As TCPControl, Data As String)
    
    ' SERVER CONFIG
    Public ServerIP As IPAddress = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0)
    Public ServerPort As Integer = 64555
    Public Server As TcpListener

    Private CommThread As Thread
    Public IsListening As Boolean = True

    ' CLIENTS
    Private Client As TcpClient
    Private ClientData As StreamReader

    Public Sub New()
        Server = New TcpListener(ServerIP, ServerPort)
        Server.Start()

        CommThread = New Thread(New ThreadStart(AddressOf Listening))
        CommThread.Start()
    End Sub

    Private Sub Listening()
        ' mache LISTENER LOOP
        Do Until IsListening = False
            ' incoming connections akzeptieren
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)

            End If

            ' Event für eingehende Nachrichten
            Try
                RaiseEvent MessageReceived(Me, ClientData.ReadLine)
            Catch ex As Exception

            End Try
        Loop
    End Sub
End Class

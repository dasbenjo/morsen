﻿'Copyright (C) 2015 Benjamin Witte

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

Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class TCPControlClient
    Public Client As TcpClient
    Public DataStream As StreamWriter

    Public Sub New(Host As String, Port As Integer)
        ' CLIENT
        Client = New TcpClient(Host, Port)
        DataStream = New StreamWriter(Client.GetStream)
    End Sub

    Public Sub Send(Data As String)
        DataStream.Write(Data & vbCrLf)
        DataStream.Flush()
    End Sub
End Class

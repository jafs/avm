Imports System.Net
Imports System.Net.Sockets
Imports System.Text

''' Proyecto: AVM
''' Autor: José Antonio Fuentes Santiago
''' Versión: 0.5
''' Fecha: 29/06/2012
''' <summary>Clase que implementa una conexión Telnet para emuladores Android.</summary>
Public Class AndTelnet
    ''' <summary>Dirección IP de conexión a la máquina virtual.</summary>
    Dim objDireccionIp As IPAddress
    ''' <summary>Puerto de conexión a la máquina virtual.</summary>
    Dim iPuerto As Integer
    ''' <summary>Objeto de conexión a la máquina virtual.</summary>
    Dim objConexion As IPEndPoint
    ''' <summary>Socket de conexión a la máquina virtual.</summary>
    Dim objSocket As Socket
    ''' <summary>Indica si se ha establecido conexión.</summary>
    Dim bConexion As Boolean = False

    ''' <summary>Dirección IP por defecto.</summary>
    Const DEF_DIRECCION As String = "127.0.0.1"
    ''' <summary>Puerto de conexión por defecto.</summary>
    Const DEF_PUERTO As Integer = 5554


    ' ''' <summary>
    ' ''' Constructor por defecto para la clase.
    ' ''' </summary>
    ' ''' <param name="iPuerto">Puerto de conexión a la máquina virtual.</param>
    ' ''' <param name="sDireccion">Dirección de conexión a la máquina virtual.</param>
    'Public Sub New(ByVal iPuerto As Integer, ByRef sDireccion As String)
    '    Me.iPuerto = iPuerto
    '    Try
    '        objDireccionIp = IPAddress.Parse(sDireccion)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    ''' <summary>
    ''' Obtiene el puerto de conexión a la máquina virtual.
    ''' </summary>
    ''' <value>Puerto de conexión.</value>
    ''' <returns>Devuelve el puerto de conexión.</returns>
    Public Property Puerto() As Integer
        Get
            Return iPuerto
        End Get
        Set(ByVal iPuertoR As Integer)
            iPuerto = iPuertoR
        End Set
    End Property


    ''' <summary>
    ''' Realiza una conexión con la máquina virtual Android.
    ''' </summary>
    Public Function conectar() As String
        ' Cadena con la respuesta del servidor.
        Dim sResultado As String = String.Empty

        ' Extra la dirección IP, que de momento será fija
        objDireccionIp = IPAddress.Parse(DEF_DIRECCION)

        ' Crea un punto de conexión con la dirección IP y el puerto recibido. En caso
        ' de que el puerto recibido sea nulo se establecerá un valor por defecto.
        If iPuerto = 0 Then
            objConexion = New IPEndPoint(objDireccionIp, DEF_PUERTO)
        Else
            objConexion = New IPEndPoint(objDireccionIp, iPuerto)
        End If

        Try
            ' Crea y conecta el socket
            objSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            objSocket.Connect(objConexion)
        Catch oEX As SocketException
            MessageBox.Show("Error: " + oEX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return sResultado
        End Try

        ' Create a byte array for recieving bytes from the telnet socket
        Dim RecvBytes(255) As [Byte]

        ' If we get to here then all seems good (we are connected)
        Try
            ' Double check we are connected
            If objSocket.Connected Then
                ' Data returned from the telnet socet
                Dim sRecibido As String = String.Empty
                ' NumBytes: Number of bytes return from telnet socket (count)
                Dim NumBytes As Integer = 0
                bConexion = True

                ' loop getting 256 bytes of data from telnet socket at a time
                Do
                    ' RecvBytes with contain 256 bytes if data returned
                    ' numbytes with have the count of bytes returned
                    NumBytes = objSocket.Receive(RecvBytes, RecvBytes.Length, 0)
                    sRecibido = sRecibido + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
                Loop While Not sRecibido.EndsWith("OK" + vbCrLf) And Not sRecibido.EndsWith("KO" + vbCrLf)

                ' Send recieved bytes to the output text box
                sResultado += sRecibido

                ' Cleanup
                sRecibido = Nothing
            End If
        Catch oEX As Exception
            ' Error cleanup etc needed
        End Try

        Return sResultado
    End Function



    ''' <summary>
    ''' Realiza la desconexión del socket.
    ''' </summary>
    Public Sub desconectar()
        If Not objSocket Is Nothing Then
            If objSocket.Connected Then
                objSocket.Close()
            End If
            objSocket = Nothing
        End If
    End Sub


    ''' <summary>
    ''' Realiza una consulta a la máquina virtual.
    ''' </summary>
    ''' <param name="sComando">Comando a consultar.</param>
    ''' <returns>Cadena con el resultado de la consulta.</returns>
    Public Function consultar(ByVal sComando As String) As String
        ' Datos recibidos del socket.
        Dim sRecibido As String = String.Empty

        If 0 < sComando.Length And Not objSocket Is Nothing Then
            ' Número de bytes recibidos desde el socket.
            Dim iNumBytes As Integer = 0
            ' Array de bytes utilizado como buffer de lectura.
            Dim arbRecibidos(255) As [Byte]
            ' Convierte el comando ASCII en un array de bytes.
            Dim arbEnviados As [Byte]() = Encoding.ASCII.GetBytes(sComando & vbCrLf)

            ' Ejecución del comando
            Try
                ' Double check we are connected
                If objSocket.Connected Then
                    ' Ejecuta el comando
                    objSocket.Send(arbEnviados, arbEnviados.Length, SocketFlags.None)

                    sRecibido = String.Empty

                    ' Obtiene el resultado en bloques de 256 bytes.
                    Do
                        ' RecvBytes with contain 256 bytes if data returned
                        ' numbytes with have the count of bytes returned
                        iNumBytes = objSocket.Receive(arbRecibidos, arbRecibidos.Length, 0)
                        sRecibido += Encoding.ASCII.GetString(arbRecibidos, 0, iNumBytes)
                    Loop While Not sRecibido.EndsWith("OK" + vbCrLf) And Not sRecibido.Contains("KO:")
                    sRecibido = sRecibido.Replace(vbLf, vbNewLine)
                Else
                    MessageBox.Show("El Socket se ha desconectado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conectar()
                End If
            Catch oEX As Exception
                ' Error cleanup etc needed
            End Try

            ' Cleanup
            sComando = Nothing
        ElseIf objSocket Is Nothing Then
            MessageBox.Show("El Socket se ha desconectado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conectar()
        Else
            MessageBox.Show("Introduce un comando", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return sRecibido
    End Function
End Class

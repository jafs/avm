Public Class AndroidStatus
    ''' <summary>Enumeración de estados de carga.</summary>
    Enum PowStatus
        ''' <summary>Valor de energía desconocido.</summary>
        Unknown
        ''' <summary>Valor de energía cargando.</summary>
        Charging
        ''' <summary>Valor de energía descargando.</summary>
        Discharging
        ''' <summary>Valor de energía lleno.</summary>
        Full
        ''' <summary>Valor de energía no cargando.</summary>
        Not_charging
    End Enum

    ''' <summary>Enumeración de salid de la batería.</summary>
    Enum PowHealth
        ''' <summary>Valor de salud desconocida.</summary>
        Unknown
        ''' <summary>Valor de salud buena.</summary>
        Good
        ''' <summary>Valor de salud cuando la temperatura es alta.</summary>
        Overheat
        ''' <summary>Valor de salud para una batería rota.</summary>
        Dead
        ''' <summary>Valor de salud para sobretensión.</summary>
        Overvoltage
        ''' <summary>Valor de salud con fallo.</summary>
        Failure
    End Enum

    ''' <summary>Enumeración de estados GSM.</summary>
    Enum GsmStatus
        ''' <summary>Valor de estado de conexión correcta.</summary>
        home
        ''' <summary>Valor de estado de sin conexión.</summary>
        unregistered
        ''' <summary>Valor de estado en modo roaming.</summary>
        roaming
        ''' <summary>Valor de estado de búsqueda.</summary>
        searching
        ''' <summary>Valor de estado de conexión denegada.</summary>
        denied
        ''' <summary>Valor de estado cuando está apagado el GSM.</summary>
        off
        ''' <summary>Valor de estado cuando está activo el GSM.</summary>
        g_on
    End Enum

    ''' <summary>Fecha de generación de la configuración.</summary>
    Private objCurrentDate As Date = Date.Now

    ''' <summary>Indica si hay conexión con corriente alterna.</summary>
    Private bPowerAc As Boolean = False
    ''' <summary>Indica el estado de carga.</summary>
    Private enPowerStatus As PowStatus = PowStatus.unknown
    ''' <summary>Indica la salud de la batería.</summary>
    Private enPowerHealth As PowHealth = PowHealth.unknown
    ''' <summary>Indica si hay batería presente.</summary>
    Private bPowerPresent As Boolean = False
    ''' <summary>Indica la capacidad de carga de la batería.</summary>
    Private iPowerCapacity As Integer = 0

    ''' <summary>Indica el estado de conexión GSM para datos.</summary>
    Private enGsmData As GsmStatus = GsmStatus.unregistered
    ''' <summary>Indica el estado de conexión GSM para voz.</summary>
    Private enGsmVoice As GsmStatus = GsmStatus.unregistered

    ''' <summary>Indica el valor del sensor de aceleración.</summary>
    ''' <remarks>Especificar descripción de ejes.</remarks>
    Private ardSensorAcceleration() As Double = {0, 0, 0}
    ''' <summary>Indica el valor del sensor de campo magnético.</summary>
    ''' <remarks>Especificar descripción de ejes.</remarks>
    Private ardSensorMagnetic() As Double = {0, 0, 0}
    ''' <summary>Indica el valor del sensor de orientación.</summary>
    ''' <remarks>Especificar descripción de ejes.</remarks>
    Private ardSensorOrientation() As Double = {0, 0, 0}
    ''' <summary>Indica el valor del sensor de proximidad.</summary>
    Private iSensorProximity As Integer = 0
    ''' <summary>Indica el valor del sensor de temperatura.</summary>
    Private iSensorTemperature As Integer = 0


    ''' <summary>Propiedad de fecha de generación de la configuración.</summary>
    ''' <value>Valor de fecha a establecer.</value>
    ''' <returns>Valor de fecha actual.</returns>
    Public Property CurrentDate() As Date
        Get
            Return objCurrentDate
        End Get
        Set(ByVal value As Date)
            objCurrentDate = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para indicar si hay corriente AC.</summary>
    ''' <value>Valor de estado de corrient AC a establecer.</value>
    ''' <returns>Valor de estado de corriente AC actual.</returns>
    Public Property PowerAc() As Boolean
        Get
            Return bPowerAc
        End Get
        Set(ByVal value As Boolean)
            bPowerAc = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para estado de carga de energía.</summary>
    ''' <value>Valor de estado de carga de energía a establecer.</value>
    ''' <returns>Valor de estado de carga de energía actual.</returns>
    Public Property PowerStatus As PowStatus
        Get
            Return enPowerStatus
        End Get
        Set(ByVal value As PowStatus)
            enPowerStatus = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para estado de la batería.</summary>
    ''' <value>Valor de estado de batería a establecer.</value>
    ''' <returns>Valor de estado de batería actual.</returns>
    Public Property PowerHealth As PowHealth
        Get
            Return enPowerHealth
        End Get
        Set(ByVal value As PowHealth)
            enPowerHealth = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para conexión de batería.</summary>
    ''' <value>Valor de conexión de batería a establecer.</value>
    ''' <returns>Valor de conexión de batería actual.</returns>
    Public Property PowerPresent As Boolean
        Get
            Return bPowerPresent
        End Get
        Set(ByVal value As Boolean)
            bPowerPresent = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para capacidad de la batería.</summary>
    ''' <value>Valor de capacidad de batería a establecer.</value>
    ''' <returns>Valor de capacidad de batería actual.</returns>
    Public Property PowerCapacity As Integer
        Get
            Return iPowerCapacity
        End Get
        Set(ByVal value As Integer)
            iPowerCapacity = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para el estado de datos GSM.</summary>
    ''' <value>Valor de estado de datos GSM a establecer.</value>
    ''' <returns>Valor de estado de datos GSM actual.</returns>
    Public Property GsmData As GsmStatus
        Get
            Return enGsmData
        End Get
        Set(ByVal value As GsmStatus)
            enGsmData = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para el estado de voz GSM.</summary>
    ''' <value>Valor de estado de voz GSM a establecer.</value>
    ''' <returns>Valor de estado de voz GSM actual.</returns>
    Public Property GsmVoice As GsmStatus
        Get
            Return enGsmVoice
        End Get
        Set(ByVal value As GsmStatus)
            enGsmVoice = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para el sensor de aceleración.</summary>
    ''' <value>Valor del sensor de aceleración a establecer.</value>
    ''' <returns>Valor del sensor de aceleración actual.</returns>
    Public Property SensorAcceleration As Double()
        Get
            Return ardSensorAcceleration
        End Get
        Set(ByVal value As Double())
            ardSensorAcceleration = value
        End Set
    End Property


    ''' <summary>Obtiene una cadena con formato x:y:z para el sensor de aceleración.</summary>
    ''' <returns>Cadena con el valor actual del sensor de aceleración.</returns>>
    Public Function getSensorAcceleration() As String
        Dim result As String = String.Empty

        For i As Integer = 0 To 2
            result &= ardSensorAcceleration(i) & ":"
        Next

        Return result.Substring(0, result.Length - 1)
    End Function


    ''' <summary>Propiedad de valores para el sensor de campo magnético.</summary>
    ''' <value>Valor del sensor de campo magnético a establecer.</value>
    ''' <returns>Valor del sensor de campo magnético actual.</returns>
    Public Property SensorMagnetic As Double()
        Get
            Return ardSensorMagnetic
        End Get
        Set(ByVal value As Double())
            ardSensorMagnetic = value
        End Set
    End Property


    ''' <summary>Obtiene una cadena con formato x:y:z para el sensor de campo magnético.</summary>
    ''' <returns>Cadena con el valor actual del sensor de campo magnético.</returns>>
    Public Function getSensorMagnetic() As String
        Dim result As String = String.Empty

        For i As Integer = 0 To 2
            result &= ardSensorMagnetic(i) & ":"
        Next

        Return result.Substring(0, result.Length - 1)
    End Function


    ''' <summary>Propiedad de valores para el sensor de orientación.</summary>
    ''' <value>Valor del sensor de orientación a establecer.</value>
    ''' <returns>Valor del sensor de orientación actual.</returns>
    Public Property SensorOrientation As Double()
        Get
            Return ardSensorOrientation
        End Get
        Set(ByVal value As Double())
            ardSensorOrientation = value
        End Set
    End Property


    ''' <summary>Obtiene una cadena con formato x:y:z para el sensor de orientación.</summary>
    ''' <returns>Cadena con el valor actual del sensor de orientación.</returns>
    Public Function getSensorOrientation() As String
        Dim result As String = String.Empty

        For i As Integer = 0 To 2
            result &= ardSensorOrientation(i) & ":"
        Next

        Return result.Substring(0, result.Length - 1)
    End Function


    ''' <summary>Propiedad de valores para el sensor de proximidad.</summary>
    ''' <value>Valor del sensor de proximidad a establecer.</value>
    ''' <returns>Valor del sensor de proximidad actual.</returns>
    Public Property SensorProximity As Integer
        Get
            Return iSensorProximity
        End Get
        Set(ByVal value As Integer)
            iSensorProximity = value
        End Set
    End Property


    ''' <summary>Propiedad de valores para el sensor de temperatura</summary>
    ''' <value>Valor de sensor a establecer.</value>
    ''' <returns>Valor de sensor de temperatura a devolver.</returns>
    Public Property SensorTemperature As Integer
        Get
            Return iSensorTemperature
        End Get
        Set(ByVal value As Integer)
            iSensorTemperature = value
        End Set
    End Property


    ''' <summary>Obtiene el estado de carga del sistema a partir de su nombre.</summary>
    ''' <param name="valor">Valor por el que buscar el estado.</param>
    ''' <returns>Valor de carga de energía actual.</returns>
    Public Shared Function getPowerStatus(ByVal valor As String) As PowStatus
        Dim enEstado As PowStatus = PowStatus.unknown

        If Not valor Is Nothing And valor.Length > 0 Then
            Select Case valor
                Case "Charging"
                    enEstado = PowStatus.charging
                Case "Discharging"
                    enEstado = PowStatus.discharging
                Case "Not-charging"
                    enEstado = PowStatus.not_charging
                Case "Full"
                    enEstado = PowStatus.full
            End Select
        End If

        Return enEstado
    End Function


    ''' <summary>Obtiene el valor de salud de la batería a partir de su nombre.</summary>
    ''' <param name="valor">Cadena con el valor de salud de la batería.</param>
    ''' <returns>Valor de salud de la batería obtenido.</returns>
    Public Shared Function getPowerHealth(ByVal valor As String) As PowHealth
        Dim enSalud As PowHealth = PowHealth.Unknown

        Try
            enSalud = CType([Enum].Parse(GetType(PowHealth), valor), PowHealth)
        Catch exception As Exception
        End Try

        Return enSalud
    End Function


    ''' <summary>Obtiene el valor de salud de la batería a partir de su nombre.</summary>
    ''' <param name="valor">Cadena con el valor de salud de la batería.</param>
    ''' <returns>Valor de salud de la batería obtenido.</returns>
    Public Shared Function getGsmStatus(ByVal valor As String) As GsmStatus
        Dim enEstado As GsmStatus = GsmStatus.off

        Try
            If valor = "on" Then
                enEstado = GsmStatus.g_on
            Else
                enEstado = CType([Enum].Parse(GetType(GsmStatus), valor), GsmStatus)
            End If
        Catch exception As Exception
        End Try

        Return enEstado
    End Function
End Class

Public Class AndroidStatus
    ''' <summary>Enumeración de estados de carga.</summary>
    Enum PowStatus
        ''' <summary>Valor de energía desconocido.</summary>
        unknown
        ''' <summary>Valor de energía cargando.</summary>
        charging
        ''' <summary>Valor de energía descargando.</summary>
        discharging
        ''' <summary>Valor de energía lleno.</summary>
        full
        ''' <summary>Valor de energía no cargando.</summary>
        not_charging
    End Enum

    ''' <summary>Enumeración de salid de la batería.</summary>
    Enum PowHealth
        ''' <summary>Valor de salud desconocida.</summary>
        unknown
        ''' <summary>Valor de salud buena.</summary>
        good
        ''' <summary>Valor de salud cuando la temperatura es alta.</summary>
        overheat
        ''' <summary>Valor de salud para una batería rota.</summary>
        dead
        ''' <summary>Valor de salud para sobretensión.</summary>
        overvoltage
        ''' <summary>Valor de salud con fallo.</summary>
        failure
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
    Private ardSensorMagnetic() As Double = {0, 0, 0}
    Private ardSensorOrientation() As Double = {0, 0, 0}
    Private iSensorProximity As Integer = 0
    Private iSensorTemperature As Integer = 0


    Public Property CurrentDate() As Date
        Get
            Return objCurrentDate
        End Get
        Set(ByVal value As Date)
            objCurrentDate = value
        End Set
    End Property

    Public Property PowerAc() As Boolean
        Get
            Return bPowerAc
        End Get
        Set(ByVal value As Boolean)
            bPowerAc = value
        End Set
    End Property

    Public Property PowerStatus As PowStatus
        Get
            Return enPowerStatus
        End Get
        Set(ByVal value As PowStatus)
            enPowerStatus = value
        End Set
    End Property

    Public Property PowerHealth As PowHealth
        Get
            Return enPowerHealth
        End Get
        Set(ByVal value As PowHealth)
            enPowerHealth = value
        End Set
    End Property

    Public Property PowerPresent As Boolean
        Get
            Return bPowerPresent
        End Get
        Set(ByVal value As Boolean)
            bPowerPresent = value
        End Set
    End Property

    Public Property PowerCapacity As Integer
        Get
            Return iPowerCapacity
        End Get
        Set(ByVal value As Integer)
            iPowerCapacity = value
        End Set
    End Property

    Public Property GsmData As GsmStatus
        Get
            Return enGsmData
        End Get
        Set(ByVal value As GsmStatus)
            enGsmData = value
        End Set
    End Property

    Public Property GsmVoice As GsmStatus
        Get
            Return enGsmVoice
        End Get
        Set(ByVal value As GsmStatus)
            enGsmVoice = value
        End Set
    End Property

    Public Property SensorAcceleration As Double()
        Get
            Return ardSensorAcceleration
        End Get
        Set(ByVal value As Double())
            ardSensorAcceleration = value
        End Set
    End Property

    Public Function getSensorAcceleration() As String
        Dim result As String = String.Empty

        For i As Integer = 0 To 2
            result &= ardSensorAcceleration(i) & ":"
        Next

        Return result.Substring(0, result.Length - 1)
    End Function

    Public Property SensorMagnetic As Double()
        Get
            Return ardSensorMagnetic
        End Get
        Set(ByVal value As Double())
            ardSensorMagnetic = value
        End Set
    End Property

    Public Function getSensorMagnetic() As String
        Dim result As String = String.Empty

        For i As Integer = 0 To 2
            result &= ardSensorMagnetic(i) & ":"
        Next

        Return result.Substring(0, result.Length - 1)
    End Function

    Public Property SensorOrientation As Double()
        Get
            Return ardSensorOrientation
        End Get
        Set(ByVal value As Double())
            ardSensorOrientation = value
        End Set
    End Property

    Public Function getSensorOrientation() As String
        Dim result As String = String.Empty

        For i As Integer = 0 To 2
            result &= ardSensorOrientation(i) & ":"
        Next

        Return result.Substring(0, result.Length - 1)
    End Function

    Public Property SensorProximity As Integer
        Get
            Return iSensorProximity
        End Get
        Set(ByVal value As Integer)
            iSensorProximity = value
        End Set
    End Property

    Public Property SensorTemperature As Integer
        Get
            Return iSensorTemperature
        End Get
        Set(ByVal value As Integer)
            iSensorTemperature = value
        End Set
    End Property
End Class

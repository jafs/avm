''' <summary>Clase que contiene todos los comandos utlizados por la máquina virtual.</summary>
Public NotInheritable Class Comando
    ' ######################################
    ' COMANDOS
    ' ######################################
    ''' <summary>Comando de envío de posición GPS.</summary>
    Public Const GEO_FIX As String = "geo fix "

    ''' <summary>Comando de activación de carga AC.</summary>
    Public Const POWER_AC_ON As String = "power ac on"
    ''' <summary>Comando de desactivación de carga AC.</summary>
    Public Const POWER_AC_OFF As String = "power ac off"
    ''' <summary>Estado de carga.</summary>
    Public Const POWER_STATUS As String = "power status "
    ''' <summary>Indica si hay una batería presente.</summary>
    Public Const POWER_PRESENT As String = "power present "
    ''' <summary>Salud de la batería.</summary>
    Public Const POWER_HEALTH As String = "power health "
    ''' <summary>Cpaacidad de la batería.</summary>
    Public Const POWER_CAPACITY As String = "power capacity "
    ''' <summary>Comando que muestra la información de energía.</summary>
    Public Const POWER_DISPLAY As String = "power display"

    ''' <summary>Comando que establece los valores de un sensor.</summary>
    Public Const SENSOR_SET As String = "sensor set "
    ''' <summary>Comando que obtiene los valores de un sensor.</summary>
    Public Const SENSOR_GET As String = "sensor get "

    ''' <summary>Comando de envío en un sms en modo texto.</summary>
    Public Const SMS_SEND As String = "sms send "

    ''' <summary>Comando que establece la llamada indicada como la activa.</summary>
    Public Const GSM_ACCEPT As String = "gsm accept "
    ''' <summary>Comando que pide que la llamada indicada finalice como si estuviera ocupada.</summary>
    Public Const GSM_BUSY As String = "gsm busy "
    ''' <summary>Comando de realización de llamada.</summary>
    Public Const GSM_CALL As String = "gsm call "
    ''' <summary>Comando que cancela la llamda especificada.</summary>
    Public Const GSM_CANCEL As String = "gsm cancel "
    ''' <summary>Comando de cambio de estado de conexión de datos.</summary>
    Public Const GSM_DATA As String = "gsm data "
    ''' <summary>Comando que pone en espera la llamada especificada.</summary>
    Public Const GSM_HOLD As String = "gsm hold "
    ''' <summary>Comando que obtiene la lista de llamadas actual.</summary>
    Public Const GSM_LIST As String = "gsm list"
    ''' <summary>Comando de establecimiento de señal GSM.</summary>
    Public Const GSM_SIGNAL As String = "gsm signal "
    ''' <summary>Comando de consulta de estado GSM.</summary>
    Public Const GSM_STATUS As String = "gsm status"
    ''' <summary>Comando de cambio de estado de conexión de voz.</summary>
    Public Const GSM_VOICE As String = "gsm voice "

    ''' <summary>Comando de eliminación de captura.</summary>
    Public Const AVM_SNAPSHOT_DEL As String = "avd snapshot del"
    ''' <summary>Comando de obtención de lista de capturas.</summary>
    Public Const AVM_SNAPSHOT_LIST As String = "avd snapshot list"
    ''' <summary>Comando de carga captura.</summary>
    Public Const AVM_SNAPSHOT_LOAD As String = "avd snapshot load"
    ''' <summary>Comando de guardado de capturas.</summary>
    Public Const AVM_SNAPSHOT_SAVE As String = "avd snapshot save"


    ' ######################################
    ' PARÁMETROS
    ' ######################################
    ''' <summary>Indica un nivel de señal GSM desconocido.</summary>
    Public Const GSM_SIGNAL_UNKNOWN As Integer = 99

    ''' <summary>Nombre del sensor de aceleración.</summary>
    Public Const SEN_ACCELERATION As String = "acceleration"
    ''' <summary>Nombre del sensor de campo magnético.</summary>
    Public Const SEN_MAGNETIC_FIELD As String = "magnetic-field"
    ''' <summary>Nombre del sensor de orientación.</summary>
    Public Const SEN_ORIENTATION As String = "orientation"
    ''' <summary>Nombre del sensor de temperatura.</summary>
    Public Const SEN_TEMPERATURE As String = "temperature"
    ''' <summary>Nombre del sensor de proximidad.</summary>
    Public Const SEN_PROXIMITY As String = "proximity"


    ' ######################################
    ' VALORES
    ' ######################################
    ''' <summary>Valor de error cuando falta un parámetro.</summary>
    Public Const AVD_ERR_ARGUMENT As String = "KO: argument missing"

    ''' <summary>Constructor privado para evitar instancias.</summary>
    Private Sub New()
    End Sub
End Class

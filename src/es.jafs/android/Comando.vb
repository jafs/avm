''' <summary>Clase que contiene todos los comandos utlizados por la máquina virtual.</summary>
Public Class Comando
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

End Class

Imports System.Xml

''' <summary>
''' Clase para generación y lectura de ficheros XML de configuración de Android.
''' </summary>
Public Class AndroidXml
    ''' <summary>Almacena en un fichero XML la configuración recibida.</summary>
    ''' <param name="status">Objecto que contiene el estado a almacenar.</param>
    ''' <param name="file">Fichero en el que guardar los resultados.</param>
    Public Shared Sub saveXml(ByRef status As AndroidStatus, ByRef file As String)
        If Not Nothing Is file And file.Length > 0 Then
            ' Configuración de XML. Nos permite tabular los elementos.
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            ' Creación del escritor XML.
            Using writer As XmlWriter = XmlWriter.Create(file, settings)
                ' Elemento raíz.
                writer.WriteStartDocument()
                writer.WriteStartElement("configuration")
                writer.WriteAttributeString("date", status.CurrentDate.ToString)

                ' Sección Batería
                writer.WriteStartElement("section")
                writer.WriteAttributeString("name", "power")
                addProperty(writer, "power_ac", status.PowerAc.ToString)
                addProperty(writer, "power_status", status.PowerStatus.ToString)
                addProperty(writer, "power_health", status.PowerHealth.ToString)
                addProperty(writer, "power_present", status.PowerPresent.ToString)
                addProperty(writer, "power_capacity", status.PowerCapacity.ToString)
                writer.WriteEndElement()

                ' Sección GSM
                writer.WriteStartElement("section")
                writer.WriteAttributeString("name", "gsm")

                If status.GsmData = AndroidStatus.GsmStatus.g_on Then
                    addProperty(writer, "gsm_data", "on")
                Else
                    addProperty(writer, "gsm_data", status.GsmData.ToString)
                End If
                If status.GsmVoice = AndroidStatus.GsmStatus.g_on Then
                    addProperty(writer, "gsm_voice", "on")
                Else
                    addProperty(writer, "gsm_voice", status.GsmVoice.ToString)
                End If
                writer.WriteEndElement()

                ' Sección Sensores
                writer.WriteStartElement("section")
                writer.WriteAttributeString("name", "sensors")
                addProperty(writer, "sensor_acceleration", status.getSensorAcceleration())
                addProperty(writer, "sensor_magnetic", status.getSensorMagnetic())
                addProperty(writer, "sensor_orientation", status.getSensorOrientation())
                addProperty(writer, "sensor_proximity", status.SensorProximity.ToString)
                addProperty(writer, "sensor_temperature", status.SensorTemperature.ToString)
                writer.WriteEndElement()

                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
        End If
    End Sub


    ''' <summary>Añade una propiedad al documento XML cuyo escritor se ha recibido.</summary>
    ''' <param name="writer">Objecto que contiene el escritor.</param>
    ''' <param name="name">Nombre de la propiedad.</param>
    ''' <param name="value">Valor de la propiedad</param>
    Private Shared Sub addProperty(ByRef writer As XmlWriter, ByVal name As String, ByVal value As String)
        If Not writer Is Nothing And Not name Is Nothing And name.Length > 0 Then
            writer.WriteStartElement("property")
            writer.WriteStartAttribute("name")
            writer.WriteString(name)
            writer.WriteEndAttribute()

            If Not value Is Nothing And value.Length > 0 Then
                writer.WriteString(value)
            End If
            writer.WriteEndElement()
        End If
    End Sub
End Class

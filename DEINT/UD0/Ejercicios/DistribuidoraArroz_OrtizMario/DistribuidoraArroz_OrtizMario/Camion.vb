Public Class Camion
    Public ReadOnly Property Nombre As String
    Public ReadOnly Property Capacidad As Integer
    Public ReadOnly Property Imagen As Image

    Public Sub New(ByRef nom As String, ByRef cap As Integer, ByRef img As Image)
        Nombre = nom
        Capacidad = cap
        Imagen = img
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("[Nombre: {0}, Capacidad: {1} kg]", Nombre, Capacidad)
    End Function
End Class

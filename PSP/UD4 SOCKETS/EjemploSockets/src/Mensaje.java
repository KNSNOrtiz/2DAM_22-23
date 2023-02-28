
import java.io.Serializable;
import java.text.SimpleDateFormat;
import java.util.Date;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author akihi
 */
public class Mensaje implements Serializable {
    String nombre;
    String hostDestino;
    String mensaje;
    String horaEnvio;

    public Mensaje(String nombre, String hostDestino, String mensaje) {
        this.nombre = nombre;
        this.hostDestino = hostDestino;
        this.mensaje = mensaje;
        Date hora = new Date();   //  Se obtiene la fecha actual para extraer la hora.
        this.horaEnvio = new SimpleDateFormat("HH:mm").format(hora); //  Se aplica el formato hora:minuto y seteamos la propiedad.
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getHostDestino() {
        return hostDestino;
    }

    public void setHostDestino(String hostDestino) {
        this.hostDestino = hostDestino;
    }

    public String getMensaje() {
        return mensaje;
    }

    public void setMensaje(String mensaje) {
        this.mensaje = mensaje;
    }

    public String getHoraEnvio() {
        return horaEnvio;
    }
}

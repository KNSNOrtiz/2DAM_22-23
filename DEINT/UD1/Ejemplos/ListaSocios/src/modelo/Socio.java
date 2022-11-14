
package modelo;

import java.util.Date;


public class Socio {
    private String nombre;
    private String apellidos;
    private Date fechaAlta;
    private String provincia;
    private String licencia;

    public Socio(String nombre, String apellidos, Date fechaAlta, String provincia, String licencia) {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.fechaAlta = fechaAlta;
        this.provincia = provincia;
        this.licencia = licencia;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public Date getFechaAlta() {
        return fechaAlta;
    }

    public void setFechaAlta(Date fechaAlta) {
        this.fechaAlta = fechaAlta;
    }

    public String getProvincia() {
        return provincia;
    }

    public void setProvincia(String provincia) {
        this.provincia = provincia;
    }

    public String getLicencia() {
        return licencia;
    }

    public void setLicencia(String licencia) {
        this.licencia = licencia;
    }
    
    public String[] toStringArray(){
        String[] s = {apellidos, nombre, fechaAlta.toString(), provincia, licencia};
        return s;
    }
    
}

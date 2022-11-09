package Modelo;

import java.util.Date;


public class Cliente {
    private String codCliente;
    private String nombre;
    private String apellido1;
    private String apellido2;
    private String telefono;
    private String nacimiento;
    private String direccion;

    public Cliente(String codCliente, String nombre, String apellido1, String apellido2, String telefono, String nacimiento, String direccion) {
        this.codCliente = codCliente;
        this.nombre = nombre;
        this.apellido1 = apellido1;
        this.apellido2 = apellido2;
        this.telefono = telefono;
        this.nacimiento = nacimiento;
        this.direccion = direccion;
    }
    

    public String getCodCliente() {
        return codCliente;
    }

    public void setCodCliente(String codCliente) {
        this.codCliente = codCliente;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido1() {
        return apellido1;
    }

    public void setApellido1(String apellido1) {
        this.apellido1 = apellido1;
    }

    public String getApellido2() {
        return apellido2;
    }

    public void setApellido2(String apellido2) {
        this.apellido2 = apellido2;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getNacimiento() {
        return nacimiento;
    }

    public void setNacimiento(String nacimiento) {
        this.nacimiento = nacimiento;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    @Override
    public String toString() {
        return codCliente + "-" + nombre + "-" + apellido1 ;
    }
    
    
    
    

}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;


public class Alumno {
    String codAlumno;
    String nombreAlumno;
    
    public  Alumno(){
        
    }
    public Alumno(String codAlumno, String nombreAlumno){
        this.codAlumno = codAlumno;
        this.nombreAlumno = nombreAlumno;
    }

    public String getCodAlumno() {
        return codAlumno;
    }

    public void setCodAlumno(String codAlumno) {
        this.codAlumno = codAlumno;
    }

    public String getNombreAlumno() {
        return nombreAlumno;
    }

    public void setNombreAlumno(String nombreAlumno) {
        this.nombreAlumno = nombreAlumno;
    }

    @Override
    public String toString() {
        return codAlumno + ";" + nombreAlumno;
    }
    
}

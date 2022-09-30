
package alumno;

import java.io.Serializable;
import java.util.Date;

public class Alumno implements Serializable{
    int numExp;
    Double notamedia;
    String apellido1, apellido2, nombre;
    Date fechaNac; //  Cambiar a Date
    
    public Alumno(int num, Double not, String ap1, String ap2, String nom, Date fech){
        numExp = num;
        notamedia = not;
        apellido1 = ap1;
        apellido2 = ap2;
        nombre = nom;
        fechaNac = fech;
    }
    public int getNumExp()
    {
        return numExp;
    }
    public void setNumExp(int num){
        numExp = num;
    }
    public Double getNotaMedia(){
        return notamedia;
    }
    public void setNotaMedia(Double nota){
        notamedia = nota;
    }    
    public String getApellido1(){
        return apellido1;
    }
    public void setApellido1(String ap){
        apellido1 = ap;
    }
    public String getApellido2(){
        return apellido2;
    }  
    public void setApellido2(String ap){
        apellido2 = ap;
    }
    public String getNombre(){
        return nombre;
    }  
    public void setNombre(String nom){
        nombre = nom;
    }  
    public Date getFnac(){
        return fechaNac;
    }
    public void setFnac(Date fecha){
        fechaNac = fecha;
    }
    @Override
    public String toString() {
        String texto = String.valueOf(numExp) + ";" + String.valueOf(notamedia) + ";" + apellido1+";"+apellido2+";"+nombre+";"+fechaNac.toString();
        return texto;
    }
      
}

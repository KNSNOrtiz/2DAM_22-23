package Modelo;


import java.io.Serializable;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import javax.swing.JOptionPane;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author akihi
 */
public class Alumno implements Serializable {
    int numMatricula;
    String nombre;
    Date fechaNac; 
    Double notamedia;
    int edad;
    
    public Alumno(){
        numMatricula = -1;
        notamedia = 0.0;
        nombre = "";
        fechaNac = Calendar.getInstance().getTime();
        edad = 0;
    }
    public Alumno(int num, String nom, String fech, Double not, int ed){
        numMatricula = num;
        notamedia = not;
        nombre = nom;
        fechaNac = StringToDate(fech);
        edad = ed;
    }
    public int getNumMatr()
    {
        return numMatricula;
    }
    public void setNumMatr(int num){
        numMatricula = num;
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
    public Double getNotaMedia(){
        return notamedia;
    }
    public void setNotaMedia(Double nota){
        notamedia = nota;
    }    
    public int getEdad(){
        return edad;
    }
    public void setEdad(int ed){
        edad = ed;
    }
    @Override
    public String toString() {
        char sep = '*';
        String texto = String.valueOf(numMatricula) + sep + nombre + sep + DateToString(fechaNac)+sep+String.valueOf(notamedia)+sep+String.valueOf(edad);
        return texto;
    }
    public static Date StringToDate(String fechaString){
        Date fecha;
        DateFormat formato = new SimpleDateFormat("dd/MM/yyyy");
        try {
            fecha = formato.parse(fechaString);
        } catch (ParseException ex) {
            JOptionPane.showMessageDialog(null,"ERROR: La fecha introducida no es válida. Se cogerá la actual.");
            fecha = Calendar.getInstance().getTime();
        }
        return fecha;
    }
    public static String DateToString(Date fecha){
        String salida;
        DateFormat formato = new SimpleDateFormat("dd/MM/yyyy");
        salida = formato.format(fecha);
        return salida;
    }
    
}

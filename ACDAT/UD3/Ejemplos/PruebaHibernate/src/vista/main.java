package vista;

import controlador.ctrlBD;
import modelo.Direccion;
import modelo.Profesor;


public class main {
     
    private static ctrlBD control = new ctrlBD();
    private static Profesor prof = null; 
    private static Direccion dir = null;
    
    public static void main(String[] args){
        dir = new Direccion(1, "Cruz del Sur", new Long(4), "Granada", "Granada");
        //prof = new Profesor(1, "Juan", "Juanito", "Juan");
        //prof.setDireccion(dir);
        //control.insertarProfesor(prof);
         control.borrarDireccion(dir);
        //control.borrarProfesor(prof);
    }
    
}

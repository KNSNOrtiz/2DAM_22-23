/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import Vista.*;
import javax.swing.JDialog;
import javax.swing.JOptionPane;

/**
 *
 * @author akihi
 */
public class CtrlAlumnos {
    
    public static void Alta(){
        JDialog dlgAlta = new dialogAlta(null, true);
        dlgAlta.setVisible(true);
                mainFrame.cargarDatos();
    } 
    public static void Baja(){
        int respuesta = JOptionPane.showConfirmDialog(null, "Vas a borrar al alumno con matrícula " + mainFrame.matrSelec + ".\n¿Estás seguro?" , "Confirmar baja", JOptionPane.YES_NO_OPTION);
            if (respuesta == JOptionPane.YES_OPTION) {
               mainFrame.listaAlumnos.remove(mainFrame.indexAlumno); 
               mainFrame.cargarDatos();
            }    
    }
    public static void Modificar(){
        JDialog dlgModificar = new dialogModificar(null, true);
        dlgModificar.setVisible(true);
        mainFrame.cargarDatos();           
               
    }
    
    
        public static int comprobarMatricula(int numMatricula){
        for (int i = 0; i < mainFrame.listaAlumnos.size(); i++) {
            if (numMatricula == mainFrame.listaAlumnos.get(i).getNumMatr()) {                
                return -1;
            }
        }
        return 0;
    }
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controlador;

import java.util.ArrayList;
import modelo.Alumno;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import vista.frameMain;


public class ctrlAlumno {
    
    ResultSet rs;
    PreparedStatement ps;
    
    public ArrayList<Alumno> listarAlumnos(){
        ArrayList<Alumno> listaAlumnos = new ArrayList<>();
        if (frameMain.con != null) {
            try {
                ps = frameMain.con.prepareStatement("select * from alumnos");
                rs = ps.executeQuery();
                while (rs.next()) {                    
                    Alumno al = new Alumno(
                            rs.getString(1),
                            rs.getString(2)
                    );
                    if (al != null) {
                        listaAlumnos.add(al);
                    }
                }
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getSQLState()+"-"+ex.getMessage());
            }
        }
        return listaAlumnos;
    }
}

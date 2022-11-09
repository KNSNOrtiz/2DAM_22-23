
package Controlador;

import java.sql.*;
import Vista.mainFrame;
import Modelo.Alumno;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class CtrlAlumno {
    ResultSet rs;
    Statement stmt;
    ArrayList<Alumno> listaAlumnos = new ArrayList<Alumno>();
    
    public ArrayList<Alumno> ConsultarAlumnos(){
        if (mainFrame.con != null) {
            listaAlumnos.clear();
            try {
                stmt = mainFrame.con.createStatement();
                rs = stmt.executeQuery("select * from alumnos");
                while (rs.next()) {                    
                    Alumno alTmp = new Alumno(
                        rs.getString(1), 
                        rs.getString(2)                    
                    );
                    listaAlumnos.add(alTmp);
                }
                rs.close();
                
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getErrorCode() + "-" + ex.getSQLState() + "-" + ex.getMessage());
            }
        } else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return listaAlumnos;
    }
}

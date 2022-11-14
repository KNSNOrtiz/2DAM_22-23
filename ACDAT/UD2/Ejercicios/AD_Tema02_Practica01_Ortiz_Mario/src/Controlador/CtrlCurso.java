/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import java.sql.*;
import Vista.mainFrame;
import Modelo.Curso;
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class CtrlCurso {
    ResultSet rs;
    Statement stmt;
    ArrayList<Curso> listaCursos = new ArrayList<Curso>();
    
    public ArrayList<Curso> ConsultarCursos(){
        if (mainFrame.con != null) {
            listaCursos.clear();
            try {
                stmt = mainFrame.con.createStatement();
                rs = stmt.executeQuery("select * from cursos");
                while (rs.next()) {                    
                    Curso alTmp = new Curso(
                        rs.getString(1), 
                        rs.getString(2),
                        rs.getInt(3)
                    );
                    listaCursos.add(alTmp);
                }
                stmt.close();
                rs.close();
                
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getErrorCode() + "-" + ex.getSQLState() + "-" + ex.getMessage());
            }
        } else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return listaCursos;
    }
}

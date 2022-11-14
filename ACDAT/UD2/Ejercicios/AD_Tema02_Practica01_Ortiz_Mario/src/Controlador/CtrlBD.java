package Controlador;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class CtrlBD {
    public Connection connectOracle(String user, String pwd){
        Connection con = null;
        try {
            con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe", user, pwd);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido conectar a la BD.");
            con = null;
        }
        return con;
    }
    
    
}

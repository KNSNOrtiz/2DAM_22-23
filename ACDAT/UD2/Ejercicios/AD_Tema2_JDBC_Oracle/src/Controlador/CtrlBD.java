package Controlador;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;


public class CtrlBD {
    public static Connection ConectarOracle(){
        Connection conexion = null;
        try {
            conexion = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","SYSTEM","MANAGER");
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido establecer la conexión con la BD.");
            return null;
        }
        return conexion;
    }
    public static ResultSet ConsultaOracle(Connection con, String query){
        PreparedStatement stmt = null;
        ResultSet rs = null;
        try {
            stmt = con.prepareStatement(query);
            rs = stmt.executeQuery();
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido ejecutar la consulta SQL.");
            return null;
        }
        return rs;
    }
    
}

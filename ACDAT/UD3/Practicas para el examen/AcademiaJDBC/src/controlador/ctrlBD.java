
package controlador;

import java.sql.*;
import javax.swing.JOptionPane;

public class ctrlBD {
    public Connection conectarOracle(){
        Connection con = null;
        try {
            con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","AD_ACADEMIA","AD_ACADEMIA");
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, ex.getSQLState()+"-"+ex.getMessage());
        }
        return con;
    }
}

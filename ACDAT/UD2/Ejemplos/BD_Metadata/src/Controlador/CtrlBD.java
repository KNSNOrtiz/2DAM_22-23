package Controlador;

import Vista.mainFrame;
import java.sql.*;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;


public class CtrlBD {
    
    private DatabaseMetaData dbmd;
    private Statement stmt;
    private ResultSet rs;
    private ArrayList<Object[]> listaObjetos = new ArrayList<>();
    
    public Connection ConectarOracle(String server, String port, String user, String pwd){
        Connection con = null;
        try {
            con = DriverManager.getConnection("jdbc:oracle:thin:@"+server+":"+port+":xe",user,pwd);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido conectar a la BD de Oracle.");
        }
        return con;
    }
    
    public ResultSet ListarTablas(){
        if (mainFrame.con != null) {
             String[] tipostablas = {"TABLE"};
            try {
                dbmd = mainFrame.con.getMetaData();
                rs = dbmd.getTables(null, "AD_TEMA02", "%", tipostablas);
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getErrorCode()+"-"+ex.getSQLState()+"-"+ex.getMessage());
            }
        }
        return rs;
    } 
    
    public ResultSet ListarColumnas(String nombreTabla){
            if (mainFrame.con != null) {
                String[] tipostablas = {"TABLE"};
                try {
                    dbmd = mainFrame.con.getMetaData();
                    rs = dbmd.getColumns(null, "AD_TEMA02", nombreTabla+"%", "%");
                } catch (SQLException ex) {
                    JOptionPane.showMessageDialog(null, ex.getErrorCode()+"-"+ex.getSQLState()+"-"+ex.getMessage());
                }
        }
        return rs;
    }
    
    public ArrayList<Object[]> ConsultarTabla(String nombreTabla, int numCol){
        if (mainFrame.con != null) {
                listaObjetos.clear();
                String sql = "SELECT * FROM " + nombreTabla;
                try {
                    stmt = mainFrame.con.createStatement();
                    rs = stmt.executeQuery(sql);         
                    while (rs.next()) {  
                        Object[] registro = new Object[numCol];
                        for (int i = 0; i < numCol; i++) {
                            
                            registro[i] = rs.getObject(i+1);
                        }             
                        listaObjetos.add(registro);
                    }
                } catch (SQLException ex) {
                    JOptionPane.showMessageDialog(null, ex.getErrorCode()+"-"+ex.getSQLState()+"-"+ex.getMessage());
                }
        }
        return listaObjetos;
    }
}

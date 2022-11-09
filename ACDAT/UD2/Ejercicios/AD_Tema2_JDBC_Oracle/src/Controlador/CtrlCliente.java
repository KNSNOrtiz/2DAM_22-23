package Controlador;
import Modelo.Cliente;
import Vista.frameBD;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class CtrlCliente {
    private int filasAfectadas;
    private ArrayList<Cliente> listaClientes = new ArrayList<>();
    private PreparedStatement psp;
    private String query;
    private ResultSet rs;
    
    public int AltaCliente(Cliente cliente){
        filasAfectadas = -1;
        if (frameBD.conexion != null) {
            query = "INSERT INTO CLIENTES VALUES(?,?,?,?,?,?,?)";
            try {
                psp = frameBD.conexion.prepareStatement(query);
                psp.setString(1, cliente.getCodCliente());
                psp.setString(2, cliente.getNombre());
                psp.setString(3, cliente.getApellido1());
                psp.setString(4, cliente.getApellido2());
                psp.setString(5, cliente.getTelefono());
                psp.setString(6, cliente.getNacimiento());
                psp.setString(7, cliente.getDireccion());
                filasAfectadas = psp.executeUpdate();
                psp.close();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getMessage());
            }
        }else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return filasAfectadas;
    }
    public int BajaCliente(String codCliente){
        filasAfectadas = -1;
        if (frameBD.conexion != null) {
            query = "DELETE CLIENTES WHERE CODCLIENTE = ?";
            try {
                psp = frameBD.conexion.prepareStatement(query);
                psp.setString(1, codCliente);          
                filasAfectadas = psp.executeUpdate();
                psp.close();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getMessage());
            }
        }else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return filasAfectadas;     
    }
    public int ModificarCliente(Cliente cli){
        filasAfectadas = -1;
        if (frameBD.conexion != null) {
            query = "UPDATE CLIENTE SET VALUES(?,?,?,?,?,?,?) WHERE CODCLIENTE = ?";
            /*try {
                psp = frameBD.conexion.prepareStatement(query);
                psp.setString(1, cliente.getCodCliente());
                psp.setString(2, cliente.getNombre());
                psp.setString(3, cliente.getApellido1());
                psp.setString(4, cliente.getApellido2());
                psp.setString(5, cliente.getTelefono());
                psp.setString(6, cliente.getNacimiento());
                psp.setString(7, cliente.getDireccion());
                filasAfectadas = psp.executeUpdate();
                psp.close();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getMessage());
            }*/
        }else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return filasAfectadas;   
    }
    public ArrayList<Cliente> ConsultarCliente(String where){
        listaClientes.clear();
        if (frameBD.conexion != null) {
            if (where.equals("")) {
                query = "SELECT * FROM CLIENTES"; 
            } else {
                query = "SELECT * FROM CLIENTES WHERE " + where;
            }       
            try {
                psp = frameBD.conexion.prepareStatement(query);   
                rs = psp.executeQuery();
                while (rs.next()) {                    
                    listaClientes.add(new Cliente(
                        rs.getString("codCliente"),
                        rs.getString("nombre"),
                        rs.getString("apellido1"),
                        rs.getString("apellido2"),
                        rs.getString("telefono"),
                        rs.getString("nacimiento"),
                        rs.getString("direccion")    
                    ));
                }
                rs.close();
                psp.close();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getMessage());
            }
        }else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }        
        return listaClientes;
        
    }
}


package Controlador;
import Modelo.Examen;
import java.sql.*;
import Vista.mainFrame;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;


public class CtrlExamen {
    ResultSet rs;
    PreparedStatement psp;
    CallableStatement cs;
    String sql;
    int filasAfectadas;
    ArrayList<Examen> listaExamenes = new ArrayList<>();
    DateFormat df = new SimpleDateFormat("dd/MM/yyyy");
    
    
    public ArrayList<Examen> ConsultarExamenes(String codAlumno, String codCurso){
        if (mainFrame.con != null) {
            sql = "SELECT * FROM EXAMENES WHERE CCODALU = ? AND CCODCURSO = ?";
            try {  
                psp = mainFrame.con.prepareStatement(sql);
                psp.setString(1, codAlumno);
                psp.setString(2, codCurso);
                rs = psp.executeQuery();
                while (rs.next()) {   
                    String fechaAux = "";
                    if (rs.getDate(4) != null) {
                        fechaAux = df.format(rs.getDate(4));
                    }
                    Examen examen = new Examen(
                            rs.getString(1),
                            rs.getString(2),
                            rs.getInt(3),
                            fechaAux,
                            rs.getDouble(5)
                    );
                    listaExamenes.add(examen);
                }
                psp.close();
                rs.close();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getErrorCode() + "-" + ex.getSQLState() + "-" + ex.getMessage());
            }
        }
        else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }        
        return listaExamenes;
    }
    
    public int ModificarExamen(Examen examen){
        if (mainFrame.con != null) {
            sql = "UPDATE EXAMENES SET DFECEXAM = ?, NNOTAEXAM = ? WHERE CCODALU = ? AND CCODCURSO = ? AND NNUMEXAM = ?";
            try{
                psp = mainFrame.con.prepareStatement(sql);
                psp.setString(1, examen.getFechaExamen());
                psp.setDouble(2, examen.getNotaExamen());
                psp.setString(3, examen.getCodAlumno());
                psp.setString(4, examen.getCodMatricula());
                psp.setInt(5, examen.getNumExamen());
                filasAfectadas = psp.executeUpdate();
                psp.close();
                sql = "{call SP_ACTUALIZARNOTAMEDIA(?,?,?)}";
                if (filasAfectadas != -1) {
                    cs = mainFrame.con.prepareCall(sql);
                    cs.setString(1, examen.getCodAlumno());
                    cs.setString(2, examen.getCodMatricula());
                    cs.registerOutParameter(3, Types.INTEGER);
                    filasAfectadas = cs.executeUpdate();
                    if (cs.getInt(3) == -1) {
                        filasAfectadas = -1;
                    }
                    cs.close();
                }
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getErrorCode() + "-" + ex.getSQLState() + "-" + ex.getMessage());
            }
        } else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return filasAfectadas;
    }
    
}

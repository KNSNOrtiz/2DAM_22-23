package Controlador;

import java.sql.*;
import Vista.mainFrame;
import Modelo.Matricula;
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class CtrlMatricula {
    ResultSet rs1;
    ResultSet rs2;
    String sql;
    PreparedStatement psp;
    CallableStatement cs;
    public int filasAfectadas;
    ArrayList<Matricula> listaMatriculas = new ArrayList<>();
    
    
    public ArrayList<Matricula> ConsultarMatriculas(String codAlumno){
        String nomCurso = "";
         if (mainFrame.con != null) {
            listaMatriculas.clear();
            try {
                psp = mainFrame.con.prepareStatement("SELECT * FROM MATRICULAS WHERE CCODALU = ?");                  
                psp.setString(1, codAlumno);
                rs1 = psp.executeQuery();
                while (rs1.next()) {    
                    psp = mainFrame.con.prepareStatement("SELECT CNOMCURSO FROM CURSOS WHERE CCODCURSO = ?");
                    psp.setString(1, rs1.getString(2));
                    rs2 = psp.executeQuery();
                    if (rs2.next()){        //  Uso un IF porque en esta ocasión el cursor solo devuelve una tupla.
                       nomCurso = rs2.getString(1);
                    }
                    rs2.close();
                    Matricula matrTmp = new Matricula(
                        rs1.getString(1),
                        rs1.getString(2),
                        nomCurso,
                        rs1.getFloat(3)
                    );
                    listaMatriculas.add(matrTmp);
                }
                psp.close();
                rs1.close();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, ex.getErrorCode() + "-" + ex.getSQLState() + "-" + ex.getMessage());
            }
        } else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return listaMatriculas;
    }       
    
    public int AltaMatricula(Matricula matricula){
        filasAfectadas = -1;
        if (mainFrame.con != null) {
            if (matricula != null) {
                sql = "{call SP_ALTAMATRICULA(?,?,?)}";
                try {
                    cs = mainFrame.con.prepareCall(sql);
                    cs.setString(1, matricula.getCodAlumno());
                    cs.setString(2, matricula.getCodCurso());
                    cs.registerOutParameter(3, Types.INTEGER);
                    filasAfectadas = cs.executeUpdate();
                    if (cs.getInt(3) == -1) {
                        filasAfectadas = -1;
                    }
                    cs.close();
                } catch (SQLException ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage());
                }
            }    
        }else{
            JOptionPane.showMessageDialog(null, "ERROR: Se ha perdido la conexión con la BD.");
        }
        return filasAfectadas;
    }
}

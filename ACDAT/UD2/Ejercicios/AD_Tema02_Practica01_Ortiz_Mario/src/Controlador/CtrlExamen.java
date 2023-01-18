package Controlador;

import Modelo.Examen;
import java.sql.*;
import java.io.File;
import java.io.FileWriter;
import Vista.mainFrame;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import com.google.gson.Gson;
import java.awt.Desktop;
import java.io.IOException;


public class CtrlExamen {
    ResultSet rs;
    PreparedStatement psp;
    CallableStatement cs;
    String sql;
    int filasAfectadas;
    File fichero;
    FileWriter fw;
    ArrayList<Examen> listaExamenes = new ArrayList<>();
    DateFormat df = new SimpleDateFormat("dd/MM/yyyy");     //  Este objeto se ha creado para aplicar el mismo formato tanto a las fechas que se introducen como las que se obtienen.
    
    
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
                        fechaAux = df.format(rs.getDate(4));    //  Se aplica el formato al Date recibido y se pasa a String para reflejarlo en el objeto.
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
                sql = "{call SP_ACTUALIZARNOTAMEDIA(?,?,?)}";       //  Para evitar el error "mutating table" del trigger, lo sustituimos por este procedimiento almacenado.
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
    
    public void ListarJSON(ArrayList<Examen> listaExamenes){        //  Exclusivamente para este ejercicio se crea un JSON haciendo uso de la libreria GSON de Google.
        String json = "";
        json = new Gson().toJson(listaExamenes);    //  Con este  método se crea toda la estructura del JSON en base a los objetos que contiene la lista de exámenes. La lista será la que tenemos en la vista en el momento que se llame a la función.
        if ((!json.equals("")) && (json != null)) {
            try {
                fichero = new File("boletin.json");
                fw = new FileWriter(fichero);
                fw.write(json);
                fw.close();
                int respuesta = JOptionPane.showConfirmDialog(null, "Se ha creado con éxito el boletín de notas para la matrícula seleccionada. ¿Quieres abrir el fichero?");
                if (respuesta == JOptionPane.YES_OPTION) {
                    Desktop escritorio = Desktop.getDesktop();  //  Con este objeto podemos abrir el fichero en el explorador de archivos mediante Java.
                    escritorio.open(fichero);
                }
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null, "ERROR: No se ha podido crear el boletín.");
                } catch (UnsupportedOperationException ex){
                    JOptionPane.showMessageDialog(null, "ERROR: No es posible abrir el fichero JSON desde el programa. Debe hacerse manualmente.");
                }         
        }   
    }
    
}

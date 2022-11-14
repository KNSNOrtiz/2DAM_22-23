package Controlador;

import Modelo.Alumno;
import java.sql.*;
import Vista.mainFrame;
import Modelo.Matricula;
import java.awt.Desktop;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import org.w3c.dom.*;

public class CtrlMatricula {
    
    //  Para realizar las operaciones en la BD.
    ResultSet rs1;
    ResultSet rs2;  //  Este ResultSet se usará para recibir una consulta adicional y darle a cada matrícula un atributo auxiliar para sacar el nombre del curso sin necesidad de manejar la vista.
    String sql;
    PreparedStatement psp;
    CallableStatement cs;
    public int filasAfectadas;
    
    // Para construir el XML, haciendo solamente uso de nodos de tipo Element y TextContent.
    DocumentBuilder builder;
    Document doc;
    Element raiz;
    Node nodo;
    Transformer transform;
    
    
    File fichero;
    ArrayList<Matricula> listaMatriculas = new ArrayList<>();
    
     
    public ArrayList<Matricula> ConsultarMatriculas(String codAlumno){
        String nomCurso = "";   //  Variable auxiliar que se introducirá en cada objeto Matrícula.
         if (mainFrame.con != null) {
            listaMatriculas.clear();
            try {
                psp = mainFrame.con.prepareStatement("SELECT * FROM MATRICULAS WHERE CCODALU = ?");                  
                psp.setString(1, codAlumno);
                rs1 = psp.executeQuery();
                while (rs1.next()) {    
                    psp = mainFrame.con.prepareStatement("SELECT CNOMCURSO FROM CURSOS WHERE CCODCURSO = ?");
                    psp.setString(1, rs1.getString(2));     //  Se prepara la consulta en la tabla Cursos mediante la clave foránea que tenemos en Matrículas.
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
                    if (cs.getInt(3) == -1) {       //  Si ha ocurrido algún error al ejecutar el procedimiento almacenado, se reflejará en filasAfectadas.
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
    
    public void ListarXML(ArrayList<Alumno> listaAlumnos){
        try{
            builder = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            doc = builder.newDocument();     
            raiz = doc.createElement("Matriculas");
            doc.appendChild(raiz);         
            for(Alumno alumno : listaAlumnos){
                listaMatriculas = ConsultarMatriculas(alumno.getCodAlumno());
                if (listaMatriculas.isEmpty()) {
                    return;
                }
                nodo = doc.createElement("Matricula");
                Element nodoCodAlumno = doc.createElement("CodAlumno");
                Element nodoNombre = doc.createElement("Nombre");
                Element nodoCursos = doc.createElement("Cursos");
                nodoCodAlumno.setTextContent(alumno.getCodAlumno());
                nodoNombre.setTextContent(alumno.getNombreAlumno());
                nodo.appendChild(nodoCodAlumno);
                nodo.appendChild(nodoNombre);
                nodo.appendChild(nodoCursos);
                for (Matricula matricula : listaMatriculas) {
                    Element nodoCurso = doc.createElement("Curso");
                    Element nodoCodCurso = doc.createElement("CodCurso");
                    Element nodoNomCurso = doc.createElement("NombreCurso");
                    Element nodoNotaMedia = doc.createElement("NotaMedia");
                    nodoCodCurso.setTextContent(matricula.getCodCurso());
                    nodoNomCurso.setTextContent(matricula.getNomCurso());
                    nodoNotaMedia.setTextContent(String.valueOf(matricula.getNotaMedia()));
                    nodoCurso.appendChild(nodoCodCurso);
                    nodoCurso.appendChild(nodoNomCurso);
                    nodoCurso.appendChild(nodoNotaMedia);
                    nodoCursos.appendChild(nodoCurso);
                }
                raiz.appendChild(nodo);
            }
        } catch (ParserConfigurationException ex){
            JOptionPane.showMessageDialog(null, "ERROR DE PARSEO");
        }
        try {
           transform = TransformerFactory.newInstance().newTransformer();
           transform.setOutputProperty(OutputKeys.INDENT, "yes");
           Source source = new DOMSource(doc);
           fichero = new File("matriculas.xml");
           Result resultado = new StreamResult(fichero);
           transform.transform(source, resultado);
           int respuesta = JOptionPane.showConfirmDialog(null, "Se ha creado con éxito el listado de matrículas. ¿Quieres abrir el fichero?");
           if (respuesta == JOptionPane.YES_OPTION) {
                Desktop escritorio = Desktop.getDesktop();  //  Con este objeto podemos abrir el fichero en el explorador de archivos mediante Java.
                escritorio.open(fichero);
           }
           
        } catch (TransformerConfigurationException ex) {
            JOptionPane.showMessageDialog(null, "ERROR AL CREAR EL TRANSFORMER");
        } catch (TransformerException ex) {
           JOptionPane.showMessageDialog(null, "ERROR AL CREAR EL DOCUMENTO XML");
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido abrir el fichero XML.");
        } catch (UnsupportedOperationException ex){     //  Esta excepción se lanza cuando la plataforma no permite abrir el fichero, por cualquier motivo.
            JOptionPane.showMessageDialog(null, "ERROR: No es posible abrir el fichero XML desde el programa. Debe hacerse manualmente.");
        }
    }
}

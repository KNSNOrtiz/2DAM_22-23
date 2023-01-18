/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controlador;

import java.awt.Desktop;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.math.BigDecimal;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.Instant;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Set;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.persistence.ParameterMode;
import javax.swing.JOptionPane;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import modelo.Alumnos;
import modelo.Cursos;
import modelo.Examenes;
import modelo.Matriculas;
import org.hibernate.Criteria;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.Query;
import org.hibernate.Transaction;
import org.hibernate.criterion.Restrictions;
import org.hibernate.procedure.ProcedureCall;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;


/**
 *
 * @author akihi
 */
public class ctrlBD {
    private Session sesion;
    private Transaction trans;
    
    //  Método para abrir sesión y transacción.
    private void iniciarOperacion(){
        sesion = NewHibernateUtil.getSessionFactory().openSession();
        trans = sesion.beginTransaction();
       
    }
     
    
    public List<Alumnos> listarAlumnos(){
        List<Alumnos> listaAlumnos = null;
        try{
            iniciarOperacion();
            listaAlumnos = sesion.createQuery("from Alumnos").list();
        } catch (HibernateException ex){    //  Recoge las excepciones lanzadas por Hibernate. Hay que decir que no las recoge todas, como las violaciones de clave foránea o primaria.
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido obtener la lista de los alumnos.");
        } finally{
            trans.commit(); //  No es necesario porque no se alteran los datos, pero al quedar la transación abierta por el método iniciarOperacion() es mejor cerrarla.
            sesion.close();
        }
        return listaAlumnos;
    }
    
    public Alumnos consultarAlumno(String codAlumno){
        Alumnos alumno = null;
        iniciarOperacion();
        alumno = (Alumnos)sesion.get(Alumnos.class, codAlumno);             
        trans.commit();
        sesion.close();
        return alumno;
    }
    
    public Alumnos consultarAlumnoCriteria(String codAlumno){
        iniciarOperacion();
        //  FORMA 1
       // Criteria crit = sesion.createCriteria(Alumnos.class, codAlumno);
       
       //FORMA 2
        Criteria crit = sesion.createCriteria(Alumnos.class);
        crit.add(Restrictions.like("ccodalu", codAlumno));
        
        ArrayList<Alumnos> alumnos;
        Alumnos alumno;
        alumnos = new ArrayList<>(crit.list());
        alumno = alumnos.get(0);
        trans.commit();
        sesion.close();
        return alumno;
    }
    
    public void borrarAlumno(Alumnos alumno){
        try{
            iniciarOperacion();
            sesion.delete(alumno);
        } catch (HibernateException he) {
            JOptionPane.showMessageDialog(null,"ERROR: No se ha podido borrar al alumno seleccionado.");
        } finally{
            trans.commit();
            sesion.close();
        }  
    }
    //  Para ahorrar código, empleamos el método "saveOrUpdate" tanto para dar de alta como para modificar los datos, en lugar de tener un método separado para cada operación.
    public void insertarModificarAlumno(Alumnos alumno){
        try{
            iniciarOperacion();
            sesion.saveOrUpdate(alumno); 
        } catch(HibernateException ex){
            JOptionPane.showMessageDialog(null,"ERROR: No se ha podido guardar o modificar el alumno.");
            
        } finally{
            trans.commit();
            sesion.close();
        }  
    }
    
    public List<Cursos> listarCursos(){
        List<Cursos> listaCursos = null;       
        try{
            iniciarOperacion();
            listaCursos = sesion.createQuery("from Cursos").list();
        } catch (Exception ex){
            
        } finally{
            trans.commit();
            sesion.close();
        }
        return listaCursos;
    }
    
    public Cursos consultarCurso(String codCurso){
        Cursos curso = null;    
        iniciarOperacion();
        curso = (Cursos)sesion.get(Cursos.class, codCurso);
        trans.commit();
        sesion.close();            
        return curso;
             
    }
    
    public void borrarCurso(Cursos curso){
        try{
            iniciarOperacion();
            sesion.delete(curso);    
        } catch(HibernateException ex){
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido borrar el curso seleccionado.");
            
        } finally{
            trans.commit();
            sesion.close();
        }  
    }
    public void insertarModificarCurso(Cursos curso){
        try{
            iniciarOperacion();
            sesion.saveOrUpdate(curso); 
        } catch(HibernateException ex){
           JOptionPane.showMessageDialog(null, "ERROR: No se ha podido guardar o modificar el curso.");
        } finally{
            trans.commit();
            sesion.close();
        }  
    }
    
    public List<Matriculas> listarMatriculas(Alumnos alumno){
        List<Matriculas> listaMatriculas = null;    
        //  Con la siguiente consulta HQL obtenemos los cursos en los que está matriculado el alumno seleccionado.
        String hql = "FROM Matriculas AS M WHERE M.alumnos.ccodalu='"+alumno.getCcodalu()+"'";
        try {
            sesion = NewHibernateUtil.getSessionFactory().openSession();   
            Query consulta = sesion.createQuery(hql);
            listaMatriculas = consulta.list();
        } catch (HibernateException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido recoger la lista de matrículas.");
        }
        return listaMatriculas;
    }
    
    public void matricularAlumno(String codAlumno, String codCurso){  
        int xError = 0;
        iniciarOperacion();
        //  Para llamar a procedimientos almacenados desde Hibernate creamos una instancia de 
        //  ProcedureCall mediante createStoredProcedureCall, pasándole  como parámetro el nombre de este.
        ProcedureCall procedimiento =  sesion.createStoredProcedureCall("sp_AltaMatricula");
        //  Asignamos los parámetros de entrada, que serán los códigos de alumno y curso.
        procedimiento.registerParameter(1, String.class, ParameterMode.IN);
        procedimiento.registerParameter(2, String.class, ParameterMode.IN);
        //  Asignamos ahora los valores a estos parámetros.
        procedimiento.getParameterRegistration(1).bindValue(codAlumno);
        procedimiento.getParameterRegistration(2).bindValue(codCurso);
        //  Para controlar los errores del procedimiento, recogemos el valor que devuelve xError en el procedimiento.
        procedimiento.registerParameter(3, Integer.class, ParameterMode.OUT);
        xError = Integer.parseInt(procedimiento.getOutputs().getOutputParameterValue(3).toString());
        
        if (xError == -1) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido matricular al alumno.");
        } else{
            JOptionPane.showMessageDialog(null ,"Alumno matriculado con éxito.");
        }
        trans.commit();
        sesion.close();
    }
    
    public List<Examenes> listarExamenes(Matriculas matricula){
        List<Examenes> listaExamenes = null;
        iniciarOperacion();
        String hql = "FROM Examenes AS E WHERE E.matriculas.alumnos.ccodalu='"+matricula.getAlumnos().getCcodalu()+
                "' AND E.matriculas.cursos.ccodcurso='" + matricula.getCursos().getCcodcurso() +"'";
        try {
            Query consulta = sesion.createQuery(hql);
            listaExamenes = consulta.list();            
        } catch (HibernateException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido recoger la lista de exámenes.");
        } finally{
            trans.commit();
            sesion.close();
        }
        return listaExamenes;
    }
    
    public void modificarExamen(Examenes examen, String fechaNueva, String nuevaNota){
        Date fecha = null;
        BigDecimal nota = null;
        //  Para modificar el padre, creamos una instancia del padre a través del hijo, para acceder al objeto persistente.
        Matriculas matricula = null;
        ArrayList<Examenes> listaExamenes = null;
        double notaTotal = 0.0;
        short notaMedia = 0;
        int numExamenes = 0;
        
        try {
            fecha = new SimpleDateFormat("dd/MM/yyyy").parse(fechaNueva);
            nota = new BigDecimal(nuevaNota);
            
        } catch (ParseException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: La fecha introducida no es válida.");
            return;
        } catch(NumberFormatException ex){
            JOptionPane.showMessageDialog(null, "ERROR: La nota introducida no es válida.");
            return;
        }
        
        
        iniciarOperacion();
        try {
            //  Propiedades a modificar de examen
            examen.setDfecexam(fecha);
            examen.setNnotaexam(nota);
            sesion.saveOrUpdate(examen);

            //  Tras guardar los cambios en el examen, accedemos a la matrícula correspondiente con esos nuevos cambios en su lista de exámenes
            //  para poder modificar la nota media con las notas actualizadas.
            matricula = examen.getMatriculas();
            listaExamenes = new ArrayList<>(matricula.getExameneses());
            for (Examenes ex : listaExamenes) {
                notaTotal += ex.getNnotaexam().doubleValue();
            }
            numExamenes = listaExamenes.size();
            notaMedia = (short) (notaTotal / numExamenes);

            //  Modificación del padre.
            matricula.setNnotamedia(notaMedia);
            sesion.saveOrUpdate(matricula);  
        } catch (HibernateException ex) {
            JOptionPane.showMessageDialog(null, "ERROR: No se ha podido modificar el examen o actualizar la nota de la matrícula.");
        } catch(IllegalArgumentException ex){
            JOptionPane.showMessageDialog(null, "ERROR: Uno de los valores introducidos para el examen no son válidos.");
        }
        finally{
            trans.commit();
            sesion.close();
        }



    }
    
    //  En esta ocasión el JSON se crea manualmente.
    public void ListarJSON(ArrayList<Examenes> listaExamenes){       
        File fichero;
        FileWriter fw;
        String json = "";
        String fecha = "";
        json = "[";

        
        for (Examenes examen : listaExamenes) {
            try {
                fecha = new SimpleDateFormat("dd/MM/yyyy").format(examen.getDfecexam());
            } catch (Exception ex) {
                fecha = "<No presentado>";
            }   
             json += "{\"codAlumno\":\""+examen.getId().getCcodalu()+"\",\"codCurso\":\"" + examen.getId().getCcodcurso()+"\",\"numExamen\":"+
                     examen.getId().getNnumexam() + ",\"fechaExamen\":\""+fecha+
                     "\",\"notaExamen\":"+examen.getNnotaexam()+"}";
            if (listaExamenes.indexOf(examen) != listaExamenes.size()-1) {  //  Con esto determinamos si es el último objeto del JSONArray o no.
                json += ",";
            }
        }
        json += "]";
        if ((!json.equals("")) && (json != null)) {
            try {
                fichero = new File("boletin.json");
                fw = new FileWriter(fichero);
                fw.write(json);
                fw.close();
                int respuesta = JOptionPane.showConfirmDialog(null, "Se ha creado con éxito el boletín de notas para la matrícula seleccionada. ¿Quieres abrir el fichero?");
                if (respuesta == JOptionPane.YES_OPTION) {
                    Desktop escritorio = Desktop.getDesktop();  
                    escritorio.open(fichero);
                }
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null, "ERROR: No se ha podido crear el boletín.");
                } catch (UnsupportedOperationException ex){
                    JOptionPane.showMessageDialog(null, "ERROR: No es posible abrir el fichero JSON desde el programa. Debe hacerse manualmente.");
                }         
        }   
    }
  
    public void ListarXML(ArrayList<Alumnos> listaAlumnos){
        File fichero;
        DocumentBuilder builder;
        Document doc = null;
        Element raiz;
        Node nodo;
        Transformer transform;
        try{
            builder = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            doc = builder.newDocument();     
            raiz = doc.createElement("Matriculas");
            doc.appendChild(raiz);         
            for(Alumnos alumno : listaAlumnos){
                ArrayList<Matriculas> listaMatriculas = new ArrayList<>(listarMatriculas(alumno));
                if (listaMatriculas.isEmpty()) {
                    return;
                }
                nodo = doc.createElement("Matricula");
                Element nodoCodAlumno = doc.createElement("CodAlumno");
                Element nodoNombre = doc.createElement("Nombre");
                Element nodoCursos = doc.createElement("Cursos");
                nodoCodAlumno.setTextContent(alumno.getCcodalu());
                nodoNombre.setTextContent(alumno.getCnomalu());
                nodo.appendChild(nodoCodAlumno);
                nodo.appendChild(nodoNombre);
                nodo.appendChild(nodoCursos);
                for (Matriculas matricula : listaMatriculas) {
                    Element nodoCurso = doc.createElement("Curso");
                    Element nodoCodCurso = doc.createElement("CodCurso");
                    Element nodoNomCurso = doc.createElement("NombreCurso");
                    Element nodoNotaMedia = doc.createElement("NotaMedia");
                    nodoCodCurso.setTextContent(matricula.getId().getCcodcurso());
                    nodoNomCurso.setTextContent(matricula.getCursos().getCnomcurso());
                    nodoNotaMedia.setTextContent(String.valueOf(matricula.getNnotamedia()));
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

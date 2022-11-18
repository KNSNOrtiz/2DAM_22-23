
package controlador;

import modelo.Alumnos;
import modelo.Direccion;
import modelo.Profesor;
import org.hibernate.*;


public class ctrlBD {
    SessionFactory sf = NewHibernateUtil.getSessionFactory();
    Session ss;
    
    public void insertarAlumno(Alumnos alumno){
        ss = sf.openSession();
        Transaction ts = ss.beginTransaction();
        ss.save(alumno);
        ts.commit();
        ss.close();
    }
    
    public void insertarProfesor(Profesor prof){
        ss = sf.openSession();
        Transaction ts = ss.beginTransaction();
        ss.save(prof);
        ts.commit();
        ss.close();       
    }
    
    public void borrarProfesor(Profesor prof){
        ss = sf.openSession();
        Transaction ts = ss.beginTransaction();
        ss.delete(prof);
        ts.commit();
        ss.close(); 
    }
    
    public void borrarDireccion(Direccion direccion){
        ss = sf.openSession();
        Transaction ts = ss.beginTransaction();
        ss.delete(direccion);
        ts.commit();
        ss.close(); 
    }
    
    
}

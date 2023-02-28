package modelo;
// Generated 01-dic-2022 18:10:14 by Hibernate Tools 4.3.1


import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;

/**
 * Matriculas generated by hbm2java
 */
public class Matriculas  implements java.io.Serializable {


     private MatriculasId id;
     private Alumnos alumnos;
     private Cursos cursos;
     private short nnotamedia;
     private Set exameneses = new HashSet(0);

    public Matriculas() {
    }

	
    public Matriculas(MatriculasId id, Alumnos alumnos, Cursos cursos, short nnotamedia) {
        this.id = id;
        this.alumnos = alumnos;
        this.cursos = cursos;
        this.nnotamedia = nnotamedia;
    }
    public Matriculas(MatriculasId id, Alumnos alumnos, Cursos cursos, short nnotamedia, Set exameneses) {
       this.id = id;
       this.alumnos = alumnos;
       this.cursos = cursos;
       this.nnotamedia = nnotamedia;
       this.exameneses = exameneses;
    }
   
    public MatriculasId getId() {
        return this.id;
    }
    
    public void setId(MatriculasId id) {
        this.id = id;
    }
    public Alumnos getAlumnos() {
        return this.alumnos;
    }
    
    public void setAlumnos(Alumnos alumnos) {
        this.alumnos = alumnos;
    }
    public Cursos getCursos() {
        return this.cursos;
    }
    
    public void setCursos(Cursos cursos) {
        this.cursos = cursos;
    }
    public short getNnotamedia() {
        return this.nnotamedia;
    }
    
    public void setNnotamedia(short nnotamedia) {
        this.nnotamedia = nnotamedia;
    }
    public Set getExameneses() {
        return this.exameneses;
    }
    
    public void setExameneses(Set exameneses) {
        this.exameneses = exameneses;
    }




}


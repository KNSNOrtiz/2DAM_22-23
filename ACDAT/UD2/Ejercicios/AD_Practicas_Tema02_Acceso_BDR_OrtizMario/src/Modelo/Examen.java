package Modelo;


public class Examen {
    String codAlumno;
    String codMatricula;
    int numExamen;
    String fechaExamen;
    Double notaExamen;
    
    public Examen(){
        
    }

    public Examen(String codAlumno, String codMatricula, int numExamen, String fechaExamen, Double notaExamen) {
        this.codAlumno = codAlumno;
        this.codMatricula = codMatricula;
        this.numExamen = numExamen;
        this.fechaExamen = fechaExamen;
        this.notaExamen = notaExamen;
    }

    public String getCodAlumno() {
        return codAlumno;
    }

    public void setCodAlumno(String codAlumno) {
        this.codAlumno = codAlumno;
    }

    public String getCodMatricula() {
        return codMatricula;
    }

    public void setCodMatricula(String codMatricula) {
        this.codMatricula = codMatricula;
    }

    public int getNumExamen() {
        return numExamen;
    }

    public void setNumExamen(int numExamen) {
        this.numExamen = numExamen;
    }

    public String getFechaExamen() {
        return fechaExamen;
    }

    public void setFechaExamen(String fechaExamen) {
        this.fechaExamen = fechaExamen;
    }

    public Double getNotaExamen() {
        return notaExamen;
    }

    public void setNotaExamen(Double notaExamen) {
        this.notaExamen = notaExamen;
    }
    
}

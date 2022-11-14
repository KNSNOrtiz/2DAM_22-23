package Modelo;


public class Curso {
    
    String codCurso;
    String nombreCurso;
    int numExamenes;
    
    public Curso(){
        
    }
    public Curso(String codCurso, String nombreCurso, int numExamenes){
        this.codCurso = codCurso;
        this.nombreCurso = nombreCurso;
        this.numExamenes = numExamenes;
    }

    public String getCodCurso() {
        return codCurso;
    }

    public void setCodCurso(String codCurso) {
        this.codCurso = codCurso;
    }

    public String getNombreCurso() {
        return nombreCurso;
    }

    public void setNombreCurso(String nombreCurso) {
        this.nombreCurso = nombreCurso;
    }

    public int getNumExamenes() {
        return numExamenes;
    }

    public void setNumExamenes(int numExamenes) {
        this.numExamenes = numExamenes;
    }
    
}


package Modelo;


public class Matricula {
    
    String codAlumno;
    String codCurso;
    String nomCurso;
    double notaMedia;
    
    public Matricula(){
        
    }

    public Matricula(String codAlumno,String codCurso, String nomCurso, double notaMedia) {
        this.codAlumno = codAlumno;
        this.codCurso = codCurso;
        this.nomCurso = nomCurso;
        this.notaMedia = notaMedia;
    }

    public String getCodAlumno() {
        return codAlumno;
    }

    public void setCodAlumno(String codAlumno) {
        this.codAlumno = codAlumno;
    }

    public String getCodCurso() {
        return codCurso;
    }

    public void setCodCurso(String codCurso) {
        this.codCurso = codCurso;
    }

    public String getNomCurso() {
        return nomCurso;
    }

    public void setNomCurso(String nomCurso) {
        this.nomCurso = nomCurso;
    }

    public double getNotaMedia() {
        return notaMedia;
    }

    public void setNotaMedia(double notaMedia) {
        this.notaMedia = notaMedia;
    }


    
    
    
    
    
}

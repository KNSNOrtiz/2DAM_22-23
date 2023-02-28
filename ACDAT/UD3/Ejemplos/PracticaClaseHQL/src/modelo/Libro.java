package modelo;
// Generated 23-nov-2022 17:10:03 by Hibernate Tools 4.3.1



/**
 * Libro generated by hbm2java
 */
public class Libro  implements java.io.Serializable {


     private long id;
     private Persona persona;
     private String titulo;

    public Libro() {
    }

	
    public Libro(long id) {
        this.id = id;
    }
    public Libro(long id, Persona persona, String titulo) {
       this.id = id;
       this.persona = persona;
       this.titulo = titulo;
    }
   
    public long getId() {
        return this.id;
    }
    
    public void setId(long id) {
        this.id = id;
    }
    public Persona getPersona() {
        return this.persona;
    }
    
    public void setPersona(Persona persona) {
        this.persona = persona;
    }
    public String getTitulo() {
        return this.titulo;
    }
    
    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }




}


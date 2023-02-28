package modelo;
// Generated 17-nov-2022 17:49:20 by Hibernate Tools 4.3.1



/**
 * CuentasId generated by hbm2java
 */
public class CuentasId  implements java.io.Serializable {


     private String codbanco;
     private String numcta;

    public CuentasId() {
    }

    public CuentasId(String codbanco, String numcta) {
       this.codbanco = codbanco;
       this.numcta = numcta;
    }
   
    public String getCodbanco() {
        return this.codbanco;
    }
    
    public void setCodbanco(String codbanco) {
        this.codbanco = codbanco;
    }
    public String getNumcta() {
        return this.numcta;
    }
    
    public void setNumcta(String numcta) {
        this.numcta = numcta;
    }


   public boolean equals(Object other) {
         if ( (this == other ) ) return true;
		 if ( (other == null ) ) return false;
		 if ( !(other instanceof CuentasId) ) return false;
		 CuentasId castOther = ( CuentasId ) other; 
         
		 return ( (this.getCodbanco()==castOther.getCodbanco()) || ( this.getCodbanco()!=null && castOther.getCodbanco()!=null && this.getCodbanco().equals(castOther.getCodbanco()) ) )
 && ( (this.getNumcta()==castOther.getNumcta()) || ( this.getNumcta()!=null && castOther.getNumcta()!=null && this.getNumcta().equals(castOther.getNumcta()) ) );
   }
   
   public int hashCode() {
         int result = 17;
         
         result = 37 * result + ( getCodbanco() == null ? 0 : this.getCodbanco().hashCode() );
         result = 37 * result + ( getNumcta() == null ? 0 : this.getNumcta().hashCode() );
         return result;
   }   


}


package modelo;
// Generated 17-nov-2022 17:49:20 by Hibernate Tools 4.3.1


import java.math.BigDecimal;

/**
 * Cuentas generated by hbm2java
 */
public class Cuentas  implements java.io.Serializable {


     private CuentasId id;
     private String titular;
     private BigDecimal saldo;

    public Cuentas() {
    }

	
    public Cuentas(CuentasId id) {
        this.id = id;
    }
    public Cuentas(CuentasId id, String titular, BigDecimal saldo) {
       this.id = id;
       this.titular = titular;
       this.saldo = saldo;
    }
   
    public CuentasId getId() {
        return this.id;
    }
    
    public void setId(CuentasId id) {
        this.id = id;
    }
    public String getTitular() {
        return this.titular;
    }
    
    public void setTitular(String titular) {
        this.titular = titular;
    }
    public BigDecimal getSaldo() {
        return this.saldo;
    }
    
    public void setSaldo(BigDecimal saldo) {
        this.saldo = saldo;
    }




}



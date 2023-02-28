/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bannerpublicitario;

import java.io.Serializable;
import java.util.ArrayList;

/**
 *
 * @author akihi
 */
public class DatosBanner implements Serializable {
    private ArrayList<String> frases;
    private int intervalo;
    private int repeticion;
    
    public DatosBanner(ArrayList<String> frases, int intervalo, int repeticion) {
        this.frases = frases;
        this.intervalo = intervalo;
        this.repeticion = repeticion;
    }
    
    public ArrayList<String> getFrases() {
        return frases;
    }
    public String getFrases(int posicion) {
        return frases.get(posicion);
    }

    public void setFrases(ArrayList<String> frases) {
        this.frases = frases;
    }
    public void setFrases(int posicion, String frase) {
        this.frases.set(posicion, frase);
    }

    public int getIntervalo() {
        return intervalo;
    }

    public void setIntervalo(int intervalo) {
        this.intervalo = intervalo;
    }

    public int getRepeticion() {
        return repeticion;
    }

    public void setRepeticion(int repeticion) {
        this.repeticion = repeticion;
    }
        
        
        
        
}

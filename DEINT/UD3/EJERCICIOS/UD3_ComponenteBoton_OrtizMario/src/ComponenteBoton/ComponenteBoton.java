package ComponenteBoton;


import java.awt.Image;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.File;
import java.io.IOException;
import java.io.Serializable;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JButton;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author akihi
 */
public class ComponenteBoton extends JButton implements Serializable {
    private String tipo = "CANCELAR";   //  Se le asigna un tipo por defecto para que contenga un texto por defecto que no sea el título.
    private String texto = "";
    private ImageIcon imgAplauso = new ImageIcon(getClass().getResource("res/aplauso.png")); 
    private Image auxiliar;
    private ImageIcon imgTriste = new ImageIcon(getClass().getResource("res/triste.png")); 
    
     
    public ComponenteBoton(){
            auxiliar = imgAplauso.getImage();
            auxiliar = auxiliar.getScaledInstance(64, 64, Image.SCALE_SMOOTH);
            imgAplauso = new ImageIcon(auxiliar);
            auxiliar = imgTriste.getImage();
            auxiliar = auxiliar.getScaledInstance(64, 64, Image.SCALE_SMOOTH);
            imgTriste = new ImageIcon(auxiliar);

            if (tipo.toLowerCase().equals("aceptar")) {
                texto = "ACEPTAR";
            } else if (tipo.toLowerCase().equals("cancelar")){
                texto = "CANCELAR";
            }          
            setText(texto);
            
            this.addMouseListener(new MouseAdapter(){
            @Override
            public void mouseExited(MouseEvent e) {
                setIcon(null);
                setText(texto);
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                setText("");
                switch(tipo.toLowerCase()){
                   case "aceptar":    
                        texto = "ACEPTAR";
                        setIcon(imgAplauso);              
                        break;
                   case "cancelar":
                        texto = "CANCELAR";
                        setIcon(imgTriste);
                        break;
               }            
            }
            });         
           
    }
 

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }


    
    
    
    
        
    
}

package jpanelimagen;

import java.awt.Graphics;
import java.io.File;
import java.io.Serializable;
import javax.swing.ImageIcon;
import javax.swing.JPanel;


public class jpanelimagen extends JPanel implements Serializable {
     
    public File rutaImagen;

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g); 
        if (rutaImagen != null && rutaImagen.exists()) {
             ImageIcon imagen = new ImageIcon(rutaImagen.getAbsolutePath());
            g.drawImage(imagen.getImage(), 0, 0, null);
        }
       
    }
    
    
              
    public jpanelimagen(){
         
    }

    public File getRutaImagen() {
        return rutaImagen;
    }

    public void setRutaImagen(File rutaImagen) {
        this.rutaImagen = rutaImagen;
    }

    
    
    
}

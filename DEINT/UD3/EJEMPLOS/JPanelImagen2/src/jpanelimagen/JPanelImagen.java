package jpanelimagen;


import java.awt.AlphaComposite;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.io.File;
import java.io.Serializable;
import javax.swing.ImageIcon;
import javax.swing.JPanel;



/**
 *
 * @author migup
 */
public class JPanelImagen extends JPanel implements Serializable{
    private ImagenFondo imagenFondo;
    
    public JPanelImagen(){
        
    }

    public ImagenFondo getImagenFondo() {
        return imagenFondo;
    }

    public void setImagenFondo(ImagenFondo imagenFondo) {
        this.imagenFondo = imagenFondo;
    }
    
    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g); 
        
        if(imagenFondo != null){
            //if(imagenFondo.getRutaImagen() != null && imagenFondo.getRutaImagen().exists()){
            Graphics2D g2d = (Graphics2D)g;
            g2d.setComposite(AlphaComposite.getInstance(AlphaComposite.SRC_OVER, imagenFondo.getOpacidad()));
            ImageIcon imagen = new ImageIcon(imagenFondo.getRutaImagen().getAbsolutePath());
            g.drawImage(imagen.getImage(), 0, 0, null);            
            g2d.setComposite(AlphaComposite.getInstance(AlphaComposite.SRC_OVER, 1));
            //}
        }        
    }     
}

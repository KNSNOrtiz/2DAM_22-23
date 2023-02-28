
package bannerpublicitario;

import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.Serializable;
import java.util.Timer;
import java.util.TimerTask;
import javax.swing.JLabel;
import javax.swing.JOptionPane;


public class BannerPublicitario extends JLabel implements Serializable {
    
    private DatosBanner datosBanner;
    private BannerListener bannerListener;
    private Timer timer;
    
    private Font fuenteDefecto = getFont();
    private int i = 0;
    private int j = 0;
    private int fraseActual = 0;

    public BannerPublicitario() {
        
        this.addMouseListener(new MouseAdapter(){
            @Override
            public void mouseEntered(MouseEvent e) {
                setFont(new Font("Arial Black",0, 14));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                setFont(fuenteDefecto);
            } 

            @Override
            public void mouseClicked(MouseEvent e) {
                if (bannerListener !=  null) {
                    bannerListener.clickBanner();
                }
            }
            
            
        });        
    }
    

    public void IniciarBanner(){
            timer = new Timer();
            if (datosBanner != null) {
                if (datosBanner.getFrases().size() != 0) {
                j = 0;
                timer.schedule(new TimerTask()  {   
                    @Override
                    public void run() {
                        if (datosBanner.getRepeticion() >= 0) {
                            if (i <= datosBanner.getRepeticion()) {
                                if (j < datosBanner.getFrases().size()) {
                                   setText(datosBanner.getFrases(j));
                                   fraseActual = j + 1;
                                   j++;
                                }
                                if (j == datosBanner.getFrases().size()) {
                                    i++; 
                                    j = 0;
                                }
                            } else{
                                i = 0;
                                setText(datosBanner.getFrases(j));
                                fraseActual = j+1;
                                this.cancel();
                            }
                        }
                        if (datosBanner.getRepeticion() == -1) {
                            setText(datosBanner.getFrases(j));
                            fraseActual = j +1;
                            j++;
                            if (j == datosBanner.getFrases().size()) {
                                j = 0;
                            }
                        }                      
                    }
                }, 0, datosBanner.getIntervalo());
                } else{
                   JOptionPane.showMessageDialog(null, "Aviso: El banner debe tener mínimo una frase.");
                }  
            } else{
                JOptionPane.showMessageDialog(null, "Por favor, inicia la propiedad DatosBanner primero.");
            }
    }
    
    

    public DatosBanner getDatosBanner() {
        return datosBanner;
    }

    public void setDatosBanner(DatosBanner datosBanner) {
        this.datosBanner = datosBanner;
    }

    public void setBannerListener(BannerListener bannerListener) {
        this.bannerListener = bannerListener;
    }

    public int getFraseActual() {
        return fraseActual;
    }


    

    
    
    
    
    
    
   
}

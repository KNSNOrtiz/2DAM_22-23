package relojdigital;

import java.io.Serializable;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Timer;
import java.util.TimerTask;
import javax.swing.JLabel;

public class RelojDigital extends JLabel implements Serializable {
    private Alarma alarma;
    private AlarmaListener alarmaListener;
    private boolean formato24;
    
    private SimpleDateFormat sdf24h = new SimpleDateFormat("HH:mm:ss");
    private SimpleDateFormat sdf12h = new SimpleDateFormat("hh:mm:ss a"); 
    
    public RelojDigital(){
        Timer timer = new Timer();
        timer.schedule(new TimerTask()  {
            @Override
            public void run() {
                Date horaActual = new Date();
                if (formato24) {
                    setText(sdf24h.format(horaActual));
                } else{
                    setText(sdf12h.format(horaActual));
                }
                if (alarma != null) {
                    if (alarma.isActiva() && horasCoinciden(horaActual,alarma.getHoraAlarma())) {
                        if (alarmaListener != null) {
                            alarmaListener.suenaAlarma();
                        }
                    }
                }
            }
        }, 0, 1000);
    }
    
    public boolean horasCoinciden(Date horaActual, Date horaAlarma){
        long horaMili = horaActual.getTime();
        long alarmaMili = horaAlarma.getTime();
        return horaMili == alarmaMili;
    }

    public Alarma getAlarma() {
        return alarma;
    }

    public void setAlarma(Alarma alarma) {
        this.alarma = alarma;
    }

    public AlarmaListener getAlarmaListener() {
        return alarmaListener;
    }

    public void setAlarmaListener(AlarmaListener alarmaListener) {
        this.alarmaListener = alarmaListener;
    }

    public boolean isFormato24() {
        return formato24;
    }

    public void setFormato24(boolean formato24) {
        this.formato24 = formato24;
    }

}

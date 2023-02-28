package relojdigital;

import java.awt.Component;
import java.beans.PropertyEditorSupport;
import java.util.Date;

public class AlarmaPropertyEditorSupport extends PropertyEditorSupport{
    
    private AlarmaPanel alarmaPanel = new AlarmaPanel();

    @Override
    public boolean supportsCustomEditor() {
      return true;
    }

    @Override
    public Component getCustomEditor() {
        return alarmaPanel;
    }

    @Override
    public String getJavaInitializationString() {
        Date horaAlarma = alarmaPanel.getSelectedValue().getHoraAlarma();
        boolean activa = alarmaPanel.getSelectedValue().isActiva();
        
        return "new relojdigital.Alarma(new java.util.Date("+horaAlarma.getTime()+"l),"+activa+")";
    }

    @Override
    public Object getValue() {
        return alarmaPanel.getSelectedValue();
    }
    
    
}

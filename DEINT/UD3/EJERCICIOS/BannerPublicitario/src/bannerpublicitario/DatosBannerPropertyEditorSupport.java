package bannerpublicitario;

import java.awt.Component;
import java.beans.PropertyEditorSupport;
import java.util.ArrayList;
import java.util.Arrays;

public class DatosBannerPropertyEditorSupport extends PropertyEditorSupport {
    
    private PanelBanner panelBanner = new PanelBanner();

    @Override
    public boolean supportsCustomEditor() {
      return true;
    }

    @Override
    public Component getCustomEditor() {
        return panelBanner;
    }

    @Override
    public String getJavaInitializationString() {

        ArrayList<String> frases = panelBanner.getValue().getFrases();
        int intervalo = panelBanner.getValue().getIntervalo();
        int repeticion = panelBanner.getValue().getRepeticion();
        String frasesString = frases.toString();
        
        //  Uso StringBuilder para pasar a String manualmente el arrayList con las frases para evitar problemas a la hora de formatear la salida
        //  de texto, así evito caracteres extra no deseados que pueden hacer que el programa donde se utilice el componente no se pueda ejecutar.

        StringBuilder inicializar = new StringBuilder("new bannerpublicitario.DatosBanner(new java.util.ArrayList<String>(java.util.Arrays.asList(");
        int i = 0;
        for(String frase : frases){
            inicializar.append('"'+frase+'"');
            if (i != frases.size()-1) {
                 inicializar.append(',');
                 i++;
            } else{
                inicializar.append(")),");
            }
        }
        inicializar.append(intervalo+","+repeticion+")");
        
        return inicializar.toString();
    }

    @Override
    public Object getValue() {
        return panelBanner.getValue();
    }    
}

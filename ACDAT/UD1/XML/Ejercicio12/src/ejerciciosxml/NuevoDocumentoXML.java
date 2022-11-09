
package ejerciciosxml;

import java.io.File;
import org.w3c.dom.*;
import javax.xml.parsers.*;
import org.xml.sax.SAXException;

public class NuevoDocumentoXML {
    static DocumentBuilder builder;
    static Document doc;
    static Element raiz;
    static Node nodo;
    static Attr atributo;
    
    public static void main(String[] args) {
        try{
            builder = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            doc = builder.newDocument();
            
        } catch(ParserConfigurationException ex){

        }  
    }

    
}

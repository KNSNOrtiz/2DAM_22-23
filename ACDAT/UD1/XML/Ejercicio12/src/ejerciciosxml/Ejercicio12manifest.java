package ejerciciosxml;

import java.io.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.w3c.dom.*;
import javax.xml.parsers.*;
import org.xml.sax.SAXException;

public class Ejercicio12manifest {
    
    public static void main(String[] args){
        try {        
            DocumentBuilder db = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            Document doc = db.parse(new File("AndroidManifest.xml"));
            Element root = doc.getDocumentElement();
            NodeList rootHijos = root.getChildNodes();                      //  HIJOS DE ROOT
            for (int i = 0; i < rootHijos.getLength(); i++) {
                Node rootHijo = rootHijos.item(i);
                if (rootHijo instanceof Element) {
                    if (rootHijo.hasAttributes()) {
                      NamedNodeMap atributosHijo = rootHijo.getAttributes();  //  ATRIBUTOS DE LOS HIJOS DE ROOT
                      System.out.println("<"+rootHijo.getNodeName());
                      NodeList hijosN2 = rootHijo.getChildNodes();            //  HIJOS DE LOS HIJOS DE ROOT (NIVEL 2)

                      for (int j = 0; j < atributosHijo.getLength(); j++) {
                          Node atributoHijo = atributosHijo.item(j);
                          System.out.println("\t" + atributoHijo.getNodeName() +  "=\""  + atributoHijo.getNodeValue()+"\"");  //  ATRIBUTOS DE LOS HIJOS DE ROOT
                      }
                      System.out.println(">"); // FIN ATRIBUTOS DE LOS HIJOS DE ROOT
                      for (int j = 0; j < hijosN2.getLength(); j++) {
                          Node hijoN2 = hijosN2.item(j);
                          if (hijoN2 instanceof Element) {
                              System.out.println("\t<" + hijoN2.getNodeName());
                              if (hijoN2.hasAttributes()) {
                                  NamedNodeMap atributosHijoN2 = hijoN2.getAttributes();  //  ATRIBUTOS DE LOS HIJOS DE LOS HIJOS DE ROOT (NIVEL 2) 
                                  NodeList hijosN3 = hijoN2.getChildNodes();
                                  for (int k = 0; k < atributosHijoN2.getLength(); k++) {
                                      Node atributoHijoN2 = atributosHijoN2.item(k);
                                      System.out.println("\t\t"+atributoHijoN2.getNodeName() + "=\"" + atributoHijoN2.getNodeValue()+"\"");   //  ATRIBUTOS DE HIJO RAÍZ
                                  }
                                for (int k = 0; k < hijosN3.getLength(); k++) {
                                     Node hijoN3 = hijosN3.item(k);
                                      if (hijoN3 instanceof Element) {
                                          System.out.println("\t\t<" + hijoN3.getNodeName());
                                          NamedNodeMap atributosHijoN3 = hijoN3.getAttributes();
                                          for (int l = 0; l < atributosHijo.getLength(); l++) {
                                              Node atributoHijoN3 = atributosHijo.item(l);
                                              System.out.println("\t\t\t"+atributoHijoN3.getNodeName()+"=\""+atributoHijoN3.getNodeValue()+"\"");
                                          }
                                          System.out.println("\t\t>");
                                      }
                                }
                                System.out.println("\t>");   
                              }            
                          }
                      }  
                    }
                    
                    System.out.println("</"+rootHijo.getNodeName()+">");    //  FIN RAÍZ
                }    
            }
        } catch (ParserConfigurationException ex) {
            System.out.println("ERROR: No se ha podido crear el DocumentBuilder");
        } catch (SAXException ex) {
            System.out.println("ERROR: No se ha podido crear el documento.");
        } catch (IOException ex) {
            System.out.println("ERROR: No se ha podido leer el contenido del fichero XML.");
        }
    }

}

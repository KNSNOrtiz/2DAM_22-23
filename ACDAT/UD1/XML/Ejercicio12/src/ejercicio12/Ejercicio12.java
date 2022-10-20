/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio12;

import java.io.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.w3c.dom.*;
import javax.xml.parsers.*;
import org.xml.sax.SAXException;

public class Ejercicio12 {

    public static void main(String[] args) {
        try {
            DocumentBuilder db = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            Document doc = db.parse(new File("catalogo.xml"));
            Element root = doc.getDocumentElement();
            NodeList hijos = root.getChildNodes();
            for (int i = 0; i < hijos.getLength(); i++) {
                Node nodo = hijos.item(i);
                if (nodo instanceof Element) {
                    System.out.println("<"+nodo.getNodeName()+">");
                    NodeList hijosNodo = nodo.getChildNodes();
                    for (int j = 0; j < hijosNodo.getLength(); j++) {
                        Node hijoNodo = hijosNodo.item(j);
                        System.out.println("\t"+hijoNodo.getNodeValue() + "\n<\\" + nodo.getNodeName()+">");
                    }
                }
                
            }
        } catch (ParserConfigurationException ex) {
            System.out.println("ERROR: No se ha podido cargar el documento XML.");
        } catch (SAXException ex){
            System.out.println("Error al crear el DOM");
        } catch (IOException ex){
            System.out.println("ERROR: No se ha podido leer el archivo.");
        }
        
    }
    
}

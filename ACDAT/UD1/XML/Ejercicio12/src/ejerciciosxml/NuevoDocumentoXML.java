
package ejerciciosxml;

import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.w3c.dom.*;
import javax.xml.parsers.*;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import org.xml.sax.SAXException;

public class NuevoDocumentoXML {
    static DocumentBuilder builder;
    static Document doc;
    static Element raiz;
    static Node nodo;
    static NodeList hijos;
    static Attr atributo;
    static NamedNodeMap atributos;
    
    static Transformer transform;
    
    public static void main(String[] args) {
        generarXML();
        cargarXML();
        
    }
    
    static public void generarXML(){
                try{
            builder = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            doc = builder.newDocument();
            raiz = doc.createElement("Articulos");
            nodo = doc.createElement("Libro");
            doc.appendChild(raiz);
            raiz.appendChild(nodo);
            nodo = doc.createElement("Titulo");
            nodo.setTextContent("El Quijote");
            Element libro = (Element)raiz.getElementsByTagName("Libro").item(0);
            atributo = doc.createAttribute("Autor");
            atributo.setNodeValue("Miguel Cervantes");
            libro.setAttributeNode(atributo);
            libro.appendChild(nodo);

            
            transform = TransformerFactory.newInstance().newTransformer();
            transform.setOutputProperty(OutputKeys.INDENT, "yes");
            Source source = new DOMSource(doc);
            Result result = new StreamResult(new File("libros.xml"));
            transform.transform(source, result);
            
            
        } catch(ParserConfigurationException ex){

        } catch(TransformerConfigurationException ex){
            
        } catch (TransformerException ex) {
            Logger.getLogger(NuevoDocumentoXML.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    static public void cargarXML(){
        try {
            builder = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            doc = builder.parse(new File("libros.xml"));
            raiz = doc.getDocumentElement();
            hijos = raiz.getChildNodes();
            System.out.println("<"+raiz.getNodeName()+">");
            for (int i = 0; i < hijos.getLength(); i++) {
                nodo = hijos.item(i);
                if (nodo.getNodeType() == Document.ELEMENT_NODE) {
                if (nodo.hasAttributes()) {
                    atributos = nodo.getAttributes();
                }
                System.out.println("\t<"+nodo.getNodeName()+" " + atributos.item(0).getNodeName()+"=\""+atributos.item(0).getNodeValue() +"\">"+nodo.getTextContent()+"<Libro/>");
                }

                
            }
            
        } catch (ParserConfigurationException ex) {
            Logger.getLogger(NuevoDocumentoXML.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SAXException ex) {
            Logger.getLogger(NuevoDocumentoXML.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(NuevoDocumentoXML.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }
    
}

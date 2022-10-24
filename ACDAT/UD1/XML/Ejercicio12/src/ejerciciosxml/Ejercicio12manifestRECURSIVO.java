package ejerciciosxml;

import java.io.File;
import java.io.IOException;
import org.w3c.dom.*;
import javax.xml.parsers.*;
import org.xml.sax.SAXException;

public class Ejercicio12manifestRECURSIVO{
    public static void getNodes(Node node) {
        if (node.getNodeType() == Node.ELEMENT_NODE) {
            System.out.println("Node: " + node.getNodeName());
            getNodes(node.getChildNodes(), 0);
        }
        else if (node.getNodeType() == Node.ATTRIBUTE_NODE) {
            System.out.println("Attribute: " + node.getNodeName() + "||" + "Value: " + node.getNodeValue());
        }
    }

    private static void getNodes(NodeList nodes, int i) {
        Node node = nodes.item(i);
        if (node == null)
            return;
        if (node.getNodeValue() != null && !node.getNodeValue().contains("\n"))
            System.out.println(" Value: " + node.getNodeValue());


        
        if (node.getNodeType() == Node.ATTRIBUTE_NODE)
            getNodes(node);
                if (node.getNodeType() == Node.ELEMENT_NODE)
            getNodes(node);
        getNodes(nodes, i + 1);
    }
    
    public static void main(String[] args) {
        try{
            DocumentBuilder db = DocumentBuilderFactory.newInstance().newDocumentBuilder();
            Document doc = db.parse(new File("AndroidManifest.xml"));
            Element root = doc.getDocumentElement(); 
            getNodes(root);
        } catch (ParserConfigurationException ex) {
            System.out.println("ERROR: No se ha podido crear el DocumentBuilder");
        } catch (SAXException ex) {
            System.out.println("ERROR: No se ha podido crear el documento.");
        } catch (IOException ex) {
            System.out.println("ERROR: No se ha podido leer el contenido del fichero XML.");
        }

    }   
}
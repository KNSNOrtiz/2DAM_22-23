/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejemplodocumentbuilder;

import java.io.*;
import javax.xml.parsers.*;
import org.w3c.dom.*;

public class EjemploDocumentBuilder {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
        try {
            DocumentBuilder builder = dbf.newDocumentBuilder();
            Document document = builder.parse(new File("holamundo.html"));
        } catch (Exception e) {
        }
    }
    
}

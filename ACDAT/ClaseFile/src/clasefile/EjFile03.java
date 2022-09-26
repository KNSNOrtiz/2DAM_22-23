/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clasefile;
import java.io.*;


public class EjFile03 {
    public static void main(String[] args) throws IOException{
        File fichero = new File(".\\src\\clasefile\\EjFile03.java");    //  Se crea un puntero hacia la ruta donde está el fichero.
       
        FileReader fr = null;                                           //  Se crea un variable de tipo FileReader no asignada aún.
        if (fichero.exists() && fichero.isFile()) {                     //  Comprobamos que el puntero señala hacia un fichero y que además este exista.
            try {
                fr = new FileReader(fichero);                           //  Se crea una instancia de FileReader, de forma que ahora contamos con un Stream lector que apunta hacia el fichero.
            } catch (FileNotFoundException ex) {

            }
            String textoSalida = "";
            int caracter = 0;
            try {
                while ((caracter = fr.read()) != -1) {                  //  Al no saber la longitud del fichero, se lee de él hasta que este vale -1, que es cuando falla.        
                    textoSalida += (char)caracter;                      //  Hacemos un casting de int a char, y concatenamos estos a un String, que será el contenido del fichero.
                }
            } catch (Exception ex) {
                System.out.println("Se ha llegado al final del fichero.");
            }
            fr.close();
            System.out.println(textoSalida);
        }
        else{
            System.out.println("En la ruta especificada no hay un fichero.");
        }
        

    }
}

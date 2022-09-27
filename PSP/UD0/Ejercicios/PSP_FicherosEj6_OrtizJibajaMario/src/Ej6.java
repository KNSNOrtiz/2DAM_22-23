
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import javax.swing.JOptionPane;

public class Ej6 {
    static File ficheroEntrada;
    public static void main(String[] args){
        try {
            ficheroEntrada = new File(args[0]);
            String palabra = args[1];
            if (ficheroEntrada.exists()) {
                try {
                    FileReader lector = new FileReader(ficheroEntrada);
                    String texto = "";
                    int caracter = 0;
                    try {
                        while ((caracter = lector.read()) != -1 ) {
                           texto += (char)caracter; 
                        }
                        int contador = 0;
                        String[] palabras = texto.split("[\r\n\\s]+");
                        for (int i = 0; i < palabras.length; i++) {
                            if (palabras[i].equals(palabra)) {
                                contador++;
                            }
                        }
                        System.out.println("Se ha encontrado la palabra " + palabra + " un total de " + contador + " veces.");
                        
                    } catch (IOException ex) {
                        JOptionPane.showMessageDialog(null, "Ha ocurrido un error en la lectura del fichero.");
                    }
                } catch (FileNotFoundException ex) {
                    JOptionPane.showMessageDialog(null, "No se ha podido encontrar el fichero.");
                }
            }
            else{
                JOptionPane.showMessageDialog(null, "El fichero de entrada no existe (Parámetro 1).");
            }
        } catch (ArrayIndexOutOfBoundsException e) {
            JOptionPane.showMessageDialog(null, "Se necesitan dos parámetros (rutaFicheroEntrada, palabraABuscar).");
        }
        
    }
}

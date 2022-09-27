import java.io.*;
import javax.swing.JOptionPane;
public class Ej4 {
    static File ficheroEntrada;
    static File ficheroSalida;
    public static void main(String args[]){
        try {
            ficheroEntrada = new File(args[0]);
            ficheroSalida = new File(args[0].substring(0, args[0].lastIndexOf("."))+"_sort.txt");
            if (ficheroEntrada.exists()) {
                FileInputStream lector = null;
                try {
                    lector = new FileInputStream(ficheroEntrada);
                } catch (FileNotFoundException ex) {
                    JOptionPane.showMessageDialog(null,"No se ha podido encontrar el fichero.");
                }
                int caracter = 0;
                String texto = "";
                try {
                    while ((caracter = lector.read()) != -1) {                    
                    texto += (char)caracter;
                }
                } catch (IOException e) {
                    System.out.println("Fin del fichero.");
                }
                String[] palabras = texto.split("[\r\n\\s]+");
                for (int i = 0; i < palabras.length; i++) {
                    for (int j = i + 1; j < palabras.length; j++) {
                        if (palabras[i].compareTo(palabras[j]) > 0) {
                            String palabraTmp = palabras[i];
                            palabras[i] = palabras[j];
                            palabras[j] = palabraTmp;
                        }
                    }
                }
                try (BufferedWriter escritor = new BufferedWriter(new FileWriter(ficheroSalida))) {
                    String linea = "";
                    for (int i = 0; i < palabras.length; i++) {
                        linea = palabras[i];
                        escritor.write(linea+"\n");
                    }
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null,"No se ha podido escribir en el fichero.");
                }
                

            }
        } catch (ArrayIndexOutOfBoundsException e) {
            JOptionPane.showMessageDialog(null, "Se necesita una ruta de fichero correcta.");
        }          
    }
}

import java.io.*;
import javax.swing.JOptionPane;
public class Ej5 {
    static File ficheroEntrada;
    static File ficheroSalida;
    public static void main(String[] args){
        try {
            ficheroEntrada = new File(args[0]);
            ficheroSalida = new File(args[1]);
            if (ficheroEntrada.exists()) {
                try {
                    FileReader lector = new FileReader(ficheroEntrada);
                    String texto = "";
                    int caracter = 0;
                    try {
                        while ((caracter = lector.read()) != -1 ) {
                           texto += (char)caracter; 
                        }
                        texto = texto.replaceAll("(?:/\\*(?:[^*]|(?:\\*+[^*/]))*\\*+/)|(?://.*)","");
                        BufferedWriter escritor = new BufferedWriter(new FileWriter(ficheroSalida));
                        escritor.write(texto);
                        escritor.close();
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
            JOptionPane.showMessageDialog(null, "Se necesitan dos parámetros (rutaFicheroEntrada, rutaFicheroSalida).");
        }
        
    }

}

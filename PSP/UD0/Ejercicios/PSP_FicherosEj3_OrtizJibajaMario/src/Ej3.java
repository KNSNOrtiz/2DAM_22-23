import java.io.*;
import javax.swing.JOptionPane;

public class Ej3 {
    static File ficheroEntrada1;
    static File ficheroEntrada2;
    static File ficheroSalida;
    public static void main(String args[]){
        BufferedReader lector1;
        BufferedReader lector2;
        BufferedWriter escritor;
        try {
            ficheroEntrada1 = new File(args[0]);
            ficheroEntrada2 = new File(args[1]);
            ficheroSalida = new File(args[2]);
            if (ficheroEntrada1.exists() && ficheroEntrada2.exists()) {
                lector1 = new BufferedReader(new FileReader(ficheroEntrada1));
                lector2 = new BufferedReader(new FileReader(ficheroEntrada2));
                escritor = new BufferedWriter(new FileWriter(ficheroSalida));
                String linea1 = "";
                String linea2 = "";
                while (linea1 != null || linea2 != null) {  
                    linea1 = lector1.readLine();
                    if (linea1 != null) {
                        escritor.write(linea1+"\n");
                    }
                    linea2 = lector2.readLine();
                    if (linea2 != null) {
                        escritor.write(linea2+"\n");
                    }
                }
                lector1.close();
                lector2.close(); 
                escritor.close();
            }
        } catch (IOException e) {
            JOptionPane.showMessageDialog(null, "Uno o más ficheros no existen o la ruta no es correcta.");
        }
        catch(ArrayIndexOutOfBoundsException ex){
            JOptionPane.showMessageDialog(null, "Se deben pasar 3 argumentos.");
        }
    }
}

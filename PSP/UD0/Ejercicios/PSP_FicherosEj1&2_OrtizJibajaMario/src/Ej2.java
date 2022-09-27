import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
public class Ej2 {
    static File fichero;
    static FileInputStream lector;
    public static void main(String args[]){
        try {
            String texto = "";
            fichero = new File("./primos.dat");
            if (fichero.exists()) {
                lector = new FileInputStream(fichero);
                int caracter = 0;
                try {
                    while ((caracter = lector.read()) != -1 ) { 
                        texto += (char)caracter;
                    }
                    lector.close();
                } catch (IOException e) {
                    System.out.println("Se ha terminado de leer el fichero.");

                }
                System.out.println(texto);
            }
        } catch (FileNotFoundException e) {
            System.out.println("El fichero no existe.");
        }
    }
}

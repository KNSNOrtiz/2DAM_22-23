import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
public class Ej1 {
    static File fichero;
    static FileOutputStream escritor;
        
    public static void main (String args[]){
        fichero = new File("./primos.dat");
        try {
            if (!fichero.exists()) {
                fichero.createNewFile();
            }
            escritor = new FileOutputStream(fichero);
            String texto = GenerarPrimos().toString();
            escritor.write(texto.getBytes());
            escritor.close();      
                   
        } catch (IOException ex) {
            System.out.println("No se ha podido crear el fichero.");
        }
    }
    public static List<Integer> GenerarPrimos(){
        List<Integer> primos = new ArrayList<>();
        for (int i = 2; i <= 500; i++) {
            if (esPrimo(i)) {
                primos.add(i);
            }
        }
        return primos;
    }
    public static boolean esPrimo(int num) {
	for (int i = 2; i < num; i++) {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

}

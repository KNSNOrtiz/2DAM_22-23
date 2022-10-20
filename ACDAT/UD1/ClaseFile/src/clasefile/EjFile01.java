package clasefile;

import java.io.File;
import java.io.IOException;
import javax.swing.JOptionPane;

public class EjFile01 {
    public static File mifile;
    public static File mifile1;
    /*public static void main(String[] args) {
        mifile = new File("c:\\basura\\prueba.xxl");
        System.out.println(""+mifile.getAbsolutePath());
        if (mifile.exists()) {
            int respuesta = JOptionPane.showConfirmDialog(null, "El fichero existe. ¿Deseas borrarlo?");
            if (respuesta == JOptionPane.YES_OPTION) {
                mifile.delete();
            }
        }
        else{
            System.out.println("El fichero no existe");
            try {
                mifile.createNewFile();
            } catch (IOException ex) {
                JOptionPane.showMessageDialog(null, "No tienes permisos de creación");  //  Esto se produce porque no tenemos permiso para tocar el directorio raíz
            }
        }
       /* File[] ficheros = mifile.listFiles();
        
        for (int i = 0; i < ficheros.length; i++) {
            System.out.println(""+ficheros[i].length());
            System.out.println(""+ficheros[i].isDirectory());
            System.out.println(""+ficheros[i].isFile());
            System.out.println(""+ficheros[i].getAbsolutePath());
        }*/

    }


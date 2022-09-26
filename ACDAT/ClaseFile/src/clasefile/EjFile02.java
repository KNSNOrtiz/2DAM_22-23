package clasefile;

import java.io.File;

public class EjFile02 {
    public static File mifile;
    public static void main(String[] args){
        if (args.length == 1) {
            mifile = new File(args[0]);
            if (mifile.exists() && mifile.isDirectory()) {
                String[] la = mifile.list();
                for (int i = 0; i < la.length; i++) {
                    System.out.println(""+la[i]);
                }
            }
        }
        System.out.println("hola "+args[0]);
    }
}

package alumno;
import java.io.*;
import java.util.ArrayList;
import java.util.Date;

public class main {
    public static void main(String[] args) throws FileNotFoundException, IOException, ClassNotFoundException {
        File file = new File(".\\alumnos.dat");
        FileOutputStream fos = new FileOutputStream(file);
        FileInputStream fis = new FileInputStream(file);
        ObjectOutputStream oos = new ObjectOutputStream(fos);
        ObjectInputStream ois = new ObjectInputStream(fis);
        Alumno al = new Alumno(1000, 8.5, "Ortiz", "Jibaja", "Mario", new Date(2003, 0, 9));
        Alumno a2 = new Alumno(1000, 8.5, "lao", "ses", "Wen", new Date(2022, 9, 13));
        ArrayList<Alumno> listaAlumnos = new ArrayList<>();
        listaAlumnos.add(al);
        listaAlumnos.add(a2);
        for(Alumno alTmp : listaAlumnos){
            oos.writeObject(alTmp);
        }
        oos.writeObject(al);
        oos.close();
        fos.close();
        
        Alumno alCopia = (Alumno)ois.readObject();
        System.out.println(alCopia.toString());
        
        //  Otra forma de hacerlo /////////////////////
        Object al2;
        try {
            al2 = (Alumno)ois.readObject();
            if (al2 instanceof Alumno) {
                System.out.println(al2.toString());
            }
        } catch (Exception e) {
            System.out.println("No es un alumno.");
        }
        ///////////////////////////////////////////////
        ois.close();

        fis.close();

    }
}

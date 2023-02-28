import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.*;

public class ServidorAndroid {
    
    private ServerSocket serverSocket;
    private Socket clienteSocket;
    private final int PUERTO = 1234;

    private ObjectInputStream flujoEntrada;
    private ObjectOutputStream flujoSalida;

    public ServidorAndroid(){
        try {
            serverSocket = new ServerSocket(PUERTO);
        } catch (IOException e) {
            System.out.println("SERVIDOR -> No se pudo abrir serverSocket.");
        }
    }

    public Mensaje RecibirMensaje(){
        try {
            Mensaje mensaje;
            clienteSocket = serverSocket.accept();
            flujoEntrada = new ObjectInputStream(clienteSocket.getInputStream());
            mensaje = (Mensaje) flujoEntrada.readObject();
            System.out.println("SERVIDOR->"+ " Mensaje obtenido: "+ mensaje.getMensaje());;
            clienteSocket.close();
            serverSocket.close();
            return mensaje;
        } catch (IOException e) {
            System.out.println(e.getMessage());
        } catch (ClassNotFoundException e) {
            System.out.println("SERVIDOR - >No se pudo realizar el casting en la lectura de Mensaje.");
        }
        return null;
    }
}


import java.io.IOException;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author akihi
 */
public class mainServer {
    public static void main(String[] args) throws IOException {
        Servidor server = new Servidor();  
        server.startServer();
    }
}

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author akihi
 */
public class Prueba {
    static Mensaje mensaje;
    static ServidorAndroid servidorAndroid;
    
    public static void main(String[] args) {
    servidorAndroid = new ServidorAndroid();
    
    Thread hiloIniciar = new Thread(new Runnable() {
        @Override
        public void run() {
            mensaje = servidorAndroid.RecibirMensaje();
        }
    });
    hiloIniciar.start();
    }
    
}

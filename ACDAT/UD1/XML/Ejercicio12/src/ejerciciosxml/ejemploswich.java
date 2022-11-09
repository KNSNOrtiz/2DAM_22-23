/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejerciciosxml;
import java.util.Scanner;
/**
 *
 * @author akihi
 */
public class ejemploswich {
    static String waifu;
    static int dinero;
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Introduce a tu waifu: ");
        waifu = in.nextLine();
        switch(waifu){
            case "Eula":
                System.out.println("La mejor písame porfavor");
                break;
            case "Scaramouche":
                System.out.println("Eres un tóxico desínstala.");
                break;
                default:
                    System.out.println("Impacto de Genshin");
        }
    }
    
}

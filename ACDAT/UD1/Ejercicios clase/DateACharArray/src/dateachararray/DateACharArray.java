/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dateachararray;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

public class DateACharArray {

    public static void main(String[] args) {
        Date fecha = Calendar.getInstance().getTime();
        char[] fechaArray = ConvertirDateChar(fecha);
        System.out.println(fechaArray);
    }
    
    public static char[] ConvertirDateChar(Date fecha){
        String fechaString;
        char[] fechaCharArray;
        DateFormat formato = new SimpleDateFormat("dd/MM/yyyy");
        fechaString = formato.format(fecha);
        fechaCharArray = fechaString.toCharArray();
        return fechaCharArray;    
    }
    
}


import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.nio.charset.StandardCharsets;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Arrays;
import java.util.Calendar;
import java.util.Date;
import java.util.Locale;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author akihi
 */
public class frameMain extends javax.swing.JFrame {

    /**
     * Creates new form frameMain
     */
    final int TAMANO = 248;
    long pos = 0;
    DefaultTableModel tabla;
    RandomAccessFile raf;
    File fichero;
    
    
    public frameMain() {
        initComponents();
        tabla = (DefaultTableModel)tblAlumnos.getModel();
        fichero = new File("./alumnos.dat");
        try {
            //  Abrimos el fichero de acceso directo
            raf = new RandomAccessFile(fichero, "rw");
        } catch (FileNotFoundException ex) {
           JOptionPane.showMessageDialog(null, "ERROR: La ruta del fichero no es accesible.");
        }

        cargarDatos();        
        
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        txtPos = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        txtNombre = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        txtNota1 = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txtNota2 = new javax.swing.JTextField();
        txtNotaFIN = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        txtFnac = new javax.swing.JTextField();
        jScrollPane2 = new javax.swing.JScrollPane();
        tblAlumnos = new javax.swing.JTable();
        jMenuBar1 = new javax.swing.JMenuBar();
        mitAlta = new javax.swing.JMenu();
        mitBaja = new javax.swing.JMenu();
        mitConsulta = new javax.swing.JMenu();
        mitModificar = new javax.swing.JMenu();

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane1.setViewportView(jTable1);

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Gestión de notas con RandomFileAccess | Ortiz Jibaja, Mario");

        jLabel1.setText("Posición");

        jLabel2.setText("Nombre");

        jLabel3.setText("Nota1");

        jLabel4.setText("Nota2");

        jLabel5.setText("NotaFIN");

        jLabel6.setText("Fecha Nac.");

        tblAlumnos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null, null},
                {null, null, null, null, null, null},
                {null, null, null, null, null, null},
                {null, null, null, null, null, null}
            },
            new String [] {
                "ID Registro", "Nombre", "Fecha nac.", "Nota 1", "Nota 2", "Nota FIN"
            }
        ));
        jScrollPane2.setViewportView(tblAlumnos);

        mitAlta.setText("Alta");
        mitAlta.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                mitAltaMouseClicked(evt);
            }
        });
        mitAlta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mitAltaActionPerformed(evt);
            }
        });
        jMenuBar1.add(mitAlta);

        mitBaja.setText("Baja");
        mitBaja.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                mitBajaMouseClicked(evt);
            }
        });
        jMenuBar1.add(mitBaja);

        mitConsulta.setText("Consulta");
        mitConsulta.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                mitConsultaMouseClicked(evt);
            }
        });
        jMenuBar1.add(mitConsulta);

        mitModificar.setText("Modificar");
        mitModificar.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                mitModificarMouseClicked(evt);
            }
        });
        jMenuBar1.add(mitModificar);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(80, 80, 80)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 53, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                        .addComponent(txtPos, javax.swing.GroupLayout.PREFERRED_SIZE, 94, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 53, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(12, 12, 12)
                                        .addComponent(txtNombre, javax.swing.GroupLayout.PREFERRED_SIZE, 163, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                            .addComponent(jLabel3)
                                            .addComponent(jLabel4)
                                            .addComponent(jLabel5))
                                        .addGap(18, 18, 18)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(txtNota1)
                                            .addComponent(txtNota2)
                                            .addComponent(txtNotaFIN, javax.swing.GroupLayout.PREFERRED_SIZE, 94, javax.swing.GroupLayout.PREFERRED_SIZE))))
                                .addGap(224, 224, 224))
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addGap(70, 70, 70)
                                .addComponent(jLabel6)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(txtFnac, javax.swing.GroupLayout.PREFERRED_SIZE, 163, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(0, 235, Short.MAX_VALUE))
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.TRAILING))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(46, 46, 46)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(txtPos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txtNombre, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(10, 10, 10)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel6)
                    .addComponent(txtFnac, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(txtNota1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(txtNota2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtNotaFIN, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel5))
                .addGap(18, 18, 18)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 195, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(133, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void mitAltaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mitAltaActionPerformed


    }//GEN-LAST:event_mitAltaActionPerformed

    private void mitAltaMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_mitAltaMouseClicked
        Alta();
    }//GEN-LAST:event_mitAltaMouseClicked

    private void mitBajaMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_mitBajaMouseClicked
        Baja();
    }//GEN-LAST:event_mitBajaMouseClicked

    private void mitConsultaMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_mitConsultaMouseClicked
        Consulta();
    }//GEN-LAST:event_mitConsultaMouseClicked

    private void mitModificarMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_mitModificarMouseClicked
        Modificar(Integer.valueOf(txtPos.getText()));
    }//GEN-LAST:event_mitModificarMouseClicked
    

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(frameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frameMain().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTable jTable1;
    private javax.swing.JMenu mitAlta;
    private javax.swing.JMenu mitBaja;
    private javax.swing.JMenu mitConsulta;
    private javax.swing.JMenu mitModificar;
    private javax.swing.JTable tblAlumnos;
    private javax.swing.JTextField txtFnac;
    private javax.swing.JTextField txtNombre;
    private javax.swing.JTextField txtNota1;
    private javax.swing.JTextField txtNota2;
    private javax.swing.JTextField txtNotaFIN;
    private javax.swing.JTextField txtPos;
    // End of variables declaration//GEN-END:variables
    private void cargarDatos(){
        int idRegistro;
        tabla.setRowCount(0);  
        try {
            //  Recorremos el fichero
            int numRegistros = (int)raf.length() / TAMANO;
            for (int i = 1; i <= numRegistros; i++) {
               pos = (i-1) * TAMANO;
               //   Situamos el puntero en la posición indicada.
                raf.seek(pos);
                //  Leemos el identificador (siempre es un número entero)
                if ((idRegistro = raf.readInt()) != 0) {
                    byte[] nombreBytes = new byte[200];
                    byte[] fechaBytes = new byte[20];
                    Double nota1 = 0.0;
                    Double nota2 = 0.0;
                    Double notaFin = 0.0;
                    raf.readFully(nombreBytes);
                    raf.readFully(fechaBytes);
                    nota1 = raf.readDouble();
                    nota2 = raf.readDouble();
                    notaFin = raf.readDouble();   
                    Object[] datosAlumno = {idRegistro, new String(nombreBytes), new String(fechaBytes), nota1, nota2, notaFin};
                    tabla.addRow(datosAlumno);
                }                  
            }
            //raf.close();
        } catch (IOException ex) {
           JOptionPane.showMessageDialog(null, "ERROR: No se puede leer/escribir en el fichero.");
        }
    }
    
    private void Alta(){    
        int idRegistro = 0;
        int altaPosible = -1;
        StringBuffer nombre; 
        StringBuffer fecha;
        Double nota1 = null;
        Double nota2 = null;
        Double notaFin = null;
        try {      
            nombre = new StringBuffer(this.txtNombre.getText());
            nombre.setLength(100);
            System.out.println(nombre.length());
            fecha = new StringBuffer(ConvertirStringDate(txtFnac.getText()));
            fecha.setLength(10);
            nota1 = Double.parseDouble(txtNota1.getText());
            nota2 = Double.parseDouble(txtNota2.getText());
            notaFin = Double.parseDouble(txtNotaFIN.getText());
        } catch (NumberFormatException e){
            JOptionPane.showMessageDialog(null,"ERROR: Asegúrate de que los campos tienen datos válidos.");
            return;
        }        
            try {
                //  Calcular dónde se situa el cursor en base al registro que el usuario quiere tocar.
                pos = (Long.parseLong(txtPos.getText())-1) * TAMANO;
                //  Situo el cursor.
                System.out.println(raf.getFilePointer());
                raf.seek(pos);
                //  Comprobamos que el registro sobre el que estamos esté "vacío", es decir, que sea 0. 
                idRegistro = raf.readInt();
                if ( idRegistro == 0) {
                     altaPosible = 0;        
                }
                else{
                    altaPosible = -1;
                    JOptionPane.showMessageDialog(null, "ERROR: Ya hay un registro en esta posición.");
                }
            } catch (IOException e) {
                JOptionPane.showMessageDialog(null, "Final del archivo, puedes escribir.");
                altaPosible = 0;
            }
           if (altaPosible == 0) {
                try {
                    idRegistro = Integer.parseInt(txtPos.getText());               
                    //  Tras leer el registro, situamos el cursor al principio del registro.                   
                    raf.seek(pos);
                    raf.writeInt(idRegistro);
                    raf.writeChars(nombre.toString());
                    raf.writeChars(fecha.toString());
                    raf.writeDouble(nota1);
                    raf.writeDouble(nota2);
                    raf.writeDouble(notaFin);
                    cargarDatos();           
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(null, "Formato no correcto.");
            } catch (IOException ex){
                JOptionPane.showMessageDialog(null, "Ha pasado algo chungo.");
            }
    }
        
         
    }
    
    public void Baja(){      
        int idRegistro = 0;
        try {
            idRegistro = Integer.valueOf(txtPos.getText());
        }
        catch (NumberFormatException ex){
            JOptionPane.showMessageDialog(null, "El valor del registro no es válido.");
        }
        pos = (idRegistro-1) * TAMANO;
            try{
                raf.seek(pos);
                if ((idRegistro = raf.readInt()) != 0) {
                    raf.seek(pos);
                    int respuesta = JOptionPane.showConfirmDialog(null, "¿Estás seguro de que quieres borrar el registro?");
                    if (respuesta == JOptionPane.OK_OPTION) {
                        raf.writeInt(0);
                        cargarDatos(); 
                    }

                }                  
            } catch(IOException e){
                JOptionPane.showMessageDialog(null, "No hay un registro en la posición seleccionada.");
            }
    }
    public void Consulta(){
        int idRegistro = 0;
        try{
            idRegistro = Integer.valueOf(txtPos.getText());
        } catch(NumberFormatException e){
            JOptionPane.showMessageDialog(null, "El valor del registro no es válido.");            
        }
        pos = (idRegistro-1) * TAMANO;      
        try{
            raf.seek(pos);
            if ((idRegistro = raf.readInt()) != 0) {
                byte[] nombreBytes = new byte[200];
                byte[] fechaBytes = new byte[20];
                try {
                    raf.readFully(nombreBytes);    
                    raf.readFully(fechaBytes); 
                } catch (IOException e) {
                    JOptionPane.showMessageDialog(null, "ERROR: No se pueden leer los campos de nombre y fecha.");
                    return;
                }
                String nombre = new String(nombreBytes);            
                String fecha = new String(fechaBytes);
                try {
                    txtNombre.setText(nombre);
                    txtFnac.setText(fecha);
                    txtNota1.setText(String.valueOf(raf.readDouble()));
                    txtNota2.setText(String.valueOf(raf.readDouble()));         
                    txtNotaFIN.setText(String.valueOf(raf.readDouble()));
                } catch (NumberFormatException ex) {
                    JOptionPane.showMessageDialog(null, "ERROR: No se han podido leer los campos en la consulta.");
                }              
            }
            else{
                throw new IOException();
            }
        } catch(IOException ex){
            JOptionPane.showMessageDialog(null, "ERROR: No hay ningún registro en esa posición.");
        }            
        
    }
    
    public void Modificar(int numExp){
        String auxNombre = "";
        String auxFechaNac = "";
        byte[] nombreBytes = new byte[200];
        byte[] fechaBytes = new byte[20];       
        double auxNota1 = (double)0;
        double auxNota2 = (double)0;
        double auxNotaFin = (double)0;
        pos = (numExp-1) * TAMANO;
        try{
            raf.seek(pos);
            raf.readInt();
            raf.readFully(nombreBytes);    
            raf.readFully(fechaBytes);
            auxNombre = new String(nombreBytes);
            auxFechaNac = new String(fechaBytes);      
            auxNota1 = raf.readDouble();
            auxNota2 = raf.readDouble();
            auxNotaFin = raf.readDouble();
        }
        catch(IOException ex){
            JOptionPane.showMessageDialog(null, "Error de lectura");
        }
        try{
            raf.seek(pos);
            raf.readInt();
            if (txtNombre.getText().equals("")) {
                raf.writeChars(auxNombre);
            } else{
                StringBuffer sb = new StringBuffer(txtNombre.getText());
                sb.setLength(100);
                raf.writeChars(sb.toString());
            }
            if (txtFnac.getText().equals("")) {
                raf.writeChars(auxFechaNac);
            } else{
                StringBuffer sb = new StringBuffer(ConvertirStringDate(txtFnac.getText()));
                sb.setLength(10);
                raf.writeChars(sb.toString());
            }            
            if (txtNota1.getText().equals("")) {
                raf.writeDouble(auxNota1);
            } else{
                raf.writeDouble(Double.parseDouble(txtNota1.getText()));
            }
            if (txtNota2.getText().equals("")) {
                raf.writeDouble(auxNota2);
            } else{
                raf.writeDouble(Double.parseDouble(txtNota2.getText()));
            }            
            if (txtNotaFIN.getText().equals("")) {
                raf.writeDouble(auxNotaFin);
            } else{
                raf.writeDouble(Double.parseDouble(txtNotaFIN.getText()));
            }            
        } catch(IOException ex){
            JOptionPane.showMessageDialog(null, "Error de lectura");            
        }
        cargarDatos();
    }
    
    public static String ConvertirStringDate(String fechaString){
        Date fecha;
        DateFormat formato = new SimpleDateFormat("dd/MM/yyyy");
        try {
            fecha = formato.parse(fechaString);
        } catch (ParseException ex) {
            JOptionPane.showMessageDialog(null,"ERROR: La fecha introducida no es válida. Se cogerá la actual.");
            fecha = Calendar.getInstance().getTime();
        }
        fechaString = formato.format(fecha);
        return fechaString;
    }
    public static String ConvertirCharArrayString(char[] arrayChars){
        String salida = "";
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < arrayChars.length; i++) {
            sb.append(arrayChars[i]);
        }
        salida = sb.toString();
        salida = salida.trim();
        return salida;
    }

}

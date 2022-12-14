package ad_2022_23_practica_01_explorador_marioortizjibaja;

import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.io.File;
import java.io.FilenameFilter;  //  Librería necesaria para poder implementar la interfaz del mismo nombre.
import javax.swing.JOptionPane;
import javax.swing.WindowConstants;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author akihi
 */
public class mainExplorador extends javax.swing.JFrame {
    File directorio;
    File[] ficheros;
    /**
     * Creates new form mainExplorador
     */
    public mainExplorador() {
        initComponents();
        Configurar();

    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txtRuta = new javax.swing.JTextField();
        txtExtension = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        btnBuscar = new javax.swing.JButton();
        btnFiltrar = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblArchivos = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Práctica 01: Explorador de archivos | Mario Ortiz Jibaja");

        txtExtension.setEnabled(false);

        jLabel1.setText("Indica un directorio:");

        jLabel2.setText("Indica extensión:");

        btnBuscar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/iconoLupa.png"))); // NOI18N
        btnBuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarActionPerformed(evt);
            }
        });

        btnFiltrar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/iconoLupa.png"))); // NOI18N
        btnFiltrar.setEnabled(false);
        btnFiltrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnFiltrarActionPerformed(evt);
            }
        });

        tblArchivos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Nombre", "Extensión", "Tamaño", "F/D"
            }
        ));
        jScrollPane1.setViewportView(tblArchivos);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(49, 49, 49)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jLabel1)
                    .addComponent(jLabel2))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(txtExtension)
                    .addComponent(txtRuta, javax.swing.GroupLayout.PREFERRED_SIZE, 172, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnFiltrar, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(210, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(72, 72, 72)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnBuscar)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(txtRuta, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jLabel1)))
                .addGap(35, 35, 35)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnFiltrar, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(txtExtension, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jLabel2)))
                .addGap(38, 38, 38)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 286, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(109, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnFiltrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnFiltrarActionPerformed
        DefaultTableModel tabla = (DefaultTableModel)tblArchivos.getModel();    //  Referencia al modelo de la tabla para poder operar con ella. Se castea de TableModel a DefaultTableModel.
        String ext = txtExtension.getText().toLowerCase();      
        tabla.setRowCount(0);   //  Limpiar la tabla eliminando las filas.
        ficheros = directorio.listFiles(new FilenameFilter() {      //  Con la interfaz FileNameFilter se filtra el array de File implementando el método y pasándole la extensión escrita en el TextField.
            @Override
            public boolean accept(File dir, String name) {
                String ext = txtExtension.getText().toLowerCase();
                return name.toLowerCase().endsWith(ext);    //  Devuelve true para cada fichero que cumple con el filtro que le indicamos.
            }
        });
        for (int i = 0; i < ficheros.length; i++) {
                    String nombre = ficheros[i].getName();
                    String tamano = ""+ficheros[i].length();
                    ext = "";
                    String tipo;
                    if (ficheros[i].isFile()) {
                        tipo = "Es un fichero.";  
                        ext = nombre.substring(nombre.lastIndexOf(".")+1);      //  Se extrae la extensión con un substring a partir de la derecha del punto.

                    }
                    else{
                        tipo = "Es un directorio.";
                    }
                    tabla.addRow(new String[]{nombre,ext,tamano,tipo});     //  Se añade una columna con un array de Strings.
                }
    }//GEN-LAST:event_btnFiltrarActionPerformed

    private void btnBuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarActionPerformed
        String ruta = txtRuta.getText();
        DefaultTableModel tabla = (DefaultTableModel)tblArchivos.getModel();    
        tabla.setRowCount(0);  
        if (!ruta.isEmpty()) {      //  Comprobamos que en el directorio haya contenido.
            directorio = new File(ruta);
            if (directorio.isDirectory() && directorio.exists()) {
            ficheros = directorio.listFiles();
            txtExtension.setEnabled(true);  //  Se activan tanto el campo de texto como el botón tras comprobar que el directorio existe y que no está vacío.
            btnFiltrar.setEnabled(true);
                for (int i = 0; i < ficheros.length; i++) {
                    String nombre = ficheros[i].getName();
                    String ext = "";
                    String tamano = ""+ficheros[i].length();
                    String tipo;
                    if (ficheros[i].isFile()) {
                        tipo = "Es un fichero.";
                        ext = nombre.substring(nombre.lastIndexOf(".")+1);      
                    }
                    else{
                        tipo = "Es un directorio.";
                    }
                    tabla.addRow(new String[]{nombre,ext,tamano,tipo});     
                }
             }
            else{
                JOptionPane.showMessageDialog(null,"La ruta no existe o no es un directorio.", "Ruta inválida", JOptionPane.ERROR_MESSAGE);
                txtExtension.setEnabled(false); //  Se deshabilitan los campos de filtrado en cuanto se comprueba que la ruta no es válida.
                btnFiltrar.setEnabled(false);   
                txtRuta.requestFocus();     //  Se pone el foco en el JTextField por comodidad para el usuario.
            }
        } else {
            JOptionPane.showMessageDialog(null,"Por favor, indica un directorio.", "Campo vacío", JOptionPane.ERROR_MESSAGE);
            txtRuta.requestFocus();    
        }
    }//GEN-LAST:event_btnBuscarActionPerformed

    private void Configurar(){  //  En este método asignamos una configuración cuando el programa inicia, ya que no podemos manipular initComponents.
        setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
        addWindowListener(new WindowAdapter(){      //  Implemento este adaptador para mostrar un mensaje cuando se intente cerrar la ventana y evitar que el usuario cierre por accidente el programa.
            @Override
            public void windowClosing(WindowEvent e) {
                String[] opciones = {"Claro", "No, me quedo"};
                int respuesta = 0;
                respuesta = JOptionPane.showOptionDialog(null, "¿Estás seguro de que quieres salir del programa?", "Salir", JOptionPane.YES_NO_OPTION, respuesta, null, 
                        opciones, opciones[0]);
                System.out.println(respuesta);
                if (respuesta == JOptionPane.YES_OPTION) {
                    dispose();
                }
                
            }
            
        });
    }
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
            java.util.logging.Logger.getLogger(mainExplorador.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(mainExplorador.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(mainExplorador.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(mainExplorador.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new mainExplorador().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnFiltrar;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tblArchivos;
    private javax.swing.JTextField txtExtension;
    private javax.swing.JTextField txtRuta;
    // End of variables declaration//GEN-END:variables
}

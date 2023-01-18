import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

public class fPrincipal extends javax.swing.JFrame {
    private JdConectar jd;
    private DefaultTableModel dtm;
    public static Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private int filasafectadas;
    private String ins;

    public fPrincipal() {

        /* Abrimos el JDialog de Conexion */
        jd = new JdConectar(this, true);
        jd.setVisible(true);

        setExtendedState(JFrame.MAXIMIZED_BOTH);
        initComponents();
        dtm = (DefaultTableModel) jTable1.getModel();
        
        rellenarTabla();
    }
    
    private void rellenarTabla(){
        ins = "Select * from alumnos";
        /* Este metodo rellena el JTable con los datos de la consulta Select * from alumnos*/
        try{
            if (con != null) {
                ps = con.prepareStatement(ins);
                rs = ps.executeQuery();
                dtm.setRowCount(0);
                while (rs.next()) {                    
                    Object[] datos = {rs.getString(1), rs.getString(2), rs.getString(3), rs.getString(4)};
                    dtm.addRow(datos);
                }
                rs.close();
            } else{
                JOptionPane.showMessageDialog(this, "Se ha perdido la conexión con Oracle","Mensaje", JOptionPane.INFORMATION_MESSAGE);
                System.exit(0);
            }
        } catch(SQLException ex){
            JOptionPane.showMessageDialog(this, ex.getSQLState()+"-"+ex.getMessage(),"Mensaje", JOptionPane.INFORMATION_MESSAGE);
        }
        
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        btSelecc = new javax.swing.JButton();
        txtFichero = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        btEjecutar = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jScrollPane2 = new javax.swing.JScrollPane();
        taScripts = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Ejecucion de Script de Oracle");

        jLabel1.setText("Archivo Scripts");

        btSelecc.setText("Seleccionar");
        btSelecc.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btSeleccActionPerformed(evt);
            }
        });

        txtFichero.setEditable(false);

        jLabel2.setText("Sentencia SQL");

        btEjecutar.setText("Ejecutar");
        btEjecutar.setEnabled(false);
        btEjecutar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btEjecutarActionPerformed(evt);
            }
        });

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Codigo", "Nombre", "Asignatura", "Nota Final"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jTable1.getTableHeader().setReorderingAllowed(false);
        jScrollPane1.setViewportView(jTable1);
        if (jTable1.getColumnModel().getColumnCount() > 0) {
            jTable1.getColumnModel().getColumn(0).setResizable(false);
            jTable1.getColumnModel().getColumn(1).setResizable(false);
            jTable1.getColumnModel().getColumn(2).setResizable(false);
            jTable1.getColumnModel().getColumn(3).setResizable(false);
        }

        taScripts.setColumns(20);
        taScripts.setRows(5);
        jScrollPane2.setViewportView(taScripts);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(txtFichero)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btSelecc, javax.swing.GroupLayout.PREFERRED_SIZE, 157, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 1145, Short.MAX_VALUE)
                            .addComponent(jScrollPane2))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btEjecutar, javax.swing.GroupLayout.PREFERRED_SIZE, 157, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(btSelecc)
                    .addComponent(txtFichero, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel2)
                        .addComponent(btEjecutar))
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 144, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btSeleccActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btSeleccActionPerformed
        File fichero = null;        
        JFileChooser jfc = new JFileChooser();
        jfc.setCurrentDirectory(new File(".")); //  Carpeta actual del proyecto, con tal de no tener que buscar los Scripts continuamente.
        
        int res = jfc.showOpenDialog(this);
        if (res == JFileChooser.APPROVE_OPTION) {
            fichero = jfc.getSelectedFile();
            txtFichero.setText(fichero.getAbsolutePath());
            leerFichero();     
        }
        

       
    }//GEN-LAST:event_btSeleccActionPerformed

    private void leerFichero() {
        File fichero = null;
        FileReader fr = null;
        BufferedReader br = null;
        String linea = "";
        
        fichero = new File(txtFichero.getText());
        if (fichero != null) {
            try {
                taScripts.setText("");
                fr = new FileReader(fichero);
                br = new BufferedReader(fr);
                while ((linea = br.readLine()) != null) {                        
                    taScripts.append(linea+"\n");
                }
                br.close();
                fr.close();
                btEjecutar.setEnabled(true);
                } catch (FileNotFoundException ex) {
                    JOptionPane.showMessageDialog(this, "Error al cargar el fichero.","Mensaje", JOptionPane.INFORMATION_MESSAGE);
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(this, "Error de lectura.","Mensaje", JOptionPane.INFORMATION_MESSAGE);
                }          
        } else{
            JOptionPane.showMessageDialog(null, "No hay ningún fichero que leer.","Mensaje", JOptionPane.INFORMATION_MESSAGE);
        }
    }

    private void btEjecutarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btEjecutarActionPerformed
        /* En este metodo se ejecuta la sentencia SQL contenida en cada linea del
           fichero de texto.
           Despues de ejecutar todas las lineas se actualiza el JTable
        */
        File fichero = null;
        FileReader fr = null;
        BufferedReader br = null;
        String linea = "";
        try {
            fichero = new File(txtFichero.getText());
            if (fichero != null) {
                fr = new FileReader(fichero);
                br = new BufferedReader(fr);
                while ((linea = br.readLine()) != null) {
                    ejecutarLinea(linea);
                } 
                br.close();
                fr.close();
                rellenarTabla();
            }
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(this, "Error de lectura","Mensaje", JOptionPane.INFORMATION_MESSAGE);
        } catch (NullPointerException ex){
            JOptionPane.showMessageDialog(this, "No se ha podido crear el lector.","Mensaje", JOptionPane.INFORMATION_MESSAGE);
        }
        
    }//GEN-LAST:event_btEjecutarActionPerformed

    private void ejecutarLinea(String linea) {
        char letra;
        linea = linea.toUpperCase();
        if (!linea.trim().isEmpty()) {
            letra = linea.trim().charAt(0);            
        } else {return ;}
        ins = linea;
        /*
         Este metodo ejecuta la sentencia SQL contenida en el String linea 
         que se pasa como parámetro.
        
            Si la primera letra de este String es una S, se tratará de una sentencia SELECT
         que rellenará el JTable con los registros obtenidos por dicha consulta, 
         sin borrar los anteriores.
        
               Si la primera letra de este String es una I (Insert), D (delete) o U (Update)
        se ejecutará la sentencia y se mostrarán los registros afectados por cada operación.
        */
        if (con != null) {
            switch(letra){
                case 'S':
                    try{
                        ps = con.prepareStatement(ins);
                        rs = ps.executeQuery();
                        while (rs.next()) {                    
                            Object[] datos = {rs.getString(1), rs.getString(2), rs.getString(3), rs.getString(4)};
                            dtm.addRow(datos);
                        }
                        rs.close();
                        JOptionPane.showMessageDialog(this, "Select añadido al JTable","Mensaje", JOptionPane.INFORMATION_MESSAGE);
                    } catch (SQLException ex) {
                        JOptionPane.showMessageDialog(this, "Error en " + linea + "\n"+ ex.getSQLState()+"-"+ex.getMessage(),"Mensaje", JOptionPane.INFORMATION_MESSAGE);
                    }  
                    break;
                case 'I':
                    try{
                        ps = con.prepareStatement(ins);
                        filasafectadas = ps.executeUpdate();
                        if (filasafectadas != -1) {
                            JOptionPane.showMessageDialog(this, filasafectadas+" filas afectadas por "+ letra,"Mensaje", JOptionPane.INFORMATION_MESSAGE);
                        }
                    } catch (SQLException ex) {
                       JOptionPane.showMessageDialog(this, "Error en " + linea + "\n"+ ex.getSQLState()+"-"+ex.getMessage(),"Mensaje", JOptionPane.INFORMATION_MESSAGE);
                    }                  
                    break;
                case 'D':
                    try{
                        ps = con.prepareStatement(ins);
                        filasafectadas = ps.executeUpdate();
                        if (filasafectadas != -1) {
                            JOptionPane.showMessageDialog(this, filasafectadas+" filas afectadas por "+ letra,"Mensaje", JOptionPane.INFORMATION_MESSAGE);
                        }
                    } catch (SQLException ex) {
                       JOptionPane.showMessageDialog(this, "Error en " + linea + "\n"+ ex.getSQLState()+"-"+ex.getMessage(),"Mensaje", JOptionPane.INFORMATION_MESSAGE);
                    }                  
                    break;
                case 'U':
                    try{
                        ps = con.prepareStatement(ins);
                        filasafectadas = ps.executeUpdate();
                        if (filasafectadas != -1) {
                            JOptionPane.showMessageDialog(this, filasafectadas+" filas afectadas por "+ letra,"Mensaje", JOptionPane.INFORMATION_MESSAGE);
                        }
                    } catch (SQLException ex) {
                        JOptionPane.showMessageDialog(this, "Error en " + linea + "\n"+ ex.getSQLState()+"-"+ex.getMessage(),"Mensaje", JOptionPane.INFORMATION_MESSAGE);
                    }                  
                    break;
            } 
        }else{
            JOptionPane.showMessageDialog(this, "Se ha perdido la conexión con Oracle","Mensaje", JOptionPane.INFORMATION_MESSAGE);
            System.exit(0);
        }

        
        
           
    }
    
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
            java.util.logging.Logger.getLogger(fPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(fPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(fPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(fPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new fPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btEjecutar;
    private javax.swing.JButton btSelecc;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTable jTable1;
    private javax.swing.JTextArea taScripts;
    private javax.swing.JTextField txtFichero;
    // End of variables declaration//GEN-END:variables
}

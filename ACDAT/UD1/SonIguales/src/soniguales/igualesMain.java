/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package soniguales;

import java.io.*;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.filechooser.FileNameExtensionFilter;

/**
 *
 * @author akihi
 */
public class igualesMain extends javax.swing.JFrame {

    /**
     * Creates new form igualesMain
     */
    public igualesMain() {
        initComponents();
        this.setTitle("Ejercicio de clase: Comparar ficheros | Mario Ortiz Jibaja");
        this.setResizable(false);
        
        txtFich1.setEditable(false);
        txtFich2.setEditable(false);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txtFich1 = new javax.swing.JTextField();
        txtFich2 = new javax.swing.JTextField();
        btnSel1 = new javax.swing.JButton();
        btnSel2 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        btnComparar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        btnSel1.setText("Seleccionar 1");
        btnSel1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSel1ActionPerformed(evt);
            }
        });

        btnSel2.setText("Seleccionar 2");
        btnSel2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSel2ActionPerformed(evt);
            }
        });

        jLabel1.setText("Fichero 1: ");

        jLabel2.setText("Fichero 2: ");

        btnComparar.setText("Comparar");
        btnComparar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCompararActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(30, 30, 30)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel1)
                                .addGap(18, 18, 18)
                                .addComponent(txtFich1, javax.swing.GroupLayout.PREFERRED_SIZE, 178, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel2)
                                .addGap(18, 18, 18)
                                .addComponent(txtFich2, javax.swing.GroupLayout.PREFERRED_SIZE, 178, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(btnSel1, javax.swing.GroupLayout.PREFERRED_SIZE, 136, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(btnSel2, javax.swing.GroupLayout.PREFERRED_SIZE, 136, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(138, 138, 138)
                        .addComponent(btnComparar, javax.swing.GroupLayout.PREFERRED_SIZE, 136, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(140, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(62, 62, 62)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtFich1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnSel1)
                    .addComponent(jLabel1))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(txtFich2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(btnSel2))
                    .addComponent(jLabel2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnComparar)
                .addContainerGap(24, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnSel1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSel1ActionPerformed
        JFileChooser jfc = new JFileChooser();
        jfc.setFileSelectionMode(JFileChooser.FILES_ONLY);
        FileNameExtensionFilter filtro = new FileNameExtensionFilter("Archivos Java", "java");
        jfc.setFileFilter(filtro);
        if (jfc.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
            txtFich1.setText(jfc.getSelectedFile().getAbsolutePath());
        } else{
            JOptionPane.showMessageDialog(this, "No se ha seleccionado un fichero");
        }
    }//GEN-LAST:event_btnSel1ActionPerformed

    private void btnSel2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSel2ActionPerformed
        JFileChooser jfc = new JFileChooser();
        jfc.setFileSelectionMode(JFileChooser.FILES_ONLY);
        FileNameExtensionFilter filtro = new FileNameExtensionFilter("Archivos Java", "java");
        jfc.setFileFilter(filtro);
        if (jfc.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
            txtFich2.setText(jfc.getSelectedFile().getAbsolutePath());
        } else{
            JOptionPane.showMessageDialog(this, "No se ha seleccionado un fichero");
        }
    }//GEN-LAST:event_btnSel2ActionPerformed

    private void btnCompararActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCompararActionPerformed
         if (txtFich1.getText().isEmpty() || txtFich2.getText().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Se deben elegir dos ficheros.");
            return;
        }       
       FileReader reader1 = null;
       FileReader reader2 = null;
       File fich1 = new File(txtFich1.getText());
       File fich2 = new File(txtFich2.getText());
       int num1 = 0;
       int num2 = 0;
       try {
            reader1 = new FileReader(fich1);
            reader2 = new FileReader(fich2);
            while ((num1 = reader1.read()) != -1 && (num2 = reader2.read()) != -1) {  
                if (num1 != num2) {
                    JOptionPane.showMessageDialog(this,"Los ficheros no son iguales");
                    return;
                }
            }
            JOptionPane.showMessageDialog(this,"Los ficheros S?? son iguales");
        } catch (FileNotFoundException ex) {
            JOptionPane.showMessageDialog(this, "Error: Fichero no encontrado");
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(this, "Error de lectura");
        } finally{
            
            try {
                reader1.close();
                reader2.close();
            } catch (IOException ex) {
                
            }
        }
        
    }//GEN-LAST:event_btnCompararActionPerformed

    
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
            java.util.logging.Logger.getLogger(igualesMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(igualesMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(igualesMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(igualesMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new igualesMain().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnComparar;
    private javax.swing.JButton btnSel1;
    private javax.swing.JButton btnSel2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JTextField txtFich1;
    private javax.swing.JTextField txtFich2;
    // End of variables declaration//GEN-END:variables
}

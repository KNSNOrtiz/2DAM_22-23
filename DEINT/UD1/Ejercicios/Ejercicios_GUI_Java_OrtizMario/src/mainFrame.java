
import javax.swing.JOptionPane;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */

/**
 *
 * @author akihi
 */
public class mainFrame extends javax.swing.JFrame {

    /**
     * Creates new form mainFrame
     */
    public mainFrame() {
        initComponents();
        this.setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
        
    }
    
    private void ConfirmarSalida(){
        int res = JOptionPane.showConfirmDialog(this, "Se va a cerrar la ventana.", "¿Seguro que desea salir?", JOptionPane.YES_NO_OPTION);
        if (res == JOptionPane.YES_OPTION) {
            dispose();
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        itemEj1 = new javax.swing.JMenuItem();
        itemEj2 = new javax.swing.JMenuItem();
        itemEj3 = new javax.swing.JMenuItem();
        itemEj4 = new javax.swing.JMenuItem();
        itemEj5 = new javax.swing.JMenuItem();
        itemEj6 = new javax.swing.JMenuItem();
        itemSalir = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jMenu1.setText("Ejercicios");

        itemEj1.setText("Ejercicio 1: Suma y Resta");
        itemEj1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemEj1ActionPerformed(evt);
            }
        });
        jMenu1.add(itemEj1);

        itemEj2.setText("Ejercicio 2: Suma y Resta +");
        itemEj2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemEj2ActionPerformed(evt);
            }
        });
        jMenu1.add(itemEj2);

        itemEj3.setText("Ejercicio 3: Conversor");
        itemEj3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemEj3ActionPerformed(evt);
            }
        });
        jMenu1.add(itemEj3);

        itemEj4.setText("Ejercicio 4: TextArea y Listeners");
        itemEj4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemEj4ActionPerformed(evt);
            }
        });
        jMenu1.add(itemEj4);

        itemEj5.setText("Ejercicio 5: Cancelar Cierre");
        itemEj5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemEj5ActionPerformed(evt);
            }
        });
        jMenu1.add(itemEj5);

        itemEj6.setText("Ejercicio 6: Conversor +");
        itemEj6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemEj6ActionPerformed(evt);
            }
        });
        jMenu1.add(itemEj6);

        jMenuBar1.add(jMenu1);

        itemSalir.setText("Salir");
        itemSalir.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                itemSalirMouseClicked(evt);
            }
        });
        jMenuBar1.add(itemSalir);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 607, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 385, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void itemEj1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemEj1ActionPerformed
        Ej1_SumaResta dialog = new Ej1_SumaResta(this, true);
        dialog.setVisible(true);
    }//GEN-LAST:event_itemEj1ActionPerformed

    private void itemEj2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemEj2ActionPerformed
        Ej2_SumaRestaAmpliado dialog = new Ej2_SumaRestaAmpliado(this, true);
        dialog.setVisible(true);
    }//GEN-LAST:event_itemEj2ActionPerformed

    private void itemEj5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemEj5ActionPerformed
        Ej5_CerrarVentana dialog = new Ej5_CerrarVentana(this, true);
        dialog.setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
        dialog.setVisible(true);
    }//GEN-LAST:event_itemEj5ActionPerformed

    private void itemEj3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemEj3ActionPerformed
        Ej3_EurosPesetas dialog = new  Ej3_EurosPesetas(this, true);
        dialog.setVisible(true);
    }//GEN-LAST:event_itemEj3ActionPerformed

    private void itemEj4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemEj4ActionPerformed
        Ej4_TextAreaListeners dialog = new Ej4_TextAreaListeners(this, true);
        dialog.setVisible(true);
    }//GEN-LAST:event_itemEj4ActionPerformed

    private void itemEj6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemEj6ActionPerformed
        Ej6_EurosPesetasAmpliado dialog = new Ej6_EurosPesetasAmpliado(this, true);
        dialog.setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
        dialog.setVisible(true);
    }//GEN-LAST:event_itemEj6ActionPerformed

    private void itemSalirMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_itemSalirMouseClicked
        ConfirmarSalida();
    }//GEN-LAST:event_itemSalirMouseClicked

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
            java.util.logging.Logger.getLogger(mainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(mainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(mainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(mainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new mainFrame().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenuItem itemEj1;
    private javax.swing.JMenuItem itemEj2;
    private javax.swing.JMenuItem itemEj3;
    private javax.swing.JMenuItem itemEj4;
    private javax.swing.JMenuItem itemEj5;
    private javax.swing.JMenuItem itemEj6;
    private javax.swing.JMenu itemSalir;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    // End of variables declaration//GEN-END:variables
}

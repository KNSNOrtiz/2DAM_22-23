
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
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jProgressBar1 = new javax.swing.JProgressBar();
        jMenuBar1 = new javax.swing.JMenuBar();
        menuArchivo = new javax.swing.JMenu();
        itemNuevo = new javax.swing.JMenuItem();
        itemAbrir = new javax.swing.JMenuItem();
        itemSalir = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setResizable(false);

        menuArchivo.setText("Archivo");

        itemNuevo.setText("Nuevo");
        itemNuevo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemNuevoActionPerformed(evt);
            }
        });
        menuArchivo.add(itemNuevo);

        itemAbrir.setText("Abrir");
        menuArchivo.add(itemAbrir);

        jMenuBar1.add(menuArchivo);

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
            .addGap(0, 736, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 384, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void itemSalirMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_itemSalirMouseClicked
        int res = JOptionPane.showConfirmDialog(this, "Se va a cerrar el programa. ¿Seguro?", "Salir del programa", JOptionPane.YES_NO_CANCEL_OPTION);
        if (res == JOptionPane.YES_OPTION) {
            System.exit(0);
        }
    }//GEN-LAST:event_itemSalirMouseClicked

    private void itemNuevoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemNuevoActionPerformed
        dialogEditar dialog = new dialogEditar(this, false);
        dialog.setVisible(true);
    }//GEN-LAST:event_itemNuevoActionPerformed

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
    private javax.swing.JMenuItem itemAbrir;
    private javax.swing.JMenuItem itemNuevo;
    private javax.swing.JMenu itemSalir;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JProgressBar jProgressBar1;
    private javax.swing.JMenu menuArchivo;
    // End of variables declaration//GEN-END:variables
}

import javax.swing.JLabel;

public class PantallaPrincipal extends javax.swing.JFrame {

    public PantallaPrincipal() {
        initComponents();
    }

     @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButtonClickMouse = new javax.swing.JButton();
        jButtonEvento = new javax.swing.JButton();
        jLabelSaludo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jButtonClickMouse.setText("Click Mouse");
        jButtonClickMouse.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButtonClickMouseMouseClicked(evt);
            }
        });

        jButtonEvento.setText("Evento");
        jButtonEvento.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonEventoActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(130, 130, 130)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jButtonClickMouse, javax.swing.GroupLayout.PREFERRED_SIZE, 131, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jButtonEvento)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(143, 143, 143)
                        .addComponent(jLabelSaludo)))
                .addContainerGap(139, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(54, 54, 54)
                .addComponent(jButtonClickMouse, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(28, 28, 28)
                .addComponent(jButtonEvento)
                .addGap(33, 33, 33)
                .addComponent(jLabelSaludo)
                .addContainerGap(101, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonClickMouseMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButtonClickMouseMouseClicked
        PantallaSecundaria pantalla2=new PantallaSecundaria(this,true);
        pantalla2.setVisible(true);
    }//GEN-LAST:event_jButtonClickMouseMouseClicked

    private void jButtonEventoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonEventoActionPerformed
        PantallaSecundaria pantalla2=new PantallaSecundaria(this,true);
        pantalla2.setVisible(true);
    }//GEN-LAST:event_jButtonEventoActionPerformed

    public void EstablecerNombre(String n) {
        jLabelSaludo.setText("Bienvenido: " + n);           
    }
            

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new PantallaPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonClickMouse;
    private javax.swing.JButton jButtonEvento;
    private javax.swing.JLabel jLabelSaludo;
    // End of variables declaration//GEN-END:variables
}

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JPanel.java to edit this template
 */
package bannerpublicitario;

import java.util.ArrayList;

/**
 *
 * @author akihi
 */
public class PanelBanner extends javax.swing.JPanel {
    
    public PanelBanner() {
        initComponents();
    }
    
    public DatosBanner getValue(){
        ArrayList<String> frases = new ArrayList<>();    
        for (int i = 0; i < cbxFrases.getItemCount(); i++) {
            frases.add(cbxFrases.getItemAt(i));
        }
        DatosBanner datosBanner = new DatosBanner(frases,(int)spinIntervalo.getValue(), (int)spinRepeticion.getValue());    
        return datosBanner;
    }
    
    


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        cbxFrases = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        btnAnadir = new javax.swing.JButton();
        btnBorrar = new javax.swing.JButton();
        jLabel4 = new javax.swing.JLabel();
        txtFrase = new javax.swing.JTextField();
        spinIntervalo = new javax.swing.JSpinner();
        spinRepeticion = new javax.swing.JSpinner();

        cbxFrases.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Frase por defecto", "Otra más" }));

        jLabel1.setText("Frases:");

        jLabel2.setText("Intervalo:");

        jLabel3.setText("Repetición:");

        btnAnadir.setText("Añadir");
        btnAnadir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAnadirActionPerformed(evt);
            }
        });

        btnBorrar.setText("Borrar");
        btnBorrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBorrarActionPerformed(evt);
            }
        });

        jLabel4.setText("Nueva frase:");

        spinIntervalo.setModel(new javax.swing.SpinnerNumberModel(0, 0, null, 100));

        spinRepeticion.setModel(new javax.swing.SpinnerNumberModel(-1, -1, null, 1));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(106, 106, 106)
                        .addComponent(btnAnadir)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnBorrar))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(26, 26, 26)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(jLabel3)
                                    .addComponent(jLabel2)
                                    .addComponent(jLabel4))
                                .addGap(18, 18, 18))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(22, 22, 22)
                                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 52, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(9, 9, 9)))
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(cbxFrases, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(spinIntervalo)
                            .addComponent(spinRepeticion)
                            .addComponent(txtFrase, javax.swing.GroupLayout.PREFERRED_SIZE, 135, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addContainerGap(42, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(32, 32, 32)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cbxFrases, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(spinIntervalo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(spinRepeticion, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 31, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(txtFrase, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(17, 17, 17)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnAnadir)
                    .addComponent(btnBorrar))
                .addGap(40, 40, 40))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void btnAnadirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAnadirActionPerformed
        //  Es necesario añadir comillas a cada frase para evitar problemas en el InitializationString de PropertyEditorSupport.
        //  De no hacerlo, a la hora de insertarse el código en el proyecto de Pruebas, cuando se intenta crear el ArrayList a partir de una colección,
        //  quedaría tal que así:
        //  new java.util.ArrayList<String>(java.util.Arrays.asList(Hola, Que tal));
        //  
        //  Con las comillas conseguimos que se inserten como Strings:
        //  new java.util.ArrayList<String>(java.util.Arrays.asList("Hola", "Que tal"));
        if (!txtFrase.getText().isEmpty()) {
            String frase = txtFrase.getText();
           StringBuilder sb = new StringBuilder(frase);
            /*sb.insert(0, '"');
            sb.append('"');*/
            cbxFrases.addItem(sb.toString());
            cbxFrases.setSelectedIndex(cbxFrases.getItemCount()-1);
        }
    }//GEN-LAST:event_btnAnadirActionPerformed

    private void btnBorrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBorrarActionPerformed
        if (cbxFrases.getItemCount() != 0) {
             cbxFrases.removeItemAt(cbxFrases.getSelectedIndex());
        }
       
    }//GEN-LAST:event_btnBorrarActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAnadir;
    private javax.swing.JButton btnBorrar;
    private javax.swing.JComboBox<String> cbxFrases;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JSpinner spinIntervalo;
    private javax.swing.JSpinner spinRepeticion;
    private javax.swing.JTextField txtFrase;
    // End of variables declaration//GEN-END:variables
}

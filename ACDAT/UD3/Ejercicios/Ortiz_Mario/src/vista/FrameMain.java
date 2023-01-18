package vista;


import controlador.ctrlBD;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.math.BigDecimal;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import modelo.Alumnos;
import modelo.Cursos;
import modelo.Examenes;
import modelo.Matriculas;


public class FrameMain extends javax.swing.JFrame {
    
    private ctrlBD controlBD = new ctrlBD();
    
    DefaultTableModel tableAlumnos;
    DefaultTableModel tableCursos;
    DefaultTableModel tableMatriculas;
    DefaultTableModel tableExamenes;
    
    private List<Alumnos> listaAlumnos;
    private List<Cursos> listaCursos;
    private List<Matriculas> listaMatriculas;
    private List<Examenes> listaExamenes;
    
    int alumnoSeleccionado = 0; //  Esta variable es necesaria para poder cargar las matrículas tanto al hacer click desde la tabla, como al actualizar las notas.
    String codAluSelecc = "";
    String codCurSelecc = "";
    Examenes examenSelecc = null;
    
    
    public FrameMain() {
        initComponents();
        tableAlumnos = (DefaultTableModel)JTableAlumnos.getModel();
        tableCursos = (DefaultTableModel)JTableCursos.getModel();
        tableMatriculas = (DefaultTableModel)JTableMatriculas.getModel();
        tableExamenes = (DefaultTableModel)JTableExamenes.getModel();
        cargarTablas();
        
        JTableAlumnos.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                alumnoSeleccionado = JTableAlumnos.getSelectedRow();
                if (alumnoSeleccionado >= 0) {
                    codAluSelecc = JTableAlumnos.getValueAt(alumnoSeleccionado, 0).toString();    
                    cargarMatriculas();
                } 
            }   
        });
        JTableCursos.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                int fil = JTableCursos.getSelectedRow();
                if (fil >= 0) {
                    codCurSelecc = JTableCursos.getValueAt(fil, 0).toString();   
                } 
            }
            
        });
        JTableMatriculas.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                int fil = JTableMatriculas.getSelectedRow();
                if (fil >= 0) {
                    listaExamenes = controlBD.listarExamenes(listaMatriculas.get(fil));
                    cargarExamenes();
                } 
            }   
        });
        JTableExamenes.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                int fil = JTableExamenes.getSelectedRow();
                if (fil >= 0) {
                    try{
                        examenSelecc = listaExamenes.get(fil);
                        txtFecha.setText(new SimpleDateFormat("dd/MM/yyyy").format(examenSelecc.getDfecexam()));
                    } catch (NullPointerException ex){
                        txtFecha.setText("");
                    }
                    txtNota.setText(String.valueOf(examenSelecc.getNnotaexam()));
                }
            } 
        });
    }


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txtFecha = new javax.swing.JTextField();
        txtNota = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        JTableAlumnos = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        JTableCursos = new javax.swing.JTable();
        btnActualizar = new javax.swing.JButton();
        btnJSON = new javax.swing.JButton();
        btnMatricular = new javax.swing.JButton();
        jScrollPane3 = new javax.swing.JScrollPane();
        JTableMatriculas = new javax.swing.JTable();
        jScrollPane4 = new javax.swing.JScrollPane();
        JTableExamenes = new javax.swing.JTable();
        btnXML = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        itemAlumnos = new javax.swing.JMenuItem();
        itemCursos = new javax.swing.JMenuItem();
        itemSalir = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setTitle("Acceso a Datos UD3: Gestión de academia mediante Hibernate | Ortiz Jibaja, Mario");
        setResizable(false);

        JTableAlumnos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Código Alumno", "Nombre"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane1.setViewportView(JTableAlumnos);

        jLabel1.setText("Fecha examen:");

        jLabel2.setText("Nota:");

        JTableCursos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Código Curso", "Nombre Curso", "Nº Exámenes"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane2.setViewportView(JTableCursos);

        btnActualizar.setText("Actualizar");
        btnActualizar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnActualizarActionPerformed(evt);
            }
        });

        btnJSON.setText("Boletín JSON");
        btnJSON.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnJSONActionPerformed(evt);
            }
        });

        btnMatricular.setText("Matricular Alumno en Curso");
        btnMatricular.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMatricularActionPerformed(evt);
            }
        });

        JTableMatriculas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Código Alumno", "Nombre Alumno", "Código Curso", "Nombre Curso", "Nota Media"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane3.setViewportView(JTableMatriculas);

        JTableExamenes.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Número Examen", "Fecha Examen", "Nota"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane4.setViewportView(JTableExamenes);

        btnXML.setText("Listado Matricula XML");
        btnXML.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnXMLActionPerformed(evt);
            }
        });

        jMenu1.setText("Gestión");

        itemAlumnos.setText("Alumnos");
        itemAlumnos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemAlumnosActionPerformed(evt);
            }
        });
        jMenu1.add(itemAlumnos);

        itemCursos.setText("Cursos");
        itemCursos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                itemCursosActionPerformed(evt);
            }
        });
        jMenu1.add(itemCursos);

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
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jScrollPane3))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(19, 19, 19)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 332, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 49, Short.MAX_VALUE)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 491, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(24, 24, 24))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(22, 22, 22)
                        .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 524, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(81, 81, 81)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel1, javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(jLabel2, javax.swing.GroupLayout.Alignment.TRAILING))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(btnActualizar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(txtFecha)
                                    .addComponent(txtNota, javax.swing.GroupLayout.PREFERRED_SIZE, 98, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addComponent(btnJSON, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnXML, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(320, 320, 320)
                        .addComponent(btnMatricular)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 178, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 178, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(27, 27, 27)
                        .addComponent(btnMatricular)
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 136, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 31, Short.MAX_VALUE)
                        .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(36, 36, 36))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 292, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtFecha, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel1))
                        .addGap(33, 33, 33)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtNota, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel2))
                        .addGap(18, 18, 18)
                        .addComponent(btnActualizar)
                        .addGap(35, 35, 35)
                        .addComponent(btnJSON)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnXML)
                        .addGap(69, 69, 69))))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnActualizarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnActualizarActionPerformed
        if (!txtFecha.getText().isEmpty() && !txtNota.getText().isEmpty()) {
            controlBD.modificarExamen(examenSelecc, txtFecha.getText(), txtNota.getText());
            cargarExamenes();
            cargarMatriculas();
        }

    }//GEN-LAST:event_btnActualizarActionPerformed

    private void btnJSONActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnJSONActionPerformed
        if (listaExamenes != null) {
            if (listaExamenes.size() != 0) {
                controlBD.ListarJSON(new ArrayList<>(listaExamenes)); 
            }  
        }
        else{
            JOptionPane.showMessageDialog(this, "No hay exámenes con los que elaborar el boletín.");
        }

    }//GEN-LAST:event_btnJSONActionPerformed

    private void btnMatricularActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMatricularActionPerformed
        if (!codCurSelecc.isEmpty() && !codAluSelecc.isEmpty()) {
            controlBD.matricularAlumno(codAluSelecc, codCurSelecc);
            listaMatriculas = controlBD.listarMatriculas(listaAlumnos.get(JTableAlumnos.getSelectedRow()));
            cargarMatriculas();
        }
    }//GEN-LAST:event_btnMatricularActionPerformed

    private void itemAlumnosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemAlumnosActionPerformed
        DialogAlumnos dialog = new DialogAlumnos(this, true);
        dialog.setVisible(true);
        cargarTablas();
    }//GEN-LAST:event_itemAlumnosActionPerformed

    private void itemCursosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_itemCursosActionPerformed
        DialogCursos dialog = new DialogCursos(this, true);
        dialog.setVisible(true);
        cargarTablas();
    }//GEN-LAST:event_itemCursosActionPerformed

    private void btnXMLActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnXMLActionPerformed
        if (listaAlumnos != null) {
            if (listaAlumnos.size() != 0) {
                controlBD.ListarXML(new ArrayList<>(listaAlumnos)); 
            }  
        }
        else{
            JOptionPane.showMessageDialog(this, "No hay alumnos que poder listar.");
        }
        
    }//GEN-LAST:event_btnXMLActionPerformed

    private void itemSalirMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_itemSalirMouseClicked
        int res = JOptionPane.showConfirmDialog(this, "Se va a cerrar el programa. Puede perderse información. ¿Estás seguro/a?");
        if (res == JOptionPane.YES_OPTION) {
            System.exit(0);
        }
    }//GEN-LAST:event_itemSalirMouseClicked
    
    private void cargarTablas(){
        listaAlumnos = controlBD.listarAlumnos();
        listaCursos = controlBD.listarCursos();
        
        tableAlumnos.setRowCount(0);
        tableCursos.setRowCount(0);
        
        for (Alumnos alumno : listaAlumnos) {
            Object[] fila = {alumno.getCcodalu(), alumno.getCnomalu()};
            tableAlumnos.addRow(fila);
        }
        for (Cursos curso : listaCursos) {
            Object[] fila = {curso.getCcodcurso(), curso.getCnomcurso(), curso.getNnumexa()};
            tableCursos.addRow(fila);
        }
    }
    //  Cargo la propia lista de matrículas en este método y no desde fuera para no depender de la tabla para obtener el índice.
    private void cargarMatriculas(){
        listaMatriculas = controlBD.listarMatriculas(listaAlumnos.get(alumnoSeleccionado));
        if (listaMatriculas != null) {
            tableMatriculas.setRowCount(0);
            for (Matriculas matricula : listaMatriculas) {
                Object[] fila = {matricula.getAlumnos().getCcodalu(),matricula.getAlumnos().getCnomalu(),matricula.getCursos().getCcodcurso(), matricula.getCursos().getCnomcurso(), matricula.getNnotamedia() };
                tableMatriculas.addRow(fila);
            }                        
        }
    }
    private void cargarExamenes(){
        if (listaExamenes != null) {
            tableExamenes.setRowCount(0);
            for (Examenes examen : listaExamenes) {
                String fechaString = "";
                if (examen.getDfecexam() != null) {
                    fechaString = new SimpleDateFormat("dd/MM/yyyy").format(examen.getDfecexam());
                }
                Object[] fila = {examen.getId().getNnumexam(),fechaString , examen.getNnotaexam()};
                tableExamenes.addRow(fila);
            }                        
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
            java.util.logging.Logger.getLogger(FrameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameMain().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTable JTableAlumnos;
    private javax.swing.JTable JTableCursos;
    private javax.swing.JTable JTableExamenes;
    private javax.swing.JTable JTableMatriculas;
    private javax.swing.JButton btnActualizar;
    private javax.swing.JButton btnJSON;
    private javax.swing.JButton btnMatricular;
    private javax.swing.JButton btnXML;
    private javax.swing.JMenuItem itemAlumnos;
    private javax.swing.JMenuItem itemCursos;
    private javax.swing.JMenu itemSalir;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JTextField txtFecha;
    private javax.swing.JTextField txtNota;
    // End of variables declaration//GEN-END:variables
}

package Vista;

import java.sql.*;
import java.util.Date;
import Controlador.*;
import Modelo.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

public class mainFrame extends javax.swing.JFrame {
    public static Connection con = null;
    
    CtrlBD controlBD = new CtrlBD();
    CtrlAlumno controlAlumno = new CtrlAlumno();
    CtrlCurso controlCurso = new CtrlCurso();
    CtrlMatricula controlMatricula = new CtrlMatricula();
    CtrlExamen controlExamen = new CtrlExamen();
    
    ArrayList<Alumno> listaAlumnos = new ArrayList<Alumno>();
    ArrayList<Curso> listaCursos = new ArrayList<Curso>();
    ArrayList<Matricula> listaMatriculas = new ArrayList<>();
    ArrayList<Examen> listaExamenes = new ArrayList<>();
    
    Examen examenSeleccionado = null;
    
    DefaultTableModel tablaAlumnos;
    DefaultTableModel tablaCursos;
    DefaultTableModel tablaMatriculas;
    DefaultTableModel tablaExamenes;
    
    

    public mainFrame() {
        initComponents();
        Inicializar();
        
    }
    
    private void Inicializar(){
        tablaAlumnos = (DefaultTableModel)JTableAlumnos.getModel();
        tablaCursos = (DefaultTableModel)JTableCursos.getModel();
        tablaMatriculas = (DefaultTableModel)JTableMatriculas.getModel();
        tablaExamenes = (DefaultTableModel)JTableExamenes.getModel();
        
        JTableAlumnos.addMouseListener(new MouseAdapter(){
            @Override
            public void mouseClicked(MouseEvent e){
               int fila = JTableAlumnos.getSelectedRow();
               int col = 0;
               String codAlumno = "";
                if (fila > -1) {
                    codAlumno = String.valueOf(JTableAlumnos.getValueAt(fila, col));
                    CargarMatriculas(codAlumno);
                }
            }
        });
        JTableMatriculas.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
               int fila = JTableMatriculas.getSelectedRow();
               String codAlumno = "";
               String codCurso = "";
                if (fila > -1) {
                    codAlumno = String.valueOf(JTableMatriculas.getValueAt(fila, 0));
                    codCurso = String.valueOf(JTableMatriculas.getValueAt(fila, 2));
                    CargarExamenes(codAlumno, codCurso);
                }
            }
        });
        JTableExamenes.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
               int fila = JTableExamenes.getSelectedRow();              
                if (fila > -1) {
                    examenSeleccionado  = listaExamenes.get(fila);
                }
                if (examenSeleccionado != null) {
                    txtFecha.setText(examenSeleccionado.getFechaExamen());
                    txtNota.setText(examenSeleccionado.getNotaExamen().toString());
                }
            }           
        });
        con = controlBD.connectOracle("AD_TEMA02", "AD_TEMA02");
        if (con == null) {
            System.exit(0);
        } else{
            CargarTablas();
        }
    }
    
    private void CargarTablas(){
        listaAlumnos = controlAlumno.ConsultarAlumnos();
        listaCursos = controlCurso.ConsultarCursos();
        for (Alumno alTmp : listaAlumnos) {
            Object[] datos = {alTmp.getCodAlumno(), alTmp.getNombreAlumno()};
            tablaAlumnos.addRow(datos);
        }
        for (Curso cursoTmp : listaCursos) {
            Object[] datos = {cursoTmp.getCodCurso(), cursoTmp.getNombreCurso(), cursoTmp.getNumExamenes()};
            tablaCursos.addRow(datos);            
        }
    }
    
    private void CargarMatriculas(String codAlumno){
        tablaMatriculas.setRowCount(0);
        listaMatriculas = controlMatricula.ConsultarMatriculas(codAlumno);
        for (Matricula matricula : listaMatriculas) {
            Object[] datos = {matricula.getCodAlumno(),JTableAlumnos.getValueAt(JTableAlumnos.getSelectedRow(), 1),matricula.getCodCurso(), matricula.getNomCurso(), matricula.getNotaMedia()};
            tablaMatriculas.addRow(datos);
        }
    }
    
    private void CargarExamenes(String codAlumno, String codCurso){
        listaExamenes.clear();
        tablaExamenes.setRowCount(0);
        listaExamenes = controlExamen.ConsultarExamenes(codAlumno, codCurso);
        for (Examen examen : listaExamenes) {
            Object[] datos = {examen.getNumExamen(), examen.getFechaExamen(), examen.getNotaExamen()};
            tablaExamenes.addRow(datos);
        }
    }
    
    private Matricula PrepararMatricula(){
        Matricula matrTmp = null;
        if (JTableAlumnos.getSelectedRow() != -1 && JTableAlumnos.getSelectedRow() != -1) {
            matrTmp = new Matricula(
                    String.valueOf(JTableAlumnos.getValueAt(JTableAlumnos.getSelectedRow(), 0)),
                    String.valueOf(JTableCursos.getValueAt(JTableCursos.getSelectedRow(), 0)),
                    String.valueOf(JTableCursos.getValueAt(JTableCursos.getSelectedRow(), 1)),
                    (float) 0.0);
        }
        return matrTmp;
    }
    
    private int ComprobarCampos(){
        int res = -1;
        if (txtFecha.getText() != "" && txtFecha.getText() != null && txtNota.getText() != "" && txtNota.getText() != null) {
            double nota;
            Date fecha;
            try{
                nota = Double.valueOf(txtNota.getText());
                fecha = new SimpleDateFormat("dd/MM/yyyy").parse(txtFecha.getText());
                res = 0;
            }catch (Exception ex){
                JOptionPane.showMessageDialog(null, "ERROR: Uno de los campos de Actualizar es incorrecto.");
            }
        }
        return res;
    }
    


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        JTableAlumnos = new javax.swing.JTable();
        jScrollPane2 = new javax.swing.JScrollPane();
        JTableCursos = new javax.swing.JTable();
        btnMatricular = new javax.swing.JButton();
        jScrollPane3 = new javax.swing.JScrollPane();
        JTableMatriculas = new javax.swing.JTable();
        jScrollPane4 = new javax.swing.JScrollPane();
        JTableExamenes = new javax.swing.JTable();
        txtFecha = new javax.swing.JTextField();
        txtNota = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        btnActualizar = new javax.swing.JButton();
        btnJSON = new javax.swing.JButton();
        btnXML = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Práctica Tema 02: Acceso a una BDR desde Java | Ortiz Jibaja, Mario");
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

        jLabel1.setText("Fecha examen:");

        jLabel2.setText("Nota:");

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

        btnXML.setText("Listado Matricula XML");
        btnXML.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnXMLActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jScrollPane3)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 332, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 43, Short.MAX_VALUE)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 491, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(27, 27, 27))
            .addGroup(layout.createSequentialGroup()
                .addGap(327, 327, 327)
                .addComponent(btnMatricular)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 524, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel1, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel2, javax.swing.GroupLayout.Alignment.TRAILING))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(btnActualizar, javax.swing.GroupLayout.DEFAULT_SIZE, 98, Short.MAX_VALUE)
                            .addComponent(txtFecha)
                            .addComponent(txtNota)))
                    .addComponent(btnJSON, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 190, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnXML, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 190, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(98, 98, 98))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(47, 47, 47)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 178, Short.MAX_VALUE)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addGap(31, 31, 31)
                .addComponent(btnMatricular)
                .addGap(32, 32, 32)
                .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 136, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(59, 59, 59)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
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
                        .addGap(18, 18, 18)
                        .addComponent(btnXML)
                        .addGap(43, 43, 43)))
                .addContainerGap(19, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnMatricularActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMatricularActionPerformed
        Matricula matricula = PrepararMatricula();
        int filasAfectadas = -1;
        if (matricula != null) {
            filasAfectadas = controlMatricula.AltaMatricula(matricula);
            if (filasAfectadas == -1) {
                JOptionPane.showMessageDialog(null, "ERROR: No se ha podido matricular al alumno " + JTableAlumnos.getValueAt(JTableAlumnos.getSelectedRow(), 1) + " en " + JTableCursos.getValueAt(JTableCursos.getSelectedRow(), 1));
            } else{
                JOptionPane.showMessageDialog(null, "Alumno/a " + JTableAlumnos.getValueAt(JTableAlumnos.getSelectedRow(), 1) + " matriculado/a con éxito en " + JTableCursos.getValueAt(JTableCursos.getSelectedRow(), 1));
                CargarMatriculas(matricula.getCodAlumno());
            }
        }
    }//GEN-LAST:event_btnMatricularActionPerformed

    private void btnActualizarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnActualizarActionPerformed
        int filasAfectadas = -1;
        if (examenSeleccionado != null && ComprobarCampos() != -1) {
            examenSeleccionado.setFechaExamen(txtFecha.getText());
            examenSeleccionado.setNotaExamen(Double.valueOf(txtNota.getText()));
            filasAfectadas = controlExamen.ModificarExamen(examenSeleccionado);
            if (filasAfectadas != -1) {
                CargarExamenes(examenSeleccionado.getCodAlumno(), examenSeleccionado.getCodMatricula());
                CargarMatriculas(examenSeleccionado.getCodAlumno());
            }
        }
        
    }//GEN-LAST:event_btnActualizarActionPerformed

    private void btnXMLActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnXMLActionPerformed
        controlMatricula.ListarXML(listaAlumnos);
    }//GEN-LAST:event_btnXMLActionPerformed

    private void btnJSONActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnJSONActionPerformed
        if (listaExamenes.size() != 0) {
            controlExamen.ListarJSON(listaExamenes);
        }
        
    }//GEN-LAST:event_btnJSONActionPerformed

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
    private javax.swing.JTable JTableAlumnos;
    private javax.swing.JTable JTableCursos;
    private javax.swing.JTable JTableExamenes;
    private javax.swing.JTable JTableMatriculas;
    private javax.swing.JButton btnActualizar;
    private javax.swing.JButton btnJSON;
    private javax.swing.JButton btnMatricular;
    private javax.swing.JButton btnXML;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JTextField txtFecha;
    private javax.swing.JTextField txtNota;
    // End of variables declaration//GEN-END:variables
}

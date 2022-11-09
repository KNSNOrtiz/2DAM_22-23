package bd_metadata;
import java.sql.*;
import javax.swing.JOptionPane;
public class BD_Metadata {
    private static Connection con;
    private static DatabaseMetaData dbmd;
    private static ResultSet rs;
    
    public static void main(String[] args) {
        try{
            con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","SYSTEM","MANAGER");
            dbmd = con.getMetaData();
            System.out.println("ProductName: " + dbmd.getDatabaseProductName());
            System.out.println("ProductVersion: " + dbmd.getDatabaseProductVersion());
            System.out.println("DriverName: " + dbmd.getDriverName());
            System.out.println("Usuario: " + dbmd.getUserName());
            System.out.println("---------------------------------------------------------------------------------");
            String[] tipostablas = {"TABLE"};
  
            rs = dbmd.getTables(null, "SYSTEM", "AL%", tipostablas);
            while (rs.next()) {                
                System.out.println("\tCatálogo: " + rs.getString(1));
                System.out.println("\tEsquema: " + rs.getString(2));
                System.out.println("\tNombre tabla: " + rs.getString(3));
                System.out.println("\tTipo de tabla: " + rs.getString(4));  
                System.out.println("\n");
            }
             System.out.println("---------------------------------------------------------------------------------");
            rs = dbmd.getColumns(null, "SYSTEM", "AL%", "%");
            while (rs.next()) {                
                System.out.println("\tTabla: " + rs.getString("TABLE_NAME"));
                System.out.println("\tColumna: " + rs.getString("COLUMN_NAME"));
                System.out.println("\tVersión Java: " + rs.getString("DATA_TYPE"));
                System.out.println("\tTipo de dato: " + rs.getString("TYPE_NAME")); 
                System.out.println("\n");
            }
            
            rs = dbmd.getPrimaryKeys(null, "SYSTEM", "EXAMENES");
            while (rs.next()) {                
                System.out.println("\tTabla: " + rs.getString("TABLE_NAME"));
                System.out.println("\tColumna: " + rs.getString("COLUMN_NAME"));
                System.out.println("\tVersión Java: " + rs.getString("KEY_SEQ"));
                System.out.println("\tTipo de dato: " + rs.getString("PK_NAME")); 
                System.out.println("\n");
            }        
            
            rs = dbmd.getExportedKeys(null, "SYSTEM", "EXAMENES");
            while (rs.next()) {                
                System.out.println("\tTabla PK: " + rs.getString("PKTABLE_NAME"));
                System.out.println("\tColumna PK: " + rs.getString("PKCOLUMN_NAME"));
                System.out.println("\tTabla FK: " + rs.getString("FKTABLE_NAME"));
                System.out.println("\tColumna FK: " + rs.getString("FK_COLUMNAME")); 
                System.out.println("\n");
            }               
        }catch(SQLException ex){
            JOptionPane.showMessageDialog(null, "ERROR AL CONECTAR A LA BD");
        }
    }
    
}

<html>
  <head>
    <title>Práctica 03 - Ortiz Jibaja, Mario</title>
  </head>
  <body>
      <table border="1px">
        {
          for $cli in doc("ColeccionVentas/clientes.xml")/clientes/clien
          return
          <tr>     
              <td>{$cli/nombre}</td>        
              <td>
              {
                let $numFacCli := count(doc("ColeccionVentas/facturas.xml")/facturas/factura[numcliente = $cli/@numero])
                return
                if($numFacCli > 2)
                then(<td style="background-color:red">$numFacCli</td>)
                else(<td>$numFacCli</td>) 
              }
              </td>      
          </tr> 
         }
      </table>
  </body>
</html>

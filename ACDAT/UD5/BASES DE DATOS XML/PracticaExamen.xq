<html>
  <head>
    <title>Exámen - Ejercicio 09 - Mario Ortiz Jibaja</title>
  </head>
  <body>
    <table border="1">
      <tr>
        <td>
        {
          let $factura := facturas/factura[@numero="11"]
          return
          <p>{concat("Numero: ", $factura/@numero)}</p> |
          <p>{concat("Fecha: ", $factura/fecha)}</p> |
          <p>{concat("Cliente: ", $factura/numcliente)}</p>
        }
          </td>
          <td colspan="5">
          {
            let $cliente := clientes/clien[@numero="20"]
            return
          <p>{concat("Nombre: ", $cliente/nombre)}</p> |
          <p>{concat("Población: ",  $cliente/poblacion)}</p> |
          <p>{concat("Teléfono: ", $cliente/tlf)}</p> |
          <p>{concat("Dirección: ", $cliente/direccion)}</p>
          }
          </td>
      </tr>
      <tr>
        <td>Código</td>
        <td>Nombre</td>
        <td>Precio</td>
        <td>Unidades</td>
        <td>%Descuento</td>
        <td>Total</td>
      </tr>
        {
          for $productos in /productos/product, $detalles in /detallefacturas/factura[@numero="11"]
          where $productos/codigo = $detalles/producto/codigo
          return
            <tr>
              <td>{$productos/codigo}</td>
              <td>{$productos/nombre}</td>
              <td>{data($productos/@pvp)}</td>
              <td>
              {
                let $detalleProd := $detalles/producto[codigo=$productos/codigo]
                return
                $detalleProd/unidades
              }
              </td>     
                                                            
              
              {
                let $detalleProd := $detalles/producto[codigo=$productos/codigo]
                return
                  if(number(data($detalleProd/@descuento)) > 0.15)
                  then(<td style="background-color:red">{number(data($detalleProd/@descuento)) * 100}</td>)
                  else(<td>{number(data($detalleProd/@descuento)) * 100}</td>)
                }
               <td>
               {
                 let $detalleProd := $detalles/producto[codigo=$productos/codigo]
                 return
                   (number($detalleProd/unidades) * number(data($productos/@pvp))) - (number($detalleProd/unidades) * number(data($productos/@pvp))) *  number(data($detalleProd/@descuento))
               }
               </td>
            </tr>
        }
    </table>
  </body>
</html>

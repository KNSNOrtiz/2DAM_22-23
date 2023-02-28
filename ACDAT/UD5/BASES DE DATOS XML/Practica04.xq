"Mostrar los títulos de los libros con la etiqueta titulo.",
for $book in /bookstore/book
return 
 $book/title,
 
 "Mostrar los libros cuyo precio sea menor o igual a 30. Primero incluyendo la condición en la cláusula where y luego en la ruta del XPath.",
 for $book in /bookstore/book[data(price) <= 30]
return 
 $book,
  for $book in /bookstore/book
  where $book/price <= 30
return 
 $book,
 
 "Mostrar sólo el título de los libros cuyo precio sea menor o igual a 30.",
 
for $book in /bookstore/book
  where $book/price <= 30
return 
 $book/title,
 "Mostrar sólo el título sin atributos de los libros cuyo precio sea menor o igual a 30.",
 for $book in /bookstore/book
 where $book/price <= 30
 return 
   $book/title/text(),
  " Mostrar el título y el autor de los libros del año 2005, y etiquetar cada uno de ellos con lib2005.",
 for $book in /bookstore/book
 where data($book/year) = "2005"
 return 
 <lib2005>
   {$book/title}
   {$book/author}
 </lib2005>,
 "Mostrar los años de publicación, primero con for y luego con let para comprobar la diferencia entre ellos. Etiquetar la salida con publicación",
 for $book in /bookstore/book
 return 
   <publicacion>{$book/year}</publicacion>,
    let $book := /bookstore/book
 return 
   <publicacion>{$book/year}</publicacion>,
"-------------------------------------------------",
 let $book := /bookstore/book/title
 return 
   <resultado>
   {$book}
   <numLibros> {let $numlibros := count($book)
    return $numlibros}</numLibros>
   </resultado>,
"-------------------------------------------------",
    let $maxBook := max(/bookstore/book/price)
    let $minBook := min(/bookstore/book/price)
 return 
 <resultado>
   <max>{$maxBook}</max>
   <min>{$minBook}</min>
   </resultado>,
"-------------------MAXIMO EN ROJO MINIMO EN VERDE------------------------------",
<html>
<head>
  <title>
    Titulos
  </title>
</head>
<body>
  <table border="1">
    <tr><th>Títulos de los libros</th></tr>
    {
      for $libros in /bookstore/book
      let $precio_min := min(/bookstore/book/price)
      let $precio_max := max(/bookstore/book/price)
      return
          <tr>
          <td>
          {
            if(number($libros/price) = $precio_min)
            then(@style="color:green")
            else()
          }
           {$libros/title/text()}                
          </td>
          </tr>
    }
  </table>  
</body>
</html>
      

   
  
"Práctica 05 - Mario Ortiz Jibaja",
"Mostrar cada uno de los nombres de los bailes con la etiqueta 'losbailes'
",
let $nombreBailes := /bailes/baile/nombre
return
  <losbailes>{$nombreBailes}</losbailes>,
 "-----------------------------------------------------------",
 "Mostrar los nombres de los bailes seguidos con el número de plazas entre paréntesis, ambos dentro de la misma etiqueta 'losbailes'",
 for $baile in /bailes/baile
 return
   <losbailes>{concat($baile/nombre/text(), "(", $baile/plazas/text(), ")")}</losbailes>,
 "-----------------------------------------------------------",
 "Mostrar los nombres de los bailes cuyo precio sea mayor de 30.",
  for $baile in /bailes/baile
  where number($baile/precio) > 30
 return
   $baile/nombre,
 "-----------------------------------------------------------",
 "Mostrar los nombres de los bailes cuyo precio sea mayor de 30 y la moneda 'euro'",
 for $baile in /bailes/baile
  where number($baile/precio) > 30 and $baile/precio/@moneda = "euro"
 return
   $baile/nombre,
 "-----------------------------------------------------------",
 "Mostrar los nombres y la fecha de comienzo de los bailes que comiencen el mes de enero (utiliza para buscarlo la cadena de texto '1').",
  for $baile in /bailes/baile
  where contains($baile/comienzo, "/1/")
 return
   <baile>{$baile/nombre | $baile/comienzo}</baile>,
 "-----------------------------------------------------------",
 " Mostrar los nombres de los profesores y la sala en la que dan clase, ordénalos por sala.",
 for $baile in /bailes/baile
 order by $baile/sala
 return
 <ProfesorSala>{$baile/profesor | $baile/sala}</ProfesorSala>,
 "-----------------------------------------------------------",
 for $baile in /bailes/baile
 return
 <BaileComienzoDias>{concat($baile/profesor/text(), " - ", $baile/comienzo ," - " , fn:substring(xs:string(xs:date($baile/comienzo/text())-xs:date($baile/fin/text())),3))}</BaileComienzoDias>
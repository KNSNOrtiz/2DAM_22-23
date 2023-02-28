CREATE OR REPLACE TYPE A_TRANSPORTES AS VARRAY(3) OF VARCHAR2(20);

CREATE OR REPLACE TYPE T_DESTINO AS OBJECT(
  destino VARCHAR2(30),
  transportes A_TRANSPORTES,
  MEMBER FUNCTION f_listaTransportes RETURN VARCHAR2
);

CREATE OR REPLACE TYPE BODY T_DESTINO AS 
  MEMBER FUNCTION f_listaTransportes RETURN VARCHAR2 IS
    xTransportes VARCHAR2(70);
  BEGIN
    xTransportes := '';
    FOR I IN 1..transportes.count LOOP
      xTransportes := xTransportes || ' - ' || transportes(i);
    END LOOP;
    RETURN xTransportes;
  END;
END;

-- Crear tabla
CREATE TABLE DESTINOS OF T_DESTINO;
ALTER TABLE DESTINOS ADD CONSTRAINT PK_DESTINOS PRIMARY KEY(destino);
COMMIT;
--Insertar datos
INSERT INTO Destinos VALUES (T_DESTINO('Peninsula',A_TRANSPORTES('Furgoneta','Tren','Avion')));
INSERT INTO Destinos VALUES (T_DESTINO('Canarias',A_TRANSPORTES('Barco','Avion')));
INSERT INTO Destinos VALUES (T_DESTINO('Europa',A_TRANSPORTES('Tren','Avion')));
INSERT INTO Destinos VALUES (T_DESTINO('America',A_TRANSPORTES('Avion')));
COMMIT;

-- Comprobar funciones
SELECT D.destino, D.f_listaTransportes() FROM DESTINOS D;

-------------------------------------------------------------------


CREATE OR REPLACE TYPE T_DETALLE_TARIFA AS OBJECT(
  tarifa NUMBER,
  pesoMin NUMBER,
  pesoMax NUMBER
);

CREATE OR REPLACE TYPE TA_DETALLES AS TABLE OF T_DETALLE_TARIFA;

CREATE OR REPLACE TYPE T_TARIFA AS OBJECT(
  destino REF T_DESTINO,
  tipo VARCHAR2(20),
  detalles TA_DETALLES,
  MEMBER FUNCTION f_calculaTarifa(xPeso NUMBER) RETURN NUMBER,
  MEMBER FUNCTION f_nombreDestino RETURN VARCHAR2,
  MEMBER FUNCTION toString RETURN VARCHAR2
);

CREATE OR REPLACE TYPE BODY T_TARIFA AS
  MEMBER FUNCTION f_calculaTarifa(xPeso NUMBER) RETURN NUMBER IS
    xTarifa NUMBER := 0;
  BEGIN 
    FOR I IN 1..detalles.COUNT LOOP
      IF xPeso BETWEEN detalles(i).pesoMin AND detalles(i).pesoMax THEN
        RETURN detalles(i).tarifa;
      END IF;
    END LOOP;
    RETURN xTarifa;
  END;
  MEMBER FUNCTION f_nombreDestino RETURN VARCHAR2 IS
    xDestino T_DESTINO;
  BEGIN
    SELECT DEREF(destino) INTO xDestino FROM DUAL;
    RETURN xDestino.destino;
  END;
  MEMBER FUNCTION toString RETURN VARCHAR2 IS
    xDestino T_DESTINO;
    xtoString VARCHAR2(300) := '';
  BEGIN
    SELECT DEREF(destino) INTO xDestino FROM DUAL;
    xtoString := xDestino.destino || ' - ' || tipo || ' - ' || xDestino.f_listaTransportes();
    RETURN xtoString;
  END;
END;


-- Crear tabla
CREATE TABLE TARIFAS OF T_TARIFA
NESTED TABLE detalles STORE AS tmpDetallesTarifa;
--Insertar datos
INSERT INTO Tarifas VALUES ((SELECT REF(D) FROM DESTINOS D WHERE destino = 'Peninsula'),
  'SOBRE',
    TA_DETALLES(
      T_DETALLE_TARIFA(2.00, 0.01, 0.10),
      T_DETALLE_TARIFA(2.55, 0.11, 0.50),
      T_DETALLE_TARIFA(3.00, 0.51, 1)
      )
); 
INSERT INTO Tarifas VALUES ((SELECT REF(D) FROM DESTINOS D WHERE destino = 'Peninsula'),
  'CAJA',
    TA_DETALLES(
      T_DETALLE_TARIFA(3.15, 0.01, 1),
      T_DETALLE_TARIFA(5.50, 1.01, 3),
      T_DETALLE_TARIFA(7.00, 3.01, 10)
      )
); 
INSERT INTO Tarifas VALUES ((SELECT REF(D) FROM DESTINOS D WHERE destino = 'Europa'),
  'SOBRE',
    TA_DETALLES(
      T_DETALLE_TARIFA(5.00, 0.01, 0.10),
      T_DETALLE_TARIFA(6.30, 0.11, 0.50)
      )
); 
commit;

-- Mostrar registros
SELECT * FROM TARIFAS A;
-- Comprobar funciones
SELECT A.f_nombreDestino(), A.tipo FROM TARIFAS A;
-- Aplanar para ver datos tabla anidada
SELECT A.f_nombreDestino(), A.tipo, D.* FROM TARIFAS A, TABLE(DETALLES) D;
-- Comprobar funciones
SELECT A.f_nombreDestino(), A.tipo, A.f_calculaTarifa(1) FROM TARIFAS A;

--------------------------------------------------------


CREATE OR REPLACE TYPE T_ENVIO AS OBJECT(
  idEnvio NUMBER,
  unidades NUMBER,
  pesoUnd NUMBER,
  tarifa REF T_TARIFA,
  destinatario VARCHAR2(30),
  MEMBER FUNCTION f_precioEnvio RETURN NUMBER,
  MEMBER FUNCTION toString RETURN VARCHAR2
);

CREATE OR REPLACE TYPE BODY T_ENVIO AS 
  MEMBER FUNCTION f_precioEnvio RETURN NUMBER IS
    xTarifa T_TARIFA;
  BEGIN
    SELECT DEREF(tarifa) INTO xTarifa FROM DUAL;
    RETURN unidades * xTarifa.f_calculaTarifa(pesoUnd);
  END;
  MEMBER FUNCTION toString RETURN VARCHAR2 IS
    xInfo VARCHAR2(100) := '';
  BEGIN
    xInfo := 'uds: ' || unidades || ' tarifa : ' || (self.f_precioEnvio()/unidades) 
    || ' importe: ' || self.f_precioEnvio() || ' destinatario: ' || destinatario;
    RETURN xInfo;
  END;
END;
CREATE OR REPLACE TYPE TA_LISTA_ENVIOS AS TABLE OF T_ENVIO;

CREATE OR REPLACE TYPE T_DOCUMENTO AS OBJECT(
  idDocumento NUMBER,
  fecha DATE,
  envios TA_LISTA_ENVIOS,
  MEMBER FUNCTION f_totalDocumento RETURN NUMBER,
  MEMBER PROCEDURE sp_infoDocumento,
  MEMBER FUNCTION f_numEnviosxdoc RETURN NUMBER
);
CREATE OR REPLACE TYPE BODY T_DOCUMENTO AS
  MEMBER FUNCTION f_totalDocumento RETURN NUMBER IS
    xTotalDoc NUMBER := 0;
  BEGIN
    FOR I IN 1..envios.count LOOP
      xTotalDoc := xTotalDoc + envios(i).f_precioEnvio();
    END LOOP;
    RETURN xTotalDoc;
  END;  
  MEMBER PROCEDURE sp_infoDocumento IS
    xInfo VARCHAR2(2048) := '';
    xTarifa T_TARIFA;
    xDestino T_DESTINO;
  BEGIN
    FOR I IN 1..ENVIOS.count LOOP
      xInfo := 'fecha: ' || fecha || ' idEnvio: ' || envios(i).idEnvio;
      SELECT DEREF(envios(i).tarifa) INTO xTarifa FROM DUAL;
      xInfo := xInfo || ' - ' || xTarifa.toString();
      xInfo := xInfo || ' ' || envios(i).toString();
      DBMS_OUTPUT.PUT_LINE(xInfo);
    END LOOP;
  END;
  MEMBER FUNCTION f_numEnviosxdoc RETURN NUMBER IS
  BEGIN
    RETURN envios.count;
  END; 
END;

CREATE OR REPLACE TYPE TA_LISTA_DOCUMENTOS AS TABLE OF T_DOCUMENTO;

CREATE OR REPLACE TYPE T_CLIENTE AS OBJECT(
  nombre VARCHAR2(40),
  NIF VARCHAR2(10),
  documentos TA_LISTA_DOCUMENTOS,
  MEMBER FUNCTION fNumeroEnvios RETURN NUMBER,
  MEMBER FUNCTION fNumeroEnviosxFecha(xFechaInicio DATE, xFechaFin DATE) RETURN NUMBER,
  MEMBER PROCEDURE fMostrarDatosxFecha(xFechaInicio DATE, xFechaFin DATE)
);
CREATE OR REPLACE TYPE BODY T_CLIENTE AS 
  MEMBER FUNCTION fNumeroEnvios RETURN NUMBER IS
    xTotalEnviosCliente NUMBER := 0;
  BEGIN
    FOR I IN 1..documentos.count LOOP
      xTotalEnviosCliente := xTotalEnviosCliente + documentos(i).f_numEnviosxdoc();
    END LOOP;
    RETURN xTotalEnviosCliente;
  END;
  MEMBER FUNCTION fNumeroEnviosxFecha(xFechaInicio DATE, xFechaFin DATE) RETURN NUMBER IS
   xTotalEnviosCliente NUMBER := 0;
  BEGIN
    FOR I IN 1..documentos.count LOOP
      IF documentos(i).fecha BETWEEN xFechaInicio AND xFechaFin THEN
        xTotalEnviosCliente := xTotalEnviosCliente + documentos(i).f_numEnviosxdoc();
      END IF;  
    END LOOP;
    RETURN xTotalEnviosCliente;
  END;  
  MEMBER PROCEDURE fMostrarDatosxFecha(xFechaInicio DATE, xFechaFin DATE) IS
    xDocumento T_DOCUMENTO;
  BEGIN
    FOR I IN 1..documentos.count LOOP
      xDocumento := documentos(i);
      IF  xDocumento.fecha BETWEEN xFechaInicio AND xFechaFin THEN
        xDocumento.sp_infoDocumento;
      END IF;
    END LOOP;
  END;
END;

CREATE TABLE CLIENTES OF T_CLIENTE
NESTED TABLE documentos STORE AS tmpDocuementos
(NESTED TABLE envios STORE AS tmpEnvios);
ALTER TABLE CLIENTES ADD CONSTRAINT PK_CLIENTES PRIMARY KEY(NIF);


INSERT INTO CLIENTES VALUES('Juan', '123456789A', TA_LISTA_DOCUMENTOS());

INSERT INTO TABLE(SELECT documentos FROM CLIENTES WHERE NIF = '123456789A') 
VALUES(T_DOCUMENTO(1, '12/02/2015', TA_LISTA_ENVIOS()));

INSERT INTO TABLE(
  SELECT envios FROM TABLE(
    SELECT documentos FROM CLIENTES WHERE NIF = '123456789A'
  )WHERE idDocumento = 1
)VALUES(101, 1, 5, 
                  (SELECT REF(T) FROM TARIFAS T WHERE DESTINO = (SELECT REF(D) FROM DESTINOS D WHERE DESTINO = 'Peninsula')
                  AND TIPO = 'CAJA')
                  , 'Pablo, Illora, Granada, 18260'
);

INSERT INTO TABLE(
  SELECT envios FROM TABLE(
    SELECT documentos FROM CLIENTES WHERE NIF = '123456789A'
  )WHERE idDocumento = 1
)VALUES(102, 5, 0.2, 
                  (SELECT REF(T) FROM TARIFAS T WHERE DESTINO = (SELECT REF(D) FROM DESTINOS D WHERE DESTINO = 'Europa')
                  AND TIPO = 'SOBRE')
                  , 'David, Illora, Granada, 18260'
);

SELECT * FROM CLIENTES E;
SELECT E.nombre, E.NIF, D.* FROM CLIENTES E, TABLE(documentos) D;
SELECT E.nombre, E.NIF, D.idDocumento, D.fecha, S.* FROM CLIENTES E, TABLE(documentos) D, TABLE(envios) S;

SELECT E.nombre, E.NIF, D.idDocumento, D.fecha, S.*, S.toString()
FROM CLIENTES E, TABLE(documentos) D, TABLE(envios) S;

SELECT E.nombre, E.NIF, E.fNumeroEnvios() FROM CLIENTES E;

SELECT E.nombre, E.NIF, E.fNumeroEnviosxFecha('10/05/2016', '10/05/2017') FROM CLIENTES E;


CREATE OR REPLACE PROCEDURE sp_listaClientes (xFechaIni DATE, xFechaFin DATE) IS
  CURSOR c_clientes IS SELECT VALUE(C) FROM CLIENTES C;
  xCliente T_CLIENTE;
BEGIN
  OPEN c_clientes;
  LOOP
    FETCH c_clientes INTO xCliente;
    EXIT WHEN c_clientes%NOTFOUND;
    DBMS_OUTPUT.PUT_LINE(xCliente.nombre || ' - ' || xCliente.NIF || ' - ' || xCliente.fNumeroEnviosxFecha(xFechaIni, xFechaFin));
    xCliente.fMostrarDatosxFecha(xFechaIni, xFechaFin);
  END LOOP;
  CLOSE c_clientes;
END;

SET SERVEROUTPUT ON;
DECLARE
BEGIN
  sp_listaClientes('12/02/2014', '12/02/2016');
END;

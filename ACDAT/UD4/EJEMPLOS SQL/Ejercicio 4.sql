 CREATE OR REPLACE TYPE T_FABRICANTE AS OBJECT(
    CODFAB VARCHAR2(10),
    NOMBRE VARCHAR2(50),
    PAIS VARCHAR2(50)
 );
 
 CREATE OR REPLACE TYPE VAR_COLORES AS VARRAY(10) OF VARCHAR2(50);
 CREATE OR REPLACE TYPE T_COMPONENTE AS OBJECT(
    CODCOM VARCHAR2(10),
    DESCRIPCION VARCHAR2(50),
    FABRICANTE REF T_FABRICANTE,
    PRECIOFAB NUMBER(10,2),
    PVP NUMBER(10,2),
    COLORES VAR_COLORES
 ); 
 
 CREATE OR REPLACE TYPE T_COMP_ORDENADOR AS OBJECT(
    COMPONENTE REF T_COMPONENTE,
    UNIDADES NUMBER(6),
    MEMBER FUNCTION fBeneficio RETURN NUMBER,
    MEMBER FUNCTION fFabricante RETURN VARCHAR2,
    MEMBER FUNCTION fCodigo RETURN VARCHAR2,
    MEMBER FUNCTION fDescripcion RETURN VARCHAR2
 );
 CREATE OR REPLACE TYPE BODY T_COMP_ORDENADOR AS
    MEMBER FUNCTION fBeneficio RETURN NUMBER IS   
        xComponente T_COMPONENTE;
        xBeneficio NUMBER(10,2);
        BEGIN
            SELECT DEREF(SELF.COMPONENTE) INTO xComponente FROM DUAL;
            xBeneficio := (xComponente.pvp - xComponente.preciofab)* self.unidades;
            RETURN xBeneficio;
        END;
    MEMBER FUNCTION fFabricante RETURN VARCHAR2 IS
        xComponente T_COMPONENTE;
        xFabricante T_FABRICANTE;
        BEGIN
            SELECT DEREF(self.componente) INTO xComponente FROM DUAL;
            SELECT DEREF(xComponente.fabricante) INTO xFabricante FROM DUAL;
            RETURN xFabricante.nombre;
        END;
    MEMBER FUNCTION fCodigo RETURN VARCHAR2 IS
        xComponente T_COMPONENTE;
        BEGIN
            SELECT DEREF(self.componente) into xComponente FROM DUAL;
            RETURN xComponente.codcom;
        END;
    MEMBER FUNCTION fDescripcion RETURN VARCHAR2 IS
        xComponente T_COMPONENTE;
        BEGIN
            SELECT DEREF(self.componente) into xComponente FROM DUAL;
            RETURN xComponente.descripcion;
        END;    
 END;
    
DROP TYPE NESTED_COMPONENTES;
DROP TYPE T_ORDENADOR;
 CREATE OR REPLACE TYPE NESTED_COMPONENTES AS TABLE OF T_COMP_ORDENADOR;
 CREATE OR REPLACE TYPE T_ORDENADOR AS OBJECT(
    CODORD VARCHAR2(10),
    DESCRIPCION VARCHAR2(100),
    COMPONENTES NESTED_COMPONENTES,
    MEMBER FUNCTION fBeneficio RETURN NUMBER,
    MEMBER PROCEDURE spInfoOrdenador,
    MEMBER PROCEDURE spInfoComponentes
 );
 
 CREATE OR REPLACE TYPE BODY T_ORDENADOR AS 
    MEMBER FUNCTION fBeneficio RETURN NUMBER IS  
        xBeneficioTotal NUMBER(10,2):= 0;  
        BEGIN
            FOR i IN 1..self.COMPONENTES.COUNT LOOP
                xBeneficioTotal := xBeneficioTotal + self.componentes(i).fBeneficio();
            END LOOP;
            RETURN xBeneficioTotal;
        END;
    MEMBER PROCEDURE spInfoOrdenador IS
        BEGIN
            dbms_output.put_line('CÓDIGO: '  || self.codord || chr(13) ||
                                'DESCRIPCIÓN: ' || self.descripcion);
        END;
    MEMBER PROCEDURE spInfoComponentes IS      
        BEGIN
            FOR i IN 1..SELF.COMPONENTES.COUNT LOOP
                dbms_output.put_line('COMPONENTE ' || i || chr(13) ||
                'Código: '  || self.componentes(i).fCodigo() || chr(13) ||
                'Descripción: ' || self.componentes(i).fDescripcion() || chr(13) ||
                'Unidades: ' || self.componentes(i).unidades || chr(13) ||
                'Fabricante: ' || self.componentes(i).fFabricante());
            END LOOP;
        END;
 END;
 
 ----------------------------------------PRUEBAS-------------------------------------------------------------------
 
CREATE TABLE FABRICANTES OF T_FABRICANTE;
ALTER TABLE FABRICANTES ADD CONSTRAINT pk_fabricante PRIMARY KEY(codfab);

CREATE TABLE COMPONENTES OF T_COMPONENTE;
ALTER TABLE COMPONENTES ADD CONSTRAINT pk_componente PRIMARY KEY(codcom);

CREATE TABLE ORDENADORES OF T_ORDENADOR
NESTED TABLE COMPONENTES STORE AS tmpComponentes;
ALTER TABLE ORDENADORES ADD CONSTRAINT pk_ordenador PRIMARY KEY(codord);

INSERT INTO FABRICANTES VALUES ('F01', 'Asus', 'USA');
INSERT INTO FABRICANTES VALUES ('F02', 'HP', 'Alemania');

INSERT INTO COMPONENTES VALUES('C01', 'Tarjeta gráfica', (SELECT REF(F) FROM FABRICANTES F WHERE F.CODFAB = 'F01'), 200, 300, VAR_COLORES('Negro'));
INSERT INTO COMPONENTES VALUES('C02', 'Memoria RAM 8GB', (SELECT REF(F) FROM FABRICANTES F WHERE F.CODFAB = 'F01'), 40, 60, VAR_COLORES('Blanco'));
INSERT INTO COMPONENTES VALUES('C03', 'Teclado', (SELECT REF(F) FROM FABRICANTES F WHERE F.CODFAB = 'F02'), 15, 20, VAR_COLORES('Verde', 'Amarillo'));
INSERT INTO COMPONENTES VALUES('C04', 'Ratón', (SELECT REF(F) FROM FABRICANTES F WHERE F.CODFAB = 'F02'), 5, 10, VAR_COLORES('Rosa', 'Fucsia'));

INSERT INTO ORDENADORES VALUES('O01','Sobremesa',NESTED_COMPONENTES());
INSERT INTO TABLE(SELECT O.COMPONENTES FROM ORDENADORES O WHERE O.CODORD ='O01') VALUES ((SELECT REF(C) FROM COMPONENTES C WHERE C.CODCOM = 'C01'), 2); 
INSERT INTO TABLE(SELECT O.COMPONENTES FROM ORDENADORES O WHERE O.CODORD ='O01') VALUES ((SELECT REF(C) FROM COMPONENTES C WHERE C.CODCOM = 'C03'), 4); 

INSERT INTO ORDENADORES VALUES('O02','Portátil',NESTED_COMPONENTES());
INSERT INTO TABLE(SELECT O.COMPONENTES FROM ORDENADORES O WHERE O.CODORD ='O02') VALUES ((SELECT REF(C) FROM COMPONENTES C WHERE C.CODCOM = 'C02'), 3); 
INSERT INTO TABLE(SELECT O.COMPONENTES FROM ORDENADORES O WHERE O.CODORD ='O02') VALUES ((SELECT REF(C) FROM COMPONENTES C WHERE C.CODCOM = 'C04'), 3); 

UPDATE TABLE(SELECT O.COMPONENTES FROM ORDENADORES O WHERE O.CODORD = 'O02') SET UNIDADES = 2 WHERE COMPONENTE = (SELECT REF(C) FROM COMPONENTES C WHERE C.CODCOM = 'C02');


SELECT * FROM FABRICANTES;
SELECT * FROM COMPONENTES;
SELECT * FROM ORDENADORES;

SELECT O.fBeneficio() from ORDENADORES O;
CREATE OR REPLACE PROCEDURE spListarComps(xCodFab VARCHAR2) IS
    xFabricante T_FABRICANTE;
    xComponente T_COMPONENTE;
    CURSOR C1 IS SELECT VALUE(C) FROM COMPONENTES C;
    BEGIN
        OPEN C1;
        LOOP
            FETCH C1 INTO xComponente;
            EXIT WHEN C1%NOTFOUND;
            SELECT DEREF(xComponente.fabricante) into xFabricante from DUAL;
            IF (xfabricante.codfab = xCodFab) THEN
                dbms_output.put_line('Código: ' || xComponente.codcom || chr(13) ||
                'Descripción: ' || xComponente.descripcion || chr(13) ||
                'Precio de fábrica: ' || xComponente.preciofab || chr(13) ||
                'PVP: ' || xComponente.pvp || chr(13) ||
                'COLORES'|| chr(13)
                ); 
                FOR i in 1..xComponente.colores.count LOOP
                    dbms_output.put_line('Color ' || i || ':' || xComponente.colores(i) || chr(13));
                END LOOP;
            END IF;
        END LOOP;        
    END;
    
SET SERVEROUTPUT ON;
DECLARE
    xOrdenador T_ORDENADOR;
BEGIN
    SELECT VALUE(O) INTO xOrdenador FROM ORDENADORES O where O.CODORD = 'O01';
    xOrdenador.spInfoOrdenador();
    --spListarComps('F02');
END;
 
 
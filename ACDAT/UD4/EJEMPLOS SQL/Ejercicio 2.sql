CREATE OR REPLACE TYPE V_TELEFONOS AS VARRAY(3) OF VARCHAR2(20);

CREATE OR REPLACE TYPE T_DIRECCION AS OBJECT(
    DOMICILIO VARCHAR2(50),
    POBLACION VARCHAR2(50),
    CP NUMBER(5),
    PROVINCIA VARCHAR2(50)
);

CREATE OR REPLACE TYPE T_CLIENTE AS OBJECT(
    IDCLIENTE NUMBER,
    NOMBRE VARCHAR2(50),
    NIF VARCHAR2(9),
    DIRECCION T_DIRECCION,
    TELEFONOS V_TELEFONOS
);

CREATE OR REPLACE TYPE T_PRODUCTO AS OBJECT(
    IDPRODUCTO NUMBER,
    DESCRIPCION VARCHAR2(50),
    PVP NUMBER,
    STOCKACTUAL NUMBER
);

CREATE OR REPLACE TYPE NESTED_PRODUCTOS AS TABLE OF T_PRODUCTO;

CREATE OR REPLACE TYPE T_LINEA AS OBJECT(
    NUMEROLINEA NUMBER,
    CANTIDAD NUMBER,
    PRODUCTO REF T_PRODUCTO
    --  PARA ESTABLECER UN ÁMBITO EXCLUSIVO HACIA UN TIPO DE OBJETO, NECESITAMOS UNA TABLA DE ESE OBJETO Y APUNTAR A ELLA MEDIANTE SCOPE DE LA SIGUIENTE FORMA:
    --  SCOPE FOR (PRODUCTO) IS TABLA_PRODUCTOS
);

DROP TYPE NESTED_LINEAS;


CREATE OR REPLACE TYPE NESTED_LINEAS AS TABLE OF T_LINEA;

DROP TYPE T_VENTA;

CREATE OR REPLACE TYPE T_VENTA AS OBJECT(
    IDVENTA NUMBER,
    IDCLIENTE REF T_CLIENTE,
    LINEAS NESTED_LINEAS,
    FECHAVENTA DATE,
  
    MEMBER FUNCTION TOTAL_VENTA RETURN NUMBER 
);

CREATE OR REPLACE TYPE BODY T_VENTA AS
    MEMBER FUNCTION TOTAL_VENTA RETURN NUMBER IS
        xTotal NUMBER;
        xLinea T_LINEA;
        xProducto t_producto;
        numRegistros NUMBER;
    BEGIN 
        xTotal := 0;
        SELECT COUNT(*)INTO numRegistros FROM TABLE(SELF.LINEAS);
        FOR i in 1..numRegistros LOOP
            SELECT t_linea(l.numerolinea, l.cantidad, l.producto) into xLinea FROM TABLE(SELF.LINEAS) l where l.numerolinea = i; 
            SELECT DEREF(l.producto) into xProducto FROM TABLE(SELF.LINEAS) l where l.numerolinea = i; 
            xTotal := xTotal + xLinea.cantidad * xProducto.pvp;
        END LOOP;
        return xTotal;
    END;
END;

CREATE TABLE TABLA_CLIENTES OF T_CLIENTE;

ALTER TABLE TABLA_CLIENTES ADD CONSTRAINT pk_cliente PRIMARY KEY (IDCLIENTE);

CREATE TABLE TABLA_PRODUCTOS OF T_PRODUCTO;

ALTER TABLE TABLA_PRODUCTOS ADD CONSTRAINT pk_producto PRIMARY KEY (IDPRODUCTO);

CREATE TABLE TABLA_VENTAS OF T_VENTA NESTED TABLE LINEAS STORE AS LINEAS_ANIDADAS;

ALTER TABLE TABLA_VENTAS ADD CONSTRAINT pk_venta PRIMARY KEY (IDVENTA);

DELETE FROM TABLA_PRODUCTOS;

insert into tabla_productos values(t_producto(1,'Ratón',9.99,10));
insert into tabla_productos values(t_producto(2,'Teclado',15,21));
insert into tabla_productos values(t_producto(3,'Auriculares',20,30));
insert into tabla_productos values(t_producto(4,'Mando',40,5));

insert into tabla_clientes values(t_cliente(1, 'Mario Ortiz', '123456789',t_direccion('Cruz del sur', 'Granada',18015,'Granada'),v_telefonos('748373483','23452357')));
insert into tabla_clientes values(t_cliente(2, 'Lidia Sepúlveda', '987654321',t_direccion('Av.Andalucia', 'Estepona',29006,'Málaga'),v_telefonos('24552356')));

DELETE FROM TABLA_VENTAS;
insert into tabla_ventas values(1,(select ref(t) from tabla_clientes t  where t.idcliente = 1),nested_lineas(),sysdate);

-- INSERCIÓN DE LÍNEAS EN LA TABLA ANIDADA DENTRO DE VENTAS
insert into table(select v.lineas from tabla_ventas v where v.idventa = 1) values(t_linea(1,2, (select ref(p) from tabla_productos p where p.idproducto = 4)));
insert into table(select v.lineas from tabla_ventas v where v.idventa = 1) values(t_linea(2,11, (select ref(p) from tabla_productos p where p.idproducto = 3)));

/*CREATE OR REPLACE PROCEDURE sp_IMPRIME_VENTA(idVenta IN NUMBER) IS
BEGIN
    
END;*/

SET SERVEROUTPUT ON;  
DECLARE
    xVenta t_venta;
BEGIN
    SELECT t_venta(v.idventa, v.idcliente, v.lineas, v.fechaventa) into xVenta from tabla_ventas v where idventa = 1;
    dbms_output.put_line('Total de la venta: ' || xVenta.total_venta() || ' €');
END;

select * from tabla_productos;
select * from tabla_clientes;
select * from tabla_ventas;

SELECT t_linea(l.numerolinea, l.cantidad, l.producto) FROM TABLE(SELECT LINEAS FROM TABLA_VENTAS WHERE IDVENTA = 1) l where l.numerolinea = 1;
select CURSOR(select * from table(v.lineas)) from tabla_ventas v;





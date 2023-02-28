CREATE OR REPLACE TYPE T_CURSO AS OBJECT(
    CODCUR VARCHAR2(10),
    NOMBRE VARCHAR2(50)
);

CREATE OR REPLACE TYPE T_ASIGNATURA AS OBJECT(
    CODASI VARCHAR2(10),
    NOMBRE VARCHAR2(50),
    CURSO REF T_CURSO
);

CREATE OR REPLACE TYPE VAR_TELEFONOS AS VARRAY(3) OF VARCHAR2(10);

CREATE OR REPLACE TYPE T_ALUMNO AS OBJECT(
    CODALU VARCHAR2(10),
    NOMBRE VARCHAR2(50),
    DIRECCION VARCHAR2(100),
    TELEFONOS VAR_TELEFONOS
);

DROP TYPE T_ALUMNO_PRO;

CREATE OR REPLACE TYPE T_ALUMNO_PRO AS OBJECT(
    ALUMNO REF T_ALUMNO,
    OBSERVACION VARCHAR2(50),
    NOTA NUMBER (3,2)
);
DROP TYPE NESTED_ALUMNOS;
DROP TYPE T_PROYECTO;
CREATE OR REPLACE TYPE NESTED_ALUMNOS AS TABLE OF T_ALUMNO_PRO;
DROP TYPE T_PROYECTO;
CREATE OR REPLACE TYPE T_PROYECTO AS OBJECT(
    CODPRO VARCHAR2(10),
    DESCRIPCION VARCHAR2(100),
    ASIGNATURA REF T_ASIGNATURA,
    NOTA NUMBER(3,2),
    ALUMNOS NESTED_ALUMNOS,
    
    MEMBER FUNCTION fNumAluxPrj RETURN NUMBER,
    MEMBER PROCEDURE spImprimePrj

);

CREATE OR REPLACE TYPE BODY T_PROYECTO AS
    MEMBER FUNCTION fNumAluxPrj RETURN NUMBER IS
        xNumAlu NUMBER := 0;
    BEGIN
        xNumAlu := ALUMNOS.COUNT;
        RETURN xNumAlu;
    END;
    MEMBER PROCEDURE spImprimePrj IS
        xAsignatura T_ASIGNATURA;
        xAlumno T_ALUMNO;
    BEGIN
        SELECT DEREF(SELF.ASIGNATURA) INTO xAsignatura FROM DUAL;
        dbms_output.put_line(   
            'CÓDIGO: ' || SELF.codpro  || chr(10) ||
            'DESCRIPCIÓN: ' || SELF.descripcion || chr(10) || 
            'NOTA: ' || SELF.nota || chr(10) || 
            'CÓD. ASIGNATURA: ' || xAsignatura.CODASI || chr(10) || 
            'NOM. ASIGNATURA: ' || xAsignatura.NOMBRE || chr(10)
        );
        FOR i IN 1..SELF.ALUMNOS.count LOOP
        SELECT DEREF(SELF.ALUMNOS(i).ALUMNO) INTO xAlumno from DUAL;
            dbms_output.put_line(   
                'ALUMNO Nº' || i || chr(10) ||
                'NOMBRE: ' || xAlumno.nombre  || chr(10) ||
                'NOTA: ' || alumnos(i).nota
                );
        END LOOP;
    END;
END;

DROP TABLE PROYECTOS;
DROP TABLE ALUMNOS;

-- -----------------------------------------------------------------------------------------------------------

CREATE TABLE CURSOS OF T_CURSO;
ALTER TABLE CURSOS ADD CONSTRAINT pk_cur PRIMARY KEY(codcur);
CREATE TABLE ASIGNATURAS OF T_ASIGNATURA;
ALTER TABLE ASIGNATURAS ADD CONSTRAINT pk_asig PRIMARY KEY(codasi);
CREATE TABLE ALUMNOS OF T_ALUMNO;
ALTER TABLE ALUMNOS ADD CONSTRAINT pk_alu PRIMARY KEY(codalu);

CREATE TABLE PROYECTOS OF T_PROYECTO
NESTED TABLE ALUMNOS STORE AS TMP_ALUMNOS;
ALTER TABLE PROYECTOS ADD CONSTRAINT pk_pro PRIMARY KEY (codpro);


INSERT INTO CURSOS VALUES (t_curso('C001','2DAM'));

INSERT INTO ASIGNATURAS VALUES ('A001', 'AD', (SELECT REF(C) FROM CURSOS C WHERE C.CODCUR = 'C001'));

INSERT INTO ALUMNOS VALUES ('ALU01', 'Mario Ortiz Jibaja', 'C. Cruz del Sur 3', var_telefonos('629649784',null,null));
INSERT INTO ALUMNOS VALUES ('ALU02', 'Manuel José Fernández Poyatos', 'C. Cruz del Sur 3', var_telefonos('123456789','123456789',null));
INSERT INTO ALUMNOS VALUES ('ALU03', 'Lidia Sepúlveda Villodres', 'Av. Andalucía 34', var_telefonos('123456789',null,null));
INSERT INTO ALUMNOS VALUES ('ALU04', 'Ramón Raya Membrilla', 'C. Cruz del Sur 3', var_telefonos('123456789','123456789',null));
SELECT * FROM ALUMNOS;
SELECT * FROM ASIGNATURAS;
SELECT * FROM CURSOS;



INSERT INTO PROYECTOS VALUES('PRO001','Sin descripción', (SELECT REF(A) FROM ASIGNATURAS A WHERE A.CODASI = 'A001'), 7.5, NESTED_ALUMNOS());
INSERT INTO TABLE(SELECT ALUMNOS FROM PROYECTOS P WHERE P.CODPRO = 'PRO001') VALUES (t_alumno_pro((SELECT REF(A) FROM ALUMNOS A WHERE A.CODALU = 'ALU01'), 'Se va por las nubes', 9));
INSERT INTO TABLE(SELECT ALUMNOS FROM PROYECTOS P WHERE P.CODPRO = 'PRO001') VALUES (t_alumno_pro((SELECT REF(A) FROM ALUMNOS A WHERE A.CODALU = 'ALU02'), 'Avispado pero no estudia', 5));
SELECT * FROM PROYECTOS WHERE CODPRO = 'PRO001';

INSERT INTO PROYECTOS VALUES('PRO002','BDOR', (SELECT REF(A) FROM ASIGNATURAS A WHERE A.CODASI = 'A001'), 8, NESTED_ALUMNOS());
INSERT INTO TABLE(SELECT ALUMNOS FROM PROYECTOS P WHERE P.CODPRO = 'PRO002') VALUES (t_alumno_pro((SELECT REF(A) FROM ALUMNOS A WHERE A.CODALU = 'ALU03'), 'Muy buena estudiante', 9.9));
INSERT INTO TABLE(SELECT ALUMNOS FROM PROYECTOS P WHERE P.CODPRO = 'PRO002') VALUES (t_alumno_pro((SELECT REF(A) FROM ALUMNOS A WHERE A.CODALU = 'ALU04'), 'Le han carreado el proyecto', 4.9));

SELECT * FROM PROYECTOS;

 SELECT VALUE(P) FROM PROYECTOS P WHERE DEREF(P.ASIGNATURA).codasi = 'A001';

SELECT P.*, A.* FROM PROYECTOS P, TABLE(ALUMNOS) A;

DELETE FROM TABLE(SELECT ALUMNOS FROM PROYECTOS P WHERE P.CODPRO = 'PRO002') WHERE ALUMNO = (SELECT REF(A) FROM ALUMNOS A WHERE A.CODALU = 'ALU04');

SET SERVEROUTPUT ON;
DECLARE
    xProyecto T_PROYECTO;
BEGIN
  SELECT VALUE(P) INTO xProyecto FROM PROYECTOS P WHERE P.CODPRO = 'PRO002';
  --xProyecto.spImprimePrj();
  spImprimePrjxAsig('A001');
END;

CREATE OR REPLACE PROCEDURE spImprimePrjxAsig(xCodAsi VARCHAR2) IS
    xProyecto T_PROYECTO;
    xAlumno T_ALUMNO;
    CURSOR c1 IS SELECT VALUE(P) FROM PROYECTOS P WHERE DEREF(P.ASIGNATURA).codasi = xCodAsi;
    BEGIN
        open c1;
        LOOP
        FETCH c1 into xProyecto;
        EXIT WHEN C1%NOTFOUND;
            dbms_output.put_line(   
                'CÓDIGO: ' || xProyecto.codpro  || chr(13) ||
                'DESCRIPCIÓN: ' ||xProyecto.descripcion || chr(13) || 
                'NOTA: ' || xProyecto.nota || chr(13)
            );
            FOR i IN 1..xProyecto.alumnos.count LOOP
                SELECT DEREF(xProyecto.alumnos(i).alumno) INTO xAlumno FROM DUAL;
                dbms_output.put_line(   
                        'ALUMNO Nº' || i || chr(13) ||
                        'NOMBRE: ' || xAlumno.nombre  || chr(13)
                        );
                        FOR j in 1..xAlumno.telefonos.count LOOP
                             dbms_output.put_line(   
                                'TELÉFONO ' || j ||':' || chr(13) ||
                                xAlumno.telefonos(j)
                             );
                        END LOOP;
            END LOOP;          
        END LOOP;
        CLOSE c1;    
END;






CREATE OR REPLACE TYPE T_ALUMNO AS OBJECT(
    cCodAlu VARCHAR2(13),
    cNomAlu VARCHAR2(100),
    nNotaMedia NUMBER(10,2),
    cCodDelegado VARCHAR2(13),
    cCurso VARCHAR2(13),
    MEMBER FUNCTION fNombreDelegado RETURN VARCHAR2
);

CREATE OR REPLACE TYPE BODY T_ALUMNO AS
    MEMBER FUNCTION fNombreDelegado RETURN VARCHAR2 IS
        xNombreDelegado VARCHAR2(100);
    BEGIN
        SELECT D.cNomAlu INTO xNombreDelegado FROM ALUMNOS D WHERE D.CCODALU = self.ccoddelegado;
        RETURN xNombreDelegado;
    END;   
END;

CREATE TABLE ALUMNOS OF T_ALUMNO;

INSERT INTO ALUMNOS VALUES('01','Mario Ortiz', 9, '01', '2DAM');
INSERT INTO ALUMNOS VALUES('02','Ramón Raya', 7.5, '01', '2DAM');
INSERT INTO ALUMNOS VALUES('03','Pepe', 6, '02', '2DAM');
INSERT INTO ALUMNOS VALUES('04','Lidia', 8, '04', '1DAM');
INSERT INTO ALUMNOS VALUES('05','Manu', 5, '04', '1DAM');
DELETE FROM ALUMNOS WHERE CCODALU = '05';

SELECT A.fNombreDelegado() FROM ALUMNOS A;

CREATE OR REPLACE PROCEDURE spInfoAlumnosDel(xCodAlumno VARCHAR2) IS
    xAlumno T_ALUMNO;
    CURSOR C1 IS SELECT VALUE(A) FROM ALUMNOS A WHERE A.CCODDELEGADO = xCodAlumno;
    BEGIN
        OPEN C1;
        LOOP
            FETCH C1 INTO xAlumno;
            EXIT WHEN C1%NOTFOUND;
            dbms_output.put_line( 'Cód: '||xAlumno.ccodalu || chr(13) ||
            'Nombre: ' || xAlumno.cnomalu || chr(13) ||
            'Delegado: ' || xAlumno.ccoddelegado);          
        END LOOP;        
END;

CREATE OR REPLACE PROCEDURE spMismoDel(xCodCurso VARCHAR2) IS
    xAlumnoPrev T_ALUMNO;
    xAlumno T_ALUMNO;
    CURSOR C1 IS SELECT VALUE(A) FROM ALUMNOS A WHERE A.CCURSO = xCodCurso;
    BEGIN
        OPEN C1;
        FETCH C1 INTO xAlumnoPrev;
        LOOP
            FETCH C1 INTO xAlumno;
            EXIT WHEN C1%NOTFOUND;  
            IF (xAlumnoPrev.ccoddelegado != xAlumno.ccoddelegado) THEN
               dbms_output.put_line('No todos los alumnos tienen el mismo delegado.');  
               CLOSE C1;
               EXIT;
            END IF;
            xAlumnoPrev := xAlumno;
        END LOOP;        
END;

CREATE OR REPLACE PROCEDURE spMismoDel(xCodCurso VARCHAR2) IS
    xAlumno T_ALUMNO;
    XAlumnosCurso NUMBER(4);
    xNumAlumnos NUMBER(4);
    BEGIN   
       SELECT VALUE(A) INTO xAlumno FROM ALUMNOS A where rownum = 1 and ccurso = xCodCurso;
       SELECT COUNT(*) INTO xAlumnosCurso FROM ALUMNOS where ccurso = xCodCurso;
       select count(*) INTO XNUMALUMNOS from alumnos where ccurso = xCodCurso and ccoddelegado = xAlumno.ccoddelegado;
       IF (xNumAlumnos != xAlumnosCurso) THEN
            dbms_output.put_line('No todos los alumnos tienen el mismo delegado.');  
       END IF;     
END;

CREATE OR REPLACE PROCEDURE spMismoDel(xCodCurso VARCHAR2) IS
    xNumAlumnos NUMBER(4);
    BEGIN   
       SELECT COUNT(DISTINCT(CCODDELEGADO)) INTO xNumAlumnos FROM ALUMNOS where ccurso = xCodCurso;
       IF (xNumAlumnos > 1) THEN
            dbms_output.put_line('No todos los alumnos tienen el mismo delegado.');  
       END IF;     
END;
   
SET SERVEROUTPUT ON;

BEGIN
    --spInfoAlumnosDel('01');
    spMismoDel('2DAM');
END;

SELECT count(*) FROM ALUMNOS WHERE CCURSO = '2DAM';

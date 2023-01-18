DROP TYPE ALUMNO;
DROP TYPE NOTAS;
CREATE OR REPLACE TYPE NOTA AS OBJECT (
    COD_ASIGNATURA VARCHAR2(10),
    CURSO_ACTIVO NUMBER(2),
    CURSO_ACADEMICO NUMBER(4),
    NOTA_1EVAL NUMBER(4,2),
    NOTA_2EVAL NUMBER (4,2),
    NOTA_FINAL NUMBER (4,2),
    
    MEMBER PROCEDURE Notas_Curso (codCurso NUMBER),
    MEMBER PROCEDURE Aprobado_Curso (codCurso NUMBER),
    MEMBER PROCEDURE Aprobar_Eval,
    MEMBER PROCEDURE Alta_Notas  
);

CREATE OR REPLACE TYPE NOTAS AS VARRAY(10) OF NOTA;

CREATE OR REPLACE TYPE ALUMNO AS OBJECT(
    MATRICULA NUMBER(10),
    NOMBRE VARCHAR2(100),
    FECHA_NAC DATE,
    FECHA_INGRESO DATE,
    NOTAS_ALUMNO NOTAS,
    
    MEMBER PROCEDURE Get_DatosAlumno,
    MEMBER PROCEDURE Set_FechaIngreso(nuevafecha date),
    MEMBER FUNCTION Num_Asignaturas RETURN NUMBER,
    MEMBER PROCEDURE sp_Asig_Suspensas (curso_acad number),
    MEMBER PROCEDURE sp_Notas_Curso (xCurso number),
    MEMBER PROCEDURE AltaNota (xNota nota)
    /*MEMBER FUNCTION Get_AprobadoCurso (xCurso number) RETURN VARCHAR2,
    MEMBER PROCEDURE sp_AprobarEval,
    MEMBER PROCEDURE AltaNota (nuevanota nota)*/
);

CREATE OR REPLACE TYPE BODY ALUMNO AS 
    MEMBER PROCEDURE Get_DatosAlumno IS
    meses number(10);
    BEGIN
        meses := months_between(sysdate, fecha_nac);
        dbms_output.put_line('Número de matrícula: ' || SELF.MATRICULA || ' Nombre: ' || SELF.NOMBRE || ' Edad: ' || round(meses/12,1));
    END;
    MEMBER PROCEDURE Set_FechaIngreso(nuevafecha date) IS
    BEGIN
        SELF.FECHA_INGRESO := nuevafecha;
    END;
    MEMBER FUNCTION Num_Asignaturas RETURN NUMBER IS
    numnotas NUMBER(10);
    BEGIN
        IF self.notas_alumno.count is null THEN
            numnotas := 0;
        END IF;
        numnotas := self.notas_alumno.COUNT;
        RETURN numnotas;
    END;
    MEMBER PROCEDURE sp_Asig_Suspensas (curso_acad number) IS
        xNota nota;
    BEGIN
        FOR i IN 1..self.notas_alumno.count LOOP
            xNota := self.notas_alumno(i);
            IF (xNota.CURSO_ACADEMICO = curso_acad) THEN
                IF (xNota.NOTA_FINAL < 5) THEN
                    dbms_output.put_line('La asignatura ' || xNota.cod_asignatura || ' está suspensa.');
                END IF;
            END IF;   
        END LOOP;
    END;
    MEMBER PROCEDURE sp_Notas_Curso(xCurso number) IS
    xNota nota;
    BEGIN
          FOR i IN 1..self.notas_alumno.count LOOP
            xNota := self.notas_alumno(i);
            IF (xNota.CURSO_ACADEMICO = xCurso) THEN
                    dbms_output.put_line('Asignatura ' || xNota.cod_asignatura || ' Nota: ' || xNota.nota_final);
            END IF;   
        END LOOP;      
    END;
    MEMBER PROCEDURE AltaNota (xNota nota) is
    BEGIN
        IF (SELF.Notas_alumno.count < SELF.notas_alumno.limit and self.notas_alumno is not null) THEN
            SELF.notas_alumno.EXTEND;
            SELF.notas_alumno( SELF.notas_alumno.COUNT) := xNota;
        ELSE
            dbms_output.put_line('El VARRAY de notas está lleno.');
        END IF;
    END;
END;

set serveroutput on;
DECLARE
    alu alumno;
BEGIN
    alu := alumno(1234, 'Mario', '09/01/2003', null, null);
    alu.notas_alumno := notas();
    alu.notas_alumno.extend;
    alu.notas_alumno(alu.notas_alumno.count) := nota('AD', 1, 2022, 10, 9, 4);
    alu.Get_DatosAlumno;
    alu.Set_FechaIngreso('05/05/2021');
    alu.sp_Asig_Suspensas(2022);
    alu.sp_Notas_Curso(2022);
    dbms_output.put_line('Número de notas: ' || alu.Num_Asignaturas);
END;

CREATE TABLE ALUMNOS OF ALUMNO;

ALTER TABLE ALUMNOS ADD CONSTRAINT PK_ALUMNOS PRIMARY KEY (NUM_MATR);
ALTER TABLE ALUMNOS ADD  CONSTRAINT CK_NN_ALUMNOS CHECK (NOMBRE IS NOT NULL);
ALTER TABLE ALUMNOS ADD  CONSTRAINT UQ_ALUMNOS UNIQUE (NOMBRE);
ALTER TABLE ALUMNOS MODIFY (FECHA_INGRESO DEFAULT SYSDATE);
ALTER TABLE ALUMNOS MODIFY NOTAS_ALUMNO DEFAULT NOTAS();

INSERT INTO ALUMNOS (MATRICULA, NOMBRE) VALUES (1234,'Mario');

select * from alumnos;

set serveroutput on;
declare
  xAlu alumno;
begin
  select value(a) into xAlu from alumnos a where nombre = 'Mario';
  xAlu.AltaNota(nota('PMDM', 2, 2022, 9, 9, 10));
  update alumnos set notas_alumno = xAlu.notas_alumno where nombre = 'Mario';
  commit;
end;


CREATE USER EXAMEN_AD IDENTIFIED BY EXAMEN_AD;
GRANT DBA TO EXAMEN_AD;




DROP TABLE OBJETOS_ALUMNOS;

CREATE OR REPLACE TYPE t_ALUMNO AS OBJECT
(
    DNI VARCHAR2(10),
    NOMBRE VARCHAR2(100),
    CURSO VARCHAR2(100),
    FECHANAC DATE,
    PESO NUMBER(5,2),
    ESTATURA NUMBER(3),
    
    MEMBER FUNCTION fEdad RETURN NUMBER,
    MEMBER FUNCTION fIMC RETURN NUMBER,
    MEMBER FUNCTION fIndice RETURN VARCHAR2
);

CREATE OR REPLACE TYPE BODY t_ALUMNO AS
    MEMBER FUNCTION fEdad RETURN number IS
        ED NUMBER;
        BEGIN
            ED := TO_CHAR(SYSDATE,'yyyy') - TO_CHAR(FECHANAC,'yyyy');
            RETURN ED;
        END;
    
    
    MEMBER FUNCTION fIMC RETURN NUMBER IS
        IMC NUMBER(4,2);
        xError NUMBER;
        BEGIN
            IF PESO <= 0 AND ESTATURA <= 100 THEN
                xError := -1;
                RETURN xError;
            ELSE
                IMC := PESO / POWER(ESTATURA/100,2);
            END IF;    
            RETURN IMC;
        END;   
        
    MEMBER FUNCTION fIndice RETURN VARCHAR2 IS
        INDICE VARCHAR2(100);
        IMC NUMBER(4,2);
        BEGIN
            IMC := fImc();
            IF IMC <= 18.4 THEN
                INDICE := 'INFERIOR';
            END IF;
            IF IMC >= 18.5 AND IMC < 25 THEN
                INDICE := 'NORMAL';
            END IF;
            IF IMC >= 25 AND IMC < 30 THEN
                INDICE := 'SUPERIOR';
            END IF;
            IF IMC > 30 THEN
                INDICE := 'OBESO';
            END IF;
            RETURN INDICE;
        END;
END;

CREATE TABLE OBJETOS_ALUMNOS OF t_ALUMNO;

INSERT INTO OBJETOS_ALUMNOS VALUES(t_ALUMNO('12345678A','Mario Ortiz', '2DAM','09/01/2003', 70.00, 178));
INSERT INTO OBJETOS_ALUMNOS VALUES(t_ALUMNO('234567890B','Wenceslao', '2DAM','01/01/2001', 85.00, 180));

SELECT * FROM 

DELETE FROM OBJETOS_ALUMNOS;
SELECT A.*,A.fEdad(), A.fIMC(), A.fIndice() FROM OBJETOS_ALUMNOS A WHERE A.fIMC() > 23;
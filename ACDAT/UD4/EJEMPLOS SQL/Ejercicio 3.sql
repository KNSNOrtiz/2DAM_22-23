CREATE OR REPLACE TYPE T_ARBITRO AS OBJECT(
    CODIGO NUMBER,
    NOMBRE VARCHAR2(50)
);

CREATE OR REPLACE TYPE T_VISITANTE AS OBJECT(
    CODIGO NUMBER,
    NOMBRE VARCHAR2(50),
    CIUDAD VARCHAR2(50),
    PABELLON VARCHAR2(50)
);

CREATE OR REPLACE TYPE T_PARTIDO AS OBJECT(
    VISITANTE REF T_VISITANTE,
    FECHA_PARTIDO DATE,
    PF NUMBER,
    PC NUMBER 
);

CREATE OR REPLACE TYPE PARTIDOS AS TABLE OF T_PARTIDO;



CREATE OR REPLACE TYPE T_LOCAL AS OBJECT(
    EQUIPO REF T_VISITANTE,
    TABLA_PARTIDOS PARTIDOS 
);

CREATE OR REPLACE PROCEDURE sp_ImprimirPartido () AS

END;
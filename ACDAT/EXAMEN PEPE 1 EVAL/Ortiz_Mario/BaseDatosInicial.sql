create table alumnos(
    codAlu VARCHAR2(13) PRIMARY KEY,
    nomAlu VARCHAR2(100) NOT NULL UNIQUE,
    asignatura VARCHAR2(100) NOT NULL,
    notaFinal NUMBER(5,2) NOT NULL
);

INSERT INTO ALUMNOS VALUES ('001','UNO','AD',1);
INSERT INTO ALUMNOS VALUES ('002','DOS','PSP',2);
INSERT INTO ALUMNOS VALUES ('003','TRES','ANDROID',3);
COMMIT;
CREATE TABLE Salas (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL UNIQUE,
    Andar INTEGER NOT NULL,
    QtdAssentos INTEGER NOT NULL,
    Status INTEGER NOT NULL
);

CREATE TABLE Reservas (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Inicio TIMESTAMP NOT NULL,
    Fim TIMESTAMP NOT NULL,
    Status INTEGER NOT NULL,
    SalaId BIGINT NOT null,
    constraint FK_Reservas_Salas
        FOREIGN KEY (SalaId)
        REFERENCES Salas(Id)
);

select * from salas;
select * from reservas;
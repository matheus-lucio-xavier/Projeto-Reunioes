CREATE TABLE Salas (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(80) NOT NULL,
    Andar INTEGER NOT NULL,
    QtdAssentos INTEGER NOT NULL
);

CREATE TABLE Reservas (
    Id BIGINT PRIMARY KEY,
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
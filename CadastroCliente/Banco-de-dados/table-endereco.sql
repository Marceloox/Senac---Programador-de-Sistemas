CREATE TABLE endereco (
	id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
	cep VARCHAR(8) NOT NULL
);

INSERT INTO endereco (
	logradouro,
    numero,
    bairro,
    municipio,
    estado,
    cep
)
VALUES
("Rua José Francisco de Freitas", "133", "Jardim Maria Rita", "São Paulo", "SP", "04814180"),
("Rua Manoel Caldeira", "583",  "Jardim Ana Lúcia", "São Paulo", "SP", "04812000"),
("Avenida Gonçalo de Paiva de Gomes", "166",  "Jardim República", "São Paulo", "SP", "04915160");



select * from endereco;
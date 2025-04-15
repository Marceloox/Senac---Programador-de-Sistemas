CREATE TABLE cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
	FOREIGN KEY (id_endereco)
		REFERENCES endereco (id)
);

Drop table cliente;
drop table endereco;

INSERT INTO cliente (
	nome,
    data_nascimento,
    email, telefone, 
    tipo, 
    etnia, 
    genero, 
    estrangeiro, 
    id_endereco
)
VALUES
('Marcelo Ferreira', '06-07-2006', 'marcelo06ferr@email', '11960295985', 0, 0, 0, 0, (SELECT id FROM endereco WHERE logradouro = "Rua José Francisco de Freitas")),
('Eduardo Henrique', '10-11-1996', 'edu1910@email.com', '11980202499', 0, 0, 0, 0, (SELECT id FROM endereco WHERE logradouro = "Rua Manuel Caldeira")),
('Leonice Ramos', '11-12-1955', 'nice.mwa@email.com', '11980202502', 0, 1, 0, 0, (SELECT id FROM endereco WHERE logradouro = "Avenida Gonçalo de Paiva de Gomes"));

CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);

INSERT INTO cliente
(nome, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)
VALUES
('Rafael Sousa', '1991-08-31', 'rafael@email.com', '11999999999', 0, 3, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco do Rafael')),
('Vanda Maria', '1958-03-08', 'vanda@email.com', '11999999991', 0, 0, 1, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco dos pais do Rafael')),
('Joao Sousa', '1962-07-14', 'joao@email.com', '11999999992', 0, 1, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco dos pais do Rafael'));


select * from cliente;
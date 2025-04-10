CREATE TABLE cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL,
    telefone VARCHAR(11) NOT NULL,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
	FOREIGN KEY (id_endereco)
		REFERENCES endereco (id)
);
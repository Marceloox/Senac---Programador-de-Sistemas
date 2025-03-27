CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10,2) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    genero VARCHAR(30) NOT NULL,
    editora VARCHAR(50) NOT NULL,
    autor VARCHAR(100) NOT NULL
);

INSERT INTO livro (
	titulo,
    data_publicacao,
    numero_paginas,
    preco,
    isbn,
    genero,
    editora,
    autor
)
VALUES (
	'Harry Potter e a Pedra Filosofal',
    '1997-06-26',
    264,
    40.00,
    '978-0-43-955493-0',
    'Literatura fantástica',
    'Rocco Ltda.',
    'J. K. Rowling'
);
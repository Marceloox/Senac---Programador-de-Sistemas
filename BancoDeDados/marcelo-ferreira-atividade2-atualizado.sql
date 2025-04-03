/*
Atividade 2
*/

/*
Exercício 1
*/

-- Criando tabela
CREATE TABLE IF NOT EXISTS cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    saldo INT NOT NULL
);

-- Inserindo Dados
INSERT INTO cliente (
	nome,
    idade,
    cidade,
    saldo
)
VALUES 
("Carlos", 45, "São Paulo", 2500.00),
("Mariana", 32, "Rio de Janeiro", 3200.50),
("Pedro", 27, "Belo Horizonte", 1500.75),
("Fernanda", 38, "Curitiba", 4200.00);

-- Tarefas
SELECT
	*
FROM
	cliente
WHERE
	cidade = "Rio de Janeiro";
    
SELECT
	*
FROM
	cliente
WHERE
	saldo > 2000
ORDER BY 
	saldo DESC;

SELECT 
	nome,
    idade
FROM
	cliente
WHERE
	idade > 30;
    

/*
Exercício 2
*/

-- Tarefas
SELECT
	*
FROM
	cliente
WHERE
	idade BETWEEN 25 AND 40;
    
SELECT
	*
FROM
	cliente
WHERE
	nome LIKE "F%";
    
SELECT
	*
FROM
	cliente
WHERE
	cidade = "Rio de Janeiro" OR cidade = "Belo Horizonte";
    

/*
Execício 3
*/

-- Criando outra tabela
CREATE TABLE IF NOT EXISTS pedido (
	id INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    valor INT NOT NULL,
    data_pedido DATETIME NOT NULL
);

-- Inserindo dados nessa tabela
INSERT INTO pedido (
	id_cliente,
	valor,
	data_pedido
)
VALUES
(1, 500.00, "2024-03-10"),
(2, 1200.00, "2024-03-12"),
(3, 300.50, "2024-03-18"),
(1, 800.00, "2024-03-18");    


-- Tarefas
SELECT
	COUNT(id)
FROM
	pedido;

SELECT
	AVG(valor) AS media_valor
FROM
	pedido;
    
SELECT
	id_cliente, SUM(valor) AS total_gasto
FROM
	pedido
GROUP BY
	id_cliente;
    

/*
Exercício 4
*/

DROP TABLE cliente;
DROP TABLE pedido;

CREATE TABLE IF NOT EXISTS cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL
);

INSERT INTO cliente (
		nome,
        cidade
)
VALUES
("Carlos", "São Paulo"),
("Mariana", "Rio de Janeiro"),
("Pedro", "Belo Horizonte"),
("Fernanda", "Curitiba");

CREATE TABLE IF NOT EXISTS pedido (
	id INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    valor DECIMAL(8,2) NOT NULL,
	FOREIGN KEY (id_cliente)
			REFERENCES cliente(id)
);
 
INSERT INTO pedido (
		id_cliente,
        valor
)
VALUES
(1, 500.00),
(2, 1200.00),
(3, 300.50),
(1, 800.00);


-- Tarefas
SELECT
	pedido.id,
    cliente.nome,
    pedido.valor
FROM
	pedido
INNER JOIN
	cliente ON cliente.id = pedido.id_cliente;

SELECT 
	cliente.id,
    cliente.nome,
    pedido.valor
FROM
	cliente
LEFT JOIN
	pedido ON cliente.id = pedido.id_cliente;


/*
Exercício 5
*/

-- Tarefas
SELECT 
    cliente.nome,
    cliente.cidade,
    pedido.valor 
FROM
    pedido
INNER JOIN
    cliente ON pedido.id_cliente = cliente.id
WHERE
    pedido.valor > (SELECT AVG(valor) FROM pedido);
    
SELECT
	cliente.nome,
    cliente.cidade,
    pedido.valor
FROM
	pedido
INNER JOIN
	cliente ON pedido.id_cliente = cliente.id
WHERE
	pedido.valor > 1000;
    

/*
Exercício 6
*/

DROP TABLE cliente;

CREATE TABLE IF NOT EXISTS cliente (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    saldo INT NOT NULL
);

INSERT INTO cliente (
	nome,
    idade,
    cidade,
    saldo
)
VALUES 
("Carlos", 45, "São Paulo", 2500.00),
("Mariana", 32, "Rio de Janeiro", 3200.50),
("Pedro", 27, "Belo Horizonte", 1500.75),
("Fernanda", 38, "Curitiba", 4200.00);

-- Tarefas
INSERT INTO cliente (
	nome,
	cidade
 )
 VALUES
 ("Rafael", "Porto Alegre");
 
UPDATE
	cliente
SET
	saldo = saldo + (saldo + 0.10);

DELETE FROM
	pedido
WHERE
	pedido.valor < 500;
 



 
 
 
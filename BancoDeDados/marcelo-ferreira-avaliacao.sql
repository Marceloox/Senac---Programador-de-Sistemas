/*
Avaliação
*/

/*
Criação de Tabelas
*/

-- Tabela Produto
CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL(8,2) NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
	FOREIGN KEY (fornecedor_id)
		REFERENCES fornecedor(id)	
);

INSERT INTO produto (
	nome,
    categoria,
    preco,
    estoque,
    fornecedor_id
)
VALUES
("Celular X", "Eletrônicos", 2500.00, 30, 1),
("Notebook Y", "Eletrônicos", 4800.00, 15, 2),
("Mesa de Madeira", "Móveis", 750.00, 10, 3),
("Cadeira Z", "Móveis", 300.00, 25, 3),
("TV 50'", "Eletrônicos", 3500.00, 8, 1);

-- Tablea Fornecedor
CREATE TABLE IF NOT EXISTS fornecedor (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
	cidade VARCHAR(50) NOT NULL
);

INSERT INTO fornecedor (
	nome,
    cidade
)
VALUES
("TechBrasil", "São Paulo"),
("CompuTech", "Rio de Janeiro"),
("Moveis&Co", "Curitiba");

-- Tabela Pedido
CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATETIME NOT NULL,
    cliente_id INT NOT NULL,
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

INSERT INTO pedido (
	produto_id,
    quantidade,
    data_pedido,
    cliente_id
)
VALUES
(1, 2, "2024-03-10", 1),
(3, 1, "2024-03-11", 2),
(2, 1, "2024-03-15", 3),
(5, 3, "2024-03-18", 1),
(4, 4, "2024-03-20", 4);

-- Tabela Cliente
CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    idade INT NOT NULL
);

INSERT INTO cliente (
	nome,
    cidade,
    idade
)
VALUES
("João Silva", "São Paulo", 35),
("Maria Santos", "Belo Horizonte", 28),
("Carlos Lima", "Rio de Janeiro", 42),
("Fernanda Rocha", "Curitiba", 30);



/*
Exercício 1
*/

-- Tarefas
SELECT 
    *
FROM
    produto
WHERE
    produto.categoria = 'Eletrônicos' AND produto.preco > 3000
ORDER BY preco DESC;

SELECT
	*
FROM
	cliente
WHERE
	cliente.cidade <> "São Paulo" AND cliente.idade > 30;
    
SELECT
	*
FROM
	pedido
WHERE
	data_pedido BETWEEN "2024-03-10" AND "2024-03-15"
ORDER BY data_pedido ASC;

SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
GROUP BY estoque DESC;

SELECT
	*
FROM
	fornecedor
WHERE
	cidade <> "Rio de Janeiro" AND nome LIKE "T%";
  
  
  
/*
Exercício 2
*/

-- Tarefas
SELECT
	categoria,
    AVG(preco) AS preco_medio
FROM
	produto
GROUP BY categoria;

SELECT 
    cliente.nome,
    COUNT(pedido.cliente_id)
FROM
	pedido
INNER JOIN
	cliente ON pedido.cliente_id = cliente.id  
GROUP BY cliente_id;

SELECT
	categoria,
	SUM(estoque) AS estoque_total
FROM
	produto
GROUP BY categoria;

SELECT
	id,
    produto_id,
    quantidade
FROM
	pedido
ORDER BY quantidade DESC
LIMIT 1;

INSERT INTO cliente (
	nome,
    cidade,
    idade
)
VALUES
("Cauã Linhares", "São Paulo", 18);

SELECT
    COUNT(cliente.nome) AS clientes,
    cidade
FROM
	cliente
GROUP BY cidade DESC;
    
    
    
/*
Exercício 3
*/

-- Tarefas
SELECT
	fornecedor.nome AS fornecedor,
	produto.nome AS produto
FROM
	produto
INNER JOIN
	fornecedor ON produto.fornecedor_id = fornecedor.id;

SELECT
	pedido.data_pedido,
	cliente.nome AS cliente,
    produto.nome AS produto
FROM
	pedido
INNER JOIN
	produto ON pedido.produto_id = produto.id
INNER JOIN
	cliente ON pedido.cliente_id = cliente.id;
    
SELECT
	cliente.nome,
    produto.nome,
    fornecedor.nome
FROM
	pedido
INNER JOIN
	produto ON pedido.produto_id = produto.id
INNER JOIN
	cliente ON pedido.cliente_id = cliente.id
INNER JOIN
	fornecedor ON produto.fornecedor_id = fornecedor.id;
    
SELECT 
	cliente.id,
	cliente.nome,
    SUM(pedido.quantidade) AS total_produtos
FROM
	pedido
INNER JOIN
	cliente ON pedido.cliente_id = cliente.id
GROUP BY cliente.id; 



/*
Exercício 4
*/

-- Tarefas
SELECT 
    produto.*
FROM
    produto 
WHERE
    produto.preco > (SELECT 
            AVG(preco)
        FROM
            produto 
        WHERE
			produto.categoria = "Eletrônicos")
		AND categoria = 'Eletrônicos'
UNION SELECT 
    produto.*
FROM
    produto
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = 'Móveis')
		AND categoria = 'Móveis';
    
UPDATE
	produto
SET
	produto.preco = produto.preco + (produto.preco * 0.10)
WHERE
	produto.categoria = "Eletrônicos";

SELECT 
	*
FROM
	produto;
    
DELETE FROM pedido 
WHERE
    cliente_id IN (SELECT 
        id
    FROM
        cliente
    WHERE
        cidade = 'Curitiba');

INSERT INTO cliente (
	nome,
    cidade,
    idade
)
VALUES
("Ricardo Lopes", "Porto Alegre", 38);

INSERT INTO pedido (
	produto_id,
    quantidade,
    data_pedido,
    cliente_id
)
VALUES
(2, 2, "2024-03-25", 1);

SELECT
	cliente.nome AS Cliente
FROM
	cliente
INNER JOIN
	pedido ON cliente.id = pedido.cliente_id
INNER JOIN
	produto ON pedido.produto_id = produto.id
WHERE
	produto.categoria = 'Móveis';
	
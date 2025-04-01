/*
Exercício 1
*/


-- Tabela Empregado
CREATE TABLE IF NOT EXISTS empregado (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade VARCHAR(2) NOT NULL,
	departamento VARCHAR(50) NOT NULL,
    salario INT NOT NULL
);


-- Inserindo Dados
INSERT INTO empregado (
	nome,
    idade,
    departamento,
    salario
) 
VALUES 
("João", "30", "RH", 50000),
("Sarah", "28", "TI", 60000),
("Miguel", "35", "Vendas", 55000),
("Ana", "27", "TI", 62000);


-- Tarefas
SELECT
	*
FROM
	empregado
WHERE
	departamento = "TI";
    
SELECT
	nome,
    salario
FROM
	empregado
WHERE
	salario > 55000;

SELECT
	*
FROM
	empregado
ORDER BY 
	idade DESC;
    
    
/*
Exercício 2
*/

-- Tarefas
SELECT
	*
FROM
	empregado
WHERE
	idade >= "28" AND idade <= "35";

SELECT
	*
FROM
	empregado
WHERE
	nome LIKE "M%";
    
SELECT
	*
FROM
	empregado
WHERE 
	departamento <> "RH";
 
 
/*
Exercício 3
*/

-- Tarefas
SELECT
	COUNT(id)
FROM
	empregado;
    
SELECT
	AVG(salario)
FROM
	empregado;
    
SELECT
	SUM(salario)
FROM
	empregado
WHERE
	departamento = "Vendas";


/*
Exercício 4
*/

DROP TABLE empregado;

CREATE TABLE IF NOT EXISTS empregado (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
	id_departamento INT NOT NULL,
    FOREIGN KEY (id_departamento)
		REFERENCES departamento(id)
);

CREATE TABLE IF NOT EXISTS departamento (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome_departamento VARCHAR(50) NOT NULL
);

INSERT INTO empregado (
	nome,
    id_departamento
)
VALUES
("João", 1),
("Sarah", 2),
("Miguel", 3),
("Ana", 2);

INSERT INTO departamento (
	nome_departamento
) 
VALUES 
("RH"),
("TI"),
("Vendas");

-- Tarefas
SELECT
	empregado.id,
    empregado.nome,
    departamento.nome_departamento
FROM
	empregado
INNER JOIN
	departamento ON empregado.id_departamento = departamento.id;

SELECT DISTINCT
	departamento.nome_departamento
FROM
	departamento
LEFT JOIN
	empregado ON empregado.id_departamento = departamento.id;
    

/*
Exercício 5
*/

DROP TABLE empregado;

CREATE TABLE IF NOT EXISTS empregado (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
	departamento VARCHAR(25) NOT NULL,
    salario INT NOT NULL 
);

INSERT INTO empregado (
	nome,
    idade,
    departamento,
    salario
) 
VALUES 
("João", 30, "RH", 50000),
("Sarah", 28, "TI", 60000),
("Miguel", 35, "Vendas", 55000),
("Ana", 27, "TI", 62000);

-- Tarefas
SELECT
	*
FROM
	empregado
WHERE
	salario > (
		SELECT
			AVG(salario)
		FROM
			empregado
);

SELECT 
	*
FROM
	empregado
WHERE
	departamento = "TI";
    
    
/*
Exercício 6
*/

-- Tarefas
INSERT INTO empregado (
	nome,
    idade,
    departamento,
    salario
) 
VALUE
("Tomás", 41, "Vendas", 58000);

UPDATE empregado 
SET 
    salario = salario * 1.05
WHERE
    departamento = 'TI';

DELETE FROM 
	empregado
WHERE
	idade > 40;
	

	

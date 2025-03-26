CREATE TABLE IF NOT EXISTS testeatividade (
	id INT PRIMARY KEY AUTO_INCREMENT,
    carro VARCHAR(50) NOT NULL,
    cor VARCHAR(15) NOT NULL,
    placa VARCHAR(7) NOT NULL UNIQUE,
    ano VARCHAR(4) NOT NULL
);

SELECT
	*
FROM
	testeatividade;
    
INSERT INTO testeatividade (
	carro,
    cor,
    placa,
    ano
)
VALUES
('Civic', 'Preto', 'MOC5Z87', '2008'),
('Cerrato', 'Prata', 'MXM1R43', '2015'),
('Jetta', 'Branco', 'KOY7G42', '2025'),
('Nivus', 'Cinza', 'HUJ3Y58', '2023'),
('Creta', 'Vermelho', 'ADT7B96', '2023'),
('Virtus', 'Preto', 'CZB0B76', '2022'),
('Palio', 'Marrom', 'ZGJ7S28', '2005'),
('Opala', 'Cinza', 'FPH7F17', '1974'),
('Corolla', 'Branco', 'RXU3K19', '2018'),
('Tiguan', 'Preto', 'UOT2R25', '2025'),
('City', 'Cinza', 'ZFL9R75', '2013'),
('Kicks', 'Laranja', 'YSP8G31', '2017'),
('Golf', 'Vermelho', 'QMC2L73', '2024'),
('Uno', 'Cinza', 'WMQ1I79', '2002'),
('Aventador', 'Cinza', 'TEE0I32', '2025');
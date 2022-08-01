CREATE TABLE [pedido] (
	idPedido int IDENTITY(1,1) NOT NULL,
	descricaoPedido VARCHAR(100) NOT NULL,
	valorTotal real NOT NULL,
	idItem int not null,
	idCliente int not null,
	CONSTRAINT [pk_pedido] PRIMARY KEY CLUSTERED (idPedido)
	);

CREATE TABLE [item] (
	idItem int IDENTITY(10,10),
	descricaoItem varchar(100) not null,
	qtdItem int,
	valor float not null,
	CONSTRAINT [pk_item] PRIMARY KEY CLUSTERED (idItem)
);

ALTER TABLE pedido ALTER COLUMN valorTotal money
ALTER TABLE item DROP COLUMN idCliente

CREATE TABLE [cliente]
(
idCliente int identity(1,1) not null,
nomeCompleto varchar(40) not null,
email varchar(20) not null,
cpf varchar(11) not null,
CONSTRAINT [pk_cliente] PRIMARY KEY CLUSTERED (idCliente)
)

-- Tabela Pedido tem como chave estrangeira a tabela Item
-- Tabela Item tem como chave estrangeira a tabela Cliente

--COMANDO PARA ADICIONAR CHAVE ESTRANGEIRA NA TABELA PEDIDO
ALTER TABLE [item] WITH NOCHECK ADD CONSTRAINT [fk_cliente_item] 
FOREIGN KEY ([idCliente]) REFERENCES [cliente] ([idCliente]);

SELECT * FROM item;
SELECT * FROM cliente;
SELECT * FROM pedido;
delete from pedido where idPedido > 1
--SELECT COUNT(idPedido) as TotalPedidos from pedido where idCLiente = 1
DELETE FROM pedido WHERE idPedido > 0

-- INSERT INTO cliente (nomeCompleto, email, cpf) values ('Victor Ribeiro', 'v@gmail.com', '15679847859');

--INSERT INTO cliente (nomeCompleto, email, cpf) values ('James Oliveria', 'jo@email', '1568799800');
--INSERT INTO item (descricaoItem, qtdItem, valor) values ('Notebook Dell', 2, 3500.00);

INSERT INTO pedido (descricaoPedido, valorTotal, idItem,idCliente) values ('Pedido COMPRA 2', 35,70,1);

INSERT INTO item (descricaoItem,qtdItem,valor,idCliente) values ('COMPRA 2',3,35,1);

	






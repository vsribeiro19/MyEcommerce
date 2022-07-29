CREATE TABLE [pedido] (
	idPedido int IDENTITY(1,1) NOT NULL,
	descricaoPedido VARCHAR(100) NOT NULL,
	valorTotal FLOAT NOT NULL,
	CONSTRAINT [pk_pedido] PRIMARY KEY CLUSTERED (idPedido)
	);

--CREATE TABLE [item] (
--	idItem int IDENTITY(10,10) constraint,
--	descricaoItem varchar(100) not null,
--	QtdItem int,
--	Valor float not null
--);

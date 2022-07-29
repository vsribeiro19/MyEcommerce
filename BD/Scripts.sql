CREATE TABLE [pedido] (
	idPedido int primary key IDENTITY(1,1) ,
	descricaoPedido varchar(100) not null,
	valorTotal float);

CREATE TABLE [item] (
	idItem int primary key IDENTITY(10,10),
	descricaoItem varchar(100) not null,
	QtdItem int,
	Valor float not null
);

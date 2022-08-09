SELECT * FROM ITEM;
SELECT * FROM CLIENTE;
SELECT * FROM PEDIDO;


-- CREATE TRIGGER
CREATE TRIGGER tr_itemPedido AFTER INSERT ON item
for each row INSERT INTO pedido (idItem,idCliente,totalCompra) values (NEW.idItem,NEW.idCliente, NEW.valor);

CREATE TRIGGER tr_itemPedido AFTER INSERT ON cliente
for each row INSERT INTO item (IdCliente,nomeComprador,cpf,email) values (NEW.idCliente,NEW.nome,NEW.cpf, NEW.email);
DROP trigger tr_itemPedido;

-- FIM TRIGGER

delete idItem from item where idItem = 0;
delete idCliente from cliente where idCliente= 1;
delete idCliente from  cliente where idCliente > 1;

INSERT INTO cliente (nome,cpf,email) VALUES ('Aurora','236549821056', 'aurora@gmail.com');

SELECT pe.idPedido,pe.idItem,pe.idCliente, cl.nome,pe.totalCompra, cl.cpf from pedido pe
inner join item ite on ite.idItem = pe.idItem
inner join cliente cl on cl.idCliente = pe.idPedido;


SELECT PE.IDPEDIDO, PE.IDITEM, PE.IDCLIENTE FROM PEDIDO PE
INNER JOIN ITEM it ON it.idItem = PE.idPedido;

SELECT ite.descricao,pe.* FROM pedido pe
                    INNER JOIN item ite on ite.idItem = pe.idItem;

update item set idCliente = 0 where idItem = 6;


INSERT INTO ITEM (descricao, valor, qtdItem, idCliente,link) values ('Televisão 50 polegadas Samsung',3500, 1,2,'https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcT4W9NcCeA_lh38qwlzoAg_CYbHpPcPJiaC42mM_NRuIqBV9kBH51mKgLysLrFHTW9pyVtn7IMBwA&amp;usqp=CAc');
INSERT INTO CLIENTE (nome, cpf, email) VALUES ('Victor', '00000000000','v@gmail.com');

ALTER TABLE item ADD CONSTRAINT fk_item_idCliente FOREIGN KEY (idCliente) REFERENCES cliente (idCliente);





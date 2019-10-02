insert into Clientes(Nome,Idade,Genero)
values ('Marley', 18, 1),
('Brad', 25,1),
('Dora', 28, 0)
select * from Clientes

select * from Pedidos
insert into Pedidos (Numero,ClienteId,Valor)
values ('N000000002',1,280.80),
('N000000003',1,420.70),
('N000000004',1,340.12),
('N000000005',2,235),
('N000000006',2,850.70),
('N000000007',2,580.36),
('N000000008',3,1005.95),
('N000000009',3,120.00),
('N000000010',3,480.38)

insert into Pedidos (Numero,ClienteId, Valor)
values
('N000000011',4,120.00),
('N000000012',4,120.00),
('N000000013',4,120.00)

update Clientes   
set Genero = 0
where Id = 4
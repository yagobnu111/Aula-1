--2.2  - Agora devemos inserir 2 funcionarios diferentes
insert into Funcionarios (Nome)
values ('Pedrinho'), ('Joãozinho')
--2.3  - Agora devemos cadastrar 5 produtos ambev com seus respectivos valores
insert into Produtos (Nome, Valor)
values ('Guaraná 2L', 5.99),
('Energético Fusion 1L', 6.99),
('Budweiser lata', 2.99),
('Bohemia Puro Malte 990ml', 3.99),
('Stella Artois 550ml', 7.99)
--2.4  - Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, sendo 2 para o primeiro funcionario e 1 para o segundo (min 2 itens, max 5 itens)
select * from Funcionarios
select * from Produtos
insert into Pedidos (FuncionarioId, ProdutoId, Quantidade)
values (1,1, 3),
(1,4,6),
(1,5,5),
(2,3,12),
(2,2,2),
(2,5,12),
(2,1,4)
--2.5  - Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
select * from Funcionarios fun
order by fun.Nome
--2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
select * from Produtos pro
order by pro.Valor desc
--2.7  - Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario
select 
fun.Nome,
prod.Nome,
ped.Quantidade
from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
				 inner join Produtos prod on prod.Id = ped.ProdutoId
--2.8  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
select 
fun.Nome,
sum(ped.Quantidade) as 'Quantidade pedidos'
from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
group by fun.Nome
--2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total
select 
fun.Nome,
sum(pro.Valor * ped.Quantidade) as 'Total Pedido'
from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
				 inner join Produtos pro on ped.ProdutoId = pro.Id
group by fun.Nome
--2.10 - Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
select top 1
pro.Nome,
sum(ped.Quantidade) as 'Maior Pedido'
from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
				 inner join Produtos pro on ped.ProdutoId = pro.Id
group by pro.Nome
order by sum(ped.Quantidade) desc
--2.11 - Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
select top 1
pro.Nome,
sum(ped.Quantidade * pro.Valor) as 'Maior Valor'
from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
				 inner join Produtos pro on ped.ProdutoId = pro.Id
group by pro.Nome
order by sum(ped.Quantidade * pro.Valor) desc

--2.12 - Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou de nosso mercado
select * from Funcionarios
select * from Pedidos
select * from Produtos
select
prod.Id,
prod.Nome
from Produtos prod	
where prod.Id not in 
(select ped.ProdutoId from Funcionarios fun inner join Pedidos ped on fun.Id = ped.FuncionarioId
 where fun.Nome like 'Pedrinho%')

--2.13 - Vamos retornar em uma seleção os produtos ordenados pela ordem do mais comprado para o menos comprado

select 
pro.Nome,
count(ped.Quantidade) as 'Quantidade'
from Pedidos ped inner join Produtos pro on ped.ProdutoId = pro.Id
group by pro.Nome
order by 'Quantidade' desc
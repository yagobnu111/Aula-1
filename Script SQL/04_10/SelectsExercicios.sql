select * from Marcas

update Marcas set UsuInc = 1, UsuAlt = 1
where UsuInc = 0

-- Marcas cadastradas por Felipe
select
mar.Nome as 'Marcas cadastradas Felipe'
from Marcas mar inner join Usuarios usu
on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'

--Marcas que Giomar cadastrou
select 
mar.Nome as 'Marcas cadastradas Giomar'
from Marcas mar inner join Usuarios usu
on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%'

-- Quantidade de marcas cadastradas por felipe
select
count(mar.Nome) as 'Quantidade de marcas Felipe'
from Marcas mar inner join Usuarios usu
on mar.UsuInc = usu.Id
where usu.Usuario = 'Felipe%'
order by count(mar.Nome) desc

-- Quantidade de marcas cadastradas por felipe
select
count(mar.Nome) as 'Quantidade de marcas Giomar'
from Marcas mar inner join Usuarios usu
on mar.UsuInc = usu.Id
where usu.Usuario = 'Giomar%'
order by count(mar.Nome) asc

-- Quantidade de marcas cadastradas por Felipe e Giomar
select 
count (mar.Nome) as 'Quantidade de marcas Felipe e Giomar'
from Marcas mar inner join Usuarios usu
on mar.UsuInc = usu.Id
group by usu.Usuario

-- Carros que Felipe cadastrou
select 
car.Modelo as 'Cadatros de carros Felipe'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

-- Carros que Giomar cadastrou
select 
car.Modelo as 'Cadatros de carros Giomar'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'

-- Quantidade de carros que Felipe cadastrou
select 
count(car.Modelo) as 'Quantidade de carros Felipe'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
order by count(car.Modelo) desc

--Quantidade de carros que Giomar cadastrou
select 
count(car.Modelo) as 'Quantidade de carros Giomar'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by count(car.Modelo) asc

-- Quantidade de carros que Felipe e Giomar cadastraram
select 
count(car.Modelo) as 'Quantidade carros Felipe e Giomar'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
group by (usu.Usuario)

--Carros das marcas que Felipe cadastrou
select 
car.Modelo
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

-- Carros das marcas que Giomar cadastrou
select 
car.Modelo
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on usu.Id = mar.UsuInc
where  usu.Usuario like 'Giomar%' 

-- Quantidade de carros das marcas que Felipe cadastrou
select 
count(car.Modelo) as 'Quantidade'
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%' 

-- Quantidade de carros das marcas que Giomar cadastrou
select 
count(car.Modelo) as 'Quantidade'
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%' 

-- Total de vendas de 2019
select 
sum(ven.Quantidade * ven.Valor) as 'Total vendas 2019'
from Vendas ven
where year (ven.DatInc) = 2019

-- Quantidade de vendas de 2019
select 
sum(ven.Quantidade) as 'Quantidade vendas 2019'
from Vendas ven
where year (ven.DatInc) = 2019

--Valor total das vendas de cada ano
select 
sum(ven.Quantidade * ven.Valor) as 'Valor Total Vendas '
from Vendas ven
group by year(ven.DatInc) 
order by sum(ven.Valor) desc

--Quantidade  total de vendas de cada ano
select 
sum(ven.Quantidade) as 'Quantidade Vendas Total Asc'
from Vendas ven
group by year(ven.DatInc) 
order by sum(ven.Valor) asc

-- Mês de cada ano que retornou a maior quantidade de vendas (Professor)
SELECT YEAR(ven1.DatInc),
(	SELECT TOP 1 MONTH(ven.DatInc)
        FROM Vendas ven
        WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc)
  GROUP BY MONTH(ven.DatInc)
  ORDER BY SUM(ven.Quantidade) DESC)
FROM Vendas ven1
GROUP BY YEAR(ven1.DatInc)

-- Mês de cada ano que retornou o maior valor de vendas (Não fiz)






-- Valor total de vendas que Felipe realizou
select 
sum(ven.Quantidade * ven.Valor) as 'Total Vendas Felipe '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Felipe%'

-- valor total de vendas que Giomar realizou
select 
sum(ven.Quantidade * ven.Valor) as 'Total Vendas Giomar'
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Giomar%'

-- Quantidade total de vendas que Felipe realizou
select 
sum(ven.Quantidade ) as 'Quantidade Vendas Felipe '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Felipe%'

-- Quantidade total de vendas que Giomar realizou
select 
sum(ven.Quantidade ) as 'Quantidade Vendas Giomar '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Giomar%'

-- Quantidade total de vendas que Felipe e Giomar realizaram
select 
sum(ven.Quantidade ) as 'Quantidade Vendas Total '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
group by usu.Usuario
order by sum(ven.Quantidade) desc

-- Valor de vendas total Felipe e Giomar
select 
sum(ven.Valor * ven.Quantidade ) as 'Valor Vendas Total '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.I
group by usu.Usuario
order by sum(ven.Quantidade * ven.Valor) desc

-- Marca mais vendida de todos os anos (Não fiz)

 

				 



-- Quantidade de carro mais vendido todos anos (Não fiz)



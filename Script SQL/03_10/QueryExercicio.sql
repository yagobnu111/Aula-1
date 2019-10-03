select * from Marcas

update Marcas set UsuInc = 1, UsuAlt = 1
where UsuInc = 0

select
mar.Nome as 'Marcas cadastradas Felipe'
from Marcas mar inner join Usuarios usu
on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'

select 
mar.Nome as 'Marcas cadastradas Giomar'
from Marcas mar inner join Usuarios usu
on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%'

select
count(mar.Nome) as 'Quantidade de marcas Felipe'
from Marcas mar inner join Usuarios usu
on mar.UsuInc = usu.Id
where usu.Usuario = 'Felipe%'
order by count(mar.Nome) desc

select
count(mar.Nome) as 'Quantidade de marcas Giomar'
from Marcas mar inner join Usuarios usu
on mar.UsuInc = usu.Id
where usu.Usuario = 'Giomar%'
order by count(mar.Nome) asc

select 
count (mar.Nome) as 'Quantidade de marcas Felipe e Giomar'
from Marcas mar inner join Usuarios usu
on mar.UsuInc = usu.Id
group by usu.Usuario

select 
car.Modelo as 'Cadatros de carros Felipe'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

select 
car.Modelo as 'Cadatros de carros Giomar'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'

select 
count(car.Modelo) as 'Quantidade de carros Felipe'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Id = 1
order by count(car.Modelo) desc

select 
count(car.Modelo) as 'Quantidade de carros Giomar'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
where usu.Id = 2
order by count(car.Modelo) asc

select 
count(car.Modelo) as 'Quantidade carros Felipe e Giomar'
from Carros car inner join Usuarios usu
on car.UsuInc = usu.Id
group by (usu.Usuario)

select 
car.Modelo
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'


select 
car.Modelo
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on usu.Id = mar.UsuInc
where  usu.Usuario like 'Giomar%' 

select 
count(car.Modelo) as 'Quantidade'
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%' 

select 
count(car.Modelo) as 'Quantidade'
from Carros car inner join marcas mar on mar.Id = car.Marca
				inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%' 

select 
sum(ven.Quantidade * ven.Valor) as 'Total vendas 2019'
from Vendas ven
where year (ven.DatInc) = 2019

select 
sum(ven.Quantidade) as 'Quantidade vendas 2019'
from Vendas ven
where year (ven.DatInc) = 2019

select 
sum(ven.Quantidade * ven.Valor) as 'Valor Total Vendas '
from Vendas ven
group by year(ven.DatInc) 
order by sum(ven.Valor) desc

select 
sum(ven.Quantidade) as 'Quantidade Vendas Total Asc'
from Vendas ven
group by year(ven.DatInc) 
order by sum(ven.Valor) asc

select 
sum(ven.Quantidade) as 'Quantidade Total Mês '
from Vendas ven
group by month(ven.DatInc) 
order by sum(ven.Valor) desc

select 
sum(ven.Quantidade * ven.Valor) as 'Valor Total Mês '
from Vendas ven
group by month(ven.DatInc) 
order by sum(ven.Valor) desc

select 
sum(ven.Quantidade * ven.Valor) as 'Total Vendas Felipe '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Felipe%'


select 
sum(ven.Quantidade * ven.Valor) as 'Total Vendas Giomar'
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Giomar%'


select 
sum(ven.Quantidade ) as 'Quantidade Vendas Felipe '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Felipe%'

select 
sum(ven.Quantidade ) as 'Quantidade Vendas Giomar '
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where  usu.Usuario like 'Giomar%'











select * from Salarios 
where Id between 5 and 9 -- buscar registros entre dois Ids

select * from Salarios
where DataCriacao between '07/06/2019' and '08/07/2019' -- com datas

select top 5 * from Salarios  -- busca o top 5 
order by Valor desc

select * from Salarios
where Id >= 3 and Id <= 8
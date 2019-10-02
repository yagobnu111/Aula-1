--Subselect, um select dentro de outro select
select * from Pedidos ped
where ped.ClienteId in(select cli.* from Clientes cli 
inner join Pedidos ped on cli.Id = ped.ClienteId
where ped.Numero in ('N000000001', 'N000000006','N000000011'))
order by ped.Valor desc
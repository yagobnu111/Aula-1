select 
cli.Nome,
ped.Numero,
ped.Valor
from Clientes cli inner join Pedidos ped on cli.Id = ped.ClienteId
where cli.Id = 4
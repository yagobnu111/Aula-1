-- Sum some os valores
select SUM(ped.Valor) as 'Soma de vendas'
from Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id
where cli.Nome = 'Gabriel'

-- IIF analisa se a informação é verdadera e se sim traz a primera opção, se não a segunda (é um if) 
select IIF(SUM(ped.Valor) > 1600, 'Brinde Xiaomi', 'Não ganhou nada') as 'Bonificação',
SUM(ped.Valor) as 'Total',
cli.Nome
from Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id
group by cli.Nome

select IIF(SUM(ped.Valor) > 1600, 'Brinde Xiaomi', 'Não ganhou nada') as 'Bonificação',
SUM(ped.Valor) as 'Total',
cli.Nome
from Clientes cli inner join Pedidos ped on cli.Id = ped.ClienteId
group by cli.Nome

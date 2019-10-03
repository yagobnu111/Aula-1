select  
fun.Nome,
SUM(sal.Valor) as 'Total nos 3 meses',
AVG(sal.Valor) as 'Média 3 meses',
SUM(sal.Valor) / COUNT(sal.Valor) as 'Média forma 2',
count(sal.Valor) as 'Quantidade Pagamentos'
from Funcionarios fun inner join Salarios sal 
on fun.Id = sal.FuncionarioId
group by fun.Nome			-- preciso do group by para ordenar os nomes
order by sum(sal.Valor) desc



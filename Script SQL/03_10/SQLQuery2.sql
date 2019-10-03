select  
fun.Id,
fun.Nome,
sal.Valor,
convert(varchar(10), sal.DataCriacao, 103) as 'Data depósito'
from Salarios sal inner join Funcionarios fun on sal.FuncionarioId = fun.Id 
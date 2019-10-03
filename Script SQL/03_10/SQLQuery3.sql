select
fun.Id,
fun.Nome,
convert (varchar(10), fun.DataInicio,103) as 'Data Contratação',
convert (varchar(10),fun.DataSaida,103) as 'Data Demissão'
from Funcionarios fun inner join Salarios sal
on fun.Id = sal.FuncionarioId

select * from Funcionarios; 

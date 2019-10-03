select 
fun.Id,
fun.Nome,
convert(varchar(10),fun.DataInicio,103),
convert(varchar(10),fun.DataSaida,103)
from Funcionarios fun
where fun.Ativo = 0
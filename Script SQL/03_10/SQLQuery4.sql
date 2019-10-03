select -- select com subquery, traz o usuario e a soma dos valores 
Id,
Nome,
(select sum(Valor) from Salarios where FuncionarioId = Funcionarios.Id)
from Funcionarios 

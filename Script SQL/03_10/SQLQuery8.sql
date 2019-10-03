select * from Funcionarios

update Funcionarios
set DataSaida = '10/03/2019',
DataAlteracao = GETDATE(),
Ativo = 0
where Nome like'Jervison%'

select * from Funcionarios where Nome like '%son' --procura todos os nomes que terminam com 'son' 
select * from Funcionarios where Nome like 'je%'  --procura todos os nomes que começam com 'je'
select * from Funcionarios where Nome like '%e%'  --procura todos os nomes que possuem 'e'
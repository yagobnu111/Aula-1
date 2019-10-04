select 
gen.Nome as 'Genero',
art.Nome as 'Artista',
can.Nome as 'Cancao'
from Generos gen inner join Artistas art on gen.Id = art.GeneroId
				 inner join Cancoes can on art.Id = can.ArtistaId
order by can.Nome

select 
gen.Nome as 'Genero',
Count(art.Nome) as 'Quantidade Artistas'
from Generos gen inner join Artistas art 
on gen.Id = art.GeneroId
group by gen.Nome

select 
gen.Nome as 'Genero',
count(can.Nome) as 'Quantidades de Canções' 
from Generos gen inner join Artistas art on gen.Id = art.GeneroId
				 inner join Cancoes can on art.Id = can.ArtistaId
group by gen.Nome
			


create database Playlist
go
use Playlist

-- inserindo Generos
INSERT INTO Generos  VALUES ( 'Rock'	),( 'Rap'	),( 'Indie' ),( 'EDM'	)
-- inserindo Artistas
INSERT INTO Artistas ( GeneroId, Nome ) VALUES (1,'Queen'),
(1,'Johnny Cash'),
(1,'Arctic Monkeys'),
(2,'Eminem'),
(2,'Nas'),
(2,'Notorious B.I.G'),
(3,'Kodaline'),
(3,'Chet Faker'),
(4,'Kindrid'),
(4,'Deadmau5')
-- inserindo Canções
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (1,'Hammer to fall '       ) 
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (2,'Wayfaring stranger'    )
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (3,'Arabella'				)
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (4,'Renegade'				)
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (5,'Nas is like'			)
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (6,'Going back to Cali'	)
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (7,'All I want'			)
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (8,'Talk is cheap'			)
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (9,'Dynamia'			    )
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (10,'Strobe'				)
INSERT INTO Cancoes (ArtistaId, Nome) VALUES (10,'Monophobia'			)
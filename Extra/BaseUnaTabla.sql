Create Database UnTabla

use UnTabla

create table Jugador(
idJugador int identity(1,1),
Apellido varchar(50) not null,
Edad int not null,
constraint PK_idJugador PRIMARY KEY (idJugador))



insert into Jugador(Apellido,Edad)
values('Cortazar',30),
      ('Gomez',35),
	  ('Molina',25),
	  ('Hernandez',20)
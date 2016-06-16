use Peliculas;
go

create table Movies(CategoriaId int identity(1,1) primary key,
 Descripcion varchar(30) );

go
create table PeliculasDetalles(IdPelicula int identity(1,1) primary key,
 IdCategoria int,
 Titulo varchar(20),
 Sipnosis text,
 Calificacion varchar(2),
 Ano varchar(4),
 Idioma varchar(11) );




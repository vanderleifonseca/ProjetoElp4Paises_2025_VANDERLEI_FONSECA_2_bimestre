create table estados(
	cod ind not null identity(10,1) primary key,
	estado varchar(55) not null,
	sigla varchar(2) not null,
)
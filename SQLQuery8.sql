create table produtos(
	id int not null identity(10,1) primary key,
	produto varchar(55) not null,
	codigo varchar(15) not null,
	descricao varchar(255),
	preco decimal(10,2) not null,
	estoque int not null,
	fornecedor int not null,
	categoria int not null,
	obs text
)
create table ProdForn(
	id int not null identity(10,1) primary key,
	fornecedor varchar(55) not null,
	cnpj varchar(18) not null,
	ie varchar(15),
	im varchar(15),
	email varchar(55),
	telefone varchar(15),
	celular varchar(15),
	cep varchar(9) not null,
	endereco varchar(55) not null,
	numero int not null,
	complemento varchar(55),
	bairro varchar(55) not null,
	cidade int not null,
	estado int not null,
	pais int not null,
	obs text
)
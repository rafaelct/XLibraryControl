
--create database biblioteca;

use biblioteca;
drop table tbEmpLivros;
drop table tbLivros
drop table tbAlunos

create table tbAlunos (
ra int primary key,
nome varchar(100) not null,
ddd int not null,
telefone int not null,
email varchar(80) not null,
dataNascimento date
);

create table tbLivros (
codLivro int primary key,
titulo varchar(200) not null,
autor varchar(100) not null,
categoria varchar(100) not null,
editora varchar(100) not null
);

create table tbEmpLivros (
codEmpLivro int identity(1,1) primary key,
ra int foreign key references tbAlunos(ra),
codLivro int foreign key references tbLivros(codLivro),
dataRetirada date not null,
dataEntrega date
);

create index iAlunos on tbAlunos(ra);
create index iLivros on tbLivros(codLivro);

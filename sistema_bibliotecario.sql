/*drop database sistema_bibliotecario;*/
create database sistema_bibliotecario;
use sistema_bibliotecario;
create table roles(
	id int identity(1,1) primary key,
	name varchar(50),
	description varchar(200) null,
	state int default(1),
	created_at datetime,
	updated_at datetime
);

create table users(
	id int identity(1,1) primary key,
	name varchar(150),
	birthday date null,
	id_rol int,
	email varchar(100) unique,
	phone varchar(25) unique,
	carnet varchar(12) unique null,
	state int default(1),
	created_at datetime,
	updated_at datetime
	constraint fk_user_role foreign key(id_rol) references roles(id),
);

create table providers(
	id int identity(1,1) primary key,
	name varchar(100) unique,
	email varchar(100) unique null,
	phone varchar(20) unique,
	address varchar(300) null,
	state int default(1),
	created_at datetime,
	updated_at datetime
)

create table editorials(
	id int identity(1,1) primary key,
	name varchar(50) unique,
	state int default(1),
	created_at datetime,
	updated_at datetime
)

create table authors(
	id int identity(1,1) primary key,
	name varchar(50),
	birthday date null,
	pais varchar(60) null,
	state int default(1),
	created_at datetime,
	updated_at datetime
)

create table categories(
	id int identity(1,1) primary key,
	name varchar(50),
	state int default(1),
	created_at datetime,
	updated_at datetime
)

create table books(
	id int identity(1,1) primary key,
	name varchar(50),
	state int default(1),
	copies int,/*total de ejemplares del libro que hay en la biblioteca*/
	stock_min int,/*cantidad en la cual ya no se pueden prestar libros*/
	stock int,/*cantidad de libros disponibles*/
	release_date date null,/*fecha de lanzamiento del libro*/
	amount_pages int null,/*cantidad de paginas*/
	id_provider int,
	id_author int,
	id_categorie int,
	id_editorial int,
	created_at datetime,
	updated_at datetime,

	constraint fk_provider_book foreign key(id_provider) references providers(id),
	constraint fk_author_book foreign key(id_author) references authors(id),
	constraint fk_categorie_book foreign key(id_categorie) references categories(id),
	constraint fk_editorial_book foreign key(id_editorial) references editorials(id),
)

create table orders(
	id int identity(1,1) primary key,
	comentary varchar(300),
	state int default(1),
	id_user int,
	created_at datetime,
	updated_at datetime,

	constraint fk_orders_user foreign key(id_user) references users(id),
);

create table datail_orders(
	id int identity(1,1) primary key,
	state int default(1),
	id_order int,
	id_book int,
	created_at datetime,
	updated_at datetime,
	amount int,
	constraint fk_detailorders_order foreign key(id_order) references orders(id),
	constraint fk_detailorders_book foreign key(id_book) references books(id),
);

create table rervations(
	id int identity(1,1) primary key,
	comentary varchar(300) null,
	state int default(1),
	id_user int,
	id_book int,
	created_at datetime,
	updated_at datetime,

	constraint fk_reservation_user foreign key(id_user) references users(id),
	constraint fk_reservation_book foreign key(id_book) references books(id)
);


create table lends(
	id int identity(1,1) primary key,
	comentary varchar(300) null,
	state int default(1),
	id_user int,
	start_date datetime,
	end_date datetime,
	created_at datetime,
	updated_at datetime,

	constraint fk_lend_user foreign key(id_user) references users(id),
);

create table detail_lends(
	id int identity(1,1) primary key,
	state int default(1),
	id_lend int,
	id_book int,
	book_amount int,/*porque en el mismo prestamo puede llevar mas de un libro de el mismo libro, respetando siempre el max de tres.*/
	created_at datetime,
	updated_at datetime,

	constraint fk_detaillend_lend foreign key(id_lend) references lends(id),
	constraint fk_detaillend_book foreign key(id_book) references books(id),
);



create table penalizations( 
	id int identity(1,1) primary key,
	comentary varchar(300) null,
	state int default(1),
	id_lend int,
	start_date datetime,
	end_dates datetime,
	created_at datetime,
	updated_at datetime,

	constraint fk_penalization_lend foreign key(id_lend) references lends(id),
);

/*esta tabla contendra los precios con los cuales se calculara el monto del prestamo*/
create table prices(
	id int primary key identity(1,1),
	name varchar(100),
	price decimal,
	description varchar(300)
)

insert into prices values ('hour',0.80,'valor con el que se calculara el monto a cancelar si el prestamo es por menos de 8 horas');
insert into prices values ('day',1.99,'valor con el que se calculara el monto a cancelar si el prestamo es por mas de 8 horas osea un dia y menos de 7 doas ');
insert into prices values ('week',8.99,'valor con el que se calculara el monto a cancelar si el prestamo es mas de una semana');

/**************************************************************************************************************************************/

insert into roles(name, description, created_at, updated_at) values('admin','usuario con el control de todas las configuraciones posibles del sistema','2019-10-31 07:44:15','2019-10-31 07:44:15');
insert into roles(name, description, created_at, updated_at) values('user','usuario bibliotecario este puede autorizar prestamos, realziar penalizaciones etc...','2019-10-31 07:44:16','2019-10-31 07:44:16');
insert into roles(name, description, created_at, updated_at) values('client','usuario con la capacidad de realizar prestamos','2019-10-31 07:44:17','2019-10-31 07:44:17');

/**************************************************************************************************************************************/

/*REVISAR ANTES NO SE QUE PEDO XD*/
insert into users(name,id_rol,email,phone,carnet,created_at,updated_at) values('benjamin ramirez',1,'benjamin.ramirez17@itca.edu.sv','7458-5845','AD-000000001','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into users(name,id_rol,email,phone,carnet,created_at,updated_at) values('alejandra rene',1,'alejandra.rene17@itca.edu.sv','7458-5846','AD-000000002','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into users(name,id_rol,email,phone,carnet,created_at,updated_at) values('josue amaya',1,'josue.amaya17@itca.edu.sv','7458-5847','AD-000000003','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into users(name,id_rol,email,phone,carnet,created_at,updated_at) values('karla ferrer',2,'karla.ferrer@itca.edu.sv','7458-5848','US-000000004','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into users(name,id_rol,email,phone,carnet,created_at,updated_at) values('elvis martinez',3,'elvis.martinez@itca.edu.sv','7458-5849','CL-000000005','2019-10-31 07:44:17','2019-10-31 07:44:17');


/************************************************************************************************************************************/

insert into providers(name,email,phone,address,created_at,updated_at) values('La doncella','clientes@doncella.com','7463-4512','colonia la rabida 245 b7','2019-10-31 08:44:17','2019-10-31 07:44:17');
insert into providers(name,email,phone,address,created_at,updated_at) values('The best','clientes@bestprov.com','7473-8574','colonia cucumacayn','2019-10-31 08:44:16','2019-10-31 07:44:13');

delete from users;
/**********************************************************************************************************************/

insert into editorials(name, created_at, updated_at) values('Don quijote','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into editorials(name, created_at, updated_at) values('Los 3 Hermanos','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into editorials(name, created_at, updated_at) values('La ceiba','2019-10-31 07:44:17','2019-10-31 07:44:17');

/**********************************************************************************************************************/

insert into authors(name,birthday,pais,created_at,updated_at) values('Alfredo Espino','1974-05-09','El Salvador','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into authors(name,birthday,pais,created_at,updated_at) values('Ana Frank','1930-05-15','Alemania','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into authors(name,birthday,pais,created_at,updated_at) values('Gabriel Garcia Marquez','1950-02-19','Colombia','2019-10-31 07:44:17','2019-10-31 07:44:17');

/**********************************************************************************************************************/

insert into categories(name, created_at,updated_at) values('Infantiles','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('drama','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('novelas','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('suspenso','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('terror','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('fantasia','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('cienciaficcion','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('aventuras','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('romance','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('ciencia','2019-10-31 07:44:17','2019-10-31 07:44:17');
insert into categories(name, created_at,updated_at) values('educacion','2019-10-31 07:44:17','2019-10-31 07:44:17');


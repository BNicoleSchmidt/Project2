IF OBJECT_ID('Genre', 'U') IS NOT NULL DROP TABLE Genre;
IF OBJECT_ID('Contact_Method', 'U') IS NOT NULL DROP TABLE Contact_Method;
IF OBJECT_ID('Subscription', 'U') IS NOT NULL DROP TABLE Subscription;
IF OBJECT_ID('Movie', 'U') IS NOT NULL DROP TABLE Movie;
IF OBJECT_ID('Member', 'U') IS NOT NULL DROP TABLE Member;
IF OBJECT_ID('Vendor', 'U') IS NOT NULL DROP TABLE Vendor;
IF OBJECT_ID('Rental', 'U') IS NOT NULL DROP TABLE Rental;

create table Genre ( id int not null identity primary key, name varchar(30) not null);
create table Contact_Method (id int not null identity primary key, name varchar(30) not null);
create table Subscription ( id int not null identity primary key, name varchar(20) not null, cost money);
create table Movie ( movie_number int not null identity primary key, movie_title varchar(50) not null, description varchar(255) not null, movie_year_made smallint not null, genre_id smallint not null, movie_rating char(5) not null, media_type varchar(10) not null, movie_retail_cost money not null, copies_on_hand smallint null, image varchar(30) null, trailer varchar(30) null);
create table Member ( number int not null identity primary key, joindate datetime not null, firstname char(15) not null, lastname char(25) not null, address char(30) not null, city char(20) not null, state char(2) not null, zipcode char(5) not null, phone char(10) not null, member_status char(1) not null, login_name varchar(20) not null, password varchar(20) not null, email varchar(20) not null, contact_method int null, subscription_id int not null, photo varchar(30) null, is_admin bit not null);
create table Vendor ( id int not null identity primary key, name varchar(30) not null);
create table Rental ( id int not null identity primary key, movie_number int not null, member_number int not null, media_checkout_date datetime not null, media_return_date datetime null);

insert into Genre (name) values ('Childrens'),('Comedy'),('Horror'),('Drama'),('Action'),('Classic'),('Sci-fi'),('Documentary'),('Romance'),('Musical'),('Mystery');
insert into Contact_Method (name) values ('Phone'), ('Email');
insert into Subscription (name, cost) values ('Standard', 10),('Plus', 15);
insert into Movie (movie_title, description, movie_year_made, genre_id, movie_rating, media_type, movie_retail_cost, copies_on_hand) values
	('Rocky Horror Picture Show', '1975 horror comedy musical starring Tim Curry', 1975, 10, 'R', 'DVD', 15, 8),
	('Hitchhiker''s Guide to the Galaxy', 'Space comedy', 2005, 7, 'PG', 'DVD', 15, 2);
insert into Member (joindate, firstname, lastname, address, city, state, zipcode, phone, member_status, login_name, password, email, contact_method, subscription_id, is_admin) values
	('2016-11-11', 'Nicole', 'Schmidt', '123 Any Street', 'Nowhere', 'NO', '12345', '1234567890', 'A', 'nicole', 'supersecret', 'n@s.co', 2, 1, 1),
	('2016-11-12', 'Tim', 'Stuart', '456 Some Road', 'Awayfromhere', 'FU', '98765', '0987654321', 'I', 'tim', 'supersecret', 't@s.uk', 1, 2, 1),
	('2010-01-01', 'John', 'Smith', '5 Street Lane', 'Citytown', 'ST', '87654', '7396748623', 'A', 'john', 'supersecret1', 'j@s.gov', 1, 1, 0);
insert into Rental (movie_number, member_number, media_checkout_date, media_return_date) values
	(1, 1, '2016-11-11', '2016-11-12'),
	(2, 2, '2016-11-12', null);
IF OBJECT_ID('Genre', 'U') IS NOT NULL DROP TABLE Genre;
IF OBJECT_ID('Contact_Method', 'U') IS NOT NULL DROP TABLE Contact_Method;
IF OBJECT_ID('Subscription', 'U') IS NOT NULL DROP TABLE Subscription;
IF OBJECT_ID('Movie', 'U') IS NOT NULL DROP TABLE Movie;
IF OBJECT_ID('Member', 'U') IS NOT NULL DROP TABLE Member;
IF OBJECT_ID('Vendor', 'U') IS NOT NULL DROP TABLE Vendor;
IF OBJECT_ID('Rental', 'U') IS NOT NULL DROP TABLE Rental;

create table Genre ( id int not null identity primary key, name varchar(30) not null unique);
create table Contact_Method (id int not null identity primary key, name varchar(30) not null unique);
create table Subscription ( id int not null identity primary key, name varchar(20) not null, cost money);
create table Movie ( id int not null identity primary key, movie_title varchar(50) not null, description varchar(2000) not null, movie_year_made smallint not null, genre_id smallint not null, movie_rating char(10) not null, media_type varchar(10) not null, movie_retail_cost money not null, copies_on_hand smallint null, image varchar(50) null, trailer varchar(100) null);
create table Member ( id int not null identity primary key, joindate datetime not null, firstname char(15) not null, lastname char(25) not null, address char(30) not null, city char(20) not null, state char(2) not null, zipcode char(5) not null, phone char(10) not null, member_status char(1) not null, login_name varchar(20) not null unique, password varchar(20) not null, email varchar(40) not null, contact_method int null, subscription_id int not null, photo varchar(50) null, is_admin bit not null);
create table Vendor ( id int not null identity primary key, name varchar(30) not null unique);
create table Rental ( id int not null identity primary key, movie_number int not null, member_number int not null, media_checkout_date datetime not null, media_return_date datetime null);

insert into Genre (name) values ('Childrens'),('Comedy'),('Horror'),('Drama'),('Action'),('Classic'),('Sci-fi'),('Documentary'),('Romance'),('Musical'),('Mystery'),('Fantasy');
insert into Contact_Method (name) values ('Phone'),('Email'),('Facebook'),('Twitter');
insert into Subscription (name, cost) values ('Standard', 10),('Plus', 15),('Trial', 0),('Student', 5);
insert into Movie (movie_title, description, movie_year_made, genre_id, movie_rating, media_type, movie_retail_cost, copies_on_hand, image, trailer) values
	('Rocky Horror Picture Show', '1975 horror comedy musical starring Tim Curry', 1975, 10, 'R', 'DVD', 15, 8, 'RockyHorror.jpg', 'Pgx1QZFNMz8'),
	('Hitchhiker''s Guide to the Galaxy', 'Arthur Dent (Martin Freeman) is trying to prevent his house from being bulldozed when his friend Ford Prefect (Mos Def) whisks him into outer space. It turns out Ford is an alien who has just saved Arthur from Earth''s total annihilation. Ford introduces Arthur to his myriad friends, including many-headed President Zaphod Beeblebrox (Sam Rockwell) and sexy refugee Trillian (Zooey Deschanel). Arthur makes his way across the stars while seeking the meaning of life, or something close to it.', 2005, 7, 'PG', 'DVD', 15, 2, 'Hitchhikers.jpg', 'eLdiWe_HJv4'),
	('The Princess Bride', 'While home sick in bed, a young boy''s grandfather reads him a story called The Princess Bride.', 1987, 11, 'PG', 'VHS', 2.99, 8, 'PrincessBride.jpeg', 'mtj_Ix5IUo8'),
	('Kung Fury', 'In 1985, Kung Fury, the toughest martial artist cop in Miami, goes back in time to kill the worst criminal of all time - kung fuhrer Hitler.', 2015, 4, 'Unrated', 'Digital', 4.99, 0, 'KungFury.jpeg', '5PwtSA1aKG4'),
	('Star Wars: Episode IV - A New Hope', 'Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a wookiee and two droids to save the galaxy from the Empire''s world-destroying battle-station, while also attempting to rescue Princess Leia from the evil Darth Vader.', 1977, 6, 'PG', 'VHS', 14.99, 20, 'StarWars.jpeg', '1g3_CFmnU7k'),
	('The Godfather', 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', 1972, 4, 'R', 'VHS', 2.99, 27, 'Godfather.jpeg', '5DO-nDW43Ik');
insert into Member (joindate, firstname, lastname, address, city, state, zipcode, phone, member_status, login_name, password, email, contact_method, subscription_id, is_admin) values
	('2016-11-11', 'Nicole', 'Schmidt', '123 Any Street', 'Nowhere', 'NO', '12345', '1234567890', 'A', 'nicole', 'supersecret', 'n@s.co', 2, 1, 1),
	('2016-11-12', 'Tim', 'Stuart', '456 Some Road', 'Awayfromhere', 'FU', '98765', '0987654321', 'I', 'tim', 'supersecret', 't@s.uk', 1, 2, 1),
	('2010-01-01', 'John', 'Smith', '5 Street Lane', 'Citytown', 'ST', '87654', '7396748623', 'A', 'john', 'supersecret', 'j@s.gov', 1, 1, 0);
insert into Rental (movie_number, member_number, media_checkout_date, media_return_date) values
	(1, 1, '2016-11-11', '2016-11-12'),
	(2, 2, '2016-11-12', null);
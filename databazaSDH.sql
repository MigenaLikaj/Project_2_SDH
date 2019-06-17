create database project2;

use project2;
create table project2sdh (

idF int not null AUTO_INCREMENT,
Name varchar(45) not null,
Surname varchar(45) not null,
Email varchar(45) not null,
Degree varchar(45) not null,
Salary varchar(45),
Username varchar(45),
Password varchar(30) not null,
primary key (idF));

INSERT INTO project2sdh VALUES(1, 'Tiara','Gashi','tiaragashi@hotmail.com','Profesor', '600','Tiara','Tiara123');
INSERT INTO project2sdh VALUES(2, 'Megi','Likaj','migenalikaj@hotmail.com','Docent', '500','MegiLikaj','Megi123');
INSERT INTO project2sdh VALUES(3, 'Rudina','Gjikokaj','rudinagjikokaj@hotmail.com','Profesor', '600','Rudina','Rudina123');
INSERT INTO project2sdh VALUES(4, 'Besa','Gashi','besagashi@hotmail.com','Docent', '500','Besa','Besa123');
INSERT INTO project2sdh VALUES(5, 'Uranik','Gashi','uranikgashi@hotmail.com','Profesor', '600','Uranik','Uranik123');

select * from project2sdh;

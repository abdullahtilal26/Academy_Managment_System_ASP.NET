create database korean_db_asp
use korean_db_asp
-----------------------------------------------------------------------------------
create table userr_asp
(
Id int identity (1,1),
Name varchar(50),
Pwd varchar(50)
)
insert into userr_asp values('Abdullah Tilal','123')
select * from userr_asp
truncate table userr_asp
-----------------------------------------------------------------------------------
create table Programs_asp
(
Id int identity(1,1),
Dat varchar(50),
Course varchar(50),
Duration varchar(50),
Mon_fee varchar(50),
Add_fee varchar(50),
Teacher varchar(50),
Timing varchar(50)
)
select * from Programs_asp
truncate table programs_asp
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
----insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')
--insert into Programs_asp values('23/09/2015','chnn','1 year','4500','3500','sir arsalan','7-8')

------------------------------------------------------------------------------------
create table std_asp
(
Id int identity(1,1),
Dat varchar(50),
Name varchar(50),
F_name varchar(50),
Addres varchar(50),
Img varchar(50),
Quali varchar(50),
Course varchar(50),
Advnce varchar(50),
Cell varchar(50),
leav_dat varchar(50),
Remarks varchar(50)
)
select * from std_asp
------------------------------------------------------------------------------------
create table fee
(
fee_id int identity(1,1),
std_id int, 
dat varchar(50),
Name varchar(50),
F_name varchar(50),
Course varchar(50),
Advnce varchar(50),
amount int
)

select * from fee


------------------------------------------------------------------------------------
select * from userr_asp
select * from Programs_asp
select * from std_asp
select * from fee
------------------------------------------------------------------------------------
truncate table userr_asp
truncate table Programs_asp
truncate table std_asp

---------------------------------------------------------------------------------
backup database korean_db_asp to disk = 'D:\ASP FINAL PROJECT 8\asp final project\asp final project\backup\backuptest.bak'
restore database korean_db_asp from disk = 'D:\ASP FINAL PROJECT 9\asp final project\asp final project\backup\backuptest.bak'
---DROP DATABASE korean_db_asp
drop database korean_db_asp
use master
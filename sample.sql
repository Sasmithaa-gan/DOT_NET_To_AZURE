create database project
 create database sample

 create table basic1(
 id int identity,
 emp_name nvarchar(20),
 emp_id int primary key ,
 email nvarchar(20),
 mobile nvarchar(20),
 address nvarchar(20)
 )
 
 create table education(
 id int primary key identity,
 empid int foreign key references basic1(emp_id),
 Grade_10_percentage nvarchar(20),
 Grade_10_yop int
 )

 create table experience
 (id int primary key identity,
 empid int foreign key references basic1(emp_id),
 yop nvarchar(20)
 )




 select * from basic1
 select * from education
 select * from experience



 create table login(
 name varchar primary key,
 password nvarchar)
 select * from login



 create table Image
 (ImageID int primary key identity,
 Title varchar(20),
 ImagePath varchar(max))

 select * from Image

 create table leave(
id int primary key identity,
empid int foreign key references basic1(emp_id),
typeofleave varchar(250),
startdate date,
enddate date,
comments nvarchar(250))


select * from basic1
select * from leave

create table leaveapp
(id int primary key identity,
empid int foreign key references basic1(emp_id),
typeofleave varchar(250),
startdate date,
enddate date,
comments nvarchar(250),
ApplyforLeave nvarchar(50)
)

select * from leaveapp
drop table leaveapp



create table sample
(id int not null primary key identity(1,1),
name nvarchar(max)
)

select * from sample
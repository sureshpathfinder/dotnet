create database ado;

use ado;

create table emp(eid int primary key,ename varchar(10),salary int);

insert into emp values(1,'Sunil',12000);

insert into emp values(2,'Dinesh',12000);
insert into emp values(3,'Ram',12000);
insert into emp values(4,'Arun',12000);
insert into emp values(5,'Jaya',12000);
insert into emp values(5,'Jaya',12000);


update emp set salary=23000 where eid=2;

delete from emp where eid=4

select * from emp

select * from emp where salary>12000

select sum(salary) from emp

select count(salary) from emp


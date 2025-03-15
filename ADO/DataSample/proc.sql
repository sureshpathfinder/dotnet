create procedure GetEmployees as
select * from emp


create procedure UpdateEmployee(@eid int,@sal numeric(10,2)) as
update emp set sal=@sal where empno=@eid




create database EmployeeManagementDB;
go

use EmployeeManagementDB;
go
drop table employee_details;

create table employee_details
(
    empno int primary key,
    empname varchar(50) not null,
    empsal numeric(10,2) check(empsal >= 25000),
    emptype char(1) check(emptype in ('F','P'))
);
go

-- INSERT PROCEDURE
create procedure sp_insertemployee
(
    @empname varchar(50),
    @empsal numeric(10,2),
    @emptype char(1)
)
as
begin
    declare @empno int;

    select @empno = isnull(max(empno),0) + 1
    from employee_details;

    insert into employee_details
    values(@empno,@empname,@empsal,@emptype);
end
go


create procedure sp_updatesalary
(
    @empid int,
    @updatedsalary numeric(10,2) output
)
as
begin
    update employee_details
    set empsal = empsal + 100
    where empno = @empid;

    select @updatedsalary = empsal
    from employee_details
    where empno = @empid;
end
go

select * from employee_details;


use EmployeeManagementDB;
go

create user [infics\kaviranjanis]
for login [infics\kaviranjanis];
go

alter role db_owner
add member [infics\kaviranjanis];
go
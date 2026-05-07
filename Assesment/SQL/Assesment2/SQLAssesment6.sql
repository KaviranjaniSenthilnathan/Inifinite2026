use Assignment2

--1.  Write a query to display your birthday( day of week)
	select datename(weekday, cast('2002-04-27' as date)) as birthday_day;

--2.  Write a query to display your age in days
	select datediff(day, cast('2002-04-27' as date), getdate()) as age_in_days;

--3. Write a query to display all employees information those who joined before 5 years in the current month
 
select empno, ename, hiredate
from emp
where hiredate < dateadd(year, -5, getdate())
and month(hiredate) = month(getdate());

--4.Create table Employee with empno, ename, sal, doj columns or use your emp table and perform the following operations in a single transaction
 
begin transaction;
--	a. First insert 3 rows 
 
insert into emp values (8431, 'Ranjan', 'clerk', null, getdate(), 1000, null, 20);
insert into emp values (8432, 'Balu', 'cler', null, getdate(), 2000, null, 20);
insert into emp values (8433, 'Rika', 'Manager', null, getdate(), 3000, null, 20);
 
 --	b. Update the second row sal with 15% increment 
update emp
set sal = sal * 1.15
where empno = 9002; 
save transaction sp1;
 
 --  c. Delete first row
delete from emp
where empno = 9001;

--  After completing above all actions, recall the deleted row without losing increment of second row
rollback transaction sp1;
commit;

--5. Create a user defined function calculate Bonus for all employees of a given dept using following conditions:
go

create function calculate_bonus (@deptno int, @sal int)
returns decimal(10,2)
as
begin
    declare @bonus decimal(10,2);
    -- a. For Deptno 10 employees 15% of sal as bonus.
    if @deptno = 10
        set @bonus = @sal * 0.15;
    -- b. For Deptno 20 employees 20% of sal as bonus 
    else if @deptno = 20
        set @bonus = @sal * 0.20;
    -- c. For Others employees 5%of sal as bonus
    else
        set @bonus = @sal * 0.05;

    return @bonus;
end;

go
-- to execute
select empno, ename, deptno, sal,
dbo.calculate_bonus(deptno, sal) as bonus
from emp;

go

--6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500 (use emp table)

create procedure update_sales_salary
as
begin
    update emp
    set sal = sal + 500
    where deptno = 30
    and sal < 1500;
end;

go
-- to execute
exec update_sales_salary;

go

select * from emp

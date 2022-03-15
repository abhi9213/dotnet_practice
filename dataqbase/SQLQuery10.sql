create database abhi

use abhi

create table worker(worker_id int,first_name varchar(20),last_name varchar(20)
,salary int,joining_date datetime,department varchar(25))

select * from worker

create table bonus(worker_refid int,bonus_date datetime,bonus_ammount int)

select * from bonus

update   bonus set bonus_date='2016-02-20'  where worker_refid=1

update   bonus set bonus_date='2016-06-11'  where worker_refid=2

update   bonus set bonus_date='2016-02-20'  where worker_refid=3


update   bonus set bonus_ammount=5000  where worker_refid=1

update   bonus set bonus_ammount=3000  where worker_refid=2

update   bonus set bonus_ammount=4000  where worker_refid=3

update   bonus set bonus_ammount=4500  where worker_refid=1 and bonus_date='2016-02-20'

update   bonus set bonus_ammount=3500  where worker_refid=2 and bonus_date='2016-06-11'


select * from title


--ans 1
select first_name  as WORKER_NAME  from worker

--ans 2
select upper(first_name)  as WORKER_NAME  from worker

--ans 3
select distinct department from worker

--ans 4
select SUBSTRING(first_name,1,3) from worker

--ans 5  not working
select INSTR(first_name,binary'a') from worker where first_name='amitabh'

--ans 6
select rtrim(first_name) from worker

--ans 7
select ltrim(department) from worker

--ans 8 length is not a recognised fun// not working
select distinct length(department) from worker

--ans 9
select replace(first_name,'a','A') from worker

--ans 10
select concat(first_name,' ',last_name)as complete_name from worker

--ans 11
select * from worker order by first_name

--ans-12

select * from worker  order by first_name , department desc
select * from worker

--ans 13
select * from worker where first_name='vipul' or first_name='satish'

--ans 14


select * from worker where first_name not in('vipul','satish')

--ans 15
select * from worker where department='admin'

--ans-16
select * from worker where first_name like'%a%'

--ans 17

select * from worker where first_name like'%a'

--ans-18
select * from worker where first_name like'_____h'

--ans 19

select * from worker where salary between 100000 and 500000

--ans 20

select * from worker where  year (joining_date)=2014 and month(joining_date)=2

--ans 21
select count(department) from worker where department='admin'

select count(*) from worker where department='admin'

--ans 22
select first_name from worker where salary>=50000 and salary<=100000 




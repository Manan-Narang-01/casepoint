
--1
SELECT *FROM t_employee WHERE c_name LIKE 'A%';

--2

SELECT *FROM t_employee WHERE c_name LIKE '%a%';

--3

SELECT  AVG(c_salary),COUNT(c_dept_id) 
FROM t_employee GROUP BY c_dept_id;

--4

SELECT  COUNT(c_dept_id) AS c_empolyee_count 
FROM t_employee 
GROUP BY c_dept_id 
HAVING  COUNT(c_dept_id) > 1;

--5

SELECT *
FROM t_employee 
where c_hire_date BETWEEN '2019-01-01' AND '2020-12-31' ;
--6

SELECT *
FROM t_employee 
WHERE c_dept_id IN (2,4,5) ;

--7

SELECT DISTINCT(c_salary)
FROM t_employee ;

--8

ALTER TABLE t_employee ADD COLUMN c_email varchar(50);

--9

ALTER TABLE t_employee ADD CONSTRAINT unique_email UNIQUE(c_email);

--10

SELECT *
FROM t_employee 
ORDER BY c_salary DESC 
LIMIT 3;

--11

UPDATE t_employee
SET c_salary=c_salary*1.10
WHERE c_name='Alice';

--12

INSERT INTO t_employee(c_name,c_dept_id,c_salary,c_hire_date,c_email)VALUES
('Ivy',1,90000,'2017-04-25','ivy@gamil.com');

--13

ALTER TABLE t_employee ADD COLUMN c_job_title varchar(50) ;

--14

SELECT c_name AS Employee_Name  FROM t_employee ;

--15

SELECT c_name,c_salary
FROM t_employee 
where c_salary BETWEEN 48000 AND 60000  ;

--16

SELECT c_dept_id,SUM(c_salary), COUNT(c_dept_id) AS c_empolyee_count 
FROM t_employee 
GROUP BY c_dept_id 
HAVING  SUM(c_salary) > 100000;

--17

SELECT DISTINCT(c_dept_id)
FROM t_employee ;

--18

SELECT *FROM t_employee WHERE c_name LIKE '%e';

--19

SELECT *FROM t_employee WHERE c_job_title IS NULL;

--20

ALTER TABLE t_employee RENAME COLUMN c_name TO full_name;

--21

SELECT c_dept_id,AVG(c_salary), COUNT(c_dept_id) AS c_empolyee_count 
FROM t_employee 
GROUP BY c_dept_id 
HAVING  SUM(c_dept_id) > 1;

--22

SELECT *
FROM t_employee 
ORDER BY c_hire_date DESC 
LIMIT 5;

--23

INSERT INTO t_employee(full_name,c_dept_id,c_salary,c_hire_date,c_email,c_job_title)VALUES
('Envy',2,65000,'2020-02-20','envy@gamil.com','Employee');

--24
SELECT *
FROM t_employee 
WHERE c_salary NOT IN (45000,50000) ;

--25


SELECT *
FROM t_employee 
WHERE full_name IN ('Alice','Eve','Grace') ;




SELECT *FROM t_employee ;

SELECT *FROM t_employee WHERE c_name LIKE 'A%';

SELECT *FROM t_employee WHERE c_name LIKE '%a%';

SELECT  AVG(c_salary),COUNT(c_dept_id) 
FROM t_employee GROUP BY c_dept_id;

SELECT c_dept_id, COUNT(c_dept_id) AS c_empolyee_count 
FROM t_employee 
GROUP BY c_dept_id 
HAVING  COUNT(c_dept_id) > 1;

SELECT *
FROM t_employee 
where c_hire_date BETWEEN '2019-01-01' AND '2020-12-31' ;

SELECT *
FROM t_employee 
WHERE c_dept_id IN (2,4,5) ;

SELECT DISTINCT(c_salary)
FROM t_employee ;

ALTER TABLE t_employee ADD COLUMN c_email varchar(50);

ALTER TABLE t_employee ADD CONSTRAINT unique_email UNIQUE(c_email);

SELECT *
FROM t_employee 
ORDER BY c_salary DESC 
LIMIT 3;

UPDATE t_employee
SET c_salary=c_salary*1.10
WHERE c_name='Alice';


INSERT INTO t_employee(c_name,c_dept_id,c_salary,c_hire_date,c_email)VALUES
('Ivy',1,90000,'2017-04-25','ivy@gamil.com');


ALTER TABLE t_employee ADD COLUMN c_job_title varchar(50) ;


SELECT c_name AS Employee_Name  FROM t_employee ;

SELECT c_name,c_salary
FROM t_employee 
where c_salary BETWEEN 48000 AND 60000  ;


SELECT c_dept_id,SUM(c_salary), COUNT(c_dept_id) AS c_empolyee_count 
FROM t_employee 
GROUP BY c_dept_id 
HAVING  SUM(c_salary) > 100000;



SELECT DISTINCT(c_dept_id)
FROM t_employee ;

SELECT *FROM t_employee WHERE c_name LIKE '%e';

SELECT *FROM t_employee WHERE c_job_title IS NULL;

ALTER TABLE t_employee RENAME COLUMN c_name TO full_name;


SELECT c_dept_id,AVG(c_salary), COUNT(c_dept_id) AS c_empolyee_count 
FROM t_employee 
GROUP BY c_dept_id 
HAVING  SUM(c_dept_id) > 1;

SELECT *
FROM t_employee 
ORDER BY c_hire_date DESC 
LIMIT 5;


INSERT INTO t_employee(full_name,c_dept_id,c_salary,c_hire_date,c_email,c_job_title)VALUES
('Envy',2,65000,'2020-02-20','envy@gamil.com','Employee');


SELECT *
FROM t_employee 
WHERE c_salary NOT IN (45000,50000) ;

SELECT *
FROM t_employee 
WHERE full_name IN ('Alice','Eve','Grace') ;




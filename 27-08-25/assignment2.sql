CREATE TABLE t_employees (
    c_eid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    c_name VARCHAR(100) NOT NULL,
    c_deptid INT NOT NULL,
    c_salary DECIMAL(10,2) NOT NULL,
    c_hiredate DATE NOT NULL,
    CONSTRAINT fk_depts_employees FOREIGN KEY(c_deptid) REFERENCES t_depts(c_did)
);


CREATE TABLE t_depts(
c_did INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_name VARCHAR(50)
);

INSERT INTO t_employees (c_name, c_deptid, c_salary, c_hiredate) VALUES
('Alice', 1, 50000.00, '2020-01-15'),
('Bob', 2, 60000.00, '2019-03-10'),
('Carol', 3, 45000.00, '2021-07-23'),
('David', 2, 70000.00, '2018-05-22'),
('Eve', 4, 55000.00, '2017-08-19'),
('Frank', 5, 48000.00, '2019-11-30'),
('Grace', 5, 50000.00, '2021-01-01'),
('Hannah', 5, 52000.00, '2020-02-17');


--1
ALTER TABLE t_employees ADD COLUMN c_email VARCHAR(100);

--2
ALTER TABLE t_employees ALTER COLUMN c_name TYPE VARCHAR(100);

--3
ALTER TABLE t_employees RENAME c_deptid TO c_dept_id;

--4
ALTER TABLE t_employees DROP COLUMN c_hiredate;

--5
ALTER TABLE t_employees ALTER COLUMN c_salary SET DEFAULT 0;

--6
ALTER TABLE t_employees ADD CONSTRAINT unique_email_id UNIQUE(c_email);

--7
ALTER TABLE t_employees DROP CONSTRAINT unique_email_id;

--8
ALTER TABLE t_employees ADD CONSTRAINT fk_depts_employees FOREIGN KEY(c_dept_id) REFERENCES t_depts(c_did);

--9
ALTER TABLE t_employees DROP CONSTRAINT fk_depts_employees ;

--10

ALTER TABLE t_employees ALTER COLUMN c_name SET NOT NULL;

--11

UPDATE t_employees
SET c_salary=55000	
WHERE c_name='Alice';

--12
UPDATE t_employees
SET c_salary=c_salary*1.05;

--13
UPDATE t_employees
SET c_hiredate='2021-01-01'	
WHERE c_salary <50000;

--14

UPDATE t_employees e
SET c_deptid = d.c_did
FROM t_department d
WHERE e.c_dname = d.c_dname;

--15
UPDATE t_employees
SET c_hiredate=	NULL
WHERE c_hiredate <'2018-01-01';

--16

UPDATE t_employees
SET c_salary=c_salary*1.10
WHERE c_salary<(SELECT AVG(c_salary) FROM t_employees);

--17

ALTER TABLE t_employees RENAME  TO t_staff;

--18
ALTER TABLE t_stafft_staff RENAME fk_depts_employees  TO fk_depts_emp;

--19
ALTER TABLE t_staff RENAME t_employee_c_eid  TO t_employee_c_eid_seq;

--20
DELETE FROM t_staff WHERE c_name='David';

--21
DELETE FROM t_staff WHERE c_dept_id=4;

--22
DELETE FROM t_staff;

--23
DELETE FROM t_staff
WHERE c_dept_id NOT IN (SELECT c_did FROM t_depts);

--24
DELETE FROM t_staff
WHERE c_salary<(SELECT AVG(c_salary) FROM t_staff);

--25
DROP TABLE t_staff;

--part 2

--1 BASIC QUERIES:-
--1
SELECT *FROM t_staff;

--2
SELECT *FROM t_staff WHERE c_salary>50000;

--3
SELECT *FROM t_staff WHERE c_dept_id=2;

--4
SELECT *FROM t_staff WHERE c_hiredate<'2020-01-01';

--5
SELECT *FROM t_staff WHERE c_salary=(SELECT c_salary FROM t_staff );

--6
SELECT *FROM t_staff WHERE c_name LIKE 'A%';

--7
SELECT *FROM t_staff WHERE c_salary BETWEEN 45000 TO 60000;

--8
SELECT *FROM t_staff WHERE c_hiredate > '2021-01-01' AND c_hiredate < '2022-01-01';

--9
SELECT *FROM t_staff WHERE c_salary=>(SELECT AVG(c_salary) FROM t_staff );

--10
SELECT *FROM t_staff WHERE c_hiredate < CURRENT_DATE - INTERVAL '5 years' ;

--11
SELECT *FROM t_staff WHERE TO_CHAR(c_hiredate,'DAY') ILIKE "Monday%" ;
	
--12

SELECT TO_CHAR(c_hiredate,'MONTH') FROM t_staff;

--2 AGGREGATIONS:-

--1
SELECT COUNT(*) FROM t_staff;

--2 
SELECT AVG(c_salary) FROM t_staff;

--3
SELECT MAX(c_salary) FROM t_staff;

--4
SELECT MIN(c_salary) FROM t_staff;

--5
SELECT SUM(c_salary) FROM t_staff WHERE c_dept_id=5;

--6
SELECT SUM(c_salary) FROM t_staff WHERE c_hiredate<'2020-01-01';

--7
SELECT MAX(c_salary) FROM t_staff WHERE c_salary !=(SELECT MAX(c_salary) FROM t_staff );

--3 GROUPING

--1
SELECT SUM(c_salary),COUNT(*) FROM t_staff GROUP BY c_dept_id;

--2
SELECT COUNT(c_eid) FROM t_staff GROUP BY c_dept_id;

--3
SELECT MAX(c_salary),FROM t_staff GROUP BY c_dept_id;

--4
SELECT * FROM t_staff ORDER BY c_hiredate LIMIT 1 ;

--5

SELECT * FROM t_staff ORDER BY c_salary DESC ;

--6

SELECT * FROM t_staff ORDER BY c_salary>(SELECT AVG(c_salary FROM t_staff GROUP BY c_dept_id) ;



-- Conditional Operations:

--1

SELECT * FROM t_staff WHERE c_hiredate BETWEEN '2021-01-01' AND '2022-01-01' AND c_salary>60000;

--2
SELECT * FROM t_staff WHERE c_hiredate BETWEEN '2021-01-01' AND '2022-01-01' AND c_salary<(SELECT AVG(c_salary) FROM t_staff);




CREATE TABLE t_dept(
c_deptid SERIAL PRIMARY KEY,
c_deptname VARCHAR(50),
c_city VARCHAR(50) NOT NULL
);



CREATE TABLE t_emp(
c_empid SERIAL PRIMARY KEY,
c_name VARCHAR(50) NOT NULL,
c_desig VARCHAR(50) NOT NULL,
c_salary DECIMAL(10,2) ,
c_hiredate DATE  DEFAULT CURRENT_DATE,
c_mgrno INT NOT NULL,
c_deptid INT NOT NULL,
c_city VARCHAR(50) NOT NULL,
c_email VARCHAR(50) NOT NULL UNIQUE,
 FOREIGN KEY (c_mgrno) REFERENCES t_emp(c_empid),
 FOREIGN KEY (c_deptid) REFERENCES t_dept(c_deptid),
 CONSTRAINT check_value CHECK(c_salary>0)
);



INSERT INTO t_dept(c_deptname,c_city)VALUES
('Hr','Mumbai'),
('Finance','Delhi'),
('It','Chennai'),
('Marketing','Kolkata');



INSERT INTO t_emp (c_name, c_desig, c_salary, c_hiredate, c_mgrno, c_deptid, c_city, c_email)
VALUES 
('Rajesh Kumar', 'Manager', 90000.00, '2023-01-01', NULL, 1, 'Mumbai', 'Rajesh.kumar@example.com'),
('Sita Sharma', 'Analyst', 70000.00, '2023-05-10', 1, 2, 'Delhi', 'Sita.sharma@example.com'),
('Anil Mehra', 'Developer', 60000.00, '2023-03-15', 1, 3, 'Chennai', 'Anil.mehra@example.com'),
('Priya Nair', 'Executive', 50000.00, '2023-07-25', 2, 4, 'Kolkata', 'Priya.nair@example.com'),
('Mohan Gupta', 'Developer', 65000.00, '2023-06-05', 1, 3, 'Chennai', 'Mohan.gupta@example.com'),
('Kavita Singh', 'Analyst', 72000.00, '2023-04-20', 2, 2, 'Delhi', 'Kavita.singh@example.com'),
('Vikram Desai', 'Manager', 95000.00, '2023-02-01', NULL, 1, 'Mumbai', 'Vikram.desai@example.com'),
('Ananya Rao', 'Executive', 52000.00, '2023-08-10', 4, NULL, 'Bangalore', 'Ananya.rao@example.com'),
('Suraj Patil', 'Developer', 60000.00, '2023-07-01', 3, 3, 'Chennai', 'Suraj.patil@example.com'),
('Meera Iyer', 'Executive', 51000.00, '2023-07-15', 2, 4, 'Kolkata', 'Meera.iyer@example.com'),
('Arun Menon', 'Developer', 68000.00, '2023-03-01', 1, 3, 'Chennai', 'Arun.menon@example.com'),
('Sunil Yadav', 'Analyst', 75000.00, '2023-06-10', 2, 2, 'Delhi', 'Sunil.yadav@example.com'),
('Deepa Joshi', 'Executive', 55000.00, '2023-09-01', 4, 4, 'Kolkata', 'Deepa.joshi@example.com'),
('Naveen Sharma', 'Manager', 92000.00, '2023-01-10', NULL, 1, 'Mumbai', 'Naveen.sharma@example.com'),
('Rakesh Nair', 'Developer', 62000.00, '2023-05-01', 3, 3, 'Chennai', 'Rakesh.nair@example.com');


SELECT * FROM t_emp WHERE c_city='Chennai';

SELECT * FROM t_emp WHERE c_city='Chennai' OR c_city='Mumbai';

SELECT * FROM t_emp WHERE c_city IN ('Chennai','Mumbai');

SELECT * FROM t_emp WHERE c_salary < 70000 OR c_salary >90000 ;

SELECT * FROM t_emp WHERE c_salary NOT BETWEEN 70000 AND 90000 ;



SELECT SUM(c_salary) FROM t_emp ;
SELECT MAX(c_salary) FROM t_emp ;
SELECT MIN(c_salary) FROM t_emp ;
SELECT AVG(c_salary) FROM t_emp ;
SELECT COUNT(c_salary) FROM t_emp ;


SELECT MAX(c_salary),COUNT(c_deptid) FROM t_emp GROUP BY c_deptid ;
SELECT SUM(c_salary),c_deptid FROM t_emp GROUP BY c_deptid ;
SELECT MIN(c_salary),c_deptid FROM t_emp GROUP BY c_deptid ;
SELECT AVG(c_salary),c_deptid FROM t_emp GROUP BY c_deptid ;

SELECT MAX(c_salary),COUNT(c_deptid) FROM t_emp GROUP BY c_deptid  HAVING COUNT(c_deptid)>3;

SELECT c_deptid,COUNT(c_deptid) FROM t_emp WHERE c_salary>70000 GROUP BY c_deptid   HAVING COUNT(c_deptid)>0 ;

SELECT c_name FROM t_emp where c_salary=(SELECT MAX(c_salary) FROM t_emp);

SELECT c_deptname FROM t_dept WHERE c_deptid IN (SELECT COUNT(c_deptid) FROM t_emp  GROUP BY c_deptid HAVING COUNT(c_deptid)>1);

SELECT c_name,c_salary FROM t_emp WHERE c_salary >= ALL(SELECT c_salary FROM t_emp);


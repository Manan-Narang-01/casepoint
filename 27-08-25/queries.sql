CREATE TABLE t_test(
c_did INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_name VARCHAR(50) NOT NULL,
c_address VARCHAR(100),
c_city VARCHAR(50)
);

INSERT INTO t_test(c_name,c_address,c_city)VALUES
('A','abc','surat'),
('B',NULL,'bardoli'),
('C','def',NULL),
('D','ghi','surat'),
('E','jkl','bardoli'),
('F','mno','surat');



CREATE OR REPLACE VIEW view1
AS SELECT c_did,c_name FROM t_test;

INSERT INTO view1(c_name) VALUES('F');


CREATE OR REPLACE VIEW view2
AS SELECT COUNT(*) AS "NO OF PERSON" FROM t_test GROUP BY c_city;

SELECT *FROM view2;



SELECT c_deptid, c_city, SUM(c_salary)
FROM t_emp
GROUP BY ROLLUP (c_city,c_deptid) ORDER BY 2,1;

SELECT c_deptid, c_city, SUM(c_salary)
FROM t_emp
GROUP BY CUBE (c_city,c_deptid) ORDER BY 2,1;

SELECT c_deptid, c_city, SUM(c_salary)
FROM t_emp
GROUP BY GROUPING SETS (
(c_city,c_deptid),
(c_deptid),
(c_city)) ;


SELECT c_empid,c_name,c_city,c_salary, RANK() OVER( ORDER BY c_salary) RANK FROM t_emp;

SELECT c_empid,c_name,c_city,c_salary, ROW_NUMBER() OVER( PARTITION BY c_city ORDER BY c_salary DESC) AS ROW_NUM FROM t_emp;

SELECT c_empid,c_name,c_city,c_salary, ROW_NUMBER() OVER(  ORDER BY c_salary DESC) AS ROW_NUM FROM t_emp;


CREATE TABLE test(
c_id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_email VARCHAR(50) NOT NULL,
c_pwd VARCHAR(100) NOT NULL);

insert into test(c_email,c_pwd) VALUES
('ABC@gmail.com','ABC'),
('DEF@gmail.com','DEF'),
('GHI@gmail.com','GHI'),
('JKL@gmail.com','JKL');


SELECT *FROM test WHERE c_email='ABC@gmail.com' AND c_pwd='ABC';

SELECT *FROM test WHERE c_email='ABC@gmail.com' AND c_pwd='' OR '1'='1';

PREPARE t_user(VARCHAR,VARCHAR) AS SELECT *FROM test u WHERE u.c_email=$1 AND u.c_pwd=$2;

EXECUTE t_user('ABC@gmail.com','ABC');

EXECUTE t_user('ABC@gmail.com','' OR '1'='1');


CREATE TABLE order_details(
order_id SERIAL,
item_id INT NOT NULL,
item_text VARCHAR NOT NULL,
price DEC(10,2) NOT NULL,
PRIMARY KEY(order_id, item_id)
);

CREATE SEQUENCE item_id
START 1
INCREMENT 1
MINVALUE 1
OWNED BY order_details.item_id;


INSERT INTO 
order_details(order_id, item_id, item_text, price)
VALUES
(100, nextval('item_id'),'DVD Player',100),
(100, nextval('item_id'),'Android TV',550),
(100, nextval('item_id'),'Speaker',250);

	
ALTER SEQUENCE item_id RESTART WITH 10;

SELECT *FROM order_details;


SELECT CAST('200' AS INTEGER)+'10','01-OCT-2015'::DATE+1;

SELECT '15 minute' :: interval,
'2 hour' :: interval,
'1 day' :: interval,
'2 week' :: interval,
'3 month'::interval;

CREATE TABLE student(
c_id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_name VARCHAR(50) NOT NULL,
c_s1 INT NOT NULL,
c_s2 INT NOT NULL,
c_s3 INT NOT NULL);

INSERT INTO student(c_name,c_s1,c_s2,c_s3) VALUES
('manan',90,90,90),
('varun',80,80,80),
('man',70,70,70);

drop table student;


SELECT c_name,c_s1,c_s2,c_s3,
c_s1+c_s2+c_s3 AS "Total Marks",
(c_s1+c_s2+c_s3)/3 AS "PERCENTAGE",
CASE
	WHEN (c_s1+c_s2+c_s3)/3 >=90 THEN
		CAST ('DISTINCTION' AS TEXT)
	
	WHEN (c_s1+c_s2+c_s3)/3 >=80  AND (c_s1+c_s2+c_s3)/3 <90 THEN
		CAST ('FIRST' AS TEXT)
	
	WHEN (c_s1+c_s2+c_s3)/3 >=70 AND (c_s1+c_s2+c_s3)/3 <80 THEN
		CAST ('SECOND' AS TEXT)
	
	WHEN (c_s1+c_s2+c_s3)/3 >=60 AND (c_s1+c_s2+c_s3)/3 <70 THEN
		CAST ('THIRD' AS TEXT)
	WHEN (c_s1+c_s2+c_s3)/3 <60 THEN
		CAST ('FOURTH' AS TEXT)
	
	END

FROM student


with cte1 AS(
SELECT c_name,c_s1,c_s2,c_s3,
c_s1+c_s2+c_s3 AS "Total Marks",
(c_s1+c_s2+c_s3)/3 AS "PERCENTAGE",
CASE
	WHEN (c_s1+c_s2+c_s3)/3 >=90 THEN
		CAST ('DISTINCTION' AS TEXT)
	
	WHEN (c_s1+c_s2+c_s3)/3 >=80  AND (c_s1+c_s2+c_s3)/3 <90 THEN
		CAST ('FIRST' AS TEXT)
	
	WHEN (c_s1+c_s2+c_s3)/3 >=70 AND (c_s1+c_s2+c_s3)/3 <80 THEN
		CAST ('SECOND' AS TEXT)
	
	WHEN (c_s1+c_s2+c_s3)/3 >=60 AND (c_s1+c_s2+c_s3)/3 <70 THEN
		CAST ('THIRD' AS TEXT)
	WHEN (c_s1+c_s2+c_s3)/3 <60 THEN
		CAST ('FOURTH' AS TEXT)
	
	END AS CLASS

FROM student

)SELECT*FROM cte1 WHERE CLASS='DISTINCTION'; 


with cte2 AS(
SELECT c_empid,c_name,c_city,c_salary, 
RANK() OVER( ORDER BY c_salary) RANK FROM t_emp
)SELECT*FROM cte2 WHERE RANK IN (4,5); 

with cte3 AS(
SELECT c_empid,c_deptid,c_name,c_city,c_salary, ROW_NUMBER() OVER( PARTITION BY c_deptid ORDER BY c_name) AS ROW_NUM FROM t_emp
)SELECT*FROM cte3 WHERE ROW_NUM < 3; 

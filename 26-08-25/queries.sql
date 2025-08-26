SELECT SUM(c_salary) AS "Total Sum" FROM t_emp;

SELECT c_salary FROM t_emp ORDER BY c_salary DESC LIMIT 3;

SELECT c_salary,c_name FROM t_emp ORDER BY c_salary DESC LIMIT 3 OFFSET 2;

SELECT c_salary,c_name FROM t_emp ORDER BY c_salary DESC OFFSET 2 FETCH NEXT 4 ROWS ONLY;

SELECT MAX(c_salary) AS "Second Highest Salary"  FROM t_emp WHERE c_salary<(SELECT MAX(c_salary) FROM t_emp);

SELECT DISTINCT(c_salary) FROM t_emp ORDER BY c_salary DESC  LIMIT 4 OFFSET 7;

SELECT t_emp.c_empid,t_emp.c_name,t_emp.c_deptid, t_dept.c_deptid,t_dept.c_deptid
from t_emp,t_dept;


SELECT t_emp.c_empid,t_emp.c_name,t_emp.c_deptid, t_dept.c_deptid,t_dept.c_deptname
from t_emp CROSS JOIN t_dept;


--equvi join
SELECT t_emp.c_empid,t_emp.c_name,t_emp.c_deptid, t_dept.c_deptid,t_dept.c_deptname
from t_emp , t_dept where t_emp.c_deptid=t_dept.c_deptid;

--inner join
SELECT t_emp.c_empid,t_emp.c_name,t_emp.c_deptid, t_dept.c_deptid,t_dept.c_deptname
FROM t_emp 
INNER JOIN t_dept 
ON t_emp.c_deptid=t_dept.c_deptid;

--left join
SELECT t_emp.c_empid,t_emp.c_name,t_emp.c_deptid, t_dept.c_deptid,t_dept.c_deptname
FROM t_emp 
LEFT JOIN t_dept 
ON t_emp.c_deptid=t_dept.c_deptid;

--right join
SELECT t_emp.c_empid,t_emp.c_name,t_emp.c_deptid, t_dept.c_deptid,t_dept.c_deptname
FROM t_emp 
RIGHT JOIN t_dept 
ON t_emp.c_deptid=t_dept.c_deptid;

--FULL OUTER join
SELECT e.c_empid,e.c_name,e.c_deptid, d.c_deptid,d.c_deptname
FROM t_emp e
FULL OUTER JOIN t_dept d
ON e.c_deptid=d.c_deptid;

--Self 
SELECT e.c_empid,e.c_name,e1.c_mgrno 
FROM t_emp e
JOIN t_emp e1
ON e.c_empid=e1.c_empid;

CREATE TABLE t_salesman(
c_cid INT GENERATED ALWAYS AS IDENTITY,
c_name VARCHAR(50) NOT NULL
);

--set operatoins
select c_name from t_emp intersect select c_name from t_salesman; 

select c_name from t_emp UNION select c_name from t_salesman; 

select c_name from t_emp UNION ALL select c_name from t_salesman; 

select c_name from t_emp EXCEPT select c_name from t_salesman; 


create table sp(
id serial primary key,
data jsonb
);

insert into sp(data) values
('{"name":"Alice","age":"25","skills":["c#","SQL","JS"]}'),
('{"name":"Bob","age":"30","skills":["Python","Django"]}'),
('{"name":"Charlie","age":"28","skills":["Java","Spring"]}');


SELECT * FROM sp;

SELECT id, data->>'name' AS "Name" FROM sp;

SELECT id,(data->>'age')::int as "Age" FROM sp;

SELECT id, data->>'name' AS "Name" FROM sp WHERE ;

SELECT id, data->>'name' AS "Name" FROM sp WHERE data->'skills' @> '["Python"]';

UPDATE sp 
SET data= jsonb_set(data,'{city}','"New York"')
WHERE data->>'name'='Alice';


UPDATE sp
SET data=jsonb_set(data,'{age}','26')
WHERE data->>'name'='Alice';

UPDATE sp
SET data=data-'CITY'
WHERE data->>'name'='Alice';

DELETE FROM sp where data->>'name'='Alice';


UPDATE sp 
SET data= jsonb_set(data,'{salary}','10000');


UPDATE sp 
SET data = jsonb_set(
    data,
    '{salary}',
    ((data->>'salary')::numeric * 1.10)::text::jsonb
);


CREATE INDEX idx_json_name ON sp ((data->>'name'));
CREATE INDEX idx_skills_gin ON sp USING GIN ((data->'skills'));




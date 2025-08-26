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

--Self join
SELECT e.c_empid,e.c_name,e1.c_name AS "Manager Name" 
FROM t_emp e
JOIN t_emp e1	
ON e.c_mgrno=e1.c_empid;







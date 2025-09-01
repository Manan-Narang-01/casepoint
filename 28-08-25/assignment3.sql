--1
WITH cte1 AS(
SELECT c_deptid, COUNT(*) FROM t_emp GROUP BY c_deptid ORDER BY c_deptid
)SELECT * FROM cte1;

--2
WITH cte2 AS(
SELECT c_city,AVG(c_salary), COUNT(*) FROM t_emp GROUP BY c_city
)SELECT * FROM cte2;

--3
WITH city_counts AS (
    SELECT c_city, COUNT(*) AS city_emp
    FROM t_emp
    GROUP BY c_city
)
SELECT e.*, cc.city_emp
FROM t_emp e
JOIN city_counts cc ON e.c_city = cc.c_city
ORDER BY cc.city_emp DESC;

--4
WITH desig_salary AS (
    SELECT c_desig, SUM(c_salary) AS total_salary, AVG(c_salary) AS avg_salary
    FROM t_emp
    GROUP BY c_desig
)
SELECT * 
FROM desig_salary
WHERE total_salary > 200000 AND avg_salary > 60000;

--5

SELECT c_deptid, c_city, SUM(c_salary) AS totalsalary
FROM t_emp
GROUP BY ROLLUP (c_deptid, c_city);

--6

SELECT c_deptid, c_desig, COUNT(*) AS emp_count
FROM t_emp
GROUP BY ROLLUP (c_deptid, c_desig);


--7

SELECT c_city, SUM(c_salary) AS total_salary, AVG(c_salary) AS avg_salary
FROM t_emp
GROUP BY ROLLUP (c_city);


--8
SELECT c_deptid, c_city, SUM(c_salary) AS total_salary
FROM t_emp
GROUP BY CUBE (c_deptid, c_city);


--9
SELECT c_desig, c_city, COUNT(*) AS emp_count
FROM t_emp
GROUP BY CUBE (c_desig, c_city);

--10
SELECT c_deptid, c_city, c_desig, SUM(c_salary) AS total_salary
FROM t_emp
GROUP BY CUBE (c_deptid, c_city, c_desig);


--11
SELECT *
FROM (
    SELECT *, ROW_NUMBER() OVER (PARTITION BY c_deptid ORDER BY c_salary DESC) AS row_num
    FROM t_emp
) sub
ORDER BY c_deptid, row_num;


--12

SELECT *
FROM (
    SELECT *, ROW_NUMBER() OVER (PARTITION BY c_city ORDER BY c_salary DESC) AS rn
    FROM t_emp
) sub
WHERE rn <= 2;


--13
SELECT *
FROM (
    SELECT *, ROW_NUMBER() OVER (PARTITION BY c_deptid ORDER BY c_salary DESC) AS rn
    FROM t_emp
) sub
WHERE rn = 2;


--14
SELECT *
FROM (
    SELECT *, ROW_NUMBER() OVER (PARTITION BY c_deptid ORDER BY c_hiredate ASC) AS rn
    FROM t_emp
) sub
WHERE rn <= 3;

--15

SELECT *
FROM (
    SELECT *, RANK() OVER (PARTITION BY c_deptid ORDER BY c_salary DESC) AS rnk
    FROM t_emp
) sub
WHERE rnk = 2;


--16
SELECT *
FROM (
    SELECT *, RANK() OVER (PARTITION BY c_deptid ORDER BY c_salary DESC) AS rnk
    FROM t_emp
) sub
WHERE rnk IN (1, 2);


--17

SELECT *
FROM (
    SELECT *, RANK() OVER (PARTITION BY c_deptid ORDER BY c_salary DESC) AS rnk
    FROM t_emp
) sub
WHERE rnk = 1 AND c_salary > 80000;



--18

SELECT *
FROM (
    SELECT *, RANK() OVER (PARTITION BY c_city ORDER BY c_salary DESC) AS rnk
    FROM t_emp
) sub
WHERE rnk <= 5;





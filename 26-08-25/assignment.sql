CREATE TABLE t_customers(
c_cid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_name VARCHAR(50) NOT NULL,
c_city VARCHAR(50) NOT NULL,
c_joindate DATE NOT NULL,
c_creditlimit DECIMAL(10,2) NOT NULL
);


CREATE TABLE t_orders(
c_oid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_cid INT NOT NULL,
c_orderdate DATE NOT NULL,
c_totalamount DECIMAL(10,2) NOT NULL,
CONSTRAINT fk_Customer FOREIGN KEY(c_cid) REFERENCES t_customers(c_cid)
);


CREATE TABLE t_products(
c_pid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_name VARCHAR(50) NOT NULL,
c_category VARCHAR(50) NOT NULL,
c_price DECIMAL(10,2) NOT NULL
);



CREATE TABLE t_orderdetail(
c_odid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_oid INT NOT NULL,
c_pid INT NOT NULL,
c_quantity INT NOT NULL,
c_unitprice DECIMAL(10,2) NOT NULL,
CONSTRAINT fk_order FOREIGN KEY(c_oid) REFERENCES t_orders(c_oid),
CONSTRAINT fk_product FOREIGN KEY(c_pid) REFERENCES t_products(c_pid)
);

INSERT INTO t_customers (c_name, c_city, c_joindate, c_creditlimit) VALUES
('Alice Johnson', 'New York', '2023-01-15', 10000.00),
('Bob Smith', 'Los Angeles', '2022-10-10', 15000.00),
('Charlie Brown', 'Chicago', '2024-05-05', 8000.00),
('David Wilson', 'New York', '2023-08-20', 20000.00),
('Emma Thomas', 'Miami', '2023-02-12', 12000.00);


INSERT INTO t_orders (c_cid, c_orderdate, c_totalamount) VALUES
(1, '2024-01-01', 1200.00),
(3, '2024-06-15', 2500.00),
(2, '2024-03-20', 1800.00),
(4, '2024-02-10', 3000.00),
(1, '2024-04-05', 2200.00),
(5, '2024-05-18', 3500.00);

INSERT INTO t_products (c_name, c_category, c_price) VALUES
('Laptop', 'Electronics', 1200.00),
('Smartphone', 'Electronics', 800.00),
('Office Chair', 'Furniture', 150.00),
('Dining Table', 'Furniture', 600.00),
('Headphones', 'Electronics', 300.00);


INSERT INTO t_orderdetail (c_oid, c_pid, c_quantity, c_unitprice) VALUES
(1, 1, 1, 50000.00),
(1, 2, 2, 25000.00),
(2, 3, 4, 5000.00),
(3, 4, 1, 15000.00),
(4, 5, 3, 3000.00),
(5, 1, 2, 50000.00),
(6, 2, 1, 25000.00);


--1
SELECT * FROM t_customers;

--2
SELECT DISTINCT(c_category) FROM t_products;

--3
SELECT * FROM t_orders WHERE c_totalamount>3000;

--4
SELECT * FROM t_customers WHERE c_joindate<'2023-06-01';

--5
SELECT *FROM t_customers WHERE c_cid IN (SELECT c_cid FROM t_orders);

--6
SELECT * FROM t_customers WHERE c_city IN ('Mumbai','Delhi','Chennai');

--7
SELECT * FROM t_products WHERE c_name LIKE '%Table%';

--8
SELECT *
FROM t_orders
WHERE EXTRACT(MONTH FROM c_orderdate) = 4
  AND EXTRACT(YEAR FROM c_orderdate) = 2024;

--9
SELECT * FROM t_products WHERE c_price BETWEEN 5000 AND 30000;

--10

SELECT * FROM t_customers WHERE c_name LIKE 'R%';

--11

SELECT c_cid,COUNT(c_oid) AS "Total Orders" FROM t_orders GROUP BY c_cid ;

--12

SELECT AVG(c_price),count(c_category) AS "Category" FROM t_products GROUP BY c_category ;

--13

SELECT MAX(c_totalamount) AS "MAX Total Amount",MIN(c_totalamount) AS "Min Total Amount" FROM t_orders;

--14

SELECT SUM(c_quantity * c_unitprice) FROM t_orderdetail ;

--15
SELECT  COUNT(c_oid),c_pid FROM t_orderdetail GROUP BY c_pid ORDER BY c_pid ;

--16

SELECT c_cid,COUNT(c_oid) AS "Total Orders" FROM t_orders GROUP BY c_cid HAVING COUNT(c_oid)>1 ;

--17
SELECT DISTINCT(c_category) FROM t_products;

--18
SELECT c_cid , SUM(c_totalamount) FROM t_orders GROUP BY c_cid HAVING SUM(c_totalamount)>4000; 
--19

SELECT p.c_category , COUNT(o.c_pid)
FROM t_orderdetail o
JOIN t_products p
ON o.c_pid=p.c_pid
GROUP BY p.c_category;

--20
SELECT DISTINCT(c_city) FROM t_customers;

--21


SELECT * FROM t_products ORDER BY c_category ASC , c_price DESC;


--22

SELECT * FROM t_customers ORDER BY c_city ASC , c_creditlimit DESC;


--23

SELECT * FROM t_orders ORDER BY c_orderdate ASC , c_totalamount ASC;

--24

SELECT * FROM t_products ORDER BY  c_price DESC LIMIT 3;

--25
SELECT DISTINCT ON(c_cid)* FROM t_orders  ORDER BY c_cid,c_orderdate DESC;

--26
SELECT c_name FROM t_customers WHERE c_cid IN (SELECT c_cid FROM t_orders)
UNION
SELECT c_name FROM t_customers WHERE c_cid NOT IN (SELECT c_cid FROM t_orders);

--27
SELECT DISTINCT c.c_name
FROM t_customers c
JOIN t_orders o ON c.c_cid = o.c_cid
JOIN t_orderdetail od ON o.c_oid = od.c_oid
JOIN t_products p ON od.c_pid = p.c_pid
WHERE p.c_category = 'Furniture'
INTERSECT
SELECT c_name FROM t_customers;


--28
SELECT c_name FROM t_customers WHERE c_cid IN (
  SELECT c_cid FROM t_orders WHERE c_totalamount >= 2000
)
EXCEPT
SELECT c_name FROM t_customers WHERE c_cid IN (
  SELECT c_cid FROM t_orders WHERE c_totalamount < 2000
);

--29
SELECT DISTINCT c.c_name AS "Customer Name",p.c_name AS "Product Name",o.c_oid
FROM t_customers c
JOIN t_orders o ON c.c_cid = o.c_cid
JOIN t_orderdetail od ON o.c_oid = od.c_oid
JOIN t_products p ON od.c_pid = p.c_pid;

--30

SELECT c_name FROM t_customers
WHERE c_cid IN (SELECT c_cid FROM t_orders 
where c_totalamount <(SELECT AVG(c_totalamount) FROM t_orders));

--31


SELECT c.c_name, SUM(od.c_quantity) AS total_quantity
FROM t_customers c
JOIN t_orders o ON c.c_cid = o.c_cid
JOIN t_orderdetail od ON o.c_oid = od.c_oid
GROUP BY c.c_name;

--32
SELECT c.*
FROM t_customers c
LEFT JOIN t_orders o ON c.c_cid = o.c_cid
WHERE o.c_oid IS NULL;

--33

SELECT p.c_name AS "Product Name",od.c_quantity*od.c_unitprice AS "Total Revenue"
FROM t_products p
JOIN t_orderdetail od 
ON od.c_pid = p.c_pid;

--34
SELECT a.c_name AS customer1, b.c_name AS customer2, a.c_city
FROM t_customers a
JOIN t_customers b ON a.c_city = b.c_city AND a.c_cid < b.c_cid;
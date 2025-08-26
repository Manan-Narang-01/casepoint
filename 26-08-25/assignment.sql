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
c_price INT NOT NULL
);


INSERT INTO t_customers (c_name, c_city, c_joindate, c_creditlimit) VALUES
('Alice Johnson', 'New York', '2023-01-15', 10000.00),
('Bob Smith', 'Los Angeles', '2022-10-10', 15000.00),
('Charlie Brown', 'Chicago', '2024-05-05', 8000.00),
('David Wilson', 'New York', '2023-08-20', 20000.00),
('Emma Thomas', 'Miami', '2023-02-12', 12000.00);


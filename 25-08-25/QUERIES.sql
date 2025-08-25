CREATE TABLE t_employee(
c_eid SERIAL PRIMARY KEY,
c_name VARCHAR(50),
c_deptid INT,
c_salary DECIMAL(10,2),
c_hire_date DATE
);

INSERT INTO t_employee(c_name,c_deptid,c_salary,c_hire_date)VALUES
('Alice',1,50000,'2020-01-15'),
('Bob',2,60000,'2019-03-10'),
('Carol',3,45000,'2021-07-23'),
('David',2,70000,'2018-05-15'),
('Eve',3,55000,'2021-03-05');

CREATE TABLE t_department(
c_did SERIAL PRIMARY KEY,
c_department_name VARCHAR(50)
);

INSERT INTO t_department(c_department_name)VALUES
('Hr'),
('It'),
('Sales');

ALTER TABLE t_employee ADD CONSTRAINT fk_dept FOREIGN KEY(c_deptid) REFERENCES t_department(c_did); 
ALTER TABLE t_employee ADD COLUMN c_email  VARCHAR(50); 
ALTER TABLE t_employee ALTER COLUMN c_email TYPE  VARCHAR(500);
ALTER TABLE t_employee ALTER COLUMN c_email  SET DEFAULT 'abc@gmail.com'; 
ALTER TABLE t_employee DROP COLUMN c_email_id; 

ALTER TABLE t_department RENAME COLUMN c_did TO c_deparment_id; 
UPDATE t_employee SET c_email_id='abc@gmail.com'; 

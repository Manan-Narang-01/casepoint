CREATE TABLE employees (
    emp_id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    emp_name VARCHAR(100),
    designation VARCHAR(50),
    salary INT,
    hire_date DATE,
    dept_id INT,
    city VARCHAR(50),
    email VARCHAR(100),
    profile_data JSONB
);

alter table employees alter column profile_data TYPE JSONB;

INSERT INTO employees (emp_name, designation, salary, hire_date, dept_id, city, email, profile_data) VALUES
('Rajesh Kumar', 'Manager', 90000, '2021-05-10', 1, 'Mumbai', 'rajesh@example.com',
 '{"age": 40, "skills": ["Leadership", "Finance"]}'),

('Anjali Sharma', 'Developer', 75000, '2022-08-15', 2, 'Delhi', 'anjali@example.com',
 '{"age": 28, "skills": ["Java", "SQL"]}'),

('Vikram Patel', 'Analyst', 65000, '2020-11-20', 3, 'Bangalore', 'vikram@example.com',
 '{"age": 35, "skills": ["Data Analysis", "Excel"]}'),

('Sneha Verma', 'HR Executive', 55000, '2023-02-01', 1, 'Kolkata', 'sneha@example.com',
 '{"age": 30, "skills": ["Recruitment", "Communication"]}'),

('Manish Gupta', 'Sales Manager', 85000, '2019-06-25', 4, 'Chennai', 'manish@example.com',
 '{"age": 45, "skills": ["Negotiation", "Marketing"]}'),

('Priya Singh', 'Developer', 72000, '2021-09-10', 2, 'Pune', 'priya@example.com',
 '{"age": 26, "skills": ["Python", "Django"]}'),

('Arjun Mehta', 'Analyst', 60000, '2022-04-12', 3, 'Hyderabad', 'arjun@example.com',
 '{"age": 32, "skills": ["SQL", "Reporting"]}'),

('Kavita Joshi', 'HR Manager', 75000, '2020-01-05', 1, 'Mumbai', 'kavita@example.com',
 '{"age": 38, "skills": ["HR Policies", "Employee Relations"]}'),

('Rahul Nair', 'Developer', 78000, '2023-07-14', 2, 'Delhi', 'rahul@example.com',
 '{"age": 29, "skills": ["React", "Node.js"]}'),

('Sunil Rao', 'Sales Executive', 62000, '2021-12-19', 4, 'Bangalore', 'sunil@example.com',
 '{"age": 34, "skills": ["Client Handling", "CRM"]}');


--1
SELECT *FROM employees ORDER BY hire_date LIMIT 5;

--2
SELECT *FROM employees ORDER BY salary  LIMIT 5;

--3
SELECT *FROM employees ORDER BY emp_id OFFSET 5 LIMIT 5;

--4
SELECT *FROM employees ORDER BY emp_id OFFSET 5 LIMIT 5;

--5

SELECT *FROM employees ORDER BY hire_date OFFSET 2 LIMIT 5;

--6

SELECT *FROM employees ORDER BY emp_id OFFSET 3 LIMIT 4;

--7
SELECT *FROM employees ORDER BY salary DESC LIMIT 3;

--8
SELECT *FROM employees ORDER BY emp_id OFFSET 2 LIMIT 4;

--9

SELECT *FROM employees ORDER BY profile_data->>('age') LIMIT 5;

--10
SELECT *FROM employees WHERE salary >60000 LIMIT 5;

--11
INSERT INTO employees(emp_name, designation, salary, hire_date, dept_id, city, email, profile_data)
VALUES('Priyam Roy', 'Developer', 72000, '2022-08-11', 2, 'Pune', 'priyam@example.com',
 '{"age": 22, "skills": ["Python", "Django"]}')

 --12
 SELECT emp_name,profile_data->>('skills') AS Skills FROM employees;

 --13
SELECT * FROM employees WHERE profile_data->'skills' @> '["Python"]';

--14

UPDATE employees
SET profile_data=jsonb_set(profile_data,'{skills}','"AI"')
WHERE emp_name='Anjali Sharma';

--15

SELECT *FROM employees WHERE (profile_data->>'age')::int > 30;


--16

SELECT *FROM employees WHERE jsonb_array_length(profile_data->'skills')>2;

--17

 SELECT emp_name,profile_data->>('skills') AS Skills,profile_data->>('age') AS Age FROM employees;

--18

 SELECT emp_name,profile_data->>('age') AS Age FROM employees ORDER BY profile_data->>('age');

--19
SELECT * FROM employees WHERE profile_data->'skills' is NULL;

--20
SELECT
  emp_name,
  profile_data -> 'skills'->>0 AS Skills, 
  profile_data->>'age' AS Age
FROM employees;



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


CREATE TABLE t_accounts(
c_cid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_name VARCHAR(50) NOT NULL,
c_balance DECIMAL(10,2) NOT NULL
)

INSERT INTO t_accounts(c_name,c_balance) VALUES
('Manan',100000),
('Varun',100000),
('DaBi',100000);


CREATE OR REPLACE PROCEDURE transfer(
    sender INT,
    receiver INT,
    amount DECIMAL(10,2)
)
LANGUAGE plpgsql
AS $$
DECLARE
    sender_balance DECIMAL(10,2);
BEGIN
    
    SELECT c_balance INTO sender_balance
    FROM t_accounts
    WHERE c_cid = sender
    FOR UPDATE;
	
	    IF sender_balance < amount THEN
        RAISE EXCEPTION 'Insufficient funds: Available = %, Required = %', sender_balance, amount;
    END IF;

    
    UPDATE t_accounts
    SET c_balance = c_balance - amount
    WHERE c_cid = sender;

    
    UPDATE t_accounts
    SET c_balance = c_balance + amount
    WHERE c_cid = receiver;    
END;
$$;


CALL transfer(3,1,5000000);



SELECT * FROM t_accounts;


CREATE TABLE t_accounts_audits(
c_aid INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
c_uid INT NOT NULL ,
c_u_old DECIMAL(10,2)  NOT NULL,
c_u_new DECIMAL(10,2)  NOT NULL,
c_amount DECIMAL(10,2) NOT NULL,
c_status VARCHAR(50) NOT NULL
);

DROP TABLE t_accounts_audits;


CREATE OR REPLACE FUNCTION log_audits()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
BEGIN
	IF NEW.c_balance <> OLD.c_balance THEN
		IF NEW.c_balance > OLD.c_balance THEN
			
			INSERT INTO t_accounts_audits(c_uid,c_u_old,c_u_new,c_amount,c_status) VALUES(NEW.c_cid,OLD.c_balance,NEW.c_balance,NEW.c_balance-OLD.c_balance,'CREDIT');
		END IF;
		IF NEW.c_balance < OLD.c_balance THEN
			
			INSERT INTO t_accounts_audits(c_uid,c_u_old,c_u_new,c_amount,c_status) VALUES(NEW.c_cid,OLD.c_balance,NEW.c_balance,OLD.c_balance-NEW.c_balance,'DEBIT');
		END IF;
	END IF;

	RETURN NEW;
	
END;$$






CREATE OR REPLACE TRIGGER audit
AFTER UPDATE
ON t_accounts
FOR EACH ROW
EXECUTE FUNCTION log_audits(); 



select * from t_accounts_audits;

create table t1(like t_accounts);
insert into t1 

select * from t_accounts;
create table t2 AS  select * from t_accounts;


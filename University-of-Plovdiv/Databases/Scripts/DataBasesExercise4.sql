  SELECT JOB_ID,
  	     AVG(SALARY) AS [AverageSalary] 
    FROM EMPLOYEES
GROUP BY JOB_ID
GO

    SELECT c.FNAME + ' ' + c.LNAME AS [Customer Name],
    	   COUNT(o.ORDER_ID) AS [CountOrders]
      FROM ORDERS AS o
RIGHT JOIN CUSTOMERS AS c
  	    ON c.CUSTOMER_ID = o.CUSTOMER_ID
  GROUP BY c.CUSTOMER_ID, c.FNAME + ' ' + c.LNAME
  ORDER BY CountOrders DESC
GO

SELECT e.FNAME + ' ' + e.LNAME AS [Employee Name],
	   j.JOB_TITLE
  FROM EMPLOYEES AS e
  JOIN JOBS AS j
    ON j.JOB_ID = e.JOB_ID
GO

SELECT cu.FNAME + ' ' + cu.LNAME AS [Customer Name],
	   co.NAME AS [Country Name],
	   re.NAME AS [Region Name]
  FROM Customers AS cu
  JOIN COUNTRIES AS co
    ON co.COUNTRY_ID = cu.COUNTRY_ID
  JOIN REGIONS AS re
    ON re.REGION_ID = co.REGION_ID
GO

  SELECT c.FNAME + ' ' + c.LNAME AS [Customer Name],
  	     SUM(oi.QUANTITY * oi.UNIT_PRICE) AS [Total Orders Price]
    FROM CUSTOMERS AS c
    JOIN ORDERS AS o
      ON o.CUSTOMER_ID = c.CUSTOMER_ID
    JOIN ORDER_ITEMS AS oi
      ON oi.ORDER_ID = o.ORDER_ID
GROUP BY c.CUSTOMER_ID, .FNAME + ' ' + c.LNAME
  HAVING SUM(oi.QUANTITY * oi.UNIT_PRICE) > 100000
GO

  SELECT d.NAME AS [Department Name],
  	     COUNT(e.EMPLOYEE_ID) AS [Count Employees]
    FROM EMPLOYEES AS e
    JOIN DEPARTMENTS AS d
      ON d.DEPARTMENT_ID = e.DEPARTMENT_ID
   WHERE d.COUNTRY_ID IN ('US', 'DE')
GROUP BY d.DEPARTMENT_ID, d.NAME
  HAVING COUNT(e.EMPLOYEE_ID) > 5
GO
	
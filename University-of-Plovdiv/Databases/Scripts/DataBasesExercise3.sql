UPDATE ORDER_ITEMS
SET QUANTITY += 200, UNIT_PRICE *= 0.95
WHERE PRODUCT_ID = 3150 AND ORDER_ID = 2354


SELECT FNAME + ' ' + LNAME AS [FullName],
	   [ADDRESS]
  FROM CUSTOMERS
 WHERE COUNTRY_ID IN ('IN', 'US')

SELECT COUNT(DISTINCT CUSTOMER_ID) AS [CountCustomersWithOrders]
  FROM ORDERS

SELECT SUM(UNIT_PRICE * QUANTITY) AS [Order2355TotalPrice]
  FROM ORDER_ITEMS
 WHERE ORDER_ID = 2355

SELECT MIN(HIRE_DATE) AS [FirstEmployeeHireDate]
  FROM EMPLOYEES

  SELECT DEPARTMENT_ID,
		 SUM(SALARY / 12) AS [TotalSalaries]
    FROM EMPLOYEES
GROUP BY DEPARTMENT_ID
  HAVING DEPARTMENT_ID IS NOT NULL
ORDER BY TotalSalaries DESC

  SELECT c.COUNTRY_ID,
  	     COUNT(CUSTOMER_ID) AS [CountCustomers]
    FROM CUSTOMERS AS c
GROUP BY c.COUNTRY_ID
ORDER BY CountCustomers



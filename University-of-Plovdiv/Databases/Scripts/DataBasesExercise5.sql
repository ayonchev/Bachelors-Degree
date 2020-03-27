/*�������� ������� �� ���������� � ������
����������, � ����� �� ���� ��������, ����
� ��������� �������� ���� ���������� � ����
���������� > 1000. ��������� ��������� ��
���� ���������� ���������.*/

SELECT NAME, SUM(QUANTITY) AS SUM_QUANTITY
FROM PRODUCTS P JOIN ORDER_ITEMS O
ON P.PRODUCT_ID = O.PRODUCT_ID
GROUP BY NAME
HAVING SUM(QUANTITY) > 1000
ORDER BY SUM_QUANTITY DESC

/*�������� ������� �� ����������� � �������
�� ������� ����� ���������*/

SELECT E.FNAME+' '+E.LNAME AS EMPLOYEE,
M.FNAME+' '+M.LNAME AS MANAGER
FROM EMPLOYEES E JOIN EMPLOYEES M
ON M.EMPLOYEE_ID = E.MANAGER_ID

/*�������� ������� �� ����������� � �������
�� ������� ����� ���������, ���� � ���������
�������� � �����������, ����� ����� ���������*/

SELECT E.FNAME+' '+E.LNAME AS EMPLOYEE,
M.FNAME+' '+M.LNAME AS MANAGER
FROM EMPLOYEES E LEFT JOIN EMPLOYEES M
ON M.EMPLOYEE_ID = E.MANAGER_ID

/*�������� ������� � ��������� �� ������
���������, ����� ���� ������� > �� ���������
�� �������� 152*/

SELECT E.FNAME, E.LNAME, E.SALARY
FROM EMPLOYEES E JOIN EMPLOYEES P
ON E.SALARY > P.SALARY
WHERE P.EMPLOYEE_ID = 152

SELECT FNAME, LNAME, SALARY
FROM EMPLOYEES
WHERE SALARY > (SELECT SALARY
FROM EMPLOYEES
WHERE EMPLOYEE_ID = 152)

SELECT FNAME, LNAME, SALARY
FROM EMPLOYEES
WHERE SALARY > (SELECT SALARY
FROM EMPLOYEES
WHERE EMPLOYEE_ID = 152
OR EMPLOYEE_ID = 155)

/*�������� ������� �� �����������, �����
��������� ������� > �� ��������� �� ����� ��
����������� �������� � ����� 100*/

SELECT FNAME, LNAME, SALARY
FROM EMPLOYEES
WHERE SALARY > ANY (SELECT SALARY
FROM EMPLOYEES
WHERE DEPARTMENT_ID = 100)
ORDER BY 3

SELECT FNAME, LNAME, SALARY
FROM EMPLOYEES
WHERE SALARY > (SELECT MIN(SALARY)
FROM EMPLOYEES
WHERE DEPARTMENT_ID = 100)
ORDER BY 3

/*�������� ������� �� �����������, �����
��������� ������� > �� ��������� �� ����� ��
����������� �������� � ����� 100*/

SELECT FNAME, LNAME, SALARY
FROM EMPLOYEES
WHERE SALARY > ALL (SELECT SALARY
FROM EMPLOYEES
WHERE DEPARTMENT_ID = 100)
ORDER BY 3

SELECT FNAME, LNAME, SALARY
FROM EMPLOYEES
WHERE SALARY > (SELECT MAX(SALARY)
FROM EMPLOYEES
WHERE DEPARTMENT_ID = 100)
ORDER BY 3

/*�������� �������� � ������ �� ���������, �����
�� ��������� ���� 12.04.2008*/

SELECT ORDER_ID, ORDER_DATE
FROM ORDERS
WHERE ORDER_DATE > '2008-04-13'
ORDER BY 2

SELECT ORDER_ID, ORDER_DATE
FROM ORDERS
WHERE ORDER_DATE > '12.04.2008'
ORDER BY 2

SELECT ORDER_ID, ORDER_DATE
FROM ORDERS
WHERE ORDER_DATE > 'APR 12, 2008'
ORDER BY 2

SELECT ORDER_ID, ORDER_DATE
FROM ORDERS
WHERE ORDER_DATE > CAST('12.04.2008' AS DATETIME)
ORDER BY 2

SELECT ORDER_ID, ORDER_DATE
FROM ORDERS
WHERE ORDER_DATE > 
CONVERT(DATETIME, '12.04.2008', 104)
ORDER BY 2

/*�������� ������� � ������ �� ����������� 
�� ������ ���������, �������� ������ � ���� 109*/

SELECT FNAME, LNAME, CONVERT(VARCHAR,HIRE_DATE,109)
FROM EMPLOYEES

SELECT SYSDATETIME(), SYSDATETIMEOFFSET(),
CURRENT_TIMESTAMP, GETDATE()

/*�������� �������, ������ �� ����������� �
������, � ����� �� ���� ��������� ������
���������*/

SELECT FNAME, LNAME, HIRE_DATE, 
MONTH(HIRE_DATE) AS MONTH, 
DATEPART(MONTH, HIRE_DATE) AS DATEPART,
DATENAME(MONTH, HIRE_DATE) AS DATENAME
FROM EMPLOYEES

SELECT DATEFROMPARTS ( 2010, 12, 31 ) AS Result;

SELECT DATETIMEFROMPARTS ( 2010, 12, 31, 23, 59, 59, 0 ) AS Result;  

SELECT DATEDIFF(millisecond, GETDATE(), 
SYSDATETIME());  

/*�������� ���� ����� ��� � ����������� �� 
���� �� �����*/

SELECT DATEDIFF(DAY, GETDATE(), '2018-12-04')

SELECT EOMONTH(GETDATE())

SELECT ROUND(123.9994, 3), ROUND(123.9995, 3);

DECLARE @myvalue float;  
SET @myvalue = 1.00;  
WHILE @myvalue < 10.00  
   BEGIN  
      SELECT SQRT(@myvalue);  
      SET @myvalue = @myvalue + 1  
   END;  
GO 

DECLARE @input1 float;  
DECLARE @input2 float;  
SET @input1= 2;  
SET @input2 = 2.5;  
SELECT POWER(@input1, 3) AS Result1, 
POWER(@input2, 3) AS Result2; 

SELECT ABS(-1.0), ABS(0.0), ABS(1.0); 

SELECT x = SUBSTRING('abcdef', 2, 3); 

SELECT SUBSTRING(FNAME, 1, 1)+'. '+LNAME
FROM EMPLOYEES

SELECT REPLACE('abcdefghicde','cde','xxx'); 

SELECT FNAME, REVERSE(FNAME)
FROM EMPLOYEES

SELECT LTRIM('     Five spaces are at the 
beginning of this string.') 

/*�������� ������� � ��������� �� ������ ���������,
����� ������� ��������� � ������� D*/

SELECT FNAME, LNAME
FROM EMPLOYEES
WHERE LNAME LIKE 'D%'

/*�������� ������ ����� ������� �� ������� �
���������*/

SELECT FNAME
FROM EMPLOYEES
UNION
SELECT FNAME
FROM CUSTOMERS
ORDER BY 1

/*�������� ������� �� ���������, � �����
��� ������� ��� ������ �� �������*/

SELECT NAME
FROM CUSTOMERS C JOIN COUNTRIES CO
ON C.COUNTRY_ID = CO.COUNTRY_ID
UNION
SELECT C.NAME
FROM DEPARTMENTS D JOIN COUNTRIES C
ON C.COUNTRY_ID = D.COUNTRY_ID
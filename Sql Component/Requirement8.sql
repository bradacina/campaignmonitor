
--Return the name of the salesperson with
--the 3rd highest salary.

select top 1 Name from 
(
	-- sort by salary and attach rownumber
	select s.Name, ROW_NUMBER() over (order by s.Salary desc) as rownum
	from Salesperson as s) as a
where rownum > 2

-- OR

select s.Name from Salesperson as s
order by s.Salary desc
offset 2 rows 
fetch next 1 rows only




--Create a new roll-up table BigOrders(where
--columns are CustomerID,
--TotalOrderValue), and insert into that table
--customers whose total Amount across all
--orders is greater than 1000

select CustomerId, TotalOrderValue 
into BigOrders
from
(
	-- aggregate sales per customer
	select 
		o.CustomerID,
		SUM(o.NumberOfUnits * o.CostOfUnit) as TotalOrderValue
	from Orders as o
	group by o.CustomerId
) as a
where TotalOrderValue > 1000




--Return the total Amount of orders for each
--month, ordered by year, then month (both
--in descending order)

select 
	SUM(o.NumberOfUnits * o.CostOfUnit) as MonthlySales,
	YEAR(o.OrderDate) as Year,
	MONTH(o.OrderDate) as Month
from Orders as o
group by MONTH(o.OrderDate), YEAR(o.OrderDate)
order by Year desc, Month desc

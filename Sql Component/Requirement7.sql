
--Return the names of all salespeople that
--have an order with George

select distinct s.Name from Orders as o
join Customer as c on c.CustomerId = o.CustomerID
join Salesperson as s on s.SalespersonID = o.SalespersonID
where c.Name = 'George'


--Return the names of all salespeople that do
--not have any order with George

select distinct s.Name from Salesperson as s
where s.SalespersonID not in 
(
	-- salespeople that DO have an order with George
	select o.SalespersonID from Orders as o
	join Customer as c on o.CustomerId = c.CustomerId
	where c.Name = 'George'
)


-- Return the names of salespeople that have
-- 2 or more orders
select o.Name from 
(
	-- aggregate number of orders
	select SalespersonID, COUNT(SalespersonID) as NumberOfOrders from Orders as o
	group by SalespersonID 
) as a
left join SalesPerson as o on o.SalespersonID = a.SalespersonID
where NumberOfOrders >= 2

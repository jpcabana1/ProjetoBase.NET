create procedure spOrdemCompleta @Id varchar(50)
as
if(TRIM(@Id) = '')
	begin
		select 
		*
		from 
		Orders as O
		left join
		[Order Details] as OD
			on O.OrderID = OD.OrderID
		left join
		Products as P
			on P.ProductID = OD.ProductID
	end
else
	begin
		select 
		*
		from 
		Orders as O
		left join
		[Order Details] as OD
			on O.OrderID = OD.OrderID
		left join
		Products as P
			on P.ProductID = OD.ProductID
			where O.OrderID = @ID
	end

	spOrdemCompleta ''
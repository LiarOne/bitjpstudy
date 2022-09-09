select u.user_id as buyer_id,u.join_date as join_date,
(select count(*) from Orders where u.user_id = Orders.buyer_id and order_date between '2019-01-01' and '2019-12-31') as orders_in_2019
from Users as u;
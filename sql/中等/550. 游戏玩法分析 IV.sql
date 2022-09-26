select (count(distinct player_id)/(select count(distinct player_id) from activity)) as fraction
from activity 
where (player_id, event_date) in
(
    select player_id, date(min(event_date) + 1)
    from activity
    group by player_id
)



select 
	ifnull(
	round(
        count(distinct player_id)/ 
    	(select count(distinct player_id) from activity)
    ,2)
    ,0) as fraction
from activity 
where (player_id, event_date) in
(
    select player_id, date(min(event_date) + 1)
    from activity
    group by player_id

)

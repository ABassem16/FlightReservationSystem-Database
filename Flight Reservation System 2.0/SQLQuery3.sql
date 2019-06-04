select p.P_id,f.Flight_id
from passenger p,Flight f, reserves r
where p.P_id=r.P_id
and f.Flight_id=r.Flight_id
select *
from admin
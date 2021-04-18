with tablex as 
(select employee_id,  
row_number() over( order by max(salary)) as row_id, 
max(salary) 
from employee 
group by employee_id) 
select * from tablex where row_id=3;
update Employees
set location = case when location ='Chennai' then 'Bangalore'
                    else 
                        case when location='Bangalore' then 'Chennai'
                        else location
                        end
                    end 
where 1>2



select row_number(), emp.Name, emp.sal from Employees emp
order by sal 
having row_number


select * 
into Employees2
from Employees
where 1>2

select emp.Name, emp.Address from Employees emp 
inner join address add on add.employee_key = emp.key 


                
emp.key emp.Address
select first_name from customer union all select first_name from actor order by first_name;
select first_name from customer intersect select first_name from actor order by first_name;
select first_name from customer except select first_name from actor order by first_name;

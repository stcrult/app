select country, city from country inner join city on country.country_id = city.country_id order by countr, city;
select first_name, last_name, amount from customer inner join payment on customer.customer_id = payment.customer_id;
select first_name, last_name, rental_date from customer inner join rental on customer.customer_id = rental.customer_id order by rental_date desc;

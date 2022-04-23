select city, country from city left join country on city.country_id = country.country_id order by country;
select first_name, last_name, amount from customer right join payment on customer.customer_id = payment.customer_id;
select first_name, last_name, rental_date from customer full join rental on customer.customer_id = rental.customer_id;
